using System;
using VRChat.API.Model;

namespace VRChat.API.Realtime.Messages
{
    public class UserLocationContent : EventArgs
    {
        public string UserId { get; set; }
        public LimitedUser User { get; set; }
        public string Location { get; set; }
        public string Instance { get; set; }
        public string TravelingToLocation { get; set; }
    }
}

