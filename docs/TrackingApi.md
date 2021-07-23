# shippingapi.Api.TrackingApi

All URIs are relative to *https://shipping-api-sandbox.pitneybowes.com/shippingservices*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddTrackingEvents**](TrackingApi.md#addtrackingevents) | **POST** /v2/track/events | getTrackingDetails
[**GetTrackingDetails**](TrackingApi.md#gettrackingdetails) | **GET** /v1/tracking/{trackingNumber} | getTrackingDetails



## AddTrackingEvents

> InlineResponse2002 AddTrackingEvents (AddTrackingEvents addTrackingEvents, bool? xPBUnifiedErrorStructure = null)

getTrackingDetails

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using shippingapi.Api;
using shippingapi.Client;
using shippingapi.Model;

namespace Example
{
    public class AddTrackingEventsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://shipping-api-sandbox.pitneybowes.com/shippingservices";
            // Configure OAuth2 access token for authorization: oAuth2ClientCredentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TrackingApi(Configuration.Default);
            var addTrackingEvents = new AddTrackingEvents(); // AddTrackingEvents | add track event
            var xPBUnifiedErrorStructure = true;  // bool? | Set this to true to use the standard [error object](https://shipping.pitneybowes.com/reference/error-object.html#standard-error-object) if an error occurs. (optional)  (default to true)

            try
            {
                // getTrackingDetails
                InlineResponse2002 result = apiInstance.AddTrackingEvents(addTrackingEvents, xPBUnifiedErrorStructure);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TrackingApi.AddTrackingEvents: " + e.Message );
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
 **addTrackingEvents** | [**AddTrackingEvents**](AddTrackingEvents.md)| add track event | 
 **xPBUnifiedErrorStructure** | **bool?**| Set this to true to use the standard [error object](https://shipping.pitneybowes.com/reference/error-object.html#standard-error-object) if an error occurs. | [optional] [default to true]

### Return type

[**InlineResponse2002**](InlineResponse2002.md)

### Authorization

[oAuth2ClientCredentials](../README.md#oAuth2ClientCredentials)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Error |  -  |
| **0** | Error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetTrackingDetails

> TrackingResponse GetTrackingDetails (string trackingNumber, string packageIdentifierType, string carrier, bool? xPBUnifiedErrorStructure = null)

getTrackingDetails

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using shippingapi.Api;
using shippingapi.Client;
using shippingapi.Model;

namespace Example
{
    public class GetTrackingDetailsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://shipping-api-sandbox.pitneybowes.com/shippingservices";
            // Configure OAuth2 access token for authorization: oAuth2ClientCredentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TrackingApi(Configuration.Default);
            var trackingNumber = trackingNumber_example;  // string | The tracking number for the shipment.
            var packageIdentifierType = packageIdentifierType_example;  // string | packageIdentifierType (default to "TrackingNumber")
            var carrier = carrier_example;  // string | carrier
            var xPBUnifiedErrorStructure = true;  // bool? | Set this to true to use the standard [error object](https://shipping.pitneybowes.com/reference/error-object.html#standard-error-object) if an error occurs. (optional)  (default to true)

            try
            {
                // getTrackingDetails
                TrackingResponse result = apiInstance.GetTrackingDetails(trackingNumber, packageIdentifierType, carrier, xPBUnifiedErrorStructure);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TrackingApi.GetTrackingDetails: " + e.Message );
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
 **trackingNumber** | **string**| The tracking number for the shipment. | 
 **packageIdentifierType** | **string**| packageIdentifierType | [default to &quot;TrackingNumber&quot;]
 **carrier** | **string**| carrier | 
 **xPBUnifiedErrorStructure** | **bool?**| Set this to true to use the standard [error object](https://shipping.pitneybowes.com/reference/error-object.html#standard-error-object) if an error occurs. | [optional] [default to true]

### Return type

[**TrackingResponse**](TrackingResponse.md)

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

