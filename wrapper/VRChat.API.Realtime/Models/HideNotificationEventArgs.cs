using System;

namespace VRChat.API.Realtime.Models
{
    public class HideNotificationEventArgs : EventArgs
    {
        public string NotificationId { get; set; }
    }
}

