/*
 * VRChat API Documentation
 *
 *
 * The version of the OpenAPI document: 1.20.0
 * Contact: vrchatapi.lpv0t@aries.fyi
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


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
using OpenAPIDateConverter = VRChat.API.Client.OpenAPIDateConverter;

namespace VRChat.API.Model
{
    /// <summary>
    /// GroupRole
    /// </summary>
    [DataContract(Name = "GroupRole")]
    public partial class GroupRole : IEquatable<GroupRole>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupRole" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="groupId">groupId.</param>
        /// <param name="name">name.</param>
        /// <param name="description">description.</param>
        /// <param name="isSelfAssignable">isSelfAssignable (default to false).</param>
        /// <param name="permissions">permissions.</param>
        /// <param name="isManagementRole">isManagementRole (default to false).</param>
        /// <param name="requiresTwoFactor">requiresTwoFactor (default to false).</param>
        /// <param name="requiresPurchase">requiresPurchase (default to false).</param>
        /// <param name="order">order.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="updatedAt">updatedAt.</param>
        public GroupRole(string id = default(string), string groupId = default(string), string name = default(string), string description = default(string), bool isSelfAssignable = false, List<GroupPermissions> permissions = default(List<GroupPermissions>), bool isManagementRole = false, bool requiresTwoFactor = false, bool requiresPurchase = false, int order = default(int), DateTime createdAt = default(DateTime), DateTime updatedAt = default(DateTime))
        {
            this.Id = id;
            this.GroupId = groupId;
            this.Name = name;
            this.Description = description;
            this.IsSelfAssignable = isSelfAssignable;
            this.Permissions = permissions;
            this.IsManagementRole = isManagementRole;
            this.RequiresTwoFactor = requiresTwoFactor;
            this.RequiresPurchase = requiresPurchase;
            this.Order = order;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets GroupId
        /// </summary>
        [DataMember(Name = "groupId", EmitDefaultValue = false)]
        public string GroupId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets IsSelfAssignable
        /// </summary>
        [DataMember(Name = "isSelfAssignable", EmitDefaultValue = true)]
        public bool IsSelfAssignable { get; set; }

        /// <summary>
        /// Gets or Sets Permissions
        /// </summary>
        [DataMember(Name = "permissions", EmitDefaultValue = false)]
        public List<GroupPermissions> Permissions { get; set; }

        /// <summary>
        /// Gets or Sets IsManagementRole
        /// </summary>
        [DataMember(Name = "isManagementRole", EmitDefaultValue = true)]
        public bool IsManagementRole { get; set; }

        /// <summary>
        /// Gets or Sets RequiresTwoFactor
        /// </summary>
        [DataMember(Name = "requiresTwoFactor", EmitDefaultValue = true)]
        public bool RequiresTwoFactor { get; set; }

        /// <summary>
        /// Gets or Sets RequiresPurchase
        /// </summary>
        [DataMember(Name = "requiresPurchase", EmitDefaultValue = true)]
        public bool RequiresPurchase { get; set; }

        /// <summary>
        /// Gets or Sets Order
        /// </summary>
        [DataMember(Name = "order", EmitDefaultValue = false)]
        public int Order { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "createdAt", EmitDefaultValue = false)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updatedAt", EmitDefaultValue = false)]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GroupRole {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  GroupId: ").Append(GroupId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  IsSelfAssignable: ").Append(IsSelfAssignable).Append("\n");
            sb.Append("  Permissions: ").Append(Permissions).Append("\n");
            sb.Append("  IsManagementRole: ").Append(IsManagementRole).Append("\n");
            sb.Append("  RequiresTwoFactor: ").Append(RequiresTwoFactor).Append("\n");
            sb.Append("  RequiresPurchase: ").Append(RequiresPurchase).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
            return this.Equals(input as GroupRole);
        }

        /// <summary>
        /// Returns true if GroupRole instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupRole to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupRole input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.GroupId == input.GroupId ||
                    (this.GroupId != null &&
                    this.GroupId.Equals(input.GroupId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.IsSelfAssignable == input.IsSelfAssignable ||
                    this.IsSelfAssignable.Equals(input.IsSelfAssignable)
                ) && 
                (
                    this.Permissions == input.Permissions ||
                    this.Permissions != null &&
                    input.Permissions != null &&
                    this.Permissions.SequenceEqual(input.Permissions)
                ) && 
                (
                    this.IsManagementRole == input.IsManagementRole ||
                    this.IsManagementRole.Equals(input.IsManagementRole)
                ) && 
                (
                    this.RequiresTwoFactor == input.RequiresTwoFactor ||
                    this.RequiresTwoFactor.Equals(input.RequiresTwoFactor)
                ) && 
                (
                    this.RequiresPurchase == input.RequiresPurchase ||
                    this.RequiresPurchase.Equals(input.RequiresPurchase)
                ) && 
                (
                    this.Order == input.Order ||
                    this.Order.Equals(input.Order)
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.GroupId != null)
                {
                    hashCode = (hashCode * 59) + this.GroupId.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsSelfAssignable.GetHashCode();
                if (this.Permissions != null)
                {
                    hashCode = (hashCode * 59) + this.Permissions.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsManagementRole.GetHashCode();
                hashCode = (hashCode * 59) + this.RequiresTwoFactor.GetHashCode();
                hashCode = (hashCode * 59) + this.RequiresPurchase.GetHashCode();
                hashCode = (hashCode * 59) + this.Order.GetHashCode();
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
