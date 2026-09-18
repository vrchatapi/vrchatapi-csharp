

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
    /// UpdateProfileRequest
    /// </summary>
    [DataContract(Name = "UpdateProfileRequest")]
    public partial class UpdateProfileRequest : IEquatable<UpdateProfileRequest>, IValidatableObject
    {
        /// <summary>
        /// Defines BackgroundType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum BackgroundTypeEnum
        {
            /// <summary>
            /// Enum Default for value: default
            /// </summary>
            [EnumMember(Value = "default")]
            Default = 1,

            /// <summary>
            /// Enum Gradient for value: gradient
            /// </summary>
            [EnumMember(Value = "gradient")]
            Gradient = 2,

            /// <summary>
            /// Enum Inventory for value: inventory
            /// </summary>
            [EnumMember(Value = "inventory")]
            Inventory = 3,

            /// <summary>
            /// Enum Texture for value: texture
            /// </summary>
            [EnumMember(Value = "texture")]
            Texture = 4
        }


        /// <summary>
        /// Gets or Sets BackgroundType
        /// </summary>
        [DataMember(Name = "backgroundType", EmitDefaultValue = false)]
        public BackgroundTypeEnum? BackgroundType { get; set; }
        /// <summary>
        /// Defines BannerType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum BannerTypeEnum
        {
            /// <summary>
            /// Enum AvatarBanner for value: avatarBanner
            /// </summary>
            [EnumMember(Value = "avatarBanner")]
            AvatarBanner = 1,

            /// <summary>
            /// Enum Color for value: color
            /// </summary>
            [EnumMember(Value = "color")]
            Color = 2,

            /// <summary>
            /// Enum CustomImage for value: customImage
            /// </summary>
            [EnumMember(Value = "customImage")]
            CustomImage = 3
        }


        /// <summary>
        /// Gets or Sets BannerType
        /// </summary>
        [DataMember(Name = "bannerType", EmitDefaultValue = false)]
        public BannerTypeEnum? BannerType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProfileRequest" /> class.
        /// </summary>
        /// <param name="backgroundTextureId">backgroundTextureId.</param>
        /// <param name="backgroundType">backgroundType.</param>
        /// <param name="bannerColor">Six hexadecimal digits, without a leading &#x60;#&#x60;. May be empty..</param>
        /// <param name="bannerType">bannerType.</param>
        /// <param name="bio">bio.</param>
        /// <param name="bioLinks">bioLinks.</param>
        /// <param name="iconFrame">iconFrame.</param>
        /// <param name="languages">languages.</param>
        /// <param name="nameplateEffect">nameplateEffect.</param>
        /// <param name="profileEffect">profileEffect.</param>
        /// <param name="themeId">themeId.</param>
        /// <param name="userIcon">userIcon.</param>
        public UpdateProfileRequest(string backgroundTextureId = default, BackgroundTypeEnum? backgroundType = default, string bannerColor = default, BannerTypeEnum? bannerType = default, string bio = default, List<string> bioLinks = default, string iconFrame = default, List<string> languages = default, string nameplateEffect = default, string profileEffect = default, string themeId = default, string userIcon = default)
        {
            this.BackgroundTextureId = backgroundTextureId;
            this.BackgroundType = backgroundType;
            this.BannerColor = bannerColor;
            this.BannerType = bannerType;
            this.Bio = bio;
            this.BioLinks = bioLinks;
            this.IconFrame = iconFrame;
            this.Languages = languages;
            this.NameplateEffect = nameplateEffect;
            this.ProfileEffect = profileEffect;
            this.ThemeId = themeId;
            this.UserIcon = userIcon;
        }

        /// <summary>
        /// Gets or Sets BackgroundTextureId
        /// </summary>
        [DataMember(Name = "backgroundTextureId", EmitDefaultValue = false)]
        public string BackgroundTextureId { get; set; }

        /// <summary>
        /// Six hexadecimal digits, without a leading &#x60;#&#x60;. May be empty.
        /// </summary>
        /// <value>Six hexadecimal digits, without a leading &#x60;#&#x60;. May be empty.</value>
        /*
        <example>3cc92c</example>
        */
        [DataMember(Name = "bannerColor", EmitDefaultValue = false)]
        public string BannerColor { get; set; }

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
        /// Gets or Sets IconFrame
        /// </summary>
        /*
        <example>invt_b80ce14b-038b-4f56-b970-d232771d62e3</example>
        */
        [DataMember(Name = "iconFrame", EmitDefaultValue = false)]
        public string IconFrame { get; set; }

        /// <summary>
        /// Gets or Sets Languages
        /// </summary>
        [DataMember(Name = "languages", EmitDefaultValue = false)]
        public List<string> Languages { get; set; }

        /// <summary>
        /// Gets or Sets NameplateEffect
        /// </summary>
        /*
        <example>invt_b80ce14b-038b-4f56-b970-d232771d62e3</example>
        */
        [DataMember(Name = "nameplateEffect", EmitDefaultValue = false)]
        public string NameplateEffect { get; set; }

        /// <summary>
        /// Gets or Sets ProfileEffect
        /// </summary>
        /*
        <example>invt_b80ce14b-038b-4f56-b970-d232771d62e3</example>
        */
        [DataMember(Name = "profileEffect", EmitDefaultValue = false)]
        public string ProfileEffect { get; set; }

        /// <summary>
        /// Gets or Sets ThemeId
        /// </summary>
        [DataMember(Name = "themeId", EmitDefaultValue = false)]
        public string ThemeId { get; set; }

        /// <summary>
        /// Gets or Sets UserIcon
        /// </summary>
        [DataMember(Name = "userIcon", EmitDefaultValue = false)]
        public string UserIcon { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdateProfileRequest {\n");
            sb.Append("  BackgroundTextureId: ").Append(BackgroundTextureId).Append("\n");
            sb.Append("  BackgroundType: ").Append(BackgroundType).Append("\n");
            sb.Append("  BannerColor: ").Append(BannerColor).Append("\n");
            sb.Append("  BannerType: ").Append(BannerType).Append("\n");
            sb.Append("  Bio: ").Append(Bio).Append("\n");
            sb.Append("  BioLinks: ").Append(BioLinks).Append("\n");
            sb.Append("  IconFrame: ").Append(IconFrame).Append("\n");
            sb.Append("  Languages: ").Append(Languages).Append("\n");
            sb.Append("  NameplateEffect: ").Append(NameplateEffect).Append("\n");
            sb.Append("  ProfileEffect: ").Append(ProfileEffect).Append("\n");
            sb.Append("  ThemeId: ").Append(ThemeId).Append("\n");
            sb.Append("  UserIcon: ").Append(UserIcon).Append("\n");
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
            return this.Equals(input as UpdateProfileRequest);
        }

        /// <summary>
        /// Returns true if UpdateProfileRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateProfileRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateProfileRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BackgroundTextureId == input.BackgroundTextureId ||
                    (this.BackgroundTextureId != null &&
                    this.BackgroundTextureId.Equals(input.BackgroundTextureId))
                ) && 
                (
                    this.BackgroundType == input.BackgroundType ||
                    this.BackgroundType.Equals(input.BackgroundType)
                ) && 
                (
                    this.BannerColor == input.BannerColor ||
                    (this.BannerColor != null &&
                    this.BannerColor.Equals(input.BannerColor))
                ) && 
                (
                    this.BannerType == input.BannerType ||
                    this.BannerType.Equals(input.BannerType)
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
                    this.IconFrame == input.IconFrame ||
                    (this.IconFrame != null &&
                    this.IconFrame.Equals(input.IconFrame))
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
                    this.ThemeId == input.ThemeId ||
                    (this.ThemeId != null &&
                    this.ThemeId.Equals(input.ThemeId))
                ) && 
                (
                    this.UserIcon == input.UserIcon ||
                    (this.UserIcon != null &&
                    this.UserIcon.Equals(input.UserIcon))
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
                if (this.BackgroundTextureId != null)
                {
                    hashCode = (hashCode * 59) + this.BackgroundTextureId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.BackgroundType.GetHashCode();
                if (this.BannerColor != null)
                {
                    hashCode = (hashCode * 59) + this.BannerColor.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.BannerType.GetHashCode();
                if (this.Bio != null)
                {
                    hashCode = (hashCode * 59) + this.Bio.GetHashCode();
                }
                if (this.BioLinks != null)
                {
                    hashCode = (hashCode * 59) + this.BioLinks.GetHashCode();
                }
                if (this.IconFrame != null)
                {
                    hashCode = (hashCode * 59) + this.IconFrame.GetHashCode();
                }
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
                if (this.ThemeId != null)
                {
                    hashCode = (hashCode * 59) + this.ThemeId.GetHashCode();
                }
                if (this.UserIcon != null)
                {
                    hashCode = (hashCode * 59) + this.UserIcon.GetHashCode();
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
