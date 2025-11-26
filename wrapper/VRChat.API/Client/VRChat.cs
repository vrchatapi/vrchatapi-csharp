using OtpNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VRChat.API.Api;
using VRChat.API.Model;

namespace VRChat.API.Client
{
    /// <summary>
    /// A generic interface for communicating against VRChat's API.
    /// </summary>
    public interface IVRChat
    {
        /// <summary>
        /// The VRChat <see cref="VRChat.API.Client.Configuration"/> used by this client. <br />
        /// Can be used to modify default headers, base path, and other settings, and modify the VRChat configuration.
        /// </summary>
        public Configuration Configuration { get; }

        /// <summary>
        /// The VRChat <see cref="ApiClient"/> used by this client. <br />
        /// Can be used to manually execute requests.
        /// </summary>
        public ApiClient Client { get; }

        /// <summary>
        /// Gets the underlying <see cref="System.Net.Http.HttpClient"/> instance used to send HTTP requests.
        /// </summary>
        /// <remarks>Use this property to configure default request headers, timeouts, or other settings
        /// for outgoing HTTP requests. Changes to the <see cref="System.Net.Http.HttpClient"/> instance affect all requests sent
        /// through this client.</remarks>
        public HttpClient HttpClient { get; }

        /// <summary>
        /// Gets the underlying <see cref="System.Net.Http.HttpClientHandler"/> used to configure HTTP request and response processing.
        /// </summary>
        /// <remarks>Use this property to customize settings such as proxy, cookies, authentication, or
        /// SSL options for HTTP requests made by the client. Changes to the handler may affect subsequent
        /// requests.</remarks>
        public HttpClientHandler HttpClientHandler { get; }

        /// <summary>
        /// <b>The Jams API for VRChat.</b> <br />
        /// Documentation to be updated later.
        /// </summary>
        IJamsApi Jams { get; }

        /// <summary>
        /// <b>The Props API for VRChat.</b> <br />
        /// Documentation to be updated later.
        /// </summary>
        IPropsApi Props { get; }

        /// <summary>
        /// <b>The Files API for VRChat.</b> <br />
        /// The Files API provides access to creating, deleting, uploading, and managing files for avatars, worlds, thumbnails, and user profiles on VRChat.
        /// </summary>
        IFilesApi Files { get; }

        /// <summary>
        /// <b>The Users API for VRChat.</b> <br />
        /// The Users API provides access to searching for, querying, and updating user information on VRChat.
        /// </summary>
        IUsersApi Users { get; }

        /// <summary>
        /// <b>The Worlds API for VRChat.</b> <br />
        /// The Worlds API provides access to querying, creating, updating, and general world resource management on VRChat.
        /// </summary>
        IWorldsApi Worlds { get; }

        /// <summary>
        /// <b>The Prints API for VRChat.</b> <br />
        /// This API can be used to manage and read your VRChat prints.
        /// </summary>
        IPrintsApi Prints { get; }

        /// <summary>
        /// <b>The Groups API for VRChat.</b> <br />
        /// The Groups API provides access to managing your group, group members, and accessing audit logs.
        /// </summary>
        IGroupsApi Groups { get; }

        /// <summary>
        /// <b>The Invites API for VRChat.</b> <br />
        /// The Invites API provides access to requesting invites, listing invites, sending invites, and managing invites on VRChat.
        /// </summary>
        IInviteApi Invites { get; }

        /// <summary>
        /// <b>The Avatars API for VRChat.</b> <br />
        /// The Avatars API provides access to querying, creating, updating, and general avatar resource management on VRChat.
        /// </summary>
        IAvatarsApi Avatars { get; }

        /// <summary>
        /// <b>The Economy API for VRChat.</b> <br />
        /// The Economy API provides access to information on the current user's transactions toward VRChat Inc.
        /// </summary>
        IEconomyApi Economy { get; }

        /// <summary>
        /// <b>The Friends API for VRChat.</b> <br />
        /// The Friends API provides access to managing relationships with other users on VRChat.
        /// </summary>
        IFriendsApi Friends { get; }

        /// <summary>
        /// <b>The Calendar API for VRChat.</b> <br />
        /// Documentation to be updated later.
        /// </summary>
        ICalendarApi Calendar { get; }

        /// <summary>
        /// <b>The Instances API for VRChat.</b> <br />
        /// The Instances API provides access to querying instance information and requesting instance access on VRChat.
        /// </summary>
        IInstancesApi Instances { get; }

        /// <summary>
        /// <b>The Inventory API for VRChat.</b> <br />
        /// Documetation to be updated later
        /// </summary>
        IInventoryApi Inventory { get; }

