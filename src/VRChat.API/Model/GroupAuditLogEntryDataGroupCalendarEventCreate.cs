

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
    /// GroupAuditLogEntryDataGroupCalendarEventCreate
    /// </summary>
    [DataContract(Name = "GroupAuditLogEntryDataGroupCalendarEventCreate")]
    public partial class GroupAuditLogEntryDataGroupCalendarEventCreate : IEquatable<GroupAuditLogEntryDataGroupCalendarEventCreate>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets AccessType
        /// </summary>
        [DataMember(Name = "accessType", IsRequired = true, EmitDefaultValue = true)]
        public CalendarEventAccess AccessType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLogEntryDataGroupCalendarEventCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GroupAuditLogEntryDataGroupCalendarEventCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLogEntryDataGroupCalendarEventCreate" /> class.
        /// </summary>
        /// <param name="accessType">accessType (required).</param>
        /// <param name="description">The description of the calendar event. (required).</param>
        /// <param name="imageId">imageId (required).</param>
        /// <param name="title">The title of the calendar event. (required).</param>
        /// <param name="type">The type of calendar entry. (required).</param>
        public GroupAuditLogEntryDataGroupCalendarEventCreate(CalendarEventAccess accessType = default, string description = default, string imageId = default, string title = default, string type = default)
        {
            this.AccessType = accessType;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Description = description;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.ImageId = imageId;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Title = title;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Type = type;
        }

        /// <summary>
        /// The description of the calendar event.
        /// </summary>
        /// <value>The description of the calendar event.</value>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets ImageId
        /// </summary>
        /*
        <example>file_ce35d830-e20a-4df0-a6d4-5aaef4508044</example>
        */
        [DataMember(Name = "imageId", IsRequired = true, EmitDefaultValue = true)]
        public string ImageId { get; set; }

        /// <summary>
        /// The title of the calendar event.
        /// </summary>
        /// <value>The title of the calendar event.</value>
        [DataMember(Name = "title", IsRequired = true, EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// The type of calendar entry.
        /// </summary>
        /// <value>The type of calendar entry.</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GroupAuditLogEntryDataGroupCalendarEventCreate {\n");
            sb.Append("  AccessType: ").Append(AccessType).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ImageId: ").Append(ImageId).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as GroupAuditLogEntryDataGroupCalendarEventCreate);
        }

        /// <summary>
        /// Returns true if GroupAuditLogEntryDataGroupCalendarEventCreate instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupAuditLogEntryDataGroupCalendarEventCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupAuditLogEntryDataGroupCalendarEventCreate input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccessType == input.AccessType ||
                    this.AccessType.Equals(input.AccessType)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.ImageId == input.ImageId ||
                    (this.ImageId != null &&
                    this.ImageId.Equals(input.ImageId))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                hashCode = (hashCode * 59) + this.AccessType.GetHashCode();
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.ImageId != null)
                {
                    hashCode = (hashCode * 59) + this.ImageId.GetHashCode();
                }
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
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
