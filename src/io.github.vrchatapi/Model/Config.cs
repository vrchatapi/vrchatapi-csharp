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
    /// Config
    /// </summary>
    [DataContract]
    public partial class Config :  IEquatable<Config>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets DeploymentGroup
        /// </summary>
        [DataMember(Name="deploymentGroup", EmitDefaultValue=true)]
        public DeploymentGroup DeploymentGroup { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Config" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Config() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Config" /> class.
        /// </summary>
        /// <param name="clientBPSCeiling">Unknown.</param>
        /// <param name="clientDisconnectTimeout">Unknown.</param>
        /// <param name="clientReservedPlayerBPS">Unknown.</param>
        /// <param name="clientSentCountAllowance">Unknown.</param>
        /// <param name="defaultAvatar">defaultAvatar (required).</param>
        /// <param name="deploymentGroup">deploymentGroup (required).</param>
        /// <param name="disableAvatarCopying">Toggles if copying avatars should be disabled (required) (default to false).</param>
        /// <param name="disableAvatarGating">Toggles if avatar gating should be disabled. Avatar gating restricts uploading of avatars to people with the &#x60;system_avatar_access&#x60; Tag or &#x60;admin_avatar_access&#x60; Tag (required) (default to false).</param>
        /// <param name="disableCommunityLabs">Toggles if the Community Labs should be disabled (required) (default to false).</param>
        /// <param name="disableCommunityLabsPromotion">Toggles if promotion out of Community Labs should be disabled (required) (default to false).</param>
        /// <param name="disableEmail">Unknown (default to false).</param>
        /// <param name="disableEventStream">Toggles if Analytics should be disabled (this sreportedly not used in the Client) (required) (default to false).</param>
        /// <param name="disableFeedbackGating">Toggles if feedback gating should be disabled. Feedback gating restricts submission of feedback (reporting a World or User) to people with the &#x60;system_feedback_access&#x60; Tag. (required) (default to false).</param>
        /// <param name="disableHello">Unknown (default to false).</param>
        /// <param name="disableRegistration">Toggles if new user account registration should be disabled (required) (default to false).</param>
        /// <param name="disableSteamNetworking">Toggles if Steam Networking should be disabled. VRChat these days uses Photon Unity Networking (PUN) instead. (required) (default to true).</param>
        /// <param name="disableTwoFactorAuth">Toggles if 2FA should be disabled. (required) (default to false).</param>
        /// <param name="disableUdon">Toggles if Udon should be universally disabled in-game. (required) (default to false).</param>
        /// <param name="disableUpgradeAccount">Toggles if account upgrading \&quot;linking with Steam/Oculus\&quot; should be disabled. (required) (default to false).</param>
        /// <param name="downloadUrls">downloadUrls (required).</param>
        /// <param name="events">events (required).</param>
        /// <param name="homeWorldId">homeWorldId (required).</param>
        /// <param name="hubWorldId">hubWorldId (required).</param>
        /// <param name="moderationQueryPeriod">Unknown (required).</param>
        /// <param name="timeOutWorldId">timeOutWorldId (required).</param>
        /// <param name="tutorialWorldId">tutorialWorldId (required).</param>
        /// <param name="useReliableUdpForVoice">Unknown (required) (default to false).</param>
        public Config(decimal clientBPSCeiling = default(decimal), decimal clientDisconnectTimeout = default(decimal), decimal clientReservedPlayerBPS = default(decimal), decimal clientSentCountAllowance = default(decimal), string defaultAvatar = default(string), DeploymentGroup deploymentGroup = default(DeploymentGroup), bool disableAvatarCopying = false, bool disableAvatarGating = false, bool disableCommunityLabs = false, bool disableCommunityLabsPromotion = false, bool disableEmail = false, bool disableEventStream = false, bool disableFeedbackGating = false, bool disableHello = false, bool disableRegistration = false, bool disableSteamNetworking = true, bool disableTwoFactorAuth = false, bool disableUdon = false, bool disableUpgradeAccount = false, ConfigDownloadUrls downloadUrls = default(ConfigDownloadUrls), ConfigEvents events = default(ConfigEvents), string homeWorldId = default(string), string hubWorldId = default(string), decimal moderationQueryPeriod = default(decimal), string timeOutWorldId = default(string), string tutorialWorldId = default(string), bool useReliableUdpForVoice = false)
        {
            // to ensure "defaultAvatar" is required (not null)
            if (defaultAvatar == null)
            {
                throw new InvalidDataException("defaultAvatar is a required property for Config and cannot be null");
            }
            else
            {
                this.DefaultAvatar = defaultAvatar;
            }

            // to ensure "deploymentGroup" is required (not null)
            if (deploymentGroup == null)
            {
                throw new InvalidDataException("deploymentGroup is a required property for Config and cannot be null");
            }
            else
            {
                this.DeploymentGroup = deploymentGroup;
            }

            // to ensure "disableAvatarCopying" is required (not null)
            if (disableAvatarCopying == null)
            {
                throw new InvalidDataException("disableAvatarCopying is a required property for Config and cannot be null");
            }
            else
            {
                this.DisableAvatarCopying = disableAvatarCopying;
            }

            // to ensure "disableAvatarGating" is required (not null)
            if (disableAvatarGating == null)
            {
                throw new InvalidDataException("disableAvatarGating is a required property for Config and cannot be null");
            }
            else
            {
                this.DisableAvatarGating = disableAvatarGating;
            }

            // to ensure "disableCommunityLabs" is required (not null)
            if (disableCommunityLabs == null)
            {
                throw new InvalidDataException("disableCommunityLabs is a required property for Config and cannot be null");
            }
            else
            {
                this.DisableCommunityLabs = disableCommunityLabs;
            }

            // to ensure "disableCommunityLabsPromotion" is required (not null)
            if (disableCommunityLabsPromotion == null)
            {
                throw new InvalidDataException("disableCommunityLabsPromotion is a required property for Config and cannot be null");
            }
            else
            {
                this.DisableCommunityLabsPromotion = disableCommunityLabsPromotion;
            }

            // to ensure "disableEventStream" is required (not null)
            if (disableEventStream == null)
            {
                throw new InvalidDataException("disableEventStream is a required property for Config and cannot be null");
            }
            else
            {
                this.DisableEventStream = disableEventStream;
            }

            // to ensure "disableFeedbackGating" is required (not null)
            if (disableFeedbackGating == null)
            {
                throw new InvalidDataException("disableFeedbackGating is a required property for Config and cannot be null");
            }
            else
            {
                this.DisableFeedbackGating = disableFeedbackGating;
            }

            // to ensure "disableRegistration" is required (not null)
            if (disableRegistration == null)
            {
                throw new InvalidDataException("disableRegistration is a required property for Config and cannot be null");
            }
            else
            {
                this.DisableRegistration = disableRegistration;
            }

            // to ensure "disableSteamNetworking" is required (not null)
            if (disableSteamNetworking == null)
            {
                throw new InvalidDataException("disableSteamNetworking is a required property for Config and cannot be null");
            }
            else
            {
                this.DisableSteamNetworking = disableSteamNetworking;
            }

            // to ensure "disableTwoFactorAuth" is required (not null)
            if (disableTwoFactorAuth == null)
            {
                throw new InvalidDataException("disableTwoFactorAuth is a required property for Config and cannot be null");
            }
            else
            {
                this.DisableTwoFactorAuth = disableTwoFactorAuth;
            }

            // to ensure "disableUdon" is required (not null)
            if (disableUdon == null)
            {
                throw new InvalidDataException("disableUdon is a required property for Config and cannot be null");
            }
            else
            {
                this.DisableUdon = disableUdon;
            }

            // to ensure "disableUpgradeAccount" is required (not null)
            if (disableUpgradeAccount == null)
            {
                throw new InvalidDataException("disableUpgradeAccount is a required property for Config and cannot be null");
            }
            else
            {
                this.DisableUpgradeAccount = disableUpgradeAccount;
            }

            // to ensure "downloadUrls" is required (not null)
            if (downloadUrls == null)
            {
                throw new InvalidDataException("downloadUrls is a required property for Config and cannot be null");
            }
            else
            {
                this.DownloadUrls = downloadUrls;
            }

            // to ensure "events" is required (not null)
            if (events == null)
            {
                throw new InvalidDataException("events is a required property for Config and cannot be null");
            }
            else
            {
                this.Events = events;
            }

            // to ensure "homeWorldId" is required (not null)
            if (homeWorldId == null)
            {
                throw new InvalidDataException("homeWorldId is a required property for Config and cannot be null");
            }
            else
            {
                this.HomeWorldId = homeWorldId;
            }

            // to ensure "hubWorldId" is required (not null)
            if (hubWorldId == null)
            {
                throw new InvalidDataException("hubWorldId is a required property for Config and cannot be null");
            }
            else
            {
                this.HubWorldId = hubWorldId;
            }

            // to ensure "moderationQueryPeriod" is required (not null)
            if (moderationQueryPeriod == null)
            {
                throw new InvalidDataException("moderationQueryPeriod is a required property for Config and cannot be null");
            }
            else
            {
                this.ModerationQueryPeriod = moderationQueryPeriod;
            }

            // to ensure "timeOutWorldId" is required (not null)
            if (timeOutWorldId == null)
            {
                throw new InvalidDataException("timeOutWorldId is a required property for Config and cannot be null");
            }
            else
            {
                this.TimeOutWorldId = timeOutWorldId;
            }

            // to ensure "tutorialWorldId" is required (not null)
            if (tutorialWorldId == null)
            {
                throw new InvalidDataException("tutorialWorldId is a required property for Config and cannot be null");
            }
            else
            {
                this.TutorialWorldId = tutorialWorldId;
            }

            // to ensure "useReliableUdpForVoice" is required (not null)
            if (useReliableUdpForVoice == null)
            {
                throw new InvalidDataException("useReliableUdpForVoice is a required property for Config and cannot be null");
            }
            else
            {
                this.UseReliableUdpForVoice = useReliableUdpForVoice;
            }

            this.ClientBPSCeiling = clientBPSCeiling;
            this.ClientDisconnectTimeout = clientDisconnectTimeout;
            this.ClientReservedPlayerBPS = clientReservedPlayerBPS;
            this.ClientSentCountAllowance = clientSentCountAllowance;
            // use default value if no "disableEmail" provided
            if (disableEmail == null)
            {
                this.DisableEmail = false;
            }
            else
            {
                this.DisableEmail = disableEmail;
            }
            // use default value if no "disableHello" provided
            if (disableHello == null)
            {
                this.DisableHello = false;
            }
            else
            {
                this.DisableHello = disableHello;
            }
        }

        /// <summary>
        /// VRChat&#39;s office address
        /// </summary>
        /// <value>VRChat&#39;s office address</value>
        [DataMember(Name="address", EmitDefaultValue=true)]
        public string Address { get; private set; }

        /// <summary>
        /// Public Announcements
        /// </summary>
        /// <value>Public Announcements</value>
        [DataMember(Name="announcements", EmitDefaultValue=true)]
        public List<ConfigAnnouncements> Announcements { get; private set; }

        /// <summary>
        /// apiKey to be used for all other requests
        /// </summary>
        /// <value>apiKey to be used for all other requests</value>
        [DataMember(Name="apiKey", EmitDefaultValue=true)]
        public string ApiKey { get; private set; }

        /// <summary>
        /// Game name
        /// </summary>
        /// <value>Game name</value>
        [DataMember(Name="appName", EmitDefaultValue=true)]
        public string AppName { get; private set; }

        /// <summary>
        /// Build tag of the API server
        /// </summary>
        /// <value>Build tag of the API server</value>
        [DataMember(Name="buildVersionTag", EmitDefaultValue=true)]
        public string BuildVersionTag { get; private set; }

        /// <summary>
        /// apiKey to be used for all other requests
        /// </summary>
        /// <value>apiKey to be used for all other requests</value>
        [DataMember(Name="clientApiKey", EmitDefaultValue=true)]
        public string ClientApiKey { get; private set; }

        /// <summary>
        /// Unknown
        /// </summary>
        /// <value>Unknown</value>
        [DataMember(Name="clientBPSCeiling", EmitDefaultValue=false)]
        public decimal ClientBPSCeiling { get; set; }

        /// <summary>
        /// Unknown
        /// </summary>
        /// <value>Unknown</value>
        [DataMember(Name="clientDisconnectTimeout", EmitDefaultValue=false)]
        public decimal ClientDisconnectTimeout { get; set; }

        /// <summary>
        /// Unknown
        /// </summary>
        /// <value>Unknown</value>
        [DataMember(Name="clientReservedPlayerBPS", EmitDefaultValue=false)]
        public decimal ClientReservedPlayerBPS { get; set; }

        /// <summary>
        /// Unknown
        /// </summary>
        /// <value>Unknown</value>
        [DataMember(Name="clientSentCountAllowance", EmitDefaultValue=false)]
        public decimal ClientSentCountAllowance { get; set; }

        /// <summary>
        /// VRChat&#39;s contact email
        /// </summary>
        /// <value>VRChat&#39;s contact email</value>
        [DataMember(Name="contactEmail", EmitDefaultValue=true)]
        public string ContactEmail { get; private set; }

        /// <summary>
        /// VRChat&#39;s copyright-issues-related email
        /// </summary>
        /// <value>VRChat&#39;s copyright-issues-related email</value>
        [DataMember(Name="copyrightEmail", EmitDefaultValue=true)]
        public string CopyrightEmail { get; private set; }

        /// <summary>
        /// Current version number of the Terms of Service
        /// </summary>
        /// <value>Current version number of the Terms of Service</value>
        [DataMember(Name="currentTOSVersion", EmitDefaultValue=true)]
        public decimal CurrentTOSVersion { get; private set; }

        /// <summary>
        /// Gets or Sets DefaultAvatar
        /// </summary>
        [DataMember(Name="defaultAvatar", EmitDefaultValue=true)]
        public string DefaultAvatar { get; set; }


        /// <summary>
        /// Version number for game development build
        /// </summary>
        /// <value>Version number for game development build</value>
        [DataMember(Name="devAppVersionStandalone", EmitDefaultValue=true)]
        public string DevAppVersionStandalone { get; private set; }

        /// <summary>
        /// Developer Download link
        /// </summary>
        /// <value>Developer Download link</value>
        [DataMember(Name="devDownloadLinkWindows", EmitDefaultValue=true)]
        public string DevDownloadLinkWindows { get; private set; }

        /// <summary>
        /// Link to download the development SDK, use downloadUrls instead
        /// </summary>
        /// <value>Link to download the development SDK, use downloadUrls instead</value>
        [DataMember(Name="devSdkUrl", EmitDefaultValue=true)]
        public string DevSdkUrl { get; private set; }

        /// <summary>
        /// Version of the development SDK
        /// </summary>
        /// <value>Version of the development SDK</value>
        [DataMember(Name="devSdkVersion", EmitDefaultValue=true)]
        public string DevSdkVersion { get; private set; }

        /// <summary>
        /// Version number for server development build
        /// </summary>
        /// <value>Version number for server development build</value>
        [DataMember(Name="devServerVersionStandalone", EmitDefaultValue=true)]
        public string DevServerVersionStandalone { get; private set; }

        /// <summary>
        /// Toggles if copying avatars should be disabled
        /// </summary>
        /// <value>Toggles if copying avatars should be disabled</value>
        [DataMember(Name="disableAvatarCopying", EmitDefaultValue=true)]
        public bool DisableAvatarCopying { get; set; }

        /// <summary>
        /// Toggles if avatar gating should be disabled. Avatar gating restricts uploading of avatars to people with the &#x60;system_avatar_access&#x60; Tag or &#x60;admin_avatar_access&#x60; Tag
        /// </summary>
        /// <value>Toggles if avatar gating should be disabled. Avatar gating restricts uploading of avatars to people with the &#x60;system_avatar_access&#x60; Tag or &#x60;admin_avatar_access&#x60; Tag</value>
        [DataMember(Name="disableAvatarGating", EmitDefaultValue=true)]
        public bool DisableAvatarGating { get; set; }

        /// <summary>
        /// Toggles if the Community Labs should be disabled
        /// </summary>
        /// <value>Toggles if the Community Labs should be disabled</value>
        [DataMember(Name="disableCommunityLabs", EmitDefaultValue=true)]
        public bool DisableCommunityLabs { get; set; }

        /// <summary>
        /// Toggles if promotion out of Community Labs should be disabled
        /// </summary>
        /// <value>Toggles if promotion out of Community Labs should be disabled</value>
        [DataMember(Name="disableCommunityLabsPromotion", EmitDefaultValue=true)]
        public bool DisableCommunityLabsPromotion { get; set; }

        /// <summary>
        /// Unknown
        /// </summary>
        /// <value>Unknown</value>
        [DataMember(Name="disableEmail", EmitDefaultValue=false)]
        public bool DisableEmail { get; set; }

        /// <summary>
        /// Toggles if Analytics should be disabled (this sreportedly not used in the Client)
        /// </summary>
        /// <value>Toggles if Analytics should be disabled (this sreportedly not used in the Client)</value>
        [DataMember(Name="disableEventStream", EmitDefaultValue=true)]
        public bool DisableEventStream { get; set; }

        /// <summary>
        /// Toggles if feedback gating should be disabled. Feedback gating restricts submission of feedback (reporting a World or User) to people with the &#x60;system_feedback_access&#x60; Tag.
        /// </summary>
        /// <value>Toggles if feedback gating should be disabled. Feedback gating restricts submission of feedback (reporting a World or User) to people with the &#x60;system_feedback_access&#x60; Tag.</value>
        [DataMember(Name="disableFeedbackGating", EmitDefaultValue=true)]
        public bool DisableFeedbackGating { get; set; }

        /// <summary>
        /// Unknown
        /// </summary>
        /// <value>Unknown</value>
        [DataMember(Name="disableHello", EmitDefaultValue=false)]
        public bool DisableHello { get; set; }

        /// <summary>
        /// Toggles if new user account registration should be disabled
        /// </summary>
        /// <value>Toggles if new user account registration should be disabled</value>
        [DataMember(Name="disableRegistration", EmitDefaultValue=true)]
        public bool DisableRegistration { get; set; }

        /// <summary>
        /// Toggles if Steam Networking should be disabled. VRChat these days uses Photon Unity Networking (PUN) instead.
        /// </summary>
        /// <value>Toggles if Steam Networking should be disabled. VRChat these days uses Photon Unity Networking (PUN) instead.</value>
        [DataMember(Name="disableSteamNetworking", EmitDefaultValue=true)]
        public bool DisableSteamNetworking { get; set; }

        /// <summary>
        /// Toggles if 2FA should be disabled.
        /// </summary>
        /// <value>Toggles if 2FA should be disabled.</value>
        [DataMember(Name="disableTwoFactorAuth", EmitDefaultValue=true)]
        public bool DisableTwoFactorAuth { get; set; }

        /// <summary>
        /// Toggles if Udon should be universally disabled in-game.
        /// </summary>
        /// <value>Toggles if Udon should be universally disabled in-game.</value>
        [DataMember(Name="disableUdon", EmitDefaultValue=true)]
        public bool DisableUdon { get; set; }

        /// <summary>
        /// Toggles if account upgrading \&quot;linking with Steam/Oculus\&quot; should be disabled.
        /// </summary>
        /// <value>Toggles if account upgrading \&quot;linking with Steam/Oculus\&quot; should be disabled.</value>
        [DataMember(Name="disableUpgradeAccount", EmitDefaultValue=true)]
        public bool DisableUpgradeAccount { get; set; }

        /// <summary>
        /// Download link for game on the Oculus Rift website.
        /// </summary>
        /// <value>Download link for game on the Oculus Rift website.</value>
        [DataMember(Name="downloadLinkWindows", EmitDefaultValue=true)]
        public string DownloadLinkWindows { get; private set; }

        /// <summary>
        /// Gets or Sets DownloadUrls
        /// </summary>
        [DataMember(Name="downloadUrls", EmitDefaultValue=true)]
        public ConfigDownloadUrls DownloadUrls { get; set; }

        /// <summary>
        /// Array of DynamicWorldRow objects, used by the game to display the list of world rows
        /// </summary>
        /// <value>Array of DynamicWorldRow objects, used by the game to display the list of world rows</value>
        [DataMember(Name="dynamicWorldRows", EmitDefaultValue=true)]
        public List<ConfigDynamicWorldRows> DynamicWorldRows { get; private set; }

        /// <summary>
        /// Gets or Sets Events
        /// </summary>
        [DataMember(Name="events", EmitDefaultValue=true)]
        public ConfigEvents Events { get; set; }

        /// <summary>
        /// Unknown
        /// </summary>
        /// <value>Unknown</value>
        [DataMember(Name="gearDemoRoomId", EmitDefaultValue=true)]
        public string GearDemoRoomId { get; private set; }

        /// <summary>
        /// Redirect target if you try to open the base API domain in your browser
        /// </summary>
        /// <value>Redirect target if you try to open the base API domain in your browser</value>
        [DataMember(Name="homepageRedirectTarget", EmitDefaultValue=true)]
        public string HomepageRedirectTarget { get; private set; }

        /// <summary>
        /// Gets or Sets HomeWorldId
        /// </summary>
        [DataMember(Name="homeWorldId", EmitDefaultValue=true)]
        public string HomeWorldId { get; set; }

        /// <summary>
        /// Gets or Sets HubWorldId
        /// </summary>
        [DataMember(Name="hubWorldId", EmitDefaultValue=true)]
        public string HubWorldId { get; set; }

        /// <summary>
        /// VRChat&#39;s job application email
        /// </summary>
        /// <value>VRChat&#39;s job application email</value>
        [DataMember(Name="jobsEmail", EmitDefaultValue=true)]
        public string JobsEmail { get; private set; }

        /// <summary>
        /// MOTD
        /// </summary>
        /// <value>MOTD</value>
        [DataMember(Name="messageOfTheDay", EmitDefaultValue=true)]
        public string MessageOfTheDay { get; private set; }

        /// <summary>
        /// VRChat&#39;s moderation related email
        /// </summary>
        /// <value>VRChat&#39;s moderation related email</value>
        [DataMember(Name="moderationEmail", EmitDefaultValue=true)]
        public string ModerationEmail { get; private set; }

        /// <summary>
        /// Unknown
        /// </summary>
        /// <value>Unknown</value>
        [DataMember(Name="moderationQueryPeriod", EmitDefaultValue=true)]
        public decimal ModerationQueryPeriod { get; set; }

        /// <summary>
        /// Used in-game to notify a user they aren&#39;t allowed to select avatars in private worlds
        /// </summary>
        /// <value>Used in-game to notify a user they aren&#39;t allowed to select avatars in private worlds</value>
        [DataMember(Name="notAllowedToSelectAvatarInPrivateWorldMessage", EmitDefaultValue=true)]
        public string NotAllowedToSelectAvatarInPrivateWorldMessage { get; private set; }

        /// <summary>
        /// Extra [plugin](https://doc.photonengine.com/en-us/server/current/plugins/manual) to run in each instance
        /// </summary>
        /// <value>Extra [plugin](https://doc.photonengine.com/en-us/server/current/plugins/manual) to run in each instance</value>
        [DataMember(Name="plugin", EmitDefaultValue=true)]
        public string Plugin { get; private set; }

        /// <summary>
        /// Version number for game release build
        /// </summary>
        /// <value>Version number for game release build</value>
        [DataMember(Name="releaseAppVersionStandalone", EmitDefaultValue=true)]
        public string ReleaseAppVersionStandalone { get; private set; }

        /// <summary>
        /// Link to download the release SDK
        /// </summary>
        /// <value>Link to download the release SDK</value>
        [DataMember(Name="releaseSdkUrl", EmitDefaultValue=true)]
        public string ReleaseSdkUrl { get; private set; }

        /// <summary>
        /// Version of the release SDK
        /// </summary>
        /// <value>Version of the release SDK</value>
        [DataMember(Name="releaseSdkVersion", EmitDefaultValue=true)]
        public string ReleaseSdkVersion { get; private set; }

        /// <summary>
        /// Version number for server release build
        /// </summary>
        /// <value>Version number for server release build</value>
        [DataMember(Name="releaseServerVersionStandalone", EmitDefaultValue=true)]
        public string ReleaseServerVersionStandalone { get; private set; }

        /// <summary>
        /// Link to the developer FAQ
        /// </summary>
        /// <value>Link to the developer FAQ</value>
        [DataMember(Name="sdkDeveloperFaqUrl", EmitDefaultValue=true)]
        public string SdkDeveloperFaqUrl { get; private set; }

        /// <summary>
        /// Link to the official VRChat Discord
        /// </summary>
        /// <value>Link to the official VRChat Discord</value>
        [DataMember(Name="sdkDiscordUrl", EmitDefaultValue=true)]
        public string SdkDiscordUrl { get; private set; }

        /// <summary>
        /// Used in the SDK to notify a user they aren&#39;t allowed to upload avatars/worlds yet
        /// </summary>
        /// <value>Used in the SDK to notify a user they aren&#39;t allowed to upload avatars/worlds yet</value>
        [DataMember(Name="sdkNotAllowedToPublishMessage", EmitDefaultValue=true)]
        public string SdkNotAllowedToPublishMessage { get; private set; }

        /// <summary>
        /// Unity version supported by the SDK
        /// </summary>
        /// <value>Unity version supported by the SDK</value>
        [DataMember(Name="sdkUnityVersion", EmitDefaultValue=true)]
        public string SdkUnityVersion { get; private set; }

        /// <summary>
        /// Server name of the API server currently responding
        /// </summary>
        /// <value>Server name of the API server currently responding</value>
        [DataMember(Name="serverName", EmitDefaultValue=true)]
        public string ServerName { get; private set; }

        /// <summary>
        /// VRChat&#39;s support email
        /// </summary>
        /// <value>VRChat&#39;s support email</value>
        [DataMember(Name="supportEmail", EmitDefaultValue=true)]
        public string SupportEmail { get; private set; }

        /// <summary>
        /// Gets or Sets TimeOutWorldId
        /// </summary>
        [DataMember(Name="timeOutWorldId", EmitDefaultValue=true)]
        public string TimeOutWorldId { get; set; }

        /// <summary>
        /// Gets or Sets TutorialWorldId
        /// </summary>
        [DataMember(Name="tutorialWorldId", EmitDefaultValue=true)]
        public string TutorialWorldId { get; set; }

        /// <summary>
        /// Unknown
        /// </summary>
        /// <value>Unknown</value>
        [DataMember(Name="updateRateMsMaximum", EmitDefaultValue=true)]
        public decimal UpdateRateMsMaximum { get; private set; }

        /// <summary>
        /// Unknown
        /// </summary>
        /// <value>Unknown</value>
        [DataMember(Name="updateRateMsMinimum", EmitDefaultValue=true)]
        public decimal UpdateRateMsMinimum { get; private set; }

        /// <summary>
        /// Unknown
        /// </summary>
        /// <value>Unknown</value>
        [DataMember(Name="updateRateMsNormal", EmitDefaultValue=true)]
        public decimal UpdateRateMsNormal { get; private set; }

        /// <summary>
        /// Unknown
        /// </summary>
        /// <value>Unknown</value>
        [DataMember(Name="updateRateMsUdonManual", EmitDefaultValue=true)]
        public decimal UpdateRateMsUdonManual { get; private set; }

        /// <summary>
        /// Unknown
        /// </summary>
        /// <value>Unknown</value>
        [DataMember(Name="uploadAnalysisPercent", EmitDefaultValue=true)]
        public decimal UploadAnalysisPercent { get; private set; }

        /// <summary>
        /// List of allowed URLs that bypass the \&quot;Allow untrusted URL&#39;s\&quot; setting in-game
        /// </summary>
        /// <value>List of allowed URLs that bypass the \&quot;Allow untrusted URL&#39;s\&quot; setting in-game</value>
        [DataMember(Name="urlList", EmitDefaultValue=true)]
        public List<string> UrlList { get; private set; }

        /// <summary>
        /// Unknown
        /// </summary>
        /// <value>Unknown</value>
        [DataMember(Name="useReliableUdpForVoice", EmitDefaultValue=true)]
        public bool UseReliableUdpForVoice { get; set; }

        /// <summary>
        /// Unknown
        /// </summary>
        /// <value>Unknown</value>
        [DataMember(Name="userUpdatePeriod", EmitDefaultValue=true)]
        public decimal UserUpdatePeriod { get; private set; }

        /// <summary>
        /// Unknown
        /// </summary>
        /// <value>Unknown</value>
        [DataMember(Name="userVerificationDelay", EmitDefaultValue=true)]
        public decimal UserVerificationDelay { get; private set; }

        /// <summary>
        /// Unknown
        /// </summary>
        /// <value>Unknown</value>
        [DataMember(Name="userVerificationRetry", EmitDefaultValue=true)]
        public decimal UserVerificationRetry { get; private set; }

        /// <summary>
        /// Unknown
        /// </summary>
        /// <value>Unknown</value>
        [DataMember(Name="userVerificationTimeout", EmitDefaultValue=true)]
        public decimal UserVerificationTimeout { get; private set; }

        /// <summary>
        /// Download link for game on the Steam website.
        /// </summary>
        /// <value>Download link for game on the Steam website.</value>
        [DataMember(Name="viveWindowsUrl", EmitDefaultValue=true)]
        public string ViveWindowsUrl { get; private set; }

        /// <summary>
        /// List of allowed URLs that are allowed to host avatar assets
        /// </summary>
        /// <value>List of allowed URLs that are allowed to host avatar assets</value>
        [DataMember(Name="whiteListedAssetUrls", EmitDefaultValue=true)]
        public List<string> WhiteListedAssetUrls { get; private set; }

        /// <summary>
        /// Unknown
        /// </summary>
        /// <value>Unknown</value>
        [DataMember(Name="worldUpdatePeriod", EmitDefaultValue=true)]
        public decimal WorldUpdatePeriod { get; private set; }

        /// <summary>
        /// Currently used youtube-dl.exe hash in SHA-256-delimited format
        /// </summary>
        /// <value>Currently used youtube-dl.exe hash in SHA-256-delimited format</value>
        [DataMember(Name="youtubedl-hash", EmitDefaultValue=true)]
        public string YoutubedlHash { get; private set; }

        /// <summary>
        /// Currently used youtube-dl.exe version
        /// </summary>
        /// <value>Currently used youtube-dl.exe version</value>
        [DataMember(Name="youtubedl-version", EmitDefaultValue=true)]
        public string YoutubedlVersion { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Config {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Announcements: ").Append(Announcements).Append("\n");
            sb.Append("  ApiKey: ").Append(ApiKey).Append("\n");
            sb.Append("  AppName: ").Append(AppName).Append("\n");
            sb.Append("  BuildVersionTag: ").Append(BuildVersionTag).Append("\n");
            sb.Append("  ClientApiKey: ").Append(ClientApiKey).Append("\n");
            sb.Append("  ClientBPSCeiling: ").Append(ClientBPSCeiling).Append("\n");
            sb.Append("  ClientDisconnectTimeout: ").Append(ClientDisconnectTimeout).Append("\n");
            sb.Append("  ClientReservedPlayerBPS: ").Append(ClientReservedPlayerBPS).Append("\n");
            sb.Append("  ClientSentCountAllowance: ").Append(ClientSentCountAllowance).Append("\n");
            sb.Append("  ContactEmail: ").Append(ContactEmail).Append("\n");
            sb.Append("  CopyrightEmail: ").Append(CopyrightEmail).Append("\n");
            sb.Append("  CurrentTOSVersion: ").Append(CurrentTOSVersion).Append("\n");
            sb.Append("  DefaultAvatar: ").Append(DefaultAvatar).Append("\n");
            sb.Append("  DeploymentGroup: ").Append(DeploymentGroup).Append("\n");
            sb.Append("  DevAppVersionStandalone: ").Append(DevAppVersionStandalone).Append("\n");
            sb.Append("  DevDownloadLinkWindows: ").Append(DevDownloadLinkWindows).Append("\n");
            sb.Append("  DevSdkUrl: ").Append(DevSdkUrl).Append("\n");
            sb.Append("  DevSdkVersion: ").Append(DevSdkVersion).Append("\n");
            sb.Append("  DevServerVersionStandalone: ").Append(DevServerVersionStandalone).Append("\n");
            sb.Append("  DisableAvatarCopying: ").Append(DisableAvatarCopying).Append("\n");
            sb.Append("  DisableAvatarGating: ").Append(DisableAvatarGating).Append("\n");
            sb.Append("  DisableCommunityLabs: ").Append(DisableCommunityLabs).Append("\n");
            sb.Append("  DisableCommunityLabsPromotion: ").Append(DisableCommunityLabsPromotion).Append("\n");
            sb.Append("  DisableEmail: ").Append(DisableEmail).Append("\n");
            sb.Append("  DisableEventStream: ").Append(DisableEventStream).Append("\n");
            sb.Append("  DisableFeedbackGating: ").Append(DisableFeedbackGating).Append("\n");
            sb.Append("  DisableHello: ").Append(DisableHello).Append("\n");
            sb.Append("  DisableRegistration: ").Append(DisableRegistration).Append("\n");
            sb.Append("  DisableSteamNetworking: ").Append(DisableSteamNetworking).Append("\n");
            sb.Append("  DisableTwoFactorAuth: ").Append(DisableTwoFactorAuth).Append("\n");
            sb.Append("  DisableUdon: ").Append(DisableUdon).Append("\n");
            sb.Append("  DisableUpgradeAccount: ").Append(DisableUpgradeAccount).Append("\n");
            sb.Append("  DownloadLinkWindows: ").Append(DownloadLinkWindows).Append("\n");
            sb.Append("  DownloadUrls: ").Append(DownloadUrls).Append("\n");
            sb.Append("  DynamicWorldRows: ").Append(DynamicWorldRows).Append("\n");
            sb.Append("  Events: ").Append(Events).Append("\n");
            sb.Append("  GearDemoRoomId: ").Append(GearDemoRoomId).Append("\n");
            sb.Append("  HomepageRedirectTarget: ").Append(HomepageRedirectTarget).Append("\n");
            sb.Append("  HomeWorldId: ").Append(HomeWorldId).Append("\n");
            sb.Append("  HubWorldId: ").Append(HubWorldId).Append("\n");
            sb.Append("  JobsEmail: ").Append(JobsEmail).Append("\n");
            sb.Append("  MessageOfTheDay: ").Append(MessageOfTheDay).Append("\n");
            sb.Append("  ModerationEmail: ").Append(ModerationEmail).Append("\n");
            sb.Append("  ModerationQueryPeriod: ").Append(ModerationQueryPeriod).Append("\n");
            sb.Append("  NotAllowedToSelectAvatarInPrivateWorldMessage: ").Append(NotAllowedToSelectAvatarInPrivateWorldMessage).Append("\n");
            sb.Append("  Plugin: ").Append(Plugin).Append("\n");
            sb.Append("  ReleaseAppVersionStandalone: ").Append(ReleaseAppVersionStandalone).Append("\n");
            sb.Append("  ReleaseSdkUrl: ").Append(ReleaseSdkUrl).Append("\n");
            sb.Append("  ReleaseSdkVersion: ").Append(ReleaseSdkVersion).Append("\n");
            sb.Append("  ReleaseServerVersionStandalone: ").Append(ReleaseServerVersionStandalone).Append("\n");
            sb.Append("  SdkDeveloperFaqUrl: ").Append(SdkDeveloperFaqUrl).Append("\n");
            sb.Append("  SdkDiscordUrl: ").Append(SdkDiscordUrl).Append("\n");
            sb.Append("  SdkNotAllowedToPublishMessage: ").Append(SdkNotAllowedToPublishMessage).Append("\n");
            sb.Append("  SdkUnityVersion: ").Append(SdkUnityVersion).Append("\n");
            sb.Append("  ServerName: ").Append(ServerName).Append("\n");
            sb.Append("  SupportEmail: ").Append(SupportEmail).Append("\n");
            sb.Append("  TimeOutWorldId: ").Append(TimeOutWorldId).Append("\n");
            sb.Append("  TutorialWorldId: ").Append(TutorialWorldId).Append("\n");
            sb.Append("  UpdateRateMsMaximum: ").Append(UpdateRateMsMaximum).Append("\n");
            sb.Append("  UpdateRateMsMinimum: ").Append(UpdateRateMsMinimum).Append("\n");
            sb.Append("  UpdateRateMsNormal: ").Append(UpdateRateMsNormal).Append("\n");
            sb.Append("  UpdateRateMsUdonManual: ").Append(UpdateRateMsUdonManual).Append("\n");
            sb.Append("  UploadAnalysisPercent: ").Append(UploadAnalysisPercent).Append("\n");
            sb.Append("  UrlList: ").Append(UrlList).Append("\n");
            sb.Append("  UseReliableUdpForVoice: ").Append(UseReliableUdpForVoice).Append("\n");
            sb.Append("  UserUpdatePeriod: ").Append(UserUpdatePeriod).Append("\n");
            sb.Append("  UserVerificationDelay: ").Append(UserVerificationDelay).Append("\n");
            sb.Append("  UserVerificationRetry: ").Append(UserVerificationRetry).Append("\n");
            sb.Append("  UserVerificationTimeout: ").Append(UserVerificationTimeout).Append("\n");
            sb.Append("  ViveWindowsUrl: ").Append(ViveWindowsUrl).Append("\n");
            sb.Append("  WhiteListedAssetUrls: ").Append(WhiteListedAssetUrls).Append("\n");
            sb.Append("  WorldUpdatePeriod: ").Append(WorldUpdatePeriod).Append("\n");
            sb.Append("  YoutubedlHash: ").Append(YoutubedlHash).Append("\n");
            sb.Append("  YoutubedlVersion: ").Append(YoutubedlVersion).Append("\n");
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
            return this.Equals(input as Config);
        }

        /// <summary>
        /// Returns true if Config instances are equal
        /// </summary>
        /// <param name="input">Instance of Config to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Config input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.Announcements == input.Announcements ||
                    this.Announcements != null &&
                    input.Announcements != null &&
                    this.Announcements.SequenceEqual(input.Announcements)
                ) && 
                (
                    this.ApiKey == input.ApiKey ||
                    (this.ApiKey != null &&
                    this.ApiKey.Equals(input.ApiKey))
                ) && 
                (
                    this.AppName == input.AppName ||
                    (this.AppName != null &&
                    this.AppName.Equals(input.AppName))
                ) && 
                (
                    this.BuildVersionTag == input.BuildVersionTag ||
                    (this.BuildVersionTag != null &&
                    this.BuildVersionTag.Equals(input.BuildVersionTag))
                ) && 
                (
                    this.ClientApiKey == input.ClientApiKey ||
                    (this.ClientApiKey != null &&
                    this.ClientApiKey.Equals(input.ClientApiKey))
                ) && 
                (
                    this.ClientBPSCeiling == input.ClientBPSCeiling ||
                    (this.ClientBPSCeiling != null &&
                    this.ClientBPSCeiling.Equals(input.ClientBPSCeiling))
                ) && 
                (
                    this.ClientDisconnectTimeout == input.ClientDisconnectTimeout ||
                    (this.ClientDisconnectTimeout != null &&
                    this.ClientDisconnectTimeout.Equals(input.ClientDisconnectTimeout))
                ) && 
                (
                    this.ClientReservedPlayerBPS == input.ClientReservedPlayerBPS ||
                    (this.ClientReservedPlayerBPS != null &&
                    this.ClientReservedPlayerBPS.Equals(input.ClientReservedPlayerBPS))
                ) && 
                (
                    this.ClientSentCountAllowance == input.ClientSentCountAllowance ||
                    (this.ClientSentCountAllowance != null &&
                    this.ClientSentCountAllowance.Equals(input.ClientSentCountAllowance))
                ) && 
                (
                    this.ContactEmail == input.ContactEmail ||
                    (this.ContactEmail != null &&
                    this.ContactEmail.Equals(input.ContactEmail))
                ) && 
                (
                    this.CopyrightEmail == input.CopyrightEmail ||
                    (this.CopyrightEmail != null &&
                    this.CopyrightEmail.Equals(input.CopyrightEmail))
                ) && 
                (
                    this.CurrentTOSVersion == input.CurrentTOSVersion ||
                    (this.CurrentTOSVersion != null &&
                    this.CurrentTOSVersion.Equals(input.CurrentTOSVersion))
                ) && 
                (
                    this.DefaultAvatar == input.DefaultAvatar ||
                    (this.DefaultAvatar != null &&
                    this.DefaultAvatar.Equals(input.DefaultAvatar))
                ) && 
                (
                    this.DeploymentGroup == input.DeploymentGroup ||
                    (this.DeploymentGroup != null &&
                    this.DeploymentGroup.Equals(input.DeploymentGroup))
                ) && 
                (
                    this.DevAppVersionStandalone == input.DevAppVersionStandalone ||
                    (this.DevAppVersionStandalone != null &&
                    this.DevAppVersionStandalone.Equals(input.DevAppVersionStandalone))
                ) && 
                (
                    this.DevDownloadLinkWindows == input.DevDownloadLinkWindows ||
                    (this.DevDownloadLinkWindows != null &&
                    this.DevDownloadLinkWindows.Equals(input.DevDownloadLinkWindows))
                ) && 
                (
                    this.DevSdkUrl == input.DevSdkUrl ||
                    (this.DevSdkUrl != null &&
                    this.DevSdkUrl.Equals(input.DevSdkUrl))
                ) && 
                (
                    this.DevSdkVersion == input.DevSdkVersion ||
                    (this.DevSdkVersion != null &&
                    this.DevSdkVersion.Equals(input.DevSdkVersion))
                ) && 
                (
                    this.DevServerVersionStandalone == input.DevServerVersionStandalone ||
                    (this.DevServerVersionStandalone != null &&
                    this.DevServerVersionStandalone.Equals(input.DevServerVersionStandalone))
                ) && 
                (
                    this.DisableAvatarCopying == input.DisableAvatarCopying ||
                    (this.DisableAvatarCopying != null &&
                    this.DisableAvatarCopying.Equals(input.DisableAvatarCopying))
                ) && 
                (
                    this.DisableAvatarGating == input.DisableAvatarGating ||
                    (this.DisableAvatarGating != null &&
                    this.DisableAvatarGating.Equals(input.DisableAvatarGating))
                ) && 
                (
                    this.DisableCommunityLabs == input.DisableCommunityLabs ||
                    (this.DisableCommunityLabs != null &&
                    this.DisableCommunityLabs.Equals(input.DisableCommunityLabs))
                ) && 
                (
                    this.DisableCommunityLabsPromotion == input.DisableCommunityLabsPromotion ||
                    (this.DisableCommunityLabsPromotion != null &&
                    this.DisableCommunityLabsPromotion.Equals(input.DisableCommunityLabsPromotion))
                ) && 
                (
                    this.DisableEmail == input.DisableEmail ||
                    (this.DisableEmail != null &&
                    this.DisableEmail.Equals(input.DisableEmail))
                ) && 
                (
                    this.DisableEventStream == input.DisableEventStream ||
                    (this.DisableEventStream != null &&
                    this.DisableEventStream.Equals(input.DisableEventStream))
                ) && 
                (
                    this.DisableFeedbackGating == input.DisableFeedbackGating ||
                    (this.DisableFeedbackGating != null &&
                    this.DisableFeedbackGating.Equals(input.DisableFeedbackGating))
                ) && 
                (
                    this.DisableHello == input.DisableHello ||
                    (this.DisableHello != null &&
                    this.DisableHello.Equals(input.DisableHello))
                ) && 
                (
                    this.DisableRegistration == input.DisableRegistration ||
                    (this.DisableRegistration != null &&
                    this.DisableRegistration.Equals(input.DisableRegistration))
                ) && 
                (
                    this.DisableSteamNetworking == input.DisableSteamNetworking ||
                    (this.DisableSteamNetworking != null &&
                    this.DisableSteamNetworking.Equals(input.DisableSteamNetworking))
                ) && 
                (
                    this.DisableTwoFactorAuth == input.DisableTwoFactorAuth ||
                    (this.DisableTwoFactorAuth != null &&
                    this.DisableTwoFactorAuth.Equals(input.DisableTwoFactorAuth))
                ) && 
                (
                    this.DisableUdon == input.DisableUdon ||
                    (this.DisableUdon != null &&
                    this.DisableUdon.Equals(input.DisableUdon))
                ) && 
                (
                    this.DisableUpgradeAccount == input.DisableUpgradeAccount ||
                    (this.DisableUpgradeAccount != null &&
                    this.DisableUpgradeAccount.Equals(input.DisableUpgradeAccount))
                ) && 
                (
                    this.DownloadLinkWindows == input.DownloadLinkWindows ||
                    (this.DownloadLinkWindows != null &&
                    this.DownloadLinkWindows.Equals(input.DownloadLinkWindows))
                ) && 
                (
                    this.DownloadUrls == input.DownloadUrls ||
                    (this.DownloadUrls != null &&
                    this.DownloadUrls.Equals(input.DownloadUrls))
                ) && 
                (
                    this.DynamicWorldRows == input.DynamicWorldRows ||
                    this.DynamicWorldRows != null &&
                    input.DynamicWorldRows != null &&
                    this.DynamicWorldRows.SequenceEqual(input.DynamicWorldRows)
                ) && 
                (
                    this.Events == input.Events ||
                    (this.Events != null &&
                    this.Events.Equals(input.Events))
                ) && 
                (
                    this.GearDemoRoomId == input.GearDemoRoomId ||
                    (this.GearDemoRoomId != null &&
                    this.GearDemoRoomId.Equals(input.GearDemoRoomId))
                ) && 
                (
                    this.HomepageRedirectTarget == input.HomepageRedirectTarget ||
                    (this.HomepageRedirectTarget != null &&
                    this.HomepageRedirectTarget.Equals(input.HomepageRedirectTarget))
                ) && 
                (
                    this.HomeWorldId == input.HomeWorldId ||
                    (this.HomeWorldId != null &&
                    this.HomeWorldId.Equals(input.HomeWorldId))
                ) && 
                (
                    this.HubWorldId == input.HubWorldId ||
                    (this.HubWorldId != null &&
                    this.HubWorldId.Equals(input.HubWorldId))
                ) && 
                (
                    this.JobsEmail == input.JobsEmail ||
                    (this.JobsEmail != null &&
                    this.JobsEmail.Equals(input.JobsEmail))
                ) && 
                (
                    this.MessageOfTheDay == input.MessageOfTheDay ||
                    (this.MessageOfTheDay != null &&
                    this.MessageOfTheDay.Equals(input.MessageOfTheDay))
                ) && 
                (
                    this.ModerationEmail == input.ModerationEmail ||
                    (this.ModerationEmail != null &&
                    this.ModerationEmail.Equals(input.ModerationEmail))
                ) && 
                (
                    this.ModerationQueryPeriod == input.ModerationQueryPeriod ||
                    (this.ModerationQueryPeriod != null &&
                    this.ModerationQueryPeriod.Equals(input.ModerationQueryPeriod))
                ) && 
                (
                    this.NotAllowedToSelectAvatarInPrivateWorldMessage == input.NotAllowedToSelectAvatarInPrivateWorldMessage ||
                    (this.NotAllowedToSelectAvatarInPrivateWorldMessage != null &&
                    this.NotAllowedToSelectAvatarInPrivateWorldMessage.Equals(input.NotAllowedToSelectAvatarInPrivateWorldMessage))
                ) && 
                (
                    this.Plugin == input.Plugin ||
                    (this.Plugin != null &&
                    this.Plugin.Equals(input.Plugin))
                ) && 
                (
                    this.ReleaseAppVersionStandalone == input.ReleaseAppVersionStandalone ||
                    (this.ReleaseAppVersionStandalone != null &&
                    this.ReleaseAppVersionStandalone.Equals(input.ReleaseAppVersionStandalone))
                ) && 
                (
                    this.ReleaseSdkUrl == input.ReleaseSdkUrl ||
                    (this.ReleaseSdkUrl != null &&
                    this.ReleaseSdkUrl.Equals(input.ReleaseSdkUrl))
                ) && 
                (
                    this.ReleaseSdkVersion == input.ReleaseSdkVersion ||
                    (this.ReleaseSdkVersion != null &&
                    this.ReleaseSdkVersion.Equals(input.ReleaseSdkVersion))
                ) && 
                (
                    this.ReleaseServerVersionStandalone == input.ReleaseServerVersionStandalone ||
                    (this.ReleaseServerVersionStandalone != null &&
                    this.ReleaseServerVersionStandalone.Equals(input.ReleaseServerVersionStandalone))
                ) && 
                (
                    this.SdkDeveloperFaqUrl == input.SdkDeveloperFaqUrl ||
                    (this.SdkDeveloperFaqUrl != null &&
                    this.SdkDeveloperFaqUrl.Equals(input.SdkDeveloperFaqUrl))
                ) && 
                (
                    this.SdkDiscordUrl == input.SdkDiscordUrl ||
                    (this.SdkDiscordUrl != null &&
                    this.SdkDiscordUrl.Equals(input.SdkDiscordUrl))
                ) && 
                (
                    this.SdkNotAllowedToPublishMessage == input.SdkNotAllowedToPublishMessage ||
                    (this.SdkNotAllowedToPublishMessage != null &&
                    this.SdkNotAllowedToPublishMessage.Equals(input.SdkNotAllowedToPublishMessage))
                ) && 
                (
                    this.SdkUnityVersion == input.SdkUnityVersion ||
                    (this.SdkUnityVersion != null &&
                    this.SdkUnityVersion.Equals(input.SdkUnityVersion))
                ) && 
                (
                    this.ServerName == input.ServerName ||
                    (this.ServerName != null &&
                    this.ServerName.Equals(input.ServerName))
                ) && 
                (
                    this.SupportEmail == input.SupportEmail ||
                    (this.SupportEmail != null &&
                    this.SupportEmail.Equals(input.SupportEmail))
                ) && 
                (
                    this.TimeOutWorldId == input.TimeOutWorldId ||
                    (this.TimeOutWorldId != null &&
                    this.TimeOutWorldId.Equals(input.TimeOutWorldId))
                ) && 
                (
                    this.TutorialWorldId == input.TutorialWorldId ||
                    (this.TutorialWorldId != null &&
                    this.TutorialWorldId.Equals(input.TutorialWorldId))
                ) && 
                (
                    this.UpdateRateMsMaximum == input.UpdateRateMsMaximum ||
                    (this.UpdateRateMsMaximum != null &&
                    this.UpdateRateMsMaximum.Equals(input.UpdateRateMsMaximum))
                ) && 
                (
                    this.UpdateRateMsMinimum == input.UpdateRateMsMinimum ||
                    (this.UpdateRateMsMinimum != null &&
                    this.UpdateRateMsMinimum.Equals(input.UpdateRateMsMinimum))
                ) && 
                (
                    this.UpdateRateMsNormal == input.UpdateRateMsNormal ||
                    (this.UpdateRateMsNormal != null &&
                    this.UpdateRateMsNormal.Equals(input.UpdateRateMsNormal))
                ) && 
                (
                    this.UpdateRateMsUdonManual == input.UpdateRateMsUdonManual ||
                    (this.UpdateRateMsUdonManual != null &&
                    this.UpdateRateMsUdonManual.Equals(input.UpdateRateMsUdonManual))
                ) && 
                (
                    this.UploadAnalysisPercent == input.UploadAnalysisPercent ||
                    (this.UploadAnalysisPercent != null &&
                    this.UploadAnalysisPercent.Equals(input.UploadAnalysisPercent))
                ) && 
                (
                    this.UrlList == input.UrlList ||
                    this.UrlList != null &&
                    input.UrlList != null &&
                    this.UrlList.SequenceEqual(input.UrlList)
                ) && 
                (
                    this.UseReliableUdpForVoice == input.UseReliableUdpForVoice ||
                    (this.UseReliableUdpForVoice != null &&
                    this.UseReliableUdpForVoice.Equals(input.UseReliableUdpForVoice))
                ) && 
                (
                    this.UserUpdatePeriod == input.UserUpdatePeriod ||
                    (this.UserUpdatePeriod != null &&
                    this.UserUpdatePeriod.Equals(input.UserUpdatePeriod))
                ) && 
                (
                    this.UserVerificationDelay == input.UserVerificationDelay ||
                    (this.UserVerificationDelay != null &&
                    this.UserVerificationDelay.Equals(input.UserVerificationDelay))
                ) && 
                (
                    this.UserVerificationRetry == input.UserVerificationRetry ||
                    (this.UserVerificationRetry != null &&
                    this.UserVerificationRetry.Equals(input.UserVerificationRetry))
                ) && 
                (
                    this.UserVerificationTimeout == input.UserVerificationTimeout ||
                    (this.UserVerificationTimeout != null &&
                    this.UserVerificationTimeout.Equals(input.UserVerificationTimeout))
                ) && 
                (
                    this.ViveWindowsUrl == input.ViveWindowsUrl ||
                    (this.ViveWindowsUrl != null &&
                    this.ViveWindowsUrl.Equals(input.ViveWindowsUrl))
                ) && 
                (
                    this.WhiteListedAssetUrls == input.WhiteListedAssetUrls ||
                    this.WhiteListedAssetUrls != null &&
                    input.WhiteListedAssetUrls != null &&
                    this.WhiteListedAssetUrls.SequenceEqual(input.WhiteListedAssetUrls)
                ) && 
                (
                    this.WorldUpdatePeriod == input.WorldUpdatePeriod ||
                    (this.WorldUpdatePeriod != null &&
                    this.WorldUpdatePeriod.Equals(input.WorldUpdatePeriod))
                ) && 
                (
                    this.YoutubedlHash == input.YoutubedlHash ||
                    (this.YoutubedlHash != null &&
                    this.YoutubedlHash.Equals(input.YoutubedlHash))
                ) && 
                (
                    this.YoutubedlVersion == input.YoutubedlVersion ||
                    (this.YoutubedlVersion != null &&
                    this.YoutubedlVersion.Equals(input.YoutubedlVersion))
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
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.Announcements != null)
                    hashCode = hashCode * 59 + this.Announcements.GetHashCode();
                if (this.ApiKey != null)
                    hashCode = hashCode * 59 + this.ApiKey.GetHashCode();
                if (this.AppName != null)
                    hashCode = hashCode * 59 + this.AppName.GetHashCode();
                if (this.BuildVersionTag != null)
                    hashCode = hashCode * 59 + this.BuildVersionTag.GetHashCode();
                if (this.ClientApiKey != null)
                    hashCode = hashCode * 59 + this.ClientApiKey.GetHashCode();
                if (this.ClientBPSCeiling != null)
                    hashCode = hashCode * 59 + this.ClientBPSCeiling.GetHashCode();
                if (this.ClientDisconnectTimeout != null)
                    hashCode = hashCode * 59 + this.ClientDisconnectTimeout.GetHashCode();
                if (this.ClientReservedPlayerBPS != null)
                    hashCode = hashCode * 59 + this.ClientReservedPlayerBPS.GetHashCode();
                if (this.ClientSentCountAllowance != null)
                    hashCode = hashCode * 59 + this.ClientSentCountAllowance.GetHashCode();
                if (this.ContactEmail != null)
                    hashCode = hashCode * 59 + this.ContactEmail.GetHashCode();
                if (this.CopyrightEmail != null)
                    hashCode = hashCode * 59 + this.CopyrightEmail.GetHashCode();
                if (this.CurrentTOSVersion != null)
                    hashCode = hashCode * 59 + this.CurrentTOSVersion.GetHashCode();
                if (this.DefaultAvatar != null)
                    hashCode = hashCode * 59 + this.DefaultAvatar.GetHashCode();
                if (this.DeploymentGroup != null)
                    hashCode = hashCode * 59 + this.DeploymentGroup.GetHashCode();
                if (this.DevAppVersionStandalone != null)
                    hashCode = hashCode * 59 + this.DevAppVersionStandalone.GetHashCode();
                if (this.DevDownloadLinkWindows != null)
                    hashCode = hashCode * 59 + this.DevDownloadLinkWindows.GetHashCode();
                if (this.DevSdkUrl != null)
                    hashCode = hashCode * 59 + this.DevSdkUrl.GetHashCode();
                if (this.DevSdkVersion != null)
                    hashCode = hashCode * 59 + this.DevSdkVersion.GetHashCode();
                if (this.DevServerVersionStandalone != null)
                    hashCode = hashCode * 59 + this.DevServerVersionStandalone.GetHashCode();
                if (this.DisableAvatarCopying != null)
                    hashCode = hashCode * 59 + this.DisableAvatarCopying.GetHashCode();
                if (this.DisableAvatarGating != null)
                    hashCode = hashCode * 59 + this.DisableAvatarGating.GetHashCode();
                if (this.DisableCommunityLabs != null)
                    hashCode = hashCode * 59 + this.DisableCommunityLabs.GetHashCode();
                if (this.DisableCommunityLabsPromotion != null)
                    hashCode = hashCode * 59 + this.DisableCommunityLabsPromotion.GetHashCode();
                if (this.DisableEmail != null)
                    hashCode = hashCode * 59 + this.DisableEmail.GetHashCode();
                if (this.DisableEventStream != null)
                    hashCode = hashCode * 59 + this.DisableEventStream.GetHashCode();
                if (this.DisableFeedbackGating != null)
                    hashCode = hashCode * 59 + this.DisableFeedbackGating.GetHashCode();
                if (this.DisableHello != null)
                    hashCode = hashCode * 59 + this.DisableHello.GetHashCode();
                if (this.DisableRegistration != null)
                    hashCode = hashCode * 59 + this.DisableRegistration.GetHashCode();
                if (this.DisableSteamNetworking != null)
                    hashCode = hashCode * 59 + this.DisableSteamNetworking.GetHashCode();
                if (this.DisableTwoFactorAuth != null)
                    hashCode = hashCode * 59 + this.DisableTwoFactorAuth.GetHashCode();
                if (this.DisableUdon != null)
                    hashCode = hashCode * 59 + this.DisableUdon.GetHashCode();
                if (this.DisableUpgradeAccount != null)
                    hashCode = hashCode * 59 + this.DisableUpgradeAccount.GetHashCode();
                if (this.DownloadLinkWindows != null)
                    hashCode = hashCode * 59 + this.DownloadLinkWindows.GetHashCode();
                if (this.DownloadUrls != null)
                    hashCode = hashCode * 59 + this.DownloadUrls.GetHashCode();
                if (this.DynamicWorldRows != null)
                    hashCode = hashCode * 59 + this.DynamicWorldRows.GetHashCode();
                if (this.Events != null)
                    hashCode = hashCode * 59 + this.Events.GetHashCode();
                if (this.GearDemoRoomId != null)
                    hashCode = hashCode * 59 + this.GearDemoRoomId.GetHashCode();
                if (this.HomepageRedirectTarget != null)
                    hashCode = hashCode * 59 + this.HomepageRedirectTarget.GetHashCode();
                if (this.HomeWorldId != null)
                    hashCode = hashCode * 59 + this.HomeWorldId.GetHashCode();
                if (this.HubWorldId != null)
                    hashCode = hashCode * 59 + this.HubWorldId.GetHashCode();
                if (this.JobsEmail != null)
                    hashCode = hashCode * 59 + this.JobsEmail.GetHashCode();
                if (this.MessageOfTheDay != null)
                    hashCode = hashCode * 59 + this.MessageOfTheDay.GetHashCode();
                if (this.ModerationEmail != null)
                    hashCode = hashCode * 59 + this.ModerationEmail.GetHashCode();
                if (this.ModerationQueryPeriod != null)
                    hashCode = hashCode * 59 + this.ModerationQueryPeriod.GetHashCode();
                if (this.NotAllowedToSelectAvatarInPrivateWorldMessage != null)
                    hashCode = hashCode * 59 + this.NotAllowedToSelectAvatarInPrivateWorldMessage.GetHashCode();
                if (this.Plugin != null)
                    hashCode = hashCode * 59 + this.Plugin.GetHashCode();
                if (this.ReleaseAppVersionStandalone != null)
                    hashCode = hashCode * 59 + this.ReleaseAppVersionStandalone.GetHashCode();
                if (this.ReleaseSdkUrl != null)
                    hashCode = hashCode * 59 + this.ReleaseSdkUrl.GetHashCode();
                if (this.ReleaseSdkVersion != null)
                    hashCode = hashCode * 59 + this.ReleaseSdkVersion.GetHashCode();
                if (this.ReleaseServerVersionStandalone != null)
                    hashCode = hashCode * 59 + this.ReleaseServerVersionStandalone.GetHashCode();
                if (this.SdkDeveloperFaqUrl != null)
                    hashCode = hashCode * 59 + this.SdkDeveloperFaqUrl.GetHashCode();
                if (this.SdkDiscordUrl != null)
                    hashCode = hashCode * 59 + this.SdkDiscordUrl.GetHashCode();
                if (this.SdkNotAllowedToPublishMessage != null)
                    hashCode = hashCode * 59 + this.SdkNotAllowedToPublishMessage.GetHashCode();
                if (this.SdkUnityVersion != null)
                    hashCode = hashCode * 59 + this.SdkUnityVersion.GetHashCode();
                if (this.ServerName != null)
                    hashCode = hashCode * 59 + this.ServerName.GetHashCode();
                if (this.SupportEmail != null)
                    hashCode = hashCode * 59 + this.SupportEmail.GetHashCode();
                if (this.TimeOutWorldId != null)
                    hashCode = hashCode * 59 + this.TimeOutWorldId.GetHashCode();
                if (this.TutorialWorldId != null)
                    hashCode = hashCode * 59 + this.TutorialWorldId.GetHashCode();
                if (this.UpdateRateMsMaximum != null)
                    hashCode = hashCode * 59 + this.UpdateRateMsMaximum.GetHashCode();
                if (this.UpdateRateMsMinimum != null)
                    hashCode = hashCode * 59 + this.UpdateRateMsMinimum.GetHashCode();
                if (this.UpdateRateMsNormal != null)
                    hashCode = hashCode * 59 + this.UpdateRateMsNormal.GetHashCode();
                if (this.UpdateRateMsUdonManual != null)
                    hashCode = hashCode * 59 + this.UpdateRateMsUdonManual.GetHashCode();
                if (this.UploadAnalysisPercent != null)
                    hashCode = hashCode * 59 + this.UploadAnalysisPercent.GetHashCode();
                if (this.UrlList != null)
                    hashCode = hashCode * 59 + this.UrlList.GetHashCode();
                if (this.UseReliableUdpForVoice != null)
                    hashCode = hashCode * 59 + this.UseReliableUdpForVoice.GetHashCode();
                if (this.UserUpdatePeriod != null)
                    hashCode = hashCode * 59 + this.UserUpdatePeriod.GetHashCode();
                if (this.UserVerificationDelay != null)
                    hashCode = hashCode * 59 + this.UserVerificationDelay.GetHashCode();
                if (this.UserVerificationRetry != null)
                    hashCode = hashCode * 59 + this.UserVerificationRetry.GetHashCode();
                if (this.UserVerificationTimeout != null)
                    hashCode = hashCode * 59 + this.UserVerificationTimeout.GetHashCode();
                if (this.ViveWindowsUrl != null)
                    hashCode = hashCode * 59 + this.ViveWindowsUrl.GetHashCode();
                if (this.WhiteListedAssetUrls != null)
                    hashCode = hashCode * 59 + this.WhiteListedAssetUrls.GetHashCode();
                if (this.WorldUpdatePeriod != null)
                    hashCode = hashCode * 59 + this.WorldUpdatePeriod.GetHashCode();
                if (this.YoutubedlHash != null)
                    hashCode = hashCode * 59 + this.YoutubedlHash.GetHashCode();
                if (this.YoutubedlVersion != null)
                    hashCode = hashCode * 59 + this.YoutubedlVersion.GetHashCode();
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

            // Address (string) minLength
            if(this.Address != null && this.Address.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Address, length must be greater than 1.", new [] { "Address" });
            }
 

 

            // ApiKey (string) minLength
            if(this.ApiKey != null && this.ApiKey.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ApiKey, length must be greater than 1.", new [] { "ApiKey" });
            }
 

            // AppName (string) minLength
            if(this.AppName != null && this.AppName.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AppName, length must be greater than 1.", new [] { "AppName" });
            }
 

            // BuildVersionTag (string) minLength
            if(this.BuildVersionTag != null && this.BuildVersionTag.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BuildVersionTag, length must be greater than 1.", new [] { "BuildVersionTag" });
            }
 

            // ClientApiKey (string) minLength
            if(this.ClientApiKey != null && this.ClientApiKey.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ClientApiKey, length must be greater than 1.", new [] { "ClientApiKey" });
            }
 

            // ContactEmail (string) minLength
            if(this.ContactEmail != null && this.ContactEmail.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ContactEmail, length must be greater than 1.", new [] { "ContactEmail" });
            }
 

            // CopyrightEmail (string) minLength
            if(this.CopyrightEmail != null && this.CopyrightEmail.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CopyrightEmail, length must be greater than 1.", new [] { "CopyrightEmail" });
            }
 

 
            // DefaultAvatar (string) pattern
            Regex regexDefaultAvatar = new Regex(@"avtr_[0-9a-fA-F]{8}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{12}", RegexOptions.CultureInvariant);
            if (false == regexDefaultAvatar.Match(this.DefaultAvatar).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DefaultAvatar, must match a pattern of " + regexDefaultAvatar, new [] { "DefaultAvatar" });
            }


            // DevAppVersionStandalone (string) minLength
            if(this.DevAppVersionStandalone != null && this.DevAppVersionStandalone.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DevAppVersionStandalone, length must be greater than 1.", new [] { "DevAppVersionStandalone" });
            }
 

            // DevDownloadLinkWindows (string) minLength
            if(this.DevDownloadLinkWindows != null && this.DevDownloadLinkWindows.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DevDownloadLinkWindows, length must be greater than 1.", new [] { "DevDownloadLinkWindows" });
            }
 

            // DevSdkUrl (string) minLength
            if(this.DevSdkUrl != null && this.DevSdkUrl.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DevSdkUrl, length must be greater than 1.", new [] { "DevSdkUrl" });
            }
 

            // DevSdkVersion (string) minLength
            if(this.DevSdkVersion != null && this.DevSdkVersion.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DevSdkVersion, length must be greater than 1.", new [] { "DevSdkVersion" });
            }
 

            // DevServerVersionStandalone (string) minLength
            if(this.DevServerVersionStandalone != null && this.DevServerVersionStandalone.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DevServerVersionStandalone, length must be greater than 1.", new [] { "DevServerVersionStandalone" });
            }
 

            // DownloadLinkWindows (string) minLength
            if(this.DownloadLinkWindows != null && this.DownloadLinkWindows.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DownloadLinkWindows, length must be greater than 1.", new [] { "DownloadLinkWindows" });
            }
 

 

            // GearDemoRoomId (string) minLength
            if(this.GearDemoRoomId != null && this.GearDemoRoomId.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for GearDemoRoomId, length must be greater than 1.", new [] { "GearDemoRoomId" });
            }
 

            // HomepageRedirectTarget (string) minLength
            if(this.HomepageRedirectTarget != null && this.HomepageRedirectTarget.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for HomepageRedirectTarget, length must be greater than 1.", new [] { "HomepageRedirectTarget" });
            }
 

 
            // HomeWorldId (string) pattern
            Regex regexHomeWorldId = new Regex(@"(^$|offline|(wrld|wld)_[0-9a-fA-F]{8}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{12})", RegexOptions.CultureInvariant);
            if (false == regexHomeWorldId.Match(this.HomeWorldId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for HomeWorldId, must match a pattern of " + regexHomeWorldId, new [] { "HomeWorldId" });
            }


 
            // HubWorldId (string) pattern
            Regex regexHubWorldId = new Regex(@"(^$|offline|(wrld|wld)_[0-9a-fA-F]{8}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{12})", RegexOptions.CultureInvariant);
            if (false == regexHubWorldId.Match(this.HubWorldId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for HubWorldId, must match a pattern of " + regexHubWorldId, new [] { "HubWorldId" });
            }


            // JobsEmail (string) minLength
            if(this.JobsEmail != null && this.JobsEmail.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for JobsEmail, length must be greater than 1.", new [] { "JobsEmail" });
            }
 

            // MessageOfTheDay (string) minLength
            if(this.MessageOfTheDay != null && this.MessageOfTheDay.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MessageOfTheDay, length must be greater than 1.", new [] { "MessageOfTheDay" });
            }
 

            // ModerationEmail (string) minLength
            if(this.ModerationEmail != null && this.ModerationEmail.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ModerationEmail, length must be greater than 1.", new [] { "ModerationEmail" });
            }
 

            // NotAllowedToSelectAvatarInPrivateWorldMessage (string) minLength
            if(this.NotAllowedToSelectAvatarInPrivateWorldMessage != null && this.NotAllowedToSelectAvatarInPrivateWorldMessage.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for NotAllowedToSelectAvatarInPrivateWorldMessage, length must be greater than 1.", new [] { "NotAllowedToSelectAvatarInPrivateWorldMessage" });
            }
 

            // Plugin (string) minLength
            if(this.Plugin != null && this.Plugin.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Plugin, length must be greater than 1.", new [] { "Plugin" });
            }
 

            // ReleaseAppVersionStandalone (string) minLength
            if(this.ReleaseAppVersionStandalone != null && this.ReleaseAppVersionStandalone.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ReleaseAppVersionStandalone, length must be greater than 1.", new [] { "ReleaseAppVersionStandalone" });
            }
 

            // ReleaseSdkUrl (string) minLength
            if(this.ReleaseSdkUrl != null && this.ReleaseSdkUrl.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ReleaseSdkUrl, length must be greater than 1.", new [] { "ReleaseSdkUrl" });
            }
 

            // ReleaseSdkVersion (string) minLength
            if(this.ReleaseSdkVersion != null && this.ReleaseSdkVersion.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ReleaseSdkVersion, length must be greater than 1.", new [] { "ReleaseSdkVersion" });
            }
 

            // ReleaseServerVersionStandalone (string) minLength
            if(this.ReleaseServerVersionStandalone != null && this.ReleaseServerVersionStandalone.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ReleaseServerVersionStandalone, length must be greater than 1.", new [] { "ReleaseServerVersionStandalone" });
            }
 

            // SdkDeveloperFaqUrl (string) minLength
            if(this.SdkDeveloperFaqUrl != null && this.SdkDeveloperFaqUrl.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SdkDeveloperFaqUrl, length must be greater than 1.", new [] { "SdkDeveloperFaqUrl" });
            }
 

            // SdkDiscordUrl (string) minLength
            if(this.SdkDiscordUrl != null && this.SdkDiscordUrl.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SdkDiscordUrl, length must be greater than 1.", new [] { "SdkDiscordUrl" });
            }
 

            // SdkNotAllowedToPublishMessage (string) minLength
            if(this.SdkNotAllowedToPublishMessage != null && this.SdkNotAllowedToPublishMessage.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SdkNotAllowedToPublishMessage, length must be greater than 1.", new [] { "SdkNotAllowedToPublishMessage" });
            }
 

            // SdkUnityVersion (string) minLength
            if(this.SdkUnityVersion != null && this.SdkUnityVersion.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SdkUnityVersion, length must be greater than 1.", new [] { "SdkUnityVersion" });
            }
 

            // ServerName (string) minLength
            if(this.ServerName != null && this.ServerName.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ServerName, length must be greater than 1.", new [] { "ServerName" });
            }
 

            // SupportEmail (string) minLength
            if(this.SupportEmail != null && this.SupportEmail.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SupportEmail, length must be greater than 1.", new [] { "SupportEmail" });
            }
 

 
            // TimeOutWorldId (string) pattern
            Regex regexTimeOutWorldId = new Regex(@"(^$|offline|(wrld|wld)_[0-9a-fA-F]{8}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{12})", RegexOptions.CultureInvariant);
            if (false == regexTimeOutWorldId.Match(this.TimeOutWorldId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TimeOutWorldId, must match a pattern of " + regexTimeOutWorldId, new [] { "TimeOutWorldId" });
            }


 
            // TutorialWorldId (string) pattern
            Regex regexTutorialWorldId = new Regex(@"(^$|offline|(wrld|wld)_[0-9a-fA-F]{8}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{12})", RegexOptions.CultureInvariant);
            if (false == regexTutorialWorldId.Match(this.TutorialWorldId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TutorialWorldId, must match a pattern of " + regexTutorialWorldId, new [] { "TutorialWorldId" });
            }


            // ViveWindowsUrl (string) minLength
            if(this.ViveWindowsUrl != null && this.ViveWindowsUrl.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ViveWindowsUrl, length must be greater than 1.", new [] { "ViveWindowsUrl" });
            }
 

            // YoutubedlHash (string) minLength
            if(this.YoutubedlHash != null && this.YoutubedlHash.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for YoutubedlHash, length must be greater than 1.", new [] { "YoutubedlHash" });
            }
 

            // YoutubedlVersion (string) minLength
            if(this.YoutubedlVersion != null && this.YoutubedlVersion.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for YoutubedlVersion, length must be greater than 1.", new [] { "YoutubedlVersion" });
            }
 
            yield break;
        }
    }

}
