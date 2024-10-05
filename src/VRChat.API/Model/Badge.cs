/*
 * VRChat API Documentation
 *
 *
 * The version of the OpenAPI document: 1.18.5
 * Contact: vrchatapi.lpv0t@aries.fyi
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
using OpenAPIDateConverter = VRChat.API.Client.OpenAPIDateConverter;

namespace VRChat.API.Model
{
    /// <summary>
    /// Badge
    /// </summary>
    [DataContract(Name = "Badge")]
    public partial class Badge : IEquatable<Badge>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Badge" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Badge() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Badge" /> class.
        /// </summary>
        /// <param name="assignedAt">only present in CurrentUser badges.</param>
        /// <param name="badgeDescription">badgeDescription (required).</param>
        /// <param name="badgeId">badgeId (required).</param>
        /// <param name="badgeImageUrl">direct url to image (required).</param>
        /// <param name="badgeName">badgeName (required).</param>
        /// <param name="hidden">only present in CurrentUser badges.</param>
        /// <param name="showcased">showcased (required).</param>
        /// <param name="updatedAt">only present in CurrentUser badges.</param>
        public Badge(DateTime? assignedAt = default(DateTime?), string badgeDescription = default(string), string badgeId = default(string), string badgeImageUrl = default(string), string badgeName = default(string), bool? hidden = default(bool?), bool showcased = default(bool), DateTime? updatedAt = default(DateTime?))
        {
            // to ensure "badgeDescription" is required (not null)
            if (badgeDescription == null)
            {
                throw new ArgumentNullException("badgeDescription is a required property for Badge and cannot be null");
            }
            this.BadgeDescription = badgeDescription;
            // to ensure "badgeId" is required (not null)
            if (badgeId == null)
            {
                throw new ArgumentNullException("badgeId is a required property for Badge and cannot be null");
            }
            this.BadgeId = badgeId;
            // to ensure "badgeImageUrl" is required (not null)
            if (badgeImageUrl == null)
            {
                throw new ArgumentNullException("badgeImageUrl is a required property for Badge and cannot be null");
            }
            this.BadgeImageUrl = badgeImageUrl;
            // to ensure "badgeName" is required (not null)
            if (badgeName == null)
            {
                throw new ArgumentNullException("badgeName is a required property for Badge and cannot be null");
            }
            this.BadgeName = badgeName;
            this.Showcased = showcased;
            this.AssignedAt = assignedAt;
            this.Hidden = hidden;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// only present in CurrentUser badges
        /// </summary>
        /// <value>only present in CurrentUser badges</value>
        [DataMember(Name = "assignedAt", EmitDefaultValue = true)]
        public DateTime? AssignedAt { get; set; }

        /// <summary>
        /// Gets or Sets BadgeDescription
        /// </summary>
        [DataMember(Name = "badgeDescription", IsRequired = true, EmitDefaultValue = true)]
        public string BadgeDescription { get; set; }

        /// <summary>
        /// Gets or Sets BadgeId
        /// </summary>
        [DataMember(Name = "badgeId", IsRequired = true, EmitDefaultValue = true)]
        public string BadgeId { get; set; }

        /// <summary>
        /// direct url to image
        /// </summary>
        /// <value>direct url to image</value>
        [DataMember(Name = "badgeImageUrl", IsRequired = true, EmitDefaultValue = true)]
        public string BadgeImageUrl { get; set; }

        /// <summary>
        /// Gets or Sets BadgeName
        /// </summary>
        [DataMember(Name = "badgeName", IsRequired = true, EmitDefaultValue = true)]
        public string BadgeName { get; set; }

        /// <summary>
        /// only present in CurrentUser badges
        /// </summary>
        /// <value>only present in CurrentUser badges</value>
        [DataMember(Name = "hidden", EmitDefaultValue = true)]
        public bool? Hidden { get; set; }

        /// <summary>
        /// Gets or Sets Showcased
        /// </summary>
        [DataMember(Name = "showcased", IsRequired = true, EmitDefaultValue = true)]
        public bool Showcased { get; set; }

        /// <summary>
        /// only present in CurrentUser badges
        /// </summary>
        /// <value>only present in CurrentUser badges</value>
        [DataMember(Name = "updatedAt", EmitDefaultValue = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Badge {\n");
            sb.Append("  AssignedAt: ").Append(AssignedAt).Append("\n");
            sb.Append("  BadgeDescription: ").Append(BadgeDescription).Append("\n");
            sb.Append("  BadgeId: ").Append(BadgeId).Append("\n");
            sb.Append("  BadgeImageUrl: ").Append(BadgeImageUrl).Append("\n");
            sb.Append("  BadgeName: ").Append(BadgeName).Append("\n");
            sb.Append("  Hidden: ").Append(Hidden).Append("\n");
            sb.Append("  Showcased: ").Append(Showcased).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
            return this.Equals(input as Badge);
        }

        /// <summary>
        /// Returns true if Badge instances are equal
        /// </summary>
        /// <param name="input">Instance of Badge to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Badge input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AssignedAt == input.AssignedAt ||
                    (this.AssignedAt != null &&
                    this.AssignedAt.Equals(input.AssignedAt))
                ) && 
                (
                    this.BadgeDescription == input.BadgeDescription ||
                    (this.BadgeDescription != null &&
                    this.BadgeDescription.Equals(input.BadgeDescription))
                ) && 
                (
                    this.BadgeId == input.BadgeId ||
                    (this.BadgeId != null &&
                    this.BadgeId.Equals(input.BadgeId))
                ) && 
                (
                    this.BadgeImageUrl == input.BadgeImageUrl ||
                    (this.BadgeImageUrl != null &&
                    this.BadgeImageUrl.Equals(input.BadgeImageUrl))
                ) && 
                (
                    this.BadgeName == input.BadgeName ||
                    (this.BadgeName != null &&
                    this.BadgeName.Equals(input.BadgeName))
                ) && 
                (
                    this.Hidden == input.Hidden ||
                    (this.Hidden != null &&
                    this.Hidden.Equals(input.Hidden))
                ) && 
                (
                    this.Showcased == input.Showcased ||
                    this.Showcased.Equals(input.Showcased)
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
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
                if (this.AssignedAt != null)
                {
                    hashCode = (hashCode * 59) + this.AssignedAt.GetHashCode();
                }
                if (this.BadgeDescription != null)
                {
                    hashCode = (hashCode * 59) + this.BadgeDescription.GetHashCode();
                }
                if (this.BadgeId != null)
                {
                    hashCode = (hashCode * 59) + this.BadgeId.GetHashCode();
                }
                if (this.BadgeImageUrl != null)
                {
                    hashCode = (hashCode * 59) + this.BadgeImageUrl.GetHashCode();
                }
                if (this.BadgeName != null)
                {
                    hashCode = (hashCode * 59) + this.BadgeName.GetHashCode();
                }
                if (this.Hidden != null)
                {
                    hashCode = (hashCode * 59) + this.Hidden.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Showcased.GetHashCode();
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
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
