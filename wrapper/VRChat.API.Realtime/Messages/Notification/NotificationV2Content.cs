using System;
using System.Collections.Generic;

namespace VRChat.API.Realtime.Messages
{
    /// <summary>
    /// Represents the content of a "notification-v2" WebSocket event.
    /// </summary>
    /// <remarks>
    /// V2 notifications are an enhanced notification system used for group announcements,
    /// system messages, and other rich notifications that support responses and expiration.
    /// </remarks>
    /// <seealso cref="NotificationV2UpdateContent"/>
    /// <seealso cref="NotificationV2DeleteContent"/>
    /// <seealso cref="NotificationV2ResponseItem"/>
    public class NotificationV2Content
    {
        /// <summary>
        /// Gets or sets the unique identifier of the notification.
        /// </summary>
        /// <value>
        /// A notification ID in the form of <c>not_xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx</c>.
        /// </value>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the version number of the notification.
        /// </summary>
        /// <value>
        /// An integer version number that increments when the notification is updated.
        /// </value>
        public int Version { get; set; }

        /// <summary>
        /// Gets or sets the type of the notification.
        /// </summary>
        /// <value>
        /// The notification type, such as "group.announcement", "group.informative", etc.
        /// </value>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the category of the notification.
        /// </summary>
        /// <value>
        /// The notification category, such as "social", "system", etc.
        /// </value>
        public string Category { get; set; }

        /// <summary>
        /// Gets or sets whether this is a system notification.
        /// </summary>
        /// <value>
        /// <c>true</c> if this is a system-generated notification; otherwise, <c>false</c>.
        /// </value>
        public bool IsSystem { get; set; }

        /// <summary>
        /// Gets or sets whether this notification should ignore Do Not Disturb settings.
        /// </summary>
        /// <value>
        /// <c>true</c> if the notification should bypass DND; otherwise, <c>false</c>.
        /// </value>
        public bool IgnoreDND { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of the user who sent the notification.
        /// </summary>
        /// <value>
        /// A user's unique ID, or <c>null</c> for system notifications.
        /// </value>
        public string SenderUserId { get; set; }

        /// <summary>
        /// Gets or sets the username of the sender.
        /// </summary>
        /// <value>
        /// The sender's username, or <c>null</c> for system notifications.
        /// Note: VRChat no longer returns usernames in most API responses.
        /// </value>
        [Obsolete("VRChat API no longer returns usernames of other users in most cases.")]
        public string SenderUsername { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of the user receiving the notification.
        /// </summary>
        /// <value>
        /// A user's unique ID, usually in the form of <c>usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469</c>.
        /// </value>
        public string ReceiverUserId { get; set; }

        /// <summary>
        /// Gets or sets the ID of related notifications.
        /// </summary>
        /// <value>
        /// An ID linking related notifications together, or <c>null</c> if standalone.
        /// </value>
        public string RelatedNotificationsId { get; set; }

        /// <summary>
        /// Gets or sets the title of the notification.
        /// </summary>
        /// <value>
        /// The notification title displayed to the user.
        /// </value>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the main message content of the notification.
        /// </summary>
        /// <value>
        /// The notification body text.
        /// </value>
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the URL of an image associated with the notification.
        /// </summary>
        /// <value>
        /// A URL to an image, or <c>null</c> if no image is attached.
        /// </value>
        public string ImageUrl { get; set; }

        /// <summary>
        /// Gets or sets a link associated with the notification.
        /// </summary>
        /// <value>
        /// A URL the user can navigate to, or <c>null</c> if no link is provided.
        /// </value>
        public string Link { get; set; }

        /// <summary>
        /// Gets or sets the display text for the link.
        /// </summary>
        /// <value>
        /// The text shown for the link, or <c>null</c> if no link is provided.
        /// </value>
        public string LinkText { get; set; }

        /// <summary>
        /// Gets or sets the available response options for the notification.
        /// </summary>
        /// <value>
        /// A list of <see cref="NotificationV2ResponseItem"/> objects representing
        /// possible user responses, or <c>null</c> if no responses are available.
        /// </value>
        public List<NotificationV2ResponseItem> Responses { get; set; }

        /// <summary>
        /// Gets or sets the expiration date and time of the notification.
        /// </summary>
        /// <value>
        /// The UTC timestamp when the notification expires and should be removed.
        /// </value>
        public DateTime ExpiresAt { get; set; }

        /// <summary>
        /// Gets or sets the number of seconds after being seen before the notification expires.
        /// </summary>
        /// <value>
        /// The expiry delay in seconds after the notification is marked as seen.
        /// </value>
        public int ExpiryAfterSeen { get; set; }

        /// <summary>
        /// Gets or sets whether the notification requires acknowledgment.
        /// </summary>
        /// <value>
        /// <c>true</c> if the notification must be marked as seen; otherwise, <c>false</c>.
        /// </value>
        public bool RequireSeen { get; set; }

        /// <summary>
        /// Gets or sets whether the notification has been seen.
        /// </summary>
        /// <value>
        /// <c>true</c> if the notification has been marked as seen; otherwise, <c>false</c>.
        /// </value>
        public bool Seen { get; set; }

        /// <summary>
        /// Gets or sets whether the notification can be deleted by the user.
        /// </summary>
        /// <value>
        /// <c>true</c> if the user can delete this notification; otherwise, <c>false</c>.
        /// </value>
        public bool CanDelete { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the notification was created.
        /// </summary>
        /// <value>
        /// The UTC timestamp of notification creation.
        /// </value>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the notification was last updated.
        /// </summary>
        /// <value>
        /// The UTC timestamp of the last modification.
        /// </value>
        public DateTime UpdatedAt { get; set; }
    }
}
