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
using Newtonsoft.Json.Serialization;

namespace shippingapi.Model
{
    /// <summary>
    /// ParcelTypeRules
    /// </summary>
    [DataContract]
    public partial class ParcelTypeRules :  IEquatable<ParcelTypeRules>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets ParcelType
        /// </summary>
        [DataMember(Name="parcelType", EmitDefaultValue=false)]
        public ParcelType? ParcelType { get; set; }
        /// <summary>
        /// Gets or Sets Trackable
        /// </summary>
        [DataMember(Name="trackable", EmitDefaultValue=false)]
        public Trackable? Trackable { get; set; }
        /// <summary>
        /// Gets or Sets SuggestedTrackableSpecialServiceId
        /// </summary>
        [DataMember(Name="suggestedTrackableSpecialServiceId", EmitDefaultValue=false)]
        public SpecialServiceCodes? SuggestedTrackableSpecialServiceId { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ParcelTypeRules" /> class.
        /// </summary>
        /// <param name="parcelType">parcelType.</param>
        /// <param name="brandedName">brandedName.</param>
        /// <param name="rateTypeId">rateTypeId.</param>
        /// <param name="rateTypeBrandedName">rateTypeBrandedName.</param>
        /// <param name="trackable">trackable.</param>
        /// <param name="specialServiceRules">specialServiceRules.</param>
        /// <param name="weightRules">weightRules.</param>
        /// <param name="dimensionRules">dimensionRules.</param>
        /// <param name="suggestedTrackableSpecialServiceId">suggestedTrackableSpecialServiceId.</param>
        public ParcelTypeRules(ParcelType? parcelType = default(ParcelType?), string brandedName = default(string), string rateTypeId = default(string), string rateTypeBrandedName = default(string), Trackable? trackable = default(Trackable?), List<SpecialServiceRule> specialServiceRules = default(List<SpecialServiceRule>), List<WeightRules> weightRules = default(List<WeightRules>), List<DimensionRules> dimensionRules = default(List<DimensionRules>), SpecialServiceCodes? suggestedTrackableSpecialServiceId = default(SpecialServiceCodes?))
        {
            this.ParcelType = parcelType;
            this.BrandedName = brandedName;
            this.RateTypeId = rateTypeId;
            this.RateTypeBrandedName = rateTypeBrandedName;
            this.Trackable = trackable;
            this.SpecialServiceRules = specialServiceRules;
            this.WeightRules = weightRules;
            this.DimensionRules = dimensionRules;
            this.SuggestedTrackableSpecialServiceId = suggestedTrackableSpecialServiceId;
        }
        

        /// <summary>
        /// Gets or Sets BrandedName
        /// </summary>
        [DataMember(Name="brandedName", EmitDefaultValue=false)]
        public string BrandedName { get; set; }

        /// <summary>
        /// Gets or Sets RateTypeId
        /// </summary>
        [DataMember(Name="rateTypeId", EmitDefaultValue=false)]
        public string RateTypeId { get; set; }

        /// <summary>
        /// Gets or Sets RateTypeBrandedName
        /// </summary>
        [DataMember(Name="rateTypeBrandedName", EmitDefaultValue=false)]
        public string RateTypeBrandedName { get; set; }


        /// <summary>
        /// Gets or Sets SpecialServiceRules
        /// </summary>
        [DataMember(Name="specialServiceRules", EmitDefaultValue=false)]
        public List<SpecialServiceRule> SpecialServiceRules { get; set; }

        /// <summary>
        /// Gets or Sets WeightRules
        /// </summary>
        [DataMember(Name="weightRules", EmitDefaultValue=false)]
        public List<WeightRules> WeightRules { get; set; }

        /// <summary>
        /// Gets or Sets DimensionRules
        /// </summary>
        [DataMember(Name="dimensionRules", EmitDefaultValue=false)]
        public List<DimensionRules> DimensionRules { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ParcelTypeRules {\n");
            sb.Append("  ParcelType: ").Append(ParcelType).Append("\n");
            sb.Append("  BrandedName: ").Append(BrandedName).Append("\n");
            sb.Append("  RateTypeId: ").Append(RateTypeId).Append("\n");
            sb.Append("  RateTypeBrandedName: ").Append(RateTypeBrandedName).Append("\n");
            sb.Append("  Trackable: ").Append(Trackable).Append("\n");
            sb.Append("  SpecialServiceRules: ").Append(SpecialServiceRules).Append("\n");
            sb.Append("  WeightRules: ").Append(WeightRules).Append("\n");
            sb.Append("  DimensionRules: ").Append(DimensionRules).Append("\n");
            sb.Append("  SuggestedTrackableSpecialServiceId: ").Append(SuggestedTrackableSpecialServiceId).Append("\n");
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
            return this.Equals(input as ParcelTypeRules);
        }

        /// <summary>
        /// Returns true if ParcelTypeRules instances are equal
        /// </summary>
        /// <param name="input">Instance of ParcelTypeRules to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ParcelTypeRules input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ParcelType == input.ParcelType ||
                    (this.ParcelType != null &&
                    this.ParcelType.Equals(input.ParcelType))
                ) && 
                (
                    this.BrandedName == input.BrandedName ||
                    (this.BrandedName != null &&
                    this.BrandedName.Equals(input.BrandedName))
                ) && 
                (
                    this.RateTypeId == input.RateTypeId ||
                    (this.RateTypeId != null &&
                    this.RateTypeId.Equals(input.RateTypeId))
                ) && 
                (
                    this.RateTypeBrandedName == input.RateTypeBrandedName ||
                    (this.RateTypeBrandedName != null &&
                    this.RateTypeBrandedName.Equals(input.RateTypeBrandedName))
                ) && 
                (
                    this.Trackable == input.Trackable ||
                    (this.Trackable != null &&
                    this.Trackable.Equals(input.Trackable))
                ) && 
                (
                    this.SpecialServiceRules == input.SpecialServiceRules ||
                    this.SpecialServiceRules != null &&
                    input.SpecialServiceRules != null &&
                    this.SpecialServiceRules.SequenceEqual(input.SpecialServiceRules)
                ) && 
                (
                    this.WeightRules == input.WeightRules ||
                    this.WeightRules != null &&
                    input.WeightRules != null &&
                    this.WeightRules.SequenceEqual(input.WeightRules)
                ) && 
                (
                    this.DimensionRules == input.DimensionRules ||
                    this.DimensionRules != null &&
                    input.DimensionRules != null &&
                    this.DimensionRules.SequenceEqual(input.DimensionRules)
                ) && 
                (
                    this.SuggestedTrackableSpecialServiceId == input.SuggestedTrackableSpecialServiceId ||
                    (this.SuggestedTrackableSpecialServiceId != null &&
                    this.SuggestedTrackableSpecialServiceId.Equals(input.SuggestedTrackableSpecialServiceId))
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
                if (this.ParcelType != null)
                    hashCode = hashCode * 59 + this.ParcelType.GetHashCode();
                if (this.BrandedName != null)
                    hashCode = hashCode * 59 + this.BrandedName.GetHashCode();
                if (this.RateTypeId != null)
                    hashCode = hashCode * 59 + this.RateTypeId.GetHashCode();
                if (this.RateTypeBrandedName != null)
                    hashCode = hashCode * 59 + this.RateTypeBrandedName.GetHashCode();
                if (this.Trackable != null)
                    hashCode = hashCode * 59 + this.Trackable.GetHashCode();
                if (this.SpecialServiceRules != null)
                    hashCode = hashCode * 59 + this.SpecialServiceRules.GetHashCode();
                if (this.WeightRules != null)
                    hashCode = hashCode * 59 + this.WeightRules.GetHashCode();
                if (this.DimensionRules != null)
                    hashCode = hashCode * 59 + this.DimensionRules.GetHashCode();
                if (this.SuggestedTrackableSpecialServiceId != null)
                    hashCode = hashCode * 59 + this.SuggestedTrackableSpecialServiceId.GetHashCode();
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

        [OnError]
        internal void OnError(StreamingContext context, ErrorContext errorContext)
        {
            // unknown parcel types (LGENV-IMB) are causing deserialization failure
            // TODO: just skip errors for now...
            errorContext.Handled = true;
        }
    }

}
