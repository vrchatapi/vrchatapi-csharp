

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
    /// User object received when querying mutual friends
    /// </summary>
    [DataContract(Name = "MutualFriend")]
    public partial class MutualFriend : IEquatable<MutualFriend>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public UserStatus Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MutualFriend" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MutualFriend() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MutualFriend" /> class.
        /// </summary>
        /// <param name="avatarThumbnail">When profilePicOverride is not empty, use it instead..</param>
        /// <param name="bannerColor">Hex colour without a leading &#x60;#&#x60;..</param>
        /// <param name="bannerType">bannerType.</param>
        /// <param name="currentAvatarImageUrl">When profilePicOverride is not empty, use it instead. (required).</param>
        /// <param name="currentAvatarTags">currentAvatarTags.</param>
        /// <param name="currentAvatarThumbnailImageUrl">When profilePicOverride is not empty, use it instead..</param>
        /// <param name="displayName">displayName (required).</param>
        /// <param name="iconFrame">iconFrame.</param>
        /// <param name="iconUrl">iconUrl.</param>
        /// <param name="id">A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed. (required).</param>
        /// <param name="imageUrl">imageUrl (required).</param>
        /// <param name="nameplateEffect">nameplateEffect.</param>
        /// <param name="profileEffect">profileEffect.</param>
        /// <param name="profilePicOverride">profilePicOverride.</param>
        /// <param name="status">status (required).</param>
        /// <param name="statusDescription">statusDescription (required).</param>
        public MutualFriend(string avatarThumbnail = default, string bannerColor = default, string bannerType = default, string currentAvatarImageUrl = default, List<string> currentAvatarTags = default, string currentAvatarThumbnailImageUrl = default, string displayName = default, string iconFrame = default, string iconUrl = default, string id = default, string imageUrl = default, string nameplateEffect = default, string profileEffect = default, string profilePicOverride = default, UserStatus status = default, string statusDescription = default)
        {
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.CurrentAvatarImageUrl = currentAvatarImageUrl;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.DisplayName = displayName;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Id = id;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.ImageUrl = imageUrl;
            this.Status = status;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.StatusDescription = statusDescription;
            this.AvatarThumbnail = avatarThumbnail;
            this.BannerColor = bannerColor;
            this.BannerType = bannerType;
            this.CurrentAvatarTags = currentAvatarTags;
            this.CurrentAvatarThumbnailImageUrl = currentAvatarThumbnailImageUrl;
            this.IconFrame = iconFrame;
            this.IconUrl = iconUrl;
            this.NameplateEffect = nameplateEffect;
            this.ProfileEffect = profileEffect;
            this.ProfilePicOverride = profilePicOverride;
        }

        /// <summary>
        /// When profilePicOverride is not empty, use it instead.
        /// </summary>
        /// <value>When profilePicOverride is not empty, use it instead.</value>
        /*
        <example>https://api.vrchat.cloud/api/1/image/file_aae83ed9-d42d-4d72-9f4b-9f1e41ed17e1/1/256</example>
        */
        [DataMember(Name = "avatarThumbnail", EmitDefaultValue = false)]
        public string AvatarThumbnail { get; set; }

        /// <summary>
        /// Hex colour without a leading &#x60;#&#x60;.
        /// </summary>
        /// <value>Hex colour without a leading &#x60;#&#x60;.</value>
        /*
        <example>3cc92c</example>
        */
        [DataMember(Name = "bannerColor", EmitDefaultValue = false)]
        public string BannerColor { get; set; }

        /// <summary>
        /// Gets or Sets BannerType
        /// </summary>
        /*
        <example>color</example>
        */
        [DataMember(Name = "bannerType", EmitDefaultValue = false)]
        public string BannerType { get; set; }

        /// <summary>
        /// When profilePicOverride is not empty, use it instead.
        /// </summary>
        /// <value>When profilePicOverride is not empty, use it instead.</value>
        /*
        <example>https://api.vrchat.cloud/api/1/file/file_ae46d521-7281-4b38-b365-804b32a1d6a7/1/file</example>
        */
        [DataMember(Name = "currentAvatarImageUrl", IsRequired = true, EmitDefaultValue = true)]
        public string CurrentAvatarImageUrl { get; set; }

        /// <summary>
        /// Gets or Sets CurrentAvatarTags
        /// </summary>
        [DataMember(Name = "currentAvatarTags", EmitDefaultValue = false)]
        public List<string> CurrentAvatarTags { get; set; }

        /// <summary>
        /// When profilePicOverride is not empty, use it instead.
        /// </summary>
        /// <value>When profilePicOverride is not empty, use it instead.</value>
        /*
        <example>https://api.vrchat.cloud/api/1/image/file_aae83ed9-d42d-4d72-9f4b-9f1e41ed17e1/1/256</example>
        */
        [DataMember(Name = "currentAvatarThumbnailImageUrl", EmitDefaultValue = false)]
        public string CurrentAvatarThumbnailImageUrl { get; set; }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name = "displayName", IsRequired = true, EmitDefaultValue = true)]
        public string DisplayName { get; set; }

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
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets ImageUrl
        /// </summary>
        [DataMember(Name = "imageUrl", IsRequired = true, EmitDefaultValue = true)]
        public string ImageUrl { get; set; }

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
        /// Gets or Sets ProfilePicOverride
        /// </summary>
        [DataMember(Name = "profilePicOverride", EmitDefaultValue = false)]
        public string ProfilePicOverride { get; set; }

        /// <summary>
        /// Gets or Sets StatusDescription
        /// </summary>
        [DataMember(Name = "statusDescription", IsRequired = true, EmitDefaultValue = true)]
        public string StatusDescription { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MutualFriend {\n");
            sb.Append("  AvatarThumbnail: ").Append(AvatarThumbnail).Append("\n");
            sb.Append("  BannerColor: ").Append(BannerColor).Append("\n");
            sb.Append("  BannerType: ").Append(BannerType).Append("\n");
            sb.Append("  CurrentAvatarImageUrl: ").Append(CurrentAvatarImageUrl).Append("\n");
            sb.Append("  CurrentAvatarTags: ").Append(CurrentAvatarTags).Append("\n");
            sb.Append("  CurrentAvatarThumbnailImageUrl: ").Append(CurrentAvatarThumbnailImageUrl).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  IconFrame: ").Append(IconFrame).Append("\n");
            sb.Append("  IconUrl: ").Append(IconUrl).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("  NameplateEffect: ").Append(NameplateEffect).Append("\n");
            sb.Append("  ProfileEffect: ").Append(ProfileEffect).Append("\n");
            sb.Append("  ProfilePicOverride: ").Append(ProfilePicOverride).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StatusDescription: ").Append(StatusDescription).Append("\n");
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
            return this.Equals(input as MutualFriend);
        }

        /// <summary>
        /// Returns true if MutualFriend instances are equal
        /// </summary>
        /// <param name="input">Instance of MutualFriend to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MutualFriend input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AvatarThumbnail == input.AvatarThumbnail ||
                    (this.AvatarThumbnail != null &&
                    this.AvatarThumbnail.Equals(input.AvatarThumbnail))
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
                    this.CurrentAvatarImageUrl == input.CurrentAvatarImageUrl ||
                    (this.CurrentAvatarImageUrl != null &&
                    this.CurrentAvatarImageUrl.Equals(input.CurrentAvatarImageUrl))
                ) && 
                (
                    this.CurrentAvatarTags == input.CurrentAvatarTags ||
                    this.CurrentAvatarTags != null &&
                    input.CurrentAvatarTags != null &&
                    this.CurrentAvatarTags.SequenceEqual(input.CurrentAvatarTags)
                ) && 
                (
                    this.CurrentAvatarThumbnailImageUrl == input.CurrentAvatarThumbnailImageUrl ||
                    (this.CurrentAvatarThumbnailImageUrl != null &&
                    this.CurrentAvatarThumbnailImageUrl.Equals(input.CurrentAvatarThumbnailImageUrl))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
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
                    this.ImageUrl == input.ImageUrl ||
                    (this.ImageUrl != null &&
                    this.ImageUrl.Equals(input.ImageUrl))
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
                    this.ProfilePicOverride == input.ProfilePicOverride ||
                    (this.ProfilePicOverride != null &&
                    this.ProfilePicOverride.Equals(input.ProfilePicOverride))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.StatusDescription == input.StatusDescription ||
                    (this.StatusDescription != null &&
                    this.StatusDescription.Equals(input.StatusDescription))
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
                if (this.AvatarThumbnail != null)
                {
                    hashCode = (hashCode * 59) + this.AvatarThumbnail.GetHashCode();
                }
                if (this.BannerColor != null)
                {
                    hashCode = (hashCode * 59) + this.BannerColor.GetHashCode();
                }
                if (this.BannerType != null)
                {
                    hashCode = (hashCode * 59) + this.BannerType.GetHashCode();
                }
                if (this.CurrentAvatarImageUrl != null)
                {
                    hashCode = (hashCode * 59) + this.CurrentAvatarImageUrl.GetHashCode();
                }
                if (this.CurrentAvatarTags != null)
                {
                    hashCode = (hashCode * 59) + this.CurrentAvatarTags.GetHashCode();
                }
                if (this.CurrentAvatarThumbnailImageUrl != null)
                {
                    hashCode = (hashCode * 59) + this.CurrentAvatarThumbnailImageUrl.GetHashCode();
                }
                if (this.DisplayName != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayName.GetHashCode();
                }
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
                if (this.ImageUrl != null)
                {
                    hashCode = (hashCode * 59) + this.ImageUrl.GetHashCode();
                }
                if (this.NameplateEffect != null)
                {
                    hashCode = (hashCode * 59) + this.NameplateEffect.GetHashCode();
                }
                if (this.ProfileEffect != null)
                {
                    hashCode = (hashCode * 59) + this.ProfileEffect.GetHashCode();
                }
                if (this.ProfilePicOverride != null)
                {
                    hashCode = (hashCode * 59) + this.ProfilePicOverride.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.StatusDescription != null)
                {
                    hashCode = (hashCode * 59) + this.StatusDescription.GetHashCode();
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
