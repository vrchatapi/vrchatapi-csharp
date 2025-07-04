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
    /// GroupGalleryImage
    /// </summary>
    [DataContract(Name = "GroupGalleryImage")]
    public partial class GroupGalleryImage : IEquatable<GroupGalleryImage>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupGalleryImage" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="groupId">groupId.</param>
        /// <param name="galleryId">galleryId.</param>
        /// <param name="fileId">fileId.</param>
        /// <param name="imageUrl">imageUrl.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="submittedByUserId">A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed..</param>
        /// <param name="approved">approved (default to false).</param>
        /// <param name="approvedByUserId">A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed..</param>
        /// <param name="approvedAt">approvedAt.</param>
        public GroupGalleryImage(string id = default(string), string groupId = default(string), string galleryId = default(string), string fileId = default(string), string imageUrl = default(string), DateTime createdAt = default(DateTime), string submittedByUserId = default(string), bool approved = false, string approvedByUserId = default(string), DateTime approvedAt = default(DateTime))
        {
            this.Id = id;
            this.GroupId = groupId;
            this.GalleryId = galleryId;
            this.FileId = fileId;
            this.ImageUrl = imageUrl;
            this.CreatedAt = createdAt;
            this.SubmittedByUserId = submittedByUserId;
            this.Approved = approved;
            this.ApprovedByUserId = approvedByUserId;
            this.ApprovedAt = approvedAt;
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
        /// Gets or Sets GalleryId
        /// </summary>
        [DataMember(Name = "galleryId", EmitDefaultValue = false)]
        public string GalleryId { get; set; }

        /// <summary>
        /// Gets or Sets FileId
        /// </summary>
        [DataMember(Name = "fileId", EmitDefaultValue = false)]
        public string FileId { get; set; }

        /// <summary>
        /// Gets or Sets ImageUrl
        /// </summary>
        [DataMember(Name = "imageUrl", EmitDefaultValue = false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "createdAt", EmitDefaultValue = false)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed.
        /// </summary>
        /// <value>A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed.</value>
        [DataMember(Name = "submittedByUserId", EmitDefaultValue = false)]
        public string SubmittedByUserId { get; set; }

        /// <summary>
        /// Gets or Sets Approved
        /// </summary>
        [DataMember(Name = "approved", EmitDefaultValue = true)]
        public bool Approved { get; set; }

        /// <summary>
        /// A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed.
        /// </summary>
        /// <value>A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed.</value>
        [DataMember(Name = "approvedByUserId", EmitDefaultValue = false)]
        public string ApprovedByUserId { get; set; }

        /// <summary>
        /// Gets or Sets ApprovedAt
        /// </summary>
        [DataMember(Name = "approvedAt", EmitDefaultValue = false)]
        public DateTime ApprovedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GroupGalleryImage {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  GroupId: ").Append(GroupId).Append("\n");
            sb.Append("  GalleryId: ").Append(GalleryId).Append("\n");
            sb.Append("  FileId: ").Append(FileId).Append("\n");
            sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  SubmittedByUserId: ").Append(SubmittedByUserId).Append("\n");
            sb.Append("  Approved: ").Append(Approved).Append("\n");
            sb.Append("  ApprovedByUserId: ").Append(ApprovedByUserId).Append("\n");
            sb.Append("  ApprovedAt: ").Append(ApprovedAt).Append("\n");
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
            return this.Equals(input as GroupGalleryImage);
        }

        /// <summary>
        /// Returns true if GroupGalleryImage instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupGalleryImage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupGalleryImage input)
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
                    this.GalleryId == input.GalleryId ||
                    (this.GalleryId != null &&
                    this.GalleryId.Equals(input.GalleryId))
                ) && 
                (
                    this.FileId == input.FileId ||
                    (this.FileId != null &&
                    this.FileId.Equals(input.FileId))
                ) && 
                (
                    this.ImageUrl == input.ImageUrl ||
                    (this.ImageUrl != null &&
                    this.ImageUrl.Equals(input.ImageUrl))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.SubmittedByUserId == input.SubmittedByUserId ||
                    (this.SubmittedByUserId != null &&
                    this.SubmittedByUserId.Equals(input.SubmittedByUserId))
                ) && 
                (
                    this.Approved == input.Approved ||
                    this.Approved.Equals(input.Approved)
                ) && 
                (
                    this.ApprovedByUserId == input.ApprovedByUserId ||
                    (this.ApprovedByUserId != null &&
                    this.ApprovedByUserId.Equals(input.ApprovedByUserId))
                ) && 
                (
                    this.ApprovedAt == input.ApprovedAt ||
                    (this.ApprovedAt != null &&
                    this.ApprovedAt.Equals(input.ApprovedAt))
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
                if (this.GalleryId != null)
                {
                    hashCode = (hashCode * 59) + this.GalleryId.GetHashCode();
                }
                if (this.FileId != null)
                {
                    hashCode = (hashCode * 59) + this.FileId.GetHashCode();
                }
                if (this.ImageUrl != null)
                {
                    hashCode = (hashCode * 59) + this.ImageUrl.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.SubmittedByUserId != null)
                {
                    hashCode = (hashCode * 59) + this.SubmittedByUserId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Approved.GetHashCode();
                if (this.ApprovedByUserId != null)
                {
                    hashCode = (hashCode * 59) + this.ApprovedByUserId.GetHashCode();
                }
                if (this.ApprovedAt != null)
                {
                    hashCode = (hashCode * 59) + this.ApprovedAt.GetHashCode();
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
