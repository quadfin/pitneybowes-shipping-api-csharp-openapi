# shippingapi.Api.ContainerApi

All URIs are relative to *https://api-sandbox.pitneybowes.com/shippingservices*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetContainerizedParcelsLabels**](ContainerApi.md#getcontainerizedparcelslabels) | **POST** /v1/container-manifest | Create Container Manifest Label



## GetContainerizedParcelsLabels

> ContainerManifestResponse GetContainerizedParcelsLabels (string xPBTransactionId, Manifest manifest, bool? xPBUnifiedErrorStructure = null)

Create Container Manifest Label

This operation prints a label for the shipment of containerized parcels destined for a Pitney Bowes warehouse facility from the client location.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using shippingapi.Api;
using shippingapi.Client;
using shippingapi.Model;

namespace Example
{
    public class GetContainerizedParcelsLabelsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-sandbox.pitneybowes.com/shippingservices";
            // Configure OAuth2 access token for authorization: oAuth2ClientCredentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContainerApi(Configuration.Default);
            var xPBTransactionId = xPBTransactionId_example;  // string | Required. A unique identifier for the transaction, up to 25 characters.
            var manifest = new Manifest(); // Manifest | manifest
            var xPBUnifiedErrorStructure = true;  // bool? | Set this to true to use the standard [error object](https://shipping.pitneybowes.com/reference/error-object.html#standard-error-object) if an error occurs. (optional)  (default to true)

            try
            {
                // Create Container Manifest Label
                ContainerManifestResponse result = apiInstance.GetContainerizedParcelsLabels(xPBTransactionId, manifest, xPBUnifiedErrorStructure);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ContainerApi.GetContainerizedParcelsLabels: " + e.Message );
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

[**ContainerManifestResponse**](ContainerManifestResponse.md)

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

