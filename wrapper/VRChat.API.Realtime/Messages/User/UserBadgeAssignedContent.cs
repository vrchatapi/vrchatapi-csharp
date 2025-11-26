using System;

namespace VRChat.API.Realtime.Messages
{
    public class UserBadgeAssignedContent : EventArgs
    {
        public string Badge { get; set; }
    }
}

