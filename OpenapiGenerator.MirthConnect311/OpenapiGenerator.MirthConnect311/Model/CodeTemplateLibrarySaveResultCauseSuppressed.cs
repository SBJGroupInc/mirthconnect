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
    /// CodeTemplateLibrarySaveResultCauseSuppressed
    /// </summary>
    [DataContract(Name = "CodeTemplateLibrarySaveResult_cause_suppressed")]
    public partial class CodeTemplateLibrarySaveResultCauseSuppressed : IEquatable<CodeTemplateLibrarySaveResultCauseSuppressed>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CodeTemplateLibrarySaveResultCauseSuppressed" /> class.
        /// </summary>
        /// <param name="stackTrace">stackTrace.</param>
        /// <param name="message">message.</param>
        /// <param name="localizedMessage">localizedMessage.</param>
        public CodeTemplateLibrarySaveResultCauseSuppressed(List<CodeTemplateLibrarySaveResultCauseStackTrace> stackTrace = default(List<CodeTemplateLibrarySaveResultCauseStackTrace>), string message = default(string), string localizedMessage = default(string))
        {
            this.StackTrace = stackTrace;
            this.Message = message;
            this.LocalizedMessage = localizedMessage;
        }

        /// <summary>
        /// Gets or Sets StackTrace
        /// </summary>
        [DataMember(Name = "stackTrace", EmitDefaultValue = false)]
        public List<CodeTemplateLibrarySaveResultCauseStackTrace> StackTrace { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets LocalizedMessage
        /// </summary>
        [DataMember(Name = "localizedMessage", EmitDefaultValue = false)]
        public string LocalizedMessage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CodeTemplateLibrarySaveResultCauseSuppressed {\n");
            sb.Append("  StackTrace: ").Append(StackTrace).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  LocalizedMessage: ").Append(LocalizedMessage).Append("\n");
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
            return this.Equals(input as CodeTemplateLibrarySaveResultCauseSuppressed);
        }

        /// <summary>
        /// Returns true if CodeTemplateLibrarySaveResultCauseSuppressed instances are equal
        /// </summary>
        /// <param name="input">Instance of CodeTemplateLibrarySaveResultCauseSuppressed to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CodeTemplateLibrarySaveResultCauseSuppressed input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.StackTrace == input.StackTrace ||
                    this.StackTrace != null &&
                    input.StackTrace != null &&
                    this.StackTrace.SequenceEqual(input.StackTrace)
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.LocalizedMessage == input.LocalizedMessage ||
                    (this.LocalizedMessage != null &&
                    this.LocalizedMessage.Equals(input.LocalizedMessage))
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
                if (this.StackTrace != null)
                {
                    hashCode = (hashCode * 59) + this.StackTrace.GetHashCode();
                }
                if (this.Message != null)
                {
                    hashCode = (hashCode * 59) + this.Message.GetHashCode();
                }
                if (this.LocalizedMessage != null)
                {
                    hashCode = (hashCode * 59) + this.LocalizedMessage.GetHashCode();
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
