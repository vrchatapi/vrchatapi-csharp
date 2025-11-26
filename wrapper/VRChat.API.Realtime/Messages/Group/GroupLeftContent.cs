using System;

namespace VRChat.API.Realtime.Messages
{
    public class GroupLeftContent : EventArgs
    {
        public string GroupId { get; set; }
    }
}

