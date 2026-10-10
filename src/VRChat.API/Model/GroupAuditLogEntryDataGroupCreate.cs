

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
    /// GroupAuditLogEntryDataGroupCreate
    /// </summary>
    [DataContract(Name = "GroupAuditLogEntryDataGroupCreate")]
    public partial class GroupAuditLogEntryDataGroupCreate : IEquatable<GroupAuditLogEntryDataGroupCreate>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets JoinState
        /// </summary>
        [DataMember(Name = "joinState", IsRequired = true, EmitDefaultValue = true)]
        public GroupJoinState JoinState { get; set; }

        /// <summary>
        /// Gets or Sets Privacy
        /// </summary>
        [DataMember(Name = "privacy", IsRequired = true, EmitDefaultValue = true)]
        public GroupPrivacy Privacy { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLogEntryDataGroupCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GroupAuditLogEntryDataGroupCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLogEntryDataGroupCreate" /> class.
        /// </summary>
        /// <param name="bannerId">bannerId (required).</param>
        /// <param name="bannerVersion">bannerVersion.</param>
        /// <param name="description">description (required).</param>
        /// <param name="discoverability">discoverability (required).</param>
        /// <param name="galleries">galleries.</param>
        /// <param name="iconId">iconId (required).</param>
        /// <param name="iconVersion">iconVersion.</param>
        /// <param name="joinState">joinState (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="ownerId">A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed. (required).</param>
        /// <param name="privacy">privacy (required).</param>
        /// <param name="rules">rules (required).</param>
        /// <param name="shortCode">shortCode (required).</param>
        public GroupAuditLogEntryDataGroupCreate(string bannerId = default, int bannerVersion = default, string description = default, GroupAuditLogEntryDataGroupCreateDiscoverability discoverability = default, List<GroupAuditLogEntryDataGroupCreateGallery> galleries = default, string iconId = default, int iconVersion = default, GroupJoinState joinState = default, string name = default, string ownerId = default, GroupPrivacy privacy = default, string rules = default, string shortCode = default)
        {
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.BannerId = bannerId;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Description = description;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Discoverability = discoverability;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.IconId = iconId;
            this.JoinState = joinState;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Name = name;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.OwnerId = ownerId;
            this.Privacy = privacy;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Rules = rules;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.ShortCode = shortCode;
            this.BannerVersion = bannerVersion;
            this.Galleries = galleries;
            this.IconVersion = iconVersion;
        }

        /// <summary>
        /// Gets or Sets BannerId
        /// </summary>
        [DataMember(Name = "bannerId", IsRequired = true, EmitDefaultValue = true)]
        public string BannerId { get; set; }

        /// <summary>
        /// Gets or Sets BannerVersion
        /// </summary>
        [DataMember(Name = "bannerVersion", EmitDefaultValue = false)]
        public int BannerVersion { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Discoverability
        /// </summary>
        [DataMember(Name = "discoverability", IsRequired = true, EmitDefaultValue = true)]
        public GroupAuditLogEntryDataGroupCreateDiscoverability Discoverability { get; set; }

        /// <summary>
        /// Gets or Sets Galleries
        /// </summary>
        [DataMember(Name = "galleries", EmitDefaultValue = false)]
        public List<GroupAuditLogEntryDataGroupCreateGallery> Galleries { get; set; }

        /// <summary>
        /// Gets or Sets IconId
        /// </summary>
        [DataMember(Name = "iconId", IsRequired = true, EmitDefaultValue = true)]
        public string IconId { get; set; }

        /// <summary>
        /// Gets or Sets IconVersion
        /// </summary>
        [DataMember(Name = "iconVersion", EmitDefaultValue = false)]
        public int IconVersion { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed.
        /// </summary>
        /// <value>A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed.</value>
        [DataMember(Name = "ownerId", IsRequired = true, EmitDefaultValue = true)]
        public string OwnerId { get; set; }

        /// <summary>
        /// Gets or Sets Rules
        /// </summary>
        [DataMember(Name = "rules", IsRequired = true, EmitDefaultValue = true)]
        public string Rules { get; set; }

        /// <summary>
        /// Gets or Sets ShortCode
        /// </summary>
        [DataMember(Name = "shortCode", IsRequired = true, EmitDefaultValue = true)]
        public string ShortCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GroupAuditLogEntryDataGroupCreate {\n");
            sb.Append("  BannerId: ").Append(BannerId).Append("\n");
            sb.Append("  BannerVersion: ").Append(BannerVersion).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Discoverability: ").Append(Discoverability).Append("\n");
            sb.Append("  Galleries: ").Append(Galleries).Append("\n");
            sb.Append("  IconId: ").Append(IconId).Append("\n");
            sb.Append("  IconVersion: ").Append(IconVersion).Append("\n");
            sb.Append("  JoinState: ").Append(JoinState).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OwnerId: ").Append(OwnerId).Append("\n");
            sb.Append("  Privacy: ").Append(Privacy).Append("\n");
            sb.Append("  Rules: ").Append(Rules).Append("\n");
            sb.Append("  ShortCode: ").Append(ShortCode).Append("\n");
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
            return this.Equals(input as GroupAuditLogEntryDataGroupCreate);
        }

        /// <summary>
        /// Returns true if GroupAuditLogEntryDataGroupCreate instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupAuditLogEntryDataGroupCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupAuditLogEntryDataGroupCreate input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BannerId == input.BannerId ||
                    (this.BannerId != null &&
                    this.BannerId.Equals(input.BannerId))
                ) && 
                (
                    this.BannerVersion == input.BannerVersion ||
                    this.BannerVersion.Equals(input.BannerVersion)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Discoverability == input.Discoverability ||
                    (this.Discoverability != null &&
                    this.Discoverability.Equals(input.Discoverability))
                ) && 
                (
                    this.Galleries == input.Galleries ||
                    this.Galleries != null &&
                    input.Galleries != null &&
                    this.Galleries.SequenceEqual(input.Galleries)
                ) && 
                (
                    this.IconId == input.IconId ||
                    (this.IconId != null &&
                    this.IconId.Equals(input.IconId))
                ) && 
                (
                    this.IconVersion == input.IconVersion ||
                    this.IconVersion.Equals(input.IconVersion)
                ) && 
                (
                    this.JoinState == input.JoinState ||
                    this.JoinState.Equals(input.JoinState)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.OwnerId == input.OwnerId ||
                    (this.OwnerId != null &&
                    this.OwnerId.Equals(input.OwnerId))
                ) && 
                (
                    this.Privacy == input.Privacy ||
                    this.Privacy.Equals(input.Privacy)
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
                if (this.BannerId != null)
                {
                    hashCode = (hashCode * 59) + this.BannerId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.BannerVersion.GetHashCode();
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Discoverability != null)
                {
                    hashCode = (hashCode * 59) + this.Discoverability.GetHashCode();
                }
                if (this.Galleries != null)
                {
                    hashCode = (hashCode * 59) + this.Galleries.GetHashCode();
                }
                if (this.IconId != null)
                {
                    hashCode = (hashCode * 59) + this.IconId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IconVersion.GetHashCode();
                hashCode = (hashCode * 59) + this.JoinState.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.OwnerId != null)
                {
                    hashCode = (hashCode * 59) + this.OwnerId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Privacy.GetHashCode();
                if (this.Rules != null)
                {
                    hashCode = (hashCode * 59) + this.Rules.GetHashCode();
                }
                if (this.ShortCode != null)
                {
                    hashCode = (hashCode * 59) + this.ShortCode.GetHashCode();
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
