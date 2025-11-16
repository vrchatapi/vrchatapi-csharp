# VRChat.API.Api.EconomyApi

All URIs are relative to *https://api.vrchat.cloud/api/1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetActiveLicenses**](EconomyApi.md#getactivelicenses) | **GET** /economy/licenses/active | Get Active Licenses |
| [**GetAdminTransaction**](EconomyApi.md#getadmintransaction) | **GET** /Admin/transactions/{transactionId} | Get Admin Transactions |
| [**GetAdminTransactions**](EconomyApi.md#getadmintransactions) | **GET** /Admin/transactions | Get Admin Transactions |
| [**GetBalance**](EconomyApi.md#getbalance) | **GET** /user/{userId}/balance | Get Balance |
| [**GetBalanceEarnings**](EconomyApi.md#getbalanceearnings) | **GET** /user/{userId}/balance/earnings | Get Balance Earnings |
| [**GetCurrentSubscriptions**](EconomyApi.md#getcurrentsubscriptions) | **GET** /auth/user/subscription | Get Current Subscriptions |
| [**GetEconomyAccount**](EconomyApi.md#geteconomyaccount) | **GET** /user/{userId}/economy/account | Get Economy Account |
| [**GetLicenseGroup**](EconomyApi.md#getlicensegroup) | **GET** /licenseGroups/{licenseGroupId} | Get License Group |
| [**GetProductListing**](EconomyApi.md#getproductlisting) | **GET** /listing/{productId} | Get Product Listing |
| [**GetProductListings**](EconomyApi.md#getproductlistings) | **GET** /user/{userId}/listings | Get User Product Listings |
| [**GetSteamTransaction**](EconomyApi.md#getsteamtransaction) | **GET** /Steam/transactions/{transactionId} | Get Steam Transaction |
| [**GetSteamTransactions**](EconomyApi.md#getsteamtransactions) | **GET** /Steam/transactions | List Steam Transactions |
| [**GetStore**](EconomyApi.md#getstore) | **GET** /economy/store | Get Store |
| [**GetStoreShelves**](EconomyApi.md#getstoreshelves) | **GET** /economy/store/shelves | Get Store Shelves |
| [**GetSubscriptions**](EconomyApi.md#getsubscriptions) | **GET** /subscriptions | List Subscriptions |
| [**GetTiliaStatus**](EconomyApi.md#gettiliastatus) | **GET** /tilia/status | Get Tilia Status |
| [**GetTiliaTos**](EconomyApi.md#gettiliatos) | **GET** /user/{userId}/tilia/tos | Get Tilia TOS Agreement Status |
| [**GetTokenBundles**](EconomyApi.md#gettokenbundles) | **GET** /tokenBundles | List Token Bundles |
| [**GetUserSubscriptionEligible**](EconomyApi.md#getusersubscriptioneligible) | **GET** /users/{userId}/subscription/eligible | Get User Subscription Eligiblity |

<a name="getactivelicenses"></a>
# **GetActiveLicenses**
> List&lt;License&gt; GetActiveLicenses ()

Get Active Licenses

Gets active licenses

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class GetActiveLicensesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vrchat.cloud/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new EconomyApi(config);

            try
            {
                // Get Active Licenses
                List<License> result = apiInstance.GetActiveLicenses();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EconomyApi.GetActiveLicenses: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetActiveLicensesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Active Licenses
    ApiResponse<List<License>> response = apiInstance.GetActiveLicensesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EconomyApi.GetActiveLicensesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;License&gt;**](License.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a list of License objects. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getadmintransaction"></a>
# **GetAdminTransaction**
> Transaction GetAdminTransaction (string transactionId)

Get Admin Transactions

Get a single Admin transactions by ID. This returns the exact same information as `getAdminTransactions`, so no point in using this endpoint.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class GetAdminTransactionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vrchat.cloud/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new EconomyApi(config);
            var transactionId = "transactionId_example";  // string | Must be a valid transaction ID.

            try
            {
                // Get Admin Transactions
                Transaction result = apiInstance.GetAdminTransaction(transactionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EconomyApi.GetAdminTransaction: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAdminTransactionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Admin Transactions
    ApiResponse<Transaction> response = apiInstance.GetAdminTransactionWithHttpInfo(transactionId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EconomyApi.GetAdminTransactionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **transactionId** | **string** | Must be a valid transaction ID. |  |

### Return type

[**Transaction**](Transaction.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a single Transaction object. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getadmintransactions"></a>
# **GetAdminTransactions**
> List&lt;Transaction&gt; GetAdminTransactions ()

Get Admin Transactions

Get all own Admin transactions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class GetAdminTransactionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vrchat.cloud/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new EconomyApi(config);

            try
            {
                // Get Admin Transactions
                List<Transaction> result = apiInstance.GetAdminTransactions();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EconomyApi.GetAdminTransactions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAdminTransactionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Admin Transactions
    ApiResponse<List<Transaction>> response = apiInstance.GetAdminTransactionsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EconomyApi.GetAdminTransactionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;Transaction&gt;**](Transaction.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a list of Transaction objects. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbalance"></a>
# **GetBalance**
> Balance GetBalance (string userId)

Get Balance

Gets the balance of a user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class GetBalanceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vrchat.cloud/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new EconomyApi(config);
            var userId = "userId_example";  // string | Must be a valid user ID.

            try
            {
                // Get Balance
                Balance result = apiInstance.GetBalance(userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EconomyApi.GetBalance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetBalanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Balance
    ApiResponse<Balance> response = apiInstance.GetBalanceWithHttpInfo(userId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EconomyApi.GetBalanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **string** | Must be a valid user ID. |  |

### Return type

[**Balance**](Balance.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a single Balance object. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbalanceearnings"></a>
# **GetBalanceEarnings**
> Balance GetBalanceEarnings (string userId)

Get Balance Earnings

Gets the balance of a user from earnings

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class GetBalanceEarningsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vrchat.cloud/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new EconomyApi(config);
            var userId = "userId_example";  // string | Must be a valid user ID.

            try
            {
                // Get Balance Earnings
                Balance result = apiInstance.GetBalanceEarnings(userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EconomyApi.GetBalanceEarnings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetBalanceEarningsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Balance Earnings
    ApiResponse<Balance> response = apiInstance.GetBalanceEarningsWithHttpInfo(userId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EconomyApi.GetBalanceEarningsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **string** | Must be a valid user ID. |  |

### Return type

[**Balance**](Balance.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a single Balance object. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcurrentsubscriptions"></a>
# **GetCurrentSubscriptions**
> List&lt;UserSubscription&gt; GetCurrentSubscriptions ()

Get Current Subscriptions

Get a list of all current user subscriptions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class GetCurrentSubscriptionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vrchat.cloud/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new EconomyApi(config);

            try
            {
                // Get Current Subscriptions
                List<UserSubscription> result = apiInstance.GetCurrentSubscriptions();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EconomyApi.GetCurrentSubscriptions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCurrentSubscriptionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Current Subscriptions
    ApiResponse<List<UserSubscription>> response = apiInstance.GetCurrentSubscriptionsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EconomyApi.GetCurrentSubscriptionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;UserSubscription&gt;**](UserSubscription.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a list of UserSubscription objects. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="geteconomyaccount"></a>
# **GetEconomyAccount**
> EconomyAccount GetEconomyAccount (string userId)

Get Economy Account

Gets the economy account of a user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class GetEconomyAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vrchat.cloud/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new EconomyApi(config);
            var userId = "userId_example";  // string | Must be a valid user ID.

            try
            {
                // Get Economy Account
                EconomyAccount result = apiInstance.GetEconomyAccount(userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EconomyApi.GetEconomyAccount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEconomyAccountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Economy Account
    ApiResponse<EconomyAccount> response = apiInstance.GetEconomyAccountWithHttpInfo(userId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EconomyApi.GetEconomyAccountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **string** | Must be a valid user ID. |  |

### Return type

[**EconomyAccount**](EconomyAccount.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a single EconomyAccount object. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlicensegroup"></a>
# **GetLicenseGroup**
> LicenseGroup GetLicenseGroup (string licenseGroupId)

Get License Group

Get a single License Group by given ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class GetLicenseGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vrchat.cloud/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new EconomyApi(config);
            var licenseGroupId = "licenseGroupId_example";  // string | Must be a valid license group ID.

            try
            {
                // Get License Group
                LicenseGroup result = apiInstance.GetLicenseGroup(licenseGroupId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EconomyApi.GetLicenseGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetLicenseGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get License Group
    ApiResponse<LicenseGroup> response = apiInstance.GetLicenseGroupWithHttpInfo(licenseGroupId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EconomyApi.GetLicenseGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **licenseGroupId** | **string** | Must be a valid license group ID. |  |

### Return type

[**LicenseGroup**](LicenseGroup.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a single LicenseGroup object. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getproductlisting"></a>
# **GetProductListing**
> ProductListing GetProductListing (string productId, bool? hydrate = null)

Get Product Listing

Gets a product listing

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class GetProductListingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vrchat.cloud/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new EconomyApi(config);
            var productId = "productId_example";  // string | Must be a valid product ID.
            var hydrate = true;  // bool? | Populates some fields and changes types of others for certain objects. (optional) 

            try
            {
                // Get Product Listing
                ProductListing result = apiInstance.GetProductListing(productId, hydrate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EconomyApi.GetProductListing: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetProductListingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Product Listing
    ApiResponse<ProductListing> response = apiInstance.GetProductListingWithHttpInfo(productId, hydrate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EconomyApi.GetProductListingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productId** | **string** | Must be a valid product ID. |  |
| **hydrate** | **bool?** | Populates some fields and changes types of others for certain objects. | [optional]  |

### Return type

[**ProductListing**](ProductListing.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a single ProductListing object. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getproductlistings"></a>
# **GetProductListings**
> List&lt;ProductListing&gt; GetProductListings (string userId, int? n = null, int? offset = null, bool? hydrate = null, string groupId = null, bool? active = null)

Get User Product Listings

Gets the product listings of a given user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class GetProductListingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vrchat.cloud/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new EconomyApi(config);
            var userId = "userId_example";  // string | Must be a valid user ID.
            var n = 60;  // int? | The number of objects to return. (optional)  (default to 60)
            var offset = 56;  // int? | A zero-based offset from the default object sorting from where search results start. (optional) 
            var hydrate = true;  // bool? | Populates some fields and changes types of others for certain objects. (optional) 
            var groupId = grp_00000000-0000-0000-0000-000000000000;  // string | Must be a valid group ID. (optional) 
            var active = true;  // bool? | Filter for users' listings and inventory bundles. (optional) 

            try
            {
                // Get User Product Listings
                List<ProductListing> result = apiInstance.GetProductListings(userId, n, offset, hydrate, groupId, active);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EconomyApi.GetProductListings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetProductListingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get User Product Listings
    ApiResponse<List<ProductListing>> response = apiInstance.GetProductListingsWithHttpInfo(userId, n, offset, hydrate, groupId, active);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EconomyApi.GetProductListingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **string** | Must be a valid user ID. |  |
| **n** | **int?** | The number of objects to return. | [optional] [default to 60] |
| **offset** | **int?** | A zero-based offset from the default object sorting from where search results start. | [optional]  |
| **hydrate** | **bool?** | Populates some fields and changes types of others for certain objects. | [optional]  |
| **groupId** | **string** | Must be a valid group ID. | [optional]  |
| **active** | **bool?** | Filter for users&#39; listings and inventory bundles. | [optional]  |

### Return type

[**List&lt;ProductListing&gt;**](ProductListing.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a list of ProductListing objects. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsteamtransaction"></a>
# **GetSteamTransaction**
> Transaction GetSteamTransaction (string transactionId)

Get Steam Transaction

Get a single Steam transactions by ID. This returns the exact same information as `getSteamTransactions`, so no point in using this endpoint.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class GetSteamTransactionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vrchat.cloud/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new EconomyApi(config);
            var transactionId = "transactionId_example";  // string | Must be a valid transaction ID.

            try
            {
                // Get Steam Transaction
                Transaction result = apiInstance.GetSteamTransaction(transactionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EconomyApi.GetSteamTransaction: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSteamTransactionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Steam Transaction
    ApiResponse<Transaction> response = apiInstance.GetSteamTransactionWithHttpInfo(transactionId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EconomyApi.GetSteamTransactionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **transactionId** | **string** | Must be a valid transaction ID. |  |

### Return type

[**Transaction**](Transaction.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a single Transaction object. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsteamtransactions"></a>
# **GetSteamTransactions**
> List&lt;Transaction&gt; GetSteamTransactions ()

List Steam Transactions

Get all own Steam transactions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class GetSteamTransactionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vrchat.cloud/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new EconomyApi(config);

            try
            {
                // List Steam Transactions
                List<Transaction> result = apiInstance.GetSteamTransactions();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EconomyApi.GetSteamTransactions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSteamTransactionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Steam Transactions
    ApiResponse<List<Transaction>> response = apiInstance.GetSteamTransactionsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EconomyApi.GetSteamTransactionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;Transaction&gt;**](Transaction.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a list of Transaction objects. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstore"></a>
# **GetStore**
> Store GetStore (string storeId, bool? hydrateListings = null, bool? hydrateProducts = null)

Get Store

Gets a store

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class GetStoreExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vrchat.cloud/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new EconomyApi(config);
            var storeId = "storeId_example";  // string | 
            var hydrateListings = true;  // bool? | Listings fields will be populated. (optional) 
            var hydrateProducts = true;  // bool? | Products fields will be populated. (optional) 

            try
            {
                // Get Store
                Store result = apiInstance.GetStore(storeId, hydrateListings, hydrateProducts);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EconomyApi.GetStore: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetStoreWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Store
    ApiResponse<Store> response = apiInstance.GetStoreWithHttpInfo(storeId, hydrateListings, hydrateProducts);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EconomyApi.GetStoreWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **storeId** | **string** |  |  |
| **hydrateListings** | **bool?** | Listings fields will be populated. | [optional]  |
| **hydrateProducts** | **bool?** | Products fields will be populated. | [optional]  |

### Return type

[**Store**](Store.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a single Store object. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstoreshelves"></a>
# **GetStoreShelves**
> List&lt;StoreShelf&gt; GetStoreShelves (string storeId, bool? hydrateListings = null, StoreView? fetch = null)

Get Store Shelves

Gets the shelves for a store

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class GetStoreShelvesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vrchat.cloud/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new EconomyApi(config);
            var storeId = "storeId_example";  // string | 
            var hydrateListings = true;  // bool? | Listings fields will be populated. (optional) 
            var fetch = (StoreView) "all";  // StoreView? |  (optional) 

            try
            {
                // Get Store Shelves
                List<StoreShelf> result = apiInstance.GetStoreShelves(storeId, hydrateListings, fetch);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EconomyApi.GetStoreShelves: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetStoreShelvesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Store Shelves
    ApiResponse<List<StoreShelf>> response = apiInstance.GetStoreShelvesWithHttpInfo(storeId, hydrateListings, fetch);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EconomyApi.GetStoreShelvesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **storeId** | **string** |  |  |
| **hydrateListings** | **bool?** | Listings fields will be populated. | [optional]  |
| **fetch** | **StoreView?** |  | [optional]  |

### Return type

[**List&lt;StoreShelf&gt;**](StoreShelf.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a list of StoreShelf objects. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsubscriptions"></a>
# **GetSubscriptions**
> List&lt;Subscription&gt; GetSubscriptions ()

List Subscriptions

List all existing Subscriptions. For example, \"vrchatplus-monthly\" and \"vrchatplus-yearly\".

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class GetSubscriptionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vrchat.cloud/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new EconomyApi(config);

            try
            {
                // List Subscriptions
                List<Subscription> result = apiInstance.GetSubscriptions();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EconomyApi.GetSubscriptions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSubscriptionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Subscriptions
    ApiResponse<List<Subscription>> response = apiInstance.GetSubscriptionsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EconomyApi.GetSubscriptionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;Subscription&gt;**](Subscription.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a list of Subscription objects. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettiliastatus"></a>
# **GetTiliaStatus**
> TiliaStatus GetTiliaStatus ()

Get Tilia Status

Gets the status of Tilia integration

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class GetTiliaStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vrchat.cloud/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new EconomyApi(config);

            try
            {
                // Get Tilia Status
                TiliaStatus result = apiInstance.GetTiliaStatus();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EconomyApi.GetTiliaStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTiliaStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Tilia Status
    ApiResponse<TiliaStatus> response = apiInstance.GetTiliaStatusWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EconomyApi.GetTiliaStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**TiliaStatus**](TiliaStatus.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a single TiliaStatus object. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettiliatos"></a>
# **GetTiliaTos**
> TiliaTOS GetTiliaTos (string userId)

Get Tilia TOS Agreement Status

Gets the status of the agreement of a user to the Tilia TOS

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class GetTiliaTosExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vrchat.cloud/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new EconomyApi(config);
            var userId = "userId_example";  // string | Must be a valid user ID.

            try
            {
                // Get Tilia TOS Agreement Status
                TiliaTOS result = apiInstance.GetTiliaTos(userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EconomyApi.GetTiliaTos: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTiliaTosWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Tilia TOS Agreement Status
    ApiResponse<TiliaTOS> response = apiInstance.GetTiliaTosWithHttpInfo(userId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EconomyApi.GetTiliaTosWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **string** | Must be a valid user ID. |  |

### Return type

[**TiliaTOS**](TiliaTOS.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a single TiliaTOS object. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettokenbundles"></a>
# **GetTokenBundles**
> List&lt;TokenBundle&gt; GetTokenBundles ()

List Token Bundles

Gets the list of token bundles

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class GetTokenBundlesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vrchat.cloud/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new EconomyApi(config);

            try
            {
                // List Token Bundles
                List<TokenBundle> result = apiInstance.GetTokenBundles();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EconomyApi.GetTokenBundles: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTokenBundlesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Token Bundles
    ApiResponse<List<TokenBundle>> response = apiInstance.GetTokenBundlesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EconomyApi.GetTokenBundlesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;TokenBundle&gt;**](TokenBundle.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a list of TokenBundle objects. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusersubscriptioneligible"></a>
# **GetUserSubscriptionEligible**
> UserSubscriptionEligible GetUserSubscriptionEligible (string userId, string steamId = null)

Get User Subscription Eligiblity

Get the user's eligibility status for subscriptions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class GetUserSubscriptionEligibleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vrchat.cloud/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new EconomyApi(config);
            var userId = "userId_example";  // string | Must be a valid user ID.
            var steamId = game night;  // string | The Steam ID of the user. (optional) 

            try
            {
                // Get User Subscription Eligiblity
                UserSubscriptionEligible result = apiInstance.GetUserSubscriptionEligible(userId, steamId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EconomyApi.GetUserSubscriptionEligible: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetUserSubscriptionEligibleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get User Subscription Eligiblity
    ApiResponse<UserSubscriptionEligible> response = apiInstance.GetUserSubscriptionEligibleWithHttpInfo(userId, steamId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EconomyApi.GetUserSubscriptionEligibleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **string** | Must be a valid user ID. |  |
| **steamId** | **string** | The Steam ID of the user. | [optional]  |

### Return type

[**UserSubscriptionEligible**](UserSubscriptionEligible.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a single UserSubscriptionEligible object. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

