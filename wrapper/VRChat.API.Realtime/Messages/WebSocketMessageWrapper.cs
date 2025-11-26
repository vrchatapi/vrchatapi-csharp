namespace VRChat.API.Realtime.Messages
{
    public class WebSocketMessage<T>
    {
        public string Type { get; set; }
        public T Content { get; set; }
    }
}

