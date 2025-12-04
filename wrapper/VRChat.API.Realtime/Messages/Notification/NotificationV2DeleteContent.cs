using System.Collections.Generic;

namespace VRChat.API.Realtime.Messages
{
    /// <summary>
    /// Represents the content of a "notification-v2-delete" WebSocket event.
    /// </summary>
    /// <remarks>
    /// This event is raised when one or more V2 notifications should be deleted from the client.
    /// </remarks>
    /// <seealso cref="NotificationV2Content"/>
    /// <seealso cref="NotificationV2UpdateContent"/>
    public class NotificationV2DeleteContent
    {
        /// <summary>
        /// Gets or sets the list of notification IDs to delete.
        /// </summary>
        /// <value>
        /// A list of notification IDs in the form of <c>not_xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx</c>.
        /// </value>
        public List<string> Ids { get; set; }

        /// <summary>
        /// Gets or sets the version number of this delete operation.
        /// </summary>
        /// <value>
        /// An integer version number for tracking purposes.
        /// </value>
        public int Version { get; set; }
    }
}
