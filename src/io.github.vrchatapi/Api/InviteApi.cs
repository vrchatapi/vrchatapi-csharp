/*
 * VRChat API Documentation
 *
 * ![VRChat API Banner](https://vrchatapi.github.io/assets/img/api_banner_1500x400.png)  # Welcome to the VRChat API  Before we begin, we would like to state this is a **COMMUNITY DRIVEN PROJECT**. This means that everything you read on here was written by the community itself and is **not** officially supported by VRChat. The documentation is provided \"AS IS\", and any action you take towards VRChat is completely your own responsibility.  The documentation and additional libraries SHALL ONLY be used for applications interacting with VRChat's API in accordance with their [Terms of Service](https://github.com/VRChatAPI), and MUST NOT be used for modifying the client, \"avatar ripping\", or other illegal activities. Malicious usage or spamming the API may result in account termination. Certain parts of the API are also more sensitive than others, for example moderation, so please tread extra carefully and read the warnings when present.  ![Tupper Policy on API](https://i.imgur.com/yLlW7Ok.png)  Finally, use of the API using applications other than the approved methods (website, VRChat application, Unity SDK) is not officially supported. VRChat provides no guarantee or support for external applications using the API. Access to API endpoints may break **at any time, without notice**. Therefore, please **do not ping** VRChat Staff in the VRChat Discord if you are having API problems, as they do not provide API support. We will make a best effort in keeping this documentation and associated language libraries up to date, but things might be outdated or missing. If you find that something is no longer valid, please contact us on Discord or [create an issue](https://github.com/vrchatapi/specification/issues) and tell us so we can fix it.  # Getting Started  The VRChat API can be used to programmatically retrieve or update information regarding your profile, friends, avatars, worlds and more. The API consists of two parts, \"Photon\" which is only used in-game, and the \"Web API\" which is used by both the game and the website. This documentation focuses only on the Web API.  The API is designed around the REST ideology, providing semi-simple and usually predictable URIs to access and modify objects. Requests support standard HTTP methods like GET, PUT, POST, and DELETE and standard status codes. Response bodies are always UTF-8 encoded JSON objects, unless explicitly documented otherwise.  <div class=\"callout callout-error\">   <strong>🛑 Warning! Do not touch Photon!</strong><br>   Photon is only used by the in-game client and should <b>not</b> be touched. Doing so may result in permanent account termination. </div>  <div class=\"callout callout-info\">   <strong>ℹ️ API Key and Authentication</strong><br>   The API Key has always been the same and is currently <code>JlE5Jldo5Jibnk5O5hTx6XVqsJu4WJ26</code>.   Read <a href=\"#tag- -authentication\">Authentication</a> for how to log in. </div>  # Using the API  For simply exploring what the API can do it is strongly recommended to download [Insomnia](https://insomnia.rest/download), a free and open-source API client that's great for sending requests to the API in an orderly fashion. Insomnia allows you to send data in the format that's required for VRChat's API. It is also possible to try out the API in your browser, by first logging in at [vrchat.com/home](https://vrchat.com/home/) and then going to [vrchat.com/api/1/auth/user](https://vrchat.com/api/1/auth/user), but the information will be much harder to work with.  For more permanent operation such as software development it is instead recommended to use one of the existing language SDKs. This community project maintains API libraries in several languages, which allows you to interact with the API with simple function calls rather than having to implement the HTTP protocol yourself. Most of these libraries are automatically generated from the API specification, sometimes with additional helpful wrapper code to make usage easier. This allows them to be almost automatically updated and expanded upon as soon as a new feature is introduced in the specification itself. The libraries can be found on [GitHub](https://github.com/vrchatapi) or following:  * [NodeJS (JavaScript)](https://www.npmjs.com/package/vrchat) * [Dart](https://pub.dev/packages/vrchat_dart) * [Rust](https://crates.io/crates/vrchatapi) * [C#](https://github.com/vrchatapi/vrchatapi-csharp) * [Python](https://github.com/vrchatapi/VRChatPython)  # Pagination  Most endpoints enforce pagination, meaning they will only return 10 entries by default, and never more than 100.<br> Using both the limit and offset parameters allows you to easily paginate through a large number of objects.  | Query Parameter | Type | Description | | - -- -- -- -- -|- -|- -- -- -- | | `limit` | integer  | The number of objects to return. This value often defaults to 10. Highest limit is always 100.| | `offset` | integer  | A zero-based offset from the default object sorting.|  If a request returns fewer objects than the `limit` parameter, there are no more items available to return.  # Contribution  Do you want to get involved in the documentation effort? Do you want to help improve one of the language API libraries? This project is an [OPEN Open Source Project](https://openopensource.org)! This means that individuals making significant and valuable contributions are given commit-access to the project. It also means we are very open and welcoming of new people making contributions, unlike some more guarded open-source projects.  [![Discord](https://img.shields.io/static/v1?label=vrchatapi&message=discord&color=blueviolet&style=for-the-badge)](https://discord.gg/qjZE9C9fkB)
 *
 * The version of the OpenAPI document: 1.3.3
 * Contact: me@ruby.js.org
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using RestSharp;
using io.github.vrchatapi.Client;
using io.github.vrchatapi.Model;

namespace io.github.vrchatapi.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IInviteApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get Invite Messages
        /// </summary>
        /// <remarks>
        /// Returns a single Invite Message. This returns the exact same information but less than &#x60;getInviteMessages&#x60;. Admin Credentials are required to view messages of other users!
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="messageId"></param>
        /// <returns>InviteMessage</returns>
        InviteMessage GetInviteMessage (string userId, int messageId);

        /// <summary>
        /// Get Invite Messages
        /// </summary>
        /// <remarks>
        /// Returns a single Invite Message. This returns the exact same information but less than &#x60;getInviteMessages&#x60;. Admin Credentials are required to view messages of other users!
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="messageId"></param>
        /// <returns>ApiResponse of InviteMessage</returns>
        ApiResponse<InviteMessage> GetInviteMessageWithHttpInfo (string userId, int messageId);
        /// <summary>
        /// List Invite Messages
        /// </summary>
        /// <remarks>
        /// Returns a list of all that users Invite Messages. Admin Credentials are required to view messages of other users!
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <returns>List&lt;InviteMessage&gt;</returns>
        List<InviteMessage> GetInviteMessages (string userId);

        /// <summary>
        /// List Invite Messages
        /// </summary>
        /// <remarks>
        /// Returns a list of all that users Invite Messages. Admin Credentials are required to view messages of other users!
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <returns>ApiResponse of List&lt;InviteMessage&gt;</returns>
        ApiResponse<List<InviteMessage>> GetInviteMessagesWithHttpInfo (string userId);
        /// <summary>
        /// Invite User
        /// </summary>
        /// <remarks>
        /// Sends an invite to a user. Returns the Notification of type &#x60;invite&#x60; that was sent.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="inviteRequest">Instance ID when inviting a user. (optional)</param>
        /// <returns>Notification</returns>
        Notification InviteUser (string userId, InviteRequest inviteRequest = default(InviteRequest));

        /// <summary>
        /// Invite User
        /// </summary>
        /// <remarks>
        /// Sends an invite to a user. Returns the Notification of type &#x60;invite&#x60; that was sent.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="inviteRequest">Instance ID when inviting a user. (optional)</param>
        /// <returns>ApiResponse of Notification</returns>
        ApiResponse<Notification> InviteUserWithHttpInfo (string userId, InviteRequest inviteRequest = default(InviteRequest));
        /// <summary>
        /// Request Invite
        /// </summary>
        /// <remarks>
        /// Requests an invite from a user. Returns the Notification of type &#x60;requestInvite&#x60; that was sent.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <returns>Notification</returns>
        Notification RequestInvite (string userId);

        /// <summary>
        /// Request Invite
        /// </summary>
        /// <remarks>
        /// Requests an invite from a user. Returns the Notification of type &#x60;requestInvite&#x60; that was sent.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <returns>ApiResponse of Notification</returns>
        ApiResponse<Notification> RequestInviteWithHttpInfo (string userId);
        /// <summary>
        /// Reset Invite Message
        /// </summary>
        /// <remarks>
        /// Resets a single Invite Message back to it&#39;s original message, and then returns a list of all of them. Admin Credentials are required to update messages of other users!  Resetting a message respects the rate-limit, but resetting it does not set the rate-limit to 60 like when editing it. It is possible to edit it right after resetting it. Trying to edit a message before the cooldown timer expires results in a 429 Too Fast Error.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="messageId"></param>
        /// <returns>List&lt;InviteMessage&gt;</returns>
        List<InviteMessage> ResetInviteMessage (string userId, int messageId);

        /// <summary>
        /// Reset Invite Message
        /// </summary>
        /// <remarks>
        /// Resets a single Invite Message back to it&#39;s original message, and then returns a list of all of them. Admin Credentials are required to update messages of other users!  Resetting a message respects the rate-limit, but resetting it does not set the rate-limit to 60 like when editing it. It is possible to edit it right after resetting it. Trying to edit a message before the cooldown timer expires results in a 429 Too Fast Error.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="messageId"></param>
        /// <returns>ApiResponse of List&lt;InviteMessage&gt;</returns>
        ApiResponse<List<InviteMessage>> ResetInviteMessageWithHttpInfo (string userId, int messageId);
        /// <summary>
        /// Respond Invite
        /// </summary>
        /// <remarks>
        /// Sends a world invite to a user.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="notificationId"></param>
        /// <param name="inviteResponse">Instance ID when inviting a user. (optional)</param>
        /// <returns>Notification</returns>
        Notification RespondInvite (string notificationId, InviteResponse inviteResponse = default(InviteResponse));

        /// <summary>
        /// Respond Invite
        /// </summary>
        /// <remarks>
        /// Sends a world invite to a user.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="notificationId"></param>
        /// <param name="inviteResponse">Instance ID when inviting a user. (optional)</param>
        /// <returns>ApiResponse of Notification</returns>
        ApiResponse<Notification> RespondInviteWithHttpInfo (string notificationId, InviteResponse inviteResponse = default(InviteResponse));
        /// <summary>
        /// Update Invite Message
        /// </summary>
        /// <remarks>
        /// Updates a single Invite Message and then returns a list of all of them. Admin Credentials are required to update messages of other users!  Updating a message automatically sets the cooldown timer to 60 minutes. Trying to edit a message before the cooldown timer expires results in a 429 Too Fast Error.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="messageId"></param>
        /// <returns>List&lt;InviteMessage&gt;</returns>
        List<InviteMessage> UpdateInviteMessage (string userId, int messageId);

        /// <summary>
        /// Update Invite Message
        /// </summary>
        /// <remarks>
        /// Updates a single Invite Message and then returns a list of all of them. Admin Credentials are required to update messages of other users!  Updating a message automatically sets the cooldown timer to 60 minutes. Trying to edit a message before the cooldown timer expires results in a 429 Too Fast Error.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="messageId"></param>
        /// <returns>ApiResponse of List&lt;InviteMessage&gt;</returns>
        ApiResponse<List<InviteMessage>> UpdateInviteMessageWithHttpInfo (string userId, int messageId);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get Invite Messages
        /// </summary>
        /// <remarks>
        /// Returns a single Invite Message. This returns the exact same information but less than &#x60;getInviteMessages&#x60;. Admin Credentials are required to view messages of other users!
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="messageId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of InviteMessage</returns>
        System.Threading.Tasks.Task<InviteMessage> GetInviteMessageAsync (string userId, int messageId, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get Invite Messages
        /// </summary>
        /// <remarks>
        /// Returns a single Invite Message. This returns the exact same information but less than &#x60;getInviteMessages&#x60;. Admin Credentials are required to view messages of other users!
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="messageId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (InviteMessage)</returns>
        System.Threading.Tasks.Task<ApiResponse<InviteMessage>> GetInviteMessageWithHttpInfoAsync (string userId, int messageId, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// List Invite Messages
        /// </summary>
        /// <remarks>
        /// Returns a list of all that users Invite Messages. Admin Credentials are required to view messages of other users!
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of List&lt;InviteMessage&gt;</returns>
        System.Threading.Tasks.Task<List<InviteMessage>> GetInviteMessagesAsync (string userId, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// List Invite Messages
        /// </summary>
        /// <remarks>
        /// Returns a list of all that users Invite Messages. Admin Credentials are required to view messages of other users!
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (List&lt;InviteMessage&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<InviteMessage>>> GetInviteMessagesWithHttpInfoAsync (string userId, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Invite User
        /// </summary>
        /// <remarks>
        /// Sends an invite to a user. Returns the Notification of type &#x60;invite&#x60; that was sent.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="inviteRequest">Instance ID when inviting a user. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of Notification</returns>
        System.Threading.Tasks.Task<Notification> InviteUserAsync (string userId, InviteRequest inviteRequest = default(InviteRequest), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Invite User
        /// </summary>
        /// <remarks>
        /// Sends an invite to a user. Returns the Notification of type &#x60;invite&#x60; that was sent.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="inviteRequest">Instance ID when inviting a user. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (Notification)</returns>
        System.Threading.Tasks.Task<ApiResponse<Notification>> InviteUserWithHttpInfoAsync (string userId, InviteRequest inviteRequest = default(InviteRequest), CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Request Invite
        /// </summary>
        /// <remarks>
        /// Requests an invite from a user. Returns the Notification of type &#x60;requestInvite&#x60; that was sent.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of Notification</returns>
        System.Threading.Tasks.Task<Notification> RequestInviteAsync (string userId, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Request Invite
        /// </summary>
        /// <remarks>
        /// Requests an invite from a user. Returns the Notification of type &#x60;requestInvite&#x60; that was sent.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (Notification)</returns>
        System.Threading.Tasks.Task<ApiResponse<Notification>> RequestInviteWithHttpInfoAsync (string userId, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Reset Invite Message
        /// </summary>
        /// <remarks>
        /// Resets a single Invite Message back to it&#39;s original message, and then returns a list of all of them. Admin Credentials are required to update messages of other users!  Resetting a message respects the rate-limit, but resetting it does not set the rate-limit to 60 like when editing it. It is possible to edit it right after resetting it. Trying to edit a message before the cooldown timer expires results in a 429 Too Fast Error.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="messageId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of List&lt;InviteMessage&gt;</returns>
        System.Threading.Tasks.Task<List<InviteMessage>> ResetInviteMessageAsync (string userId, int messageId, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Reset Invite Message
        /// </summary>
        /// <remarks>
        /// Resets a single Invite Message back to it&#39;s original message, and then returns a list of all of them. Admin Credentials are required to update messages of other users!  Resetting a message respects the rate-limit, but resetting it does not set the rate-limit to 60 like when editing it. It is possible to edit it right after resetting it. Trying to edit a message before the cooldown timer expires results in a 429 Too Fast Error.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="messageId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (List&lt;InviteMessage&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<InviteMessage>>> ResetInviteMessageWithHttpInfoAsync (string userId, int messageId, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Respond Invite
        /// </summary>
        /// <remarks>
        /// Sends a world invite to a user.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="notificationId"></param>
        /// <param name="inviteResponse">Instance ID when inviting a user. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of Notification</returns>
        System.Threading.Tasks.Task<Notification> RespondInviteAsync (string notificationId, InviteResponse inviteResponse = default(InviteResponse), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Respond Invite
        /// </summary>
        /// <remarks>
        /// Sends a world invite to a user.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="notificationId"></param>
        /// <param name="inviteResponse">Instance ID when inviting a user. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (Notification)</returns>
        System.Threading.Tasks.Task<ApiResponse<Notification>> RespondInviteWithHttpInfoAsync (string notificationId, InviteResponse inviteResponse = default(InviteResponse), CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Update Invite Message
        /// </summary>
        /// <remarks>
        /// Updates a single Invite Message and then returns a list of all of them. Admin Credentials are required to update messages of other users!  Updating a message automatically sets the cooldown timer to 60 minutes. Trying to edit a message before the cooldown timer expires results in a 429 Too Fast Error.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="messageId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of List&lt;InviteMessage&gt;</returns>
        System.Threading.Tasks.Task<List<InviteMessage>> UpdateInviteMessageAsync (string userId, int messageId, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Update Invite Message
        /// </summary>
        /// <remarks>
        /// Updates a single Invite Message and then returns a list of all of them. Admin Credentials are required to update messages of other users!  Updating a message automatically sets the cooldown timer to 60 minutes. Trying to edit a message before the cooldown timer expires results in a 429 Too Fast Error.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="messageId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (List&lt;InviteMessage&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<InviteMessage>>> UpdateInviteMessageWithHttpInfoAsync (string userId, int messageId, CancellationToken cancellationToken = default(CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class InviteApi : IInviteApi
    {
        private io.github.vrchatapi.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="InviteApi"/> class.
        /// </summary>
        /// <returns></returns>
        public InviteApi(String basePath)
        {
            this.Configuration = new io.github.vrchatapi.Client.Configuration { BasePath = basePath };

            ExceptionFactory = io.github.vrchatapi.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InviteApi"/> class
        /// </summary>
        /// <returns></returns>
        public InviteApi()
        {
            this.Configuration = io.github.vrchatapi.Client.Configuration.Default;

            ExceptionFactory = io.github.vrchatapi.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InviteApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public InviteApi(io.github.vrchatapi.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = io.github.vrchatapi.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = io.github.vrchatapi.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public io.github.vrchatapi.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public io.github.vrchatapi.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Get Invite Messages Returns a single Invite Message. This returns the exact same information but less than &#x60;getInviteMessages&#x60;. Admin Credentials are required to view messages of other users!
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="messageId"></param>
        /// <returns>InviteMessage</returns>
        public InviteMessage GetInviteMessage (string userId, int messageId)
        {
             ApiResponse<InviteMessage> localVarResponse = GetInviteMessageWithHttpInfo(userId, messageId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Invite Messages Returns a single Invite Message. This returns the exact same information but less than &#x60;getInviteMessages&#x60;. Admin Credentials are required to view messages of other users!
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="messageId"></param>
        /// <returns>ApiResponse of InviteMessage</returns>
        public ApiResponse<InviteMessage> GetInviteMessageWithHttpInfo (string userId, int messageId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling InviteApi->GetInviteMessage");
            // verify the required parameter 'messageId' is set
            if (messageId == null)
                throw new ApiException(400, "Missing required parameter 'messageId' when calling InviteApi->GetInviteMessage");

            var localVarPath = "/message/{userId}/message/{messageId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId)); // path parameter
            if (messageId != null) localVarPathParams.Add("messageId", this.Configuration.ApiClient.ParameterToString(messageId)); // path parameter

            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetInviteMessage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InviteMessage>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (InviteMessage) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InviteMessage)));
        }

        /// <summary>
        /// Get Invite Messages Returns a single Invite Message. This returns the exact same information but less than &#x60;getInviteMessages&#x60;. Admin Credentials are required to view messages of other users!
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="messageId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of InviteMessage</returns>
        public async System.Threading.Tasks.Task<InviteMessage> GetInviteMessageAsync (string userId, int messageId, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<InviteMessage> localVarResponse = await GetInviteMessageWithHttpInfoAsync(userId, messageId, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Invite Messages Returns a single Invite Message. This returns the exact same information but less than &#x60;getInviteMessages&#x60;. Admin Credentials are required to view messages of other users!
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="messageId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (InviteMessage)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InviteMessage>> GetInviteMessageWithHttpInfoAsync (string userId, int messageId, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling InviteApi->GetInviteMessage");
            // verify the required parameter 'messageId' is set
            if (messageId == null)
                throw new ApiException(400, "Missing required parameter 'messageId' when calling InviteApi->GetInviteMessage");

            var localVarPath = "/message/{userId}/message/{messageId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId)); // path parameter
            if (messageId != null) localVarPathParams.Add("messageId", this.Configuration.ApiClient.ParameterToString(messageId)); // path parameter

            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetInviteMessage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InviteMessage>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (InviteMessage) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InviteMessage)));
        }

        /// <summary>
        /// List Invite Messages Returns a list of all that users Invite Messages. Admin Credentials are required to view messages of other users!
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <returns>List&lt;InviteMessage&gt;</returns>
        public List<InviteMessage> GetInviteMessages (string userId)
        {
             ApiResponse<List<InviteMessage>> localVarResponse = GetInviteMessagesWithHttpInfo(userId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List Invite Messages Returns a list of all that users Invite Messages. Admin Credentials are required to view messages of other users!
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <returns>ApiResponse of List&lt;InviteMessage&gt;</returns>
        public ApiResponse<List<InviteMessage>> GetInviteMessagesWithHttpInfo (string userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling InviteApi->GetInviteMessages");

            var localVarPath = "/message/{userId}/message";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId)); // path parameter

            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetInviteMessages", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<InviteMessage>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<InviteMessage>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<InviteMessage>)));
        }

        /// <summary>
        /// List Invite Messages Returns a list of all that users Invite Messages. Admin Credentials are required to view messages of other users!
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of List&lt;InviteMessage&gt;</returns>
        public async System.Threading.Tasks.Task<List<InviteMessage>> GetInviteMessagesAsync (string userId, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<List<InviteMessage>> localVarResponse = await GetInviteMessagesWithHttpInfoAsync(userId, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List Invite Messages Returns a list of all that users Invite Messages. Admin Credentials are required to view messages of other users!
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (List&lt;InviteMessage&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<InviteMessage>>> GetInviteMessagesWithHttpInfoAsync (string userId, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling InviteApi->GetInviteMessages");

            var localVarPath = "/message/{userId}/message";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId)); // path parameter

            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetInviteMessages", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<InviteMessage>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<InviteMessage>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<InviteMessage>)));
        }

        /// <summary>
        /// Invite User Sends an invite to a user. Returns the Notification of type &#x60;invite&#x60; that was sent.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="inviteRequest">Instance ID when inviting a user. (optional)</param>
        /// <returns>Notification</returns>
        public Notification InviteUser (string userId, InviteRequest inviteRequest = default(InviteRequest))
        {
             ApiResponse<Notification> localVarResponse = InviteUserWithHttpInfo(userId, inviteRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Invite User Sends an invite to a user. Returns the Notification of type &#x60;invite&#x60; that was sent.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="inviteRequest">Instance ID when inviting a user. (optional)</param>
        /// <returns>ApiResponse of Notification</returns>
        public ApiResponse<Notification> InviteUserWithHttpInfo (string userId, InviteRequest inviteRequest = default(InviteRequest))
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling InviteApi->InviteUser");

            var localVarPath = "/invite/{userId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId)); // path parameter
            if (inviteRequest != null && inviteRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(inviteRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = inviteRequest; // byte array
            }

            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("InviteUser", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Notification>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Notification) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Notification)));
        }

        /// <summary>
        /// Invite User Sends an invite to a user. Returns the Notification of type &#x60;invite&#x60; that was sent.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="inviteRequest">Instance ID when inviting a user. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of Notification</returns>
        public async System.Threading.Tasks.Task<Notification> InviteUserAsync (string userId, InviteRequest inviteRequest = default(InviteRequest), CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<Notification> localVarResponse = await InviteUserWithHttpInfoAsync(userId, inviteRequest, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Invite User Sends an invite to a user. Returns the Notification of type &#x60;invite&#x60; that was sent.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="inviteRequest">Instance ID when inviting a user. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (Notification)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Notification>> InviteUserWithHttpInfoAsync (string userId, InviteRequest inviteRequest = default(InviteRequest), CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling InviteApi->InviteUser");

            var localVarPath = "/invite/{userId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId)); // path parameter
            if (inviteRequest != null && inviteRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(inviteRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = inviteRequest; // byte array
            }

            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("InviteUser", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Notification>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Notification) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Notification)));
        }

        /// <summary>
        /// Request Invite Requests an invite from a user. Returns the Notification of type &#x60;requestInvite&#x60; that was sent.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <returns>Notification</returns>
        public Notification RequestInvite (string userId)
        {
             ApiResponse<Notification> localVarResponse = RequestInviteWithHttpInfo(userId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Request Invite Requests an invite from a user. Returns the Notification of type &#x60;requestInvite&#x60; that was sent.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <returns>ApiResponse of Notification</returns>
        public ApiResponse<Notification> RequestInviteWithHttpInfo (string userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling InviteApi->RequestInvite");

            var localVarPath = "/requestInvite/{userId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId)); // path parameter

            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("RequestInvite", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Notification>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Notification) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Notification)));
        }

        /// <summary>
        /// Request Invite Requests an invite from a user. Returns the Notification of type &#x60;requestInvite&#x60; that was sent.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of Notification</returns>
        public async System.Threading.Tasks.Task<Notification> RequestInviteAsync (string userId, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<Notification> localVarResponse = await RequestInviteWithHttpInfoAsync(userId, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Request Invite Requests an invite from a user. Returns the Notification of type &#x60;requestInvite&#x60; that was sent.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (Notification)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Notification>> RequestInviteWithHttpInfoAsync (string userId, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling InviteApi->RequestInvite");

            var localVarPath = "/requestInvite/{userId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId)); // path parameter

            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("RequestInvite", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Notification>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Notification) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Notification)));
        }

        /// <summary>
        /// Reset Invite Message Resets a single Invite Message back to it&#39;s original message, and then returns a list of all of them. Admin Credentials are required to update messages of other users!  Resetting a message respects the rate-limit, but resetting it does not set the rate-limit to 60 like when editing it. It is possible to edit it right after resetting it. Trying to edit a message before the cooldown timer expires results in a 429 Too Fast Error.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="messageId"></param>
        /// <returns>List&lt;InviteMessage&gt;</returns>
        public List<InviteMessage> ResetInviteMessage (string userId, int messageId)
        {
             ApiResponse<List<InviteMessage>> localVarResponse = ResetInviteMessageWithHttpInfo(userId, messageId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Reset Invite Message Resets a single Invite Message back to it&#39;s original message, and then returns a list of all of them. Admin Credentials are required to update messages of other users!  Resetting a message respects the rate-limit, but resetting it does not set the rate-limit to 60 like when editing it. It is possible to edit it right after resetting it. Trying to edit a message before the cooldown timer expires results in a 429 Too Fast Error.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="messageId"></param>
        /// <returns>ApiResponse of List&lt;InviteMessage&gt;</returns>
        public ApiResponse<List<InviteMessage>> ResetInviteMessageWithHttpInfo (string userId, int messageId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling InviteApi->ResetInviteMessage");
            // verify the required parameter 'messageId' is set
            if (messageId == null)
                throw new ApiException(400, "Missing required parameter 'messageId' when calling InviteApi->ResetInviteMessage");

            var localVarPath = "/message/{userId}/message/{messageId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId)); // path parameter
            if (messageId != null) localVarPathParams.Add("messageId", this.Configuration.ApiClient.ParameterToString(messageId)); // path parameter

            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ResetInviteMessage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<InviteMessage>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<InviteMessage>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<InviteMessage>)));
        }

        /// <summary>
        /// Reset Invite Message Resets a single Invite Message back to it&#39;s original message, and then returns a list of all of them. Admin Credentials are required to update messages of other users!  Resetting a message respects the rate-limit, but resetting it does not set the rate-limit to 60 like when editing it. It is possible to edit it right after resetting it. Trying to edit a message before the cooldown timer expires results in a 429 Too Fast Error.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="messageId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of List&lt;InviteMessage&gt;</returns>
        public async System.Threading.Tasks.Task<List<InviteMessage>> ResetInviteMessageAsync (string userId, int messageId, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<List<InviteMessage>> localVarResponse = await ResetInviteMessageWithHttpInfoAsync(userId, messageId, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Reset Invite Message Resets a single Invite Message back to it&#39;s original message, and then returns a list of all of them. Admin Credentials are required to update messages of other users!  Resetting a message respects the rate-limit, but resetting it does not set the rate-limit to 60 like when editing it. It is possible to edit it right after resetting it. Trying to edit a message before the cooldown timer expires results in a 429 Too Fast Error.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="messageId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (List&lt;InviteMessage&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<InviteMessage>>> ResetInviteMessageWithHttpInfoAsync (string userId, int messageId, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling InviteApi->ResetInviteMessage");
            // verify the required parameter 'messageId' is set
            if (messageId == null)
                throw new ApiException(400, "Missing required parameter 'messageId' when calling InviteApi->ResetInviteMessage");

            var localVarPath = "/message/{userId}/message/{messageId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId)); // path parameter
            if (messageId != null) localVarPathParams.Add("messageId", this.Configuration.ApiClient.ParameterToString(messageId)); // path parameter

            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ResetInviteMessage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<InviteMessage>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<InviteMessage>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<InviteMessage>)));
        }

        /// <summary>
        /// Respond Invite Sends a world invite to a user.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="notificationId"></param>
        /// <param name="inviteResponse">Instance ID when inviting a user. (optional)</param>
        /// <returns>Notification</returns>
        public Notification RespondInvite (string notificationId, InviteResponse inviteResponse = default(InviteResponse))
        {
             ApiResponse<Notification> localVarResponse = RespondInviteWithHttpInfo(notificationId, inviteResponse);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Respond Invite Sends a world invite to a user.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="notificationId"></param>
        /// <param name="inviteResponse">Instance ID when inviting a user. (optional)</param>
        /// <returns>ApiResponse of Notification</returns>
        public ApiResponse<Notification> RespondInviteWithHttpInfo (string notificationId, InviteResponse inviteResponse = default(InviteResponse))
        {
            // verify the required parameter 'notificationId' is set
            if (notificationId == null)
                throw new ApiException(400, "Missing required parameter 'notificationId' when calling InviteApi->RespondInvite");

            var localVarPath = "/invite/{notificationId}/response";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (notificationId != null) localVarPathParams.Add("notificationId", this.Configuration.ApiClient.ParameterToString(notificationId)); // path parameter
            if (inviteResponse != null && inviteResponse.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(inviteResponse); // http body (model) parameter
            }
            else
            {
                localVarPostBody = inviteResponse; // byte array
            }

            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("RespondInvite", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Notification>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Notification) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Notification)));
        }

        /// <summary>
        /// Respond Invite Sends a world invite to a user.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="notificationId"></param>
        /// <param name="inviteResponse">Instance ID when inviting a user. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of Notification</returns>
        public async System.Threading.Tasks.Task<Notification> RespondInviteAsync (string notificationId, InviteResponse inviteResponse = default(InviteResponse), CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<Notification> localVarResponse = await RespondInviteWithHttpInfoAsync(notificationId, inviteResponse, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Respond Invite Sends a world invite to a user.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="notificationId"></param>
        /// <param name="inviteResponse">Instance ID when inviting a user. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (Notification)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Notification>> RespondInviteWithHttpInfoAsync (string notificationId, InviteResponse inviteResponse = default(InviteResponse), CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'notificationId' is set
            if (notificationId == null)
                throw new ApiException(400, "Missing required parameter 'notificationId' when calling InviteApi->RespondInvite");

            var localVarPath = "/invite/{notificationId}/response";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (notificationId != null) localVarPathParams.Add("notificationId", this.Configuration.ApiClient.ParameterToString(notificationId)); // path parameter
            if (inviteResponse != null && inviteResponse.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(inviteResponse); // http body (model) parameter
            }
            else
            {
                localVarPostBody = inviteResponse; // byte array
            }

            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("RespondInvite", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Notification>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Notification) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Notification)));
        }

        /// <summary>
        /// Update Invite Message Updates a single Invite Message and then returns a list of all of them. Admin Credentials are required to update messages of other users!  Updating a message automatically sets the cooldown timer to 60 minutes. Trying to edit a message before the cooldown timer expires results in a 429 Too Fast Error.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="messageId"></param>
        /// <returns>List&lt;InviteMessage&gt;</returns>
        public List<InviteMessage> UpdateInviteMessage (string userId, int messageId)
        {
             ApiResponse<List<InviteMessage>> localVarResponse = UpdateInviteMessageWithHttpInfo(userId, messageId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update Invite Message Updates a single Invite Message and then returns a list of all of them. Admin Credentials are required to update messages of other users!  Updating a message automatically sets the cooldown timer to 60 minutes. Trying to edit a message before the cooldown timer expires results in a 429 Too Fast Error.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="messageId"></param>
        /// <returns>ApiResponse of List&lt;InviteMessage&gt;</returns>
        public ApiResponse<List<InviteMessage>> UpdateInviteMessageWithHttpInfo (string userId, int messageId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling InviteApi->UpdateInviteMessage");
            // verify the required parameter 'messageId' is set
            if (messageId == null)
                throw new ApiException(400, "Missing required parameter 'messageId' when calling InviteApi->UpdateInviteMessage");

            var localVarPath = "/message/{userId}/message/{messageId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId)); // path parameter
            if (messageId != null) localVarPathParams.Add("messageId", this.Configuration.ApiClient.ParameterToString(messageId)); // path parameter

            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdateInviteMessage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<InviteMessage>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<InviteMessage>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<InviteMessage>)));
        }

        /// <summary>
        /// Update Invite Message Updates a single Invite Message and then returns a list of all of them. Admin Credentials are required to update messages of other users!  Updating a message automatically sets the cooldown timer to 60 minutes. Trying to edit a message before the cooldown timer expires results in a 429 Too Fast Error.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="messageId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of List&lt;InviteMessage&gt;</returns>
        public async System.Threading.Tasks.Task<List<InviteMessage>> UpdateInviteMessageAsync (string userId, int messageId, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<List<InviteMessage>> localVarResponse = await UpdateInviteMessageWithHttpInfoAsync(userId, messageId, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update Invite Message Updates a single Invite Message and then returns a list of all of them. Admin Credentials are required to update messages of other users!  Updating a message automatically sets the cooldown timer to 60 minutes. Trying to edit a message before the cooldown timer expires results in a 429 Too Fast Error.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="messageId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (List&lt;InviteMessage&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<InviteMessage>>> UpdateInviteMessageWithHttpInfoAsync (string userId, int messageId, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling InviteApi->UpdateInviteMessage");
            // verify the required parameter 'messageId' is set
            if (messageId == null)
                throw new ApiException(400, "Missing required parameter 'messageId' when calling InviteApi->UpdateInviteMessage");

            var localVarPath = "/message/{userId}/message/{messageId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId)); // path parameter
            if (messageId != null) localVarPathParams.Add("messageId", this.Configuration.ApiClient.ParameterToString(messageId)); // path parameter

            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdateInviteMessage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<InviteMessage>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<InviteMessage>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<InviteMessage>)));
        }

    }
}
