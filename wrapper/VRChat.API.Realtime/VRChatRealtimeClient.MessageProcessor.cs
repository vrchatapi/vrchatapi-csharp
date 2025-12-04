using System.Text.Json;
using VRChat.API.Realtime.Models;
using VRChat.API.Realtime.Messages;
using System;

namespace VRChat.API.Realtime
{
    public partial class VRChatRealtimeClient
    {
        /// <summary>
        /// JSON serialization options used for deserializing WebSocket message content.
        /// </summary>
        private static readonly JsonSerializerOptions JsonOptions = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        };

        /// <summary>
        /// Routes and processes an incoming WebSocket message based on its type.
        /// </summary>
        /// <param name="messageType">The message type identifier from VRChat.</param>
        /// <param name="rawJson">The complete raw JSON message string.</param>
        /// <param name="rawContent">The extracted content field as a JSON string.</param>
        private void ProcessMessage(string messageType, string rawJson, string rawContent)
        {
            object parsedContent = null;

            try
            {
                var result = messageType switch
                {
                    // Notification Events
                    "notification" => ProcessContent<Notification>(messageType, rawJson, rawContent, OnNotification),
                    "response-notification" => ProcessContent<ResponseNotificationContent>(messageType, rawJson, rawContent, OnResponseNotification),
                    "see-notification" => ProcessStringContent(messageType, rawJson, rawContent, OnSeeNotification),
                    "hide-notification" => ProcessStringContent(messageType, rawJson, rawContent, OnHideNotification),
                    "clear-notification" => ProcessClearNotification(),
                    "notification-v2" => ProcessContent<NotificationV2Content>(messageType, rawJson, rawContent, OnNotificationV2),
                    "notification-v2-update" => ProcessContent<NotificationV2UpdateContent>(messageType, rawJson, rawContent, OnNotificationV2Update),
                    "notification-v2-delete" => ProcessContent<NotificationV2DeleteContent>(messageType, rawJson, rawContent, OnNotificationV2Delete),

                    // Friend Events
                    "friend-add" => ProcessContent<FriendAddContent>(messageType, rawJson, rawContent, OnFriendAdd),
                    "friend-delete" => ProcessContent<FriendDeleteContent>(messageType, rawJson, rawContent, OnFriendDelete),
                    "friend-online" => ProcessContent<FriendOnlineContent>(messageType, rawJson, rawContent, OnFriendOnline),
                    "friend-active" => ProcessContent<FriendActiveContent>(messageType, rawJson, rawContent, OnFriendActive),
                    "friend-offline" => ProcessContent<FriendOfflineContent>(messageType, rawJson, rawContent, OnFriendOffline),
                    "friend-update" => ProcessContent<FriendUpdateContent>(messageType, rawJson, rawContent, OnFriendUpdate),
                    "friend-location" => ProcessContent<FriendLocationContent>(messageType, rawJson, rawContent, OnFriendLocation),

                    // User Events
                    "user-update" => ProcessContent<UserUpdateContent>(messageType, rawJson, rawContent, OnUserUpdate),
                    "user-location" => ProcessContent<UserLocationContent>(messageType, rawJson, rawContent, OnUserLocation),
                    "user-badge-assigned" => ProcessContent<UserBadgeAssignedContent>(messageType, rawJson, rawContent, OnUserBadgeAssigned),
                    "user-badge-unassigned" => ProcessContent<UserBadgeUnassignedContent>(messageType, rawJson, rawContent, OnUserBadgeUnassigned),
                    "content-refresh" => ProcessContent<ContentRefreshContent>(messageType, rawJson, rawContent, OnContentRefresh),
                    "modified-image-update" => ProcessContent<ModifiedImageUpdateContent>(messageType, rawJson, rawContent, OnModifiedImageUpdate),
                    "instance-queue-joined" => ProcessContent<InstanceQueueJoinedContent>(messageType, rawJson, rawContent, OnInstanceQueueJoined),
                    "instance-queue-ready" => ProcessContent<InstanceQueueReadyContent>(messageType, rawJson, rawContent, OnInstanceQueueReady),

                    // Group Events
                    "group-joined" => ProcessContent<GroupJoinedContent>(messageType, rawJson, rawContent, OnGroupJoined),
                    "group-left" => ProcessContent<GroupLeftContent>(messageType, rawJson, rawContent, OnGroupLeft),
                    "group-member-updated" => ProcessContent<GroupMemberUpdatedContent>(messageType, rawJson, rawContent, OnGroupMemberUpdated),
                    "group-role-updated" => ProcessContent<GroupRoleUpdatedContent>(messageType, rawJson, rawContent, OnGroupRoleUpdated),

                    // Unknown
                    _ => LogUnknownMessage(messageType)
                };

                parsedContent = result;
            }
            catch (Exception ex)
            {
                LogMessage(LogLevel.Error, $"Error processing {messageType} message: {ex.Message}", ex);
            }

            // Fire generic OnEvent with parsed content
            if (parsedContent != null)
            {
                OnEvent?.Invoke(this, new VRChatEventArgs<object>
                {
                    Message = parsedContent,
                    RawMessage = rawJson,
                    RawContent = rawContent,
                    Type = messageType
                });
            }
        }

