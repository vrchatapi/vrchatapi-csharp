using System;

namespace VRChat.API.Realtime.Messages
{
    public class GroupJoinedContent : EventArgs
    {
        public string GroupId { get; set; }
    }
}

