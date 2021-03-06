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
    /// Channel
    /// </summary>
    [DataContract(Name = "Channel")]
    public partial class Channel : IEquatable<Channel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Channel" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="nextMetaDataId">nextMetaDataId.</param>
        /// <param name="name">name.</param>
        /// <param name="description">description.</param>
        /// <param name="revision">revision.</param>
        /// <param name="sourceConnector">sourceConnector.</param>
        /// <param name="destinationConnectors">destinationConnectors.</param>
        /// <param name="preprocessingScript">preprocessingScript.</param>
        /// <param name="postprocessingScript">postprocessingScript.</param>
        /// <param name="deployScript">deployScript.</param>
        /// <param name="undeployScript">undeployScript.</param>
        /// <param name="properties">properties.</param>
        /// <param name="exportData">exportData.</param>
        /// <param name="purgedProperties">purgedProperties.</param>
        /// <param name="enabledDestinationConnectors">enabledDestinationConnectors.</param>
        public Channel(string id = default(string), int nextMetaDataId = default(int), string name = default(string), string description = default(string), int revision = default(int), Connector sourceConnector = default(Connector), List<Connector> destinationConnectors = default(List<Connector>), string preprocessingScript = default(string), string postprocessingScript = default(string), string deployScript = default(string), string undeployScript = default(string), ChannelProperties properties = default(ChannelProperties), ChannelExportData exportData = default(ChannelExportData), Dictionary<string, Object> purgedProperties = default(Dictionary<string, Object>), List<Connector> enabledDestinationConnectors = default(List<Connector>))
        {
            this.Id = id;
            this.NextMetaDataId = nextMetaDataId;
            this.Name = name;
            this.Description = description;
            this.Revision = revision;
            this.SourceConnector = sourceConnector;
            this.DestinationConnectors = destinationConnectors;
            this.PreprocessingScript = preprocessingScript;
            this.PostprocessingScript = postprocessingScript;
            this.DeployScript = deployScript;
            this.UndeployScript = undeployScript;
            this.Properties = properties;
            this.ExportData = exportData;
            this.PurgedProperties = purgedProperties;
            this.EnabledDestinationConnectors = enabledDestinationConnectors;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets NextMetaDataId
        /// </summary>
        [DataMember(Name = "nextMetaDataId", EmitDefaultValue = false)]
        public int NextMetaDataId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Revision
        /// </summary>
        [DataMember(Name = "revision", EmitDefaultValue = false)]
        public int Revision { get; set; }

        /// <summary>
        /// Gets or Sets SourceConnector
        /// </summary>
        [DataMember(Name = "sourceConnector", EmitDefaultValue = false)]
        public Connector SourceConnector { get; set; }

        /// <summary>
        /// Gets or Sets DestinationConnectors
        /// </summary>
        [DataMember(Name = "destinationConnectors", EmitDefaultValue = false)]
        public List<Connector> DestinationConnectors { get; set; }

        /// <summary>
        /// Gets or Sets PreprocessingScript
        /// </summary>
        [DataMember(Name = "preprocessingScript", EmitDefaultValue = false)]
        public string PreprocessingScript { get; set; }

        /// <summary>
        /// Gets or Sets PostprocessingScript
        /// </summary>
        [DataMember(Name = "postprocessingScript", EmitDefaultValue = false)]
        public string PostprocessingScript { get; set; }

        /// <summary>
        /// Gets or Sets DeployScript
        /// </summary>
        [DataMember(Name = "deployScript", EmitDefaultValue = false)]
        public string DeployScript { get; set; }

        /// <summary>
        /// Gets or Sets UndeployScript
        /// </summary>
        [DataMember(Name = "undeployScript", EmitDefaultValue = false)]
        public string UndeployScript { get; set; }

        /// <summary>
        /// Gets or Sets Properties
        /// </summary>
        [DataMember(Name = "properties", EmitDefaultValue = false)]
        public ChannelProperties Properties { get; set; }

        /// <summary>
        /// Gets or Sets ExportData
        /// </summary>
        [DataMember(Name = "exportData", EmitDefaultValue = false)]
        public ChannelExportData ExportData { get; set; }

        /// <summary>
        /// Gets or Sets PurgedProperties
        /// </summary>
        [DataMember(Name = "purgedProperties", EmitDefaultValue = false)]
        public Dictionary<string, Object> PurgedProperties { get; set; }

        /// <summary>
        /// Gets or Sets EnabledDestinationConnectors
        /// </summary>
        [DataMember(Name = "enabledDestinationConnectors", EmitDefaultValue = false)]
        public List<Connector> EnabledDestinationConnectors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Channel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  NextMetaDataId: ").Append(NextMetaDataId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Revision: ").Append(Revision).Append("\n");
            sb.Append("  SourceConnector: ").Append(SourceConnector).Append("\n");
            sb.Append("  DestinationConnectors: ").Append(DestinationConnectors).Append("\n");
            sb.Append("  PreprocessingScript: ").Append(PreprocessingScript).Append("\n");
            sb.Append("  PostprocessingScript: ").Append(PostprocessingScript).Append("\n");
            sb.Append("  DeployScript: ").Append(DeployScript).Append("\n");
            sb.Append("  UndeployScript: ").Append(UndeployScript).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  ExportData: ").Append(ExportData).Append("\n");
            sb.Append("  PurgedProperties: ").Append(PurgedProperties).Append("\n");
            sb.Append("  EnabledDestinationConnectors: ").Append(EnabledDestinationConnectors).Append("\n");
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
            return this.Equals(input as Channel);
        }

        /// <summary>
        /// Returns true if Channel instances are equal
        /// </summary>
        /// <param name="input">Instance of Channel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Channel input)
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
                    this.NextMetaDataId == input.NextMetaDataId ||
                    this.NextMetaDataId.Equals(input.NextMetaDataId)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Revision == input.Revision ||
                    this.Revision.Equals(input.Revision)
                ) && 
                (
                    this.SourceConnector == input.SourceConnector ||
                    (this.SourceConnector != null &&
                    this.SourceConnector.Equals(input.SourceConnector))
                ) && 
                (
                    this.DestinationConnectors == input.DestinationConnectors ||
                    this.DestinationConnectors != null &&
                    input.DestinationConnectors != null &&
                    this.DestinationConnectors.SequenceEqual(input.DestinationConnectors)
                ) && 
                (
                    this.PreprocessingScript == input.PreprocessingScript ||
                    (this.PreprocessingScript != null &&
                    this.PreprocessingScript.Equals(input.PreprocessingScript))
                ) && 
                (
                    this.PostprocessingScript == input.PostprocessingScript ||
                    (this.PostprocessingScript != null &&
                    this.PostprocessingScript.Equals(input.PostprocessingScript))
                ) && 
                (
                    this.DeployScript == input.DeployScript ||
                    (this.DeployScript != null &&
                    this.DeployScript.Equals(input.DeployScript))
                ) && 
                (
                    this.UndeployScript == input.UndeployScript ||
                    (this.UndeployScript != null &&
                    this.UndeployScript.Equals(input.UndeployScript))
                ) && 
                (
                    this.Properties == input.Properties ||
                    (this.Properties != null &&
                    this.Properties.Equals(input.Properties))
                ) && 
                (
                    this.ExportData == input.ExportData ||
                    (this.ExportData != null &&
                    this.ExportData.Equals(input.ExportData))
                ) && 
                (
                    this.PurgedProperties == input.PurgedProperties ||
                    this.PurgedProperties != null &&
                    input.PurgedProperties != null &&
                    this.PurgedProperties.SequenceEqual(input.PurgedProperties)
                ) && 
                (
                    this.EnabledDestinationConnectors == input.EnabledDestinationConnectors ||
                    this.EnabledDestinationConnectors != null &&
                    input.EnabledDestinationConnectors != null &&
                    this.EnabledDestinationConnectors.SequenceEqual(input.EnabledDestinationConnectors)
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
                hashCode = (hashCode * 59) + this.NextMetaDataId.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Revision.GetHashCode();
                if (this.SourceConnector != null)
                {
                    hashCode = (hashCode * 59) + this.SourceConnector.GetHashCode();
                }
                if (this.DestinationConnectors != null)
                {
                    hashCode = (hashCode * 59) + this.DestinationConnectors.GetHashCode();
                }
                if (this.PreprocessingScript != null)
                {
                    hashCode = (hashCode * 59) + this.PreprocessingScript.GetHashCode();
                }
                if (this.PostprocessingScript != null)
                {
                    hashCode = (hashCode * 59) + this.PostprocessingScript.GetHashCode();
                }
                if (this.DeployScript != null)
                {
                    hashCode = (hashCode * 59) + this.DeployScript.GetHashCode();
                }
                if (this.UndeployScript != null)
                {
                    hashCode = (hashCode * 59) + this.UndeployScript.GetHashCode();
                }
                if (this.Properties != null)
                {
                    hashCode = (hashCode * 59) + this.Properties.GetHashCode();
                }
                if (this.ExportData != null)
                {
                    hashCode = (hashCode * 59) + this.ExportData.GetHashCode();
                }
                if (this.PurgedProperties != null)
                {
                    hashCode = (hashCode * 59) + this.PurgedProperties.GetHashCode();
                }
                if (this.EnabledDestinationConnectors != null)
                {
                    hashCode = (hashCode * 59) + this.EnabledDestinationConnectors.GetHashCode();
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
