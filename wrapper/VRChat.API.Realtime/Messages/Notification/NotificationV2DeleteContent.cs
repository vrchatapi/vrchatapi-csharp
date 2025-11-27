using System.Collections.Generic;

namespace VRChat.API.Realtime.Messages
{
    public class NotificationV2DeleteContent
    {
        public List<string> Ids { get; set; }
        public int Version { get; set; }
    }
}

