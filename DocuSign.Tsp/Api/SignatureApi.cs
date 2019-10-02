﻿/*
 * Inspired from DocuSign.eSign.Api
 * https://github.com/docusign/docusign-csharp-client/blob/master/sdk/src/DocuSign.eSign/Api
 */

using System;
using System.Collections.Generic;
using System.Linq;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;
using RestSharp;

namespace DocuSign.eSign.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISignatureApi : IApiAccessor
    {
        #region Synchronous Operations
        #region SignHashSessionInfo
        /// <summary>
        /// Provides signing session information for a Trust Service Provider. 
        /// </summary>
        /// <exception cref="DocuSign.eSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="signHashSessionInfo">SignSessionInfoRequest object.</param>
        /// <returns>SignHashSessionInfoResponse</returns>
        SignHashSessionInfoResponse SignHashSessionInfo(SignSessionInfoRequest signHashSessionInfo);

        /// <summary>
        /// Provides signing session information for a Trust Service Provider. 
        /// </summary>
        /// <exception cref="DocuSign.eSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="signHashSessionInfo">SignSessionInfoRequest object.</param>
        /// <returns>ApiResponse of (SignHashSessionInfoResponse)</returns>
        ApiResponse<SignHashSessionInfoResponse> SignHashSessionInfoWithHttpInfo(SignSessionInfoRequest signHashSessionInfo);
        #endregion SignHashSessionInfo

        #region CompleteSignHash
        /// <summary>
        /// Finalize the Trust Service Provider session with the signed Hash. 
        /// </summary>
        /// <exception cref="DocuSign.eSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="completeSignRequest">CompleteSignRequest object.</param>
        /// <returns>CompleteSignHashResponse</returns>
        CompleteSignHashResponse CompleteSignHash(CompleteSignRequest completeSignRequest);

        /// <summary>
        /// Finalize the Trust Service Provider session with the signed Hash. 
        /// </summary>
        /// <exception cref="DocuSign.eSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="completeSignRequest">CompleteSignRequest object.</param>
        /// <returns>ApiResponse of (CompleteSignHashResponse)</returns>
        ApiResponse<CompleteSignHashResponse> CompleteSignHashWithHttpInfo(CompleteSignRequest completeSignRequest);
        #endregion CompleteSignHash

        #region SignDocumentSessionInfo
        /// <summary>
        /// Provides signing session information for a Trust Service Provider. 
        /// </summary>
        /// <exception cref="DocuSign.eSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="signDocumentSessionInfo">SignSessionInfoRequest object.</param>
        /// <returns>SignHashSessionInfoResponse</returns>
        SignHashSessionInfoResponse SignDocumentSessionInfo(SignSessionInfoRequest signDocumentSessionInfo);

        /// <summary>
        /// Provides signing session information for a Trust Service Provider. 
        /// </summary>
        /// <exception cref="DocuSign.eSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="signDocumentSessionInfo">SignSessionInfoRequest object.</param>
        /// <returns>ApiResponse of (SignHashSessionInfoResponse)</returns>
        ApiResponse<SignHashSessionInfoResponse> SignDocumentSessionInfoWithHttpInfo(SignSessionInfoRequest signDocumentSessionInfo);
        #endregion SignHashSessionInfo

        #region CompleteSignDocument
        /// <summary>
        /// Finalize the Trust Service Provider session with the signed Hash. 
        /// </summary>
        /// <exception cref="DocuSign.eSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="completeSignRequest">CompleteSignRequest object.</param>
        /// <returns>CompleteSignHashResponse</returns>
        CompleteSignHashResponse CompleteSignDocument(CompleteSignRequest completeSignRequest);

        /// <summary>
        /// Finalize the Trust Service Provider session with the signed Hash. 
        /// </summary>
        /// <exception cref="DocuSign.eSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="completeSignRequest">CompleteSignRequest object.</param>
        /// <returns>ApiResponse of (CompleteSignHashResponse)</returns>
        ApiResponse<CompleteSignHashResponse> CompleteSignDocumentWithHttpInfo(CompleteSignRequest completeSignRequest);
        #endregion CompleteSignDocument

        #region UpdateTransaction
        /// <summary>
        /// Report an error from the Trust Service Provider to DocuSign. 
        /// </summary>
        /// <exception cref="DocuSign.eSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateTransactionRequest">UpdateTransactionRequest object.</param>
        /// <returns>UpdateTransactionResponse</returns>
        UpdateTransactionResponse UpdateTransaction(UpdateTransactionRequest updateTransactionRequest);

        /// <summary>
        /// Report an error from the Trust Service Provider to DocuSign. 
        /// </summary>
        /// <exception cref="DocuSign.eSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateTransactionRequest">UpdateTransactionRequest object.</param>
        /// <returns>ApiResponse of (UpdateTransactionResponse)</returns>
        ApiResponse<UpdateTransactionResponse> UpdateTransactionWithHttpInfo(UpdateTransactionRequest updateTransactionRequest);
        #endregion UpdateTransaction
        #endregion Synchronous Operations

        #region Asynchronous Operations
        #region SignHashSessionInfo
        /// <summary>
        /// Provides signing session information for a Trust Service Provider. 
        /// </summary>
        /// <exception cref="DocuSign.eSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="signHashSessionInfo">SignSessionInfoRequest object.</param>
        /// <returns>SignHashSessionInfoResponse</returns>
        System.Threading.Tasks.Task<SignHashSessionInfoResponse> SignHashSessionInfoAsync(SignSessionInfoRequest signHashSessionInfo);


        /// <summary>
        /// Provides signing session information for a Trust Service Provider. 
        /// </summary>
        /// <exception cref="DocuSign.eSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="signHashSessionInfo">SignSessionInfoRequest object.</param>
        /// <returns>ApiResponse of (SignHashSessionInfoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<SignHashSessionInfoResponse>> SignHashSessionInfoAsyncWithHttpInfo(SignSessionInfoRequest signHashSessionInfo);
        #endregion SignHashSessionInfo

        #region CompleteSignHash
        /// <summary>
        /// Finalize the Trust Service Provider session with the signed Hash. 
        /// </summary>
        /// <exception cref="DocuSign.eSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="completeSignRequest">CompleteSignRequest object.</param>
        /// <returns>CompleteSignHashResponse</returns>
        System.Threading.Tasks.Task<CompleteSignHashResponse> CompleteSignHashAsync(CompleteSignRequest completeSignRequest);

        /// <summary>
        /// Finalize the Trust Service Provider session with the signed Hash. 
        /// </summary>
        /// <exception cref="DocuSign.eSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="completeSignRequest">CompleteSignRequest object.</param>
        /// <returns>ApiResponse of (CompleteSignHashResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CompleteSignHashResponse>> CompleteSignHashAsyncWithHttpInfo(CompleteSignRequest completeSignRequest);
        #endregion CompleteSignHash

        #region SignDocumentSessionInfo
        /// <summary>
        /// Provides signing session information for a Trust Service Provider. 
        /// </summary>
        /// <exception cref="DocuSign.eSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="signHashSessionInfo">SignSessionInfoRequest object.</param>
        /// <returns>SignHashSessionInfoResponse</returns>
        System.Threading.Tasks.Task<SignHashSessionInfoResponse> SignDocumentSessionInfoAsync(SignSessionInfoRequest signHashSessionInfo);


        /// <summary>
        /// Provides signing session information for a Trust Service Provider. 
        /// </summary>
        /// <exception cref="DocuSign.eSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="signHashSessionInfo">SignSessionInfoRequest object.</param>
        /// <returns>ApiResponse of (SignHashSessionInfoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<SignHashSessionInfoResponse>> SignDocumentSessionInfoAsyncWithHttpInfo(SignSessionInfoRequest signHashSessionInfo);
        #endregion SignDocumentSessionInfo

        #region CompleteSignDocument
        /// <summary>
        /// Finalize the Trust Service Provider session with the signed Hash. 
        /// </summary>
        /// <exception cref="DocuSign.eSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="completeSignRequest">CompleteSignRequest object.</param>
        /// <returns>CompleteSignHashResponse</returns>
        System.Threading.Tasks.Task<CompleteSignHashResponse> CompleteSignDocumentAsync(CompleteSignRequest completeSignRequest);

        /// <summary>
        /// Finalize the Trust Service Provider session with the signed Hash. 
        /// </summary>
        /// <exception cref="DocuSign.eSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="completeSignRequest">CompleteSignRequest object.</param>
        /// <returns>ApiResponse of (CompleteSignHashResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CompleteSignHashResponse>> CompleteSignDocumentAsyncWithHttpInfo(CompleteSignRequest completeSignRequest);
        #endregion CompleteSignDocument

        #region UpdateTransaction
        /// <summary>
        /// Report an error from the Trust Service Provider to DocuSign. 
        /// </summary>
        /// <exception cref="DocuSign.eSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateTransactionRequest">UpdateTransactionRequest object.</param>
        /// <returns>UpdateTransactionResponse</returns>
        System.Threading.Tasks.Task<UpdateTransactionResponse> UpdateTransactionAsync(UpdateTransactionRequest updateTransactionRequest);


        /// <summary>
        /// Report an error from the Trust Service Provider to DocuSign. 
        /// </summary>
        /// <exception cref="DocuSign.eSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateTransactionRequest">UpdateTransactionRequest object.</param>
        /// <returns>ApiResponse of (UpdateTransactionResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<UpdateTransactionResponse>> UpdateTransactionAsyncWithHttpInfo(UpdateTransactionRequest updateTransactionRequest);
        #endregion UpdateTransaction
        #endregion Asynchronous Operations
    }


    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class SignatureApi : ISignatureApi
    {
        private DocuSign.eSign.Client.ExceptionFactory _exceptionFactory = (name, response) => null;
        private const string _defaultApiPath = "/v2.1/signature";

        #region Ctor
        /// <summary>
        /// Initializes a new instance of the <see cref="TrustServiceProvidersApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SignatureApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = DocuSign.eSign.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrustServiceProvidersApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SignatureApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = DocuSign.eSign.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
        #endregion

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public DocuSign.eSign.Client.ExceptionFactory ExceptionFactory
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

        #region Synchronous Operations
        #region SignHashSessionInfo
        /// <summary>
        /// Provides signing session information for a Trust Service Provider. 
        /// </summary>
        /// <exception cref="DocuSign.eSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="signHashSessionInfo">SignSessionInfoRequest object.</param>
        /// <returns>SignHashSessionInfoResponse</returns>
        public SignHashSessionInfoResponse SignHashSessionInfo(SignSessionInfoRequest signHashSessionInfo)
        {
            ApiResponse<SignHashSessionInfoResponse> localVarResponse = SignHashSessionInfoWithHttpInfo(signHashSessionInfo);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Provides signing session information for a Trust Service Provider. 
        /// </summary>
        /// <exception cref="DocuSign.eSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="signHashSessionInfo">SignSessionInfoRequest object.</param>
        /// <returns>ApiResponse of (SignHashSessionInfoResponse)</returns>
        public ApiResponse<SignHashSessionInfoResponse> SignHashSessionInfoWithHttpInfo(SignSessionInfoRequest signHashSessionInfo)
        {
            var localVarPath = _defaultApiPath + "/signhashsessioninfo";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = { };
            string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = { "application/json" };
            string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (signHashSessionInfo != null && signHashSessionInfo.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(signHashSessionInfo); // http body (model) parameter
            }
            else
            {
                localVarPostBody = signHashSessionInfo; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
            Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SignHashSessionInfo", localVarResponse);
                if (exception != null) throw exception;
            }


            // DocuSign: Handle for PDF return types
            if (localVarResponse.ContentType != null && !localVarResponse.ContentType.ToLower().Contains("json"))
            {
                return new ApiResponse<SignHashSessionInfoResponse>(localVarStatusCode, localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()), (SignHashSessionInfoResponse)Configuration.ApiClient.Deserialize(localVarResponse.RawBytes, typeof(SignHashSessionInfoResponse)));
            }
            else
            {
                return new ApiResponse<SignHashSessionInfoResponse>(localVarStatusCode, localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()), (SignHashSessionInfoResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(SignHashSessionInfoResponse)));
            }

        }

        #endregion SignHashSessionInfo

        #region CompleteSignHash
        /// <summary>
        /// Finalize the Trust Service Provider session with the signed Hash. 
        /// </summary>
        /// <exception cref="DocuSign.eSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="completeSignRequest">CompleteSignRequest object.</param>
        /// <returns>CompleteSignHashResponse</returns>
        public CompleteSignHashResponse CompleteSignHash(CompleteSignRequest completeSignRequest)
        {
            ApiResponse<CompleteSignHashResponse> localVarResponse = CompleteSignHashWithHttpInfo(completeSignRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Finalize the Trust Service Provider session with the signed Hash. 
        /// </summary>
        /// <exception cref="DocuSign.eSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="completeSignRequest">CompleteSignRequest object.</param>
        /// <returns>ApiResponse of (CompleteSignHashResponse)</returns>
        public ApiResponse<CompleteSignHashResponse> CompleteSignHashWithHttpInfo(CompleteSignRequest completeSignRequest)
        {
            var localVarPath = _defaultApiPath + "/completesignhash";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = { };
            string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = { "application/json" };
            string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (completeSignRequest != null && completeSignRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(completeSignRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = completeSignRequest; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
            Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CompleteSignHash", localVarResponse);
                if (exception != null) throw exception;
            }


            // DocuSign: Handle for PDF return types
            if (localVarResponse.ContentType != null && !localVarResponse.ContentType.ToLower().Contains("json"))
            {
                return new ApiResponse<CompleteSignHashResponse>(localVarStatusCode, localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()), (CompleteSignHashResponse)Configuration.ApiClient.Deserialize(localVarResponse.RawBytes, typeof(CompleteSignHashResponse)));
            }
            else
            {
                return new ApiResponse<CompleteSignHashResponse>(localVarStatusCode, localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()), (CompleteSignHashResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(CompleteSignHashResponse)));
            }

        }
        #endregion CompleteSignHash

        #region SignDocumentSessionInfo
        /// <summary>
        /// Provides signing session information for a Trust Service Provider. 
        /// </summary>
        /// <exception cref="DocuSign.eSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="signDocumentSessionInfo">SignSessionInfoRequest object.</param>
        /// <returns>SignHashSessionInfoResponse</returns>
        public SignHashSessionInfoResponse SignDocumentSessionInfo(SignSessionInfoRequest signDocumentSessionInfo)
        {
            ApiResponse<SignHashSessionInfoResponse> localVarResponse = SignDocumentSessionInfoWithHttpInfo(signDocumentSessionInfo);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Provides signing session information for a Trust Service Provider. 
        /// </summary>
        /// <exception cref="DocuSign.eSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="signDocumentSessionInfo">SignSessionInfoRequest object.</param>
        /// <returns>ApiResponse of (SignHashSessionInfoResponse)</returns>
        public ApiResponse<SignHashSessionInfoResponse> SignDocumentSessionInfoWithHttpInfo(SignSessionInfoRequest signDocumentSessionInfo)
        {
            var localVarPath = _defaultApiPath + "/signdocumentsessioninfo";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = { };
            string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = { "application/json" };
            string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (signDocumentSessionInfo != null && signDocumentSessionInfo.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(signDocumentSessionInfo); // http body (model) parameter
            }
            else
            {
                localVarPostBody = signDocumentSessionInfo; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
            Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SignDocumentSessionInfo", localVarResponse);
                if (exception != null) throw exception;
            }


            // DocuSign: Handle for PDF return types
            if (localVarResponse.ContentType != null && !localVarResponse.ContentType.ToLower().Contains("json"))
            {
                return new ApiResponse<SignHashSessionInfoResponse>(localVarStatusCode, localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()), (SignHashSessionInfoResponse)Configuration.ApiClient.Deserialize(localVarResponse.RawBytes, typeof(SignHashSessionInfoResponse)));
            }
            else
            {
                return new ApiResponse<SignHashSessionInfoResponse>(localVarStatusCode, localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()), (SignHashSessionInfoResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(SignHashSessionInfoResponse)));
            }

        }

        #endregion SignHashSessionInfo

        #region CompleteSignDocument
        /// <summary>
        /// Finalize the Trust Service Provider session with the signed Hash. 
        /// </summary>
        /// <exception cref="DocuSign.eSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="completeSignRequest">CompleteSignRequest object.</param>
        /// <returns>CompleteSignHashResponse</returns>
        public CompleteSignHashResponse CompleteSignDocument(CompleteSignRequest completeSignRequest)
        {
            ApiResponse<CompleteSignHashResponse> localVarResponse = CompleteSignDocumentWithHttpInfo(completeSignRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Finalize the Trust Service Provider session with the signed Hash. 
        /// </summary>
        /// <exception cref="DocuSign.eSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="completeSignRequest">CompleteSignRequest object.</param>
        /// <returns>ApiResponse of (CompleteSignHashResponse)</returns>
        public ApiResponse<CompleteSignHashResponse> CompleteSignDocumentWithHttpInfo(CompleteSignRequest completeSignRequest)
        {
            var localVarPath = _defaultApiPath + "/completesigndocument";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = { };
            string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = { "application/json" };
            string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (completeSignRequest != null && completeSignRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(completeSignRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = completeSignRequest; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
            Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CompleteSignDocument", localVarResponse);
                if (exception != null) throw exception;
            }


            // DocuSign: Handle for PDF return types
            if (localVarResponse.ContentType != null && !localVarResponse.ContentType.ToLower().Contains("json"))
            {
                return new ApiResponse<CompleteSignHashResponse>(localVarStatusCode, localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()), (CompleteSignHashResponse)Configuration.ApiClient.Deserialize(localVarResponse.RawBytes, typeof(CompleteSignHashResponse)));
            }
            else
            {
                return new ApiResponse<CompleteSignHashResponse>(localVarStatusCode, localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()), (CompleteSignHashResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(CompleteSignHashResponse)));
            }

        }
        #endregion CompleteSignHash

        #region UpdateTransaction
        /// <summary>
        /// Report an error from the Trust Service Provider to DocuSign. 
        /// </summary>
        /// <exception cref="DocuSign.eSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateTransactionRequest">UpdateTransactionRequest object.</param>
        /// <returns>UpdateTransactionResponse</returns>
        public UpdateTransactionResponse UpdateTransaction(UpdateTransactionRequest updateTransactionRequest)
        {
            ApiResponse<UpdateTransactionResponse> localVarResponse = UpdateTransactionWithHttpInfo(updateTransactionRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Report an error from the Trust Service Provider to DocuSign. 
        /// </summary>
        /// <exception cref="DocuSign.eSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateTransactionRequest">UpdateTransactionRequest object.</param>
        /// <returns>ApiResponse of (UpdateTransactionResponse)</returns>
        public ApiResponse<UpdateTransactionResponse> UpdateTransactionWithHttpInfo(UpdateTransactionRequest updateTransactionRequest)
        {
            var localVarPath = _defaultApiPath + "/updatetransaction";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = { };
            string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = { "application/json" };
            string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (updateTransactionRequest != null && updateTransactionRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(updateTransactionRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = updateTransactionRequest; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
            Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdateTransaction", localVarResponse);
                if (exception != null) throw exception;
            }


            // DocuSign: Handle for PDF return types
            if (localVarResponse.ContentType != null && !localVarResponse.ContentType.ToLower().Contains("json"))
            {
                return new ApiResponse<UpdateTransactionResponse>(localVarStatusCode, localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()), (UpdateTransactionResponse)Configuration.ApiClient.Deserialize(localVarResponse.RawBytes, typeof(UpdateTransactionResponse)));
            }
            else
            {
                return new ApiResponse<UpdateTransactionResponse>(localVarStatusCode, localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()), (UpdateTransactionResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(UpdateTransactionResponse)));
            }

        }
        #endregion UpdateTransaction
        
        #endregion Synchronous Operations

        #region Asynchronous Operations
        #region SignHashSessionInfo
        /// <summary>
        /// Returns Account available seals for specified account. 
        /// </summary>
        /// <exception cref="DocuSign.eSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="signHashSessionInfo">The external account number (int) or account ID Guid.</param>
        /// <returns>Task of SignHashSessionInfoResponse</returns>
        public async System.Threading.Tasks.Task<SignHashSessionInfoResponse> SignHashSessionInfoAsync(SignSessionInfoRequest signHashSessionInfo)
        {
            ApiResponse<SignHashSessionInfoResponse> localVarResponse = await SignHashSessionInfoAsyncWithHttpInfo(signHashSessionInfo);
            return localVarResponse.Data;

        }

        /// <summary>
        /// Returns Account available seals for specified account. 
        /// </summary>
        /// <exception cref="DocuSign.eSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="signHashSessionInfo">The external account number (int) or account ID Guid.</param>
        /// <returns>Task of ApiResponse (SignHashSessionInfoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SignHashSessionInfoResponse>> SignHashSessionInfoAsyncWithHttpInfo(SignSessionInfoRequest signHashSessionInfo)
        {
            var localVarPath = _defaultApiPath + "/signhashsessioninfo";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (signHashSessionInfo != null && signHashSessionInfo.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(signHashSessionInfo); // http body (model) parameter
            }
            else
            {
                localVarPostBody = signHashSessionInfo; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SignHashSessionInfo", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SignHashSessionInfoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SignHashSessionInfoResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(SignHashSessionInfoResponse)));

        }
        #endregion SignHashSessionInfo
        
        #region CompleteSignHash
        /// <summary>
        /// Finalize the Trust Service Provider session with the signed Hash. 
        /// </summary>
        /// <exception cref="DocuSign.eSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="completeSignRequest">CompleteSignRequest object.</param>
        /// <returns>CompleteSignHashResponse</returns>
        public async System.Threading.Tasks.Task<CompleteSignHashResponse> CompleteSignHashAsync(CompleteSignRequest completeSignRequest)
        {
            ApiResponse<CompleteSignHashResponse> localVarResponse = await CompleteSignHashAsyncWithHttpInfo(completeSignRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Finalize the Trust Service Provider session with the signed Hash. 
        /// </summary>
        /// <exception cref="DocuSign.eSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="completeSignRequest">CompleteSignRequest object.</param>
        /// <returns>ApiResponse of (CompleteSignHashResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CompleteSignHashResponse>> CompleteSignHashAsyncWithHttpInfo(CompleteSignRequest completeSignRequest)
        {
            var localVarPath = _defaultApiPath + "/completesignhash";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = { };
            string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = { "application/json" };
            string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (completeSignRequest != null && completeSignRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(completeSignRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = completeSignRequest; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
            Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CompleteSignHash", localVarResponse);
                if (exception != null) throw exception;
            }


            // DocuSign: Handle for PDF return types
            return new ApiResponse<CompleteSignHashResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CompleteSignHashResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(CompleteSignHashResponse)));
        }
        #endregion CompleteSignHash

        #region SignDocumentSessionInfo
        /// <summary>
        /// Returns Account available seals for specified account. 
        /// </summary>
        /// <exception cref="DocuSign.eSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="signDocumentSessionInfo">The external account number (int) or account ID Guid.</param>
        /// <returns>Task of SignHashSessionInfoResponse</returns>
        public async System.Threading.Tasks.Task<SignHashSessionInfoResponse> SignDocumentSessionInfoAsync(SignSessionInfoRequest signDocumentSessionInfo)
        {
            ApiResponse<SignHashSessionInfoResponse> localVarResponse = await SignDocumentSessionInfoAsyncWithHttpInfo(signDocumentSessionInfo);
            return localVarResponse.Data;

        }

        /// <summary>
        /// Returns Account available seals for specified account. 
        /// </summary>
        /// <exception cref="DocuSign.eSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="signDocumentSessionInfo">The external account number (int) or account ID Guid.</param>
        /// <returns>Task of ApiResponse (SignHashSessionInfoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SignHashSessionInfoResponse>> SignDocumentSessionInfoAsyncWithHttpInfo(SignSessionInfoRequest signDocumentSessionInfo)
        {
            var localVarPath = _defaultApiPath + "/signdocumentsessioninfo";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (signDocumentSessionInfo != null && signDocumentSessionInfo.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(signDocumentSessionInfo); // http body (model) parameter
            }
            else
            {
                localVarPostBody = signDocumentSessionInfo; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SignDocumentSessionInfo", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SignHashSessionInfoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SignHashSessionInfoResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(SignHashSessionInfoResponse)));

        }
        #endregion SignDocumentSessionInfo

        #region CompleteSignDocument
        /// <summary>
        /// Finalize the Trust Service Provider session with the signed Hash. 
        /// </summary>
        /// <exception cref="DocuSign.eSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="completeSignRequest">CompleteSignRequest object.</param>
        /// <returns>CompleteSignHashResponse</returns>
        public async System.Threading.Tasks.Task<CompleteSignHashResponse> CompleteSignDocumentAsync(CompleteSignRequest completeSignRequest)
        {
            ApiResponse<CompleteSignHashResponse> localVarResponse = await CompleteSignDocumentAsyncWithHttpInfo(completeSignRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Finalize the Trust Service Provider session with the signed Hash. 
        /// </summary>
        /// <exception cref="DocuSign.eSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="completeSignRequest">CompleteSignRequest object.</param>
        /// <returns>ApiResponse of (CompleteSignHashResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CompleteSignHashResponse>> CompleteSignDocumentAsyncWithHttpInfo(CompleteSignRequest completeSignRequest)
        {
            var localVarPath = _defaultApiPath + "/completesigndocument";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = { };
            string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = { "application/json" };
            string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (completeSignRequest != null && completeSignRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(completeSignRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = completeSignRequest; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
            Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CompleteSignDocument", localVarResponse);
                if (exception != null) throw exception;
            }


            // DocuSign: Handle for PDF return types
            return new ApiResponse<CompleteSignHashResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CompleteSignHashResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(CompleteSignHashResponse)));
        }
        #endregion CompleteSignDocument

        #region UpdateTransaction
        /// <summary>
        /// Report an error from the Trust Service Provider to DocuSign. 
        /// </summary>
        /// <exception cref="DocuSign.eSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateTransactionRequest">UpdateTransactionRequest object.</param>
        /// <returns>UpdateTransactionResponse</returns>
        public async System.Threading.Tasks.Task<UpdateTransactionResponse> UpdateTransactionAsync(UpdateTransactionRequest updateTransactionRequest)
        {
            ApiResponse<UpdateTransactionResponse> localVarResponse = await UpdateTransactionAsyncWithHttpInfo(updateTransactionRequest);
            return localVarResponse.Data;

        }

        /// <summary>
        /// Report an error from the Trust Service Provider to DocuSign. 
        /// </summary>
        /// <exception cref="DocuSign.eSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateTransactionRequest">UpdateTransactionRequest object.</param>
        /// <returns>ApiResponse of (UpdateTransactionResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UpdateTransactionResponse>> UpdateTransactionAsyncWithHttpInfo(UpdateTransactionRequest updateTransactionRequest)
        {
            var localVarPath = _defaultApiPath + "/updatetransaction";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (updateTransactionRequest != null && updateTransactionRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(updateTransactionRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = updateTransactionRequest; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdateTransaction", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<UpdateTransactionResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UpdateTransactionResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(UpdateTransactionResponse)));

        }
        #endregion UpdateTransaction
        #endregion Asynchronous Operations

    }
}