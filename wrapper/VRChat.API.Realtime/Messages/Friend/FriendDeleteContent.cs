using System;

namespace VRChat.API.Realtime.Messages
{
    public class FriendDeleteContent : EventArgs
    {
        public string UserId { get; set; }
    }
}