        /// <summary>
        /// <b>The Favorites API for VRChat.</b> <br />
        /// The Favorites API provides access to managing avatar and world favorites, and favorite groups with VRChat.
        /// </summary>
        IFavoritesApi Favorites { get; }

        /// <summary>
        /// <b>The Miscellaneous API for VRChat.</b> <br />
        /// The Miscellanous API provides system information, assigned permissions, API config, CSS, and general statistics on VRChat. <br />
        /// This API is not really used.
        /// </summary>
        IMiscellaneousApi Miscellaneous { get; }

        /// <summary>
        /// <b>The Notifications API for VRChat.</b> <br />
        /// The Notifications API provides access to listing, deleting, acknowledging, and clearning notifications on VRChat.
        /// <em>An important use-case of this API is to accept a friend request notification.</em>
        /// </summary>
        INotificationsApi Notifications { get; }

        /// <summary>
        /// <b>The Moderations API for VRChat.</b> <br />
        /// The Moderations API provides access to blocking/unblocking users, muting users, and managing general moderations on VRChat.
        /// </summary>
        IPlayermoderationApi Moderations { get; }

        /// <summary>
        /// <b>The Authentication API for VRChat.</b> <br />
        /// The Authentication API provides access to basic authentication (login/logout), 2FA access, user deletion, and checking for taken usernames/emails.
        /// </summary>
        IAuthenticationApi Authentication { get; }

        /// <summary>
        /// Returns a list of cookies from the current client's CookieContainer.
        /// </summary>
        /// <returns>A <see cref="List{Cookie}"/> with the cookies of the current CookieContainer.</returns>
        public List<Cookie> GetCookies();

        /// <summary>
        /// Will be <c>true</c> if the current client is successfully logged in as a user.
        /// <br /> Otherwise, this will return <c>false</c>.
        /// <br /> <em>This property automatically updates when calling <see cref="IVRChat.TryLoginAsync(CancellationToken)"/> or <see cref="IVRChat.LoginAsync(bool, CancellationToken)"/></em>
        /// </summary>
        bool IsLoggedIn { get; }

        /// <summary>
        /// Tries to login as the currently configured user, and returns a <see cref="bool"/> with the result.
        /// </summary>
        /// <param name="ct">Cancellation token for cancelling any asynchronous operations</param>
        /// <returns>A <see cref="bool"/> specifying if the current client is logged in successfully.</returns>
        Task<bool> TryLoginAsync(CancellationToken ct = default);

        /// <summary>
        /// Logs in as the currently configured user. Will throw an exception unless <b><c>throwOnFail</c></b> is set to <b><c>true</c></b>.
        /// <br /> If successful, the <see cref="CurrentUser"/> will be returned, otherwise <b><c>null</c></b> (if <b><c>throwOnFail</c></b> is false).
        /// </summary>
        /// <param name="throwOnFail">If you are simply checking for valid authentication, leave this as false</param>
        /// <param name="ct">Cancellation token for cancelling any asynchronous operations</param>
        /// <returns>A <see cref="CurrentUser"/> with the currently logged in user, if successful.</returns>
        Task<CurrentUser> LoginAsync(CancellationToken ct = default);
    }

    internal class VRChatClient : IVRChat
    {
        private VRChatClient(Configuration configuration, string twoFactorSecret = null, ApiClient client = null, HttpClient httpClient = null, HttpClientHandler httpClientHandler = null)
        {
            _twoFactorSecret = twoFactorSecret;
            _httpClientHandler = httpClientHandler ?? new HttpClientHandler()
            {
                UseCookies = true,
                CookieContainer = new CookieContainer()
            };

            _httpClient = httpClient ?? new HttpClient(_httpClientHandler);
            _client = client ?? new ApiClient(_httpClient, _httpClientHandler);
            _configuration = configuration ?? new Configuration();

            _jams = new JamsApi(_client, _client, _configuration);
            _props = new PropsApi(_client, _client, _configuration);
            _inventory = new InventoryApi(_client, _client, _configuration);
            _groups = new GroupsApi(_client, _client, _configuration);
            _miscellaneous = new MiscellaneousApi(_client, _client, _configuration);
            _prints = new PrintsApi(_client, _client, _configuration);
            _files = new FilesApi(_client, _client, _configuration);
            _users = new UsersApi(_client, _client, _configuration);
            _worlds = new WorldsApi(_client, _client, _configuration);
            _invites = new InviteApi(_client, _client, _configuration);
            _avatars = new AvatarsApi(_client, _client, _configuration);
            _economy = new EconomyApi(_client, _client, _configuration);
            _calendar = new CalendarApi(_client, _client, _configuration);
            _friends = new FriendsApi(_client, _client, _configuration);
            _instances = new InstancesApi(_client, _client, _configuration);
            _favorites = new FavoritesApi(_client, _client, _configuration);
            _notifications = new NotificationsApi(_client, _client, _configuration);
            _moderations = new PlayermoderationApi(_client, _client, _configuration);
            _authentication = new AuthenticationApi(_client, _client, _configuration);
        }

