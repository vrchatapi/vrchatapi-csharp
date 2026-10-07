

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
    /// GroupAuditLogEntryDataGroupRoleCreate
    /// </summary>
    [DataContract(Name = "GroupAuditLogEntryDataGroupRoleCreate")]
    public partial class GroupAuditLogEntryDataGroupRoleCreate : IEquatable<GroupAuditLogEntryDataGroupRoleCreate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLogEntryDataGroupRoleCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GroupAuditLogEntryDataGroupRoleCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLogEntryDataGroupRoleCreate" /> class.
        /// </summary>
        /// <param name="description">The role description. (required).</param>
        /// <param name="isAddedOnJoin">Whether the role is automatically assigned on join. (required).</param>
        /// <param name="isSelfAssignable">Whether users can self-assign this role. (required).</param>
        /// <param name="name">The role name. (required).</param>
        /// <param name="order">The display order of the role..</param>
        /// <param name="permissions">The permissions assigned to this role. (required).</param>
        /// <param name="requiresPurchase">Whether the role requires a purchase. (required).</param>
        /// <param name="requiresTwoFactor">Whether the role requires two-factor authentication. (required).</param>
        /// <param name="groupId">The group ID. (required).</param>
        /// <param name="lastUpdatedByUserId">The ID of the user who last updated the role. (required).</param>
        public GroupAuditLogEntryDataGroupRoleCreate(string description = default, bool isAddedOnJoin = default, bool isSelfAssignable = default, string name = default, int order = default, List<GroupPermissions> permissions = default, bool requiresPurchase = default, bool requiresTwoFactor = default, string groupId = default, string lastUpdatedByUserId = default)
        {
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Description = description;
            this.IsAddedOnJoin = isAddedOnJoin;
            this.IsSelfAssignable = isSelfAssignable;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Name = name;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Permissions = permissions;
            this.RequiresPurchase = requiresPurchase;
            this.RequiresTwoFactor = requiresTwoFactor;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.GroupId = groupId;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.LastUpdatedByUserId = lastUpdatedByUserId;
            this.Order = order;
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
        [DataMember(Name = "order", EmitDefaultValue = false)]
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
        /// The group ID.
        /// </summary>
        /// <value>The group ID.</value>
        [DataMember(Name = "groupId", IsRequired = true, EmitDefaultValue = true)]
        public string GroupId { get; set; }

        /// <summary>
        /// The ID of the user who last updated the role.
        /// </summary>
        /// <value>The ID of the user who last updated the role.</value>
        [DataMember(Name = "lastUpdatedByUserId", IsRequired = true, EmitDefaultValue = true)]
        public string LastUpdatedByUserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GroupAuditLogEntryDataGroupRoleCreate {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  IsAddedOnJoin: ").Append(IsAddedOnJoin).Append("\n");
            sb.Append("  IsSelfAssignable: ").Append(IsSelfAssignable).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  Permissions: ").Append(Permissions).Append("\n");
            sb.Append("  RequiresPurchase: ").Append(RequiresPurchase).Append("\n");
            sb.Append("  RequiresTwoFactor: ").Append(RequiresTwoFactor).Append("\n");
            sb.Append("  GroupId: ").Append(GroupId).Append("\n");
            sb.Append("  LastUpdatedByUserId: ").Append(LastUpdatedByUserId).Append("\n");
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
            return this.Equals(input as GroupAuditLogEntryDataGroupRoleCreate);
        }

        /// <summary>
        /// Returns true if GroupAuditLogEntryDataGroupRoleCreate instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupAuditLogEntryDataGroupRoleCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupAuditLogEntryDataGroupRoleCreate input)
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
                    this.GroupId == input.GroupId ||
                    (this.GroupId != null &&
                    this.GroupId.Equals(input.GroupId))
                ) && 
                (
                    this.LastUpdatedByUserId == input.LastUpdatedByUserId ||
                    (this.LastUpdatedByUserId != null &&
                    this.LastUpdatedByUserId.Equals(input.LastUpdatedByUserId))
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
                if (this.GroupId != null)
                {
                    hashCode = (hashCode * 59) + this.GroupId.GetHashCode();
                }
                if (this.LastUpdatedByUserId != null)
                {
                    hashCode = (hashCode * 59) + this.LastUpdatedByUserId.GetHashCode();
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
