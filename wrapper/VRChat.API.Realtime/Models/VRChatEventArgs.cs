using System;

namespace VRChat.API.Realtime.Models
{
    /// <summary>
    /// Provides data for VRChat realtime events containing typed message content.
    /// </summary>
    /// <typeparam name="T">The type of the deserialized message content.</typeparam>
    /// <remarks>
    /// This class is used as the event argument for all typed VRChat WebSocket events,
    /// providing access to both the strongly-typed content and raw JSON data for
    /// debugging or custom processing scenarios.
    /// </remarks>
    /// <seealso cref="VRChat.API.Realtime.IVRChatRealtime"/>
    public class VRChatEventArgs<T> : EventArgs
    {
        /// <summary>
        /// Gets or sets the deserialized message content.
        /// </summary>
        /// <value>
        /// The strongly-typed content object deserialized from the WebSocket message.
        /// The type depends on the specific event (e.g., <see cref="VRChat.API.Realtime.Messages.FriendOnlineContent"/>
        /// for friend-online events).
        /// </value>
        public T Message { get; set; }

        /// <summary>
        /// Gets or sets the complete raw JSON string received from the WebSocket.
        /// </summary>
        /// <value>
        /// The original JSON string as received from VRChat's Pipeline API,
        /// including both the "type" and "content" fields.
        /// Useful for debugging, logging, or custom deserialization scenarios.
        /// </value>
        public string RawMessage { get; set; }

        /// <summary>
        /// Gets or sets the raw JSON string of the content field before deserialization.
        /// </summary>
        /// <value>
        /// The JSON string representation of the "content" field from the VRChat message.
        /// For double-encoded messages, this is the inner JSON string that was decoded
        /// before being deserialized to type <typeparamref name="T"/>.
        /// </value>
        public string RawContent { get; set; }

        /// <summary>
        /// Gets or sets the message type identifier.
        /// </summary>
        /// <value>
        /// The message type string from VRChat, such as "friend-online", "notification",
        /// "user-update", "group-joined", etc.
        /// </value>
        /// <seealso href="https://vrchatapi.github.io/docs/websocket/">VRChat WebSocket API Documentation</seealso>
        public string Type { get; set; }
    }
}
