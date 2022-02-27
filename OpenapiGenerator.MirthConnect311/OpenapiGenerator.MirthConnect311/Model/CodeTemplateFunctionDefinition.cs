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
    /// CodeTemplateFunctionDefinition
    /// </summary>
    [DataContract(Name = "CodeTemplateFunctionDefinition")]
    public partial class CodeTemplateFunctionDefinition : IEquatable<CodeTemplateFunctionDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CodeTemplateFunctionDefinition" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="parameters">parameters.</param>
        /// <param name="returnType">returnType.</param>
        /// <param name="returnDescription">returnDescription.</param>
        /// <param name="transferData">transferData.</param>
        public CodeTemplateFunctionDefinition(string name = default(string), List<Parameter> parameters = default(List<Parameter>), string returnType = default(string), string returnDescription = default(string), string transferData = default(string))
        {
            this.Name = name;
            this.Parameters = parameters;
            this.ReturnType = returnType;
            this.ReturnDescription = returnDescription;
            this.TransferData = transferData;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Parameters
        /// </summary>
        [DataMember(Name = "parameters", EmitDefaultValue = false)]
        public List<Parameter> Parameters { get; set; }

        /// <summary>
        /// Gets or Sets ReturnType
        /// </summary>
        [DataMember(Name = "returnType", EmitDefaultValue = false)]
        public string ReturnType { get; set; }

        /// <summary>
        /// Gets or Sets ReturnDescription
        /// </summary>
        [DataMember(Name = "returnDescription", EmitDefaultValue = false)]
        public string ReturnDescription { get; set; }

        /// <summary>
        /// Gets or Sets TransferData
        /// </summary>
        [DataMember(Name = "transferData", EmitDefaultValue = false)]
        public string TransferData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CodeTemplateFunctionDefinition {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
            sb.Append("  ReturnType: ").Append(ReturnType).Append("\n");
            sb.Append("  ReturnDescription: ").Append(ReturnDescription).Append("\n");
            sb.Append("  TransferData: ").Append(TransferData).Append("\n");
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
            return this.Equals(input as CodeTemplateFunctionDefinition);
        }

        /// <summary>
        /// Returns true if CodeTemplateFunctionDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of CodeTemplateFunctionDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CodeTemplateFunctionDefinition input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Parameters == input.Parameters ||
                    this.Parameters != null &&
                    input.Parameters != null &&
                    this.Parameters.SequenceEqual(input.Parameters)
                ) && 
                (
                    this.ReturnType == input.ReturnType ||
                    (this.ReturnType != null &&
                    this.ReturnType.Equals(input.ReturnType))
                ) && 
                (
                    this.ReturnDescription == input.ReturnDescription ||
                    (this.ReturnDescription != null &&
                    this.ReturnDescription.Equals(input.ReturnDescription))
                ) && 
                (
                    this.TransferData == input.TransferData ||
                    (this.TransferData != null &&
                    this.TransferData.Equals(input.TransferData))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Parameters != null)
                {
                    hashCode = (hashCode * 59) + this.Parameters.GetHashCode();
                }
                if (this.ReturnType != null)
                {
                    hashCode = (hashCode * 59) + this.ReturnType.GetHashCode();
                }
                if (this.ReturnDescription != null)
                {
                    hashCode = (hashCode * 59) + this.ReturnDescription.GetHashCode();
                }
                if (this.TransferData != null)
                {
                    hashCode = (hashCode * 59) + this.TransferData.GetHashCode();
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
