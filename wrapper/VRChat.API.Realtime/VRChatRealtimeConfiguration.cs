using System;

namespace VRChat.API.Realtime
{
    public class VRChatRealtimeConfiguration
    {
        /// <summary>
        /// The WebSocket endpoint URL for VRChat's Pipeline API
        /// </summary>
        public string EndpointURL { get; set; } = "wss://pipeline.vrchat.cloud/";

        /// <summary>
        /// Auto-reconnection mode for the WebSocket connection
        /// </summary>
        public AutoReconnectMode AutoReconnectMode { get; set; } = AutoReconnectMode.OnDisconnect;

        /// <summary>
        /// VRChat authentication token (authcookie)
        /// </summary>
        public string AuthToken { get; set; }

        /// <summary>
        /// User-Agent header for the WebSocket connection
        /// </summary>
        public string UserAgent { get; set; }
    }

    public enum AutoReconnectMode
    {
        /// <summary>
        /// Do not automatically reconnect
        /// </summary>
        None,

        /// <summary>
        /// Reconnect when disconnected unexpectedly
        /// </summary>
        OnDisconnect,

        /// <summary>
        /// Reconnect every 10 minutes
        /// </summary>
        Every10Minutes,

        /// <summary>
        /// Reconnect every 20 minutes
        /// </summary>
        Every20Minutes,

        /// <summary>
        /// Reconnect every 30 minutes
        /// </summary>
        Every30Minutes
    }
}

