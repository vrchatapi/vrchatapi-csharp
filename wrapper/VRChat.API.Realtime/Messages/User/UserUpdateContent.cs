namespace VRChat.API.Realtime.Messages
{
    /// <summary>
    /// Represents the content of a "user-update" WebSocket event.
    /// </summary>
    /// <remarks>
    /// This event is raised when the current user's profile information is updated.
    /// This includes changes to display name, status, avatar, bio, and other profile fields.
    /// </remarks>
    /// <seealso cref="CurrentUserInfo"/>
    /// <seealso cref="UserLocationContent"/>
    public class UserUpdateContent
    {
        /// <summary>
        /// Gets or sets the unique identifier of the current user.
        /// </summary>
        /// <value>
        /// A user's unique ID, usually in the form of <c>usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469</c>.
        /// </value>
        public string UserId { get; set; }

        /// <summary>
        /// Gets or sets the current user's updated information.
        /// </summary>
        /// <value>
        /// A <see cref="CurrentUserInfo"/> object containing the updated profile information.
        /// </value>
        public CurrentUserInfo User { get; set; }
    }
}
