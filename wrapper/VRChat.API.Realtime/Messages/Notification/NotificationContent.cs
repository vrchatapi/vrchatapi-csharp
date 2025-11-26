using System;
using VRChat.API.Model;

namespace VRChat.API.Realtime.Messages
{
    public class NotificationContent : EventArgs
    {
        public string UserId { get; set; }
        public LimitedUser User { get; set; }
    }
}

