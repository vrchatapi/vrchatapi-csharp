using System;
using VRChat.API.Model;

namespace VRChat.API.Realtime.Messages
{
    public class FriendActiveContent : EventArgs
    {
        public string UserId { get; set; }
        public string Platform { get; set; }
        public LimitedUser User { get; set; }
    }
}

