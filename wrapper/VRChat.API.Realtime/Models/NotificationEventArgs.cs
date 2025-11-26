using System;
using VRChat.API.Model;

namespace VRChat.API.Realtime.Models
{
    public class NotificationEventArgs : EventArgs
    {
        public Notification Notification { get; set; }
    }
}

