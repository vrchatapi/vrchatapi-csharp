

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
    /// GroupAuditLogEntryDataGroupGalleryDelete
    /// </summary>
    [DataContract(Name = "GroupAuditLogEntryDataGroupGalleryDelete")]
    public partial class GroupAuditLogEntryDataGroupGalleryDelete : IEquatable<GroupAuditLogEntryDataGroupGalleryDelete>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLogEntryDataGroupGalleryDelete" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GroupAuditLogEntryDataGroupGalleryDelete() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLogEntryDataGroupGalleryDelete" /> class.
        /// </summary>
        /// <param name="description">The gallery description. (required).</param>
        /// <param name="membersOnly">Whether the gallery is members only. (required).</param>
        /// <param name="name">The gallery name. (required).</param>
        /// <param name="roleIdsToAutoApprove">The role IDs whose submissions are approved automatically. (required).</param>
        /// <param name="roleIdsToManage">The role IDs that can manage the gallery. (required).</param>
        /// <param name="roleIdsToSubmit">The role IDs that can submit to the gallery. (required).</param>
        /// <param name="roleIdsToView">The role IDs that can view the gallery. (required).</param>
        /// <param name="createdAt">The creation timestamp of the gallery. (required).</param>
        /// <param name="updatedAt">The last update timestamp of the gallery. (required).</param>
        public GroupAuditLogEntryDataGroupGalleryDelete(string description = default, bool membersOnly = default, string name = default, List<string> roleIdsToAutoApprove = default, List<string> roleIdsToManage = default, List<string> roleIdsToSubmit = default, List<string> roleIdsToView = default, DateTime createdAt = default, DateTime updatedAt = default)
        {
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Description = description;
            this.MembersOnly = membersOnly;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Name = name;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.RoleIdsToAutoApprove = roleIdsToAutoApprove;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.RoleIdsToManage = roleIdsToManage;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.RoleIdsToSubmit = roleIdsToSubmit;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.RoleIdsToView = roleIdsToView;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// The gallery description.
        /// </summary>
        /// <value>The gallery description.</value>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Whether the gallery is members only.
        /// </summary>
        /// <value>Whether the gallery is members only.</value>
        [DataMember(Name = "membersOnly", IsRequired = true, EmitDefaultValue = true)]
        public bool MembersOnly { get; set; }

        /// <summary>
        /// The gallery name.
        /// </summary>
        /// <value>The gallery name.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The role IDs whose submissions are approved automatically.
        /// </summary>
        /// <value>The role IDs whose submissions are approved automatically.</value>
        [DataMember(Name = "roleIdsToAutoApprove", IsRequired = true, EmitDefaultValue = true)]
        public List<string> RoleIdsToAutoApprove { get; set; }

        /// <summary>
        /// The role IDs that can manage the gallery.
        /// </summary>
        /// <value>The role IDs that can manage the gallery.</value>
        [DataMember(Name = "roleIdsToManage", IsRequired = true, EmitDefaultValue = true)]
        public List<string> RoleIdsToManage { get; set; }

        /// <summary>
        /// The role IDs that can submit to the gallery.
        /// </summary>
        /// <value>The role IDs that can submit to the gallery.</value>
        [DataMember(Name = "roleIdsToSubmit", IsRequired = true, EmitDefaultValue = true)]
        public List<string> RoleIdsToSubmit { get; set; }

        /// <summary>
        /// The role IDs that can view the gallery.
        /// </summary>
        /// <value>The role IDs that can view the gallery.</value>
        [DataMember(Name = "roleIdsToView", IsRequired = true, EmitDefaultValue = true)]
        public List<string> RoleIdsToView { get; set; }

        /// <summary>
        /// The creation timestamp of the gallery.
        /// </summary>
        /// <value>The creation timestamp of the gallery.</value>
        [DataMember(Name = "createdAt", IsRequired = true, EmitDefaultValue = true)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// The last update timestamp of the gallery.
        /// </summary>
        /// <value>The last update timestamp of the gallery.</value>
        [DataMember(Name = "updatedAt", IsRequired = true, EmitDefaultValue = true)]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GroupAuditLogEntryDataGroupGalleryDelete {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  MembersOnly: ").Append(MembersOnly).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  RoleIdsToAutoApprove: ").Append(RoleIdsToAutoApprove).Append("\n");
            sb.Append("  RoleIdsToManage: ").Append(RoleIdsToManage).Append("\n");
            sb.Append("  RoleIdsToSubmit: ").Append(RoleIdsToSubmit).Append("\n");
            sb.Append("  RoleIdsToView: ").Append(RoleIdsToView).Append("\n");
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
            return this.Equals(input as GroupAuditLogEntryDataGroupGalleryDelete);
        }

        /// <summary>
        /// Returns true if GroupAuditLogEntryDataGroupGalleryDelete instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupAuditLogEntryDataGroupGalleryDelete to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupAuditLogEntryDataGroupGalleryDelete input)
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
                    this.MembersOnly == input.MembersOnly ||
                    this.MembersOnly.Equals(input.MembersOnly)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.RoleIdsToAutoApprove == input.RoleIdsToAutoApprove ||
                    this.RoleIdsToAutoApprove != null &&
                    input.RoleIdsToAutoApprove != null &&
                    this.RoleIdsToAutoApprove.SequenceEqual(input.RoleIdsToAutoApprove)
                ) && 
                (
                    this.RoleIdsToManage == input.RoleIdsToManage ||
                    this.RoleIdsToManage != null &&
                    input.RoleIdsToManage != null &&
                    this.RoleIdsToManage.SequenceEqual(input.RoleIdsToManage)
                ) && 
                (
                    this.RoleIdsToSubmit == input.RoleIdsToSubmit ||
                    this.RoleIdsToSubmit != null &&
                    input.RoleIdsToSubmit != null &&
                    this.RoleIdsToSubmit.SequenceEqual(input.RoleIdsToSubmit)
                ) && 
                (
                    this.RoleIdsToView == input.RoleIdsToView ||
                    this.RoleIdsToView != null &&
                    input.RoleIdsToView != null &&
                    this.RoleIdsToView.SequenceEqual(input.RoleIdsToView)
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    this.CreatedAt.Equals(input.CreatedAt)
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    this.UpdatedAt.Equals(input.UpdatedAt)
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
                hashCode = (hashCode * 59) + this.MembersOnly.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.RoleIdsToAutoApprove != null)
                {
                    hashCode = (hashCode * 59) + this.RoleIdsToAutoApprove.GetHashCode();
                }
                if (this.RoleIdsToManage != null)
                {
                    hashCode = (hashCode * 59) + this.RoleIdsToManage.GetHashCode();
                }
                if (this.RoleIdsToSubmit != null)
                {
                    hashCode = (hashCode * 59) + this.RoleIdsToSubmit.GetHashCode();
                }
                if (this.RoleIdsToView != null)
                {
                    hashCode = (hashCode * 59) + this.RoleIdsToView.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
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
