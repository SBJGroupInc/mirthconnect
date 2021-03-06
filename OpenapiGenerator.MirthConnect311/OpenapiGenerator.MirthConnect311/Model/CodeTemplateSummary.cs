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
    /// CodeTemplateSummary
    /// </summary>
    [DataContract(Name = "CodeTemplateSummary")]
    public partial class CodeTemplateSummary : IEquatable<CodeTemplateSummary>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CodeTemplateSummary" /> class.
        /// </summary>
        /// <param name="codeTemplateId">codeTemplateId.</param>
        /// <param name="deleted">deleted.</param>
        /// <param name="codeTemplate">codeTemplate.</param>
        public CodeTemplateSummary(string codeTemplateId = default(string), bool deleted = default(bool), CodeTemplate codeTemplate = default(CodeTemplate))
        {
            this.CodeTemplateId = codeTemplateId;
            this.Deleted = deleted;
            this.CodeTemplate = codeTemplate;
        }

        /// <summary>
        /// Gets or Sets CodeTemplateId
        /// </summary>
        [DataMember(Name = "codeTemplateId", EmitDefaultValue = false)]
        public string CodeTemplateId { get; set; }

        /// <summary>
        /// Gets or Sets Deleted
        /// </summary>
        [DataMember(Name = "deleted", EmitDefaultValue = true)]
        public bool Deleted { get; set; }

        /// <summary>
        /// Gets or Sets CodeTemplate
        /// </summary>
        [DataMember(Name = "codeTemplate", EmitDefaultValue = false)]
        public CodeTemplate CodeTemplate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CodeTemplateSummary {\n");
            sb.Append("  CodeTemplateId: ").Append(CodeTemplateId).Append("\n");
            sb.Append("  Deleted: ").Append(Deleted).Append("\n");
            sb.Append("  CodeTemplate: ").Append(CodeTemplate).Append("\n");
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
            return this.Equals(input as CodeTemplateSummary);
        }

        /// <summary>
        /// Returns true if CodeTemplateSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of CodeTemplateSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CodeTemplateSummary input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CodeTemplateId == input.CodeTemplateId ||
                    (this.CodeTemplateId != null &&
                    this.CodeTemplateId.Equals(input.CodeTemplateId))
                ) && 
                (
                    this.Deleted == input.Deleted ||
                    this.Deleted.Equals(input.Deleted)
                ) && 
                (
                    this.CodeTemplate == input.CodeTemplate ||
                    (this.CodeTemplate != null &&
                    this.CodeTemplate.Equals(input.CodeTemplate))
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
                if (this.CodeTemplateId != null)
                {
                    hashCode = (hashCode * 59) + this.CodeTemplateId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Deleted.GetHashCode();
                if (this.CodeTemplate != null)
                {
                    hashCode = (hashCode * 59) + this.CodeTemplate.GetHashCode();
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
