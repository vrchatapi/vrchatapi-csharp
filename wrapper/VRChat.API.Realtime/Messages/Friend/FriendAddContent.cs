using System;
using VRChat.API.Model;

namespace VRChat.API.Realtime.Messages
{
    public class FriendAddContent : EventArgs
    {
        public string UserId { get; set; }
        public LimitedUser User { get; set; }
    }
}

