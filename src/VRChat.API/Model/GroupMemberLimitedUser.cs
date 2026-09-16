

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
    /// Only visible via the /groups/:groupId/members endpoint, **not** when fetching a specific user.
    /// </summary>
    [DataContract(Name = "GroupMemberLimitedUser")]
    public partial class GroupMemberLimitedUser : IEquatable<GroupMemberLimitedUser>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupMemberLimitedUser" /> class.
        /// </summary>
        /// <param name="bannerColor">Six hexadecimal digits, without a leading &#x60;#&#x60;. May be empty..</param>
        /// <param name="bannerType">bannerType.</param>
        /// <param name="bannerUrl">bannerUrl.</param>
        /// <param name="displayName">displayName.</param>
        /// <param name="iconFrame">iconFrame.</param>
        /// <param name="iconUrl">iconUrl.</param>
        /// <param name="id">A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed..</param>
        /// <param name="nameplateEffect">nameplateEffect.</param>
        /// <param name="profileEffect">profileEffect.</param>
        public GroupMemberLimitedUser(string bannerColor = default, string bannerType = default, string bannerUrl = default, string displayName = default, string iconFrame = default, string iconUrl = default, string id = default, string nameplateEffect = default, string profileEffect = default)
        {
            this.BannerColor = bannerColor;
            this.BannerType = bannerType;
            this.BannerUrl = bannerUrl;
            this.DisplayName = displayName;
            this.IconFrame = iconFrame;
            this.IconUrl = iconUrl;
            this.Id = id;
            this.NameplateEffect = nameplateEffect;
            this.ProfileEffect = profileEffect;
        }

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
        /// Gets or Sets BannerType
        /// </summary>
        [DataMember(Name = "bannerType", EmitDefaultValue = false)]
        public string BannerType { get; set; }

        /// <summary>
        /// Gets or Sets BannerUrl
        /// </summary>
        [DataMember(Name = "bannerUrl", EmitDefaultValue = false)]
        public string BannerUrl { get; set; }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name = "displayName", EmitDefaultValue = false)]
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
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GroupMemberLimitedUser {\n");
            sb.Append("  BannerColor: ").Append(BannerColor).Append("\n");
            sb.Append("  BannerType: ").Append(BannerType).Append("\n");
            sb.Append("  BannerUrl: ").Append(BannerUrl).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  IconFrame: ").Append(IconFrame).Append("\n");
            sb.Append("  IconUrl: ").Append(IconUrl).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  NameplateEffect: ").Append(NameplateEffect).Append("\n");
            sb.Append("  ProfileEffect: ").Append(ProfileEffect).Append("\n");
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
            return this.Equals(input as GroupMemberLimitedUser);
        }

        /// <summary>
        /// Returns true if GroupMemberLimitedUser instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupMemberLimitedUser to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupMemberLimitedUser input)
        {
            if (input == null)
            {
                return false;
            }
            return 
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
                    this.BannerUrl == input.BannerUrl ||
                    (this.BannerUrl != null &&
                    this.BannerUrl.Equals(input.BannerUrl))
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
                    this.NameplateEffect == input.NameplateEffect ||
                    (this.NameplateEffect != null &&
                    this.NameplateEffect.Equals(input.NameplateEffect))
                ) && 
                (
                    this.ProfileEffect == input.ProfileEffect ||
                    (this.ProfileEffect != null &&
                    this.ProfileEffect.Equals(input.ProfileEffect))
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
                if (this.BannerColor != null)
                {
                    hashCode = (hashCode * 59) + this.BannerColor.GetHashCode();
                }
                if (this.BannerType != null)
                {
                    hashCode = (hashCode * 59) + this.BannerType.GetHashCode();
                }
                if (this.BannerUrl != null)
                {
                    hashCode = (hashCode * 59) + this.BannerUrl.GetHashCode();
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
                if (this.NameplateEffect != null)
                {
                    hashCode = (hashCode * 59) + this.NameplateEffect.GetHashCode();
                }
                if (this.ProfileEffect != null)
                {
                    hashCode = (hashCode * 59) + this.ProfileEffect.GetHashCode();
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
