namespace VRChat.API.Realtime.Messages
{
    /// <summary>
    /// Represents the content of a "friend-delete" WebSocket event.
    /// </summary>
    /// <remarks>
    /// This event is raised when a friend is removed from your friends list.
    /// This can occur when either you unfriend someone, or they unfriend you.
    /// </remarks>
    /// <seealso cref="FriendAddContent"/>
    public class FriendDeleteContent
    {
        /// <summary>
        /// Gets or sets the unique identifier of the friend who was removed.
        /// </summary>
        /// <value>
        /// A user's unique ID, usually in the form of <c>usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469</c>.
        /// Legacy players can have old IDs in the form of <c>8JoV9XEdpo</c>.
        /// </value>
        public string UserId { get; set; }
    }
}
