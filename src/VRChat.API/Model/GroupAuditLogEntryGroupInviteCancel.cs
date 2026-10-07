

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
    /// GroupAuditLogEntryGroupInviteCancel
    /// </summary>
    [DataContract(Name = "GroupAuditLogEntryGroupInviteCancel")]
    public partial class GroupAuditLogEntryGroupInviteCancel : IEquatable<GroupAuditLogEntryGroupInviteCancel>, IValidatableObject
    {
        /// <summary>
        /// Defines EventType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EventTypeEnum
        {
            /// <summary>
            /// Enum GroupInviteCancel for value: group.invite.cancel
            /// </summary>
            [EnumMember(Value = "group.invite.cancel")]
            GroupInviteCancel = 1
        }


        /// <summary>
        /// Gets or Sets EventType
        /// </summary>
        [DataMember(Name = "eventType", IsRequired = true, EmitDefaultValue = true)]
        public EventTypeEnum EventType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLogEntryGroupInviteCancel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GroupAuditLogEntryGroupInviteCancel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLogEntryGroupInviteCancel" /> class.
        /// </summary>
        /// <param name="data">data (required).</param>
        /// <param name="eventType">eventType (required).</param>
        /// <param name="targetId">A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed. (required).</param>
        public GroupAuditLogEntryGroupInviteCancel(Object data = default, EventTypeEnum eventType = default, string targetId = default)
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
        public Object Data { get; set; }

        /// <summary>
        /// A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed.
        /// </summary>
        /// <value>A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed.</value>
        /*
        <example>usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469</example>
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
            sb.Append("class GroupAuditLogEntryGroupInviteCancel {\n");
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
            return this.Equals(input as GroupAuditLogEntryGroupInviteCancel);
        }

        /// <summary>
        /// Returns true if GroupAuditLogEntryGroupInviteCancel instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupAuditLogEntryGroupInviteCancel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupAuditLogEntryGroupInviteCancel input)
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
