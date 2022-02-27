using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace OpenapiGenerator.MirthConnect311.Model
{
    /// <summary>
    /// TcpDispatcherProperties
    /// </summary>
    [DataContract(Name = "TcpReceiverProperties")]
    public partial class JsonConnectorProperties: ConnectorProperties, IEquatable<TcpDispatcherProperties>, IValidatableObject
    {
        public string Json { get; set; }
        public JsonConnectorProperties(List<ConnectorPluginProperties> pluginProperties = default(List<ConnectorPluginProperties>), DestinationConnectorProperties destinationConnectorProperties = default(DestinationConnectorProperties), TransmissionModeProperties transmissionModeProperties = default(TransmissionModeProperties), bool serverMode = default(bool), string remoteAddress = default(string), string remotePort = default(string), bool overrideLocalBinding = default(bool), string localAddress = default(string), string localPort = default(string), string sendTimeout = default(string), string bufferSize = default(string), string maxConnections = default(string), bool keepConnectionOpen = default(bool), bool checkRemoteHost = default(bool), string responseTimeout = default(string), bool ignoreResponse = default(bool), bool queueOnResponseTimeout = default(bool), bool dataTypeBinary = default(bool), string charsetEncoding = default(string), string template = default(string), string name = default(string), string protocol = default(string), Dictionary<string, Object> purgedProperties = default(Dictionary<string, Object>))
        {
            this.PluginProperties = pluginProperties;
            this.Name = name;
            this.Protocol = protocol;
            this.PurgedProperties = purgedProperties;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TcpDispatcherProperties {\n");
            sb.Append("  PluginProperties: ").Append(PluginProperties).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Protocol: ").Append(Protocol).Append("\n");
            sb.Append("  PurgedProperties: ").Append(PurgedProperties).Append("\n");
            sb.Append("  Json: ").Append(Json).Append("\n"); 
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return Json;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as TcpDispatcherProperties);
        }

        /// <summary>
        /// Returns true if TcpDispatcherProperties instances are equal
        /// </summary>
        /// <param name="input">Instance of TcpDispatcherProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TcpDispatcherProperties input)
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
        public new IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
