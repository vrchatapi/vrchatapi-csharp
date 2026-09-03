using System;
using System.Reflection;
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
        private const string _defaultUserAgent = "Example/0.0 (CONTACT_EMAIL), VRChat.API/net8.0 (https://vrchat.community/dotnet)";
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
        /// Sets the username, password and TOTP secret in one call.
        /// </summary>
        /// <param name="username">The username to authenticate with.</param>
        /// <param name="password">The password to authenticate with.</param>
        /// <param name="twoFactorSecret">The TOTP secret used to answer a two-factor challenge.</param>
        /// <returns>This <see cref="VRChatClientBuilder"/>, so calls can be chained.</returns>
        public VRChatClientBuilder WithCredentials(string username, string password, string twoFactorSecret) => this
            .WithUsername(username)
            .WithPassword(password)
            .WithTwoFactorSecret(twoFactorSecret);

        /// <summary>
        /// Sets the username and password, for an account without two-factor authentication.
        /// </summary>
        /// <param name="username">The username to authenticate with.</param>
        /// <param name="password">The password to authenticate with.</param>
        /// <returns>This <see cref="VRChatClientBuilder"/>, so calls can be chained.</returns>
        public VRChatClientBuilder WithCredentials(string username, string password) =>
            this.WithCredentials(username, password, null);

        /// <summary>
        /// Sets the username to authenticate with.
        /// </summary>
        /// <param name="username">The account's username. VRChat also accepts the email address.</param>
        /// <returns>This <see cref="VRChatClientBuilder"/>, so calls can be chained.</returns>
        public VRChatClientBuilder WithUsername(string username)
        {
            _configuration.Username = username;
            return this;
        }

        /// <summary>
        /// Sets the password to authenticate with.
        /// </summary>
        /// <param name="password">The account's password.</param>
        /// <returns>This <see cref="VRChatClientBuilder"/>, so calls can be chained.</returns>
        public VRChatClientBuilder WithPassword(string password)
        {
            _configuration.Password = password;
            return this;
        }

        /// <summary>
        /// Sets the TOTP secret used to answer a two-factor challenge.
        /// </summary>
        /// <remarks>This is the base32 secret shown when two-factor authentication is set up, not a
        /// six-digit code. It is required by <see cref="IVRChat.LoginAsync(System.Threading.CancellationToken)"/>;
        /// without it, use <see cref="IVRChat.LoginWithExternalCodeAsync"/> to supply codes yourself.</remarks>
        /// <param name="twoFactorSecret">The account's base32 TOTP secret.</param>
        /// <returns>This <see cref="VRChatClientBuilder"/>, so calls can be chained.</returns>
        public VRChatClientBuilder WithTwoFactorSecret(string twoFactorSecret)
        {
            _twoFactorSecret = twoFactorSecret;
            return this;
        }

        /// <summary>
        /// Authenticates with cookies from an earlier session instead of a username and password.
        /// </summary>
        /// <remarks>Obtain these from <see cref="IVRChat.GetCookies"/> on a logged-in client.</remarks>
        /// <param name="auth">The <c>auth</c> cookie value.</param>
        /// <param name="twoFactorAuth">The <c>twoFactorAuth</c> cookie value, which lets the session
        /// skip the two-factor challenge.</param>
        /// <returns>This <see cref="VRChatClientBuilder"/>, so calls can be chained.</returns>
        public VRChatClientBuilder WithAuthCookie(string auth, string twoFactorAuth = null)
        {
            // AddApiKey, not AddApiKeyPrefix: GetApiKeyWithPrefix returns `prefix + " " + value`, so
            // storing a cookie as the prefix sent it with a trailing space and no value.
            if (auth != null)
                _configuration.AddApiKey("auth", auth);

            if (twoFactorAuth != null)
                _configuration.AddApiKey("twoFactorAuth", twoFactorAuth);

            return this;
        }

        /// <summary>
        /// Sets the User-Agent header sent with every request.
        /// </summary>
        /// <remarks>VRChat requires a descriptive User-Agent identifying your application and a way to
        /// contact you. Prefer <see cref="WithApplication"/>, which formats one correctly.</remarks>
        /// <param name="userAgent">The User-Agent to send, or <see langword="null"/> for the default.</param>
        /// <returns>This <see cref="VRChatClientBuilder"/>, so calls can be chained.</returns>
        public VRChatClientBuilder WithUserAgent(string userAgent)
        {
            _configuration.UserAgent = userAgent ?? _defaultUserAgent;
            return this;
        }

        /// <summary>
        /// Sets how long a request may take before it is abandoned.
        /// </summary>
        /// <param name="timeout">The request timeout.</param>
        /// <returns>This <see cref="VRChatClientBuilder"/>, so calls can be chained.</returns>
        public VRChatClientBuilder WithTimeout(TimeSpan timeout)
        {
            _configuration.Timeout = timeout; // Using Miliseconds over TotalMilliseconds can cause issues when the timespan is empty
            return this;
        }

        /// <summary>
        /// Routes every request through a proxy.
        /// </summary>
        /// <param name="proxy">The proxy to send requests through.</param>
        /// <returns>This <see cref="VRChatClientBuilder"/>, so calls can be chained.</returns>
        public VRChatClientBuilder WithProxy(WebProxy proxy)
        {
            _configuration.Proxy = proxy;
            return this;
        }

        /// <summary>
        /// Routes every request through the proxy at a URL.
        /// </summary>
        /// <param name="url">The proxy's address.</param>
        /// <param name="bypass">Whether to bypass the proxy for local addresses.</param>
        /// <returns>This <see cref="VRChatClientBuilder"/>, so calls can be chained.</returns>
        public VRChatClientBuilder WithProxy(string url, bool bypass = true) =>
            this.WithProxy(new WebProxy(url, bypass));


        /// <summary>
        /// Sets the User-Agent from your application's details, in the form VRChat asks for.
        /// </summary>
        /// <remarks>Produces <c>{name}/{version} ({contact}), VRChat.API/{libraryVersion}</c>. VRChat may
        /// block traffic whose User-Agent does not identify the application and a way to reach its author.</remarks>
        /// <param name="name">Your application's name.</param>
        /// <param name="version">Your application's version.</param>
        /// <param name="contact">How VRChat can reach you, such as an email address or Discord handle.</param>
        /// <returns>This <see cref="VRChatClientBuilder"/>, so calls can be chained.</returns>
        public VRChatClientBuilder WithApplication(string name, string version, string contact)
        {
            var libraryVersion = Assembly.GetExecutingAssembly().GetName().Version!.ToString();
            this.WithUserAgent($"{name}/{version} ({contact}), VRChat.API/{libraryVersion} (https://vrchat.community/dotnet)");
            return this;
        }

        /// <summary>
        /// Builds the configured <see cref="IVRChat"/> client.
        /// </summary>
        /// <remarks>The returned client is not logged in. Call one of the login methods on
        /// <see cref="IVRChat"/>, or supply cookies through <see cref="WithAuthCookie"/>.</remarks>
        /// <param name="useWithoutCredentials">Whether to allow building a client that has no credentials,
        /// which is valid for the endpoints that do not require authentication.</param>
        /// <returns>The configured <see cref="IVRChat"/> client.</returns>
        /// <exception cref="ArgumentException">Thrown when <paramref name="useWithoutCredentials"/> is
        /// <see langword="false"/> and neither a username and password nor an auth cookie were set.</exception>
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

            return VRChatClient.Create(_configuration, _twoFactorSecret, _client, _httpClient, _httpClientHandler);
        }
    }
}