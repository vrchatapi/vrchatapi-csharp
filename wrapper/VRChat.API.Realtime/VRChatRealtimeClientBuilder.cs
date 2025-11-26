using System;

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

        /// <summary>
        /// Set the auto-reconnect mode
        /// </summary>
        public VRChatRealtimeClientBuilder WithAutoReconnect(AutoReconnectMode mode)
        {
            _configuration.AutoReconnectMode = mode;
            return this;
        }

        /// <summary>
        /// Build the VRChatRealtimeClient with the configured settings
        /// </summary>
        public VRChatRealtimeClient Build()
        {
            if (string.IsNullOrWhiteSpace(_configuration.AuthToken))
                throw new InvalidOperationException("AuthToken is required. Use WithAuthToken() to set it.");

            return new VRChatRealtimeClient(_configuration);
        }
    }
}
