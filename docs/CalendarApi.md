# VRChat.API.Api.CalendarApi

All URIs are relative to *https://api.vrchat.cloud/api/1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateGroupCalendarEvent**](CalendarApi.md#creategroupcalendarevent) | **POST** /calendar/{groupId}/event | Create a calendar event |
| [**DeleteGroupCalendarEvent**](CalendarApi.md#deletegroupcalendarevent) | **DELETE** /calendar/{groupId}/{calendarId} | Delete a calendar event |
| [**FollowGroupCalendarEvent**](CalendarApi.md#followgroupcalendarevent) | **POST** /calendar/{groupId}/{calendarId}/follow | Follow a calendar event |
| [**GetCalendarEvents**](CalendarApi.md#getcalendarevents) | **GET** /calendar | List calendar events |
| [**GetFeaturedCalendarEvents**](CalendarApi.md#getfeaturedcalendarevents) | **GET** /calendar/featured | List featured calendar events |
| [**GetFollowedCalendarEvents**](CalendarApi.md#getfollowedcalendarevents) | **GET** /calendar/following | List followed calendar events |
| [**GetGroupCalendarEvent**](CalendarApi.md#getgroupcalendarevent) | **GET** /calendar/{groupId}/{calendarId} | Get a calendar event |
| [**GetGroupCalendarEventICS**](CalendarApi.md#getgroupcalendareventics) | **GET** /calendar/{groupId}/{calendarId}.ics | Download calendar event as ICS |
| [**GetGroupCalendarEvents**](CalendarApi.md#getgroupcalendarevents) | **GET** /calendar/{groupId} | List a group&#39;s calendar events |
| [**SearchCalendarEvents**](CalendarApi.md#searchcalendarevents) | **GET** /calendar/search | Search for calendar events |
| [**UpdateGroupCalendarEvent**](CalendarApi.md#updategroupcalendarevent) | **PUT** /calendar/{groupId}/{calendarId}/event | Update a calendar event |

<a name="creategroupcalendarevent"></a>
# **CreateGroupCalendarEvent**
> CalendarEvent CreateGroupCalendarEvent (string groupId, CreateCalendarEventRequest createCalendarEventRequest)

Create a calendar event

Creates an event for a group on the calendar

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class CreateGroupCalendarEventExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vrchat.cloud/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new CalendarApi(config);
            var groupId = grp_00000000-0000-0000-0000-000000000000;  // string | Must be a valid group ID.
            var createCalendarEventRequest = new CreateCalendarEventRequest(); // CreateCalendarEventRequest | 

            try
            {
                // Create a calendar event
                CalendarEvent result = apiInstance.CreateGroupCalendarEvent(groupId, createCalendarEventRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CalendarApi.CreateGroupCalendarEvent: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateGroupCalendarEventWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a calendar event
    ApiResponse<CalendarEvent> response = apiInstance.CreateGroupCalendarEventWithHttpInfo(groupId, createCalendarEventRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CalendarApi.CreateGroupCalendarEventWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **string** | Must be a valid group ID. |  |
| **createCalendarEventRequest** | [**CreateCalendarEventRequest**](CreateCalendarEventRequest.md) |  |  |

### Return type

[**CalendarEvent**](CalendarEvent.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a single CalendarEvent object. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletegroupcalendarevent"></a>
# **DeleteGroupCalendarEvent**
> Success DeleteGroupCalendarEvent (string groupId, string calendarId)

Delete a calendar event

Delete a group calendar event

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class DeleteGroupCalendarEventExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vrchat.cloud/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new CalendarApi(config);
            var groupId = grp_00000000-0000-0000-0000-000000000000;  // string | Must be a valid group ID.
            var calendarId = cal_00000000-0000-0000-0000-000000000000;  // string | Must be a valid calendar ID.

            try
            {
                // Delete a calendar event
                Success result = apiInstance.DeleteGroupCalendarEvent(groupId, calendarId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CalendarApi.DeleteGroupCalendarEvent: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteGroupCalendarEventWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a calendar event
    ApiResponse<Success> response = apiInstance.DeleteGroupCalendarEventWithHttpInfo(groupId, calendarId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CalendarApi.DeleteGroupCalendarEventWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **string** | Must be a valid group ID. |  |
| **calendarId** | **string** | Must be a valid calendar ID. |  |

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
| **200** | Successful response after deleting a calendar event. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="followgroupcalendarevent"></a>
# **FollowGroupCalendarEvent**
> CalendarEvent FollowGroupCalendarEvent (string groupId, string calendarId, FollowCalendarEventRequest followCalendarEventRequest)

Follow a calendar event

Follow or unfollow an event on a group's calendar

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class FollowGroupCalendarEventExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vrchat.cloud/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new CalendarApi(config);
            var groupId = grp_00000000-0000-0000-0000-000000000000;  // string | Must be a valid group ID.
            var calendarId = cal_00000000-0000-0000-0000-000000000000;  // string | Must be a valid calendar ID.
            var followCalendarEventRequest = new FollowCalendarEventRequest(); // FollowCalendarEventRequest | 

            try
            {
                // Follow a calendar event
                CalendarEvent result = apiInstance.FollowGroupCalendarEvent(groupId, calendarId, followCalendarEventRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CalendarApi.FollowGroupCalendarEvent: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FollowGroupCalendarEventWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Follow a calendar event
    ApiResponse<CalendarEvent> response = apiInstance.FollowGroupCalendarEventWithHttpInfo(groupId, calendarId, followCalendarEventRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CalendarApi.FollowGroupCalendarEventWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **string** | Must be a valid group ID. |  |
| **calendarId** | **string** | Must be a valid calendar ID. |  |
| **followCalendarEventRequest** | [**FollowCalendarEventRequest**](FollowCalendarEventRequest.md) |  |  |

### Return type

[**CalendarEvent**](CalendarEvent.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a single CalendarEvent object. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcalendarevents"></a>
# **GetCalendarEvents**
> PaginatedCalendarEventList GetCalendarEvents (DateTime? date = null, int? n = null, int? offset = null)

List calendar events

Get a list of a user's calendar events for the month in ?date

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class GetCalendarEventsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vrchat.cloud/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new CalendarApi(config);
            var date = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | The month to search in. (optional) 
            var n = 60;  // int? | The number of objects to return. (optional)  (default to 60)
            var offset = 56;  // int? | A zero-based offset from the default object sorting from where search results start. (optional) 

            try
            {
                // List calendar events
                PaginatedCalendarEventList result = apiInstance.GetCalendarEvents(date, n, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CalendarApi.GetCalendarEvents: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCalendarEventsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List calendar events
    ApiResponse<PaginatedCalendarEventList> response = apiInstance.GetCalendarEventsWithHttpInfo(date, n, offset);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CalendarApi.GetCalendarEventsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **date** | **DateTime?** | The month to search in. | [optional]  |
| **n** | **int?** | The number of objects to return. | [optional] [default to 60] |
| **offset** | **int?** | A zero-based offset from the default object sorting from where search results start. | [optional]  |

### Return type

[**PaginatedCalendarEventList**](PaginatedCalendarEventList.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a list of CalendarEvent objects. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfeaturedcalendarevents"></a>
# **GetFeaturedCalendarEvents**
> PaginatedCalendarEventList GetFeaturedCalendarEvents (DateTime? date = null, int? n = null, int? offset = null)

List featured calendar events

Get a list of a featured calendar events for the month in ?date

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class GetFeaturedCalendarEventsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vrchat.cloud/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new CalendarApi(config);
            var date = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | The month to search in. (optional) 
            var n = 60;  // int? | The number of objects to return. (optional)  (default to 60)
            var offset = 56;  // int? | A zero-based offset from the default object sorting from where search results start. (optional) 

            try
            {
                // List featured calendar events
                PaginatedCalendarEventList result = apiInstance.GetFeaturedCalendarEvents(date, n, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CalendarApi.GetFeaturedCalendarEvents: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFeaturedCalendarEventsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List featured calendar events
    ApiResponse<PaginatedCalendarEventList> response = apiInstance.GetFeaturedCalendarEventsWithHttpInfo(date, n, offset);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CalendarApi.GetFeaturedCalendarEventsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **date** | **DateTime?** | The month to search in. | [optional]  |
| **n** | **int?** | The number of objects to return. | [optional] [default to 60] |
| **offset** | **int?** | A zero-based offset from the default object sorting from where search results start. | [optional]  |

### Return type

[**PaginatedCalendarEventList**](PaginatedCalendarEventList.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a list of CalendarEvent objects. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfollowedcalendarevents"></a>
# **GetFollowedCalendarEvents**
> PaginatedCalendarEventList GetFollowedCalendarEvents (DateTime? date = null, int? n = null, int? offset = null)

List followed calendar events

Get a list of a followed calendar events for the month in ?date

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class GetFollowedCalendarEventsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vrchat.cloud/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new CalendarApi(config);
            var date = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | The month to search in. (optional) 
            var n = 60;  // int? | The number of objects to return. (optional)  (default to 60)
            var offset = 56;  // int? | A zero-based offset from the default object sorting from where search results start. (optional) 

            try
            {
                // List followed calendar events
                PaginatedCalendarEventList result = apiInstance.GetFollowedCalendarEvents(date, n, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CalendarApi.GetFollowedCalendarEvents: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFollowedCalendarEventsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List followed calendar events
    ApiResponse<PaginatedCalendarEventList> response = apiInstance.GetFollowedCalendarEventsWithHttpInfo(date, n, offset);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CalendarApi.GetFollowedCalendarEventsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **date** | **DateTime?** | The month to search in. | [optional]  |
| **n** | **int?** | The number of objects to return. | [optional] [default to 60] |
| **offset** | **int?** | A zero-based offset from the default object sorting from where search results start. | [optional]  |

### Return type

[**PaginatedCalendarEventList**](PaginatedCalendarEventList.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a list of CalendarEvent objects. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgroupcalendarevent"></a>
# **GetGroupCalendarEvent**
> CalendarEvent GetGroupCalendarEvent (string groupId, string calendarId)

Get a calendar event

Get a group calendar event

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class GetGroupCalendarEventExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vrchat.cloud/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new CalendarApi(config);
            var groupId = grp_00000000-0000-0000-0000-000000000000;  // string | Must be a valid group ID.
            var calendarId = cal_00000000-0000-0000-0000-000000000000;  // string | Must be a valid calendar ID.

            try
            {
                // Get a calendar event
                CalendarEvent result = apiInstance.GetGroupCalendarEvent(groupId, calendarId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CalendarApi.GetGroupCalendarEvent: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetGroupCalendarEventWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a calendar event
    ApiResponse<CalendarEvent> response = apiInstance.GetGroupCalendarEventWithHttpInfo(groupId, calendarId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CalendarApi.GetGroupCalendarEventWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **string** | Must be a valid group ID. |  |
| **calendarId** | **string** | Must be a valid calendar ID. |  |

### Return type

[**CalendarEvent**](CalendarEvent.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a single CalendarEvent object. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgroupcalendareventics"></a>
# **GetGroupCalendarEventICS**
> System.IO.Stream GetGroupCalendarEventICS (string groupId, string calendarId)

Download calendar event as ICS

Returns the specified calendar in iCalendar (ICS) format.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class GetGroupCalendarEventICSExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vrchat.cloud/api/1";
            var apiInstance = new CalendarApi(config);
            var groupId = grp_00000000-0000-0000-0000-000000000000;  // string | Must be a valid group ID.
            var calendarId = cal_00000000-0000-0000-0000-000000000000;  // string | Must be a valid calendar ID.

            try
            {
                // Download calendar event as ICS
                System.IO.Stream result = apiInstance.GetGroupCalendarEventICS(groupId, calendarId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CalendarApi.GetGroupCalendarEventICS: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetGroupCalendarEventICSWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Download calendar event as ICS
    ApiResponse<System.IO.Stream> response = apiInstance.GetGroupCalendarEventICSWithHttpInfo(groupId, calendarId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CalendarApi.GetGroupCalendarEventICSWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **string** | Must be a valid group ID. |  |
| **calendarId** | **string** | Must be a valid calendar ID. |  |

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/calendar, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | iCalendar file download |  -  |
| **401** | Error response due to missing auth cookie. |  -  |
| **404** | Error response when trying to download ICS calendar of a non-existent calendar entry. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgroupcalendarevents"></a>
# **GetGroupCalendarEvents**
> PaginatedCalendarEventList GetGroupCalendarEvents (string groupId, DateTime? date = null, int? n = null, int? offset = null)

List a group's calendar events

Get a list of a group's calendar events

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class GetGroupCalendarEventsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vrchat.cloud/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new CalendarApi(config);
            var groupId = grp_00000000-0000-0000-0000-000000000000;  // string | Must be a valid group ID.
            var date = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | The month to search in. (optional) 
            var n = 60;  // int? | The number of objects to return. (optional)  (default to 60)
            var offset = 56;  // int? | A zero-based offset from the default object sorting from where search results start. (optional) 

            try
            {
                // List a group's calendar events
                PaginatedCalendarEventList result = apiInstance.GetGroupCalendarEvents(groupId, date, n, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CalendarApi.GetGroupCalendarEvents: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetGroupCalendarEventsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List a group's calendar events
    ApiResponse<PaginatedCalendarEventList> response = apiInstance.GetGroupCalendarEventsWithHttpInfo(groupId, date, n, offset);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CalendarApi.GetGroupCalendarEventsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **string** | Must be a valid group ID. |  |
| **date** | **DateTime?** | The month to search in. | [optional]  |
| **n** | **int?** | The number of objects to return. | [optional] [default to 60] |
| **offset** | **int?** | A zero-based offset from the default object sorting from where search results start. | [optional]  |

### Return type

[**PaginatedCalendarEventList**](PaginatedCalendarEventList.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a list of CalendarEvent objects. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchcalendarevents"></a>
# **SearchCalendarEvents**
> PaginatedCalendarEventList SearchCalendarEvents (string searchTerm, int? utcOffset = null, int? n = null, int? offset = null)

Search for calendar events

Get a list of calendar events by search terms

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class SearchCalendarEventsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vrchat.cloud/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new CalendarApi(config);
            var searchTerm = game night;  // string | Search term for calendar events.
            var utcOffset = 56;  // int? | The offset from UTC in hours of the client or authenticated user. (optional) 
            var n = 60;  // int? | The number of objects to return. (optional)  (default to 60)
            var offset = 56;  // int? | A zero-based offset from the default object sorting from where search results start. (optional) 

            try
            {
                // Search for calendar events
                PaginatedCalendarEventList result = apiInstance.SearchCalendarEvents(searchTerm, utcOffset, n, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CalendarApi.SearchCalendarEvents: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SearchCalendarEventsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search for calendar events
    ApiResponse<PaginatedCalendarEventList> response = apiInstance.SearchCalendarEventsWithHttpInfo(searchTerm, utcOffset, n, offset);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CalendarApi.SearchCalendarEventsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **searchTerm** | **string** | Search term for calendar events. |  |
| **utcOffset** | **int?** | The offset from UTC in hours of the client or authenticated user. | [optional]  |
| **n** | **int?** | The number of objects to return. | [optional] [default to 60] |
| **offset** | **int?** | A zero-based offset from the default object sorting from where search results start. | [optional]  |

### Return type

[**PaginatedCalendarEventList**](PaginatedCalendarEventList.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a list of CalendarEvent objects. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updategroupcalendarevent"></a>
# **UpdateGroupCalendarEvent**
> CalendarEvent UpdateGroupCalendarEvent (string groupId, string calendarId, UpdateCalendarEventRequest updateCalendarEventRequest)

Update a calendar event

Updates an event for a group on the calendar

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class UpdateGroupCalendarEventExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vrchat.cloud/api/1";
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new CalendarApi(config);
            var groupId = grp_00000000-0000-0000-0000-000000000000;  // string | Must be a valid group ID.
            var calendarId = cal_00000000-0000-0000-0000-000000000000;  // string | Must be a valid calendar ID.
            var updateCalendarEventRequest = new UpdateCalendarEventRequest(); // UpdateCalendarEventRequest | 

            try
            {
                // Update a calendar event
                CalendarEvent result = apiInstance.UpdateGroupCalendarEvent(groupId, calendarId, updateCalendarEventRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CalendarApi.UpdateGroupCalendarEvent: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateGroupCalendarEventWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a calendar event
    ApiResponse<CalendarEvent> response = apiInstance.UpdateGroupCalendarEventWithHttpInfo(groupId, calendarId, updateCalendarEventRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CalendarApi.UpdateGroupCalendarEventWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **string** | Must be a valid group ID. |  |
| **calendarId** | **string** | Must be a valid calendar ID. |  |
| **updateCalendarEventRequest** | [**UpdateCalendarEventRequest**](UpdateCalendarEventRequest.md) |  |  |

### Return type

[**CalendarEvent**](CalendarEvent.md)

### Authorization

[authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a single CalendarEvent object. |  -  |
| **401** | Error response due to missing auth cookie. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

