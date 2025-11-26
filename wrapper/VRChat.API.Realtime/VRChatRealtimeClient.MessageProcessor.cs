using System;
using System.Text.Json;
using VRChat.API.Model;
using VRChat.API.Realtime.Models;
using VRChat.API.Realtime.Messages;

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
            try
            {
                switch (messageType)
                {
                    // Notification Events
                    case "notification":
                        ProcessNotification(json);
                        break;

                    case "response-notification":
                        ProcessResponseNotification(json);
                        break;

                    case "see-notification":
                        ProcessSeeNotification(json);
                        break;

                    case "hide-notification":
                        ProcessHideNotification(json);
                        break;

                    case "clear-notification":
                        OnClearNotification?.Invoke(this, EventArgs.Empty);
                        break;

                    case "notification-v2":
                        ProcessNotificationV2(json);
                        break;

                    case "notification-v2-update":
                        ProcessNotificationV2Update(json);
                        break;

                    case "notification-v2-delete":
                        ProcessNotificationV2Delete(json);
                        break;

                    // Friend Events
                    case "friend-add":
                        ProcessFriendAdd(json);
                        break;

                    case "friend-delete":
                        ProcessFriendDelete(json);
                        break;

                    case "friend-online":
                        ProcessFriendOnline(json);
                        break;

                    case "friend-active":
                        ProcessFriendActive(json);
                        break;

                    case "friend-offline":
                        ProcessFriendOffline(json);
                        break;

                    case "friend-update":
                        ProcessFriendUpdate(json);
                        break;

                    case "friend-location":
                        ProcessFriendLocation(json);
                        break;

                    // User Events
                    case "user-update":
                        ProcessUserUpdate(json);
                        break;

                    case "user-location":
                        ProcessUserLocation(json);
                        break;

                    case "user-badge-assigned":
                        ProcessUserBadgeAssigned(json);
                        break;

                    case "user-badge-unassigned":
                        ProcessUserBadgeUnassigned(json);
                        break;

                    case "content-refresh":
                        ProcessContentRefresh(json);
                        break;

                    case "modified-image-update":
                        ProcessModifiedImageUpdate(json);
                        break;

                    case "instance-queue-joined":
                        ProcessInstanceQueueJoined(json);
                        break;

                    case "instance-queue-ready":
                        ProcessInstanceQueueReady(json);
                        break;

                    // Group Events
                    case "group-joined":
                        ProcessGroupJoined(json);
                        break;

                    case "group-left":
                        ProcessGroupLeft(json);
                        break;

                    case "group-member-updated":
                        ProcessGroupMemberUpdated(json);
                        break;

                    case "group-role-updated":
                        ProcessGroupRoleUpdated(json);
                        break;

                    default:
                        LogMessage(LogLevel.Debug, $"Unknown message type: {messageType}");
                        break;
                }
            }
            catch (Exception ex)
            {
                LogMessage(LogLevel.Error, $"Error processing {messageType} message: {ex.Message}", ex);
            }
        }

        #region Notification Event Processors

        private void ProcessNotification(string json)
        {
            var message = JsonSerializer.Deserialize<WebSocketMessage<Notification>>(json, JsonOptions);
            var args = new NotificationEventArgs { Notification = message.Content };
            
            OnNotificationReceived?.Invoke(this, args);
            OnNotification?.Invoke(this, args); // Legacy event
        }

        private void ProcessResponseNotification(string json)
        {
            var message = JsonSerializer.Deserialize<WebSocketMessage<ResponseNotificationContent>>(json, JsonOptions);
            OnResponseNotification?.Invoke(this, message.Content);
        }

        private void ProcessSeeNotification(string json)
        {
            var message = JsonSerializer.Deserialize<WebSocketMessage<string>>(json, JsonOptions);
            OnSeeNotification?.Invoke(this, new SeeNotificationEventArgs { NotificationId = message.Content });
        }

        private void ProcessHideNotification(string json)
        {
            var message = JsonSerializer.Deserialize<WebSocketMessage<string>>(json, JsonOptions);
            OnHideNotification?.Invoke(this, new HideNotificationEventArgs { NotificationId = message.Content });
        }

        private void ProcessNotificationV2(string json)
        {
            var message = JsonSerializer.Deserialize<WebSocketMessage<NotificationV2Content>>(json, JsonOptions);
            OnNotificationV2?.Invoke(this, message.Content);
        }

        private void ProcessNotificationV2Update(string json)
        {
            var message = JsonSerializer.Deserialize<WebSocketMessage<NotificationV2UpdateContent>>(json, JsonOptions);
            OnNotificationV2Update?.Invoke(this, message.Content);
        }

        private void ProcessNotificationV2Delete(string json)
        {
            var message = JsonSerializer.Deserialize<WebSocketMessage<NotificationV2DeleteContent>>(json, JsonOptions);
            OnNotificationV2Delete?.Invoke(this, message.Content);
        }

        #endregion

        #region Friend Event Processors

        private void ProcessFriendAdd(string json)
        {
            var message = JsonSerializer.Deserialize<WebSocketMessage<FriendAddContent>>(json, JsonOptions);
            OnFriendAdd?.Invoke(this, message.Content);
        }

        private void ProcessFriendDelete(string json)
        {
            var message = JsonSerializer.Deserialize<WebSocketMessage<FriendDeleteContent>>(json, JsonOptions);
            OnFriendDelete?.Invoke(this, message.Content);
        }

        private void ProcessFriendOnline(string json)
        {
            var message = JsonSerializer.Deserialize<WebSocketMessage<FriendOnlineContent>>(json, JsonOptions);
            OnFriendOnline?.Invoke(this, message.Content);
        }

        private void ProcessFriendActive(string json)
        {
            var message = JsonSerializer.Deserialize<WebSocketMessage<FriendActiveContent>>(json, JsonOptions);
            OnFriendActive?.Invoke(this, message.Content);
        }

        private void ProcessFriendOffline(string json)
        {
            var message = JsonSerializer.Deserialize<WebSocketMessage<FriendOfflineContent>>(json, JsonOptions);
            OnFriendOffline?.Invoke(this, message.Content);
        }

        private void ProcessFriendUpdate(string json)
        {
            var message = JsonSerializer.Deserialize<WebSocketMessage<FriendUpdateContent>>(json, JsonOptions);
            OnFriendUpdate?.Invoke(this, message.Content);
        }

        private void ProcessFriendLocation(string json)
        {
            var message = JsonSerializer.Deserialize<WebSocketMessage<FriendLocationContent>>(json, JsonOptions);
            OnFriendLocation?.Invoke(this, message.Content);
        }

        #endregion

        #region User Event Processors

        private void ProcessUserUpdate(string json)
        {
            var message = JsonSerializer.Deserialize<WebSocketMessage<UserUpdateContent>>(json, JsonOptions);
            OnUserUpdate?.Invoke(this, message.Content);
        }

        private void ProcessUserLocation(string json)
        {
            var message = JsonSerializer.Deserialize<WebSocketMessage<UserLocationContent>>(json, JsonOptions);
            OnUserLocation?.Invoke(this, message.Content);
        }

        private void ProcessUserBadgeAssigned(string json)
        {
            var message = JsonSerializer.Deserialize<WebSocketMessage<UserBadgeAssignedContent>>(json, JsonOptions);
            OnUserBadgeAssigned?.Invoke(this, message.Content);
        }

        private void ProcessUserBadgeUnassigned(string json)
        {
            var message = JsonSerializer.Deserialize<WebSocketMessage<UserBadgeUnassignedContent>>(json, JsonOptions);
            OnUserBadgeUnassigned?.Invoke(this, message.Content);
        }

        private void ProcessContentRefresh(string json)
        {
            var message = JsonSerializer.Deserialize<WebSocketMessage<ContentRefreshContent>>(json, JsonOptions);
            OnContentRefresh?.Invoke(this, message.Content);
        }

        private void ProcessModifiedImageUpdate(string json)
        {
            var message = JsonSerializer.Deserialize<WebSocketMessage<ModifiedImageUpdateContent>>(json, JsonOptions);
            OnModifiedImageUpdate?.Invoke(this, message.Content);
        }

        private void ProcessInstanceQueueJoined(string json)
        {
            var message = JsonSerializer.Deserialize<WebSocketMessage<InstanceQueueJoinedContent>>(json, JsonOptions);
            OnInstanceQueueJoined?.Invoke(this, message.Content);
        }

        private void ProcessInstanceQueueReady(string json)
        {
            var message = JsonSerializer.Deserialize<WebSocketMessage<InstanceQueueReadyContent>>(json, JsonOptions);
            OnInstanceQueueReady?.Invoke(this, message.Content);
        }

        #endregion

        #region Group Event Processors

        private void ProcessGroupJoined(string json)
        {
            var message = JsonSerializer.Deserialize<WebSocketMessage<GroupJoinedContent>>(json, JsonOptions);
            OnGroupJoined?.Invoke(this, message.Content);
        }

        private void ProcessGroupLeft(string json)
        {
            var message = JsonSerializer.Deserialize<WebSocketMessage<GroupLeftContent>>(json, JsonOptions);
            OnGroupLeft?.Invoke(this, message.Content);
        }

        private void ProcessGroupMemberUpdated(string json)
        {
            var message = JsonSerializer.Deserialize<WebSocketMessage<GroupMemberUpdatedContent>>(json, JsonOptions);
            OnGroupMemberUpdated?.Invoke(this, message.Content);
        }

        private void ProcessGroupRoleUpdated(string json)
        {
            var message = JsonSerializer.Deserialize<WebSocketMessage<GroupRoleUpdatedContent>>(json, JsonOptions);
            OnGroupRoleUpdated?.Invoke(this, message.Content);
        }

        #endregion
    }
}

