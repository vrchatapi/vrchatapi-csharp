using System.Text.Json;

namespace VRChat.API.Realtime.Messages
{
    /// <summary>
    /// Represents a parsed WebSocket message received from the VRChat Pipeline API.
    /// </summary>
    /// <typeparam name="T">The type of the deserialized message content.</typeparam>
    /// <remarks>
    /// VRChat WebSocket messages typically have a "type" field indicating the event type
    /// and a "content" field containing the event data. This class provides convenient
    /// access to both the typed content and raw JSON for debugging or custom processing.
    /// </remarks>
    public class WebSocketMessage<T>
    {
        /// <summary>
        /// Gets or sets the message type identifier from VRChat.
        /// </summary>
        /// <value>
        /// The message type string, such as "friend-online", "notification", or "user-update".
        /// </value>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the deserialized message content.
        /// </summary>
        /// <value>
        /// The strongly-typed content object deserialized from the JSON payload.
        /// </value>
        public T Content { get; set; }

        /// <summary>
        /// Gets or sets the complete raw JSON string of the entire WebSocket message.
        /// </summary>
        /// <value>
        /// The original JSON string as received from the WebSocket, including type and content fields.
        /// Useful for debugging, logging, or custom deserialization scenarios.
        /// </value>
        public string RawMessage { get; set; }

        /// <summary>
        /// Gets or sets the raw JSON string of just the content field.
        /// </summary>
        /// <value>
        /// The JSON string representation of the content field before deserialization.
        /// For double-encoded messages, this is the inner JSON string that was decoded.
        /// </value>
        public string RawContent { get; set; }

        /// <summary>
        /// Creates a new <see cref="WebSocketMessage{T}"/> from pre-extracted type and content.
        /// </summary>
        /// <param name="type">The message type identifier.</param>
        /// <param name="rawMessage">The complete raw JSON message string.</param>
        /// <param name="rawContent">The raw content JSON string to deserialize.</param>
        /// <param name="options">The <see cref="JsonSerializerOptions"/> to use for deserialization.</param>
        /// <returns>A new <see cref="WebSocketMessage{T}"/> with the deserialized content.</returns>
        /// <remarks>
        /// Use this method for double-encoded messages where the content is already extracted
        /// as a JSON string from the outer message structure.
        /// </remarks>
        public static WebSocketMessage<T> FromContent(string type, string rawMessage, string rawContent, JsonSerializerOptions options)
        {
            return new WebSocketMessage<T>
            {
                Type = type,
                Content = JsonSerializer.Deserialize<T>(rawContent, options),
                RawMessage = rawMessage,
                RawContent = rawContent
            };
        }

        /// <summary>
        /// Creates a new <see cref="WebSocketMessage{T}"/> with string content that requires no deserialization.
        /// </summary>
        /// <param name="type">The message type identifier.</param>
        /// <param name="rawMessage">The complete raw JSON message string.</param>
        /// <param name="rawContent">The string content value.</param>
        /// <returns>A new <see cref="WebSocketMessage{T}"/> where T is <see cref="string"/>.</returns>
        /// <remarks>
        /// Use this method for simple messages where the content is a plain string value,
        /// such as notification IDs in "see-notification" or "hide-notification" events.
        /// </remarks>
        public static WebSocketMessage<string> FromStringContent(string type, string rawMessage, string rawContent)
        {
            return new WebSocketMessage<string>
            {
                Type = type,
                Content = rawContent,
                RawMessage = rawMessage,
                RawContent = rawContent
            };
        }
    }
}
