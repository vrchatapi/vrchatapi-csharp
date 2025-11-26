using System;
using System.Collections.Generic;

namespace VRChat.API.Realtime.Messages
{
    public class NotificationV2Content : EventArgs
    {
        public string Id { get; set; }
        public int Version { get; set; }
        public string Type { get; set; }
        public string Category { get; set; }
        public bool IsSystem { get; set; }
        public bool IgnoreDND { get; set; }
        public string SenderUserId { get; set; }
        public string SenderUsername { get; set; }
        public string ReceiverUserId { get; set; }
        public string RelatedNotificationsId { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public string ImageUrl { get; set; }
        public string Link { get; set; }
        public string LinkText { get; set; }
        public List<NotificationV2ResponseItem> Responses { get; set; }
        public DateTime ExpiresAt { get; set; }
        public int ExpiryAfterSeen { get; set; }
        public bool RequireSeen { get; set; }
        public bool Seen { get; set; }
        public bool CanDelete { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}

