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
    /// FileDispatcherProperties
    /// </summary>
    [DataContract(Name = "FileDispatcherProperties")]
    public partial class FileDispatcherProperties : IEquatable<FileDispatcherProperties>, IValidatableObject
    {
        /// <summary>
        /// Defines Scheme
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SchemeEnum
        {
            /// <summary>
            /// Enum File for value: file
            /// </summary>
            [EnumMember(Value = "file")]
            File = 1,

            /// <summary>
            /// Enum Ftp for value: ftp
            /// </summary>
            [EnumMember(Value = "ftp")]
            Ftp = 2,

            /// <summary>
            /// Enum Sftp for value: sftp
            /// </summary>
            [EnumMember(Value = "sftp")]
            Sftp = 3,

            /// <summary>
            /// Enum AmazonS3 for value: Amazon S3
            /// </summary>
            [EnumMember(Value = "Amazon S3")]
            AmazonS3 = 4,

            /// <summary>
            /// Enum Smb for value: smb
            /// </summary>
            [EnumMember(Value = "smb")]
            Smb = 5,

            /// <summary>
            /// Enum Webdav for value: webdav
            /// </summary>
            [EnumMember(Value = "webdav")]
            Webdav = 6

        }


        /// <summary>
        /// Gets or Sets Scheme
        /// </summary>
        [DataMember(Name = "scheme", EmitDefaultValue = false)]
        public SchemeEnum? Scheme { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FileDispatcherProperties" /> class.
        /// </summary>
        /// <param name="pluginProperties">pluginProperties.</param>
        /// <param name="destinationConnectorProperties">destinationConnectorProperties.</param>
        /// <param name="scheme">scheme.</param>
        /// <param name="schemeProperties">schemeProperties.</param>
        /// <param name="host">host.</param>
        /// <param name="outputPattern">outputPattern.</param>
        /// <param name="anonymous">anonymous.</param>
        /// <param name="username">username.</param>
        /// <param name="password">password.</param>
        /// <param name="timeout">timeout.</param>
        /// <param name="keepConnectionOpen">keepConnectionOpen.</param>
        /// <param name="maxIdleTime">maxIdleTime.</param>
        /// <param name="secure">secure.</param>
        /// <param name="passive">passive.</param>
        /// <param name="validateConnection">validateConnection.</param>
        /// <param name="outputAppend">outputAppend.</param>
        /// <param name="errorOnExists">errorOnExists.</param>
        /// <param name="temporary">temporary.</param>
        /// <param name="binary">binary.</param>
        /// <param name="charsetEncoding">charsetEncoding.</param>
        /// <param name="template">template.</param>
        /// <param name="name">name.</param>
        /// <param name="protocol">protocol.</param>
        /// <param name="purgedProperties">purgedProperties.</param>
        public FileDispatcherProperties(List<ConnectorPluginProperties> pluginProperties = default(List<ConnectorPluginProperties>), DestinationConnectorProperties destinationConnectorProperties = default(DestinationConnectorProperties), SchemeEnum? scheme = default(SchemeEnum?), SchemeProperties schemeProperties = default(SchemeProperties), string host = default(string), string outputPattern = default(string), bool anonymous = default(bool), string username = default(string), string password = default(string), string timeout = default(string), bool keepConnectionOpen = default(bool), string maxIdleTime = default(string), bool secure = default(bool), bool passive = default(bool), bool validateConnection = default(bool), bool outputAppend = default(bool), bool errorOnExists = default(bool), bool temporary = default(bool), bool binary = default(bool), string charsetEncoding = default(string), string template = default(string), string name = default(string), string protocol = default(string), Dictionary<string, Object> purgedProperties = default(Dictionary<string, Object>))
        {
            this.PluginProperties = pluginProperties;
            this.DestinationConnectorProperties = destinationConnectorProperties;
            this.Scheme = scheme;
            this.SchemeProperties = schemeProperties;
            this.Host = host;
            this.OutputPattern = outputPattern;
            this.Anonymous = anonymous;
            this.Username = username;
            this.Password = password;
            this.Timeout = timeout;
            this.KeepConnectionOpen = keepConnectionOpen;
            this.MaxIdleTime = maxIdleTime;
            this.Secure = secure;
            this.Passive = passive;
            this.ValidateConnection = validateConnection;
            this.OutputAppend = outputAppend;
            this.ErrorOnExists = errorOnExists;
            this.Temporary = temporary;
            this.Binary = binary;
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
        /// Gets or Sets SchemeProperties
        /// </summary>
        [DataMember(Name = "schemeProperties", EmitDefaultValue = false)]
        public SchemeProperties SchemeProperties { get; set; }

        /// <summary>
        /// Gets or Sets Host
        /// </summary>
        [DataMember(Name = "host", EmitDefaultValue = false)]
        public string Host { get; set; }

        /// <summary>
        /// Gets or Sets OutputPattern
        /// </summary>
        [DataMember(Name = "outputPattern", EmitDefaultValue = false)]
        public string OutputPattern { get; set; }

        /// <summary>
        /// Gets or Sets Anonymous
        /// </summary>
        [DataMember(Name = "anonymous", EmitDefaultValue = true)]
        public bool Anonymous { get; set; }

        /// <summary>
        /// Gets or Sets Username
        /// </summary>
        [DataMember(Name = "username", EmitDefaultValue = false)]
        public string Username { get; set; }

        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [DataMember(Name = "password", EmitDefaultValue = false)]
        public string Password { get; set; }

        /// <summary>
        /// Gets or Sets Timeout
        /// </summary>
        [DataMember(Name = "timeout", EmitDefaultValue = false)]
        public string Timeout { get; set; }

        /// <summary>
        /// Gets or Sets KeepConnectionOpen
        /// </summary>
        [DataMember(Name = "keepConnectionOpen", EmitDefaultValue = true)]
        public bool KeepConnectionOpen { get; set; }

        /// <summary>
        /// Gets or Sets MaxIdleTime
        /// </summary>
        [DataMember(Name = "maxIdleTime", EmitDefaultValue = false)]
        public string MaxIdleTime { get; set; }

        /// <summary>
        /// Gets or Sets Secure
        /// </summary>
        [DataMember(Name = "secure", EmitDefaultValue = true)]
        public bool Secure { get; set; }

        /// <summary>
        /// Gets or Sets Passive
        /// </summary>
        [DataMember(Name = "passive", EmitDefaultValue = true)]
        public bool Passive { get; set; }

        /// <summary>
        /// Gets or Sets ValidateConnection
        /// </summary>
        [DataMember(Name = "validateConnection", EmitDefaultValue = true)]
        public bool ValidateConnection { get; set; }

        /// <summary>
        /// Gets or Sets OutputAppend
        /// </summary>
        [DataMember(Name = "outputAppend", EmitDefaultValue = true)]
        public bool OutputAppend { get; set; }

        /// <summary>
        /// Gets or Sets ErrorOnExists
        /// </summary>
        [DataMember(Name = "errorOnExists", EmitDefaultValue = true)]
        public bool ErrorOnExists { get; set; }

        /// <summary>
        /// Gets or Sets Temporary
        /// </summary>
        [DataMember(Name = "temporary", EmitDefaultValue = true)]
        public bool Temporary { get; set; }

        /// <summary>
        /// Gets or Sets Binary
        /// </summary>
        [DataMember(Name = "binary", EmitDefaultValue = true)]
        public bool Binary { get; set; }

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
            sb.Append("class FileDispatcherProperties {\n");
            sb.Append("  PluginProperties: ").Append(PluginProperties).Append("\n");
            sb.Append("  DestinationConnectorProperties: ").Append(DestinationConnectorProperties).Append("\n");
            sb.Append("  Scheme: ").Append(Scheme).Append("\n");
            sb.Append("  SchemeProperties: ").Append(SchemeProperties).Append("\n");
            sb.Append("  Host: ").Append(Host).Append("\n");
            sb.Append("  OutputPattern: ").Append(OutputPattern).Append("\n");
            sb.Append("  Anonymous: ").Append(Anonymous).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Timeout: ").Append(Timeout).Append("\n");
            sb.Append("  KeepConnectionOpen: ").Append(KeepConnectionOpen).Append("\n");
            sb.Append("  MaxIdleTime: ").Append(MaxIdleTime).Append("\n");
            sb.Append("  Secure: ").Append(Secure).Append("\n");
            sb.Append("  Passive: ").Append(Passive).Append("\n");
            sb.Append("  ValidateConnection: ").Append(ValidateConnection).Append("\n");
            sb.Append("  OutputAppend: ").Append(OutputAppend).Append("\n");
            sb.Append("  ErrorOnExists: ").Append(ErrorOnExists).Append("\n");
            sb.Append("  Temporary: ").Append(Temporary).Append("\n");
            sb.Append("  Binary: ").Append(Binary).Append("\n");
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
            return this.Equals(input as FileDispatcherProperties);
        }

        /// <summary>
        /// Returns true if FileDispatcherProperties instances are equal
        /// </summary>
        /// <param name="input">Instance of FileDispatcherProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FileDispatcherProperties input)
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
                    this.Scheme == input.Scheme ||
                    this.Scheme.Equals(input.Scheme)
                ) && 
                (
                    this.SchemeProperties == input.SchemeProperties ||
                    (this.SchemeProperties != null &&
                    this.SchemeProperties.Equals(input.SchemeProperties))
                ) && 
                (
                    this.Host == input.Host ||
                    (this.Host != null &&
                    this.Host.Equals(input.Host))
                ) && 
                (
                    this.OutputPattern == input.OutputPattern ||
                    (this.OutputPattern != null &&
                    this.OutputPattern.Equals(input.OutputPattern))
                ) && 
                (
                    this.Anonymous == input.Anonymous ||
                    this.Anonymous.Equals(input.Anonymous)
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.Timeout == input.Timeout ||
                    (this.Timeout != null &&
                    this.Timeout.Equals(input.Timeout))
                ) && 
                (
                    this.KeepConnectionOpen == input.KeepConnectionOpen ||
                    this.KeepConnectionOpen.Equals(input.KeepConnectionOpen)
                ) && 
                (
                    this.MaxIdleTime == input.MaxIdleTime ||
                    (this.MaxIdleTime != null &&
                    this.MaxIdleTime.Equals(input.MaxIdleTime))
                ) && 
                (
                    this.Secure == input.Secure ||
                    this.Secure.Equals(input.Secure)
                ) && 
                (
                    this.Passive == input.Passive ||
                    this.Passive.Equals(input.Passive)
                ) && 
                (
                    this.ValidateConnection == input.ValidateConnection ||
                    this.ValidateConnection.Equals(input.ValidateConnection)
                ) && 
                (
                    this.OutputAppend == input.OutputAppend ||
                    this.OutputAppend.Equals(input.OutputAppend)
                ) && 
                (
                    this.ErrorOnExists == input.ErrorOnExists ||
                    this.ErrorOnExists.Equals(input.ErrorOnExists)
                ) && 
                (
                    this.Temporary == input.Temporary ||
                    this.Temporary.Equals(input.Temporary)
                ) && 
                (
                    this.Binary == input.Binary ||
                    this.Binary.Equals(input.Binary)
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
                hashCode = (hashCode * 59) + this.Scheme.GetHashCode();
                if (this.SchemeProperties != null)
                {
                    hashCode = (hashCode * 59) + this.SchemeProperties.GetHashCode();
                }
                if (this.Host != null)
                {
                    hashCode = (hashCode * 59) + this.Host.GetHashCode();
                }
                if (this.OutputPattern != null)
                {
                    hashCode = (hashCode * 59) + this.OutputPattern.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Anonymous.GetHashCode();
                if (this.Username != null)
                {
                    hashCode = (hashCode * 59) + this.Username.GetHashCode();
                }
                if (this.Password != null)
                {
                    hashCode = (hashCode * 59) + this.Password.GetHashCode();
                }
                if (this.Timeout != null)
                {
                    hashCode = (hashCode * 59) + this.Timeout.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.KeepConnectionOpen.GetHashCode();
                if (this.MaxIdleTime != null)
                {
                    hashCode = (hashCode * 59) + this.MaxIdleTime.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Secure.GetHashCode();
                hashCode = (hashCode * 59) + this.Passive.GetHashCode();
                hashCode = (hashCode * 59) + this.ValidateConnection.GetHashCode();
                hashCode = (hashCode * 59) + this.OutputAppend.GetHashCode();
                hashCode = (hashCode * 59) + this.ErrorOnExists.GetHashCode();
                hashCode = (hashCode * 59) + this.Temporary.GetHashCode();
                hashCode = (hashCode * 59) + this.Binary.GetHashCode();
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