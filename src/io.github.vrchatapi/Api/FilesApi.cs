/*
 * VRChat API Documentation
 *
 * ![VRChat API Banner](https://vrchatapi.github.io/assets/img/api_banner_1500x400.png)  # Welcome to the VRChat API  Before we begin, we would like to state this is a **COMMUNITY DRIVEN PROJECT**. This means that everything you read on here was written by the community itself and is **not** officially supported by VRChat. The documentation is provided \"AS IS\", and any action you take towards VRChat is completely your own responsibility.  The documentation and additional libraries SHALL ONLY be used for applications interacting with VRChat's API in accordance with their [Terms of Service](https://github.com/VRChatAPI), and MUST NOT be used for modifying the client, \"avatar ripping\", or other illegal activities. Malicious usage or spamming the API may result in account termination. Certain parts of the API are also more sensitive than others, for example moderation, so please read tread extra carefully and read the warnings when present.  ![Tupper Policy on API](https://i.imgur.com/yLlW7Ok.png)  Finally, use of the API using applications other than the approved methods (website, VRChat application, Unity SDK) is not officially supported. VRChat provides no guarantee or support for external applications using the API. Access to API endpoints may break **at any time, without notice**. Therefore, please **do not ping** VRChat Staff in the VRChat Discord if you are having API problems, as they do not provide API support. We will make a best effort in keeping this documentation and associated language libraries up to date, but things might be outdated or missing. If you find that something is no longer valid, please contact us on Discord or [create an issue](https://github.com/vrchatapi/specification/issues) and tell us so we can fix it.  # Getting Started  The VRChat API can be used to programmatically retrieve or update information regarding your profile, friends, avatars, worlds and more. The API consists of two parts, \"Photon\" which is only used in-game, and the \"Web API\" which is used by both the game and the website. This documentation focuses only on the Web API.  The API is designed around the REST ideology, providing semi-simple and usually predictable URIs to access and modify objects. Requests support standard HTTP methods like GET, PUT, POST, and DELETE and standard status codes. Response bodies are always UTF-8 encoded JSON objects, unless explicitly documented otherwise.  <div class=\"callout callout-error\">   <strong>🛑 Warning! Do not touch Photon!</strong><br>   Photon is only used by the in-game client and should <b>not</b> be touched. Doing so may result in permanent account termination. </div>  <div class=\"callout callout-info\">   <strong>ℹ️ API Key and Authentication</strong><br>   The API Key has always been the same and is currently <code>JlE5Jldo5Jibnk5O5hTx6XVqsJu4WJ26</code>.   Read <a href=\"#tag- -authentication\">Authentication</a> for how to log in. </div>  # Using the API  For simply exploring what the API can do it is strongly recommended to download [Insomnia](https://insomnia.rest/download), a free and open-source API client that's great for sending requests to the API in an orderly fashion. Insomnia allows you to send data in the format that's required for VRChat's API. It is also possible to try out the API in your browser, by first logging in at [vrchat.com/home](https://vrchat.com/home/) and then going to [vrchat.com/api/1/auth/user](https://vrchat.com/api/1/auth/user), but the information will be much harder to work with.  For more permanent operation such as software development it is instead recommended to use one of the existing language SDKs. This community project maintains API libraries in several languages, which allows you to interact with the API with simple function calls rather than having to implement the HTTP protocol yourself. Most of these libraries are automatically generated from the API specification, sometimes with additional helpful wrapper code to make usage easier. This allows them to be almost automatically updated and expanded upon as soon as a new feature is introduced in the specification itself. The libraries can be found on [GitHub](https://github.com/vrchatapi) or following:  * [NodeJS (JavaScript)](https://www.npmjs.com/package/vrchat) * [Dart](https://pub.dev/packages/vrchat_dart) * [Rust](https://crates.io/crates/vrchatapi) * [C#](github.com/vrchatapi/vrchatapi-csharp) * [Python](https://github.com/vrchatapi/VRChatPython)  # Pagination  Most endpoints enforce pagination, meaning they will only return 10 entries by default, and never more than 100.<br> Using both the limit and offset parameters allows you to easily paginate through a large number of objects.  | Query Parameter | Type | Description | | - -- -- -- -- -|- -|- -- -- -- | | `limit` | integer  | The number of objects to return. This value often defaults to 10. Highest limit is always 100.| | `offset` | integer  | A zero-based offset from the default object sorting.|  If a request returns fewer objects than the `limit` parameter, there are no more items available to return.  # Contribution  Do you want to get involved in the documentation effort? Do you want to help improve one of the language API libraries? This project is an [OPEN Open Source Project](https://openopensource.org)! This means that individuals making significant and valuable contributions are given commit-access to the project. It also means we are very open and welcoming of new people making contributions, unlike some more guarded open-source projects.  [![Discord](https://img.shields.io/static/v1?label=vrchatapi&message=discord&color=blueviolet&style=for-the-badge)](https://discord.gg/qjZE9C9fkB)
 *
 * The version of the OpenAPI document: 1.0.2
 * Contact: me@ruby.js.org
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using RestSharp;
using io.github.vrchatapi.Client;
using io.github.vrchatapi.Model;

namespace io.github.vrchatapi.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IFilesApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Create File
        /// </summary>
        /// <remarks>
        /// Creates a new File object
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inlineObject3"> (optional)</param>
        /// <returns>File</returns>
        File CreateFile (InlineObject3 inlineObject3 = default(InlineObject3));

        /// <summary>
        /// Create File
        /// </summary>
        /// <remarks>
        /// Creates a new File object
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inlineObject3"> (optional)</param>
        /// <returns>ApiResponse of File</returns>
        ApiResponse<File> CreateFileWithHttpInfo (InlineObject3 inlineObject3 = default(InlineObject3));
        /// <summary>
        /// Create File Version
        /// </summary>
        /// <remarks>
        /// Creates a new FileVersion. Once a Version has been created, proceed to the &#x60;/file/{fileId}/{versionId}/file/start&#x60; endpoint to start a file upload.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <param name="inlineObject4"> (optional)</param>
        /// <returns>File</returns>
        File CreateFileVersion (string fileId, InlineObject4 inlineObject4 = default(InlineObject4));

        /// <summary>
        /// Create File Version
        /// </summary>
        /// <remarks>
        /// Creates a new FileVersion. Once a Version has been created, proceed to the &#x60;/file/{fileId}/{versionId}/file/start&#x60; endpoint to start a file upload.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <param name="inlineObject4"> (optional)</param>
        /// <returns>ApiResponse of File</returns>
        ApiResponse<File> CreateFileVersionWithHttpInfo (string fileId, InlineObject4 inlineObject4 = default(InlineObject4));
        /// <summary>
        /// Delete File
        /// </summary>
        /// <remarks>
        /// Deletes a File object.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <returns>Success</returns>
        Success DeleteFile (string fileId);

        /// <summary>
        /// Delete File
        /// </summary>
        /// <remarks>
        /// Deletes a File object.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <returns>ApiResponse of Success</returns>
        ApiResponse<Success> DeleteFileWithHttpInfo (string fileId);
        /// <summary>
        /// Delete File Version
        /// </summary>
        /// <remarks>
        /// Delete a specific version of a file. You can only delete the latest version.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <param name="versionId"></param>
        /// <returns>File</returns>
        File DeleteFileVersion (string fileId, int versionId);

        /// <summary>
        /// Delete File Version
        /// </summary>
        /// <remarks>
        /// Delete a specific version of a file. You can only delete the latest version.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <param name="versionId"></param>
        /// <returns>ApiResponse of File</returns>
        ApiResponse<File> DeleteFileVersionWithHttpInfo (string fileId, int versionId);
        /// <summary>
        /// Download File Version
        /// </summary>
        /// <remarks>
        /// Downloads the file with the provided version number.  **Version Note:** Version 0 is always when the file was created. The real data is usually always located in version 1 and up.  **Extension Note:** Files are not guaranteed to have a file extensions. UnityPackage files tends to have it, images through this endpoint do not. You are responsible for appending file extension from the &#x60;extension&#x60; field when neccesary.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <param name="versionId"></param>
        /// <returns></returns>
        void DownloadFileVersion (string fileId, int versionId);

        /// <summary>
        /// Download File Version
        /// </summary>
        /// <remarks>
        /// Downloads the file with the provided version number.  **Version Note:** Version 0 is always when the file was created. The real data is usually always located in version 1 and up.  **Extension Note:** Files are not guaranteed to have a file extensions. UnityPackage files tends to have it, images through this endpoint do not. You are responsible for appending file extension from the &#x60;extension&#x60; field when neccesary.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <param name="versionId"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DownloadFileVersionWithHttpInfo (string fileId, int versionId);
        /// <summary>
        /// Finish FileData Upload
        /// </summary>
        /// <remarks>
        /// Finish an upload of a FileData. This will mark it as \&quot;complete\&quot;. After uploading the &#x60;file&#x60; for Avatars and Worlds you then have to upload a &#x60;signature&#x60; file.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <param name="versionId"></param>
        /// <param name="fileType"></param>
        /// <param name="inlineObject5"> (optional)</param>
        /// <returns>File</returns>
        File FinishFileDataUpload (string fileId, int versionId, string fileType, InlineObject5 inlineObject5 = default(InlineObject5));

        /// <summary>
        /// Finish FileData Upload
        /// </summary>
        /// <remarks>
        /// Finish an upload of a FileData. This will mark it as \&quot;complete\&quot;. After uploading the &#x60;file&#x60; for Avatars and Worlds you then have to upload a &#x60;signature&#x60; file.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <param name="versionId"></param>
        /// <param name="fileType"></param>
        /// <param name="inlineObject5"> (optional)</param>
        /// <returns>ApiResponse of File</returns>
        ApiResponse<File> FinishFileDataUploadWithHttpInfo (string fileId, int versionId, string fileType, InlineObject5 inlineObject5 = default(InlineObject5));
        /// <summary>
        /// Show File
        /// </summary>
        /// <remarks>
        /// Shows general information about the \&quot;File\&quot; object. Each File can have several \&quot;Version\&quot;&#39;s, and each Version can have multiple real files or \&quot;Data\&quot; blobs.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <returns>File</returns>
        File GetFile (string fileId);

        /// <summary>
        /// Show File
        /// </summary>
        /// <remarks>
        /// Shows general information about the \&quot;File\&quot; object. Each File can have several \&quot;Version\&quot;&#39;s, and each Version can have multiple real files or \&quot;Data\&quot; blobs.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <returns>ApiResponse of File</returns>
        ApiResponse<File> GetFileWithHttpInfo (string fileId);
        /// <summary>
        /// Check FileData Upload Status
        /// </summary>
        /// <remarks>
        /// Retrieves the upload status for file upload. Can currently only be accessed when &#x60;status&#x60; is &#x60;waiting&#x60;. Trying to access it on a file version already uploaded currently times out.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <param name="versionId"></param>
        /// <param name="fileType"></param>
        /// <returns>InlineResponse2004</returns>
        InlineResponse2004 GetFileDataUploadStatus (string fileId, int versionId, string fileType);

        /// <summary>
        /// Check FileData Upload Status
        /// </summary>
        /// <remarks>
        /// Retrieves the upload status for file upload. Can currently only be accessed when &#x60;status&#x60; is &#x60;waiting&#x60;. Trying to access it on a file version already uploaded currently times out.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <param name="versionId"></param>
        /// <param name="fileType"></param>
        /// <returns>ApiResponse of InlineResponse2004</returns>
        ApiResponse<InlineResponse2004> GetFileDataUploadStatusWithHttpInfo (string fileId, int versionId, string fileType);
        /// <summary>
        /// List Files
        /// </summary>
        /// <remarks>
        /// Returns a list of files
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tag">Tag, for example \&quot;icon\&quot; or \&quot;gallery\&quot;, not included by default. (optional)</param>
        /// <param name="userId">UserID, will always generate a 500 permission error. (optional)</param>
        /// <param name="n">The number of objects to return. (optional, default to 60)</param>
        /// <param name="offset">A zero-based offset from the default object sorting from where search results start. (optional)</param>
        /// <returns>List&lt;File&gt;</returns>
        List<File> GetFiles (string tag = default(string), string userId = default(string), int? n = default(int?), int? offset = default(int?));

        /// <summary>
        /// List Files
        /// </summary>
        /// <remarks>
        /// Returns a list of files
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tag">Tag, for example \&quot;icon\&quot; or \&quot;gallery\&quot;, not included by default. (optional)</param>
        /// <param name="userId">UserID, will always generate a 500 permission error. (optional)</param>
        /// <param name="n">The number of objects to return. (optional, default to 60)</param>
        /// <param name="offset">A zero-based offset from the default object sorting from where search results start. (optional)</param>
        /// <returns>ApiResponse of List&lt;File&gt;</returns>
        ApiResponse<List<File>> GetFilesWithHttpInfo (string tag = default(string), string userId = default(string), int? n = default(int?), int? offset = default(int?));
        /// <summary>
        /// Start FileData Upload
        /// </summary>
        /// <remarks>
        /// Starts an upload of a specific FilePart. This endpoint will return an AWS URL which you can PUT data to. You need to call this and receive a new AWS API URL for each &#x60;partNumber&#x60;. Please see AWS&#39;s REST documentation on \&quot;PUT Object to S3\&quot; on how to upload. Once all parts has been uploaded, proceed to &#x60;/finish&#x60; endpoint.  **Note:** &#x60;nextPartNumber&#x60; seems like it is always ignored. Despite it returning 0, first partNumber is always 1.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <param name="versionId"></param>
        /// <param name="fileType"></param>
        /// <param name="partNumber"></param>
        /// <returns>InlineResponse2005</returns>
        InlineResponse2005 StartFileDataUpload (string fileId, int versionId, string fileType, int partNumber);

        /// <summary>
        /// Start FileData Upload
        /// </summary>
        /// <remarks>
        /// Starts an upload of a specific FilePart. This endpoint will return an AWS URL which you can PUT data to. You need to call this and receive a new AWS API URL for each &#x60;partNumber&#x60;. Please see AWS&#39;s REST documentation on \&quot;PUT Object to S3\&quot; on how to upload. Once all parts has been uploaded, proceed to &#x60;/finish&#x60; endpoint.  **Note:** &#x60;nextPartNumber&#x60; seems like it is always ignored. Despite it returning 0, first partNumber is always 1.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <param name="versionId"></param>
        /// <param name="fileType"></param>
        /// <param name="partNumber"></param>
        /// <returns>ApiResponse of InlineResponse2005</returns>
        ApiResponse<InlineResponse2005> StartFileDataUploadWithHttpInfo (string fileId, int versionId, string fileType, int partNumber);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Create File
        /// </summary>
        /// <remarks>
        /// Creates a new File object
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inlineObject3"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of File</returns>
        System.Threading.Tasks.Task<File> CreateFileAsync (InlineObject3 inlineObject3 = default(InlineObject3), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Create File
        /// </summary>
        /// <remarks>
        /// Creates a new File object
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inlineObject3"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (File)</returns>
        System.Threading.Tasks.Task<ApiResponse<File>> CreateFileWithHttpInfoAsync (InlineObject3 inlineObject3 = default(InlineObject3), CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create File Version
        /// </summary>
        /// <remarks>
        /// Creates a new FileVersion. Once a Version has been created, proceed to the &#x60;/file/{fileId}/{versionId}/file/start&#x60; endpoint to start a file upload.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <param name="inlineObject4"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of File</returns>
        System.Threading.Tasks.Task<File> CreateFileVersionAsync (string fileId, InlineObject4 inlineObject4 = default(InlineObject4), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Create File Version
        /// </summary>
        /// <remarks>
        /// Creates a new FileVersion. Once a Version has been created, proceed to the &#x60;/file/{fileId}/{versionId}/file/start&#x60; endpoint to start a file upload.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <param name="inlineObject4"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (File)</returns>
        System.Threading.Tasks.Task<ApiResponse<File>> CreateFileVersionWithHttpInfoAsync (string fileId, InlineObject4 inlineObject4 = default(InlineObject4), CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete File
        /// </summary>
        /// <remarks>
        /// Deletes a File object.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of Success</returns>
        System.Threading.Tasks.Task<Success> DeleteFileAsync (string fileId, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Delete File
        /// </summary>
        /// <remarks>
        /// Deletes a File object.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (Success)</returns>
        System.Threading.Tasks.Task<ApiResponse<Success>> DeleteFileWithHttpInfoAsync (string fileId, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete File Version
        /// </summary>
        /// <remarks>
        /// Delete a specific version of a file. You can only delete the latest version.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <param name="versionId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of File</returns>
        System.Threading.Tasks.Task<File> DeleteFileVersionAsync (string fileId, int versionId, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Delete File Version
        /// </summary>
        /// <remarks>
        /// Delete a specific version of a file. You can only delete the latest version.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <param name="versionId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (File)</returns>
        System.Threading.Tasks.Task<ApiResponse<File>> DeleteFileVersionWithHttpInfoAsync (string fileId, int versionId, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Download File Version
        /// </summary>
        /// <remarks>
        /// Downloads the file with the provided version number.  **Version Note:** Version 0 is always when the file was created. The real data is usually always located in version 1 and up.  **Extension Note:** Files are not guaranteed to have a file extensions. UnityPackage files tends to have it, images through this endpoint do not. You are responsible for appending file extension from the &#x60;extension&#x60; field when neccesary.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <param name="versionId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DownloadFileVersionAsync (string fileId, int versionId, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Download File Version
        /// </summary>
        /// <remarks>
        /// Downloads the file with the provided version number.  **Version Note:** Version 0 is always when the file was created. The real data is usually always located in version 1 and up.  **Extension Note:** Files are not guaranteed to have a file extensions. UnityPackage files tends to have it, images through this endpoint do not. You are responsible for appending file extension from the &#x60;extension&#x60; field when neccesary.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <param name="versionId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DownloadFileVersionWithHttpInfoAsync (string fileId, int versionId, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Finish FileData Upload
        /// </summary>
        /// <remarks>
        /// Finish an upload of a FileData. This will mark it as \&quot;complete\&quot;. After uploading the &#x60;file&#x60; for Avatars and Worlds you then have to upload a &#x60;signature&#x60; file.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <param name="versionId"></param>
        /// <param name="fileType"></param>
        /// <param name="inlineObject5"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of File</returns>
        System.Threading.Tasks.Task<File> FinishFileDataUploadAsync (string fileId, int versionId, string fileType, InlineObject5 inlineObject5 = default(InlineObject5), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Finish FileData Upload
        /// </summary>
        /// <remarks>
        /// Finish an upload of a FileData. This will mark it as \&quot;complete\&quot;. After uploading the &#x60;file&#x60; for Avatars and Worlds you then have to upload a &#x60;signature&#x60; file.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <param name="versionId"></param>
        /// <param name="fileType"></param>
        /// <param name="inlineObject5"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (File)</returns>
        System.Threading.Tasks.Task<ApiResponse<File>> FinishFileDataUploadWithHttpInfoAsync (string fileId, int versionId, string fileType, InlineObject5 inlineObject5 = default(InlineObject5), CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Show File
        /// </summary>
        /// <remarks>
        /// Shows general information about the \&quot;File\&quot; object. Each File can have several \&quot;Version\&quot;&#39;s, and each Version can have multiple real files or \&quot;Data\&quot; blobs.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of File</returns>
        System.Threading.Tasks.Task<File> GetFileAsync (string fileId, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Show File
        /// </summary>
        /// <remarks>
        /// Shows general information about the \&quot;File\&quot; object. Each File can have several \&quot;Version\&quot;&#39;s, and each Version can have multiple real files or \&quot;Data\&quot; blobs.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (File)</returns>
        System.Threading.Tasks.Task<ApiResponse<File>> GetFileWithHttpInfoAsync (string fileId, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Check FileData Upload Status
        /// </summary>
        /// <remarks>
        /// Retrieves the upload status for file upload. Can currently only be accessed when &#x60;status&#x60; is &#x60;waiting&#x60;. Trying to access it on a file version already uploaded currently times out.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <param name="versionId"></param>
        /// <param name="fileType"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of InlineResponse2004</returns>
        System.Threading.Tasks.Task<InlineResponse2004> GetFileDataUploadStatusAsync (string fileId, int versionId, string fileType, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Check FileData Upload Status
        /// </summary>
        /// <remarks>
        /// Retrieves the upload status for file upload. Can currently only be accessed when &#x60;status&#x60; is &#x60;waiting&#x60;. Trying to access it on a file version already uploaded currently times out.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <param name="versionId"></param>
        /// <param name="fileType"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (InlineResponse2004)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2004>> GetFileDataUploadStatusWithHttpInfoAsync (string fileId, int versionId, string fileType, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// List Files
        /// </summary>
        /// <remarks>
        /// Returns a list of files
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tag">Tag, for example \&quot;icon\&quot; or \&quot;gallery\&quot;, not included by default. (optional)</param>
        /// <param name="userId">UserID, will always generate a 500 permission error. (optional)</param>
        /// <param name="n">The number of objects to return. (optional, default to 60)</param>
        /// <param name="offset">A zero-based offset from the default object sorting from where search results start. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of List&lt;File&gt;</returns>
        System.Threading.Tasks.Task<List<File>> GetFilesAsync (string tag = default(string), string userId = default(string), int? n = default(int?), int? offset = default(int?), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// List Files
        /// </summary>
        /// <remarks>
        /// Returns a list of files
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tag">Tag, for example \&quot;icon\&quot; or \&quot;gallery\&quot;, not included by default. (optional)</param>
        /// <param name="userId">UserID, will always generate a 500 permission error. (optional)</param>
        /// <param name="n">The number of objects to return. (optional, default to 60)</param>
        /// <param name="offset">A zero-based offset from the default object sorting from where search results start. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (List&lt;File&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<File>>> GetFilesWithHttpInfoAsync (string tag = default(string), string userId = default(string), int? n = default(int?), int? offset = default(int?), CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Start FileData Upload
        /// </summary>
        /// <remarks>
        /// Starts an upload of a specific FilePart. This endpoint will return an AWS URL which you can PUT data to. You need to call this and receive a new AWS API URL for each &#x60;partNumber&#x60;. Please see AWS&#39;s REST documentation on \&quot;PUT Object to S3\&quot; on how to upload. Once all parts has been uploaded, proceed to &#x60;/finish&#x60; endpoint.  **Note:** &#x60;nextPartNumber&#x60; seems like it is always ignored. Despite it returning 0, first partNumber is always 1.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <param name="versionId"></param>
        /// <param name="fileType"></param>
        /// <param name="partNumber"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of InlineResponse2005</returns>
        System.Threading.Tasks.Task<InlineResponse2005> StartFileDataUploadAsync (string fileId, int versionId, string fileType, int partNumber, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Start FileData Upload
        /// </summary>
        /// <remarks>
        /// Starts an upload of a specific FilePart. This endpoint will return an AWS URL which you can PUT data to. You need to call this and receive a new AWS API URL for each &#x60;partNumber&#x60;. Please see AWS&#39;s REST documentation on \&quot;PUT Object to S3\&quot; on how to upload. Once all parts has been uploaded, proceed to &#x60;/finish&#x60; endpoint.  **Note:** &#x60;nextPartNumber&#x60; seems like it is always ignored. Despite it returning 0, first partNumber is always 1.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <param name="versionId"></param>
        /// <param name="fileType"></param>
        /// <param name="partNumber"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (InlineResponse2005)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2005>> StartFileDataUploadWithHttpInfoAsync (string fileId, int versionId, string fileType, int partNumber, CancellationToken cancellationToken = default(CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class FilesApi : IFilesApi
    {
        private io.github.vrchatapi.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="FilesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public FilesApi(String basePath)
        {
            this.Configuration = new io.github.vrchatapi.Client.Configuration { BasePath = basePath };

            ExceptionFactory = io.github.vrchatapi.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FilesApi"/> class
        /// </summary>
        /// <returns></returns>
        public FilesApi()
        {
            this.Configuration = io.github.vrchatapi.Client.Configuration.Default;

            ExceptionFactory = io.github.vrchatapi.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FilesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public FilesApi(io.github.vrchatapi.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = io.github.vrchatapi.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = io.github.vrchatapi.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public io.github.vrchatapi.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public io.github.vrchatapi.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Create File Creates a new File object
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inlineObject3"> (optional)</param>
        /// <returns>File</returns>
        public File CreateFile (InlineObject3 inlineObject3 = default(InlineObject3))
        {
             ApiResponse<File> localVarResponse = CreateFileWithHttpInfo(inlineObject3);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create File Creates a new File object
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inlineObject3"> (optional)</param>
        /// <returns>ApiResponse of File</returns>
        public ApiResponse<File> CreateFileWithHttpInfo (InlineObject3 inlineObject3 = default(InlineObject3))
        {

            var localVarPath = "/file";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (inlineObject3 != null && inlineObject3.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(inlineObject3); // http body (model) parameter
            }
            else
            {
                localVarPostBody = inlineObject3; // byte array
            }

            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateFile", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<File>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (File) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(File)));
        }

        /// <summary>
        /// Create File Creates a new File object
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inlineObject3"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of File</returns>
        public async System.Threading.Tasks.Task<File> CreateFileAsync (InlineObject3 inlineObject3 = default(InlineObject3), CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<File> localVarResponse = await CreateFileWithHttpInfoAsync(inlineObject3, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create File Creates a new File object
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inlineObject3"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (File)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<File>> CreateFileWithHttpInfoAsync (InlineObject3 inlineObject3 = default(InlineObject3), CancellationToken cancellationToken = default(CancellationToken))
        {

            var localVarPath = "/file";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (inlineObject3 != null && inlineObject3.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(inlineObject3); // http body (model) parameter
            }
            else
            {
                localVarPostBody = inlineObject3; // byte array
            }

            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateFile", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<File>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (File) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(File)));
        }

        /// <summary>
        /// Create File Version Creates a new FileVersion. Once a Version has been created, proceed to the &#x60;/file/{fileId}/{versionId}/file/start&#x60; endpoint to start a file upload.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <param name="inlineObject4"> (optional)</param>
        /// <returns>File</returns>
        public File CreateFileVersion (string fileId, InlineObject4 inlineObject4 = default(InlineObject4))
        {
             ApiResponse<File> localVarResponse = CreateFileVersionWithHttpInfo(fileId, inlineObject4);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create File Version Creates a new FileVersion. Once a Version has been created, proceed to the &#x60;/file/{fileId}/{versionId}/file/start&#x60; endpoint to start a file upload.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <param name="inlineObject4"> (optional)</param>
        /// <returns>ApiResponse of File</returns>
        public ApiResponse<File> CreateFileVersionWithHttpInfo (string fileId, InlineObject4 inlineObject4 = default(InlineObject4))
        {
            // verify the required parameter 'fileId' is set
            if (fileId == null)
                throw new ApiException(400, "Missing required parameter 'fileId' when calling FilesApi->CreateFileVersion");

            var localVarPath = "/file/{fileId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (fileId != null) localVarPathParams.Add("fileId", this.Configuration.ApiClient.ParameterToString(fileId)); // path parameter
            if (inlineObject4 != null && inlineObject4.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(inlineObject4); // http body (model) parameter
            }
            else
            {
                localVarPostBody = inlineObject4; // byte array
            }

            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateFileVersion", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<File>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (File) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(File)));
        }

        /// <summary>
        /// Create File Version Creates a new FileVersion. Once a Version has been created, proceed to the &#x60;/file/{fileId}/{versionId}/file/start&#x60; endpoint to start a file upload.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <param name="inlineObject4"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of File</returns>
        public async System.Threading.Tasks.Task<File> CreateFileVersionAsync (string fileId, InlineObject4 inlineObject4 = default(InlineObject4), CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<File> localVarResponse = await CreateFileVersionWithHttpInfoAsync(fileId, inlineObject4, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create File Version Creates a new FileVersion. Once a Version has been created, proceed to the &#x60;/file/{fileId}/{versionId}/file/start&#x60; endpoint to start a file upload.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <param name="inlineObject4"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (File)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<File>> CreateFileVersionWithHttpInfoAsync (string fileId, InlineObject4 inlineObject4 = default(InlineObject4), CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'fileId' is set
            if (fileId == null)
                throw new ApiException(400, "Missing required parameter 'fileId' when calling FilesApi->CreateFileVersion");

            var localVarPath = "/file/{fileId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (fileId != null) localVarPathParams.Add("fileId", this.Configuration.ApiClient.ParameterToString(fileId)); // path parameter
            if (inlineObject4 != null && inlineObject4.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(inlineObject4); // http body (model) parameter
            }
            else
            {
                localVarPostBody = inlineObject4; // byte array
            }

            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateFileVersion", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<File>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (File) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(File)));
        }

        /// <summary>
        /// Delete File Deletes a File object.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <returns>Success</returns>
        public Success DeleteFile (string fileId)
        {
             ApiResponse<Success> localVarResponse = DeleteFileWithHttpInfo(fileId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete File Deletes a File object.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <returns>ApiResponse of Success</returns>
        public ApiResponse<Success> DeleteFileWithHttpInfo (string fileId)
        {
            // verify the required parameter 'fileId' is set
            if (fileId == null)
                throw new ApiException(400, "Missing required parameter 'fileId' when calling FilesApi->DeleteFile");

            var localVarPath = "/file/{fileId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (fileId != null) localVarPathParams.Add("fileId", this.Configuration.ApiClient.ParameterToString(fileId)); // path parameter

            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteFile", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Success>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Success) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Success)));
        }

        /// <summary>
        /// Delete File Deletes a File object.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of Success</returns>
        public async System.Threading.Tasks.Task<Success> DeleteFileAsync (string fileId, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<Success> localVarResponse = await DeleteFileWithHttpInfoAsync(fileId, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete File Deletes a File object.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (Success)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Success>> DeleteFileWithHttpInfoAsync (string fileId, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'fileId' is set
            if (fileId == null)
                throw new ApiException(400, "Missing required parameter 'fileId' when calling FilesApi->DeleteFile");

            var localVarPath = "/file/{fileId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (fileId != null) localVarPathParams.Add("fileId", this.Configuration.ApiClient.ParameterToString(fileId)); // path parameter

            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteFile", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Success>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Success) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Success)));
        }

        /// <summary>
        /// Delete File Version Delete a specific version of a file. You can only delete the latest version.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <param name="versionId"></param>
        /// <returns>File</returns>
        public File DeleteFileVersion (string fileId, int versionId)
        {
             ApiResponse<File> localVarResponse = DeleteFileVersionWithHttpInfo(fileId, versionId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete File Version Delete a specific version of a file. You can only delete the latest version.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <param name="versionId"></param>
        /// <returns>ApiResponse of File</returns>
        public ApiResponse<File> DeleteFileVersionWithHttpInfo (string fileId, int versionId)
        {
            // verify the required parameter 'fileId' is set
            if (fileId == null)
                throw new ApiException(400, "Missing required parameter 'fileId' when calling FilesApi->DeleteFileVersion");
            // verify the required parameter 'versionId' is set
            if (versionId == null)
                throw new ApiException(400, "Missing required parameter 'versionId' when calling FilesApi->DeleteFileVersion");

            var localVarPath = "/file/{fileId}/{versionId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (fileId != null) localVarPathParams.Add("fileId", this.Configuration.ApiClient.ParameterToString(fileId)); // path parameter
            if (versionId != null) localVarPathParams.Add("versionId", this.Configuration.ApiClient.ParameterToString(versionId)); // path parameter

            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteFileVersion", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<File>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (File) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(File)));
        }

        /// <summary>
        /// Delete File Version Delete a specific version of a file. You can only delete the latest version.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <param name="versionId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of File</returns>
        public async System.Threading.Tasks.Task<File> DeleteFileVersionAsync (string fileId, int versionId, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<File> localVarResponse = await DeleteFileVersionWithHttpInfoAsync(fileId, versionId, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete File Version Delete a specific version of a file. You can only delete the latest version.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <param name="versionId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (File)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<File>> DeleteFileVersionWithHttpInfoAsync (string fileId, int versionId, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'fileId' is set
            if (fileId == null)
                throw new ApiException(400, "Missing required parameter 'fileId' when calling FilesApi->DeleteFileVersion");
            // verify the required parameter 'versionId' is set
            if (versionId == null)
                throw new ApiException(400, "Missing required parameter 'versionId' when calling FilesApi->DeleteFileVersion");

            var localVarPath = "/file/{fileId}/{versionId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (fileId != null) localVarPathParams.Add("fileId", this.Configuration.ApiClient.ParameterToString(fileId)); // path parameter
            if (versionId != null) localVarPathParams.Add("versionId", this.Configuration.ApiClient.ParameterToString(versionId)); // path parameter

            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteFileVersion", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<File>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (File) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(File)));
        }

        /// <summary>
        /// Download File Version Downloads the file with the provided version number.  **Version Note:** Version 0 is always when the file was created. The real data is usually always located in version 1 and up.  **Extension Note:** Files are not guaranteed to have a file extensions. UnityPackage files tends to have it, images through this endpoint do not. You are responsible for appending file extension from the &#x60;extension&#x60; field when neccesary.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <param name="versionId"></param>
        /// <returns></returns>
        public void DownloadFileVersion (string fileId, int versionId)
        {
             DownloadFileVersionWithHttpInfo(fileId, versionId);
        }

        /// <summary>
        /// Download File Version Downloads the file with the provided version number.  **Version Note:** Version 0 is always when the file was created. The real data is usually always located in version 1 and up.  **Extension Note:** Files are not guaranteed to have a file extensions. UnityPackage files tends to have it, images through this endpoint do not. You are responsible for appending file extension from the &#x60;extension&#x60; field when neccesary.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <param name="versionId"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DownloadFileVersionWithHttpInfo (string fileId, int versionId)
        {
            // verify the required parameter 'fileId' is set
            if (fileId == null)
                throw new ApiException(400, "Missing required parameter 'fileId' when calling FilesApi->DownloadFileVersion");
            // verify the required parameter 'versionId' is set
            if (versionId == null)
                throw new ApiException(400, "Missing required parameter 'versionId' when calling FilesApi->DownloadFileVersion");

            var localVarPath = "/file/{fileId}/{versionId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (fileId != null) localVarPathParams.Add("fileId", this.Configuration.ApiClient.ParameterToString(fileId)); // path parameter
            if (versionId != null) localVarPathParams.Add("versionId", this.Configuration.ApiClient.ParameterToString(versionId)); // path parameter

            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DownloadFileVersion", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Download File Version Downloads the file with the provided version number.  **Version Note:** Version 0 is always when the file was created. The real data is usually always located in version 1 and up.  **Extension Note:** Files are not guaranteed to have a file extensions. UnityPackage files tends to have it, images through this endpoint do not. You are responsible for appending file extension from the &#x60;extension&#x60; field when neccesary.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <param name="versionId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DownloadFileVersionAsync (string fileId, int versionId, CancellationToken cancellationToken = default(CancellationToken))
        {
             await DownloadFileVersionWithHttpInfoAsync(fileId, versionId, cancellationToken);

        }

        /// <summary>
        /// Download File Version Downloads the file with the provided version number.  **Version Note:** Version 0 is always when the file was created. The real data is usually always located in version 1 and up.  **Extension Note:** Files are not guaranteed to have a file extensions. UnityPackage files tends to have it, images through this endpoint do not. You are responsible for appending file extension from the &#x60;extension&#x60; field when neccesary.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <param name="versionId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DownloadFileVersionWithHttpInfoAsync (string fileId, int versionId, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'fileId' is set
            if (fileId == null)
                throw new ApiException(400, "Missing required parameter 'fileId' when calling FilesApi->DownloadFileVersion");
            // verify the required parameter 'versionId' is set
            if (versionId == null)
                throw new ApiException(400, "Missing required parameter 'versionId' when calling FilesApi->DownloadFileVersion");

            var localVarPath = "/file/{fileId}/{versionId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (fileId != null) localVarPathParams.Add("fileId", this.Configuration.ApiClient.ParameterToString(fileId)); // path parameter
            if (versionId != null) localVarPathParams.Add("versionId", this.Configuration.ApiClient.ParameterToString(versionId)); // path parameter

            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DownloadFileVersion", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Finish FileData Upload Finish an upload of a FileData. This will mark it as \&quot;complete\&quot;. After uploading the &#x60;file&#x60; for Avatars and Worlds you then have to upload a &#x60;signature&#x60; file.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <param name="versionId"></param>
        /// <param name="fileType"></param>
        /// <param name="inlineObject5"> (optional)</param>
        /// <returns>File</returns>
        public File FinishFileDataUpload (string fileId, int versionId, string fileType, InlineObject5 inlineObject5 = default(InlineObject5))
        {
             ApiResponse<File> localVarResponse = FinishFileDataUploadWithHttpInfo(fileId, versionId, fileType, inlineObject5);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Finish FileData Upload Finish an upload of a FileData. This will mark it as \&quot;complete\&quot;. After uploading the &#x60;file&#x60; for Avatars and Worlds you then have to upload a &#x60;signature&#x60; file.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <param name="versionId"></param>
        /// <param name="fileType"></param>
        /// <param name="inlineObject5"> (optional)</param>
        /// <returns>ApiResponse of File</returns>
        public ApiResponse<File> FinishFileDataUploadWithHttpInfo (string fileId, int versionId, string fileType, InlineObject5 inlineObject5 = default(InlineObject5))
        {
            // verify the required parameter 'fileId' is set
            if (fileId == null)
                throw new ApiException(400, "Missing required parameter 'fileId' when calling FilesApi->FinishFileDataUpload");
            // verify the required parameter 'versionId' is set
            if (versionId == null)
                throw new ApiException(400, "Missing required parameter 'versionId' when calling FilesApi->FinishFileDataUpload");
            // verify the required parameter 'fileType' is set
            if (fileType == null)
                throw new ApiException(400, "Missing required parameter 'fileType' when calling FilesApi->FinishFileDataUpload");

            var localVarPath = "/file/{fileId}/{versionId}/{fileType}/finish";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (fileId != null) localVarPathParams.Add("fileId", this.Configuration.ApiClient.ParameterToString(fileId)); // path parameter
            if (versionId != null) localVarPathParams.Add("versionId", this.Configuration.ApiClient.ParameterToString(versionId)); // path parameter
            if (fileType != null) localVarPathParams.Add("fileType", this.Configuration.ApiClient.ParameterToString(fileType)); // path parameter
            if (inlineObject5 != null && inlineObject5.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(inlineObject5); // http body (model) parameter
            }
            else
            {
                localVarPostBody = inlineObject5; // byte array
            }

            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("FinishFileDataUpload", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<File>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (File) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(File)));
        }

        /// <summary>
        /// Finish FileData Upload Finish an upload of a FileData. This will mark it as \&quot;complete\&quot;. After uploading the &#x60;file&#x60; for Avatars and Worlds you then have to upload a &#x60;signature&#x60; file.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <param name="versionId"></param>
        /// <param name="fileType"></param>
        /// <param name="inlineObject5"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of File</returns>
        public async System.Threading.Tasks.Task<File> FinishFileDataUploadAsync (string fileId, int versionId, string fileType, InlineObject5 inlineObject5 = default(InlineObject5), CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<File> localVarResponse = await FinishFileDataUploadWithHttpInfoAsync(fileId, versionId, fileType, inlineObject5, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Finish FileData Upload Finish an upload of a FileData. This will mark it as \&quot;complete\&quot;. After uploading the &#x60;file&#x60; for Avatars and Worlds you then have to upload a &#x60;signature&#x60; file.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <param name="versionId"></param>
        /// <param name="fileType"></param>
        /// <param name="inlineObject5"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (File)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<File>> FinishFileDataUploadWithHttpInfoAsync (string fileId, int versionId, string fileType, InlineObject5 inlineObject5 = default(InlineObject5), CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'fileId' is set
            if (fileId == null)
                throw new ApiException(400, "Missing required parameter 'fileId' when calling FilesApi->FinishFileDataUpload");
            // verify the required parameter 'versionId' is set
            if (versionId == null)
                throw new ApiException(400, "Missing required parameter 'versionId' when calling FilesApi->FinishFileDataUpload");
            // verify the required parameter 'fileType' is set
            if (fileType == null)
                throw new ApiException(400, "Missing required parameter 'fileType' when calling FilesApi->FinishFileDataUpload");

            var localVarPath = "/file/{fileId}/{versionId}/{fileType}/finish";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (fileId != null) localVarPathParams.Add("fileId", this.Configuration.ApiClient.ParameterToString(fileId)); // path parameter
            if (versionId != null) localVarPathParams.Add("versionId", this.Configuration.ApiClient.ParameterToString(versionId)); // path parameter
            if (fileType != null) localVarPathParams.Add("fileType", this.Configuration.ApiClient.ParameterToString(fileType)); // path parameter
            if (inlineObject5 != null && inlineObject5.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(inlineObject5); // http body (model) parameter
            }
            else
            {
                localVarPostBody = inlineObject5; // byte array
            }

            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("FinishFileDataUpload", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<File>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (File) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(File)));
        }

        /// <summary>
        /// Show File Shows general information about the \&quot;File\&quot; object. Each File can have several \&quot;Version\&quot;&#39;s, and each Version can have multiple real files or \&quot;Data\&quot; blobs.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <returns>File</returns>
        public File GetFile (string fileId)
        {
             ApiResponse<File> localVarResponse = GetFileWithHttpInfo(fileId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Show File Shows general information about the \&quot;File\&quot; object. Each File can have several \&quot;Version\&quot;&#39;s, and each Version can have multiple real files or \&quot;Data\&quot; blobs.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <returns>ApiResponse of File</returns>
        public ApiResponse<File> GetFileWithHttpInfo (string fileId)
        {
            // verify the required parameter 'fileId' is set
            if (fileId == null)
                throw new ApiException(400, "Missing required parameter 'fileId' when calling FilesApi->GetFile");

            var localVarPath = "/file/{fileId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (fileId != null) localVarPathParams.Add("fileId", this.Configuration.ApiClient.ParameterToString(fileId)); // path parameter

            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetFile", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<File>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (File) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(File)));
        }

        /// <summary>
        /// Show File Shows general information about the \&quot;File\&quot; object. Each File can have several \&quot;Version\&quot;&#39;s, and each Version can have multiple real files or \&quot;Data\&quot; blobs.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of File</returns>
        public async System.Threading.Tasks.Task<File> GetFileAsync (string fileId, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<File> localVarResponse = await GetFileWithHttpInfoAsync(fileId, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Show File Shows general information about the \&quot;File\&quot; object. Each File can have several \&quot;Version\&quot;&#39;s, and each Version can have multiple real files or \&quot;Data\&quot; blobs.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (File)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<File>> GetFileWithHttpInfoAsync (string fileId, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'fileId' is set
            if (fileId == null)
                throw new ApiException(400, "Missing required parameter 'fileId' when calling FilesApi->GetFile");

            var localVarPath = "/file/{fileId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (fileId != null) localVarPathParams.Add("fileId", this.Configuration.ApiClient.ParameterToString(fileId)); // path parameter

            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetFile", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<File>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (File) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(File)));
        }

        /// <summary>
        /// Check FileData Upload Status Retrieves the upload status for file upload. Can currently only be accessed when &#x60;status&#x60; is &#x60;waiting&#x60;. Trying to access it on a file version already uploaded currently times out.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <param name="versionId"></param>
        /// <param name="fileType"></param>
        /// <returns>InlineResponse2004</returns>
        public InlineResponse2004 GetFileDataUploadStatus (string fileId, int versionId, string fileType)
        {
             ApiResponse<InlineResponse2004> localVarResponse = GetFileDataUploadStatusWithHttpInfo(fileId, versionId, fileType);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Check FileData Upload Status Retrieves the upload status for file upload. Can currently only be accessed when &#x60;status&#x60; is &#x60;waiting&#x60;. Trying to access it on a file version already uploaded currently times out.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <param name="versionId"></param>
        /// <param name="fileType"></param>
        /// <returns>ApiResponse of InlineResponse2004</returns>
        public ApiResponse<InlineResponse2004> GetFileDataUploadStatusWithHttpInfo (string fileId, int versionId, string fileType)
        {
            // verify the required parameter 'fileId' is set
            if (fileId == null)
                throw new ApiException(400, "Missing required parameter 'fileId' when calling FilesApi->GetFileDataUploadStatus");
            // verify the required parameter 'versionId' is set
            if (versionId == null)
                throw new ApiException(400, "Missing required parameter 'versionId' when calling FilesApi->GetFileDataUploadStatus");
            // verify the required parameter 'fileType' is set
            if (fileType == null)
                throw new ApiException(400, "Missing required parameter 'fileType' when calling FilesApi->GetFileDataUploadStatus");

            var localVarPath = "/file/{fileId}/{versionId}/{fileType}/status";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (fileId != null) localVarPathParams.Add("fileId", this.Configuration.ApiClient.ParameterToString(fileId)); // path parameter
            if (versionId != null) localVarPathParams.Add("versionId", this.Configuration.ApiClient.ParameterToString(versionId)); // path parameter
            if (fileType != null) localVarPathParams.Add("fileType", this.Configuration.ApiClient.ParameterToString(fileType)); // path parameter

            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetFileDataUploadStatus", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2004>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (InlineResponse2004) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2004)));
        }

        /// <summary>
        /// Check FileData Upload Status Retrieves the upload status for file upload. Can currently only be accessed when &#x60;status&#x60; is &#x60;waiting&#x60;. Trying to access it on a file version already uploaded currently times out.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <param name="versionId"></param>
        /// <param name="fileType"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of InlineResponse2004</returns>
        public async System.Threading.Tasks.Task<InlineResponse2004> GetFileDataUploadStatusAsync (string fileId, int versionId, string fileType, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<InlineResponse2004> localVarResponse = await GetFileDataUploadStatusWithHttpInfoAsync(fileId, versionId, fileType, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Check FileData Upload Status Retrieves the upload status for file upload. Can currently only be accessed when &#x60;status&#x60; is &#x60;waiting&#x60;. Trying to access it on a file version already uploaded currently times out.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <param name="versionId"></param>
        /// <param name="fileType"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (InlineResponse2004)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2004>> GetFileDataUploadStatusWithHttpInfoAsync (string fileId, int versionId, string fileType, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'fileId' is set
            if (fileId == null)
                throw new ApiException(400, "Missing required parameter 'fileId' when calling FilesApi->GetFileDataUploadStatus");
            // verify the required parameter 'versionId' is set
            if (versionId == null)
                throw new ApiException(400, "Missing required parameter 'versionId' when calling FilesApi->GetFileDataUploadStatus");
            // verify the required parameter 'fileType' is set
            if (fileType == null)
                throw new ApiException(400, "Missing required parameter 'fileType' when calling FilesApi->GetFileDataUploadStatus");

            var localVarPath = "/file/{fileId}/{versionId}/{fileType}/status";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (fileId != null) localVarPathParams.Add("fileId", this.Configuration.ApiClient.ParameterToString(fileId)); // path parameter
            if (versionId != null) localVarPathParams.Add("versionId", this.Configuration.ApiClient.ParameterToString(versionId)); // path parameter
            if (fileType != null) localVarPathParams.Add("fileType", this.Configuration.ApiClient.ParameterToString(fileType)); // path parameter

            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetFileDataUploadStatus", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2004>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (InlineResponse2004) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2004)));
        }

        /// <summary>
        /// List Files Returns a list of files
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tag">Tag, for example \&quot;icon\&quot; or \&quot;gallery\&quot;, not included by default. (optional)</param>
        /// <param name="userId">UserID, will always generate a 500 permission error. (optional)</param>
        /// <param name="n">The number of objects to return. (optional, default to 60)</param>
        /// <param name="offset">A zero-based offset from the default object sorting from where search results start. (optional)</param>
        /// <returns>List&lt;File&gt;</returns>
        public List<File> GetFiles (string tag = default(string), string userId = default(string), int? n = default(int?), int? offset = default(int?))
        {
             ApiResponse<List<File>> localVarResponse = GetFilesWithHttpInfo(tag, userId, n, offset);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List Files Returns a list of files
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tag">Tag, for example \&quot;icon\&quot; or \&quot;gallery\&quot;, not included by default. (optional)</param>
        /// <param name="userId">UserID, will always generate a 500 permission error. (optional)</param>
        /// <param name="n">The number of objects to return. (optional, default to 60)</param>
        /// <param name="offset">A zero-based offset from the default object sorting from where search results start. (optional)</param>
        /// <returns>ApiResponse of List&lt;File&gt;</returns>
        public ApiResponse<List<File>> GetFilesWithHttpInfo (string tag = default(string), string userId = default(string), int? n = default(int?), int? offset = default(int?))
        {

            var localVarPath = "/files";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (tag != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "tag", tag)); // query parameter
            if (userId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "userId", userId)); // query parameter
            if (n != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "n", n)); // query parameter
            if (offset != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "offset", offset)); // query parameter

            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetFiles", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<File>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<File>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<File>)));
        }

        /// <summary>
        /// List Files Returns a list of files
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tag">Tag, for example \&quot;icon\&quot; or \&quot;gallery\&quot;, not included by default. (optional)</param>
        /// <param name="userId">UserID, will always generate a 500 permission error. (optional)</param>
        /// <param name="n">The number of objects to return. (optional, default to 60)</param>
        /// <param name="offset">A zero-based offset from the default object sorting from where search results start. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of List&lt;File&gt;</returns>
        public async System.Threading.Tasks.Task<List<File>> GetFilesAsync (string tag = default(string), string userId = default(string), int? n = default(int?), int? offset = default(int?), CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<List<File>> localVarResponse = await GetFilesWithHttpInfoAsync(tag, userId, n, offset, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List Files Returns a list of files
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tag">Tag, for example \&quot;icon\&quot; or \&quot;gallery\&quot;, not included by default. (optional)</param>
        /// <param name="userId">UserID, will always generate a 500 permission error. (optional)</param>
        /// <param name="n">The number of objects to return. (optional, default to 60)</param>
        /// <param name="offset">A zero-based offset from the default object sorting from where search results start. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (List&lt;File&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<File>>> GetFilesWithHttpInfoAsync (string tag = default(string), string userId = default(string), int? n = default(int?), int? offset = default(int?), CancellationToken cancellationToken = default(CancellationToken))
        {

            var localVarPath = "/files";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (tag != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "tag", tag)); // query parameter
            if (userId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "userId", userId)); // query parameter
            if (n != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "n", n)); // query parameter
            if (offset != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "offset", offset)); // query parameter

            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetFiles", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<File>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<File>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<File>)));
        }

        /// <summary>
        /// Start FileData Upload Starts an upload of a specific FilePart. This endpoint will return an AWS URL which you can PUT data to. You need to call this and receive a new AWS API URL for each &#x60;partNumber&#x60;. Please see AWS&#39;s REST documentation on \&quot;PUT Object to S3\&quot; on how to upload. Once all parts has been uploaded, proceed to &#x60;/finish&#x60; endpoint.  **Note:** &#x60;nextPartNumber&#x60; seems like it is always ignored. Despite it returning 0, first partNumber is always 1.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <param name="versionId"></param>
        /// <param name="fileType"></param>
        /// <param name="partNumber"></param>
        /// <returns>InlineResponse2005</returns>
        public InlineResponse2005 StartFileDataUpload (string fileId, int versionId, string fileType, int partNumber)
        {
             ApiResponse<InlineResponse2005> localVarResponse = StartFileDataUploadWithHttpInfo(fileId, versionId, fileType, partNumber);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Start FileData Upload Starts an upload of a specific FilePart. This endpoint will return an AWS URL which you can PUT data to. You need to call this and receive a new AWS API URL for each &#x60;partNumber&#x60;. Please see AWS&#39;s REST documentation on \&quot;PUT Object to S3\&quot; on how to upload. Once all parts has been uploaded, proceed to &#x60;/finish&#x60; endpoint.  **Note:** &#x60;nextPartNumber&#x60; seems like it is always ignored. Despite it returning 0, first partNumber is always 1.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <param name="versionId"></param>
        /// <param name="fileType"></param>
        /// <param name="partNumber"></param>
        /// <returns>ApiResponse of InlineResponse2005</returns>
        public ApiResponse<InlineResponse2005> StartFileDataUploadWithHttpInfo (string fileId, int versionId, string fileType, int partNumber)
        {
            // verify the required parameter 'fileId' is set
            if (fileId == null)
                throw new ApiException(400, "Missing required parameter 'fileId' when calling FilesApi->StartFileDataUpload");
            // verify the required parameter 'versionId' is set
            if (versionId == null)
                throw new ApiException(400, "Missing required parameter 'versionId' when calling FilesApi->StartFileDataUpload");
            // verify the required parameter 'fileType' is set
            if (fileType == null)
                throw new ApiException(400, "Missing required parameter 'fileType' when calling FilesApi->StartFileDataUpload");
            // verify the required parameter 'partNumber' is set
            if (partNumber == null)
                throw new ApiException(400, "Missing required parameter 'partNumber' when calling FilesApi->StartFileDataUpload");

            var localVarPath = "/file/{fileId}/{versionId}/{fileType}/start";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (fileId != null) localVarPathParams.Add("fileId", this.Configuration.ApiClient.ParameterToString(fileId)); // path parameter
            if (versionId != null) localVarPathParams.Add("versionId", this.Configuration.ApiClient.ParameterToString(versionId)); // path parameter
            if (fileType != null) localVarPathParams.Add("fileType", this.Configuration.ApiClient.ParameterToString(fileType)); // path parameter
            if (partNumber != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "partNumber", partNumber)); // query parameter

            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("StartFileDataUpload", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2005>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (InlineResponse2005) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2005)));
        }

        /// <summary>
        /// Start FileData Upload Starts an upload of a specific FilePart. This endpoint will return an AWS URL which you can PUT data to. You need to call this and receive a new AWS API URL for each &#x60;partNumber&#x60;. Please see AWS&#39;s REST documentation on \&quot;PUT Object to S3\&quot; on how to upload. Once all parts has been uploaded, proceed to &#x60;/finish&#x60; endpoint.  **Note:** &#x60;nextPartNumber&#x60; seems like it is always ignored. Despite it returning 0, first partNumber is always 1.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <param name="versionId"></param>
        /// <param name="fileType"></param>
        /// <param name="partNumber"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of InlineResponse2005</returns>
        public async System.Threading.Tasks.Task<InlineResponse2005> StartFileDataUploadAsync (string fileId, int versionId, string fileType, int partNumber, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<InlineResponse2005> localVarResponse = await StartFileDataUploadWithHttpInfoAsync(fileId, versionId, fileType, partNumber, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Start FileData Upload Starts an upload of a specific FilePart. This endpoint will return an AWS URL which you can PUT data to. You need to call this and receive a new AWS API URL for each &#x60;partNumber&#x60;. Please see AWS&#39;s REST documentation on \&quot;PUT Object to S3\&quot; on how to upload. Once all parts has been uploaded, proceed to &#x60;/finish&#x60; endpoint.  **Note:** &#x60;nextPartNumber&#x60; seems like it is always ignored. Despite it returning 0, first partNumber is always 1.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <param name="versionId"></param>
        /// <param name="fileType"></param>
        /// <param name="partNumber"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (InlineResponse2005)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2005>> StartFileDataUploadWithHttpInfoAsync (string fileId, int versionId, string fileType, int partNumber, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'fileId' is set
            if (fileId == null)
                throw new ApiException(400, "Missing required parameter 'fileId' when calling FilesApi->StartFileDataUpload");
            // verify the required parameter 'versionId' is set
            if (versionId == null)
                throw new ApiException(400, "Missing required parameter 'versionId' when calling FilesApi->StartFileDataUpload");
            // verify the required parameter 'fileType' is set
            if (fileType == null)
                throw new ApiException(400, "Missing required parameter 'fileType' when calling FilesApi->StartFileDataUpload");
            // verify the required parameter 'partNumber' is set
            if (partNumber == null)
                throw new ApiException(400, "Missing required parameter 'partNumber' when calling FilesApi->StartFileDataUpload");

            var localVarPath = "/file/{fileId}/{versionId}/{fileType}/start";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (fileId != null) localVarPathParams.Add("fileId", this.Configuration.ApiClient.ParameterToString(fileId)); // path parameter
            if (versionId != null) localVarPathParams.Add("versionId", this.Configuration.ApiClient.ParameterToString(versionId)); // path parameter
            if (fileType != null) localVarPathParams.Add("fileType", this.Configuration.ApiClient.ParameterToString(fileType)); // path parameter
            if (partNumber != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "partNumber", partNumber)); // query parameter

            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("StartFileDataUpload", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2005>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (InlineResponse2005) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2005)));
        }

    }
}
