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
    /// ChannelStatus
    /// </summary>
    [DataContract(Name = "ChannelStatus")]
    public partial class ChannelStatus : IEquatable<ChannelStatus>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelStatus" /> class.
        /// </summary>
        /// <param name="channel">channel.</param>
        /// <param name="deployedDate">deployedDate.</param>
        /// <param name="deployedRevisionDelta">deployedRevisionDelta.</param>
        /// <param name="codeTemplatesChanged">codeTemplatesChanged.</param>
        /// <param name="localChannelId">localChannelId.</param>
        public ChannelStatus(Channel channel = default(Channel), DateTime deployedDate = default(DateTime), int deployedRevisionDelta = default(int), bool codeTemplatesChanged = default(bool), long localChannelId = default(long))
        {
            this.Channel = channel;
            this.DeployedDate = deployedDate;
            this.DeployedRevisionDelta = deployedRevisionDelta;
            this.CodeTemplatesChanged = codeTemplatesChanged;
            this.LocalChannelId = localChannelId;
        }

        /// <summary>
        /// Gets or Sets Channel
        /// </summary>
        [DataMember(Name = "channel", EmitDefaultValue = false)]
        public Channel Channel { get; set; }

        /// <summary>
        /// Gets or Sets DeployedDate
        /// </summary>
        [DataMember(Name = "deployedDate", EmitDefaultValue = false)]
        public DateTime DeployedDate { get; set; }

        /// <summary>
        /// Gets or Sets DeployedRevisionDelta
        /// </summary>
        [DataMember(Name = "deployedRevisionDelta", EmitDefaultValue = false)]
        public int DeployedRevisionDelta { get; set; }

        /// <summary>
        /// Gets or Sets CodeTemplatesChanged
        /// </summary>
        [DataMember(Name = "codeTemplatesChanged", EmitDefaultValue = true)]
        public bool CodeTemplatesChanged { get; set; }

        /// <summary>
        /// Gets or Sets LocalChannelId
        /// </summary>
        [DataMember(Name = "localChannelId", EmitDefaultValue = false)]
        public long LocalChannelId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ChannelStatus {\n");
            sb.Append("  Channel: ").Append(Channel).Append("\n");
            sb.Append("  DeployedDate: ").Append(DeployedDate).Append("\n");
            sb.Append("  DeployedRevisionDelta: ").Append(DeployedRevisionDelta).Append("\n");
            sb.Append("  CodeTemplatesChanged: ").Append(CodeTemplatesChanged).Append("\n");
            sb.Append("  LocalChannelId: ").Append(LocalChannelId).Append("\n");
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
            return this.Equals(input as ChannelStatus);
        }

        /// <summary>
        /// Returns true if ChannelStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of ChannelStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChannelStatus input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Channel == input.Channel ||
                    (this.Channel != null &&
                    this.Channel.Equals(input.Channel))
                ) && 
                (
                    this.DeployedDate == input.DeployedDate ||
                    (this.DeployedDate != null &&
                    this.DeployedDate.Equals(input.DeployedDate))
                ) && 
                (
                    this.DeployedRevisionDelta == input.DeployedRevisionDelta ||
                    this.DeployedRevisionDelta.Equals(input.DeployedRevisionDelta)
                ) && 
                (
                    this.CodeTemplatesChanged == input.CodeTemplatesChanged ||
                    this.CodeTemplatesChanged.Equals(input.CodeTemplatesChanged)
                ) && 
                (
                    this.LocalChannelId == input.LocalChannelId ||
                    this.LocalChannelId.Equals(input.LocalChannelId)
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
                if (this.Channel != null)
                {
                    hashCode = (hashCode * 59) + this.Channel.GetHashCode();
                }
                if (this.DeployedDate != null)
                {
                    hashCode = (hashCode * 59) + this.DeployedDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.DeployedRevisionDelta.GetHashCode();
                hashCode = (hashCode * 59) + this.CodeTemplatesChanged.GetHashCode();
                hashCode = (hashCode * 59) + this.LocalChannelId.GetHashCode();
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
