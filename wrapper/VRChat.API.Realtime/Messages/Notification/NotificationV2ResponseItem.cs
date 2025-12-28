namespace VRChat.API.Realtime.Messages
{
    /// <summary>
    /// Represents a response option for a V2 notification.
    /// </summary>
    /// <remarks>
    /// V2 notifications can include interactive response options that users can select.
    /// Each response item defines an action the user can take in response to the notification.
    /// </remarks>
    /// <seealso cref="NotificationV2Content"/>
    public class NotificationV2ResponseItem
    {
        /// <summary>
        /// Gets or sets the type of response action.
        /// </summary>
        /// <value>
        /// The response type, such as "accept", "decline", "block", etc.
        /// </value>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets additional data associated with the response.
        /// </summary>
        /// <value>
        /// Response-specific data that will be sent when this response is selected,
        /// or <c>null</c> if no additional data is needed.
        /// </value>
        public string Data { get; set; }

        /// <summary>
        /// Gets or sets the icon identifier for the response button.
        /// </summary>
        /// <value>
        /// An icon identifier or URL for display, or <c>null</c> if no icon is specified.
        /// </value>
        public string Icon { get; set; }

        /// <summary>
        /// Gets or sets the display text for the response button.
        /// </summary>
        /// <value>
        /// The human-readable text shown on the response button.
        /// </value>
        public string Text { get; set; }
    }
}
