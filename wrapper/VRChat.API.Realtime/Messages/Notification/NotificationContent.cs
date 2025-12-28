namespace VRChat.API.Realtime.Messages
{
    /// <summary>
    /// Represents generic notification content containing user information.
    /// </summary>
    /// <remarks>
    /// This is a base content type used for notifications that include user data.
    /// For the full notification object, see <see cref="Notification"/>.
    /// </remarks>
    /// <seealso cref="Notification"/>
    /// <seealso cref="NotificationV2Content"/>
    public class NotificationContent
    {
        /// <summary>
        /// Gets or sets the unique identifier of the user associated with the notification.
        /// </summary>
        /// <value>
        /// A user's unique ID, usually in the form of <c>usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469</c>.
        /// Legacy players can have old IDs in the form of <c>8JoV9XEdpo</c>.
        /// </value>
        public string UserId { get; set; }

        /// <summary>
        /// Gets or sets the user information associated with the notification.
        /// </summary>
        /// <value>
        /// A <see cref="LimitedUser"/> object containing user profile information,
        /// or <c>null</c> if not provided.
        /// </value>
        public LimitedUser User { get; set; }
    }
}
