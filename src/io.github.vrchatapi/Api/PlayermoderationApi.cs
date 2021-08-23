/*
 * VRChat API Documentation
 *
 * ![VRChat API Banner](https://vrchatapi.github.io/assets/img/api_banner_1500x400.png)  # Welcome to the VRChat API  Before we begin, we would like to state this is a **COMMUNITY DRIVEN PROJECT**. This means that everything you read on here was written by the community itself and is **not** officially supported by VRChat. The documentation is provided \"AS IS\", and any action you take towards VRChat is completely your own responsibility.  The documentation and additional libraries SHALL ONLY be used for applications interacting with VRChat's API in accordance with their [Terms of Service](https://github.com/VRChatAPI), and MUST NOT be used for modifying the client, \"avatar ripping\", or other illegal activities. Malicious usage or spamming the API may result in account termination. Certain parts of the API are also more sensitive than others, for example moderation, so please read tread extra carefully and read the warnings when present.  ![Tupper Policy on API](https://i.imgur.com/yLlW7Ok.png)  Finally, use of the API using applications other than the approved methods (website, VRChat application, Unity SDK) is not officially supported. VRChat provides no guarantee or support for external applications using the API. Access to API endpoints may break **at any time, without notice**. Therefore, please **do not ping** VRChat Staff in the VRChat Discord if you are having API problems, as they do not provide API support. We will make a best effort in keeping this documentation and associated language libraries up to date, but things might be outdated or missing. If you find that something is no longer valid, please contact us on Discord or [create an issue](https://github.com/vrchatapi/specification/issues) and tell us so we can fix it.  # Getting Started  The VRChat API can be used to programmatically retrieve or update information regarding your profile, friends, avatars, worlds and more. The API consists of two parts, \"Photon\" which is only used in-game, and the \"Web API\" which is used by both the game and the website. This documentation focuses only on the Web API.  The API is designed around the REST ideology, providing semi-simple and usually predictable URIs to access and modify objects. Requests support standard HTTP methods like GET, PUT, POST, and DELETE and standard status codes. Response bodies are always UTF-8 encoded JSON objects, unless explicitly documented otherwise.  <div class=\"callout callout-error\">   <strong>🛑 Warning! Do not touch Photon!</strong><br>   Photon is only used by the in-game client and should <b>not</b> be touched. Doing so may result in permanent account termination. </div>  <div class=\"callout callout-info\">   <strong>ℹ️ API Key and Authentication</strong><br>   The API Key has always been the same and is currently <code>JlE5Jldo5Jibnk5O5hTx6XVqsJu4WJ26</code>.   Read <a href=\"#tag- -authentication\">Authentication</a> for how to log in. </div>  # Using the API  For simply exploring what the API can do it is strongly recommended to download [Insomnia](https://insomnia.rest/download), a free and open-source API client that's great for sending requests to the API in an orderly fashion. Insomnia allows you to send data in the format that's required for VRChat's API. It is also possible to try out the API in your browser, by first logging in at [vrchat.com/home](https://vrchat.com/home/) and then going to [vrchat.com/api/1/auth/user](https://vrchat.com/api/1/auth/user), but the information will be much harder to work with.  For more permanent operation such as software development it is instead recommended to use one of the existing language SDKs. This community project maintains API libraries in several languages, which allows you to interact with the API with simple function calls rather than having to implement the HTTP protocol yourself. Most of these libraries are automatically generated from the API specification, sometimes with additional helpful wrapper code to make usage easier. This allows them to be almost automatically updated and expanded upon as soon as a new feature is introduced in the specification itself. The libraries can be found on [GitHub](https://github.com/vrchatapi) or following:  * [NodeJS (JavaScript)](https://www.npmjs.com/package/vrchat) * [Dart](https://pub.dev/packages/vrchat_dart) * [Rust](https://crates.io/crates/vrchatapi) * [C#](github.com/vrchatapi/vrchatapi-csharp) * [Python](https://github.com/vrchatapi/VRChatPython)  # Pagination  Most endpoints enforce pagination, meaning they will only return 10 entries by default, and never more than 100.<br> Using both the limit and offset parameters allows you to easily paginate through a large number of objects.  | Query Parameter | Type | Description | | - -- -- -- -- -|- -|- -- -- -- | | `limit` | integer  | The number of objects to return. This value often defaults to 10. Highest limit is always 100.| | `offset` | integer  | A zero-based offset from the default object sorting.|  If a request returns fewer objects than the `limit` parameter, there are no more items available to return.  # Contribution  Do you want to get involved in the documentation effort? Do you want to help improve one of the language API libraries? This project is an [OPEN Open Source Project](https://openopensource.org)! This means that individuals making significant and valuable contributions are given commit-access to the project. It also means we are very open and welcoming of new people making contributions, unlike some more guarded open-source projects.  [![Discord](https://img.shields.io/static/v1?label=vrchatapi&message=discord&color=blueviolet&style=for-the-badge)](https://discord.gg/qjZE9C9fkB)
 *
 * The version of the OpenAPI document: 1.0.2
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
    public interface IPlayermoderationApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Clear All Player Moderations
        /// </summary>
        /// <remarks>
        /// ⚠️ **This will delete every single player moderation you&#39;ve ever made.**
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Error</returns>
        Error ClearAllPlayerModerations ();

        /// <summary>
        /// Clear All Player Moderations
        /// </summary>
        /// <remarks>
        /// ⚠️ **This will delete every single player moderation you&#39;ve ever made.**
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Error</returns>
        ApiResponse<Error> ClearAllPlayerModerationsWithHttpInfo ();
        /// <summary>
        /// Delete Player Moderation
        /// </summary>
        /// <remarks>
        /// Deletes a specific player moderation based on it&#39;s &#x60;pmod_&#x60; ID. The website uses &#x60;unmoderateUser&#x60; instead. You can delete the same player moderation multiple times successfully.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="playerModerationId"></param>
        /// <returns>Error</returns>
        Error DeletePlayerModeration (string playerModerationId);

        /// <summary>
        /// Delete Player Moderation
        /// </summary>
        /// <remarks>
        /// Deletes a specific player moderation based on it&#39;s &#x60;pmod_&#x60; ID. The website uses &#x60;unmoderateUser&#x60; instead. You can delete the same player moderation multiple times successfully.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="playerModerationId"></param>
        /// <returns>ApiResponse of Error</returns>
        ApiResponse<Error> DeletePlayerModerationWithHttpInfo (string playerModerationId);
        /// <summary>
        /// Get Player Moderation
        /// </summary>
        /// <remarks>
        /// Returns a single Player Moderation. This returns the exact same amount of information as the more generalised &#x60;getPlayerModerations&#x60;.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="playerModerationId"></param>
        /// <returns>PlayerModeration</returns>
        PlayerModeration GetPlayerModeration (string playerModerationId);

        /// <summary>
        /// Get Player Moderation
        /// </summary>
        /// <remarks>
        /// Returns a single Player Moderation. This returns the exact same amount of information as the more generalised &#x60;getPlayerModerations&#x60;.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="playerModerationId"></param>
        /// <returns>ApiResponse of PlayerModeration</returns>
        ApiResponse<PlayerModeration> GetPlayerModerationWithHttpInfo (string playerModerationId);
        /// <summary>
        /// Search Player Moderations
        /// </summary>
        /// <remarks>
        /// Returns a list of all player moderations made by **you**.  This endpoint does not have pagination, and will return *all* results. Use query parameters to limit your query if needed.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">Must be one of PlayerModerationType, except unblock. Unblocking simply removes a block. (optional)</param>
        /// <param name="targetUserId">Must be valid UserID. (optional)</param>
        /// <returns>List&lt;PlayerModeration&gt;</returns>
        List<PlayerModeration> GetPlayerModerations (string type = default(string), string targetUserId = default(string));

        /// <summary>
        /// Search Player Moderations
        /// </summary>
        /// <remarks>
        /// Returns a list of all player moderations made by **you**.  This endpoint does not have pagination, and will return *all* results. Use query parameters to limit your query if needed.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">Must be one of PlayerModerationType, except unblock. Unblocking simply removes a block. (optional)</param>
        /// <param name="targetUserId">Must be valid UserID. (optional)</param>
        /// <returns>ApiResponse of List&lt;PlayerModeration&gt;</returns>
        ApiResponse<List<PlayerModeration>> GetPlayerModerationsWithHttpInfo (string type = default(string), string targetUserId = default(string));
        /// <summary>
        /// Moderate User
        /// </summary>
        /// <remarks>
        /// Moderate a user, e.g. unmute them or show their avatar.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inlineObject12"> (optional)</param>
        /// <returns>PlayerModeration</returns>
        PlayerModeration ModerateUser (InlineObject12 inlineObject12 = default(InlineObject12));

        /// <summary>
        /// Moderate User
        /// </summary>
        /// <remarks>
        /// Moderate a user, e.g. unmute them or show their avatar.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inlineObject12"> (optional)</param>
        /// <returns>ApiResponse of PlayerModeration</returns>
        ApiResponse<PlayerModeration> ModerateUserWithHttpInfo (InlineObject12 inlineObject12 = default(InlineObject12));
        /// <summary>
        /// Unmoderate User
        /// </summary>
        /// <remarks>
        /// Removes a player moderation previously added through &#x60;moderateUser&#x60;. E.g if you previuosly have shown their avatar, but now want to reset it to default.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inlineObject13"> (optional)</param>
        /// <returns>Error</returns>
        Error UnmoderateUser (InlineObject13 inlineObject13 = default(InlineObject13));

        /// <summary>
        /// Unmoderate User
        /// </summary>
        /// <remarks>
        /// Removes a player moderation previously added through &#x60;moderateUser&#x60;. E.g if you previuosly have shown their avatar, but now want to reset it to default.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inlineObject13"> (optional)</param>
        /// <returns>ApiResponse of Error</returns>
        ApiResponse<Error> UnmoderateUserWithHttpInfo (InlineObject13 inlineObject13 = default(InlineObject13));
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Clear All Player Moderations
        /// </summary>
        /// <remarks>
        /// ⚠️ **This will delete every single player moderation you&#39;ve ever made.**
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of Error</returns>
        System.Threading.Tasks.Task<Error> ClearAllPlayerModerationsAsync (CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Clear All Player Moderations
        /// </summary>
        /// <remarks>
        /// ⚠️ **This will delete every single player moderation you&#39;ve ever made.**
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (Error)</returns>
        System.Threading.Tasks.Task<ApiResponse<Error>> ClearAllPlayerModerationsWithHttpInfoAsync (CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete Player Moderation
        /// </summary>
        /// <remarks>
        /// Deletes a specific player moderation based on it&#39;s &#x60;pmod_&#x60; ID. The website uses &#x60;unmoderateUser&#x60; instead. You can delete the same player moderation multiple times successfully.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="playerModerationId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of Error</returns>
        System.Threading.Tasks.Task<Error> DeletePlayerModerationAsync (string playerModerationId, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Delete Player Moderation
        /// </summary>
        /// <remarks>
        /// Deletes a specific player moderation based on it&#39;s &#x60;pmod_&#x60; ID. The website uses &#x60;unmoderateUser&#x60; instead. You can delete the same player moderation multiple times successfully.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="playerModerationId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (Error)</returns>
        System.Threading.Tasks.Task<ApiResponse<Error>> DeletePlayerModerationWithHttpInfoAsync (string playerModerationId, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get Player Moderation
        /// </summary>
        /// <remarks>
        /// Returns a single Player Moderation. This returns the exact same amount of information as the more generalised &#x60;getPlayerModerations&#x60;.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="playerModerationId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of PlayerModeration</returns>
        System.Threading.Tasks.Task<PlayerModeration> GetPlayerModerationAsync (string playerModerationId, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get Player Moderation
        /// </summary>
        /// <remarks>
        /// Returns a single Player Moderation. This returns the exact same amount of information as the more generalised &#x60;getPlayerModerations&#x60;.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="playerModerationId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (PlayerModeration)</returns>
        System.Threading.Tasks.Task<ApiResponse<PlayerModeration>> GetPlayerModerationWithHttpInfoAsync (string playerModerationId, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Search Player Moderations
        /// </summary>
        /// <remarks>
        /// Returns a list of all player moderations made by **you**.  This endpoint does not have pagination, and will return *all* results. Use query parameters to limit your query if needed.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">Must be one of PlayerModerationType, except unblock. Unblocking simply removes a block. (optional)</param>
        /// <param name="targetUserId">Must be valid UserID. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of List&lt;PlayerModeration&gt;</returns>
        System.Threading.Tasks.Task<List<PlayerModeration>> GetPlayerModerationsAsync (string type = default(string), string targetUserId = default(string), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Search Player Moderations
        /// </summary>
        /// <remarks>
        /// Returns a list of all player moderations made by **you**.  This endpoint does not have pagination, and will return *all* results. Use query parameters to limit your query if needed.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">Must be one of PlayerModerationType, except unblock. Unblocking simply removes a block. (optional)</param>
        /// <param name="targetUserId">Must be valid UserID. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (List&lt;PlayerModeration&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<PlayerModeration>>> GetPlayerModerationsWithHttpInfoAsync (string type = default(string), string targetUserId = default(string), CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Moderate User
        /// </summary>
        /// <remarks>
        /// Moderate a user, e.g. unmute them or show their avatar.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inlineObject12"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of PlayerModeration</returns>
        System.Threading.Tasks.Task<PlayerModeration> ModerateUserAsync (InlineObject12 inlineObject12 = default(InlineObject12), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Moderate User
        /// </summary>
        /// <remarks>
        /// Moderate a user, e.g. unmute them or show their avatar.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inlineObject12"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (PlayerModeration)</returns>
        System.Threading.Tasks.Task<ApiResponse<PlayerModeration>> ModerateUserWithHttpInfoAsync (InlineObject12 inlineObject12 = default(InlineObject12), CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Unmoderate User
        /// </summary>
        /// <remarks>
        /// Removes a player moderation previously added through &#x60;moderateUser&#x60;. E.g if you previuosly have shown their avatar, but now want to reset it to default.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inlineObject13"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of Error</returns>
        System.Threading.Tasks.Task<Error> UnmoderateUserAsync (InlineObject13 inlineObject13 = default(InlineObject13), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Unmoderate User
        /// </summary>
        /// <remarks>
        /// Removes a player moderation previously added through &#x60;moderateUser&#x60;. E.g if you previuosly have shown their avatar, but now want to reset it to default.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inlineObject13"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (Error)</returns>
        System.Threading.Tasks.Task<ApiResponse<Error>> UnmoderateUserWithHttpInfoAsync (InlineObject13 inlineObject13 = default(InlineObject13), CancellationToken cancellationToken = default(CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PlayermoderationApi : IPlayermoderationApi
    {
        private io.github.vrchatapi.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PlayermoderationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PlayermoderationApi(String basePath)
        {
            this.Configuration = new io.github.vrchatapi.Client.Configuration { BasePath = basePath };

            ExceptionFactory = io.github.vrchatapi.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlayermoderationApi"/> class
        /// </summary>
        /// <returns></returns>
        public PlayermoderationApi()
        {
            this.Configuration = io.github.vrchatapi.Client.Configuration.Default;

            ExceptionFactory = io.github.vrchatapi.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlayermoderationApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PlayermoderationApi(io.github.vrchatapi.Client.Configuration configuration = null)
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
        /// Clear All Player Moderations ⚠️ **This will delete every single player moderation you&#39;ve ever made.**
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Error</returns>
        public Error ClearAllPlayerModerations ()
        {
             ApiResponse<Error> localVarResponse = ClearAllPlayerModerationsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Clear All Player Moderations ⚠️ **This will delete every single player moderation you&#39;ve ever made.**
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Error</returns>
        public ApiResponse<Error> ClearAllPlayerModerationsWithHttpInfo ()
        {

            var localVarPath = "/auth/user/playermoderations";
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


            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ClearAllPlayerModerations", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Error>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Error) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Error)));
        }

        /// <summary>
        /// Clear All Player Moderations ⚠️ **This will delete every single player moderation you&#39;ve ever made.**
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of Error</returns>
        public async System.Threading.Tasks.Task<Error> ClearAllPlayerModerationsAsync (CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<Error> localVarResponse = await ClearAllPlayerModerationsWithHttpInfoAsync(cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Clear All Player Moderations ⚠️ **This will delete every single player moderation you&#39;ve ever made.**
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (Error)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Error>> ClearAllPlayerModerationsWithHttpInfoAsync (CancellationToken cancellationToken = default(CancellationToken))
        {

            var localVarPath = "/auth/user/playermoderations";
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


            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ClearAllPlayerModerations", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Error>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Error) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Error)));
        }

        /// <summary>
        /// Delete Player Moderation Deletes a specific player moderation based on it&#39;s &#x60;pmod_&#x60; ID. The website uses &#x60;unmoderateUser&#x60; instead. You can delete the same player moderation multiple times successfully.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="playerModerationId"></param>
        /// <returns>Error</returns>
        public Error DeletePlayerModeration (string playerModerationId)
        {
             ApiResponse<Error> localVarResponse = DeletePlayerModerationWithHttpInfo(playerModerationId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete Player Moderation Deletes a specific player moderation based on it&#39;s &#x60;pmod_&#x60; ID. The website uses &#x60;unmoderateUser&#x60; instead. You can delete the same player moderation multiple times successfully.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="playerModerationId"></param>
        /// <returns>ApiResponse of Error</returns>
        public ApiResponse<Error> DeletePlayerModerationWithHttpInfo (string playerModerationId)
        {
            // verify the required parameter 'playerModerationId' is set
            if (playerModerationId == null)
                throw new ApiException(400, "Missing required parameter 'playerModerationId' when calling PlayermoderationApi->DeletePlayerModeration");

            var localVarPath = "/auth/user/playermoderations/{playerModerationId}";
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

            if (playerModerationId != null) localVarPathParams.Add("playerModerationId", this.Configuration.ApiClient.ParameterToString(playerModerationId)); // path parameter

            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeletePlayerModeration", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Error>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Error) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Error)));
        }

        /// <summary>
        /// Delete Player Moderation Deletes a specific player moderation based on it&#39;s &#x60;pmod_&#x60; ID. The website uses &#x60;unmoderateUser&#x60; instead. You can delete the same player moderation multiple times successfully.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="playerModerationId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of Error</returns>
        public async System.Threading.Tasks.Task<Error> DeletePlayerModerationAsync (string playerModerationId, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<Error> localVarResponse = await DeletePlayerModerationWithHttpInfoAsync(playerModerationId, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete Player Moderation Deletes a specific player moderation based on it&#39;s &#x60;pmod_&#x60; ID. The website uses &#x60;unmoderateUser&#x60; instead. You can delete the same player moderation multiple times successfully.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="playerModerationId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (Error)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Error>> DeletePlayerModerationWithHttpInfoAsync (string playerModerationId, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'playerModerationId' is set
            if (playerModerationId == null)
                throw new ApiException(400, "Missing required parameter 'playerModerationId' when calling PlayermoderationApi->DeletePlayerModeration");

            var localVarPath = "/auth/user/playermoderations/{playerModerationId}";
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

            if (playerModerationId != null) localVarPathParams.Add("playerModerationId", this.Configuration.ApiClient.ParameterToString(playerModerationId)); // path parameter

            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeletePlayerModeration", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Error>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Error) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Error)));
        }

        /// <summary>
        /// Get Player Moderation Returns a single Player Moderation. This returns the exact same amount of information as the more generalised &#x60;getPlayerModerations&#x60;.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="playerModerationId"></param>
        /// <returns>PlayerModeration</returns>
        public PlayerModeration GetPlayerModeration (string playerModerationId)
        {
             ApiResponse<PlayerModeration> localVarResponse = GetPlayerModerationWithHttpInfo(playerModerationId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Player Moderation Returns a single Player Moderation. This returns the exact same amount of information as the more generalised &#x60;getPlayerModerations&#x60;.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="playerModerationId"></param>
        /// <returns>ApiResponse of PlayerModeration</returns>
        public ApiResponse<PlayerModeration> GetPlayerModerationWithHttpInfo (string playerModerationId)
        {
            // verify the required parameter 'playerModerationId' is set
            if (playerModerationId == null)
                throw new ApiException(400, "Missing required parameter 'playerModerationId' when calling PlayermoderationApi->GetPlayerModeration");

            var localVarPath = "/auth/user/playermoderations/{playerModerationId}";
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

            if (playerModerationId != null) localVarPathParams.Add("playerModerationId", this.Configuration.ApiClient.ParameterToString(playerModerationId)); // path parameter

            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetPlayerModeration", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PlayerModeration>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PlayerModeration) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PlayerModeration)));
        }

        /// <summary>
        /// Get Player Moderation Returns a single Player Moderation. This returns the exact same amount of information as the more generalised &#x60;getPlayerModerations&#x60;.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="playerModerationId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of PlayerModeration</returns>
        public async System.Threading.Tasks.Task<PlayerModeration> GetPlayerModerationAsync (string playerModerationId, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<PlayerModeration> localVarResponse = await GetPlayerModerationWithHttpInfoAsync(playerModerationId, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Player Moderation Returns a single Player Moderation. This returns the exact same amount of information as the more generalised &#x60;getPlayerModerations&#x60;.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="playerModerationId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (PlayerModeration)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PlayerModeration>> GetPlayerModerationWithHttpInfoAsync (string playerModerationId, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'playerModerationId' is set
            if (playerModerationId == null)
                throw new ApiException(400, "Missing required parameter 'playerModerationId' when calling PlayermoderationApi->GetPlayerModeration");

            var localVarPath = "/auth/user/playermoderations/{playerModerationId}";
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

            if (playerModerationId != null) localVarPathParams.Add("playerModerationId", this.Configuration.ApiClient.ParameterToString(playerModerationId)); // path parameter

            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetPlayerModeration", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PlayerModeration>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PlayerModeration) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PlayerModeration)));
        }

        /// <summary>
        /// Search Player Moderations Returns a list of all player moderations made by **you**.  This endpoint does not have pagination, and will return *all* results. Use query parameters to limit your query if needed.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">Must be one of PlayerModerationType, except unblock. Unblocking simply removes a block. (optional)</param>
        /// <param name="targetUserId">Must be valid UserID. (optional)</param>
        /// <returns>List&lt;PlayerModeration&gt;</returns>
        public List<PlayerModeration> GetPlayerModerations (string type = default(string), string targetUserId = default(string))
        {
             ApiResponse<List<PlayerModeration>> localVarResponse = GetPlayerModerationsWithHttpInfo(type, targetUserId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search Player Moderations Returns a list of all player moderations made by **you**.  This endpoint does not have pagination, and will return *all* results. Use query parameters to limit your query if needed.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">Must be one of PlayerModerationType, except unblock. Unblocking simply removes a block. (optional)</param>
        /// <param name="targetUserId">Must be valid UserID. (optional)</param>
        /// <returns>ApiResponse of List&lt;PlayerModeration&gt;</returns>
        public ApiResponse<List<PlayerModeration>> GetPlayerModerationsWithHttpInfo (string type = default(string), string targetUserId = default(string))
        {

            var localVarPath = "/auth/user/playermoderations";
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

            if (type != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "type", type)); // query parameter
            if (targetUserId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "targetUserId", targetUserId)); // query parameter

            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetPlayerModerations", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<PlayerModeration>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<PlayerModeration>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<PlayerModeration>)));
        }

        /// <summary>
        /// Search Player Moderations Returns a list of all player moderations made by **you**.  This endpoint does not have pagination, and will return *all* results. Use query parameters to limit your query if needed.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">Must be one of PlayerModerationType, except unblock. Unblocking simply removes a block. (optional)</param>
        /// <param name="targetUserId">Must be valid UserID. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of List&lt;PlayerModeration&gt;</returns>
        public async System.Threading.Tasks.Task<List<PlayerModeration>> GetPlayerModerationsAsync (string type = default(string), string targetUserId = default(string), CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<List<PlayerModeration>> localVarResponse = await GetPlayerModerationsWithHttpInfoAsync(type, targetUserId, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search Player Moderations Returns a list of all player moderations made by **you**.  This endpoint does not have pagination, and will return *all* results. Use query parameters to limit your query if needed.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">Must be one of PlayerModerationType, except unblock. Unblocking simply removes a block. (optional)</param>
        /// <param name="targetUserId">Must be valid UserID. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (List&lt;PlayerModeration&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<PlayerModeration>>> GetPlayerModerationsWithHttpInfoAsync (string type = default(string), string targetUserId = default(string), CancellationToken cancellationToken = default(CancellationToken))
        {

            var localVarPath = "/auth/user/playermoderations";
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

            if (type != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "type", type)); // query parameter
            if (targetUserId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "targetUserId", targetUserId)); // query parameter

            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetPlayerModerations", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<PlayerModeration>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<PlayerModeration>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<PlayerModeration>)));
        }

        /// <summary>
        /// Moderate User Moderate a user, e.g. unmute them or show their avatar.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inlineObject12"> (optional)</param>
        /// <returns>PlayerModeration</returns>
        public PlayerModeration ModerateUser (InlineObject12 inlineObject12 = default(InlineObject12))
        {
             ApiResponse<PlayerModeration> localVarResponse = ModerateUserWithHttpInfo(inlineObject12);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Moderate User Moderate a user, e.g. unmute them or show their avatar.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inlineObject12"> (optional)</param>
        /// <returns>ApiResponse of PlayerModeration</returns>
        public ApiResponse<PlayerModeration> ModerateUserWithHttpInfo (InlineObject12 inlineObject12 = default(InlineObject12))
        {

            var localVarPath = "/auth/user/playermoderations";
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

            if (inlineObject12 != null && inlineObject12.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(inlineObject12); // http body (model) parameter
            }
            else
            {
                localVarPostBody = inlineObject12; // byte array
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
                Exception exception = ExceptionFactory("ModerateUser", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PlayerModeration>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PlayerModeration) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PlayerModeration)));
        }

        /// <summary>
        /// Moderate User Moderate a user, e.g. unmute them or show their avatar.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inlineObject12"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of PlayerModeration</returns>
        public async System.Threading.Tasks.Task<PlayerModeration> ModerateUserAsync (InlineObject12 inlineObject12 = default(InlineObject12), CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<PlayerModeration> localVarResponse = await ModerateUserWithHttpInfoAsync(inlineObject12, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Moderate User Moderate a user, e.g. unmute them or show their avatar.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inlineObject12"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (PlayerModeration)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PlayerModeration>> ModerateUserWithHttpInfoAsync (InlineObject12 inlineObject12 = default(InlineObject12), CancellationToken cancellationToken = default(CancellationToken))
        {

            var localVarPath = "/auth/user/playermoderations";
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

            if (inlineObject12 != null && inlineObject12.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(inlineObject12); // http body (model) parameter
            }
            else
            {
                localVarPostBody = inlineObject12; // byte array
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
                Exception exception = ExceptionFactory("ModerateUser", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PlayerModeration>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PlayerModeration) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PlayerModeration)));
        }

        /// <summary>
        /// Unmoderate User Removes a player moderation previously added through &#x60;moderateUser&#x60;. E.g if you previuosly have shown their avatar, but now want to reset it to default.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inlineObject13"> (optional)</param>
        /// <returns>Error</returns>
        public Error UnmoderateUser (InlineObject13 inlineObject13 = default(InlineObject13))
        {
             ApiResponse<Error> localVarResponse = UnmoderateUserWithHttpInfo(inlineObject13);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Unmoderate User Removes a player moderation previously added through &#x60;moderateUser&#x60;. E.g if you previuosly have shown their avatar, but now want to reset it to default.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inlineObject13"> (optional)</param>
        /// <returns>ApiResponse of Error</returns>
        public ApiResponse<Error> UnmoderateUserWithHttpInfo (InlineObject13 inlineObject13 = default(InlineObject13))
        {

            var localVarPath = "/auth/user/unplayermoderate";
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

            if (inlineObject13 != null && inlineObject13.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(inlineObject13); // http body (model) parameter
            }
            else
            {
                localVarPostBody = inlineObject13; // byte array
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
                Exception exception = ExceptionFactory("UnmoderateUser", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Error>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Error) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Error)));
        }

        /// <summary>
        /// Unmoderate User Removes a player moderation previously added through &#x60;moderateUser&#x60;. E.g if you previuosly have shown their avatar, but now want to reset it to default.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inlineObject13"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of Error</returns>
        public async System.Threading.Tasks.Task<Error> UnmoderateUserAsync (InlineObject13 inlineObject13 = default(InlineObject13), CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<Error> localVarResponse = await UnmoderateUserWithHttpInfoAsync(inlineObject13, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Unmoderate User Removes a player moderation previously added through &#x60;moderateUser&#x60;. E.g if you previuosly have shown their avatar, but now want to reset it to default.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inlineObject13"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (Error)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Error>> UnmoderateUserWithHttpInfoAsync (InlineObject13 inlineObject13 = default(InlineObject13), CancellationToken cancellationToken = default(CancellationToken))
        {

            var localVarPath = "/auth/user/unplayermoderate";
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

            if (inlineObject13 != null && inlineObject13.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(inlineObject13); // http body (model) parameter
            }
            else
            {
                localVarPostBody = inlineObject13; // byte array
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
                Exception exception = ExceptionFactory("UnmoderateUser", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Error>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Error) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Error)));
        }

    }
}
