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
    public interface IWorldsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Create World
        /// </summary>
        /// <remarks>
        /// Create a new world. This endpoint requires &#x60;assetUrl&#x60; to be a valid File object with &#x60;.vrcw&#x60; file extension, and &#x60;imageUrl&#x60; to be a valid File object with an image file extension.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inlineObject5"> (optional)</param>
        /// <returns>World</returns>
        World CreateWorld (InlineObject5 inlineObject5 = default(InlineObject5));

        /// <summary>
        /// Create World
        /// </summary>
        /// <remarks>
        /// Create a new world. This endpoint requires &#x60;assetUrl&#x60; to be a valid File object with &#x60;.vrcw&#x60; file extension, and &#x60;imageUrl&#x60; to be a valid File object with an image file extension.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inlineObject5"> (optional)</param>
        /// <returns>ApiResponse of World</returns>
        ApiResponse<World> CreateWorldWithHttpInfo (InlineObject5 inlineObject5 = default(InlineObject5));
        /// <summary>
        /// Delete World
        /// </summary>
        /// <remarks>
        /// Delete a world. Notice a world is never fully \&quot;deleted\&quot;, only its ReleaseStatus is set to \&quot;hidden\&quot; and the linked Files are deleted. The WorldID is permanently reserved.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worldId"></param>
        /// <returns></returns>
        void DeleteWorld (string worldId);

        /// <summary>
        /// Delete World
        /// </summary>
        /// <remarks>
        /// Delete a world. Notice a world is never fully \&quot;deleted\&quot;, only its ReleaseStatus is set to \&quot;hidden\&quot; and the linked Files are deleted. The WorldID is permanently reserved.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worldId"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteWorldWithHttpInfo (string worldId);
        /// <summary>
        /// List Active Worlds
        /// </summary>
        /// <remarks>
        /// Search and list currently Active worlds by query filters.
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
        /// <returns>List&lt;LimitedWorld&gt;</returns>
        List<LimitedWorld> GetActiveWorlds (string featured = default(string), string sort = default(string), int? n = default(int?), string order = default(string), int? offset = default(int?), string search = default(string), string tag = default(string), string notag = default(string), string releaseStatus = default(string), string maxUnityVersion = default(string), string minUnityVersion = default(string), string platform = default(string));

        /// <summary>
        /// List Active Worlds
        /// </summary>
        /// <remarks>
        /// Search and list currently Active worlds by query filters.
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
        /// <returns>ApiResponse of List&lt;LimitedWorld&gt;</returns>
        ApiResponse<List<LimitedWorld>> GetActiveWorldsWithHttpInfo (string featured = default(string), string sort = default(string), int? n = default(int?), string order = default(string), int? offset = default(int?), string search = default(string), string tag = default(string), string notag = default(string), string releaseStatus = default(string), string maxUnityVersion = default(string), string minUnityVersion = default(string), string platform = default(string));
        /// <summary>
        /// List Favorited Worlds
        /// </summary>
        /// <remarks>
        /// Search and list favorited worlds by query filters.
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
        /// <returns>List&lt;LimitedWorld&gt;</returns>
        List<LimitedWorld> GetFavoritedWorlds (string featured = default(string), string sort = default(string), int? n = default(int?), string order = default(string), int? offset = default(int?), string search = default(string), string tag = default(string), string notag = default(string), string releaseStatus = default(string), string maxUnityVersion = default(string), string minUnityVersion = default(string), string platform = default(string), string userId = default(string));

        /// <summary>
        /// List Favorited Worlds
        /// </summary>
        /// <remarks>
        /// Search and list favorited worlds by query filters.
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
        /// <returns>ApiResponse of List&lt;LimitedWorld&gt;</returns>
        ApiResponse<List<LimitedWorld>> GetFavoritedWorldsWithHttpInfo (string featured = default(string), string sort = default(string), int? n = default(int?), string order = default(string), int? offset = default(int?), string search = default(string), string tag = default(string), string notag = default(string), string releaseStatus = default(string), string maxUnityVersion = default(string), string minUnityVersion = default(string), string platform = default(string), string userId = default(string));
        /// <summary>
        /// List Recent Worlds
        /// </summary>
        /// <remarks>
        /// Search and list recently visited worlds by query filters.
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
        /// <returns>List&lt;LimitedWorld&gt;</returns>
        List<LimitedWorld> GetRecentWorlds (string featured = default(string), string sort = default(string), int? n = default(int?), string order = default(string), int? offset = default(int?), string search = default(string), string tag = default(string), string notag = default(string), string releaseStatus = default(string), string maxUnityVersion = default(string), string minUnityVersion = default(string), string platform = default(string), string userId = default(string));

        /// <summary>
        /// List Recent Worlds
        /// </summary>
        /// <remarks>
        /// Search and list recently visited worlds by query filters.
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
        /// <returns>ApiResponse of List&lt;LimitedWorld&gt;</returns>
        ApiResponse<List<LimitedWorld>> GetRecentWorldsWithHttpInfo (string featured = default(string), string sort = default(string), int? n = default(int?), string order = default(string), int? offset = default(int?), string search = default(string), string tag = default(string), string notag = default(string), string releaseStatus = default(string), string maxUnityVersion = default(string), string minUnityVersion = default(string), string platform = default(string), string userId = default(string));
        /// <summary>
        /// Get World by ID
        /// </summary>
        /// <remarks>
        /// Get information about a specific World.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worldId"></param>
        /// <returns>World</returns>
        World GetWorld (string worldId);

        /// <summary>
        /// Get World by ID
        /// </summary>
        /// <remarks>
        /// Get information about a specific World.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worldId"></param>
        /// <returns>ApiResponse of World</returns>
        ApiResponse<World> GetWorldWithHttpInfo (string worldId);
        /// <summary>
        /// Get World Instance
        /// </summary>
        /// <remarks>
        /// Returns a worlds instance.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worldId"></param>
        /// <param name="instanceId"></param>
        /// <returns>Instance</returns>
        Instance GetWorldInstance (string worldId, string instanceId);

        /// <summary>
        /// Get World Instance
        /// </summary>
        /// <remarks>
        /// Returns a worlds instance.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worldId"></param>
        /// <param name="instanceId"></param>
        /// <returns>ApiResponse of Instance</returns>
        ApiResponse<Instance> GetWorldInstanceWithHttpInfo (string worldId, string instanceId);
        /// <summary>
        /// Get World Metadata
        /// </summary>
        /// <remarks>
        /// Return a worlds custom metadata. This is currently believed to be unused. Metadata can be set with &#x60;updateWorld&#x60; and can be any arbitrary object.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worldId"></param>
        /// <returns>InlineResponse2006</returns>
        InlineResponse2006 GetWorldMetadata (string worldId);

        /// <summary>
        /// Get World Metadata
        /// </summary>
        /// <remarks>
        /// Return a worlds custom metadata. This is currently believed to be unused. Metadata can be set with &#x60;updateWorld&#x60; and can be any arbitrary object.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worldId"></param>
        /// <returns>ApiResponse of InlineResponse2006</returns>
        ApiResponse<InlineResponse2006> GetWorldMetadataWithHttpInfo (string worldId);
        /// <summary>
        /// Get World Publish Status
        /// </summary>
        /// <remarks>
        /// Returns a worlds publish status.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worldId"></param>
        /// <returns>InlineResponse2007</returns>
        InlineResponse2007 GetWorldPublishStatus (string worldId);

        /// <summary>
        /// Get World Publish Status
        /// </summary>
        /// <remarks>
        /// Returns a worlds publish status.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worldId"></param>
        /// <returns>ApiResponse of InlineResponse2007</returns>
        ApiResponse<InlineResponse2007> GetWorldPublishStatusWithHttpInfo (string worldId);
        /// <summary>
        /// Publish World
        /// </summary>
        /// <remarks>
        /// Publish a world. You can only publish one world per week.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worldId"></param>
        /// <returns></returns>
        void PublishWorld (string worldId);

        /// <summary>
        /// Publish World
        /// </summary>
        /// <remarks>
        /// Publish a world. You can only publish one world per week.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worldId"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PublishWorldWithHttpInfo (string worldId);
        /// <summary>
        /// Search All Worlds
        /// </summary>
        /// <remarks>
        /// Search and list any worlds by query filters.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="featured">Filters on featured results. (optional)</param>
        /// <param name="sort"> (optional, default to popularity)</param>
        /// <param name="user">Set to &#x60;me&#x60; for searching own worlds. (optional)</param>
        /// <param name="userId">Filter by author UserID (optional)</param>
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
        /// <returns>List&lt;LimitedWorld&gt;</returns>
        List<LimitedWorld> SearchWorlds (string featured = default(string), string sort = default(string), string user = default(string), string userId = default(string), int? n = default(int?), string order = default(string), int? offset = default(int?), string search = default(string), string tag = default(string), string notag = default(string), string releaseStatus = default(string), string maxUnityVersion = default(string), string minUnityVersion = default(string), string platform = default(string));

        /// <summary>
        /// Search All Worlds
        /// </summary>
        /// <remarks>
        /// Search and list any worlds by query filters.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="featured">Filters on featured results. (optional)</param>
        /// <param name="sort"> (optional, default to popularity)</param>
        /// <param name="user">Set to &#x60;me&#x60; for searching own worlds. (optional)</param>
        /// <param name="userId">Filter by author UserID (optional)</param>
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
        /// <returns>ApiResponse of List&lt;LimitedWorld&gt;</returns>
        ApiResponse<List<LimitedWorld>> SearchWorldsWithHttpInfo (string featured = default(string), string sort = default(string), string user = default(string), string userId = default(string), int? n = default(int?), string order = default(string), int? offset = default(int?), string search = default(string), string tag = default(string), string notag = default(string), string releaseStatus = default(string), string maxUnityVersion = default(string), string minUnityVersion = default(string), string platform = default(string));
        /// <summary>
        /// Unpublish World
        /// </summary>
        /// <remarks>
        /// Unpublish a world.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worldId"></param>
        /// <returns></returns>
        void UnpublishWorld (string worldId);

        /// <summary>
        /// Unpublish World
        /// </summary>
        /// <remarks>
        /// Unpublish a world.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worldId"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UnpublishWorldWithHttpInfo (string worldId);
        /// <summary>
        /// Update World
        /// </summary>
        /// <remarks>
        /// Update information about a specific World.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worldId"></param>
        /// <param name="inlineObject6"> (optional)</param>
        /// <returns>World</returns>
        World UpdateWorld (string worldId, InlineObject6 inlineObject6 = default(InlineObject6));

        /// <summary>
        /// Update World
        /// </summary>
        /// <remarks>
        /// Update information about a specific World.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worldId"></param>
        /// <param name="inlineObject6"> (optional)</param>
        /// <returns>ApiResponse of World</returns>
        ApiResponse<World> UpdateWorldWithHttpInfo (string worldId, InlineObject6 inlineObject6 = default(InlineObject6));
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Create World
        /// </summary>
        /// <remarks>
        /// Create a new world. This endpoint requires &#x60;assetUrl&#x60; to be a valid File object with &#x60;.vrcw&#x60; file extension, and &#x60;imageUrl&#x60; to be a valid File object with an image file extension.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inlineObject5"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of World</returns>
        System.Threading.Tasks.Task<World> CreateWorldAsync (InlineObject5 inlineObject5 = default(InlineObject5), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Create World
        /// </summary>
        /// <remarks>
        /// Create a new world. This endpoint requires &#x60;assetUrl&#x60; to be a valid File object with &#x60;.vrcw&#x60; file extension, and &#x60;imageUrl&#x60; to be a valid File object with an image file extension.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inlineObject5"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (World)</returns>
        System.Threading.Tasks.Task<ApiResponse<World>> CreateWorldWithHttpInfoAsync (InlineObject5 inlineObject5 = default(InlineObject5), CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete World
        /// </summary>
        /// <remarks>
        /// Delete a world. Notice a world is never fully \&quot;deleted\&quot;, only its ReleaseStatus is set to \&quot;hidden\&quot; and the linked Files are deleted. The WorldID is permanently reserved.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worldId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteWorldAsync (string worldId, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Delete World
        /// </summary>
        /// <remarks>
        /// Delete a world. Notice a world is never fully \&quot;deleted\&quot;, only its ReleaseStatus is set to \&quot;hidden\&quot; and the linked Files are deleted. The WorldID is permanently reserved.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worldId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteWorldWithHttpInfoAsync (string worldId, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// List Active Worlds
        /// </summary>
        /// <remarks>
        /// Search and list currently Active worlds by query filters.
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
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of List&lt;LimitedWorld&gt;</returns>
        System.Threading.Tasks.Task<List<LimitedWorld>> GetActiveWorldsAsync (string featured = default(string), string sort = default(string), int? n = default(int?), string order = default(string), int? offset = default(int?), string search = default(string), string tag = default(string), string notag = default(string), string releaseStatus = default(string), string maxUnityVersion = default(string), string minUnityVersion = default(string), string platform = default(string), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// List Active Worlds
        /// </summary>
        /// <remarks>
        /// Search and list currently Active worlds by query filters.
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
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (List&lt;LimitedWorld&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<LimitedWorld>>> GetActiveWorldsWithHttpInfoAsync (string featured = default(string), string sort = default(string), int? n = default(int?), string order = default(string), int? offset = default(int?), string search = default(string), string tag = default(string), string notag = default(string), string releaseStatus = default(string), string maxUnityVersion = default(string), string minUnityVersion = default(string), string platform = default(string), CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// List Favorited Worlds
        /// </summary>
        /// <remarks>
        /// Search and list favorited worlds by query filters.
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
        /// <returns>Task of List&lt;LimitedWorld&gt;</returns>
        System.Threading.Tasks.Task<List<LimitedWorld>> GetFavoritedWorldsAsync (string featured = default(string), string sort = default(string), int? n = default(int?), string order = default(string), int? offset = default(int?), string search = default(string), string tag = default(string), string notag = default(string), string releaseStatus = default(string), string maxUnityVersion = default(string), string minUnityVersion = default(string), string platform = default(string), string userId = default(string), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// List Favorited Worlds
        /// </summary>
        /// <remarks>
        /// Search and list favorited worlds by query filters.
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
        /// <returns>Task of ApiResponse (List&lt;LimitedWorld&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<LimitedWorld>>> GetFavoritedWorldsWithHttpInfoAsync (string featured = default(string), string sort = default(string), int? n = default(int?), string order = default(string), int? offset = default(int?), string search = default(string), string tag = default(string), string notag = default(string), string releaseStatus = default(string), string maxUnityVersion = default(string), string minUnityVersion = default(string), string platform = default(string), string userId = default(string), CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// List Recent Worlds
        /// </summary>
        /// <remarks>
        /// Search and list recently visited worlds by query filters.
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
        /// <returns>Task of List&lt;LimitedWorld&gt;</returns>
        System.Threading.Tasks.Task<List<LimitedWorld>> GetRecentWorldsAsync (string featured = default(string), string sort = default(string), int? n = default(int?), string order = default(string), int? offset = default(int?), string search = default(string), string tag = default(string), string notag = default(string), string releaseStatus = default(string), string maxUnityVersion = default(string), string minUnityVersion = default(string), string platform = default(string), string userId = default(string), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// List Recent Worlds
        /// </summary>
        /// <remarks>
        /// Search and list recently visited worlds by query filters.
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
        /// <returns>Task of ApiResponse (List&lt;LimitedWorld&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<LimitedWorld>>> GetRecentWorldsWithHttpInfoAsync (string featured = default(string), string sort = default(string), int? n = default(int?), string order = default(string), int? offset = default(int?), string search = default(string), string tag = default(string), string notag = default(string), string releaseStatus = default(string), string maxUnityVersion = default(string), string minUnityVersion = default(string), string platform = default(string), string userId = default(string), CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get World by ID
        /// </summary>
        /// <remarks>
        /// Get information about a specific World.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worldId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of World</returns>
        System.Threading.Tasks.Task<World> GetWorldAsync (string worldId, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get World by ID
        /// </summary>
        /// <remarks>
        /// Get information about a specific World.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worldId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (World)</returns>
        System.Threading.Tasks.Task<ApiResponse<World>> GetWorldWithHttpInfoAsync (string worldId, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get World Instance
        /// </summary>
        /// <remarks>
        /// Returns a worlds instance.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worldId"></param>
        /// <param name="instanceId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of Instance</returns>
        System.Threading.Tasks.Task<Instance> GetWorldInstanceAsync (string worldId, string instanceId, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get World Instance
        /// </summary>
        /// <remarks>
        /// Returns a worlds instance.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worldId"></param>
        /// <param name="instanceId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (Instance)</returns>
        System.Threading.Tasks.Task<ApiResponse<Instance>> GetWorldInstanceWithHttpInfoAsync (string worldId, string instanceId, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get World Metadata
        /// </summary>
        /// <remarks>
        /// Return a worlds custom metadata. This is currently believed to be unused. Metadata can be set with &#x60;updateWorld&#x60; and can be any arbitrary object.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worldId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of InlineResponse2006</returns>
        System.Threading.Tasks.Task<InlineResponse2006> GetWorldMetadataAsync (string worldId, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get World Metadata
        /// </summary>
        /// <remarks>
        /// Return a worlds custom metadata. This is currently believed to be unused. Metadata can be set with &#x60;updateWorld&#x60; and can be any arbitrary object.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worldId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (InlineResponse2006)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2006>> GetWorldMetadataWithHttpInfoAsync (string worldId, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get World Publish Status
        /// </summary>
        /// <remarks>
        /// Returns a worlds publish status.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worldId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of InlineResponse2007</returns>
        System.Threading.Tasks.Task<InlineResponse2007> GetWorldPublishStatusAsync (string worldId, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get World Publish Status
        /// </summary>
        /// <remarks>
        /// Returns a worlds publish status.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worldId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (InlineResponse2007)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2007>> GetWorldPublishStatusWithHttpInfoAsync (string worldId, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Publish World
        /// </summary>
        /// <remarks>
        /// Publish a world. You can only publish one world per week.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worldId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PublishWorldAsync (string worldId, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Publish World
        /// </summary>
        /// <remarks>
        /// Publish a world. You can only publish one world per week.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worldId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PublishWorldWithHttpInfoAsync (string worldId, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Search All Worlds
        /// </summary>
        /// <remarks>
        /// Search and list any worlds by query filters.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="featured">Filters on featured results. (optional)</param>
        /// <param name="sort"> (optional, default to popularity)</param>
        /// <param name="user">Set to &#x60;me&#x60; for searching own worlds. (optional)</param>
        /// <param name="userId">Filter by author UserID (optional)</param>
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
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of List&lt;LimitedWorld&gt;</returns>
        System.Threading.Tasks.Task<List<LimitedWorld>> SearchWorldsAsync (string featured = default(string), string sort = default(string), string user = default(string), string userId = default(string), int? n = default(int?), string order = default(string), int? offset = default(int?), string search = default(string), string tag = default(string), string notag = default(string), string releaseStatus = default(string), string maxUnityVersion = default(string), string minUnityVersion = default(string), string platform = default(string), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Search All Worlds
        /// </summary>
        /// <remarks>
        /// Search and list any worlds by query filters.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="featured">Filters on featured results. (optional)</param>
        /// <param name="sort"> (optional, default to popularity)</param>
        /// <param name="user">Set to &#x60;me&#x60; for searching own worlds. (optional)</param>
        /// <param name="userId">Filter by author UserID (optional)</param>
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
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (List&lt;LimitedWorld&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<LimitedWorld>>> SearchWorldsWithHttpInfoAsync (string featured = default(string), string sort = default(string), string user = default(string), string userId = default(string), int? n = default(int?), string order = default(string), int? offset = default(int?), string search = default(string), string tag = default(string), string notag = default(string), string releaseStatus = default(string), string maxUnityVersion = default(string), string minUnityVersion = default(string), string platform = default(string), CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Unpublish World
        /// </summary>
        /// <remarks>
        /// Unpublish a world.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worldId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UnpublishWorldAsync (string worldId, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Unpublish World
        /// </summary>
        /// <remarks>
        /// Unpublish a world.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worldId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UnpublishWorldWithHttpInfoAsync (string worldId, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Update World
        /// </summary>
        /// <remarks>
        /// Update information about a specific World.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worldId"></param>
        /// <param name="inlineObject6"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of World</returns>
        System.Threading.Tasks.Task<World> UpdateWorldAsync (string worldId, InlineObject6 inlineObject6 = default(InlineObject6), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Update World
        /// </summary>
        /// <remarks>
        /// Update information about a specific World.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worldId"></param>
        /// <param name="inlineObject6"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (World)</returns>
        System.Threading.Tasks.Task<ApiResponse<World>> UpdateWorldWithHttpInfoAsync (string worldId, InlineObject6 inlineObject6 = default(InlineObject6), CancellationToken cancellationToken = default(CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class WorldsApi : IWorldsApi
    {
        private io.github.vrchatapi.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="WorldsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public WorldsApi(String basePath)
        {
            this.Configuration = new io.github.vrchatapi.Client.Configuration { BasePath = basePath };

            ExceptionFactory = io.github.vrchatapi.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorldsApi"/> class
        /// </summary>
        /// <returns></returns>
        public WorldsApi()
        {
            this.Configuration = io.github.vrchatapi.Client.Configuration.Default;

            ExceptionFactory = io.github.vrchatapi.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorldsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public WorldsApi(io.github.vrchatapi.Client.Configuration configuration = null)
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
        /// Create World Create a new world. This endpoint requires &#x60;assetUrl&#x60; to be a valid File object with &#x60;.vrcw&#x60; file extension, and &#x60;imageUrl&#x60; to be a valid File object with an image file extension.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inlineObject5"> (optional)</param>
        /// <returns>World</returns>
        public World CreateWorld (InlineObject5 inlineObject5 = default(InlineObject5))
        {
             ApiResponse<World> localVarResponse = CreateWorldWithHttpInfo(inlineObject5);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create World Create a new world. This endpoint requires &#x60;assetUrl&#x60; to be a valid File object with &#x60;.vrcw&#x60; file extension, and &#x60;imageUrl&#x60; to be a valid File object with an image file extension.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inlineObject5"> (optional)</param>
        /// <returns>ApiResponse of World</returns>
        public ApiResponse<World> CreateWorldWithHttpInfo (InlineObject5 inlineObject5 = default(InlineObject5))
        {

            var localVarPath = "/worlds";
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

            if (inlineObject5 != null && inlineObject5.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(inlineObject5); // http body (model) parameter
            }
            else
            {
                localVarPostBody = inlineObject5; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateWorld", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<World>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (World) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(World)));
        }

        /// <summary>
        /// Create World Create a new world. This endpoint requires &#x60;assetUrl&#x60; to be a valid File object with &#x60;.vrcw&#x60; file extension, and &#x60;imageUrl&#x60; to be a valid File object with an image file extension.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inlineObject5"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of World</returns>
        public async System.Threading.Tasks.Task<World> CreateWorldAsync (InlineObject5 inlineObject5 = default(InlineObject5), CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<World> localVarResponse = await CreateWorldWithHttpInfoAsync(inlineObject5, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create World Create a new world. This endpoint requires &#x60;assetUrl&#x60; to be a valid File object with &#x60;.vrcw&#x60; file extension, and &#x60;imageUrl&#x60; to be a valid File object with an image file extension.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inlineObject5"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (World)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<World>> CreateWorldWithHttpInfoAsync (InlineObject5 inlineObject5 = default(InlineObject5), CancellationToken cancellationToken = default(CancellationToken))
        {

            var localVarPath = "/worlds";
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

            if (inlineObject5 != null && inlineObject5.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(inlineObject5); // http body (model) parameter
            }
            else
            {
                localVarPostBody = inlineObject5; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateWorld", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<World>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (World) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(World)));
        }

        /// <summary>
        /// Delete World Delete a world. Notice a world is never fully \&quot;deleted\&quot;, only its ReleaseStatus is set to \&quot;hidden\&quot; and the linked Files are deleted. The WorldID is permanently reserved.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worldId"></param>
        /// <returns></returns>
        public void DeleteWorld (string worldId)
        {
             DeleteWorldWithHttpInfo(worldId);
        }

        /// <summary>
        /// Delete World Delete a world. Notice a world is never fully \&quot;deleted\&quot;, only its ReleaseStatus is set to \&quot;hidden\&quot; and the linked Files are deleted. The WorldID is permanently reserved.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worldId"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteWorldWithHttpInfo (string worldId)
        {
            // verify the required parameter 'worldId' is set
            if (worldId == null)
                throw new ApiException(400, "Missing required parameter 'worldId' when calling WorldsApi->DeleteWorld");

            var localVarPath = "/worlds/{worldId}";
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

            if (worldId != null) localVarPathParams.Add("worldId", this.Configuration.ApiClient.ParameterToString(worldId)); // path parameter

            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteWorld", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Delete World Delete a world. Notice a world is never fully \&quot;deleted\&quot;, only its ReleaseStatus is set to \&quot;hidden\&quot; and the linked Files are deleted. The WorldID is permanently reserved.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worldId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteWorldAsync (string worldId, CancellationToken cancellationToken = default(CancellationToken))
        {
             await DeleteWorldWithHttpInfoAsync(worldId, cancellationToken);

        }

        /// <summary>
        /// Delete World Delete a world. Notice a world is never fully \&quot;deleted\&quot;, only its ReleaseStatus is set to \&quot;hidden\&quot; and the linked Files are deleted. The WorldID is permanently reserved.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worldId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteWorldWithHttpInfoAsync (string worldId, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'worldId' is set
            if (worldId == null)
                throw new ApiException(400, "Missing required parameter 'worldId' when calling WorldsApi->DeleteWorld");

            var localVarPath = "/worlds/{worldId}";
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

            if (worldId != null) localVarPathParams.Add("worldId", this.Configuration.ApiClient.ParameterToString(worldId)); // path parameter

            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteWorld", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// List Active Worlds Search and list currently Active worlds by query filters.
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
        /// <returns>List&lt;LimitedWorld&gt;</returns>
        public List<LimitedWorld> GetActiveWorlds (string featured = default(string), string sort = default(string), int? n = default(int?), string order = default(string), int? offset = default(int?), string search = default(string), string tag = default(string), string notag = default(string), string releaseStatus = default(string), string maxUnityVersion = default(string), string minUnityVersion = default(string), string platform = default(string))
        {
             ApiResponse<List<LimitedWorld>> localVarResponse = GetActiveWorldsWithHttpInfo(featured, sort, n, order, offset, search, tag, notag, releaseStatus, maxUnityVersion, minUnityVersion, platform);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List Active Worlds Search and list currently Active worlds by query filters.
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
        /// <returns>ApiResponse of List&lt;LimitedWorld&gt;</returns>
        public ApiResponse<List<LimitedWorld>> GetActiveWorldsWithHttpInfo (string featured = default(string), string sort = default(string), int? n = default(int?), string order = default(string), int? offset = default(int?), string search = default(string), string tag = default(string), string notag = default(string), string releaseStatus = default(string), string maxUnityVersion = default(string), string minUnityVersion = default(string), string platform = default(string))
        {

            var localVarPath = "/worlds/active";
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

            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetActiveWorlds", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<LimitedWorld>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<LimitedWorld>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<LimitedWorld>)));
        }

        /// <summary>
        /// List Active Worlds Search and list currently Active worlds by query filters.
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
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of List&lt;LimitedWorld&gt;</returns>
        public async System.Threading.Tasks.Task<List<LimitedWorld>> GetActiveWorldsAsync (string featured = default(string), string sort = default(string), int? n = default(int?), string order = default(string), int? offset = default(int?), string search = default(string), string tag = default(string), string notag = default(string), string releaseStatus = default(string), string maxUnityVersion = default(string), string minUnityVersion = default(string), string platform = default(string), CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<List<LimitedWorld>> localVarResponse = await GetActiveWorldsWithHttpInfoAsync(featured, sort, n, order, offset, search, tag, notag, releaseStatus, maxUnityVersion, minUnityVersion, platform, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List Active Worlds Search and list currently Active worlds by query filters.
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
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (List&lt;LimitedWorld&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<LimitedWorld>>> GetActiveWorldsWithHttpInfoAsync (string featured = default(string), string sort = default(string), int? n = default(int?), string order = default(string), int? offset = default(int?), string search = default(string), string tag = default(string), string notag = default(string), string releaseStatus = default(string), string maxUnityVersion = default(string), string minUnityVersion = default(string), string platform = default(string), CancellationToken cancellationToken = default(CancellationToken))
        {

            var localVarPath = "/worlds/active";
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

            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetActiveWorlds", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<LimitedWorld>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<LimitedWorld>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<LimitedWorld>)));
        }

        /// <summary>
        /// List Favorited Worlds Search and list favorited worlds by query filters.
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
        /// <returns>List&lt;LimitedWorld&gt;</returns>
        public List<LimitedWorld> GetFavoritedWorlds (string featured = default(string), string sort = default(string), int? n = default(int?), string order = default(string), int? offset = default(int?), string search = default(string), string tag = default(string), string notag = default(string), string releaseStatus = default(string), string maxUnityVersion = default(string), string minUnityVersion = default(string), string platform = default(string), string userId = default(string))
        {
             ApiResponse<List<LimitedWorld>> localVarResponse = GetFavoritedWorldsWithHttpInfo(featured, sort, n, order, offset, search, tag, notag, releaseStatus, maxUnityVersion, minUnityVersion, platform, userId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List Favorited Worlds Search and list favorited worlds by query filters.
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
        /// <returns>ApiResponse of List&lt;LimitedWorld&gt;</returns>
        public ApiResponse<List<LimitedWorld>> GetFavoritedWorldsWithHttpInfo (string featured = default(string), string sort = default(string), int? n = default(int?), string order = default(string), int? offset = default(int?), string search = default(string), string tag = default(string), string notag = default(string), string releaseStatus = default(string), string maxUnityVersion = default(string), string minUnityVersion = default(string), string platform = default(string), string userId = default(string))
        {

            var localVarPath = "/worlds/favorites";
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
                Exception exception = ExceptionFactory("GetFavoritedWorlds", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<LimitedWorld>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<LimitedWorld>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<LimitedWorld>)));
        }

        /// <summary>
        /// List Favorited Worlds Search and list favorited worlds by query filters.
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
        /// <returns>Task of List&lt;LimitedWorld&gt;</returns>
        public async System.Threading.Tasks.Task<List<LimitedWorld>> GetFavoritedWorldsAsync (string featured = default(string), string sort = default(string), int? n = default(int?), string order = default(string), int? offset = default(int?), string search = default(string), string tag = default(string), string notag = default(string), string releaseStatus = default(string), string maxUnityVersion = default(string), string minUnityVersion = default(string), string platform = default(string), string userId = default(string), CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<List<LimitedWorld>> localVarResponse = await GetFavoritedWorldsWithHttpInfoAsync(featured, sort, n, order, offset, search, tag, notag, releaseStatus, maxUnityVersion, minUnityVersion, platform, userId, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List Favorited Worlds Search and list favorited worlds by query filters.
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
        /// <returns>Task of ApiResponse (List&lt;LimitedWorld&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<LimitedWorld>>> GetFavoritedWorldsWithHttpInfoAsync (string featured = default(string), string sort = default(string), int? n = default(int?), string order = default(string), int? offset = default(int?), string search = default(string), string tag = default(string), string notag = default(string), string releaseStatus = default(string), string maxUnityVersion = default(string), string minUnityVersion = default(string), string platform = default(string), string userId = default(string), CancellationToken cancellationToken = default(CancellationToken))
        {

            var localVarPath = "/worlds/favorites";
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
                Exception exception = ExceptionFactory("GetFavoritedWorlds", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<LimitedWorld>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<LimitedWorld>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<LimitedWorld>)));
        }

        /// <summary>
        /// List Recent Worlds Search and list recently visited worlds by query filters.
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
        /// <returns>List&lt;LimitedWorld&gt;</returns>
        public List<LimitedWorld> GetRecentWorlds (string featured = default(string), string sort = default(string), int? n = default(int?), string order = default(string), int? offset = default(int?), string search = default(string), string tag = default(string), string notag = default(string), string releaseStatus = default(string), string maxUnityVersion = default(string), string minUnityVersion = default(string), string platform = default(string), string userId = default(string))
        {
             ApiResponse<List<LimitedWorld>> localVarResponse = GetRecentWorldsWithHttpInfo(featured, sort, n, order, offset, search, tag, notag, releaseStatus, maxUnityVersion, minUnityVersion, platform, userId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List Recent Worlds Search and list recently visited worlds by query filters.
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
        /// <returns>ApiResponse of List&lt;LimitedWorld&gt;</returns>
        public ApiResponse<List<LimitedWorld>> GetRecentWorldsWithHttpInfo (string featured = default(string), string sort = default(string), int? n = default(int?), string order = default(string), int? offset = default(int?), string search = default(string), string tag = default(string), string notag = default(string), string releaseStatus = default(string), string maxUnityVersion = default(string), string minUnityVersion = default(string), string platform = default(string), string userId = default(string))
        {

            var localVarPath = "/worlds/recent";
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
                Exception exception = ExceptionFactory("GetRecentWorlds", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<LimitedWorld>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<LimitedWorld>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<LimitedWorld>)));
        }

        /// <summary>
        /// List Recent Worlds Search and list recently visited worlds by query filters.
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
        /// <returns>Task of List&lt;LimitedWorld&gt;</returns>
        public async System.Threading.Tasks.Task<List<LimitedWorld>> GetRecentWorldsAsync (string featured = default(string), string sort = default(string), int? n = default(int?), string order = default(string), int? offset = default(int?), string search = default(string), string tag = default(string), string notag = default(string), string releaseStatus = default(string), string maxUnityVersion = default(string), string minUnityVersion = default(string), string platform = default(string), string userId = default(string), CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<List<LimitedWorld>> localVarResponse = await GetRecentWorldsWithHttpInfoAsync(featured, sort, n, order, offset, search, tag, notag, releaseStatus, maxUnityVersion, minUnityVersion, platform, userId, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List Recent Worlds Search and list recently visited worlds by query filters.
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
        /// <returns>Task of ApiResponse (List&lt;LimitedWorld&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<LimitedWorld>>> GetRecentWorldsWithHttpInfoAsync (string featured = default(string), string sort = default(string), int? n = default(int?), string order = default(string), int? offset = default(int?), string search = default(string), string tag = default(string), string notag = default(string), string releaseStatus = default(string), string maxUnityVersion = default(string), string minUnityVersion = default(string), string platform = default(string), string userId = default(string), CancellationToken cancellationToken = default(CancellationToken))
        {

            var localVarPath = "/worlds/recent";
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
                Exception exception = ExceptionFactory("GetRecentWorlds", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<LimitedWorld>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<LimitedWorld>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<LimitedWorld>)));
        }

        /// <summary>
        /// Get World by ID Get information about a specific World.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worldId"></param>
        /// <returns>World</returns>
        public World GetWorld (string worldId)
        {
             ApiResponse<World> localVarResponse = GetWorldWithHttpInfo(worldId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get World by ID Get information about a specific World.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worldId"></param>
        /// <returns>ApiResponse of World</returns>
        public ApiResponse<World> GetWorldWithHttpInfo (string worldId)
        {
            // verify the required parameter 'worldId' is set
            if (worldId == null)
                throw new ApiException(400, "Missing required parameter 'worldId' when calling WorldsApi->GetWorld");

            var localVarPath = "/worlds/{worldId}";
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

            if (worldId != null) localVarPathParams.Add("worldId", this.Configuration.ApiClient.ParameterToString(worldId)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetWorld", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<World>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (World) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(World)));
        }

        /// <summary>
        /// Get World by ID Get information about a specific World.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worldId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of World</returns>
        public async System.Threading.Tasks.Task<World> GetWorldAsync (string worldId, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<World> localVarResponse = await GetWorldWithHttpInfoAsync(worldId, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get World by ID Get information about a specific World.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worldId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (World)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<World>> GetWorldWithHttpInfoAsync (string worldId, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'worldId' is set
            if (worldId == null)
                throw new ApiException(400, "Missing required parameter 'worldId' when calling WorldsApi->GetWorld");

            var localVarPath = "/worlds/{worldId}";
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

            if (worldId != null) localVarPathParams.Add("worldId", this.Configuration.ApiClient.ParameterToString(worldId)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetWorld", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<World>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (World) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(World)));
        }

        /// <summary>
        /// Get World Instance Returns a worlds instance.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worldId"></param>
        /// <param name="instanceId"></param>
        /// <returns>Instance</returns>
        public Instance GetWorldInstance (string worldId, string instanceId)
        {
             ApiResponse<Instance> localVarResponse = GetWorldInstanceWithHttpInfo(worldId, instanceId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get World Instance Returns a worlds instance.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worldId"></param>
        /// <param name="instanceId"></param>
        /// <returns>ApiResponse of Instance</returns>
        public ApiResponse<Instance> GetWorldInstanceWithHttpInfo (string worldId, string instanceId)
        {
            // verify the required parameter 'worldId' is set
            if (worldId == null)
                throw new ApiException(400, "Missing required parameter 'worldId' when calling WorldsApi->GetWorldInstance");
            // verify the required parameter 'instanceId' is set
            if (instanceId == null)
                throw new ApiException(400, "Missing required parameter 'instanceId' when calling WorldsApi->GetWorldInstance");

            var localVarPath = "/worlds/{worldId}/{instanceId}";
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

            if (worldId != null) localVarPathParams.Add("worldId", this.Configuration.ApiClient.ParameterToString(worldId)); // path parameter
            if (instanceId != null) localVarPathParams.Add("instanceId", this.Configuration.ApiClient.ParameterToString(instanceId)); // path parameter

            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetWorldInstance", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Instance>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Instance) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Instance)));
        }

        /// <summary>
        /// Get World Instance Returns a worlds instance.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worldId"></param>
        /// <param name="instanceId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of Instance</returns>
        public async System.Threading.Tasks.Task<Instance> GetWorldInstanceAsync (string worldId, string instanceId, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<Instance> localVarResponse = await GetWorldInstanceWithHttpInfoAsync(worldId, instanceId, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get World Instance Returns a worlds instance.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worldId"></param>
        /// <param name="instanceId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (Instance)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Instance>> GetWorldInstanceWithHttpInfoAsync (string worldId, string instanceId, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'worldId' is set
            if (worldId == null)
                throw new ApiException(400, "Missing required parameter 'worldId' when calling WorldsApi->GetWorldInstance");
            // verify the required parameter 'instanceId' is set
            if (instanceId == null)
                throw new ApiException(400, "Missing required parameter 'instanceId' when calling WorldsApi->GetWorldInstance");

            var localVarPath = "/worlds/{worldId}/{instanceId}";
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

            if (worldId != null) localVarPathParams.Add("worldId", this.Configuration.ApiClient.ParameterToString(worldId)); // path parameter
            if (instanceId != null) localVarPathParams.Add("instanceId", this.Configuration.ApiClient.ParameterToString(instanceId)); // path parameter

            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetWorldInstance", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Instance>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Instance) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Instance)));
        }

        /// <summary>
        /// Get World Metadata Return a worlds custom metadata. This is currently believed to be unused. Metadata can be set with &#x60;updateWorld&#x60; and can be any arbitrary object.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worldId"></param>
        /// <returns>InlineResponse2006</returns>
        public InlineResponse2006 GetWorldMetadata (string worldId)
        {
             ApiResponse<InlineResponse2006> localVarResponse = GetWorldMetadataWithHttpInfo(worldId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get World Metadata Return a worlds custom metadata. This is currently believed to be unused. Metadata can be set with &#x60;updateWorld&#x60; and can be any arbitrary object.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worldId"></param>
        /// <returns>ApiResponse of InlineResponse2006</returns>
        public ApiResponse<InlineResponse2006> GetWorldMetadataWithHttpInfo (string worldId)
        {
            // verify the required parameter 'worldId' is set
            if (worldId == null)
                throw new ApiException(400, "Missing required parameter 'worldId' when calling WorldsApi->GetWorldMetadata");

            var localVarPath = "/worlds/{worldId}/metadata";
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

            if (worldId != null) localVarPathParams.Add("worldId", this.Configuration.ApiClient.ParameterToString(worldId)); // path parameter

            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetWorldMetadata", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2006>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (InlineResponse2006) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2006)));
        }

        /// <summary>
        /// Get World Metadata Return a worlds custom metadata. This is currently believed to be unused. Metadata can be set with &#x60;updateWorld&#x60; and can be any arbitrary object.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worldId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of InlineResponse2006</returns>
        public async System.Threading.Tasks.Task<InlineResponse2006> GetWorldMetadataAsync (string worldId, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<InlineResponse2006> localVarResponse = await GetWorldMetadataWithHttpInfoAsync(worldId, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get World Metadata Return a worlds custom metadata. This is currently believed to be unused. Metadata can be set with &#x60;updateWorld&#x60; and can be any arbitrary object.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worldId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (InlineResponse2006)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2006>> GetWorldMetadataWithHttpInfoAsync (string worldId, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'worldId' is set
            if (worldId == null)
                throw new ApiException(400, "Missing required parameter 'worldId' when calling WorldsApi->GetWorldMetadata");

            var localVarPath = "/worlds/{worldId}/metadata";
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

            if (worldId != null) localVarPathParams.Add("worldId", this.Configuration.ApiClient.ParameterToString(worldId)); // path parameter

            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetWorldMetadata", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2006>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (InlineResponse2006) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2006)));
        }

        /// <summary>
        /// Get World Publish Status Returns a worlds publish status.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worldId"></param>
        /// <returns>InlineResponse2007</returns>
        public InlineResponse2007 GetWorldPublishStatus (string worldId)
        {
             ApiResponse<InlineResponse2007> localVarResponse = GetWorldPublishStatusWithHttpInfo(worldId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get World Publish Status Returns a worlds publish status.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worldId"></param>
        /// <returns>ApiResponse of InlineResponse2007</returns>
        public ApiResponse<InlineResponse2007> GetWorldPublishStatusWithHttpInfo (string worldId)
        {
            // verify the required parameter 'worldId' is set
            if (worldId == null)
                throw new ApiException(400, "Missing required parameter 'worldId' when calling WorldsApi->GetWorldPublishStatus");

            var localVarPath = "/worlds/{worldId}/publish";
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

            if (worldId != null) localVarPathParams.Add("worldId", this.Configuration.ApiClient.ParameterToString(worldId)); // path parameter

            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetWorldPublishStatus", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2007>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (InlineResponse2007) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2007)));
        }

        /// <summary>
        /// Get World Publish Status Returns a worlds publish status.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worldId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of InlineResponse2007</returns>
        public async System.Threading.Tasks.Task<InlineResponse2007> GetWorldPublishStatusAsync (string worldId, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<InlineResponse2007> localVarResponse = await GetWorldPublishStatusWithHttpInfoAsync(worldId, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get World Publish Status Returns a worlds publish status.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worldId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (InlineResponse2007)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2007>> GetWorldPublishStatusWithHttpInfoAsync (string worldId, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'worldId' is set
            if (worldId == null)
                throw new ApiException(400, "Missing required parameter 'worldId' when calling WorldsApi->GetWorldPublishStatus");

            var localVarPath = "/worlds/{worldId}/publish";
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

            if (worldId != null) localVarPathParams.Add("worldId", this.Configuration.ApiClient.ParameterToString(worldId)); // path parameter

            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetWorldPublishStatus", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2007>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (InlineResponse2007) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2007)));
        }

        /// <summary>
        /// Publish World Publish a world. You can only publish one world per week.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worldId"></param>
        /// <returns></returns>
        public void PublishWorld (string worldId)
        {
             PublishWorldWithHttpInfo(worldId);
        }

        /// <summary>
        /// Publish World Publish a world. You can only publish one world per week.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worldId"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PublishWorldWithHttpInfo (string worldId)
        {
            // verify the required parameter 'worldId' is set
            if (worldId == null)
                throw new ApiException(400, "Missing required parameter 'worldId' when calling WorldsApi->PublishWorld");

            var localVarPath = "/worlds/{worldId}/publish";
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

            if (worldId != null) localVarPathParams.Add("worldId", this.Configuration.ApiClient.ParameterToString(worldId)); // path parameter

            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PublishWorld", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Publish World Publish a world. You can only publish one world per week.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worldId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PublishWorldAsync (string worldId, CancellationToken cancellationToken = default(CancellationToken))
        {
             await PublishWorldWithHttpInfoAsync(worldId, cancellationToken);

        }

        /// <summary>
        /// Publish World Publish a world. You can only publish one world per week.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worldId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PublishWorldWithHttpInfoAsync (string worldId, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'worldId' is set
            if (worldId == null)
                throw new ApiException(400, "Missing required parameter 'worldId' when calling WorldsApi->PublishWorld");

            var localVarPath = "/worlds/{worldId}/publish";
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

            if (worldId != null) localVarPathParams.Add("worldId", this.Configuration.ApiClient.ParameterToString(worldId)); // path parameter

            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PublishWorld", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Search All Worlds Search and list any worlds by query filters.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="featured">Filters on featured results. (optional)</param>
        /// <param name="sort"> (optional, default to popularity)</param>
        /// <param name="user">Set to &#x60;me&#x60; for searching own worlds. (optional)</param>
        /// <param name="userId">Filter by author UserID (optional)</param>
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
        /// <returns>List&lt;LimitedWorld&gt;</returns>
        public List<LimitedWorld> SearchWorlds (string featured = default(string), string sort = default(string), string user = default(string), string userId = default(string), int? n = default(int?), string order = default(string), int? offset = default(int?), string search = default(string), string tag = default(string), string notag = default(string), string releaseStatus = default(string), string maxUnityVersion = default(string), string minUnityVersion = default(string), string platform = default(string))
        {
             ApiResponse<List<LimitedWorld>> localVarResponse = SearchWorldsWithHttpInfo(featured, sort, user, userId, n, order, offset, search, tag, notag, releaseStatus, maxUnityVersion, minUnityVersion, platform);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search All Worlds Search and list any worlds by query filters.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="featured">Filters on featured results. (optional)</param>
        /// <param name="sort"> (optional, default to popularity)</param>
        /// <param name="user">Set to &#x60;me&#x60; for searching own worlds. (optional)</param>
        /// <param name="userId">Filter by author UserID (optional)</param>
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
        /// <returns>ApiResponse of List&lt;LimitedWorld&gt;</returns>
        public ApiResponse<List<LimitedWorld>> SearchWorldsWithHttpInfo (string featured = default(string), string sort = default(string), string user = default(string), string userId = default(string), int? n = default(int?), string order = default(string), int? offset = default(int?), string search = default(string), string tag = default(string), string notag = default(string), string releaseStatus = default(string), string maxUnityVersion = default(string), string minUnityVersion = default(string), string platform = default(string))
        {

            var localVarPath = "/worlds";
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
            if (search != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "search", search)); // query parameter
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
                Exception exception = ExceptionFactory("SearchWorlds", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<LimitedWorld>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<LimitedWorld>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<LimitedWorld>)));
        }

        /// <summary>
        /// Search All Worlds Search and list any worlds by query filters.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="featured">Filters on featured results. (optional)</param>
        /// <param name="sort"> (optional, default to popularity)</param>
        /// <param name="user">Set to &#x60;me&#x60; for searching own worlds. (optional)</param>
        /// <param name="userId">Filter by author UserID (optional)</param>
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
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of List&lt;LimitedWorld&gt;</returns>
        public async System.Threading.Tasks.Task<List<LimitedWorld>> SearchWorldsAsync (string featured = default(string), string sort = default(string), string user = default(string), string userId = default(string), int? n = default(int?), string order = default(string), int? offset = default(int?), string search = default(string), string tag = default(string), string notag = default(string), string releaseStatus = default(string), string maxUnityVersion = default(string), string minUnityVersion = default(string), string platform = default(string), CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<List<LimitedWorld>> localVarResponse = await SearchWorldsWithHttpInfoAsync(featured, sort, user, userId, n, order, offset, search, tag, notag, releaseStatus, maxUnityVersion, minUnityVersion, platform, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search All Worlds Search and list any worlds by query filters.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="featured">Filters on featured results. (optional)</param>
        /// <param name="sort"> (optional, default to popularity)</param>
        /// <param name="user">Set to &#x60;me&#x60; for searching own worlds. (optional)</param>
        /// <param name="userId">Filter by author UserID (optional)</param>
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
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (List&lt;LimitedWorld&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<LimitedWorld>>> SearchWorldsWithHttpInfoAsync (string featured = default(string), string sort = default(string), string user = default(string), string userId = default(string), int? n = default(int?), string order = default(string), int? offset = default(int?), string search = default(string), string tag = default(string), string notag = default(string), string releaseStatus = default(string), string maxUnityVersion = default(string), string minUnityVersion = default(string), string platform = default(string), CancellationToken cancellationToken = default(CancellationToken))
        {

            var localVarPath = "/worlds";
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
            if (search != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "search", search)); // query parameter
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
                Exception exception = ExceptionFactory("SearchWorlds", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<LimitedWorld>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<LimitedWorld>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<LimitedWorld>)));
        }

        /// <summary>
        /// Unpublish World Unpublish a world.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worldId"></param>
        /// <returns></returns>
        public void UnpublishWorld (string worldId)
        {
             UnpublishWorldWithHttpInfo(worldId);
        }

        /// <summary>
        /// Unpublish World Unpublish a world.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worldId"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UnpublishWorldWithHttpInfo (string worldId)
        {
            // verify the required parameter 'worldId' is set
            if (worldId == null)
                throw new ApiException(400, "Missing required parameter 'worldId' when calling WorldsApi->UnpublishWorld");

            var localVarPath = "/worlds/{worldId}/publish";
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

            if (worldId != null) localVarPathParams.Add("worldId", this.Configuration.ApiClient.ParameterToString(worldId)); // path parameter

            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UnpublishWorld", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Unpublish World Unpublish a world.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worldId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UnpublishWorldAsync (string worldId, CancellationToken cancellationToken = default(CancellationToken))
        {
             await UnpublishWorldWithHttpInfoAsync(worldId, cancellationToken);

        }

        /// <summary>
        /// Unpublish World Unpublish a world.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worldId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UnpublishWorldWithHttpInfoAsync (string worldId, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'worldId' is set
            if (worldId == null)
                throw new ApiException(400, "Missing required parameter 'worldId' when calling WorldsApi->UnpublishWorld");

            var localVarPath = "/worlds/{worldId}/publish";
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

            if (worldId != null) localVarPathParams.Add("worldId", this.Configuration.ApiClient.ParameterToString(worldId)); // path parameter

            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UnpublishWorld", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Update World Update information about a specific World.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worldId"></param>
        /// <param name="inlineObject6"> (optional)</param>
        /// <returns>World</returns>
        public World UpdateWorld (string worldId, InlineObject6 inlineObject6 = default(InlineObject6))
        {
             ApiResponse<World> localVarResponse = UpdateWorldWithHttpInfo(worldId, inlineObject6);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update World Update information about a specific World.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worldId"></param>
        /// <param name="inlineObject6"> (optional)</param>
        /// <returns>ApiResponse of World</returns>
        public ApiResponse<World> UpdateWorldWithHttpInfo (string worldId, InlineObject6 inlineObject6 = default(InlineObject6))
        {
            // verify the required parameter 'worldId' is set
            if (worldId == null)
                throw new ApiException(400, "Missing required parameter 'worldId' when calling WorldsApi->UpdateWorld");

            var localVarPath = "/worlds/{worldId}";
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

            if (worldId != null) localVarPathParams.Add("worldId", this.Configuration.ApiClient.ParameterToString(worldId)); // path parameter
            if (inlineObject6 != null && inlineObject6.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(inlineObject6); // http body (model) parameter
            }
            else
            {
                localVarPostBody = inlineObject6; // byte array
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
                Exception exception = ExceptionFactory("UpdateWorld", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<World>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (World) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(World)));
        }

        /// <summary>
        /// Update World Update information about a specific World.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worldId"></param>
        /// <param name="inlineObject6"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of World</returns>
        public async System.Threading.Tasks.Task<World> UpdateWorldAsync (string worldId, InlineObject6 inlineObject6 = default(InlineObject6), CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<World> localVarResponse = await UpdateWorldWithHttpInfoAsync(worldId, inlineObject6, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update World Update information about a specific World.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worldId"></param>
        /// <param name="inlineObject6"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (World)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<World>> UpdateWorldWithHttpInfoAsync (string worldId, InlineObject6 inlineObject6 = default(InlineObject6), CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'worldId' is set
            if (worldId == null)
                throw new ApiException(400, "Missing required parameter 'worldId' when calling WorldsApi->UpdateWorld");

            var localVarPath = "/worlds/{worldId}";
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

            if (worldId != null) localVarPathParams.Add("worldId", this.Configuration.ApiClient.ParameterToString(worldId)); // path parameter
            if (inlineObject6 != null && inlineObject6.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(inlineObject6); // http body (model) parameter
            }
            else
            {
                localVarPostBody = inlineObject6; // byte array
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
                Exception exception = ExceptionFactory("UpdateWorld", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<World>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (World) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(World)));
        }

    }
}
