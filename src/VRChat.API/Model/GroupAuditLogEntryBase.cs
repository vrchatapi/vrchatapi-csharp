

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
    /// GroupAuditLogEntryBase
    /// </summary>
    [DataContract(Name = "GroupAuditLogEntryBase")]
    public partial class GroupAuditLogEntryBase : IEquatable<GroupAuditLogEntryBase>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLogEntryBase" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GroupAuditLogEntryBase() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLogEntryBase" /> class.
        /// </summary>
        /// <param name="actorDisplayName">The display name of the user who performed the action. (required).</param>
        /// <param name="actorId">A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed. (required).</param>
        /// <param name="createdAt">When the action was performed. (required).</param>
        /// <param name="description">A human-readable description of the event. (required).</param>
        /// <param name="eventType">The type of event that occurred. This is a string that is prefixed with the type of object that the event occurred on. For example, a group role update event would be prefixed with &#x60;group.role&#x60;. (required) (default to &quot;group.update&quot;).</param>
        /// <param name="groupId">groupId (required).</param>
        /// <param name="id">id (required).</param>
        public GroupAuditLogEntryBase(string actorDisplayName = default, string actorId = default, DateTime createdAt = default, string description = default, string eventType = @"group.update", string groupId = default, string id = default)
        {
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.ActorDisplayName = actorDisplayName;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.ActorId = actorId;
            this.CreatedAt = createdAt;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Description = description;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.EventType = eventType;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.GroupId = groupId;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Id = id;
        }

        /// <summary>
        /// The display name of the user who performed the action.
        /// </summary>
        /// <value>The display name of the user who performed the action.</value>
        [DataMember(Name = "actorDisplayName", IsRequired = true, EmitDefaultValue = true)]
        public string ActorDisplayName { get; set; }

        /// <summary>
        /// A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed.
        /// </summary>
        /// <value>A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed.</value>
        /*
        <example>usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469</example>
        */
        [DataMember(Name = "actorId", IsRequired = true, EmitDefaultValue = true)]
        public string ActorId { get; set; }

        /// <summary>
        /// When the action was performed.
        /// </summary>
        /// <value>When the action was performed.</value>
        [DataMember(Name = "created_at", IsRequired = true, EmitDefaultValue = true)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// A human-readable description of the event.
        /// </summary>
        /// <value>A human-readable description of the event.</value>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// The type of event that occurred. This is a string that is prefixed with the type of object that the event occurred on. For example, a group role update event would be prefixed with &#x60;group.role&#x60;.
        /// </summary>
        /// <value>The type of event that occurred. This is a string that is prefixed with the type of object that the event occurred on. For example, a group role update event would be prefixed with &#x60;group.role&#x60;.</value>
        /*
        <example>group.role.update</example>
        */
        [DataMember(Name = "eventType", IsRequired = true, EmitDefaultValue = true)]
        public string EventType { get; set; }

        /// <summary>
        /// Gets or Sets GroupId
        /// </summary>
        /*
        <example>grp_71a7ff59-112c-4e78-a990-c7cc650776e5</example>
        */
        [DataMember(Name = "groupId", IsRequired = true, EmitDefaultValue = true)]
        public string GroupId { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        /*
        <example>gaud_71a7ff59-112c-4e78-a990-c7cc650776e5</example>
        */
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GroupAuditLogEntryBase {\n");
            sb.Append("  ActorDisplayName: ").Append(ActorDisplayName).Append("\n");
            sb.Append("  ActorId: ").Append(ActorId).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
            sb.Append("  GroupId: ").Append(GroupId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(input as GroupAuditLogEntryBase);
        }

        /// <summary>
        /// Returns true if GroupAuditLogEntryBase instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupAuditLogEntryBase to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupAuditLogEntryBase input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ActorDisplayName == input.ActorDisplayName ||
                    (this.ActorDisplayName != null &&
                    this.ActorDisplayName.Equals(input.ActorDisplayName))
                ) && 
                (
                    this.ActorId == input.ActorId ||
                    (this.ActorId != null &&
                    this.ActorId.Equals(input.ActorId))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    this.CreatedAt.Equals(input.CreatedAt)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.EventType == input.EventType ||
                    (this.EventType != null &&
                    this.EventType.Equals(input.EventType))
                ) && 
                (
                    this.GroupId == input.GroupId ||
                    (this.GroupId != null &&
                    this.GroupId.Equals(input.GroupId))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                if (this.ActorDisplayName != null)
                {
                    hashCode = (hashCode * 59) + this.ActorDisplayName.GetHashCode();
                }
                if (this.ActorId != null)
                {
                    hashCode = (hashCode * 59) + this.ActorId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.EventType != null)
                {
                    hashCode = (hashCode * 59) + this.EventType.GetHashCode();
                }
                if (this.GroupId != null)
                {
                    hashCode = (hashCode * 59) + this.GroupId.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
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
