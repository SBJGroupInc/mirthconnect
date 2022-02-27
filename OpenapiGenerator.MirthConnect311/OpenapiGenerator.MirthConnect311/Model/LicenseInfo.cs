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
    /// LicenseInfo
    /// </summary>
    [DataContract(Name = "LicenseInfo")]
    public partial class LicenseInfo : IEquatable<LicenseInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LicenseInfo" /> class.
        /// </summary>
        /// <param name="activated">activated.</param>
        /// <param name="online">online.</param>
        /// <param name="expirationDate">expirationDate.</param>
        /// <param name="warningPeriod">warningPeriod.</param>
        /// <param name="gracePeriod">gracePeriod.</param>
        /// <param name="reason">reason.</param>
        /// <param name="extensions">extensions.</param>
        public LicenseInfo(bool activated = default(bool), bool online = default(bool), long expirationDate = default(long), long warningPeriod = default(long), long gracePeriod = default(long), string reason = default(string), List<string> extensions = default(List<string>))
        {
            this.Activated = activated;
            this.Online = online;
            this.ExpirationDate = expirationDate;
            this.WarningPeriod = warningPeriod;
            this.GracePeriod = gracePeriod;
            this.Reason = reason;
            this.Extensions = extensions;
        }

        /// <summary>
        /// Gets or Sets Activated
        /// </summary>
        [DataMember(Name = "activated", EmitDefaultValue = true)]
        public bool Activated { get; set; }

        /// <summary>
        /// Gets or Sets Online
        /// </summary>
        [DataMember(Name = "online", EmitDefaultValue = true)]
        public bool Online { get; set; }

        /// <summary>
        /// Gets or Sets ExpirationDate
        /// </summary>
        [DataMember(Name = "expirationDate", EmitDefaultValue = false)]
        public long ExpirationDate { get; set; }

        /// <summary>
        /// Gets or Sets WarningPeriod
        /// </summary>
        [DataMember(Name = "warningPeriod", EmitDefaultValue = false)]
        public long WarningPeriod { get; set; }

        /// <summary>
        /// Gets or Sets GracePeriod
        /// </summary>
        [DataMember(Name = "gracePeriod", EmitDefaultValue = false)]
        public long GracePeriod { get; set; }

        /// <summary>
        /// Gets or Sets Reason
        /// </summary>
        [DataMember(Name = "reason", EmitDefaultValue = false)]
        public string Reason { get; set; }

        /// <summary>
        /// Gets or Sets Extensions
        /// </summary>
        [DataMember(Name = "extensions", EmitDefaultValue = false)]
        public List<string> Extensions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LicenseInfo {\n");
            sb.Append("  Activated: ").Append(Activated).Append("\n");
            sb.Append("  Online: ").Append(Online).Append("\n");
            sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
            sb.Append("  WarningPeriod: ").Append(WarningPeriod).Append("\n");
            sb.Append("  GracePeriod: ").Append(GracePeriod).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  Extensions: ").Append(Extensions).Append("\n");
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
            return this.Equals(input as LicenseInfo);
        }

        /// <summary>
        /// Returns true if LicenseInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of LicenseInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LicenseInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Activated == input.Activated ||
                    this.Activated.Equals(input.Activated)
                ) && 
                (
                    this.Online == input.Online ||
                    this.Online.Equals(input.Online)
                ) && 
                (
                    this.ExpirationDate == input.ExpirationDate ||
                    this.ExpirationDate.Equals(input.ExpirationDate)
                ) && 
                (
                    this.WarningPeriod == input.WarningPeriod ||
                    this.WarningPeriod.Equals(input.WarningPeriod)
                ) && 
                (
                    this.GracePeriod == input.GracePeriod ||
                    this.GracePeriod.Equals(input.GracePeriod)
                ) && 
                (
                    this.Reason == input.Reason ||
                    (this.Reason != null &&
                    this.Reason.Equals(input.Reason))
                ) && 
                (
                    this.Extensions == input.Extensions ||
                    this.Extensions != null &&
                    input.Extensions != null &&
                    this.Extensions.SequenceEqual(input.Extensions)
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
                hashCode = (hashCode * 59) + this.Activated.GetHashCode();
                hashCode = (hashCode * 59) + this.Online.GetHashCode();
                hashCode = (hashCode * 59) + this.ExpirationDate.GetHashCode();
                hashCode = (hashCode * 59) + this.WarningPeriod.GetHashCode();
                hashCode = (hashCode * 59) + this.GracePeriod.GetHashCode();
                if (this.Reason != null)
                {
                    hashCode = (hashCode * 59) + this.Reason.GetHashCode();
                }
                if (this.Extensions != null)
                {
                    hashCode = (hashCode * 59) + this.Extensions.GetHashCode();
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
