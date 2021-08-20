# io.github.vrchatapi.Api.FilesApi

All URIs are relative to *https://api.vrchat.cloud/api/1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateFile**](FilesApi.md#createfile) | **POST** /file | Create File
[**CreateFileVersion**](FilesApi.md#createfileversion) | **POST** /file/{fileId} | Create File Version
[**DeleteFile**](FilesApi.md#deletefile) | **DELETE** /file/{fileId} | Delete File
[**DeleteFileVersion**](FilesApi.md#deletefileversion) | **DELETE** /file/{fileId}/{versionId} | Delete File Version
[**DownloadFileVersion**](FilesApi.md#downloadfileversion) | **GET** /file/{fileId}/{versionId} | Download File Version
[**FinishFileDataUpload**](FilesApi.md#finishfiledataupload) | **PUT** /file/{fileId}/{versionId}/{fileType}/finish | Finish FileData Upload
[**GetFile**](FilesApi.md#getfile) | **GET** /file/{fileId} | Show File
[**GetFileDataUploadStatus**](FilesApi.md#getfiledatauploadstatus) | **GET** /file/{fileId}/{versionId}/{fileType}/status | Check FileData Upload Status
[**GetFiles**](FilesApi.md#getfiles) | **GET** /files | List Files
[**StartFileDataUpload**](FilesApi.md#startfiledataupload) | **PUT** /file/{fileId}/{versionId}/{fileType}/start | Start FileData Upload



## CreateFile

> File CreateFile (InlineObject3 inlineObject3 = null)

Create File

Creates a new File object

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using io.github.vrchatapi.Api;
using io.github.vrchatapi.Client;
using io.github.vrchatapi.Model;

namespace Example
{
    public class CreateFileExample
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

            var apiInstance = new FilesApi(Configuration.Default);
            var inlineObject3 = new InlineObject3(); // InlineObject3 |  (optional) 

            try
            {
                // Create File
                File result = apiInstance.CreateFile(inlineObject3);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling FilesApi.CreateFile: " + e.Message );
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
 **inlineObject3** | [**InlineObject3**](InlineObject3.md)|  | [optional] 

### Return type

[**File**](File.md)

### Authorization

[apiKeyCookie](../README.md#apiKeyCookie), [authCookie](../README.md#authCookie)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a single File object. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CreateFileVersion

> File CreateFileVersion (string fileId, InlineObject4 inlineObject4 = null)

Create File Version

Creates a new FileVersion. Once a Version has been created, proceed to the `/file/{fileId}/{versionId}/file/start` endpoint to start a file upload.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using io.github.vrchatapi.Api;
using io.github.vrchatapi.Client;
using io.github.vrchatapi.Model;

namespace Example
{
    public class CreateFileVersionExample
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

            var apiInstance = new FilesApi(Configuration.Default);
            var fileId = file_00000000-0000-0000-0000-000000000000;  // string | 
            var inlineObject4 = new InlineObject4(); // InlineObject4 |  (optional) 

            try
            {
                // Create File Version
                File result = apiInstance.CreateFileVersion(fileId, inlineObject4);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling FilesApi.CreateFileVersion: " + e.Message );
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
 **fileId** | **string**|  | 
 **inlineObject4** | [**InlineObject4**](InlineObject4.md)|  | [optional] 

### Return type

[**File**](File.md)

### Authorization

[apiKeyCookie](../README.md#apiKeyCookie), [authCookie](../README.md#authCookie)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a single File object. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteFile

> Success DeleteFile (string fileId)

Delete File

Deletes a File object.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using io.github.vrchatapi.Api;
using io.github.vrchatapi.Client;
using io.github.vrchatapi.Model;

namespace Example
{
    public class DeleteFileExample
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

            var apiInstance = new FilesApi(Configuration.Default);
            var fileId = file_00000000-0000-0000-0000-000000000000;  // string | 

            try
            {
                // Delete File
                Success result = apiInstance.DeleteFile(fileId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling FilesApi.DeleteFile: " + e.Message );
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
 **fileId** | **string**|  | 

### Return type

[**Success**](Success.md)

### Authorization

[apiKeyCookie](../README.md#apiKeyCookie), [authCookie](../README.md#authCookie)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response after deleting a File. |  -  |
| **404** | Error response when trying to delete a non-existent file. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteFileVersion

> File DeleteFileVersion (string fileId, int versionId)

Delete File Version

Delete a specific version of a file. You can only delete the latest version.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using io.github.vrchatapi.Api;
using io.github.vrchatapi.Client;
using io.github.vrchatapi.Model;

namespace Example
{
    public class DeleteFileVersionExample
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

            var apiInstance = new FilesApi(Configuration.Default);
            var fileId = file_00000000-0000-0000-0000-000000000000;  // string | 
            var versionId = 1;  // int | 

            try
            {
                // Delete File Version
                File result = apiInstance.DeleteFileVersion(fileId, versionId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling FilesApi.DeleteFileVersion: " + e.Message );
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
 **fileId** | **string**|  | 
 **versionId** | **int**|  | 

### Return type

[**File**](File.md)

### Authorization

[apiKeyCookie](../README.md#apiKeyCookie), [authCookie](../README.md#authCookie)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a single File object. |  -  |
| **400** | Error response when trying to delete the initial version of a file. Delete the main File object instead. |  -  |
| **500** | Error response when trying to delete any version of a file that is not hte last one. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DownloadFileVersion

> void DownloadFileVersion (string fileId, int versionId)

Download File Version

Downloads the file with the provided version number.  **Version Note:** Version 0 is always when the file was created. The real data is usually always located in version 1 and up.  **Extension Note:** Files are not guaranteed to have a file extensions. UnityPackage files tends to have it, images through this endpoint do not. You are responsible for appending file extension from the `extension` field when neccesary.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using io.github.vrchatapi.Api;
using io.github.vrchatapi.Client;
using io.github.vrchatapi.Model;

namespace Example
{
    public class DownloadFileVersionExample
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

            var apiInstance = new FilesApi(Configuration.Default);
            var fileId = file_00000000-0000-0000-0000-000000000000;  // string | 
            var versionId = 1;  // int | 

            try
            {
                // Download File Version
                apiInstance.DownloadFileVersion(fileId, versionId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling FilesApi.DownloadFileVersion: " + e.Message );
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
 **fileId** | **string**|  | 
 **versionId** | **int**|  | 

### Return type

void (empty response body)

### Authorization

[apiKeyCookie](../README.md#apiKeyCookie), [authCookie](../README.md#authCookie)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Raw file |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## FinishFileDataUpload

> File FinishFileDataUpload (string fileId, int versionId, string fileType, InlineObject5 inlineObject5 = null)

Finish FileData Upload

Finish an upload of a FileData. This will mark it as \"complete\". After uploading the `file` for Avatars and Worlds you then have to upload a `signature` file.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using io.github.vrchatapi.Api;
using io.github.vrchatapi.Client;
using io.github.vrchatapi.Model;

namespace Example
{
    public class FinishFileDataUploadExample
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

            var apiInstance = new FilesApi(Configuration.Default);
            var fileId = file_00000000-0000-0000-0000-000000000000;  // string | 
            var versionId = 1;  // int | 
            var fileType = file;  // string | 
            var inlineObject5 = new InlineObject5(); // InlineObject5 |  (optional) 

            try
            {
                // Finish FileData Upload
                File result = apiInstance.FinishFileDataUpload(fileId, versionId, fileType, inlineObject5);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling FilesApi.FinishFileDataUpload: " + e.Message );
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
 **fileId** | **string**|  | 
 **versionId** | **int**|  | 
 **fileType** | **string**|  | 
 **inlineObject5** | [**InlineObject5**](InlineObject5.md)|  | [optional] 

### Return type

[**File**](File.md)

### Authorization

[apiKeyCookie](../README.md#apiKeyCookie), [authCookie](../README.md#authCookie)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a single File object. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetFile

> File GetFile (string fileId)

Show File

Shows general information about the \"File\" object. Each File can have several \"Version\"'s, and each Version can have multiple real files or \"Data\" blobs.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using io.github.vrchatapi.Api;
using io.github.vrchatapi.Client;
using io.github.vrchatapi.Model;

namespace Example
{
    public class GetFileExample
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

            var apiInstance = new FilesApi(Configuration.Default);
            var fileId = file_00000000-0000-0000-0000-000000000000;  // string | 

            try
            {
                // Show File
                File result = apiInstance.GetFile(fileId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling FilesApi.GetFile: " + e.Message );
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
 **fileId** | **string**|  | 

### Return type

[**File**](File.md)

### Authorization

[apiKeyCookie](../README.md#apiKeyCookie), [authCookie](../README.md#authCookie)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a single File object. |  -  |
| **404** | Error response when trying to show information about a non-existent file. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetFileDataUploadStatus

> InlineResponse2004 GetFileDataUploadStatus (string fileId, int versionId, string fileType)

Check FileData Upload Status

Retrieves the upload status for file upload. Can currently only be accessed when `status` is `waiting`. Trying to access it on a file version already uploaded currently times out.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using io.github.vrchatapi.Api;
using io.github.vrchatapi.Client;
using io.github.vrchatapi.Model;

namespace Example
{
    public class GetFileDataUploadStatusExample
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

            var apiInstance = new FilesApi(Configuration.Default);
            var fileId = file_00000000-0000-0000-0000-000000000000;  // string | 
            var versionId = 1;  // int | 
            var fileType = file;  // string | 

            try
            {
                // Check FileData Upload Status
                InlineResponse2004 result = apiInstance.GetFileDataUploadStatus(fileId, versionId, fileType);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling FilesApi.GetFileDataUploadStatus: " + e.Message );
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
 **fileId** | **string**|  | 
 **versionId** | **int**|  | 
 **fileType** | **string**|  | 

### Return type

[**InlineResponse2004**](InlineResponse2004.md)

### Authorization

[apiKeyCookie](../README.md#apiKeyCookie), [authCookie](../README.md#authCookie)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Current FileVersion upload status. Contains the uploadId needed for uploading, as well as the already uploaded parts. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetFiles

> List&lt;File&gt; GetFiles (string tag = null, string userId = null, int? n = null, int? offset = null)

List Files

Returns a list of files

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using io.github.vrchatapi.Api;
using io.github.vrchatapi.Client;
using io.github.vrchatapi.Model;

namespace Example
{
    public class GetFilesExample
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

            var apiInstance = new FilesApi(Configuration.Default);
            var tag = tag_example;  // string | Tag, for example \"icon\" or \"gallery\", not included by default. (optional) 
            var userId = userId_example;  // string | UserID, will always generate a 500 permission error. (optional) 
            var n = 56;  // int? | The number of objects to return. (optional)  (default to 60)
            var offset = 56;  // int? | A zero-based offset from the default object sorting from where search results start. (optional) 

            try
            {
                // List Files
                List<File> result = apiInstance.GetFiles(tag, userId, n, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling FilesApi.GetFiles: " + e.Message );
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
 **tag** | **string**| Tag, for example \&quot;icon\&quot; or \&quot;gallery\&quot;, not included by default. | [optional] 
 **userId** | **string**| UserID, will always generate a 500 permission error. | [optional] 
 **n** | **int?**| The number of objects to return. | [optional] [default to 60]
 **offset** | **int?**| A zero-based offset from the default object sorting from where search results start. | [optional] 

### Return type

[**List&lt;File&gt;**](File.md)

### Authorization

[apiKeyCookie](../README.md#apiKeyCookie), [authCookie](../README.md#authCookie)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a list of File objects. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## StartFileDataUpload

> InlineResponse2005 StartFileDataUpload (string fileId, int versionId, string fileType, int partNumber)

Start FileData Upload

Starts an upload of a specific FilePart. This endpoint will return an AWS URL which you can PUT data to. You need to call this and receive a new AWS API URL for each `partNumber`. Please see AWS's REST documentation on \"PUT Object to S3\" on how to upload. Once all parts has been uploaded, proceed to `/finish` endpoint.  **Note:** `nextPartNumber` seems like it is always ignored. Despite it returning 0, first partNumber is always 1.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using io.github.vrchatapi.Api;
using io.github.vrchatapi.Client;
using io.github.vrchatapi.Model;

namespace Example
{
    public class StartFileDataUploadExample
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

            var apiInstance = new FilesApi(Configuration.Default);
            var fileId = file_00000000-0000-0000-0000-000000000000;  // string | 
            var versionId = 1;  // int | 
            var fileType = file;  // string | 
            var partNumber = 1;  // int | 

            try
            {
                // Start FileData Upload
                InlineResponse2005 result = apiInstance.StartFileDataUpload(fileId, versionId, fileType, partNumber);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling FilesApi.StartFileDataUpload: " + e.Message );
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
 **fileId** | **string**|  | 
 **versionId** | **int**|  | 
 **fileType** | **string**|  | 
 **partNumber** | **int**|  | 

### Return type

[**InlineResponse2005**](InlineResponse2005.md)

### Authorization

[apiKeyCookie](../README.md#apiKeyCookie), [authCookie](../README.md#authCookie)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | See [https://docs.aws.amazon.com/AmazonS3/latest/API/API_PutObject.html](AWS REST docs - PUT Object) |  -  |
| **400** | Error response when trying to start an upload against a FileVersion that is already marked as  &#x60;complete&#x60;. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

