namespace VRChat.API.Realtime.Messages
{
    /// <summary>
    /// WebSocket message wrapper where content is a string (double-encoded JSON)
    /// </summary>
    public class WebSocketMessageString
    {
        public string Type { get; set; }
        public string Content { get; set; }
    }
}

