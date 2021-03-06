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
    /// SerializerProperties
    /// </summary>
    [DataContract(Name = "SerializerProperties")]
    public partial class SerializerProperties : IEquatable<SerializerProperties>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SerializerProperties" /> class.
        /// </summary>
        /// <param name="serializationProperties">serializationProperties.</param>
        /// <param name="deserializationProperties">deserializationProperties.</param>
        /// <param name="batchProperties">batchProperties.</param>
        public SerializerProperties(SerializationProperties serializationProperties = default(SerializationProperties), DeserializationProperties deserializationProperties = default(DeserializationProperties), BatchProperties batchProperties = default(BatchProperties))
        {
            this.SerializationProperties = serializationProperties;
            this.DeserializationProperties = deserializationProperties;
            this.BatchProperties = batchProperties;
        }

        /// <summary>
        /// Gets or Sets SerializationProperties
        /// </summary>
        [DataMember(Name = "serializationProperties", EmitDefaultValue = false)]
        public SerializationProperties SerializationProperties { get; set; }

        /// <summary>
        /// Gets or Sets DeserializationProperties
        /// </summary>
        [DataMember(Name = "deserializationProperties", EmitDefaultValue = false)]
        public DeserializationProperties DeserializationProperties { get; set; }

        /// <summary>
        /// Gets or Sets BatchProperties
        /// </summary>
        [DataMember(Name = "batchProperties", EmitDefaultValue = false)]
        public BatchProperties BatchProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SerializerProperties {\n");
            sb.Append("  SerializationProperties: ").Append(SerializationProperties).Append("\n");
            sb.Append("  DeserializationProperties: ").Append(DeserializationProperties).Append("\n");
            sb.Append("  BatchProperties: ").Append(BatchProperties).Append("\n");
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
            return this.Equals(input as SerializerProperties);
        }

        /// <summary>
        /// Returns true if SerializerProperties instances are equal
        /// </summary>
        /// <param name="input">Instance of SerializerProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SerializerProperties input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SerializationProperties == input.SerializationProperties ||
                    (this.SerializationProperties != null &&
                    this.SerializationProperties.Equals(input.SerializationProperties))
                ) && 
                (
                    this.DeserializationProperties == input.DeserializationProperties ||
                    (this.DeserializationProperties != null &&
                    this.DeserializationProperties.Equals(input.DeserializationProperties))
                ) && 
                (
                    this.BatchProperties == input.BatchProperties ||
                    (this.BatchProperties != null &&
                    this.BatchProperties.Equals(input.BatchProperties))
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
                if (this.SerializationProperties != null)
                {
                    hashCode = (hashCode * 59) + this.SerializationProperties.GetHashCode();
                }
                if (this.DeserializationProperties != null)
                {
                    hashCode = (hashCode * 59) + this.DeserializationProperties.GetHashCode();
                }
                if (this.BatchProperties != null)
                {
                    hashCode = (hashCode * 59) + this.BatchProperties.GetHashCode();
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
