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
    /// SystemInfo
    /// </summary>
    [DataContract(Name = "SystemInfo")]
    public partial class SystemInfo : IEquatable<SystemInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemInfo" /> class.
        /// </summary>
        /// <param name="jvmVersion">jvmVersion.</param>
        /// <param name="osName">osName.</param>
        /// <param name="osVersion">osVersion.</param>
        /// <param name="osArchitecture">osArchitecture.</param>
        /// <param name="dbName">dbName.</param>
        /// <param name="dbVersion">dbVersion.</param>
        public SystemInfo(string jvmVersion = default(string), string osName = default(string), string osVersion = default(string), string osArchitecture = default(string), string dbName = default(string), string dbVersion = default(string))
        {
            this.JvmVersion = jvmVersion;
            this.OsName = osName;
            this.OsVersion = osVersion;
            this.OsArchitecture = osArchitecture;
            this.DbName = dbName;
            this.DbVersion = dbVersion;
        }

        /// <summary>
        /// Gets or Sets JvmVersion
        /// </summary>
        [DataMember(Name = "jvmVersion", EmitDefaultValue = false)]
        public string JvmVersion { get; set; }

        /// <summary>
        /// Gets or Sets OsName
        /// </summary>
        [DataMember(Name = "osName", EmitDefaultValue = false)]
        public string OsName { get; set; }

        /// <summary>
        /// Gets or Sets OsVersion
        /// </summary>
        [DataMember(Name = "osVersion", EmitDefaultValue = false)]
        public string OsVersion { get; set; }

        /// <summary>
        /// Gets or Sets OsArchitecture
        /// </summary>
        [DataMember(Name = "osArchitecture", EmitDefaultValue = false)]
        public string OsArchitecture { get; set; }

        /// <summary>
        /// Gets or Sets DbName
        /// </summary>
        [DataMember(Name = "dbName", EmitDefaultValue = false)]
        public string DbName { get; set; }

        /// <summary>
        /// Gets or Sets DbVersion
        /// </summary>
        [DataMember(Name = "dbVersion", EmitDefaultValue = false)]
        public string DbVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SystemInfo {\n");
            sb.Append("  JvmVersion: ").Append(JvmVersion).Append("\n");
            sb.Append("  OsName: ").Append(OsName).Append("\n");
            sb.Append("  OsVersion: ").Append(OsVersion).Append("\n");
            sb.Append("  OsArchitecture: ").Append(OsArchitecture).Append("\n");
            sb.Append("  DbName: ").Append(DbName).Append("\n");
            sb.Append("  DbVersion: ").Append(DbVersion).Append("\n");
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
            return this.Equals(input as SystemInfo);
        }

        /// <summary>
        /// Returns true if SystemInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of SystemInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SystemInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.JvmVersion == input.JvmVersion ||
                    (this.JvmVersion != null &&
                    this.JvmVersion.Equals(input.JvmVersion))
                ) && 
                (
                    this.OsName == input.OsName ||
                    (this.OsName != null &&
                    this.OsName.Equals(input.OsName))
                ) && 
                (
                    this.OsVersion == input.OsVersion ||
                    (this.OsVersion != null &&
                    this.OsVersion.Equals(input.OsVersion))
                ) && 
                (
                    this.OsArchitecture == input.OsArchitecture ||
                    (this.OsArchitecture != null &&
                    this.OsArchitecture.Equals(input.OsArchitecture))
                ) && 
                (
                    this.DbName == input.DbName ||
                    (this.DbName != null &&
                    this.DbName.Equals(input.DbName))
                ) && 
                (
                    this.DbVersion == input.DbVersion ||
                    (this.DbVersion != null &&
                    this.DbVersion.Equals(input.DbVersion))
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
                if (this.JvmVersion != null)
                {
                    hashCode = (hashCode * 59) + this.JvmVersion.GetHashCode();
                }
                if (this.OsName != null)
                {
                    hashCode = (hashCode * 59) + this.OsName.GetHashCode();
                }
                if (this.OsVersion != null)
                {
                    hashCode = (hashCode * 59) + this.OsVersion.GetHashCode();
                }
                if (this.OsArchitecture != null)
                {
                    hashCode = (hashCode * 59) + this.OsArchitecture.GetHashCode();
                }
                if (this.DbName != null)
                {
                    hashCode = (hashCode * 59) + this.DbName.GetHashCode();
                }
                if (this.DbVersion != null)
                {
                    hashCode = (hashCode * 59) + this.DbVersion.GetHashCode();
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
