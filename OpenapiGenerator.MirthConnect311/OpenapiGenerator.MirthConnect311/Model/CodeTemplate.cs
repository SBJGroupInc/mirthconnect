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
    /// CodeTemplate
    /// </summary>
    [DataContract(Name = "CodeTemplate")]
    public partial class CodeTemplate : IEquatable<CodeTemplate>, IValidatableObject
    {
        /// <summary>
        /// Defines ContextSet
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ContextSetEnum
        {
            /// <summary>
            /// Enum GlobalDeploy for value: Global Deploy
            /// </summary>
            [EnumMember(Value = "Global Deploy")]
            GlobalDeploy = 1,

            /// <summary>
            /// Enum GlobalUndeploy for value: Global Undeploy
            /// </summary>
            [EnumMember(Value = "Global Undeploy")]
            GlobalUndeploy = 2,

            /// <summary>
            /// Enum GlobalPreprocessor for value: Global Preprocessor
            /// </summary>
            [EnumMember(Value = "Global Preprocessor")]
            GlobalPreprocessor = 3,

            /// <summary>
            /// Enum GlobalPostprocessor for value: Global Postprocessor
            /// </summary>
            [EnumMember(Value = "Global Postprocessor")]
            GlobalPostprocessor = 4,

            /// <summary>
            /// Enum ChannelDeploy for value: Channel Deploy
            /// </summary>
            [EnumMember(Value = "Channel Deploy")]
            ChannelDeploy = 5,

            /// <summary>
            /// Enum ChannelUndeploy for value: Channel Undeploy
            /// </summary>
            [EnumMember(Value = "Channel Undeploy")]
            ChannelUndeploy = 6,

            /// <summary>
            /// Enum ChannelPreprocessor for value: Channel Preprocessor
            /// </summary>
            [EnumMember(Value = "Channel Preprocessor")]
            ChannelPreprocessor = 7,

            /// <summary>
            /// Enum ChannelPostprocessor for value: Channel Postprocessor
            /// </summary>
            [EnumMember(Value = "Channel Postprocessor")]
            ChannelPostprocessor = 8,

            /// <summary>
            /// Enum ChannelAttachment for value: Channel Attachment
            /// </summary>
            [EnumMember(Value = "Channel Attachment")]
            ChannelAttachment = 9,

            /// <summary>
            /// Enum ChannelBatch for value: Channel Batch
            /// </summary>
            [EnumMember(Value = "Channel Batch")]
            ChannelBatch = 10,

            /// <summary>
            /// Enum SourceReceiver for value: Source Receiver
            /// </summary>
            [EnumMember(Value = "Source Receiver")]
            SourceReceiver = 11,

            /// <summary>
            /// Enum SourceFilterTransformer for value: Source Filter Transformer
            /// </summary>
            [EnumMember(Value = "Source Filter Transformer")]
            SourceFilterTransformer = 12,

            /// <summary>
            /// Enum DestinationFilterTransformer for value: Destination Filter Transformer
            /// </summary>
            [EnumMember(Value = "Destination Filter Transformer")]
            DestinationFilterTransformer = 13,

            /// <summary>
            /// Enum DestinationDispatcher for value: Destination Dispatcher
            /// </summary>
            [EnumMember(Value = "Destination Dispatcher")]
            DestinationDispatcher = 14,

            /// <summary>
            /// Enum DestinationResponseTransformer for value: Destination Response Transformer
            /// </summary>
            [EnumMember(Value = "Destination Response Transformer")]
            DestinationResponseTransformer = 15

        }



        /// <summary>
        /// Gets or Sets ContextSet
        /// </summary>
        [DataMember(Name = "contextSet", EmitDefaultValue = false)]
        public List<ContextSetEnum> ContextSet { get; set; }
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
        /// Initializes a new instance of the <see cref="CodeTemplate" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="revision">revision.</param>
        /// <param name="lastModified">lastModified.</param>
        /// <param name="contextSet">contextSet.</param>
        /// <param name="properties">properties.</param>
        /// <param name="type">type.</param>
        /// <param name="description">description.</param>
        /// <param name="purgedProperties">purgedProperties.</param>
        /// <param name="functionDefinition">functionDefinition.</param>
        /// <param name="addToScripts">addToScripts.</param>
        /// <param name="code">code.</param>
        public CodeTemplate(string id = default(string), string name = default(string), int revision = default(int), DateTime lastModified = default(DateTime), List<ContextSetEnum> contextSet = default(List<ContextSetEnum>), CodeTemplateProperties properties = default(CodeTemplateProperties), TypeEnum? type = default(TypeEnum?), string description = default(string), Dictionary<string, Object> purgedProperties = default(Dictionary<string, Object>), CodeTemplateFunctionDefinition functionDefinition = default(CodeTemplateFunctionDefinition), bool addToScripts = default(bool), string code = default(string))
        {
            this.Id = id;
            this.Name = name;
            this.Revision = revision;
            this.LastModified = lastModified;
            this.ContextSet = contextSet;
            this.Properties = properties;
            this.Type = type;
            this.Description = description;
            this.PurgedProperties = purgedProperties;
            this.FunctionDefinition = functionDefinition;
            this.AddToScripts = addToScripts;
            this.Code = code;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Revision
        /// </summary>
        [DataMember(Name = "revision", EmitDefaultValue = false)]
        public int Revision { get; set; }

        /// <summary>
        /// Gets or Sets LastModified
        /// </summary>
        [DataMember(Name = "lastModified", EmitDefaultValue = false)]
        public DateTime LastModified { get; set; }

        /// <summary>
        /// Gets or Sets Properties
        /// </summary>
        [DataMember(Name = "properties", EmitDefaultValue = false)]
        public CodeTemplateProperties Properties { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets PurgedProperties
        /// </summary>
        [DataMember(Name = "purgedProperties", EmitDefaultValue = false)]
        public Dictionary<string, Object> PurgedProperties { get; set; }

        /// <summary>
        /// Gets or Sets FunctionDefinition
        /// </summary>
        [DataMember(Name = "functionDefinition", EmitDefaultValue = false)]
        public CodeTemplateFunctionDefinition FunctionDefinition { get; set; }

        /// <summary>
        /// Gets or Sets AddToScripts
        /// </summary>
        [DataMember(Name = "addToScripts", EmitDefaultValue = true)]
        public bool AddToScripts { get; set; }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public string Code { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CodeTemplate {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Revision: ").Append(Revision).Append("\n");
            sb.Append("  LastModified: ").Append(LastModified).Append("\n");
            sb.Append("  ContextSet: ").Append(ContextSet).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  PurgedProperties: ").Append(PurgedProperties).Append("\n");
            sb.Append("  FunctionDefinition: ").Append(FunctionDefinition).Append("\n");
            sb.Append("  AddToScripts: ").Append(AddToScripts).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
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
            return this.Equals(input as CodeTemplate);
        }

        /// <summary>
        /// Returns true if CodeTemplate instances are equal
        /// </summary>
        /// <param name="input">Instance of CodeTemplate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CodeTemplate input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Revision == input.Revision ||
                    this.Revision.Equals(input.Revision)
                ) && 
                (
                    this.LastModified == input.LastModified ||
                    (this.LastModified != null &&
                    this.LastModified.Equals(input.LastModified))
                ) && 
                (
                    this.ContextSet == input.ContextSet ||
                    this.ContextSet.SequenceEqual(input.ContextSet)
                ) && 
                (
                    this.Properties == input.Properties ||
                    (this.Properties != null &&
                    this.Properties.Equals(input.Properties))
                ) && 
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
                    this.PurgedProperties == input.PurgedProperties ||
                    this.PurgedProperties != null &&
                    input.PurgedProperties != null &&
                    this.PurgedProperties.SequenceEqual(input.PurgedProperties)
                ) && 
                (
                    this.FunctionDefinition == input.FunctionDefinition ||
                    (this.FunctionDefinition != null &&
                    this.FunctionDefinition.Equals(input.FunctionDefinition))
                ) && 
                (
                    this.AddToScripts == input.AddToScripts ||
                    this.AddToScripts.Equals(input.AddToScripts)
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Revision.GetHashCode();
                if (this.LastModified != null)
                {
                    hashCode = (hashCode * 59) + this.LastModified.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ContextSet.GetHashCode();
                if (this.Properties != null)
                {
                    hashCode = (hashCode * 59) + this.Properties.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.PurgedProperties != null)
                {
                    hashCode = (hashCode * 59) + this.PurgedProperties.GetHashCode();
                }
                if (this.FunctionDefinition != null)
                {
                    hashCode = (hashCode * 59) + this.FunctionDefinition.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AddToScripts.GetHashCode();
                if (this.Code != null)
                {
                    hashCode = (hashCode * 59) + this.Code.GetHashCode();
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
