

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
    /// GroupAuditLogEntryDataGroupMemberRole
    /// </summary>
    [DataContract(Name = "GroupAuditLogEntryDataGroupMemberRole")]
    public partial class GroupAuditLogEntryDataGroupMemberRole : IEquatable<GroupAuditLogEntryDataGroupMemberRole>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLogEntryDataGroupMemberRole" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GroupAuditLogEntryDataGroupMemberRole() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLogEntryDataGroupMemberRole" /> class.
        /// </summary>
        /// <param name="roleId">roleId (required).</param>
        /// <param name="roleName">The name of the role that was assigned or unassigned. (required).</param>
        public GroupAuditLogEntryDataGroupMemberRole(string roleId = default, string roleName = default)
        {
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.RoleId = roleId;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.RoleName = roleName;
        }

        /// <summary>
        /// Gets or Sets RoleId
        /// </summary>
        /*
        <example>grol_459d3911-f672-44bc-b84d-e54ffe7960fe</example>
        */
        [DataMember(Name = "roleId", IsRequired = true, EmitDefaultValue = true)]
        public string RoleId { get; set; }

        /// <summary>
        /// The name of the role that was assigned or unassigned.
        /// </summary>
        /// <value>The name of the role that was assigned or unassigned.</value>
        [DataMember(Name = "roleName", IsRequired = true, EmitDefaultValue = true)]
        public string RoleName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GroupAuditLogEntryDataGroupMemberRole {\n");
            sb.Append("  RoleId: ").Append(RoleId).Append("\n");
            sb.Append("  RoleName: ").Append(RoleName).Append("\n");
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
            return this.Equals(input as GroupAuditLogEntryDataGroupMemberRole);
        }

        /// <summary>
        /// Returns true if GroupAuditLogEntryDataGroupMemberRole instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupAuditLogEntryDataGroupMemberRole to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupAuditLogEntryDataGroupMemberRole input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.RoleId == input.RoleId ||
                    (this.RoleId != null &&
                    this.RoleId.Equals(input.RoleId))
                ) && 
                (
                    this.RoleName == input.RoleName ||
                    (this.RoleName != null &&
                    this.RoleName.Equals(input.RoleName))
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
                if (this.RoleId != null)
                {
                    hashCode = (hashCode * 59) + this.RoleId.GetHashCode();
                }
                if (this.RoleName != null)
                {
                    hashCode = (hashCode * 59) + this.RoleName.GetHashCode();
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
