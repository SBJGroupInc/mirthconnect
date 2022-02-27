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
    /// MetaDataSearch
    /// </summary>
    [DataContract(Name = "MetaDataSearch")]
    public partial class MetaDataSearch : IEquatable<MetaDataSearch>, IValidatableObject
    {
        /// <summary>
        /// Defines Operator
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OperatorEnum
        {
            /// <summary>
            /// Enum Equal for value: &#x3D;
            /// </summary>
            [EnumMember(Value = "=")]
            Equal = 1,

            /// <summary>
            /// Enum NotEqual for value: !&#x3D;
            /// </summary>
            [EnumMember(Value = "!=")]
            NotEqual = 2,

            /// <summary>
            /// Enum LessThan for value: &lt;
            /// </summary>
            [EnumMember(Value = "<")]
            LessThan = 3,

            /// <summary>
            /// Enum LessThanOrEqualTo for value: &lt;&#x3D;
            /// </summary>
            [EnumMember(Value = "<=")]
            LessThanOrEqualTo = 4,

            /// <summary>
            /// Enum GreaterThan for value: &gt;
            /// </summary>
            [EnumMember(Value = ">")]
            GreaterThan = 5,

            /// <summary>
            /// Enum GreaterThanOrEqualTo for value: &gt;&#x3D;
            /// </summary>
            [EnumMember(Value = ">=")]
            GreaterThanOrEqualTo = 6,

            /// <summary>
            /// Enum CONTAINS for value: CONTAINS
            /// </summary>
            [EnumMember(Value = "CONTAINS")]
            CONTAINS = 7,

            /// <summary>
            /// Enum DOESNOTCONTAIN for value: DOES NOT CONTAIN
            /// </summary>
            [EnumMember(Value = "DOES NOT CONTAIN")]
            DOESNOTCONTAIN = 8,

            /// <summary>
            /// Enum STARTSWITH for value: STARTS WITH
            /// </summary>
            [EnumMember(Value = "STARTS WITH")]
            STARTSWITH = 9,

            /// <summary>
            /// Enum DOESNOTSTARTWITH for value: DOES NOT START WITH
            /// </summary>
            [EnumMember(Value = "DOES NOT START WITH")]
            DOESNOTSTARTWITH = 10,

            /// <summary>
            /// Enum ENDSWITH for value: ENDS WITH
            /// </summary>
            [EnumMember(Value = "ENDS WITH")]
            ENDSWITH = 11,

            /// <summary>
            /// Enum DOESNOTENDWITH for value: DOES NOT END WITH
            /// </summary>
            [EnumMember(Value = "DOES NOT END WITH")]
            DOESNOTENDWITH = 12

        }


        /// <summary>
        /// Gets or Sets Operator
        /// </summary>
        [DataMember(Name = "operator", EmitDefaultValue = false)]
        public OperatorEnum? Operator { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MetaDataSearch" /> class.
        /// </summary>
        /// <param name="columnName">columnName.</param>
        /// <param name="_operator">_operator.</param>
        /// <param name="value">value.</param>
        public MetaDataSearch(string columnName = default(string), OperatorEnum? _operator = default(OperatorEnum?), string value = default(string))
        {
            this.ColumnName = columnName;
            this.Operator = _operator;
            this.Value = value;
        }

        /// <summary>
        /// Gets or Sets ColumnName
        /// </summary>
        [DataMember(Name = "columnName", EmitDefaultValue = false)]
        public string ColumnName { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MetaDataSearch {\n");
            sb.Append("  ColumnName: ").Append(ColumnName).Append("\n");
            sb.Append("  Operator: ").Append(Operator).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as MetaDataSearch);
        }

        /// <summary>
        /// Returns true if MetaDataSearch instances are equal
        /// </summary>
        /// <param name="input">Instance of MetaDataSearch to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MetaDataSearch input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ColumnName == input.ColumnName ||
                    (this.ColumnName != null &&
                    this.ColumnName.Equals(input.ColumnName))
                ) && 
                (
                    this.Operator == input.Operator ||
                    this.Operator.Equals(input.Operator)
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.ColumnName != null)
                {
                    hashCode = (hashCode * 59) + this.ColumnName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Operator.GetHashCode();
                if (this.Value != null)
                {
                    hashCode = (hashCode * 59) + this.Value.GetHashCode();
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
