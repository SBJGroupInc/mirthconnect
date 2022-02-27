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
    /// TcpDispatcherProperties
    /// </summary>
    [DataContract(Name = "TcpDispatcherProperties")]
    public partial class TcpDispatcherProperties : IEquatable<TcpDispatcherProperties>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TcpDispatcherProperties" /> class.
        /// </summary>
        /// <param name="pluginProperties">pluginProperties.</param>
        /// <param name="destinationConnectorProperties">destinationConnectorProperties.</param>
        /// <param name="transmissionModeProperties">transmissionModeProperties.</param>
        /// <param name="serverMode">serverMode.</param>
        /// <param name="remoteAddress">remoteAddress.</param>
        /// <param name="remotePort">remotePort.</param>
        /// <param name="overrideLocalBinding">overrideLocalBinding.</param>
        /// <param name="localAddress">localAddress.</param>
        /// <param name="localPort">localPort.</param>
        /// <param name="sendTimeout">sendTimeout.</param>
        /// <param name="bufferSize">bufferSize.</param>
        /// <param name="maxConnections">maxConnections.</param>
        /// <param name="keepConnectionOpen">keepConnectionOpen.</param>
        /// <param name="checkRemoteHost">checkRemoteHost.</param>
        /// <param name="responseTimeout">responseTimeout.</param>
        /// <param name="ignoreResponse">ignoreResponse.</param>
        /// <param name="queueOnResponseTimeout">queueOnResponseTimeout.</param>
        /// <param name="dataTypeBinary">dataTypeBinary.</param>
        /// <param name="charsetEncoding">charsetEncoding.</param>
        /// <param name="template">template.</param>
        /// <param name="name">name.</param>
        /// <param name="protocol">protocol.</param>
        /// <param name="purgedProperties">purgedProperties.</param>
        public TcpDispatcherProperties(List<ConnectorPluginProperties> pluginProperties = default(List<ConnectorPluginProperties>), DestinationConnectorProperties destinationConnectorProperties = default(DestinationConnectorProperties), TransmissionModeProperties transmissionModeProperties = default(TransmissionModeProperties), bool serverMode = default(bool), string remoteAddress = default(string), string remotePort = default(string), bool overrideLocalBinding = default(bool), string localAddress = default(string), string localPort = default(string), string sendTimeout = default(string), string bufferSize = default(string), string maxConnections = default(string), bool keepConnectionOpen = default(bool), bool checkRemoteHost = default(bool), string responseTimeout = default(string), bool ignoreResponse = default(bool), bool queueOnResponseTimeout = default(bool), bool dataTypeBinary = default(bool), string charsetEncoding = default(string), string template = default(string), string name = default(string), string protocol = default(string), Dictionary<string, Object> purgedProperties = default(Dictionary<string, Object>))
        {
            this.PluginProperties = pluginProperties;
            this.DestinationConnectorProperties = destinationConnectorProperties;
            this.TransmissionModeProperties = transmissionModeProperties;
            this.ServerMode = serverMode;
            this.RemoteAddress = remoteAddress;
            this.RemotePort = remotePort;
            this.OverrideLocalBinding = overrideLocalBinding;
            this.LocalAddress = localAddress;
            this.LocalPort = localPort;
            this.SendTimeout = sendTimeout;
            this.BufferSize = bufferSize;
            this.MaxConnections = maxConnections;
            this.KeepConnectionOpen = keepConnectionOpen;
            this.CheckRemoteHost = checkRemoteHost;
            this.ResponseTimeout = responseTimeout;
            this.IgnoreResponse = ignoreResponse;
            this.QueueOnResponseTimeout = queueOnResponseTimeout;
            this.DataTypeBinary = dataTypeBinary;
            this.CharsetEncoding = charsetEncoding;
            this.Template = template;
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
        /// Gets or Sets DestinationConnectorProperties
        /// </summary>
        [DataMember(Name = "destinationConnectorProperties", EmitDefaultValue = false)]
        public DestinationConnectorProperties DestinationConnectorProperties { get; set; }

        /// <summary>
        /// Gets or Sets TransmissionModeProperties
        /// </summary>
        [DataMember(Name = "transmissionModeProperties", EmitDefaultValue = false)]
        public TransmissionModeProperties TransmissionModeProperties { get; set; }

        /// <summary>
        /// Gets or Sets ServerMode
        /// </summary>
        [DataMember(Name = "serverMode", EmitDefaultValue = true)]
        public bool ServerMode { get; set; }

        /// <summary>
        /// Gets or Sets RemoteAddress
        /// </summary>
        [DataMember(Name = "remoteAddress", EmitDefaultValue = false)]
        public string RemoteAddress { get; set; }

        /// <summary>
        /// Gets or Sets RemotePort
        /// </summary>
        [DataMember(Name = "remotePort", EmitDefaultValue = false)]
        public string RemotePort { get; set; }

        /// <summary>
        /// Gets or Sets OverrideLocalBinding
        /// </summary>
        [DataMember(Name = "overrideLocalBinding", EmitDefaultValue = true)]
        public bool OverrideLocalBinding { get; set; }

        /// <summary>
        /// Gets or Sets LocalAddress
        /// </summary>
        [DataMember(Name = "localAddress", EmitDefaultValue = false)]
        public string LocalAddress { get; set; }

        /// <summary>
        /// Gets or Sets LocalPort
        /// </summary>
        [DataMember(Name = "localPort", EmitDefaultValue = false)]
        public string LocalPort { get; set; }

        /// <summary>
        /// Gets or Sets SendTimeout
        /// </summary>
        [DataMember(Name = "sendTimeout", EmitDefaultValue = false)]
        public string SendTimeout { get; set; }

        /// <summary>
        /// Gets or Sets BufferSize
        /// </summary>
        [DataMember(Name = "bufferSize", EmitDefaultValue = false)]
        public string BufferSize { get; set; }

        /// <summary>
        /// Gets or Sets MaxConnections
        /// </summary>
        [DataMember(Name = "maxConnections", EmitDefaultValue = false)]
        public string MaxConnections { get; set; }

        /// <summary>
        /// Gets or Sets KeepConnectionOpen
        /// </summary>
        [DataMember(Name = "keepConnectionOpen", EmitDefaultValue = true)]
        public bool KeepConnectionOpen { get; set; }

        /// <summary>
        /// Gets or Sets CheckRemoteHost
        /// </summary>
        [DataMember(Name = "checkRemoteHost", EmitDefaultValue = true)]
        public bool CheckRemoteHost { get; set; }

        /// <summary>
        /// Gets or Sets ResponseTimeout
        /// </summary>
        [DataMember(Name = "responseTimeout", EmitDefaultValue = false)]
        public string ResponseTimeout { get; set; }

        /// <summary>
        /// Gets or Sets IgnoreResponse
        /// </summary>
        [DataMember(Name = "ignoreResponse", EmitDefaultValue = true)]
        public bool IgnoreResponse { get; set; }

        /// <summary>
        /// Gets or Sets QueueOnResponseTimeout
        /// </summary>
        [DataMember(Name = "queueOnResponseTimeout", EmitDefaultValue = true)]
        public bool QueueOnResponseTimeout { get; set; }

        /// <summary>
        /// Gets or Sets DataTypeBinary
        /// </summary>
        [DataMember(Name = "dataTypeBinary", EmitDefaultValue = true)]
        public bool DataTypeBinary { get; set; }

        /// <summary>
        /// Gets or Sets CharsetEncoding
        /// </summary>
        [DataMember(Name = "charsetEncoding", EmitDefaultValue = false)]
        public string CharsetEncoding { get; set; }

        /// <summary>
        /// Gets or Sets Template
        /// </summary>
        [DataMember(Name = "template", EmitDefaultValue = false)]
        public string Template { get; set; }

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
            sb.Append("class TcpDispatcherProperties {\n");
            sb.Append("  PluginProperties: ").Append(PluginProperties).Append("\n");
            sb.Append("  DestinationConnectorProperties: ").Append(DestinationConnectorProperties).Append("\n");
            sb.Append("  TransmissionModeProperties: ").Append(TransmissionModeProperties).Append("\n");
            sb.Append("  ServerMode: ").Append(ServerMode).Append("\n");
            sb.Append("  RemoteAddress: ").Append(RemoteAddress).Append("\n");
            sb.Append("  RemotePort: ").Append(RemotePort).Append("\n");
            sb.Append("  OverrideLocalBinding: ").Append(OverrideLocalBinding).Append("\n");
            sb.Append("  LocalAddress: ").Append(LocalAddress).Append("\n");
            sb.Append("  LocalPort: ").Append(LocalPort).Append("\n");
            sb.Append("  SendTimeout: ").Append(SendTimeout).Append("\n");
            sb.Append("  BufferSize: ").Append(BufferSize).Append("\n");
            sb.Append("  MaxConnections: ").Append(MaxConnections).Append("\n");
            sb.Append("  KeepConnectionOpen: ").Append(KeepConnectionOpen).Append("\n");
            sb.Append("  CheckRemoteHost: ").Append(CheckRemoteHost).Append("\n");
            sb.Append("  ResponseTimeout: ").Append(ResponseTimeout).Append("\n");
            sb.Append("  IgnoreResponse: ").Append(IgnoreResponse).Append("\n");
            sb.Append("  QueueOnResponseTimeout: ").Append(QueueOnResponseTimeout).Append("\n");
            sb.Append("  DataTypeBinary: ").Append(DataTypeBinary).Append("\n");
            sb.Append("  CharsetEncoding: ").Append(CharsetEncoding).Append("\n");
            sb.Append("  Template: ").Append(Template).Append("\n");
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
                    this.DestinationConnectorProperties == input.DestinationConnectorProperties ||
                    (this.DestinationConnectorProperties != null &&
                    this.DestinationConnectorProperties.Equals(input.DestinationConnectorProperties))
                ) && 
                (
                    this.TransmissionModeProperties == input.TransmissionModeProperties ||
                    (this.TransmissionModeProperties != null &&
                    this.TransmissionModeProperties.Equals(input.TransmissionModeProperties))
                ) && 
                (
                    this.ServerMode == input.ServerMode ||
                    this.ServerMode.Equals(input.ServerMode)
                ) && 
                (
                    this.RemoteAddress == input.RemoteAddress ||
                    (this.RemoteAddress != null &&
                    this.RemoteAddress.Equals(input.RemoteAddress))
                ) && 
                (
                    this.RemotePort == input.RemotePort ||
                    (this.RemotePort != null &&
                    this.RemotePort.Equals(input.RemotePort))
                ) && 
                (
                    this.OverrideLocalBinding == input.OverrideLocalBinding ||
                    this.OverrideLocalBinding.Equals(input.OverrideLocalBinding)
                ) && 
                (
                    this.LocalAddress == input.LocalAddress ||
                    (this.LocalAddress != null &&
                    this.LocalAddress.Equals(input.LocalAddress))
                ) && 
                (
                    this.LocalPort == input.LocalPort ||
                    (this.LocalPort != null &&
                    this.LocalPort.Equals(input.LocalPort))
                ) && 
                (
                    this.SendTimeout == input.SendTimeout ||
                    (this.SendTimeout != null &&
                    this.SendTimeout.Equals(input.SendTimeout))
                ) && 
                (
                    this.BufferSize == input.BufferSize ||
                    (this.BufferSize != null &&
                    this.BufferSize.Equals(input.BufferSize))
                ) && 
                (
                    this.MaxConnections == input.MaxConnections ||
                    (this.MaxConnections != null &&
                    this.MaxConnections.Equals(input.MaxConnections))
                ) && 
                (
                    this.KeepConnectionOpen == input.KeepConnectionOpen ||
                    this.KeepConnectionOpen.Equals(input.KeepConnectionOpen)
                ) && 
                (
                    this.CheckRemoteHost == input.CheckRemoteHost ||
                    this.CheckRemoteHost.Equals(input.CheckRemoteHost)
                ) && 
                (
                    this.ResponseTimeout == input.ResponseTimeout ||
                    (this.ResponseTimeout != null &&
                    this.ResponseTimeout.Equals(input.ResponseTimeout))
                ) && 
                (
                    this.IgnoreResponse == input.IgnoreResponse ||
                    this.IgnoreResponse.Equals(input.IgnoreResponse)
                ) && 
                (
                    this.QueueOnResponseTimeout == input.QueueOnResponseTimeout ||
                    this.QueueOnResponseTimeout.Equals(input.QueueOnResponseTimeout)
                ) && 
                (
                    this.DataTypeBinary == input.DataTypeBinary ||
                    this.DataTypeBinary.Equals(input.DataTypeBinary)
                ) && 
                (
                    this.CharsetEncoding == input.CharsetEncoding ||
                    (this.CharsetEncoding != null &&
                    this.CharsetEncoding.Equals(input.CharsetEncoding))
                ) && 
                (
                    this.Template == input.Template ||
                    (this.Template != null &&
                    this.Template.Equals(input.Template))
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
                if (this.DestinationConnectorProperties != null)
                {
                    hashCode = (hashCode * 59) + this.DestinationConnectorProperties.GetHashCode();
                }
                if (this.TransmissionModeProperties != null)
                {
                    hashCode = (hashCode * 59) + this.TransmissionModeProperties.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ServerMode.GetHashCode();
                if (this.RemoteAddress != null)
                {
                    hashCode = (hashCode * 59) + this.RemoteAddress.GetHashCode();
                }
                if (this.RemotePort != null)
                {
                    hashCode = (hashCode * 59) + this.RemotePort.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.OverrideLocalBinding.GetHashCode();
                if (this.LocalAddress != null)
                {
                    hashCode = (hashCode * 59) + this.LocalAddress.GetHashCode();
                }
                if (this.LocalPort != null)
                {
                    hashCode = (hashCode * 59) + this.LocalPort.GetHashCode();
                }
                if (this.SendTimeout != null)
                {
                    hashCode = (hashCode * 59) + this.SendTimeout.GetHashCode();
                }
                if (this.BufferSize != null)
                {
                    hashCode = (hashCode * 59) + this.BufferSize.GetHashCode();
                }
                if (this.MaxConnections != null)
                {
                    hashCode = (hashCode * 59) + this.MaxConnections.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.KeepConnectionOpen.GetHashCode();
                hashCode = (hashCode * 59) + this.CheckRemoteHost.GetHashCode();
                if (this.ResponseTimeout != null)
                {
                    hashCode = (hashCode * 59) + this.ResponseTimeout.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IgnoreResponse.GetHashCode();
                hashCode = (hashCode * 59) + this.QueueOnResponseTimeout.GetHashCode();
                hashCode = (hashCode * 59) + this.DataTypeBinary.GetHashCode();
                if (this.CharsetEncoding != null)
                {
                    hashCode = (hashCode * 59) + this.CharsetEncoding.GetHashCode();
                }
                if (this.Template != null)
                {
                    hashCode = (hashCode * 59) + this.Template.GetHashCode();
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