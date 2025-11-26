using System.Collections.Generic;

namespace VRChat.API.Realtime.Messages
{
    public class CurrentUserInfo
    {
        public string Bio { get; set; }
        public string CurrentAvatar { get; set; }
        public string CurrentAvatarImageUrl { get; set; }
        public string CurrentAvatarThumbnailImageUrl { get; set; }
        public string DisplayName { get; set; }
        public string FallbackAvatar { get; set; }
        public string Id { get; set; }
        public string ProfilePicOverride { get; set; }
        public string Status { get; set; }
        public string StatusDescription { get; set; }
        public List<string> Tags { get; set; }
        public string UserIcon { get; set; }
        public string Username { get; set; }
    }
}

