# shippingapi.Api.AddressValidationApi

All URIs are relative to *https://api-sandbox.pitneybowes.com/shippingservices*

Method | HTTP request | Description
------------- | ------------- | -------------
[**VerifyAddress**](AddressValidationApi.md#verifyaddress) | **POST** /v1/addresses/verify | Address validation
[**VerifyAndSuggestAddress**](AddressValidationApi.md#verifyandsuggestaddress) | **POST** /v1/addresses/verify-suggest | Address Suggestion



## VerifyAddress

> Address VerifyAddress (Address address, bool? xPBUnifiedErrorStructure = null, bool? minimalAddressValidation = null)

Address validation

Address validation verifies and cleanses postal addresses within the United States to help ensure packages are rated accurately and shipments arrive at their final destinations on time.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using shippingapi.Api;
using shippingapi.Client;
using shippingapi.Model;

namespace Example
{
    public class VerifyAddressExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-sandbox.pitneybowes.com/shippingservices";
            // Configure OAuth2 access token for authorization: oAuth2ClientCredentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AddressValidationApi(Configuration.Default);
            var address = new Address(); // Address | Address object that needs to be validated.
            var xPBUnifiedErrorStructure = true;  // bool? | Set this to true to use the standard [error object](https://shipping.pitneybowes.com/reference/error-object.html#standard-error-object) if an error occurs. (optional)  (default to true)
            var minimalAddressValidation = true;  // bool? | When set to true, the complete address (delivery line and last line) is validated but only the last line (city, state, and postal code) would be changed by the validation check. (optional) 

            try
            {
                // Address validation
                Address result = apiInstance.VerifyAddress(address, xPBUnifiedErrorStructure, minimalAddressValidation);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AddressValidationApi.VerifyAddress: " + e.Message );
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
 **address** | [**Address**](Address.md)| Address object that needs to be validated. | 
 **xPBUnifiedErrorStructure** | **bool?**| Set this to true to use the standard [error object](https://shipping.pitneybowes.com/reference/error-object.html#standard-error-object) if an error occurs. | [optional] [default to true]
 **minimalAddressValidation** | **bool?**| When set to true, the complete address (delivery line and last line) is validated but only the last line (city, state, and postal code) would be changed by the validation check. | [optional] 

### Return type

[**Address**](Address.md)

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


## VerifyAndSuggestAddress

> AddressSuggestionResponse VerifyAndSuggestAddress (string returnSuggestions, AddressVerifySuggest addressVerifySuggest, bool? xPBUnifiedErrorStructure = null)

Address Suggestion

This operation returns suggested addresses. Use this if the [Address Validation API](https://shipping.pitneybowes.com/api/post-address-verify.html) call has returned an error.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using shippingapi.Api;
using shippingapi.Client;
using shippingapi.Model;

namespace Example
{
    public class VerifyAndSuggestAddressExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-sandbox.pitneybowes.com/shippingservices";
            // Configure OAuth2 access token for authorization: oAuth2ClientCredentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AddressValidationApi(Configuration.Default);
            var returnSuggestions = returnSuggestions_example;  // string | To return suggested addresses, set this to true. (default to "true")
            var addressVerifySuggest = new AddressVerifySuggest(); // AddressVerifySuggest | Address object that needs to be validated.
            var xPBUnifiedErrorStructure = true;  // bool? | Set this to true to use the standard [error object](https://shipping.pitneybowes.com/reference/error-object.html#standard-error-object) if an error occurs. (optional)  (default to true)

            try
            {
                // Address Suggestion
                AddressSuggestionResponse result = apiInstance.VerifyAndSuggestAddress(returnSuggestions, addressVerifySuggest, xPBUnifiedErrorStructure);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AddressValidationApi.VerifyAndSuggestAddress: " + e.Message );
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
 **returnSuggestions** | **string**| To return suggested addresses, set this to true. | [default to &quot;true&quot;]
 **addressVerifySuggest** | [**AddressVerifySuggest**](AddressVerifySuggest.md)| Address object that needs to be validated. | 
 **xPBUnifiedErrorStructure** | **bool?**| Set this to true to use the standard [error object](https://shipping.pitneybowes.com/reference/error-object.html#standard-error-object) if an error occurs. | [optional] [default to true]

### Return type

[**AddressSuggestionResponse**](AddressSuggestionResponse.md)

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

