/*
 * VRChat API Documentation
 *
 * ![VRChat API Banner](https://vrchatapi.github.io/assets/img/api_banner_1500x400.png)  # Welcome to the VRChat API  Before we begin, we would like to state this is a **COMMUNITY DRIVEN PROJECT**. This means that everything you read on here was written by the community itself and is **not** officially supported by VRChat. The documentation is provided \"AS IS\", and any action you take towards VRChat is completely your own responsibility.  The documentation and additional libraries SHALL ONLY be used for applications interacting with VRChat's API in accordance with their [Terms of Service](https://github.com/VRChatAPI), and MUST NOT be used for modifying the client, \"avatar ripping\", or other illegal activities. Malicious usage or spamming the API may result in account termination. Certain parts of the API are also more sensitive than others, for example moderation, so please read tread extra carefully and read the warnings when present.  ![Tupper Policy on API](https://i.imgur.com/yLlW7Ok.png)  Finally, use of the API using applications other than the approved methods (website, VRChat application, Unity SDK) is not officially supported. VRChat provides no guarantee or support for external applications using the API. Access to API endpoints may break **at any time, without notice**. Therefore, please **do not ping** VRChat Staff in the VRChat Discord if you are having API problems, as they do not provide API support. We will make a best effort in keeping this documentation and associated language libraries up to date, but things might be outdated or missing. If you find that something is no longer valid, please contact us on Discord or [create an issue](https://github.com/vrchatapi/specification/issues) and tell us so we can fix it.  # Getting Started  The VRChat API can be used to programmatically retrieve or update information regarding your profile, friends, avatars, worlds and more. The API consists of two parts, \"Photon\" which is only used in-game, and the \"Web API\" which is used by both the game and the website. This documentation focuses only on the Web API.  The API is designed around the REST ideology, providing semi-simple and usually predictable URIs to access and modify objects. Requests support standard HTTP methods like GET, PUT, POST, and DELETE and standard status codes. Response bodies are always UTF-8 encoded JSON objects, unless explicitly documented otherwise.  <div class=\"callout callout-error\">   <strong>🛑 Warning! Do not touch Photon!</strong><br>   Photon is only used by the in-game client and should <b>not</b> be touched. Doing so may result in permanent account termination. </div>  <div class=\"callout callout-info\">   <strong>ℹ️ API Key and Authentication</strong><br>   The API Key has always been the same and is currently <code>JlE5Jldo5Jibnk5O5hTx6XVqsJu4WJ26</code>.   Read <a href=\"#tag- -authentication\">Authentication</a> for how to log in. </div>  # Using the API  For simply exploring what the API can do it is strongly recommended to download [Insomnia](https://insomnia.rest/download), a free and open-source API client that's great for sending requests to the API in an orderly fashion. Insomnia allows you to send data in the format that's required for VRChat's API. It is also possible to try out the API in your browser, by first logging in at [vrchat.com/home](https://vrchat.com/home/) and then going to [vrchat.com/api/1/auth/user](https://vrchat.com/api/1/auth/user), but the information will be much harder to work with.  For more permanent operation such as software development it is instead recommended to use one of the existing language SDKs. This community project maintains API libraries in several languages, which allows you to interact with the API with simple function calls rather than having to implement the HTTP protocol yourself. Most of these libraries are automatically generated from the API specification, sometimes with additional helpful wrapper code to make usage easier. This allows them to be almost automatically updated and expanded upon as soon as a new feature is introduced in the specification itself. The libraries can be found on [GitHub](https://github.com/vrchatapi) or following:  * [NodeJS (JavaScript)](https://www.npmjs.com/package/vrchat) * [Dart](https://pub.dev/packages/vrchat_dart) * [Rust](https://crates.io/crates/vrchatapi) * [C#](github.com/vrchatapi/vrchatapi-csharp) * [Python](https://github.com/vrchatapi/VRChatPython)  # Pagination  Most endpoints enforce pagination, meaning they will only return 10 entries by default, and never more than 100.<br> Using both the limit and offset parameters allows you to easily paginate through a large number of objects.  | Query Parameter | Type | Description | | - -- -- -- -- -|- -|- -- -- -- | | `limit` | integer  | The number of objects to return. This value often defaults to 10. Highest limit is always 100.| | `offset` | integer  | A zero-based offset from the default object sorting.|  If a request returns fewer objects than the `limit` parameter, there are no more items available to return.  # Contribution  Do you want to get involved in the documentation effort? Do you want to help improve one of the language API libraries? This project is an [OPEN Open Source Project](https://openopensource.org)! This means that individuals making significant and valuable contributions are given commit-access to the project. It also means we are very open and welcoming of new people making contributions, unlike some more guarded open-source projects.  [![Discord](https://img.shields.io/static/v1?label=vrchatapi&message=discord&color=blueviolet&style=for-the-badge)](https://discord.gg/qjZE9C9fkB)
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: me@ruby.js.org
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = io.github.vrchatapi.Client.OpenAPIDateConverter;

namespace io.github.vrchatapi.Model
{
    /// <summary>
    /// CurrentUser
    /// </summary>
    [DataContract]
    public partial class CurrentUser :  IEquatable<CurrentUser>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=true)]
        public UserState State { get; set; }
        /// <summary>
        /// Gets or Sets DeveloperType
        /// </summary>
        [DataMember(Name="developerType", EmitDefaultValue=true)]
        public DeveloperType DeveloperType { get; set; }
        /// <summary>
        /// Gets or Sets LastPlatform
        /// </summary>
        [DataMember(Name="last_platform", EmitDefaultValue=true)]
        public Platform LastPlatform { get; set; }
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=true)]
        public UserStatus Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CurrentUser" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CurrentUser() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CurrentUser" /> class.
        /// </summary>
        /// <param name="username">username (required).</param>
        /// <param name="displayName">displayName (required).</param>
        /// <param name="userIcon">userIcon (required).</param>
        /// <param name="bio">bio (required).</param>
        /// <param name="bioLinks">bioLinks (required).</param>
        /// <param name="profilePicOverride">profilePicOverride (required).</param>
        /// <param name="statusDescription">statusDescription (required).</param>
        /// <param name="pastDisplayNames">pastDisplayNames (required).</param>
        /// <param name="hasEmail">hasEmail (required).</param>
        /// <param name="hasPendingEmail">hasPendingEmail (required).</param>
        /// <param name="obfuscatedEmail">obfuscatedEmail (required).</param>
        /// <param name="obfuscatedPendingEmail">obfuscatedPendingEmail (required).</param>
        /// <param name="emailVerified">emailVerified (required).</param>
        /// <param name="hasBirthday">hasBirthday (required).</param>
        /// <param name="unsubscribe">unsubscribe (required).</param>
        /// <param name="statusHistory">statusHistory (required).</param>
        /// <param name="statusFirstTime">statusFirstTime (required).</param>
        /// <param name="friends">friends (required).</param>
        /// <param name="friendGroupNames">Always empty array. (required).</param>
        /// <param name="currentAvatarImageUrl">currentAvatarImageUrl (required).</param>
        /// <param name="currentAvatarThumbnailImageUrl">currentAvatarThumbnailImageUrl (required).</param>
        /// <param name="fallbackAvatar">fallbackAvatar (required).</param>
        /// <param name="currentAvatar">currentAvatar (required).</param>
        /// <param name="currentAvatarAssetUrl">currentAvatarAssetUrl (required).</param>
        /// <param name="accountDeletionDate">accountDeletionDate.</param>
        /// <param name="acceptedTOSVersion">acceptedTOSVersion (required).</param>
        /// <param name="steamId">steamId (required).</param>
        /// <param name="steamDetails">steamDetails (required).</param>
        /// <param name="oculusId">oculusId (required).</param>
        /// <param name="hasLoggedInFromClient">hasLoggedInFromClient (required).</param>
        /// <param name="homeLocation">homeLocation (required).</param>
        /// <param name="twoFactorAuthEnabled">twoFactorAuthEnabled (required).</param>
        /// <param name="state">state (required).</param>
        /// <param name="tags">tags (required).</param>
        /// <param name="developerType">developerType (required).</param>
        /// <param name="lastLogin">lastLogin (required).</param>
        /// <param name="lastPlatform">lastPlatform (required).</param>
        /// <param name="allowAvatarCopying">allowAvatarCopying (required).</param>
        /// <param name="status">status (required).</param>
        /// <param name="isFriend">isFriend (required) (default to false).</param>
        /// <param name="friendKey">friendKey (required).</param>
        /// <param name="onlineFriends">onlineFriends.</param>
        /// <param name="activeFriends">activeFriends.</param>
        /// <param name="offlineFriends">offlineFriends.</param>
        public CurrentUser(string username = default(string), string displayName = default(string), string userIcon = default(string), string bio = default(string), List<string> bioLinks = default(List<string>), string profilePicOverride = default(string), string statusDescription = default(string), List<string> pastDisplayNames = default(List<string>), bool hasEmail = default(bool), bool hasPendingEmail = default(bool), string obfuscatedEmail = default(string), string obfuscatedPendingEmail = default(string), bool emailVerified = default(bool), bool hasBirthday = default(bool), bool unsubscribe = default(bool), List<string> statusHistory = default(List<string>), bool statusFirstTime = default(bool), List<string> friends = default(List<string>), List<string> friendGroupNames = default(List<string>), string currentAvatarImageUrl = default(string), string currentAvatarThumbnailImageUrl = default(string), string fallbackAvatar = default(string), string currentAvatar = default(string), string currentAvatarAssetUrl = default(string), DateTime? accountDeletionDate = default(DateTime?), decimal acceptedTOSVersion = default(decimal), string steamId = default(string), Object steamDetails = default(Object), string oculusId = default(string), bool hasLoggedInFromClient = default(bool), string homeLocation = default(string), bool twoFactorAuthEnabled = default(bool), UserState state = default(UserState), List<string> tags = default(List<string>), DeveloperType developerType = default(DeveloperType), DateTime lastLogin = default(DateTime), Platform lastPlatform = default(Platform), bool allowAvatarCopying = default(bool), UserStatus status = default(UserStatus), bool isFriend = false, string friendKey = default(string), List<string> onlineFriends = default(List<string>), List<string> activeFriends = default(List<string>), List<string> offlineFriends = default(List<string>))
        {
            // to ensure "username" is required (not null)
            if (username == null)
            {
                throw new InvalidDataException("username is a required property for CurrentUser and cannot be null");
            }
            else
            {
                this.Username = username;
            }

            // to ensure "displayName" is required (not null)
            if (displayName == null)
            {
                throw new InvalidDataException("displayName is a required property for CurrentUser and cannot be null");
            }
            else
            {
                this.DisplayName = displayName;
            }

            // to ensure "userIcon" is required (not null)
            if (userIcon == null)
            {
                throw new InvalidDataException("userIcon is a required property for CurrentUser and cannot be null");
            }
            else
            {
                this.UserIcon = userIcon;
            }

            // to ensure "bio" is required (not null)
            if (bio == null)
            {
                throw new InvalidDataException("bio is a required property for CurrentUser and cannot be null");
            }
            else
            {
                this.Bio = bio;
            }

            // to ensure "bioLinks" is required (not null)
            if (bioLinks == null)
            {
                throw new InvalidDataException("bioLinks is a required property for CurrentUser and cannot be null");
            }
            else
            {
                this.BioLinks = bioLinks;
            }

            // to ensure "profilePicOverride" is required (not null)
            if (profilePicOverride == null)
            {
                throw new InvalidDataException("profilePicOverride is a required property for CurrentUser and cannot be null");
            }
            else
            {
                this.ProfilePicOverride = profilePicOverride;
            }

            // to ensure "statusDescription" is required (not null)
            if (statusDescription == null)
            {
                throw new InvalidDataException("statusDescription is a required property for CurrentUser and cannot be null");
            }
            else
            {
                this.StatusDescription = statusDescription;
            }

            // to ensure "pastDisplayNames" is required (not null)
            if (pastDisplayNames == null)
            {
                throw new InvalidDataException("pastDisplayNames is a required property for CurrentUser and cannot be null");
            }
            else
            {
                this.PastDisplayNames = pastDisplayNames;
            }

            // to ensure "hasEmail" is required (not null)
            if (hasEmail == null)
            {
                throw new InvalidDataException("hasEmail is a required property for CurrentUser and cannot be null");
            }
            else
            {
                this.HasEmail = hasEmail;
            }

            // to ensure "hasPendingEmail" is required (not null)
            if (hasPendingEmail == null)
            {
                throw new InvalidDataException("hasPendingEmail is a required property for CurrentUser and cannot be null");
            }
            else
            {
                this.HasPendingEmail = hasPendingEmail;
            }

            // to ensure "obfuscatedEmail" is required (not null)
            if (obfuscatedEmail == null)
            {
                throw new InvalidDataException("obfuscatedEmail is a required property for CurrentUser and cannot be null");
            }
            else
            {
                this.ObfuscatedEmail = obfuscatedEmail;
            }

            // to ensure "obfuscatedPendingEmail" is required (not null)
            if (obfuscatedPendingEmail == null)
            {
                throw new InvalidDataException("obfuscatedPendingEmail is a required property for CurrentUser and cannot be null");
            }
            else
            {
                this.ObfuscatedPendingEmail = obfuscatedPendingEmail;
            }

            // to ensure "emailVerified" is required (not null)
            if (emailVerified == null)
            {
                throw new InvalidDataException("emailVerified is a required property for CurrentUser and cannot be null");
            }
            else
            {
                this.EmailVerified = emailVerified;
            }

            // to ensure "hasBirthday" is required (not null)
            if (hasBirthday == null)
            {
                throw new InvalidDataException("hasBirthday is a required property for CurrentUser and cannot be null");
            }
            else
            {
                this.HasBirthday = hasBirthday;
            }

            // to ensure "unsubscribe" is required (not null)
            if (unsubscribe == null)
            {
                throw new InvalidDataException("unsubscribe is a required property for CurrentUser and cannot be null");
            }
            else
            {
                this.Unsubscribe = unsubscribe;
            }

            // to ensure "statusHistory" is required (not null)
            if (statusHistory == null)
            {
                throw new InvalidDataException("statusHistory is a required property for CurrentUser and cannot be null");
            }
            else
            {
                this.StatusHistory = statusHistory;
            }

            // to ensure "statusFirstTime" is required (not null)
            if (statusFirstTime == null)
            {
                throw new InvalidDataException("statusFirstTime is a required property for CurrentUser and cannot be null");
            }
            else
            {
                this.StatusFirstTime = statusFirstTime;
            }

            // to ensure "friends" is required (not null)
            if (friends == null)
            {
                throw new InvalidDataException("friends is a required property for CurrentUser and cannot be null");
            }
            else
            {
                this.Friends = friends;
            }

            // to ensure "friendGroupNames" is required (not null)
            if (friendGroupNames == null)
            {
                throw new InvalidDataException("friendGroupNames is a required property for CurrentUser and cannot be null");
            }
            else
            {
                this.FriendGroupNames = friendGroupNames;
            }

            // to ensure "currentAvatarImageUrl" is required (not null)
            if (currentAvatarImageUrl == null)
            {
                throw new InvalidDataException("currentAvatarImageUrl is a required property for CurrentUser and cannot be null");
            }
            else
            {
                this.CurrentAvatarImageUrl = currentAvatarImageUrl;
            }

            // to ensure "currentAvatarThumbnailImageUrl" is required (not null)
            if (currentAvatarThumbnailImageUrl == null)
            {
                throw new InvalidDataException("currentAvatarThumbnailImageUrl is a required property for CurrentUser and cannot be null");
            }
            else
            {
                this.CurrentAvatarThumbnailImageUrl = currentAvatarThumbnailImageUrl;
            }

            // to ensure "fallbackAvatar" is required (not null)
            if (fallbackAvatar == null)
            {
                throw new InvalidDataException("fallbackAvatar is a required property for CurrentUser and cannot be null");
            }
            else
            {
                this.FallbackAvatar = fallbackAvatar;
            }

            // to ensure "currentAvatar" is required (not null)
            if (currentAvatar == null)
            {
                throw new InvalidDataException("currentAvatar is a required property for CurrentUser and cannot be null");
            }
            else
            {
                this.CurrentAvatar = currentAvatar;
            }

            // to ensure "currentAvatarAssetUrl" is required (not null)
            if (currentAvatarAssetUrl == null)
            {
                throw new InvalidDataException("currentAvatarAssetUrl is a required property for CurrentUser and cannot be null");
            }
            else
            {
                this.CurrentAvatarAssetUrl = currentAvatarAssetUrl;
            }

            this.AccountDeletionDate = accountDeletionDate;
            // to ensure "acceptedTOSVersion" is required (not null)
            if (acceptedTOSVersion == null)
            {
                throw new InvalidDataException("acceptedTOSVersion is a required property for CurrentUser and cannot be null");
            }
            else
            {
                this.AcceptedTOSVersion = acceptedTOSVersion;
            }

            // to ensure "steamId" is required (not null)
            if (steamId == null)
            {
                throw new InvalidDataException("steamId is a required property for CurrentUser and cannot be null");
            }
            else
            {
                this.SteamId = steamId;
            }

            // to ensure "steamDetails" is required (not null)
            if (steamDetails == null)
            {
                throw new InvalidDataException("steamDetails is a required property for CurrentUser and cannot be null");
            }
            else
            {
                this.SteamDetails = steamDetails;
            }

            // to ensure "oculusId" is required (not null)
            if (oculusId == null)
            {
                throw new InvalidDataException("oculusId is a required property for CurrentUser and cannot be null");
            }
            else
            {
                this.OculusId = oculusId;
            }

            // to ensure "hasLoggedInFromClient" is required (not null)
            if (hasLoggedInFromClient == null)
            {
                throw new InvalidDataException("hasLoggedInFromClient is a required property for CurrentUser and cannot be null");
            }
            else
            {
                this.HasLoggedInFromClient = hasLoggedInFromClient;
            }

            // to ensure "homeLocation" is required (not null)
            if (homeLocation == null)
            {
                throw new InvalidDataException("homeLocation is a required property for CurrentUser and cannot be null");
            }
            else
            {
                this.HomeLocation = homeLocation;
            }

            // to ensure "twoFactorAuthEnabled" is required (not null)
            if (twoFactorAuthEnabled == null)
            {
                throw new InvalidDataException("twoFactorAuthEnabled is a required property for CurrentUser and cannot be null");
            }
            else
            {
                this.TwoFactorAuthEnabled = twoFactorAuthEnabled;
            }

            // to ensure "state" is required (not null)
            if (state == null)
            {
                throw new InvalidDataException("state is a required property for CurrentUser and cannot be null");
            }
            else
            {
                this.State = state;
            }

            // to ensure "tags" is required (not null)
            if (tags == null)
            {
                throw new InvalidDataException("tags is a required property for CurrentUser and cannot be null");
            }
            else
            {
                this.Tags = tags;
            }

            // to ensure "developerType" is required (not null)
            if (developerType == null)
            {
                throw new InvalidDataException("developerType is a required property for CurrentUser and cannot be null");
            }
            else
            {
                this.DeveloperType = developerType;
            }

            // to ensure "lastLogin" is required (not null)
            if (lastLogin == null)
            {
                throw new InvalidDataException("lastLogin is a required property for CurrentUser and cannot be null");
            }
            else
            {
                this.LastLogin = lastLogin;
            }

            // to ensure "lastPlatform" is required (not null)
            if (lastPlatform == null)
            {
                throw new InvalidDataException("lastPlatform is a required property for CurrentUser and cannot be null");
            }
            else
            {
                this.LastPlatform = lastPlatform;
            }

            // to ensure "allowAvatarCopying" is required (not null)
            if (allowAvatarCopying == null)
            {
                throw new InvalidDataException("allowAvatarCopying is a required property for CurrentUser and cannot be null");
            }
            else
            {
                this.AllowAvatarCopying = allowAvatarCopying;
            }

            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new InvalidDataException("status is a required property for CurrentUser and cannot be null");
            }
            else
            {
                this.Status = status;
            }

            // to ensure "isFriend" is required (not null)
            if (isFriend == null)
            {
                throw new InvalidDataException("isFriend is a required property for CurrentUser and cannot be null");
            }
            else
            {
                this.IsFriend = isFriend;
            }

            // to ensure "friendKey" is required (not null)
            if (friendKey == null)
            {
                throw new InvalidDataException("friendKey is a required property for CurrentUser and cannot be null");
            }
            else
            {
                this.FriendKey = friendKey;
            }

            this.AccountDeletionDate = accountDeletionDate;
            this.OnlineFriends = onlineFriends;
            this.ActiveFriends = activeFriends;
            this.OfflineFriends = offlineFriends;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public string Id { get; private set; }

        /// <summary>
        /// Gets or Sets Username
        /// </summary>
        [DataMember(Name="username", EmitDefaultValue=true)]
        public string Username { get; set; }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name="displayName", EmitDefaultValue=true)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets UserIcon
        /// </summary>
        [DataMember(Name="userIcon", EmitDefaultValue=true)]
        public string UserIcon { get; set; }

        /// <summary>
        /// Gets or Sets Bio
        /// </summary>
        [DataMember(Name="bio", EmitDefaultValue=true)]
        public string Bio { get; set; }

        /// <summary>
        /// Gets or Sets BioLinks
        /// </summary>
        [DataMember(Name="bioLinks", EmitDefaultValue=true)]
        public List<string> BioLinks { get; set; }

        /// <summary>
        /// Gets or Sets ProfilePicOverride
        /// </summary>
        [DataMember(Name="profilePicOverride", EmitDefaultValue=true)]
        public string ProfilePicOverride { get; set; }

        /// <summary>
        /// Gets or Sets StatusDescription
        /// </summary>
        [DataMember(Name="statusDescription", EmitDefaultValue=true)]
        public string StatusDescription { get; set; }

        /// <summary>
        /// Gets or Sets PastDisplayNames
        /// </summary>
        [DataMember(Name="pastDisplayNames", EmitDefaultValue=true)]
        public List<string> PastDisplayNames { get; set; }

        /// <summary>
        /// Gets or Sets HasEmail
        /// </summary>
        [DataMember(Name="hasEmail", EmitDefaultValue=true)]
        public bool HasEmail { get; set; }

        /// <summary>
        /// Gets or Sets HasPendingEmail
        /// </summary>
        [DataMember(Name="hasPendingEmail", EmitDefaultValue=true)]
        public bool HasPendingEmail { get; set; }

        /// <summary>
        /// Gets or Sets ObfuscatedEmail
        /// </summary>
        [DataMember(Name="obfuscatedEmail", EmitDefaultValue=true)]
        public string ObfuscatedEmail { get; set; }

        /// <summary>
        /// Gets or Sets ObfuscatedPendingEmail
        /// </summary>
        [DataMember(Name="obfuscatedPendingEmail", EmitDefaultValue=true)]
        public string ObfuscatedPendingEmail { get; set; }

        /// <summary>
        /// Gets or Sets EmailVerified
        /// </summary>
        [DataMember(Name="emailVerified", EmitDefaultValue=true)]
        public bool EmailVerified { get; set; }

        /// <summary>
        /// Gets or Sets HasBirthday
        /// </summary>
        [DataMember(Name="hasBirthday", EmitDefaultValue=true)]
        public bool HasBirthday { get; set; }

        /// <summary>
        /// Gets or Sets Unsubscribe
        /// </summary>
        [DataMember(Name="unsubscribe", EmitDefaultValue=true)]
        public bool Unsubscribe { get; set; }

        /// <summary>
        /// Gets or Sets StatusHistory
        /// </summary>
        [DataMember(Name="statusHistory", EmitDefaultValue=true)]
        public List<string> StatusHistory { get; set; }

        /// <summary>
        /// Gets or Sets StatusFirstTime
        /// </summary>
        [DataMember(Name="statusFirstTime", EmitDefaultValue=true)]
        public bool StatusFirstTime { get; set; }

        /// <summary>
        /// Gets or Sets Friends
        /// </summary>
        [DataMember(Name="friends", EmitDefaultValue=true)]
        public List<string> Friends { get; set; }

        /// <summary>
        /// Always empty array.
        /// </summary>
        /// <value>Always empty array.</value>
        [DataMember(Name="friendGroupNames", EmitDefaultValue=true)]
        public List<string> FriendGroupNames { get; set; }

        /// <summary>
        /// Gets or Sets CurrentAvatarImageUrl
        /// </summary>
        [DataMember(Name="currentAvatarImageUrl", EmitDefaultValue=true)]
        public string CurrentAvatarImageUrl { get; set; }

        /// <summary>
        /// Gets or Sets CurrentAvatarThumbnailImageUrl
        /// </summary>
        [DataMember(Name="currentAvatarThumbnailImageUrl", EmitDefaultValue=true)]
        public string CurrentAvatarThumbnailImageUrl { get; set; }

        /// <summary>
        /// Gets or Sets FallbackAvatar
        /// </summary>
        [DataMember(Name="fallbackAvatar", EmitDefaultValue=true)]
        public string FallbackAvatar { get; set; }

        /// <summary>
        /// Gets or Sets CurrentAvatar
        /// </summary>
        [DataMember(Name="currentAvatar", EmitDefaultValue=true)]
        public string CurrentAvatar { get; set; }

        /// <summary>
        /// Gets or Sets CurrentAvatarAssetUrl
        /// </summary>
        [DataMember(Name="currentAvatarAssetUrl", EmitDefaultValue=true)]
        public string CurrentAvatarAssetUrl { get; set; }

        /// <summary>
        /// Gets or Sets AccountDeletionDate
        /// </summary>
        [DataMember(Name="accountDeletionDate", EmitDefaultValue=true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? AccountDeletionDate { get; set; }

        /// <summary>
        /// Gets or Sets AcceptedTOSVersion
        /// </summary>
        [DataMember(Name="acceptedTOSVersion", EmitDefaultValue=true)]
        public decimal AcceptedTOSVersion { get; set; }

        /// <summary>
        /// Gets or Sets SteamId
        /// </summary>
        [DataMember(Name="steamId", EmitDefaultValue=true)]
        public string SteamId { get; set; }

        /// <summary>
        /// Gets or Sets SteamDetails
        /// </summary>
        [DataMember(Name="steamDetails", EmitDefaultValue=true)]
        public Object SteamDetails { get; set; }

        /// <summary>
        /// Gets or Sets OculusId
        /// </summary>
        [DataMember(Name="oculusId", EmitDefaultValue=true)]
        public string OculusId { get; set; }

        /// <summary>
        /// Gets or Sets HasLoggedInFromClient
        /// </summary>
        [DataMember(Name="hasLoggedInFromClient", EmitDefaultValue=true)]
        public bool HasLoggedInFromClient { get; set; }

        /// <summary>
        /// Gets or Sets HomeLocation
        /// </summary>
        [DataMember(Name="homeLocation", EmitDefaultValue=true)]
        public string HomeLocation { get; set; }

        /// <summary>
        /// Gets or Sets TwoFactorAuthEnabled
        /// </summary>
        [DataMember(Name="twoFactorAuthEnabled", EmitDefaultValue=true)]
        public bool TwoFactorAuthEnabled { get; set; }


        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name="tags", EmitDefaultValue=true)]
        public List<string> Tags { get; set; }


        /// <summary>
        /// Gets or Sets LastLogin
        /// </summary>
        [DataMember(Name="last_login", EmitDefaultValue=true)]
        public DateTime LastLogin { get; set; }


        /// <summary>
        /// Gets or Sets AllowAvatarCopying
        /// </summary>
        [DataMember(Name="allowAvatarCopying", EmitDefaultValue=true)]
        public bool AllowAvatarCopying { get; set; }


        /// <summary>
        /// Gets or Sets DateJoined
        /// </summary>
        [DataMember(Name="date_joined", EmitDefaultValue=true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime DateJoined { get; private set; }

        /// <summary>
        /// Gets or Sets IsFriend
        /// </summary>
        [DataMember(Name="isFriend", EmitDefaultValue=true)]
        public bool IsFriend { get; set; }

        /// <summary>
        /// Gets or Sets FriendKey
        /// </summary>
        [DataMember(Name="friendKey", EmitDefaultValue=true)]
        public string FriendKey { get; set; }

        /// <summary>
        /// Gets or Sets OnlineFriends
        /// </summary>
        [DataMember(Name="onlineFriends", EmitDefaultValue=false)]
        public List<string> OnlineFriends { get; set; }

        /// <summary>
        /// Gets or Sets ActiveFriends
        /// </summary>
        [DataMember(Name="activeFriends", EmitDefaultValue=false)]
        public List<string> ActiveFriends { get; set; }

        /// <summary>
        /// Gets or Sets OfflineFriends
        /// </summary>
        [DataMember(Name="offlineFriends", EmitDefaultValue=false)]
        public List<string> OfflineFriends { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CurrentUser {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  UserIcon: ").Append(UserIcon).Append("\n");
            sb.Append("  Bio: ").Append(Bio).Append("\n");
            sb.Append("  BioLinks: ").Append(BioLinks).Append("\n");
            sb.Append("  ProfilePicOverride: ").Append(ProfilePicOverride).Append("\n");
            sb.Append("  StatusDescription: ").Append(StatusDescription).Append("\n");
            sb.Append("  PastDisplayNames: ").Append(PastDisplayNames).Append("\n");
            sb.Append("  HasEmail: ").Append(HasEmail).Append("\n");
            sb.Append("  HasPendingEmail: ").Append(HasPendingEmail).Append("\n");
            sb.Append("  ObfuscatedEmail: ").Append(ObfuscatedEmail).Append("\n");
            sb.Append("  ObfuscatedPendingEmail: ").Append(ObfuscatedPendingEmail).Append("\n");
            sb.Append("  EmailVerified: ").Append(EmailVerified).Append("\n");
            sb.Append("  HasBirthday: ").Append(HasBirthday).Append("\n");
            sb.Append("  Unsubscribe: ").Append(Unsubscribe).Append("\n");
            sb.Append("  StatusHistory: ").Append(StatusHistory).Append("\n");
            sb.Append("  StatusFirstTime: ").Append(StatusFirstTime).Append("\n");
            sb.Append("  Friends: ").Append(Friends).Append("\n");
            sb.Append("  FriendGroupNames: ").Append(FriendGroupNames).Append("\n");
            sb.Append("  CurrentAvatarImageUrl: ").Append(CurrentAvatarImageUrl).Append("\n");
            sb.Append("  CurrentAvatarThumbnailImageUrl: ").Append(CurrentAvatarThumbnailImageUrl).Append("\n");
            sb.Append("  FallbackAvatar: ").Append(FallbackAvatar).Append("\n");
            sb.Append("  CurrentAvatar: ").Append(CurrentAvatar).Append("\n");
            sb.Append("  CurrentAvatarAssetUrl: ").Append(CurrentAvatarAssetUrl).Append("\n");
            sb.Append("  AccountDeletionDate: ").Append(AccountDeletionDate).Append("\n");
            sb.Append("  AcceptedTOSVersion: ").Append(AcceptedTOSVersion).Append("\n");
            sb.Append("  SteamId: ").Append(SteamId).Append("\n");
            sb.Append("  SteamDetails: ").Append(SteamDetails).Append("\n");
            sb.Append("  OculusId: ").Append(OculusId).Append("\n");
            sb.Append("  HasLoggedInFromClient: ").Append(HasLoggedInFromClient).Append("\n");
            sb.Append("  HomeLocation: ").Append(HomeLocation).Append("\n");
            sb.Append("  TwoFactorAuthEnabled: ").Append(TwoFactorAuthEnabled).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  DeveloperType: ").Append(DeveloperType).Append("\n");
            sb.Append("  LastLogin: ").Append(LastLogin).Append("\n");
            sb.Append("  LastPlatform: ").Append(LastPlatform).Append("\n");
            sb.Append("  AllowAvatarCopying: ").Append(AllowAvatarCopying).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  DateJoined: ").Append(DateJoined).Append("\n");
            sb.Append("  IsFriend: ").Append(IsFriend).Append("\n");
            sb.Append("  FriendKey: ").Append(FriendKey).Append("\n");
            sb.Append("  OnlineFriends: ").Append(OnlineFriends).Append("\n");
            sb.Append("  ActiveFriends: ").Append(ActiveFriends).Append("\n");
            sb.Append("  OfflineFriends: ").Append(OfflineFriends).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as CurrentUser);
        }

        /// <summary>
        /// Returns true if CurrentUser instances are equal
        /// </summary>
        /// <param name="input">Instance of CurrentUser to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CurrentUser input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.UserIcon == input.UserIcon ||
                    (this.UserIcon != null &&
                    this.UserIcon.Equals(input.UserIcon))
                ) && 
                (
                    this.Bio == input.Bio ||
                    (this.Bio != null &&
                    this.Bio.Equals(input.Bio))
                ) && 
                (
                    this.BioLinks == input.BioLinks ||
                    this.BioLinks != null &&
                    input.BioLinks != null &&
                    this.BioLinks.SequenceEqual(input.BioLinks)
                ) && 
                (
                    this.ProfilePicOverride == input.ProfilePicOverride ||
                    (this.ProfilePicOverride != null &&
                    this.ProfilePicOverride.Equals(input.ProfilePicOverride))
                ) && 
                (
                    this.StatusDescription == input.StatusDescription ||
                    (this.StatusDescription != null &&
                    this.StatusDescription.Equals(input.StatusDescription))
                ) && 
                (
                    this.PastDisplayNames == input.PastDisplayNames ||
                    this.PastDisplayNames != null &&
                    input.PastDisplayNames != null &&
                    this.PastDisplayNames.SequenceEqual(input.PastDisplayNames)
                ) && 
                (
                    this.HasEmail == input.HasEmail ||
                    (this.HasEmail != null &&
                    this.HasEmail.Equals(input.HasEmail))
                ) && 
                (
                    this.HasPendingEmail == input.HasPendingEmail ||
                    (this.HasPendingEmail != null &&
                    this.HasPendingEmail.Equals(input.HasPendingEmail))
                ) && 
                (
                    this.ObfuscatedEmail == input.ObfuscatedEmail ||
                    (this.ObfuscatedEmail != null &&
                    this.ObfuscatedEmail.Equals(input.ObfuscatedEmail))
                ) && 
                (
                    this.ObfuscatedPendingEmail == input.ObfuscatedPendingEmail ||
                    (this.ObfuscatedPendingEmail != null &&
                    this.ObfuscatedPendingEmail.Equals(input.ObfuscatedPendingEmail))
                ) && 
                (
                    this.EmailVerified == input.EmailVerified ||
                    (this.EmailVerified != null &&
                    this.EmailVerified.Equals(input.EmailVerified))
                ) && 
                (
                    this.HasBirthday == input.HasBirthday ||
                    (this.HasBirthday != null &&
                    this.HasBirthday.Equals(input.HasBirthday))
                ) && 
                (
                    this.Unsubscribe == input.Unsubscribe ||
                    (this.Unsubscribe != null &&
                    this.Unsubscribe.Equals(input.Unsubscribe))
                ) && 
                (
                    this.StatusHistory == input.StatusHistory ||
                    this.StatusHistory != null &&
                    input.StatusHistory != null &&
                    this.StatusHistory.SequenceEqual(input.StatusHistory)
                ) && 
                (
                    this.StatusFirstTime == input.StatusFirstTime ||
                    (this.StatusFirstTime != null &&
                    this.StatusFirstTime.Equals(input.StatusFirstTime))
                ) && 
                (
                    this.Friends == input.Friends ||
                    this.Friends != null &&
                    input.Friends != null &&
                    this.Friends.SequenceEqual(input.Friends)
                ) && 
                (
                    this.FriendGroupNames == input.FriendGroupNames ||
                    this.FriendGroupNames != null &&
                    input.FriendGroupNames != null &&
                    this.FriendGroupNames.SequenceEqual(input.FriendGroupNames)
                ) && 
                (
                    this.CurrentAvatarImageUrl == input.CurrentAvatarImageUrl ||
                    (this.CurrentAvatarImageUrl != null &&
                    this.CurrentAvatarImageUrl.Equals(input.CurrentAvatarImageUrl))
                ) && 
                (
                    this.CurrentAvatarThumbnailImageUrl == input.CurrentAvatarThumbnailImageUrl ||
                    (this.CurrentAvatarThumbnailImageUrl != null &&
                    this.CurrentAvatarThumbnailImageUrl.Equals(input.CurrentAvatarThumbnailImageUrl))
                ) && 
                (
                    this.FallbackAvatar == input.FallbackAvatar ||
                    (this.FallbackAvatar != null &&
                    this.FallbackAvatar.Equals(input.FallbackAvatar))
                ) && 
                (
                    this.CurrentAvatar == input.CurrentAvatar ||
                    (this.CurrentAvatar != null &&
                    this.CurrentAvatar.Equals(input.CurrentAvatar))
                ) && 
                (
                    this.CurrentAvatarAssetUrl == input.CurrentAvatarAssetUrl ||
                    (this.CurrentAvatarAssetUrl != null &&
                    this.CurrentAvatarAssetUrl.Equals(input.CurrentAvatarAssetUrl))
                ) && 
                (
                    this.AccountDeletionDate == input.AccountDeletionDate ||
                    (this.AccountDeletionDate != null &&
                    this.AccountDeletionDate.Equals(input.AccountDeletionDate))
                ) && 
                (
                    this.AcceptedTOSVersion == input.AcceptedTOSVersion ||
                    (this.AcceptedTOSVersion != null &&
                    this.AcceptedTOSVersion.Equals(input.AcceptedTOSVersion))
                ) && 
                (
                    this.SteamId == input.SteamId ||
                    (this.SteamId != null &&
                    this.SteamId.Equals(input.SteamId))
                ) && 
                (
                    this.SteamDetails == input.SteamDetails ||
                    (this.SteamDetails != null &&
                    this.SteamDetails.Equals(input.SteamDetails))
                ) && 
                (
                    this.OculusId == input.OculusId ||
                    (this.OculusId != null &&
                    this.OculusId.Equals(input.OculusId))
                ) && 
                (
                    this.HasLoggedInFromClient == input.HasLoggedInFromClient ||
                    (this.HasLoggedInFromClient != null &&
                    this.HasLoggedInFromClient.Equals(input.HasLoggedInFromClient))
                ) && 
                (
                    this.HomeLocation == input.HomeLocation ||
                    (this.HomeLocation != null &&
                    this.HomeLocation.Equals(input.HomeLocation))
                ) && 
                (
                    this.TwoFactorAuthEnabled == input.TwoFactorAuthEnabled ||
                    (this.TwoFactorAuthEnabled != null &&
                    this.TwoFactorAuthEnabled.Equals(input.TwoFactorAuthEnabled))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.DeveloperType == input.DeveloperType ||
                    (this.DeveloperType != null &&
                    this.DeveloperType.Equals(input.DeveloperType))
                ) && 
                (
                    this.LastLogin == input.LastLogin ||
                    (this.LastLogin != null &&
                    this.LastLogin.Equals(input.LastLogin))
                ) && 
                (
                    this.LastPlatform == input.LastPlatform ||
                    (this.LastPlatform != null &&
                    this.LastPlatform.Equals(input.LastPlatform))
                ) && 
                (
                    this.AllowAvatarCopying == input.AllowAvatarCopying ||
                    (this.AllowAvatarCopying != null &&
                    this.AllowAvatarCopying.Equals(input.AllowAvatarCopying))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.DateJoined == input.DateJoined ||
                    (this.DateJoined != null &&
                    this.DateJoined.Equals(input.DateJoined))
                ) && 
                (
                    this.IsFriend == input.IsFriend ||
                    (this.IsFriend != null &&
                    this.IsFriend.Equals(input.IsFriend))
                ) && 
                (
                    this.FriendKey == input.FriendKey ||
                    (this.FriendKey != null &&
                    this.FriendKey.Equals(input.FriendKey))
                ) && 
                (
                    this.OnlineFriends == input.OnlineFriends ||
                    this.OnlineFriends != null &&
                    input.OnlineFriends != null &&
                    this.OnlineFriends.SequenceEqual(input.OnlineFriends)
                ) && 
                (
                    this.ActiveFriends == input.ActiveFriends ||
                    this.ActiveFriends != null &&
                    input.ActiveFriends != null &&
                    this.ActiveFriends.SequenceEqual(input.ActiveFriends)
                ) && 
                (
                    this.OfflineFriends == input.OfflineFriends ||
                    this.OfflineFriends != null &&
                    input.OfflineFriends != null &&
                    this.OfflineFriends.SequenceEqual(input.OfflineFriends)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.UserIcon != null)
                    hashCode = hashCode * 59 + this.UserIcon.GetHashCode();
                if (this.Bio != null)
                    hashCode = hashCode * 59 + this.Bio.GetHashCode();
                if (this.BioLinks != null)
                    hashCode = hashCode * 59 + this.BioLinks.GetHashCode();
                if (this.ProfilePicOverride != null)
                    hashCode = hashCode * 59 + this.ProfilePicOverride.GetHashCode();
                if (this.StatusDescription != null)
                    hashCode = hashCode * 59 + this.StatusDescription.GetHashCode();
                if (this.PastDisplayNames != null)
                    hashCode = hashCode * 59 + this.PastDisplayNames.GetHashCode();
                if (this.HasEmail != null)
                    hashCode = hashCode * 59 + this.HasEmail.GetHashCode();
                if (this.HasPendingEmail != null)
                    hashCode = hashCode * 59 + this.HasPendingEmail.GetHashCode();
                if (this.ObfuscatedEmail != null)
                    hashCode = hashCode * 59 + this.ObfuscatedEmail.GetHashCode();
                if (this.ObfuscatedPendingEmail != null)
                    hashCode = hashCode * 59 + this.ObfuscatedPendingEmail.GetHashCode();
                if (this.EmailVerified != null)
                    hashCode = hashCode * 59 + this.EmailVerified.GetHashCode();
                if (this.HasBirthday != null)
                    hashCode = hashCode * 59 + this.HasBirthday.GetHashCode();
                if (this.Unsubscribe != null)
                    hashCode = hashCode * 59 + this.Unsubscribe.GetHashCode();
                if (this.StatusHistory != null)
                    hashCode = hashCode * 59 + this.StatusHistory.GetHashCode();
                if (this.StatusFirstTime != null)
                    hashCode = hashCode * 59 + this.StatusFirstTime.GetHashCode();
                if (this.Friends != null)
                    hashCode = hashCode * 59 + this.Friends.GetHashCode();
                if (this.FriendGroupNames != null)
                    hashCode = hashCode * 59 + this.FriendGroupNames.GetHashCode();
                if (this.CurrentAvatarImageUrl != null)
                    hashCode = hashCode * 59 + this.CurrentAvatarImageUrl.GetHashCode();
                if (this.CurrentAvatarThumbnailImageUrl != null)
                    hashCode = hashCode * 59 + this.CurrentAvatarThumbnailImageUrl.GetHashCode();
                if (this.FallbackAvatar != null)
                    hashCode = hashCode * 59 + this.FallbackAvatar.GetHashCode();
                if (this.CurrentAvatar != null)
                    hashCode = hashCode * 59 + this.CurrentAvatar.GetHashCode();
                if (this.CurrentAvatarAssetUrl != null)
                    hashCode = hashCode * 59 + this.CurrentAvatarAssetUrl.GetHashCode();
                if (this.AccountDeletionDate != null)
                    hashCode = hashCode * 59 + this.AccountDeletionDate.GetHashCode();
                if (this.AcceptedTOSVersion != null)
                    hashCode = hashCode * 59 + this.AcceptedTOSVersion.GetHashCode();
                if (this.SteamId != null)
                    hashCode = hashCode * 59 + this.SteamId.GetHashCode();
                if (this.SteamDetails != null)
                    hashCode = hashCode * 59 + this.SteamDetails.GetHashCode();
                if (this.OculusId != null)
                    hashCode = hashCode * 59 + this.OculusId.GetHashCode();
                if (this.HasLoggedInFromClient != null)
                    hashCode = hashCode * 59 + this.HasLoggedInFromClient.GetHashCode();
                if (this.HomeLocation != null)
                    hashCode = hashCode * 59 + this.HomeLocation.GetHashCode();
                if (this.TwoFactorAuthEnabled != null)
                    hashCode = hashCode * 59 + this.TwoFactorAuthEnabled.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.DeveloperType != null)
                    hashCode = hashCode * 59 + this.DeveloperType.GetHashCode();
                if (this.LastLogin != null)
                    hashCode = hashCode * 59 + this.LastLogin.GetHashCode();
                if (this.LastPlatform != null)
                    hashCode = hashCode * 59 + this.LastPlatform.GetHashCode();
                if (this.AllowAvatarCopying != null)
                    hashCode = hashCode * 59 + this.AllowAvatarCopying.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.DateJoined != null)
                    hashCode = hashCode * 59 + this.DateJoined.GetHashCode();
                if (this.IsFriend != null)
                    hashCode = hashCode * 59 + this.IsFriend.GetHashCode();
                if (this.FriendKey != null)
                    hashCode = hashCode * 59 + this.FriendKey.GetHashCode();
                if (this.OnlineFriends != null)
                    hashCode = hashCode * 59 + this.OnlineFriends.GetHashCode();
                if (this.ActiveFriends != null)
                    hashCode = hashCode * 59 + this.ActiveFriends.GetHashCode();
                if (this.OfflineFriends != null)
                    hashCode = hashCode * 59 + this.OfflineFriends.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {

 
            // FallbackAvatar (string) pattern
            Regex regexFallbackAvatar = new Regex(@"avtr_[0-9a-fA-F]{8}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{12}", RegexOptions.CultureInvariant);
            if (false == regexFallbackAvatar.Match(this.FallbackAvatar).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FallbackAvatar, must match a pattern of " + regexFallbackAvatar, new [] { "FallbackAvatar" });
            }


 
            // CurrentAvatar (string) pattern
            Regex regexCurrentAvatar = new Regex(@"avtr_[0-9a-fA-F]{8}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{12}", RegexOptions.CultureInvariant);
            if (false == regexCurrentAvatar.Match(this.CurrentAvatar).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CurrentAvatar, must match a pattern of " + regexCurrentAvatar, new [] { "CurrentAvatar" });
            }


 
            // HomeLocation (string) pattern
            Regex regexHomeLocation = new Regex(@"(^$|offline|(wrld|wld)_[0-9a-fA-F]{8}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{12})", RegexOptions.CultureInvariant);
            if (false == regexHomeLocation.Match(this.HomeLocation).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for HomeLocation, must match a pattern of " + regexHomeLocation, new [] { "HomeLocation" });
            }

            yield break;
        }
    }

}
