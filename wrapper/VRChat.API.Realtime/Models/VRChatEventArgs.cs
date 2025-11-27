using System;

namespace VRChat.API.Realtime.Models
{
    /// <summary>
    /// Generic event arguments for VRChat realtime events containing typed message data
    /// </summary>
    /// <typeparam name="T">The type of the message content</typeparam>
    public class VRChatEventArgs<T> : EventArgs
    {
        /// <summary>
        /// The typed message content
        /// </summary>
        public T Message { get; set; }

        /// <summary>
        /// The complete raw JSON string received from the WebSocket
        /// </summary>
        public string RawMessage { get; set; }

        /// <summary>
        /// The raw "content" field as a JSON string from the VRChat message
        /// </summary>
        public string RawContent { get; set; }

        /// <summary>
        /// The message type identifier
        /// </summary>
        public string Type { get; set; }
    }
}

