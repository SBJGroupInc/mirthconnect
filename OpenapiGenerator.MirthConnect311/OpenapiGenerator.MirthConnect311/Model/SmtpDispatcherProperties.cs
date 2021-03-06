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
    /// SmtpDispatcherProperties
    /// </summary>
    [DataContract(Name = "SmtpDispatcherProperties")]
    public partial class SmtpDispatcherProperties : IEquatable<SmtpDispatcherProperties>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SmtpDispatcherProperties" /> class.
        /// </summary>
        /// <param name="pluginProperties">pluginProperties.</param>
        /// <param name="destinationConnectorProperties">destinationConnectorProperties.</param>
        /// <param name="smtpHost">smtpHost.</param>
        /// <param name="smtpPort">smtpPort.</param>
        /// <param name="overrideLocalBinding">overrideLocalBinding.</param>
        /// <param name="localAddress">localAddress.</param>
        /// <param name="localPort">localPort.</param>
        /// <param name="timeout">timeout.</param>
        /// <param name="encryption">encryption.</param>
        /// <param name="authentication">authentication.</param>
        /// <param name="username">username.</param>
        /// <param name="password">password.</param>
        /// <param name="to">to.</param>
        /// <param name="from">from.</param>
        /// <param name="cc">cc.</param>
        /// <param name="bcc">bcc.</param>
        /// <param name="replyTo">replyTo.</param>
        /// <param name="headersVariable">headersVariable.</param>
        /// <param name="subject">subject.</param>
        /// <param name="charsetEncoding">charsetEncoding.</param>
        /// <param name="html">html.</param>
        /// <param name="body">body.</param>
        /// <param name="attachmentsVariable">attachmentsVariable.</param>
        /// <param name="name">name.</param>
        /// <param name="protocol">protocol.</param>
        /// <param name="purgedProperties">purgedProperties.</param>
        /// <param name="useHeadersVariable">useHeadersVariable.</param>
        /// <param name="useAttachmentsVariable">useAttachmentsVariable.</param>
        /// <param name="headersMap">headersMap.</param>
        /// <param name="attachmentsList">attachmentsList.</param>
        public SmtpDispatcherProperties(List<ConnectorPluginProperties> pluginProperties = default(List<ConnectorPluginProperties>), DestinationConnectorProperties destinationConnectorProperties = default(DestinationConnectorProperties), string smtpHost = default(string), string smtpPort = default(string), bool overrideLocalBinding = default(bool), string localAddress = default(string), string localPort = default(string), string timeout = default(string), string encryption = default(string), bool authentication = default(bool), string username = default(string), string password = default(string), string to = default(string), string from = default(string), string cc = default(string), string bcc = default(string), string replyTo = default(string), string headersVariable = default(string), string subject = default(string), string charsetEncoding = default(string), bool html = default(bool), string body = default(string), string attachmentsVariable = default(string), string name = default(string), string protocol = default(string), Dictionary<string, Object> purgedProperties = default(Dictionary<string, Object>), bool useHeadersVariable = default(bool), bool useAttachmentsVariable = default(bool), Dictionary<string, string> headersMap = default(Dictionary<string, string>), List<Attachment> attachmentsList = default(List<Attachment>))
        {
            this.PluginProperties = pluginProperties;
            this.DestinationConnectorProperties = destinationConnectorProperties;
            this.SmtpHost = smtpHost;
            this.SmtpPort = smtpPort;
            this.OverrideLocalBinding = overrideLocalBinding;
            this.LocalAddress = localAddress;
            this.LocalPort = localPort;
            this.Timeout = timeout;
            this.Encryption = encryption;
            this.Authentication = authentication;
            this.Username = username;
            this.Password = password;
            this.To = to;
            this.From = from;
            this.Cc = cc;
            this.Bcc = bcc;
            this.ReplyTo = replyTo;
            this.HeadersVariable = headersVariable;
            this.Subject = subject;
            this.CharsetEncoding = charsetEncoding;
            this.Html = html;
            this.Body = body;
            this.AttachmentsVariable = attachmentsVariable;
            this.Name = name;
            this.Protocol = protocol;
            this.PurgedProperties = purgedProperties;
            this.UseHeadersVariable = useHeadersVariable;
            this.UseAttachmentsVariable = useAttachmentsVariable;
            this.HeadersMap = headersMap;
            this.AttachmentsList = attachmentsList;
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
        /// Gets or Sets SmtpHost
        /// </summary>
        [DataMember(Name = "smtpHost", EmitDefaultValue = false)]
        public string SmtpHost { get; set; }

        /// <summary>
        /// Gets or Sets SmtpPort
        /// </summary>
        [DataMember(Name = "smtpPort", EmitDefaultValue = false)]
        public string SmtpPort { get; set; }

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
        /// Gets or Sets Timeout
        /// </summary>
        [DataMember(Name = "timeout", EmitDefaultValue = false)]
        public string Timeout { get; set; }

        /// <summary>
        /// Gets or Sets Encryption
        /// </summary>
        [DataMember(Name = "encryption", EmitDefaultValue = false)]
        public string Encryption { get; set; }

        /// <summary>
        /// Gets or Sets Authentication
        /// </summary>
        [DataMember(Name = "authentication", EmitDefaultValue = true)]
        public bool Authentication { get; set; }

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
        /// Gets or Sets To
        /// </summary>
        [DataMember(Name = "to", EmitDefaultValue = false)]
        public string To { get; set; }

        /// <summary>
        /// Gets or Sets From
        /// </summary>
        [DataMember(Name = "from", EmitDefaultValue = false)]
        public string From { get; set; }

        /// <summary>
        /// Gets or Sets Cc
        /// </summary>
        [DataMember(Name = "cc", EmitDefaultValue = false)]
        public string Cc { get; set; }

        /// <summary>
        /// Gets or Sets Bcc
        /// </summary>
        [DataMember(Name = "bcc", EmitDefaultValue = false)]
        public string Bcc { get; set; }

        /// <summary>
        /// Gets or Sets ReplyTo
        /// </summary>
        [DataMember(Name = "replyTo", EmitDefaultValue = false)]
        public string ReplyTo { get; set; }

        /// <summary>
        /// Gets or Sets HeadersVariable
        /// </summary>
        [DataMember(Name = "headersVariable", EmitDefaultValue = false)]
        public string HeadersVariable { get; set; }

        /// <summary>
        /// Gets or Sets Subject
        /// </summary>
        [DataMember(Name = "subject", EmitDefaultValue = false)]
        public string Subject { get; set; }

        /// <summary>
        /// Gets or Sets CharsetEncoding
        /// </summary>
        [DataMember(Name = "charsetEncoding", EmitDefaultValue = false)]
        public string CharsetEncoding { get; set; }

        /// <summary>
        /// Gets or Sets Html
        /// </summary>
        [DataMember(Name = "html", EmitDefaultValue = true)]
        public bool Html { get; set; }

        /// <summary>
        /// Gets or Sets Body
        /// </summary>
        [DataMember(Name = "body", EmitDefaultValue = false)]
        public string Body { get; set; }

        /// <summary>
        /// Gets or Sets AttachmentsVariable
        /// </summary>
        [DataMember(Name = "attachmentsVariable", EmitDefaultValue = false)]
        public string AttachmentsVariable { get; set; }

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
        /// Gets or Sets UseHeadersVariable
        /// </summary>
        [DataMember(Name = "useHeadersVariable", EmitDefaultValue = true)]
        public bool UseHeadersVariable { get; set; }

        /// <summary>
        /// Gets or Sets UseAttachmentsVariable
        /// </summary>
        [DataMember(Name = "useAttachmentsVariable", EmitDefaultValue = true)]
        public bool UseAttachmentsVariable { get; set; }

        /// <summary>
        /// Gets or Sets HeadersMap
        /// </summary>
        [DataMember(Name = "headersMap", EmitDefaultValue = false)]
        public Dictionary<string, string> HeadersMap { get; set; }

        /// <summary>
        /// Gets or Sets AttachmentsList
        /// </summary>
        [DataMember(Name = "attachmentsList", EmitDefaultValue = false)]
        public List<Attachment> AttachmentsList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SmtpDispatcherProperties {\n");
            sb.Append("  PluginProperties: ").Append(PluginProperties).Append("\n");
            sb.Append("  DestinationConnectorProperties: ").Append(DestinationConnectorProperties).Append("\n");
            sb.Append("  SmtpHost: ").Append(SmtpHost).Append("\n");
            sb.Append("  SmtpPort: ").Append(SmtpPort).Append("\n");
            sb.Append("  OverrideLocalBinding: ").Append(OverrideLocalBinding).Append("\n");
            sb.Append("  LocalAddress: ").Append(LocalAddress).Append("\n");
            sb.Append("  LocalPort: ").Append(LocalPort).Append("\n");
            sb.Append("  Timeout: ").Append(Timeout).Append("\n");
            sb.Append("  Encryption: ").Append(Encryption).Append("\n");
            sb.Append("  Authentication: ").Append(Authentication).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  Cc: ").Append(Cc).Append("\n");
            sb.Append("  Bcc: ").Append(Bcc).Append("\n");
            sb.Append("  ReplyTo: ").Append(ReplyTo).Append("\n");
            sb.Append("  HeadersVariable: ").Append(HeadersVariable).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  CharsetEncoding: ").Append(CharsetEncoding).Append("\n");
            sb.Append("  Html: ").Append(Html).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  AttachmentsVariable: ").Append(AttachmentsVariable).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Protocol: ").Append(Protocol).Append("\n");
            sb.Append("  PurgedProperties: ").Append(PurgedProperties).Append("\n");
            sb.Append("  UseHeadersVariable: ").Append(UseHeadersVariable).Append("\n");
            sb.Append("  UseAttachmentsVariable: ").Append(UseAttachmentsVariable).Append("\n");
            sb.Append("  HeadersMap: ").Append(HeadersMap).Append("\n");
            sb.Append("  AttachmentsList: ").Append(AttachmentsList).Append("\n");
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
            return this.Equals(input as SmtpDispatcherProperties);
        }

        /// <summary>
        /// Returns true if SmtpDispatcherProperties instances are equal
        /// </summary>
        /// <param name="input">Instance of SmtpDispatcherProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SmtpDispatcherProperties input)
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
                    this.SmtpHost == input.SmtpHost ||
                    (this.SmtpHost != null &&
                    this.SmtpHost.Equals(input.SmtpHost))
                ) && 
                (
                    this.SmtpPort == input.SmtpPort ||
                    (this.SmtpPort != null &&
                    this.SmtpPort.Equals(input.SmtpPort))
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
                    this.Timeout == input.Timeout ||
                    (this.Timeout != null &&
                    this.Timeout.Equals(input.Timeout))
                ) && 
                (
                    this.Encryption == input.Encryption ||
                    (this.Encryption != null &&
                    this.Encryption.Equals(input.Encryption))
                ) && 
                (
                    this.Authentication == input.Authentication ||
                    this.Authentication.Equals(input.Authentication)
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
                    this.To == input.To ||
                    (this.To != null &&
                    this.To.Equals(input.To))
                ) && 
                (
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
                ) && 
                (
                    this.Cc == input.Cc ||
                    (this.Cc != null &&
                    this.Cc.Equals(input.Cc))
                ) && 
                (
                    this.Bcc == input.Bcc ||
                    (this.Bcc != null &&
                    this.Bcc.Equals(input.Bcc))
                ) && 
                (
                    this.ReplyTo == input.ReplyTo ||
                    (this.ReplyTo != null &&
                    this.ReplyTo.Equals(input.ReplyTo))
                ) && 
                (
                    this.HeadersVariable == input.HeadersVariable ||
                    (this.HeadersVariable != null &&
                    this.HeadersVariable.Equals(input.HeadersVariable))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.CharsetEncoding == input.CharsetEncoding ||
                    (this.CharsetEncoding != null &&
                    this.CharsetEncoding.Equals(input.CharsetEncoding))
                ) && 
                (
                    this.Html == input.Html ||
                    this.Html.Equals(input.Html)
                ) && 
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
                ) && 
                (
                    this.AttachmentsVariable == input.AttachmentsVariable ||
                    (this.AttachmentsVariable != null &&
                    this.AttachmentsVariable.Equals(input.AttachmentsVariable))
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
                ) && 
                (
                    this.UseHeadersVariable == input.UseHeadersVariable ||
                    this.UseHeadersVariable.Equals(input.UseHeadersVariable)
                ) && 
                (
                    this.UseAttachmentsVariable == input.UseAttachmentsVariable ||
                    this.UseAttachmentsVariable.Equals(input.UseAttachmentsVariable)
                ) && 
                (
                    this.HeadersMap == input.HeadersMap ||
                    this.HeadersMap != null &&
                    input.HeadersMap != null &&
                    this.HeadersMap.SequenceEqual(input.HeadersMap)
                ) && 
                (
                    this.AttachmentsList == input.AttachmentsList ||
                    this.AttachmentsList != null &&
                    input.AttachmentsList != null &&
                    this.AttachmentsList.SequenceEqual(input.AttachmentsList)
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
                if (this.SmtpHost != null)
                {
                    hashCode = (hashCode * 59) + this.SmtpHost.GetHashCode();
                }
                if (this.SmtpPort != null)
                {
                    hashCode = (hashCode * 59) + this.SmtpPort.GetHashCode();
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
                if (this.Timeout != null)
                {
                    hashCode = (hashCode * 59) + this.Timeout.GetHashCode();
                }
                if (this.Encryption != null)
                {
                    hashCode = (hashCode * 59) + this.Encryption.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Authentication.GetHashCode();
                if (this.Username != null)
                {
                    hashCode = (hashCode * 59) + this.Username.GetHashCode();
                }
                if (this.Password != null)
                {
                    hashCode = (hashCode * 59) + this.Password.GetHashCode();
                }
                if (this.To != null)
                {
                    hashCode = (hashCode * 59) + this.To.GetHashCode();
                }
                if (this.From != null)
                {
                    hashCode = (hashCode * 59) + this.From.GetHashCode();
                }
                if (this.Cc != null)
                {
                    hashCode = (hashCode * 59) + this.Cc.GetHashCode();
                }
                if (this.Bcc != null)
                {
                    hashCode = (hashCode * 59) + this.Bcc.GetHashCode();
                }
                if (this.ReplyTo != null)
                {
                    hashCode = (hashCode * 59) + this.ReplyTo.GetHashCode();
                }
                if (this.HeadersVariable != null)
                {
                    hashCode = (hashCode * 59) + this.HeadersVariable.GetHashCode();
                }
                if (this.Subject != null)
                {
                    hashCode = (hashCode * 59) + this.Subject.GetHashCode();
                }
                if (this.CharsetEncoding != null)
                {
                    hashCode = (hashCode * 59) + this.CharsetEncoding.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Html.GetHashCode();
                if (this.Body != null)
                {
                    hashCode = (hashCode * 59) + this.Body.GetHashCode();
                }
                if (this.AttachmentsVariable != null)
                {
                    hashCode = (hashCode * 59) + this.AttachmentsVariable.GetHashCode();
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
                hashCode = (hashCode * 59) + this.UseHeadersVariable.GetHashCode();
                hashCode = (hashCode * 59) + this.UseAttachmentsVariable.GetHashCode();
                if (this.HeadersMap != null)
                {
                    hashCode = (hashCode * 59) + this.HeadersMap.GetHashCode();
                }
                if (this.AttachmentsList != null)
                {
                    hashCode = (hashCode * 59) + this.AttachmentsList.GetHashCode();
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
