using System;
using VRChat.API.Model;

namespace VRChat.API.Realtime.Messages
{
    public class FriendUpdateContent : EventArgs
    {
        public string UserId { get; set; }
        public LimitedUser User { get; set; }
    }
}