        private readonly string _twoFactorSecret;

        private readonly ApiClient _client;
        private readonly HttpClient _httpClient;
        private readonly Configuration _configuration;
        private readonly HttpClientHandler _httpClientHandler;

        private readonly JamsApi _jams;
        private readonly PropsApi _props;
        private readonly FilesApi _files;
        private readonly UsersApi _users;
        private readonly PrintsApi _prints;
        private readonly GroupsApi _groups;
        private readonly WorldsApi _worlds;
        private readonly InviteApi _invites;
        private readonly AvatarsApi _avatars;
        private readonly EconomyApi _economy;
        private readonly FriendsApi _friends;
        private readonly CalendarApi _calendar;
        private readonly InstancesApi _instances;
        private readonly InventoryApi _inventory;
        private readonly FavoritesApi _favorites;
        private readonly MiscellaneousApi _miscellaneous;
        private readonly NotificationsApi _notifications;
        private readonly PlayermoderationApi _moderations;
        private readonly AuthenticationApi _authentication;

        public Configuration Configuration => _configuration;
        public ApiClient Client => _client;
        public HttpClient HttpClient => _httpClient;
        public HttpClientHandler HttpClientHandler => _httpClientHandler;

        public IJamsApi Jams => _jams;
        public IFilesApi Files => _files;
        public IUsersApi Users => _users;
        public IPropsApi Props => _props;
        public IPrintsApi Prints => _prints;
        public IGroupsApi Groups => _groups;
        public IWorldsApi Worlds => _worlds;
        public IInviteApi Invites => _invites;
        public IAvatarsApi Avatars => _avatars;
        public IEconomyApi Economy => _economy;
        public IFriendsApi Friends => _friends;
        public ICalendarApi Calendar => _calendar;
        public IInventoryApi Inventory => _inventory;
        public IInstancesApi Instances => _instances;
        public IFavoritesApi Favorites => _favorites;
        public IMiscellaneousApi Miscellaneous => _miscellaneous;
        public INotificationsApi Notifications => _notifications;
        public IPlayermoderationApi Moderations => _moderations;
        public IAuthenticationApi Authentication => _authentication;

        public bool IsLoggedIn { get; private set; }

        // Creates a new VRChatClient internally, compatible with IVRChatClient
        internal static VRChatClient CreateInternal(Configuration configuration, string twoFactorSecret, ApiClient client, HttpClient httpClient, HttpClientHandler handler) =>
            new VRChatClient(configuration, twoFactorSecret, client, httpClient, handler);

        public List<Cookie> GetCookies()
        {
            return _httpClientHandler.CookieContainer?.GetAllCookies().ToList();
        }

        public async Task<bool> TryLoginAsync(CancellationToken ct = default)
        {
            CurrentUser user = null;
            try
            {
                user = await this.LoginAsync(ct);
            }
            catch
            {
                return false;
            }

            return user == null;
        }

        public async Task<CurrentUser> LoginAsync(CancellationToken ct = default)
        {
            if (_twoFactorSecret == null)
                throw new ArgumentNullException("This method only supports logging in with Two-Factor TOTP authentication. Please use VRChatClientBuilder.WithTwoFactorSecret() to use this method");

            ApiResponse<CurrentUser> response = await this.Authentication.GetCurrentUserWithHttpInfoAsync(cancellationToken: ct);

            if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                throw new UnauthorizedAccessException("401 Unauthorized");
            }

            if (response.Data.RequiresTwoFactorAuth != null && response.Data.RequiresTwoFactorAuth.Contains("totp"))
            {
                var totp = new Totp(Base32Encoding.ToBytes(_twoFactorSecret));
                var twoFactorResponse = await this.Authentication.Verify2FAWithHttpInfoAsync(new TwoFactorAuthCode(totp.ComputeTotp()), ct);

                if (twoFactorResponse.StatusCode != HttpStatusCode.OK)
                    throw new UnauthorizedAccessException("Failed to verify two-factor authentication with VRChat.");

                response = await this.Authentication.GetCurrentUserWithHttpInfoAsync(ct);
            }
            else if (response.Data.RequiresTwoFactorAuth != null)
                throw new InvalidOperationException("This account does not have TOTP Two Factor Authentication set up on it. This method only supports Two-Factor TOTP authentication");

            var user = response.Data;

            this.IsLoggedIn = response.StatusCode == HttpStatusCode.OK && user != null;
            return response.StatusCode == HttpStatusCode.OK ? user : null;
        }
    }
}