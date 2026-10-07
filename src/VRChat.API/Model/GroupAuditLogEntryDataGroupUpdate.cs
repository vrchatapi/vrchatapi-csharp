

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
    [DataContract(Name = "GroupAuditLogEntryDataGroupUpdate")]
    public partial class GroupAuditLogEntryDataGroupUpdate : IEquatable<GroupAuditLogEntryDataGroupUpdate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLogEntryDataGroupUpdate" /> class.
        /// </summary>
        /// <param name="allowGroupJoinPrompt">allowGroupJoinPrompt.</param>
        /// <param name="bannerId">bannerId.</param>
        /// <param name="description">description.</param>
        /// <param name="iconId">iconId.</param>
        /// <param name="joinState">joinState.</param>
        /// <param name="languages">languages.</param>
        /// <param name="links">links.</param>
        /// <param name="name">name.</param>
        /// <param name="nameplateId">nameplateId.</param>
        /// <param name="rules">rules.</param>
        /// <param name="shortCode">shortCode.</param>
        /// <param name="tags">tags.</param>
        public GroupAuditLogEntryDataGroupUpdate(GroupAuditLogEntryBooleanChange allowGroupJoinPrompt = default, GroupAuditLogEntryFileIDChange bannerId = default, GroupAuditLogEntryStringChange description = default, GroupAuditLogEntryFileIDChange iconId = default, GroupAuditLogEntryJoinStateChange joinState = default, GroupAuditLogEntryStringListChange languages = default, GroupAuditLogEntryStringListChange links = default, GroupAuditLogEntryStringChange name = default, GroupAuditLogEntryFileIDChange nameplateId = default, GroupAuditLogEntryStringChange rules = default, GroupAuditLogEntryStringChange shortCode = default, GroupAuditLogEntryStringListChange tags = default)
        {
            this.AllowGroupJoinPrompt = allowGroupJoinPrompt;
            this.BannerId = bannerId;
            this.Description = description;
            this.IconId = iconId;
            this.JoinState = joinState;
            this.Languages = languages;
            this.Links = links;
            this.Name = name;
            this.NameplateId = nameplateId;
            this.Rules = rules;
            this.ShortCode = shortCode;
            this.Tags = tags;
        }

        /// <summary>
        /// Gets or Sets AllowGroupJoinPrompt
        /// </summary>
        [DataMember(Name = "allowGroupJoinPrompt", EmitDefaultValue = false)]
        public GroupAuditLogEntryBooleanChange AllowGroupJoinPrompt { get; set; }

        /// <summary>
        /// Gets or Sets BannerId
        /// </summary>
        [DataMember(Name = "bannerId", EmitDefaultValue = false)]
        public GroupAuditLogEntryFileIDChange BannerId { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public GroupAuditLogEntryStringChange Description { get; set; }

        /// <summary>
        /// Gets or Sets IconId
        /// </summary>
        [DataMember(Name = "iconId", EmitDefaultValue = false)]
        public GroupAuditLogEntryFileIDChange IconId { get; set; }

        /// <summary>
        /// Gets or Sets JoinState
        /// </summary>
        [DataMember(Name = "joinState", EmitDefaultValue = false)]
        public GroupAuditLogEntryJoinStateChange JoinState { get; set; }

        /// <summary>
        /// Gets or Sets Languages
        /// </summary>
        [DataMember(Name = "languages", EmitDefaultValue = false)]
        public GroupAuditLogEntryStringListChange Languages { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "links", EmitDefaultValue = false)]
        public GroupAuditLogEntryStringListChange Links { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public GroupAuditLogEntryStringChange Name { get; set; }

        /// <summary>
        /// Gets or Sets NameplateId
        /// </summary>
        [DataMember(Name = "nameplateId", EmitDefaultValue = false)]
        public GroupAuditLogEntryFileIDChange NameplateId { get; set; }

        /// <summary>
        /// Gets or Sets Rules
        /// </summary>
        [DataMember(Name = "rules", EmitDefaultValue = false)]
        public GroupAuditLogEntryStringChange Rules { get; set; }

        /// <summary>
        /// Gets or Sets ShortCode
        /// </summary>
        [DataMember(Name = "shortCode", EmitDefaultValue = false)]
        public GroupAuditLogEntryStringChange ShortCode { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name = "tags", EmitDefaultValue = false)]
        public GroupAuditLogEntryStringListChange Tags { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GroupAuditLogEntryDataGroupUpdate {\n");
            sb.Append("  AllowGroupJoinPrompt: ").Append(AllowGroupJoinPrompt).Append("\n");
            sb.Append("  BannerId: ").Append(BannerId).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  IconId: ").Append(IconId).Append("\n");
            sb.Append("  JoinState: ").Append(JoinState).Append("\n");
            sb.Append("  Languages: ").Append(Languages).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  NameplateId: ").Append(NameplateId).Append("\n");
            sb.Append("  Rules: ").Append(Rules).Append("\n");
            sb.Append("  ShortCode: ").Append(ShortCode).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
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
            return this.Equals(input as GroupAuditLogEntryDataGroupUpdate);
        }

        /// <summary>
        /// Returns true if GroupAuditLogEntryDataGroupUpdate instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupAuditLogEntryDataGroupUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupAuditLogEntryDataGroupUpdate input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AllowGroupJoinPrompt == input.AllowGroupJoinPrompt ||
                    (this.AllowGroupJoinPrompt != null &&
                    this.AllowGroupJoinPrompt.Equals(input.AllowGroupJoinPrompt))
                ) && 
                (
                    this.BannerId == input.BannerId ||
                    (this.BannerId != null &&
                    this.BannerId.Equals(input.BannerId))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.IconId == input.IconId ||
                    (this.IconId != null &&
                    this.IconId.Equals(input.IconId))
                ) && 
                (
                    this.JoinState == input.JoinState ||
                    (this.JoinState != null &&
                    this.JoinState.Equals(input.JoinState))
                ) && 
                (
                    this.Languages == input.Languages ||
                    (this.Languages != null &&
                    this.Languages.Equals(input.Languages))
                ) && 
                (
                    this.Links == input.Links ||
                    (this.Links != null &&
                    this.Links.Equals(input.Links))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.NameplateId == input.NameplateId ||
                    (this.NameplateId != null &&
                    this.NameplateId.Equals(input.NameplateId))
                ) && 
                (
                    this.Rules == input.Rules ||
                    (this.Rules != null &&
                    this.Rules.Equals(input.Rules))
                ) && 
                (
                    this.ShortCode == input.ShortCode ||
                    (this.ShortCode != null &&
                    this.ShortCode.Equals(input.ShortCode))
                ) && 
                (
                    this.Tags == input.Tags ||
                    (this.Tags != null &&
                    this.Tags.Equals(input.Tags))
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
                if (this.AllowGroupJoinPrompt != null)
                {
                    hashCode = (hashCode * 59) + this.AllowGroupJoinPrompt.GetHashCode();
                }
                if (this.BannerId != null)
                {
                    hashCode = (hashCode * 59) + this.BannerId.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.IconId != null)
                {
                    hashCode = (hashCode * 59) + this.IconId.GetHashCode();
                }
                if (this.JoinState != null)
                {
                    hashCode = (hashCode * 59) + this.JoinState.GetHashCode();
                }
                if (this.Languages != null)
                {
                    hashCode = (hashCode * 59) + this.Languages.GetHashCode();
                }
                if (this.Links != null)
                {
                    hashCode = (hashCode * 59) + this.Links.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.NameplateId != null)
                {
                    hashCode = (hashCode * 59) + this.NameplateId.GetHashCode();
                }
                if (this.Rules != null)
                {
                    hashCode = (hashCode * 59) + this.Rules.GetHashCode();
                }
                if (this.ShortCode != null)
                {
                    hashCode = (hashCode * 59) + this.ShortCode.GetHashCode();
                }
                if (this.Tags != null)
                {
                    hashCode = (hashCode * 59) + this.Tags.GetHashCode();
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
