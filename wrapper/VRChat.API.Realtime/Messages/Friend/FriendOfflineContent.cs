namespace VRChat.API.Realtime.Messages
{
    /// <summary>
    /// Represents the content of a "friend-offline" WebSocket event.
    /// </summary>
    /// <remarks>
    /// This event is raised when a friend goes offline from VRChat.
    /// </remarks>
    /// <seealso cref="FriendOnlineContent"/>
    /// <seealso cref="FriendActiveContent"/>
    public class FriendOfflineContent
    {
        /// <summary>
        /// Gets or sets the unique identifier of the friend who went offline.
        /// </summary>
        /// <value>
        /// A user's unique ID, usually in the form of <c>usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469</c>.
        /// Legacy players can have old IDs in the form of <c>8JoV9XEdpo</c>.
        /// </value>
        public string UserId { get; set; }

        /// <summary>
        /// Gets or sets the platform the friend was on before going offline.
        /// </summary>
        /// <value>
        /// The platform identifier, such as "standalonewindows", "android", or other Unity version strings.
        /// </value>
        public string Platform { get; set; }
    }
}
