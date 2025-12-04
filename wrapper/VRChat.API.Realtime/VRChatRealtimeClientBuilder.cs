using System;
using System.Reflection;

namespace VRChat.API.Realtime
{
    /// <summary>
    /// Provides a fluent builder pattern for creating and configuring <see cref="IVRChatRealtime"/> instances.
    /// </summary>
    /// <remarks>
    /// Use this builder to configure the VRChat realtime client with the required authentication token,
    /// optional User-Agent header, and reconnection settings.
    /// </remarks>
    /// <example>
    /// <code>
    /// var client = new VRChatRealtimeClientBuilder(new VRChatRealtimeConfiguration())
    ///     .WithAuthToken("authcookie_xxx")
    ///     .WithApplication("MyApp", "1.0.0", "myapp@example.com")
    ///     .WithAutoReconnect(AutoReconnectMode.OnDisconnect)
    ///     .Build();
    /// </code>
    /// </example>
    /// <seealso cref="VRChatRealtimeConfiguration"/>
    /// <seealso cref="IVRChatRealtime"/>
    public class VRChatRealtimeClientBuilder
    {
        /// <summary>
        /// The configuration being built.
        /// </summary>
        private readonly VRChatRealtimeConfiguration _configuration;

        /// <summary>
        /// Initializes a new instance of the <see cref="VRChatRealtimeClientBuilder"/> class.
        /// </summary>
        /// <param name="incomingConfiguration">
        /// An existing <see cref="VRChatRealtimeConfiguration"/> to start with, or <c>null</c> to use defaults.
        /// </param>
        public VRChatRealtimeClientBuilder(VRChatRealtimeConfiguration incomingConfiguration = null)
        {
            _configuration = incomingConfiguration ?? new VRChatRealtimeConfiguration();
        }

        /// <summary>
        /// Sets the WebSocket endpoint URL for the VRChat Pipeline API.
        /// </summary>
        /// <param name="endpointUrl">The WebSocket URL to connect to.</param>
        /// <returns>The current <see cref="VRChatRealtimeClientBuilder"/> instance for method chaining.</returns>
        /// <remarks>
        /// The default endpoint is <c>wss://pipeline.vrchat.cloud/</c>. Only change this if you
        /// need to connect to a different server for testing or development purposes.
        /// </remarks>
        public VRChatRealtimeClientBuilder WithEndpoint(string endpointUrl)
        {
            _configuration.EndpointURL = endpointUrl;
            return this;
        }

        /// <summary>
        /// Sets the authentication token (authcookie) for the WebSocket connection.
        /// </summary>
        /// <param name="authToken">The VRChat authentication cookie value.</param>
        /// <returns>The current <see cref="VRChatRealtimeClientBuilder"/> instance for method chaining.</returns>
        /// <remarks>
        /// This is required. The authcookie can be obtained after logging in via the VRChat API.
        /// It is typically found in the <c>Set-Cookie</c> header of the authentication response.
        /// </remarks>
        /// <exception cref="InvalidOperationException">
        /// Thrown by <see cref="Build"/> if this method is not called with a valid token.
        /// </exception>
        public VRChatRealtimeClientBuilder WithAuthToken(string authToken)
        {
            _configuration.AuthToken = authToken;
            return this;
        }

        /// <summary>
        /// Sets a custom User-Agent header for the WebSocket connection.
        /// </summary>
        /// <param name="userAgent">The User-Agent string to send with WebSocket requests.</param>
        /// <returns>The current <see cref="VRChatRealtimeClientBuilder"/> instance for method chaining.</returns>
        /// <remarks>
        /// VRChat requires applications to identify themselves with a proper User-Agent header.
        /// Consider using <see cref="WithApplication"/> instead for automatic formatting.
        /// </remarks>
        /// <seealso cref="WithApplication"/>
        public VRChatRealtimeClientBuilder WithUserAgent(string userAgent)
        {
            _configuration.UserAgent = userAgent;
            return this;
        }

        /// <summary>
        /// Configures the User-Agent header with standardized application information.
        /// </summary>
        /// <param name="name">The name of your application.</param>
        /// <param name="version">The version of your application.</param>
        /// <param name="contact">Contact information (typically an email or URL) for the application author.</param>
        /// <returns>The current <see cref="VRChatRealtimeClientBuilder"/> instance for method chaining.</returns>
        /// <remarks>
        /// This method automatically formats the User-Agent string to include your application
        /// information along with the VRChat.API.Realtime library version. The format follows
        /// VRChat's recommended User-Agent guidelines.
        /// </remarks>
        /// <example>
        /// <code>
        /// builder.WithApplication("MyVRChatBot", "2.1.0", "contact@example.com");
        /// // Produces: MyVRChatBot/2.1.0 (contact@example.com), VRChat.API.Realtime/x.x.x (https://vrchat.community/dotnet)
        /// </code>
        /// </example>
        public VRChatRealtimeClientBuilder WithApplication(string name, string version, string contact)
        {
            string libraryVersion = Assembly.GetExecutingAssembly().GetName().Version!.ToString();
            string userAgent = $"{name}/{version} ({contact}), VRChat.API/{libraryVersion} (https://vrchat.community/dotnet)";
            return this.WithUserAgent(userAgent);
        }

        /// <summary>
        /// Sets the auto-reconnect behavior for the WebSocket connection.
        /// </summary>
        /// <param name="mode">The <see cref="AutoReconnectMode"/> specifying when to reconnect.</param>
        /// <returns>The current <see cref="VRChatRealtimeClientBuilder"/> instance for method chaining.</returns>
        /// <remarks>
        /// Auto-reconnection helps maintain a stable connection to VRChat's Pipeline API.
        /// Some users prefer periodic reconnection (every 10-30 minutes) to avoid connection
        /// issues that can occur with long-lived WebSocket connections.
        /// </remarks>
        /// <seealso cref="AutoReconnectMode"/>
        public VRChatRealtimeClientBuilder WithAutoReconnect(AutoReconnectMode mode)
        {
            _configuration.AutoReconnectMode = mode;
            return this;
        }

        /// <summary>
        /// Builds and returns a configured <see cref="IVRChatRealtime"/> instance.
        /// </summary>
        /// <returns>A new <see cref="IVRChatRealtime"/> instance ready for connection.</returns>
        /// <exception cref="InvalidOperationException">
        /// Thrown if <see cref="WithAuthToken"/> was not called with a valid authentication token.
        /// </exception>
        /// <remarks>
        /// After building, call <see cref="IVRChatRealtime.ConnectAsync"/> to establish the
        /// WebSocket connection to VRChat's Pipeline API.
        /// </remarks>
        public IVRChatRealtime Build()
        {
            if (string.IsNullOrWhiteSpace(_configuration.AuthToken))
                throw new InvalidOperationException("AuthToken is required. Use WithAuthToken() to set it.");

            return new VRChatRealtimeClient(_configuration);
        }
    }
}
