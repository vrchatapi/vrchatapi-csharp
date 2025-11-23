# VRChat.API.Api.WorldsApi

All URIs are relative to *https://api.vrchat.cloud/api/1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CheckUserPersistenceExists**](WorldsApi.md#checkuserpersistenceexists) | **GET** /users/{userId}/{worldId}/persist/exists | Check User Persistence Exists |
| [**CreateWorld**](WorldsApi.md#createworld) | **POST** /worlds | Create World |
| [**DeleteUserPersistence**](WorldsApi.md#deleteuserpersistence) | **DELETE** /users/{userId}/{worldId}/persist | Delete User Persistence |
| [**DeleteWorld**](WorldsApi.md#deleteworld) | **DELETE** /worlds/{worldId} | Delete World |
| [**GetActiveWorlds**](WorldsApi.md#getactiveworlds) | **GET** /worlds/active | List Active Worlds |
| [**GetFavoritedWorlds**](WorldsApi.md#getfavoritedworlds) | **GET** /worlds/favorites | List Favorited Worlds |
| [**GetRecentWorlds**](WorldsApi.md#getrecentworlds) | **GET** /worlds/recent | List Recent Worlds |
| [**GetWorld**](WorldsApi.md#getworld) | **GET** /worlds/{worldId} | Get World by ID |
| [**GetWorldInstance**](WorldsApi.md#getworldinstance) | **GET** /worlds/{worldId}/{instanceId} | Get World Instance |
| [**GetWorldMetadata**](WorldsApi.md#getworldmetadata) | **GET** /worlds/{worldId}/metadata | Get World Metadata |
| [**GetWorldPublishStatus**](WorldsApi.md#getworldpublishstatus) | **GET** /worlds/{worldId}/publish | Get World Publish Status |
| [**PublishWorld**](WorldsApi.md#publishworld) | **PUT** /worlds/{worldId}/publish | Publish World |
| [**SearchWorlds**](WorldsApi.md#searchworlds) | **GET** /worlds | Search All Worlds |
| [**UnpublishWorld**](WorldsApi.md#unpublishworld) | **DELETE** /worlds/{worldId}/publish | Unpublish World |
| [**UpdateWorld**](WorldsApi.md#updateworld) | **PUT** /worlds/{worldId} | Update World |

<a id="checkuserpersistenceexists"></a>
# **CheckUserPersistenceExists**
> void CheckUserPersistenceExists (string userId, string worldId)

Check User Persistence Exists

Checks whether the user has persistence data for a given world

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class CheckUserPersistenceExistsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vrchat.cloud/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new WorldsApi(httpClient, config, httpClientHandler);
            var userId = "userId_example";  // string | Must be a valid user ID.
            var worldId = "worldId_example";  // string | Must be a valid world ID.

            try
            {
                // Check User Persistence Exists
                apiInstance.CheckUserPersistenceExists(userId, worldId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsApi.CheckUserPersistenceExists: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CheckUserPersistenceExistsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Check User Persistence Exists
    apiInstance.CheckUserPersistenceExistsWithHttpInfo(userId, worldId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorldsApi.CheckUserPersistenceExistsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **string** | Must be a valid user ID. |  |
| **worldId** | **string** | Must be a valid world ID. |  |

### Return type

void (empty response body)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The user has persistence data for the given world. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |
| **404** | The user does not have persistence data for the given world. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createworld"></a>
# **CreateWorld**
> World CreateWorld (CreateWorldRequest? createWorldRequest = null)

Create World

Create a new world. This endpoint requires `assetUrl` to be a valid File object with `.vrcw` file extension, and `imageUrl` to be a valid File object with an image file extension.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class CreateWorldExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vrchat.cloud/api/1";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new WorldsApi(httpClient, config, httpClientHandler);
            var createWorldRequest = new CreateWorldRequest?(); // CreateWorldRequest? |  (optional) 

            try
            {
                // Create World
                World result = apiInstance.CreateWorld(createWorldRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsApi.CreateWorld: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateWorldWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create World
    ApiResponse<World> response = apiInstance.CreateWorldWithHttpInfo(createWorldRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorldsApi.CreateWorldWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createWorldRequest** | [**CreateWorldRequest?**](CreateWorldRequest?.md) |  | [optional]  |

### Return type

[**World**](World.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a single World object. |  -  |
| **400** | Error response when trying create a world without having the neccesary Trust rank yet. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteuserpersistence"></a>
# **DeleteUserPersistence**
> void DeleteUserPersistence (string userId, string worldId)

Delete User Persistence

Deletes the user's persistence data for a given world

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class DeleteUserPersistenceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vrchat.cloud/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new WorldsApi(httpClient, config, httpClientHandler);
            var userId = "userId_example";  // string | Must be a valid user ID.
            var worldId = "worldId_example";  // string | Must be a valid world ID.

            try
            {
                // Delete User Persistence
                apiInstance.DeleteUserPersistence(userId, worldId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsApi.DeleteUserPersistence: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteUserPersistenceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete User Persistence
    apiInstance.DeleteUserPersistenceWithHttpInfo(userId, worldId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorldsApi.DeleteUserPersistenceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **string** | Must be a valid user ID. |  |
| **worldId** | **string** | Must be a valid world ID. |  |

### Return type

void (empty response body)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The user&#39;s persistence data for the given world is deleted. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |
| **404** | The user does not have persistence data for the given world. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteworld"></a>
# **DeleteWorld**
> void DeleteWorld (string worldId)

Delete World

Delete a world. Notice a world is never fully \"deleted\", only its ReleaseStatus is set to \"hidden\" and the linked Files are deleted. The WorldID is permanently reserved.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class DeleteWorldExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vrchat.cloud/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new WorldsApi(httpClient, config, httpClientHandler);
            var worldId = "worldId_example";  // string | Must be a valid world ID.

            try
            {
                // Delete World
                apiInstance.DeleteWorld(worldId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsApi.DeleteWorld: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteWorldWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete World
    apiInstance.DeleteWorldWithHttpInfo(worldId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorldsApi.DeleteWorldWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **worldId** | **string** | Must be a valid world ID. |  |

### Return type

void (empty response body)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Error response due to missing auth cookie. |  -  |
| **404** | Error response when trying to show information about a non-existent world. Sometimes returns with &#x60;model &lt;worldId&gt; not found&#x60; instead of &#x60;World &lt;worldId not found&#x60;. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getactiveworlds"></a>
# **GetActiveWorlds**
> List&lt;LimitedWorld&gt; GetActiveWorlds (bool? featured = null, SortOption? sort = null, int? n = null, OrderOption? order = null, int? offset = null, string? search = null, string? tag = null, string? notag = null, ReleaseStatus? releaseStatus = null, string? maxUnityVersion = null, string? minUnityVersion = null, string? platform = null, string? noplatform = null)

List Active Worlds

Search and list currently Active worlds by query filters.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class GetActiveWorldsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vrchat.cloud/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new WorldsApi(httpClient, config, httpClientHandler);
            var featured = true;  // bool? | Filters on featured results. (optional) 
            var sort = new SortOption?(); // SortOption? | The sort order of the results. (optional) 
            var n = 60;  // int? | The number of objects to return. (optional)  (default to 60)
            var order = new OrderOption?(); // OrderOption? | Result ordering (optional) 
            var offset = 56;  // int? | A zero-based offset from the default object sorting from where search results start. (optional) 
            var search = "search_example";  // string? | Filters by world name. (optional) 
            var tag = "tag_example";  // string? | Tags to include (comma-separated). Any of the tags needs to be present. (optional) 
            var notag = "notag_example";  // string? | Tags to exclude (comma-separated). (optional) 
            var releaseStatus = new ReleaseStatus?(); // ReleaseStatus? | Filter by ReleaseStatus. (optional) 
            var maxUnityVersion = "maxUnityVersion_example";  // string? | The maximum Unity version supported by the asset. (optional) 
            var minUnityVersion = "minUnityVersion_example";  // string? | The minimum Unity version supported by the asset. (optional) 
            var platform = "platform_example";  // string? | The platform the asset supports. (optional) 
            var noplatform = "noplatform_example";  // string? | The platform the asset does not support. (optional) 

            try
            {
                // List Active Worlds
                List<LimitedWorld> result = apiInstance.GetActiveWorlds(featured, sort, n, order, offset, search, tag, notag, releaseStatus, maxUnityVersion, minUnityVersion, platform, noplatform);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsApi.GetActiveWorlds: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetActiveWorldsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Active Worlds
    ApiResponse<List<LimitedWorld>> response = apiInstance.GetActiveWorldsWithHttpInfo(featured, sort, n, order, offset, search, tag, notag, releaseStatus, maxUnityVersion, minUnityVersion, platform, noplatform);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorldsApi.GetActiveWorldsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **featured** | **bool?** | Filters on featured results. | [optional]  |
| **sort** | [**SortOption?**](SortOption?.md) | The sort order of the results. | [optional]  |
| **n** | **int?** | The number of objects to return. | [optional] [default to 60] |
| **order** | [**OrderOption?**](OrderOption?.md) | Result ordering | [optional]  |
| **offset** | **int?** | A zero-based offset from the default object sorting from where search results start. | [optional]  |
| **search** | **string?** | Filters by world name. | [optional]  |
| **tag** | **string?** | Tags to include (comma-separated). Any of the tags needs to be present. | [optional]  |
| **notag** | **string?** | Tags to exclude (comma-separated). | [optional]  |
| **releaseStatus** | [**ReleaseStatus?**](ReleaseStatus?.md) | Filter by ReleaseStatus. | [optional]  |
| **maxUnityVersion** | **string?** | The maximum Unity version supported by the asset. | [optional]  |
| **minUnityVersion** | **string?** | The minimum Unity version supported by the asset. | [optional]  |
| **platform** | **string?** | The platform the asset supports. | [optional]  |
| **noplatform** | **string?** | The platform the asset does not support. | [optional]  |

### Return type

[**List&lt;LimitedWorld&gt;**](LimitedWorld.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a list of LimitedWorld objects. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getfavoritedworlds"></a>
# **GetFavoritedWorlds**
> List&lt;FavoritedWorld&gt; GetFavoritedWorlds (bool? featured = null, SortOption? sort = null, int? n = null, OrderOption? order = null, int? offset = null, string? search = null, string? tag = null, string? notag = null, ReleaseStatus? releaseStatus = null, string? maxUnityVersion = null, string? minUnityVersion = null, string? platform = null, string? userId = null)

List Favorited Worlds

Search and list favorited worlds by query filters.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class GetFavoritedWorldsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vrchat.cloud/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new WorldsApi(httpClient, config, httpClientHandler);
            var featured = true;  // bool? | Filters on featured results. (optional) 
            var sort = new SortOption?(); // SortOption? | The sort order of the results. (optional) 
            var n = 60;  // int? | The number of objects to return. (optional)  (default to 60)
            var order = new OrderOption?(); // OrderOption? | Result ordering (optional) 
            var offset = 56;  // int? | A zero-based offset from the default object sorting from where search results start. (optional) 
            var search = "search_example";  // string? | Filters by world name. (optional) 
            var tag = "tag_example";  // string? | Tags to include (comma-separated). Any of the tags needs to be present. (optional) 
            var notag = "notag_example";  // string? | Tags to exclude (comma-separated). (optional) 
            var releaseStatus = new ReleaseStatus?(); // ReleaseStatus? | Filter by ReleaseStatus. (optional) 
            var maxUnityVersion = "maxUnityVersion_example";  // string? | The maximum Unity version supported by the asset. (optional) 
            var minUnityVersion = "minUnityVersion_example";  // string? | The minimum Unity version supported by the asset. (optional) 
            var platform = "platform_example";  // string? | The platform the asset supports. (optional) 
            var userId = "userId_example";  // string? | Target user to see information on, admin-only. (optional) 

            try
            {
                // List Favorited Worlds
                List<FavoritedWorld> result = apiInstance.GetFavoritedWorlds(featured, sort, n, order, offset, search, tag, notag, releaseStatus, maxUnityVersion, minUnityVersion, platform, userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsApi.GetFavoritedWorlds: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFavoritedWorldsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Favorited Worlds
    ApiResponse<List<FavoritedWorld>> response = apiInstance.GetFavoritedWorldsWithHttpInfo(featured, sort, n, order, offset, search, tag, notag, releaseStatus, maxUnityVersion, minUnityVersion, platform, userId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorldsApi.GetFavoritedWorldsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **featured** | **bool?** | Filters on featured results. | [optional]  |
| **sort** | [**SortOption?**](SortOption?.md) | The sort order of the results. | [optional]  |
| **n** | **int?** | The number of objects to return. | [optional] [default to 60] |
| **order** | [**OrderOption?**](OrderOption?.md) | Result ordering | [optional]  |
| **offset** | **int?** | A zero-based offset from the default object sorting from where search results start. | [optional]  |
| **search** | **string?** | Filters by world name. | [optional]  |
| **tag** | **string?** | Tags to include (comma-separated). Any of the tags needs to be present. | [optional]  |
| **notag** | **string?** | Tags to exclude (comma-separated). | [optional]  |
| **releaseStatus** | [**ReleaseStatus?**](ReleaseStatus?.md) | Filter by ReleaseStatus. | [optional]  |
| **maxUnityVersion** | **string?** | The maximum Unity version supported by the asset. | [optional]  |
| **minUnityVersion** | **string?** | The minimum Unity version supported by the asset. | [optional]  |
| **platform** | **string?** | The platform the asset supports. | [optional]  |
| **userId** | **string?** | Target user to see information on, admin-only. | [optional]  |

### Return type

[**List&lt;FavoritedWorld&gt;**](FavoritedWorld.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a list of FavoritedWorld objects. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |
| **403** | Error response when trying to see favourited worlds of another user without sufficient admin permissions. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getrecentworlds"></a>
# **GetRecentWorlds**
> List&lt;LimitedWorld&gt; GetRecentWorlds (bool? featured = null, SortOption? sort = null, int? n = null, OrderOption? order = null, int? offset = null, string? search = null, string? tag = null, string? notag = null, ReleaseStatus? releaseStatus = null, string? maxUnityVersion = null, string? minUnityVersion = null, string? platform = null, string? userId = null)

List Recent Worlds

Search and list recently visited worlds by query filters.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class GetRecentWorldsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vrchat.cloud/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new WorldsApi(httpClient, config, httpClientHandler);
            var featured = true;  // bool? | Filters on featured results. (optional) 
            var sort = new SortOption?(); // SortOption? | The sort order of the results. (optional) 
            var n = 60;  // int? | The number of objects to return. (optional)  (default to 60)
            var order = new OrderOption?(); // OrderOption? | Result ordering (optional) 
            var offset = 56;  // int? | A zero-based offset from the default object sorting from where search results start. (optional) 
            var search = "search_example";  // string? | Filters by world name. (optional) 
            var tag = "tag_example";  // string? | Tags to include (comma-separated). Any of the tags needs to be present. (optional) 
            var notag = "notag_example";  // string? | Tags to exclude (comma-separated). (optional) 
            var releaseStatus = new ReleaseStatus?(); // ReleaseStatus? | Filter by ReleaseStatus. (optional) 
            var maxUnityVersion = "maxUnityVersion_example";  // string? | The maximum Unity version supported by the asset. (optional) 
            var minUnityVersion = "minUnityVersion_example";  // string? | The minimum Unity version supported by the asset. (optional) 
            var platform = "platform_example";  // string? | The platform the asset supports. (optional) 
            var userId = "userId_example";  // string? | Target user to see information on, admin-only. (optional) 

            try
            {
                // List Recent Worlds
                List<LimitedWorld> result = apiInstance.GetRecentWorlds(featured, sort, n, order, offset, search, tag, notag, releaseStatus, maxUnityVersion, minUnityVersion, platform, userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsApi.GetRecentWorlds: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRecentWorldsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Recent Worlds
    ApiResponse<List<LimitedWorld>> response = apiInstance.GetRecentWorldsWithHttpInfo(featured, sort, n, order, offset, search, tag, notag, releaseStatus, maxUnityVersion, minUnityVersion, platform, userId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorldsApi.GetRecentWorldsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **featured** | **bool?** | Filters on featured results. | [optional]  |
| **sort** | [**SortOption?**](SortOption?.md) | The sort order of the results. | [optional]  |
| **n** | **int?** | The number of objects to return. | [optional] [default to 60] |
| **order** | [**OrderOption?**](OrderOption?.md) | Result ordering | [optional]  |
| **offset** | **int?** | A zero-based offset from the default object sorting from where search results start. | [optional]  |
| **search** | **string?** | Filters by world name. | [optional]  |
| **tag** | **string?** | Tags to include (comma-separated). Any of the tags needs to be present. | [optional]  |
| **notag** | **string?** | Tags to exclude (comma-separated). | [optional]  |
| **releaseStatus** | [**ReleaseStatus?**](ReleaseStatus?.md) | Filter by ReleaseStatus. | [optional]  |
| **maxUnityVersion** | **string?** | The maximum Unity version supported by the asset. | [optional]  |
| **minUnityVersion** | **string?** | The minimum Unity version supported by the asset. | [optional]  |
| **platform** | **string?** | The platform the asset supports. | [optional]  |
| **userId** | **string?** | Target user to see information on, admin-only. | [optional]  |

### Return type

[**List&lt;LimitedWorld&gt;**](LimitedWorld.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a list of LimitedWorld objects. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |
| **403** | Error response when trying to see recently visited worlds of another user without sufficient admin permissions. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getworld"></a>
# **GetWorld**
> World GetWorld (string worldId)

Get World by ID

Get information about a specific World. Works unauthenticated but when so will always return `0` for certain fields.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class GetWorldExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vrchat.cloud/api/1";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new WorldsApi(httpClient, config, httpClientHandler);
            var worldId = "worldId_example";  // string | Must be a valid world ID.

            try
            {
                // Get World by ID
                World result = apiInstance.GetWorld(worldId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsApi.GetWorld: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetWorldWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get World by ID
    ApiResponse<World> response = apiInstance.GetWorldWithHttpInfo(worldId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorldsApi.GetWorldWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **worldId** | **string** | Must be a valid world ID. |  |

### Return type

[**World**](World.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a single World object. |  -  |
| **404** | Error response when trying to show information about a non-existent world. Sometimes returns with &#x60;model &lt;worldId&gt; not found&#x60; instead of &#x60;World &lt;worldId not found&#x60;. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getworldinstance"></a>
# **GetWorldInstance**
> Instance GetWorldInstance (string worldId, string instanceId)

Get World Instance

Returns a worlds instance.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class GetWorldInstanceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vrchat.cloud/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new WorldsApi(httpClient, config, httpClientHandler);
            var worldId = "worldId_example";  // string | Must be a valid world ID.
            var instanceId = "instanceId_example";  // string | Must be a valid instance ID.

            try
            {
                // Get World Instance
                Instance result = apiInstance.GetWorldInstance(worldId, instanceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsApi.GetWorldInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetWorldInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get World Instance
    ApiResponse<Instance> response = apiInstance.GetWorldInstanceWithHttpInfo(worldId, instanceId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorldsApi.GetWorldInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **worldId** | **string** | Must be a valid world ID. |  |
| **instanceId** | **string** | Must be a valid instance ID. |  |

### Return type

[**Instance**](Instance.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a single Instance object. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getworldmetadata"></a>
# **GetWorldMetadata**
> WorldMetadata GetWorldMetadata (string worldId)

Get World Metadata

Return a worlds custom metadata. This is currently believed to be unused. Metadata can be set with `updateWorld` and can be any arbitrary object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class GetWorldMetadataExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vrchat.cloud/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new WorldsApi(httpClient, config, httpClientHandler);
            var worldId = "worldId_example";  // string | Must be a valid world ID.

            try
            {
                // Get World Metadata
                WorldMetadata result = apiInstance.GetWorldMetadata(worldId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsApi.GetWorldMetadata: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetWorldMetadataWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get World Metadata
    ApiResponse<WorldMetadata> response = apiInstance.GetWorldMetadataWithHttpInfo(worldId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorldsApi.GetWorldMetadataWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **worldId** | **string** | Must be a valid world ID. |  |

### Return type

[**WorldMetadata**](WorldMetadata.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Error response when trying to show information about a non-existent world. Sometimes returns with &#x60;model &lt;worldId&gt; not found&#x60; instead of &#x60;World &lt;worldId not found&#x60;. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getworldpublishstatus"></a>
# **GetWorldPublishStatus**
> WorldPublishStatus GetWorldPublishStatus (string worldId)

Get World Publish Status

Returns a worlds publish status.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class GetWorldPublishStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vrchat.cloud/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new WorldsApi(httpClient, config, httpClientHandler);
            var worldId = "worldId_example";  // string | Must be a valid world ID.

            try
            {
                // Get World Publish Status
                WorldPublishStatus result = apiInstance.GetWorldPublishStatus(worldId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsApi.GetWorldPublishStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetWorldPublishStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get World Publish Status
    ApiResponse<WorldPublishStatus> response = apiInstance.GetWorldPublishStatusWithHttpInfo(worldId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorldsApi.GetWorldPublishStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **worldId** | **string** | Must be a valid world ID. |  |

### Return type

[**WorldPublishStatus**](WorldPublishStatus.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a single WorldPublishStatus object. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |
| **404** | Error response when trying to show information about a non-existent world. Sometimes returns with &#x60;model &lt;worldId&gt; not found&#x60; instead of &#x60;World &lt;worldId not found&#x60;. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="publishworld"></a>
# **PublishWorld**
> void PublishWorld (string worldId)

Publish World

Publish a world. You can only publish one world per week.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class PublishWorldExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vrchat.cloud/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new WorldsApi(httpClient, config, httpClientHandler);
            var worldId = "worldId_example";  // string | Must be a valid world ID.

            try
            {
                // Publish World
                apiInstance.PublishWorld(worldId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsApi.PublishWorld: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PublishWorldWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Publish World
    apiInstance.PublishWorldWithHttpInfo(worldId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorldsApi.PublishWorldWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **worldId** | **string** | Must be a valid world ID. |  |

### Return type

void (empty response body)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | TODO |  -  |
| **401** | Error response due to missing auth cookie. |  -  |
| **404** | Error response when trying to show information about a non-existent world. Sometimes returns with &#x60;model &lt;worldId&gt; not found&#x60; instead of &#x60;World &lt;worldId not found&#x60;. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="searchworlds"></a>
# **SearchWorlds**
> List&lt;LimitedWorld&gt; SearchWorlds (bool? featured = null, SortOption? sort = null, string? user = null, string? userId = null, int? n = null, OrderOption? order = null, int? offset = null, string? search = null, string? tag = null, string? notag = null, ReleaseStatus? releaseStatus = null, string? maxUnityVersion = null, string? minUnityVersion = null, string? platform = null, string? noplatform = null, bool? fuzzy = null, bool? avatarSpecific = null)

Search All Worlds

Search and list any worlds by query filters.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class SearchWorldsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vrchat.cloud/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new WorldsApi(httpClient, config, httpClientHandler);
            var featured = true;  // bool? | Filters on featured results. (optional) 
            var sort = new SortOption?(); // SortOption? | The sort order of the results. (optional) 
            var user = "me";  // string? | Set to `me` for searching own worlds. (optional) 
            var userId = "userId_example";  // string? | Filter by UserID. (optional) 
            var n = 60;  // int? | The number of objects to return. (optional)  (default to 60)
            var order = new OrderOption?(); // OrderOption? | Result ordering (optional) 
            var offset = 56;  // int? | A zero-based offset from the default object sorting from where search results start. (optional) 
            var search = "search_example";  // string? | Filters by world name. (optional) 
            var tag = "tag_example";  // string? | Tags to include (comma-separated). Any of the tags needs to be present. (optional) 
            var notag = "notag_example";  // string? | Tags to exclude (comma-separated). (optional) 
            var releaseStatus = new ReleaseStatus?(); // ReleaseStatus? | Filter by ReleaseStatus. (optional) 
            var maxUnityVersion = "maxUnityVersion_example";  // string? | The maximum Unity version supported by the asset. (optional) 
            var minUnityVersion = "minUnityVersion_example";  // string? | The minimum Unity version supported by the asset. (optional) 
            var platform = "platform_example";  // string? | The platform the asset supports. (optional) 
            var noplatform = "noplatform_example";  // string? | The platform the asset does not support. (optional) 
            var fuzzy = true;  // bool? |  (optional) 
            var avatarSpecific = true;  // bool? | Only search for avatar worlds. (optional) 

            try
            {
                // Search All Worlds
                List<LimitedWorld> result = apiInstance.SearchWorlds(featured, sort, user, userId, n, order, offset, search, tag, notag, releaseStatus, maxUnityVersion, minUnityVersion, platform, noplatform, fuzzy, avatarSpecific);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsApi.SearchWorlds: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SearchWorldsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search All Worlds
    ApiResponse<List<LimitedWorld>> response = apiInstance.SearchWorldsWithHttpInfo(featured, sort, user, userId, n, order, offset, search, tag, notag, releaseStatus, maxUnityVersion, minUnityVersion, platform, noplatform, fuzzy, avatarSpecific);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorldsApi.SearchWorldsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **featured** | **bool?** | Filters on featured results. | [optional]  |
| **sort** | [**SortOption?**](SortOption?.md) | The sort order of the results. | [optional]  |
| **user** | **string?** | Set to &#x60;me&#x60; for searching own worlds. | [optional]  |
| **userId** | **string?** | Filter by UserID. | [optional]  |
| **n** | **int?** | The number of objects to return. | [optional] [default to 60] |
| **order** | [**OrderOption?**](OrderOption?.md) | Result ordering | [optional]  |
| **offset** | **int?** | A zero-based offset from the default object sorting from where search results start. | [optional]  |
| **search** | **string?** | Filters by world name. | [optional]  |
| **tag** | **string?** | Tags to include (comma-separated). Any of the tags needs to be present. | [optional]  |
| **notag** | **string?** | Tags to exclude (comma-separated). | [optional]  |
| **releaseStatus** | [**ReleaseStatus?**](ReleaseStatus?.md) | Filter by ReleaseStatus. | [optional]  |
| **maxUnityVersion** | **string?** | The maximum Unity version supported by the asset. | [optional]  |
| **minUnityVersion** | **string?** | The minimum Unity version supported by the asset. | [optional]  |
| **platform** | **string?** | The platform the asset supports. | [optional]  |
| **noplatform** | **string?** | The platform the asset does not support. | [optional]  |
| **fuzzy** | **bool?** |  | [optional]  |
| **avatarSpecific** | **bool?** | Only search for avatar worlds. | [optional]  |

### Return type

[**List&lt;LimitedWorld&gt;**](LimitedWorld.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a list of LimitedWorld objects. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="unpublishworld"></a>
# **UnpublishWorld**
> void UnpublishWorld (string worldId)

Unpublish World

Unpublish a world.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class UnpublishWorldExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vrchat.cloud/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new WorldsApi(httpClient, config, httpClientHandler);
            var worldId = "worldId_example";  // string | Must be a valid world ID.

            try
            {
                // Unpublish World
                apiInstance.UnpublishWorld(worldId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsApi.UnpublishWorld: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UnpublishWorldWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Unpublish World
    apiInstance.UnpublishWorldWithHttpInfo(worldId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorldsApi.UnpublishWorldWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **worldId** | **string** | Must be a valid world ID. |  |

### Return type

void (empty response body)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Error response due to missing auth cookie. |  -  |
| **404** | Error response when trying to show information about a non-existent world. Sometimes returns with &#x60;model &lt;worldId&gt; not found&#x60; instead of &#x60;World &lt;worldId not found&#x60;. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateworld"></a>
# **UpdateWorld**
> World UpdateWorld (string worldId, UpdateWorldRequest? updateWorldRequest = null)

Update World

Update information about a specific World.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class UpdateWorldExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vrchat.cloud/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new WorldsApi(httpClient, config, httpClientHandler);
            var worldId = "worldId_example";  // string | Must be a valid world ID.
            var updateWorldRequest = new UpdateWorldRequest?(); // UpdateWorldRequest? |  (optional) 

            try
            {
                // Update World
                World result = apiInstance.UpdateWorld(worldId, updateWorldRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsApi.UpdateWorld: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateWorldWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update World
    ApiResponse<World> response = apiInstance.UpdateWorldWithHttpInfo(worldId, updateWorldRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorldsApi.UpdateWorldWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **worldId** | **string** | Must be a valid world ID. |  |
| **updateWorldRequest** | [**UpdateWorldRequest?**](UpdateWorldRequest?.md) |  | [optional]  |

### Return type

[**World**](World.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a single World object. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |
| **404** | Error response when trying to show information about a non-existent world. Sometimes returns with &#x60;model &lt;worldId&gt; not found&#x60; instead of &#x60;World &lt;worldId not found&#x60;. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

