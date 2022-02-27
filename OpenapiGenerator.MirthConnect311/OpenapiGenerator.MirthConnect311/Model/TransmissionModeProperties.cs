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
    /// TransmissionModeProperties
    /// </summary>
    [DataContract(Name = "TransmissionModeProperties")]
    public partial class TransmissionModeProperties : IEquatable<TransmissionModeProperties>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransmissionModeProperties" /> class.
        /// </summary>
        /// <param name="pluginPointName">pluginPointName.</param>
        /// <param name="purgedProperties">purgedProperties.</param>
        public TransmissionModeProperties(string pluginPointName = default(string), Dictionary<string, Object> purgedProperties = default(Dictionary<string, Object>))
        {
            this.PluginPointName = pluginPointName;
            this.PurgedProperties = purgedProperties;
        }

        /// <summary>
        /// Gets or Sets PluginPointName
        /// </summary>
        [DataMember(Name = "pluginPointName", EmitDefaultValue = false)]
        public string PluginPointName { get; set; }

        /// <summary>
        /// Gets or Sets PurgedProperties
        /// </summary>
        [DataMember(Name = "purgedProperties", EmitDefaultValue = false)]
        public Dictionary<string, Object> PurgedProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransmissionModeProperties {\n");
            sb.Append("  PluginPointName: ").Append(PluginPointName).Append("\n");
            sb.Append("  PurgedProperties: ").Append(PurgedProperties).Append("\n");
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
            return this.Equals(input as TransmissionModeProperties);
        }

        /// <summary>
        /// Returns true if TransmissionModeProperties instances are equal
        /// </summary>
        /// <param name="input">Instance of TransmissionModeProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransmissionModeProperties input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PluginPointName == input.PluginPointName ||
                    (this.PluginPointName != null &&
                    this.PluginPointName.Equals(input.PluginPointName))
                ) && 
                (
                    this.PurgedProperties == input.PurgedProperties ||
                    this.PurgedProperties != null &&
                    input.PurgedProperties != null &&
                    this.PurgedProperties.SequenceEqual(input.PurgedProperties)
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
                if (this.PluginPointName != null)
                {
                    hashCode = (hashCode * 59) + this.PluginPointName.GetHashCode();
                }
                if (this.PurgedProperties != null)
                {
                    hashCode = (hashCode * 59) + this.PurgedProperties.GetHashCode();
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
