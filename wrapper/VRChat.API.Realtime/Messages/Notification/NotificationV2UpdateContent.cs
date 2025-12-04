using System.Collections.Generic;

namespace VRChat.API.Realtime.Messages
{
    /// <summary>
    /// Represents the content of a "notification-v2-update" WebSocket event.
    /// </summary>
    /// <remarks>
    /// This event is raised when a V2 notification should be updated with new property values.
    /// Only the properties that changed are included in the update.
    /// </remarks>
    /// <seealso cref="NotificationV2Content"/>
    /// <seealso cref="NotificationV2DeleteContent"/>
    public class NotificationV2UpdateContent
    {
        /// <summary>
        /// Gets or sets the unique identifier of the notification to update.
        /// </summary>
        /// <value>
        /// A notification ID in the form of <c>not_xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx</c>.
        /// </value>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the new version number of the notification.
        /// </summary>
        /// <value>
        /// An integer version number that increments with each update.
        /// </value>
        public int Version { get; set; }

        /// <summary>
        /// Gets or sets the property updates to apply to the notification.
        /// </summary>
        /// <value>
        /// A dictionary containing property names as keys and their new values.
        /// Only changed properties are included.
        /// </value>
        public Dictionary<string, object> Updates { get; set; }
    }
}
