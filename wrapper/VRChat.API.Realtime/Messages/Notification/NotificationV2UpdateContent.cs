using System;
using System.Collections.Generic;

namespace VRChat.API.Realtime.Messages
{
    public class NotificationV2UpdateContent : EventArgs
    {
        public string Id { get; set; }
        public int Version { get; set; }
        public Dictionary<string, object> Updates { get; set; }
    }
}

