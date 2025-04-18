# VRChat.API.Api.UsersApi

All URIs are relative to *https://api.vrchat.cloud/api/1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddTags**](UsersApi.md#addtags) | **POST** /users/{userId}/addTags | Add User Tags |
| [**CheckUserPersistenceExists**](UsersApi.md#checkuserpersistenceexists) | **GET** /users/{userId}/{worldId}/persist/exists | Check User Persistence Exists |
| [**DeleteUserPersistence**](UsersApi.md#deleteuserpersistence) | **DELETE** /users/{userId}/{worldId}/persist | Delete User Persistence |
| [**GetUser**](UsersApi.md#getuser) | **GET** /users/{userId} | Get User by ID |
| [**GetUserByName**](UsersApi.md#getuserbyname) | **GET** /users/{username}/name | Get User by Username |
| [**GetUserFeedback**](UsersApi.md#getuserfeedback) | **GET** /users/{userId}/feedback | Get User Feedback |
| [**GetUserGroupInstances**](UsersApi.md#getusergroupinstances) | **GET** /users/{userId}/instances/groups | Get User Group Instances |
| [**GetUserGroupRequests**](UsersApi.md#getusergrouprequests) | **GET** /users/{userId}/groups/requested | Get User Group Requests |
| [**GetUserGroups**](UsersApi.md#getusergroups) | **GET** /users/{userId}/groups | Get User Groups |
| [**GetUserNote**](UsersApi.md#getusernote) | **GET** /userNotes/{userNoteId} | Get User Note |
| [**GetUserNotes**](UsersApi.md#getusernotes) | **GET** /userNotes | Get User Notes |
| [**GetUserRepresentedGroup**](UsersApi.md#getuserrepresentedgroup) | **GET** /users/{userId}/groups/represented | Get user&#39;s current represented group |
| [**RemoveTags**](UsersApi.md#removetags) | **POST** /users/{userId}/removeTags | Remove User Tags |
| [**SearchUsers**](UsersApi.md#searchusers) | **GET** /users | Search All Users |
| [**UpdateBadge**](UsersApi.md#updatebadge) | **PUT** /users/{userId}/badges/{badgeId} | Update User Badge |
| [**UpdateUser**](UsersApi.md#updateuser) | **PUT** /users/{userId} | Update User Info |
| [**UpdateUserNote**](UsersApi.md#updateusernote) | **POST** /userNotes | Update User Note |

<a name="addtags"></a>
# **AddTags**
> CurrentUser AddTags (string userId, ChangeUserTagsRequest changeUserTagsRequest)

Add User Tags

Adds tags to the user's profile

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class AddTagsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vrchat.cloud/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new UsersApi(config);
            var userId = "userId_example";  // string | Must be a valid user ID.
            var changeUserTagsRequest = new ChangeUserTagsRequest(); // ChangeUserTagsRequest | 

            try
            {
                // Add User Tags
                CurrentUser result = apiInstance.AddTags(userId, changeUserTagsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.AddTags: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddTagsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add User Tags
    ApiResponse<CurrentUser> response = apiInstance.AddTagsWithHttpInfo(userId, changeUserTagsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.AddTagsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **string** | Must be a valid user ID. |  |
| **changeUserTagsRequest** | [**ChangeUserTagsRequest**](ChangeUserTagsRequest.md) |  |  |

### Return type

[**CurrentUser**](CurrentUser.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a single CurrentUser object. |  -  |
| **400** | Error response when a user attempts to add an invalid, restricted, or duplicate tag to their profile, attempts to add tags above the limit for their profile, or attempts to remove invalid, restricted, or absent tag from their profile. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="checkuserpersistenceexists"></a>
# **CheckUserPersistenceExists**
> void CheckUserPersistenceExists (string userId, string worldId)

Check User Persistence Exists

Checks whether the user has persistence data for a given world

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
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

            var apiInstance = new UsersApi(config);
            var userId = "userId_example";  // string | Must be a valid user ID.
            var worldId = "worldId_example";  // string | Must be a valid world ID.

            try
            {
                // Check User Persistence Exists
                apiInstance.CheckUserPersistenceExists(userId, worldId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.CheckUserPersistenceExists: " + e.Message);
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
    Debug.Print("Exception when calling UsersApi.CheckUserPersistenceExistsWithHttpInfo: " + e.Message);
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

<a name="deleteuserpersistence"></a>
# **DeleteUserPersistence**
> void DeleteUserPersistence (string userId, string worldId)

Delete User Persistence

Deletes the user's persistence data for a given world

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
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

            var apiInstance = new UsersApi(config);
            var userId = "userId_example";  // string | Must be a valid user ID.
            var worldId = "worldId_example";  // string | Must be a valid world ID.

            try
            {
                // Delete User Persistence
                apiInstance.DeleteUserPersistence(userId, worldId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.DeleteUserPersistence: " + e.Message);
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
    Debug.Print("Exception when calling UsersApi.DeleteUserPersistenceWithHttpInfo: " + e.Message);
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

<a name="getuser"></a>
# **GetUser**
> User GetUser (string userId)

Get User by ID

Get public user information about a specific user using their ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class GetUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vrchat.cloud/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new UsersApi(config);
            var userId = "userId_example";  // string | Must be a valid user ID.

            try
            {
                // Get User by ID
                User result = apiInstance.GetUser(userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.GetUser: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get User by ID
    ApiResponse<User> response = apiInstance.GetUserWithHttpInfo(userId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.GetUserWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **string** | Must be a valid user ID. |  |

### Return type

[**User**](User.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a single User object. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserbyname"></a>
# **GetUserByName**
> User GetUserByName (string username)

Get User by Username

~~Get public user information about a specific user using their name.~~  **DEPRECATED:** VRChat API no longer return usernames of other users. [See issue by Tupper for more information](https://github.com/pypy-vrc/VRCX/issues/429). This endpoint now require Admin Credentials.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class GetUserByNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vrchat.cloud/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new UsersApi(config);
            var username = "username_example";  // string | Username of the user

            try
            {
                // Get User by Username
                User result = apiInstance.GetUserByName(username);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserByName: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetUserByNameWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get User by Username
    ApiResponse<User> response = apiInstance.GetUserByNameWithHttpInfo(username);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.GetUserByNameWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **username** | **string** | Username of the user |  |

### Return type

[**User**](User.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a single User object. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserfeedback"></a>
# **GetUserFeedback**
> List&lt;Feedback&gt; GetUserFeedback (string userId, bool? contentId = null, int? n = null, int? offset = null)

Get User Feedback

Get user's submitted feedback

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class GetUserFeedbackExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vrchat.cloud/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new UsersApi(config);
            var userId = "userId_example";  // string | Must be a valid user ID.
            var contentId = true;  // bool? | Filter for users' previously submitted feedback, e.g., a groupId, useeId, avatarId, etc. (optional) 
            var n = 60;  // int? | The number of objects to return. (optional)  (default to 60)
            var offset = 56;  // int? | A zero-based offset from the default object sorting from where search results start. (optional) 

            try
            {
                // Get User Feedback
                List<Feedback> result = apiInstance.GetUserFeedback(userId, contentId, n, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserFeedback: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetUserFeedbackWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get User Feedback
    ApiResponse<List<Feedback>> response = apiInstance.GetUserFeedbackWithHttpInfo(userId, contentId, n, offset);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.GetUserFeedbackWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **string** | Must be a valid user ID. |  |
| **contentId** | **bool?** | Filter for users&#39; previously submitted feedback, e.g., a groupId, useeId, avatarId, etc. | [optional]  |
| **n** | **int?** | The number of objects to return. | [optional] [default to 60] |
| **offset** | **int?** | A zero-based offset from the default object sorting from where search results start. | [optional]  |

### Return type

[**List&lt;Feedback&gt;**](Feedback.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a list of Feedback objects. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusergroupinstances"></a>
# **GetUserGroupInstances**
> GetUserGroupInstances200Response GetUserGroupInstances (string userId)

Get User Group Instances

Returns a list of group instances for a user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class GetUserGroupInstancesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vrchat.cloud/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new UsersApi(config);
            var userId = "userId_example";  // string | Must be a valid user ID.

            try
            {
                // Get User Group Instances
                GetUserGroupInstances200Response result = apiInstance.GetUserGroupInstances(userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserGroupInstances: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetUserGroupInstancesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get User Group Instances
    ApiResponse<GetUserGroupInstances200Response> response = apiInstance.GetUserGroupInstancesWithHttpInfo(userId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.GetUserGroupInstancesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **string** | Must be a valid user ID. |  |

### Return type

[**GetUserGroupInstances200Response**](GetUserGroupInstances200Response.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a list of Instance objects with a fetched at time. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |
| **403** | Error response when trying get group instances of another user. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusergrouprequests"></a>
# **GetUserGroupRequests**
> List&lt;Group&gt; GetUserGroupRequests (string userId)

Get User Group Requests

Returns a list of Groups the user has requested to be invited into.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class GetUserGroupRequestsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vrchat.cloud/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new UsersApi(config);
            var userId = "userId_example";  // string | Must be a valid user ID.

            try
            {
                // Get User Group Requests
                List<Group> result = apiInstance.GetUserGroupRequests(userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserGroupRequests: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetUserGroupRequestsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get User Group Requests
    ApiResponse<List<Group>> response = apiInstance.GetUserGroupRequestsWithHttpInfo(userId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.GetUserGroupRequestsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **string** | Must be a valid user ID. |  |

### Return type

[**List&lt;Group&gt;**](Group.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a list of Group objects. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusergroups"></a>
# **GetUserGroups**
> List&lt;LimitedUserGroups&gt; GetUserGroups (string userId)

Get User Groups

Get user's public groups

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class GetUserGroupsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vrchat.cloud/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new UsersApi(config);
            var userId = "userId_example";  // string | Must be a valid user ID.

            try
            {
                // Get User Groups
                List<LimitedUserGroups> result = apiInstance.GetUserGroups(userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserGroups: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetUserGroupsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get User Groups
    ApiResponse<List<LimitedUserGroups>> response = apiInstance.GetUserGroupsWithHttpInfo(userId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.GetUserGroupsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **string** | Must be a valid user ID. |  |

### Return type

[**List&lt;LimitedUserGroups&gt;**](LimitedUserGroups.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a list of LimitedUserGroups objects. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusernote"></a>
# **GetUserNote**
> UserNote GetUserNote (string userNoteId)

Get User Note

Get a particular user note

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class GetUserNoteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vrchat.cloud/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new UsersApi(config);
            var userNoteId = "userNoteId_example";  // string | Must be a valid user note ID.

            try
            {
                // Get User Note
                UserNote result = apiInstance.GetUserNote(userNoteId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserNote: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetUserNoteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get User Note
    ApiResponse<UserNote> response = apiInstance.GetUserNoteWithHttpInfo(userNoteId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.GetUserNoteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userNoteId** | **string** | Must be a valid user note ID. |  |

### Return type

[**UserNote**](UserNote.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a single UserNote object. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusernotes"></a>
# **GetUserNotes**
> List&lt;UserNote&gt; GetUserNotes (int? n = null, int? offset = null)

Get User Notes

Get recently updated user notes

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class GetUserNotesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vrchat.cloud/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new UsersApi(config);
            var n = 60;  // int? | The number of objects to return. (optional)  (default to 60)
            var offset = 56;  // int? | A zero-based offset from the default object sorting from where search results start. (optional) 

            try
            {
                // Get User Notes
                List<UserNote> result = apiInstance.GetUserNotes(n, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserNotes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetUserNotesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get User Notes
    ApiResponse<List<UserNote>> response = apiInstance.GetUserNotesWithHttpInfo(n, offset);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.GetUserNotesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **n** | **int?** | The number of objects to return. | [optional] [default to 60] |
| **offset** | **int?** | A zero-based offset from the default object sorting from where search results start. | [optional]  |

### Return type

[**List&lt;UserNote&gt;**](UserNote.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a list of UserNote objects. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserrepresentedgroup"></a>
# **GetUserRepresentedGroup**
> RepresentedGroup GetUserRepresentedGroup (string userId)

Get user's current represented group

Returns the current group that the user is currently representing

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class GetUserRepresentedGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vrchat.cloud/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new UsersApi(config);
            var userId = "userId_example";  // string | Must be a valid user ID.

            try
            {
                // Get user's current represented group
                RepresentedGroup result = apiInstance.GetUserRepresentedGroup(userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserRepresentedGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetUserRepresentedGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get user's current represented group
    ApiResponse<RepresentedGroup> response = apiInstance.GetUserRepresentedGroupWithHttpInfo(userId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.GetUserRepresentedGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **string** | Must be a valid user ID. |  |

### Return type

[**RepresentedGroup**](RepresentedGroup.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removetags"></a>
# **RemoveTags**
> CurrentUser RemoveTags (string userId, ChangeUserTagsRequest changeUserTagsRequest)

Remove User Tags

Removes tags from the user's profile

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class RemoveTagsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vrchat.cloud/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new UsersApi(config);
            var userId = "userId_example";  // string | Must be a valid user ID.
            var changeUserTagsRequest = new ChangeUserTagsRequest(); // ChangeUserTagsRequest | 

            try
            {
                // Remove User Tags
                CurrentUser result = apiInstance.RemoveTags(userId, changeUserTagsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.RemoveTags: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RemoveTagsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove User Tags
    ApiResponse<CurrentUser> response = apiInstance.RemoveTagsWithHttpInfo(userId, changeUserTagsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.RemoveTagsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **string** | Must be a valid user ID. |  |
| **changeUserTagsRequest** | [**ChangeUserTagsRequest**](ChangeUserTagsRequest.md) |  |  |

### Return type

[**CurrentUser**](CurrentUser.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a single CurrentUser object. |  -  |
| **400** | Error response when a user attempts to add an invalid, restricted, or duplicate tag to their profile, attempts to add tags above the limit for their profile, or attempts to remove invalid, restricted, or absent tag from their profile. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchusers"></a>
# **SearchUsers**
> List&lt;LimitedUser&gt; SearchUsers (string search = null, string developerType = null, int? n = null, int? offset = null)

Search All Users

Search and list any users by text query

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class SearchUsersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vrchat.cloud/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new UsersApi(config);
            var search = "search_example";  // string | Searches by `displayName`. Will return empty array if search query is empty or missing. (optional) 
            var developerType = "developerType_example";  // string | Active user by developer type, none for normal users and internal for moderators (optional) 
            var n = 60;  // int? | The number of objects to return. (optional)  (default to 60)
            var offset = 56;  // int? | A zero-based offset from the default object sorting from where search results start. (optional) 

            try
            {
                // Search All Users
                List<LimitedUser> result = apiInstance.SearchUsers(search, developerType, n, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.SearchUsers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SearchUsersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search All Users
    ApiResponse<List<LimitedUser>> response = apiInstance.SearchUsersWithHttpInfo(search, developerType, n, offset);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.SearchUsersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **search** | **string** | Searches by &#x60;displayName&#x60;. Will return empty array if search query is empty or missing. | [optional]  |
| **developerType** | **string** | Active user by developer type, none for normal users and internal for moderators | [optional]  |
| **n** | **int?** | The number of objects to return. | [optional] [default to 60] |
| **offset** | **int?** | A zero-based offset from the default object sorting from where search results start. | [optional]  |

### Return type

[**List&lt;LimitedUser&gt;**](LimitedUser.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a list of LimitedUser objects. |  -  |
| **400** | Error response when trying to search list of users with an invalid request. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatebadge"></a>
# **UpdateBadge**
> void UpdateBadge (string userId, string badgeId, UpdateUserBadgeRequest updateUserBadgeRequest)

Update User Badge

Updates a user's badge

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class UpdateBadgeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vrchat.cloud/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new UsersApi(config);
            var userId = "userId_example";  // string | Must be a valid user ID.
            var badgeId = "badgeId_example";  // string | Must be a valid badge ID.
            var updateUserBadgeRequest = new UpdateUserBadgeRequest(); // UpdateUserBadgeRequest | 

            try
            {
                // Update User Badge
                apiInstance.UpdateBadge(userId, badgeId, updateUserBadgeRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.UpdateBadge: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateBadgeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update User Badge
    apiInstance.UpdateBadgeWithHttpInfo(userId, badgeId, updateUserBadgeRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.UpdateBadgeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **string** | Must be a valid user ID. |  |
| **badgeId** | **string** | Must be a valid badge ID. |  |
| **updateUserBadgeRequest** | [**UpdateUserBadgeRequest**](UpdateUserBadgeRequest.md) |  |  |

### Return type

void (empty response body)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The user&#39;s badge is updated. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |
| **403** | Error response when trying get group instances of another user. |  -  |
| **404** | The user does not have the badge. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateuser"></a>
# **UpdateUser**
> CurrentUser UpdateUser (string userId, UpdateUserRequest updateUserRequest = null)

Update User Info

Update a users information such as the email and birthday.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class UpdateUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vrchat.cloud/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new UsersApi(config);
            var userId = "userId_example";  // string | Must be a valid user ID.
            var updateUserRequest = new UpdateUserRequest(); // UpdateUserRequest |  (optional) 

            try
            {
                // Update User Info
                CurrentUser result = apiInstance.UpdateUser(userId, updateUserRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.UpdateUser: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update User Info
    ApiResponse<CurrentUser> response = apiInstance.UpdateUserWithHttpInfo(userId, updateUserRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.UpdateUserWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **string** | Must be a valid user ID. |  |
| **updateUserRequest** | [**UpdateUserRequest**](UpdateUserRequest.md) |  | [optional]  |

### Return type

[**CurrentUser**](CurrentUser.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a single CurrentUser object. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateusernote"></a>
# **UpdateUserNote**
> UserNote UpdateUserNote (UpdateUserNoteRequest updateUserNoteRequest)

Update User Note

Updates the currently authenticated user's note on a user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class UpdateUserNoteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vrchat.cloud/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new UsersApi(config);
            var updateUserNoteRequest = new UpdateUserNoteRequest(); // UpdateUserNoteRequest | 

            try
            {
                // Update User Note
                UserNote result = apiInstance.UpdateUserNote(updateUserNoteRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.UpdateUserNote: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateUserNoteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update User Note
    ApiResponse<UserNote> response = apiInstance.UpdateUserNoteWithHttpInfo(updateUserNoteRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.UpdateUserNoteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **updateUserNoteRequest** | [**UpdateUserNoteRequest**](UpdateUserNoteRequest.md) |  |  |

### Return type

[**UserNote**](UserNote.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a single UserNote object. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

