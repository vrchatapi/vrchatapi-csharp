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
    public interface IFavoritesApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Add Favorite
        /// </summary>
        /// <remarks>
        /// Add a new favorite.  Friend groups are named &#x60;group_0&#x60; through &#x60;group_3&#x60;. Avatar and World groups are named &#x60;avatars1&#x60; to &#x60;avatar4&#x60; and &#x60;worlds1&#x60; to &#x60;worlds4&#x60;.  You cannot add people whom you are not friends with to your friends list. Destroying a friendship removes the person as favorite on both sides.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inlineObject7"> (optional)</param>
        /// <returns>Favorite</returns>
        Favorite AddFavorite (InlineObject7 inlineObject7 = default(InlineObject7));

        /// <summary>
        /// Add Favorite
        /// </summary>
        /// <remarks>
        /// Add a new favorite.  Friend groups are named &#x60;group_0&#x60; through &#x60;group_3&#x60;. Avatar and World groups are named &#x60;avatars1&#x60; to &#x60;avatar4&#x60; and &#x60;worlds1&#x60; to &#x60;worlds4&#x60;.  You cannot add people whom you are not friends with to your friends list. Destroying a friendship removes the person as favorite on both sides.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inlineObject7"> (optional)</param>
        /// <returns>ApiResponse of Favorite</returns>
        ApiResponse<Favorite> AddFavoriteWithHttpInfo (InlineObject7 inlineObject7 = default(InlineObject7));
        /// <summary>
        /// Clear Favorite Group
        /// </summary>
        /// <remarks>
        /// Clear ALL contents of a specific favorite group.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="favoriteGroupType">The type of group to fetch, must be a valid FavoriteType.</param>
        /// <param name="favoriteGroupName"></param>
        /// <param name="userId"></param>
        /// <returns>Error</returns>
        Error ClearFavoriteGroup (string favoriteGroupType, string favoriteGroupName, string userId);

        /// <summary>
        /// Clear Favorite Group
        /// </summary>
        /// <remarks>
        /// Clear ALL contents of a specific favorite group.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="favoriteGroupType">The type of group to fetch, must be a valid FavoriteType.</param>
        /// <param name="favoriteGroupName"></param>
        /// <param name="userId"></param>
        /// <returns>ApiResponse of Error</returns>
        ApiResponse<Error> ClearFavoriteGroupWithHttpInfo (string favoriteGroupType, string favoriteGroupName, string userId);
        /// <summary>
        /// Show Favorite
        /// </summary>
        /// <remarks>
        /// Return information about a specific Favorite.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="favoriteId"></param>
        /// <returns>Favorite</returns>
        Favorite GetFavorite (string favoriteId);

        /// <summary>
        /// Show Favorite
        /// </summary>
        /// <remarks>
        /// Return information about a specific Favorite.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="favoriteId"></param>
        /// <returns>ApiResponse of Favorite</returns>
        ApiResponse<Favorite> GetFavoriteWithHttpInfo (string favoriteId);
        /// <summary>
        /// Show Favorite Group
        /// </summary>
        /// <remarks>
        /// Fetch information about a specific favorite group.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="favoriteGroupType">The type of group to fetch, must be a valid FavoriteType.</param>
        /// <param name="favoriteGroupName"></param>
        /// <param name="userId"></param>
        /// <returns>FavoriteGroup</returns>
        FavoriteGroup GetFavoriteGroup (string favoriteGroupType, string favoriteGroupName, string userId);

        /// <summary>
        /// Show Favorite Group
        /// </summary>
        /// <remarks>
        /// Fetch information about a specific favorite group.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="favoriteGroupType">The type of group to fetch, must be a valid FavoriteType.</param>
        /// <param name="favoriteGroupName"></param>
        /// <param name="userId"></param>
        /// <returns>ApiResponse of FavoriteGroup</returns>
        ApiResponse<FavoriteGroup> GetFavoriteGroupWithHttpInfo (string favoriteGroupType, string favoriteGroupName, string userId);
        /// <summary>
        /// List Favorite Groups
        /// </summary>
        /// <remarks>
        /// Return a list of favorite groups owned by a user. Returns the same information as &#x60;getFavoriteGroups&#x60;.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="n">The number of objects to return. (optional, default to 60)</param>
        /// <param name="offset">A zero-based offset from the default object sorting from where search results start. (optional)</param>
        /// <param name="ownerId">The owner of whoms favorite groups to return. Must be a UserID. (optional)</param>
        /// <returns>List&lt;FavoriteGroup&gt;</returns>
        List<FavoriteGroup> GetFavoriteGroups (int? n = default(int?), int? offset = default(int?), string ownerId = default(string));

        /// <summary>
        /// List Favorite Groups
        /// </summary>
        /// <remarks>
        /// Return a list of favorite groups owned by a user. Returns the same information as &#x60;getFavoriteGroups&#x60;.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="n">The number of objects to return. (optional, default to 60)</param>
        /// <param name="offset">A zero-based offset from the default object sorting from where search results start. (optional)</param>
        /// <param name="ownerId">The owner of whoms favorite groups to return. Must be a UserID. (optional)</param>
        /// <returns>ApiResponse of List&lt;FavoriteGroup&gt;</returns>
        ApiResponse<List<FavoriteGroup>> GetFavoriteGroupsWithHttpInfo (int? n = default(int?), int? offset = default(int?), string ownerId = default(string));
        /// <summary>
        /// List Favorites
        /// </summary>
        /// <remarks>
        /// Returns a list of favorites.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="n">The number of objects to return. (optional, default to 60)</param>
        /// <param name="offset">A zero-based offset from the default object sorting from where search results start. (optional)</param>
        /// <param name="type">The type of favorites to return, FavoriteType. (optional)</param>
        /// <param name="tag">Tags to include (comma-separated). (optional)</param>
        /// <returns>List&lt;Favorite&gt;</returns>
        List<Favorite> GetFavorites (int? n = default(int?), int? offset = default(int?), string type = default(string), string tag = default(string));

        /// <summary>
        /// List Favorites
        /// </summary>
        /// <remarks>
        /// Returns a list of favorites.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="n">The number of objects to return. (optional, default to 60)</param>
        /// <param name="offset">A zero-based offset from the default object sorting from where search results start. (optional)</param>
        /// <param name="type">The type of favorites to return, FavoriteType. (optional)</param>
        /// <param name="tag">Tags to include (comma-separated). (optional)</param>
        /// <returns>ApiResponse of List&lt;Favorite&gt;</returns>
        ApiResponse<List<Favorite>> GetFavoritesWithHttpInfo (int? n = default(int?), int? offset = default(int?), string type = default(string), string tag = default(string));
        /// <summary>
        /// Remove Favorite
        /// </summary>
        /// <remarks>
        /// Remove a favorite from your favorites list.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="favoriteId"></param>
        /// <returns>Error</returns>
        Error RemoveFavorite (string favoriteId);

        /// <summary>
        /// Remove Favorite
        /// </summary>
        /// <remarks>
        /// Remove a favorite from your favorites list.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="favoriteId"></param>
        /// <returns>ApiResponse of Error</returns>
        ApiResponse<Error> RemoveFavoriteWithHttpInfo (string favoriteId);
        /// <summary>
        /// Update Favorite Group
        /// </summary>
        /// <remarks>
        /// Update information about a specific favorite group.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="favoriteGroupType">The type of group to fetch, must be a valid FavoriteType.</param>
        /// <param name="favoriteGroupName"></param>
        /// <param name="userId"></param>
        /// <param name="inlineObject8"> (optional)</param>
        /// <returns></returns>
        void UpdateFavoriteGroup (string favoriteGroupType, string favoriteGroupName, string userId, InlineObject8 inlineObject8 = default(InlineObject8));

        /// <summary>
        /// Update Favorite Group
        /// </summary>
        /// <remarks>
        /// Update information about a specific favorite group.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="favoriteGroupType">The type of group to fetch, must be a valid FavoriteType.</param>
        /// <param name="favoriteGroupName"></param>
        /// <param name="userId"></param>
        /// <param name="inlineObject8"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateFavoriteGroupWithHttpInfo (string favoriteGroupType, string favoriteGroupName, string userId, InlineObject8 inlineObject8 = default(InlineObject8));
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Add Favorite
        /// </summary>
        /// <remarks>
        /// Add a new favorite.  Friend groups are named &#x60;group_0&#x60; through &#x60;group_3&#x60;. Avatar and World groups are named &#x60;avatars1&#x60; to &#x60;avatar4&#x60; and &#x60;worlds1&#x60; to &#x60;worlds4&#x60;.  You cannot add people whom you are not friends with to your friends list. Destroying a friendship removes the person as favorite on both sides.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inlineObject7"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of Favorite</returns>
        System.Threading.Tasks.Task<Favorite> AddFavoriteAsync (InlineObject7 inlineObject7 = default(InlineObject7), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Add Favorite
        /// </summary>
        /// <remarks>
        /// Add a new favorite.  Friend groups are named &#x60;group_0&#x60; through &#x60;group_3&#x60;. Avatar and World groups are named &#x60;avatars1&#x60; to &#x60;avatar4&#x60; and &#x60;worlds1&#x60; to &#x60;worlds4&#x60;.  You cannot add people whom you are not friends with to your friends list. Destroying a friendship removes the person as favorite on both sides.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inlineObject7"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (Favorite)</returns>
        System.Threading.Tasks.Task<ApiResponse<Favorite>> AddFavoriteWithHttpInfoAsync (InlineObject7 inlineObject7 = default(InlineObject7), CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Clear Favorite Group
        /// </summary>
        /// <remarks>
        /// Clear ALL contents of a specific favorite group.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="favoriteGroupType">The type of group to fetch, must be a valid FavoriteType.</param>
        /// <param name="favoriteGroupName"></param>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of Error</returns>
        System.Threading.Tasks.Task<Error> ClearFavoriteGroupAsync (string favoriteGroupType, string favoriteGroupName, string userId, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Clear Favorite Group
        /// </summary>
        /// <remarks>
        /// Clear ALL contents of a specific favorite group.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="favoriteGroupType">The type of group to fetch, must be a valid FavoriteType.</param>
        /// <param name="favoriteGroupName"></param>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (Error)</returns>
        System.Threading.Tasks.Task<ApiResponse<Error>> ClearFavoriteGroupWithHttpInfoAsync (string favoriteGroupType, string favoriteGroupName, string userId, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Show Favorite
        /// </summary>
        /// <remarks>
        /// Return information about a specific Favorite.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="favoriteId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of Favorite</returns>
        System.Threading.Tasks.Task<Favorite> GetFavoriteAsync (string favoriteId, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Show Favorite
        /// </summary>
        /// <remarks>
        /// Return information about a specific Favorite.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="favoriteId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (Favorite)</returns>
        System.Threading.Tasks.Task<ApiResponse<Favorite>> GetFavoriteWithHttpInfoAsync (string favoriteId, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Show Favorite Group
        /// </summary>
        /// <remarks>
        /// Fetch information about a specific favorite group.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="favoriteGroupType">The type of group to fetch, must be a valid FavoriteType.</param>
        /// <param name="favoriteGroupName"></param>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of FavoriteGroup</returns>
        System.Threading.Tasks.Task<FavoriteGroup> GetFavoriteGroupAsync (string favoriteGroupType, string favoriteGroupName, string userId, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Show Favorite Group
        /// </summary>
        /// <remarks>
        /// Fetch information about a specific favorite group.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="favoriteGroupType">The type of group to fetch, must be a valid FavoriteType.</param>
        /// <param name="favoriteGroupName"></param>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (FavoriteGroup)</returns>
        System.Threading.Tasks.Task<ApiResponse<FavoriteGroup>> GetFavoriteGroupWithHttpInfoAsync (string favoriteGroupType, string favoriteGroupName, string userId, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// List Favorite Groups
        /// </summary>
        /// <remarks>
        /// Return a list of favorite groups owned by a user. Returns the same information as &#x60;getFavoriteGroups&#x60;.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="n">The number of objects to return. (optional, default to 60)</param>
        /// <param name="offset">A zero-based offset from the default object sorting from where search results start. (optional)</param>
        /// <param name="ownerId">The owner of whoms favorite groups to return. Must be a UserID. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of List&lt;FavoriteGroup&gt;</returns>
        System.Threading.Tasks.Task<List<FavoriteGroup>> GetFavoriteGroupsAsync (int? n = default(int?), int? offset = default(int?), string ownerId = default(string), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// List Favorite Groups
        /// </summary>
        /// <remarks>
        /// Return a list of favorite groups owned by a user. Returns the same information as &#x60;getFavoriteGroups&#x60;.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="n">The number of objects to return. (optional, default to 60)</param>
        /// <param name="offset">A zero-based offset from the default object sorting from where search results start. (optional)</param>
        /// <param name="ownerId">The owner of whoms favorite groups to return. Must be a UserID. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (List&lt;FavoriteGroup&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<FavoriteGroup>>> GetFavoriteGroupsWithHttpInfoAsync (int? n = default(int?), int? offset = default(int?), string ownerId = default(string), CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// List Favorites
        /// </summary>
        /// <remarks>
        /// Returns a list of favorites.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="n">The number of objects to return. (optional, default to 60)</param>
        /// <param name="offset">A zero-based offset from the default object sorting from where search results start. (optional)</param>
        /// <param name="type">The type of favorites to return, FavoriteType. (optional)</param>
        /// <param name="tag">Tags to include (comma-separated). (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of List&lt;Favorite&gt;</returns>
        System.Threading.Tasks.Task<List<Favorite>> GetFavoritesAsync (int? n = default(int?), int? offset = default(int?), string type = default(string), string tag = default(string), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// List Favorites
        /// </summary>
        /// <remarks>
        /// Returns a list of favorites.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="n">The number of objects to return. (optional, default to 60)</param>
        /// <param name="offset">A zero-based offset from the default object sorting from where search results start. (optional)</param>
        /// <param name="type">The type of favorites to return, FavoriteType. (optional)</param>
        /// <param name="tag">Tags to include (comma-separated). (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (List&lt;Favorite&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Favorite>>> GetFavoritesWithHttpInfoAsync (int? n = default(int?), int? offset = default(int?), string type = default(string), string tag = default(string), CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Remove Favorite
        /// </summary>
        /// <remarks>
        /// Remove a favorite from your favorites list.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="favoriteId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of Error</returns>
        System.Threading.Tasks.Task<Error> RemoveFavoriteAsync (string favoriteId, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Remove Favorite
        /// </summary>
        /// <remarks>
        /// Remove a favorite from your favorites list.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="favoriteId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (Error)</returns>
        System.Threading.Tasks.Task<ApiResponse<Error>> RemoveFavoriteWithHttpInfoAsync (string favoriteId, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Update Favorite Group
        /// </summary>
        /// <remarks>
        /// Update information about a specific favorite group.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="favoriteGroupType">The type of group to fetch, must be a valid FavoriteType.</param>
        /// <param name="favoriteGroupName"></param>
        /// <param name="userId"></param>
        /// <param name="inlineObject8"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateFavoriteGroupAsync (string favoriteGroupType, string favoriteGroupName, string userId, InlineObject8 inlineObject8 = default(InlineObject8), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Update Favorite Group
        /// </summary>
        /// <remarks>
        /// Update information about a specific favorite group.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="favoriteGroupType">The type of group to fetch, must be a valid FavoriteType.</param>
        /// <param name="favoriteGroupName"></param>
        /// <param name="userId"></param>
        /// <param name="inlineObject8"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateFavoriteGroupWithHttpInfoAsync (string favoriteGroupType, string favoriteGroupName, string userId, InlineObject8 inlineObject8 = default(InlineObject8), CancellationToken cancellationToken = default(CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class FavoritesApi : IFavoritesApi
    {
        private io.github.vrchatapi.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="FavoritesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public FavoritesApi(String basePath)
        {
            this.Configuration = new io.github.vrchatapi.Client.Configuration { BasePath = basePath };

            ExceptionFactory = io.github.vrchatapi.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FavoritesApi"/> class
        /// </summary>
        /// <returns></returns>
        public FavoritesApi()
        {
            this.Configuration = io.github.vrchatapi.Client.Configuration.Default;

            ExceptionFactory = io.github.vrchatapi.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FavoritesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public FavoritesApi(io.github.vrchatapi.Client.Configuration configuration = null)
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
        /// Add Favorite Add a new favorite.  Friend groups are named &#x60;group_0&#x60; through &#x60;group_3&#x60;. Avatar and World groups are named &#x60;avatars1&#x60; to &#x60;avatar4&#x60; and &#x60;worlds1&#x60; to &#x60;worlds4&#x60;.  You cannot add people whom you are not friends with to your friends list. Destroying a friendship removes the person as favorite on both sides.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inlineObject7"> (optional)</param>
        /// <returns>Favorite</returns>
        public Favorite AddFavorite (InlineObject7 inlineObject7 = default(InlineObject7))
        {
             ApiResponse<Favorite> localVarResponse = AddFavoriteWithHttpInfo(inlineObject7);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Add Favorite Add a new favorite.  Friend groups are named &#x60;group_0&#x60; through &#x60;group_3&#x60;. Avatar and World groups are named &#x60;avatars1&#x60; to &#x60;avatar4&#x60; and &#x60;worlds1&#x60; to &#x60;worlds4&#x60;.  You cannot add people whom you are not friends with to your friends list. Destroying a friendship removes the person as favorite on both sides.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inlineObject7"> (optional)</param>
        /// <returns>ApiResponse of Favorite</returns>
        public ApiResponse<Favorite> AddFavoriteWithHttpInfo (InlineObject7 inlineObject7 = default(InlineObject7))
        {

            var localVarPath = "/favorites";
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

            if (inlineObject7 != null && inlineObject7.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(inlineObject7); // http body (model) parameter
            }
            else
            {
                localVarPostBody = inlineObject7; // byte array
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
                Exception exception = ExceptionFactory("AddFavorite", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Favorite>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Favorite) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Favorite)));
        }

        /// <summary>
        /// Add Favorite Add a new favorite.  Friend groups are named &#x60;group_0&#x60; through &#x60;group_3&#x60;. Avatar and World groups are named &#x60;avatars1&#x60; to &#x60;avatar4&#x60; and &#x60;worlds1&#x60; to &#x60;worlds4&#x60;.  You cannot add people whom you are not friends with to your friends list. Destroying a friendship removes the person as favorite on both sides.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inlineObject7"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of Favorite</returns>
        public async System.Threading.Tasks.Task<Favorite> AddFavoriteAsync (InlineObject7 inlineObject7 = default(InlineObject7), CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<Favorite> localVarResponse = await AddFavoriteWithHttpInfoAsync(inlineObject7, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Add Favorite Add a new favorite.  Friend groups are named &#x60;group_0&#x60; through &#x60;group_3&#x60;. Avatar and World groups are named &#x60;avatars1&#x60; to &#x60;avatar4&#x60; and &#x60;worlds1&#x60; to &#x60;worlds4&#x60;.  You cannot add people whom you are not friends with to your friends list. Destroying a friendship removes the person as favorite on both sides.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inlineObject7"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (Favorite)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Favorite>> AddFavoriteWithHttpInfoAsync (InlineObject7 inlineObject7 = default(InlineObject7), CancellationToken cancellationToken = default(CancellationToken))
        {

            var localVarPath = "/favorites";
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

            if (inlineObject7 != null && inlineObject7.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(inlineObject7); // http body (model) parameter
            }
            else
            {
                localVarPostBody = inlineObject7; // byte array
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
                Exception exception = ExceptionFactory("AddFavorite", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Favorite>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Favorite) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Favorite)));
        }

        /// <summary>
        /// Clear Favorite Group Clear ALL contents of a specific favorite group.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="favoriteGroupType">The type of group to fetch, must be a valid FavoriteType.</param>
        /// <param name="favoriteGroupName"></param>
        /// <param name="userId"></param>
        /// <returns>Error</returns>
        public Error ClearFavoriteGroup (string favoriteGroupType, string favoriteGroupName, string userId)
        {
             ApiResponse<Error> localVarResponse = ClearFavoriteGroupWithHttpInfo(favoriteGroupType, favoriteGroupName, userId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Clear Favorite Group Clear ALL contents of a specific favorite group.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="favoriteGroupType">The type of group to fetch, must be a valid FavoriteType.</param>
        /// <param name="favoriteGroupName"></param>
        /// <param name="userId"></param>
        /// <returns>ApiResponse of Error</returns>
        public ApiResponse<Error> ClearFavoriteGroupWithHttpInfo (string favoriteGroupType, string favoriteGroupName, string userId)
        {
            // verify the required parameter 'favoriteGroupType' is set
            if (favoriteGroupType == null)
                throw new ApiException(400, "Missing required parameter 'favoriteGroupType' when calling FavoritesApi->ClearFavoriteGroup");
            // verify the required parameter 'favoriteGroupName' is set
            if (favoriteGroupName == null)
                throw new ApiException(400, "Missing required parameter 'favoriteGroupName' when calling FavoritesApi->ClearFavoriteGroup");
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling FavoritesApi->ClearFavoriteGroup");

            var localVarPath = "/favorite/group/{favoriteGroupType}/{favoriteGroupName}/{userId}";
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

            if (favoriteGroupType != null) localVarPathParams.Add("favoriteGroupType", this.Configuration.ApiClient.ParameterToString(favoriteGroupType)); // path parameter
            if (favoriteGroupName != null) localVarPathParams.Add("favoriteGroupName", this.Configuration.ApiClient.ParameterToString(favoriteGroupName)); // path parameter
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
                Exception exception = ExceptionFactory("ClearFavoriteGroup", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Error>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Error) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Error)));
        }

        /// <summary>
        /// Clear Favorite Group Clear ALL contents of a specific favorite group.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="favoriteGroupType">The type of group to fetch, must be a valid FavoriteType.</param>
        /// <param name="favoriteGroupName"></param>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of Error</returns>
        public async System.Threading.Tasks.Task<Error> ClearFavoriteGroupAsync (string favoriteGroupType, string favoriteGroupName, string userId, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<Error> localVarResponse = await ClearFavoriteGroupWithHttpInfoAsync(favoriteGroupType, favoriteGroupName, userId, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Clear Favorite Group Clear ALL contents of a specific favorite group.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="favoriteGroupType">The type of group to fetch, must be a valid FavoriteType.</param>
        /// <param name="favoriteGroupName"></param>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (Error)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Error>> ClearFavoriteGroupWithHttpInfoAsync (string favoriteGroupType, string favoriteGroupName, string userId, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'favoriteGroupType' is set
            if (favoriteGroupType == null)
                throw new ApiException(400, "Missing required parameter 'favoriteGroupType' when calling FavoritesApi->ClearFavoriteGroup");
            // verify the required parameter 'favoriteGroupName' is set
            if (favoriteGroupName == null)
                throw new ApiException(400, "Missing required parameter 'favoriteGroupName' when calling FavoritesApi->ClearFavoriteGroup");
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling FavoritesApi->ClearFavoriteGroup");

            var localVarPath = "/favorite/group/{favoriteGroupType}/{favoriteGroupName}/{userId}";
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

            if (favoriteGroupType != null) localVarPathParams.Add("favoriteGroupType", this.Configuration.ApiClient.ParameterToString(favoriteGroupType)); // path parameter
            if (favoriteGroupName != null) localVarPathParams.Add("favoriteGroupName", this.Configuration.ApiClient.ParameterToString(favoriteGroupName)); // path parameter
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
                Exception exception = ExceptionFactory("ClearFavoriteGroup", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Error>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Error) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Error)));
        }

        /// <summary>
        /// Show Favorite Return information about a specific Favorite.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="favoriteId"></param>
        /// <returns>Favorite</returns>
        public Favorite GetFavorite (string favoriteId)
        {
             ApiResponse<Favorite> localVarResponse = GetFavoriteWithHttpInfo(favoriteId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Show Favorite Return information about a specific Favorite.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="favoriteId"></param>
        /// <returns>ApiResponse of Favorite</returns>
        public ApiResponse<Favorite> GetFavoriteWithHttpInfo (string favoriteId)
        {
            // verify the required parameter 'favoriteId' is set
            if (favoriteId == null)
                throw new ApiException(400, "Missing required parameter 'favoriteId' when calling FavoritesApi->GetFavorite");

            var localVarPath = "/favorites/{favoriteId}";
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

            if (favoriteId != null) localVarPathParams.Add("favoriteId", this.Configuration.ApiClient.ParameterToString(favoriteId)); // path parameter

            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetFavorite", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Favorite>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Favorite) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Favorite)));
        }

        /// <summary>
        /// Show Favorite Return information about a specific Favorite.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="favoriteId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of Favorite</returns>
        public async System.Threading.Tasks.Task<Favorite> GetFavoriteAsync (string favoriteId, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<Favorite> localVarResponse = await GetFavoriteWithHttpInfoAsync(favoriteId, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Show Favorite Return information about a specific Favorite.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="favoriteId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (Favorite)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Favorite>> GetFavoriteWithHttpInfoAsync (string favoriteId, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'favoriteId' is set
            if (favoriteId == null)
                throw new ApiException(400, "Missing required parameter 'favoriteId' when calling FavoritesApi->GetFavorite");

            var localVarPath = "/favorites/{favoriteId}";
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

            if (favoriteId != null) localVarPathParams.Add("favoriteId", this.Configuration.ApiClient.ParameterToString(favoriteId)); // path parameter

            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetFavorite", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Favorite>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Favorite) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Favorite)));
        }

        /// <summary>
        /// Show Favorite Group Fetch information about a specific favorite group.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="favoriteGroupType">The type of group to fetch, must be a valid FavoriteType.</param>
        /// <param name="favoriteGroupName"></param>
        /// <param name="userId"></param>
        /// <returns>FavoriteGroup</returns>
        public FavoriteGroup GetFavoriteGroup (string favoriteGroupType, string favoriteGroupName, string userId)
        {
             ApiResponse<FavoriteGroup> localVarResponse = GetFavoriteGroupWithHttpInfo(favoriteGroupType, favoriteGroupName, userId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Show Favorite Group Fetch information about a specific favorite group.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="favoriteGroupType">The type of group to fetch, must be a valid FavoriteType.</param>
        /// <param name="favoriteGroupName"></param>
        /// <param name="userId"></param>
        /// <returns>ApiResponse of FavoriteGroup</returns>
        public ApiResponse<FavoriteGroup> GetFavoriteGroupWithHttpInfo (string favoriteGroupType, string favoriteGroupName, string userId)
        {
            // verify the required parameter 'favoriteGroupType' is set
            if (favoriteGroupType == null)
                throw new ApiException(400, "Missing required parameter 'favoriteGroupType' when calling FavoritesApi->GetFavoriteGroup");
            // verify the required parameter 'favoriteGroupName' is set
            if (favoriteGroupName == null)
                throw new ApiException(400, "Missing required parameter 'favoriteGroupName' when calling FavoritesApi->GetFavoriteGroup");
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling FavoritesApi->GetFavoriteGroup");

            var localVarPath = "/favorite/group/{favoriteGroupType}/{favoriteGroupName}/{userId}";
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

            if (favoriteGroupType != null) localVarPathParams.Add("favoriteGroupType", this.Configuration.ApiClient.ParameterToString(favoriteGroupType)); // path parameter
            if (favoriteGroupName != null) localVarPathParams.Add("favoriteGroupName", this.Configuration.ApiClient.ParameterToString(favoriteGroupName)); // path parameter
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
                Exception exception = ExceptionFactory("GetFavoriteGroup", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<FavoriteGroup>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (FavoriteGroup) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(FavoriteGroup)));
        }

        /// <summary>
        /// Show Favorite Group Fetch information about a specific favorite group.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="favoriteGroupType">The type of group to fetch, must be a valid FavoriteType.</param>
        /// <param name="favoriteGroupName"></param>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of FavoriteGroup</returns>
        public async System.Threading.Tasks.Task<FavoriteGroup> GetFavoriteGroupAsync (string favoriteGroupType, string favoriteGroupName, string userId, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<FavoriteGroup> localVarResponse = await GetFavoriteGroupWithHttpInfoAsync(favoriteGroupType, favoriteGroupName, userId, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Show Favorite Group Fetch information about a specific favorite group.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="favoriteGroupType">The type of group to fetch, must be a valid FavoriteType.</param>
        /// <param name="favoriteGroupName"></param>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (FavoriteGroup)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FavoriteGroup>> GetFavoriteGroupWithHttpInfoAsync (string favoriteGroupType, string favoriteGroupName, string userId, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'favoriteGroupType' is set
            if (favoriteGroupType == null)
                throw new ApiException(400, "Missing required parameter 'favoriteGroupType' when calling FavoritesApi->GetFavoriteGroup");
            // verify the required parameter 'favoriteGroupName' is set
            if (favoriteGroupName == null)
                throw new ApiException(400, "Missing required parameter 'favoriteGroupName' when calling FavoritesApi->GetFavoriteGroup");
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling FavoritesApi->GetFavoriteGroup");

            var localVarPath = "/favorite/group/{favoriteGroupType}/{favoriteGroupName}/{userId}";
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

            if (favoriteGroupType != null) localVarPathParams.Add("favoriteGroupType", this.Configuration.ApiClient.ParameterToString(favoriteGroupType)); // path parameter
            if (favoriteGroupName != null) localVarPathParams.Add("favoriteGroupName", this.Configuration.ApiClient.ParameterToString(favoriteGroupName)); // path parameter
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
                Exception exception = ExceptionFactory("GetFavoriteGroup", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<FavoriteGroup>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (FavoriteGroup) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(FavoriteGroup)));
        }

        /// <summary>
        /// List Favorite Groups Return a list of favorite groups owned by a user. Returns the same information as &#x60;getFavoriteGroups&#x60;.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="n">The number of objects to return. (optional, default to 60)</param>
        /// <param name="offset">A zero-based offset from the default object sorting from where search results start. (optional)</param>
        /// <param name="ownerId">The owner of whoms favorite groups to return. Must be a UserID. (optional)</param>
        /// <returns>List&lt;FavoriteGroup&gt;</returns>
        public List<FavoriteGroup> GetFavoriteGroups (int? n = default(int?), int? offset = default(int?), string ownerId = default(string))
        {
             ApiResponse<List<FavoriteGroup>> localVarResponse = GetFavoriteGroupsWithHttpInfo(n, offset, ownerId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List Favorite Groups Return a list of favorite groups owned by a user. Returns the same information as &#x60;getFavoriteGroups&#x60;.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="n">The number of objects to return. (optional, default to 60)</param>
        /// <param name="offset">A zero-based offset from the default object sorting from where search results start. (optional)</param>
        /// <param name="ownerId">The owner of whoms favorite groups to return. Must be a UserID. (optional)</param>
        /// <returns>ApiResponse of List&lt;FavoriteGroup&gt;</returns>
        public ApiResponse<List<FavoriteGroup>> GetFavoriteGroupsWithHttpInfo (int? n = default(int?), int? offset = default(int?), string ownerId = default(string))
        {

            var localVarPath = "/favorite/groups";
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

            if (n != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "n", n)); // query parameter
            if (offset != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "offset", offset)); // query parameter
            if (ownerId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "ownerId", ownerId)); // query parameter

            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetFavoriteGroups", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<FavoriteGroup>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<FavoriteGroup>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<FavoriteGroup>)));
        }

        /// <summary>
        /// List Favorite Groups Return a list of favorite groups owned by a user. Returns the same information as &#x60;getFavoriteGroups&#x60;.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="n">The number of objects to return. (optional, default to 60)</param>
        /// <param name="offset">A zero-based offset from the default object sorting from where search results start. (optional)</param>
        /// <param name="ownerId">The owner of whoms favorite groups to return. Must be a UserID. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of List&lt;FavoriteGroup&gt;</returns>
        public async System.Threading.Tasks.Task<List<FavoriteGroup>> GetFavoriteGroupsAsync (int? n = default(int?), int? offset = default(int?), string ownerId = default(string), CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<List<FavoriteGroup>> localVarResponse = await GetFavoriteGroupsWithHttpInfoAsync(n, offset, ownerId, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List Favorite Groups Return a list of favorite groups owned by a user. Returns the same information as &#x60;getFavoriteGroups&#x60;.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="n">The number of objects to return. (optional, default to 60)</param>
        /// <param name="offset">A zero-based offset from the default object sorting from where search results start. (optional)</param>
        /// <param name="ownerId">The owner of whoms favorite groups to return. Must be a UserID. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (List&lt;FavoriteGroup&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<FavoriteGroup>>> GetFavoriteGroupsWithHttpInfoAsync (int? n = default(int?), int? offset = default(int?), string ownerId = default(string), CancellationToken cancellationToken = default(CancellationToken))
        {

            var localVarPath = "/favorite/groups";
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

            if (n != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "n", n)); // query parameter
            if (offset != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "offset", offset)); // query parameter
            if (ownerId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "ownerId", ownerId)); // query parameter

            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetFavoriteGroups", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<FavoriteGroup>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<FavoriteGroup>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<FavoriteGroup>)));
        }

        /// <summary>
        /// List Favorites Returns a list of favorites.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="n">The number of objects to return. (optional, default to 60)</param>
        /// <param name="offset">A zero-based offset from the default object sorting from where search results start. (optional)</param>
        /// <param name="type">The type of favorites to return, FavoriteType. (optional)</param>
        /// <param name="tag">Tags to include (comma-separated). (optional)</param>
        /// <returns>List&lt;Favorite&gt;</returns>
        public List<Favorite> GetFavorites (int? n = default(int?), int? offset = default(int?), string type = default(string), string tag = default(string))
        {
             ApiResponse<List<Favorite>> localVarResponse = GetFavoritesWithHttpInfo(n, offset, type, tag);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List Favorites Returns a list of favorites.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="n">The number of objects to return. (optional, default to 60)</param>
        /// <param name="offset">A zero-based offset from the default object sorting from where search results start. (optional)</param>
        /// <param name="type">The type of favorites to return, FavoriteType. (optional)</param>
        /// <param name="tag">Tags to include (comma-separated). (optional)</param>
        /// <returns>ApiResponse of List&lt;Favorite&gt;</returns>
        public ApiResponse<List<Favorite>> GetFavoritesWithHttpInfo (int? n = default(int?), int? offset = default(int?), string type = default(string), string tag = default(string))
        {

            var localVarPath = "/favorites";
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

            if (n != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "n", n)); // query parameter
            if (offset != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "offset", offset)); // query parameter
            if (type != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "type", type)); // query parameter
            if (tag != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "tag", tag)); // query parameter

            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetFavorites", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<Favorite>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<Favorite>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Favorite>)));
        }

        /// <summary>
        /// List Favorites Returns a list of favorites.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="n">The number of objects to return. (optional, default to 60)</param>
        /// <param name="offset">A zero-based offset from the default object sorting from where search results start. (optional)</param>
        /// <param name="type">The type of favorites to return, FavoriteType. (optional)</param>
        /// <param name="tag">Tags to include (comma-separated). (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of List&lt;Favorite&gt;</returns>
        public async System.Threading.Tasks.Task<List<Favorite>> GetFavoritesAsync (int? n = default(int?), int? offset = default(int?), string type = default(string), string tag = default(string), CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<List<Favorite>> localVarResponse = await GetFavoritesWithHttpInfoAsync(n, offset, type, tag, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List Favorites Returns a list of favorites.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="n">The number of objects to return. (optional, default to 60)</param>
        /// <param name="offset">A zero-based offset from the default object sorting from where search results start. (optional)</param>
        /// <param name="type">The type of favorites to return, FavoriteType. (optional)</param>
        /// <param name="tag">Tags to include (comma-separated). (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (List&lt;Favorite&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Favorite>>> GetFavoritesWithHttpInfoAsync (int? n = default(int?), int? offset = default(int?), string type = default(string), string tag = default(string), CancellationToken cancellationToken = default(CancellationToken))
        {

            var localVarPath = "/favorites";
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

            if (n != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "n", n)); // query parameter
            if (offset != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "offset", offset)); // query parameter
            if (type != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "type", type)); // query parameter
            if (tag != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "tag", tag)); // query parameter

            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetFavorites", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<Favorite>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<Favorite>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Favorite>)));
        }

        /// <summary>
        /// Remove Favorite Remove a favorite from your favorites list.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="favoriteId"></param>
        /// <returns>Error</returns>
        public Error RemoveFavorite (string favoriteId)
        {
             ApiResponse<Error> localVarResponse = RemoveFavoriteWithHttpInfo(favoriteId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Remove Favorite Remove a favorite from your favorites list.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="favoriteId"></param>
        /// <returns>ApiResponse of Error</returns>
        public ApiResponse<Error> RemoveFavoriteWithHttpInfo (string favoriteId)
        {
            // verify the required parameter 'favoriteId' is set
            if (favoriteId == null)
                throw new ApiException(400, "Missing required parameter 'favoriteId' when calling FavoritesApi->RemoveFavorite");

            var localVarPath = "/favorites/{favoriteId}";
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

            if (favoriteId != null) localVarPathParams.Add("favoriteId", this.Configuration.ApiClient.ParameterToString(favoriteId)); // path parameter

            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("RemoveFavorite", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Error>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Error) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Error)));
        }

        /// <summary>
        /// Remove Favorite Remove a favorite from your favorites list.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="favoriteId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of Error</returns>
        public async System.Threading.Tasks.Task<Error> RemoveFavoriteAsync (string favoriteId, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<Error> localVarResponse = await RemoveFavoriteWithHttpInfoAsync(favoriteId, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Remove Favorite Remove a favorite from your favorites list.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="favoriteId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (Error)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Error>> RemoveFavoriteWithHttpInfoAsync (string favoriteId, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'favoriteId' is set
            if (favoriteId == null)
                throw new ApiException(400, "Missing required parameter 'favoriteId' when calling FavoritesApi->RemoveFavorite");

            var localVarPath = "/favorites/{favoriteId}";
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

            if (favoriteId != null) localVarPathParams.Add("favoriteId", this.Configuration.ApiClient.ParameterToString(favoriteId)); // path parameter

            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("RemoveFavorite", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Error>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Error) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Error)));
        }

        /// <summary>
        /// Update Favorite Group Update information about a specific favorite group.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="favoriteGroupType">The type of group to fetch, must be a valid FavoriteType.</param>
        /// <param name="favoriteGroupName"></param>
        /// <param name="userId"></param>
        /// <param name="inlineObject8"> (optional)</param>
        /// <returns></returns>
        public void UpdateFavoriteGroup (string favoriteGroupType, string favoriteGroupName, string userId, InlineObject8 inlineObject8 = default(InlineObject8))
        {
             UpdateFavoriteGroupWithHttpInfo(favoriteGroupType, favoriteGroupName, userId, inlineObject8);
        }

        /// <summary>
        /// Update Favorite Group Update information about a specific favorite group.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="favoriteGroupType">The type of group to fetch, must be a valid FavoriteType.</param>
        /// <param name="favoriteGroupName"></param>
        /// <param name="userId"></param>
        /// <param name="inlineObject8"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateFavoriteGroupWithHttpInfo (string favoriteGroupType, string favoriteGroupName, string userId, InlineObject8 inlineObject8 = default(InlineObject8))
        {
            // verify the required parameter 'favoriteGroupType' is set
            if (favoriteGroupType == null)
                throw new ApiException(400, "Missing required parameter 'favoriteGroupType' when calling FavoritesApi->UpdateFavoriteGroup");
            // verify the required parameter 'favoriteGroupName' is set
            if (favoriteGroupName == null)
                throw new ApiException(400, "Missing required parameter 'favoriteGroupName' when calling FavoritesApi->UpdateFavoriteGroup");
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling FavoritesApi->UpdateFavoriteGroup");

            var localVarPath = "/favorite/group/{favoriteGroupType}/{favoriteGroupName}/{userId}";
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
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (favoriteGroupType != null) localVarPathParams.Add("favoriteGroupType", this.Configuration.ApiClient.ParameterToString(favoriteGroupType)); // path parameter
            if (favoriteGroupName != null) localVarPathParams.Add("favoriteGroupName", this.Configuration.ApiClient.ParameterToString(favoriteGroupName)); // path parameter
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId)); // path parameter
            if (inlineObject8 != null && inlineObject8.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(inlineObject8); // http body (model) parameter
            }
            else
            {
                localVarPostBody = inlineObject8; // byte array
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
                Exception exception = ExceptionFactory("UpdateFavoriteGroup", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Update Favorite Group Update information about a specific favorite group.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="favoriteGroupType">The type of group to fetch, must be a valid FavoriteType.</param>
        /// <param name="favoriteGroupName"></param>
        /// <param name="userId"></param>
        /// <param name="inlineObject8"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateFavoriteGroupAsync (string favoriteGroupType, string favoriteGroupName, string userId, InlineObject8 inlineObject8 = default(InlineObject8), CancellationToken cancellationToken = default(CancellationToken))
        {
             await UpdateFavoriteGroupWithHttpInfoAsync(favoriteGroupType, favoriteGroupName, userId, inlineObject8, cancellationToken);

        }

        /// <summary>
        /// Update Favorite Group Update information about a specific favorite group.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="favoriteGroupType">The type of group to fetch, must be a valid FavoriteType.</param>
        /// <param name="favoriteGroupName"></param>
        /// <param name="userId"></param>
        /// <param name="inlineObject8"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateFavoriteGroupWithHttpInfoAsync (string favoriteGroupType, string favoriteGroupName, string userId, InlineObject8 inlineObject8 = default(InlineObject8), CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'favoriteGroupType' is set
            if (favoriteGroupType == null)
                throw new ApiException(400, "Missing required parameter 'favoriteGroupType' when calling FavoritesApi->UpdateFavoriteGroup");
            // verify the required parameter 'favoriteGroupName' is set
            if (favoriteGroupName == null)
                throw new ApiException(400, "Missing required parameter 'favoriteGroupName' when calling FavoritesApi->UpdateFavoriteGroup");
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling FavoritesApi->UpdateFavoriteGroup");

            var localVarPath = "/favorite/group/{favoriteGroupType}/{favoriteGroupName}/{userId}";
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
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (favoriteGroupType != null) localVarPathParams.Add("favoriteGroupType", this.Configuration.ApiClient.ParameterToString(favoriteGroupType)); // path parameter
            if (favoriteGroupName != null) localVarPathParams.Add("favoriteGroupName", this.Configuration.ApiClient.ParameterToString(favoriteGroupName)); // path parameter
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId)); // path parameter
            if (inlineObject8 != null && inlineObject8.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(inlineObject8); // http body (model) parameter
            }
            else
            {
                localVarPostBody = inlineObject8; // byte array
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
                Exception exception = ExceptionFactory("UpdateFavoriteGroup", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

    }
}
