using System;
using VRChat.API.Realtime.Messages;

namespace VRChat.API.Realtime.Models
{
    public class NotificationEventArgs : EventArgs
    {
        public Notification Notification { get; set; }
    }
}

