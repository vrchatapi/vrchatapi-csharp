namespace VRChat.API.Realtime
{
    /// <summary>
    /// Configuration options for the VRChat realtime WebSocket client.
    /// </summary>
    /// <remarks>
    /// Use this class to configure the WebSocket endpoint, authentication, and reconnection behavior.
    /// Pass an instance to <see cref="VRChatRealtimeClientBuilder"/> to create a configured client.
    /// </remarks>
    /// <example>
    /// <code>
    /// var config = new VRChatRealtimeConfiguration
    /// {
    ///     AuthToken = "authcookie_xxx",
    ///     AutoReconnectMode = AutoReconnectMode.Every20Minutes
    /// };
    /// var client = new VRChatRealtimeClientBuilder(config).Build();
    /// </code>
    /// </example>
    /// <seealso cref="VRChatRealtimeClientBuilder"/>
    /// <seealso cref="AutoReconnectMode"/>
    public class VRChatRealtimeConfiguration
    {
        /// <summary>
        /// Gets or sets the WebSocket endpoint URL for VRChat's Pipeline API.
        /// </summary>
        /// <value>
        /// The WebSocket URL to connect to. Defaults to <c>wss://pipeline.vrchat.cloud/</c>.
        /// </value>
        /// <remarks>
        /// You typically don't need to change this unless connecting to a test server.
        /// </remarks>
        public string EndpointURL { get; set; } = "wss://pipeline.vrchat.cloud/";

        /// <summary>
        /// Gets or sets the auto-reconnection mode for the WebSocket connection.
        /// </summary>
        /// <value>
        /// The <see cref="AutoReconnectMode"/> determining when to automatically reconnect.
        /// Defaults to <see cref="AutoReconnectMode.OnDisconnect"/>.
        /// </value>
        /// <remarks>
        /// Some users find that periodic reconnection helps maintain a more stable connection
        /// over extended periods of use.
        /// </remarks>
        public AutoReconnectMode AutoReconnectMode { get; set; } = AutoReconnectMode.OnDisconnect;

        /// <summary>
        /// Gets or sets the VRChat authentication token (authcookie).
        /// </summary>
        /// <value>
        /// The authentication cookie value obtained from logging in to VRChat.
        /// This is required for establishing a WebSocket connection.
        /// </value>
        /// <remarks>
        /// The authcookie is obtained from the REST API authentication response.
        /// It is included in the <c>Set-Cookie</c> header after successful login.
        /// </remarks>
        public string AuthToken { get; set; }

        /// <summary>
        /// Gets or sets the User-Agent header for the WebSocket connection.
        /// </summary>
        /// <value>
        /// A User-Agent string identifying your application to VRChat's servers.
        /// </value>
        /// <remarks>
        /// VRChat requires applications to identify themselves with a proper User-Agent header.
        /// Use <see cref="VRChatRealtimeClientBuilder.WithApplication"/> for automatic formatting,
        /// or set this manually with a string in the format:
        /// <c>AppName/Version (Contact), VRChat.API.Realtime/Version (URL)</c>
        /// </remarks>
        /// <seealso cref="VRChatRealtimeClientBuilder.WithApplication"/>
        public string UserAgent { get; set; }
    }

    /// <summary>
    /// Specifies when the VRChat realtime client should automatically reconnect to the WebSocket.
    /// </summary>
    /// <remarks>
    /// Periodic reconnection can help maintain a stable connection over long periods.
    /// Choose a mode based on your application's requirements and VRChat's connection stability.
    /// </remarks>
    /// <seealso cref="VRChatRealtimeConfiguration.AutoReconnectMode"/>
    public enum AutoReconnectMode
    {
        /// <summary>
        /// Do not automatically reconnect. The client will remain disconnected if the connection is lost.
        /// </summary>
        /// <remarks>
        /// Use this mode if you want full control over reconnection logic in your application.
        /// </remarks>
        None,

        /// <summary>
        /// Automatically reconnect when the connection is unexpectedly lost.
        /// </summary>
        /// <remarks>
        /// This is the default mode. The client will attempt to reconnect after a brief delay
        /// when the WebSocket connection is closed unexpectedly.
        /// </remarks>
        OnDisconnect,

        /// <summary>
        /// Automatically reconnect every 10 minutes, in addition to reconnecting on disconnect.
        /// </summary>
        /// <remarks>
        /// Periodic reconnection can help prevent connection issues that may occur
        /// with very long-lived WebSocket connections.
        /// </remarks>
        Every10Minutes,

        /// <summary>
        /// Automatically reconnect every 20 minutes, in addition to reconnecting on disconnect.
        /// </summary>
        /// <remarks>
        /// A balance between frequent reconnection and connection stability.
        /// </remarks>
        Every20Minutes,

        /// <summary>
        /// Automatically reconnect every 30 minutes, in addition to reconnecting on disconnect.
        /// </summary>
        /// <remarks>
        /// Less frequent reconnection, suitable for applications that prefer
        /// longer uninterrupted connection periods.
        /// </remarks>
        Every30Minutes
    }
}
