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
    /// UpdateSettings
    /// </summary>
    [DataContract(Name = "UpdateSettings")]
    public partial class UpdateSettings : IEquatable<UpdateSettings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSettings" /> class.
        /// </summary>
        /// <param name="statsEnabled">statsEnabled.</param>
        /// <param name="lastStatsTime">lastStatsTime.</param>
        /// <param name="properties">properties.</param>
        /// <param name="purgedProperties">purgedProperties.</param>
        public UpdateSettings(bool statsEnabled = default(bool), long lastStatsTime = default(long), Dictionary<string, string> properties = default(Dictionary<string, string>), Dictionary<string, Object> purgedProperties = default(Dictionary<string, Object>))
        {
            this.StatsEnabled = statsEnabled;
            this.LastStatsTime = lastStatsTime;
            this.Properties = properties;
            this.PurgedProperties = purgedProperties;
        }

        /// <summary>
        /// Gets or Sets StatsEnabled
        /// </summary>
        [DataMember(Name = "statsEnabled", EmitDefaultValue = true)]
        public bool StatsEnabled { get; set; }

        /// <summary>
        /// Gets or Sets LastStatsTime
        /// </summary>
        [DataMember(Name = "lastStatsTime", EmitDefaultValue = false)]
        public long LastStatsTime { get; set; }

        /// <summary>
        /// Gets or Sets Properties
        /// </summary>
        [DataMember(Name = "properties", EmitDefaultValue = false)]
        public Dictionary<string, string> Properties { get; set; }

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
            sb.Append("class UpdateSettings {\n");
            sb.Append("  StatsEnabled: ").Append(StatsEnabled).Append("\n");
            sb.Append("  LastStatsTime: ").Append(LastStatsTime).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
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
            return this.Equals(input as UpdateSettings);
        }

        /// <summary>
        /// Returns true if UpdateSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateSettings input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.StatsEnabled == input.StatsEnabled ||
                    this.StatsEnabled.Equals(input.StatsEnabled)
                ) && 
                (
                    this.LastStatsTime == input.LastStatsTime ||
                    this.LastStatsTime.Equals(input.LastStatsTime)
                ) && 
                (
                    this.Properties == input.Properties ||
                    this.Properties != null &&
                    input.Properties != null &&
                    this.Properties.SequenceEqual(input.Properties)
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
                hashCode = (hashCode * 59) + this.StatsEnabled.GetHashCode();
                hashCode = (hashCode * 59) + this.LastStatsTime.GetHashCode();
                if (this.Properties != null)
                {
                    hashCode = (hashCode * 59) + this.Properties.GetHashCode();
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
