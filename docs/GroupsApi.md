# VRChat.API.Api.GroupsApi

All URIs are relative to *https://vrchat.com/api/1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddGroupGalleryImage**](GroupsApi.md#addgroupgalleryimage) | **POST** /groups/{groupId}/galleries/{groupGalleryId}/images | Add Group Gallery Image |
| [**AddGroupMemberRole**](GroupsApi.md#addgroupmemberrole) | **PUT** /groups/{groupId}/members/{userId}/roles/{groupRoleId} | Add Role to GroupMember |
| [**AddGroupPost**](GroupsApi.md#addgrouppost) | **POST** /groups/{groupId}/posts | Create a post in a Group |
| [**BanGroupMember**](GroupsApi.md#bangroupmember) | **POST** /groups/{groupId}/bans | Ban Group Member |
| [**CancelGroupRequest**](GroupsApi.md#cancelgrouprequest) | **DELETE** /groups/{groupId}/requests | Cancel Group Join Request |
| [**CreateGroup**](GroupsApi.md#creategroup) | **POST** /groups | Create Group |
| [**CreateGroupAnnouncement**](GroupsApi.md#creategroupannouncement) | **POST** /groups/{groupId}/announcement | Create Group Announcement |
| [**CreateGroupGallery**](GroupsApi.md#creategroupgallery) | **POST** /groups/{groupId}/galleries | Create Group Gallery |
| [**CreateGroupInvite**](GroupsApi.md#creategroupinvite) | **POST** /groups/{groupId}/invites | Invite User to Group |
| [**CreateGroupRole**](GroupsApi.md#creategrouprole) | **POST** /groups/{groupId}/roles | Create GroupRole |
| [**DeleteGroup**](GroupsApi.md#deletegroup) | **DELETE** /groups/{groupId} | Delete Group |
| [**DeleteGroupAnnouncement**](GroupsApi.md#deletegroupannouncement) | **DELETE** /groups/{groupId}/announcement | Delete Group Announcement |
| [**DeleteGroupGallery**](GroupsApi.md#deletegroupgallery) | **DELETE** /groups/{groupId}/galleries/{groupGalleryId} | Delete Group Gallery |
| [**DeleteGroupGalleryImage**](GroupsApi.md#deletegroupgalleryimage) | **DELETE** /groups/{groupId}/galleries/{groupGalleryId}/images/{groupGalleryImageId} | Delete Group Gallery Image |
| [**DeleteGroupInvite**](GroupsApi.md#deletegroupinvite) | **DELETE** /groups/{groupId}/invites/{userId} | Delete User Invite |
| [**DeleteGroupPost**](GroupsApi.md#deletegrouppost) | **DELETE** /groups/{groupId}/posts/{notificationId} | Delete a Group post |
| [**DeleteGroupRole**](GroupsApi.md#deletegrouprole) | **DELETE** /groups/{groupId}/roles/{groupRoleId} | Delete Group Role |
| [**GetGroup**](GroupsApi.md#getgroup) | **GET** /groups/{groupId} | Get Group by ID |
| [**GetGroupAnnouncements**](GroupsApi.md#getgroupannouncements) | **GET** /groups/{groupId}/announcement | Get Group Announcement |
| [**GetGroupAuditLogs**](GroupsApi.md#getgroupauditlogs) | **GET** /groups/{groupId}/auditLogs | Get Group Audit Logs |
| [**GetGroupBans**](GroupsApi.md#getgroupbans) | **GET** /groups/{groupId}/bans | Get Group Bans |
| [**GetGroupGalleryImages**](GroupsApi.md#getgroupgalleryimages) | **GET** /groups/{groupId}/galleries/{groupGalleryId} | Get Group Gallery Images |
| [**GetGroupInstances**](GroupsApi.md#getgroupinstances) | **GET** /groups/{groupId}/instances | Get Group Instances |
| [**GetGroupInvites**](GroupsApi.md#getgroupinvites) | **GET** /groups/{groupId}/invites | Get Group Invites Sent |
| [**GetGroupMember**](GroupsApi.md#getgroupmember) | **GET** /groups/{groupId}/members/{userId} | Get Group Member |
| [**GetGroupMembers**](GroupsApi.md#getgroupmembers) | **GET** /groups/{groupId}/members | List Group Members |
| [**GetGroupPermissions**](GroupsApi.md#getgrouppermissions) | **GET** /groups/{groupId}/permissions | List Group Permissions |
| [**GetGroupPost**](GroupsApi.md#getgrouppost) | **GET** /groups/{groupId}/posts | Get posts from a Group |
| [**GetGroupRequests**](GroupsApi.md#getgrouprequests) | **GET** /groups/{groupId}/requests | Get Group Join Requests |
| [**GetGroupRoles**](GroupsApi.md#getgrouproles) | **GET** /groups/{groupId}/roles | Get Group Roles |
| [**JoinGroup**](GroupsApi.md#joingroup) | **POST** /groups/{groupId}/join | Join Group |
| [**KickGroupMember**](GroupsApi.md#kickgroupmember) | **DELETE** /groups/{groupId}/members/{userId} | Kick Group Member |
| [**LeaveGroup**](GroupsApi.md#leavegroup) | **POST** /groups/{groupId}/leave | Leave Group |
| [**RemoveGroupMemberRole**](GroupsApi.md#removegroupmemberrole) | **DELETE** /groups/{groupId}/members/{userId}/roles/{groupRoleId} | Remove Role from GroupMember |
| [**RespondGroupJoinRequest**](GroupsApi.md#respondgroupjoinrequest) | **PUT** /groups/{groupId}/requests/{userId} | Respond Group Join request |
| [**SearchGroups**](GroupsApi.md#searchgroups) | **GET** /groups | Search Group |
| [**UnbanGroupMember**](GroupsApi.md#unbangroupmember) | **DELETE** /groups/{groupId}/bans/{userId} | Unban Group Member |
| [**UpdateGroup**](GroupsApi.md#updategroup) | **PUT** /groups/{groupId} | Update Group |
| [**UpdateGroupGallery**](GroupsApi.md#updategroupgallery) | **PUT** /groups/{groupId}/galleries/{groupGalleryId} | Update Group Gallery |
| [**UpdateGroupMember**](GroupsApi.md#updategroupmember) | **PUT** /groups/{groupId}/members/{userId} | Update Group Member |
| [**UpdateGroupPost**](GroupsApi.md#updategrouppost) | **PUT** /groups/{groupId}/posts/{notificationId} | Edits a Group post |
| [**UpdateGroupRole**](GroupsApi.md#updategrouprole) | **PUT** /groups/{groupId}/roles/{groupRoleId} | Update Group Role |

<a name="addgroupgalleryimage"></a>
# **AddGroupGalleryImage**
> GroupGalleryImage AddGroupGalleryImage (string groupId, string groupGalleryId, AddGroupGalleryImageRequest addGroupGalleryImageRequest)

Add Group Gallery Image

Adds an image to a Group gallery.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class AddGroupGalleryImageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrchat.com/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new GroupsApi(config);
            var groupId = grp_00000000-0000-0000-0000-000000000000;  // string | Must be a valid group ID.
            var groupGalleryId = ggal_00000000-0000-0000-0000-000000000000;  // string | Must be a valid group gallery ID.
            var addGroupGalleryImageRequest = new AddGroupGalleryImageRequest(); // AddGroupGalleryImageRequest | 

            try
            {
                // Add Group Gallery Image
                GroupGalleryImage result = apiInstance.AddGroupGalleryImage(groupId, groupGalleryId, addGroupGalleryImageRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.AddGroupGalleryImage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddGroupGalleryImageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add Group Gallery Image
    ApiResponse<GroupGalleryImage> response = apiInstance.AddGroupGalleryImageWithHttpInfo(groupId, groupGalleryId, addGroupGalleryImageRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupsApi.AddGroupGalleryImageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **string** | Must be a valid group ID. |  |
| **groupGalleryId** | **string** | Must be a valid group gallery ID. |  |
| **addGroupGalleryImageRequest** | [**AddGroupGalleryImageRequest**](AddGroupGalleryImageRequest.md) |  |  |

### Return type

[**GroupGalleryImage**](GroupGalleryImage.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a single GroupGalleryImage object. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |
| **404** | Error response when trying to perform operations on a non-existing group. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addgroupmemberrole"></a>
# **AddGroupMemberRole**
> List&lt;string&gt; AddGroupMemberRole (string groupId, string userId, string groupRoleId)

Add Role to GroupMember

Adds a Role to a Group Member

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class AddGroupMemberRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrchat.com/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new GroupsApi(config);
            var groupId = grp_00000000-0000-0000-0000-000000000000;  // string | Must be a valid group ID.
            var userId = "userId_example";  // string | Must be a valid user ID.
            var groupRoleId = grol_00000000-0000-0000-0000-000000000000;  // string | Must be a valid group role ID.

            try
            {
                // Add Role to GroupMember
                List<string> result = apiInstance.AddGroupMemberRole(groupId, userId, groupRoleId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.AddGroupMemberRole: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddGroupMemberRoleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add Role to GroupMember
    ApiResponse<List<string>> response = apiInstance.AddGroupMemberRoleWithHttpInfo(groupId, userId, groupRoleId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupsApi.AddGroupMemberRoleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **string** | Must be a valid group ID. |  |
| **userId** | **string** | Must be a valid user ID. |  |
| **groupRoleId** | **string** | Must be a valid group role ID. |  |

### Return type

**List<string>**

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a list of GroupRoleID objects. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |
| **404** | Error response when trying to perform operations on a non-existing group. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addgrouppost"></a>
# **AddGroupPost**
> GroupPost AddGroupPost (string groupId, CreateGroupPostRequest createGroupPostRequest)

Create a post in a Group

Create a post in a Group.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class AddGroupPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrchat.com/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new GroupsApi(config);
            var groupId = grp_00000000-0000-0000-0000-000000000000;  // string | Must be a valid group ID.
            var createGroupPostRequest = new CreateGroupPostRequest(); // CreateGroupPostRequest | 

            try
            {
                // Create a post in a Group
                GroupPost result = apiInstance.AddGroupPost(groupId, createGroupPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.AddGroupPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddGroupPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a post in a Group
    ApiResponse<GroupPost> response = apiInstance.AddGroupPostWithHttpInfo(groupId, createGroupPostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupsApi.AddGroupPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **string** | Must be a valid group ID. |  |
| **createGroupPostRequest** | [**CreateGroupPostRequest**](CreateGroupPostRequest.md) |  |  |

### Return type

[**GroupPost**](GroupPost.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a GroupPost object. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="bangroupmember"></a>
# **BanGroupMember**
> GroupMember BanGroupMember (string groupId, BanGroupMemberRequest banGroupMemberRequest)

Ban Group Member

Bans a user from a Group.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class BanGroupMemberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrchat.com/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new GroupsApi(config);
            var groupId = grp_00000000-0000-0000-0000-000000000000;  // string | Must be a valid group ID.
            var banGroupMemberRequest = new BanGroupMemberRequest(); // BanGroupMemberRequest | 

            try
            {
                // Ban Group Member
                GroupMember result = apiInstance.BanGroupMember(groupId, banGroupMemberRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.BanGroupMember: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BanGroupMemberWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Ban Group Member
    ApiResponse<GroupMember> response = apiInstance.BanGroupMemberWithHttpInfo(groupId, banGroupMemberRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupsApi.BanGroupMemberWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **string** | Must be a valid group ID. |  |
| **banGroupMemberRequest** | [**BanGroupMemberRequest**](BanGroupMemberRequest.md) |  |  |

### Return type

[**GroupMember**](GroupMember.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a list of GroupMember objects. |  -  |
| **400** | Bad request error response when banning a user |  -  |
| **401** | Error response due to missing auth cookie. |  -  |
| **404** | Error response when trying to perform operations on a non-existing group. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cancelgrouprequest"></a>
# **CancelGroupRequest**
> void CancelGroupRequest (string groupId)

Cancel Group Join Request

Cancels a request sent to join the group.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class CancelGroupRequestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrchat.com/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new GroupsApi(config);
            var groupId = grp_00000000-0000-0000-0000-000000000000;  // string | Must be a valid group ID.

            try
            {
                // Cancel Group Join Request
                apiInstance.CancelGroupRequest(groupId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.CancelGroupRequest: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CancelGroupRequestWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Cancel Group Join Request
    apiInstance.CancelGroupRequestWithHttpInfo(groupId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupsApi.CancelGroupRequestWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **string** | Must be a valid group ID. |  |

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
| **400** | You can&#39;t cancel a join request if you didn&#39;t request to join․ |  -  |
| **403** | Error response when trying to perform operations on a group you are not member of. |  -  |
| **404** | Error response when trying to perform operations on a non-existing group. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="creategroup"></a>
# **CreateGroup**
> Group CreateGroup (CreateGroupRequest createGroupRequest)

Create Group

Creates a Group and returns a Group object. **Requires VRC+ Subscription.**

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class CreateGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrchat.com/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new GroupsApi(config);
            var createGroupRequest = new CreateGroupRequest(); // CreateGroupRequest | 

            try
            {
                // Create Group
                Group result = apiInstance.CreateGroup(createGroupRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.CreateGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Group
    ApiResponse<Group> response = apiInstance.CreateGroupWithHttpInfo(createGroupRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupsApi.CreateGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createGroupRequest** | [**CreateGroupRequest**](CreateGroupRequest.md) |  |  |

### Return type

[**Group**](Group.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a single Group object. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="creategroupannouncement"></a>
# **CreateGroupAnnouncement**
> GroupAnnouncement CreateGroupAnnouncement (string groupId, CreateGroupAnnouncementRequest createGroupAnnouncementRequest)

Create Group Announcement

Creates an Announcement for a Group.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class CreateGroupAnnouncementExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrchat.com/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new GroupsApi(config);
            var groupId = grp_00000000-0000-0000-0000-000000000000;  // string | Must be a valid group ID.
            var createGroupAnnouncementRequest = new CreateGroupAnnouncementRequest(); // CreateGroupAnnouncementRequest | 

            try
            {
                // Create Group Announcement
                GroupAnnouncement result = apiInstance.CreateGroupAnnouncement(groupId, createGroupAnnouncementRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.CreateGroupAnnouncement: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateGroupAnnouncementWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Group Announcement
    ApiResponse<GroupAnnouncement> response = apiInstance.CreateGroupAnnouncementWithHttpInfo(groupId, createGroupAnnouncementRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupsApi.CreateGroupAnnouncementWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **string** | Must be a valid group ID. |  |
| **createGroupAnnouncementRequest** | [**CreateGroupAnnouncementRequest**](CreateGroupAnnouncementRequest.md) |  |  |

### Return type

[**GroupAnnouncement**](GroupAnnouncement.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a single GroupAnnouncement object. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |
| **404** | Error response when trying to perform operations on a non-existing group. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="creategroupgallery"></a>
# **CreateGroupGallery**
> GroupGallery CreateGroupGallery (string groupId, CreateGroupGalleryRequest createGroupGalleryRequest)

Create Group Gallery

Creates a gallery for a Group.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class CreateGroupGalleryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrchat.com/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new GroupsApi(config);
            var groupId = grp_00000000-0000-0000-0000-000000000000;  // string | Must be a valid group ID.
            var createGroupGalleryRequest = new CreateGroupGalleryRequest(); // CreateGroupGalleryRequest | 

            try
            {
                // Create Group Gallery
                GroupGallery result = apiInstance.CreateGroupGallery(groupId, createGroupGalleryRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.CreateGroupGallery: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateGroupGalleryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Group Gallery
    ApiResponse<GroupGallery> response = apiInstance.CreateGroupGalleryWithHttpInfo(groupId, createGroupGalleryRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupsApi.CreateGroupGalleryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **string** | Must be a valid group ID. |  |
| **createGroupGalleryRequest** | [**CreateGroupGalleryRequest**](CreateGroupGalleryRequest.md) |  |  |

### Return type

[**GroupGallery**](GroupGallery.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a single GroupGallery object. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |
| **404** | Error response when trying to perform operations on a non-existing group. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="creategroupinvite"></a>
# **CreateGroupInvite**
> void CreateGroupInvite (string groupId, CreateGroupInviteRequest createGroupInviteRequest)

Invite User to Group

Sends an invite to a user to join the group.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class CreateGroupInviteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrchat.com/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new GroupsApi(config);
            var groupId = grp_00000000-0000-0000-0000-000000000000;  // string | Must be a valid group ID.
            var createGroupInviteRequest = new CreateGroupInviteRequest(); // CreateGroupInviteRequest | 

            try
            {
                // Invite User to Group
                apiInstance.CreateGroupInvite(groupId, createGroupInviteRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.CreateGroupInvite: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateGroupInviteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Invite User to Group
    apiInstance.CreateGroupInviteWithHttpInfo(groupId, createGroupInviteRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupsApi.CreateGroupInviteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **string** | Must be a valid group ID. |  |
| **createGroupInviteRequest** | [**CreateGroupInviteRequest**](CreateGroupInviteRequest.md) |  |  |

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
| **200** | OK |  -  |
| **400** | Bad request error response when creating a group invite. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |
| **403** | Forbidden error response when creating a group invite. |  -  |
| **404** | Error response when trying to perform operations on a non-existing group. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="creategrouprole"></a>
# **CreateGroupRole**
> GroupRole CreateGroupRole (string groupId, CreateGroupRoleRequest createGroupRoleRequest)

Create GroupRole

Create a Group role.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class CreateGroupRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrchat.com/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new GroupsApi(config);
            var groupId = grp_00000000-0000-0000-0000-000000000000;  // string | Must be a valid group ID.
            var createGroupRoleRequest = new CreateGroupRoleRequest(); // CreateGroupRoleRequest | 

            try
            {
                // Create GroupRole
                GroupRole result = apiInstance.CreateGroupRole(groupId, createGroupRoleRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.CreateGroupRole: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateGroupRoleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create GroupRole
    ApiResponse<GroupRole> response = apiInstance.CreateGroupRoleWithHttpInfo(groupId, createGroupRoleRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupsApi.CreateGroupRoleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **string** | Must be a valid group ID. |  |
| **createGroupRoleRequest** | [**CreateGroupRoleRequest**](CreateGroupRoleRequest.md) |  |  |

### Return type

[**GroupRole**](GroupRole.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a single GroupRole object. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |
| **404** | Error response when trying to perform operations on a non-existing group. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletegroup"></a>
# **DeleteGroup**
> Success DeleteGroup (string groupId)

Delete Group

Deletes a Group.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class DeleteGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrchat.com/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new GroupsApi(config);
            var groupId = grp_00000000-0000-0000-0000-000000000000;  // string | Must be a valid group ID.

            try
            {
                // Delete Group
                Success result = apiInstance.DeleteGroup(groupId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.DeleteGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Group
    ApiResponse<Success> response = apiInstance.DeleteGroupWithHttpInfo(groupId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupsApi.DeleteGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **string** | Must be a valid group ID. |  |

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
| **200** | Successful response after deleting a Group. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |
| **404** | Error response when trying to perform operations on a non-existing group. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletegroupannouncement"></a>
# **DeleteGroupAnnouncement**
> Success DeleteGroupAnnouncement (string groupId)

Delete Group Announcement

Deletes the announcement for a Group.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class DeleteGroupAnnouncementExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrchat.com/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new GroupsApi(config);
            var groupId = grp_00000000-0000-0000-0000-000000000000;  // string | Must be a valid group ID.

            try
            {
                // Delete Group Announcement
                Success result = apiInstance.DeleteGroupAnnouncement(groupId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.DeleteGroupAnnouncement: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteGroupAnnouncementWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Group Announcement
    ApiResponse<Success> response = apiInstance.DeleteGroupAnnouncementWithHttpInfo(groupId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupsApi.DeleteGroupAnnouncementWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **string** | Must be a valid group ID. |  |

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
| **200** | Successful response after deleting/clearing the group announcement. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |
| **404** | Error response when trying to perform operations on a non-existing group. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletegroupgallery"></a>
# **DeleteGroupGallery**
> Success DeleteGroupGallery (string groupId, string groupGalleryId)

Delete Group Gallery

Deletes a gallery for a Group.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class DeleteGroupGalleryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrchat.com/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new GroupsApi(config);
            var groupId = grp_00000000-0000-0000-0000-000000000000;  // string | Must be a valid group ID.
            var groupGalleryId = ggal_00000000-0000-0000-0000-000000000000;  // string | Must be a valid group gallery ID.

            try
            {
                // Delete Group Gallery
                Success result = apiInstance.DeleteGroupGallery(groupId, groupGalleryId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.DeleteGroupGallery: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteGroupGalleryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Group Gallery
    ApiResponse<Success> response = apiInstance.DeleteGroupGalleryWithHttpInfo(groupId, groupGalleryId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupsApi.DeleteGroupGalleryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **string** | Must be a valid group ID. |  |
| **groupGalleryId** | **string** | Must be a valid group gallery ID. |  |

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
| **200** | Successful response after deleting a group gallery. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |
| **404** | Error response when trying to perform operations on a non-existing group. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletegroupgalleryimage"></a>
# **DeleteGroupGalleryImage**
> Success DeleteGroupGalleryImage (string groupId, string groupGalleryId, string groupGalleryImageId)

Delete Group Gallery Image

Deletes an image from a Group gallery.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class DeleteGroupGalleryImageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrchat.com/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new GroupsApi(config);
            var groupId = grp_00000000-0000-0000-0000-000000000000;  // string | Must be a valid group ID.
            var groupGalleryId = ggal_00000000-0000-0000-0000-000000000000;  // string | Must be a valid group gallery ID.
            var groupGalleryImageId = ggim_00000000-0000-0000-0000-000000000000;  // string | Must be a valid group gallery image ID.

            try
            {
                // Delete Group Gallery Image
                Success result = apiInstance.DeleteGroupGalleryImage(groupId, groupGalleryId, groupGalleryImageId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.DeleteGroupGalleryImage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteGroupGalleryImageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Group Gallery Image
    ApiResponse<Success> response = apiInstance.DeleteGroupGalleryImageWithHttpInfo(groupId, groupGalleryId, groupGalleryImageId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupsApi.DeleteGroupGalleryImageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **string** | Must be a valid group ID. |  |
| **groupGalleryId** | **string** | Must be a valid group gallery ID. |  |
| **groupGalleryImageId** | **string** | Must be a valid group gallery image ID. |  |

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
| **200** | Successful response after deleting a group gallery image. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |
| **403** | Error response when trying to delete a submission to a group&#39;s gallery when the user does not have permission to do so. |  -  |
| **404** | Error response when trying to perform operations on a non-existing group. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletegroupinvite"></a>
# **DeleteGroupInvite**
> void DeleteGroupInvite (string groupId, string userId)

Delete User Invite

Deletes an Group invite sent to a User

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class DeleteGroupInviteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrchat.com/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new GroupsApi(config);
            var groupId = grp_00000000-0000-0000-0000-000000000000;  // string | Must be a valid group ID.
            var userId = "userId_example";  // string | Must be a valid user ID.

            try
            {
                // Delete User Invite
                apiInstance.DeleteGroupInvite(groupId, userId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.DeleteGroupInvite: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteGroupInviteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete User Invite
    apiInstance.DeleteGroupInviteWithHttpInfo(groupId, userId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupsApi.DeleteGroupInviteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **string** | Must be a valid group ID. |  |
| **userId** | **string** | Must be a valid user ID. |  |

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
| **400** | Bad request error response when deleting a group invite |  -  |
| **401** | Error response due to missing auth cookie. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletegrouppost"></a>
# **DeleteGroupPost**
> Success DeleteGroupPost (string groupId, string notificationId)

Delete a Group post

Delete a Group post

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class DeleteGroupPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrchat.com/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new GroupsApi(config);
            var groupId = grp_00000000-0000-0000-0000-000000000000;  // string | Must be a valid group ID.
            var notificationId = "notificationId_example";  // string | Must be a valid notification ID.

            try
            {
                // Delete a Group post
                Success result = apiInstance.DeleteGroupPost(groupId, notificationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.DeleteGroupPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteGroupPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a Group post
    ApiResponse<Success> response = apiInstance.DeleteGroupPostWithHttpInfo(groupId, notificationId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupsApi.DeleteGroupPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **string** | Must be a valid group ID. |  |
| **notificationId** | **string** | Must be a valid notification ID. |  |

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
| **200** | Response after deleting a group post. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |
| **404** | Response after deleting a group post. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletegrouprole"></a>
# **DeleteGroupRole**
> List&lt;GroupRole&gt; DeleteGroupRole (string groupId, string groupRoleId)

Delete Group Role

Deletes a Group Role by ID and returns the remaining roles.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class DeleteGroupRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrchat.com/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new GroupsApi(config);
            var groupId = grp_00000000-0000-0000-0000-000000000000;  // string | Must be a valid group ID.
            var groupRoleId = grol_00000000-0000-0000-0000-000000000000;  // string | Must be a valid group role ID.

            try
            {
                // Delete Group Role
                List<GroupRole> result = apiInstance.DeleteGroupRole(groupId, groupRoleId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.DeleteGroupRole: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteGroupRoleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Group Role
    ApiResponse<List<GroupRole>> response = apiInstance.DeleteGroupRoleWithHttpInfo(groupId, groupRoleId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupsApi.DeleteGroupRoleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **string** | Must be a valid group ID. |  |
| **groupRoleId** | **string** | Must be a valid group role ID. |  |

### Return type

[**List&lt;GroupRole&gt;**](GroupRole.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a list of GroupRole objects. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |
| **404** | Error response when trying to perform operations on a group you are not member of. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgroup"></a>
# **GetGroup**
> Group GetGroup (string groupId, bool? includeRoles = null)

Get Group by ID

Returns a single Group by ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class GetGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrchat.com/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new GroupsApi(config);
            var groupId = grp_00000000-0000-0000-0000-000000000000;  // string | Must be a valid group ID.
            var includeRoles = true;  // bool? | Include roles for the Group object. Defaults to false. (optional) 

            try
            {
                // Get Group by ID
                Group result = apiInstance.GetGroup(groupId, includeRoles);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.GetGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Group by ID
    ApiResponse<Group> response = apiInstance.GetGroupWithHttpInfo(groupId, includeRoles);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupsApi.GetGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **string** | Must be a valid group ID. |  |
| **includeRoles** | **bool?** | Include roles for the Group object. Defaults to false. | [optional]  |

### Return type

[**Group**](Group.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a single Group object. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |
| **404** | Error response when trying to perform operations on a non-existing group. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgroupannouncements"></a>
# **GetGroupAnnouncements**
> GroupAnnouncement GetGroupAnnouncements (string groupId)

Get Group Announcement

Returns the announcement for a Group. If no announcement has been made, then it returns **empty object**.  If an announcement exists, then it will always return all fields except `imageId` and `imageUrl` which may be null.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class GetGroupAnnouncementsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrchat.com/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new GroupsApi(config);
            var groupId = grp_00000000-0000-0000-0000-000000000000;  // string | Must be a valid group ID.

            try
            {
                // Get Group Announcement
                GroupAnnouncement result = apiInstance.GetGroupAnnouncements(groupId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.GetGroupAnnouncements: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetGroupAnnouncementsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Group Announcement
    ApiResponse<GroupAnnouncement> response = apiInstance.GetGroupAnnouncementsWithHttpInfo(groupId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupsApi.GetGroupAnnouncementsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **string** | Must be a valid group ID. |  |

### Return type

[**GroupAnnouncement**](GroupAnnouncement.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a single GroupAnnouncement object. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |
| **404** | Error response when trying to perform operations on a non-existing group. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgroupauditlogs"></a>
# **GetGroupAuditLogs**
> PaginatedGroupAuditLogEntryList GetGroupAuditLogs (string groupId, int? n = null, int? offset = null, DateTime? startDate = null, DateTime? endDate = null)

Get Group Audit Logs

Returns a list of audit logs for a Group.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class GetGroupAuditLogsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrchat.com/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new GroupsApi(config);
            var groupId = grp_00000000-0000-0000-0000-000000000000;  // string | Must be a valid group ID.
            var n = 60;  // int? | The number of objects to return. (optional)  (default to 60)
            var offset = 56;  // int? | A zero-based offset from the default object sorting from where search results start. (optional) 
            var startDate = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | The start date of the search range. (optional) 
            var endDate = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | The end date of the search range. (optional) 

            try
            {
                // Get Group Audit Logs
                PaginatedGroupAuditLogEntryList result = apiInstance.GetGroupAuditLogs(groupId, n, offset, startDate, endDate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.GetGroupAuditLogs: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetGroupAuditLogsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Group Audit Logs
    ApiResponse<PaginatedGroupAuditLogEntryList> response = apiInstance.GetGroupAuditLogsWithHttpInfo(groupId, n, offset, startDate, endDate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupsApi.GetGroupAuditLogsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **string** | Must be a valid group ID. |  |
| **n** | **int?** | The number of objects to return. | [optional] [default to 60] |
| **offset** | **int?** | A zero-based offset from the default object sorting from where search results start. | [optional]  |
| **startDate** | **DateTime?** | The start date of the search range. | [optional]  |
| **endDate** | **DateTime?** | The end date of the search range. | [optional]  |

### Return type

[**PaginatedGroupAuditLogEntryList**](PaginatedGroupAuditLogEntryList.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a list of GroupAudit objects, wrapped in new pagination format. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |
| **404** | Error response when trying to perform operations on a non-existing group. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgroupbans"></a>
# **GetGroupBans**
> List&lt;GroupMember&gt; GetGroupBans (string groupId, int? n = null, int? offset = null)

Get Group Bans

Returns a list of banned users for a Group.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class GetGroupBansExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrchat.com/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new GroupsApi(config);
            var groupId = grp_00000000-0000-0000-0000-000000000000;  // string | Must be a valid group ID.
            var n = 60;  // int? | The number of objects to return. (optional)  (default to 60)
            var offset = 56;  // int? | A zero-based offset from the default object sorting from where search results start. (optional) 

            try
            {
                // Get Group Bans
                List<GroupMember> result = apiInstance.GetGroupBans(groupId, n, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.GetGroupBans: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetGroupBansWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Group Bans
    ApiResponse<List<GroupMember>> response = apiInstance.GetGroupBansWithHttpInfo(groupId, n, offset);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupsApi.GetGroupBansWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **string** | Must be a valid group ID. |  |
| **n** | **int?** | The number of objects to return. | [optional] [default to 60] |
| **offset** | **int?** | A zero-based offset from the default object sorting from where search results start. | [optional]  |

### Return type

[**List&lt;GroupMember&gt;**](GroupMember.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a list of GroupMember objects. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |
| **403** | Error response due to missing permissions. |  -  |
| **404** | Error response when trying to perform operations on a non-existing group. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgroupgalleryimages"></a>
# **GetGroupGalleryImages**
> List&lt;GroupGalleryImage&gt; GetGroupGalleryImages (string groupId, string groupGalleryId, int? n = null, int? offset = null, bool? approved = null)

Get Group Gallery Images

Returns a list of images for a Group gallery.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class GetGroupGalleryImagesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrchat.com/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new GroupsApi(config);
            var groupId = grp_00000000-0000-0000-0000-000000000000;  // string | Must be a valid group ID.
            var groupGalleryId = ggal_00000000-0000-0000-0000-000000000000;  // string | Must be a valid group gallery ID.
            var n = 60;  // int? | The number of objects to return. (optional)  (default to 60)
            var offset = 56;  // int? | A zero-based offset from the default object sorting from where search results start. (optional) 
            var approved = true;  // bool? | If specified, only returns images that have been approved or not approved. (optional) 

            try
            {
                // Get Group Gallery Images
                List<GroupGalleryImage> result = apiInstance.GetGroupGalleryImages(groupId, groupGalleryId, n, offset, approved);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.GetGroupGalleryImages: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetGroupGalleryImagesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Group Gallery Images
    ApiResponse<List<GroupGalleryImage>> response = apiInstance.GetGroupGalleryImagesWithHttpInfo(groupId, groupGalleryId, n, offset, approved);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupsApi.GetGroupGalleryImagesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **string** | Must be a valid group ID. |  |
| **groupGalleryId** | **string** | Must be a valid group gallery ID. |  |
| **n** | **int?** | The number of objects to return. | [optional] [default to 60] |
| **offset** | **int?** | A zero-based offset from the default object sorting from where search results start. | [optional]  |
| **approved** | **bool?** | If specified, only returns images that have been approved or not approved. | [optional]  |

### Return type

[**List&lt;GroupGalleryImage&gt;**](GroupGalleryImage.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a list of GroupGalleryImage objects. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |
| **404** | Error response when trying to perform operations on a non-existing group. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgroupinstances"></a>
# **GetGroupInstances**
> List&lt;GroupInstance&gt; GetGroupInstances (string groupId)

Get Group Instances

Returns a list of group instances

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class GetGroupInstancesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrchat.com/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new GroupsApi(config);
            var groupId = grp_00000000-0000-0000-0000-000000000000;  // string | Must be a valid group ID.

            try
            {
                // Get Group Instances
                List<GroupInstance> result = apiInstance.GetGroupInstances(groupId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.GetGroupInstances: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetGroupInstancesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Group Instances
    ApiResponse<List<GroupInstance>> response = apiInstance.GetGroupInstancesWithHttpInfo(groupId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupsApi.GetGroupInstancesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **string** | Must be a valid group ID. |  |

### Return type

[**List&lt;GroupInstance&gt;**](GroupInstance.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a list of GroupInstance objects. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |
| **404** | Error response when trying to perform operations on a non-existing group. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgroupinvites"></a>
# **GetGroupInvites**
> List&lt;GroupMember&gt; GetGroupInvites (string groupId, int? n = null, int? offset = null)

Get Group Invites Sent

Returns a list of members that have been invited to the Group.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class GetGroupInvitesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrchat.com/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new GroupsApi(config);
            var groupId = grp_00000000-0000-0000-0000-000000000000;  // string | Must be a valid group ID.
            var n = 60;  // int? | The number of objects to return. (optional)  (default to 60)
            var offset = 56;  // int? | A zero-based offset from the default object sorting from where search results start. (optional) 

            try
            {
                // Get Group Invites Sent
                List<GroupMember> result = apiInstance.GetGroupInvites(groupId, n, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.GetGroupInvites: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetGroupInvitesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Group Invites Sent
    ApiResponse<List<GroupMember>> response = apiInstance.GetGroupInvitesWithHttpInfo(groupId, n, offset);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupsApi.GetGroupInvitesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **string** | Must be a valid group ID. |  |
| **n** | **int?** | The number of objects to return. | [optional] [default to 60] |
| **offset** | **int?** | A zero-based offset from the default object sorting from where search results start. | [optional]  |

### Return type

[**List&lt;GroupMember&gt;**](GroupMember.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a list of GroupMember objects. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |
| **403** | Error response when trying to perform operations on a group you are not member of. |  -  |
| **404** | Error response when trying to perform operations on a non-existing group. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgroupmember"></a>
# **GetGroupMember**
> GroupLimitedMember GetGroupMember (string groupId, string userId)

Get Group Member

Returns a LimitedGroup Member.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class GetGroupMemberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrchat.com/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new GroupsApi(config);
            var groupId = grp_00000000-0000-0000-0000-000000000000;  // string | Must be a valid group ID.
            var userId = "userId_example";  // string | Must be a valid user ID.

            try
            {
                // Get Group Member
                GroupLimitedMember result = apiInstance.GetGroupMember(groupId, userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.GetGroupMember: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetGroupMemberWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Group Member
    ApiResponse<GroupLimitedMember> response = apiInstance.GetGroupMemberWithHttpInfo(groupId, userId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupsApi.GetGroupMemberWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **string** | Must be a valid group ID. |  |
| **userId** | **string** | Must be a valid user ID. |  |

### Return type

[**GroupLimitedMember**](GroupLimitedMember.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a list of GroupMember objects. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |
| **403** | Error response when trying to perform operations on a group you are not member of. |  -  |
| **404** | Error response when trying to perform operations on a non-existing group. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgroupmembers"></a>
# **GetGroupMembers**
> List&lt;GroupMember&gt; GetGroupMembers (string groupId, int? n = null, int? offset = null, GroupSearchSort? sort = null, string roleId = null)

List Group Members

Returns a List of all **other** Group Members. This endpoint will never return the user calling the endpoint. Information about the user calling the endpoint must be found in the `myMember` field of the Group object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class GetGroupMembersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrchat.com/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new GroupsApi(config);
            var groupId = grp_00000000-0000-0000-0000-000000000000;  // string | Must be a valid group ID.
            var n = 60;  // int? | The number of objects to return. (optional)  (default to 60)
            var offset = 56;  // int? | A zero-based offset from the default object sorting from where search results start. (optional) 
            var sort = (GroupSearchSort) "joinedAt:asc";  // GroupSearchSort? | The sort order of Group Member results (optional) 
            var roleId = "roleId_example";  // string | Only returns members with a specific groupRoleId (optional) 

            try
            {
                // List Group Members
                List<GroupMember> result = apiInstance.GetGroupMembers(groupId, n, offset, sort, roleId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.GetGroupMembers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetGroupMembersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Group Members
    ApiResponse<List<GroupMember>> response = apiInstance.GetGroupMembersWithHttpInfo(groupId, n, offset, sort, roleId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupsApi.GetGroupMembersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **string** | Must be a valid group ID. |  |
| **n** | **int?** | The number of objects to return. | [optional] [default to 60] |
| **offset** | **int?** | A zero-based offset from the default object sorting from where search results start. | [optional]  |
| **sort** | **GroupSearchSort?** | The sort order of Group Member results | [optional]  |
| **roleId** | **string** | Only returns members with a specific groupRoleId | [optional]  |

### Return type

[**List&lt;GroupMember&gt;**](GroupMember.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a list of GroupMember objects. |  -  |
| **400** | Error response when trying to search list of users with an invalid request. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |
| **404** | Error response when trying to perform operations on a non-existing group. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgrouppermissions"></a>
# **GetGroupPermissions**
> List&lt;GroupPermission&gt; GetGroupPermissions (string groupId)

List Group Permissions

Returns a List of all possible/available permissions for a Group.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class GetGroupPermissionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrchat.com/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new GroupsApi(config);
            var groupId = grp_00000000-0000-0000-0000-000000000000;  // string | Must be a valid group ID.

            try
            {
                // List Group Permissions
                List<GroupPermission> result = apiInstance.GetGroupPermissions(groupId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.GetGroupPermissions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetGroupPermissionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Group Permissions
    ApiResponse<List<GroupPermission>> response = apiInstance.GetGroupPermissionsWithHttpInfo(groupId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupsApi.GetGroupPermissionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **string** | Must be a valid group ID. |  |

### Return type

[**List&lt;GroupPermission&gt;**](GroupPermission.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a list of GroupPermission objects. |  -  |
| **400** | Error response when trying to search list of users with an invalid request. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |
| **404** | Error response when trying to perform operations on a non-existing group. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgrouppost"></a>
# **GetGroupPost**
> GroupPost GetGroupPost (string groupId, int? n = null, int? offset = null, bool? publicOnly = null)

Get posts from a Group

Get posts from a Group

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class GetGroupPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrchat.com/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new GroupsApi(config);
            var groupId = grp_00000000-0000-0000-0000-000000000000;  // string | Must be a valid group ID.
            var n = 60;  // int? | The number of objects to return. (optional)  (default to 60)
            var offset = 56;  // int? | A zero-based offset from the default object sorting from where search results start. (optional) 
            var publicOnly = true;  // bool? | See public posts only. (optional) 

            try
            {
                // Get posts from a Group
                GroupPost result = apiInstance.GetGroupPost(groupId, n, offset, publicOnly);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.GetGroupPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetGroupPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get posts from a Group
    ApiResponse<GroupPost> response = apiInstance.GetGroupPostWithHttpInfo(groupId, n, offset, publicOnly);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupsApi.GetGroupPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **string** | Must be a valid group ID. |  |
| **n** | **int?** | The number of objects to return. | [optional] [default to 60] |
| **offset** | **int?** | A zero-based offset from the default object sorting from where search results start. | [optional]  |
| **publicOnly** | **bool?** | See public posts only. | [optional]  |

### Return type

[**GroupPost**](GroupPost.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a GroupPost object. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgrouprequests"></a>
# **GetGroupRequests**
> List&lt;GroupMember&gt; GetGroupRequests (string groupId, int? n = null, int? offset = null, bool? blocked = null)

Get Group Join Requests

Returns a list of members that have requested to join the Group.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class GetGroupRequestsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrchat.com/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new GroupsApi(config);
            var groupId = grp_00000000-0000-0000-0000-000000000000;  // string | Must be a valid group ID.
            var n = 60;  // int? | The number of objects to return. (optional)  (default to 60)
            var offset = 56;  // int? | A zero-based offset from the default object sorting from where search results start. (optional) 
            var blocked = true;  // bool? | See blocked join requests (optional) 

            try
            {
                // Get Group Join Requests
                List<GroupMember> result = apiInstance.GetGroupRequests(groupId, n, offset, blocked);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.GetGroupRequests: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetGroupRequestsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Group Join Requests
    ApiResponse<List<GroupMember>> response = apiInstance.GetGroupRequestsWithHttpInfo(groupId, n, offset, blocked);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupsApi.GetGroupRequestsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **string** | Must be a valid group ID. |  |
| **n** | **int?** | The number of objects to return. | [optional] [default to 60] |
| **offset** | **int?** | A zero-based offset from the default object sorting from where search results start. | [optional]  |
| **blocked** | **bool?** | See blocked join requests | [optional]  |

### Return type

[**List&lt;GroupMember&gt;**](GroupMember.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a list of GroupMember objects. |  -  |
| **400** | Bad request error response when responding to a group join request |  -  |
| **403** | Error response when trying to perform operations on a group you are not member of. |  -  |
| **404** | Error response when trying to perform operations on a non-existing group. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgrouproles"></a>
# **GetGroupRoles**
> List&lt;GroupRole&gt; GetGroupRoles (string groupId)

Get Group Roles

Returns a Group Role by ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class GetGroupRolesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrchat.com/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new GroupsApi(config);
            var groupId = grp_00000000-0000-0000-0000-000000000000;  // string | Must be a valid group ID.

            try
            {
                // Get Group Roles
                List<GroupRole> result = apiInstance.GetGroupRoles(groupId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.GetGroupRoles: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetGroupRolesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Group Roles
    ApiResponse<List<GroupRole>> response = apiInstance.GetGroupRolesWithHttpInfo(groupId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupsApi.GetGroupRolesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **string** | Must be a valid group ID. |  |

### Return type

[**List&lt;GroupRole&gt;**](GroupRole.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a list of GroupRole objects. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |
| **404** | Error response when trying to perform operations on a non-existing group. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="joingroup"></a>
# **JoinGroup**
> GroupMember JoinGroup (string groupId)

Join Group

Join a Group by ID and returns the member object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class JoinGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrchat.com/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new GroupsApi(config);
            var groupId = grp_00000000-0000-0000-0000-000000000000;  // string | Must be a valid group ID.

            try
            {
                // Join Group
                GroupMember result = apiInstance.JoinGroup(groupId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.JoinGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the JoinGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Join Group
    ApiResponse<GroupMember> response = apiInstance.JoinGroupWithHttpInfo(groupId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupsApi.JoinGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **string** | Must be a valid group ID. |  |

### Return type

[**GroupMember**](GroupMember.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a list of GroupMember objects. |  -  |
| **400** | Error response when trying to join a group that the user is already a member of. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |
| **404** | Error response when trying to perform operations on a non-existing group. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="kickgroupmember"></a>
# **KickGroupMember**
> void KickGroupMember (string groupId, string userId)

Kick Group Member

Kicks a Group Member from the Group. The current user must have the \"Remove Group Members\" permission.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class KickGroupMemberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrchat.com/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new GroupsApi(config);
            var groupId = grp_00000000-0000-0000-0000-000000000000;  // string | Must be a valid group ID.
            var userId = "userId_example";  // string | Must be a valid user ID.

            try
            {
                // Kick Group Member
                apiInstance.KickGroupMember(groupId, userId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.KickGroupMember: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the KickGroupMemberWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Kick Group Member
    apiInstance.KickGroupMemberWithHttpInfo(groupId, userId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupsApi.KickGroupMemberWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **string** | Must be a valid group ID. |  |
| **userId** | **string** | Must be a valid user ID. |  |

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
| **403** | Error response when trying to perform operations on a group you are not member of. |  -  |
| **404** | Error response when trying to perform operations on a non-existing group. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="leavegroup"></a>
# **LeaveGroup**
> void LeaveGroup (string groupId)

Leave Group

Leave a group by ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class LeaveGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrchat.com/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new GroupsApi(config);
            var groupId = grp_00000000-0000-0000-0000-000000000000;  // string | Must be a valid group ID.

            try
            {
                // Leave Group
                apiInstance.LeaveGroup(groupId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.LeaveGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LeaveGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Leave Group
    apiInstance.LeaveGroupWithHttpInfo(groupId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupsApi.LeaveGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **string** | Must be a valid group ID. |  |

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
| **403** | Error response when trying to perform operations on a group you are not member of. |  -  |
| **404** | Error response when trying to perform operations on a non-existing group. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removegroupmemberrole"></a>
# **RemoveGroupMemberRole**
> List&lt;string&gt; RemoveGroupMemberRole (string groupId, string userId, string groupRoleId)

Remove Role from GroupMember

Removes a Role from a Group Member

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class RemoveGroupMemberRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrchat.com/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new GroupsApi(config);
            var groupId = grp_00000000-0000-0000-0000-000000000000;  // string | Must be a valid group ID.
            var userId = "userId_example";  // string | Must be a valid user ID.
            var groupRoleId = grol_00000000-0000-0000-0000-000000000000;  // string | Must be a valid group role ID.

            try
            {
                // Remove Role from GroupMember
                List<string> result = apiInstance.RemoveGroupMemberRole(groupId, userId, groupRoleId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.RemoveGroupMemberRole: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RemoveGroupMemberRoleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove Role from GroupMember
    ApiResponse<List<string>> response = apiInstance.RemoveGroupMemberRoleWithHttpInfo(groupId, userId, groupRoleId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupsApi.RemoveGroupMemberRoleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **string** | Must be a valid group ID. |  |
| **userId** | **string** | Must be a valid user ID. |  |
| **groupRoleId** | **string** | Must be a valid group role ID. |  |

### Return type

**List<string>**

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a list of GroupRoleID objects. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |
| **404** | Error response when trying to perform operations on a non-existing group. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="respondgroupjoinrequest"></a>
# **RespondGroupJoinRequest**
> void RespondGroupJoinRequest (string groupId, string userId, RespondGroupJoinRequest respondGroupJoinRequest)

Respond Group Join request

Responds to a Group Join Request with Accept/Deny

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class RespondGroupJoinRequestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrchat.com/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new GroupsApi(config);
            var groupId = grp_00000000-0000-0000-0000-000000000000;  // string | Must be a valid group ID.
            var userId = "userId_example";  // string | Must be a valid user ID.
            var respondGroupJoinRequest = new RespondGroupJoinRequest(); // RespondGroupJoinRequest | 

            try
            {
                // Respond Group Join request
                apiInstance.RespondGroupJoinRequest(groupId, userId, respondGroupJoinRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.RespondGroupJoinRequest: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RespondGroupJoinRequestWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Respond Group Join request
    apiInstance.RespondGroupJoinRequestWithHttpInfo(groupId, userId, respondGroupJoinRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupsApi.RespondGroupJoinRequestWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **string** | Must be a valid group ID. |  |
| **userId** | **string** | Must be a valid user ID. |  |
| **respondGroupJoinRequest** | [**RespondGroupJoinRequest**](RespondGroupJoinRequest.md) |  |  |

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
| **200** | OK |  -  |
| **401** | Error response due to missing auth cookie. |  -  |
| **404** | Error response when trying to perform operations on a non-existing group. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchgroups"></a>
# **SearchGroups**
> List&lt;LimitedGroup&gt; SearchGroups (string query = null, int? offset = null, int? n = null)

Search Group

Searches Groups by name or shortCode

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class SearchGroupsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrchat.com/api/1";
            var apiInstance = new GroupsApi(config);
            var query = "query_example";  // string | Query to search for, can be either Group Name or Group shortCode (optional) 
            var offset = 56;  // int? | A zero-based offset from the default object sorting from where search results start. (optional) 
            var n = 60;  // int? | The number of objects to return. (optional)  (default to 60)

            try
            {
                // Search Group
                List<LimitedGroup> result = apiInstance.SearchGroups(query, offset, n);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.SearchGroups: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SearchGroupsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search Group
    ApiResponse<List<LimitedGroup>> response = apiInstance.SearchGroupsWithHttpInfo(query, offset, n);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupsApi.SearchGroupsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **query** | **string** | Query to search for, can be either Group Name or Group shortCode | [optional]  |
| **offset** | **int?** | A zero-based offset from the default object sorting from where search results start. | [optional]  |
| **n** | **int?** | The number of objects to return. | [optional] [default to 60] |

### Return type

[**List&lt;LimitedGroup&gt;**](LimitedGroup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a list of LimitedGroup objects. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="unbangroupmember"></a>
# **UnbanGroupMember**
> GroupMember UnbanGroupMember (string groupId, string userId)

Unban Group Member

Unbans a user from a Group.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class UnbanGroupMemberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrchat.com/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new GroupsApi(config);
            var groupId = grp_00000000-0000-0000-0000-000000000000;  // string | Must be a valid group ID.
            var userId = "userId_example";  // string | Must be a valid user ID.

            try
            {
                // Unban Group Member
                GroupMember result = apiInstance.UnbanGroupMember(groupId, userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.UnbanGroupMember: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UnbanGroupMemberWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Unban Group Member
    ApiResponse<GroupMember> response = apiInstance.UnbanGroupMemberWithHttpInfo(groupId, userId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupsApi.UnbanGroupMemberWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **string** | Must be a valid group ID. |  |
| **userId** | **string** | Must be a valid user ID. |  |

### Return type

[**GroupMember**](GroupMember.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a list of GroupMember objects. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |
| **404** | Error response when trying to perform operations on a non-existing group. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updategroup"></a>
# **UpdateGroup**
> Group UpdateGroup (string groupId, UpdateGroupRequest updateGroupRequest = null)

Update Group

Updates a Group and returns it.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class UpdateGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrchat.com/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new GroupsApi(config);
            var groupId = grp_00000000-0000-0000-0000-000000000000;  // string | Must be a valid group ID.
            var updateGroupRequest = new UpdateGroupRequest(); // UpdateGroupRequest |  (optional) 

            try
            {
                // Update Group
                Group result = apiInstance.UpdateGroup(groupId, updateGroupRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.UpdateGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Group
    ApiResponse<Group> response = apiInstance.UpdateGroupWithHttpInfo(groupId, updateGroupRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupsApi.UpdateGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **string** | Must be a valid group ID. |  |
| **updateGroupRequest** | [**UpdateGroupRequest**](UpdateGroupRequest.md) |  | [optional]  |

### Return type

[**Group**](Group.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a single Group object. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |
| **404** | Error response when trying to perform operations on a non-existing group. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updategroupgallery"></a>
# **UpdateGroupGallery**
> GroupGallery UpdateGroupGallery (string groupId, string groupGalleryId, UpdateGroupGalleryRequest updateGroupGalleryRequest = null)

Update Group Gallery

Updates a gallery for a Group.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class UpdateGroupGalleryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrchat.com/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new GroupsApi(config);
            var groupId = grp_00000000-0000-0000-0000-000000000000;  // string | Must be a valid group ID.
            var groupGalleryId = ggal_00000000-0000-0000-0000-000000000000;  // string | Must be a valid group gallery ID.
            var updateGroupGalleryRequest = new UpdateGroupGalleryRequest(); // UpdateGroupGalleryRequest |  (optional) 

            try
            {
                // Update Group Gallery
                GroupGallery result = apiInstance.UpdateGroupGallery(groupId, groupGalleryId, updateGroupGalleryRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.UpdateGroupGallery: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateGroupGalleryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Group Gallery
    ApiResponse<GroupGallery> response = apiInstance.UpdateGroupGalleryWithHttpInfo(groupId, groupGalleryId, updateGroupGalleryRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupsApi.UpdateGroupGalleryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **string** | Must be a valid group ID. |  |
| **groupGalleryId** | **string** | Must be a valid group gallery ID. |  |
| **updateGroupGalleryRequest** | [**UpdateGroupGalleryRequest**](UpdateGroupGalleryRequest.md) |  | [optional]  |

### Return type

[**GroupGallery**](GroupGallery.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a single GroupGallery object. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |
| **404** | Error response when trying to perform operations on a non-existing group. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updategroupmember"></a>
# **UpdateGroupMember**
> GroupLimitedMember UpdateGroupMember (string groupId, string userId, UpdateGroupMemberRequest updateGroupMemberRequest = null)

Update Group Member

Updates a Group Member

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class UpdateGroupMemberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrchat.com/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new GroupsApi(config);
            var groupId = grp_00000000-0000-0000-0000-000000000000;  // string | Must be a valid group ID.
            var userId = "userId_example";  // string | Must be a valid user ID.
            var updateGroupMemberRequest = new UpdateGroupMemberRequest(); // UpdateGroupMemberRequest |  (optional) 

            try
            {
                // Update Group Member
                GroupLimitedMember result = apiInstance.UpdateGroupMember(groupId, userId, updateGroupMemberRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.UpdateGroupMember: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateGroupMemberWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Group Member
    ApiResponse<GroupLimitedMember> response = apiInstance.UpdateGroupMemberWithHttpInfo(groupId, userId, updateGroupMemberRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupsApi.UpdateGroupMemberWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **string** | Must be a valid group ID. |  |
| **userId** | **string** | Must be a valid user ID. |  |
| **updateGroupMemberRequest** | [**UpdateGroupMemberRequest**](UpdateGroupMemberRequest.md) |  | [optional]  |

### Return type

[**GroupLimitedMember**](GroupLimitedMember.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a list of GroupMember objects. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |
| **404** | Error response when trying to perform operations on a non-existing group. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updategrouppost"></a>
# **UpdateGroupPost**
> GroupPost UpdateGroupPost (string groupId, string notificationId, CreateGroupPostRequest createGroupPostRequest)

Edits a Group post

Edits a Group post

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class UpdateGroupPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrchat.com/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new GroupsApi(config);
            var groupId = grp_00000000-0000-0000-0000-000000000000;  // string | Must be a valid group ID.
            var notificationId = "notificationId_example";  // string | Must be a valid notification ID.
            var createGroupPostRequest = new CreateGroupPostRequest(); // CreateGroupPostRequest | 

            try
            {
                // Edits a Group post
                GroupPost result = apiInstance.UpdateGroupPost(groupId, notificationId, createGroupPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.UpdateGroupPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateGroupPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Edits a Group post
    ApiResponse<GroupPost> response = apiInstance.UpdateGroupPostWithHttpInfo(groupId, notificationId, createGroupPostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupsApi.UpdateGroupPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **string** | Must be a valid group ID. |  |
| **notificationId** | **string** | Must be a valid notification ID. |  |
| **createGroupPostRequest** | [**CreateGroupPostRequest**](CreateGroupPostRequest.md) |  |  |

### Return type

[**GroupPost**](GroupPost.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a GroupPost object. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |
| **404** | Response after deleting a group post. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updategrouprole"></a>
# **UpdateGroupRole**
> List&lt;GroupRole&gt; UpdateGroupRole (string groupId, string groupRoleId, UpdateGroupRoleRequest updateGroupRoleRequest = null)

Update Group Role

Updates a group role by ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class UpdateGroupRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrchat.com/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new GroupsApi(config);
            var groupId = grp_00000000-0000-0000-0000-000000000000;  // string | Must be a valid group ID.
            var groupRoleId = grol_00000000-0000-0000-0000-000000000000;  // string | Must be a valid group role ID.
            var updateGroupRoleRequest = new UpdateGroupRoleRequest(); // UpdateGroupRoleRequest |  (optional) 

            try
            {
                // Update Group Role
                List<GroupRole> result = apiInstance.UpdateGroupRole(groupId, groupRoleId, updateGroupRoleRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.UpdateGroupRole: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateGroupRoleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Group Role
    ApiResponse<List<GroupRole>> response = apiInstance.UpdateGroupRoleWithHttpInfo(groupId, groupRoleId, updateGroupRoleRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupsApi.UpdateGroupRoleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **string** | Must be a valid group ID. |  |
| **groupRoleId** | **string** | Must be a valid group role ID. |  |
| **updateGroupRoleRequest** | [**UpdateGroupRoleRequest**](UpdateGroupRoleRequest.md) |  | [optional]  |

### Return type

[**List&lt;GroupRole&gt;**](GroupRole.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a list of GroupRole objects. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

