# VRChat.API.Api.AvatarsApi

All URIs are relative to *https://vrchat.com/api/1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateAvatar**](AvatarsApi.md#createavatar) | **POST** /avatars | Create Avatar |
| [**DeleteAvatar**](AvatarsApi.md#deleteavatar) | **DELETE** /avatars/{avatarId} | Delete Avatar |
| [**GetAvatar**](AvatarsApi.md#getavatar) | **GET** /avatars/{avatarId} | Get Avatar |
| [**GetFavoritedAvatars**](AvatarsApi.md#getfavoritedavatars) | **GET** /avatars/favorites | List Favorited Avatars |
| [**GetOwnAvatar**](AvatarsApi.md#getownavatar) | **GET** /users/{userId}/avatar | Get Own Avatar |
| [**SearchAvatars**](AvatarsApi.md#searchavatars) | **GET** /avatars | Search Avatars |
| [**SelectAvatar**](AvatarsApi.md#selectavatar) | **PUT** /avatars/{avatarId}/select | Select Avatar |
| [**SelectFallbackAvatar**](AvatarsApi.md#selectfallbackavatar) | **PUT** /avatars/{avatarId}/selectFallback | Select Fallback Avatar |
| [**UpdateAvatar**](AvatarsApi.md#updateavatar) | **PUT** /avatars/{avatarId} | Update Avatar |

<a name="createavatar"></a>
# **CreateAvatar**
> Avatar CreateAvatar (CreateAvatarRequest createAvatarRequest = null)

Create Avatar

Create an avatar. It's possible to optionally specify a ID if you want a custom one. Attempting to create an Avatar with an already claimed ID will result in a DB error.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class CreateAvatarExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrchat.com/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new AvatarsApi(config);
            var createAvatarRequest = new CreateAvatarRequest(); // CreateAvatarRequest |  (optional) 

            try
            {
                // Create Avatar
                Avatar result = apiInstance.CreateAvatar(createAvatarRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AvatarsApi.CreateAvatar: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateAvatarWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Avatar
    ApiResponse<Avatar> response = apiInstance.CreateAvatarWithHttpInfo(createAvatarRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AvatarsApi.CreateAvatarWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createAvatarRequest** | [**CreateAvatarRequest**](CreateAvatarRequest.md) |  | [optional]  |

### Return type

[**Avatar**](Avatar.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a single Avatar object. |  -  |
| **401** | Error response when set featured to true without being an admin. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteavatar"></a>
# **DeleteAvatar**
> Avatar DeleteAvatar (string avatarId)

Delete Avatar

Delete an avatar. Notice an avatar is never fully \"deleted\", only its ReleaseStatus is set to \"hidden\" and the linked Files are deleted. The AvatarID is permanently reserved.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class DeleteAvatarExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrchat.com/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new AvatarsApi(config);
            var avatarId = "avatarId_example";  // string | Must be a valid avatar ID.

            try
            {
                // Delete Avatar
                Avatar result = apiInstance.DeleteAvatar(avatarId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AvatarsApi.DeleteAvatar: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteAvatarWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Avatar
    ApiResponse<Avatar> response = apiInstance.DeleteAvatarWithHttpInfo(avatarId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AvatarsApi.DeleteAvatarWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **avatarId** | **string** | Must be a valid avatar ID. |  |

### Return type

[**Avatar**](Avatar.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a single Avatar object. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |
| **404** | Error response when trying to show information about a non-existent avatar. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getavatar"></a>
# **GetAvatar**
> Avatar GetAvatar (string avatarId)

Get Avatar

Get information about a specific Avatar.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class GetAvatarExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrchat.com/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new AvatarsApi(config);
            var avatarId = "avatarId_example";  // string | Must be a valid avatar ID.

            try
            {
                // Get Avatar
                Avatar result = apiInstance.GetAvatar(avatarId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AvatarsApi.GetAvatar: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAvatarWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Avatar
    ApiResponse<Avatar> response = apiInstance.GetAvatarWithHttpInfo(avatarId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AvatarsApi.GetAvatarWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **avatarId** | **string** | Must be a valid avatar ID. |  |

### Return type

[**Avatar**](Avatar.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a single Avatar object. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |
| **404** | Error response when trying to show information about a non-existent avatar. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfavoritedavatars"></a>
# **GetFavoritedAvatars**
> List&lt;Avatar&gt; GetFavoritedAvatars (bool? featured = null, SortOption? sort = null, int? n = null, OrderOption? order = null, int? offset = null, string search = null, string tag = null, string notag = null, ReleaseStatus? releaseStatus = null, string maxUnityVersion = null, string minUnityVersion = null, string platform = null, string userId = null)

List Favorited Avatars

Search and list favorited avatars by query filters.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class GetFavoritedAvatarsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrchat.com/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new AvatarsApi(config);
            var featured = true;  // bool? | Filters on featured results. (optional) 
            var sort = (SortOption) "popularity";  // SortOption? | The sort order of the results. (optional) 
            var n = 60;  // int? | The number of objects to return. (optional)  (default to 60)
            var order = (OrderOption) "ascending";  // OrderOption? | Result ordering (optional) 
            var offset = 56;  // int? | A zero-based offset from the default object sorting from where search results start. (optional) 
            var search = "search_example";  // string | Filters by world name. (optional) 
            var tag = "tag_example";  // string | Tags to include (comma-separated). Any of the tags needs to be present. (optional) 
            var notag = "notag_example";  // string | Tags to exclude (comma-separated). (optional) 
            var releaseStatus = (ReleaseStatus) "public";  // ReleaseStatus? | Filter by ReleaseStatus. (optional) 
            var maxUnityVersion = "maxUnityVersion_example";  // string | The maximum Unity version supported by the asset. (optional) 
            var minUnityVersion = "minUnityVersion_example";  // string | The minimum Unity version supported by the asset. (optional) 
            var platform = "platform_example";  // string | The platform the asset supports. (optional) 
            var userId = "userId_example";  // string | Target user to see information on, admin-only. (optional) 

            try
            {
                // List Favorited Avatars
                List<Avatar> result = apiInstance.GetFavoritedAvatars(featured, sort, n, order, offset, search, tag, notag, releaseStatus, maxUnityVersion, minUnityVersion, platform, userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AvatarsApi.GetFavoritedAvatars: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFavoritedAvatarsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Favorited Avatars
    ApiResponse<List<Avatar>> response = apiInstance.GetFavoritedAvatarsWithHttpInfo(featured, sort, n, order, offset, search, tag, notag, releaseStatus, maxUnityVersion, minUnityVersion, platform, userId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AvatarsApi.GetFavoritedAvatarsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **featured** | **bool?** | Filters on featured results. | [optional]  |
| **sort** | **SortOption?** | The sort order of the results. | [optional]  |
| **n** | **int?** | The number of objects to return. | [optional] [default to 60] |
| **order** | **OrderOption?** | Result ordering | [optional]  |
| **offset** | **int?** | A zero-based offset from the default object sorting from where search results start. | [optional]  |
| **search** | **string** | Filters by world name. | [optional]  |
| **tag** | **string** | Tags to include (comma-separated). Any of the tags needs to be present. | [optional]  |
| **notag** | **string** | Tags to exclude (comma-separated). | [optional]  |
| **releaseStatus** | **ReleaseStatus?** | Filter by ReleaseStatus. | [optional]  |
| **maxUnityVersion** | **string** | The maximum Unity version supported by the asset. | [optional]  |
| **minUnityVersion** | **string** | The minimum Unity version supported by the asset. | [optional]  |
| **platform** | **string** | The platform the asset supports. | [optional]  |
| **userId** | **string** | Target user to see information on, admin-only. | [optional]  |

### Return type

[**List&lt;Avatar&gt;**](Avatar.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a list of Avatar objects. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |
| **403** | Error response when trying to see favourited avatars of another user without sufficient admin permissions. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getownavatar"></a>
# **GetOwnAvatar**
> Avatar GetOwnAvatar (string userId)

Get Own Avatar

Get the current avatar for the user. This will return an error for any other user than the one logged in.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class GetOwnAvatarExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrchat.com/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new AvatarsApi(config);
            var userId = "userId_example";  // string | Must be a valid user ID.

            try
            {
                // Get Own Avatar
                Avatar result = apiInstance.GetOwnAvatar(userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AvatarsApi.GetOwnAvatar: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetOwnAvatarWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Own Avatar
    ApiResponse<Avatar> response = apiInstance.GetOwnAvatarWithHttpInfo(userId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AvatarsApi.GetOwnAvatarWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **string** | Must be a valid user ID. |  |

### Return type

[**Avatar**](Avatar.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a single Avatar object. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |
| **403** | Error response when trying to see another users current avatar without sufficient admin permissions. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchavatars"></a>
# **SearchAvatars**
> List&lt;Avatar&gt; SearchAvatars (bool? featured = null, SortOption? sort = null, string user = null, string userId = null, int? n = null, OrderOption? order = null, int? offset = null, string tag = null, string notag = null, ReleaseStatus? releaseStatus = null, string maxUnityVersion = null, string minUnityVersion = null, string platform = null)

Search Avatars

Search and list avatars by query filters. You can only search your own or featured avatars. It is not possible as a normal user to search other peoples avatars.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class SearchAvatarsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrchat.com/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new AvatarsApi(config);
            var featured = true;  // bool? | Filters on featured results. (optional) 
            var sort = (SortOption) "popularity";  // SortOption? | The sort order of the results. (optional) 
            var user = "me";  // string | Set to `me` for searching own avatars. (optional) 
            var userId = "userId_example";  // string | Filter by UserID. (optional) 
            var n = 60;  // int? | The number of objects to return. (optional)  (default to 60)
            var order = (OrderOption) "ascending";  // OrderOption? | Result ordering (optional) 
            var offset = 56;  // int? | A zero-based offset from the default object sorting from where search results start. (optional) 
            var tag = "tag_example";  // string | Tags to include (comma-separated). Any of the tags needs to be present. (optional) 
            var notag = "notag_example";  // string | Tags to exclude (comma-separated). (optional) 
            var releaseStatus = (ReleaseStatus) "public";  // ReleaseStatus? | Filter by ReleaseStatus. (optional) 
            var maxUnityVersion = "maxUnityVersion_example";  // string | The maximum Unity version supported by the asset. (optional) 
            var minUnityVersion = "minUnityVersion_example";  // string | The minimum Unity version supported by the asset. (optional) 
            var platform = "platform_example";  // string | The platform the asset supports. (optional) 

            try
            {
                // Search Avatars
                List<Avatar> result = apiInstance.SearchAvatars(featured, sort, user, userId, n, order, offset, tag, notag, releaseStatus, maxUnityVersion, minUnityVersion, platform);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AvatarsApi.SearchAvatars: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SearchAvatarsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search Avatars
    ApiResponse<List<Avatar>> response = apiInstance.SearchAvatarsWithHttpInfo(featured, sort, user, userId, n, order, offset, tag, notag, releaseStatus, maxUnityVersion, minUnityVersion, platform);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AvatarsApi.SearchAvatarsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **featured** | **bool?** | Filters on featured results. | [optional]  |
| **sort** | **SortOption?** | The sort order of the results. | [optional]  |
| **user** | **string** | Set to &#x60;me&#x60; for searching own avatars. | [optional]  |
| **userId** | **string** | Filter by UserID. | [optional]  |
| **n** | **int?** | The number of objects to return. | [optional] [default to 60] |
| **order** | **OrderOption?** | Result ordering | [optional]  |
| **offset** | **int?** | A zero-based offset from the default object sorting from where search results start. | [optional]  |
| **tag** | **string** | Tags to include (comma-separated). Any of the tags needs to be present. | [optional]  |
| **notag** | **string** | Tags to exclude (comma-separated). | [optional]  |
| **releaseStatus** | **ReleaseStatus?** | Filter by ReleaseStatus. | [optional]  |
| **maxUnityVersion** | **string** | The maximum Unity version supported by the asset. | [optional]  |
| **minUnityVersion** | **string** | The minimum Unity version supported by the asset. | [optional]  |
| **platform** | **string** | The platform the asset supports. | [optional]  |

### Return type

[**List&lt;Avatar&gt;**](Avatar.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a list of Avatar objects. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="selectavatar"></a>
# **SelectAvatar**
> CurrentUser SelectAvatar (string avatarId)

Select Avatar

Switches into that avatar.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class SelectAvatarExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrchat.com/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new AvatarsApi(config);
            var avatarId = "avatarId_example";  // string | Must be a valid avatar ID.

            try
            {
                // Select Avatar
                CurrentUser result = apiInstance.SelectAvatar(avatarId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AvatarsApi.SelectAvatar: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SelectAvatarWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Select Avatar
    ApiResponse<CurrentUser> response = apiInstance.SelectAvatarWithHttpInfo(avatarId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AvatarsApi.SelectAvatarWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **avatarId** | **string** | Must be a valid avatar ID. |  |

### Return type

[**CurrentUser**](CurrentUser.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a single CurrentUser object. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |
| **404** | Error response when trying to show information about a non-existent avatar. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="selectfallbackavatar"></a>
# **SelectFallbackAvatar**
> CurrentUser SelectFallbackAvatar (string avatarId)

Select Fallback Avatar

Switches into that avatar as your fallback avatar.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class SelectFallbackAvatarExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrchat.com/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new AvatarsApi(config);
            var avatarId = "avatarId_example";  // string | Must be a valid avatar ID.

            try
            {
                // Select Fallback Avatar
                CurrentUser result = apiInstance.SelectFallbackAvatar(avatarId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AvatarsApi.SelectFallbackAvatar: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SelectFallbackAvatarWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Select Fallback Avatar
    ApiResponse<CurrentUser> response = apiInstance.SelectFallbackAvatarWithHttpInfo(avatarId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AvatarsApi.SelectFallbackAvatarWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **avatarId** | **string** | Must be a valid avatar ID. |  |

### Return type

[**CurrentUser**](CurrentUser.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a single CurrentUser object. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |
| **403** | Error response when trying to select a fallback avatar that is missing the fallback tag. |  -  |
| **404** | Error response when trying to show information about a non-existent avatar. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateavatar"></a>
# **UpdateAvatar**
> Avatar UpdateAvatar (string avatarId, UpdateAvatarRequest updateAvatarRequest = null)

Update Avatar

Update information about a specific avatar.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class UpdateAvatarExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrchat.com/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new AvatarsApi(config);
            var avatarId = "avatarId_example";  // string | Must be a valid avatar ID.
            var updateAvatarRequest = new UpdateAvatarRequest(); // UpdateAvatarRequest |  (optional) 

            try
            {
                // Update Avatar
                Avatar result = apiInstance.UpdateAvatar(avatarId, updateAvatarRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AvatarsApi.UpdateAvatar: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateAvatarWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Avatar
    ApiResponse<Avatar> response = apiInstance.UpdateAvatarWithHttpInfo(avatarId, updateAvatarRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AvatarsApi.UpdateAvatarWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **avatarId** | **string** | Must be a valid avatar ID. |  |
| **updateAvatarRequest** | [**UpdateAvatarRequest**](UpdateAvatarRequest.md) |  | [optional]  |

### Return type

[**Avatar**](Avatar.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a single Avatar object. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |
| **404** | Error response when trying to show information about a non-existent avatar. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

