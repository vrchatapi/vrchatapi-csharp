namespace VRChat.API.Realtime.Messages
{
    /// <summary>
    /// Represents the content of a "friend-update" WebSocket event.
    /// </summary>
    /// <remarks>
    /// This event is raised when a friend's profile information is updated.
    /// This includes changes to display name, status, avatar, bio, and other profile fields.
    /// </remarks>
    /// <seealso cref="FriendLocationContent"/>
    public class FriendUpdateContent
    {
        /// <summary>
        /// Gets or sets the unique identifier of the friend whose profile was updated.
        /// </summary>
        /// <value>
        /// A user's unique ID, usually in the form of <c>usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469</c>.
        /// Legacy players can have old IDs in the form of <c>8JoV9XEdpo</c>.
        /// </value>
        public string UserId { get; set; }

        /// <summary>
        /// Gets or sets the friend's updated user information.
        /// </summary>
        /// <value>
        /// A <see cref="LimitedUser"/> object containing the friend's updated profile information.
        /// </value>
        public LimitedUser User { get; set; }
    }
}