        /// <summary>
        /// Deserializes and processes a typed message content, invoking the specified event handler.
        /// </summary>
        /// <typeparam name="T">The type to deserialize the content to.</typeparam>
        /// <param name="type">The message type identifier.</param>
        /// <param name="rawJson">The complete raw JSON message string.</param>
        /// <param name="rawContent">The content field JSON string to deserialize.</param>
        /// <param name="eventHandler">The event handler to invoke with the deserialized content.</param>
        /// <returns>The deserialized content object, or <c>null</c> if deserialization fails.</returns>
        private object ProcessContent<T>(string type, string rawJson, string rawContent, EventHandler<VRChatEventArgs<T>> eventHandler)
        {
            var message = WebSocketMessage<T>.FromContent(type, rawJson, rawContent, JsonOptions);

            eventHandler?.Invoke(this, new VRChatEventArgs<T>
            {
                Message = message.Content,
                RawMessage = message.RawMessage,
                RawContent = message.RawContent,
                Type = message.Type
            });

            return message.Content;
        }

        /// <summary>
        /// Processes string content that requires no JSON deserialization.
        /// </summary>
        /// <param name="type">The message type identifier.</param>
        /// <param name="rawJson">The complete raw JSON message string.</param>
        /// <param name="rawContent">The string content value.</param>
        /// <param name="eventHandler">The event handler to invoke with the string content.</param>
        /// <returns>The string content value.</returns>
        private object ProcessStringContent(string type, string rawJson, string rawContent, EventHandler<VRChatEventArgs<string>> eventHandler)
        {
            var message = WebSocketMessage<string>.FromStringContent(type, rawJson, rawContent);

            eventHandler?.Invoke(this, new VRChatEventArgs<string>
            {
                Message = message.Content,
                RawMessage = message.RawMessage,
                RawContent = message.RawContent,
                Type = message.Type
            });

            return message.Content;
        }

        /// <summary>
        /// Logs an unknown message type for debugging purposes.
        /// </summary>
        /// <param name="messageType">The unrecognized message type identifier.</param>
        /// <returns><c>null</c> as no content is processed.</returns>
        private object LogUnknownMessage(string messageType)
        {
            LogMessage(LogLevel.Debug, $"Unknown message type: {messageType}");
            return null;
        }

        /// <summary>
        /// Processes the clear-notification event which has no content payload.
        /// </summary>
        /// <returns><c>null</c> as no content is associated with this event.</returns>
        private object ProcessClearNotification()
        {
            OnClearNotification?.Invoke(this, EventArgs.Empty);
            return null;
        }
    }
}
