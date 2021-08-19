/*
 * VRChat API Documentation
 *
 * ![VRChat API Banner](https://vrchatapi.github.io/assets/img/api_banner_1500x400.png)  # Welcome to the VRChat API  Before we begin, we would like to state this is a **COMMUNITY DRIVEN PROJECT**. This means that everything you read on here was written by the community itself, and is **not** officially supported by VRChat. The documentation and additional libraries SHALL ONLY be used for applications interacting with VRChat's API, in accordance with their [Terms of Service](https://github.com/VRChatAPI), and MUST NOT be used for modifying the client, \"avatar ripping\", or other illegal activities.  This documentation is provided \"AS IS\", and any action you take towards VRChat is completely your own responsibility. Malicious usage or spamming the API may result in account termination. Certain parts of the API are also more sensitive than others, for example moderation, so please read tread extra carefully and read the warnings when present.  ![Tupper Policy on API](https://i.imgur.com/yLlW7Ok.png)  Finally, use of the API using applications other than the approved methods (website, VRChat application, Unity SDK) is not officially supported. VRChat provides no guarantee for external applications using the API. Access to API endpoints may break **at any time, without notice**. We will make a best effort in keeping this documentation and associated language libraries up to date, but things might be outdated or missing. If you find that something is no longer valid, please contact us on Discord or [create an issue](https://github.com/vrchatapi/specification/issues) and tell us so we can fix it.  # Getting Started  The VRChat API can be used to programatically retrive or update information regarding your profile, friends, avatars, worlds and more. The API consists of two parts, \"Photon\" which is only used in-game, and the \"Web API\" which is used by both the game and the website. This documentation focuses only on the Web API.  The API is designed around the REST ideology, providing semi-simple and usually predictable URIs to access and modify objects. Requests support standard HTTP methods like GET, PUT, POST, and DELETE and standard status codes. Response bodies are always UTF-8 encoded JSON objects, unless explicitly documented otherwise.  <div class=\"callout callout-error\">   <strong>🛑 Warning! Do not touch Photon!</strong><br>   Photon is only used by the in-game client and should <b>not</b> be touched. Doing so may result in permanent account termination. </div>  <div class=\"callout callout-info\">   <strong>ℹ️ API Key and Authentication</strong><br>   The API Key has always been the same, and is currently <code>JlE5Jldo5Jibnk5O5hTx6XVqsJu4WJ26</code>.   Read <a href=\"#tag- -authentication\">Authentication</a> for how to log in. </div>  # Using the API  For simply exploring what the API can do it is strongly recommended to download [Insomnia](https://insomnia.rest/download), a free and open-source API client that's great for sending requests to the API in an orderly fashion. Insomnia allows you to send data in the format that's required for VRChat's API. It is also possible to try out the API in your browser, by first logging in at [vrchat.com/home](https://vrchat.com/home/) and then going to [vrchat.com/api/1/auth/user](https://vrchat.com/api/1/auth/user), but the information will be much harder to work with.  For more permanent operation such as software development it is instead recommended to use one of the existing language SDKs. This community project maintain API libraries in several languages, which allows you to interact with the API with simple function calls rather than having to implement the HTTP protocol yourself. Most of these libraries are automatically generated from the API specification, sometimes with additional helpful wrapper code to make usage easier. This allows them to be almost automatically updated and expanded upon as soon as a new feature is introduced in the specification itself. The libraries can be found on [GitHub](https://github.com/vrchatapi) or following:  * [NodeJS (JavaScript)](https://www.npmjs.com/package/vrchat) * [Dart](https://pub.dev/packages/vrchat_dart) * [Rust](https://crates.io/crates/vrchatapi) * [C#](github.com/vrchatapi/vrchatapi-csharp) * [Python](https://github.com/vrchatapi/VRChatPython)  # Pagination  Most endpoints enforce pagination, meaning they will only return 10 entries by default, and never more than 100.<br> Using both the limit and offset parameters allows you to easily paginate through a large number of objects.  | Query Parameter | Type | Description | | - -- -- -- -- -|- -|- -- -- -- | | `limit` | integer  | The number of objects to return. This value often defaults to 10. Highest limit is always 100.| | `offset` | integer  | A zero-based offset from the default object sorting.|  If a request returns fewer objects than the `limit` parameter, there are no more items available to return.  # Contribution  Do you want to get involved in the documentation effort? Do you want to help improve one of the language API libraries? This project is an [OPEN Open Source Project](https://openopensource.org)! This means that individuals making significant and valuable contributions are given commit-access to the project. It also means we are very open and welcoming of new people making contributions, unlike some more guarded open source projects.  [![Discord](https://img.shields.io/static/v1?label=vrchatapi&message=discord&color=blueviolet&style=for-the-badge)](https://discord.gg/qjZE9C9fkB)
 *
 * The version of the OpenAPI document: 1.0.0
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
    public interface IFriendsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Delete Friend Request
        /// </summary>
        /// <remarks>
        /// Deletes an outgoing pending friend request to another user. To delete an incoming friend request, use the &#x60;deleteNotification&#x60; endpoint instead.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <returns>Success</returns>
        Success DeleteFriendRequest (string userId);

        /// <summary>
        /// Delete Friend Request
        /// </summary>
        /// <remarks>
        /// Deletes an outgoing pending friend request to another user. To delete an incoming friend request, use the &#x60;deleteNotification&#x60; endpoint instead.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <returns>ApiResponse of Success</returns>
        ApiResponse<Success> DeleteFriendRequestWithHttpInfo (string userId);
        /// <summary>
        /// Send Friend Request
        /// </summary>
        /// <remarks>
        /// Send a friend request to another user.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <returns>Notification</returns>
        Notification Friend (string userId);

        /// <summary>
        /// Send Friend Request
        /// </summary>
        /// <remarks>
        /// Send a friend request to another user.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <returns>ApiResponse of Notification</returns>
        ApiResponse<Notification> FriendWithHttpInfo (string userId);
        /// <summary>
        /// Check Friend Status
        /// </summary>
        /// <remarks>
        /// Retrieve if the user is currently a friend with a given user, if they have an outgoing friend request, and if they have an incoming friend request. The proper way to receive and accept friend request is by checking if the user has an incoming &#x60;Notification&#x60; of type &#x60;friendRequest&#x60;, and then accepting that notification.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <returns>InlineResponse2003</returns>
        InlineResponse2003 GetFriendStatus (string userId);

        /// <summary>
        /// Check Friend Status
        /// </summary>
        /// <remarks>
        /// Retrieve if the user is currently a friend with a given user, if they have an outgoing friend request, and if they have an incoming friend request. The proper way to receive and accept friend request is by checking if the user has an incoming &#x60;Notification&#x60; of type &#x60;friendRequest&#x60;, and then accepting that notification.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <returns>ApiResponse of InlineResponse2003</returns>
        ApiResponse<InlineResponse2003> GetFriendStatusWithHttpInfo (string userId);
        /// <summary>
        /// List Friends
        /// </summary>
        /// <remarks>
        /// List information about friends.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="offset">A zero-based offset from the default object sorting from where search results start. (optional)</param>
        /// <param name="n">The number of objects to return. (optional, default to 60)</param>
        /// <param name="offline">Returns *only* offline users if true, returns only online and active users if false (optional)</param>
        /// <returns>List&lt;LimitedUser&gt;</returns>
        List<LimitedUser> GetFriends (int? offset = default(int?), int? n = default(int?), bool? offline = default(bool?));

        /// <summary>
        /// List Friends
        /// </summary>
        /// <remarks>
        /// List information about friends.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="offset">A zero-based offset from the default object sorting from where search results start. (optional)</param>
        /// <param name="n">The number of objects to return. (optional, default to 60)</param>
        /// <param name="offline">Returns *only* offline users if true, returns only online and active users if false (optional)</param>
        /// <returns>ApiResponse of List&lt;LimitedUser&gt;</returns>
        ApiResponse<List<LimitedUser>> GetFriendsWithHttpInfo (int? offset = default(int?), int? n = default(int?), bool? offline = default(bool?));
        /// <summary>
        /// Unfriend
        /// </summary>
        /// <remarks>
        /// Unfriend a user by ID.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <returns>Success</returns>
        Success Unfriend (string userId);

        /// <summary>
        /// Unfriend
        /// </summary>
        /// <remarks>
        /// Unfriend a user by ID.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <returns>ApiResponse of Success</returns>
        ApiResponse<Success> UnfriendWithHttpInfo (string userId);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Delete Friend Request
        /// </summary>
        /// <remarks>
        /// Deletes an outgoing pending friend request to another user. To delete an incoming friend request, use the &#x60;deleteNotification&#x60; endpoint instead.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of Success</returns>
        System.Threading.Tasks.Task<Success> DeleteFriendRequestAsync (string userId, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Delete Friend Request
        /// </summary>
        /// <remarks>
        /// Deletes an outgoing pending friend request to another user. To delete an incoming friend request, use the &#x60;deleteNotification&#x60; endpoint instead.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (Success)</returns>
        System.Threading.Tasks.Task<ApiResponse<Success>> DeleteFriendRequestWithHttpInfoAsync (string userId, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Send Friend Request
        /// </summary>
        /// <remarks>
        /// Send a friend request to another user.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of Notification</returns>
        System.Threading.Tasks.Task<Notification> FriendAsync (string userId, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Send Friend Request
        /// </summary>
        /// <remarks>
        /// Send a friend request to another user.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (Notification)</returns>
        System.Threading.Tasks.Task<ApiResponse<Notification>> FriendWithHttpInfoAsync (string userId, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Check Friend Status
        /// </summary>
        /// <remarks>
        /// Retrieve if the user is currently a friend with a given user, if they have an outgoing friend request, and if they have an incoming friend request. The proper way to receive and accept friend request is by checking if the user has an incoming &#x60;Notification&#x60; of type &#x60;friendRequest&#x60;, and then accepting that notification.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of InlineResponse2003</returns>
        System.Threading.Tasks.Task<InlineResponse2003> GetFriendStatusAsync (string userId, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Check Friend Status
        /// </summary>
        /// <remarks>
        /// Retrieve if the user is currently a friend with a given user, if they have an outgoing friend request, and if they have an incoming friend request. The proper way to receive and accept friend request is by checking if the user has an incoming &#x60;Notification&#x60; of type &#x60;friendRequest&#x60;, and then accepting that notification.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (InlineResponse2003)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2003>> GetFriendStatusWithHttpInfoAsync (string userId, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// List Friends
        /// </summary>
        /// <remarks>
        /// List information about friends.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="offset">A zero-based offset from the default object sorting from where search results start. (optional)</param>
        /// <param name="n">The number of objects to return. (optional, default to 60)</param>
        /// <param name="offline">Returns *only* offline users if true, returns only online and active users if false (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of List&lt;LimitedUser&gt;</returns>
        System.Threading.Tasks.Task<List<LimitedUser>> GetFriendsAsync (int? offset = default(int?), int? n = default(int?), bool? offline = default(bool?), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// List Friends
        /// </summary>
        /// <remarks>
        /// List information about friends.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="offset">A zero-based offset from the default object sorting from where search results start. (optional)</param>
        /// <param name="n">The number of objects to return. (optional, default to 60)</param>
        /// <param name="offline">Returns *only* offline users if true, returns only online and active users if false (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (List&lt;LimitedUser&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<LimitedUser>>> GetFriendsWithHttpInfoAsync (int? offset = default(int?), int? n = default(int?), bool? offline = default(bool?), CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Unfriend
        /// </summary>
        /// <remarks>
        /// Unfriend a user by ID.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of Success</returns>
        System.Threading.Tasks.Task<Success> UnfriendAsync (string userId, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Unfriend
        /// </summary>
        /// <remarks>
        /// Unfriend a user by ID.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (Success)</returns>
        System.Threading.Tasks.Task<ApiResponse<Success>> UnfriendWithHttpInfoAsync (string userId, CancellationToken cancellationToken = default(CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class FriendsApi : IFriendsApi
    {
        private io.github.vrchatapi.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="FriendsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public FriendsApi(String basePath)
        {
            this.Configuration = new io.github.vrchatapi.Client.Configuration { BasePath = basePath };

            ExceptionFactory = io.github.vrchatapi.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FriendsApi"/> class
        /// </summary>
        /// <returns></returns>
        public FriendsApi()
        {
            this.Configuration = io.github.vrchatapi.Client.Configuration.Default;

            ExceptionFactory = io.github.vrchatapi.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FriendsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public FriendsApi(io.github.vrchatapi.Client.Configuration configuration = null)
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
        /// Delete Friend Request Deletes an outgoing pending friend request to another user. To delete an incoming friend request, use the &#x60;deleteNotification&#x60; endpoint instead.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <returns>Success</returns>
        public Success DeleteFriendRequest (string userId)
        {
             ApiResponse<Success> localVarResponse = DeleteFriendRequestWithHttpInfo(userId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete Friend Request Deletes an outgoing pending friend request to another user. To delete an incoming friend request, use the &#x60;deleteNotification&#x60; endpoint instead.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <returns>ApiResponse of Success</returns>
        public ApiResponse<Success> DeleteFriendRequestWithHttpInfo (string userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling FriendsApi->DeleteFriendRequest");

            var localVarPath = "/user/{userId}/friendRequest";
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
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteFriendRequest", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Success>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Success) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Success)));
        }

        /// <summary>
        /// Delete Friend Request Deletes an outgoing pending friend request to another user. To delete an incoming friend request, use the &#x60;deleteNotification&#x60; endpoint instead.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of Success</returns>
        public async System.Threading.Tasks.Task<Success> DeleteFriendRequestAsync (string userId, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<Success> localVarResponse = await DeleteFriendRequestWithHttpInfoAsync(userId, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete Friend Request Deletes an outgoing pending friend request to another user. To delete an incoming friend request, use the &#x60;deleteNotification&#x60; endpoint instead.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (Success)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Success>> DeleteFriendRequestWithHttpInfoAsync (string userId, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling FriendsApi->DeleteFriendRequest");

            var localVarPath = "/user/{userId}/friendRequest";
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
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteFriendRequest", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Success>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Success) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Success)));
        }

        /// <summary>
        /// Send Friend Request Send a friend request to another user.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <returns>Notification</returns>
        public Notification Friend (string userId)
        {
             ApiResponse<Notification> localVarResponse = FriendWithHttpInfo(userId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Send Friend Request Send a friend request to another user.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <returns>ApiResponse of Notification</returns>
        public ApiResponse<Notification> FriendWithHttpInfo (string userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling FriendsApi->Friend");

            var localVarPath = "/user/{userId}/friendRequest";
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
                Exception exception = ExceptionFactory("Friend", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Notification>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Notification) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Notification)));
        }

        /// <summary>
        /// Send Friend Request Send a friend request to another user.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of Notification</returns>
        public async System.Threading.Tasks.Task<Notification> FriendAsync (string userId, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<Notification> localVarResponse = await FriendWithHttpInfoAsync(userId, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Send Friend Request Send a friend request to another user.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (Notification)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Notification>> FriendWithHttpInfoAsync (string userId, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling FriendsApi->Friend");

            var localVarPath = "/user/{userId}/friendRequest";
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
                Exception exception = ExceptionFactory("Friend", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Notification>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Notification) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Notification)));
        }

        /// <summary>
        /// Check Friend Status Retrieve if the user is currently a friend with a given user, if they have an outgoing friend request, and if they have an incoming friend request. The proper way to receive and accept friend request is by checking if the user has an incoming &#x60;Notification&#x60; of type &#x60;friendRequest&#x60;, and then accepting that notification.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <returns>InlineResponse2003</returns>
        public InlineResponse2003 GetFriendStatus (string userId)
        {
             ApiResponse<InlineResponse2003> localVarResponse = GetFriendStatusWithHttpInfo(userId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Check Friend Status Retrieve if the user is currently a friend with a given user, if they have an outgoing friend request, and if they have an incoming friend request. The proper way to receive and accept friend request is by checking if the user has an incoming &#x60;Notification&#x60; of type &#x60;friendRequest&#x60;, and then accepting that notification.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <returns>ApiResponse of InlineResponse2003</returns>
        public ApiResponse<InlineResponse2003> GetFriendStatusWithHttpInfo (string userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling FriendsApi->GetFriendStatus");

            var localVarPath = "/user/{userId}/friendStatus";
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
                Exception exception = ExceptionFactory("GetFriendStatus", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2003>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (InlineResponse2003) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2003)));
        }

        /// <summary>
        /// Check Friend Status Retrieve if the user is currently a friend with a given user, if they have an outgoing friend request, and if they have an incoming friend request. The proper way to receive and accept friend request is by checking if the user has an incoming &#x60;Notification&#x60; of type &#x60;friendRequest&#x60;, and then accepting that notification.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of InlineResponse2003</returns>
        public async System.Threading.Tasks.Task<InlineResponse2003> GetFriendStatusAsync (string userId, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<InlineResponse2003> localVarResponse = await GetFriendStatusWithHttpInfoAsync(userId, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Check Friend Status Retrieve if the user is currently a friend with a given user, if they have an outgoing friend request, and if they have an incoming friend request. The proper way to receive and accept friend request is by checking if the user has an incoming &#x60;Notification&#x60; of type &#x60;friendRequest&#x60;, and then accepting that notification.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (InlineResponse2003)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2003>> GetFriendStatusWithHttpInfoAsync (string userId, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling FriendsApi->GetFriendStatus");

            var localVarPath = "/user/{userId}/friendStatus";
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
                Exception exception = ExceptionFactory("GetFriendStatus", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2003>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (InlineResponse2003) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2003)));
        }

        /// <summary>
        /// List Friends List information about friends.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="offset">A zero-based offset from the default object sorting from where search results start. (optional)</param>
        /// <param name="n">The number of objects to return. (optional, default to 60)</param>
        /// <param name="offline">Returns *only* offline users if true, returns only online and active users if false (optional)</param>
        /// <returns>List&lt;LimitedUser&gt;</returns>
        public List<LimitedUser> GetFriends (int? offset = default(int?), int? n = default(int?), bool? offline = default(bool?))
        {
             ApiResponse<List<LimitedUser>> localVarResponse = GetFriendsWithHttpInfo(offset, n, offline);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List Friends List information about friends.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="offset">A zero-based offset from the default object sorting from where search results start. (optional)</param>
        /// <param name="n">The number of objects to return. (optional, default to 60)</param>
        /// <param name="offline">Returns *only* offline users if true, returns only online and active users if false (optional)</param>
        /// <returns>ApiResponse of List&lt;LimitedUser&gt;</returns>
        public ApiResponse<List<LimitedUser>> GetFriendsWithHttpInfo (int? offset = default(int?), int? n = default(int?), bool? offline = default(bool?))
        {

            var localVarPath = "/auth/user/friends";
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

            if (offset != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "offset", offset)); // query parameter
            if (n != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "n", n)); // query parameter
            if (offline != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "offline", offline)); // query parameter

            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetFriends", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<LimitedUser>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<LimitedUser>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<LimitedUser>)));
        }

        /// <summary>
        /// List Friends List information about friends.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="offset">A zero-based offset from the default object sorting from where search results start. (optional)</param>
        /// <param name="n">The number of objects to return. (optional, default to 60)</param>
        /// <param name="offline">Returns *only* offline users if true, returns only online and active users if false (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of List&lt;LimitedUser&gt;</returns>
        public async System.Threading.Tasks.Task<List<LimitedUser>> GetFriendsAsync (int? offset = default(int?), int? n = default(int?), bool? offline = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<List<LimitedUser>> localVarResponse = await GetFriendsWithHttpInfoAsync(offset, n, offline, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List Friends List information about friends.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="offset">A zero-based offset from the default object sorting from where search results start. (optional)</param>
        /// <param name="n">The number of objects to return. (optional, default to 60)</param>
        /// <param name="offline">Returns *only* offline users if true, returns only online and active users if false (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (List&lt;LimitedUser&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<LimitedUser>>> GetFriendsWithHttpInfoAsync (int? offset = default(int?), int? n = default(int?), bool? offline = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
        {

            var localVarPath = "/auth/user/friends";
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

            if (offset != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "offset", offset)); // query parameter
            if (n != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "n", n)); // query parameter
            if (offline != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "offline", offline)); // query parameter

            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetFriends", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<LimitedUser>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<LimitedUser>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<LimitedUser>)));
        }

        /// <summary>
        /// Unfriend Unfriend a user by ID.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <returns>Success</returns>
        public Success Unfriend (string userId)
        {
             ApiResponse<Success> localVarResponse = UnfriendWithHttpInfo(userId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Unfriend Unfriend a user by ID.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <returns>ApiResponse of Success</returns>
        public ApiResponse<Success> UnfriendWithHttpInfo (string userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling FriendsApi->Unfriend");

            var localVarPath = "/auth/user/friends/{userId}";
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
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Unfriend", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Success>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Success) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Success)));
        }

        /// <summary>
        /// Unfriend Unfriend a user by ID.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of Success</returns>
        public async System.Threading.Tasks.Task<Success> UnfriendAsync (string userId, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<Success> localVarResponse = await UnfriendWithHttpInfoAsync(userId, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Unfriend Unfriend a user by ID.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (Success)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Success>> UnfriendWithHttpInfoAsync (string userId, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling FriendsApi->Unfriend");

            var localVarPath = "/auth/user/friends/{userId}";
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
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Unfriend", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Success>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Success) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Success)));
        }

    }
}
