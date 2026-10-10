

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
    /// UpdateGroupRoleRequest
    /// </summary>
    [DataContract(Name = "UpdateGroupRoleRequest")]
    public partial class UpdateGroupRoleRequest : IEquatable<UpdateGroupRoleRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateGroupRoleRequest" /> class.
        /// </summary>
        /// <param name="description">description.</param>
        /// <param name="isAddedOnJoin">isAddedOnJoin.</param>
        /// <param name="isSelfAssignable">isSelfAssignable.</param>
        /// <param name="name">name.</param>
        /// <param name="order">order.</param>
        /// <param name="permissions">permissions.</param>
        /// <param name="requiresTwoFactor">requiresTwoFactor.</param>
        public UpdateGroupRoleRequest(string description = default, bool isAddedOnJoin = default, bool isSelfAssignable = default, string name = default, int order = default, List<GroupPermissions> permissions = default, bool requiresTwoFactor = default)
        {
            this.Description = description;
            this.IsAddedOnJoin = isAddedOnJoin;
            this.IsSelfAssignable = isSelfAssignable;
            this.Name = name;
            this.Order = order;
            this.Permissions = permissions;
            this.RequiresTwoFactor = requiresTwoFactor;
        }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets IsAddedOnJoin
        /// </summary>
        [DataMember(Name = "isAddedOnJoin", EmitDefaultValue = true)]
        public bool IsAddedOnJoin { get; set; }

        /// <summary>
        /// Gets or Sets IsSelfAssignable
        /// </summary>
        [DataMember(Name = "isSelfAssignable", EmitDefaultValue = true)]
        public bool IsSelfAssignable { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Order
        /// </summary>
        [DataMember(Name = "order", EmitDefaultValue = false)]
        public int Order { get; set; }

        /// <summary>
        /// Gets or Sets Permissions
        /// </summary>
        [DataMember(Name = "permissions", EmitDefaultValue = false)]
        public List<GroupPermissions> Permissions { get; set; }

        /// <summary>
        /// Gets or Sets RequiresTwoFactor
        /// </summary>
        [DataMember(Name = "requiresTwoFactor", EmitDefaultValue = true)]
        public bool RequiresTwoFactor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdateGroupRoleRequest {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  IsAddedOnJoin: ").Append(IsAddedOnJoin).Append("\n");
            sb.Append("  IsSelfAssignable: ").Append(IsSelfAssignable).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  Permissions: ").Append(Permissions).Append("\n");
            sb.Append("  RequiresTwoFactor: ").Append(RequiresTwoFactor).Append("\n");
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
            return this.Equals(input as UpdateGroupRoleRequest);
        }

        /// <summary>
        /// Returns true if UpdateGroupRoleRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateGroupRoleRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateGroupRoleRequest input)
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
                    this.RequiresTwoFactor == input.RequiresTwoFactor ||
                    this.RequiresTwoFactor.Equals(input.RequiresTwoFactor)
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
                hashCode = (hashCode * 59) + this.RequiresTwoFactor.GetHashCode();
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
