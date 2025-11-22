using System;
using System.Net;
using System.Net.Http;

namespace VRChat.API.Client
{
    /// <summary>
    /// The core of VRChat.API.Client. The VRChatClientBuilder class provides a Fluent API for building <see cref="IVRChat"/> clients, and smoothly
    /// providing authentication against VRChat's API, with a rebuilding pipeline if ever needed.
    /// </summary>
    public class VRChatClientBuilder
    {
        private const string _defaultUserAgent = "VRChat.API/1.0 (.NET) net8.0 (https://dot.net) VRChat.API/HttpClient";
        private Configuration _configuration;
        private ApiClient _client;
        private HttpClient _httpClient;
        private HttpClientHandler _httpClientHandler;

        private string _twoFactorSecret;

        /// <summary>
        /// Initializes a blank <see cref="VRChatClientBuilder"/> <br />
        /// </summary>
        public VRChatClientBuilder() : this(null, null) { }

        /// <summary>
        /// Initializes a <see cref="VRChatClientBuilder"/> from a <see cref="global::VRChat.API.Client.Configuration"/> (if any)
        /// <br /> <b style="color: red">Note: <em>This should not be used unless you know what you're doing</em></b>
        /// </summary>
        /// <param name="incomingConfiguration">The <see cref="Configuration"/> to initialize with as a base</param>
        /// <param name="incomingClient">The <see cref="ApiClient"/> to initialize with as a base</param>
        public VRChatClientBuilder(Configuration incomingConfiguration, ApiClient incomingClient)
        {
            _httpClientHandler = new HttpClientHandler()
            {
                UseCookies = true,
                CookieContainer = new CookieContainer()
            };

            _httpClient = new HttpClient(_httpClientHandler);
            _client = incomingClient ?? new ApiClient(_httpClient, _httpClientHandler);

            _configuration = incomingConfiguration ?? new Configuration();
            if (_configuration.UserAgent == null)
                this.WithUserAgent(_defaultUserAgent);
        }

        /// <summary>
        /// Creates a <see cref="VRChatClientBuilder"/> from a <see cref="Configuration"/>
        /// <br /> <b style="color: red">Note: <em>This should not be used unless you know what you're doing</em></b>
        /// </summary>
        /// <param name="incomingConfiguration">The <see cref="Configuration"/> to initialize with as a base</param>
        public static VRChatClientBuilder From(Configuration incomingConfiguration) =>
            new VRChatClientBuilder(incomingConfiguration, null);

        /// <summary>
        /// Creates a <see cref="VRChatClientBuilder"/> from a <see cref="Configuration"/>
        /// <br /> <b style="color: red">Note: <em>This should not be used unless you know what you're doing</em></b>
        /// </summary>
        /// <param name="incomingConfiguration">The <see cref="Configuration"/> to initialize with as a base</param>
        /// <param name="incomingClient">The <see cref="ApiClient"/> to initialize with as a base</param>
        public static VRChatClientBuilder From(Configuration incomingConfiguration, ApiClient incomingClient) =>
            new VRChatClientBuilder(incomingConfiguration, incomingClient);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="auth"></param>
        /// <param name="twoFactorSecret"></param>
        /// <returns></returns>
        public VRChatClientBuilder WithCredentials(string username, string password, string twoFactorSecret) => this
            .WithUsername(username)
            .WithPassword(password)
            .WithTwoFactorSecret(twoFactorSecret);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public VRChatClientBuilder WithCredentials(string username, string password) =>
            this.WithCredentials(username, password, null);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public VRChatClientBuilder WithUsername(string username)
        {
            _configuration.Username = username;
            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public VRChatClientBuilder WithPassword(string password)
        {
            _configuration.Password = password;
            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="twoFactorSecret"></param>
        /// <returns></returns>
        public VRChatClientBuilder WithTwoFactorSecret(string twoFactorSecret)
        {
            _twoFactorSecret = twoFactorSecret;
            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="auth"></param>
        /// <param name="twoFactorAuth"></param>
        /// <returns></returns>
        public VRChatClientBuilder WithAuthCookie(string auth, string twoFactorAuth = null)
        {
            if (auth != null)
                _configuration.AddApiKey("auth", auth);

            if (twoFactorAuth != null)
                _configuration.AddApiKey("twoFactorAuth", auth);

            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userAgent"></param>
        /// <returns></returns>
        public VRChatClientBuilder WithUserAgent(string userAgent)
        {
            _configuration.UserAgent = userAgent ?? _defaultUserAgent;
            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="timeout"></param>
        /// <returns></returns>
        public VRChatClientBuilder WithTimeout(TimeSpan timeout)
        {
            _configuration.Timeout = timeout; // Using Miliseconds over TotalMilliseconds can cause issues when the timespan is empty
            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="proxy"></param>
        /// <returns></returns>
        public VRChatClientBuilder WithProxy(WebProxy proxy)
        {
            _configuration.Proxy = proxy;
            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <param name="bypass"></param>
        /// <returns></returns>
        public VRChatClientBuilder WithProxy(string url, bool bypass = true) =>
            this.WithProxy(new WebProxy(url, bypass));


        /// <summary>
        /// </summary>
        public VRChatClientBuilder WithApplication(string name, string version, string contact) =>
            this.WithUserAgent($"{name}/{version} ({contact}), VRChat.API/net8.0 (https://vrchat.community/discord)");

        /// <summary>
        /// 
        /// </summary>
        /// <param name="useWithoutCredentials"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public IVRChat Build(bool useWithoutCredentials = true)
        {
            if (!useWithoutCredentials)
            {
                if (_configuration.Username == null || _configuration.Password == null)
                {
                    if (_configuration.GetApiKeyWithPrefix("auth") == null)
                        throw new ArgumentException("No credentials have been set up, and useWithoutCredentials is false");
                }
            }

            return VRChat.CreateInternal(_configuration, _twoFactorSecret, _client, _httpClient, _httpClientHandler);
        }
    }
}