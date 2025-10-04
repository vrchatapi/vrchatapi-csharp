# VRChat.API.Api.InventoryApi

All URIs are relative to *https://api.vrchat.cloud/api/1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetInventory**](InventoryApi.md#getinventory) | **GET** /inventory | Get Inventory |
| [**GetInventoryDrops**](InventoryApi.md#getinventorydrops) | **GET** /inventory/drops | List Inventory Drops |
| [**GetInventoryTemplate**](InventoryApi.md#getinventorytemplate) | **GET** /inventory/template/{inventoryTemplateId} | Get Inventory Template |
| [**GetOwnInventoryItem**](InventoryApi.md#getowninventoryitem) | **GET** /inventory/{inventoryItemId} | Get Own Inventory Item |
| [**ShareInventoryItemDirect**](InventoryApi.md#shareinventoryitemdirect) | **POST** /inventory/cloning/direct | Share Inventory Item Direct |
| [**ShareInventoryItemPedestal**](InventoryApi.md#shareinventoryitempedestal) | **GET** /inventory/cloning/pedestal | Share Inventory Item by Pedestal |
| [**SpawnInventoryItem**](InventoryApi.md#spawninventoryitem) | **GET** /inventory/spawn | Spawn Inventory Item |
| [**UpdateOwnInventoryItem**](InventoryApi.md#updateowninventoryitem) | **PUT** /inventory/{inventoryItemId} | Update Own Inventory Item |

<a name="getinventory"></a>
# **GetInventory**
> Inventory GetInventory (int? n = null, int? offset = null, string order = null, string tags = null, InventoryItemType? types = null, InventoryFlag? flags = null, InventoryItemType? notTypes = null, InventoryFlag? notFlags = null, bool? archived = null)

Get Inventory

Returns an Inventory object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class GetInventoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vrchat.cloud/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new InventoryApi(config);
            var n = 60;  // int? | The number of objects to return. (optional)  (default to 60)
            var offset = 56;  // int? | A zero-based offset from the default object sorting from where search results start. (optional) 
            var order = "newest";  // string | Sort order for inventory retrieval. (optional) 
            var tags = "tags_example";  // string | Filter tags for inventory retrieval (comma-separated). (optional) 
            var types = (InventoryItemType) "bundle";  // InventoryItemType? | Filter for inventory retrieval. (optional) 
            var flags = (InventoryFlag) "instantiatable";  // InventoryFlag? | Filter flags for inventory retrieval (comma-separated). (optional) 
            var notTypes = (InventoryItemType) "bundle";  // InventoryItemType? | Filter out types for inventory retrieval (comma-separated). (optional) 
            var notFlags = (InventoryFlag) "instantiatable";  // InventoryFlag? | Filter out flags for inventory retrieval (comma-separated). (optional) 
            var archived = true;  // bool? | Filter archived status for inventory retrieval. (optional) 

            try
            {
                // Get Inventory
                Inventory result = apiInstance.GetInventory(n, offset, order, tags, types, flags, notTypes, notFlags, archived);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.GetInventory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetInventoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Inventory
    ApiResponse<Inventory> response = apiInstance.GetInventoryWithHttpInfo(n, offset, order, tags, types, flags, notTypes, notFlags, archived);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InventoryApi.GetInventoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **n** | **int?** | The number of objects to return. | [optional] [default to 60] |
| **offset** | **int?** | A zero-based offset from the default object sorting from where search results start. | [optional]  |
| **order** | **string** | Sort order for inventory retrieval. | [optional]  |
| **tags** | **string** | Filter tags for inventory retrieval (comma-separated). | [optional]  |
| **types** | **InventoryItemType?** | Filter for inventory retrieval. | [optional]  |
| **flags** | **InventoryFlag?** | Filter flags for inventory retrieval (comma-separated). | [optional]  |
| **notTypes** | **InventoryItemType?** | Filter out types for inventory retrieval (comma-separated). | [optional]  |
| **notFlags** | **InventoryFlag?** | Filter out flags for inventory retrieval (comma-separated). | [optional]  |
| **archived** | **bool?** | Filter archived status for inventory retrieval. | [optional]  |

### Return type

[**Inventory**](Inventory.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns an Inventory object. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinventorydrops"></a>
# **GetInventoryDrops**
> List&lt;InventoryDrop&gt; GetInventoryDrops (bool? active = null)

List Inventory Drops

Returns a list of InventoryDrop objects.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class GetInventoryDropsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vrchat.cloud/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new InventoryApi(config);
            var active = true;  // bool? | Filter for users' listings and inventory bundles. (optional) 

            try
            {
                // List Inventory Drops
                List<InventoryDrop> result = apiInstance.GetInventoryDrops(active);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.GetInventoryDrops: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetInventoryDropsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Inventory Drops
    ApiResponse<List<InventoryDrop>> response = apiInstance.GetInventoryDropsWithHttpInfo(active);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InventoryApi.GetInventoryDropsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **active** | **bool?** | Filter for users&#39; listings and inventory bundles. | [optional]  |

### Return type

[**List&lt;InventoryDrop&gt;**](InventoryDrop.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a list of InventoryDrop objects. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinventorytemplate"></a>
# **GetInventoryTemplate**
> InventoryTemplate GetInventoryTemplate (string inventoryTemplateId)

Get Inventory Template

Returns an InventoryTemplate object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class GetInventoryTemplateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vrchat.cloud/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new InventoryApi(config);
            var inventoryTemplateId = invt_00000000-0000-0000-0000-000000000000;  // string | Must be a valid inventory template ID.

            try
            {
                // Get Inventory Template
                InventoryTemplate result = apiInstance.GetInventoryTemplate(inventoryTemplateId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.GetInventoryTemplate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetInventoryTemplateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Inventory Template
    ApiResponse<InventoryTemplate> response = apiInstance.GetInventoryTemplateWithHttpInfo(inventoryTemplateId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InventoryApi.GetInventoryTemplateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **inventoryTemplateId** | **string** | Must be a valid inventory template ID. |  |

### Return type

[**InventoryTemplate**](InventoryTemplate.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns an InventoryTemplate object. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getowninventoryitem"></a>
# **GetOwnInventoryItem**
> InventoryItem GetOwnInventoryItem (string inventoryItemId)

Get Own Inventory Item

Returns an InventoryItem object held by the currently logged in user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class GetOwnInventoryItemExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vrchat.cloud/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new InventoryApi(config);
            var inventoryItemId = inv_00000000-0000-0000-0000-000000000000;  // string | Must be a valid inventory item ID.

            try
            {
                // Get Own Inventory Item
                InventoryItem result = apiInstance.GetOwnInventoryItem(inventoryItemId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.GetOwnInventoryItem: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetOwnInventoryItemWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Own Inventory Item
    ApiResponse<InventoryItem> response = apiInstance.GetOwnInventoryItemWithHttpInfo(inventoryItemId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InventoryApi.GetOwnInventoryItemWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **inventoryItemId** | **string** | Must be a valid inventory item ID. |  |

### Return type

[**InventoryItem**](InventoryItem.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns an InventoryItem object. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="shareinventoryitemdirect"></a>
# **ShareInventoryItemDirect**
> OkStatus ShareInventoryItemDirect (string itemId, int duration, ShareInventoryItemDirectRequest shareInventoryItemDirectRequest)

Share Inventory Item Direct

Share content directly with other users.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class ShareInventoryItemDirectExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vrchat.cloud/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new InventoryApi(config);
            var itemId = "itemId_example";  // string | Id for inventory item sharing.
            var duration = 90;  // int | The duration before the sharing pedestal despawns. (default to 90)
            var shareInventoryItemDirectRequest = new ShareInventoryItemDirectRequest(); // ShareInventoryItemDirectRequest | 

            try
            {
                // Share Inventory Item Direct
                OkStatus result = apiInstance.ShareInventoryItemDirect(itemId, duration, shareInventoryItemDirectRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.ShareInventoryItemDirect: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ShareInventoryItemDirectWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Share Inventory Item Direct
    ApiResponse<OkStatus> response = apiInstance.ShareInventoryItemDirectWithHttpInfo(itemId, duration, shareInventoryItemDirectRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InventoryApi.ShareInventoryItemDirectWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **itemId** | **string** | Id for inventory item sharing. |  |
| **duration** | **int** | The duration before the sharing pedestal despawns. | [default to 90] |
| **shareInventoryItemDirectRequest** | [**ShareInventoryItemDirectRequest**](ShareInventoryItemDirectRequest.md) |  |  |

### Return type

[**OkStatus**](OkStatus.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns an OkStatus object. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="shareinventoryitempedestal"></a>
# **ShareInventoryItemPedestal**
> InventorySpawn ShareInventoryItemPedestal (string itemId, int duration)

Share Inventory Item by Pedestal

Returns an InventorySpawn object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class ShareInventoryItemPedestalExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vrchat.cloud/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new InventoryApi(config);
            var itemId = "itemId_example";  // string | Id for inventory item sharing.
            var duration = 90;  // int | The duration before the sharing pedestal despawns. (default to 90)

            try
            {
                // Share Inventory Item by Pedestal
                InventorySpawn result = apiInstance.ShareInventoryItemPedestal(itemId, duration);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.ShareInventoryItemPedestal: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ShareInventoryItemPedestalWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Share Inventory Item by Pedestal
    ApiResponse<InventorySpawn> response = apiInstance.ShareInventoryItemPedestalWithHttpInfo(itemId, duration);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InventoryApi.ShareInventoryItemPedestalWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **itemId** | **string** | Id for inventory item sharing. |  |
| **duration** | **int** | The duration before the sharing pedestal despawns. | [default to 90] |

### Return type

[**InventorySpawn**](InventorySpawn.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns an InventorySpawn object. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="spawninventoryitem"></a>
# **SpawnInventoryItem**
> InventorySpawn SpawnInventoryItem (string id)

Spawn Inventory Item

Returns an InventorySpawn object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class SpawnInventoryItemExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vrchat.cloud/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new InventoryApi(config);
            var id = "id_example";  // string | Id for inventory item spawning.

            try
            {
                // Spawn Inventory Item
                InventorySpawn result = apiInstance.SpawnInventoryItem(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.SpawnInventoryItem: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SpawnInventoryItemWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Spawn Inventory Item
    ApiResponse<InventorySpawn> response = apiInstance.SpawnInventoryItemWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InventoryApi.SpawnInventoryItemWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Id for inventory item spawning. |  |

### Return type

[**InventorySpawn**](InventorySpawn.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns an InventorySpawn object. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateowninventoryitem"></a>
# **UpdateOwnInventoryItem**
> InventoryItem UpdateOwnInventoryItem (string inventoryItemId, UpdateInventoryItemRequest updateInventoryItemRequest = null)

Update Own Inventory Item

Returns the modified InventoryItem object as held by the currently logged in user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class UpdateOwnInventoryItemExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vrchat.cloud/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new InventoryApi(config);
            var inventoryItemId = inv_00000000-0000-0000-0000-000000000000;  // string | Must be a valid inventory item ID.
            var updateInventoryItemRequest = new UpdateInventoryItemRequest(); // UpdateInventoryItemRequest |  (optional) 

            try
            {
                // Update Own Inventory Item
                InventoryItem result = apiInstance.UpdateOwnInventoryItem(inventoryItemId, updateInventoryItemRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.UpdateOwnInventoryItem: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateOwnInventoryItemWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Own Inventory Item
    ApiResponse<InventoryItem> response = apiInstance.UpdateOwnInventoryItemWithHttpInfo(inventoryItemId, updateInventoryItemRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InventoryApi.UpdateOwnInventoryItemWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **inventoryItemId** | **string** | Must be a valid inventory item ID. |  |
| **updateInventoryItemRequest** | [**UpdateInventoryItemRequest**](UpdateInventoryItemRequest.md) |  | [optional]  |

### Return type

[**InventoryItem**](InventoryItem.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns an InventoryItem object. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

