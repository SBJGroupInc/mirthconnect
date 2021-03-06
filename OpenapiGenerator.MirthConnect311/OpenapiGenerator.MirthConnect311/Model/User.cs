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
    /// User
    /// </summary>
    [DataContract(Name = "User")]
    public partial class User : IEquatable<User>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="User" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="username">username.</param>
        /// <param name="email">email.</param>
        /// <param name="firstName">firstName.</param>
        /// <param name="lastName">lastName.</param>
        /// <param name="organization">organization.</param>
        /// <param name="description">description.</param>
        /// <param name="phoneNumber">phoneNumber.</param>
        /// <param name="industry">industry.</param>
        /// <param name="lastLogin">lastLogin.</param>
        /// <param name="gracePeriodStart">gracePeriodStart.</param>
        /// <param name="strikeCount">strikeCount.</param>
        /// <param name="lastStrikeTime">lastStrikeTime.</param>
        public User(int id = default(int), string username = default(string), string email = default(string), string firstName = default(string), string lastName = default(string), string organization = default(string), string description = default(string), string phoneNumber = default(string), string industry = default(string), DateTime lastLogin = default(DateTime), DateTime gracePeriodStart = default(DateTime), int strikeCount = default(int), DateTime lastStrikeTime = default(DateTime))
        {
            this.Id = id;
            this.Username = username;
            this.Email = email;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Organization = organization;
            this.Description = description;
            this.PhoneNumber = phoneNumber;
            this.Industry = industry;
            this.LastLogin = lastLogin;
            this.GracePeriodStart = gracePeriodStart;
            this.StrikeCount = strikeCount;
            this.LastStrikeTime = lastStrikeTime;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets Username
        /// </summary>
        [DataMember(Name = "username", EmitDefaultValue = false)]
        public string Username { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [DataMember(Name = "firstName", EmitDefaultValue = false)]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [DataMember(Name = "lastName", EmitDefaultValue = false)]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or Sets Organization
        /// </summary>
        [DataMember(Name = "organization", EmitDefaultValue = false)]
        public string Organization { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets PhoneNumber
        /// </summary>
        [DataMember(Name = "phoneNumber", EmitDefaultValue = false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or Sets Industry
        /// </summary>
        [DataMember(Name = "industry", EmitDefaultValue = false)]
        public string Industry { get; set; }

        /// <summary>
        /// Gets or Sets LastLogin
        /// </summary>
        [DataMember(Name = "lastLogin", EmitDefaultValue = false)]
        public DateTime LastLogin { get; set; }

        /// <summary>
        /// Gets or Sets GracePeriodStart
        /// </summary>
        [DataMember(Name = "gracePeriodStart", EmitDefaultValue = false)]
        public DateTime GracePeriodStart { get; set; }

        /// <summary>
        /// Gets or Sets StrikeCount
        /// </summary>
        [DataMember(Name = "strikeCount", EmitDefaultValue = false)]
        public int StrikeCount { get; set; }

        /// <summary>
        /// Gets or Sets LastStrikeTime
        /// </summary>
        [DataMember(Name = "lastStrikeTime", EmitDefaultValue = false)]
        public DateTime LastStrikeTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class User {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Organization: ").Append(Organization).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  Industry: ").Append(Industry).Append("\n");
            sb.Append("  LastLogin: ").Append(LastLogin).Append("\n");
            sb.Append("  GracePeriodStart: ").Append(GracePeriodStart).Append("\n");
            sb.Append("  StrikeCount: ").Append(StrikeCount).Append("\n");
            sb.Append("  LastStrikeTime: ").Append(LastStrikeTime).Append("\n");
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
            return this.Equals(input as User);
        }

        /// <summary>
        /// Returns true if User instances are equal
        /// </summary>
        /// <param name="input">Instance of User to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(User input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.Organization == input.Organization ||
                    (this.Organization != null &&
                    this.Organization.Equals(input.Organization))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.PhoneNumber == input.PhoneNumber ||
                    (this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(input.PhoneNumber))
                ) && 
                (
                    this.Industry == input.Industry ||
                    (this.Industry != null &&
                    this.Industry.Equals(input.Industry))
                ) && 
                (
                    this.LastLogin == input.LastLogin ||
                    (this.LastLogin != null &&
                    this.LastLogin.Equals(input.LastLogin))
                ) && 
                (
                    this.GracePeriodStart == input.GracePeriodStart ||
                    (this.GracePeriodStart != null &&
                    this.GracePeriodStart.Equals(input.GracePeriodStart))
                ) && 
                (
                    this.StrikeCount == input.StrikeCount ||
                    this.StrikeCount.Equals(input.StrikeCount)
                ) && 
                (
                    this.LastStrikeTime == input.LastStrikeTime ||
                    (this.LastStrikeTime != null &&
                    this.LastStrikeTime.Equals(input.LastStrikeTime))
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
                hashCode = (hashCode * 59) + this.Id.GetHashCode();
                if (this.Username != null)
                {
                    hashCode = (hashCode * 59) + this.Username.GetHashCode();
                }
                if (this.Email != null)
                {
                    hashCode = (hashCode * 59) + this.Email.GetHashCode();
                }
                if (this.FirstName != null)
                {
                    hashCode = (hashCode * 59) + this.FirstName.GetHashCode();
                }
                if (this.LastName != null)
                {
                    hashCode = (hashCode * 59) + this.LastName.GetHashCode();
                }
                if (this.Organization != null)
                {
                    hashCode = (hashCode * 59) + this.Organization.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.PhoneNumber != null)
                {
                    hashCode = (hashCode * 59) + this.PhoneNumber.GetHashCode();
                }
                if (this.Industry != null)
                {
                    hashCode = (hashCode * 59) + this.Industry.GetHashCode();
                }
                if (this.LastLogin != null)
                {
                    hashCode = (hashCode * 59) + this.LastLogin.GetHashCode();
                }
                if (this.GracePeriodStart != null)
                {
                    hashCode = (hashCode * 59) + this.GracePeriodStart.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.StrikeCount.GetHashCode();
                if (this.LastStrikeTime != null)
                {
                    hashCode = (hashCode * 59) + this.LastStrikeTime.GetHashCode();
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
