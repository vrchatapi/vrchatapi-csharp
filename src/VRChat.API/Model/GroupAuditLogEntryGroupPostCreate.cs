

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
    /// GroupAuditLogEntryGroupPostCreate
    /// </summary>
    [DataContract(Name = "GroupAuditLogEntryGroupPostCreate")]
    public partial class GroupAuditLogEntryGroupPostCreate : IEquatable<GroupAuditLogEntryGroupPostCreate>, IValidatableObject
    {
        /// <summary>
        /// Defines EventType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EventTypeEnum
        {
            /// <summary>
            /// Enum GroupPostCreate for value: group.post.create
            /// </summary>
            [EnumMember(Value = "group.post.create")]
            GroupPostCreate = 1
        }


        /// <summary>
        /// Gets or Sets EventType
        /// </summary>
        [DataMember(Name = "eventType", IsRequired = true, EmitDefaultValue = true)]
        public EventTypeEnum EventType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLogEntryGroupPostCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GroupAuditLogEntryGroupPostCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLogEntryGroupPostCreate" /> class.
        /// </summary>
        /// <param name="data">data (required).</param>
        /// <param name="eventType">eventType (required).</param>
        /// <param name="targetId">targetId (required).</param>
        public GroupAuditLogEntryGroupPostCreate(GroupAuditLogEntryDataGroupPostCreate data = default, EventTypeEnum eventType = default, string targetId = default)
        {
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Data = data;
            this.EventType = eventType;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.TargetId = targetId;
        }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", IsRequired = true, EmitDefaultValue = true)]
        public GroupAuditLogEntryDataGroupPostCreate Data { get; set; }

        /// <summary>
        /// Gets or Sets TargetId
        /// </summary>
        /*
        <example>not_00000000-0000-0000-0000-000000000000</example>
        */
        [DataMember(Name = "targetId", IsRequired = true, EmitDefaultValue = true)]
        public string TargetId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GroupAuditLogEntryGroupPostCreate {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
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
            return this.Equals(input as GroupAuditLogEntryGroupPostCreate);
        }

        /// <summary>
        /// Returns true if GroupAuditLogEntryGroupPostCreate instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupAuditLogEntryGroupPostCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupAuditLogEntryGroupPostCreate input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
                ) && 
                (
                    this.EventType == input.EventType ||
                    this.EventType.Equals(input.EventType)
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
                if (this.Data != null)
                {
                    hashCode = (hashCode * 59) + this.Data.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.EventType.GetHashCode();
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
