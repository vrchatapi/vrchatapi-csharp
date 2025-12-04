namespace VRChat.API.Realtime.Messages
{
    /// <summary>
    /// Represents the content of a "user-location" WebSocket event.
    /// </summary>
    /// <remarks>
    /// This event is raised when the current user changes their location (world/instance).
    /// This is different from <see cref="FriendLocationContent"/> which tracks friends' locations.
    /// </remarks>
    /// <seealso cref="UserUpdateContent"/>
    /// <seealso cref="FriendLocationContent"/>
    public class UserLocationContent
    {
        /// <summary>
        /// Gets or sets the unique identifier of the current user.
        /// </summary>
        /// <value>
        /// A user's unique ID, usually in the form of <c>usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469</c>.
        /// </value>
        public string UserId { get; set; }

        /// <summary>
        /// Gets or sets the current user's information.
        /// </summary>
        /// <value>
        /// A <see cref="LimitedUser"/> object containing profile information,
        /// or <c>null</c> if not provided.
        /// </value>
        public LimitedUser User { get; set; }

        /// <summary>
        /// Gets or sets the current location.
        /// </summary>
        /// <value>
        /// A location string in the format <c>worldId:instanceId</c>, such as
        /// <c>wrld_4432ea9b-729c-46e3-8eaf-846aa0a37fdd:12345~private(usr_xxx)</c>.
        /// </value>
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets the current instance identifier.
        /// </summary>
        /// <value>
        /// The instance portion of the location string, such as <c>12345~private(usr_xxx)</c>.
        /// </value>
        public string Instance { get; set; }

        /// <summary>
        /// Gets or sets the location the user is currently traveling to.
        /// </summary>
        /// <value>
        /// A location string if the user is in transit to a new world, or <c>null</c>
        /// if they are not currently traveling.
        /// </value>
        public string TravelingToLocation { get; set; }
    }
}
