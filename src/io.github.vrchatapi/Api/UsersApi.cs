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
    public interface IUsersApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get User by ID
        /// </summary>
        /// <remarks>
        /// Get public user information about a specific user using their ID.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <returns>User</returns>
        User GetUser (string userId);

        /// <summary>
        /// Get User by ID
        /// </summary>
        /// <remarks>
        /// Get public user information about a specific user using their ID.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <returns>ApiResponse of User</returns>
        ApiResponse<User> GetUserWithHttpInfo (string userId);
        /// <summary>
        /// Get User by Username
        /// </summary>
        /// <remarks>
        /// Get public user information about a specific user using their name.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username"></param>
        /// <returns>User</returns>
        User GetUserByName (string username);

        /// <summary>
        /// Get User by Username
        /// </summary>
        /// <remarks>
        /// Get public user information about a specific user using their name.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username"></param>
        /// <returns>ApiResponse of User</returns>
        ApiResponse<User> GetUserByNameWithHttpInfo (string username);
        /// <summary>
        /// Search Active Users
        /// </summary>
        /// <remarks>
        /// Search and list any Active users by text query.  **Has been locked down and now always respond with \&quot;Invalid Admin Credentials\&quot;.**
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="search">Username to search for</param>
        /// <param name="developerType">Active user by developer type, none for normal users and internal for moderators (optional)</param>
        /// <param name="offset">A zero-based offset from the default object sorting from where search results start. (optional)</param>
        /// <param name="n">The number of objects to return. (optional, default to 60)</param>
        /// <returns>List&lt;LimitedUser&gt;</returns>
        List<LimitedUser> SearchActiveUsers (string search, string developerType = default(string), int? offset = default(int?), int? n = default(int?));

        /// <summary>
        /// Search Active Users
        /// </summary>
        /// <remarks>
        /// Search and list any Active users by text query.  **Has been locked down and now always respond with \&quot;Invalid Admin Credentials\&quot;.**
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="search">Username to search for</param>
        /// <param name="developerType">Active user by developer type, none for normal users and internal for moderators (optional)</param>
        /// <param name="offset">A zero-based offset from the default object sorting from where search results start. (optional)</param>
        /// <param name="n">The number of objects to return. (optional, default to 60)</param>
        /// <returns>ApiResponse of List&lt;LimitedUser&gt;</returns>
        ApiResponse<List<LimitedUser>> SearchActiveUsersWithHttpInfo (string search, string developerType = default(string), int? offset = default(int?), int? n = default(int?));
        /// <summary>
        /// Search All Users
        /// </summary>
        /// <remarks>
        /// Search and list any users by text query
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="search">Searches by &#x60;displayName&#x60;. Will return empty array if search query is empty or missing. (optional)</param>
        /// <param name="developerType">Active user by developer type, none for normal users and internal for moderators (optional)</param>
        /// <param name="n">The number of objects to return. (optional, default to 60)</param>
        /// <param name="offset">A zero-based offset from the default object sorting from where search results start. (optional)</param>
        /// <returns>List&lt;LimitedUser&gt;</returns>
        List<LimitedUser> SearchUsers (string search = default(string), string developerType = default(string), int? n = default(int?), int? offset = default(int?));

        /// <summary>
        /// Search All Users
        /// </summary>
        /// <remarks>
        /// Search and list any users by text query
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="search">Searches by &#x60;displayName&#x60;. Will return empty array if search query is empty or missing. (optional)</param>
        /// <param name="developerType">Active user by developer type, none for normal users and internal for moderators (optional)</param>
        /// <param name="n">The number of objects to return. (optional, default to 60)</param>
        /// <param name="offset">A zero-based offset from the default object sorting from where search results start. (optional)</param>
        /// <returns>ApiResponse of List&lt;LimitedUser&gt;</returns>
        ApiResponse<List<LimitedUser>> SearchUsersWithHttpInfo (string search = default(string), string developerType = default(string), int? n = default(int?), int? offset = default(int?));
        /// <summary>
        /// Update User Info
        /// </summary>
        /// <remarks>
        /// Update a users information such as the email and birthday.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="inlineObject2"> (optional)</param>
        /// <returns>CurrentUser</returns>
        CurrentUser UpdateUser (string userId, InlineObject2 inlineObject2 = default(InlineObject2));

        /// <summary>
        /// Update User Info
        /// </summary>
        /// <remarks>
        /// Update a users information such as the email and birthday.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="inlineObject2"> (optional)</param>
        /// <returns>ApiResponse of CurrentUser</returns>
        ApiResponse<CurrentUser> UpdateUserWithHttpInfo (string userId, InlineObject2 inlineObject2 = default(InlineObject2));
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get User by ID
        /// </summary>
        /// <remarks>
        /// Get public user information about a specific user using their ID.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of User</returns>
        System.Threading.Tasks.Task<User> GetUserAsync (string userId, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get User by ID
        /// </summary>
        /// <remarks>
        /// Get public user information about a specific user using their ID.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (User)</returns>
        System.Threading.Tasks.Task<ApiResponse<User>> GetUserWithHttpInfoAsync (string userId, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get User by Username
        /// </summary>
        /// <remarks>
        /// Get public user information about a specific user using their name.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of User</returns>
        System.Threading.Tasks.Task<User> GetUserByNameAsync (string username, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get User by Username
        /// </summary>
        /// <remarks>
        /// Get public user information about a specific user using their name.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (User)</returns>
        System.Threading.Tasks.Task<ApiResponse<User>> GetUserByNameWithHttpInfoAsync (string username, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Search Active Users
        /// </summary>
        /// <remarks>
        /// Search and list any Active users by text query.  **Has been locked down and now always respond with \&quot;Invalid Admin Credentials\&quot;.**
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="search">Username to search for</param>
        /// <param name="developerType">Active user by developer type, none for normal users and internal for moderators (optional)</param>
        /// <param name="offset">A zero-based offset from the default object sorting from where search results start. (optional)</param>
        /// <param name="n">The number of objects to return. (optional, default to 60)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of List&lt;LimitedUser&gt;</returns>
        System.Threading.Tasks.Task<List<LimitedUser>> SearchActiveUsersAsync (string search, string developerType = default(string), int? offset = default(int?), int? n = default(int?), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Search Active Users
        /// </summary>
        /// <remarks>
        /// Search and list any Active users by text query.  **Has been locked down and now always respond with \&quot;Invalid Admin Credentials\&quot;.**
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="search">Username to search for</param>
        /// <param name="developerType">Active user by developer type, none for normal users and internal for moderators (optional)</param>
        /// <param name="offset">A zero-based offset from the default object sorting from where search results start. (optional)</param>
        /// <param name="n">The number of objects to return. (optional, default to 60)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (List&lt;LimitedUser&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<LimitedUser>>> SearchActiveUsersWithHttpInfoAsync (string search, string developerType = default(string), int? offset = default(int?), int? n = default(int?), CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Search All Users
        /// </summary>
        /// <remarks>
        /// Search and list any users by text query
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="search">Searches by &#x60;displayName&#x60;. Will return empty array if search query is empty or missing. (optional)</param>
        /// <param name="developerType">Active user by developer type, none for normal users and internal for moderators (optional)</param>
        /// <param name="n">The number of objects to return. (optional, default to 60)</param>
        /// <param name="offset">A zero-based offset from the default object sorting from where search results start. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of List&lt;LimitedUser&gt;</returns>
        System.Threading.Tasks.Task<List<LimitedUser>> SearchUsersAsync (string search = default(string), string developerType = default(string), int? n = default(int?), int? offset = default(int?), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Search All Users
        /// </summary>
        /// <remarks>
        /// Search and list any users by text query
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="search">Searches by &#x60;displayName&#x60;. Will return empty array if search query is empty or missing. (optional)</param>
        /// <param name="developerType">Active user by developer type, none for normal users and internal for moderators (optional)</param>
        /// <param name="n">The number of objects to return. (optional, default to 60)</param>
        /// <param name="offset">A zero-based offset from the default object sorting from where search results start. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (List&lt;LimitedUser&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<LimitedUser>>> SearchUsersWithHttpInfoAsync (string search = default(string), string developerType = default(string), int? n = default(int?), int? offset = default(int?), CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Update User Info
        /// </summary>
        /// <remarks>
        /// Update a users information such as the email and birthday.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="inlineObject2"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of CurrentUser</returns>
        System.Threading.Tasks.Task<CurrentUser> UpdateUserAsync (string userId, InlineObject2 inlineObject2 = default(InlineObject2), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Update User Info
        /// </summary>
        /// <remarks>
        /// Update a users information such as the email and birthday.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="inlineObject2"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (CurrentUser)</returns>
        System.Threading.Tasks.Task<ApiResponse<CurrentUser>> UpdateUserWithHttpInfoAsync (string userId, InlineObject2 inlineObject2 = default(InlineObject2), CancellationToken cancellationToken = default(CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class UsersApi : IUsersApi
    {
        private io.github.vrchatapi.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UsersApi(String basePath)
        {
            this.Configuration = new io.github.vrchatapi.Client.Configuration { BasePath = basePath };

            ExceptionFactory = io.github.vrchatapi.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersApi"/> class
        /// </summary>
        /// <returns></returns>
        public UsersApi()
        {
            this.Configuration = io.github.vrchatapi.Client.Configuration.Default;

            ExceptionFactory = io.github.vrchatapi.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public UsersApi(io.github.vrchatapi.Client.Configuration configuration = null)
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
        /// Get User by ID Get public user information about a specific user using their ID.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <returns>User</returns>
        public User GetUser (string userId)
        {
             ApiResponse<User> localVarResponse = GetUserWithHttpInfo(userId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get User by ID Get public user information about a specific user using their ID.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <returns>ApiResponse of User</returns>
        public ApiResponse<User> GetUserWithHttpInfo (string userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->GetUser");

            var localVarPath = "/users/{userId}";
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
                Exception exception = ExceptionFactory("GetUser", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<User>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (User) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(User)));
        }

        /// <summary>
        /// Get User by ID Get public user information about a specific user using their ID.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of User</returns>
        public async System.Threading.Tasks.Task<User> GetUserAsync (string userId, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<User> localVarResponse = await GetUserWithHttpInfoAsync(userId, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get User by ID Get public user information about a specific user using their ID.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (User)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<User>> GetUserWithHttpInfoAsync (string userId, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->GetUser");

            var localVarPath = "/users/{userId}";
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
                Exception exception = ExceptionFactory("GetUser", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<User>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (User) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(User)));
        }

        /// <summary>
        /// Get User by Username Get public user information about a specific user using their name.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username"></param>
        /// <returns>User</returns>
        public User GetUserByName (string username)
        {
             ApiResponse<User> localVarResponse = GetUserByNameWithHttpInfo(username);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get User by Username Get public user information about a specific user using their name.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username"></param>
        /// <returns>ApiResponse of User</returns>
        public ApiResponse<User> GetUserByNameWithHttpInfo (string username)
        {
            // verify the required parameter 'username' is set
            if (username == null)
                throw new ApiException(400, "Missing required parameter 'username' when calling UsersApi->GetUserByName");

            var localVarPath = "/users/{username}/name";
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

            if (username != null) localVarPathParams.Add("username", this.Configuration.ApiClient.ParameterToString(username)); // path parameter

            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetUserByName", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<User>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (User) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(User)));
        }

        /// <summary>
        /// Get User by Username Get public user information about a specific user using their name.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of User</returns>
        public async System.Threading.Tasks.Task<User> GetUserByNameAsync (string username, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<User> localVarResponse = await GetUserByNameWithHttpInfoAsync(username, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get User by Username Get public user information about a specific user using their name.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (User)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<User>> GetUserByNameWithHttpInfoAsync (string username, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'username' is set
            if (username == null)
                throw new ApiException(400, "Missing required parameter 'username' when calling UsersApi->GetUserByName");

            var localVarPath = "/users/{username}/name";
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

            if (username != null) localVarPathParams.Add("username", this.Configuration.ApiClient.ParameterToString(username)); // path parameter

            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetUserByName", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<User>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (User) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(User)));
        }

        /// <summary>
        /// Search Active Users Search and list any Active users by text query.  **Has been locked down and now always respond with \&quot;Invalid Admin Credentials\&quot;.**
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="search">Username to search for</param>
        /// <param name="developerType">Active user by developer type, none for normal users and internal for moderators (optional)</param>
        /// <param name="offset">A zero-based offset from the default object sorting from where search results start. (optional)</param>
        /// <param name="n">The number of objects to return. (optional, default to 60)</param>
        /// <returns>List&lt;LimitedUser&gt;</returns>
        public List<LimitedUser> SearchActiveUsers (string search, string developerType = default(string), int? offset = default(int?), int? n = default(int?))
        {
             ApiResponse<List<LimitedUser>> localVarResponse = SearchActiveUsersWithHttpInfo(search, developerType, offset, n);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search Active Users Search and list any Active users by text query.  **Has been locked down and now always respond with \&quot;Invalid Admin Credentials\&quot;.**
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="search">Username to search for</param>
        /// <param name="developerType">Active user by developer type, none for normal users and internal for moderators (optional)</param>
        /// <param name="offset">A zero-based offset from the default object sorting from where search results start. (optional)</param>
        /// <param name="n">The number of objects to return. (optional, default to 60)</param>
        /// <returns>ApiResponse of List&lt;LimitedUser&gt;</returns>
        public ApiResponse<List<LimitedUser>> SearchActiveUsersWithHttpInfo (string search, string developerType = default(string), int? offset = default(int?), int? n = default(int?))
        {
            // verify the required parameter 'search' is set
            if (search == null)
                throw new ApiException(400, "Missing required parameter 'search' when calling UsersApi->SearchActiveUsers");

            var localVarPath = "/users/active";
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

            if (search != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "search", search)); // query parameter
            if (developerType != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "developerType", developerType)); // query parameter
            if (offset != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "offset", offset)); // query parameter
            if (n != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "n", n)); // query parameter

            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SearchActiveUsers", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<LimitedUser>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<LimitedUser>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<LimitedUser>)));
        }

        /// <summary>
        /// Search Active Users Search and list any Active users by text query.  **Has been locked down and now always respond with \&quot;Invalid Admin Credentials\&quot;.**
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="search">Username to search for</param>
        /// <param name="developerType">Active user by developer type, none for normal users and internal for moderators (optional)</param>
        /// <param name="offset">A zero-based offset from the default object sorting from where search results start. (optional)</param>
        /// <param name="n">The number of objects to return. (optional, default to 60)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of List&lt;LimitedUser&gt;</returns>
        public async System.Threading.Tasks.Task<List<LimitedUser>> SearchActiveUsersAsync (string search, string developerType = default(string), int? offset = default(int?), int? n = default(int?), CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<List<LimitedUser>> localVarResponse = await SearchActiveUsersWithHttpInfoAsync(search, developerType, offset, n, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search Active Users Search and list any Active users by text query.  **Has been locked down and now always respond with \&quot;Invalid Admin Credentials\&quot;.**
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="search">Username to search for</param>
        /// <param name="developerType">Active user by developer type, none for normal users and internal for moderators (optional)</param>
        /// <param name="offset">A zero-based offset from the default object sorting from where search results start. (optional)</param>
        /// <param name="n">The number of objects to return. (optional, default to 60)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (List&lt;LimitedUser&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<LimitedUser>>> SearchActiveUsersWithHttpInfoAsync (string search, string developerType = default(string), int? offset = default(int?), int? n = default(int?), CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'search' is set
            if (search == null)
                throw new ApiException(400, "Missing required parameter 'search' when calling UsersApi->SearchActiveUsers");

            var localVarPath = "/users/active";
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

            if (search != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "search", search)); // query parameter
            if (developerType != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "developerType", developerType)); // query parameter
            if (offset != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "offset", offset)); // query parameter
            if (n != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "n", n)); // query parameter

            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SearchActiveUsers", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<LimitedUser>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<LimitedUser>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<LimitedUser>)));
        }

        /// <summary>
        /// Search All Users Search and list any users by text query
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="search">Searches by &#x60;displayName&#x60;. Will return empty array if search query is empty or missing. (optional)</param>
        /// <param name="developerType">Active user by developer type, none for normal users and internal for moderators (optional)</param>
        /// <param name="n">The number of objects to return. (optional, default to 60)</param>
        /// <param name="offset">A zero-based offset from the default object sorting from where search results start. (optional)</param>
        /// <returns>List&lt;LimitedUser&gt;</returns>
        public List<LimitedUser> SearchUsers (string search = default(string), string developerType = default(string), int? n = default(int?), int? offset = default(int?))
        {
             ApiResponse<List<LimitedUser>> localVarResponse = SearchUsersWithHttpInfo(search, developerType, n, offset);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search All Users Search and list any users by text query
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="search">Searches by &#x60;displayName&#x60;. Will return empty array if search query is empty or missing. (optional)</param>
        /// <param name="developerType">Active user by developer type, none for normal users and internal for moderators (optional)</param>
        /// <param name="n">The number of objects to return. (optional, default to 60)</param>
        /// <param name="offset">A zero-based offset from the default object sorting from where search results start. (optional)</param>
        /// <returns>ApiResponse of List&lt;LimitedUser&gt;</returns>
        public ApiResponse<List<LimitedUser>> SearchUsersWithHttpInfo (string search = default(string), string developerType = default(string), int? n = default(int?), int? offset = default(int?))
        {

            var localVarPath = "/users";
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

            if (search != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "search", search)); // query parameter
            if (developerType != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "developerType", developerType)); // query parameter
            if (n != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "n", n)); // query parameter
            if (offset != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "offset", offset)); // query parameter

            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SearchUsers", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<LimitedUser>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<LimitedUser>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<LimitedUser>)));
        }

        /// <summary>
        /// Search All Users Search and list any users by text query
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="search">Searches by &#x60;displayName&#x60;. Will return empty array if search query is empty or missing. (optional)</param>
        /// <param name="developerType">Active user by developer type, none for normal users and internal for moderators (optional)</param>
        /// <param name="n">The number of objects to return. (optional, default to 60)</param>
        /// <param name="offset">A zero-based offset from the default object sorting from where search results start. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of List&lt;LimitedUser&gt;</returns>
        public async System.Threading.Tasks.Task<List<LimitedUser>> SearchUsersAsync (string search = default(string), string developerType = default(string), int? n = default(int?), int? offset = default(int?), CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<List<LimitedUser>> localVarResponse = await SearchUsersWithHttpInfoAsync(search, developerType, n, offset, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search All Users Search and list any users by text query
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="search">Searches by &#x60;displayName&#x60;. Will return empty array if search query is empty or missing. (optional)</param>
        /// <param name="developerType">Active user by developer type, none for normal users and internal for moderators (optional)</param>
        /// <param name="n">The number of objects to return. (optional, default to 60)</param>
        /// <param name="offset">A zero-based offset from the default object sorting from where search results start. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (List&lt;LimitedUser&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<LimitedUser>>> SearchUsersWithHttpInfoAsync (string search = default(string), string developerType = default(string), int? n = default(int?), int? offset = default(int?), CancellationToken cancellationToken = default(CancellationToken))
        {

            var localVarPath = "/users";
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

            if (search != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "search", search)); // query parameter
            if (developerType != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "developerType", developerType)); // query parameter
            if (n != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "n", n)); // query parameter
            if (offset != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "offset", offset)); // query parameter

            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SearchUsers", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<LimitedUser>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<LimitedUser>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<LimitedUser>)));
        }

        /// <summary>
        /// Update User Info Update a users information such as the email and birthday.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="inlineObject2"> (optional)</param>
        /// <returns>CurrentUser</returns>
        public CurrentUser UpdateUser (string userId, InlineObject2 inlineObject2 = default(InlineObject2))
        {
             ApiResponse<CurrentUser> localVarResponse = UpdateUserWithHttpInfo(userId, inlineObject2);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update User Info Update a users information such as the email and birthday.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="inlineObject2"> (optional)</param>
        /// <returns>ApiResponse of CurrentUser</returns>
        public ApiResponse<CurrentUser> UpdateUserWithHttpInfo (string userId, InlineObject2 inlineObject2 = default(InlineObject2))
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->UpdateUser");

            var localVarPath = "/users/{userId}";
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
            if (inlineObject2 != null && inlineObject2.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(inlineObject2); // http body (model) parameter
            }
            else
            {
                localVarPostBody = inlineObject2; // byte array
            }

            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdateUser", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CurrentUser>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (CurrentUser) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CurrentUser)));
        }

        /// <summary>
        /// Update User Info Update a users information such as the email and birthday.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="inlineObject2"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of CurrentUser</returns>
        public async System.Threading.Tasks.Task<CurrentUser> UpdateUserAsync (string userId, InlineObject2 inlineObject2 = default(InlineObject2), CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<CurrentUser> localVarResponse = await UpdateUserWithHttpInfoAsync(userId, inlineObject2, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update User Info Update a users information such as the email and birthday.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="inlineObject2"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (CurrentUser)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CurrentUser>> UpdateUserWithHttpInfoAsync (string userId, InlineObject2 inlineObject2 = default(InlineObject2), CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->UpdateUser");

            var localVarPath = "/users/{userId}";
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
            if (inlineObject2 != null && inlineObject2.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(inlineObject2); // http body (model) parameter
            }
            else
            {
                localVarPostBody = inlineObject2; // byte array
            }

            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdateUser", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CurrentUser>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (CurrentUser) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CurrentUser)));
        }

    }
}
