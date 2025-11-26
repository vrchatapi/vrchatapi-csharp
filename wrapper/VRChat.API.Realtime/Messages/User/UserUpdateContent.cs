using System;

namespace VRChat.API.Realtime.Messages
{
    public class UserUpdateContent : EventArgs
    {
        public string UserId { get; set; }
        public CurrentUserInfo User { get; set; }
    }
}

