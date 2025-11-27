using VRChat.API.Model;

namespace VRChat.API.Realtime.Messages
{
    public class FriendOnlineContent
    {
        public string UserId { get; set; }
        public string Platform { get; set; }
        public string Location { get; set; }
        public bool CanRequestInvite { get; set; }
        public LimitedUser User { get; set; }
    }
}

