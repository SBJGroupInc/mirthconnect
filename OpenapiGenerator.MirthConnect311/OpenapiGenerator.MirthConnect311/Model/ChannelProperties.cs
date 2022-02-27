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
    /// ChannelProperties
    /// </summary>
    [DataContract(Name = "ChannelProperties")]
    public partial class ChannelProperties : IEquatable<ChannelProperties>, IValidatableObject
    {
        /// <summary>
        /// Defines MessageStorageMode
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MessageStorageModeEnum
        {
            /// <summary>
            /// Enum DEVELOPMENT for value: DEVELOPMENT
            /// </summary>
            [EnumMember(Value = "DEVELOPMENT")]
            DEVELOPMENT = 1,

            /// <summary>
            /// Enum PRODUCTION for value: PRODUCTION
            /// </summary>
            [EnumMember(Value = "PRODUCTION")]
            PRODUCTION = 2,

            /// <summary>
            /// Enum RAW for value: RAW
            /// </summary>
            [EnumMember(Value = "RAW")]
            RAW = 3,

            /// <summary>
            /// Enum METADATA for value: METADATA
            /// </summary>
            [EnumMember(Value = "METADATA")]
            METADATA = 4,

            /// <summary>
            /// Enum DISABLED for value: DISABLED
            /// </summary>
            [EnumMember(Value = "DISABLED")]
            DISABLED = 5

        }


        /// <summary>
        /// Gets or Sets MessageStorageMode
        /// </summary>
        [DataMember(Name = "messageStorageMode", EmitDefaultValue = false)]
        public MessageStorageModeEnum? MessageStorageMode { get; set; }
        /// <summary>
        /// Defines InitialState
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum InitialStateEnum
        {
            /// <summary>
            /// Enum Undeployed for value: Undeployed
            /// </summary>
            [EnumMember(Value = "Undeployed")]
            Undeployed = 1,

            /// <summary>
            /// Enum Deploying for value: Deploying
            /// </summary>
            [EnumMember(Value = "Deploying")]
            Deploying = 2,

            /// <summary>
            /// Enum Undeploying for value: Undeploying
            /// </summary>
            [EnumMember(Value = "Undeploying")]
            Undeploying = 3,

            /// <summary>
            /// Enum Starting for value: Starting
            /// </summary>
            [EnumMember(Value = "Starting")]
            Starting = 4,

            /// <summary>
            /// Enum Started for value: Started
            /// </summary>
            [EnumMember(Value = "Started")]
            Started = 5,

            /// <summary>
            /// Enum Pausing for value: Pausing
            /// </summary>
            [EnumMember(Value = "Pausing")]
            Pausing = 6,

            /// <summary>
            /// Enum Paused for value: Paused
            /// </summary>
            [EnumMember(Value = "Paused")]
            Paused = 7,

            /// <summary>
            /// Enum Stopping for value: Stopping
            /// </summary>
            [EnumMember(Value = "Stopping")]
            Stopping = 8,

            /// <summary>
            /// Enum Stopped for value: Stopped
            /// </summary>
            [EnumMember(Value = "Stopped")]
            Stopped = 9,

            /// <summary>
            /// Enum Syncing for value: Syncing
            /// </summary>
            [EnumMember(Value = "Syncing")]
            Syncing = 10,

            /// <summary>
            /// Enum Unknown for value: Unknown
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown = 11

        }


        /// <summary>
        /// Gets or Sets InitialState
        /// </summary>
        [DataMember(Name = "initialState", EmitDefaultValue = false)]
        public InitialStateEnum? InitialState { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelProperties" /> class.
        /// </summary>
        /// <param name="clearGlobalChannelMap">clearGlobalChannelMap.</param>
        /// <param name="messageStorageMode">messageStorageMode.</param>
        /// <param name="encryptData">encryptData.</param>
        /// <param name="removeContentOnCompletion">removeContentOnCompletion.</param>
        /// <param name="removeOnlyFilteredOnCompletion">removeOnlyFilteredOnCompletion.</param>
        /// <param name="removeAttachmentsOnCompletion">removeAttachmentsOnCompletion.</param>
        /// <param name="initialState">initialState.</param>
        /// <param name="storeAttachments">storeAttachments.</param>
        /// <param name="metaDataColumns">metaDataColumns.</param>
        /// <param name="attachmentProperties">attachmentProperties.</param>
        /// <param name="resourceIds">resourceIds.</param>
        /// <param name="purgedProperties">purgedProperties.</param>
        public ChannelProperties(bool clearGlobalChannelMap = default(bool), MessageStorageModeEnum? messageStorageMode = default(MessageStorageModeEnum?), bool encryptData = default(bool), bool removeContentOnCompletion = default(bool), bool removeOnlyFilteredOnCompletion = default(bool), bool removeAttachmentsOnCompletion = default(bool), InitialStateEnum? initialState = default(InitialStateEnum?), bool storeAttachments = default(bool), List<MetaDataColumn> metaDataColumns = default(List<MetaDataColumn>), AttachmentHandlerProperties attachmentProperties = default(AttachmentHandlerProperties), Dictionary<string, string> resourceIds = default(Dictionary<string, string>), Dictionary<string, Object> purgedProperties = default(Dictionary<string, Object>))
        {
            this.ClearGlobalChannelMap = clearGlobalChannelMap;
            this.MessageStorageMode = messageStorageMode;
            this.EncryptData = encryptData;
            this.RemoveContentOnCompletion = removeContentOnCompletion;
            this.RemoveOnlyFilteredOnCompletion = removeOnlyFilteredOnCompletion;
            this.RemoveAttachmentsOnCompletion = removeAttachmentsOnCompletion;
            this.InitialState = initialState;
            this.StoreAttachments = storeAttachments;
            this.MetaDataColumns = metaDataColumns;
            this.AttachmentProperties = attachmentProperties;
            this.ResourceIds = resourceIds;
            this.PurgedProperties = purgedProperties;
        }

        /// <summary>
        /// Gets or Sets ClearGlobalChannelMap
        /// </summary>
        [DataMember(Name = "clearGlobalChannelMap", EmitDefaultValue = true)]
        public bool ClearGlobalChannelMap { get; set; }

        /// <summary>
        /// Gets or Sets EncryptData
        /// </summary>
        [DataMember(Name = "encryptData", EmitDefaultValue = true)]
        public bool EncryptData { get; set; }

        /// <summary>
        /// Gets or Sets RemoveContentOnCompletion
        /// </summary>
        [DataMember(Name = "removeContentOnCompletion", EmitDefaultValue = true)]
        public bool RemoveContentOnCompletion { get; set; }

        /// <summary>
        /// Gets or Sets RemoveOnlyFilteredOnCompletion
        /// </summary>
        [DataMember(Name = "removeOnlyFilteredOnCompletion", EmitDefaultValue = true)]
        public bool RemoveOnlyFilteredOnCompletion { get; set; }

        /// <summary>
        /// Gets or Sets RemoveAttachmentsOnCompletion
        /// </summary>
        [DataMember(Name = "removeAttachmentsOnCompletion", EmitDefaultValue = true)]
        public bool RemoveAttachmentsOnCompletion { get; set; }

        /// <summary>
        /// Gets or Sets StoreAttachments
        /// </summary>
        [DataMember(Name = "storeAttachments", EmitDefaultValue = true)]
        public bool StoreAttachments { get; set; }

        /// <summary>
        /// Gets or Sets MetaDataColumns
        /// </summary>
        [DataMember(Name = "metaDataColumns", EmitDefaultValue = false)]
        public List<MetaDataColumn> MetaDataColumns { get; set; }

        /// <summary>
        /// Gets or Sets AttachmentProperties
        /// </summary>
        [DataMember(Name = "attachmentProperties", EmitDefaultValue = false)]
        public AttachmentHandlerProperties AttachmentProperties { get; set; }

        /// <summary>
        /// Gets or Sets ResourceIds
        /// </summary>
        [DataMember(Name = "resourceIds", EmitDefaultValue = false)]
        public Dictionary<string, string> ResourceIds { get; set; }

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
            sb.Append("class ChannelProperties {\n");
            sb.Append("  ClearGlobalChannelMap: ").Append(ClearGlobalChannelMap).Append("\n");
            sb.Append("  MessageStorageMode: ").Append(MessageStorageMode).Append("\n");
            sb.Append("  EncryptData: ").Append(EncryptData).Append("\n");
            sb.Append("  RemoveContentOnCompletion: ").Append(RemoveContentOnCompletion).Append("\n");
            sb.Append("  RemoveOnlyFilteredOnCompletion: ").Append(RemoveOnlyFilteredOnCompletion).Append("\n");
            sb.Append("  RemoveAttachmentsOnCompletion: ").Append(RemoveAttachmentsOnCompletion).Append("\n");
            sb.Append("  InitialState: ").Append(InitialState).Append("\n");
            sb.Append("  StoreAttachments: ").Append(StoreAttachments).Append("\n");
            sb.Append("  MetaDataColumns: ").Append(MetaDataColumns).Append("\n");
            sb.Append("  AttachmentProperties: ").Append(AttachmentProperties).Append("\n");
            sb.Append("  ResourceIds: ").Append(ResourceIds).Append("\n");
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
            return this.Equals(input as ChannelProperties);
        }

        /// <summary>
        /// Returns true if ChannelProperties instances are equal
        /// </summary>
        /// <param name="input">Instance of ChannelProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChannelProperties input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ClearGlobalChannelMap == input.ClearGlobalChannelMap ||
                    this.ClearGlobalChannelMap.Equals(input.ClearGlobalChannelMap)
                ) && 
                (
                    this.MessageStorageMode == input.MessageStorageMode ||
                    this.MessageStorageMode.Equals(input.MessageStorageMode)
                ) && 
                (
                    this.EncryptData == input.EncryptData ||
                    this.EncryptData.Equals(input.EncryptData)
                ) && 
                (
                    this.RemoveContentOnCompletion == input.RemoveContentOnCompletion ||
                    this.RemoveContentOnCompletion.Equals(input.RemoveContentOnCompletion)
                ) && 
                (
                    this.RemoveOnlyFilteredOnCompletion == input.RemoveOnlyFilteredOnCompletion ||
                    this.RemoveOnlyFilteredOnCompletion.Equals(input.RemoveOnlyFilteredOnCompletion)
                ) && 
                (
                    this.RemoveAttachmentsOnCompletion == input.RemoveAttachmentsOnCompletion ||
                    this.RemoveAttachmentsOnCompletion.Equals(input.RemoveAttachmentsOnCompletion)
                ) && 
                (
                    this.InitialState == input.InitialState ||
                    this.InitialState.Equals(input.InitialState)
                ) && 
                (
                    this.StoreAttachments == input.StoreAttachments ||
                    this.StoreAttachments.Equals(input.StoreAttachments)
                ) && 
                (
                    this.MetaDataColumns == input.MetaDataColumns ||
                    this.MetaDataColumns != null &&
                    input.MetaDataColumns != null &&
                    this.MetaDataColumns.SequenceEqual(input.MetaDataColumns)
                ) && 
                (
                    this.AttachmentProperties == input.AttachmentProperties ||
                    (this.AttachmentProperties != null &&
                    this.AttachmentProperties.Equals(input.AttachmentProperties))
                ) && 
                (
                    this.ResourceIds == input.ResourceIds ||
                    this.ResourceIds != null &&
                    input.ResourceIds != null &&
                    this.ResourceIds.SequenceEqual(input.ResourceIds)
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
                hashCode = (hashCode * 59) + this.ClearGlobalChannelMap.GetHashCode();
                hashCode = (hashCode * 59) + this.MessageStorageMode.GetHashCode();
                hashCode = (hashCode * 59) + this.EncryptData.GetHashCode();
                hashCode = (hashCode * 59) + this.RemoveContentOnCompletion.GetHashCode();
                hashCode = (hashCode * 59) + this.RemoveOnlyFilteredOnCompletion.GetHashCode();
                hashCode = (hashCode * 59) + this.RemoveAttachmentsOnCompletion.GetHashCode();
                hashCode = (hashCode * 59) + this.InitialState.GetHashCode();
                hashCode = (hashCode * 59) + this.StoreAttachments.GetHashCode();
                if (this.MetaDataColumns != null)
                {
                    hashCode = (hashCode * 59) + this.MetaDataColumns.GetHashCode();
                }
                if (this.AttachmentProperties != null)
                {
                    hashCode = (hashCode * 59) + this.AttachmentProperties.GetHashCode();
                }
                if (this.ResourceIds != null)
                {
                    hashCode = (hashCode * 59) + this.ResourceIds.GetHashCode();
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