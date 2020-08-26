/* 
 * Shipping API
 *
 * Shipping API Sample.
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: support@pb.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = shippingapi.Client.OpenAPIDateConverter;

namespace shippingapi.Model
{
    /// <summary>
    /// CarrierPayment
    /// </summary>
    [DataContract]
    public partial class CarrierPayment :  IEquatable<CarrierPayment>, IValidatableObject
    {
        /// <summary>
        /// Defines Party
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PartyEnum
        {
            /// <summary>
            /// Enum RECEIVER for value: BILL_RECEIVER
            /// </summary>
            [EnumMember(Value = "BILL_RECEIVER")]
            RECEIVER = 1,

            /// <summary>
            /// Enum SENDER for value: BILL_SENDER
            /// </summary>
            [EnumMember(Value = "BILL_SENDER")]
            SENDER = 2,

            /// <summary>
            /// Enum THIRDPARTY for value: BILL_THIRD_PARTY
            /// </summary>
            [EnumMember(Value = "BILL_THIRD_PARTY")]
            THIRDPARTY = 3,

            /// <summary>
            /// Enum RECEIVERCONTRACT for value: BILL_RECEIVER_CONTRACT
            /// </summary>
            [EnumMember(Value = "BILL_RECEIVER_CONTRACT")]
            RECEIVERCONTRACT = 4

        }

        /// <summary>
        /// Gets or Sets Party
        /// </summary>
        [DataMember(Name="party", EmitDefaultValue=true)]
        public PartyEnum Party { get; set; }
        /// <summary>
        /// Defines TypeOfCharge
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeOfChargeEnum
        {
            /// <summary>
            /// Enum TRANSPORTATIONCHARGES for value: TRANSPORTATION_CHARGES
            /// </summary>
            [EnumMember(Value = "TRANSPORTATION_CHARGES")]
            TRANSPORTATIONCHARGES = 1,

            /// <summary>
            /// Enum DUTIESANDTAXES for value: DUTIES_AND_TAXES
            /// </summary>
            [EnumMember(Value = "DUTIES_AND_TAXES")]
            DUTIESANDTAXES = 2,

            /// <summary>
            /// Enum ALLCHARGES for value: ALL_CHARGES
            /// </summary>
            [EnumMember(Value = "ALL_CHARGES")]
            ALLCHARGES = 3

        }

        /// <summary>
        /// Gets or Sets TypeOfCharge
        /// </summary>
        [DataMember(Name="typeOfCharge", EmitDefaultValue=true)]
        public TypeOfChargeEnum TypeOfCharge { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CarrierPayment" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CarrierPayment() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CarrierPayment" /> class.
        /// </summary>
        /// <param name="accountNumber">accountNumber.</param>
        /// <param name="countryCode">countryCode.</param>
        /// <param name="party">party (required).</param>
        /// <param name="postalCode">postalCode.</param>
        /// <param name="typeOfCharge">typeOfCharge (required).</param>
        public CarrierPayment(string accountNumber = default(string), string countryCode = default(string), PartyEnum party = default(PartyEnum), string postalCode = default(string), TypeOfChargeEnum typeOfCharge = default(TypeOfChargeEnum))
        {
            // to ensure "party" is required (not null)
            if (party == null)
            {
                throw new InvalidDataException("party is a required property for CarrierPayment and cannot be null");
            }
            else
            {
                this.Party = party;
            }
            
            // to ensure "typeOfCharge" is required (not null)
            if (typeOfCharge == null)
            {
                throw new InvalidDataException("typeOfCharge is a required property for CarrierPayment and cannot be null");
            }
            else
            {
                this.TypeOfCharge = typeOfCharge;
            }
            
            this.AccountNumber = accountNumber;
            this.CountryCode = countryCode;
            this.PostalCode = postalCode;
        }
        
        /// <summary>
        /// Gets or Sets AccountNumber
        /// </summary>
        [DataMember(Name="accountNumber", EmitDefaultValue=false)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Gets or Sets CountryCode
        /// </summary>
        [DataMember(Name="countryCode", EmitDefaultValue=false)]
        public string CountryCode { get; set; }


        /// <summary>
        /// Gets or Sets PostalCode
        /// </summary>
        [DataMember(Name="postalCode", EmitDefaultValue=false)]
        public string PostalCode { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CarrierPayment {\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  Party: ").Append(Party).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  TypeOfCharge: ").Append(TypeOfCharge).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as CarrierPayment);
        }

        /// <summary>
        /// Returns true if CarrierPayment instances are equal
        /// </summary>
        /// <param name="input">Instance of CarrierPayment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CarrierPayment input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccountNumber == input.AccountNumber ||
                    (this.AccountNumber != null &&
                    this.AccountNumber.Equals(input.AccountNumber))
                ) && 
                (
                    this.CountryCode == input.CountryCode ||
                    (this.CountryCode != null &&
                    this.CountryCode.Equals(input.CountryCode))
                ) && 
                (
                    this.Party == input.Party ||
                    (this.Party != null &&
                    this.Party.Equals(input.Party))
                ) && 
                (
                    this.PostalCode == input.PostalCode ||
                    (this.PostalCode != null &&
                    this.PostalCode.Equals(input.PostalCode))
                ) && 
                (
                    this.TypeOfCharge == input.TypeOfCharge ||
                    (this.TypeOfCharge != null &&
                    this.TypeOfCharge.Equals(input.TypeOfCharge))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.AccountNumber != null)
                    hashCode = hashCode * 59 + this.AccountNumber.GetHashCode();
                if (this.CountryCode != null)
                    hashCode = hashCode * 59 + this.CountryCode.GetHashCode();
                if (this.Party != null)
                    hashCode = hashCode * 59 + this.Party.GetHashCode();
                if (this.PostalCode != null)
                    hashCode = hashCode * 59 + this.PostalCode.GetHashCode();
                if (this.TypeOfCharge != null)
                    hashCode = hashCode * 59 + this.TypeOfCharge.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}