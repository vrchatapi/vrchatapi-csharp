namespace VRChat.API.Realtime.Messages
{
    /// <summary>
    /// Represents the content of a "friend-add" WebSocket event.
    /// </summary>
    /// <remarks>
    /// This event is raised when a new friend is added to your friends list.
    /// This occurs when either you accept a friend request, or someone accepts
    /// your friend request.
    /// </remarks>
    /// <seealso cref="FriendDeleteContent"/>
    public class FriendAddContent
    {
        /// <summary>
        /// Gets or sets the unique identifier of the newly added friend.
        /// </summary>
        /// <value>
        /// A user's unique ID, usually in the form of <c>usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469</c>.
        /// Legacy players can have old IDs in the form of <c>8JoV9XEdpo</c>.
        /// </value>
        public string UserId { get; set; }

        /// <summary>
        /// Gets or sets the new friend's user information.
        /// </summary>
        /// <value>
        /// A <see cref="LimitedUser"/> object containing the friend's profile information,
        /// or <c>null</c> if not provided.
        /// </value>
        public LimitedUser User { get; set; }
    }
}
