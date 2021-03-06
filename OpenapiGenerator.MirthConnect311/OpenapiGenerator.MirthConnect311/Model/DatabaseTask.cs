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
    /// DatabaseTask
    /// </summary>
    [DataContract(Name = "DatabaseTask")]
    public partial class DatabaseTask : IEquatable<DatabaseTask>, IValidatableObject
    {
        /// <summary>
        /// Defines Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Idle for value: Idle
            /// </summary>
            [EnumMember(Value = "Idle")]
            Idle = 1,

            /// <summary>
            /// Enum Running for value: Running
            /// </summary>
            [EnumMember(Value = "Running")]
            Running = 2

        }


        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DatabaseTask" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="status">status.</param>
        /// <param name="name">name.</param>
        /// <param name="description">description.</param>
        /// <param name="confirmationMessage">confirmationMessage.</param>
        /// <param name="affectedChannels">affectedChannels.</param>
        /// <param name="startDateTime">startDateTime.</param>
        public DatabaseTask(string id = default(string), StatusEnum? status = default(StatusEnum?), string name = default(string), string description = default(string), string confirmationMessage = default(string), Dictionary<string, string> affectedChannels = default(Dictionary<string, string>), DateTime startDateTime = default(DateTime))
        {
            this.Id = id;
            this.Status = status;
            this.Name = name;
            this.Description = description;
            this.ConfirmationMessage = confirmationMessage;
            this.AffectedChannels = affectedChannels;
            this.StartDateTime = startDateTime;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets ConfirmationMessage
        /// </summary>
        [DataMember(Name = "confirmationMessage", EmitDefaultValue = false)]
        public string ConfirmationMessage { get; set; }

        /// <summary>
        /// Gets or Sets AffectedChannels
        /// </summary>
        [DataMember(Name = "affectedChannels", EmitDefaultValue = false)]
        public Dictionary<string, string> AffectedChannels { get; set; }

        /// <summary>
        /// Gets or Sets StartDateTime
        /// </summary>
        [DataMember(Name = "startDateTime", EmitDefaultValue = false)]
        public DateTime StartDateTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DatabaseTask {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ConfirmationMessage: ").Append(ConfirmationMessage).Append("\n");
            sb.Append("  AffectedChannels: ").Append(AffectedChannels).Append("\n");
            sb.Append("  StartDateTime: ").Append(StartDateTime).Append("\n");
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
            return this.Equals(input as DatabaseTask);
        }

        /// <summary>
        /// Returns true if DatabaseTask instances are equal
        /// </summary>
        /// <param name="input">Instance of DatabaseTask to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DatabaseTask input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.ConfirmationMessage == input.ConfirmationMessage ||
                    (this.ConfirmationMessage != null &&
                    this.ConfirmationMessage.Equals(input.ConfirmationMessage))
                ) && 
                (
                    this.AffectedChannels == input.AffectedChannels ||
                    this.AffectedChannels != null &&
                    input.AffectedChannels != null &&
                    this.AffectedChannels.SequenceEqual(input.AffectedChannels)
                ) && 
                (
                    this.StartDateTime == input.StartDateTime ||
                    (this.StartDateTime != null &&
                    this.StartDateTime.Equals(input.StartDateTime))
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.ConfirmationMessage != null)
                {
                    hashCode = (hashCode * 59) + this.ConfirmationMessage.GetHashCode();
                }
                if (this.AffectedChannels != null)
                {
                    hashCode = (hashCode * 59) + this.AffectedChannels.GetHashCode();
                }
                if (this.StartDateTime != null)
                {
                    hashCode = (hashCode * 59) + this.StartDateTime.GetHashCode();
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
