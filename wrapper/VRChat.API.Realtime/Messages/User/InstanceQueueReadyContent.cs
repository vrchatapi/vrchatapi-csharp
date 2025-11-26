using System;

namespace VRChat.API.Realtime.Messages
{
    public class InstanceQueueReadyContent : EventArgs
    {
        public string InstanceLocation { get; set; }
        public DateTime Expiry { get; set; }
    }
}

