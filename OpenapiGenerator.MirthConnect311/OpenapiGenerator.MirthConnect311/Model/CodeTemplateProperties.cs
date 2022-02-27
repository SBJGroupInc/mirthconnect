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
    /// CodeTemplateProperties
    /// </summary>
    [DataContract(Name = "CodeTemplateProperties")]
    public partial class CodeTemplateProperties : IEquatable<CodeTemplateProperties>, IValidatableObject
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Function for value: Function
            /// </summary>
            [EnumMember(Value = "Function")]
            Function = 1,

            /// <summary>
            /// Enum DragAndDropCodeBlock for value: Drag-and-Drop Code Block
            /// </summary>
            [EnumMember(Value = "Drag-and-Drop Code Block")]
            DragAndDropCodeBlock = 2,

            /// <summary>
            /// Enum CompiledCodeBlock for value: Compiled Code Block
            /// </summary>
            [EnumMember(Value = "Compiled Code Block")]
            CompiledCodeBlock = 3

        }


        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CodeTemplateProperties" /> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="description">description.</param>
        /// <param name="functionDefinition">functionDefinition.</param>
        /// <param name="code">code.</param>
        /// <param name="pluginPointName">pluginPointName.</param>
        /// <param name="purgedProperties">purgedProperties.</param>
        public CodeTemplateProperties(TypeEnum? type = default(TypeEnum?), string description = default(string), CodeTemplateFunctionDefinition functionDefinition = default(CodeTemplateFunctionDefinition), string code = default(string), string pluginPointName = default(string), Dictionary<string, Object> purgedProperties = default(Dictionary<string, Object>))
        {
            this.Type = type;
            this.Description = description;
            this.FunctionDefinition = functionDefinition;
            this.Code = code;
            this.PluginPointName = pluginPointName;
            this.PurgedProperties = purgedProperties;
        }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets FunctionDefinition
        /// </summary>
        [DataMember(Name = "functionDefinition", EmitDefaultValue = false)]
        public CodeTemplateFunctionDefinition FunctionDefinition { get; set; }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets PluginPointName
        /// </summary>
        [DataMember(Name = "pluginPointName", EmitDefaultValue = false)]
        public string PluginPointName { get; set; }

        /// <summary>
        /// Gets or Sets PurgedProperties
        /// </summary>
        [DataMember(Name = "purgedProperties", EmitDefaultValue = false)]
        public Dictionary<string, Object> PurgedProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CodeTemplateProperties {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  FunctionDefinition: ").Append(FunctionDefinition).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  PluginPointName: ").Append(PluginPointName).Append("\n");
            sb.Append("  PurgedProperties: ").Append(PurgedProperties).Append("\n");
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
            return this.Equals(input as CodeTemplateProperties);
        }

        /// <summary>
        /// Returns true if CodeTemplateProperties instances are equal
        /// </summary>
        /// <param name="input">Instance of CodeTemplateProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CodeTemplateProperties input)
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
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.FunctionDefinition == input.FunctionDefinition ||
                    (this.FunctionDefinition != null &&
                    this.FunctionDefinition.Equals(input.FunctionDefinition))
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.PluginPointName == input.PluginPointName ||
                    (this.PluginPointName != null &&
                    this.PluginPointName.Equals(input.PluginPointName))
                ) && 
                (
                    this.PurgedProperties == input.PurgedProperties ||
                    this.PurgedProperties != null &&
                    input.PurgedProperties != null &&
                    this.PurgedProperties.SequenceEqual(input.PurgedProperties)
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
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.FunctionDefinition != null)
                {
                    hashCode = (hashCode * 59) + this.FunctionDefinition.GetHashCode();
                }
                if (this.Code != null)
                {
                    hashCode = (hashCode * 59) + this.Code.GetHashCode();
                }
                if (this.PluginPointName != null)
                {
                    hashCode = (hashCode * 59) + this.PluginPointName.GetHashCode();
                }
                if (this.PurgedProperties != null)
                {
                    hashCode = (hashCode * 59) + this.PurgedProperties.GetHashCode();
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