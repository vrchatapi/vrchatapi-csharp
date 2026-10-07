

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
    /// GroupAuditLogEntryGroupUserUnban
    /// </summary>
    [DataContract(Name = "GroupAuditLogEntryGroupUserUnban")]
    public partial class GroupAuditLogEntryGroupUserUnban : IEquatable<GroupAuditLogEntryGroupUserUnban>, IValidatableObject
    {
        /// <summary>
        /// Defines EventType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EventTypeEnum
        {
            /// <summary>
            /// Enum GroupUserUnban for value: group.user.unban
            /// </summary>
            [EnumMember(Value = "group.user.unban")]
            GroupUserUnban = 1
        }


        /// <summary>
        /// Gets or Sets EventType
        /// </summary>
        [DataMember(Name = "eventType", IsRequired = true, EmitDefaultValue = true)]
        public EventTypeEnum EventType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLogEntryGroupUserUnban" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GroupAuditLogEntryGroupUserUnban() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLogEntryGroupUserUnban" /> class.
        /// </summary>
        /// <param name="actorDisplayName">The display name of the user who performed the action. (required).</param>
        /// <param name="actorId">The ID of the user who performed the action. (required).</param>
        /// <param name="createdAt">When the action was performed. (required).</param>
        /// <param name="description">A human-readable description of the event. (required).</param>
        /// <param name="eventType">eventType (required).</param>
        /// <param name="groupId">The ID of the group the entry belongs to. (required).</param>
        /// <param name="id">The unique ID of this audit log entry. (required).</param>
        /// <param name="data">data (required).</param>
        /// <param name="targetId">A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed. (required).</param>
        public GroupAuditLogEntryGroupUserUnban(string actorDisplayName = default, string actorId = default, DateTime createdAt = default, string description = default, EventTypeEnum eventType = default, string groupId = default, string id = default, Object data = default, string targetId = default)
        {
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.ActorDisplayName = actorDisplayName;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.ActorId = actorId;
            this.CreatedAt = createdAt;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Description = description;
            this.EventType = eventType;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.GroupId = groupId;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Id = id;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Data = data;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.TargetId = targetId;
        }

        /// <summary>
        /// The display name of the user who performed the action.
        /// </summary>
        /// <value>The display name of the user who performed the action.</value>
        [DataMember(Name = "actorDisplayName", IsRequired = true, EmitDefaultValue = true)]
        public string ActorDisplayName { get; set; }

        /// <summary>
        /// The ID of the user who performed the action.
        /// </summary>
        /// <value>The ID of the user who performed the action.</value>
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
        /// The ID of the group the entry belongs to.
        /// </summary>
        /// <value>The ID of the group the entry belongs to.</value>
        [DataMember(Name = "groupId", IsRequired = true, EmitDefaultValue = true)]
        public string GroupId { get; set; }

        /// <summary>
        /// The unique ID of this audit log entry.
        /// </summary>
        /// <value>The unique ID of this audit log entry.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", IsRequired = true, EmitDefaultValue = true)]
        public Object Data { get; set; }

        /// <summary>
        /// A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed.
        /// </summary>
        /// <value>A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed.</value>
        [DataMember(Name = "targetId", IsRequired = true, EmitDefaultValue = true)]
        public string TargetId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GroupAuditLogEntryGroupUserUnban {\n");
            sb.Append("  ActorDisplayName: ").Append(ActorDisplayName).Append("\n");
            sb.Append("  ActorId: ").Append(ActorId).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
            sb.Append("  GroupId: ").Append(GroupId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  TargetId: ").Append(TargetId).Append("\n");
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
            return this.Equals(input as GroupAuditLogEntryGroupUserUnban);
        }

        /// <summary>
        /// Returns true if GroupAuditLogEntryGroupUserUnban instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupAuditLogEntryGroupUserUnban to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupAuditLogEntryGroupUserUnban input)
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
                    this.EventType.Equals(input.EventType)
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
                ) && 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
                ) && 
                (
                    this.TargetId == input.TargetId ||
                    (this.TargetId != null &&
                    this.TargetId.Equals(input.TargetId))
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
                hashCode = (hashCode * 59) + this.EventType.GetHashCode();
                if (this.GroupId != null)
                {
                    hashCode = (hashCode * 59) + this.GroupId.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Data != null)
                {
                    hashCode = (hashCode * 59) + this.Data.GetHashCode();
                }
                if (this.TargetId != null)
                {
                    hashCode = (hashCode * 59) + this.TargetId.GetHashCode();
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
