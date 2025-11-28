using System.Text.Json;
using VRChat.API.Realtime.Models;
using VRChat.API.Realtime.Messages;
using System;

namespace VRChat.API.Realtime
{
    public partial class VRChatRealtimeClient
    {
        private static readonly JsonSerializerOptions JsonOptions = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        };

        private void ProcessMessage(string messageType, string json)
        {
            object parsedContent = null;
            string rawContent = null;

            try
            {
                var result = messageType switch
                {
                    // Notification Events
                    "notification" => ProcessNotification(json),
                    "response-notification" => ProcessResponseNotification(json),
                    "see-notification" => ProcessSeeNotification(json),
                    "hide-notification" => ProcessHideNotification(json),
                    "clear-notification" => ProcessClearNotification(),
                    "notification-v2" => ProcessNotificationV2(json),
                    "notification-v2-update" => ProcessNotificationV2Update(json),
                    "notification-v2-delete" => ProcessNotificationV2Delete(json),

                    // Friend Events
                    "friend-add" => ProcessFriendAdd(json),
                    "friend-delete" => ProcessFriendDelete(json),
                    "friend-online" => ProcessFriendOnline(json),
                    "friend-active" => ProcessFriendActive(json),
                    "friend-offline" => ProcessFriendOffline(json),
                    "friend-update" => ProcessFriendUpdate(json),
                    "friend-location" => ProcessFriendLocation(json),

                    // User Events
                    "user-update" => ProcessUserUpdate(json),
                    "user-location" => ProcessUserLocation(json),
                    "user-badge-assigned" => ProcessUserBadgeAssigned(json),
                    "user-badge-unassigned" => ProcessUserBadgeUnassigned(json),
                    "content-refresh" => ProcessContentRefresh(json),
                    "modified-image-update" => ProcessModifiedImageUpdate(json),
                    "instance-queue-joined" => ProcessInstanceQueueJoined(json),
                    "instance-queue-ready" => ProcessInstanceQueueReady(json),

                    // Group Events
                    "group-joined" => ProcessGroupJoined(json),
                    "group-left" => ProcessGroupLeft(json),
                    "group-member-updated" => ProcessGroupMemberUpdated(json),
                    "group-role-updated" => ProcessGroupRoleUpdated(json),

                    // Unknown
                    _ => LogUnknownMessage(messageType)
                };

                if (result is (object content, string raw))
                {
                    parsedContent = content;
                    rawContent = raw;
                }
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
                    RawMessage = json,
                    RawContent = rawContent,
                    Type = messageType
                });
            }
        }

        private (object, string) LogUnknownMessage(string messageType)
        {
            LogMessage(LogLevel.Debug, $"Unknown message type: {messageType}");
            return (null, null);
        }

        private (object, string) ProcessClearNotification()
        {
            OnClearNotification?.Invoke(this, EventArgs.Empty);
            return (null, null);
        }

        #region Notification Event Processors

        private (object, string) ProcessNotification(string json)
        {
            // Double-encoded: content is a stringified JSON object
            var message = JsonSerializer.Deserialize<WebSocketMessageString>(json, JsonOptions);
            var content = JsonSerializer.Deserialize<Notification>(message.Content, JsonOptions);

            var args = new NotificationEventArgs { Notification = content };
            OnNotification?.Invoke(this, args); // Legacy event

            OnNotificationReceived?.Invoke(this, new VRChatEventArgs<Notification>
            {
                Message = content,
                RawMessage = json,
                RawContent = message.Content,
                Type = message.Type
            });

            return (content, message.Content);
        }

        private (object, string) ProcessResponseNotification(string json)
        {
            // Double-encoded: content is a stringified JSON object
            var message = JsonSerializer.Deserialize<WebSocketMessageString>(json, JsonOptions);
            var content = JsonSerializer.Deserialize<ResponseNotificationContent>(message.Content, JsonOptions);

            OnResponseNotification?.Invoke(this, new VRChatEventArgs<ResponseNotificationContent>
            {
                Message = content,
                RawMessage = json,
                RawContent = message.Content,
                Type = message.Type
            });

            return (content, message.Content);
        }

        private (object, string) ProcessSeeNotification(string json)
        {
            // NOT double-encoded: content is just the notification ID string
            var message = JsonSerializer.Deserialize<WebSocketMessage<string>>(json, JsonOptions);

            OnSeeNotification?.Invoke(this, new VRChatEventArgs<string>
            {
                Message = message.Content,
                RawMessage = json,
                RawContent = message.Content,
                Type = message.Type
            });

            return (message.Content, message.Content);
        }

        private (object, string) ProcessHideNotification(string json)
        {
            // NOT double-encoded: content is just the notification ID string
            var message = JsonSerializer.Deserialize<WebSocketMessage<string>>(json, JsonOptions);

            OnHideNotification?.Invoke(this, new VRChatEventArgs<string>
            {
                Message = message.Content,
                RawMessage = json,
                RawContent = message.Content,
                Type = message.Type
            });

            return (message.Content, message.Content);
        }

        private (object, string) ProcessNotificationV2(string json)
        {
            // Double-encoded: content is a stringified JSON object
            var message = JsonSerializer.Deserialize<WebSocketMessageString>(json, JsonOptions);
            var content = JsonSerializer.Deserialize<NotificationV2Content>(message.Content, JsonOptions);

            OnNotificationV2?.Invoke(this, new VRChatEventArgs<NotificationV2Content>
            {
                Message = content,
                RawMessage = json,
                RawContent = message.Content,
                Type = message.Type
            });

            return (content, message.Content);
        }

        private (object, string) ProcessNotificationV2Update(string json)
        {
            // Double-encoded: content is a stringified JSON object
            var message = JsonSerializer.Deserialize<WebSocketMessageString>(json, JsonOptions);
            var content = JsonSerializer.Deserialize<NotificationV2UpdateContent>(message.Content, JsonOptions);

            OnNotificationV2Update?.Invoke(this, new VRChatEventArgs<NotificationV2UpdateContent>
            {
                Message = content,
                RawMessage = json,
                RawContent = message.Content,
                Type = message.Type
            });

            return (content, message.Content);
        }

        private (object, string) ProcessNotificationV2Delete(string json)
        {
            // Double-encoded: content is a stringified JSON object
            var message = JsonSerializer.Deserialize<WebSocketMessageString>(json, JsonOptions);
            var content = JsonSerializer.Deserialize<NotificationV2DeleteContent>(message.Content, JsonOptions);

            OnNotificationV2Delete?.Invoke(this, new VRChatEventArgs<NotificationV2DeleteContent>
            {
                Message = content,
                RawMessage = json,
                RawContent = message.Content,
                Type = message.Type
            });

            return (content, message.Content);
        }

        #endregion

        #region Friend Event Processors

        private (object, string) ProcessFriendAdd(string json)
        {
            // Double-encoded: content is a stringified JSON object
            var message = JsonSerializer.Deserialize<WebSocketMessageString>(json, JsonOptions);
            var content = JsonSerializer.Deserialize<FriendAddContent>(message.Content, JsonOptions);

            OnFriendAdd?.Invoke(this, new VRChatEventArgs<FriendAddContent>
            {
                Message = content,
                RawMessage = json,
                RawContent = message.Content,
                Type = message.Type
            });

            return (content, message.Content);
        }

        private (object, string) ProcessFriendDelete(string json)
        {
            // Double-encoded: content is a stringified JSON object
            var message = JsonSerializer.Deserialize<WebSocketMessageString>(json, JsonOptions);
            var content = JsonSerializer.Deserialize<FriendDeleteContent>(message.Content, JsonOptions);

            OnFriendDelete?.Invoke(this, new VRChatEventArgs<FriendDeleteContent>
            {
                Message = content,
                RawMessage = json,
                RawContent = message.Content,
                Type = message.Type
            });

            return (content, message.Content);
        }

        private (object, string) ProcessFriendOnline(string json)
        {
            // Double-encoded: content is a stringified JSON object
            var message = JsonSerializer.Deserialize<WebSocketMessageString>(json, JsonOptions);
            var content = JsonSerializer.Deserialize<FriendOnlineContent>(message.Content, JsonOptions);

            OnFriendOnline?.Invoke(this, new VRChatEventArgs<FriendOnlineContent>
            {
                Message = content,
                RawMessage = json,
                RawContent = message.Content,
                Type = message.Type
            });

            return (content, message.Content);
        }

        private (object, string) ProcessFriendActive(string json)
        {
            // Double-encoded: content is a stringified JSON object
            var message = JsonSerializer.Deserialize<WebSocketMessageString>(json, JsonOptions);
            var content = JsonSerializer.Deserialize<FriendActiveContent>(message.Content, JsonOptions);

            OnFriendActive?.Invoke(this, new VRChatEventArgs<FriendActiveContent>
            {
                Message = content,
                RawMessage = json,
                RawContent = message.Content,
                Type = message.Type
            });

            return (content, message.Content);
        }

        private (object, string) ProcessFriendOffline(string json)
        {
            // Double-encoded: content is a stringified JSON object
            var message = JsonSerializer.Deserialize<WebSocketMessageString>(json, JsonOptions);
            var content = JsonSerializer.Deserialize<FriendOfflineContent>(message.Content, JsonOptions);

            OnFriendOffline?.Invoke(this, new VRChatEventArgs<FriendOfflineContent>
            {
                Message = content,
                RawMessage = json,
                RawContent = message.Content,
                Type = message.Type
            });

            return (content, message.Content);
        }

        private (object, string) ProcessFriendUpdate(string json)
        {
            // Double-encoded: content is a stringified JSON object
            var message = JsonSerializer.Deserialize<WebSocketMessageString>(json, JsonOptions);
            var content = JsonSerializer.Deserialize<FriendUpdateContent>(message.Content, JsonOptions);

            OnFriendUpdate?.Invoke(this, new VRChatEventArgs<FriendUpdateContent>
            {
                Message = content,
                RawMessage = json,
                RawContent = message.Content,
                Type = message.Type
            });

            return (content, message.Content);
        }

        private (object, string) ProcessFriendLocation(string json)
        {
            // Double-encoded: content is a stringified JSON object
            var message = JsonSerializer.Deserialize<WebSocketMessageString>(json, JsonOptions);
            var content = JsonSerializer.Deserialize<FriendLocationContent>(message.Content, JsonOptions);

            OnFriendLocation?.Invoke(this, new VRChatEventArgs<FriendLocationContent>
            {
                Message = content,
                RawMessage = json,
                RawContent = message.Content,
                Type = message.Type
            });

            return (content, message.Content);
        }

        #endregion

        #region User Event Processors

        private (object, string) ProcessUserUpdate(string json)
        {
            // Double-encoded: content is a stringified JSON object
            var message = JsonSerializer.Deserialize<WebSocketMessageString>(json, JsonOptions);
            var content = JsonSerializer.Deserialize<UserUpdateContent>(message.Content, JsonOptions);

            OnUserUpdate?.Invoke(this, new VRChatEventArgs<UserUpdateContent>
            {
                Message = content,
                RawMessage = json,
                RawContent = message.Content,
                Type = message.Type
            });

            return (content, message.Content);
        }

        private (object, string) ProcessUserLocation(string json)
        {
            // Double-encoded: content is a stringified JSON object
            var message = JsonSerializer.Deserialize<WebSocketMessageString>(json, JsonOptions);
            var content = JsonSerializer.Deserialize<UserLocationContent>(message.Content, JsonOptions);

            OnUserLocation?.Invoke(this, new VRChatEventArgs<UserLocationContent>
            {
                Message = content,
                RawMessage = json,
                RawContent = message.Content,
                Type = message.Type
            });

            return (content, message.Content);
        }

        private (object, string) ProcessUserBadgeAssigned(string json)
        {
            // Double-encoded: content is a stringified JSON object
            var message = JsonSerializer.Deserialize<WebSocketMessageString>(json, JsonOptions);
            var content = JsonSerializer.Deserialize<UserBadgeAssignedContent>(message.Content, JsonOptions);

            OnUserBadgeAssigned?.Invoke(this, new VRChatEventArgs<UserBadgeAssignedContent>
            {
                Message = content,
                RawMessage = json,
                RawContent = message.Content,
                Type = message.Type
            });

            return (content, message.Content);
        }

        private (object, string) ProcessUserBadgeUnassigned(string json)
        {
            // Double-encoded: content is a stringified JSON object
            var message = JsonSerializer.Deserialize<WebSocketMessageString>(json, JsonOptions);
            var content = JsonSerializer.Deserialize<UserBadgeUnassignedContent>(message.Content, JsonOptions);

            OnUserBadgeUnassigned?.Invoke(this, new VRChatEventArgs<UserBadgeUnassignedContent>
            {
                Message = content,
                RawMessage = json,
                RawContent = message.Content,
                Type = message.Type
            });

            return (content, message.Content);
        }

        private (object, string) ProcessContentRefresh(string json)
        {
            // Double-encoded: content is a stringified JSON object
            var message = JsonSerializer.Deserialize<WebSocketMessageString>(json, JsonOptions);
            var content = JsonSerializer.Deserialize<ContentRefreshContent>(message.Content, JsonOptions);

            OnContentRefresh?.Invoke(this, new VRChatEventArgs<ContentRefreshContent>
            {
                Message = content,
                RawMessage = json,
                RawContent = message.Content,
                Type = message.Type
            });

            return (content, message.Content);
        }

        private (object, string) ProcessModifiedImageUpdate(string json)
        {
            // Double-encoded: content is a stringified JSON object
            var message = JsonSerializer.Deserialize<WebSocketMessageString>(json, JsonOptions);
            var content = JsonSerializer.Deserialize<ModifiedImageUpdateContent>(message.Content, JsonOptions);

            OnModifiedImageUpdate?.Invoke(this, new VRChatEventArgs<ModifiedImageUpdateContent>
            {
                Message = content,
                RawMessage = json,
                RawContent = message.Content,
                Type = message.Type
            });

            return (content, message.Content);
        }

        private (object, string) ProcessInstanceQueueJoined(string json)
        {
            // Double-encoded: content is a stringified JSON object
            var message = JsonSerializer.Deserialize<WebSocketMessageString>(json, JsonOptions);
            var content = JsonSerializer.Deserialize<InstanceQueueJoinedContent>(message.Content, JsonOptions);

            OnInstanceQueueJoined?.Invoke(this, new VRChatEventArgs<InstanceQueueJoinedContent>
            {
                Message = content,
                RawMessage = json,
                RawContent = message.Content,
                Type = message.Type
            });

            return (content, message.Content);
        }

        private (object, string) ProcessInstanceQueueReady(string json)
        {
            // Double-encoded: content is a stringified JSON object
            var message = JsonSerializer.Deserialize<WebSocketMessageString>(json, JsonOptions);
            var content = JsonSerializer.Deserialize<InstanceQueueReadyContent>(message.Content, JsonOptions);

            OnInstanceQueueReady?.Invoke(this, new VRChatEventArgs<InstanceQueueReadyContent>
            {
                Message = content,
                RawMessage = json,
                RawContent = message.Content,
                Type = message.Type
            });

            return (content, message.Content);
        }

        #endregion

        #region Group Event Processors

        private (object, string) ProcessGroupJoined(string json)
        {
            // Double-encoded: content is a stringified JSON object
            var message = JsonSerializer.Deserialize<WebSocketMessageString>(json, JsonOptions);
            var content = JsonSerializer.Deserialize<GroupJoinedContent>(message.Content, JsonOptions);

            OnGroupJoined?.Invoke(this, new VRChatEventArgs<GroupJoinedContent>
            {
                Message = content,
                RawMessage = json,
                RawContent = message.Content,
                Type = message.Type
            });

            return (content, message.Content);
        }

        private (object, string) ProcessGroupLeft(string json)
        {
            // Double-encoded: content is a stringified JSON object
            var message = JsonSerializer.Deserialize<WebSocketMessageString>(json, JsonOptions);
            var content = JsonSerializer.Deserialize<GroupLeftContent>(message.Content, JsonOptions);

            OnGroupLeft?.Invoke(this, new VRChatEventArgs<GroupLeftContent>
            {
                Message = content,
                RawMessage = json,
                RawContent = message.Content,
                Type = message.Type
            });

            return (content, message.Content);
        }

        private (object, string) ProcessGroupMemberUpdated(string json)
        {
            // Double-encoded: content is a stringified JSON object
            var message = JsonSerializer.Deserialize<WebSocketMessageString>(json, JsonOptions);
            var content = JsonSerializer.Deserialize<GroupMemberUpdatedContent>(message.Content, JsonOptions);

            OnGroupMemberUpdated?.Invoke(this, new VRChatEventArgs<GroupMemberUpdatedContent>
            {
                Message = content,
                RawMessage = json,
                RawContent = message.Content,
                Type = message.Type
            });

            return (content, message.Content);
        }

        private (object, string) ProcessGroupRoleUpdated(string json)
        {
            // Double-encoded: content is a stringified JSON object
            var message = JsonSerializer.Deserialize<WebSocketMessageString>(json, JsonOptions);
            var content = JsonSerializer.Deserialize<GroupRoleUpdatedContent>(message.Content, JsonOptions);

            OnGroupRoleUpdated?.Invoke(this, new VRChatEventArgs<GroupRoleUpdatedContent>
            {
                Message = content,
                RawMessage = json,
                RawContent = message.Content,
                Type = message.Type
            });

            return (content, message.Content);
        }

        #endregion
    }
}

