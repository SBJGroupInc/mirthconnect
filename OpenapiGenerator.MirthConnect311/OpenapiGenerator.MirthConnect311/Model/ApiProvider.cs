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
    /// ApiProvider
    /// </summary>
    [DataContract(Name = "ApiProvider")]
    public partial class ApiProvider : IEquatable<ApiProvider>, IValidatableObject
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum SERVLETINTERFACEPACKAGE for value: SERVLET_INTERFACE_PACKAGE
            /// </summary>
            [EnumMember(Value = "SERVLET_INTERFACE_PACKAGE")]
            SERVLETINTERFACEPACKAGE = 1,

            /// <summary>
            /// Enum SERVLETINTERFACE for value: SERVLET_INTERFACE
            /// </summary>
            [EnumMember(Value = "SERVLET_INTERFACE")]
            SERVLETINTERFACE = 2,

            /// <summary>
            /// Enum COREPACKAGE for value: CORE_PACKAGE
            /// </summary>
            [EnumMember(Value = "CORE_PACKAGE")]
            COREPACKAGE = 3,

            /// <summary>
            /// Enum SERVERPACKAGE for value: SERVER_PACKAGE
            /// </summary>
            [EnumMember(Value = "SERVER_PACKAGE")]
            SERVERPACKAGE = 4,

            /// <summary>
            /// Enum CORECLASS for value: CORE_CLASS
            /// </summary>
            [EnumMember(Value = "CORE_CLASS")]
            CORECLASS = 5,

            /// <summary>
            /// Enum SERVERCLASS for value: SERVER_CLASS
            /// </summary>
            [EnumMember(Value = "SERVER_CLASS")]
            SERVERCLASS = 6

        }


        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProvider" /> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="name">name.</param>
        /// <param name="minVersion">minVersion.</param>
        /// <param name="maxVersion">maxVersion.</param>
        public ApiProvider(TypeEnum? type = default(TypeEnum?), string name = default(string), string minVersion = default(string), string maxVersion = default(string))
        {
            this.Type = type;
            this.Name = name;
            this.MinVersion = minVersion;
            this.MaxVersion = maxVersion;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets MinVersion
        /// </summary>
        [DataMember(Name = "minVersion", EmitDefaultValue = false)]
        public string MinVersion { get; set; }

        /// <summary>
        /// Gets or Sets MaxVersion
        /// </summary>
        [DataMember(Name = "maxVersion", EmitDefaultValue = false)]
        public string MaxVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ApiProvider {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  MinVersion: ").Append(MinVersion).Append("\n");
            sb.Append("  MaxVersion: ").Append(MaxVersion).Append("\n");
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
            return this.Equals(input as ApiProvider);
        }

        /// <summary>
        /// Returns true if ApiProvider instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiProvider to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiProvider input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.MinVersion == input.MinVersion ||
                    (this.MinVersion != null &&
                    this.MinVersion.Equals(input.MinVersion))
                ) && 
                (
                    this.MaxVersion == input.MaxVersion ||
                    (this.MaxVersion != null &&
                    this.MaxVersion.Equals(input.MaxVersion))
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
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.MinVersion != null)
                {
                    hashCode = (hashCode * 59) + this.MinVersion.GetHashCode();
                }
                if (this.MaxVersion != null)
                {
                    hashCode = (hashCode * 59) + this.MaxVersion.GetHashCode();
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
