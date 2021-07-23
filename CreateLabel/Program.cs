using System;
using System.Collections.Generic;
using System.Diagnostics;
using shippingapi.Api;
using shippingapi.Client;
using shippingapi.Model;

namespace CreateLabel
{
    class Program
    {
        static void Main(string[] args)
        {
            Configuration.Default.BasePath = "https://shipping-api-sandbox.pitneybowes.com/shippingservices";

            Configuration.Default.OAuthApiKey = "<API_KEY_REPLACE>";
            Configuration.Default.OAuthSecret = "<API_SECRET_REPLACE>";
           


            DateTime dt = DateTime.Now;

            var apiInstance = new ShipmentApi(Configuration.Default);
            var xPBTransactionId = dt.Millisecond.ToString();  // string | Required. A unique identifier for the transaction, up to 25 characters.
            var xPBUnifiedErrorStructure = true;  // bool? | Set this to true to use the standard [error object](https://shipping.pitneybowes.com/reference/error-object.html#standard-error-object) if an error occurs. (optional)  (default to true)
            var xPBIntegratorCarrierId = "898644";  // string | USPS Only. Negotiated services rate, if applicable. (optional) 
            //var xPBShipperRatePlan = xPBShipperRatePlan_example;  // string | USPS Only. Shipper rate plan, if applicable. For more information, see [this FAQ](https://shipping.pitneybowes.com/faqs/rates.html#rate-plans-faq). (optional) 
            //var xPBShipmentGroupId = xPBShipmentGroupId_example;  // string |  **[Required parameter for PBPresort service](https://shipping.pitneybowes.com/api/post-shipments-presort.html)**.The job number that represents the agreement between the merchant and PB Presort. This was provided by Pitney Bowes during [merchant onboarding for PB Presort](https://shipping.pitneybowes.com/carriers/pb-presort.html). (optional) 
            //var xPBShipperCarrierAccountId = xPBShipperCarrierAccountId_example;  // string | **[Required parameter for PBPresort service](https://shipping.pitneybowes.com/api/post-shipments-presort.html)**. The merchant's Mailer ID (MID), as provided by Pitney Bowes during merchant onboarding for PB Presort. (optional) 
            //var includeDeliveryCommitment = includeDeliveryCommitment_example;  // string | If set to true, returns estimated transit times in days. Only for USPS Create Shipment. See also [Pitney Bowes Delivery Guarantee](https://shipping.pitneybowes.com/faqs/delivery-guarantee.html) [Do all USPS services return transit times?](https://shipping.pitneybowes.com/faqs/shipments.html#transit-times-faq) (optional) 

            try
            {



                var name1 = "Paul Wright";
                var phone1="203-555-1430";
                var email1 = "john.publica@pb.com";
                var residential1 = false;
                List<string> addressLines1 = new List<string>(){ "27 Waterview Dr" };
                var cityTown1 = "Shelton";
                var stateProvince1 = "CT";
                var postalCode1 = "06484-4361";
                var countryCode1 = "US";
                var carrierRoute1= "C010";
                var deliveryPoint1 = "27";
                var company1 = "Pitney Bowes Inc.";



                Address fromAddress = new Address(name:name1,phone:phone1,residential:residential1,addressLines:addressLines1,cityTown:cityTown1,stateProvince:stateProvince1,postalCode:postalCode1,
                    countryCode:countryCode1,carrierRoute:carrierRoute1,deliveryPoint:deliveryPoint1,company:company1,email:email1);


                var name2 = "Rufous Sirius Canid";
                var phone2 = "323 555-1212";
                var email2 = "rs.canid@gmail.com";
                var residential2 = true;
                List<string> addressLines2 = new List<string>() { "631 S Main St" };
                var cityTown2 = "Greenville";
                var stateProvince2 = "SC";
                var postalCode2 = "29601";
                var countryCode2 = "US";
              
                var company2 = "ABC Company";

                Address toAddress = new Address(name: name2, phone: phone2, residential: residential2, addressLines: addressLines2, cityTown: cityTown2, stateProvince: stateProvince2, postalCode: postalCode2,
                    countryCode: countryCode2,company: company2,email:email2);

                
                
                
                //Parcel 
                ParcelDimension parcelDimension = new ParcelDimension();
                parcelDimension.Height = 6.000m;
                parcelDimension.Length = 6.000m;
                parcelDimension.Width = 6.000m;
                parcelDimension.UnitOfMeasurement = UnitOfDimension.IN;

                ParcelWeight parcelWeight = new ParcelWeight(38.00m,UnitOfWeight.OZ);

                Parcel parcel = new Parcel(parcelDimension, parcelWeight);



                //Rates
                //Specil Service
                SpecialService specialService = new SpecialService(specialServiceId: "DelCon", inputParameters: new List<Parameter> { new Parameter("INPUT_VALUE","0") });
                Rate rate = new Rate(carrier: Carrier.USPS, serviceId: Services.PM, parcelType: ParcelType.PKG, specialServices: new List<SpecialService>() { specialService }, inductionPostalCode: "06484");



                //Documents
                Document document = new Document(type: "SHIPPING_LABEL",contentType: Document.ContentTypeEnum.URL,size:Document.SizeEnum._4X6,fileFormat:Document.FileFormatEnum.PDF,printDialogOption:Document.PrintDialogOptionEnum.NOPRINTDIALOG);

                //ShipemntOptions
                List<Parameter> shipmentoption = new List<Parameter> { new Parameter("SHIPPER_ID", "9025037569"), new Parameter("ADD_TO_MANIFEST", "true"), new Parameter("HIDE_TOTAL_CARRIER_CHARGE", "true"), new Parameter("PRINT_CUSTOM_MESSAGE_1", "custom message for label"), new Parameter("SHIPPING_LABEL_RECEIPT", "NO_OPTIONS") };

                
                var shipment = new Shipment(fromAddress: fromAddress, toAddress: toAddress,parcel: parcel, rates: new List<Rate>() { rate },documents: new List<Document>(){ document },shipmentOptions:shipmentoption); // Shipment | request



                // This operation creates a shipment and purchases a shipment label.
                Shipment result = apiInstance.CreateShipmentLabel(xPBTransactionId, shipment, xPBUnifiedErrorStructure, xPBIntegratorCarrierId);

                // Console.WriteLine((new System.Collections.Generic.ICollectionDebugView<shippingapi.Model.Document>(result.Documents).Items[0]).Contents);
                Console.WriteLine(result.Documents[0].Contents);

            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ShipmentApi.CreateShipmentLabel: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
