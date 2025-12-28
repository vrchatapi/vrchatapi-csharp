namespace VRChat.API.Realtime.Messages
{
    /// <summary>
    /// Represents a heartbeat message sent to keep the WebSocket connection alive.
    /// </summary>
    /// <remarks>
    /// Heartbeat messages are sent periodically (typically every 30 seconds) to maintain
    /// the WebSocket connection with VRChat's Pipeline API. The server uses these to
    /// detect disconnected clients.
    /// </remarks>
    /// <seealso cref="VRChat.API.Realtime.IVRChatRealtime.OnHeartbeat"/>
    public class HeartbeatMessage
    {
        /// <summary>
        /// Gets or sets the message type identifier.
        /// </summary>
        /// <value>
        /// Always "heartbeat" for heartbeat messages.
        /// </value>
        public string Type { get; set; } = "heartbeat";

        /// <summary>
        /// Gets or sets whether the client is connected.
        /// </summary>
        /// <value>
        /// Always <c>true</c> for heartbeat messages.
        /// </value>
        public bool Connected { get; set; } = true;

        /// <summary>
        /// Gets or sets a unique nonce for this heartbeat.
        /// </summary>
        /// <value>
        /// A unique identifier (typically a GUID) to track this specific heartbeat message.
        /// </value>
        public string Nonce { get; set; }
    }
}
