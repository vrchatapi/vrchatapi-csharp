

#pragma warning disable CS0612
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
using FileParameter = VRChat.API.Client.FileParameter;
using OpenAPIDateConverter = VRChat.API.Client.OpenAPIDateConverter;

namespace VRChat.API.Model
{
    /// <summary>
    /// NotificationV2DataEventAnnouncement
    /// </summary>
    [DataContract(Name = "NotificationV2DataEventAnnouncement")]
    public partial class NotificationV2DataEventAnnouncement : IEquatable<NotificationV2DataEventAnnouncement>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationV2DataEventAnnouncement" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NotificationV2DataEventAnnouncement() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationV2DataEventAnnouncement" /> class.
        /// </summary>
        /// <param name="ownerId">ownerId (required).</param>
        /// <param name="ownerName">ownerName (required).</param>
        /// <param name="title">title (required).</param>
        public NotificationV2DataEventAnnouncement(string ownerId = default, string ownerName = default, string title = default)
        {
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.OwnerId = ownerId;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.OwnerName = ownerName;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Title = title;
        }

        /// <summary>
        /// Gets or Sets OwnerId
        /// </summary>
        /*
        <example>grp_71a7ff59-112c-4e78-a990-c7cc650776e5</example>
        */
        [DataMember(Name = "ownerId", IsRequired = true, EmitDefaultValue = true)]
        public string OwnerId { get; set; }

        /// <summary>
        /// Gets or Sets OwnerName
        /// </summary>
        [DataMember(Name = "ownerName", IsRequired = true, EmitDefaultValue = true)]
        public string OwnerName { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", IsRequired = true, EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NotificationV2DataEventAnnouncement {\n");
            sb.Append("  OwnerId: ").Append(OwnerId).Append("\n");
            sb.Append("  OwnerName: ").Append(OwnerName).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
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
            return this.Equals(input as NotificationV2DataEventAnnouncement);
        }

        /// <summary>
        /// Returns true if NotificationV2DataEventAnnouncement instances are equal
        /// </summary>
        /// <param name="input">Instance of NotificationV2DataEventAnnouncement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NotificationV2DataEventAnnouncement input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.OwnerId == input.OwnerId ||
                    (this.OwnerId != null &&
                    this.OwnerId.Equals(input.OwnerId))
                ) && 
                (
                    this.OwnerName == input.OwnerName ||
                    (this.OwnerName != null &&
                    this.OwnerName.Equals(input.OwnerName))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
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
                if (this.OwnerId != null)
                {
                    hashCode = (hashCode * 59) + this.OwnerId.GetHashCode();
                }
                if (this.OwnerName != null)
                {
                    hashCode = (hashCode * 59) + this.OwnerName.GetHashCode();
                }
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
