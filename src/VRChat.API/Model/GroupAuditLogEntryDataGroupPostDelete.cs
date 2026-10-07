

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
    /// GroupAuditLogEntryDataGroupPostDelete
    /// </summary>
    [DataContract(Name = "GroupAuditLogEntryDataGroupPostDelete")]
    public partial class GroupAuditLogEntryDataGroupPostDelete : IEquatable<GroupAuditLogEntryDataGroupPostDelete>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Visibility
        /// </summary>
        [DataMember(Name = "visibility", IsRequired = true, EmitDefaultValue = true)]
        public GroupPostVisibility Visibility { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLogEntryDataGroupPostDelete" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GroupAuditLogEntryDataGroupPostDelete() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLogEntryDataGroupPostDelete" /> class.
        /// </summary>
        /// <param name="authorId">The ID of the post author. (required).</param>
        /// <param name="imageId">The image file ID attached to the post. (required).</param>
        /// <param name="text">The text content of the post. (required).</param>
        /// <param name="title">The title of the post. (required).</param>
        /// <param name="visibility">visibility (required).</param>
        /// <param name="createdAt">The creation timestamp of the post. (required).</param>
        /// <param name="editorId">The ID of the user who last edited the post. (required).</param>
        /// <param name="imageUrl">The URL of the post image. (required).</param>
        /// <param name="roleIds">The role IDs that could see the post. (required).</param>
        /// <param name="updatedAt">The last update timestamp of the post. (required).</param>
        public GroupAuditLogEntryDataGroupPostDelete(string authorId = default, string imageId = default, string text = default, string title = default, GroupPostVisibility visibility = default, DateTime createdAt = default, string editorId = default, string imageUrl = default, List<string> roleIds = default, DateTime updatedAt = default)
        {
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.AuthorId = authorId;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.ImageId = imageId;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Text = text;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Title = title;
            this.Visibility = visibility;
            this.CreatedAt = createdAt;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.EditorId = editorId;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.ImageUrl = imageUrl;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.RoleIds = roleIds;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// The ID of the post author.
        /// </summary>
        /// <value>The ID of the post author.</value>
        [DataMember(Name = "authorId", IsRequired = true, EmitDefaultValue = true)]
        public string AuthorId { get; set; }

        /// <summary>
        /// The image file ID attached to the post.
        /// </summary>
        /// <value>The image file ID attached to the post.</value>
        [DataMember(Name = "imageId", IsRequired = true, EmitDefaultValue = true)]
        public string ImageId { get; set; }

        /// <summary>
        /// The text content of the post.
        /// </summary>
        /// <value>The text content of the post.</value>
        [DataMember(Name = "text", IsRequired = true, EmitDefaultValue = true)]
        public string Text { get; set; }

        /// <summary>
        /// The title of the post.
        /// </summary>
        /// <value>The title of the post.</value>
        [DataMember(Name = "title", IsRequired = true, EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// The creation timestamp of the post.
        /// </summary>
        /// <value>The creation timestamp of the post.</value>
        [DataMember(Name = "createdAt", IsRequired = true, EmitDefaultValue = true)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// The ID of the user who last edited the post.
        /// </summary>
        /// <value>The ID of the user who last edited the post.</value>
        [DataMember(Name = "editorId", IsRequired = true, EmitDefaultValue = true)]
        public string EditorId { get; set; }

        /// <summary>
        /// The URL of the post image.
        /// </summary>
        /// <value>The URL of the post image.</value>
        [DataMember(Name = "imageUrl", IsRequired = true, EmitDefaultValue = true)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// The role IDs that could see the post.
        /// </summary>
        /// <value>The role IDs that could see the post.</value>
        [DataMember(Name = "roleIds", IsRequired = true, EmitDefaultValue = true)]
        public List<string> RoleIds { get; set; }

        /// <summary>
        /// The last update timestamp of the post.
        /// </summary>
        /// <value>The last update timestamp of the post.</value>
        [DataMember(Name = "updatedAt", IsRequired = true, EmitDefaultValue = true)]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GroupAuditLogEntryDataGroupPostDelete {\n");
            sb.Append("  AuthorId: ").Append(AuthorId).Append("\n");
            sb.Append("  ImageId: ").Append(ImageId).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Visibility: ").Append(Visibility).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  EditorId: ").Append(EditorId).Append("\n");
            sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("  RoleIds: ").Append(RoleIds).Append("\n");
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
            return this.Equals(input as GroupAuditLogEntryDataGroupPostDelete);
        }

        /// <summary>
        /// Returns true if GroupAuditLogEntryDataGroupPostDelete instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupAuditLogEntryDataGroupPostDelete to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupAuditLogEntryDataGroupPostDelete input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AuthorId == input.AuthorId ||
                    (this.AuthorId != null &&
                    this.AuthorId.Equals(input.AuthorId))
                ) && 
                (
                    this.ImageId == input.ImageId ||
                    (this.ImageId != null &&
                    this.ImageId.Equals(input.ImageId))
                ) && 
                (
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Visibility == input.Visibility ||
                    this.Visibility.Equals(input.Visibility)
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    this.CreatedAt.Equals(input.CreatedAt)
                ) && 
                (
                    this.EditorId == input.EditorId ||
                    (this.EditorId != null &&
                    this.EditorId.Equals(input.EditorId))
                ) && 
                (
                    this.ImageUrl == input.ImageUrl ||
                    (this.ImageUrl != null &&
                    this.ImageUrl.Equals(input.ImageUrl))
                ) && 
                (
                    this.RoleIds == input.RoleIds ||
                    this.RoleIds != null &&
                    input.RoleIds != null &&
                    this.RoleIds.SequenceEqual(input.RoleIds)
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
                if (this.AuthorId != null)
                {
                    hashCode = (hashCode * 59) + this.AuthorId.GetHashCode();
                }
                if (this.ImageId != null)
                {
                    hashCode = (hashCode * 59) + this.ImageId.GetHashCode();
                }
                if (this.Text != null)
                {
                    hashCode = (hashCode * 59) + this.Text.GetHashCode();
                }
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Visibility.GetHashCode();
                hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                if (this.EditorId != null)
                {
                    hashCode = (hashCode * 59) + this.EditorId.GetHashCode();
                }
                if (this.ImageUrl != null)
                {
                    hashCode = (hashCode * 59) + this.ImageUrl.GetHashCode();
                }
                if (this.RoleIds != null)
                {
                    hashCode = (hashCode * 59) + this.RoleIds.GetHashCode();
                }
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
