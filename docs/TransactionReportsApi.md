# shippingapi.Api.TransactionReportsApi

All URIs are relative to *https://api-sandbox.pitneybowes.com/shippingservices*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetTransactionReport**](TransactionReportsApi.md#gettransactionreport) | **GET** /v4/ledger/developers/{developerId}/transactions/reports | This operation retrieves all transactions for a specified period of time.



## GetTransactionReport

> PageRealTransactionDetailReport GetTransactionReport (string developerId, bool? xPBUnifiedErrorStructure = null, DateTime? fromDate = null, int? shipDetails = null, int? page = null, int? size = null, string printStatus = null, DateTime? toDate = null, string transactionType = null, string merchantId = null, string sort = null, string parcelTrackingNumber = null, string transactionId = null)

This operation retrieves all transactions for a specified period of time.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using shippingapi.Api;
using shippingapi.Client;
using shippingapi.Model;

namespace Example
{
    public class GetTransactionReportExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-sandbox.pitneybowes.com/shippingservices";
            // Configure OAuth2 access token for authorization: oAuth2ClientCredentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionReportsApi(Configuration.Default);
            var developerId = developerId_example;  // string | developerId
            var xPBUnifiedErrorStructure = true;  // bool? | Set this to true to use the standard [error object](https://shipping.pitneybowes.com/reference/error-object.html#standard-error-object) if an error occurs. (optional)  (default to true)
            var fromDate = 2013-10-20T19:20:30+01:00;  // DateTime? | fromDate (optional) 
            var shipDetails = 56;  // int? |  (optional)  (default to 0)
            var page = 56;  // int? |  (optional) 
            var size = 56;  // int? |  (optional)  (default to 20)
            var printStatus = printStatus_example;  // string | printStatus (optional) 
            var toDate = 2013-10-20T19:20:30+01:00;  // DateTime? | toDate (optional) 
            var transactionType = transactionType_example;  // string | transactionType (optional) 
            var merchantId = merchantId_example;  // string | The value of the postalReportingNumber element in the [merchant object](https://shipping.pitneybowes.com/reference/resource-objects.html). This value is also the merchant's Shipper ID. (optional) 
            var sort = sort_example;  // string | Defines a property to sort on and the sort order. Sort order can be ascending (asc) or descending (desc). Use the following form-  * **sort=<property_name>,<sort_direction>** For example- **sort=transactionId,desc**  (optional) 
            var parcelTrackingNumber = parcelTrackingNumber_example;  // string | Parcel tracking number of the shipment. (optional) 
            var transactionId = transactionId_example;  // string | The unique string that identifies all the transactions associated with a given shipment. The string comprises the developer ID and the shipment's X-PB-TransactionId, separated by an underscore (_). For example-  * **transactionId=44397664_ad5aa07-ad7414-a78a-c22b3** (optional) 

            try
            {
                // This operation retrieves all transactions for a specified period of time.
                PageRealTransactionDetailReport result = apiInstance.GetTransactionReport(developerId, xPBUnifiedErrorStructure, fromDate, shipDetails, page, size, printStatus, toDate, transactionType, merchantId, sort, parcelTrackingNumber, transactionId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TransactionReportsApi.GetTransactionReport: " + e.Message );
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
 **developerId** | **string**| developerId | 
 **xPBUnifiedErrorStructure** | **bool?**| Set this to true to use the standard [error object](https://shipping.pitneybowes.com/reference/error-object.html#standard-error-object) if an error occurs. | [optional] [default to true]
 **fromDate** | **DateTime?**| fromDate | [optional] 
 **shipDetails** | **int?**|  | [optional] [default to 0]
 **page** | **int?**|  | [optional] 
 **size** | **int?**|  | [optional] [default to 20]
 **printStatus** | **string**| printStatus | [optional] 
 **toDate** | **DateTime?**| toDate | [optional] 
 **transactionType** | **string**| transactionType | [optional] 
 **merchantId** | **string**| The value of the postalReportingNumber element in the [merchant object](https://shipping.pitneybowes.com/reference/resource-objects.html). This value is also the merchant&#39;s Shipper ID. | [optional] 
 **sort** | **string**| Defines a property to sort on and the sort order. Sort order can be ascending (asc) or descending (desc). Use the following form-  * **sort&#x3D;&lt;property_name&gt;,&lt;sort_direction&gt;** For example- **sort&#x3D;transactionId,desc**  | [optional] 
 **parcelTrackingNumber** | **string**| Parcel tracking number of the shipment. | [optional] 
 **transactionId** | **string**| The unique string that identifies all the transactions associated with a given shipment. The string comprises the developer ID and the shipment&#39;s X-PB-TransactionId, separated by an underscore (_). For example-  * **transactionId&#x3D;44397664_ad5aa07-ad7414-a78a-c22b3** | [optional] 

### Return type

[**PageRealTransactionDetailReport**](PageRealTransactionDetailReport.md)

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

