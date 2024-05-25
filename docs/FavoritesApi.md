# VRChat.API.Api.FavoritesApi

All URIs are relative to *https://vrchat.com/api/1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddFavorite**](FavoritesApi.md#addfavorite) | **POST** /favorites | Add Favorite |
| [**ClearFavoriteGroup**](FavoritesApi.md#clearfavoritegroup) | **DELETE** /favorite/group/{favoriteGroupType}/{favoriteGroupName}/{userId} | Clear Favorite Group |
| [**GetFavorite**](FavoritesApi.md#getfavorite) | **GET** /favorites/{favoriteId} | Show Favorite |
| [**GetFavoriteGroup**](FavoritesApi.md#getfavoritegroup) | **GET** /favorite/group/{favoriteGroupType}/{favoriteGroupName}/{userId} | Show Favorite Group |
| [**GetFavoriteGroups**](FavoritesApi.md#getfavoritegroups) | **GET** /favorite/groups | List Favorite Groups |
| [**GetFavorites**](FavoritesApi.md#getfavorites) | **GET** /favorites | List Favorites |
| [**RemoveFavorite**](FavoritesApi.md#removefavorite) | **DELETE** /favorites/{favoriteId} | Remove Favorite |
| [**UpdateFavoriteGroup**](FavoritesApi.md#updatefavoritegroup) | **PUT** /favorite/group/{favoriteGroupType}/{favoriteGroupName}/{userId} | Update Favorite Group |

<a name="addfavorite"></a>
# **AddFavorite**
> Favorite AddFavorite (AddFavoriteRequest addFavoriteRequest = null)

Add Favorite

Add a new favorite.  Friend groups are named `group_0` through `group_3`. Avatar and World groups are named `avatars1` to `avatars4` and `worlds1` to `worlds4`.  You cannot add people whom you are not friends with to your friends list. Destroying a friendship removes the person as favorite on both sides.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class AddFavoriteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrchat.com/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new FavoritesApi(config);
            var addFavoriteRequest = new AddFavoriteRequest(); // AddFavoriteRequest |  (optional) 

            try
            {
                // Add Favorite
                Favorite result = apiInstance.AddFavorite(addFavoriteRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FavoritesApi.AddFavorite: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddFavoriteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add Favorite
    ApiResponse<Favorite> response = apiInstance.AddFavoriteWithHttpInfo(addFavoriteRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FavoritesApi.AddFavoriteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **addFavoriteRequest** | [**AddFavoriteRequest**](AddFavoriteRequest.md) |  | [optional]  |

### Return type

[**Favorite**](Favorite.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a single Favorite object. |  -  |
| **400** | Error response when trying favorite someone or something when already having it/them favorited. |  -  |
| **403** | Error response when trying favorite someone whom you are not friends with. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="clearfavoritegroup"></a>
# **ClearFavoriteGroup**
> Success ClearFavoriteGroup (string favoriteGroupType, string favoriteGroupName, string userId)

Clear Favorite Group

Clear ALL contents of a specific favorite group.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class ClearFavoriteGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrchat.com/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new FavoritesApi(config);
            var favoriteGroupType = "world";  // string | The type of group to fetch, must be a valid FavoriteType.
            var favoriteGroupName = "favoriteGroupName_example";  // string | The name of the group to fetch, must be a name of a FavoriteGroup.
            var userId = "userId_example";  // string | Must be a valid user ID.

            try
            {
                // Clear Favorite Group
                Success result = apiInstance.ClearFavoriteGroup(favoriteGroupType, favoriteGroupName, userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FavoritesApi.ClearFavoriteGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ClearFavoriteGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Clear Favorite Group
    ApiResponse<Success> response = apiInstance.ClearFavoriteGroupWithHttpInfo(favoriteGroupType, favoriteGroupName, userId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FavoritesApi.ClearFavoriteGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **favoriteGroupType** | **string** | The type of group to fetch, must be a valid FavoriteType. |  |
| **favoriteGroupName** | **string** | The name of the group to fetch, must be a name of a FavoriteGroup. |  |
| **userId** | **string** | Must be a valid user ID. |  |

### Return type

[**Success**](Success.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success response after clearing a favorite group. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfavorite"></a>
# **GetFavorite**
> Favorite GetFavorite (string favoriteId)

Show Favorite

Return information about a specific Favorite.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class GetFavoriteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrchat.com/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new FavoritesApi(config);
            var favoriteId = "favoriteId_example";  // string | Must be a valid favorite ID.

            try
            {
                // Show Favorite
                Favorite result = apiInstance.GetFavorite(favoriteId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FavoritesApi.GetFavorite: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFavoriteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Show Favorite
    ApiResponse<Favorite> response = apiInstance.GetFavoriteWithHttpInfo(favoriteId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FavoritesApi.GetFavoriteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **favoriteId** | **string** | Must be a valid favorite ID. |  |

### Return type

[**Favorite**](Favorite.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a single Favorite object. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |
| **404** | Error response when trying to show information about a non-existent favorite. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfavoritegroup"></a>
# **GetFavoriteGroup**
> FavoriteGroup GetFavoriteGroup (string favoriteGroupType, string favoriteGroupName, string userId)

Show Favorite Group

Fetch information about a specific favorite group.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class GetFavoriteGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrchat.com/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new FavoritesApi(config);
            var favoriteGroupType = "world";  // string | The type of group to fetch, must be a valid FavoriteType.
            var favoriteGroupName = "favoriteGroupName_example";  // string | The name of the group to fetch, must be a name of a FavoriteGroup.
            var userId = "userId_example";  // string | Must be a valid user ID.

            try
            {
                // Show Favorite Group
                FavoriteGroup result = apiInstance.GetFavoriteGroup(favoriteGroupType, favoriteGroupName, userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FavoritesApi.GetFavoriteGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFavoriteGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Show Favorite Group
    ApiResponse<FavoriteGroup> response = apiInstance.GetFavoriteGroupWithHttpInfo(favoriteGroupType, favoriteGroupName, userId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FavoritesApi.GetFavoriteGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **favoriteGroupType** | **string** | The type of group to fetch, must be a valid FavoriteType. |  |
| **favoriteGroupName** | **string** | The name of the group to fetch, must be a name of a FavoriteGroup. |  |
| **userId** | **string** | Must be a valid user ID. |  |

### Return type

[**FavoriteGroup**](FavoriteGroup.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a single FavoriteGroup object. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfavoritegroups"></a>
# **GetFavoriteGroups**
> List&lt;FavoriteGroup&gt; GetFavoriteGroups (int? n = null, int? offset = null, string ownerId = null)

List Favorite Groups

Return a list of favorite groups owned by a user. Returns the same information as `getFavoriteGroups`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class GetFavoriteGroupsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrchat.com/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new FavoritesApi(config);
            var n = 60;  // int? | The number of objects to return. (optional)  (default to 60)
            var offset = 56;  // int? | A zero-based offset from the default object sorting from where search results start. (optional) 
            var ownerId = "ownerId_example";  // string | The owner of whoms favorite groups to return. Must be a UserID. (optional) 

            try
            {
                // List Favorite Groups
                List<FavoriteGroup> result = apiInstance.GetFavoriteGroups(n, offset, ownerId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FavoritesApi.GetFavoriteGroups: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFavoriteGroupsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Favorite Groups
    ApiResponse<List<FavoriteGroup>> response = apiInstance.GetFavoriteGroupsWithHttpInfo(n, offset, ownerId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FavoritesApi.GetFavoriteGroupsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **n** | **int?** | The number of objects to return. | [optional] [default to 60] |
| **offset** | **int?** | A zero-based offset from the default object sorting from where search results start. | [optional]  |
| **ownerId** | **string** | The owner of whoms favorite groups to return. Must be a UserID. | [optional]  |

### Return type

[**List&lt;FavoriteGroup&gt;**](FavoriteGroup.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a list of FavoriteGroup objects. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfavorites"></a>
# **GetFavorites**
> List&lt;Favorite&gt; GetFavorites (int? n = null, int? offset = null, string type = null, string tag = null)

List Favorites

Returns a list of favorites.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class GetFavoritesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrchat.com/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new FavoritesApi(config);
            var n = 60;  // int? | The number of objects to return. (optional)  (default to 60)
            var offset = 56;  // int? | A zero-based offset from the default object sorting from where search results start. (optional) 
            var type = "type_example";  // string | The type of favorites to return, FavoriteType. (optional) 
            var tag = "tag_example";  // string | Tags to include (comma-separated). Any of the tags needs to be present. (optional) 

            try
            {
                // List Favorites
                List<Favorite> result = apiInstance.GetFavorites(n, offset, type, tag);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FavoritesApi.GetFavorites: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFavoritesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Favorites
    ApiResponse<List<Favorite>> response = apiInstance.GetFavoritesWithHttpInfo(n, offset, type, tag);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FavoritesApi.GetFavoritesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **n** | **int?** | The number of objects to return. | [optional] [default to 60] |
| **offset** | **int?** | A zero-based offset from the default object sorting from where search results start. | [optional]  |
| **type** | **string** | The type of favorites to return, FavoriteType. | [optional]  |
| **tag** | **string** | Tags to include (comma-separated). Any of the tags needs to be present. | [optional]  |

### Return type

[**List&lt;Favorite&gt;**](Favorite.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a list of Favorite objects. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removefavorite"></a>
# **RemoveFavorite**
> Success RemoveFavorite (string favoriteId)

Remove Favorite

Remove a favorite from your favorites list.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class RemoveFavoriteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrchat.com/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new FavoritesApi(config);
            var favoriteId = "favoriteId_example";  // string | Must be a valid favorite ID.

            try
            {
                // Remove Favorite
                Success result = apiInstance.RemoveFavorite(favoriteId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FavoritesApi.RemoveFavorite: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RemoveFavoriteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove Favorite
    ApiResponse<Success> response = apiInstance.RemoveFavoriteWithHttpInfo(favoriteId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FavoritesApi.RemoveFavoriteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **favoriteId** | **string** | Must be a valid favorite ID. |  |

### Return type

[**Success**](Success.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success response after removing a favorite. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |
| **404** | Error response when trying to show information about a non-existent favorite. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatefavoritegroup"></a>
# **UpdateFavoriteGroup**
> void UpdateFavoriteGroup (string favoriteGroupType, string favoriteGroupName, string userId, UpdateFavoriteGroupRequest updateFavoriteGroupRequest = null)

Update Favorite Group

Update information about a specific favorite group.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class UpdateFavoriteGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrchat.com/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new FavoritesApi(config);
            var favoriteGroupType = "world";  // string | The type of group to fetch, must be a valid FavoriteType.
            var favoriteGroupName = "favoriteGroupName_example";  // string | The name of the group to fetch, must be a name of a FavoriteGroup.
            var userId = "userId_example";  // string | Must be a valid user ID.
            var updateFavoriteGroupRequest = new UpdateFavoriteGroupRequest(); // UpdateFavoriteGroupRequest |  (optional) 

            try
            {
                // Update Favorite Group
                apiInstance.UpdateFavoriteGroup(favoriteGroupType, favoriteGroupName, userId, updateFavoriteGroupRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FavoritesApi.UpdateFavoriteGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateFavoriteGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Favorite Group
    apiInstance.UpdateFavoriteGroupWithHttpInfo(favoriteGroupType, favoriteGroupName, userId, updateFavoriteGroupRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FavoritesApi.UpdateFavoriteGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **favoriteGroupType** | **string** | The type of group to fetch, must be a valid FavoriteType. |  |
| **favoriteGroupName** | **string** | The name of the group to fetch, must be a name of a FavoriteGroup. |  |
| **userId** | **string** | Must be a valid user ID. |  |
| **updateFavoriteGroupRequest** | [**UpdateFavoriteGroupRequest**](UpdateFavoriteGroupRequest.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

