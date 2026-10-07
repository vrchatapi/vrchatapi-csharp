

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
    /// GroupAuditLogEntryGroupGalleryCreate
    /// </summary>
    [DataContract(Name = "GroupAuditLogEntryGroupGalleryCreate")]
    public partial class GroupAuditLogEntryGroupGalleryCreate : IEquatable<GroupAuditLogEntryGroupGalleryCreate>, IValidatableObject
    {
        /// <summary>
        /// Defines EventType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EventTypeEnum
        {
            /// <summary>
            /// Enum GroupGalleryCreate for value: group.gallery.create
            /// </summary>
            [EnumMember(Value = "group.gallery.create")]
            GroupGalleryCreate = 1
        }


        /// <summary>
        /// Gets or Sets EventType
        /// </summary>
        [DataMember(Name = "eventType", IsRequired = true, EmitDefaultValue = true)]
        public EventTypeEnum EventType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLogEntryGroupGalleryCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GroupAuditLogEntryGroupGalleryCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLogEntryGroupGalleryCreate" /> class.
        /// </summary>
        /// <param name="data">data (required).</param>
        /// <param name="eventType">eventType (required).</param>
        /// <param name="targetId">targetId (required).</param>
        public GroupAuditLogEntryGroupGalleryCreate(GroupAuditLogEntryDataGroupGalleryCreate data = default, EventTypeEnum eventType = default, string targetId = default)
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
        public GroupAuditLogEntryDataGroupGalleryCreate Data { get; set; }

        /// <summary>
        /// Gets or Sets TargetId
        /// </summary>
        /*
        <example>ggal_a03a4b55-4ca6-4490-9519-40ba6351a233</example>
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
            sb.Append("class GroupAuditLogEntryGroupGalleryCreate {\n");
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
            return this.Equals(input as GroupAuditLogEntryGroupGalleryCreate);
        }

        /// <summary>
        /// Returns true if GroupAuditLogEntryGroupGalleryCreate instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupAuditLogEntryGroupGalleryCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupAuditLogEntryGroupGalleryCreate input)
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
