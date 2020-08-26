# shippingapi.Api.PickupApi

All URIs are relative to *https://api-sandbox.pitneybowes.com/shippingservices*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CancelPickup**](PickupApi.md#cancelpickup) | **POST** /v1/pickups/{pickupId}/cancel | Cancel Pickup
[**GetPickupschedule**](PickupApi.md#getpickupschedule) | **POST** /v1/pickups/schedule | Address validation



## CancelPickup

> InlineResponse2001 CancelPickup (string xPBTransactionId, string pickupId, bool? xPBUnifiedErrorStructure = null)

Cancel Pickup

This operation schedules a USPS package pickup from a residential or commercial location and provides a pickup confirmation number.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using shippingapi.Api;
using shippingapi.Client;
using shippingapi.Model;

namespace Example
{
    public class CancelPickupExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-sandbox.pitneybowes.com/shippingservices";
            // Configure OAuth2 access token for authorization: oAuth2ClientCredentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PickupApi(Configuration.Default);
            var xPBTransactionId = xPBTransactionId_example;  // string | A unique identifier for the transaction, up to 25 characters
            var pickupId = pickupId_example;  // string | A unique identifier for the transaction, up to 25 characters
            var xPBUnifiedErrorStructure = true;  // bool? | Set this to true to use the standard [error object](https://shipping.pitneybowes.com/reference/error-object.html#standard-error-object) if an error occurs. (optional)  (default to true)

            try
            {
                // Cancel Pickup
                InlineResponse2001 result = apiInstance.CancelPickup(xPBTransactionId, pickupId, xPBUnifiedErrorStructure);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PickupApi.CancelPickup: " + e.Message );
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
 **xPBTransactionId** | **string**| A unique identifier for the transaction, up to 25 characters | 
 **pickupId** | **string**| A unique identifier for the transaction, up to 25 characters | 
 **xPBUnifiedErrorStructure** | **bool?**| Set this to true to use the standard [error object](https://shipping.pitneybowes.com/reference/error-object.html#standard-error-object) if an error occurs. | [optional] [default to true]

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[oAuth2ClientCredentials](../README.md#oAuth2ClientCredentials)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetPickupschedule

> SchedulePickupResponse GetPickupschedule (string xPBTransactionId, SchedulePickup schedulePickup, bool? xPBUnifiedErrorStructure = null)

Address validation

This operation schedules a USPS package pickup from a residential or commercial location and provides a pickup confirmation number.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using shippingapi.Api;
using shippingapi.Client;
using shippingapi.Model;

namespace Example
{
    public class GetPickupscheduleExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-sandbox.pitneybowes.com/shippingservices";
            // Configure OAuth2 access token for authorization: oAuth2ClientCredentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PickupApi(Configuration.Default);
            var xPBTransactionId = xPBTransactionId_example;  // string | A unique identifier for the transaction, up to 25 characters
            var schedulePickup = new SchedulePickup(); // SchedulePickup | Schedule Pickup request.
            var xPBUnifiedErrorStructure = true;  // bool? | Set this to true to use the standard [error object](https://shipping.pitneybowes.com/reference/error-object.html#standard-error-object) if an error occurs. (optional)  (default to true)

            try
            {
                // Address validation
                SchedulePickupResponse result = apiInstance.GetPickupschedule(xPBTransactionId, schedulePickup, xPBUnifiedErrorStructure);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PickupApi.GetPickupschedule: " + e.Message );
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
 **xPBTransactionId** | **string**| A unique identifier for the transaction, up to 25 characters | 
 **schedulePickup** | [**SchedulePickup**](SchedulePickup.md)| Schedule Pickup request. | 
 **xPBUnifiedErrorStructure** | **bool?**| Set this to true to use the standard [error object](https://shipping.pitneybowes.com/reference/error-object.html#standard-error-object) if an error occurs. | [optional] [default to true]

### Return type

[**SchedulePickupResponse**](SchedulePickupResponse.md)

### Authorization

[oAuth2ClientCredentials](../README.md#oAuth2ClientCredentials)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **405** | Invalid input |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

