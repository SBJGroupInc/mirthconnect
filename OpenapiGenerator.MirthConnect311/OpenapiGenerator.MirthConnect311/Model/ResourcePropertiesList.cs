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
    /// ResourcePropertiesList
    /// </summary>
    [DataContract(Name = "ResourcePropertiesList")]
    public partial class ResourcePropertiesList : IEquatable<ResourcePropertiesList>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourcePropertiesList" /> class.
        /// </summary>
        /// <param name="list">list.</param>
        public ResourcePropertiesList(List<ResourceProperties> list = default(List<ResourceProperties>))
        {
            this.List = list;
        }

        /// <summary>
        /// Gets or Sets List
        /// </summary>
        [DataMember(Name = "list", EmitDefaultValue = false)]
        public List<ResourceProperties> List { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ResourcePropertiesList {\n");
            sb.Append("  List: ").Append(List).Append("\n");
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
            return this.Equals(input as ResourcePropertiesList);
        }

        /// <summary>
        /// Returns true if ResourcePropertiesList instances are equal
        /// </summary>
        /// <param name="input">Instance of ResourcePropertiesList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResourcePropertiesList input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.List == input.List ||
                    this.List != null &&
                    input.List != null &&
                    this.List.SequenceEqual(input.List)
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
                if (this.List != null)
                {
                    hashCode = (hashCode * 59) + this.List.GetHashCode();
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
