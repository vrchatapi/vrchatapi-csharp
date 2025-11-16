# VRChat.API.Api.MiscellaneousApi

All URIs are relative to *https://api.vrchat.cloud/api/1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreatePermission**](MiscellaneousApi.md#createpermission) | **POST** /permissions | Create Permission |
| [**DeletePermission**](MiscellaneousApi.md#deletepermission) | **DELETE** /permissions/{permissionId} | Delete Permission |
| [**GetAssignedPermissions**](MiscellaneousApi.md#getassignedpermissions) | **GET** /auth/permissions | Get Assigned Permissions |
| [**GetCSS**](MiscellaneousApi.md#getcss) | **GET** /css/app.css | Download CSS |
| [**GetConfig**](MiscellaneousApi.md#getconfig) | **GET** /config | Fetch API Config |
| [**GetCurrentOnlineUsers**](MiscellaneousApi.md#getcurrentonlineusers) | **GET** /visits | Current Online Users |
| [**GetHealth**](MiscellaneousApi.md#gethealth) | **GET** /health | Check API Health |
| [**GetInfoPush**](MiscellaneousApi.md#getinfopush) | **GET** /infoPush | Show Information Notices |
| [**GetJavaScript**](MiscellaneousApi.md#getjavascript) | **GET** /js/app.js | Download JavaScript |
| [**GetPermission**](MiscellaneousApi.md#getpermission) | **GET** /permissions/{permissionId} | Get Permission |
| [**GetPermissions**](MiscellaneousApi.md#getpermissions) | **GET** /permissions | Get Permissions |
| [**GetSystemTime**](MiscellaneousApi.md#getsystemtime) | **GET** /time | Current System Time |
| [**UpdatePermission**](MiscellaneousApi.md#updatepermission) | **PUT** /permissions/{permissionId} | Update Permission |

<a name="createpermission"></a>
# **CreatePermission**
> Permission CreatePermission (int? n = null, int? offset = null, string ownerId = null, CreatePermissionRequest createPermissionRequest = null)

Create Permission

**REQUIRES ADMIN CREDENTIALS**. Creates and returns a new Permission. The permission will by default be owned by the sender of the request unless otherwise specified.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class CreatePermissionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vrchat.cloud/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new MiscellaneousApi(config);
            var n = 60;  // int? | The number of objects to return. (optional)  (default to 60)
            var offset = 56;  // int? | A zero-based offset from the default object sorting from where search results start. (optional) 
            var ownerId = "ownerId_example";  // string | Owner of the Permission, MUST be valid UserID. (optional) 
            var createPermissionRequest = new CreatePermissionRequest(); // CreatePermissionRequest |  (optional) 

            try
            {
                // Create Permission
                Permission result = apiInstance.CreatePermission(n, offset, ownerId, createPermissionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MiscellaneousApi.CreatePermission: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreatePermissionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Permission
    ApiResponse<Permission> response = apiInstance.CreatePermissionWithHttpInfo(n, offset, ownerId, createPermissionRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MiscellaneousApi.CreatePermissionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **n** | **int?** | The number of objects to return. | [optional] [default to 60] |
| **offset** | **int?** | A zero-based offset from the default object sorting from where search results start. | [optional]  |
| **ownerId** | **string** | Owner of the Permission, MUST be valid UserID. | [optional]  |
| **createPermissionRequest** | [**CreatePermissionRequest**](CreatePermissionRequest.md) |  | [optional]  |

### Return type

[**Permission**](Permission.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a single Permission object. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |
| **403** | Error response due to missing Administrator credentials. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletepermission"></a>
# **DeletePermission**
> Permission DeletePermission (string permissionId)

Delete Permission

**REQUIRES ADMIN CREDENTIALS**. Deletes a permission.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class DeletePermissionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vrchat.cloud/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new MiscellaneousApi(config);
            var permissionId = "permissionId_example";  // string | Must be a valid permission ID.

            try
            {
                // Delete Permission
                Permission result = apiInstance.DeletePermission(permissionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MiscellaneousApi.DeletePermission: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeletePermissionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Permission
    ApiResponse<Permission> response = apiInstance.DeletePermissionWithHttpInfo(permissionId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MiscellaneousApi.DeletePermissionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **permissionId** | **string** | Must be a valid permission ID. |  |

### Return type

[**Permission**](Permission.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a single Permission object. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |
| **403** | Error response due to missing Administrator credentials. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getassignedpermissions"></a>
# **GetAssignedPermissions**
> List&lt;Permission&gt; GetAssignedPermissions ()

Get Assigned Permissions

Returns a list of all permissions currently granted by the user. Permissions are assigned e.g. by subscribing to VRC+.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class GetAssignedPermissionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vrchat.cloud/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new MiscellaneousApi(config);

            try
            {
                // Get Assigned Permissions
                List<Permission> result = apiInstance.GetAssignedPermissions();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MiscellaneousApi.GetAssignedPermissions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAssignedPermissionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Assigned Permissions
    ApiResponse<List<Permission>> response = apiInstance.GetAssignedPermissionsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MiscellaneousApi.GetAssignedPermissionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;Permission&gt;**](Permission.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a list of Permission objects. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcss"></a>
# **GetCSS**
> string GetCSS (string variant = null, string branch = null)

Download CSS

Fetches the CSS code to the frontend React website.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class GetCSSExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vrchat.cloud/api/1";
            var apiInstance = new MiscellaneousApi(config);
            var variant = "public";  // string | Specifies which `variant` of the site. Public is the end-user site, while `internal` is the staff-only site with special pages for moderation and management. (optional)  (default to public)
            var branch = "\"main\"";  // string | Specifies which git branch the site should load frontend source code from. (optional)  (default to "main")

            try
            {
                // Download CSS
                string result = apiInstance.GetCSS(variant, branch);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MiscellaneousApi.GetCSS: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCSSWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Download CSS
    ApiResponse<string> response = apiInstance.GetCSSWithHttpInfo(variant, branch);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MiscellaneousApi.GetCSSWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **variant** | **string** | Specifies which &#x60;variant&#x60; of the site. Public is the end-user site, while &#x60;internal&#x60; is the staff-only site with special pages for moderation and management. | [optional] [default to public] |
| **branch** | **string** | Specifies which git branch the site should load frontend source code from. | [optional] [default to &quot;main&quot;] |

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/css, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | **Note:** VRChat uses 302 Redirect to Cloudfront. The implementing library **must** support and follow redirects natively. |  -  |
| **400** | Error response when trying to download non-public and non-main JavaScript or CSS without Admin Credentials. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getconfig"></a>
# **GetConfig**
> APIConfig GetConfig ()

Fetch API Config

API config contains configuration that the clients needs to work properly.  Currently the most important value here is `clientApiKey` which is used for all other API endpoints.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class GetConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vrchat.cloud/api/1";
            var apiInstance = new MiscellaneousApi(config);

            try
            {
                // Fetch API Config
                APIConfig result = apiInstance.GetConfig();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MiscellaneousApi.GetConfig: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetConfigWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Fetch API Config
    ApiResponse<APIConfig> response = apiInstance.GetConfigWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MiscellaneousApi.GetConfigWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**APIConfig**](APIConfig.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the API&#39;s config. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcurrentonlineusers"></a>
# **GetCurrentOnlineUsers**
> int GetCurrentOnlineUsers ()

Current Online Users

Returns the current number of online users.  **NOTE:** The response type is not a JSON object, but a simple JSON integer.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class GetCurrentOnlineUsersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vrchat.cloud/api/1";
            var apiInstance = new MiscellaneousApi(config);

            try
            {
                // Current Online Users
                int result = apiInstance.GetCurrentOnlineUsers();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MiscellaneousApi.GetCurrentOnlineUsers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCurrentOnlineUsersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Current Online Users
    ApiResponse<int> response = apiInstance.GetCurrentOnlineUsersWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MiscellaneousApi.GetCurrentOnlineUsersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**int**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gethealth"></a>
# **GetHealth**
> APIHealth GetHealth ()

Check API Health

~~Gets the overall health status, the server name, and the current build version tag of the API.~~  **DEPRECATED:** VRChat has suddenly restricted this endpoint for unknown reasons, and now always return 401 Unauthorized.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class GetHealthExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vrchat.cloud/api/1";
            var apiInstance = new MiscellaneousApi(config);

            try
            {
                // Check API Health
                APIHealth result = apiInstance.GetHealth();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MiscellaneousApi.GetHealth: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetHealthWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Check API Health
    ApiResponse<APIHealth> response = apiInstance.GetHealthWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MiscellaneousApi.GetHealthWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**APIHealth**](APIHealth.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the API&#39;s health. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinfopush"></a>
# **GetInfoPush**
> List&lt;InfoPush&gt; GetInfoPush (string require = null, string include = null)

Show Information Notices

IPS (Info Push System) is a system for VRChat to push out dynamic information to the client. This is primarily used by the Quick-Menu info banners, but can also be used to e.g. alert you to update your game to the latest version.  `include` is used to query what Information Pushes should be included in the response. If include is missing or empty, then no notices will normally be returned. This is an \"any of\" search.  `require` is used to limit what Information Pushes should be included in the response. This is usually used in combination with `include`, and is an \"all of\" search.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class GetInfoPushExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vrchat.cloud/api/1";
            var apiInstance = new MiscellaneousApi(config);
            var require = "require_example";  // string | Tags to include (comma-separated). All of the tags needs to be present. (optional) 
            var include = "include_example";  // string | Tags to include (comma-separated). Any of the tags needs to be present. (optional) 

            try
            {
                // Show Information Notices
                List<InfoPush> result = apiInstance.GetInfoPush(require, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MiscellaneousApi.GetInfoPush: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetInfoPushWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Show Information Notices
    ApiResponse<List<InfoPush>> response = apiInstance.GetInfoPushWithHttpInfo(require, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MiscellaneousApi.GetInfoPushWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **require** | **string** | Tags to include (comma-separated). All of the tags needs to be present. | [optional]  |
| **include** | **string** | Tags to include (comma-separated). Any of the tags needs to be present. | [optional]  |

### Return type

[**List&lt;InfoPush&gt;**](InfoPush.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a list of InfoPush objects. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getjavascript"></a>
# **GetJavaScript**
> string GetJavaScript (string variant = null, string branch = null)

Download JavaScript

Fetches the JavaScript code to the frontend React website.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class GetJavaScriptExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vrchat.cloud/api/1";
            var apiInstance = new MiscellaneousApi(config);
            var variant = "public";  // string | Specifies which `variant` of the site. Public is the end-user site, while `internal` is the staff-only site with special pages for moderation and management. (optional)  (default to public)
            var branch = "\"main\"";  // string | Specifies which git branch the site should load frontend source code from. (optional)  (default to "main")

            try
            {
                // Download JavaScript
                string result = apiInstance.GetJavaScript(variant, branch);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MiscellaneousApi.GetJavaScript: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetJavaScriptWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Download JavaScript
    ApiResponse<string> response = apiInstance.GetJavaScriptWithHttpInfo(variant, branch);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MiscellaneousApi.GetJavaScriptWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **variant** | **string** | Specifies which &#x60;variant&#x60; of the site. Public is the end-user site, while &#x60;internal&#x60; is the staff-only site with special pages for moderation and management. | [optional] [default to public] |
| **branch** | **string** | Specifies which git branch the site should load frontend source code from. | [optional] [default to &quot;main&quot;] |

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/javascript, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | **Note:** VRChat uses 302 Redirect to Cloudfront. The implementing library **must** support and follow redirects natively. |  -  |
| **400** | Error response when trying to download non-public and non-main JavaScript or CSS without Admin Credentials. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpermission"></a>
# **GetPermission**
> Permission GetPermission (string permissionId)

Get Permission

Returns a single permission. This endpoint is pretty useless, as it returns the exact same information as `/auth/permissions`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class GetPermissionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vrchat.cloud/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new MiscellaneousApi(config);
            var permissionId = "permissionId_example";  // string | Must be a valid permission ID.

            try
            {
                // Get Permission
                Permission result = apiInstance.GetPermission(permissionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MiscellaneousApi.GetPermission: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPermissionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Permission
    ApiResponse<Permission> response = apiInstance.GetPermissionWithHttpInfo(permissionId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MiscellaneousApi.GetPermissionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **permissionId** | **string** | Must be a valid permission ID. |  |

### Return type

[**Permission**](Permission.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a single Permission object. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpermissions"></a>
# **GetPermissions**
> List&lt;Permission&gt; GetPermissions ()

Get Permissions

**REQUIRES ADMIN CREDENTIALS**. Returns a list of all existing permissions, just like `/users` with empty search would.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class GetPermissionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vrchat.cloud/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new MiscellaneousApi(config);

            try
            {
                // Get Permissions
                List<Permission> result = apiInstance.GetPermissions();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MiscellaneousApi.GetPermissions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPermissionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Permissions
    ApiResponse<List<Permission>> response = apiInstance.GetPermissionsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MiscellaneousApi.GetPermissionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;Permission&gt;**](Permission.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a list of Permission objects. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |
| **403** | Error response due to missing Administrator credentials. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsystemtime"></a>
# **GetSystemTime**
> DateTime GetSystemTime ()

Current System Time

Returns the current time of the API server.  **NOTE:** The response type is not a JSON object, but a simple JSON string.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class GetSystemTimeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vrchat.cloud/api/1";
            var apiInstance = new MiscellaneousApi(config);

            try
            {
                // Current System Time
                DateTime result = apiInstance.GetSystemTime();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MiscellaneousApi.GetSystemTime: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSystemTimeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Current System Time
    ApiResponse<DateTime> response = apiInstance.GetSystemTimeWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MiscellaneousApi.GetSystemTimeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**DateTime**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatepermission"></a>
# **UpdatePermission**
> Permission UpdatePermission (string permissionId, UpdatePermissionRequest updatePermissionRequest = null)

Update Permission

**REQUIRES ADMIN CREDENTIALS**. Updates the info on a permission.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class UpdatePermissionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vrchat.cloud/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new MiscellaneousApi(config);
            var permissionId = "permissionId_example";  // string | Must be a valid permission ID.
            var updatePermissionRequest = new UpdatePermissionRequest(); // UpdatePermissionRequest |  (optional) 

            try
            {
                // Update Permission
                Permission result = apiInstance.UpdatePermission(permissionId, updatePermissionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MiscellaneousApi.UpdatePermission: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdatePermissionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Permission
    ApiResponse<Permission> response = apiInstance.UpdatePermissionWithHttpInfo(permissionId, updatePermissionRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MiscellaneousApi.UpdatePermissionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **permissionId** | **string** | Must be a valid permission ID. |  |
| **updatePermissionRequest** | [**UpdatePermissionRequest**](UpdatePermissionRequest.md) |  | [optional]  |

### Return type

[**Permission**](Permission.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a single Permission object. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |
| **403** | Error response due to missing Administrator credentials. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

