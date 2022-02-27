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
    /// ConnectionLogItem
    /// </summary>
    [DataContract(Name = "ConnectionLogItem")]
    public partial class ConnectionLogItem : IEquatable<ConnectionLogItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionLogItem" /> class.
        /// </summary>
        /// <param name="logId">logId.</param>
        /// <param name="serverId">serverId.</param>
        /// <param name="channelId">channelId.</param>
        /// <param name="metadataId">metadataId.</param>
        /// <param name="dateAdded">dateAdded.</param>
        /// <param name="channelName">channelName.</param>
        /// <param name="connectorType">connectorType.</param>
        /// <param name="eventState">eventState.</param>
        /// <param name="information">information.</param>
        public ConnectionLogItem(long logId = default(long), string serverId = default(string), string channelId = default(string), long metadataId = default(long), string dateAdded = default(string), string channelName = default(string), string connectorType = default(string), string eventState = default(string), string information = default(string))
        {
            this.LogId = logId;
            this.ServerId = serverId;
            this.ChannelId = channelId;
            this.MetadataId = metadataId;
            this.DateAdded = dateAdded;
            this.ChannelName = channelName;
            this.ConnectorType = connectorType;
            this.EventState = eventState;
            this.Information = information;
        }

        /// <summary>
        /// Gets or Sets LogId
        /// </summary>
        [DataMember(Name = "logId", EmitDefaultValue = false)]
        public long LogId { get; set; }

        /// <summary>
        /// Gets or Sets ServerId
        /// </summary>
        [DataMember(Name = "serverId", EmitDefaultValue = false)]
        public string ServerId { get; set; }

        /// <summary>
        /// Gets or Sets ChannelId
        /// </summary>
        [DataMember(Name = "channelId", EmitDefaultValue = false)]
        public string ChannelId { get; set; }

        /// <summary>
        /// Gets or Sets MetadataId
        /// </summary>
        [DataMember(Name = "metadataId", EmitDefaultValue = false)]
        public long MetadataId { get; set; }

        /// <summary>
        /// Gets or Sets DateAdded
        /// </summary>
        [DataMember(Name = "dateAdded", EmitDefaultValue = false)]
        public string DateAdded { get; set; }

        /// <summary>
        /// Gets or Sets ChannelName
        /// </summary>
        [DataMember(Name = "channelName", EmitDefaultValue = false)]
        public string ChannelName { get; set; }

        /// <summary>
        /// Gets or Sets ConnectorType
        /// </summary>
        [DataMember(Name = "connectorType", EmitDefaultValue = false)]
        public string ConnectorType { get; set; }

        /// <summary>
        /// Gets or Sets EventState
        /// </summary>
        [DataMember(Name = "eventState", EmitDefaultValue = false)]
        public string EventState { get; set; }

        /// <summary>
        /// Gets or Sets Information
        /// </summary>
        [DataMember(Name = "information", EmitDefaultValue = false)]
        public string Information { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ConnectionLogItem {\n");
            sb.Append("  LogId: ").Append(LogId).Append("\n");
            sb.Append("  ServerId: ").Append(ServerId).Append("\n");
            sb.Append("  ChannelId: ").Append(ChannelId).Append("\n");
            sb.Append("  MetadataId: ").Append(MetadataId).Append("\n");
            sb.Append("  DateAdded: ").Append(DateAdded).Append("\n");
            sb.Append("  ChannelName: ").Append(ChannelName).Append("\n");
            sb.Append("  ConnectorType: ").Append(ConnectorType).Append("\n");
            sb.Append("  EventState: ").Append(EventState).Append("\n");
            sb.Append("  Information: ").Append(Information).Append("\n");
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
            return this.Equals(input as ConnectionLogItem);
        }

        /// <summary>
        /// Returns true if ConnectionLogItem instances are equal
        /// </summary>
        /// <param name="input">Instance of ConnectionLogItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConnectionLogItem input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.LogId == input.LogId ||
                    this.LogId.Equals(input.LogId)
                ) && 
                (
                    this.ServerId == input.ServerId ||
                    (this.ServerId != null &&
                    this.ServerId.Equals(input.ServerId))
                ) && 
                (
                    this.ChannelId == input.ChannelId ||
                    (this.ChannelId != null &&
                    this.ChannelId.Equals(input.ChannelId))
                ) && 
                (
                    this.MetadataId == input.MetadataId ||
                    this.MetadataId.Equals(input.MetadataId)
                ) && 
                (
                    this.DateAdded == input.DateAdded ||
                    (this.DateAdded != null &&
                    this.DateAdded.Equals(input.DateAdded))
                ) && 
                (
                    this.ChannelName == input.ChannelName ||
                    (this.ChannelName != null &&
                    this.ChannelName.Equals(input.ChannelName))
                ) && 
                (
                    this.ConnectorType == input.ConnectorType ||
                    (this.ConnectorType != null &&
                    this.ConnectorType.Equals(input.ConnectorType))
                ) && 
                (
                    this.EventState == input.EventState ||
                    (this.EventState != null &&
                    this.EventState.Equals(input.EventState))
                ) && 
                (
                    this.Information == input.Information ||
                    (this.Information != null &&
                    this.Information.Equals(input.Information))
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
                hashCode = (hashCode * 59) + this.LogId.GetHashCode();
                if (this.ServerId != null)
                {
                    hashCode = (hashCode * 59) + this.ServerId.GetHashCode();
                }
                if (this.ChannelId != null)
                {
                    hashCode = (hashCode * 59) + this.ChannelId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.MetadataId.GetHashCode();
                if (this.DateAdded != null)
                {
                    hashCode = (hashCode * 59) + this.DateAdded.GetHashCode();
                }
                if (this.ChannelName != null)
                {
                    hashCode = (hashCode * 59) + this.ChannelName.GetHashCode();
                }
                if (this.ConnectorType != null)
                {
                    hashCode = (hashCode * 59) + this.ConnectorType.GetHashCode();
                }
                if (this.EventState != null)
                {
                    hashCode = (hashCode * 59) + this.EventState.GetHashCode();
                }
                if (this.Information != null)
                {
                    hashCode = (hashCode * 59) + this.Information.GetHashCode();
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