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
    /// AlertInfo
    /// </summary>
    [DataContract(Name = "AlertInfo")]
    public partial class AlertInfo : IEquatable<AlertInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlertInfo" /> class.
        /// </summary>
        /// <param name="model">model.</param>
        /// <param name="protocolOptions">protocolOptions.</param>
        /// <param name="changedChannels">changedChannels.</param>
        public AlertInfo(AlertModel model = default(AlertModel), Dictionary<string, Dictionary<string, string>> protocolOptions = default(Dictionary<string, Dictionary<string, string>>), List<ChannelSummary> changedChannels = default(List<ChannelSummary>))
        {
            this.Model = model;
            this.ProtocolOptions = protocolOptions;
            this.ChangedChannels = changedChannels;
        }

        /// <summary>
        /// Gets or Sets Model
        /// </summary>
        [DataMember(Name = "model", EmitDefaultValue = false)]
        public AlertModel Model { get; set; }

        /// <summary>
        /// Gets or Sets ProtocolOptions
        /// </summary>
        [DataMember(Name = "protocolOptions", EmitDefaultValue = false)]
        public Dictionary<string, Dictionary<string, string>> ProtocolOptions { get; set; }

        /// <summary>
        /// Gets or Sets ChangedChannels
        /// </summary>
        [DataMember(Name = "changedChannels", EmitDefaultValue = false)]
        public List<ChannelSummary> ChangedChannels { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlertInfo {\n");
            sb.Append("  Model: ").Append(Model).Append("\n");
            sb.Append("  ProtocolOptions: ").Append(ProtocolOptions).Append("\n");
            sb.Append("  ChangedChannels: ").Append(ChangedChannels).Append("\n");
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
            return this.Equals(input as AlertInfo);
        }

        /// <summary>
        /// Returns true if AlertInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of AlertInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlertInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Model == input.Model ||
                    (this.Model != null &&
                    this.Model.Equals(input.Model))
                ) && 
                (
                    this.ProtocolOptions == input.ProtocolOptions ||
                    this.ProtocolOptions != null &&
                    input.ProtocolOptions != null &&
                    this.ProtocolOptions.SequenceEqual(input.ProtocolOptions)
                ) && 
                (
                    this.ChangedChannels == input.ChangedChannels ||
                    this.ChangedChannels != null &&
                    input.ChangedChannels != null &&
                    this.ChangedChannels.SequenceEqual(input.ChangedChannels)
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
                if (this.Model != null)
                {
                    hashCode = (hashCode * 59) + this.Model.GetHashCode();
                }
                if (this.ProtocolOptions != null)
                {
                    hashCode = (hashCode * 59) + this.ProtocolOptions.GetHashCode();
                }
                if (this.ChangedChannels != null)
                {
                    hashCode = (hashCode * 59) + this.ChangedChannels.GetHashCode();
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
