

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
    /// The &#x60;eventType&#x60; of an audit log entry and the &#x60;data&#x60; that goes with it.
    /// </summary>
    [DataContract(Name = "GroupAuditLogEntryEvent")]
    public partial class GroupAuditLogEntryEvent : IEquatable<GroupAuditLogEntryEvent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLogEntryEvent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GroupAuditLogEntryEvent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLogEntryEvent" /> class.
        /// </summary>
        /// <param name="data">data (required).</param>
        /// <param name="eventType">eventType (required).</param>
        /// <param name="targetId">targetId (required).</param>
        public GroupAuditLogEntryEvent(GroupAuditLogEntryEventData data = default, string eventType = default, string targetId = default)
        {
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Data = data;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.EventType = eventType;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.TargetId = targetId;
        }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", IsRequired = true, EmitDefaultValue = true)]
        public GroupAuditLogEntryEventData Data { get; set; }

        /// <summary>
        /// Gets or Sets EventType
        /// </summary>
        [DataMember(Name = "eventType", IsRequired = true, EmitDefaultValue = true)]
        public string EventType { get; set; }

        /// <summary>
        /// Gets or Sets TargetId
        /// </summary>
        [DataMember(Name = "targetId", IsRequired = true, EmitDefaultValue = true)]
        public string TargetId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GroupAuditLogEntryEvent {\n");
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
            return this.Equals(input as GroupAuditLogEntryEvent);
        }

        /// <summary>
        /// Returns true if GroupAuditLogEntryEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupAuditLogEntryEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupAuditLogEntryEvent input)
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
                    (this.EventType != null &&
                    this.EventType.Equals(input.EventType))
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
                if (this.EventType != null)
                {
                    hashCode = (hashCode * 59) + this.EventType.GetHashCode();
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
