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
    public interface IAvatarsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Create Avatar
        /// </summary>
        /// <remarks>
        /// Create an avatar. It&#39;s possible to optionally specify a ID if you want a custom one. Attempting to create an Avatar with an already claimed ID will result in a DB error.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inlineObject10"> (optional)</param>
        /// <returns>Avatar</returns>
        Avatar CreateAvatar (InlineObject10 inlineObject10 = default(InlineObject10));

        /// <summary>
        /// Create Avatar
        /// </summary>
        /// <remarks>
        /// Create an avatar. It&#39;s possible to optionally specify a ID if you want a custom one. Attempting to create an Avatar with an already claimed ID will result in a DB error.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inlineObject10"> (optional)</param>
        /// <returns>ApiResponse of Avatar</returns>
        ApiResponse<Avatar> CreateAvatarWithHttpInfo (InlineObject10 inlineObject10 = default(InlineObject10));
        /// <summary>
        /// Delete Avatar
        /// </summary>
        /// <remarks>
        /// Delete an avatar. Notice an avatar is never fully \&quot;deleted\&quot;, only its ReleaseStatus is set to \&quot;hidden\&quot; and the linked Files are deleted. The AvatarID is permanently reserved.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="avatarId"></param>
        /// <returns>Avatar</returns>
        Avatar DeleteAvatar (string avatarId);

        /// <summary>
        /// Delete Avatar
        /// </summary>
        /// <remarks>
        /// Delete an avatar. Notice an avatar is never fully \&quot;deleted\&quot;, only its ReleaseStatus is set to \&quot;hidden\&quot; and the linked Files are deleted. The AvatarID is permanently reserved.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="avatarId"></param>
        /// <returns>ApiResponse of Avatar</returns>
        ApiResponse<Avatar> DeleteAvatarWithHttpInfo (string avatarId);
        /// <summary>
        /// Get Avatar
        /// </summary>
        /// <remarks>
        /// Get information about a specific Avatar.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="avatarId"></param>
        /// <returns>Avatar</returns>
        Avatar GetAvatar (string avatarId);

        /// <summary>
        /// Get Avatar
        /// </summary>
        /// <remarks>
        /// Get information about a specific Avatar.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="avatarId"></param>
        /// <returns>ApiResponse of Avatar</returns>
        ApiResponse<Avatar> GetAvatarWithHttpInfo (string avatarId);
        /// <summary>
        /// List Favorited Avatars
        /// </summary>
        /// <remarks>
        /// Search and list favorited avatars by query filters.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="featured">Filters on featured results. (optional)</param>
        /// <param name="sort"> (optional, default to popularity)</param>
        /// <param name="n">The number of objects to return. (optional, default to 60)</param>
        /// <param name="order"> (optional, default to descending)</param>
        /// <param name="offset">A zero-based offset from the default object sorting from where search results start. (optional)</param>
        /// <param name="search">Filters by world name. (optional)</param>
        /// <param name="tag">Tags to include (comma-separated). (optional)</param>
        /// <param name="notag">Tags to exclude (comma-separated). (optional)</param>
        /// <param name="releaseStatus">Filter by ReleaseStatus. (optional, default to hidden)</param>
        /// <param name="maxUnityVersion">The maximum Unity version supported by the asset. (optional)</param>
        /// <param name="minUnityVersion">The minimum Unity version supported by the asset. (optional)</param>
        /// <param name="platform">The platform the asset supports. (optional)</param>
        /// <param name="userId">Target user to see information on, admin-only. (optional)</param>
        /// <returns>List&lt;Avatar&gt;</returns>
        List<Avatar> GetFavoritedAvatars (string featured = default(string), string sort = default(string), int? n = default(int?), string order = default(string), int? offset = default(int?), string search = default(string), string tag = default(string), string notag = default(string), string releaseStatus = default(string), string maxUnityVersion = default(string), string minUnityVersion = default(string), string platform = default(string), string userId = default(string));

        /// <summary>
        /// List Favorited Avatars
        /// </summary>
        /// <remarks>
        /// Search and list favorited avatars by query filters.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="featured">Filters on featured results. (optional)</param>
        /// <param name="sort"> (optional, default to popularity)</param>
        /// <param name="n">The number of objects to return. (optional, default to 60)</param>
        /// <param name="order"> (optional, default to descending)</param>
        /// <param name="offset">A zero-based offset from the default object sorting from where search results start. (optional)</param>
        /// <param name="search">Filters by world name. (optional)</param>
        /// <param name="tag">Tags to include (comma-separated). (optional)</param>
        /// <param name="notag">Tags to exclude (comma-separated). (optional)</param>
        /// <param name="releaseStatus">Filter by ReleaseStatus. (optional, default to hidden)</param>
        /// <param name="maxUnityVersion">The maximum Unity version supported by the asset. (optional)</param>
        /// <param name="minUnityVersion">The minimum Unity version supported by the asset. (optional)</param>
        /// <param name="platform">The platform the asset supports. (optional)</param>
        /// <param name="userId">Target user to see information on, admin-only. (optional)</param>
        /// <returns>ApiResponse of List&lt;Avatar&gt;</returns>
        ApiResponse<List<Avatar>> GetFavoritedAvatarsWithHttpInfo (string featured = default(string), string sort = default(string), int? n = default(int?), string order = default(string), int? offset = default(int?), string search = default(string), string tag = default(string), string notag = default(string), string releaseStatus = default(string), string maxUnityVersion = default(string), string minUnityVersion = default(string), string platform = default(string), string userId = default(string));
        /// <summary>
        /// Search Avatars
        /// </summary>
        /// <remarks>
        /// Search and list avatars by query filters. You can only search your own or featured avatars. It is not possible as a normal user to search other peoples avatars.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="featured">Filters on featured results. (optional)</param>
        /// <param name="sort"> (optional, default to popularity)</param>
        /// <param name="user">Set to &#x60;me&#x60; for searching own avatars. (optional)</param>
        /// <param name="userId">Filter by UserID. (optional)</param>
        /// <param name="n">The number of objects to return. (optional, default to 60)</param>
        /// <param name="order"> (optional, default to descending)</param>
        /// <param name="offset">A zero-based offset from the default object sorting from where search results start. (optional)</param>
        /// <param name="tag">Tags to include (comma-separated). (optional)</param>
        /// <param name="notag">Tags to exclude (comma-separated). (optional)</param>
        /// <param name="releaseStatus">Filter by ReleaseStatus. (optional, default to hidden)</param>
        /// <param name="maxUnityVersion">The maximum Unity version supported by the asset. (optional)</param>
        /// <param name="minUnityVersion">The minimum Unity version supported by the asset. (optional)</param>
        /// <param name="platform">The platform the asset supports. (optional)</param>
        /// <returns>List&lt;Avatar&gt;</returns>
        List<Avatar> SearchAvatars (string featured = default(string), string sort = default(string), string user = default(string), string userId = default(string), int? n = default(int?), string order = default(string), int? offset = default(int?), string tag = default(string), string notag = default(string), string releaseStatus = default(string), string maxUnityVersion = default(string), string minUnityVersion = default(string), string platform = default(string));

        /// <summary>
        /// Search Avatars
        /// </summary>
        /// <remarks>
        /// Search and list avatars by query filters. You can only search your own or featured avatars. It is not possible as a normal user to search other peoples avatars.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="featured">Filters on featured results. (optional)</param>
        /// <param name="sort"> (optional, default to popularity)</param>
        /// <param name="user">Set to &#x60;me&#x60; for searching own avatars. (optional)</param>
        /// <param name="userId">Filter by UserID. (optional)</param>
        /// <param name="n">The number of objects to return. (optional, default to 60)</param>
        /// <param name="order"> (optional, default to descending)</param>
        /// <param name="offset">A zero-based offset from the default object sorting from where search results start. (optional)</param>
        /// <param name="tag">Tags to include (comma-separated). (optional)</param>
        /// <param name="notag">Tags to exclude (comma-separated). (optional)</param>
        /// <param name="releaseStatus">Filter by ReleaseStatus. (optional, default to hidden)</param>
        /// <param name="maxUnityVersion">The maximum Unity version supported by the asset. (optional)</param>
        /// <param name="minUnityVersion">The minimum Unity version supported by the asset. (optional)</param>
        /// <param name="platform">The platform the asset supports. (optional)</param>
        /// <returns>ApiResponse of List&lt;Avatar&gt;</returns>
        ApiResponse<List<Avatar>> SearchAvatarsWithHttpInfo (string featured = default(string), string sort = default(string), string user = default(string), string userId = default(string), int? n = default(int?), string order = default(string), int? offset = default(int?), string tag = default(string), string notag = default(string), string releaseStatus = default(string), string maxUnityVersion = default(string), string minUnityVersion = default(string), string platform = default(string));
        /// <summary>
        /// Select Avatar
        /// </summary>
        /// <remarks>
        /// Switches into that avatar.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="avatarId"></param>
        /// <returns>CurrentUser</returns>
        CurrentUser SelectAvatar (string avatarId);

        /// <summary>
        /// Select Avatar
        /// </summary>
        /// <remarks>
        /// Switches into that avatar.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="avatarId"></param>
        /// <returns>ApiResponse of CurrentUser</returns>
        ApiResponse<CurrentUser> SelectAvatarWithHttpInfo (string avatarId);
        /// <summary>
        /// Update Avatar
        /// </summary>
        /// <remarks>
        /// Update information about a specific avatar.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="avatarId"></param>
        /// <param name="inlineObject11"> (optional)</param>
        /// <returns>Avatar</returns>
        Avatar UpdateAvatar (string avatarId, InlineObject11 inlineObject11 = default(InlineObject11));

        /// <summary>
        /// Update Avatar
        /// </summary>
        /// <remarks>
        /// Update information about a specific avatar.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="avatarId"></param>
        /// <param name="inlineObject11"> (optional)</param>
        /// <returns>ApiResponse of Avatar</returns>
        ApiResponse<Avatar> UpdateAvatarWithHttpInfo (string avatarId, InlineObject11 inlineObject11 = default(InlineObject11));
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Create Avatar
        /// </summary>
        /// <remarks>
        /// Create an avatar. It&#39;s possible to optionally specify a ID if you want a custom one. Attempting to create an Avatar with an already claimed ID will result in a DB error.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inlineObject10"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of Avatar</returns>
        System.Threading.Tasks.Task<Avatar> CreateAvatarAsync (InlineObject10 inlineObject10 = default(InlineObject10), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Create Avatar
        /// </summary>
        /// <remarks>
        /// Create an avatar. It&#39;s possible to optionally specify a ID if you want a custom one. Attempting to create an Avatar with an already claimed ID will result in a DB error.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inlineObject10"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (Avatar)</returns>
        System.Threading.Tasks.Task<ApiResponse<Avatar>> CreateAvatarWithHttpInfoAsync (InlineObject10 inlineObject10 = default(InlineObject10), CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete Avatar
        /// </summary>
        /// <remarks>
        /// Delete an avatar. Notice an avatar is never fully \&quot;deleted\&quot;, only its ReleaseStatus is set to \&quot;hidden\&quot; and the linked Files are deleted. The AvatarID is permanently reserved.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="avatarId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of Avatar</returns>
        System.Threading.Tasks.Task<Avatar> DeleteAvatarAsync (string avatarId, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Delete Avatar
        /// </summary>
        /// <remarks>
        /// Delete an avatar. Notice an avatar is never fully \&quot;deleted\&quot;, only its ReleaseStatus is set to \&quot;hidden\&quot; and the linked Files are deleted. The AvatarID is permanently reserved.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="avatarId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (Avatar)</returns>
        System.Threading.Tasks.Task<ApiResponse<Avatar>> DeleteAvatarWithHttpInfoAsync (string avatarId, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get Avatar
        /// </summary>
        /// <remarks>
        /// Get information about a specific Avatar.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="avatarId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of Avatar</returns>
        System.Threading.Tasks.Task<Avatar> GetAvatarAsync (string avatarId, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get Avatar
        /// </summary>
        /// <remarks>
        /// Get information about a specific Avatar.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="avatarId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (Avatar)</returns>
        System.Threading.Tasks.Task<ApiResponse<Avatar>> GetAvatarWithHttpInfoAsync (string avatarId, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// List Favorited Avatars
        /// </summary>
        /// <remarks>
        /// Search and list favorited avatars by query filters.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="featured">Filters on featured results. (optional)</param>
        /// <param name="sort"> (optional, default to popularity)</param>
        /// <param name="n">The number of objects to return. (optional, default to 60)</param>
        /// <param name="order"> (optional, default to descending)</param>
        /// <param name="offset">A zero-based offset from the default object sorting from where search results start. (optional)</param>
        /// <param name="search">Filters by world name. (optional)</param>
        /// <param name="tag">Tags to include (comma-separated). (optional)</param>
        /// <param name="notag">Tags to exclude (comma-separated). (optional)</param>
        /// <param name="releaseStatus">Filter by ReleaseStatus. (optional, default to hidden)</param>
        /// <param name="maxUnityVersion">The maximum Unity version supported by the asset. (optional)</param>
        /// <param name="minUnityVersion">The minimum Unity version supported by the asset. (optional)</param>
        /// <param name="platform">The platform the asset supports. (optional)</param>
        /// <param name="userId">Target user to see information on, admin-only. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of List&lt;Avatar&gt;</returns>
        System.Threading.Tasks.Task<List<Avatar>> GetFavoritedAvatarsAsync (string featured = default(string), string sort = default(string), int? n = default(int?), string order = default(string), int? offset = default(int?), string search = default(string), string tag = default(string), string notag = default(string), string releaseStatus = default(string), string maxUnityVersion = default(string), string minUnityVersion = default(string), string platform = default(string), string userId = default(string), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// List Favorited Avatars
        /// </summary>
        /// <remarks>
        /// Search and list favorited avatars by query filters.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="featured">Filters on featured results. (optional)</param>
        /// <param name="sort"> (optional, default to popularity)</param>
        /// <param name="n">The number of objects to return. (optional, default to 60)</param>
        /// <param name="order"> (optional, default to descending)</param>
        /// <param name="offset">A zero-based offset from the default object sorting from where search results start. (optional)</param>
        /// <param name="search">Filters by world name. (optional)</param>
        /// <param name="tag">Tags to include (comma-separated). (optional)</param>
        /// <param name="notag">Tags to exclude (comma-separated). (optional)</param>
        /// <param name="releaseStatus">Filter by ReleaseStatus. (optional, default to hidden)</param>
        /// <param name="maxUnityVersion">The maximum Unity version supported by the asset. (optional)</param>
        /// <param name="minUnityVersion">The minimum Unity version supported by the asset. (optional)</param>
        /// <param name="platform">The platform the asset supports. (optional)</param>
        /// <param name="userId">Target user to see information on, admin-only. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (List&lt;Avatar&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Avatar>>> GetFavoritedAvatarsWithHttpInfoAsync (string featured = default(string), string sort = default(string), int? n = default(int?), string order = default(string), int? offset = default(int?), string search = default(string), string tag = default(string), string notag = default(string), string releaseStatus = default(string), string maxUnityVersion = default(string), string minUnityVersion = default(string), string platform = default(string), string userId = default(string), CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Search Avatars
        /// </summary>
        /// <remarks>
        /// Search and list avatars by query filters. You can only search your own or featured avatars. It is not possible as a normal user to search other peoples avatars.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="featured">Filters on featured results. (optional)</param>
        /// <param name="sort"> (optional, default to popularity)</param>
        /// <param name="user">Set to &#x60;me&#x60; for searching own avatars. (optional)</param>
        /// <param name="userId">Filter by UserID. (optional)</param>
        /// <param name="n">The number of objects to return. (optional, default to 60)</param>
        /// <param name="order"> (optional, default to descending)</param>
        /// <param name="offset">A zero-based offset from the default object sorting from where search results start. (optional)</param>
        /// <param name="tag">Tags to include (comma-separated). (optional)</param>
        /// <param name="notag">Tags to exclude (comma-separated). (optional)</param>
        /// <param name="releaseStatus">Filter by ReleaseStatus. (optional, default to hidden)</param>
        /// <param name="maxUnityVersion">The maximum Unity version supported by the asset. (optional)</param>
        /// <param name="minUnityVersion">The minimum Unity version supported by the asset. (optional)</param>
        /// <param name="platform">The platform the asset supports. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of List&lt;Avatar&gt;</returns>
        System.Threading.Tasks.Task<List<Avatar>> SearchAvatarsAsync (string featured = default(string), string sort = default(string), string user = default(string), string userId = default(string), int? n = default(int?), string order = default(string), int? offset = default(int?), string tag = default(string), string notag = default(string), string releaseStatus = default(string), string maxUnityVersion = default(string), string minUnityVersion = default(string), string platform = default(string), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Search Avatars
        /// </summary>
        /// <remarks>
        /// Search and list avatars by query filters. You can only search your own or featured avatars. It is not possible as a normal user to search other peoples avatars.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="featured">Filters on featured results. (optional)</param>
        /// <param name="sort"> (optional, default to popularity)</param>
        /// <param name="user">Set to &#x60;me&#x60; for searching own avatars. (optional)</param>
        /// <param name="userId">Filter by UserID. (optional)</param>
        /// <param name="n">The number of objects to return. (optional, default to 60)</param>
        /// <param name="order"> (optional, default to descending)</param>
        /// <param name="offset">A zero-based offset from the default object sorting from where search results start. (optional)</param>
        /// <param name="tag">Tags to include (comma-separated). (optional)</param>
        /// <param name="notag">Tags to exclude (comma-separated). (optional)</param>
        /// <param name="releaseStatus">Filter by ReleaseStatus. (optional, default to hidden)</param>
        /// <param name="maxUnityVersion">The maximum Unity version supported by the asset. (optional)</param>
        /// <param name="minUnityVersion">The minimum Unity version supported by the asset. (optional)</param>
        /// <param name="platform">The platform the asset supports. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (List&lt;Avatar&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Avatar>>> SearchAvatarsWithHttpInfoAsync (string featured = default(string), string sort = default(string), string user = default(string), string userId = default(string), int? n = default(int?), string order = default(string), int? offset = default(int?), string tag = default(string), string notag = default(string), string releaseStatus = default(string), string maxUnityVersion = default(string), string minUnityVersion = default(string), string platform = default(string), CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Select Avatar
        /// </summary>
        /// <remarks>
        /// Switches into that avatar.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="avatarId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of CurrentUser</returns>
        System.Threading.Tasks.Task<CurrentUser> SelectAvatarAsync (string avatarId, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Select Avatar
        /// </summary>
        /// <remarks>
        /// Switches into that avatar.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="avatarId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (CurrentUser)</returns>
        System.Threading.Tasks.Task<ApiResponse<CurrentUser>> SelectAvatarWithHttpInfoAsync (string avatarId, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Update Avatar
        /// </summary>
        /// <remarks>
        /// Update information about a specific avatar.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="avatarId"></param>
        /// <param name="inlineObject11"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of Avatar</returns>
        System.Threading.Tasks.Task<Avatar> UpdateAvatarAsync (string avatarId, InlineObject11 inlineObject11 = default(InlineObject11), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Update Avatar
        /// </summary>
        /// <remarks>
        /// Update information about a specific avatar.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="avatarId"></param>
        /// <param name="inlineObject11"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (Avatar)</returns>
        System.Threading.Tasks.Task<ApiResponse<Avatar>> UpdateAvatarWithHttpInfoAsync (string avatarId, InlineObject11 inlineObject11 = default(InlineObject11), CancellationToken cancellationToken = default(CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AvatarsApi : IAvatarsApi
    {
        private io.github.vrchatapi.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AvatarsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AvatarsApi(String basePath)
        {
            this.Configuration = new io.github.vrchatapi.Client.Configuration { BasePath = basePath };

            ExceptionFactory = io.github.vrchatapi.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AvatarsApi"/> class
        /// </summary>
        /// <returns></returns>
        public AvatarsApi()
        {
            this.Configuration = io.github.vrchatapi.Client.Configuration.Default;

            ExceptionFactory = io.github.vrchatapi.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AvatarsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AvatarsApi(io.github.vrchatapi.Client.Configuration configuration = null)
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
        /// Create Avatar Create an avatar. It&#39;s possible to optionally specify a ID if you want a custom one. Attempting to create an Avatar with an already claimed ID will result in a DB error.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inlineObject10"> (optional)</param>
        /// <returns>Avatar</returns>
        public Avatar CreateAvatar (InlineObject10 inlineObject10 = default(InlineObject10))
        {
             ApiResponse<Avatar> localVarResponse = CreateAvatarWithHttpInfo(inlineObject10);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create Avatar Create an avatar. It&#39;s possible to optionally specify a ID if you want a custom one. Attempting to create an Avatar with an already claimed ID will result in a DB error.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inlineObject10"> (optional)</param>
        /// <returns>ApiResponse of Avatar</returns>
        public ApiResponse<Avatar> CreateAvatarWithHttpInfo (InlineObject10 inlineObject10 = default(InlineObject10))
        {

            var localVarPath = "/avatars";
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

            if (inlineObject10 != null && inlineObject10.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(inlineObject10); // http body (model) parameter
            }
            else
            {
                localVarPostBody = inlineObject10; // byte array
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
                Exception exception = ExceptionFactory("CreateAvatar", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Avatar>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Avatar) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Avatar)));
        }

        /// <summary>
        /// Create Avatar Create an avatar. It&#39;s possible to optionally specify a ID if you want a custom one. Attempting to create an Avatar with an already claimed ID will result in a DB error.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inlineObject10"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of Avatar</returns>
        public async System.Threading.Tasks.Task<Avatar> CreateAvatarAsync (InlineObject10 inlineObject10 = default(InlineObject10), CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<Avatar> localVarResponse = await CreateAvatarWithHttpInfoAsync(inlineObject10, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create Avatar Create an avatar. It&#39;s possible to optionally specify a ID if you want a custom one. Attempting to create an Avatar with an already claimed ID will result in a DB error.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inlineObject10"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (Avatar)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Avatar>> CreateAvatarWithHttpInfoAsync (InlineObject10 inlineObject10 = default(InlineObject10), CancellationToken cancellationToken = default(CancellationToken))
        {

            var localVarPath = "/avatars";
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

            if (inlineObject10 != null && inlineObject10.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(inlineObject10); // http body (model) parameter
            }
            else
            {
                localVarPostBody = inlineObject10; // byte array
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
                Exception exception = ExceptionFactory("CreateAvatar", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Avatar>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Avatar) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Avatar)));
        }

        /// <summary>
        /// Delete Avatar Delete an avatar. Notice an avatar is never fully \&quot;deleted\&quot;, only its ReleaseStatus is set to \&quot;hidden\&quot; and the linked Files are deleted. The AvatarID is permanently reserved.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="avatarId"></param>
        /// <returns>Avatar</returns>
        public Avatar DeleteAvatar (string avatarId)
        {
             ApiResponse<Avatar> localVarResponse = DeleteAvatarWithHttpInfo(avatarId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete Avatar Delete an avatar. Notice an avatar is never fully \&quot;deleted\&quot;, only its ReleaseStatus is set to \&quot;hidden\&quot; and the linked Files are deleted. The AvatarID is permanently reserved.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="avatarId"></param>
        /// <returns>ApiResponse of Avatar</returns>
        public ApiResponse<Avatar> DeleteAvatarWithHttpInfo (string avatarId)
        {
            // verify the required parameter 'avatarId' is set
            if (avatarId == null)
                throw new ApiException(400, "Missing required parameter 'avatarId' when calling AvatarsApi->DeleteAvatar");

            var localVarPath = "/avatars/{avatarId}";
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

            if (avatarId != null) localVarPathParams.Add("avatarId", this.Configuration.ApiClient.ParameterToString(avatarId)); // path parameter

            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteAvatar", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Avatar>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Avatar) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Avatar)));
        }

        /// <summary>
        /// Delete Avatar Delete an avatar. Notice an avatar is never fully \&quot;deleted\&quot;, only its ReleaseStatus is set to \&quot;hidden\&quot; and the linked Files are deleted. The AvatarID is permanently reserved.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="avatarId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of Avatar</returns>
        public async System.Threading.Tasks.Task<Avatar> DeleteAvatarAsync (string avatarId, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<Avatar> localVarResponse = await DeleteAvatarWithHttpInfoAsync(avatarId, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete Avatar Delete an avatar. Notice an avatar is never fully \&quot;deleted\&quot;, only its ReleaseStatus is set to \&quot;hidden\&quot; and the linked Files are deleted. The AvatarID is permanently reserved.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="avatarId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (Avatar)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Avatar>> DeleteAvatarWithHttpInfoAsync (string avatarId, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'avatarId' is set
            if (avatarId == null)
                throw new ApiException(400, "Missing required parameter 'avatarId' when calling AvatarsApi->DeleteAvatar");

            var localVarPath = "/avatars/{avatarId}";
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

            if (avatarId != null) localVarPathParams.Add("avatarId", this.Configuration.ApiClient.ParameterToString(avatarId)); // path parameter

            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteAvatar", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Avatar>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Avatar) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Avatar)));
        }

        /// <summary>
        /// Get Avatar Get information about a specific Avatar.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="avatarId"></param>
        /// <returns>Avatar</returns>
        public Avatar GetAvatar (string avatarId)
        {
             ApiResponse<Avatar> localVarResponse = GetAvatarWithHttpInfo(avatarId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Avatar Get information about a specific Avatar.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="avatarId"></param>
        /// <returns>ApiResponse of Avatar</returns>
        public ApiResponse<Avatar> GetAvatarWithHttpInfo (string avatarId)
        {
            // verify the required parameter 'avatarId' is set
            if (avatarId == null)
                throw new ApiException(400, "Missing required parameter 'avatarId' when calling AvatarsApi->GetAvatar");

            var localVarPath = "/avatars/{avatarId}";
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

            if (avatarId != null) localVarPathParams.Add("avatarId", this.Configuration.ApiClient.ParameterToString(avatarId)); // path parameter

            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetAvatar", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Avatar>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Avatar) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Avatar)));
        }

        /// <summary>
        /// Get Avatar Get information about a specific Avatar.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="avatarId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of Avatar</returns>
        public async System.Threading.Tasks.Task<Avatar> GetAvatarAsync (string avatarId, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<Avatar> localVarResponse = await GetAvatarWithHttpInfoAsync(avatarId, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Avatar Get information about a specific Avatar.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="avatarId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (Avatar)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Avatar>> GetAvatarWithHttpInfoAsync (string avatarId, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'avatarId' is set
            if (avatarId == null)
                throw new ApiException(400, "Missing required parameter 'avatarId' when calling AvatarsApi->GetAvatar");

            var localVarPath = "/avatars/{avatarId}";
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

            if (avatarId != null) localVarPathParams.Add("avatarId", this.Configuration.ApiClient.ParameterToString(avatarId)); // path parameter

            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetAvatar", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Avatar>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Avatar) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Avatar)));
        }

        /// <summary>
        /// List Favorited Avatars Search and list favorited avatars by query filters.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="featured">Filters on featured results. (optional)</param>
        /// <param name="sort"> (optional, default to popularity)</param>
        /// <param name="n">The number of objects to return. (optional, default to 60)</param>
        /// <param name="order"> (optional, default to descending)</param>
        /// <param name="offset">A zero-based offset from the default object sorting from where search results start. (optional)</param>
        /// <param name="search">Filters by world name. (optional)</param>
        /// <param name="tag">Tags to include (comma-separated). (optional)</param>
        /// <param name="notag">Tags to exclude (comma-separated). (optional)</param>
        /// <param name="releaseStatus">Filter by ReleaseStatus. (optional, default to hidden)</param>
        /// <param name="maxUnityVersion">The maximum Unity version supported by the asset. (optional)</param>
        /// <param name="minUnityVersion">The minimum Unity version supported by the asset. (optional)</param>
        /// <param name="platform">The platform the asset supports. (optional)</param>
        /// <param name="userId">Target user to see information on, admin-only. (optional)</param>
        /// <returns>List&lt;Avatar&gt;</returns>
        public List<Avatar> GetFavoritedAvatars (string featured = default(string), string sort = default(string), int? n = default(int?), string order = default(string), int? offset = default(int?), string search = default(string), string tag = default(string), string notag = default(string), string releaseStatus = default(string), string maxUnityVersion = default(string), string minUnityVersion = default(string), string platform = default(string), string userId = default(string))
        {
             ApiResponse<List<Avatar>> localVarResponse = GetFavoritedAvatarsWithHttpInfo(featured, sort, n, order, offset, search, tag, notag, releaseStatus, maxUnityVersion, minUnityVersion, platform, userId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List Favorited Avatars Search and list favorited avatars by query filters.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="featured">Filters on featured results. (optional)</param>
        /// <param name="sort"> (optional, default to popularity)</param>
        /// <param name="n">The number of objects to return. (optional, default to 60)</param>
        /// <param name="order"> (optional, default to descending)</param>
        /// <param name="offset">A zero-based offset from the default object sorting from where search results start. (optional)</param>
        /// <param name="search">Filters by world name. (optional)</param>
        /// <param name="tag">Tags to include (comma-separated). (optional)</param>
        /// <param name="notag">Tags to exclude (comma-separated). (optional)</param>
        /// <param name="releaseStatus">Filter by ReleaseStatus. (optional, default to hidden)</param>
        /// <param name="maxUnityVersion">The maximum Unity version supported by the asset. (optional)</param>
        /// <param name="minUnityVersion">The minimum Unity version supported by the asset. (optional)</param>
        /// <param name="platform">The platform the asset supports. (optional)</param>
        /// <param name="userId">Target user to see information on, admin-only. (optional)</param>
        /// <returns>ApiResponse of List&lt;Avatar&gt;</returns>
        public ApiResponse<List<Avatar>> GetFavoritedAvatarsWithHttpInfo (string featured = default(string), string sort = default(string), int? n = default(int?), string order = default(string), int? offset = default(int?), string search = default(string), string tag = default(string), string notag = default(string), string releaseStatus = default(string), string maxUnityVersion = default(string), string minUnityVersion = default(string), string platform = default(string), string userId = default(string))
        {

            var localVarPath = "/avatars/favorites";
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

            if (featured != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "featured", featured)); // query parameter
            if (sort != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "sort", sort)); // query parameter
            if (n != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "n", n)); // query parameter
            if (order != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "order", order)); // query parameter
            if (offset != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "offset", offset)); // query parameter
            if (search != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "search", search)); // query parameter
            if (tag != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "tag", tag)); // query parameter
            if (notag != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "notag", notag)); // query parameter
            if (releaseStatus != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "releaseStatus", releaseStatus)); // query parameter
            if (maxUnityVersion != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "maxUnityVersion", maxUnityVersion)); // query parameter
            if (minUnityVersion != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "minUnityVersion", minUnityVersion)); // query parameter
            if (platform != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "platform", platform)); // query parameter
            if (userId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "userId", userId)); // query parameter

            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetFavoritedAvatars", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<Avatar>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<Avatar>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Avatar>)));
        }

        /// <summary>
        /// List Favorited Avatars Search and list favorited avatars by query filters.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="featured">Filters on featured results. (optional)</param>
        /// <param name="sort"> (optional, default to popularity)</param>
        /// <param name="n">The number of objects to return. (optional, default to 60)</param>
        /// <param name="order"> (optional, default to descending)</param>
        /// <param name="offset">A zero-based offset from the default object sorting from where search results start. (optional)</param>
        /// <param name="search">Filters by world name. (optional)</param>
        /// <param name="tag">Tags to include (comma-separated). (optional)</param>
        /// <param name="notag">Tags to exclude (comma-separated). (optional)</param>
        /// <param name="releaseStatus">Filter by ReleaseStatus. (optional, default to hidden)</param>
        /// <param name="maxUnityVersion">The maximum Unity version supported by the asset. (optional)</param>
        /// <param name="minUnityVersion">The minimum Unity version supported by the asset. (optional)</param>
        /// <param name="platform">The platform the asset supports. (optional)</param>
        /// <param name="userId">Target user to see information on, admin-only. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of List&lt;Avatar&gt;</returns>
        public async System.Threading.Tasks.Task<List<Avatar>> GetFavoritedAvatarsAsync (string featured = default(string), string sort = default(string), int? n = default(int?), string order = default(string), int? offset = default(int?), string search = default(string), string tag = default(string), string notag = default(string), string releaseStatus = default(string), string maxUnityVersion = default(string), string minUnityVersion = default(string), string platform = default(string), string userId = default(string), CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<List<Avatar>> localVarResponse = await GetFavoritedAvatarsWithHttpInfoAsync(featured, sort, n, order, offset, search, tag, notag, releaseStatus, maxUnityVersion, minUnityVersion, platform, userId, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List Favorited Avatars Search and list favorited avatars by query filters.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="featured">Filters on featured results. (optional)</param>
        /// <param name="sort"> (optional, default to popularity)</param>
        /// <param name="n">The number of objects to return. (optional, default to 60)</param>
        /// <param name="order"> (optional, default to descending)</param>
        /// <param name="offset">A zero-based offset from the default object sorting from where search results start. (optional)</param>
        /// <param name="search">Filters by world name. (optional)</param>
        /// <param name="tag">Tags to include (comma-separated). (optional)</param>
        /// <param name="notag">Tags to exclude (comma-separated). (optional)</param>
        /// <param name="releaseStatus">Filter by ReleaseStatus. (optional, default to hidden)</param>
        /// <param name="maxUnityVersion">The maximum Unity version supported by the asset. (optional)</param>
        /// <param name="minUnityVersion">The minimum Unity version supported by the asset. (optional)</param>
        /// <param name="platform">The platform the asset supports. (optional)</param>
        /// <param name="userId">Target user to see information on, admin-only. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (List&lt;Avatar&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Avatar>>> GetFavoritedAvatarsWithHttpInfoAsync (string featured = default(string), string sort = default(string), int? n = default(int?), string order = default(string), int? offset = default(int?), string search = default(string), string tag = default(string), string notag = default(string), string releaseStatus = default(string), string maxUnityVersion = default(string), string minUnityVersion = default(string), string platform = default(string), string userId = default(string), CancellationToken cancellationToken = default(CancellationToken))
        {

            var localVarPath = "/avatars/favorites";
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

            if (featured != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "featured", featured)); // query parameter
            if (sort != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "sort", sort)); // query parameter
            if (n != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "n", n)); // query parameter
            if (order != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "order", order)); // query parameter
            if (offset != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "offset", offset)); // query parameter
            if (search != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "search", search)); // query parameter
            if (tag != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "tag", tag)); // query parameter
            if (notag != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "notag", notag)); // query parameter
            if (releaseStatus != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "releaseStatus", releaseStatus)); // query parameter
            if (maxUnityVersion != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "maxUnityVersion", maxUnityVersion)); // query parameter
            if (minUnityVersion != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "minUnityVersion", minUnityVersion)); // query parameter
            if (platform != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "platform", platform)); // query parameter
            if (userId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "userId", userId)); // query parameter

            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetFavoritedAvatars", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<Avatar>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<Avatar>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Avatar>)));
        }

        /// <summary>
        /// Search Avatars Search and list avatars by query filters. You can only search your own or featured avatars. It is not possible as a normal user to search other peoples avatars.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="featured">Filters on featured results. (optional)</param>
        /// <param name="sort"> (optional, default to popularity)</param>
        /// <param name="user">Set to &#x60;me&#x60; for searching own avatars. (optional)</param>
        /// <param name="userId">Filter by UserID. (optional)</param>
        /// <param name="n">The number of objects to return. (optional, default to 60)</param>
        /// <param name="order"> (optional, default to descending)</param>
        /// <param name="offset">A zero-based offset from the default object sorting from where search results start. (optional)</param>
        /// <param name="tag">Tags to include (comma-separated). (optional)</param>
        /// <param name="notag">Tags to exclude (comma-separated). (optional)</param>
        /// <param name="releaseStatus">Filter by ReleaseStatus. (optional, default to hidden)</param>
        /// <param name="maxUnityVersion">The maximum Unity version supported by the asset. (optional)</param>
        /// <param name="minUnityVersion">The minimum Unity version supported by the asset. (optional)</param>
        /// <param name="platform">The platform the asset supports. (optional)</param>
        /// <returns>List&lt;Avatar&gt;</returns>
        public List<Avatar> SearchAvatars (string featured = default(string), string sort = default(string), string user = default(string), string userId = default(string), int? n = default(int?), string order = default(string), int? offset = default(int?), string tag = default(string), string notag = default(string), string releaseStatus = default(string), string maxUnityVersion = default(string), string minUnityVersion = default(string), string platform = default(string))
        {
             ApiResponse<List<Avatar>> localVarResponse = SearchAvatarsWithHttpInfo(featured, sort, user, userId, n, order, offset, tag, notag, releaseStatus, maxUnityVersion, minUnityVersion, platform);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search Avatars Search and list avatars by query filters. You can only search your own or featured avatars. It is not possible as a normal user to search other peoples avatars.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="featured">Filters on featured results. (optional)</param>
        /// <param name="sort"> (optional, default to popularity)</param>
        /// <param name="user">Set to &#x60;me&#x60; for searching own avatars. (optional)</param>
        /// <param name="userId">Filter by UserID. (optional)</param>
        /// <param name="n">The number of objects to return. (optional, default to 60)</param>
        /// <param name="order"> (optional, default to descending)</param>
        /// <param name="offset">A zero-based offset from the default object sorting from where search results start. (optional)</param>
        /// <param name="tag">Tags to include (comma-separated). (optional)</param>
        /// <param name="notag">Tags to exclude (comma-separated). (optional)</param>
        /// <param name="releaseStatus">Filter by ReleaseStatus. (optional, default to hidden)</param>
        /// <param name="maxUnityVersion">The maximum Unity version supported by the asset. (optional)</param>
        /// <param name="minUnityVersion">The minimum Unity version supported by the asset. (optional)</param>
        /// <param name="platform">The platform the asset supports. (optional)</param>
        /// <returns>ApiResponse of List&lt;Avatar&gt;</returns>
        public ApiResponse<List<Avatar>> SearchAvatarsWithHttpInfo (string featured = default(string), string sort = default(string), string user = default(string), string userId = default(string), int? n = default(int?), string order = default(string), int? offset = default(int?), string tag = default(string), string notag = default(string), string releaseStatus = default(string), string maxUnityVersion = default(string), string minUnityVersion = default(string), string platform = default(string))
        {

            var localVarPath = "/avatars";
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

            if (featured != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "featured", featured)); // query parameter
            if (sort != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "sort", sort)); // query parameter
            if (user != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "user", user)); // query parameter
            if (userId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "userId", userId)); // query parameter
            if (n != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "n", n)); // query parameter
            if (order != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "order", order)); // query parameter
            if (offset != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "offset", offset)); // query parameter
            if (tag != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "tag", tag)); // query parameter
            if (notag != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "notag", notag)); // query parameter
            if (releaseStatus != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "releaseStatus", releaseStatus)); // query parameter
            if (maxUnityVersion != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "maxUnityVersion", maxUnityVersion)); // query parameter
            if (minUnityVersion != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "minUnityVersion", minUnityVersion)); // query parameter
            if (platform != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "platform", platform)); // query parameter

            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SearchAvatars", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<Avatar>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<Avatar>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Avatar>)));
        }

        /// <summary>
        /// Search Avatars Search and list avatars by query filters. You can only search your own or featured avatars. It is not possible as a normal user to search other peoples avatars.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="featured">Filters on featured results. (optional)</param>
        /// <param name="sort"> (optional, default to popularity)</param>
        /// <param name="user">Set to &#x60;me&#x60; for searching own avatars. (optional)</param>
        /// <param name="userId">Filter by UserID. (optional)</param>
        /// <param name="n">The number of objects to return. (optional, default to 60)</param>
        /// <param name="order"> (optional, default to descending)</param>
        /// <param name="offset">A zero-based offset from the default object sorting from where search results start. (optional)</param>
        /// <param name="tag">Tags to include (comma-separated). (optional)</param>
        /// <param name="notag">Tags to exclude (comma-separated). (optional)</param>
        /// <param name="releaseStatus">Filter by ReleaseStatus. (optional, default to hidden)</param>
        /// <param name="maxUnityVersion">The maximum Unity version supported by the asset. (optional)</param>
        /// <param name="minUnityVersion">The minimum Unity version supported by the asset. (optional)</param>
        /// <param name="platform">The platform the asset supports. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of List&lt;Avatar&gt;</returns>
        public async System.Threading.Tasks.Task<List<Avatar>> SearchAvatarsAsync (string featured = default(string), string sort = default(string), string user = default(string), string userId = default(string), int? n = default(int?), string order = default(string), int? offset = default(int?), string tag = default(string), string notag = default(string), string releaseStatus = default(string), string maxUnityVersion = default(string), string minUnityVersion = default(string), string platform = default(string), CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<List<Avatar>> localVarResponse = await SearchAvatarsWithHttpInfoAsync(featured, sort, user, userId, n, order, offset, tag, notag, releaseStatus, maxUnityVersion, minUnityVersion, platform, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search Avatars Search and list avatars by query filters. You can only search your own or featured avatars. It is not possible as a normal user to search other peoples avatars.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="featured">Filters on featured results. (optional)</param>
        /// <param name="sort"> (optional, default to popularity)</param>
        /// <param name="user">Set to &#x60;me&#x60; for searching own avatars. (optional)</param>
        /// <param name="userId">Filter by UserID. (optional)</param>
        /// <param name="n">The number of objects to return. (optional, default to 60)</param>
        /// <param name="order"> (optional, default to descending)</param>
        /// <param name="offset">A zero-based offset from the default object sorting from where search results start. (optional)</param>
        /// <param name="tag">Tags to include (comma-separated). (optional)</param>
        /// <param name="notag">Tags to exclude (comma-separated). (optional)</param>
        /// <param name="releaseStatus">Filter by ReleaseStatus. (optional, default to hidden)</param>
        /// <param name="maxUnityVersion">The maximum Unity version supported by the asset. (optional)</param>
        /// <param name="minUnityVersion">The minimum Unity version supported by the asset. (optional)</param>
        /// <param name="platform">The platform the asset supports. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (List&lt;Avatar&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Avatar>>> SearchAvatarsWithHttpInfoAsync (string featured = default(string), string sort = default(string), string user = default(string), string userId = default(string), int? n = default(int?), string order = default(string), int? offset = default(int?), string tag = default(string), string notag = default(string), string releaseStatus = default(string), string maxUnityVersion = default(string), string minUnityVersion = default(string), string platform = default(string), CancellationToken cancellationToken = default(CancellationToken))
        {

            var localVarPath = "/avatars";
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

            if (featured != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "featured", featured)); // query parameter
            if (sort != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "sort", sort)); // query parameter
            if (user != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "user", user)); // query parameter
            if (userId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "userId", userId)); // query parameter
            if (n != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "n", n)); // query parameter
            if (order != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "order", order)); // query parameter
            if (offset != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "offset", offset)); // query parameter
            if (tag != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "tag", tag)); // query parameter
            if (notag != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "notag", notag)); // query parameter
            if (releaseStatus != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "releaseStatus", releaseStatus)); // query parameter
            if (maxUnityVersion != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "maxUnityVersion", maxUnityVersion)); // query parameter
            if (minUnityVersion != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "minUnityVersion", minUnityVersion)); // query parameter
            if (platform != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "platform", platform)); // query parameter

            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SearchAvatars", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<Avatar>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<Avatar>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Avatar>)));
        }

        /// <summary>
        /// Select Avatar Switches into that avatar.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="avatarId"></param>
        /// <returns>CurrentUser</returns>
        public CurrentUser SelectAvatar (string avatarId)
        {
             ApiResponse<CurrentUser> localVarResponse = SelectAvatarWithHttpInfo(avatarId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Select Avatar Switches into that avatar.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="avatarId"></param>
        /// <returns>ApiResponse of CurrentUser</returns>
        public ApiResponse<CurrentUser> SelectAvatarWithHttpInfo (string avatarId)
        {
            // verify the required parameter 'avatarId' is set
            if (avatarId == null)
                throw new ApiException(400, "Missing required parameter 'avatarId' when calling AvatarsApi->SelectAvatar");

            var localVarPath = "/avatars/{avatarId}/select";
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

            if (avatarId != null) localVarPathParams.Add("avatarId", this.Configuration.ApiClient.ParameterToString(avatarId)); // path parameter

            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SelectAvatar", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CurrentUser>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (CurrentUser) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CurrentUser)));
        }

        /// <summary>
        /// Select Avatar Switches into that avatar.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="avatarId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of CurrentUser</returns>
        public async System.Threading.Tasks.Task<CurrentUser> SelectAvatarAsync (string avatarId, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<CurrentUser> localVarResponse = await SelectAvatarWithHttpInfoAsync(avatarId, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Select Avatar Switches into that avatar.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="avatarId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (CurrentUser)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CurrentUser>> SelectAvatarWithHttpInfoAsync (string avatarId, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'avatarId' is set
            if (avatarId == null)
                throw new ApiException(400, "Missing required parameter 'avatarId' when calling AvatarsApi->SelectAvatar");

            var localVarPath = "/avatars/{avatarId}/select";
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

            if (avatarId != null) localVarPathParams.Add("avatarId", this.Configuration.ApiClient.ParameterToString(avatarId)); // path parameter

            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SelectAvatar", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CurrentUser>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (CurrentUser) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CurrentUser)));
        }

        /// <summary>
        /// Update Avatar Update information about a specific avatar.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="avatarId"></param>
        /// <param name="inlineObject11"> (optional)</param>
        /// <returns>Avatar</returns>
        public Avatar UpdateAvatar (string avatarId, InlineObject11 inlineObject11 = default(InlineObject11))
        {
             ApiResponse<Avatar> localVarResponse = UpdateAvatarWithHttpInfo(avatarId, inlineObject11);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update Avatar Update information about a specific avatar.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="avatarId"></param>
        /// <param name="inlineObject11"> (optional)</param>
        /// <returns>ApiResponse of Avatar</returns>
        public ApiResponse<Avatar> UpdateAvatarWithHttpInfo (string avatarId, InlineObject11 inlineObject11 = default(InlineObject11))
        {
            // verify the required parameter 'avatarId' is set
            if (avatarId == null)
                throw new ApiException(400, "Missing required parameter 'avatarId' when calling AvatarsApi->UpdateAvatar");

            var localVarPath = "/avatars/{avatarId}";
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

            if (avatarId != null) localVarPathParams.Add("avatarId", this.Configuration.ApiClient.ParameterToString(avatarId)); // path parameter
            if (inlineObject11 != null && inlineObject11.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(inlineObject11); // http body (model) parameter
            }
            else
            {
                localVarPostBody = inlineObject11; // byte array
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
                Exception exception = ExceptionFactory("UpdateAvatar", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Avatar>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Avatar) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Avatar)));
        }

        /// <summary>
        /// Update Avatar Update information about a specific avatar.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="avatarId"></param>
        /// <param name="inlineObject11"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of Avatar</returns>
        public async System.Threading.Tasks.Task<Avatar> UpdateAvatarAsync (string avatarId, InlineObject11 inlineObject11 = default(InlineObject11), CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<Avatar> localVarResponse = await UpdateAvatarWithHttpInfoAsync(avatarId, inlineObject11, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update Avatar Update information about a specific avatar.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="avatarId"></param>
        /// <param name="inlineObject11"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (Avatar)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Avatar>> UpdateAvatarWithHttpInfoAsync (string avatarId, InlineObject11 inlineObject11 = default(InlineObject11), CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'avatarId' is set
            if (avatarId == null)
                throw new ApiException(400, "Missing required parameter 'avatarId' when calling AvatarsApi->UpdateAvatar");

            var localVarPath = "/avatars/{avatarId}";
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

            if (avatarId != null) localVarPathParams.Add("avatarId", this.Configuration.ApiClient.ParameterToString(avatarId)); // path parameter
            if (inlineObject11 != null && inlineObject11.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(inlineObject11); // http body (model) parameter
            }
            else
            {
                localVarPostBody = inlineObject11; // byte array
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
                Exception exception = ExceptionFactory("UpdateAvatar", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Avatar>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Avatar) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Avatar)));
        }

    }
}
