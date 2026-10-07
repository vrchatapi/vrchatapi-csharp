

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
    [DataContract(Name = "GroupAuditLogEntryDataGroupRoleUpdate")]
    public partial class GroupAuditLogEntryDataGroupRoleUpdate : IEquatable<GroupAuditLogEntryDataGroupRoleUpdate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLogEntryDataGroupRoleUpdate" /> class.
        /// </summary>
        /// <param name="description">description.</param>
        /// <param name="isAddedOnJoin">isAddedOnJoin.</param>
        /// <param name="isSelfAssignable">isSelfAssignable.</param>
        /// <param name="name">name.</param>
        /// <param name="order">order.</param>
        /// <param name="permissions">permissions.</param>
        public GroupAuditLogEntryDataGroupRoleUpdate(GroupAuditLogEntryStringChange description = default, GroupAuditLogEntryBooleanChange isAddedOnJoin = default, GroupAuditLogEntryBooleanChange isSelfAssignable = default, GroupAuditLogEntryStringChange name = default, GroupAuditLogEntryIntegerChange order = default, GroupAuditLogEntryStringListChange permissions = default)
        {
            this.Description = description;
            this.IsAddedOnJoin = isAddedOnJoin;
            this.IsSelfAssignable = isSelfAssignable;
            this.Name = name;
            this.Order = order;
            this.Permissions = permissions;
        }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public GroupAuditLogEntryStringChange Description { get; set; }

        /// <summary>
        /// Gets or Sets IsAddedOnJoin
        /// </summary>
        [DataMember(Name = "isAddedOnJoin", EmitDefaultValue = false)]
        public GroupAuditLogEntryBooleanChange IsAddedOnJoin { get; set; }

        /// <summary>
        /// Gets or Sets IsSelfAssignable
        /// </summary>
        [DataMember(Name = "isSelfAssignable", EmitDefaultValue = false)]
        public GroupAuditLogEntryBooleanChange IsSelfAssignable { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public GroupAuditLogEntryStringChange Name { get; set; }

        /// <summary>
        /// Gets or Sets Order
        /// </summary>
        [DataMember(Name = "order", EmitDefaultValue = false)]
        public GroupAuditLogEntryIntegerChange Order { get; set; }

        /// <summary>
        /// Gets or Sets Permissions
        /// </summary>
        [DataMember(Name = "permissions", EmitDefaultValue = false)]
        public GroupAuditLogEntryStringListChange Permissions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GroupAuditLogEntryDataGroupRoleUpdate {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  IsAddedOnJoin: ").Append(IsAddedOnJoin).Append("\n");
            sb.Append("  IsSelfAssignable: ").Append(IsSelfAssignable).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  Permissions: ").Append(Permissions).Append("\n");
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
            return this.Equals(input as GroupAuditLogEntryDataGroupRoleUpdate);
        }

        /// <summary>
        /// Returns true if GroupAuditLogEntryDataGroupRoleUpdate instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupAuditLogEntryDataGroupRoleUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupAuditLogEntryDataGroupRoleUpdate input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.IsAddedOnJoin == input.IsAddedOnJoin ||
                    (this.IsAddedOnJoin != null &&
                    this.IsAddedOnJoin.Equals(input.IsAddedOnJoin))
                ) && 
                (
                    this.IsSelfAssignable == input.IsSelfAssignable ||
                    (this.IsSelfAssignable != null &&
                    this.IsSelfAssignable.Equals(input.IsSelfAssignable))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Order == input.Order ||
                    (this.Order != null &&
                    this.Order.Equals(input.Order))
                ) && 
                (
                    this.Permissions == input.Permissions ||
                    (this.Permissions != null &&
                    this.Permissions.Equals(input.Permissions))
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
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.IsAddedOnJoin != null)
                {
                    hashCode = (hashCode * 59) + this.IsAddedOnJoin.GetHashCode();
                }
                if (this.IsSelfAssignable != null)
                {
                    hashCode = (hashCode * 59) + this.IsSelfAssignable.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Order != null)
                {
                    hashCode = (hashCode * 59) + this.Order.GetHashCode();
                }
                if (this.Permissions != null)
                {
                    hashCode = (hashCode * 59) + this.Permissions.GetHashCode();
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
