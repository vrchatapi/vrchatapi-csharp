# VRChat.API.Api.InviteApi

All URIs are relative to *https://vrchat.com/api/1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetInviteMessage**](InviteApi.md#getinvitemessage) | **GET** /message/{userId}/{messageType}/{slot} | Get Invite Message |
| [**GetInviteMessages**](InviteApi.md#getinvitemessages) | **GET** /message/{userId}/{messageType} | List Invite Messages |
| [**InviteMyselfTo**](InviteApi.md#invitemyselfto) | **POST** /invite/myself/to/{worldId}:{instanceId} | Invite Myself To Instance |
| [**InviteUser**](InviteApi.md#inviteuser) | **POST** /invite/{userId} | Invite User |
| [**RequestInvite**](InviteApi.md#requestinvite) | **POST** /requestInvite/{userId} | Request Invite |
| [**ResetInviteMessage**](InviteApi.md#resetinvitemessage) | **DELETE** /message/{userId}/{messageType}/{slot} | Reset Invite Message |
| [**RespondInvite**](InviteApi.md#respondinvite) | **POST** /invite/{notificationId}/response | Respond Invite |
| [**UpdateInviteMessage**](InviteApi.md#updateinvitemessage) | **PUT** /message/{userId}/{messageType}/{slot} | Update Invite Message |

<a name="getinvitemessage"></a>
# **GetInviteMessage**
> InviteMessage GetInviteMessage (string userId, InviteMessageType messageType, int slot)

Get Invite Message

Returns a single Invite Message. This returns the exact same information but less than `getInviteMessages`. Admin Credentials are required to view messages of other users!  Message type refers to a different collection of messages, used during different types of responses.  * `message` = Message during a normal invite * `response` = Message when replying to a message * `request` = Message when requesting an invite * `requestResponse` = Message when replying to a request for invite

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class GetInviteMessageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrchat.com/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new InviteApi(config);
            var userId = "userId_example";  // string | Must be a valid user ID.
            var messageType = (InviteMessageType) "message";  // InviteMessageType | The type of message to fetch, must be a valid InviteMessageType.
            var slot = 56;  // int | The message slot to fetch of a given message type.

            try
            {
                // Get Invite Message
                InviteMessage result = apiInstance.GetInviteMessage(userId, messageType, slot);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InviteApi.GetInviteMessage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetInviteMessageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Invite Message
    ApiResponse<InviteMessage> response = apiInstance.GetInviteMessageWithHttpInfo(userId, messageType, slot);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InviteApi.GetInviteMessageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **string** | Must be a valid user ID. |  |
| **messageType** | **InviteMessageType** | The type of message to fetch, must be a valid InviteMessageType. |  |
| **slot** | **int** | The message slot to fetch of a given message type. |  |

### Return type

[**InviteMessage**](InviteMessage.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a single InviteMessage object. |  -  |
| **400** | Error response when trying to get an Invite Message with a negative slot number. |  -  |
| **401** | Error response due to missing authorization to perform that action. |  -  |
| **404** | Error response when trying to get an Invite Message with a too high slot number. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinvitemessages"></a>
# **GetInviteMessages**
> List&lt;InviteMessage&gt; GetInviteMessages (string userId, InviteMessageType messageType)

List Invite Messages

Returns a list of all the users Invite Messages. Admin Credentials are required to view messages of other users!  Message type refers to a different collection of messages, used during different types of responses.  * `message` = Message during a normal invite * `response` = Message when replying to a message * `request` = Message when requesting an invite * `requestResponse` = Message when replying to a request for invite

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class GetInviteMessagesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrchat.com/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new InviteApi(config);
            var userId = "userId_example";  // string | Must be a valid user ID.
            var messageType = (InviteMessageType) "message";  // InviteMessageType | The type of message to fetch, must be a valid InviteMessageType.

            try
            {
                // List Invite Messages
                List<InviteMessage> result = apiInstance.GetInviteMessages(userId, messageType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InviteApi.GetInviteMessages: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetInviteMessagesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Invite Messages
    ApiResponse<List<InviteMessage>> response = apiInstance.GetInviteMessagesWithHttpInfo(userId, messageType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InviteApi.GetInviteMessagesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **string** | Must be a valid user ID. |  |
| **messageType** | **InviteMessageType** | The type of message to fetch, must be a valid InviteMessageType. |  |

### Return type

[**List&lt;InviteMessage&gt;**](InviteMessage.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a list of InviteMessage objects. |  -  |
| **400** | Error response when trying to update an Invite Message with an invalid slot number. |  -  |
| **401** | Error response due to missing authorization to perform that action. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="invitemyselfto"></a>
# **InviteMyselfTo**
> SentNotification InviteMyselfTo (string worldId, string instanceId)

Invite Myself To Instance

Sends self an invite to an instance

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class InviteMyselfToExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrchat.com/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new InviteApi(config);
            var worldId = "worldId_example";  // string | Must be a valid world ID.
            var instanceId = "instanceId_example";  // string | Must be a valid instance ID.

            try
            {
                // Invite Myself To Instance
                SentNotification result = apiInstance.InviteMyselfTo(worldId, instanceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InviteApi.InviteMyselfTo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InviteMyselfToWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Invite Myself To Instance
    ApiResponse<SentNotification> response = apiInstance.InviteMyselfToWithHttpInfo(worldId, instanceId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InviteApi.InviteMyselfToWithHttpInfo: " + e.Message);
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

[**SentNotification**](SentNotification.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a single SentNotifcation object. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |
| **404** | Error response due to non existant instance |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="inviteuser"></a>
# **InviteUser**
> SentNotification InviteUser (string userId, InviteRequest inviteRequest)

Invite User

Sends an invite to a user. Returns the Notification of type `invite` that was sent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class InviteUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrchat.com/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new InviteApi(config);
            var userId = "userId_example";  // string | Must be a valid user ID.
            var inviteRequest = new InviteRequest(); // InviteRequest | Slot number of the Invite Message to use when inviting a user.

            try
            {
                // Invite User
                SentNotification result = apiInstance.InviteUser(userId, inviteRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InviteApi.InviteUser: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InviteUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Invite User
    ApiResponse<SentNotification> response = apiInstance.InviteUserWithHttpInfo(userId, inviteRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InviteApi.InviteUserWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **string** | Must be a valid user ID. |  |
| **inviteRequest** | [**InviteRequest**](InviteRequest.md) | Slot number of the Invite Message to use when inviting a user. |  |

### Return type

[**SentNotification**](SentNotification.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a single SentNotifcation object. |  -  |
| **403** | Error response when trying to invite someome whom you are not friends with. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="requestinvite"></a>
# **RequestInvite**
> Notification RequestInvite (string userId, RequestInviteRequest requestInviteRequest = null)

Request Invite

Requests an invite from a user. Returns the Notification of type `requestInvite` that was sent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class RequestInviteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrchat.com/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new InviteApi(config);
            var userId = "userId_example";  // string | Must be a valid user ID.
            var requestInviteRequest = new RequestInviteRequest(); // RequestInviteRequest | Slot number of the Request Message to use when request an invite. (optional) 

            try
            {
                // Request Invite
                Notification result = apiInstance.RequestInvite(userId, requestInviteRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InviteApi.RequestInvite: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RequestInviteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Request Invite
    ApiResponse<Notification> response = apiInstance.RequestInviteWithHttpInfo(userId, requestInviteRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InviteApi.RequestInviteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **string** | Must be a valid user ID. |  |
| **requestInviteRequest** | [**RequestInviteRequest**](RequestInviteRequest.md) | Slot number of the Request Message to use when request an invite. | [optional]  |

### Return type

[**Notification**](Notification.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a single Notifcation object. |  -  |
| **403** | Error response when trying to invite someome whom you are not friends with. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="resetinvitemessage"></a>
# **ResetInviteMessage**
> List&lt;InviteMessage&gt; ResetInviteMessage (string userId, InviteMessageType messageType, int slot)

Reset Invite Message

Resets a single Invite Message back to its original message, and then returns a list of all of them. Admin Credentials are required to update messages of other users!  Resetting a message respects the rate-limit, so it is not possible to reset within the 60 minutes countdown. Resetting it does however not set the rate-limit to 60 like when editing it. It is possible to edit it right after resetting it. Trying to edit a message before the cooldown timer expires results in a 429 \"Too Fast Error\".  Message type refers to a different collection of messages, used during different types of responses.  * `message` = Message during a normal invite * `response` = Message when replying to a message * `request` = Message when requesting an invite * `requestResponse` = Message when replying to a request for invite  The DELETE endpoint does not have/require any request body.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class ResetInviteMessageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrchat.com/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new InviteApi(config);
            var userId = "userId_example";  // string | Must be a valid user ID.
            var messageType = (InviteMessageType) "message";  // InviteMessageType | The type of message to fetch, must be a valid InviteMessageType.
            var slot = 56;  // int | The message slot to fetch of a given message type.

            try
            {
                // Reset Invite Message
                List<InviteMessage> result = apiInstance.ResetInviteMessage(userId, messageType, slot);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InviteApi.ResetInviteMessage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ResetInviteMessageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reset Invite Message
    ApiResponse<List<InviteMessage>> response = apiInstance.ResetInviteMessageWithHttpInfo(userId, messageType, slot);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InviteApi.ResetInviteMessageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **string** | Must be a valid user ID. |  |
| **messageType** | **InviteMessageType** | The type of message to fetch, must be a valid InviteMessageType. |  |
| **slot** | **int** | The message slot to fetch of a given message type. |  |

### Return type

[**List&lt;InviteMessage&gt;**](InviteMessage.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a list of InviteMessage objects. |  -  |
| **400** | Error response when trying to update an Invite Message with an invalid slot number. |  -  |
| **401** | Error response due to missing authorization to perform that action. |  -  |
| **404** | Error response when trying to reset an Invite Message whos slot doesn&#39;t exist. |  -  |
| **429** | Error response when trying to update an Invite Message before the cooldown has expired. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="respondinvite"></a>
# **RespondInvite**
> Notification RespondInvite (string notificationId, InviteResponse inviteResponse)

Respond Invite

Respond to an invite request by sending a world invite to the requesting user. `:notificationId` is the ID of the requesting notification.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class RespondInviteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrchat.com/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new InviteApi(config);
            var notificationId = "notificationId_example";  // string | Must be a valid notification ID.
            var inviteResponse = new InviteResponse(); // InviteResponse | Slot number of the Response Message to use when responding to a user.

            try
            {
                // Respond Invite
                Notification result = apiInstance.RespondInvite(notificationId, inviteResponse);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InviteApi.RespondInvite: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RespondInviteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Respond Invite
    ApiResponse<Notification> response = apiInstance.RespondInviteWithHttpInfo(notificationId, inviteResponse);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InviteApi.RespondInviteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **notificationId** | **string** | Must be a valid notification ID. |  |
| **inviteResponse** | [**InviteResponse**](InviteResponse.md) | Slot number of the Response Message to use when responding to a user. |  |

### Return type

[**Notification**](Notification.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a single Notifcation object. |  -  |
| **400** | Error response when trying to respond to an invite and something went wrong. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateinvitemessage"></a>
# **UpdateInviteMessage**
> List&lt;InviteMessage&gt; UpdateInviteMessage (string userId, InviteMessageType messageType, int slot, UpdateInviteMessageRequest updateInviteMessageRequest = null)

Update Invite Message

Updates a single Invite Message and then returns a list of all of them. Admin Credentials are required to update messages of other users!  Updating a message automatically sets the cooldown timer to 60 minutes. Trying to edit a message before the cooldown timer expires results in a 429 \"Too Fast Error\".  Message type refers to a different collection of messages, used during different types of responses.  * `message` = Message during a normal invite * `response` = Message when replying to a message * `request` = Message when requesting an invite * `requestResponse` = Message when replying to a request for invite

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class UpdateInviteMessageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrchat.com/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new InviteApi(config);
            var userId = "userId_example";  // string | Must be a valid user ID.
            var messageType = (InviteMessageType) "message";  // InviteMessageType | The type of message to fetch, must be a valid InviteMessageType.
            var slot = 56;  // int | The message slot to fetch of a given message type.
            var updateInviteMessageRequest = new UpdateInviteMessageRequest(); // UpdateInviteMessageRequest | Message of what to set the invite message to. (optional) 

            try
            {
                // Update Invite Message
                List<InviteMessage> result = apiInstance.UpdateInviteMessage(userId, messageType, slot, updateInviteMessageRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InviteApi.UpdateInviteMessage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateInviteMessageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Invite Message
    ApiResponse<List<InviteMessage>> response = apiInstance.UpdateInviteMessageWithHttpInfo(userId, messageType, slot, updateInviteMessageRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InviteApi.UpdateInviteMessageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **string** | Must be a valid user ID. |  |
| **messageType** | **InviteMessageType** | The type of message to fetch, must be a valid InviteMessageType. |  |
| **slot** | **int** | The message slot to fetch of a given message type. |  |
| **updateInviteMessageRequest** | [**UpdateInviteMessageRequest**](UpdateInviteMessageRequest.md) | Message of what to set the invite message to. | [optional]  |

### Return type

[**List&lt;InviteMessage&gt;**](InviteMessage.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a list of InviteMessage objects. |  -  |
| **400** | Error response when trying to update an Invite Message with an invalid slot number. |  -  |
| **401** | Error response due to missing authorization to perform that action. |  -  |
| **429** | Error response when trying to update an Invite Message before the cooldown has expired. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

