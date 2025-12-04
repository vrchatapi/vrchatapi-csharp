namespace VRChat.API.Realtime.Messages
{
    /// <summary>
    /// Represents the content of a "friend-location" WebSocket event.
    /// </summary>
    /// <remarks>
    /// This event is raised when a friend changes their location (world/instance).
    /// The location may be "private" if the friend is in a private instance and
    /// you don't have permission to see their location.
    /// </remarks>
    /// <seealso cref="FriendOnlineContent"/>
    public class FriendLocationContent
    {
        /// <summary>
        /// Gets or sets the unique identifier of the friend whose location changed.
        /// </summary>
        /// <value>
        /// A user's unique ID, usually in the form of <c>usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469</c>.
        /// Legacy players can have old IDs in the form of <c>8JoV9XEdpo</c>.
        /// </value>
        public string UserId { get; set; }

        /// <summary>
        /// Gets or sets the friend's current location.
        /// </summary>
        /// <value>
        /// A location string in the format <c>worldId:instanceId</c>, such as
        /// <c>wrld_4432ea9b-729c-46e3-8eaf-846aa0a37fdd:12345~private(usr_xxx)</c>.
        /// May be "private" or "offline" depending on visibility settings.
        /// </value>
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets the location the friend is currently traveling to.
        /// </summary>
        /// <value>
        /// A location string if the friend is in transit to a new world, or <c>null</c>
        /// if they are not currently traveling.
        /// </value>
        public string TravelingToLocation { get; set; }

        /// <summary>
        /// Gets or sets the world ID of the friend's current world.
        /// </summary>
        /// <value>
        /// A world's unique ID in the form of <c>wrld_xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx</c>.
        /// </value>
        public string WorldId { get; set; }

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
        /// A <see cref="LimitedUser"/> object containing updated profile information,
        /// or <c>null</c> if not provided.
        /// </value>
        public LimitedUser User { get; set; }
    }
}
