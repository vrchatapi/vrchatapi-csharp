using System;
using System.Reflection;

namespace VRChat.API.Realtime
{
    public class VRChatRealtimeClientBuilder
    {
        private readonly VRChatRealtimeConfiguration _configuration;

        public VRChatRealtimeClientBuilder()
        {
            _configuration = new VRChatRealtimeConfiguration();
        }

        /// <summary>
        /// Set the WebSocket endpoint URL
        /// </summary>
        public VRChatRealtimeClientBuilder WithEndpoint(string endpointUrl)
        {
            _configuration.EndpointURL = endpointUrl;
            return this;
        }

        /// <summary>
        /// Set the authentication token (authcookie)
        /// </summary>
        public VRChatRealtimeClientBuilder WithAuthToken(string authToken)
        {
            _configuration.AuthToken = authToken;
            return this;
        }

        /// <summary>
        /// Set the User-Agent header
        /// </summary>
        public VRChatRealtimeClientBuilder WithUserAgent(string userAgent)
        {
            _configuration.UserAgent = userAgent;
            return this;
        }

        public VRChatRealtimeClientBuilder WithApplication(string name, string version, string contact)
        {
            string libraryVersion = Assembly.GetExecutingAssembly().GetName().Version!.ToString();
            string userAgent = $"{name}/{version} ({contact}), VRChat.API.Realtime/{libraryVersion} (https://vrchat.community/dotnet)";
            return this.WithUserAgent(userAgent);
        }

        /// <summary>
        /// Set the auto-reconnect mode
        /// </summary>
        public VRChatRealtimeClientBuilder WithAutoReconnect(AutoReconnectMode mode)
        {
            _configuration.AutoReconnectMode = mode;
            return this;
        }

        /// <summary>
        /// Build the <see cref="IVRChatRealtimeClient"/> with the configured settings
        /// </summary>
        public IVRChatRealtime Build()
        {
            if (string.IsNullOrWhiteSpace(_configuration.AuthToken))
                throw new InvalidOperationException("AuthToken is required. Use WithAuthToken() to set it.");

            return new VRChatRealtimeClient(_configuration);
        }
    }
}
