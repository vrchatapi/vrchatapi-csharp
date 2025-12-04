namespace VRChat.API.Realtime.Messages
{
    /// <summary>
    /// Represents the content of a "response-notification" WebSocket event.
    /// </summary>
    /// <remarks>
    /// This event is raised when a response to a previously sent notification is received.
    /// This typically occurs when another user responds to a notification you sent,
    /// such as accepting or declining an invite request.
    /// </remarks>
    /// <seealso cref="Notification"/>
    public class ResponseNotificationContent
    {
        /// <summary>
        /// Gets or sets the unique identifier of the notification that was responded to.
        /// </summary>
        /// <value>
        /// A notification ID in the form of <c>not_xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx</c>.
        /// </value>
        public string NotificationId { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of the user who received and responded to the notification.
        /// </summary>
        /// <value>
        /// A user's unique ID, usually in the form of <c>usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469</c>.
        /// </value>
        public string ReceiverId { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of the response.
        /// </summary>
        /// <value>
        /// A response ID identifying the specific response action taken.
        /// </value>
        public string ResponseId { get; set; }
    }
}
