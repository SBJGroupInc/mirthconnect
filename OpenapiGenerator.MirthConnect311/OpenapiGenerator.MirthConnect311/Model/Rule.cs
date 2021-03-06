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
    /// Rule
    /// </summary>
    [DataContract(Name = "Rule")]
    public partial class Rule : IEquatable<Rule>, IValidatableObject
    {
        /// <summary>
        /// Defines Operator
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OperatorEnum
        {
            /// <summary>
            /// Enum AND for value: AND
            /// </summary>
            [EnumMember(Value = "AND")]
            AND = 1,

            /// <summary>
            /// Enum OR for value: OR
            /// </summary>
            [EnumMember(Value = "OR")]
            OR = 2,

            /// <summary>
            /// Enum NONE for value: NONE
            /// </summary>
            [EnumMember(Value = "NONE")]
            NONE = 3

        }


        /// <summary>
        /// Gets or Sets Operator
        /// </summary>
        [DataMember(Name = "operator", EmitDefaultValue = false)]
        public OperatorEnum? Operator { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Rule" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="sequenceNumber">sequenceNumber.</param>
        /// <param name="enabled">enabled.</param>
        /// <param name="_operator">_operator.</param>
        /// <param name="purgedProperties">purgedProperties.</param>
        /// <param name="type">type.</param>
        /// <param name="responseVariables">responseVariables.</param>
        public Rule(string name = default(string), string sequenceNumber = default(string), bool enabled = default(bool), OperatorEnum? _operator = default(OperatorEnum?), Dictionary<string, Object> purgedProperties = default(Dictionary<string, Object>), string type = default(string), List<string> responseVariables = default(List<string>))
        {
            this.Name = name;
            this.SequenceNumber = sequenceNumber;
            this.Enabled = enabled;
            this.Operator = _operator;
            this.PurgedProperties = purgedProperties;
            this.Type = type;
            this.ResponseVariables = responseVariables;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets SequenceNumber
        /// </summary>
        [DataMember(Name = "sequenceNumber", EmitDefaultValue = false)]
        public string SequenceNumber { get; set; }

        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [DataMember(Name = "enabled", EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Gets or Sets PurgedProperties
        /// </summary>
        [DataMember(Name = "purgedProperties", EmitDefaultValue = false)]
        public Dictionary<string, Object> PurgedProperties { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets ResponseVariables
        /// </summary>
        [DataMember(Name = "responseVariables", EmitDefaultValue = false)]
        public List<string> ResponseVariables { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Rule {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SequenceNumber: ").Append(SequenceNumber).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Operator: ").Append(Operator).Append("\n");
            sb.Append("  PurgedProperties: ").Append(PurgedProperties).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ResponseVariables: ").Append(ResponseVariables).Append("\n");
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
            return this.Equals(input as Rule);
        }

        /// <summary>
        /// Returns true if Rule instances are equal
        /// </summary>
        /// <param name="input">Instance of Rule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Rule input)
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
                    this.SequenceNumber == input.SequenceNumber ||
                    (this.SequenceNumber != null &&
                    this.SequenceNumber.Equals(input.SequenceNumber))
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    this.Enabled.Equals(input.Enabled)
                ) && 
                (
                    this.Operator == input.Operator ||
                    this.Operator.Equals(input.Operator)
                ) && 
                (
                    this.PurgedProperties == input.PurgedProperties ||
                    this.PurgedProperties != null &&
                    input.PurgedProperties != null &&
                    this.PurgedProperties.SequenceEqual(input.PurgedProperties)
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.ResponseVariables == input.ResponseVariables ||
                    this.ResponseVariables != null &&
                    input.ResponseVariables != null &&
                    this.ResponseVariables.SequenceEqual(input.ResponseVariables)
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
                if (this.SequenceNumber != null)
                {
                    hashCode = (hashCode * 59) + this.SequenceNumber.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Enabled.GetHashCode();
                hashCode = (hashCode * 59) + this.Operator.GetHashCode();
                if (this.PurgedProperties != null)
                {
                    hashCode = (hashCode * 59) + this.PurgedProperties.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                if (this.ResponseVariables != null)
                {
                    hashCode = (hashCode * 59) + this.ResponseVariables.GetHashCode();
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
