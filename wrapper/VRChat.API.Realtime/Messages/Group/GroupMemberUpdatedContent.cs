namespace VRChat.API.Realtime.Messages
{
    /// <summary>
    /// Represents the content of a "group-member-updated" WebSocket event.
    /// </summary>
    /// <remarks>
    /// This event is raised when your group membership information is updated,
    /// such as role changes, visibility settings, or subscription preferences.
    /// </remarks>
    /// <seealso cref="GroupLimitedMember"/>
    /// <seealso cref="GroupRoleUpdatedContent"/>
    public class GroupMemberUpdatedContent
    {
        /// <summary>
        /// Gets or sets the updated group member information.
        /// </summary>
        /// <value>
        /// A <see cref="GroupLimitedMember"/> object containing the updated membership details.
        /// </value>
        public GroupLimitedMember Member { get; set; }
    }
}
