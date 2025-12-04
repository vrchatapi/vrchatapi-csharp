namespace VRChat.API.Realtime.Messages
{
    /// <summary>
    /// Represents the content of a "group-joined" WebSocket event.
    /// </summary>
    /// <remarks>
    /// This event is raised when you join a group or have a group join request accepted.
    /// </remarks>
    /// <seealso cref="GroupLeftContent"/>
    /// <seealso cref="GroupMemberUpdatedContent"/>
    public class GroupJoinedContent
    {
        /// <summary>
        /// Gets or sets the unique identifier of the group that was joined.
        /// </summary>
        /// <value>
        /// A group's unique ID in the form of <c>grp_xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx</c>.
        /// </value>
        public string GroupId { get; set; }
    }
}
