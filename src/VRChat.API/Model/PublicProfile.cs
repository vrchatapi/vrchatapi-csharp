

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
    /// PublicProfile
    /// </summary>
    [DataContract(Name = "PublicProfile")]
    public partial class PublicProfile : IEquatable<PublicProfile>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets AgeVerificationStatus
        /// </summary>
        [DataMember(Name = "ageVerificationStatus", EmitDefaultValue = false)]
        public AgeVerificationStatus? AgeVerificationStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PublicProfile" /> class.
        /// </summary>
        /// <param name="ageVerificationStatus">ageVerificationStatus.</param>
        /// <param name="ageVerified">&#x60;true&#x60; if, user is age verified (not 18+)..</param>
        /// <param name="backgroundType">backgroundType.</param>
        /// <param name="badges">badges.</param>
        /// <param name="bannerColor">bannerColor.</param>
        /// <param name="bannerType">bannerType.</param>
        /// <param name="bio">bio.</param>
        /// <param name="bioLinks">bioLinks.</param>
        /// <param name="displayName">displayName.</param>
        /// <param name="hasVrcPlus">hasVrcPlus.</param>
        /// <param name="iconFrame">iconFrame.</param>
        /// <param name="iconUrl">iconUrl.</param>
        /// <param name="id">A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed..</param>
        /// <param name="isEconomyCreator">isEconomyCreator.</param>
        /// <param name="languages">languages.</param>
        /// <param name="nameplateEffect">nameplateEffect.</param>
        /// <param name="profileEffect">profileEffect.</param>
        /// <param name="pronouns">pronouns.</param>
        /// <param name="representedGroup">representedGroup.</param>
        /// <param name="themeId">themeId.</param>
        /// <param name="trustTags">trustTags.</param>
        public PublicProfile(AgeVerificationStatus? ageVerificationStatus = default, bool ageVerified = default, string backgroundType = default, List<Badge> badges = default, string bannerColor = default, string bannerType = default, string bio = default, List<string> bioLinks = default, string displayName = default, bool hasVrcPlus = default, string iconFrame = default, string iconUrl = default, string id = default, bool isEconomyCreator = default, List<string> languages = default, string nameplateEffect = default, string profileEffect = default, string pronouns = default, ProfileRepresentedGroup representedGroup = default, string themeId = default, List<string> trustTags = default)
        {
            this.AgeVerificationStatus = ageVerificationStatus;
            this.AgeVerified = ageVerified;
            this.BackgroundType = backgroundType;
            this.Badges = badges;
            this.BannerColor = bannerColor;
            this.BannerType = bannerType;
            this.Bio = bio;
            this.BioLinks = bioLinks;
            this.DisplayName = displayName;
            this.HasVrcPlus = hasVrcPlus;
            this.IconFrame = iconFrame;
            this.IconUrl = iconUrl;
            this.Id = id;
            this.IsEconomyCreator = isEconomyCreator;
            this.Languages = languages;
            this.NameplateEffect = nameplateEffect;
            this.ProfileEffect = profileEffect;
            this.Pronouns = pronouns;
            this.RepresentedGroup = representedGroup;
            this.ThemeId = themeId;
            this.TrustTags = trustTags;
        }

        /// <summary>
        /// &#x60;true&#x60; if, user is age verified (not 18+).
        /// </summary>
        /// <value>&#x60;true&#x60; if, user is age verified (not 18+).</value>
        [DataMember(Name = "ageVerified", EmitDefaultValue = true)]
        public bool AgeVerified { get; set; }

        /// <summary>
        /// Gets or Sets BackgroundType
        /// </summary>
        [DataMember(Name = "backgroundType", EmitDefaultValue = false)]
        public string BackgroundType { get; set; }

        /// <summary>
        /// Gets or Sets Badges
        /// </summary>
        [DataMember(Name = "badges", EmitDefaultValue = false)]
        public List<Badge> Badges { get; set; }

        /// <summary>
        /// Gets or Sets BannerColor
        /// </summary>
        [DataMember(Name = "bannerColor", EmitDefaultValue = false)]
        public string BannerColor { get; set; }

        /// <summary>
        /// Gets or Sets BannerType
        /// </summary>
        [DataMember(Name = "bannerType", EmitDefaultValue = false)]
        public string BannerType { get; set; }

        /// <summary>
        /// Gets or Sets Bio
        /// </summary>
        [DataMember(Name = "bio", EmitDefaultValue = false)]
        public string Bio { get; set; }

        /// <summary>
        /// Gets or Sets BioLinks
        /// </summary>
        [DataMember(Name = "bioLinks", EmitDefaultValue = false)]
        public List<string> BioLinks { get; set; }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name = "displayName", EmitDefaultValue = false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets HasVrcPlus
        /// </summary>
        [DataMember(Name = "hasVrcPlus", EmitDefaultValue = true)]
        public bool HasVrcPlus { get; set; }

        /// <summary>
        /// Gets or Sets IconFrame
        /// </summary>
        [DataMember(Name = "iconFrame", EmitDefaultValue = false)]
        public string IconFrame { get; set; }

        /// <summary>
        /// Gets or Sets IconUrl
        /// </summary>
        [DataMember(Name = "iconUrl", EmitDefaultValue = false)]
        public string IconUrl { get; set; }

        /// <summary>
        /// A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed.
        /// </summary>
        /// <value>A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed.</value>
        /*
        <example>usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469</example>
        */
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets IsEconomyCreator
        /// </summary>
        [DataMember(Name = "isEconomyCreator", EmitDefaultValue = true)]
        public bool IsEconomyCreator { get; set; }

        /// <summary>
        /// Gets or Sets Languages
        /// </summary>
        [DataMember(Name = "languages", EmitDefaultValue = false)]
        public List<string> Languages { get; set; }

        /// <summary>
        /// Gets or Sets NameplateEffect
        /// </summary>
        [DataMember(Name = "nameplateEffect", EmitDefaultValue = false)]
        public string NameplateEffect { get; set; }

        /// <summary>
        /// Gets or Sets ProfileEffect
        /// </summary>
        [DataMember(Name = "profileEffect", EmitDefaultValue = false)]
        public string ProfileEffect { get; set; }

        /// <summary>
        /// Gets or Sets Pronouns
        /// </summary>
        [DataMember(Name = "pronouns", EmitDefaultValue = false)]
        public string Pronouns { get; set; }

        /// <summary>
        /// Gets or Sets RepresentedGroup
        /// </summary>
        [DataMember(Name = "representedGroup", EmitDefaultValue = false)]
        public ProfileRepresentedGroup RepresentedGroup { get; set; }

        /// <summary>
        /// Gets or Sets ThemeId
        /// </summary>
        [DataMember(Name = "themeId", EmitDefaultValue = false)]
        public string ThemeId { get; set; }

        /// <summary>
        /// Gets or Sets TrustTags
        /// </summary>
        [DataMember(Name = "trustTags", EmitDefaultValue = false)]
        public List<string> TrustTags { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PublicProfile {\n");
            sb.Append("  AgeVerificationStatus: ").Append(AgeVerificationStatus).Append("\n");
            sb.Append("  AgeVerified: ").Append(AgeVerified).Append("\n");
            sb.Append("  BackgroundType: ").Append(BackgroundType).Append("\n");
            sb.Append("  Badges: ").Append(Badges).Append("\n");
            sb.Append("  BannerColor: ").Append(BannerColor).Append("\n");
            sb.Append("  BannerType: ").Append(BannerType).Append("\n");
            sb.Append("  Bio: ").Append(Bio).Append("\n");
            sb.Append("  BioLinks: ").Append(BioLinks).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  HasVrcPlus: ").Append(HasVrcPlus).Append("\n");
            sb.Append("  IconFrame: ").Append(IconFrame).Append("\n");
            sb.Append("  IconUrl: ").Append(IconUrl).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IsEconomyCreator: ").Append(IsEconomyCreator).Append("\n");
            sb.Append("  Languages: ").Append(Languages).Append("\n");
            sb.Append("  NameplateEffect: ").Append(NameplateEffect).Append("\n");
            sb.Append("  ProfileEffect: ").Append(ProfileEffect).Append("\n");
            sb.Append("  Pronouns: ").Append(Pronouns).Append("\n");
            sb.Append("  RepresentedGroup: ").Append(RepresentedGroup).Append("\n");
            sb.Append("  ThemeId: ").Append(ThemeId).Append("\n");
            sb.Append("  TrustTags: ").Append(TrustTags).Append("\n");
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
            return this.Equals(input as PublicProfile);
        }

        /// <summary>
        /// Returns true if PublicProfile instances are equal
        /// </summary>
        /// <param name="input">Instance of PublicProfile to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PublicProfile input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AgeVerificationStatus == input.AgeVerificationStatus ||
                    this.AgeVerificationStatus.Equals(input.AgeVerificationStatus)
                ) && 
                (
                    this.AgeVerified == input.AgeVerified ||
                    this.AgeVerified.Equals(input.AgeVerified)
                ) && 
                (
                    this.BackgroundType == input.BackgroundType ||
                    (this.BackgroundType != null &&
                    this.BackgroundType.Equals(input.BackgroundType))
                ) && 
                (
                    this.Badges == input.Badges ||
                    this.Badges != null &&
                    input.Badges != null &&
                    this.Badges.SequenceEqual(input.Badges)
                ) && 
                (
                    this.BannerColor == input.BannerColor ||
                    (this.BannerColor != null &&
                    this.BannerColor.Equals(input.BannerColor))
                ) && 
                (
                    this.BannerType == input.BannerType ||
                    (this.BannerType != null &&
                    this.BannerType.Equals(input.BannerType))
                ) && 
                (
                    this.Bio == input.Bio ||
                    (this.Bio != null &&
                    this.Bio.Equals(input.Bio))
                ) && 
                (
                    this.BioLinks == input.BioLinks ||
                    this.BioLinks != null &&
                    input.BioLinks != null &&
                    this.BioLinks.SequenceEqual(input.BioLinks)
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.HasVrcPlus == input.HasVrcPlus ||
                    this.HasVrcPlus.Equals(input.HasVrcPlus)
                ) && 
                (
                    this.IconFrame == input.IconFrame ||
                    (this.IconFrame != null &&
                    this.IconFrame.Equals(input.IconFrame))
                ) && 
                (
                    this.IconUrl == input.IconUrl ||
                    (this.IconUrl != null &&
                    this.IconUrl.Equals(input.IconUrl))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.IsEconomyCreator == input.IsEconomyCreator ||
                    this.IsEconomyCreator.Equals(input.IsEconomyCreator)
                ) && 
                (
                    this.Languages == input.Languages ||
                    this.Languages != null &&
                    input.Languages != null &&
                    this.Languages.SequenceEqual(input.Languages)
                ) && 
                (
                    this.NameplateEffect == input.NameplateEffect ||
                    (this.NameplateEffect != null &&
                    this.NameplateEffect.Equals(input.NameplateEffect))
                ) && 
                (
                    this.ProfileEffect == input.ProfileEffect ||
                    (this.ProfileEffect != null &&
                    this.ProfileEffect.Equals(input.ProfileEffect))
                ) && 
                (
                    this.Pronouns == input.Pronouns ||
                    (this.Pronouns != null &&
                    this.Pronouns.Equals(input.Pronouns))
                ) && 
                (
                    this.RepresentedGroup == input.RepresentedGroup ||
                    (this.RepresentedGroup != null &&
                    this.RepresentedGroup.Equals(input.RepresentedGroup))
                ) && 
                (
                    this.ThemeId == input.ThemeId ||
                    (this.ThemeId != null &&
                    this.ThemeId.Equals(input.ThemeId))
                ) && 
                (
                    this.TrustTags == input.TrustTags ||
                    this.TrustTags != null &&
                    input.TrustTags != null &&
                    this.TrustTags.SequenceEqual(input.TrustTags)
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
                hashCode = (hashCode * 59) + this.AgeVerificationStatus.GetHashCode();
                hashCode = (hashCode * 59) + this.AgeVerified.GetHashCode();
                if (this.BackgroundType != null)
                {
                    hashCode = (hashCode * 59) + this.BackgroundType.GetHashCode();
                }
                if (this.Badges != null)
                {
                    hashCode = (hashCode * 59) + this.Badges.GetHashCode();
                }
                if (this.BannerColor != null)
                {
                    hashCode = (hashCode * 59) + this.BannerColor.GetHashCode();
                }
                if (this.BannerType != null)
                {
                    hashCode = (hashCode * 59) + this.BannerType.GetHashCode();
                }
                if (this.Bio != null)
                {
                    hashCode = (hashCode * 59) + this.Bio.GetHashCode();
                }
                if (this.BioLinks != null)
                {
                    hashCode = (hashCode * 59) + this.BioLinks.GetHashCode();
                }
                if (this.DisplayName != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.HasVrcPlus.GetHashCode();
                if (this.IconFrame != null)
                {
                    hashCode = (hashCode * 59) + this.IconFrame.GetHashCode();
                }
                if (this.IconUrl != null)
                {
                    hashCode = (hashCode * 59) + this.IconUrl.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsEconomyCreator.GetHashCode();
                if (this.Languages != null)
                {
                    hashCode = (hashCode * 59) + this.Languages.GetHashCode();
                }
                if (this.NameplateEffect != null)
                {
                    hashCode = (hashCode * 59) + this.NameplateEffect.GetHashCode();
                }
                if (this.ProfileEffect != null)
                {
                    hashCode = (hashCode * 59) + this.ProfileEffect.GetHashCode();
                }
                if (this.Pronouns != null)
                {
                    hashCode = (hashCode * 59) + this.Pronouns.GetHashCode();
                }
                if (this.RepresentedGroup != null)
                {
                    hashCode = (hashCode * 59) + this.RepresentedGroup.GetHashCode();
                }
                if (this.ThemeId != null)
                {
                    hashCode = (hashCode * 59) + this.ThemeId.GetHashCode();
                }
                if (this.TrustTags != null)
                {
                    hashCode = (hashCode * 59) + this.TrustTags.GetHashCode();
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
