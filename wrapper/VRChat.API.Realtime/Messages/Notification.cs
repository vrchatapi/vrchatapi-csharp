using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VRChat.API.Realtime.Messages
{
    /// <summary>
    /// Notification information received in WebSocket messages
    /// </summary>
    public class Notification
    {
        public string Id { get; set; }
        public string Type { get; set; }
        public string SenderUserId { get; set; }
        public string SenderUsername { get; set; }
        public string ReceiverUserId { get; set; }
        public string Message { get; set; }
        public Dictionary<string, object> Details { get; set; }
        
        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }
        
        public bool Seen { get; set; }
    }
}

