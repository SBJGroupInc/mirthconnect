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
    /// PollConnectorPropertiesAdvanced
    /// </summary>
    [DataContract(Name = "PollConnectorPropertiesAdvanced")]
    public partial class PollConnectorPropertiesAdvanced : IEquatable<PollConnectorPropertiesAdvanced>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PollConnectorPropertiesAdvanced" /> class.
        /// </summary>
        /// <param name="weekly">weekly.</param>
        /// <param name="inactiveDays">inactiveDays.</param>
        /// <param name="dayOfMonth">dayOfMonth.</param>
        /// <param name="allDay">allDay.</param>
        /// <param name="startingHour">startingHour.</param>
        /// <param name="startingMinute">startingMinute.</param>
        /// <param name="endingHour">endingHour.</param>
        /// <param name="endingMinute">endingMinute.</param>
        /// <param name="purgedProperties">purgedProperties.</param>
        /// <param name="activeDays">activeDays.</param>
        public PollConnectorPropertiesAdvanced(bool weekly = default(bool), List<bool> inactiveDays = default(List<bool>), int dayOfMonth = default(int), bool allDay = default(bool), int startingHour = default(int), int startingMinute = default(int), int endingHour = default(int), int endingMinute = default(int), Dictionary<string, Object> purgedProperties = default(Dictionary<string, Object>), List<bool> activeDays = default(List<bool>))
        {
            this.Weekly = weekly;
            this.InactiveDays = inactiveDays;
            this.DayOfMonth = dayOfMonth;
            this.AllDay = allDay;
            this.StartingHour = startingHour;
            this.StartingMinute = startingMinute;
            this.EndingHour = endingHour;
            this.EndingMinute = endingMinute;
            this.PurgedProperties = purgedProperties;
            this.ActiveDays = activeDays;
        }

        /// <summary>
        /// Gets or Sets Weekly
        /// </summary>
        [DataMember(Name = "weekly", EmitDefaultValue = true)]
        public bool Weekly { get; set; }

        /// <summary>
        /// Gets or Sets InactiveDays
        /// </summary>
        [DataMember(Name = "inactiveDays", EmitDefaultValue = false)]
        public List<bool> InactiveDays { get; set; }

        /// <summary>
        /// Gets or Sets DayOfMonth
        /// </summary>
        [DataMember(Name = "dayOfMonth", EmitDefaultValue = false)]
        public int DayOfMonth { get; set; }

        /// <summary>
        /// Gets or Sets AllDay
        /// </summary>
        [DataMember(Name = "allDay", EmitDefaultValue = true)]
        public bool AllDay { get; set; }

        /// <summary>
        /// Gets or Sets StartingHour
        /// </summary>
        [DataMember(Name = "startingHour", EmitDefaultValue = false)]
        public int StartingHour { get; set; }

        /// <summary>
        /// Gets or Sets StartingMinute
        /// </summary>
        [DataMember(Name = "startingMinute", EmitDefaultValue = false)]
        public int StartingMinute { get; set; }

        /// <summary>
        /// Gets or Sets EndingHour
        /// </summary>
        [DataMember(Name = "endingHour", EmitDefaultValue = false)]
        public int EndingHour { get; set; }

        /// <summary>
        /// Gets or Sets EndingMinute
        /// </summary>
        [DataMember(Name = "endingMinute", EmitDefaultValue = false)]
        public int EndingMinute { get; set; }

        /// <summary>
        /// Gets or Sets PurgedProperties
        /// </summary>
        [DataMember(Name = "purgedProperties", EmitDefaultValue = false)]
        public Dictionary<string, Object> PurgedProperties { get; set; }

        /// <summary>
        /// Gets or Sets ActiveDays
        /// </summary>
        [DataMember(Name = "activeDays", EmitDefaultValue = false)]
        public List<bool> ActiveDays { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PollConnectorPropertiesAdvanced {\n");
            sb.Append("  Weekly: ").Append(Weekly).Append("\n");
            sb.Append("  InactiveDays: ").Append(InactiveDays).Append("\n");
            sb.Append("  DayOfMonth: ").Append(DayOfMonth).Append("\n");
            sb.Append("  AllDay: ").Append(AllDay).Append("\n");
            sb.Append("  StartingHour: ").Append(StartingHour).Append("\n");
            sb.Append("  StartingMinute: ").Append(StartingMinute).Append("\n");
            sb.Append("  EndingHour: ").Append(EndingHour).Append("\n");
            sb.Append("  EndingMinute: ").Append(EndingMinute).Append("\n");
            sb.Append("  PurgedProperties: ").Append(PurgedProperties).Append("\n");
            sb.Append("  ActiveDays: ").Append(ActiveDays).Append("\n");
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
            return this.Equals(input as PollConnectorPropertiesAdvanced);
        }

        /// <summary>
        /// Returns true if PollConnectorPropertiesAdvanced instances are equal
        /// </summary>
        /// <param name="input">Instance of PollConnectorPropertiesAdvanced to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PollConnectorPropertiesAdvanced input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Weekly == input.Weekly ||
                    this.Weekly.Equals(input.Weekly)
                ) && 
                (
                    this.InactiveDays == input.InactiveDays ||
                    this.InactiveDays != null &&
                    input.InactiveDays != null &&
                    this.InactiveDays.SequenceEqual(input.InactiveDays)
                ) && 
                (
                    this.DayOfMonth == input.DayOfMonth ||
                    this.DayOfMonth.Equals(input.DayOfMonth)
                ) && 
                (
                    this.AllDay == input.AllDay ||
                    this.AllDay.Equals(input.AllDay)
                ) && 
                (
                    this.StartingHour == input.StartingHour ||
                    this.StartingHour.Equals(input.StartingHour)
                ) && 
                (
                    this.StartingMinute == input.StartingMinute ||
                    this.StartingMinute.Equals(input.StartingMinute)
                ) && 
                (
                    this.EndingHour == input.EndingHour ||
                    this.EndingHour.Equals(input.EndingHour)
                ) && 
                (
                    this.EndingMinute == input.EndingMinute ||
                    this.EndingMinute.Equals(input.EndingMinute)
                ) && 
                (
                    this.PurgedProperties == input.PurgedProperties ||
                    this.PurgedProperties != null &&
                    input.PurgedProperties != null &&
                    this.PurgedProperties.SequenceEqual(input.PurgedProperties)
                ) && 
                (
                    this.ActiveDays == input.ActiveDays ||
                    this.ActiveDays != null &&
                    input.ActiveDays != null &&
                    this.ActiveDays.SequenceEqual(input.ActiveDays)
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
                hashCode = (hashCode * 59) + this.Weekly.GetHashCode();
                if (this.InactiveDays != null)
                {
                    hashCode = (hashCode * 59) + this.InactiveDays.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.DayOfMonth.GetHashCode();
                hashCode = (hashCode * 59) + this.AllDay.GetHashCode();
                hashCode = (hashCode * 59) + this.StartingHour.GetHashCode();
                hashCode = (hashCode * 59) + this.StartingMinute.GetHashCode();
                hashCode = (hashCode * 59) + this.EndingHour.GetHashCode();
                hashCode = (hashCode * 59) + this.EndingMinute.GetHashCode();
                if (this.PurgedProperties != null)
                {
                    hashCode = (hashCode * 59) + this.PurgedProperties.GetHashCode();
                }
                if (this.ActiveDays != null)
                {
                    hashCode = (hashCode * 59) + this.ActiveDays.GetHashCode();
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
