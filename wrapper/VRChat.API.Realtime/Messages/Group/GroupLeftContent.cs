namespace VRChat.API.Realtime.Messages
{
    /// <summary>
    /// Represents the content of a "group-left" WebSocket event.
    /// </summary>
    /// <remarks>
    /// This event is raised when you leave a group or are removed from a group.
    /// </remarks>
    /// <seealso cref="GroupJoinedContent"/>
    public class GroupLeftContent
    {
        /// <summary>
        /// Gets or sets the unique identifier of the group that was left.
        /// </summary>
        /// <value>
        /// A group's unique ID in the form of <c>grp_xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx</c>.
        /// </value>
        public string GroupId { get; set; }
    }
}
