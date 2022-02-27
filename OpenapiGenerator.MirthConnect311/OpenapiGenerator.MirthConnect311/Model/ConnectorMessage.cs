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
    /// ConnectorMessage
    /// </summary>
    [DataContract(Name = "ConnectorMessage")]
    public partial class ConnectorMessage : IEquatable<ConnectorMessage>, IValidatableObject
    {
        /// <summary>
        /// Defines Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum RECEIVED for value: RECEIVED
            /// </summary>
            [EnumMember(Value = "RECEIVED")]
            RECEIVED = 1,

            /// <summary>
            /// Enum FILTERED for value: FILTERED
            /// </summary>
            [EnumMember(Value = "FILTERED")]
            FILTERED = 2,

            /// <summary>
            /// Enum TRANSFORMED for value: TRANSFORMED
            /// </summary>
            [EnumMember(Value = "TRANSFORMED")]
            TRANSFORMED = 3,

            /// <summary>
            /// Enum SENT for value: SENT
            /// </summary>
            [EnumMember(Value = "SENT")]
            SENT = 4,

            /// <summary>
            /// Enum QUEUED for value: QUEUED
            /// </summary>
            [EnumMember(Value = "QUEUED")]
            QUEUED = 5,

            /// <summary>
            /// Enum ERROR for value: ERROR
            /// </summary>
            [EnumMember(Value = "ERROR")]
            ERROR = 6,

            /// <summary>
            /// Enum PENDING for value: PENDING
            /// </summary>
            [EnumMember(Value = "PENDING")]
            PENDING = 7

        }


        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectorMessage" /> class.
        /// </summary>
        /// <param name="messageId">messageId.</param>
        /// <param name="metaDataId">metaDataId.</param>
        /// <param name="channelId">channelId.</param>
        /// <param name="channelName">channelName.</param>
        /// <param name="connectorName">connectorName.</param>
        /// <param name="serverId">serverId.</param>
        /// <param name="receivedDate">receivedDate.</param>
        /// <param name="status">status.</param>
        /// <param name="raw">raw.</param>
        /// <param name="processedRaw">processedRaw.</param>
        /// <param name="transformed">transformed.</param>
        /// <param name="encoded">encoded.</param>
        /// <param name="sent">sent.</param>
        /// <param name="response">response.</param>
        /// <param name="responseTransformed">responseTransformed.</param>
        /// <param name="processedResponse">processedResponse.</param>
        /// <param name="sourceMapContent">sourceMapContent.</param>
        /// <param name="connectorMapContent">connectorMapContent.</param>
        /// <param name="channelMapContent">channelMapContent.</param>
        /// <param name="responseMapContent">responseMapContent.</param>
        /// <param name="metaDataMap">metaDataMap.</param>
        /// <param name="processingErrorContent">processingErrorContent.</param>
        /// <param name="postProcessorErrorContent">postProcessorErrorContent.</param>
        /// <param name="responseErrorContent">responseErrorContent.</param>
        /// <param name="errorCode">errorCode.</param>
        /// <param name="sendAttempts">sendAttempts.</param>
        /// <param name="sendDate">sendDate.</param>
        /// <param name="responseDate">responseDate.</param>
        /// <param name="chainId">chainId.</param>
        /// <param name="orderId">orderId.</param>
        /// <param name="sentProperties">sentProperties.</param>
        /// <param name="queueBucket">queueBucket.</param>
        /// <param name="attemptedFirst">attemptedFirst.</param>
        /// <param name="dispatcherId">dispatcherId.</param>
        /// <param name="messageContent">messageContent.</param>
        /// <param name="sourceMap">sourceMap.</param>
        /// <param name="connectorMap">connectorMap.</param>
        /// <param name="channelMap">channelMap.</param>
        /// <param name="responseMap">responseMap.</param>
        /// <param name="responseError">responseError.</param>
        /// <param name="processingError">processingError.</param>
        /// <param name="postProcessorError">postProcessorError.</param>
        public ConnectorMessage(long messageId = default(long), int metaDataId = default(int), string channelId = default(string), string channelName = default(string), string connectorName = default(string), string serverId = default(string), DateTime receivedDate = default(DateTime), StatusEnum? status = default(StatusEnum?), MessageContent raw = default(MessageContent), MessageContent processedRaw = default(MessageContent), MessageContent transformed = default(MessageContent), MessageContent encoded = default(MessageContent), MessageContent sent = default(MessageContent), MessageContent response = default(MessageContent), MessageContent responseTransformed = default(MessageContent), MessageContent processedResponse = default(MessageContent), MapContent sourceMapContent = default(MapContent), MapContent connectorMapContent = default(MapContent), MapContent channelMapContent = default(MapContent), MapContent responseMapContent = default(MapContent), Dictionary<string, Object> metaDataMap = default(Dictionary<string, Object>), ErrorContent processingErrorContent = default(ErrorContent), ErrorContent postProcessorErrorContent = default(ErrorContent), ErrorContent responseErrorContent = default(ErrorContent), int errorCode = default(int), int sendAttempts = default(int), DateTime sendDate = default(DateTime), DateTime responseDate = default(DateTime), int chainId = default(int), int orderId = default(int), ConnectorProperties sentProperties = default(ConnectorProperties), int queueBucket = default(int), bool attemptedFirst = default(bool), long dispatcherId = default(long), MessageContent messageContent = default(MessageContent), Dictionary<string, Object> sourceMap = default(Dictionary<string, Object>), Dictionary<string, Object> connectorMap = default(Dictionary<string, Object>), Dictionary<string, Object> channelMap = default(Dictionary<string, Object>), Dictionary<string, Object> responseMap = default(Dictionary<string, Object>), string responseError = default(string), string processingError = default(string), string postProcessorError = default(string))
        {
            this.MessageId = messageId;
            this.MetaDataId = metaDataId;
            this.ChannelId = channelId;
            this.ChannelName = channelName;
            this.ConnectorName = connectorName;
            this.ServerId = serverId;
            this.ReceivedDate = receivedDate;
            this.Status = status;
            this.Raw = raw;
            this.ProcessedRaw = processedRaw;
            this.Transformed = transformed;
            this.Encoded = encoded;
            this.Sent = sent;
            this.Response = response;
            this.ResponseTransformed = responseTransformed;
            this.ProcessedResponse = processedResponse;
            this.SourceMapContent = sourceMapContent;
            this.ConnectorMapContent = connectorMapContent;
            this.ChannelMapContent = channelMapContent;
            this.ResponseMapContent = responseMapContent;
            this.MetaDataMap = metaDataMap;
            this.ProcessingErrorContent = processingErrorContent;
            this.PostProcessorErrorContent = postProcessorErrorContent;
            this.ResponseErrorContent = responseErrorContent;
            this.ErrorCode = errorCode;
            this.SendAttempts = sendAttempts;
            this.SendDate = sendDate;
            this.ResponseDate = responseDate;
            this.ChainId = chainId;
            this.OrderId = orderId;
            this.SentProperties = sentProperties;
            this.QueueBucket = queueBucket;
            this.AttemptedFirst = attemptedFirst;
            this.DispatcherId = dispatcherId;
            this.MessageContent = messageContent;
            this.SourceMap = sourceMap;
            this.ConnectorMap = connectorMap;
            this.ChannelMap = channelMap;
            this.ResponseMap = responseMap;
            this.ResponseError = responseError;
            this.ProcessingError = processingError;
            this.PostProcessorError = postProcessorError;
        }

        /// <summary>
        /// Gets or Sets MessageId
        /// </summary>
        [DataMember(Name = "messageId", EmitDefaultValue = false)]
        public long MessageId { get; set; }

        /// <summary>
        /// Gets or Sets MetaDataId
        /// </summary>
        [DataMember(Name = "metaDataId", EmitDefaultValue = false)]
        public int MetaDataId { get; set; }

        /// <summary>
        /// Gets or Sets ChannelId
        /// </summary>
        [DataMember(Name = "channelId", EmitDefaultValue = false)]
        public string ChannelId { get; set; }

        /// <summary>
        /// Gets or Sets ChannelName
        /// </summary>
        [DataMember(Name = "channelName", EmitDefaultValue = false)]
        public string ChannelName { get; set; }

        /// <summary>
        /// Gets or Sets ConnectorName
        /// </summary>
        [DataMember(Name = "connectorName", EmitDefaultValue = false)]
        public string ConnectorName { get; set; }

        /// <summary>
        /// Gets or Sets ServerId
        /// </summary>
        [DataMember(Name = "serverId", EmitDefaultValue = false)]
        public string ServerId { get; set; }

        /// <summary>
        /// Gets or Sets ReceivedDate
        /// </summary>
        [DataMember(Name = "receivedDate", EmitDefaultValue = false)]
        public DateTime ReceivedDate { get; set; }

        /// <summary>
        /// Gets or Sets Raw
        /// </summary>
        [DataMember(Name = "raw", EmitDefaultValue = false)]
        public MessageContent Raw { get; set; }

        /// <summary>
        /// Gets or Sets ProcessedRaw
        /// </summary>
        [DataMember(Name = "processedRaw", EmitDefaultValue = false)]
        public MessageContent ProcessedRaw { get; set; }

        /// <summary>
        /// Gets or Sets Transformed
        /// </summary>
        [DataMember(Name = "transformed", EmitDefaultValue = false)]
        public MessageContent Transformed { get; set; }

        /// <summary>
        /// Gets or Sets Encoded
        /// </summary>
        [DataMember(Name = "encoded", EmitDefaultValue = false)]
        public MessageContent Encoded { get; set; }

        /// <summary>
        /// Gets or Sets Sent
        /// </summary>
        [DataMember(Name = "sent", EmitDefaultValue = false)]
        public MessageContent Sent { get; set; }

        /// <summary>
        /// Gets or Sets Response
        /// </summary>
        [DataMember(Name = "response", EmitDefaultValue = false)]
        public MessageContent Response { get; set; }

        /// <summary>
        /// Gets or Sets ResponseTransformed
        /// </summary>
        [DataMember(Name = "responseTransformed", EmitDefaultValue = false)]
        public MessageContent ResponseTransformed { get; set; }

        /// <summary>
        /// Gets or Sets ProcessedResponse
        /// </summary>
        [DataMember(Name = "processedResponse", EmitDefaultValue = false)]
        public MessageContent ProcessedResponse { get; set; }

        /// <summary>
        /// Gets or Sets SourceMapContent
        /// </summary>
        [DataMember(Name = "sourceMapContent", EmitDefaultValue = false)]
        public MapContent SourceMapContent { get; set; }

        /// <summary>
        /// Gets or Sets ConnectorMapContent
        /// </summary>
        [DataMember(Name = "connectorMapContent", EmitDefaultValue = false)]
        public MapContent ConnectorMapContent { get; set; }

        /// <summary>
        /// Gets or Sets ChannelMapContent
        /// </summary>
        [DataMember(Name = "channelMapContent", EmitDefaultValue = false)]
        public MapContent ChannelMapContent { get; set; }

        /// <summary>
        /// Gets or Sets ResponseMapContent
        /// </summary>
        [DataMember(Name = "responseMapContent", EmitDefaultValue = false)]
        public MapContent ResponseMapContent { get; set; }

        /// <summary>
        /// Gets or Sets MetaDataMap
        /// </summary>
        [DataMember(Name = "metaDataMap", EmitDefaultValue = false)]
        public Dictionary<string, Object> MetaDataMap { get; set; }

        /// <summary>
        /// Gets or Sets ProcessingErrorContent
        /// </summary>
        [DataMember(Name = "processingErrorContent", EmitDefaultValue = false)]
        public ErrorContent ProcessingErrorContent { get; set; }

        /// <summary>
        /// Gets or Sets PostProcessorErrorContent
        /// </summary>
        [DataMember(Name = "postProcessorErrorContent", EmitDefaultValue = false)]
        public ErrorContent PostProcessorErrorContent { get; set; }

        /// <summary>
        /// Gets or Sets ResponseErrorContent
        /// </summary>
        [DataMember(Name = "responseErrorContent", EmitDefaultValue = false)]
        public ErrorContent ResponseErrorContent { get; set; }

        /// <summary>
        /// Gets or Sets ErrorCode
        /// </summary>
        [DataMember(Name = "errorCode", EmitDefaultValue = false)]
        public int ErrorCode { get; set; }

        /// <summary>
        /// Gets or Sets SendAttempts
        /// </summary>
        [DataMember(Name = "sendAttempts", EmitDefaultValue = false)]
        public int SendAttempts { get; set; }

        /// <summary>
        /// Gets or Sets SendDate
        /// </summary>
        [DataMember(Name = "sendDate", EmitDefaultValue = false)]
        public DateTime SendDate { get; set; }

        /// <summary>
        /// Gets or Sets ResponseDate
        /// </summary>
        [DataMember(Name = "responseDate", EmitDefaultValue = false)]
        public DateTime ResponseDate { get; set; }

        /// <summary>
        /// Gets or Sets ChainId
        /// </summary>
        [DataMember(Name = "chainId", EmitDefaultValue = false)]
        public int ChainId { get; set; }

        /// <summary>
        /// Gets or Sets OrderId
        /// </summary>
        [DataMember(Name = "orderId", EmitDefaultValue = false)]
        public int OrderId { get; set; }

        /// <summary>
        /// Gets or Sets SentProperties
        /// </summary>
        [DataMember(Name = "sentProperties", EmitDefaultValue = false)]
        public ConnectorProperties SentProperties { get; set; }

        /// <summary>
        /// Gets or Sets QueueBucket
        /// </summary>
        [DataMember(Name = "queueBucket", EmitDefaultValue = false)]
        public int QueueBucket { get; set; }

        /// <summary>
        /// Gets or Sets AttemptedFirst
        /// </summary>
        [DataMember(Name = "attemptedFirst", EmitDefaultValue = true)]
        public bool AttemptedFirst { get; set; }

        /// <summary>
        /// Gets or Sets DispatcherId
        /// </summary>
        [DataMember(Name = "dispatcherId", EmitDefaultValue = false)]
        public long DispatcherId { get; set; }

        /// <summary>
        /// Gets or Sets MessageContent
        /// </summary>
        [DataMember(Name = "messageContent", EmitDefaultValue = false)]
        public MessageContent MessageContent { get; set; }

        /// <summary>
        /// Gets or Sets SourceMap
        /// </summary>
        [DataMember(Name = "sourceMap", EmitDefaultValue = false)]
        public Dictionary<string, Object> SourceMap { get; set; }

        /// <summary>
        /// Gets or Sets ConnectorMap
        /// </summary>
        [DataMember(Name = "connectorMap", EmitDefaultValue = false)]
        public Dictionary<string, Object> ConnectorMap { get; set; }

        /// <summary>
        /// Gets or Sets ChannelMap
        /// </summary>
        [DataMember(Name = "channelMap", EmitDefaultValue = false)]
        public Dictionary<string, Object> ChannelMap { get; set; }

        /// <summary>
        /// Gets or Sets ResponseMap
        /// </summary>
        [DataMember(Name = "responseMap", EmitDefaultValue = false)]
        public Dictionary<string, Object> ResponseMap { get; set; }

        /// <summary>
        /// Gets or Sets ResponseError
        /// </summary>
        [DataMember(Name = "responseError", EmitDefaultValue = false)]
        public string ResponseError { get; set; }

        /// <summary>
        /// Gets or Sets ProcessingError
        /// </summary>
        [DataMember(Name = "processingError", EmitDefaultValue = false)]
        public string ProcessingError { get; set; }

        /// <summary>
        /// Gets or Sets PostProcessorError
        /// </summary>
        [DataMember(Name = "postProcessorError", EmitDefaultValue = false)]
        public string PostProcessorError { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ConnectorMessage {\n");
            sb.Append("  MessageId: ").Append(MessageId).Append("\n");
            sb.Append("  MetaDataId: ").Append(MetaDataId).Append("\n");
            sb.Append("  ChannelId: ").Append(ChannelId).Append("\n");
            sb.Append("  ChannelName: ").Append(ChannelName).Append("\n");
            sb.Append("  ConnectorName: ").Append(ConnectorName).Append("\n");
            sb.Append("  ServerId: ").Append(ServerId).Append("\n");
            sb.Append("  ReceivedDate: ").Append(ReceivedDate).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Raw: ").Append(Raw).Append("\n");
            sb.Append("  ProcessedRaw: ").Append(ProcessedRaw).Append("\n");
            sb.Append("  Transformed: ").Append(Transformed).Append("\n");
            sb.Append("  Encoded: ").Append(Encoded).Append("\n");
            sb.Append("  Sent: ").Append(Sent).Append("\n");
            sb.Append("  Response: ").Append(Response).Append("\n");
            sb.Append("  ResponseTransformed: ").Append(ResponseTransformed).Append("\n");
            sb.Append("  ProcessedResponse: ").Append(ProcessedResponse).Append("\n");
            sb.Append("  SourceMapContent: ").Append(SourceMapContent).Append("\n");
            sb.Append("  ConnectorMapContent: ").Append(ConnectorMapContent).Append("\n");
            sb.Append("  ChannelMapContent: ").Append(ChannelMapContent).Append("\n");
            sb.Append("  ResponseMapContent: ").Append(ResponseMapContent).Append("\n");
            sb.Append("  MetaDataMap: ").Append(MetaDataMap).Append("\n");
            sb.Append("  ProcessingErrorContent: ").Append(ProcessingErrorContent).Append("\n");
            sb.Append("  PostProcessorErrorContent: ").Append(PostProcessorErrorContent).Append("\n");
            sb.Append("  ResponseErrorContent: ").Append(ResponseErrorContent).Append("\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  SendAttempts: ").Append(SendAttempts).Append("\n");
            sb.Append("  SendDate: ").Append(SendDate).Append("\n");
            sb.Append("  ResponseDate: ").Append(ResponseDate).Append("\n");
            sb.Append("  ChainId: ").Append(ChainId).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  SentProperties: ").Append(SentProperties).Append("\n");
            sb.Append("  QueueBucket: ").Append(QueueBucket).Append("\n");
            sb.Append("  AttemptedFirst: ").Append(AttemptedFirst).Append("\n");
            sb.Append("  DispatcherId: ").Append(DispatcherId).Append("\n");
            sb.Append("  MessageContent: ").Append(MessageContent).Append("\n");
            sb.Append("  SourceMap: ").Append(SourceMap).Append("\n");
            sb.Append("  ConnectorMap: ").Append(ConnectorMap).Append("\n");
            sb.Append("  ChannelMap: ").Append(ChannelMap).Append("\n");
            sb.Append("  ResponseMap: ").Append(ResponseMap).Append("\n");
            sb.Append("  ResponseError: ").Append(ResponseError).Append("\n");
            sb.Append("  ProcessingError: ").Append(ProcessingError).Append("\n");
            sb.Append("  PostProcessorError: ").Append(PostProcessorError).Append("\n");
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
            return this.Equals(input as ConnectorMessage);
        }

        /// <summary>
        /// Returns true if ConnectorMessage instances are equal
        /// </summary>
        /// <param name="input">Instance of ConnectorMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConnectorMessage input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MessageId == input.MessageId ||
                    this.MessageId.Equals(input.MessageId)
                ) && 
                (
                    this.MetaDataId == input.MetaDataId ||
                    this.MetaDataId.Equals(input.MetaDataId)
                ) && 
                (
                    this.ChannelId == input.ChannelId ||
                    (this.ChannelId != null &&
                    this.ChannelId.Equals(input.ChannelId))
                ) && 
                (
                    this.ChannelName == input.ChannelName ||
                    (this.ChannelName != null &&
                    this.ChannelName.Equals(input.ChannelName))
                ) && 
                (
                    this.ConnectorName == input.ConnectorName ||
                    (this.ConnectorName != null &&
                    this.ConnectorName.Equals(input.ConnectorName))
                ) && 
                (
                    this.ServerId == input.ServerId ||
                    (this.ServerId != null &&
                    this.ServerId.Equals(input.ServerId))
                ) && 
                (
                    this.ReceivedDate == input.ReceivedDate ||
                    (this.ReceivedDate != null &&
                    this.ReceivedDate.Equals(input.ReceivedDate))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.Raw == input.Raw ||
                    (this.Raw != null &&
                    this.Raw.Equals(input.Raw))
                ) && 
                (
                    this.ProcessedRaw == input.ProcessedRaw ||
                    (this.ProcessedRaw != null &&
                    this.ProcessedRaw.Equals(input.ProcessedRaw))
                ) && 
                (
                    this.Transformed == input.Transformed ||
                    (this.Transformed != null &&
                    this.Transformed.Equals(input.Transformed))
                ) && 
                (
                    this.Encoded == input.Encoded ||
                    (this.Encoded != null &&
                    this.Encoded.Equals(input.Encoded))
                ) && 
                (
                    this.Sent == input.Sent ||
                    (this.Sent != null &&
                    this.Sent.Equals(input.Sent))
                ) && 
                (
                    this.Response == input.Response ||
                    (this.Response != null &&
                    this.Response.Equals(input.Response))
                ) && 
                (
                    this.ResponseTransformed == input.ResponseTransformed ||
                    (this.ResponseTransformed != null &&
                    this.ResponseTransformed.Equals(input.ResponseTransformed))
                ) && 
                (
                    this.ProcessedResponse == input.ProcessedResponse ||
                    (this.ProcessedResponse != null &&
                    this.ProcessedResponse.Equals(input.ProcessedResponse))
                ) && 
                (
                    this.SourceMapContent == input.SourceMapContent ||
                    (this.SourceMapContent != null &&
                    this.SourceMapContent.Equals(input.SourceMapContent))
                ) && 
                (
                    this.ConnectorMapContent == input.ConnectorMapContent ||
                    (this.ConnectorMapContent != null &&
                    this.ConnectorMapContent.Equals(input.ConnectorMapContent))
                ) && 
                (
                    this.ChannelMapContent == input.ChannelMapContent ||
                    (this.ChannelMapContent != null &&
                    this.ChannelMapContent.Equals(input.ChannelMapContent))
                ) && 
                (
                    this.ResponseMapContent == input.ResponseMapContent ||
                    (this.ResponseMapContent != null &&
                    this.ResponseMapContent.Equals(input.ResponseMapContent))
                ) && 
                (
                    this.MetaDataMap == input.MetaDataMap ||
                    this.MetaDataMap != null &&
                    input.MetaDataMap != null &&
                    this.MetaDataMap.SequenceEqual(input.MetaDataMap)
                ) && 
                (
                    this.ProcessingErrorContent == input.ProcessingErrorContent ||
                    (this.ProcessingErrorContent != null &&
                    this.ProcessingErrorContent.Equals(input.ProcessingErrorContent))
                ) && 
                (
                    this.PostProcessorErrorContent == input.PostProcessorErrorContent ||
                    (this.PostProcessorErrorContent != null &&
                    this.PostProcessorErrorContent.Equals(input.PostProcessorErrorContent))
                ) && 
                (
                    this.ResponseErrorContent == input.ResponseErrorContent ||
                    (this.ResponseErrorContent != null &&
                    this.ResponseErrorContent.Equals(input.ResponseErrorContent))
                ) && 
                (
                    this.ErrorCode == input.ErrorCode ||
                    this.ErrorCode.Equals(input.ErrorCode)
                ) && 
                (
                    this.SendAttempts == input.SendAttempts ||
                    this.SendAttempts.Equals(input.SendAttempts)
                ) && 
                (
                    this.SendDate == input.SendDate ||
                    (this.SendDate != null &&
                    this.SendDate.Equals(input.SendDate))
                ) && 
                (
                    this.ResponseDate == input.ResponseDate ||
                    (this.ResponseDate != null &&
                    this.ResponseDate.Equals(input.ResponseDate))
                ) && 
                (
                    this.ChainId == input.ChainId ||
                    this.ChainId.Equals(input.ChainId)
                ) && 
                (
                    this.OrderId == input.OrderId ||
                    this.OrderId.Equals(input.OrderId)
                ) && 
                (
                    this.SentProperties == input.SentProperties ||
                    (this.SentProperties != null &&
                    this.SentProperties.Equals(input.SentProperties))
                ) && 
                (
                    this.QueueBucket == input.QueueBucket ||
                    this.QueueBucket.Equals(input.QueueBucket)
                ) && 
                (
                    this.AttemptedFirst == input.AttemptedFirst ||
                    this.AttemptedFirst.Equals(input.AttemptedFirst)
                ) && 
                (
                    this.DispatcherId == input.DispatcherId ||
                    this.DispatcherId.Equals(input.DispatcherId)
                ) && 
                (
                    this.MessageContent == input.MessageContent ||
                    (this.MessageContent != null &&
                    this.MessageContent.Equals(input.MessageContent))
                ) && 
                (
                    this.SourceMap == input.SourceMap ||
                    this.SourceMap != null &&
                    input.SourceMap != null &&
                    this.SourceMap.SequenceEqual(input.SourceMap)
                ) && 
                (
                    this.ConnectorMap == input.ConnectorMap ||
                    this.ConnectorMap != null &&
                    input.ConnectorMap != null &&
                    this.ConnectorMap.SequenceEqual(input.ConnectorMap)
                ) && 
                (
                    this.ChannelMap == input.ChannelMap ||
                    this.ChannelMap != null &&
                    input.ChannelMap != null &&
                    this.ChannelMap.SequenceEqual(input.ChannelMap)
                ) && 
                (
                    this.ResponseMap == input.ResponseMap ||
                    this.ResponseMap != null &&
                    input.ResponseMap != null &&
                    this.ResponseMap.SequenceEqual(input.ResponseMap)
                ) && 
                (
                    this.ResponseError == input.ResponseError ||
                    (this.ResponseError != null &&
                    this.ResponseError.Equals(input.ResponseError))
                ) && 
                (
                    this.ProcessingError == input.ProcessingError ||
                    (this.ProcessingError != null &&
                    this.ProcessingError.Equals(input.ProcessingError))
                ) && 
                (
                    this.PostProcessorError == input.PostProcessorError ||
                    (this.PostProcessorError != null &&
                    this.PostProcessorError.Equals(input.PostProcessorError))
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
                hashCode = (hashCode * 59) + this.MessageId.GetHashCode();
                hashCode = (hashCode * 59) + this.MetaDataId.GetHashCode();
                if (this.ChannelId != null)
                {
                    hashCode = (hashCode * 59) + this.ChannelId.GetHashCode();
                }
                if (this.ChannelName != null)
                {
                    hashCode = (hashCode * 59) + this.ChannelName.GetHashCode();
                }
                if (this.ConnectorName != null)
                {
                    hashCode = (hashCode * 59) + this.ConnectorName.GetHashCode();
                }
                if (this.ServerId != null)
                {
                    hashCode = (hashCode * 59) + this.ServerId.GetHashCode();
                }
                if (this.ReceivedDate != null)
                {
                    hashCode = (hashCode * 59) + this.ReceivedDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.Raw != null)
                {
                    hashCode = (hashCode * 59) + this.Raw.GetHashCode();
                }
                if (this.ProcessedRaw != null)
                {
                    hashCode = (hashCode * 59) + this.ProcessedRaw.GetHashCode();
                }
                if (this.Transformed != null)
                {
                    hashCode = (hashCode * 59) + this.Transformed.GetHashCode();
                }
                if (this.Encoded != null)
                {
                    hashCode = (hashCode * 59) + this.Encoded.GetHashCode();
                }
                if (this.Sent != null)
                {
                    hashCode = (hashCode * 59) + this.Sent.GetHashCode();
                }
                if (this.Response != null)
                {
                    hashCode = (hashCode * 59) + this.Response.GetHashCode();
                }
                if (this.ResponseTransformed != null)
                {
                    hashCode = (hashCode * 59) + this.ResponseTransformed.GetHashCode();
                }
                if (this.ProcessedResponse != null)
                {
                    hashCode = (hashCode * 59) + this.ProcessedResponse.GetHashCode();
                }
                if (this.SourceMapContent != null)
                {
                    hashCode = (hashCode * 59) + this.SourceMapContent.GetHashCode();
                }
                if (this.ConnectorMapContent != null)
                {
                    hashCode = (hashCode * 59) + this.ConnectorMapContent.GetHashCode();
                }
                if (this.ChannelMapContent != null)
                {
                    hashCode = (hashCode * 59) + this.ChannelMapContent.GetHashCode();
                }
                if (this.ResponseMapContent != null)
                {
                    hashCode = (hashCode * 59) + this.ResponseMapContent.GetHashCode();
                }
                if (this.MetaDataMap != null)
                {
                    hashCode = (hashCode * 59) + this.MetaDataMap.GetHashCode();
                }
                if (this.ProcessingErrorContent != null)
                {
                    hashCode = (hashCode * 59) + this.ProcessingErrorContent.GetHashCode();
                }
                if (this.PostProcessorErrorContent != null)
                {
                    hashCode = (hashCode * 59) + this.PostProcessorErrorContent.GetHashCode();
                }
                if (this.ResponseErrorContent != null)
                {
                    hashCode = (hashCode * 59) + this.ResponseErrorContent.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ErrorCode.GetHashCode();
                hashCode = (hashCode * 59) + this.SendAttempts.GetHashCode();
                if (this.SendDate != null)
                {
                    hashCode = (hashCode * 59) + this.SendDate.GetHashCode();
                }
                if (this.ResponseDate != null)
                {
                    hashCode = (hashCode * 59) + this.ResponseDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ChainId.GetHashCode();
                hashCode = (hashCode * 59) + this.OrderId.GetHashCode();
                if (this.SentProperties != null)
                {
                    hashCode = (hashCode * 59) + this.SentProperties.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.QueueBucket.GetHashCode();
                hashCode = (hashCode * 59) + this.AttemptedFirst.GetHashCode();
                hashCode = (hashCode * 59) + this.DispatcherId.GetHashCode();
                if (this.MessageContent != null)
                {
                    hashCode = (hashCode * 59) + this.MessageContent.GetHashCode();
                }
                if (this.SourceMap != null)
                {
                    hashCode = (hashCode * 59) + this.SourceMap.GetHashCode();
                }
                if (this.ConnectorMap != null)
                {
                    hashCode = (hashCode * 59) + this.ConnectorMap.GetHashCode();
                }
                if (this.ChannelMap != null)
                {
                    hashCode = (hashCode * 59) + this.ChannelMap.GetHashCode();
                }
                if (this.ResponseMap != null)
                {
                    hashCode = (hashCode * 59) + this.ResponseMap.GetHashCode();
                }
                if (this.ResponseError != null)
                {
                    hashCode = (hashCode * 59) + this.ResponseError.GetHashCode();
                }
                if (this.ProcessingError != null)
                {
                    hashCode = (hashCode * 59) + this.ProcessingError.GetHashCode();
                }
                if (this.PostProcessorError != null)
                {
                    hashCode = (hashCode * 59) + this.PostProcessorError.GetHashCode();
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