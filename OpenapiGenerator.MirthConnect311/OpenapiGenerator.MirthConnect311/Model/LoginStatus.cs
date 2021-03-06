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
    /// LoginStatus
    /// </summary>
    [DataContract(Name = "LoginStatus")]
    public partial class LoginStatus : IEquatable<LoginStatus>, IValidatableObject
    {
        /// <summary>
        /// Defines Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum SUCCESS for value: SUCCESS
            /// </summary>
            [EnumMember(Value = "SUCCESS")]
            SUCCESS = 1,

            /// <summary>
            /// Enum SUCCESSGRACEPERIOD for value: SUCCESS_GRACE_PERIOD
            /// </summary>
            [EnumMember(Value = "SUCCESS_GRACE_PERIOD")]
            SUCCESSGRACEPERIOD = 2,

            /// <summary>
            /// Enum FAIL for value: FAIL
            /// </summary>
            [EnumMember(Value = "FAIL")]
            FAIL = 3,

            /// <summary>
            /// Enum FAILEXPIRED for value: FAIL_EXPIRED
            /// </summary>
            [EnumMember(Value = "FAIL_EXPIRED")]
            FAILEXPIRED = 4,

            /// <summary>
            /// Enum FAILLOCKEDOUT for value: FAIL_LOCKED_OUT
            /// </summary>
            [EnumMember(Value = "FAIL_LOCKED_OUT")]
            FAILLOCKEDOUT = 5,

            /// <summary>
            /// Enum FAILVERSIONMISMATCH for value: FAIL_VERSION_MISMATCH
            /// </summary>
            [EnumMember(Value = "FAIL_VERSION_MISMATCH")]
            FAILVERSIONMISMATCH = 6

        }


        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="LoginStatus" /> class.
        /// </summary>
        /// <param name="status">status.</param>
        /// <param name="message">message.</param>
        /// <param name="updatedUsername">updatedUsername.</param>
        public LoginStatus(StatusEnum? status = default(StatusEnum?), string message = default(string), string updatedUsername = default(string))
        {
            this.Status = status;
            this.Message = message;
            this.UpdatedUsername = updatedUsername;
        }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedUsername
        /// </summary>
        [DataMember(Name = "updatedUsername", EmitDefaultValue = false)]
        public string UpdatedUsername { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LoginStatus {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  UpdatedUsername: ").Append(UpdatedUsername).Append("\n");
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
            return this.Equals(input as LoginStatus);
        }

        /// <summary>
        /// Returns true if LoginStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of LoginStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoginStatus input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.UpdatedUsername == input.UpdatedUsername ||
                    (this.UpdatedUsername != null &&
                    this.UpdatedUsername.Equals(input.UpdatedUsername))
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
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.Message != null)
                {
                    hashCode = (hashCode * 59) + this.Message.GetHashCode();
                }
                if (this.UpdatedUsername != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedUsername.GetHashCode();
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
