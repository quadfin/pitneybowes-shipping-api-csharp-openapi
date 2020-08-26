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
    /// Document
    /// </summary>
    [DataContract]
    public partial class Document :  IEquatable<Document>, IValidatableObject
    {
        /// <summary>
        /// Defines ContentType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ContentTypeEnum
        {
            /// <summary>
            /// Enum URL for value: URL
            /// </summary>
            [EnumMember(Value = "URL")]
            URL = 1,

            /// <summary>
            /// Enum BASE64 for value: BASE64
            /// </summary>
            [EnumMember(Value = "BASE64")]
            BASE64 = 2

        }

        /// <summary>
        /// Gets or Sets ContentType
        /// </summary>
        [DataMember(Name="contentType", EmitDefaultValue=false)]
        public ContentTypeEnum? ContentType { get; set; }
        /// <summary>
        /// Defines FileFormat
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FileFormatEnum
        {
            /// <summary>
            /// Enum PDF for value: PDF
            /// </summary>
            [EnumMember(Value = "PDF")]
            PDF = 1,

            /// <summary>
            /// Enum PNG for value: PNG
            /// </summary>
            [EnumMember(Value = "PNG")]
            PNG = 2,

            /// <summary>
            /// Enum GIF for value: GIF
            /// </summary>
            [EnumMember(Value = "GIF")]
            GIF = 3,

            /// <summary>
            /// Enum ZPL for value: ZPL
            /// </summary>
            [EnumMember(Value = "ZPL")]
            ZPL = 4,

            /// <summary>
            /// Enum ZPL2 for value: ZPL2
            /// </summary>
            [EnumMember(Value = "ZPL2")]
            ZPL2 = 5

        }

        /// <summary>
        /// Gets or Sets FileFormat
        /// </summary>
        [DataMember(Name="fileFormat", EmitDefaultValue=false)]
        public FileFormatEnum? FileFormat { get; set; }
        /// <summary>
        /// Defines PrintDialogOption
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PrintDialogOptionEnum
        {
            /// <summary>
            /// Enum NOPRINTDIALOG for value: NO_PRINT_DIALOG
            /// </summary>
            [EnumMember(Value = "NO_PRINT_DIALOG")]
            NOPRINTDIALOG = 1,

            /// <summary>
            /// Enum EMBEDPRINTDIALOG for value: EMBED_PRINT_DIALOG
            /// </summary>
            [EnumMember(Value = "EMBED_PRINT_DIALOG")]
            EMBEDPRINTDIALOG = 2

        }

        /// <summary>
        /// Gets or Sets PrintDialogOption
        /// </summary>
        [DataMember(Name="printDialogOption", EmitDefaultValue=false)]
        public PrintDialogOptionEnum? PrintDialogOption { get; set; }
        /// <summary>
        /// Defines Resolution
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ResolutionEnum
        {
            /// <summary>
            /// Enum _300 for value: DPI_300
            /// </summary>
            [EnumMember(Value = "DPI_300")]
            _300 = 1,

            /// <summary>
            /// Enum _203 for value: DPI_203
            /// </summary>
            [EnumMember(Value = "DPI_203")]
            _203 = 2,

            /// <summary>
            /// Enum _150 for value: DPI_150
            /// </summary>
            [EnumMember(Value = "DPI_150")]
            _150 = 3

        }

        /// <summary>
        /// Gets or Sets Resolution
        /// </summary>
        [DataMember(Name="resolution", EmitDefaultValue=false)]
        public ResolutionEnum? Resolution { get; set; }
        /// <summary>
        /// Defines Size
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SizeEnum
        {
            /// <summary>
            /// Enum _2X7 for value: DOC_2X7
            /// </summary>
            [EnumMember(Value = "DOC_2X7")]
            _2X7 = 1,

            /// <summary>
            /// Enum _4X1 for value: DOC_4X1
            /// </summary>
            [EnumMember(Value = "DOC_4X1")]
            _4X1 = 2,

            /// <summary>
            /// Enum _4X3 for value: DOC_4X3
            /// </summary>
            [EnumMember(Value = "DOC_4X3")]
            _4X3 = 3,

            /// <summary>
            /// Enum _4X6 for value: DOC_4X6
            /// </summary>
            [EnumMember(Value = "DOC_4X6")]
            _4X6 = 4,

            /// <summary>
            /// Enum _4X8 for value: DOC_4X8
            /// </summary>
            [EnumMember(Value = "DOC_4X8")]
            _4X8 = 5,

            /// <summary>
            /// Enum _6X4 for value: DOC_6X4
            /// </summary>
            [EnumMember(Value = "DOC_6X4")]
            _6X4 = 6,

            /// <summary>
            /// Enum _8X11 for value: DOC_8X11
            /// </summary>
            [EnumMember(Value = "DOC_8X11")]
            _8X11 = 7,

            /// <summary>
            /// Enum _9X4 for value: DOC_9X4
            /// </summary>
            [EnumMember(Value = "DOC_9X4")]
            _9X4 = 8,

            /// <summary>
            /// Enum _4X5 for value: DOC_4X5
            /// </summary>
            [EnumMember(Value = "DOC_4X5")]
            _4X5 = 9,

            /// <summary>
            /// Enum _85X55 for value: DOC_8_5X5_5
            /// </summary>
            [EnumMember(Value = "DOC_8_5X5_5")]
            _85X55 = 10

        }

        /// <summary>
        /// Gets or Sets Size
        /// </summary>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public SizeEnum? Size { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Document" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Document() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Document" /> class.
        /// </summary>
        /// <param name="contentType">contentType.</param>
        /// <param name="contents">contents.</param>
        /// <param name="docTab">docTab.</param>
        /// <param name="fileFormat">fileFormat.</param>
        /// <param name="pages">pages.</param>
        /// <param name="printDialogOption">printDialogOption.</param>
        /// <param name="resolution">resolution.</param>
        /// <param name="size">size.</param>
        /// <param name="type">type (required).</param>
        public Document(ContentTypeEnum? contentType = default(ContentTypeEnum?), string contents = default(string), List<DocTabItem> docTab = default(List<DocTabItem>), FileFormatEnum? fileFormat = default(FileFormatEnum?), List<DocumentPage> pages = default(List<DocumentPage>), PrintDialogOptionEnum? printDialogOption = default(PrintDialogOptionEnum?), ResolutionEnum? resolution = default(ResolutionEnum?), SizeEnum? size = default(SizeEnum?), string type = default(string))
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for Document and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            
            this.ContentType = contentType;
            this.Contents = contents;
            this.DocTab = docTab;
            this.FileFormat = fileFormat;
            this.Pages = pages;
            this.PrintDialogOption = printDialogOption;
            this.Resolution = resolution;
            this.Size = size;
        }
        

        /// <summary>
        /// Gets or Sets Contents
        /// </summary>
        [DataMember(Name="contents", EmitDefaultValue=false)]
        public string Contents { get; set; }

        /// <summary>
        /// Gets or Sets DocTab
        /// </summary>
        [DataMember(Name="docTab", EmitDefaultValue=false)]
        public List<DocTabItem> DocTab { get; set; }


        /// <summary>
        /// Gets or Sets Pages
        /// </summary>
        [DataMember(Name="pages", EmitDefaultValue=false)]
        public List<DocumentPage> Pages { get; set; }




        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Document {\n");
            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
            sb.Append("  Contents: ").Append(Contents).Append("\n");
            sb.Append("  DocTab: ").Append(DocTab).Append("\n");
            sb.Append("  FileFormat: ").Append(FileFormat).Append("\n");
            sb.Append("  Pages: ").Append(Pages).Append("\n");
            sb.Append("  PrintDialogOption: ").Append(PrintDialogOption).Append("\n");
            sb.Append("  Resolution: ").Append(Resolution).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as Document);
        }

        /// <summary>
        /// Returns true if Document instances are equal
        /// </summary>
        /// <param name="input">Instance of Document to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Document input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ContentType == input.ContentType ||
                    (this.ContentType != null &&
                    this.ContentType.Equals(input.ContentType))
                ) && 
                (
                    this.Contents == input.Contents ||
                    (this.Contents != null &&
                    this.Contents.Equals(input.Contents))
                ) && 
                (
                    this.DocTab == input.DocTab ||
                    this.DocTab != null &&
                    input.DocTab != null &&
                    this.DocTab.SequenceEqual(input.DocTab)
                ) && 
                (
                    this.FileFormat == input.FileFormat ||
                    (this.FileFormat != null &&
                    this.FileFormat.Equals(input.FileFormat))
                ) && 
                (
                    this.Pages == input.Pages ||
                    this.Pages != null &&
                    input.Pages != null &&
                    this.Pages.SequenceEqual(input.Pages)
                ) && 
                (
                    this.PrintDialogOption == input.PrintDialogOption ||
                    (this.PrintDialogOption != null &&
                    this.PrintDialogOption.Equals(input.PrintDialogOption))
                ) && 
                (
                    this.Resolution == input.Resolution ||
                    (this.Resolution != null &&
                    this.Resolution.Equals(input.Resolution))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.ContentType != null)
                    hashCode = hashCode * 59 + this.ContentType.GetHashCode();
                if (this.Contents != null)
                    hashCode = hashCode * 59 + this.Contents.GetHashCode();
                if (this.DocTab != null)
                    hashCode = hashCode * 59 + this.DocTab.GetHashCode();
                if (this.FileFormat != null)
                    hashCode = hashCode * 59 + this.FileFormat.GetHashCode();
                if (this.Pages != null)
                    hashCode = hashCode * 59 + this.Pages.GetHashCode();
                if (this.PrintDialogOption != null)
                    hashCode = hashCode * 59 + this.PrintDialogOption.GetHashCode();
                if (this.Resolution != null)
                    hashCode = hashCode * 59 + this.Resolution.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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