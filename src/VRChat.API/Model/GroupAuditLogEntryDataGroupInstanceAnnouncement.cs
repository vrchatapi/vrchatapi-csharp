

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
    /// GroupAuditLogEntryDataGroupInstanceAnnouncement
    /// </summary>
    [DataContract(Name = "GroupAuditLogEntryDataGroupInstanceAnnouncement")]
    public partial class GroupAuditLogEntryDataGroupInstanceAnnouncement : IEquatable<GroupAuditLogEntryDataGroupInstanceAnnouncement>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLogEntryDataGroupInstanceAnnouncement" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GroupAuditLogEntryDataGroupInstanceAnnouncement() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLogEntryDataGroupInstanceAnnouncement" /> class.
        /// </summary>
        /// <param name="message">The announcement message. (required).</param>
        /// <param name="title">The announcement title. (required).</param>
        public GroupAuditLogEntryDataGroupInstanceAnnouncement(string message = default, string title = default)
        {
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Message = message;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Title = title;
        }

        /// <summary>
        /// The announcement message.
        /// </summary>
        /// <value>The announcement message.</value>
        [DataMember(Name = "message", IsRequired = true, EmitDefaultValue = true)]
        public string Message { get; set; }

        /// <summary>
        /// The announcement title.
        /// </summary>
        /// <value>The announcement title.</value>
        [DataMember(Name = "title", IsRequired = true, EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GroupAuditLogEntryDataGroupInstanceAnnouncement {\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
            return this.Equals(input as GroupAuditLogEntryDataGroupInstanceAnnouncement);
        }

        /// <summary>
        /// Returns true if GroupAuditLogEntryDataGroupInstanceAnnouncement instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupAuditLogEntryDataGroupInstanceAnnouncement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupAuditLogEntryDataGroupInstanceAnnouncement input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
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
                if (this.Message != null)
                {
                    hashCode = (hashCode * 59) + this.Message.GetHashCode();
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
