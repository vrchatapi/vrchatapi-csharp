namespace VRChat.API.Realtime.Messages
{
    /// <summary>
    /// Represents the content of a "user-badge-assigned" WebSocket event.
    /// </summary>
    /// <remarks>
    /// This event is raised when you are assigned a badge, such as a VRChat+
    /// subscription badge or special event badges.
    /// </remarks>
    /// <seealso cref="UserBadgeUnassignedContent"/>
    /// <seealso cref="Badge"/>
    public class UserBadgeAssignedContent
    {
        /// <summary>
        /// Gets or sets the badge information as a JSON string.
        /// </summary>
        /// <value>
        /// A JSON string containing the badge details, including badgeId, badgeName,
        /// badgeDescription, and badgeImageUrl.
        /// </value>
        /// <remarks>
        /// This is provided as a string and may need to be deserialized separately
        /// to access individual badge properties.
        /// </remarks>
        public string Badge { get; set; }
    }
}
