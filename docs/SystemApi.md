# io.github.vrchatapi.Api.SystemApi

All URIs are relative to *https://api.vrchat.cloud/api/1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCSS**](SystemApi.md#getcss) | **GET** /css/app.js | Download Frontend CSS
[**GetConfig**](SystemApi.md#getconfig) | **GET** /config | Fetch API Config
[**GetCurrentOnlineUsers**](SystemApi.md#getcurrentonlineusers) | **GET** /visits | Current Online Users
[**GetHealth**](SystemApi.md#gethealth) | **GET** /health | Check API Health
[**GetJavaScript**](SystemApi.md#getjavascript) | **GET** /js/app.js | Download Frontend JavaScript
[**GetSystemTime**](SystemApi.md#getsystemtime) | **GET** /time | Current System Time



## GetCSS

> string GetCSS (string variant = null, string branch = null)

Download Frontend CSS

Fetches the CSS code to the frontend React website.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using io.github.vrchatapi.Api;
using io.github.vrchatapi.Client;
using io.github.vrchatapi.Model;

namespace Example
{
    public class GetCSSExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.vrchat.cloud/api/1";
            var apiInstance = new SystemApi(Configuration.Default);
            var variant = variant_example;  // string | Specifies which `variant` of the site. Public is the end-user site, while `internal` is the staff-only site with special pages for moderation and management. (optional)  (default to public)
            var branch = branch_example;  // string | Specifies which git branch the site should load frontend source code from. (optional)  (default to "main")

            try
            {
                // Download Frontend CSS
                string result = apiInstance.GetCSS(variant, branch);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SystemApi.GetCSS: " + e.Message );
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
 **variant** | **string**| Specifies which &#x60;variant&#x60; of the site. Public is the end-user site, while &#x60;internal&#x60; is the staff-only site with special pages for moderation and management. | [optional] [default to public]
 **branch** | **string**| Specifies which git branch the site should load frontend source code from. | [optional] [default to &quot;main&quot;]

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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetConfig

> APIConfig GetConfig ()

Fetch API Config

API config contains configuration that the clients needs to work properly.  Currently the most important value here is `clientApiKey` which is used for all other API endpoints.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using io.github.vrchatapi.Api;
using io.github.vrchatapi.Client;
using io.github.vrchatapi.Model;

namespace Example
{
    public class GetConfigExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.vrchat.cloud/api/1";
            var apiInstance = new SystemApi(Configuration.Default);

            try
            {
                // Fetch API Config
                APIConfig result = apiInstance.GetConfig();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SystemApi.GetConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
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
| **200** | OK |  * Set-Cookie -  <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetCurrentOnlineUsers

> int GetCurrentOnlineUsers ()

Current Online Users

Returns in plain format the number of currently online users.  **NOTE:** The response type is not of JSON, but is an integer in plain ASCII format.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using io.github.vrchatapi.Api;
using io.github.vrchatapi.Client;
using io.github.vrchatapi.Model;

namespace Example
{
    public class GetCurrentOnlineUsersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.vrchat.cloud/api/1";
            var apiInstance = new SystemApi(Configuration.Default);

            try
            {
                // Current Online Users
                int result = apiInstance.GetCurrentOnlineUsers();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SystemApi.GetCurrentOnlineUsers: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
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
- **Accept**: text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetHealth

> InlineResponse2002 GetHealth ()

Check API Health

~~Gets the overall health status, the server name, and the current build version tag of the API.~~  **DEPRECATED:** VRChat has suddenly restricted this endpoint for unknown reasons, and now always return 401 Unauthorized.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using io.github.vrchatapi.Api;
using io.github.vrchatapi.Client;
using io.github.vrchatapi.Model;

namespace Example
{
    public class GetHealthExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.vrchat.cloud/api/1";
            var apiInstance = new SystemApi(Configuration.Default);

            try
            {
                // Check API Health
                InlineResponse2002 result = apiInstance.GetHealth();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SystemApi.GetHealth: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**InlineResponse2002**](InlineResponse2002.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | API&#39;s Health |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetJavaScript

> string GetJavaScript (string variant = null, string branch = null)

Download Frontend JavaScript

Fetches the JavaScript code to the frontend React website.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using io.github.vrchatapi.Api;
using io.github.vrchatapi.Client;
using io.github.vrchatapi.Model;

namespace Example
{
    public class GetJavaScriptExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.vrchat.cloud/api/1";
            var apiInstance = new SystemApi(Configuration.Default);
            var variant = variant_example;  // string | Specifies which `variant` of the site. Public is the end-user site, while `internal` is the staff-only site with special pages for moderation and management. (optional)  (default to public)
            var branch = branch_example;  // string | Specifies which git branch the site should load frontend source code from. (optional)  (default to "main")

            try
            {
                // Download Frontend JavaScript
                string result = apiInstance.GetJavaScript(variant, branch);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SystemApi.GetJavaScript: " + e.Message );
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
 **variant** | **string**| Specifies which &#x60;variant&#x60; of the site. Public is the end-user site, while &#x60;internal&#x60; is the staff-only site with special pages for moderation and management. | [optional] [default to public]
 **branch** | **string**| Specifies which git branch the site should load frontend source code from. | [optional] [default to &quot;main&quot;]

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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetSystemTime

> DateTime GetSystemTime ()

Current System Time

Returns in plain format the current time of the API server.  **NOTE:** The response type is not of JSON, but is a string in plain ASCII format.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using io.github.vrchatapi.Api;
using io.github.vrchatapi.Client;
using io.github.vrchatapi.Model;

namespace Example
{
    public class GetSystemTimeExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.vrchat.cloud/api/1";
            var apiInstance = new SystemApi(Configuration.Default);

            try
            {
                // Current System Time
                DateTime result = apiInstance.GetSystemTime();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SystemApi.GetSystemTime: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
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
- **Accept**: text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

