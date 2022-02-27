/*
 * NextGen Connect Client API
 *
 * Swagger documentation for the NextGen Connect Client API.
 *
 * The version of the OpenAPI document: 3.11.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = OpenapiGenerator.MirthConnect311.Client.OpenAPIDateConverter;

namespace OpenapiGenerator.MirthConnect311.Model
{
    /// <summary>
    /// Transformer
    /// </summary>
    [DataContract(Name = "Transformer")]
    public partial class Transformer : IEquatable<Transformer>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Transformer" /> class.
        /// </summary>
        /// <param name="elements">elements.</param>
        /// <param name="inboundTemplate">inboundTemplate.</param>
        /// <param name="outboundTemplate">outboundTemplate.</param>
        /// <param name="inboundDataType">inboundDataType.</param>
        /// <param name="outboundDataType">outboundDataType.</param>
        /// <param name="inboundProperties">inboundProperties.</param>
        /// <param name="outboundProperties">outboundProperties.</param>
        /// <param name="purgedProperties">purgedProperties.</param>
        /// <param name="enabledElements">enabledElements.</param>
        public Transformer(List<Step> elements = default(List<Step>), string inboundTemplate = default(string), string outboundTemplate = default(string), string inboundDataType = default(string), string outboundDataType = default(string), DataTypeProperties inboundProperties = default(DataTypeProperties), DataTypeProperties outboundProperties = default(DataTypeProperties), Dictionary<string, Object> purgedProperties = default(Dictionary<string, Object>), List<Step> enabledElements = default(List<Step>))
        {
            this.Elements = elements;
            this.InboundTemplate = inboundTemplate;
            this.OutboundTemplate = outboundTemplate;
            this.InboundDataType = inboundDataType;
            this.OutboundDataType = outboundDataType;
            this.InboundProperties = inboundProperties;
            this.OutboundProperties = outboundProperties;
            this.PurgedProperties = purgedProperties;
            this.EnabledElements = enabledElements;
        }

        /// <summary>
        /// Gets or Sets Elements
        /// </summary>
        [DataMember(Name = "elements", EmitDefaultValue = false)]
        public List<Step> Elements { get; set; }

        /// <summary>
        /// Gets or Sets InboundTemplate
        /// </summary>
        [DataMember(Name = "inboundTemplate", EmitDefaultValue = false)]
        public string InboundTemplate { get; set; }

        /// <summary>
        /// Gets or Sets OutboundTemplate
        /// </summary>
        [DataMember(Name = "outboundTemplate", EmitDefaultValue = false)]
        public string OutboundTemplate { get; set; }

        /// <summary>
        /// Gets or Sets InboundDataType
        /// </summary>
        [DataMember(Name = "inboundDataType", EmitDefaultValue = false)]
        public string InboundDataType { get; set; }

        /// <summary>
        /// Gets or Sets OutboundDataType
        /// </summary>
        [DataMember(Name = "outboundDataType", EmitDefaultValue = false)]
        public string OutboundDataType { get; set; }

        /// <summary>
        /// Gets or Sets InboundProperties
        /// </summary>
        [DataMember(Name = "inboundProperties", EmitDefaultValue = false)]
        public DataTypeProperties InboundProperties { get; set; }

        /// <summary>
        /// Gets or Sets OutboundProperties
        /// </summary>
        [DataMember(Name = "outboundProperties", EmitDefaultValue = false)]
        public DataTypeProperties OutboundProperties { get; set; }

        /// <summary>
        /// Gets or Sets PurgedProperties
        /// </summary>
        [DataMember(Name = "purgedProperties", EmitDefaultValue = false)]
        public Dictionary<string, Object> PurgedProperties { get; set; }

        /// <summary>
        /// Gets or Sets EnabledElements
        /// </summary>
        [DataMember(Name = "enabledElements", EmitDefaultValue = false)]
        public List<Step> EnabledElements { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Transformer {\n");
            sb.Append("  Elements: ").Append(Elements).Append("\n");
            sb.Append("  InboundTemplate: ").Append(InboundTemplate).Append("\n");
            sb.Append("  OutboundTemplate: ").Append(OutboundTemplate).Append("\n");
            sb.Append("  InboundDataType: ").Append(InboundDataType).Append("\n");
            sb.Append("  OutboundDataType: ").Append(OutboundDataType).Append("\n");
            sb.Append("  InboundProperties: ").Append(InboundProperties).Append("\n");
            sb.Append("  OutboundProperties: ").Append(OutboundProperties).Append("\n");
            sb.Append("  PurgedProperties: ").Append(PurgedProperties).Append("\n");
            sb.Append("  EnabledElements: ").Append(EnabledElements).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Transformer);
        }

        /// <summary>
        /// Returns true if Transformer instances are equal
        /// </summary>
        /// <param name="input">Instance of Transformer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Transformer input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Elements == input.Elements ||
                    this.Elements != null &&
                    input.Elements != null &&
                    this.Elements.SequenceEqual(input.Elements)
                ) && 
                (
                    this.InboundTemplate == input.InboundTemplate ||
                    (this.InboundTemplate != null &&
                    this.InboundTemplate.Equals(input.InboundTemplate))
                ) && 
                (
                    this.OutboundTemplate == input.OutboundTemplate ||
                    (this.OutboundTemplate != null &&
                    this.OutboundTemplate.Equals(input.OutboundTemplate))
                ) && 
                (
                    this.InboundDataType == input.InboundDataType ||
                    (this.InboundDataType != null &&
                    this.InboundDataType.Equals(input.InboundDataType))
                ) && 
                (
                    this.OutboundDataType == input.OutboundDataType ||
                    (this.OutboundDataType != null &&
                    this.OutboundDataType.Equals(input.OutboundDataType))
                ) && 
                (
                    this.InboundProperties == input.InboundProperties ||
                    (this.InboundProperties != null &&
                    this.InboundProperties.Equals(input.InboundProperties))
                ) && 
                (
                    this.OutboundProperties == input.OutboundProperties ||
                    (this.OutboundProperties != null &&
                    this.OutboundProperties.Equals(input.OutboundProperties))
                ) && 
                (
                    this.PurgedProperties == input.PurgedProperties ||
                    this.PurgedProperties != null &&
                    input.PurgedProperties != null &&
                    this.PurgedProperties.SequenceEqual(input.PurgedProperties)
                ) && 
                (
                    this.EnabledElements == input.EnabledElements ||
                    this.EnabledElements != null &&
                    input.EnabledElements != null &&
                    this.EnabledElements.SequenceEqual(input.EnabledElements)
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
                if (this.Elements != null)
                {
                    hashCode = (hashCode * 59) + this.Elements.GetHashCode();
                }
                if (this.InboundTemplate != null)
                {
                    hashCode = (hashCode * 59) + this.InboundTemplate.GetHashCode();
                }
                if (this.OutboundTemplate != null)
                {
                    hashCode = (hashCode * 59) + this.OutboundTemplate.GetHashCode();
                }
                if (this.InboundDataType != null)
                {
                    hashCode = (hashCode * 59) + this.InboundDataType.GetHashCode();
                }
                if (this.OutboundDataType != null)
                {
                    hashCode = (hashCode * 59) + this.OutboundDataType.GetHashCode();
                }
                if (this.InboundProperties != null)
                {
                    hashCode = (hashCode * 59) + this.InboundProperties.GetHashCode();
                }
                if (this.OutboundProperties != null)
                {
                    hashCode = (hashCode * 59) + this.OutboundProperties.GetHashCode();
                }
                if (this.PurgedProperties != null)
                {
                    hashCode = (hashCode * 59) + this.PurgedProperties.GetHashCode();
                }
                if (this.EnabledElements != null)
                {
                    hashCode = (hashCode * 59) + this.EnabledElements.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
