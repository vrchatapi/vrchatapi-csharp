

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
    /// Carries only the fields the update changed.
    /// </summary>
    [DataContract(Name = "GroupAuditLogEntryDataGroupMemberUserUpdate")]
    public partial class GroupAuditLogEntryDataGroupMemberUserUpdate : IEquatable<GroupAuditLogEntryDataGroupMemberUserUpdate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLogEntryDataGroupMemberUserUpdate" /> class.
        /// </summary>
        /// <param name="managerNotes">managerNotes.</param>
        public GroupAuditLogEntryDataGroupMemberUserUpdate(GroupAuditLogEntryStringChange managerNotes = default)
        {
            this.ManagerNotes = managerNotes;
        }

        /// <summary>
        /// Gets or Sets ManagerNotes
        /// </summary>
        [DataMember(Name = "managerNotes", EmitDefaultValue = false)]
        public GroupAuditLogEntryStringChange ManagerNotes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GroupAuditLogEntryDataGroupMemberUserUpdate {\n");
            sb.Append("  ManagerNotes: ").Append(ManagerNotes).Append("\n");
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
            return this.Equals(input as GroupAuditLogEntryDataGroupMemberUserUpdate);
        }

        /// <summary>
        /// Returns true if GroupAuditLogEntryDataGroupMemberUserUpdate instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupAuditLogEntryDataGroupMemberUserUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupAuditLogEntryDataGroupMemberUserUpdate input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ManagerNotes == input.ManagerNotes ||
                    (this.ManagerNotes != null &&
                    this.ManagerNotes.Equals(input.ManagerNotes))
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
                if (this.ManagerNotes != null)
                {
                    hashCode = (hashCode * 59) + this.ManagerNotes.GetHashCode();
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
