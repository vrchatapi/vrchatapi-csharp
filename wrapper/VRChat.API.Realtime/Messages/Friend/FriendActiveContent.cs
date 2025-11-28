using System.Text.Json.Serialization;

namespace VRChat.API.Realtime.Messages
{
    public class FriendActiveContent
    {
        /// <summary>
        /// Note: API sends this as lowercase "userid" instead of "userId"
        /// </summary>
        [JsonPropertyName("userid")]
        public string UserId { get; set; }
        
        public string Platform { get; set; }
        public LimitedUser User { get; set; }
    }
}

