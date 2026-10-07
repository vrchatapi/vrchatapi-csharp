

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
    [DataContract(Name = "GroupAuditLogEntryDataGroupGalleryUpdate")]
    public partial class GroupAuditLogEntryDataGroupGalleryUpdate : IEquatable<GroupAuditLogEntryDataGroupGalleryUpdate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLogEntryDataGroupGalleryUpdate" /> class.
        /// </summary>
        /// <param name="membersOnly">membersOnly.</param>
        /// <param name="name">name.</param>
        public GroupAuditLogEntryDataGroupGalleryUpdate(GroupAuditLogEntryBooleanChange membersOnly = default, GroupAuditLogEntryStringChange name = default)
        {
            this.MembersOnly = membersOnly;
            this.Name = name;
        }

        /// <summary>
        /// Gets or Sets MembersOnly
        /// </summary>
        [DataMember(Name = "membersOnly", EmitDefaultValue = false)]
        public GroupAuditLogEntryBooleanChange MembersOnly { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public GroupAuditLogEntryStringChange Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GroupAuditLogEntryDataGroupGalleryUpdate {\n");
            sb.Append("  MembersOnly: ").Append(MembersOnly).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as GroupAuditLogEntryDataGroupGalleryUpdate);
        }

        /// <summary>
        /// Returns true if GroupAuditLogEntryDataGroupGalleryUpdate instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupAuditLogEntryDataGroupGalleryUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupAuditLogEntryDataGroupGalleryUpdate input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MembersOnly == input.MembersOnly ||
                    (this.MembersOnly != null &&
                    this.MembersOnly.Equals(input.MembersOnly))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.MembersOnly != null)
                {
                    hashCode = (hashCode * 59) + this.MembersOnly.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
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
