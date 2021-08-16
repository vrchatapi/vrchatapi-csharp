# io.github.vrchatapi.Api.UsersApi

All URIs are relative to *https://api.vrchat.cloud/api/1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetUser**](UsersApi.md#getuser) | **GET** /users/{userId} | Get User by ID
[**GetUserByName**](UsersApi.md#getuserbyname) | **GET** /users/{username}/name | Get User by Username
[**SearchActiveUsers**](UsersApi.md#searchactiveusers) | **GET** /users/active | Search Active Users
[**SearchUsers**](UsersApi.md#searchusers) | **GET** /users | Search All Users
[**UpdateUser**](UsersApi.md#updateuser) | **PUT** /users/{userId} | Update User Info



## GetUser

> User GetUser (string userId)

Get User by ID

Get public user information about a specific user using their ID.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using io.github.vrchatapi.Api;
using io.github.vrchatapi.Client;
using io.github.vrchatapi.Model;

namespace Example
{
    public class GetUserExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.vrchat.cloud/api/1";
            // Configure API key authorization: apiKeyCookie
            Configuration.Default.AddApiKey("apiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("apiKey", "Bearer");
            // Configure API key authorization: authCookie
            Configuration.Default.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new UsersApi(Configuration.Default);
            var userId = userId_example;  // string | 

            try
            {
                // Get User by ID
                User result = apiInstance.GetUser(userId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UsersApi.GetUser: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**|  | 

### Return type

[**User**](User.md)

### Authorization

[apiKeyCookie](../README.md#apiKeyCookie), [authCookie](../README.md#authCookie)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Error response due to missing apiKey or auth cookie. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetUserByName

> User GetUserByName (string username)

Get User by Username

Get public user information about a specific user using their name.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using io.github.vrchatapi.Api;
using io.github.vrchatapi.Client;
using io.github.vrchatapi.Model;

namespace Example
{
    public class GetUserByNameExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.vrchat.cloud/api/1";
            // Configure API key authorization: apiKeyCookie
            Configuration.Default.AddApiKey("apiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("apiKey", "Bearer");
            // Configure API key authorization: authCookie
            Configuration.Default.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new UsersApi(Configuration.Default);
            var username = username_example;  // string | 

            try
            {
                // Get User by Username
                User result = apiInstance.GetUserByName(username);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserByName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**|  | 

### Return type

[**User**](User.md)

### Authorization

[apiKeyCookie](../README.md#apiKeyCookie), [authCookie](../README.md#authCookie)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Error response due to missing apiKey or auth cookie. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## SearchActiveUsers

> List&lt;LimitedUser&gt; SearchActiveUsers (string search, string developerType = null, int? offset = null, int? n = null)

Search Active Users

Search and list any Active users by text query.  **Has been locked down and now always respond with \"Invalid Admin Credentials\".**

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using io.github.vrchatapi.Api;
using io.github.vrchatapi.Client;
using io.github.vrchatapi.Model;

namespace Example
{
    public class SearchActiveUsersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.vrchat.cloud/api/1";
            // Configure API key authorization: apiKeyCookie
            Configuration.Default.AddApiKey("apiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("apiKey", "Bearer");
            // Configure API key authorization: authCookie
            Configuration.Default.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new UsersApi(Configuration.Default);
            var search = search_example;  // string | Username to search for
            var developerType = developerType_example;  // string | Active user by developer type, none for normal users and internal for moderators (optional) 
            var offset = 56;  // int? | A zero-based offset from the default object sorting from where search results start. (optional) 
            var n = 56;  // int? | The number of objects to return. (optional)  (default to 60)

            try
            {
                // Search Active Users
                List<LimitedUser> result = apiInstance.SearchActiveUsers(search, developerType, offset, n);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UsersApi.SearchActiveUsers: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **search** | **string**| Username to search for | 
 **developerType** | **string**| Active user by developer type, none for normal users and internal for moderators | [optional] 
 **offset** | **int?**| A zero-based offset from the default object sorting from where search results start. | [optional] 
 **n** | **int?**| The number of objects to return. | [optional] [default to 60]

### Return type

[**List&lt;LimitedUser&gt;**](LimitedUser.md)

### Authorization

[apiKeyCookie](../README.md#apiKeyCookie), [authCookie](../README.md#authCookie)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **403** | Error response due to missing Administrator credentials. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## SearchUsers

> List&lt;LimitedUser&gt; SearchUsers (string search = null, string developerType = null, int? n = null, int? offset = null)

Search All Users

Search and list any users by text query

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using io.github.vrchatapi.Api;
using io.github.vrchatapi.Client;
using io.github.vrchatapi.Model;

namespace Example
{
    public class SearchUsersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.vrchat.cloud/api/1";
            // Configure API key authorization: apiKeyCookie
            Configuration.Default.AddApiKey("apiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("apiKey", "Bearer");
            // Configure API key authorization: authCookie
            Configuration.Default.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new UsersApi(Configuration.Default);
            var search = search_example;  // string | Searches by `displayName`. Will return empty array if search query is empty or missing. (optional) 
            var developerType = developerType_example;  // string | Active user by developer type, none for normal users and internal for moderators (optional) 
            var n = 56;  // int? | The number of objects to return. (optional)  (default to 60)
            var offset = 56;  // int? | A zero-based offset from the default object sorting from where search results start. (optional) 

            try
            {
                // Search All Users
                List<LimitedUser> result = apiInstance.SearchUsers(search, developerType, n, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UsersApi.SearchUsers: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **search** | **string**| Searches by &#x60;displayName&#x60;. Will return empty array if search query is empty or missing. | [optional] 
 **developerType** | **string**| Active user by developer type, none for normal users and internal for moderators | [optional] 
 **n** | **int?**| The number of objects to return. | [optional] [default to 60]
 **offset** | **int?**| A zero-based offset from the default object sorting from where search results start. | [optional] 

### Return type

[**List&lt;LimitedUser&gt;**](LimitedUser.md)

### Authorization

[apiKeyCookie](../README.md#apiKeyCookie), [authCookie](../README.md#authCookie)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error response when trying to search list of users with an invalid request. |  -  |
| **401** | Error response due to missing apiKey or auth cookie. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateUser

> CurrentUser UpdateUser (string userId, InlineObject2 inlineObject2 = null)

Update User Info

Update a users information such as the email and birthday.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using io.github.vrchatapi.Api;
using io.github.vrchatapi.Client;
using io.github.vrchatapi.Model;

namespace Example
{
    public class UpdateUserExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.vrchat.cloud/api/1";
            // Configure API key authorization: apiKeyCookie
            Configuration.Default.AddApiKey("apiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("apiKey", "Bearer");
            // Configure API key authorization: authCookie
            Configuration.Default.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new UsersApi(Configuration.Default);
            var userId = userId_example;  // string | 
            var inlineObject2 = new InlineObject2(); // InlineObject2 |  (optional) 

            try
            {
                // Update User Info
                CurrentUser result = apiInstance.UpdateUser(userId, inlineObject2);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UsersApi.UpdateUser: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**|  | 
 **inlineObject2** | [**InlineObject2**](InlineObject2.md)|  | [optional] 

### Return type

[**CurrentUser**](CurrentUser.md)

### Authorization

[apiKeyCookie](../README.md#apiKeyCookie), [authCookie](../README.md#authCookie)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

