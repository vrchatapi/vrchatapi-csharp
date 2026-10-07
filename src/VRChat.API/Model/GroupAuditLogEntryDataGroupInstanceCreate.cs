

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
    /// GroupAuditLogEntryDataGroupInstanceCreate
    /// </summary>
    [DataContract(Name = "GroupAuditLogEntryDataGroupInstanceCreate")]
    public partial class GroupAuditLogEntryDataGroupInstanceCreate : IEquatable<GroupAuditLogEntryDataGroupInstanceCreate>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets GroupAccessType
        /// </summary>
        [DataMember(Name = "groupAccessType", IsRequired = true, EmitDefaultValue = true)]
        public GroupAccessType GroupAccessType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLogEntryDataGroupInstanceCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GroupAuditLogEntryDataGroupInstanceCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLogEntryDataGroupInstanceCreate" /> class.
        /// </summary>
        /// <param name="calendarEntryId">The calendar entry ID if the instance was created from a calendar event. (required).</param>
        /// <param name="groupAccessType">groupAccessType (required).</param>
        /// <param name="roleIds">The role IDs that have access to the instance. (required).</param>
        public GroupAuditLogEntryDataGroupInstanceCreate(string calendarEntryId = default, GroupAccessType groupAccessType = default, List<string> roleIds = default)
        {
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.CalendarEntryId = calendarEntryId;
            this.GroupAccessType = groupAccessType;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.RoleIds = roleIds;
        }

        /// <summary>
        /// The calendar entry ID if the instance was created from a calendar event.
        /// </summary>
        /// <value>The calendar entry ID if the instance was created from a calendar event.</value>
        [DataMember(Name = "calendarEntryId", IsRequired = true, EmitDefaultValue = true)]
        public string CalendarEntryId { get; set; }

        /// <summary>
        /// The role IDs that have access to the instance.
        /// </summary>
        /// <value>The role IDs that have access to the instance.</value>
        [DataMember(Name = "roleIds", IsRequired = true, EmitDefaultValue = true)]
        public List<string> RoleIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GroupAuditLogEntryDataGroupInstanceCreate {\n");
            sb.Append("  CalendarEntryId: ").Append(CalendarEntryId).Append("\n");
            sb.Append("  GroupAccessType: ").Append(GroupAccessType).Append("\n");
            sb.Append("  RoleIds: ").Append(RoleIds).Append("\n");
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
            return this.Equals(input as GroupAuditLogEntryDataGroupInstanceCreate);
        }

        /// <summary>
        /// Returns true if GroupAuditLogEntryDataGroupInstanceCreate instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupAuditLogEntryDataGroupInstanceCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupAuditLogEntryDataGroupInstanceCreate input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CalendarEntryId == input.CalendarEntryId ||
                    (this.CalendarEntryId != null &&
                    this.CalendarEntryId.Equals(input.CalendarEntryId))
                ) && 
                (
                    this.GroupAccessType == input.GroupAccessType ||
                    this.GroupAccessType.Equals(input.GroupAccessType)
                ) && 
                (
                    this.RoleIds == input.RoleIds ||
                    this.RoleIds != null &&
                    input.RoleIds != null &&
                    this.RoleIds.SequenceEqual(input.RoleIds)
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
                if (this.CalendarEntryId != null)
                {
                    hashCode = (hashCode * 59) + this.CalendarEntryId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.GroupAccessType.GetHashCode();
                if (this.RoleIds != null)
                {
                    hashCode = (hashCode * 59) + this.RoleIds.GetHashCode();
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
