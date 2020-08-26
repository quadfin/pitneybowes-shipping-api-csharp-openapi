# shippingapi.Api.ManifestsApi

All URIs are relative to *https://api-sandbox.pitneybowes.com/shippingservices*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateManifest**](ManifestsApi.md#createmanifest) | **POST** /v1/manifests | This operation creates an end-of-day manifest
[**ReprintManifest**](ManifestsApi.md#reprintmanifest) | **GET** /v1/manifests/{manifestId} | reprintManifest
[**RetryManifest**](ManifestsApi.md#retrymanifest) | **GET** /v1/manifests | retryManifest



## CreateManifest

> Manifest CreateManifest (string xPBTransactionId, Manifest manifest, bool? xPBUnifiedErrorStructure = null)

This operation creates an end-of-day manifest

This operation creates an end-of-day manifest that either combines all parcels into a single form or electronically closes the day, depending on the carrier. Use the instructions appropriate to the carrier. * Create a [USPS SCAN Form](https://shipping.pitneybowes.com/api/post-manifests-scan.html)  * Create a [Newgistics Closeout](https://shipping.pitneybowes.com/api/post-manifests-newgistics.html) * Create a [PB Presort Pickup Slip](https://shipping.pitneybowes.com/api/post-manifests-presort.html) * Create a [Manifest for PMOD Shipments](https://shipping.pitneybowes.com/api/post-manifests-pmod.html)

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using shippingapi.Api;
using shippingapi.Client;
using shippingapi.Model;

namespace Example
{
    public class CreateManifestExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-sandbox.pitneybowes.com/shippingservices";
            // Configure OAuth2 access token for authorization: oAuth2ClientCredentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ManifestsApi(Configuration.Default);
            var xPBTransactionId = xPBTransactionId_example;  // string | Required. A unique identifier for the transaction, up to 25 characters.
            var manifest = new Manifest(); // Manifest | manifest
            var xPBUnifiedErrorStructure = true;  // bool? | Set this to true to use the standard [error object](https://shipping.pitneybowes.com/reference/error-object.html#standard-error-object) if an error occurs. (optional)  (default to true)

            try
            {
                // This operation creates an end-of-day manifest
                Manifest result = apiInstance.CreateManifest(xPBTransactionId, manifest, xPBUnifiedErrorStructure);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManifestsApi.CreateManifest: " + e.Message );
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

[**Manifest**](Manifest.md)

### Authorization

[oAuth2ClientCredentials](../README.md#oAuth2ClientCredentials)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | OK |  -  |
| **0** | Error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ReprintManifest

> Manifest ReprintManifest (string manifestId, bool? xPBUnifiedErrorStructure = null)

reprintManifest

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using shippingapi.Api;
using shippingapi.Client;
using shippingapi.Model;

namespace Example
{
    public class ReprintManifestExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-sandbox.pitneybowes.com/shippingservices";
            // Configure OAuth2 access token for authorization: oAuth2ClientCredentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ManifestsApi(Configuration.Default);
            var manifestId = manifestId_example;  // string | manifestId
            var xPBUnifiedErrorStructure = true;  // bool? | Set this to true to use the standard [error object](https://shipping.pitneybowes.com/reference/error-object.html#standard-error-object) if an error occurs. (optional)  (default to true)

            try
            {
                // reprintManifest
                Manifest result = apiInstance.ReprintManifest(manifestId, xPBUnifiedErrorStructure);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManifestsApi.ReprintManifest: " + e.Message );
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
 **manifestId** | **string**| manifestId | 
 **xPBUnifiedErrorStructure** | **bool?**| Set this to true to use the standard [error object](https://shipping.pitneybowes.com/reference/error-object.html#standard-error-object) if an error occurs. | [optional] [default to true]

### Return type

[**Manifest**](Manifest.md)

### Authorization

[oAuth2ClientCredentials](../README.md#oAuth2ClientCredentials)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **201** | OK |  -  |
| **0** | Error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## RetryManifest

> Manifest RetryManifest (string originalTransactionId, bool? xPBUnifiedErrorStructure = null)

retryManifest

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using shippingapi.Api;
using shippingapi.Client;
using shippingapi.Model;

namespace Example
{
    public class RetryManifestExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-sandbox.pitneybowes.com/shippingservices";
            // Configure OAuth2 access token for authorization: oAuth2ClientCredentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ManifestsApi(Configuration.Default);
            var originalTransactionId = originalTransactionId_example;  // string | 
            var xPBUnifiedErrorStructure = true;  // bool? | Set this to true to use the standard [error object](https://shipping.pitneybowes.com/reference/error-object.html#standard-error-object) if an error occurs. (optional)  (default to true)

            try
            {
                // retryManifest
                Manifest result = apiInstance.RetryManifest(originalTransactionId, xPBUnifiedErrorStructure);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManifestsApi.RetryManifest: " + e.Message );
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
 **originalTransactionId** | **string**|  | 
 **xPBUnifiedErrorStructure** | **bool?**| Set this to true to use the standard [error object](https://shipping.pitneybowes.com/reference/error-object.html#standard-error-object) if an error occurs. | [optional] [default to true]

### Return type

[**Manifest**](Manifest.md)

### Authorization

[oAuth2ClientCredentials](../README.md#oAuth2ClientCredentials)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **201** | OK |  -  |
| **0** | Error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

