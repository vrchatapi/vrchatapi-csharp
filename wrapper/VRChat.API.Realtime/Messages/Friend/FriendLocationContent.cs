using System;
using VRChat.API.Model;

namespace VRChat.API.Realtime.Messages
{
    public class FriendLocationContent : EventArgs
    {
        public string UserId { get; set; }
        public string Location { get; set; }
        public string TravelingToLocation { get; set; }
        public string WorldId { get; set; }
        public bool CanRequestInvite { get; set; }
        public LimitedUser User { get; set; }
    }
}

