namespace VRChat.API.Realtime.Messages
{
    /// <summary>
    /// Represents the content of a "friend-online" WebSocket event.
    /// </summary>
    /// <remarks>
    /// This event is raised when a friend comes online in the VRChat game client.
    /// This is different from <see cref="FriendActiveContent"/> which indicates
    /// a friend is active on the VRChat website.
    /// </remarks>
    /// <seealso cref="FriendOfflineContent"/>
    /// <seealso cref="FriendActiveContent"/>
    /// <seealso cref="FriendLocationContent"/>
    public class FriendOnlineContent
    {
        /// <summary>
        /// Gets or sets the unique identifier of the friend who came online.
        /// </summary>
        /// <value>
        /// A user's unique ID, usually in the form of <c>usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469</c>.
        /// Legacy players can have old IDs in the form of <c>8JoV9XEdpo</c>.
        /// </value>
        public string UserId { get; set; }

        /// <summary>
        /// Gets or sets the platform the friend is online on.
        /// </summary>
        /// <value>
        /// The platform identifier, such as "standalonewindows", "android", or other Unity version strings.
        /// </value>
        public string Platform { get; set; }

        /// <summary>
        /// Gets or sets the friend's current location.
        /// </summary>
        /// <value>
        /// A location string in the format <c>worldId:instanceId</c>, such as
        /// <c>wrld_4432ea9b-729c-46e3-8eaf-846aa0a37fdd:12345~private(usr_xxx)</c>.
        /// May be "private" depending on visibility settings.
        /// </value>
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets whether you can request an invite to the friend's instance.
        /// </summary>
        /// <value>
        /// <c>true</c> if you can request an invite to join the friend's instance;
        /// <c>false</c> if the instance is private or invites are restricted.
        /// </value>
        public bool CanRequestInvite { get; set; }

        /// <summary>
        /// Gets or sets the friend's user information.
        /// </summary>
        /// <value>
        /// A <see cref="LimitedUser"/> object containing the friend's profile information,
        /// or <c>null</c> if not provided.
        /// </value>
        public LimitedUser User { get; set; }
    }
}
