namespace VRChat.API.Realtime.Messages
{
    public class UserUpdateContent
    {
        public string UserId { get; set; }
        public CurrentUserInfo User { get; set; }
    }
}

