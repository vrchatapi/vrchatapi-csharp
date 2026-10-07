

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
    /// GroupAuditLogEntryDataGroupRoleDelete
    /// </summary>
    [DataContract(Name = "GroupAuditLogEntryDataGroupRoleDelete")]
    public partial class GroupAuditLogEntryDataGroupRoleDelete : IEquatable<GroupAuditLogEntryDataGroupRoleDelete>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLogEntryDataGroupRoleDelete" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GroupAuditLogEntryDataGroupRoleDelete() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLogEntryDataGroupRoleDelete" /> class.
        /// </summary>
        /// <param name="description">The role description. (required).</param>
        /// <param name="isAddedOnJoin">Whether the role is automatically assigned on join. (required).</param>
        /// <param name="isSelfAssignable">Whether users can self-assign this role. (required).</param>
        /// <param name="name">The role name. (required).</param>
        /// <param name="order">The display order of the role. (required).</param>
        /// <param name="permissions">The permissions assigned to this role. (required).</param>
        /// <param name="requiresPurchase">Whether the role requires a purchase. (required).</param>
        /// <param name="requiresTwoFactor">Whether the role requires two-factor authentication. (required).</param>
        /// <param name="createdAt">The creation timestamp of the role. (required).</param>
        /// <param name="defaultRole">Whether the role is the group&#39;s default role. (required).</param>
        /// <param name="isManagementRole">Whether the role is a management role. (required).</param>
        public GroupAuditLogEntryDataGroupRoleDelete(string description = default, bool isAddedOnJoin = default, bool isSelfAssignable = default, string name = default, int order = default, List<GroupPermissions> permissions = default, bool requiresPurchase = default, bool requiresTwoFactor = default, DateTime createdAt = default, bool defaultRole = default, bool isManagementRole = default)
        {
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Description = description;
            this.IsAddedOnJoin = isAddedOnJoin;
            this.IsSelfAssignable = isSelfAssignable;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Name = name;
            this.Order = order;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Permissions = permissions;
            this.RequiresPurchase = requiresPurchase;
            this.RequiresTwoFactor = requiresTwoFactor;
            this.CreatedAt = createdAt;
            this.DefaultRole = defaultRole;
            this.IsManagementRole = isManagementRole;
        }

        /// <summary>
        /// The role description.
        /// </summary>
        /// <value>The role description.</value>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Whether the role is automatically assigned on join.
        /// </summary>
        /// <value>Whether the role is automatically assigned on join.</value>
        [DataMember(Name = "isAddedOnJoin", IsRequired = true, EmitDefaultValue = true)]
        public bool IsAddedOnJoin { get; set; }

        /// <summary>
        /// Whether users can self-assign this role.
        /// </summary>
        /// <value>Whether users can self-assign this role.</value>
        [DataMember(Name = "isSelfAssignable", IsRequired = true, EmitDefaultValue = true)]
        public bool IsSelfAssignable { get; set; }

        /// <summary>
        /// The role name.
        /// </summary>
        /// <value>The role name.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The display order of the role.
        /// </summary>
        /// <value>The display order of the role.</value>
        [DataMember(Name = "order", IsRequired = true, EmitDefaultValue = true)]
        public int Order { get; set; }

        /// <summary>
        /// The permissions assigned to this role.
        /// </summary>
        /// <value>The permissions assigned to this role.</value>
        [DataMember(Name = "permissions", IsRequired = true, EmitDefaultValue = true)]
        public List<GroupPermissions> Permissions { get; set; }

        /// <summary>
        /// Whether the role requires a purchase.
        /// </summary>
        /// <value>Whether the role requires a purchase.</value>
        [DataMember(Name = "requiresPurchase", IsRequired = true, EmitDefaultValue = true)]
        public bool RequiresPurchase { get; set; }

        /// <summary>
        /// Whether the role requires two-factor authentication.
        /// </summary>
        /// <value>Whether the role requires two-factor authentication.</value>
        [DataMember(Name = "requiresTwoFactor", IsRequired = true, EmitDefaultValue = true)]
        public bool RequiresTwoFactor { get; set; }

        /// <summary>
        /// The creation timestamp of the role.
        /// </summary>
        /// <value>The creation timestamp of the role.</value>
        [DataMember(Name = "createdAt", IsRequired = true, EmitDefaultValue = true)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Whether the role is the group&#39;s default role.
        /// </summary>
        /// <value>Whether the role is the group&#39;s default role.</value>
        [DataMember(Name = "defaultRole", IsRequired = true, EmitDefaultValue = true)]
        public bool DefaultRole { get; set; }

        /// <summary>
        /// Whether the role is a management role.
        /// </summary>
        /// <value>Whether the role is a management role.</value>
        [DataMember(Name = "isManagementRole", IsRequired = true, EmitDefaultValue = true)]
        public bool IsManagementRole { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GroupAuditLogEntryDataGroupRoleDelete {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  IsAddedOnJoin: ").Append(IsAddedOnJoin).Append("\n");
            sb.Append("  IsSelfAssignable: ").Append(IsSelfAssignable).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  Permissions: ").Append(Permissions).Append("\n");
            sb.Append("  RequiresPurchase: ").Append(RequiresPurchase).Append("\n");
            sb.Append("  RequiresTwoFactor: ").Append(RequiresTwoFactor).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  DefaultRole: ").Append(DefaultRole).Append("\n");
            sb.Append("  IsManagementRole: ").Append(IsManagementRole).Append("\n");
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
            return this.Equals(input as GroupAuditLogEntryDataGroupRoleDelete);
        }

        /// <summary>
        /// Returns true if GroupAuditLogEntryDataGroupRoleDelete instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupAuditLogEntryDataGroupRoleDelete to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupAuditLogEntryDataGroupRoleDelete input)
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
                    this.IsAddedOnJoin.Equals(input.IsAddedOnJoin)
                ) && 
                (
                    this.IsSelfAssignable == input.IsSelfAssignable ||
                    this.IsSelfAssignable.Equals(input.IsSelfAssignable)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Order == input.Order ||
                    this.Order.Equals(input.Order)
                ) && 
                (
                    this.Permissions == input.Permissions ||
                    this.Permissions != null &&
                    input.Permissions != null &&
                    this.Permissions.SequenceEqual(input.Permissions)
                ) && 
                (
                    this.RequiresPurchase == input.RequiresPurchase ||
                    this.RequiresPurchase.Equals(input.RequiresPurchase)
                ) && 
                (
                    this.RequiresTwoFactor == input.RequiresTwoFactor ||
                    this.RequiresTwoFactor.Equals(input.RequiresTwoFactor)
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    this.CreatedAt.Equals(input.CreatedAt)
                ) && 
                (
                    this.DefaultRole == input.DefaultRole ||
                    this.DefaultRole.Equals(input.DefaultRole)
                ) && 
                (
                    this.IsManagementRole == input.IsManagementRole ||
                    this.IsManagementRole.Equals(input.IsManagementRole)
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
                hashCode = (hashCode * 59) + this.IsAddedOnJoin.GetHashCode();
                hashCode = (hashCode * 59) + this.IsSelfAssignable.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Order.GetHashCode();
                if (this.Permissions != null)
                {
                    hashCode = (hashCode * 59) + this.Permissions.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.RequiresPurchase.GetHashCode();
                hashCode = (hashCode * 59) + this.RequiresTwoFactor.GetHashCode();
                hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                hashCode = (hashCode * 59) + this.DefaultRole.GetHashCode();
                hashCode = (hashCode * 59) + this.IsManagementRole.GetHashCode();
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
