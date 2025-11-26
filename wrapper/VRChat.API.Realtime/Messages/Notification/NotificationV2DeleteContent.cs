using System;
using System.Collections.Generic;

namespace VRChat.API.Realtime.Messages
{
    public class NotificationV2DeleteContent : EventArgs
    {
        public List<string> Ids { get; set; }
        public int Version { get; set; }
    }
}

