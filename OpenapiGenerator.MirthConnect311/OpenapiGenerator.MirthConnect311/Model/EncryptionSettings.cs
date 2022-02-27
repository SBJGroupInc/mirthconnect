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
    /// EncryptionSettings
    /// </summary>
    [DataContract(Name = "EncryptionSettings")]
    public partial class EncryptionSettings : IEquatable<EncryptionSettings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EncryptionSettings" /> class.
        /// </summary>
        /// <param name="encryptExport">encryptExport.</param>
        /// <param name="encryptProperties">encryptProperties.</param>
        /// <param name="encryptionAlgorithm">encryptionAlgorithm.</param>
        /// <param name="encryptionKeyLength">encryptionKeyLength.</param>
        /// <param name="digestAlgorithm">digestAlgorithm.</param>
        /// <param name="securityProvider">securityProvider.</param>
        /// <param name="secretKey">secretKey.</param>
        /// <param name="properties">properties.</param>
        public EncryptionSettings(bool encryptExport = default(bool), bool encryptProperties = default(bool), string encryptionAlgorithm = default(string), int encryptionKeyLength = default(int), string digestAlgorithm = default(string), string securityProvider = default(string), List<byte[]> secretKey = default(List<byte[]>), Dictionary<string, string> properties = default(Dictionary<string, string>))
        {
            this.EncryptExport = encryptExport;
            this.EncryptProperties = encryptProperties;
            this.EncryptionAlgorithm = encryptionAlgorithm;
            this.EncryptionKeyLength = encryptionKeyLength;
            this.DigestAlgorithm = digestAlgorithm;
            this.SecurityProvider = securityProvider;
            this.SecretKey = secretKey;
            this.Properties = properties;
        }

        /// <summary>
        /// Gets or Sets EncryptExport
        /// </summary>
        [DataMember(Name = "encryptExport", EmitDefaultValue = true)]
        public bool EncryptExport { get; set; }

        /// <summary>
        /// Gets or Sets EncryptProperties
        /// </summary>
        [DataMember(Name = "encryptProperties", EmitDefaultValue = true)]
        public bool EncryptProperties { get; set; }

        /// <summary>
        /// Gets or Sets EncryptionAlgorithm
        /// </summary>
        [DataMember(Name = "encryptionAlgorithm", EmitDefaultValue = false)]
        public string EncryptionAlgorithm { get; set; }

        /// <summary>
        /// Gets or Sets EncryptionKeyLength
        /// </summary>
        [DataMember(Name = "encryptionKeyLength", EmitDefaultValue = false)]
        public int EncryptionKeyLength { get; set; }

        /// <summary>
        /// Gets or Sets DigestAlgorithm
        /// </summary>
        [DataMember(Name = "digestAlgorithm", EmitDefaultValue = false)]
        public string DigestAlgorithm { get; set; }

        /// <summary>
        /// Gets or Sets SecurityProvider
        /// </summary>
        [DataMember(Name = "securityProvider", EmitDefaultValue = false)]
        public string SecurityProvider { get; set; }

        /// <summary>
        /// Gets or Sets SecretKey
        /// </summary>
        [DataMember(Name = "secretKey", EmitDefaultValue = false)]
        public List<byte[]> SecretKey { get; set; }

        /// <summary>
        /// Gets or Sets Properties
        /// </summary>
        [DataMember(Name = "properties", EmitDefaultValue = false)]
        public Dictionary<string, string> Properties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EncryptionSettings {\n");
            sb.Append("  EncryptExport: ").Append(EncryptExport).Append("\n");
            sb.Append("  EncryptProperties: ").Append(EncryptProperties).Append("\n");
            sb.Append("  EncryptionAlgorithm: ").Append(EncryptionAlgorithm).Append("\n");
            sb.Append("  EncryptionKeyLength: ").Append(EncryptionKeyLength).Append("\n");
            sb.Append("  DigestAlgorithm: ").Append(DigestAlgorithm).Append("\n");
            sb.Append("  SecurityProvider: ").Append(SecurityProvider).Append("\n");
            sb.Append("  SecretKey: ").Append(SecretKey).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
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
            return this.Equals(input as EncryptionSettings);
        }

        /// <summary>
        /// Returns true if EncryptionSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of EncryptionSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EncryptionSettings input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.EncryptExport == input.EncryptExport ||
                    this.EncryptExport.Equals(input.EncryptExport)
                ) && 
                (
                    this.EncryptProperties == input.EncryptProperties ||
                    this.EncryptProperties.Equals(input.EncryptProperties)
                ) && 
                (
                    this.EncryptionAlgorithm == input.EncryptionAlgorithm ||
                    (this.EncryptionAlgorithm != null &&
                    this.EncryptionAlgorithm.Equals(input.EncryptionAlgorithm))
                ) && 
                (
                    this.EncryptionKeyLength == input.EncryptionKeyLength ||
                    this.EncryptionKeyLength.Equals(input.EncryptionKeyLength)
                ) && 
                (
                    this.DigestAlgorithm == input.DigestAlgorithm ||
                    (this.DigestAlgorithm != null &&
                    this.DigestAlgorithm.Equals(input.DigestAlgorithm))
                ) && 
                (
                    this.SecurityProvider == input.SecurityProvider ||
                    (this.SecurityProvider != null &&
                    this.SecurityProvider.Equals(input.SecurityProvider))
                ) && 
                (
                    this.SecretKey == input.SecretKey ||
                    this.SecretKey != null &&
                    input.SecretKey != null &&
                    this.SecretKey.SequenceEqual(input.SecretKey)
                ) && 
                (
                    this.Properties == input.Properties ||
                    this.Properties != null &&
                    input.Properties != null &&
                    this.Properties.SequenceEqual(input.Properties)
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
                hashCode = (hashCode * 59) + this.EncryptExport.GetHashCode();
                hashCode = (hashCode * 59) + this.EncryptProperties.GetHashCode();
                if (this.EncryptionAlgorithm != null)
                {
                    hashCode = (hashCode * 59) + this.EncryptionAlgorithm.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.EncryptionKeyLength.GetHashCode();
                if (this.DigestAlgorithm != null)
                {
                    hashCode = (hashCode * 59) + this.DigestAlgorithm.GetHashCode();
                }
                if (this.SecurityProvider != null)
                {
                    hashCode = (hashCode * 59) + this.SecurityProvider.GetHashCode();
                }
                if (this.SecretKey != null)
                {
                    hashCode = (hashCode * 59) + this.SecretKey.GetHashCode();
                }
                if (this.Properties != null)
                {
                    hashCode = (hashCode * 59) + this.Properties.GetHashCode();
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