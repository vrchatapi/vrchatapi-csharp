using System;

namespace VRChat.API.Realtime.Messages
{
    public class FriendOfflineContent : EventArgs
    {
        public string UserId { get; set; }
        public string Platform { get; set; }
    }
}

