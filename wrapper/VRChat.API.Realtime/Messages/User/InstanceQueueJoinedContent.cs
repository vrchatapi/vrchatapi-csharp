using System;

namespace VRChat.API.Realtime.Messages
{
    public class InstanceQueueJoinedContent : EventArgs
    {
        public string InstanceLocation { get; set; }
        public int Position { get; set; }
    }
}

