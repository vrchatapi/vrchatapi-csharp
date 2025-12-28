namespace VRChat.API.Realtime.Messages
{
    /// <summary>
    /// Represents the content of a "user-badge-unassigned" WebSocket event.
    /// </summary>
    /// <remarks>
    /// This event is raised when a badge is removed from your account, such as when
    /// a VRChat+ subscription expires or a temporary badge is revoked.
    /// </remarks>
    /// <seealso cref="UserBadgeAssignedContent"/>
    public class UserBadgeUnassignedContent
    {
        /// <summary>
        /// Gets or sets the unique identifier of the badge that was removed.
        /// </summary>
        /// <value>
        /// A badge ID in the form of <c>bdge_xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx</c>.
        /// </value>
        public string BadgeId { get; set; }
    }
}
