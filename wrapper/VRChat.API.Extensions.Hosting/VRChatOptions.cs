using System;
using System.Net;

namespace VRChat.API.Extensions.Hosting.Options
{
    /// <summary>
    /// IConfiguration options binding class, can be consumed in publically shipped-APIs.
    /// </summary>
    public class VRChatOptions
    {
        /// <summary>
        /// The username of the VRChat account to login with
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// The password of the VRChat account to login with
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// The 2FA secret of the VRChat account to login with
        /// </summary>
        public string TwoFactorSecret { get; set; }

        /// <summary>
        /// HTTP Request pool timeout, in miliseconds
        /// </summary>
        public int? Timeout { get; set; }

        /// <summary>
        /// The connecting proxy information
        /// </summary>
        public VRChatProxyOptions Proxy { get; set; }

        /// <summary>
        /// The User-Agent header to attach with the client.
        /// </summary>
        public string UserAgent { get; set; }

        /// <summary>
        /// The application information for auto-generated User-Agent handled by the library.
        /// </summary>
        public VRChatApplicationOptions Application { get; set; }
    }

    /// <summary>
    /// Application options for auto-generated user-agents based on application info provided into configuration
    /// </summary>
    public class VRChatApplicationOptions
    {
        /// <summary>
        /// The name of your application
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The version of your application
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// Contact info, like email, website, or Discord information for your application
        /// </summary>
        public string Contact { get; set; }
    }

    /// <summary>
    /// Proxy information for automatically setting up your proxy with VRChat
    /// </summary>
    public class VRChatProxyOptions
    {
        /// <summary>
        /// The Base URI of the proxy, including port
        /// </summary>
        public Uri Address { get; set; }

        /// <summary>
        /// The username for the proxy, leave null if unspecified
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// The password for the proxy, leave blank if unspecified
        /// </summary>
        public string Password { get; set; }
    }
}