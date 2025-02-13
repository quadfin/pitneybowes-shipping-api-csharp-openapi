/* 
 * Shipping API
 *
 * Shipping API Sample.
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: support@pb.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using shippingapi.Client;
using shippingapi.Model;

namespace shippingapi.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IRateParcelsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Use this operation to rate a parcel before you print and purchase a shipment label. You can rate a parcel for multiple services and multiple parcel types with a single API request.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="shippingapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipment">Shipment request for Rates</param>
        /// <param name="xPBUnifiedErrorStructure">Set this to true to use the standard [error object](https://shipping.pitneybowes.com/reference/error-object.html#standard-error-object) if an error occurs. (optional, default to true)</param>
        /// <param name="xPBShipperRatePlan">USPS Only. Shipper rate plan, if applicable. For more information, see [this FAQ](https://shipping.pitneybowes.com/faqs/rates.html#rate-plans-faq) (optional)</param>
        /// <param name="xPBIntegratorCarrierId">USPS Only. Negotiated services rate, if applicable. (optional)</param>
        /// <param name="xPBShipperCarrierAccountId">UPS (United Parcel Service) Only. The unique identifier returned in the shipperCarrierAccountId field by the [Register an Existing Carrier Account](https://shipping.pitneybowes.com/api/post-carrier-accounts-register.html) API. (optional)</param>
        /// <param name="includeDeliveryCommitment">When set to true, returns estimated transit time in days. (optional)</param>
        /// <param name="carrier">Cross-Border only. Required for PB Cross-Border. Set this to PBI. (optional)</param>
        /// <returns>Shipment</returns>
        Shipment RateParcel (Shipment shipment, bool? xPBUnifiedErrorStructure = default(bool?), string xPBShipperRatePlan = default(string), string xPBIntegratorCarrierId = default(string), string xPBShipperCarrierAccountId = default(string), bool? includeDeliveryCommitment = default(bool?), string carrier = default(string));

        /// <summary>
        /// Use this operation to rate a parcel before you print and purchase a shipment label. You can rate a parcel for multiple services and multiple parcel types with a single API request.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="shippingapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipment">Shipment request for Rates</param>
        /// <param name="xPBUnifiedErrorStructure">Set this to true to use the standard [error object](https://shipping.pitneybowes.com/reference/error-object.html#standard-error-object) if an error occurs. (optional, default to true)</param>
        /// <param name="xPBShipperRatePlan">USPS Only. Shipper rate plan, if applicable. For more information, see [this FAQ](https://shipping.pitneybowes.com/faqs/rates.html#rate-plans-faq) (optional)</param>
        /// <param name="xPBIntegratorCarrierId">USPS Only. Negotiated services rate, if applicable. (optional)</param>
        /// <param name="xPBShipperCarrierAccountId">UPS (United Parcel Service) Only. The unique identifier returned in the shipperCarrierAccountId field by the [Register an Existing Carrier Account](https://shipping.pitneybowes.com/api/post-carrier-accounts-register.html) API. (optional)</param>
        /// <param name="includeDeliveryCommitment">When set to true, returns estimated transit time in days. (optional)</param>
        /// <param name="carrier">Cross-Border only. Required for PB Cross-Border. Set this to PBI. (optional)</param>
        /// <returns>ApiResponse of Shipment</returns>
        ApiResponse<Shipment> RateParcelWithHttpInfo (Shipment shipment, bool? xPBUnifiedErrorStructure = default(bool?), string xPBShipperRatePlan = default(string), string xPBIntegratorCarrierId = default(string), string xPBShipperCarrierAccountId = default(string), bool? includeDeliveryCommitment = default(bool?), string carrier = default(string));
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Use this operation to rate a parcel before you print and purchase a shipment label. You can rate a parcel for multiple services and multiple parcel types with a single API request.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="shippingapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipment">Shipment request for Rates</param>
        /// <param name="xPBUnifiedErrorStructure">Set this to true to use the standard [error object](https://shipping.pitneybowes.com/reference/error-object.html#standard-error-object) if an error occurs. (optional, default to true)</param>
        /// <param name="xPBShipperRatePlan">USPS Only. Shipper rate plan, if applicable. For more information, see [this FAQ](https://shipping.pitneybowes.com/faqs/rates.html#rate-plans-faq) (optional)</param>
        /// <param name="xPBIntegratorCarrierId">USPS Only. Negotiated services rate, if applicable. (optional)</param>
        /// <param name="xPBShipperCarrierAccountId">UPS (United Parcel Service) Only. The unique identifier returned in the shipperCarrierAccountId field by the [Register an Existing Carrier Account](https://shipping.pitneybowes.com/api/post-carrier-accounts-register.html) API. (optional)</param>
        /// <param name="includeDeliveryCommitment">When set to true, returns estimated transit time in days. (optional)</param>
        /// <param name="carrier">Cross-Border only. Required for PB Cross-Border. Set this to PBI. (optional)</param>
        /// <returns>Task of Shipment</returns>
        System.Threading.Tasks.Task<Shipment> RateParcelAsync (Shipment shipment, bool? xPBUnifiedErrorStructure = default(bool?), string xPBShipperRatePlan = default(string), string xPBIntegratorCarrierId = default(string), string xPBShipperCarrierAccountId = default(string), bool? includeDeliveryCommitment = default(bool?), string carrier = default(string));

        /// <summary>
        /// Use this operation to rate a parcel before you print and purchase a shipment label. You can rate a parcel for multiple services and multiple parcel types with a single API request.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="shippingapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipment">Shipment request for Rates</param>
        /// <param name="xPBUnifiedErrorStructure">Set this to true to use the standard [error object](https://shipping.pitneybowes.com/reference/error-object.html#standard-error-object) if an error occurs. (optional, default to true)</param>
        /// <param name="xPBShipperRatePlan">USPS Only. Shipper rate plan, if applicable. For more information, see [this FAQ](https://shipping.pitneybowes.com/faqs/rates.html#rate-plans-faq) (optional)</param>
        /// <param name="xPBIntegratorCarrierId">USPS Only. Negotiated services rate, if applicable. (optional)</param>
        /// <param name="xPBShipperCarrierAccountId">UPS (United Parcel Service) Only. The unique identifier returned in the shipperCarrierAccountId field by the [Register an Existing Carrier Account](https://shipping.pitneybowes.com/api/post-carrier-accounts-register.html) API. (optional)</param>
        /// <param name="includeDeliveryCommitment">When set to true, returns estimated transit time in days. (optional)</param>
        /// <param name="carrier">Cross-Border only. Required for PB Cross-Border. Set this to PBI. (optional)</param>
        /// <returns>Task of ApiResponse (Shipment)</returns>
        System.Threading.Tasks.Task<ApiResponse<Shipment>> RateParcelAsyncWithHttpInfo (Shipment shipment, bool? xPBUnifiedErrorStructure = default(bool?), string xPBShipperRatePlan = default(string), string xPBIntegratorCarrierId = default(string), string xPBShipperCarrierAccountId = default(string), bool? includeDeliveryCommitment = default(bool?), string carrier = default(string));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class RateParcelsApi : IRateParcelsApi
    {
        private shippingapi.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="RateParcelsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public RateParcelsApi(String basePath)
        {
            this.Configuration = new shippingapi.Client.Configuration { BasePath = basePath };

            ExceptionFactory = shippingapi.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RateParcelsApi"/> class
        /// </summary>
        /// <returns></returns>
        public RateParcelsApi()
        {
            this.Configuration = shippingapi.Client.Configuration.Default;

            ExceptionFactory = shippingapi.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RateParcelsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public RateParcelsApi(shippingapi.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = shippingapi.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = shippingapi.Client.Configuration.DefaultExceptionFactory;
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
        public shippingapi.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public shippingapi.Client.ExceptionFactory ExceptionFactory
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
        /// Use this operation to rate a parcel before you print and purchase a shipment label. You can rate a parcel for multiple services and multiple parcel types with a single API request. 
        /// </summary>
        /// <exception cref="shippingapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipment">Shipment request for Rates</param>
        /// <param name="xPBUnifiedErrorStructure">Set this to true to use the standard [error object](https://shipping.pitneybowes.com/reference/error-object.html#standard-error-object) if an error occurs. (optional, default to true)</param>
        /// <param name="xPBShipperRatePlan">USPS Only. Shipper rate plan, if applicable. For more information, see [this FAQ](https://shipping.pitneybowes.com/faqs/rates.html#rate-plans-faq) (optional)</param>
        /// <param name="xPBIntegratorCarrierId">USPS Only. Negotiated services rate, if applicable. (optional)</param>
        /// <param name="xPBShipperCarrierAccountId">UPS (United Parcel Service) Only. The unique identifier returned in the shipperCarrierAccountId field by the [Register an Existing Carrier Account](https://shipping.pitneybowes.com/api/post-carrier-accounts-register.html) API. (optional)</param>
        /// <param name="includeDeliveryCommitment">When set to true, returns estimated transit time in days. (optional)</param>
        /// <param name="carrier">Cross-Border only. Required for PB Cross-Border. Set this to PBI. (optional)</param>
        /// <returns>Shipment</returns>
        public Shipment RateParcel (Shipment shipment, bool? xPBUnifiedErrorStructure = default(bool?), string xPBShipperRatePlan = default(string), string xPBIntegratorCarrierId = default(string), string xPBShipperCarrierAccountId = default(string), bool? includeDeliveryCommitment = default(bool?), string carrier = default(string))
        {
             ApiResponse<Shipment> localVarResponse = RateParcelWithHttpInfo(shipment, xPBUnifiedErrorStructure, xPBShipperRatePlan, xPBIntegratorCarrierId, xPBShipperCarrierAccountId, includeDeliveryCommitment, carrier);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Use this operation to rate a parcel before you print and purchase a shipment label. You can rate a parcel for multiple services and multiple parcel types with a single API request. 
        /// </summary>
        /// <exception cref="shippingapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipment">Shipment request for Rates</param>
        /// <param name="xPBUnifiedErrorStructure">Set this to true to use the standard [error object](https://shipping.pitneybowes.com/reference/error-object.html#standard-error-object) if an error occurs. (optional, default to true)</param>
        /// <param name="xPBShipperRatePlan">USPS Only. Shipper rate plan, if applicable. For more information, see [this FAQ](https://shipping.pitneybowes.com/faqs/rates.html#rate-plans-faq) (optional)</param>
        /// <param name="xPBIntegratorCarrierId">USPS Only. Negotiated services rate, if applicable. (optional)</param>
        /// <param name="xPBShipperCarrierAccountId">UPS (United Parcel Service) Only. The unique identifier returned in the shipperCarrierAccountId field by the [Register an Existing Carrier Account](https://shipping.pitneybowes.com/api/post-carrier-accounts-register.html) API. (optional)</param>
        /// <param name="includeDeliveryCommitment">When set to true, returns estimated transit time in days. (optional)</param>
        /// <param name="carrier">Cross-Border only. Required for PB Cross-Border. Set this to PBI. (optional)</param>
        /// <returns>ApiResponse of Shipment</returns>
        public ApiResponse<Shipment> RateParcelWithHttpInfo (Shipment shipment, bool? xPBUnifiedErrorStructure = default(bool?), string xPBShipperRatePlan = default(string), string xPBIntegratorCarrierId = default(string), string xPBShipperCarrierAccountId = default(string), bool? includeDeliveryCommitment = default(bool?), string carrier = default(string))
        {
            // verify the required parameter 'shipment' is set
            if (shipment == null)
                throw new ApiException(400, "Missing required parameter 'shipment' when calling RateParcelsApi->RateParcel");

            var localVarPath = "/v1/rates";
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

            if (includeDeliveryCommitment != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "includeDeliveryCommitment", includeDeliveryCommitment)); // query parameter
            if (carrier != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "carrier", carrier)); // query parameter
            if (xPBUnifiedErrorStructure != null) localVarHeaderParams.Add("X-PB-UnifiedErrorStructure", this.Configuration.ApiClient.ParameterToString(xPBUnifiedErrorStructure)); // header parameter
            if (xPBShipperRatePlan != null) localVarHeaderParams.Add("X-PB-Shipper-Rate-Plan", this.Configuration.ApiClient.ParameterToString(xPBShipperRatePlan)); // header parameter
            if (xPBIntegratorCarrierId != null) localVarHeaderParams.Add("X-PB-Integrator-CarrierId", this.Configuration.ApiClient.ParameterToString(xPBIntegratorCarrierId)); // header parameter
            if (xPBShipperCarrierAccountId != null) localVarHeaderParams.Add("X-PB-Shipper-Carrier-AccountId", this.Configuration.ApiClient.ParameterToString(xPBShipperCarrierAccountId)); // header parameter
            if (shipment != null && shipment.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(shipment); // http body (model) parameter
            }
            else
            {
                localVarPostBody = shipment; // byte array
            }

            // authentication (oAuth2ClientCredentials) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
            string requestUrl = $"POST {localVarPath}?" + string.Join("&", localVarQueryParams.Select(kvp => $"{kvp.Key}={kvp.Value}").ToList());
            string requestHeaders = string.Join("; ", localVarHeaderParams.Select(kvp => $"{kvp.Key}: {kvp.Value}"));
            string requestBody = localVarPostBody?.ToString() ?? string.Empty;

            if (ExceptionFactory != null)
            {
                ApiException exception = ExceptionFactory("RateParcel", localVarResponse);
                if (exception != null)
                {
                    exception.RequestUrl = requestUrl;
                    exception.RequestHeaders = requestHeaders;
                    exception.RequestBody = requestBody;
                    throw exception;
                }
            }

            return new ApiResponse<Shipment>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Shipment) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Shipment)),
                requestUrl, requestHeaders, requestBody, localVarResponse.Content
                );
        }

        /// <summary>
        /// Use this operation to rate a parcel before you print and purchase a shipment label. You can rate a parcel for multiple services and multiple parcel types with a single API request. 
        /// </summary>
        /// <exception cref="shippingapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipment">Shipment request for Rates</param>
        /// <param name="xPBUnifiedErrorStructure">Set this to true to use the standard [error object](https://shipping.pitneybowes.com/reference/error-object.html#standard-error-object) if an error occurs. (optional, default to true)</param>
        /// <param name="xPBShipperRatePlan">USPS Only. Shipper rate plan, if applicable. For more information, see [this FAQ](https://shipping.pitneybowes.com/faqs/rates.html#rate-plans-faq) (optional)</param>
        /// <param name="xPBIntegratorCarrierId">USPS Only. Negotiated services rate, if applicable. (optional)</param>
        /// <param name="xPBShipperCarrierAccountId">UPS (United Parcel Service) Only. The unique identifier returned in the shipperCarrierAccountId field by the [Register an Existing Carrier Account](https://shipping.pitneybowes.com/api/post-carrier-accounts-register.html) API. (optional)</param>
        /// <param name="includeDeliveryCommitment">When set to true, returns estimated transit time in days. (optional)</param>
        /// <param name="carrier">Cross-Border only. Required for PB Cross-Border. Set this to PBI. (optional)</param>
        /// <returns>Task of Shipment</returns>
        public async System.Threading.Tasks.Task<Shipment> RateParcelAsync (Shipment shipment, bool? xPBUnifiedErrorStructure = default(bool?), string xPBShipperRatePlan = default(string), string xPBIntegratorCarrierId = default(string), string xPBShipperCarrierAccountId = default(string), bool? includeDeliveryCommitment = default(bool?), string carrier = default(string))
        {
             ApiResponse<Shipment> localVarResponse = await RateParcelAsyncWithHttpInfo(shipment, xPBUnifiedErrorStructure, xPBShipperRatePlan, xPBIntegratorCarrierId, xPBShipperCarrierAccountId, includeDeliveryCommitment, carrier);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Use this operation to rate a parcel before you print and purchase a shipment label. You can rate a parcel for multiple services and multiple parcel types with a single API request. 
        /// </summary>
        /// <exception cref="shippingapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipment">Shipment request for Rates</param>
        /// <param name="xPBUnifiedErrorStructure">Set this to true to use the standard [error object](https://shipping.pitneybowes.com/reference/error-object.html#standard-error-object) if an error occurs. (optional, default to true)</param>
        /// <param name="xPBShipperRatePlan">USPS Only. Shipper rate plan, if applicable. For more information, see [this FAQ](https://shipping.pitneybowes.com/faqs/rates.html#rate-plans-faq) (optional)</param>
        /// <param name="xPBIntegratorCarrierId">USPS Only. Negotiated services rate, if applicable. (optional)</param>
        /// <param name="xPBShipperCarrierAccountId">UPS (United Parcel Service) Only. The unique identifier returned in the shipperCarrierAccountId field by the [Register an Existing Carrier Account](https://shipping.pitneybowes.com/api/post-carrier-accounts-register.html) API. (optional)</param>
        /// <param name="includeDeliveryCommitment">When set to true, returns estimated transit time in days. (optional)</param>
        /// <param name="carrier">Cross-Border only. Required for PB Cross-Border. Set this to PBI. (optional)</param>
        /// <returns>Task of ApiResponse (Shipment)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Shipment>> RateParcelAsyncWithHttpInfo (Shipment shipment, bool? xPBUnifiedErrorStructure = default(bool?), string xPBShipperRatePlan = default(string), string xPBIntegratorCarrierId = default(string), string xPBShipperCarrierAccountId = default(string), bool? includeDeliveryCommitment = default(bool?), string carrier = default(string))
        {
            // verify the required parameter 'shipment' is set
            if (shipment == null)
                throw new ApiException(400, "Missing required parameter 'shipment' when calling RateParcelsApi->RateParcel");

            var localVarPath = "/v1/rates";
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

            if (includeDeliveryCommitment != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "includeDeliveryCommitment", includeDeliveryCommitment)); // query parameter
            if (carrier != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "carrier", carrier)); // query parameter
            if (xPBUnifiedErrorStructure != null) localVarHeaderParams.Add("X-PB-UnifiedErrorStructure", this.Configuration.ApiClient.ParameterToString(xPBUnifiedErrorStructure)); // header parameter
            if (xPBShipperRatePlan != null) localVarHeaderParams.Add("X-PB-Shipper-Rate-Plan", this.Configuration.ApiClient.ParameterToString(xPBShipperRatePlan)); // header parameter
            if (xPBIntegratorCarrierId != null) localVarHeaderParams.Add("X-PB-Integrator-CarrierId", this.Configuration.ApiClient.ParameterToString(xPBIntegratorCarrierId)); // header parameter
            if (xPBShipperCarrierAccountId != null) localVarHeaderParams.Add("X-PB-Shipper-Carrier-AccountId", this.Configuration.ApiClient.ParameterToString(xPBShipperCarrierAccountId)); // header parameter
            if (shipment != null && shipment.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(shipment); // http body (model) parameter
            }
            else
            {
                localVarPostBody = shipment; // byte array
            }

            // authentication (oAuth2ClientCredentials) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("RateParcel", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Shipment>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Shipment) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Shipment)));
        }

    }
}
