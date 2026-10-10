

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
    /// CreateGroupRoleRequest
    /// </summary>
    [DataContract(Name = "CreateGroupRoleRequest")]
    public partial class CreateGroupRoleRequest : IEquatable<CreateGroupRoleRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGroupRoleRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateGroupRoleRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGroupRoleRequest" /> class.
        /// </summary>
        /// <param name="description">description.</param>
        /// <param name="isAddedOnJoin">isAddedOnJoin (default to false).</param>
        /// <param name="isSelfAssignable">isSelfAssignable (default to false).</param>
        /// <param name="name">name (required).</param>
        /// <param name="permissions">permissions.</param>
        /// <param name="requiresPurchase">requiresPurchase (default to false).</param>
        /// <param name="requiresTwoFactor">requiresTwoFactor (default to false).</param>
        public CreateGroupRoleRequest(string description = default, bool isAddedOnJoin = false, bool isSelfAssignable = false, string name = default, List<GroupPermissions> permissions = default, bool requiresPurchase = false, bool requiresTwoFactor = false)
        {
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Name = name;
            this.Description = description;
            this.IsAddedOnJoin = isAddedOnJoin;
            this.IsSelfAssignable = isSelfAssignable;
            this.Permissions = permissions;
            this.RequiresPurchase = requiresPurchase;
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
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Permissions
        /// </summary>
        [DataMember(Name = "permissions", EmitDefaultValue = false)]
        public List<GroupPermissions> Permissions { get; set; }

        /// <summary>
        /// Gets or Sets RequiresPurchase
        /// </summary>
        [DataMember(Name = "requiresPurchase", EmitDefaultValue = true)]
        public bool RequiresPurchase { get; set; }

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
            sb.Append("class CreateGroupRoleRequest {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  IsAddedOnJoin: ").Append(IsAddedOnJoin).Append("\n");
            sb.Append("  IsSelfAssignable: ").Append(IsSelfAssignable).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Permissions: ").Append(Permissions).Append("\n");
            sb.Append("  RequiresPurchase: ").Append(RequiresPurchase).Append("\n");
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
            return this.Equals(input as CreateGroupRoleRequest);
        }

        /// <summary>
        /// Returns true if CreateGroupRoleRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateGroupRoleRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateGroupRoleRequest input)
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
                if (this.Permissions != null)
                {
                    hashCode = (hashCode * 59) + this.Permissions.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.RequiresPurchase.GetHashCode();
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
