/*
 * VRChat API Documentation
 *
 *
 * The version of the OpenAPI document: 1.18.9
 * Contact: vrchatapi.lpv0t@aries.fyi
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
    public interface IJamsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Show jam information
        /// </summary>
        /// <remarks>
        /// Returns a jam.
        /// </remarks>
        /// <exception cref="VRChat.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jamId">Must be a valid query ID.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Jam</returns>
        Jam GetJam(string jamId, int operationIndex = 0);

        /// <summary>
        /// Show jam information
        /// </summary>
        /// <remarks>
        /// Returns a jam.
        /// </remarks>
        /// <exception cref="VRChat.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jamId">Must be a valid query ID.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Jam</returns>
        ApiResponse<Jam> GetJamWithHttpInfo(string jamId, int operationIndex = 0);
        /// <summary>
        /// Show jam submissions
        /// </summary>
        /// <remarks>
        /// Returns all submissions of a jam.
        /// </remarks>
        /// <exception cref="VRChat.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jamId">Must be a valid query ID.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;Submission&gt;</returns>
        List<Submission> GetJamSubmissions(string jamId, int operationIndex = 0);

        /// <summary>
        /// Show jam submissions
        /// </summary>
        /// <remarks>
        /// Returns all submissions of a jam.
        /// </remarks>
        /// <exception cref="VRChat.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jamId">Must be a valid query ID.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;Submission&gt;</returns>
        ApiResponse<List<Submission>> GetJamSubmissionsWithHttpInfo(string jamId, int operationIndex = 0);
        /// <summary>
        /// Show jams list
        /// </summary>
        /// <remarks>
        /// Lists World Jams or Avatar Jams, both currently running and ones that have ended.  &#x60;isActive&#x60; is used to select only active or already ended jams.  &#x60;type&#x60; is used to select only world or avatar jams, and can only take &#x60;world&#x60; or &#x60;avatar&#x60;. &#x60;&#x60;
        /// </remarks>
        /// <exception cref="VRChat.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">Only show jams of this type (&#x60;avatar&#x60; or &#x60;world&#x60;). (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;Jam&gt;</returns>
        List<Jam> GetJams(string type = default(string), int operationIndex = 0);

        /// <summary>
        /// Show jams list
        /// </summary>
        /// <remarks>
        /// Lists World Jams or Avatar Jams, both currently running and ones that have ended.  &#x60;isActive&#x60; is used to select only active or already ended jams.  &#x60;type&#x60; is used to select only world or avatar jams, and can only take &#x60;world&#x60; or &#x60;avatar&#x60;. &#x60;&#x60;
        /// </remarks>
        /// <exception cref="VRChat.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">Only show jams of this type (&#x60;avatar&#x60; or &#x60;world&#x60;). (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;Jam&gt;</returns>
        ApiResponse<List<Jam>> GetJamsWithHttpInfo(string type = default(string), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IJamsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Show jam information
        /// </summary>
        /// <remarks>
        /// Returns a jam.
        /// </remarks>
        /// <exception cref="VRChat.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jamId">Must be a valid query ID.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Jam</returns>
        System.Threading.Tasks.Task<Jam> GetJamAsync(string jamId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Show jam information
        /// </summary>
        /// <remarks>
        /// Returns a jam.
        /// </remarks>
        /// <exception cref="VRChat.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jamId">Must be a valid query ID.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Jam)</returns>
        System.Threading.Tasks.Task<ApiResponse<Jam>> GetJamWithHttpInfoAsync(string jamId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Show jam submissions
        /// </summary>
        /// <remarks>
        /// Returns all submissions of a jam.
        /// </remarks>
        /// <exception cref="VRChat.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jamId">Must be a valid query ID.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;Submission&gt;</returns>
        System.Threading.Tasks.Task<List<Submission>> GetJamSubmissionsAsync(string jamId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Show jam submissions
        /// </summary>
        /// <remarks>
        /// Returns all submissions of a jam.
        /// </remarks>
        /// <exception cref="VRChat.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jamId">Must be a valid query ID.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;Submission&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Submission>>> GetJamSubmissionsWithHttpInfoAsync(string jamId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Show jams list
        /// </summary>
        /// <remarks>
        /// Lists World Jams or Avatar Jams, both currently running and ones that have ended.  &#x60;isActive&#x60; is used to select only active or already ended jams.  &#x60;type&#x60; is used to select only world or avatar jams, and can only take &#x60;world&#x60; or &#x60;avatar&#x60;. &#x60;&#x60;
        /// </remarks>
        /// <exception cref="VRChat.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">Only show jams of this type (&#x60;avatar&#x60; or &#x60;world&#x60;). (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;Jam&gt;</returns>
        System.Threading.Tasks.Task<List<Jam>> GetJamsAsync(string type = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Show jams list
        /// </summary>
        /// <remarks>
        /// Lists World Jams or Avatar Jams, both currently running and ones that have ended.  &#x60;isActive&#x60; is used to select only active or already ended jams.  &#x60;type&#x60; is used to select only world or avatar jams, and can only take &#x60;world&#x60; or &#x60;avatar&#x60;. &#x60;&#x60;
        /// </remarks>
        /// <exception cref="VRChat.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">Only show jams of this type (&#x60;avatar&#x60; or &#x60;world&#x60;). (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;Jam&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Jam>>> GetJamsWithHttpInfoAsync(string type = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IJamsApi : IJamsApiSync, IJamsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class JamsApi : IJamsApi
    {
        private VRChat.API.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="JamsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public JamsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JamsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public JamsApi(string basePath)
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
        /// Initializes a new instance of the <see cref="JamsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public JamsApi(VRChat.API.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="JamsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public JamsApi(VRChat.API.Client.ISynchronousClient client, VRChat.API.Client.IAsynchronousClient asyncClient, VRChat.API.Client.IReadableConfiguration configuration)
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
        /// Show jam information Returns a jam.
        /// </summary>
        /// <exception cref="VRChat.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jamId">Must be a valid query ID.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Jam</returns>
        public Jam GetJam(string jamId, int operationIndex = 0)
        {
            VRChat.API.Client.ApiResponse<Jam> localVarResponse = GetJamWithHttpInfo(jamId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Show jam information Returns a jam.
        /// </summary>
        /// <exception cref="VRChat.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jamId">Must be a valid query ID.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Jam</returns>
        public VRChat.API.Client.ApiResponse<Jam> GetJamWithHttpInfo(string jamId, int operationIndex = 0)
        {
            // verify the required parameter 'jamId' is set
            if (jamId == null)
            {
                throw new VRChat.API.Client.ApiException(400, "Missing required parameter 'jamId' when calling JamsApi->GetJam");
            }

            VRChat.API.Client.RequestOptions localVarRequestOptions = new VRChat.API.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = VRChat.API.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = VRChat.API.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("jamId", VRChat.API.Client.ClientUtils.ParameterToString(jamId)); // path parameter

            localVarRequestOptions.Operation = "JamsApi.GetJam";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (authCookie) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("auth")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("auth", this.Configuration.GetApiKeyWithPrefix("auth"), "/", "vrchat.com"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<Jam>("/jams/{jamId}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetJam", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Show jam information Returns a jam.
        /// </summary>
        /// <exception cref="VRChat.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jamId">Must be a valid query ID.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Jam</returns>
        public async System.Threading.Tasks.Task<Jam> GetJamAsync(string jamId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            VRChat.API.Client.ApiResponse<Jam> localVarResponse = await GetJamWithHttpInfoAsync(jamId, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Show jam information Returns a jam.
        /// </summary>
        /// <exception cref="VRChat.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jamId">Must be a valid query ID.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Jam)</returns>
        public async System.Threading.Tasks.Task<VRChat.API.Client.ApiResponse<Jam>> GetJamWithHttpInfoAsync(string jamId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'jamId' is set
            if (jamId == null)
            {
                throw new VRChat.API.Client.ApiException(400, "Missing required parameter 'jamId' when calling JamsApi->GetJam");
            }


            VRChat.API.Client.RequestOptions localVarRequestOptions = new VRChat.API.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = VRChat.API.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = VRChat.API.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("jamId", VRChat.API.Client.ClientUtils.ParameterToString(jamId)); // path parameter

            localVarRequestOptions.Operation = "JamsApi.GetJam";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (authCookie) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("auth")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("auth", this.Configuration.GetApiKeyWithPrefix("auth"), "/", "vrchat.com"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<Jam>("/jams/{jamId}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetJam", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Show jam submissions Returns all submissions of a jam.
        /// </summary>
        /// <exception cref="VRChat.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jamId">Must be a valid query ID.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;Submission&gt;</returns>
        public List<Submission> GetJamSubmissions(string jamId, int operationIndex = 0)
        {
            VRChat.API.Client.ApiResponse<List<Submission>> localVarResponse = GetJamSubmissionsWithHttpInfo(jamId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Show jam submissions Returns all submissions of a jam.
        /// </summary>
        /// <exception cref="VRChat.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jamId">Must be a valid query ID.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;Submission&gt;</returns>
        public VRChat.API.Client.ApiResponse<List<Submission>> GetJamSubmissionsWithHttpInfo(string jamId, int operationIndex = 0)
        {
            // verify the required parameter 'jamId' is set
            if (jamId == null)
            {
                throw new VRChat.API.Client.ApiException(400, "Missing required parameter 'jamId' when calling JamsApi->GetJamSubmissions");
            }

            VRChat.API.Client.RequestOptions localVarRequestOptions = new VRChat.API.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = VRChat.API.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = VRChat.API.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("jamId", VRChat.API.Client.ClientUtils.ParameterToString(jamId)); // path parameter

            localVarRequestOptions.Operation = "JamsApi.GetJamSubmissions";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (authCookie) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("auth")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("auth", this.Configuration.GetApiKeyWithPrefix("auth"), "/", "vrchat.com"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<List<Submission>>("/jams/{jamId}/submissions", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetJamSubmissions", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Show jam submissions Returns all submissions of a jam.
        /// </summary>
        /// <exception cref="VRChat.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jamId">Must be a valid query ID.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;Submission&gt;</returns>
        public async System.Threading.Tasks.Task<List<Submission>> GetJamSubmissionsAsync(string jamId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            VRChat.API.Client.ApiResponse<List<Submission>> localVarResponse = await GetJamSubmissionsWithHttpInfoAsync(jamId, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Show jam submissions Returns all submissions of a jam.
        /// </summary>
        /// <exception cref="VRChat.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jamId">Must be a valid query ID.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;Submission&gt;)</returns>
        public async System.Threading.Tasks.Task<VRChat.API.Client.ApiResponse<List<Submission>>> GetJamSubmissionsWithHttpInfoAsync(string jamId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'jamId' is set
            if (jamId == null)
            {
                throw new VRChat.API.Client.ApiException(400, "Missing required parameter 'jamId' when calling JamsApi->GetJamSubmissions");
            }


            VRChat.API.Client.RequestOptions localVarRequestOptions = new VRChat.API.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = VRChat.API.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = VRChat.API.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("jamId", VRChat.API.Client.ClientUtils.ParameterToString(jamId)); // path parameter

            localVarRequestOptions.Operation = "JamsApi.GetJamSubmissions";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (authCookie) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("auth")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("auth", this.Configuration.GetApiKeyWithPrefix("auth"), "/", "vrchat.com"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<List<Submission>>("/jams/{jamId}/submissions", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetJamSubmissions", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Show jams list Lists World Jams or Avatar Jams, both currently running and ones that have ended.  &#x60;isActive&#x60; is used to select only active or already ended jams.  &#x60;type&#x60; is used to select only world or avatar jams, and can only take &#x60;world&#x60; or &#x60;avatar&#x60;. &#x60;&#x60;
        /// </summary>
        /// <exception cref="VRChat.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">Only show jams of this type (&#x60;avatar&#x60; or &#x60;world&#x60;). (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;Jam&gt;</returns>
        public List<Jam> GetJams(string type = default(string), int operationIndex = 0)
        {
            VRChat.API.Client.ApiResponse<List<Jam>> localVarResponse = GetJamsWithHttpInfo(type);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Show jams list Lists World Jams or Avatar Jams, both currently running and ones that have ended.  &#x60;isActive&#x60; is used to select only active or already ended jams.  &#x60;type&#x60; is used to select only world or avatar jams, and can only take &#x60;world&#x60; or &#x60;avatar&#x60;. &#x60;&#x60;
        /// </summary>
        /// <exception cref="VRChat.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">Only show jams of this type (&#x60;avatar&#x60; or &#x60;world&#x60;). (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;Jam&gt;</returns>
        public VRChat.API.Client.ApiResponse<List<Jam>> GetJamsWithHttpInfo(string type = default(string), int operationIndex = 0)
        {
            VRChat.API.Client.RequestOptions localVarRequestOptions = new VRChat.API.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = VRChat.API.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = VRChat.API.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (type != null)
            {
                localVarRequestOptions.QueryParameters.Add(VRChat.API.Client.ClientUtils.ParameterToMultiMap("", "type", type));
            }

            localVarRequestOptions.Operation = "JamsApi.GetJams";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (authCookie) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("auth")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("auth", this.Configuration.GetApiKeyWithPrefix("auth"), "/", "vrchat.com"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<List<Jam>>("/jams", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetJams", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Show jams list Lists World Jams or Avatar Jams, both currently running and ones that have ended.  &#x60;isActive&#x60; is used to select only active or already ended jams.  &#x60;type&#x60; is used to select only world or avatar jams, and can only take &#x60;world&#x60; or &#x60;avatar&#x60;. &#x60;&#x60;
        /// </summary>
        /// <exception cref="VRChat.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">Only show jams of this type (&#x60;avatar&#x60; or &#x60;world&#x60;). (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;Jam&gt;</returns>
        public async System.Threading.Tasks.Task<List<Jam>> GetJamsAsync(string type = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            VRChat.API.Client.ApiResponse<List<Jam>> localVarResponse = await GetJamsWithHttpInfoAsync(type, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Show jams list Lists World Jams or Avatar Jams, both currently running and ones that have ended.  &#x60;isActive&#x60; is used to select only active or already ended jams.  &#x60;type&#x60; is used to select only world or avatar jams, and can only take &#x60;world&#x60; or &#x60;avatar&#x60;. &#x60;&#x60;
        /// </summary>
        /// <exception cref="VRChat.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">Only show jams of this type (&#x60;avatar&#x60; or &#x60;world&#x60;). (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;Jam&gt;)</returns>
        public async System.Threading.Tasks.Task<VRChat.API.Client.ApiResponse<List<Jam>>> GetJamsWithHttpInfoAsync(string type = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            VRChat.API.Client.RequestOptions localVarRequestOptions = new VRChat.API.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = VRChat.API.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = VRChat.API.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (type != null)
            {
                localVarRequestOptions.QueryParameters.Add(VRChat.API.Client.ClientUtils.ParameterToMultiMap("", "type", type));
            }

            localVarRequestOptions.Operation = "JamsApi.GetJams";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (authCookie) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("auth")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("auth", this.Configuration.GetApiKeyWithPrefix("auth"), "/", "vrchat.com"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<List<Jam>>("/jams", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetJams", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
