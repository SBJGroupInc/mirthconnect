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
    /// ConnectorProperties
    /// </summary>
    [DataContract(Name = "ConnectorProperties")]
    public partial class ConnectorProperties : IEquatable<ConnectorProperties>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectorProperties" /> class.
        /// </summary>
        /// <param name="pluginProperties">pluginProperties.</param>
        /// <param name="name">name.</param>
        /// <param name="protocol">protocol.</param>
        /// <param name="purgedProperties">purgedProperties.</param>
        public ConnectorProperties(List<ConnectorPluginProperties> pluginProperties = default(List<ConnectorPluginProperties>), string name = default(string), string protocol = default(string), Dictionary<string, Object> purgedProperties = default(Dictionary<string, Object>))
        {
            this.PluginProperties = pluginProperties;
            this.Name = name;
            this.Protocol = protocol;
            this.PurgedProperties = purgedProperties;
        }

        /// <summary>
        /// Gets or Sets PluginProperties
        /// </summary>
        [DataMember(Name = "pluginProperties", EmitDefaultValue = false)]
        public List<ConnectorPluginProperties> PluginProperties { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Protocol
        /// </summary>
        [DataMember(Name = "protocol", EmitDefaultValue = false)]
        public string Protocol { get; set; }

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
            sb.Append("class ConnectorProperties {\n");
            sb.Append("  PluginProperties: ").Append(PluginProperties).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Protocol: ").Append(Protocol).Append("\n");
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
            return this.Equals(input as ConnectorProperties);
        }

        /// <summary>
        /// Returns true if ConnectorProperties instances are equal
        /// </summary>
        /// <param name="input">Instance of ConnectorProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConnectorProperties input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PluginProperties == input.PluginProperties ||
                    this.PluginProperties != null &&
                    input.PluginProperties != null &&
                    this.PluginProperties.SequenceEqual(input.PluginProperties)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Protocol == input.Protocol ||
                    (this.Protocol != null &&
                    this.Protocol.Equals(input.Protocol))
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
                if (this.PluginProperties != null)
                {
                    hashCode = (hashCode * 59) + this.PluginProperties.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Protocol != null)
                {
                    hashCode = (hashCode * 59) + this.Protocol.GetHashCode();
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