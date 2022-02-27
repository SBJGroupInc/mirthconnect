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
    /// ServerEvent
    /// </summary>
    [DataContract(Name = "ServerEvent")]
    public partial class ServerEvent : IEquatable<ServerEvent>, IValidatableObject
    {
        /// <summary>
        /// Defines Level
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LevelEnum
        {
            /// <summary>
            /// Enum INFORMATION for value: INFORMATION
            /// </summary>
            [EnumMember(Value = "INFORMATION")]
            INFORMATION = 1,

            /// <summary>
            /// Enum WARNING for value: WARNING
            /// </summary>
            [EnumMember(Value = "WARNING")]
            WARNING = 2,

            /// <summary>
            /// Enum ERROR for value: ERROR
            /// </summary>
            [EnumMember(Value = "ERROR")]
            ERROR = 3

        }


        /// <summary>
        /// Gets or Sets Level
        /// </summary>
        [DataMember(Name = "level", EmitDefaultValue = false)]
        public LevelEnum? Level { get; set; }
        /// <summary>
        /// Defines Outcome
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OutcomeEnum
        {
            /// <summary>
            /// Enum SUCCESS for value: SUCCESS
            /// </summary>
            [EnumMember(Value = "SUCCESS")]
            SUCCESS = 1,

            /// <summary>
            /// Enum FAILURE for value: FAILURE
            /// </summary>
            [EnumMember(Value = "FAILURE")]
            FAILURE = 2

        }


        /// <summary>
        /// Gets or Sets Outcome
        /// </summary>
        [DataMember(Name = "outcome", EmitDefaultValue = false)]
        public OutcomeEnum? Outcome { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ServerEvent" /> class.
        /// </summary>
        /// <param name="dateTime">dateTime.</param>
        /// <param name="nanoTime">nanoTime.</param>
        /// <param name="id">id.</param>
        /// <param name="eventTime">eventTime.</param>
        /// <param name="level">level.</param>
        /// <param name="name">name.</param>
        /// <param name="attributes">attributes.</param>
        /// <param name="outcome">outcome.</param>
        /// <param name="userId">userId.</param>
        /// <param name="ipAddress">ipAddress.</param>
        /// <param name="serverId">serverId.</param>
        public ServerEvent(long dateTime = default(long), long nanoTime = default(long), int id = default(int), DateTime eventTime = default(DateTime), LevelEnum? level = default(LevelEnum?), string name = default(string), Dictionary<string, string> attributes = default(Dictionary<string, string>), OutcomeEnum? outcome = default(OutcomeEnum?), int userId = default(int), string ipAddress = default(string), string serverId = default(string))
        {
            this.DateTime = dateTime;
            this.NanoTime = nanoTime;
            this.Id = id;
            this.EventTime = eventTime;
            this.Level = level;
            this.Name = name;
            this.Attributes = attributes;
            this.Outcome = outcome;
            this.UserId = userId;
            this.IpAddress = ipAddress;
            this.ServerId = serverId;
        }

        /// <summary>
        /// Gets or Sets DateTime
        /// </summary>
        [DataMember(Name = "dateTime", EmitDefaultValue = false)]
        public long DateTime { get; set; }

        /// <summary>
        /// Gets or Sets NanoTime
        /// </summary>
        [DataMember(Name = "nanoTime", EmitDefaultValue = false)]
        public long NanoTime { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets EventTime
        /// </summary>
        [DataMember(Name = "eventTime", EmitDefaultValue = false)]
        public DateTime EventTime { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Attributes
        /// </summary>
        [DataMember(Name = "attributes", EmitDefaultValue = false)]
        public Dictionary<string, string> Attributes { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name = "userId", EmitDefaultValue = false)]
        public int UserId { get; set; }

        /// <summary>
        /// Gets or Sets IpAddress
        /// </summary>
        [DataMember(Name = "ipAddress", EmitDefaultValue = false)]
        public string IpAddress { get; set; }

        /// <summary>
        /// Gets or Sets ServerId
        /// </summary>
        [DataMember(Name = "serverId", EmitDefaultValue = false)]
        public string ServerId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ServerEvent {\n");
            sb.Append("  DateTime: ").Append(DateTime).Append("\n");
            sb.Append("  NanoTime: ").Append(NanoTime).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  EventTime: ").Append(EventTime).Append("\n");
            sb.Append("  Level: ").Append(Level).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  Outcome: ").Append(Outcome).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  IpAddress: ").Append(IpAddress).Append("\n");
            sb.Append("  ServerId: ").Append(ServerId).Append("\n");
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
            return this.Equals(input as ServerEvent);
        }

        /// <summary>
        /// Returns true if ServerEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of ServerEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ServerEvent input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DateTime == input.DateTime ||
                    this.DateTime.Equals(input.DateTime)
                ) && 
                (
                    this.NanoTime == input.NanoTime ||
                    this.NanoTime.Equals(input.NanoTime)
                ) && 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.EventTime == input.EventTime ||
                    (this.EventTime != null &&
                    this.EventTime.Equals(input.EventTime))
                ) && 
                (
                    this.Level == input.Level ||
                    this.Level.Equals(input.Level)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Attributes == input.Attributes ||
                    this.Attributes != null &&
                    input.Attributes != null &&
                    this.Attributes.SequenceEqual(input.Attributes)
                ) && 
                (
                    this.Outcome == input.Outcome ||
                    this.Outcome.Equals(input.Outcome)
                ) && 
                (
                    this.UserId == input.UserId ||
                    this.UserId.Equals(input.UserId)
                ) && 
                (
                    this.IpAddress == input.IpAddress ||
                    (this.IpAddress != null &&
                    this.IpAddress.Equals(input.IpAddress))
                ) && 
                (
                    this.ServerId == input.ServerId ||
                    (this.ServerId != null &&
                    this.ServerId.Equals(input.ServerId))
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
                hashCode = (hashCode * 59) + this.DateTime.GetHashCode();
                hashCode = (hashCode * 59) + this.NanoTime.GetHashCode();
                hashCode = (hashCode * 59) + this.Id.GetHashCode();
                if (this.EventTime != null)
                {
                    hashCode = (hashCode * 59) + this.EventTime.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Level.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Attributes != null)
                {
                    hashCode = (hashCode * 59) + this.Attributes.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Outcome.GetHashCode();
                hashCode = (hashCode * 59) + this.UserId.GetHashCode();
                if (this.IpAddress != null)
                {
                    hashCode = (hashCode * 59) + this.IpAddress.GetHashCode();
                }
                if (this.ServerId != null)
                {
                    hashCode = (hashCode * 59) + this.ServerId.GetHashCode();
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