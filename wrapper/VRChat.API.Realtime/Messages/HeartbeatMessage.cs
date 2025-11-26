namespace VRChat.API.Realtime.Messages
{
    public class HeartbeatMessage
    {
        public string Type { get; set; } = "heartbeat";
        public bool Connected { get; set; } = true;
        public string Nonce { get; set; }
    }
}

