using System;

namespace VRChat.API.Realtime.Messages
{
    public class UserBadgeUnassignedContent : EventArgs
    {
        public string BadgeId { get; set; }
    }
}

