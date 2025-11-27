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

        private void ProcessMessage(string messageType, string json, string rawContent)
        {
            object parsedContent = null;

            try
            {
                switch (messageType)
                {
                    // Notification Events
                    case "notification":
                        ProcessNotification(json, rawContent);
                        break;

                    case "response-notification":
                        ProcessResponseNotification(json, rawContent);
                        break;

                    case "see-notification":
                        ProcessSeeNotification(json, rawContent);
                        break;

                    case "hide-notification":
                        ProcessHideNotification(json, rawContent);
                        break;

                    case "clear-notification":
                        OnClearNotification?.Invoke(this, EventArgs.Empty);
                        break;

                    case "notification-v2":
                        ProcessNotificationV2(json, rawContent);
                        break;

                    case "notification-v2-update":
                        ProcessNotificationV2Update(json, rawContent);
                        break;

                    case "notification-v2-delete":
                        ProcessNotificationV2Delete(json, rawContent);
                        break;

                    // Friend Events
                    case "friend-add":
                        ProcessFriendAdd(json, rawContent);
                        break;

                    case "friend-delete":
                        ProcessFriendDelete(json, rawContent);
                        break;

                    case "friend-online":
                        ProcessFriendOnline(json, rawContent);
                        break;

                    case "friend-active":
                        ProcessFriendActive(json, rawContent);
                        break;

                    case "friend-offline":
                        ProcessFriendOffline(json, rawContent);
                        break;

                    case "friend-update":
                        ProcessFriendUpdate(json, rawContent);
                        break;

                    case "friend-location":
                        ProcessFriendLocation(json, rawContent);
                        break;

                    // User Events
                    case "user-update":
                        ProcessUserUpdate(json, rawContent);
                        break;

                    case "user-location":
                        ProcessUserLocation(json, rawContent);
                        break;

                    case "user-badge-assigned":
                        ProcessUserBadgeAssigned(json, rawContent);
                        break;

                    case "user-badge-unassigned":
                        ProcessUserBadgeUnassigned(json, rawContent);
                        break;

                    case "content-refresh":
                        ProcessContentRefresh(json, rawContent);
                        break;

                    case "modified-image-update":
                        ProcessModifiedImageUpdate(json, rawContent);
                        break;

                    case "instance-queue-joined":
                        ProcessInstanceQueueJoined(json, rawContent);
                        break;

                    case "instance-queue-ready":
                        ProcessInstanceQueueReady(json, rawContent);
                        break;

                    // Group Events
                    case "group-joined":
                        ProcessGroupJoined(json, rawContent);
                        break;

                    case "group-left":
                        ProcessGroupLeft(json, rawContent);
                        break;

                    case "group-member-updated":
                        ProcessGroupMemberUpdated(json, rawContent);
                        break;

                    case "group-role-updated":
                        ProcessGroupRoleUpdated(json, rawContent);
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

        #region Notification Event Processors

        private void ProcessNotification(string json, string rawContent)
        {
            var message = JsonSerializer.Deserialize<WebSocketMessage<Notification>>(json, JsonOptions);
            parsedContent = message.Content;

            var args = new NotificationEventArgs { Notification = message.Content };
            OnNotification?.Invoke(this, args); // Legacy event

            OnNotificationReceived?.Invoke(this, new VRChatEventArgs<Notification>
            {
                Message = message.Content,
                RawMessage = json,
                RawContent = rawContent,
                Type = message.Type
            });
        }

        private void ProcessResponseNotification(string json, string rawContent)
        {
            var message = JsonSerializer.Deserialize<WebSocketMessage<ResponseNotificationContent>>(json, JsonOptions);
            parsedContent = message.Content;

            OnResponseNotification?.Invoke(this, new VRChatEventArgs<ResponseNotificationContent>
            {
                Message = message.Content,
                RawMessage = json,
                RawContent = rawContent,
                Type = message.Type
            });
        }

        private void ProcessSeeNotification(string json, string rawContent)
        {
            var message = JsonSerializer.Deserialize<WebSocketMessage<string>>(json, JsonOptions);
            parsedContent = message.Content;

            OnSeeNotification?.Invoke(this, new VRChatEventArgs<string>
            {
                Message = message.Content,
                RawMessage = json,
                RawContent = rawContent,
                Type = message.Type
            });
        }

        private void ProcessHideNotification(string json, string rawContent)
        {
            var message = JsonSerializer.Deserialize<WebSocketMessage<string>>(json, JsonOptions);
            parsedContent = message.Content;

            OnHideNotification?.Invoke(this, new VRChatEventArgs<string>
            {
                Message = message.Content,
                RawMessage = json,
                RawContent = rawContent,
                Type = message.Type
            });
        }

        private void ProcessNotificationV2(string json, string rawContent)
        {
            var message = JsonSerializer.Deserialize<WebSocketMessage<NotificationV2Content>>(json, JsonOptions);
            parsedContent = message.Content;

            OnNotificationV2?.Invoke(this, new VRChatEventArgs<NotificationV2Content>
            {
                Message = message.Content,
                RawMessage = json,
                RawContent = rawContent,
                Type = message.Type
            });
        }

        private void ProcessNotificationV2Update(string json, string rawContent)
        {
            var message = JsonSerializer.Deserialize<WebSocketMessage<NotificationV2UpdateContent>>(json, JsonOptions);
            parsedContent = message.Content;

            OnNotificationV2Update?.Invoke(this, new VRChatEventArgs<NotificationV2UpdateContent>
            {
                Message = message.Content,
                RawMessage = json,
                RawContent = rawContent,
                Type = message.Type
            });
        }

        private void ProcessNotificationV2Delete(string json, string rawContent)
        {
            var message = JsonSerializer.Deserialize<WebSocketMessage<NotificationV2DeleteContent>>(json, JsonOptions);
            parsedContent = message.Content;

            OnNotificationV2Delete?.Invoke(this, new VRChatEventArgs<NotificationV2DeleteContent>
            {
                Message = message.Content,
                RawMessage = json,
                RawContent = rawContent,
                Type = message.Type
            });
        }

        #endregion

        #region Friend Event Processors

        private void ProcessFriendAdd(string json, string rawContent)
        {
            var message = JsonSerializer.Deserialize<WebSocketMessage<FriendAddContent>>(json, JsonOptions);
            parsedContent = message.Content;

            OnFriendAdd?.Invoke(this, new VRChatEventArgs<FriendAddContent>
            {
                Message = message.Content,
                RawMessage = json,
                RawContent = rawContent,
                Type = message.Type
            });
        }

        private void ProcessFriendDelete(string json, string rawContent)
        {
            var message = JsonSerializer.Deserialize<WebSocketMessage<FriendDeleteContent>>(json, JsonOptions);
            parsedContent = message.Content;

            OnFriendDelete?.Invoke(this, new VRChatEventArgs<FriendDeleteContent>
            {
                Message = message.Content,
                RawMessage = json,
                RawContent = rawContent,
                Type = message.Type
            });
        }

        private void ProcessFriendOnline(string json, string rawContent)
        {
            var message = JsonSerializer.Deserialize<WebSocketMessage<FriendOnlineContent>>(json, JsonOptions);
            parsedContent = message.Content;

            OnFriendOnline?.Invoke(this, new VRChatEventArgs<FriendOnlineContent>
            {
                Message = message.Content,
                RawMessage = json,
                RawContent = rawContent,
                Type = message.Type
            });
        }

        private void ProcessFriendActive(string json, string rawContent)
        {
            var message = JsonSerializer.Deserialize<WebSocketMessage<FriendActiveContent>>(json, JsonOptions);
            parsedContent = message.Content;

            OnFriendActive?.Invoke(this, new VRChatEventArgs<FriendActiveContent>
            {
                Message = message.Content,
                RawMessage = json,
                RawContent = rawContent,
                Type = message.Type
            });
        }

        private void ProcessFriendOffline(string json, string rawContent)
        {
            var message = JsonSerializer.Deserialize<WebSocketMessage<FriendOfflineContent>>(json, JsonOptions);
            parsedContent = message.Content;

            OnFriendOffline?.Invoke(this, new VRChatEventArgs<FriendOfflineContent>
            {
                Message = message.Content,
                RawMessage = json,
                RawContent = rawContent,
                Type = message.Type
            });
        }

        private void ProcessFriendUpdate(string json, string rawContent)
        {
            var message = JsonSerializer.Deserialize<WebSocketMessage<FriendUpdateContent>>(json, JsonOptions);
            parsedContent = message.Content;

            OnFriendUpdate?.Invoke(this, new VRChatEventArgs<FriendUpdateContent>
            {
                Message = message.Content,
                RawMessage = json,
                RawContent = rawContent,
                Type = message.Type
            });
        }

        private void ProcessFriendLocation(string json, string rawContent)
        {
            var message = JsonSerializer.Deserialize<WebSocketMessage<FriendLocationContent>>(json, JsonOptions);
            parsedContent = message.Content;

            OnFriendLocation?.Invoke(this, new VRChatEventArgs<FriendLocationContent>
            {
                Message = message.Content,
                RawMessage = json,
                RawContent = rawContent,
                Type = message.Type
            });
        }

        #endregion

        #region User Event Processors

        private void ProcessUserUpdate(string json, string rawContent)
        {
            var message = JsonSerializer.Deserialize<WebSocketMessage<UserUpdateContent>>(json, JsonOptions);
            parsedContent = message.Content;

            OnUserUpdate?.Invoke(this, new VRChatEventArgs<UserUpdateContent>
            {
                Message = message.Content,
                RawMessage = json,
                RawContent = rawContent,
                Type = message.Type
            });
        }

        private void ProcessUserLocation(string json, string rawContent)
        {
            var message = JsonSerializer.Deserialize<WebSocketMessage<UserLocationContent>>(json, JsonOptions);
            parsedContent = message.Content;

            OnUserLocation?.Invoke(this, new VRChatEventArgs<UserLocationContent>
            {
                Message = message.Content,
                RawMessage = json,
                RawContent = rawContent,
                Type = message.Type
            });
        }

        private void ProcessUserBadgeAssigned(string json, string rawContent)
        {
            var message = JsonSerializer.Deserialize<WebSocketMessage<UserBadgeAssignedContent>>(json, JsonOptions);
            parsedContent = message.Content;

            OnUserBadgeAssigned?.Invoke(this, new VRChatEventArgs<UserBadgeAssignedContent>
            {
                Message = message.Content,
                RawMessage = json,
                RawContent = rawContent,
                Type = message.Type
            });
        }

        private void ProcessUserBadgeUnassigned(string json, string rawContent)
        {
            var message = JsonSerializer.Deserialize<WebSocketMessage<UserBadgeUnassignedContent>>(json, JsonOptions);
            parsedContent = message.Content;

            OnUserBadgeUnassigned?.Invoke(this, new VRChatEventArgs<UserBadgeUnassignedContent>
            {
                Message = message.Content,
                RawMessage = json,
                RawContent = rawContent,
                Type = message.Type
            });
        }

        private void ProcessContentRefresh(string json, string rawContent)
        {
            var message = JsonSerializer.Deserialize<WebSocketMessage<ContentRefreshContent>>(json, JsonOptions);
            parsedContent = message.Content;

            OnContentRefresh?.Invoke(this, new VRChatEventArgs<ContentRefreshContent>
            {
                Message = message.Content,
                RawMessage = json,
                RawContent = rawContent,
                Type = message.Type
            });
        }

        private void ProcessModifiedImageUpdate(string json, string rawContent)
        {
            var message = JsonSerializer.Deserialize<WebSocketMessage<ModifiedImageUpdateContent>>(json, JsonOptions);
            parsedContent = message.Content;

            OnModifiedImageUpdate?.Invoke(this, new VRChatEventArgs<ModifiedImageUpdateContent>
            {
                Message = message.Content,
                RawMessage = json,
                RawContent = rawContent,
                Type = message.Type
            });
        }

        private void ProcessInstanceQueueJoined(string json, string rawContent)
        {
            var message = JsonSerializer.Deserialize<WebSocketMessage<InstanceQueueJoinedContent>>(json, JsonOptions);
            parsedContent = message.Content;

            OnInstanceQueueJoined?.Invoke(this, new VRChatEventArgs<InstanceQueueJoinedContent>
            {
                Message = message.Content,
                RawMessage = json,
                RawContent = rawContent,
                Type = message.Type
            });
        }

        private void ProcessInstanceQueueReady(string json, string rawContent)
        {
            var message = JsonSerializer.Deserialize<WebSocketMessage<InstanceQueueReadyContent>>(json, JsonOptions);
            parsedContent = message.Content;

            OnInstanceQueueReady?.Invoke(this, new VRChatEventArgs<InstanceQueueReadyContent>
            {
                Message = message.Content,
                RawMessage = json,
                RawContent = rawContent,
                Type = message.Type
            });
        }

        #endregion

        #region Group Event Processors

        private void ProcessGroupJoined(string json, string rawContent)
        {
            var message = JsonSerializer.Deserialize<WebSocketMessage<GroupJoinedContent>>(json, JsonOptions);
            parsedContent = message.Content;

            OnGroupJoined?.Invoke(this, new VRChatEventArgs<GroupJoinedContent>
            {
                Message = message.Content,
                RawMessage = json,
                RawContent = rawContent,
                Type = message.Type
            });
        }

        private void ProcessGroupLeft(string json, string rawContent)
        {
            var message = JsonSerializer.Deserialize<WebSocketMessage<GroupLeftContent>>(json, JsonOptions);
            parsedContent = message.Content;

            OnGroupLeft?.Invoke(this, new VRChatEventArgs<GroupLeftContent>
            {
                Message = message.Content,
                RawMessage = json,
                RawContent = rawContent,
                Type = message.Type
            });
        }

        private void ProcessGroupMemberUpdated(string json, string rawContent)
        {
            var message = JsonSerializer.Deserialize<WebSocketMessage<GroupMemberUpdatedContent>>(json, JsonOptions);
            parsedContent = message.Content;

            OnGroupMemberUpdated?.Invoke(this, new VRChatEventArgs<GroupMemberUpdatedContent>
            {
                Message = message.Content,
                RawMessage = json,
                RawContent = rawContent,
                Type = message.Type
            });
        }

        private void ProcessGroupRoleUpdated(string json, string rawContent)
        {
            var message = JsonSerializer.Deserialize<WebSocketMessage<GroupRoleUpdatedContent>>(json, JsonOptions);
            parsedContent = message.Content;

            OnGroupRoleUpdated?.Invoke(this, new VRChatEventArgs<GroupRoleUpdatedContent>
            {
                Message = message.Content,
                RawMessage = json,
                RawContent = rawContent,
                Type = message.Type
            });
        }

        #endregion
    }
}

