

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
    /// GroupAuditLogEntryDataGroupAnnouncement
    /// </summary>
    [DataContract(Name = "GroupAuditLogEntryDataGroupAnnouncement")]
    public partial class GroupAuditLogEntryDataGroupAnnouncement : IEquatable<GroupAuditLogEntryDataGroupAnnouncement>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLogEntryDataGroupAnnouncement" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GroupAuditLogEntryDataGroupAnnouncement() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLogEntryDataGroupAnnouncement" /> class.
        /// </summary>
        /// <param name="authorId">A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed. (required).</param>
        /// <param name="imageId">imageId (required).</param>
        /// <param name="sendNotification">Whether a notification was sent for this announcement. (required).</param>
        /// <param name="text">The text content of the announcement. (required).</param>
        /// <param name="title">The title of the announcement. (required).</param>
        public GroupAuditLogEntryDataGroupAnnouncement(string authorId = default, string imageId = default, bool sendNotification = default, string text = default, string title = default)
        {
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.AuthorId = authorId;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.ImageId = imageId;
            this.SendNotification = sendNotification;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Text = text;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Title = title;
        }

        /// <summary>
        /// A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed.
        /// </summary>
        /// <value>A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed.</value>
        /*
        <example>usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469</example>
        */
        [DataMember(Name = "authorId", IsRequired = true, EmitDefaultValue = true)]
        public string AuthorId { get; set; }

        /// <summary>
        /// Gets or Sets ImageId
        /// </summary>
        /*
        <example>file_ce35d830-e20a-4df0-a6d4-5aaef4508044</example>
        */
        [DataMember(Name = "imageId", IsRequired = true, EmitDefaultValue = true)]
        public string ImageId { get; set; }

        /// <summary>
        /// Whether a notification was sent for this announcement.
        /// </summary>
        /// <value>Whether a notification was sent for this announcement.</value>
        [DataMember(Name = "sendNotification", IsRequired = true, EmitDefaultValue = true)]
        public bool SendNotification { get; set; }

        /// <summary>
        /// The text content of the announcement.
        /// </summary>
        /// <value>The text content of the announcement.</value>
        [DataMember(Name = "text", IsRequired = true, EmitDefaultValue = true)]
        public string Text { get; set; }

        /// <summary>
        /// The title of the announcement.
        /// </summary>
        /// <value>The title of the announcement.</value>
        [DataMember(Name = "title", IsRequired = true, EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GroupAuditLogEntryDataGroupAnnouncement {\n");
            sb.Append("  AuthorId: ").Append(AuthorId).Append("\n");
            sb.Append("  ImageId: ").Append(ImageId).Append("\n");
            sb.Append("  SendNotification: ").Append(SendNotification).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
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
            return this.Equals(input as GroupAuditLogEntryDataGroupAnnouncement);
        }

        /// <summary>
        /// Returns true if GroupAuditLogEntryDataGroupAnnouncement instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupAuditLogEntryDataGroupAnnouncement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupAuditLogEntryDataGroupAnnouncement input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AuthorId == input.AuthorId ||
                    (this.AuthorId != null &&
                    this.AuthorId.Equals(input.AuthorId))
                ) && 
                (
                    this.ImageId == input.ImageId ||
                    (this.ImageId != null &&
                    this.ImageId.Equals(input.ImageId))
                ) && 
                (
                    this.SendNotification == input.SendNotification ||
                    this.SendNotification.Equals(input.SendNotification)
                ) && 
                (
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
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
                if (this.AuthorId != null)
                {
                    hashCode = (hashCode * 59) + this.AuthorId.GetHashCode();
                }
                if (this.ImageId != null)
                {
                    hashCode = (hashCode * 59) + this.ImageId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SendNotification.GetHashCode();
                if (this.Text != null)
                {
                    hashCode = (hashCode * 59) + this.Text.GetHashCode();
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
