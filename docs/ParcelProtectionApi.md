# shippingapi.Api.ParcelProtectionApi

All URIs are relative to *https://shipping-api-sandbox.pitneybowes.com/shippingservices*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CancelParcelProtection**](ParcelProtectionApi.md#cancelparcelprotection) | **POST** /v1/parcel-protection/void | Parcel Protection Coverage
[**GetParcelProtectionCoverage**](ParcelProtectionApi.md#getparcelprotectioncoverage) | **POST** /v1/parcel-protection/create | Parcel Protection Coverage
[**GetParcelProtectionQuote**](ParcelProtectionApi.md#getparcelprotectionquote) | **POST** /v1/parcel-protection/quote | Parcel Protection Quote
[**GetParcelProtectionReports**](ParcelProtectionApi.md#getparcelprotectionreports) | **GET** /v1/parcel-protection/{developerId}/policies | Parcel Protection Reports



## CancelParcelProtection

> VoidParcelProtectionResponse CancelParcelProtection (string xPBTransactionId, string parcelProtectionReferenceId, VoidParcelProtectionRequest voidParcelProtectionRequest, bool? xPBUnifiedErrorStructure = null)

Parcel Protection Coverage

This API lets merchants request Pitney Bowes [Parcel Protection](https://shipping.pitneybowes.com/faqs/parcel-protection.html) coverage for shipments. Merchants can request coverage for shipments created with the Shipping APIs as well as for shipments created with other platforms.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using shippingapi.Api;
using shippingapi.Client;
using shippingapi.Model;

namespace Example
{
    public class CancelParcelProtectionExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://shipping-api-sandbox.pitneybowes.com/shippingservices";
            // Configure OAuth2 access token for authorization: oAuth2ClientCredentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ParcelProtectionApi(Configuration.Default);
            var xPBTransactionId = xPBTransactionId_example;  // string | Required. A unique identifier for the transaction, up to 25 characters.
            var parcelProtectionReferenceId = parcelProtectionReferenceId_example;  // string | Required. The identifier for the PB Parcel Protection policy that is being voided.
            var voidParcelProtectionRequest = new VoidParcelProtectionRequest(); // VoidParcelProtectionRequest | manifest
            var xPBUnifiedErrorStructure = true;  // bool? | Set this to true to use the standard [error object](https://shipping.pitneybowes.com/reference/error-object.html#standard-error-object) if an error occurs. (optional)  (default to true)

            try
            {
                // Parcel Protection Coverage
                VoidParcelProtectionResponse result = apiInstance.CancelParcelProtection(xPBTransactionId, parcelProtectionReferenceId, voidParcelProtectionRequest, xPBUnifiedErrorStructure);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ParcelProtectionApi.CancelParcelProtection: " + e.Message );
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
 **xPBTransactionId** | **string**| Required. A unique identifier for the transaction, up to 25 characters. | 
 **parcelProtectionReferenceId** | **string**| Required. The identifier for the PB Parcel Protection policy that is being voided. | 
 **voidParcelProtectionRequest** | [**VoidParcelProtectionRequest**](VoidParcelProtectionRequest.md)| manifest | 
 **xPBUnifiedErrorStructure** | **bool?**| Set this to true to use the standard [error object](https://shipping.pitneybowes.com/reference/error-object.html#standard-error-object) if an error occurs. | [optional] [default to true]

### Return type

[**VoidParcelProtectionResponse**](VoidParcelProtectionResponse.md)

### Authorization

[oAuth2ClientCredentials](../README.md#oAuth2ClientCredentials)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **0** | Error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetParcelProtectionCoverage

> ParcelProtectionCreateResponse GetParcelProtectionCoverage (string xPBTransactionId, ParcelProtectionCreateRequest parcelProtectionCreateRequest, bool? xPBUnifiedErrorStructure = null)

Parcel Protection Coverage

This API lets merchants request Pitney Bowes [Parcel Protection](https://shipping.pitneybowes.com/faqs/parcel-protection.html) coverage for shipments. Merchants can request coverage for shipments created with the Shipping APIs as well as for shipments created with other platforms.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using shippingapi.Api;
using shippingapi.Client;
using shippingapi.Model;

namespace Example
{
    public class GetParcelProtectionCoverageExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://shipping-api-sandbox.pitneybowes.com/shippingservices";
            // Configure OAuth2 access token for authorization: oAuth2ClientCredentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ParcelProtectionApi(Configuration.Default);
            var xPBTransactionId = xPBTransactionId_example;  // string | Required. A unique identifier for the transaction, up to 25 characters.
            var parcelProtectionCreateRequest = new ParcelProtectionCreateRequest(); // ParcelProtectionCreateRequest | manifest
            var xPBUnifiedErrorStructure = true;  // bool? | Set this to true to use the standard [error object](https://shipping.pitneybowes.com/reference/error-object.html#standard-error-object) if an error occurs. (optional)  (default to true)

            try
            {
                // Parcel Protection Coverage
                ParcelProtectionCreateResponse result = apiInstance.GetParcelProtectionCoverage(xPBTransactionId, parcelProtectionCreateRequest, xPBUnifiedErrorStructure);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ParcelProtectionApi.GetParcelProtectionCoverage: " + e.Message );
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
 **xPBTransactionId** | **string**| Required. A unique identifier for the transaction, up to 25 characters. | 
 **parcelProtectionCreateRequest** | [**ParcelProtectionCreateRequest**](ParcelProtectionCreateRequest.md)| manifest | 
 **xPBUnifiedErrorStructure** | **bool?**| Set this to true to use the standard [error object](https://shipping.pitneybowes.com/reference/error-object.html#standard-error-object) if an error occurs. | [optional] [default to true]

### Return type

[**ParcelProtectionCreateResponse**](ParcelProtectionCreateResponse.md)

### Authorization

[oAuth2ClientCredentials](../README.md#oAuth2ClientCredentials)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **0** | Error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetParcelProtectionQuote

> ParcelProtectionQuoteResponse GetParcelProtectionQuote (string xPBTransactionId, ParcelProtectionQuoteRequest parcelProtectionQuoteRequest, bool? xPBUnifiedErrorStructure = null)

Parcel Protection Quote

This API provides a quote for covering a shipment through Pitney Bowes [Parcel Protection](https://www.pitneybowes.com/us/ecommerce-delivery-services/parcel-protection.html).

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using shippingapi.Api;
using shippingapi.Client;
using shippingapi.Model;

namespace Example
{
    public class GetParcelProtectionQuoteExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://shipping-api-sandbox.pitneybowes.com/shippingservices";
            // Configure OAuth2 access token for authorization: oAuth2ClientCredentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ParcelProtectionApi(Configuration.Default);
            var xPBTransactionId = xPBTransactionId_example;  // string | Required. A unique identifier for the transaction, up to 25 characters.
            var parcelProtectionQuoteRequest = new ParcelProtectionQuoteRequest(); // ParcelProtectionQuoteRequest | manifest
            var xPBUnifiedErrorStructure = true;  // bool? | Set this to true to use the standard [error object](https://shipping.pitneybowes.com/reference/error-object.html#standard-error-object) if an error occurs. (optional)  (default to true)

            try
            {
                // Parcel Protection Quote
                ParcelProtectionQuoteResponse result = apiInstance.GetParcelProtectionQuote(xPBTransactionId, parcelProtectionQuoteRequest, xPBUnifiedErrorStructure);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ParcelProtectionApi.GetParcelProtectionQuote: " + e.Message );
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
 **xPBTransactionId** | **string**| Required. A unique identifier for the transaction, up to 25 characters. | 
 **parcelProtectionQuoteRequest** | [**ParcelProtectionQuoteRequest**](ParcelProtectionQuoteRequest.md)| manifest | 
 **xPBUnifiedErrorStructure** | **bool?**| Set this to true to use the standard [error object](https://shipping.pitneybowes.com/reference/error-object.html#standard-error-object) if an error occurs. | [optional] [default to true]

### Return type

[**ParcelProtectionQuoteResponse**](ParcelProtectionQuoteResponse.md)

### Authorization

[oAuth2ClientCredentials](../README.md#oAuth2ClientCredentials)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **0** | Error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetParcelProtectionReports

> ParcelProtectionPolicyResponse GetParcelProtectionReports (string xPBTransactionId, string developerId, string policyCreatedFromDate, bool? xPBUnifiedErrorStructure = null, string policyCreatedToDate = null, string policyReferenceId = null, string parcelTrackingNumber = null, string merchantId = null, string policyStatus = null, string size = null, string page = null, string sort = null)

Parcel Protection Reports

This operation retrieves the policy status and other information on the Parcel Protection policies you have purchased for your shipments. Further Details https://shipping.pitneybowes.com/api/get-parcel-protection-reports.html

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using shippingapi.Api;
using shippingapi.Client;
using shippingapi.Model;

namespace Example
{
    public class GetParcelProtectionReportsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://shipping-api-sandbox.pitneybowes.com/shippingservices";
            // Configure OAuth2 access token for authorization: oAuth2ClientCredentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ParcelProtectionApi(Configuration.Default);
            var xPBTransactionId = xPBTransactionId_example;  // string | Required. A unique identifier for the transaction, up to 25 characters.
            var developerId = developerId_example;  // string | Required. Your Pitney Bowes developer ID.
            var policyCreatedFromDate = policyCreatedFromDate_example;  // string | The beginning of the date range. Specify this value in UTC using the ISO 8601 standard. You must include both date and time, and you must end the time with Z to indicate a zero offset.
            var xPBUnifiedErrorStructure = true;  // bool? | Set this to true to use the standard [error object](https://shipping.pitneybowes.com/reference/error-object.html#standard-error-object) if an error occurs. (optional)  (default to true)
            var policyCreatedToDate = policyCreatedToDate_example;  // string | The end of the date range. Specify this value in UTC using the ISO 8601 standard. You must include both date and time, and you must end the time with Z to indicate a zero offset. (optional) 
            var policyReferenceId = policyReferenceId_example;  // string | The unique identifier for the PB Parcel Protection policy.]. (optional) 
            var parcelTrackingNumber = parcelTrackingNumber_example;  // string | The parcel tracking number of the shipment that the policy applies to. (optional) 
            var merchantId = merchantId_example;  // string | The merchant's Shipper ID. This is the value of the postalReportingNumber element in the Merchant Object. (optional) 
            var policyStatus = policyStatus_example;  // string | Whether the policy is active or voided. (optional) 
            var size = size_example;  // string | The number of transactions to return per page in the result set. (optional) 
            var page = page_example;  // string | The index number of the page to return. Page index numbering starts at 0. Specifying page=0 returns the first page of the result set. (optional) 
            var sort = sort_example;  // string | Defines a property to sort on and the sort order. Sort order can be ascending (asc) or descending (desc). (optional) 

            try
            {
                // Parcel Protection Reports
                ParcelProtectionPolicyResponse result = apiInstance.GetParcelProtectionReports(xPBTransactionId, developerId, policyCreatedFromDate, xPBUnifiedErrorStructure, policyCreatedToDate, policyReferenceId, parcelTrackingNumber, merchantId, policyStatus, size, page, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ParcelProtectionApi.GetParcelProtectionReports: " + e.Message );
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
 **xPBTransactionId** | **string**| Required. A unique identifier for the transaction, up to 25 characters. | 
 **developerId** | **string**| Required. Your Pitney Bowes developer ID. | 
 **policyCreatedFromDate** | **string**| The beginning of the date range. Specify this value in UTC using the ISO 8601 standard. You must include both date and time, and you must end the time with Z to indicate a zero offset. | 
 **xPBUnifiedErrorStructure** | **bool?**| Set this to true to use the standard [error object](https://shipping.pitneybowes.com/reference/error-object.html#standard-error-object) if an error occurs. | [optional] [default to true]
 **policyCreatedToDate** | **string**| The end of the date range. Specify this value in UTC using the ISO 8601 standard. You must include both date and time, and you must end the time with Z to indicate a zero offset. | [optional] 
 **policyReferenceId** | **string**| The unique identifier for the PB Parcel Protection policy.]. | [optional] 
 **parcelTrackingNumber** | **string**| The parcel tracking number of the shipment that the policy applies to. | [optional] 
 **merchantId** | **string**| The merchant&#39;s Shipper ID. This is the value of the postalReportingNumber element in the Merchant Object. | [optional] 
 **policyStatus** | **string**| Whether the policy is active or voided. | [optional] 
 **size** | **string**| The number of transactions to return per page in the result set. | [optional] 
 **page** | **string**| The index number of the page to return. Page index numbering starts at 0. Specifying page&#x3D;0 returns the first page of the result set. | [optional] 
 **sort** | **string**| Defines a property to sort on and the sort order. Sort order can be ascending (asc) or descending (desc). | [optional] 

### Return type

[**ParcelProtectionPolicyResponse**](ParcelProtectionPolicyResponse.md)

### Authorization

[oAuth2ClientCredentials](../README.md#oAuth2ClientCredentials)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **0** | Error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

