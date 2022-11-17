/*
 * VRChat API Documentation
 *
 *
 * The version of the OpenAPI document: 1.9.0
 * Contact: me@ariesclark.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using VRChat.API.Client;
using VRChat.API.Model;

namespace VRChat.API.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPermissionsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get Assigned Permissions
        /// </summary>
        /// <remarks>
        /// Returns a list of all permissions currently granted by the user. Permissions are assigned e.g. by subscribing to VRC+.
        /// </remarks>
        /// <exception cref="VRChat.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;Permission&gt;</returns>
        List<Permission> GetAssignedPermissions();

        /// <summary>
        /// Get Assigned Permissions
        /// </summary>
        /// <remarks>
        /// Returns a list of all permissions currently granted by the user. Permissions are assigned e.g. by subscribing to VRC+.
        /// </remarks>
        /// <exception cref="VRChat.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;Permission&gt;</returns>
        ApiResponse<List<Permission>> GetAssignedPermissionsWithHttpInfo();
        /// <summary>
        /// Get Permission
        /// </summary>
        /// <remarks>
        /// Returns a single permission. This endpoint is pretty useless, as it returns the exact same information as &#x60;/auth/permissions&#x60;.
        /// </remarks>
        /// <exception cref="VRChat.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="permissionId"></param>
        /// <returns>Permission</returns>
        Permission GetPermission(string permissionId);

        /// <summary>
        /// Get Permission
        /// </summary>
        /// <remarks>
        /// Returns a single permission. This endpoint is pretty useless, as it returns the exact same information as &#x60;/auth/permissions&#x60;.
        /// </remarks>
        /// <exception cref="VRChat.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="permissionId"></param>
        /// <returns>ApiResponse of Permission</returns>
        ApiResponse<Permission> GetPermissionWithHttpInfo(string permissionId);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPermissionsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Get Assigned Permissions
        /// </summary>
        /// <remarks>
        /// Returns a list of all permissions currently granted by the user. Permissions are assigned e.g. by subscribing to VRC+.
        /// </remarks>
        /// <exception cref="VRChat.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;Permission&gt;</returns>
        System.Threading.Tasks.Task<List<Permission>> GetAssignedPermissionsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get Assigned Permissions
        /// </summary>
        /// <remarks>
        /// Returns a list of all permissions currently granted by the user. Permissions are assigned e.g. by subscribing to VRC+.
        /// </remarks>
        /// <exception cref="VRChat.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;Permission&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Permission>>> GetAssignedPermissionsWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Get Permission
        /// </summary>
        /// <remarks>
        /// Returns a single permission. This endpoint is pretty useless, as it returns the exact same information as &#x60;/auth/permissions&#x60;.
        /// </remarks>
        /// <exception cref="VRChat.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="permissionId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Permission</returns>
        System.Threading.Tasks.Task<Permission> GetPermissionAsync(string permissionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get Permission
        /// </summary>
        /// <remarks>
        /// Returns a single permission. This endpoint is pretty useless, as it returns the exact same information as &#x60;/auth/permissions&#x60;.
        /// </remarks>
        /// <exception cref="VRChat.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="permissionId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Permission)</returns>
        System.Threading.Tasks.Task<ApiResponse<Permission>> GetPermissionWithHttpInfoAsync(string permissionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPermissionsApi : IPermissionsApiSync, IPermissionsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PermissionsApi : IPermissionsApi
    {
        private VRChat.API.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PermissionsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PermissionsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PermissionsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PermissionsApi(string basePath)
        {
            this.Configuration = VRChat.API.Client.Configuration.MergeConfigurations(
                VRChat.API.Client.GlobalConfiguration.Instance,
                new VRChat.API.Client.Configuration { BasePath = basePath }
            );
            this.Client = new VRChat.API.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new VRChat.API.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = VRChat.API.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PermissionsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PermissionsApi(VRChat.API.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = VRChat.API.Client.Configuration.MergeConfigurations(
                VRChat.API.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new VRChat.API.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new VRChat.API.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = VRChat.API.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PermissionsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public PermissionsApi(VRChat.API.Client.ISynchronousClient client, VRChat.API.Client.IAsynchronousClient asyncClient, VRChat.API.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = VRChat.API.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public VRChat.API.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public VRChat.API.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public VRChat.API.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public VRChat.API.Client.ExceptionFactory ExceptionFactory
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
        /// Get Assigned Permissions Returns a list of all permissions currently granted by the user. Permissions are assigned e.g. by subscribing to VRC+.
        /// </summary>
        /// <exception cref="VRChat.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;Permission&gt;</returns>
        public List<Permission> GetAssignedPermissions()
        {
            VRChat.API.Client.ApiResponse<List<Permission>> localVarResponse = GetAssignedPermissionsWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get Assigned Permissions Returns a list of all permissions currently granted by the user. Permissions are assigned e.g. by subscribing to VRC+.
        /// </summary>
        /// <exception cref="VRChat.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;Permission&gt;</returns>
        public VRChat.API.Client.ApiResponse<List<Permission>> GetAssignedPermissionsWithHttpInfo()
        {
            VRChat.API.Client.RequestOptions localVarRequestOptions = new VRChat.API.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = VRChat.API.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = VRChat.API.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (apiKeyCookie) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("apiKey")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("apiKey", this.Configuration.GetApiKeyWithPrefix("apiKey")));
            }
            // authentication (authCookie) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("auth")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("auth", this.Configuration.GetApiKeyWithPrefix("auth")));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<List<Permission>>("/auth/permissions", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetAssignedPermissions", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get Assigned Permissions Returns a list of all permissions currently granted by the user. Permissions are assigned e.g. by subscribing to VRC+.
        /// </summary>
        /// <exception cref="VRChat.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;Permission&gt;</returns>
        public async System.Threading.Tasks.Task<List<Permission>> GetAssignedPermissionsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            VRChat.API.Client.ApiResponse<List<Permission>> localVarResponse = await GetAssignedPermissionsWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get Assigned Permissions Returns a list of all permissions currently granted by the user. Permissions are assigned e.g. by subscribing to VRC+.
        /// </summary>
        /// <exception cref="VRChat.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;Permission&gt;)</returns>
        public async System.Threading.Tasks.Task<VRChat.API.Client.ApiResponse<List<Permission>>> GetAssignedPermissionsWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            VRChat.API.Client.RequestOptions localVarRequestOptions = new VRChat.API.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = VRChat.API.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = VRChat.API.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (apiKeyCookie) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("apiKey")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("apiKey", this.Configuration.GetApiKeyWithPrefix("apiKey")));
            }
            // authentication (authCookie) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("auth")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("auth", this.Configuration.GetApiKeyWithPrefix("auth")));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<List<Permission>>("/auth/permissions", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetAssignedPermissions", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get Permission Returns a single permission. This endpoint is pretty useless, as it returns the exact same information as &#x60;/auth/permissions&#x60;.
        /// </summary>
        /// <exception cref="VRChat.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="permissionId"></param>
        /// <returns>Permission</returns>
        public Permission GetPermission(string permissionId)
        {
            VRChat.API.Client.ApiResponse<Permission> localVarResponse = GetPermissionWithHttpInfo(permissionId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get Permission Returns a single permission. This endpoint is pretty useless, as it returns the exact same information as &#x60;/auth/permissions&#x60;.
        /// </summary>
        /// <exception cref="VRChat.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="permissionId"></param>
        /// <returns>ApiResponse of Permission</returns>
        public VRChat.API.Client.ApiResponse<Permission> GetPermissionWithHttpInfo(string permissionId)
        {
            // verify the required parameter 'permissionId' is set
            if (permissionId == null)
                throw new VRChat.API.Client.ApiException(400, "Missing required parameter 'permissionId' when calling PermissionsApi->GetPermission");

            VRChat.API.Client.RequestOptions localVarRequestOptions = new VRChat.API.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = VRChat.API.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = VRChat.API.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("permissionId", VRChat.API.Client.ClientUtils.ParameterToString(permissionId)); // path parameter

            // authentication (apiKeyCookie) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("apiKey")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("apiKey", this.Configuration.GetApiKeyWithPrefix("apiKey")));
            }
            // authentication (authCookie) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("auth")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("auth", this.Configuration.GetApiKeyWithPrefix("auth")));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<Permission>("/permissions/{permissionId}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetPermission", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get Permission Returns a single permission. This endpoint is pretty useless, as it returns the exact same information as &#x60;/auth/permissions&#x60;.
        /// </summary>
        /// <exception cref="VRChat.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="permissionId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Permission</returns>
        public async System.Threading.Tasks.Task<Permission> GetPermissionAsync(string permissionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            VRChat.API.Client.ApiResponse<Permission> localVarResponse = await GetPermissionWithHttpInfoAsync(permissionId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get Permission Returns a single permission. This endpoint is pretty useless, as it returns the exact same information as &#x60;/auth/permissions&#x60;.
        /// </summary>
        /// <exception cref="VRChat.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="permissionId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Permission)</returns>
        public async System.Threading.Tasks.Task<VRChat.API.Client.ApiResponse<Permission>> GetPermissionWithHttpInfoAsync(string permissionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'permissionId' is set
            if (permissionId == null)
                throw new VRChat.API.Client.ApiException(400, "Missing required parameter 'permissionId' when calling PermissionsApi->GetPermission");


            VRChat.API.Client.RequestOptions localVarRequestOptions = new VRChat.API.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = VRChat.API.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = VRChat.API.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("permissionId", VRChat.API.Client.ClientUtils.ParameterToString(permissionId)); // path parameter

            // authentication (apiKeyCookie) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("apiKey")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("apiKey", this.Configuration.GetApiKeyWithPrefix("apiKey")));
            }
            // authentication (authCookie) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("auth")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("auth", this.Configuration.GetApiKeyWithPrefix("auth")));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<Permission>("/permissions/{permissionId}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetPermission", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
