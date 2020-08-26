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
    /// ParcelProtectionQuoteResponseParcelProtectionFeesBreakup
    /// </summary>
    [DataContract]
    public partial class ParcelProtectionQuoteResponseParcelProtectionFeesBreakup :  IEquatable<ParcelProtectionQuoteResponseParcelProtectionFeesBreakup>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ParcelProtectionQuoteResponseParcelProtectionFeesBreakup" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ParcelProtectionQuoteResponseParcelProtectionFeesBreakup() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ParcelProtectionQuoteResponseParcelProtectionFeesBreakup" /> class.
        /// </summary>
        /// <param name="basePremium">basePremium (required).</param>
        /// <param name="technologyFee">technologyFee (required).</param>
        public ParcelProtectionQuoteResponseParcelProtectionFeesBreakup(decimal basePremium = default(decimal), decimal technologyFee = default(decimal))
        {
            // to ensure "basePremium" is required (not null)
            if (basePremium == null)
            {
                throw new InvalidDataException("basePremium is a required property for ParcelProtectionQuoteResponseParcelProtectionFeesBreakup and cannot be null");
            }
            else
            {
                this.BasePremium = basePremium;
            }
            
            // to ensure "technologyFee" is required (not null)
            if (technologyFee == null)
            {
                throw new InvalidDataException("technologyFee is a required property for ParcelProtectionQuoteResponseParcelProtectionFeesBreakup and cannot be null");
            }
            else
            {
                this.TechnologyFee = technologyFee;
            }
            
        }
        
        /// <summary>
        /// Gets or Sets BasePremium
        /// </summary>
        [DataMember(Name="basePremium", EmitDefaultValue=true)]
        public decimal BasePremium { get; set; }

        /// <summary>
        /// Gets or Sets TechnologyFee
        /// </summary>
        [DataMember(Name="technologyFee", EmitDefaultValue=true)]
        public decimal TechnologyFee { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ParcelProtectionQuoteResponseParcelProtectionFeesBreakup {\n");
            sb.Append("  BasePremium: ").Append(BasePremium).Append("\n");
            sb.Append("  TechnologyFee: ").Append(TechnologyFee).Append("\n");
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
            return this.Equals(input as ParcelProtectionQuoteResponseParcelProtectionFeesBreakup);
        }

        /// <summary>
        /// Returns true if ParcelProtectionQuoteResponseParcelProtectionFeesBreakup instances are equal
        /// </summary>
        /// <param name="input">Instance of ParcelProtectionQuoteResponseParcelProtectionFeesBreakup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ParcelProtectionQuoteResponseParcelProtectionFeesBreakup input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BasePremium == input.BasePremium ||
                    (this.BasePremium != null &&
                    this.BasePremium.Equals(input.BasePremium))
                ) && 
                (
                    this.TechnologyFee == input.TechnologyFee ||
                    (this.TechnologyFee != null &&
                    this.TechnologyFee.Equals(input.TechnologyFee))
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
                if (this.BasePremium != null)
                    hashCode = hashCode * 59 + this.BasePremium.GetHashCode();
                if (this.TechnologyFee != null)
                    hashCode = hashCode * 59 + this.TechnologyFee.GetHashCode();
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