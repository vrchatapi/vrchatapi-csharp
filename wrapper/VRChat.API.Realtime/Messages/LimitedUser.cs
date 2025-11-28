using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VRChat.API.Realtime.Messages
{
    /// <summary>
    /// User information received in WebSocket messages
    /// </summary>
    public class LimitedUser
    {
        public string Id { get; set; }
        public string Username { get; set; }
        public string DisplayName { get; set; }
        public string Bio { get; set; }
        public List<string> BioLinks { get; set; }
        public string CurrentAvatarImageUrl { get; set; }
        public string CurrentAvatarThumbnailImageUrl { get; set; }
        public List<string> CurrentAvatarTags { get; set; }
        public string DeveloperType { get; set; }
        public bool IsFriend { get; set; }
        public string FriendKey { get; set; }
        public string FriendRequestStatus { get; set; }
        public string LastPlatform { get; set; }
        public string Location { get; set; }
        public string InstanceId { get; set; }
        public string WorldId { get; set; }
        public string Platform { get; set; }
        public string ProfilePicOverride { get; set; }
        public string ProfilePicOverrideThumbnail { get; set; }
        public string Pronouns { get; set; }
        public string Status { get; set; }
        public string StatusDescription { get; set; }
        public string State { get; set; }
        public List<string> Tags { get; set; }
        public string UserIcon { get; set; }
        public string Note { get; set; }
        public string AgeVerificationStatus { get; set; }
        public bool AgeVerified { get; set; }
        public bool AllowAvatarCopying { get; set; }
        public string TravelingToInstance { get; set; }
        public string TravelingToLocation { get; set; }
        public string TravelingToWorld { get; set; }
        
        [JsonPropertyName("date_joined")]
        public string DateJoined { get; set; }
        
        [JsonPropertyName("last_activity")]
        public string LastActivity { get; set; }
        
        [JsonPropertyName("last_login")]
        public string LastLogin { get; set; }
        
        [JsonPropertyName("last_mobile")]
        public string LastMobile { get; set; }
        
        public List<Badge> Badges { get; set; }
    }

    /// <summary>
    /// Badge information
    /// </summary>
    public class Badge
    {
        public string BadgeId { get; set; }
        public string BadgeName { get; set; }
        public string BadgeDescription { get; set; }
        public string BadgeImageUrl { get; set; }
        public DateTime AssignedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool Hidden { get; set; }
        public bool Showcased { get; set; }
    }
}

