# shippingapi.Api.CarrierInfoApi

All URIs are relative to *https://api-sandbox.pitneybowes.com/shippingservices*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCarrierFacilities**](CarrierInfoApi.md#getcarrierfacilities) | **POST** /v1/carrier-facility | Find Carrier Facilities
[**GetCarrierLicenseAgreement**](CarrierInfoApi.md#getcarrierlicenseagreement) | **GET** /v1/carrier/license-agreements | This operation retrieves a carrier&#39;s license agreement.
[**GetCarrierServiceRules**](CarrierInfoApi.md#getcarrierservicerules) | **GET** /v1/information/rules/rating-services | Retrieves the rules governing the carrier&#39;s services.
[**GetCarrierSupportedDestination**](CarrierInfoApi.md#getcarriersupporteddestination) | **GET** /v1/countries | This operation returns a list of supported destination countries to which the carrier offers international shipping services.



## GetCarrierFacilities

> CarrierFacilityResponse GetCarrierFacilities (CarrierFacilityRequest carrierFacilityRequest, bool? xPBUnifiedErrorStructure = null)

Find Carrier Facilities

This operation locates Post Offices and other facilities for a given carrier. You can use this operation, for example, to locate all USPS Post Offices near to a given postal code.If you use the Standard Return API and if you use the option to print a QR code, use this API to locate facilities where the buyer can print the label from the QR code.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using shippingapi.Api;
using shippingapi.Client;
using shippingapi.Model;

namespace Example
{
    public class GetCarrierFacilitiesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-sandbox.pitneybowes.com/shippingservices";
            // Configure OAuth2 access token for authorization: oAuth2ClientCredentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CarrierInfoApi(Configuration.Default);
            var carrierFacilityRequest = new CarrierFacilityRequest(); // CarrierFacilityRequest | 
            var xPBUnifiedErrorStructure = true;  // bool? | Set this to true to use the standard [error object](https://shipping.pitneybowes.com/reference/error-object.html#standard-error-object) if an error occurs. (optional)  (default to true)

            try
            {
                // Find Carrier Facilities
                CarrierFacilityResponse result = apiInstance.GetCarrierFacilities(carrierFacilityRequest, xPBUnifiedErrorStructure);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CarrierInfoApi.GetCarrierFacilities: " + e.Message );
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
 **carrierFacilityRequest** | [**CarrierFacilityRequest**](CarrierFacilityRequest.md)|  | 
 **xPBUnifiedErrorStructure** | **bool?**| Set this to true to use the standard [error object](https://shipping.pitneybowes.com/reference/error-object.html#standard-error-object) if an error occurs. | [optional] [default to true]

### Return type

[**CarrierFacilityResponse**](CarrierFacilityResponse.md)

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


## GetCarrierLicenseAgreement

> InlineResponse200 GetCarrierLicenseAgreement (string carrier, ISOCountryCode originCountryCode, bool? xPBUnifiedErrorStructure = null)

This operation retrieves a carrier's license agreement.

This operation retrieves a carrier's license agreement. The operation is used in the [Carrier Registration Tutorial](https://shipping.pitneybowes.com/carrier-registration.html).

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using shippingapi.Api;
using shippingapi.Client;
using shippingapi.Model;

namespace Example
{
    public class GetCarrierLicenseAgreementExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-sandbox.pitneybowes.com/shippingservices";
            // Configure OAuth2 access token for authorization: oAuth2ClientCredentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CarrierInfoApi(Configuration.Default);
            var carrier = UPS;  // string | The carrier name. Currently this must be set to: UPS (default to "UPS")
            var originCountryCode = US;  // ISOCountryCode | The two-character ISO country code for the country where the shipment originates.
            var xPBUnifiedErrorStructure = true;  // bool? | Set this to true to use the standard [error object](https://shipping.pitneybowes.com/reference/error-object.html#standard-error-object) if an error occurs. (optional)  (default to true)

            try
            {
                // This operation retrieves a carrier's license agreement.
                InlineResponse200 result = apiInstance.GetCarrierLicenseAgreement(carrier, originCountryCode, xPBUnifiedErrorStructure);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CarrierInfoApi.GetCarrierLicenseAgreement: " + e.Message );
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
 **carrier** | **string**| The carrier name. Currently this must be set to: UPS | [default to &quot;UPS&quot;]
 **originCountryCode** | **ISOCountryCode**| The two-character ISO country code for the country where the shipment originates. | 
 **xPBUnifiedErrorStructure** | **bool?**| Set this to true to use the standard [error object](https://shipping.pitneybowes.com/reference/error-object.html#standard-error-object) if an error occurs. | [optional] [default to true]

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[oAuth2ClientCredentials](../README.md#oAuth2ClientCredentials)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **0** | Error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetCarrierServiceRules

> CarrierRule GetCarrierServiceRules (Carrier carrier, ISOCountryCode originCountryCode, ISOCountryCode destinationCountryCode, bool? xPBUnifiedErrorStructure = null, string rateTypeId = null, string futureShipmentDate = null, DateTime? returnShipment = null, bool? compactResponse = null)

Retrieves the rules governing the carrier's services.

This operation retrieves the rules governing the carrier's services, including the available parcel types and the limits on weights and dimensions. **This API currently returns rules only for USPS** . Find more information at [Get Carrier Rules](https://shipping.pitneybowes.com/api/get-carrier-rules.html)

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using shippingapi.Api;
using shippingapi.Client;
using shippingapi.Model;

namespace Example
{
    public class GetCarrierServiceRulesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-sandbox.pitneybowes.com/shippingservices";
            // Configure OAuth2 access token for authorization: oAuth2ClientCredentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CarrierInfoApi(Configuration.Default);
            var carrier = USPS;  // Carrier | The carrier name. **Currently this must be set to: USPS** 
            var originCountryCode = US;  // ISOCountryCode | The [two-character ISO country code](https://www.iso.org/obp/ui/#search) for the country where the shipment originates.
            var destinationCountryCode = IN;  // ISOCountryCode | The [two-character ISO country code](https://www.iso.org/obp/ui/#search) for the country of the shipment's destination address.
            var xPBUnifiedErrorStructure = true;  // bool? | Set this to true to use the standard [error object](https://shipping.pitneybowes.com/reference/error-object.html#standard-error-object) if an error occurs. (optional)  (default to true)
            var rateTypeId = rateTypeId_example;  // string | The type of rate requested, such as COMMERCIAL_BASE. If a rate type is not specified, all eligible rate types are returned. (optional) 
            var futureShipmentDate = futureShipmentDate_example;  // string | If the shipment is for a future date, and if a rate change is expected before the shipment date, use this field to ensure you get the correct rates and correct rate rules. Note that a rate change can affect the structure of the rate rules as well as the actual rates.Specify this value in UTC/GMT, not in local time. Formats allowed are   * **YYYY-MM-DD**   * **YYYY-MM-DD HH:mm:ss** * **YYYY-MM-DD HH:mm:ss.SSS** (optional) 
            var returnShipment = 2013-10-20T19:20:30+01:00;  // DateTime? | If set to true, provides only services applicable for return shipment. (optional) 
            var compactResponse = true;  // bool? | If set to true, returns only summary, without special service details. (optional) 

            try
            {
                // Retrieves the rules governing the carrier's services.
                CarrierRule result = apiInstance.GetCarrierServiceRules(carrier, originCountryCode, destinationCountryCode, xPBUnifiedErrorStructure, rateTypeId, futureShipmentDate, returnShipment, compactResponse);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CarrierInfoApi.GetCarrierServiceRules: " + e.Message );
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
 **carrier** | **Carrier**| The carrier name. **Currently this must be set to: USPS**  | 
 **originCountryCode** | **ISOCountryCode**| The [two-character ISO country code](https://www.iso.org/obp/ui/#search) for the country where the shipment originates. | 
 **destinationCountryCode** | **ISOCountryCode**| The [two-character ISO country code](https://www.iso.org/obp/ui/#search) for the country of the shipment&#39;s destination address. | 
 **xPBUnifiedErrorStructure** | **bool?**| Set this to true to use the standard [error object](https://shipping.pitneybowes.com/reference/error-object.html#standard-error-object) if an error occurs. | [optional] [default to true]
 **rateTypeId** | **string**| The type of rate requested, such as COMMERCIAL_BASE. If a rate type is not specified, all eligible rate types are returned. | [optional] 
 **futureShipmentDate** | **string**| If the shipment is for a future date, and if a rate change is expected before the shipment date, use this field to ensure you get the correct rates and correct rate rules. Note that a rate change can affect the structure of the rate rules as well as the actual rates.Specify this value in UTC/GMT, not in local time. Formats allowed are   * **YYYY-MM-DD**   * **YYYY-MM-DD HH:mm:ss** * **YYYY-MM-DD HH:mm:ss.SSS** | [optional] 
 **returnShipment** | **DateTime?**| If set to true, provides only services applicable for return shipment. | [optional] 
 **compactResponse** | **bool?**| If set to true, returns only summary, without special service details. | [optional] 

### Return type

[**CarrierRule**](CarrierRule.md)

### Authorization

[oAuth2ClientCredentials](../README.md#oAuth2ClientCredentials)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **0** | For a list of all PB Shipping APIs error codes, please see [Error Codes](https://shipping.pitneybowes.com/reference/error-codes.html) |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetCarrierSupportedDestination

> List&lt;Object&gt; GetCarrierSupportedDestination (Carrier carrier, ISOCountryCode originCountryCode, bool? xPBUnifiedErrorStructure = null)

This operation returns a list of supported destination countries to which the carrier offers international shipping services.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using shippingapi.Api;
using shippingapi.Client;
using shippingapi.Model;

namespace Example
{
    public class GetCarrierSupportedDestinationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-sandbox.pitneybowes.com/shippingservices";
            // Configure OAuth2 access token for authorization: oAuth2ClientCredentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CarrierInfoApi(Configuration.Default);
            var carrier = usps;  // Carrier | The carrier name. Currently this must be set to: USPS
            var originCountryCode = US;  // ISOCountryCode | The two-character ISO country code for the country where the shipment originates.
            var xPBUnifiedErrorStructure = true;  // bool? | Set this to true to use the standard [error object](https://shipping.pitneybowes.com/reference/error-object.html#standard-error-object) if an error occurs. (optional)  (default to true)

            try
            {
                // This operation returns a list of supported destination countries to which the carrier offers international shipping services.
                List<Object> result = apiInstance.GetCarrierSupportedDestination(carrier, originCountryCode, xPBUnifiedErrorStructure);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CarrierInfoApi.GetCarrierSupportedDestination: " + e.Message );
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
 **carrier** | **Carrier**| The carrier name. Currently this must be set to: USPS | 
 **originCountryCode** | **ISOCountryCode**| The two-character ISO country code for the country where the shipment originates. | 
 **xPBUnifiedErrorStructure** | **bool?**| Set this to true to use the standard [error object](https://shipping.pitneybowes.com/reference/error-object.html#standard-error-object) if an error occurs. | [optional] [default to true]

### Return type

**List<Object>**

### Authorization

[oAuth2ClientCredentials](../README.md#oAuth2ClientCredentials)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **0** | Error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

