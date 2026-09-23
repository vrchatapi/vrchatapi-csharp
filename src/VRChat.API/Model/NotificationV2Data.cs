

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
    /// NotificationV2Data
    /// </summary>
    [DataContract(Name = "NotificationV2_data")]
    public partial class NotificationV2Data : IEquatable<NotificationV2Data>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationV2Data" /> class.
        /// </summary>
        /// <param name="badgeDescription">badgeDescription.</param>
        /// <param name="badgeId">badgeId.</param>
        /// <param name="badgeName">badgeName.</param>
        /// <param name="boopingUserDisplayName">boopingUserDisplayName.</param>
        /// <param name="ownerId">ownerId.</param>
        /// <param name="ownerName">ownerName.</param>
        /// <param name="title">title.</param>
        /// <param name="announcementTitle">announcementTitle.</param>
        /// <param name="groupId">groupId.</param>
        /// <param name="groupName">groupName.</param>
        /// <param name="transferTargetDisplayName">transferTargetDisplayName.</param>
        /// <param name="ownerUserDisplayName">ownerUserDisplayName.</param>
        public NotificationV2Data(string badgeDescription = default, string badgeId = default, string badgeName = default, string boopingUserDisplayName = default, string ownerId = default, string ownerName = default, string title = default, string announcementTitle = default, string groupId = default, string groupName = default, string transferTargetDisplayName = default, string ownerUserDisplayName = default)
        {
            this.BadgeDescription = badgeDescription;
            this.BadgeId = badgeId;
            this.BadgeName = badgeName;
            this.BoopingUserDisplayName = boopingUserDisplayName;
            this.OwnerId = ownerId;
            this.OwnerName = ownerName;
            this.Title = title;
            this.AnnouncementTitle = announcementTitle;
            this.GroupId = groupId;
            this.GroupName = groupName;
            this.TransferTargetDisplayName = transferTargetDisplayName;
            this.OwnerUserDisplayName = ownerUserDisplayName;
        }

        /// <summary>
        /// Gets or Sets BadgeDescription
        /// </summary>
        [DataMember(Name = "badgeDescription", EmitDefaultValue = false)]
        public string BadgeDescription { get; set; }

        /// <summary>
        /// Gets or Sets BadgeId
        /// </summary>
        /*
        <example>bdg_a60e514a-8cb7-4702-8f24-2786992be1a8</example>
        */
        [DataMember(Name = "badgeId", EmitDefaultValue = false)]
        public string BadgeId { get; set; }

        /// <summary>
        /// Gets or Sets BadgeName
        /// </summary>
        [DataMember(Name = "badgeName", EmitDefaultValue = false)]
        public string BadgeName { get; set; }

        /// <summary>
        /// Gets or Sets BoopingUserDisplayName
        /// </summary>
        [DataMember(Name = "boopingUserDisplayName", EmitDefaultValue = false)]
        public string BoopingUserDisplayName { get; set; }

        /// <summary>
        /// Gets or Sets OwnerId
        /// </summary>
        /*
        <example>grp_71a7ff59-112c-4e78-a990-c7cc650776e5</example>
        */
        [DataMember(Name = "ownerId", EmitDefaultValue = false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// Gets or Sets OwnerName
        /// </summary>
        [DataMember(Name = "ownerName", EmitDefaultValue = false)]
        public string OwnerName { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets AnnouncementTitle
        /// </summary>
        [DataMember(Name = "announcementTitle", EmitDefaultValue = false)]
        public string AnnouncementTitle { get; set; }

        /// <summary>
        /// Gets or Sets GroupId
        /// </summary>
        /*
        <example>grp_71a7ff59-112c-4e78-a990-c7cc650776e5</example>
        */
        [DataMember(Name = "groupId", EmitDefaultValue = false)]
        public string GroupId { get; set; }

        /// <summary>
        /// Gets or Sets GroupName
        /// </summary>
        [DataMember(Name = "groupName", EmitDefaultValue = false)]
        public string GroupName { get; set; }

        /// <summary>
        /// Gets or Sets TransferTargetDisplayName
        /// </summary>
        [DataMember(Name = "transferTargetDisplayName", EmitDefaultValue = false)]
        public string TransferTargetDisplayName { get; set; }

        /// <summary>
        /// Gets or Sets OwnerUserDisplayName
        /// </summary>
        [DataMember(Name = "ownerUserDisplayName", EmitDefaultValue = false)]
        public string OwnerUserDisplayName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NotificationV2Data {\n");
            sb.Append("  BadgeDescription: ").Append(BadgeDescription).Append("\n");
            sb.Append("  BadgeId: ").Append(BadgeId).Append("\n");
            sb.Append("  BadgeName: ").Append(BadgeName).Append("\n");
            sb.Append("  BoopingUserDisplayName: ").Append(BoopingUserDisplayName).Append("\n");
            sb.Append("  OwnerId: ").Append(OwnerId).Append("\n");
            sb.Append("  OwnerName: ").Append(OwnerName).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  AnnouncementTitle: ").Append(AnnouncementTitle).Append("\n");
            sb.Append("  GroupId: ").Append(GroupId).Append("\n");
            sb.Append("  GroupName: ").Append(GroupName).Append("\n");
            sb.Append("  TransferTargetDisplayName: ").Append(TransferTargetDisplayName).Append("\n");
            sb.Append("  OwnerUserDisplayName: ").Append(OwnerUserDisplayName).Append("\n");
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
            return this.Equals(input as NotificationV2Data);
        }

        /// <summary>
        /// Returns true if NotificationV2Data instances are equal
        /// </summary>
        /// <param name="input">Instance of NotificationV2Data to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NotificationV2Data input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BadgeDescription == input.BadgeDescription ||
                    (this.BadgeDescription != null &&
                    this.BadgeDescription.Equals(input.BadgeDescription))
                ) && 
                (
                    this.BadgeId == input.BadgeId ||
                    (this.BadgeId != null &&
                    this.BadgeId.Equals(input.BadgeId))
                ) && 
                (
                    this.BadgeName == input.BadgeName ||
                    (this.BadgeName != null &&
                    this.BadgeName.Equals(input.BadgeName))
                ) && 
                (
                    this.BoopingUserDisplayName == input.BoopingUserDisplayName ||
                    (this.BoopingUserDisplayName != null &&
                    this.BoopingUserDisplayName.Equals(input.BoopingUserDisplayName))
                ) && 
                (
                    this.OwnerId == input.OwnerId ||
                    (this.OwnerId != null &&
                    this.OwnerId.Equals(input.OwnerId))
                ) && 
                (
                    this.OwnerName == input.OwnerName ||
                    (this.OwnerName != null &&
                    this.OwnerName.Equals(input.OwnerName))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.AnnouncementTitle == input.AnnouncementTitle ||
                    (this.AnnouncementTitle != null &&
                    this.AnnouncementTitle.Equals(input.AnnouncementTitle))
                ) && 
                (
                    this.GroupId == input.GroupId ||
                    (this.GroupId != null &&
                    this.GroupId.Equals(input.GroupId))
                ) && 
                (
                    this.GroupName == input.GroupName ||
                    (this.GroupName != null &&
                    this.GroupName.Equals(input.GroupName))
                ) && 
                (
                    this.TransferTargetDisplayName == input.TransferTargetDisplayName ||
                    (this.TransferTargetDisplayName != null &&
                    this.TransferTargetDisplayName.Equals(input.TransferTargetDisplayName))
                ) && 
                (
                    this.OwnerUserDisplayName == input.OwnerUserDisplayName ||
                    (this.OwnerUserDisplayName != null &&
                    this.OwnerUserDisplayName.Equals(input.OwnerUserDisplayName))
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
                if (this.BadgeDescription != null)
                {
                    hashCode = (hashCode * 59) + this.BadgeDescription.GetHashCode();
                }
                if (this.BadgeId != null)
                {
                    hashCode = (hashCode * 59) + this.BadgeId.GetHashCode();
                }
                if (this.BadgeName != null)
                {
                    hashCode = (hashCode * 59) + this.BadgeName.GetHashCode();
                }
                if (this.BoopingUserDisplayName != null)
                {
                    hashCode = (hashCode * 59) + this.BoopingUserDisplayName.GetHashCode();
                }
                if (this.OwnerId != null)
                {
                    hashCode = (hashCode * 59) + this.OwnerId.GetHashCode();
                }
                if (this.OwnerName != null)
                {
                    hashCode = (hashCode * 59) + this.OwnerName.GetHashCode();
                }
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
                }
                if (this.AnnouncementTitle != null)
                {
                    hashCode = (hashCode * 59) + this.AnnouncementTitle.GetHashCode();
                }
                if (this.GroupId != null)
                {
                    hashCode = (hashCode * 59) + this.GroupId.GetHashCode();
                }
                if (this.GroupName != null)
                {
                    hashCode = (hashCode * 59) + this.GroupName.GetHashCode();
                }
                if (this.TransferTargetDisplayName != null)
                {
                    hashCode = (hashCode * 59) + this.TransferTargetDisplayName.GetHashCode();
                }
                if (this.OwnerUserDisplayName != null)
                {
                    hashCode = (hashCode * 59) + this.OwnerUserDisplayName.GetHashCode();
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
