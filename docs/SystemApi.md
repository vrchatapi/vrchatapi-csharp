# io.github.vrchatapi.Api.SystemApi

All URIs are relative to *https://api.vrchat.cloud/api/1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetConfig**](SystemApi.md#getconfig) | **GET** /config | Fetch API Config
[**GetCurrentOnlineUsers**](SystemApi.md#getcurrentonlineusers) | **GET** /visits | Current Online Users
[**GetHealth**](SystemApi.md#gethealth) | **GET** /health | Check API Health
[**GetSystemTime**](SystemApi.md#getsystemtime) | **GET** /time | Current System Time



## GetConfig

> Config GetConfig ()

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
                Config result = apiInstance.GetConfig();
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

[**Config**](Config.md)

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

Gets the overall health status, the server name, and the current build version tag of the API.

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

