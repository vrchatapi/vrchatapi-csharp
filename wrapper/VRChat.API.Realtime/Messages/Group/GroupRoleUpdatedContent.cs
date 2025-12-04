namespace VRChat.API.Realtime.Messages
{
    /// <summary>
    /// Represents the content of a "group-role-updated" WebSocket event.
    /// </summary>
    /// <remarks>
    /// This event is raised when a group role is updated or modified.
    /// This includes changes to role permissions, name, description, or other properties.
    /// </remarks>
    /// <seealso cref="GroupRole"/>
    /// <seealso cref="GroupMemberUpdatedContent"/>
    public class GroupRoleUpdatedContent
    {
        /// <summary>
        /// Gets or sets the updated group role information.
        /// </summary>
        /// <value>
        /// A <see cref="GroupRole"/> object containing the updated role details.
        /// </value>
        public GroupRole Role { get; set; }
    }
}
