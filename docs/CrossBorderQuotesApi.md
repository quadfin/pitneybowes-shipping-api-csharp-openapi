# shippingapi.Api.CrossBorderQuotesApi

All URIs are relative to *https://shipping-api-sandbox.pitneybowes.com/shippingservices*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCrossBorderQuotes**](CrossBorderQuotesApi.md#getcrossborderquotes) | **POST** /v1/crossborder/checkout/quotes | Cross-Border Quotes
[**PredictedHSCode**](CrossBorderQuotesApi.md#predictedhscode) | **POST** /v1/crossborder/hs-classification/items | Predicts the HS Code for a parcel



## GetCrossBorderQuotes

> CrossBorderQuotesResponse GetCrossBorderQuotes (CrossBorderQuotesRequest crossBorderQuotesRequest, bool? xPBUnifiedErrorStructure = null)

Cross-Border Quotes

This operation provides an estimate of the duties, taxes, and transportation costs for the items in a buyer's online shopping basket. The API calculates how many separate parcels are required to ship the items and estimates costs. The API checks each item's eligibility to clear customs and returns the quote for eligible items. To look for futher info please look into [Cross-Border Quotes](https://shipping.pitneybowes.com/api/post-quotes.html#)

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using shippingapi.Api;
using shippingapi.Client;
using shippingapi.Model;

namespace Example
{
    public class GetCrossBorderQuotesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://shipping-api-sandbox.pitneybowes.com/shippingservices";
            // Configure OAuth2 access token for authorization: oAuth2ClientCredentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CrossBorderQuotesApi(Configuration.Default);
            var crossBorderQuotesRequest = new CrossBorderQuotesRequest(); // CrossBorderQuotesRequest | 
            var xPBUnifiedErrorStructure = true;  // bool? | Set this to true to use the standard [error object](https://shipping.pitneybowes.com/reference/error-object.html#standard-error-object) if an error occurs. (optional)  (default to true)

            try
            {
                // Cross-Border Quotes
                CrossBorderQuotesResponse result = apiInstance.GetCrossBorderQuotes(crossBorderQuotesRequest, xPBUnifiedErrorStructure);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CrossBorderQuotesApi.GetCrossBorderQuotes: " + e.Message );
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
 **crossBorderQuotesRequest** | [**CrossBorderQuotesRequest**](CrossBorderQuotesRequest.md)|  | 
 **xPBUnifiedErrorStructure** | **bool?**| Set this to true to use the standard [error object](https://shipping.pitneybowes.com/reference/error-object.html#standard-error-object) if an error occurs. | [optional] [default to true]

### Return type

[**CrossBorderQuotesResponse**](CrossBorderQuotesResponse.md)

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


## PredictedHSCode

> ParcelProtectionPolicyResponse PredictedHSCode (string xPBTransactionId, Manifest manifest, bool? xPBUnifiedErrorStructure = null)

Predicts the HS Code for a parcel

This operation predicts the HS Code for a parcel being shipped internationally and gives the level of confidence in the prediction.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using shippingapi.Api;
using shippingapi.Client;
using shippingapi.Model;

namespace Example
{
    public class PredictedHSCodeExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://shipping-api-sandbox.pitneybowes.com/shippingservices";
            // Configure OAuth2 access token for authorization: oAuth2ClientCredentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CrossBorderQuotesApi(Configuration.Default);
            var xPBTransactionId = xPBTransactionId_example;  // string | Required. A unique identifier for the transaction, up to 25 characters.
            var manifest = new Manifest(); // Manifest | manifest
            var xPBUnifiedErrorStructure = true;  // bool? | Set this to true to use the standard [error object](https://shipping.pitneybowes.com/reference/error-object.html#standard-error-object) if an error occurs. (optional)  (default to true)

            try
            {
                // Predicts the HS Code for a parcel
                ParcelProtectionPolicyResponse result = apiInstance.PredictedHSCode(xPBTransactionId, manifest, xPBUnifiedErrorStructure);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CrossBorderQuotesApi.PredictedHSCode: " + e.Message );
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
 **manifest** | [**Manifest**](Manifest.md)| manifest | 
 **xPBUnifiedErrorStructure** | **bool?**| Set this to true to use the standard [error object](https://shipping.pitneybowes.com/reference/error-object.html#standard-error-object) if an error occurs. | [optional] [default to true]

### Return type

[**ParcelProtectionPolicyResponse**](ParcelProtectionPolicyResponse.md)

### Authorization

[oAuth2ClientCredentials](../README.md#oAuth2ClientCredentials)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: text/plain

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

