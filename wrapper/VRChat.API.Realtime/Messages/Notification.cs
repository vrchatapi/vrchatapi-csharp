using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VRChat.API.Realtime.Messages
{
    /// <summary>
    /// Represents a notification received from the VRChat WebSocket API.
    /// </summary>
    /// <remarks>
    /// Notifications include friend requests, invites, invite responses, and other
    /// in-game notifications. The <see cref="Details"/> property contains additional
    /// information specific to the notification type.
    /// </remarks>
    /// <seealso cref="NotificationV2Content"/>
    /// <seealso cref="ResponseNotificationContent"/>
    public class Notification
    {
        /// <summary>
        /// Gets or sets the unique identifier of the notification.
        /// </summary>
        /// <value>
        /// A notification ID in the form of <c>not_xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx</c>.
        /// </value>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the type of notification.
        /// </summary>
        /// <value>
        /// The notification type, such as "friendRequest", "invite", "requestInvite",
        /// "inviteResponse", "requestInviteResponse", or "votetokick".
        /// </value>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of the user who sent the notification.
        /// </summary>
        /// <value>
        /// A user's unique ID, usually in the form of <c>usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469</c>.
        /// Legacy players can have old IDs in the form of <c>8JoV9XEdpo</c>.
        /// </value>
        public string SenderUserId { get; set; }

        /// <summary>
        /// Gets or sets the username of the sender.
        /// </summary>
        /// <value>
        /// The sender's username, or <c>null</c> if not provided.
        /// </value>
        /// <remarks>
        /// <b>DEPRECATED:</b> VRChat API no longer returns usernames of other users.
        /// See <see href="https://github.com/pypy-vrc/VRCX/issues/429">this issue</see> for more information.
        /// </remarks>
        [Obsolete("VRChat API no longer returns usernames of other users.")]
        public string SenderUsername { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of the user receiving the notification.
        /// </summary>
        /// <value>
        /// A user's unique ID, usually in the form of <c>usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469</c>.
        /// </value>
        public string ReceiverUserId { get; set; }

        /// <summary>
        /// Gets or sets the notification message text.
        /// </summary>
        /// <value>
        /// The human-readable notification message, such as "This is a generated invite to VRChat Hub".
        /// </value>
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets additional details specific to the notification type.
        /// </summary>
        /// <value>
        /// A dictionary containing notification-specific data. The contents vary based on
        /// <see cref="Type"/> and may include world information, invite details, etc.
        /// </value>
        /// <remarks>
        /// <b>NOTICE:</b> When received from the WebSocket API, this is already deserialized as an object.
        /// When received from the REST API, this is a JSON-encoded string that must be parsed separately.
        /// </remarks>
        public Dictionary<string, object> Details { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the notification was created.
        /// </summary>
        /// <value>
        /// The UTC timestamp of notification creation.
        /// </value>
        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets whether the notification has been seen.
        /// </summary>
        /// <value>
        /// <c>true</c> if the notification has been marked as seen; otherwise, <c>false</c>.
        /// </value>
        /// <remarks>
        /// This property is not included in notification objects received from the WebSocket API.
        /// </remarks>
        public bool Seen { get; set; }
    }
}
