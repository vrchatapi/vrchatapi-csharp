

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
    /// WebsocketUserUpdateUser
    /// </summary>
    [DataContract(Name = "WebsocketUserUpdateUser")]
    public partial class WebsocketUserUpdateUser : IEquatable<WebsocketUserUpdateUser>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public UserStatus Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebsocketUserUpdateUser" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WebsocketUserUpdateUser() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebsocketUserUpdateUser" /> class.
        /// </summary>
        /// <param name="bio">bio (required).</param>
        /// <param name="currentAvatar">currentAvatar (required).</param>
        /// <param name="currentAvatarImageUrl">currentAvatarImageUrl (required).</param>
        /// <param name="currentAvatarThumbnailImageUrl">currentAvatarThumbnailImageUrl (required).</param>
        /// <param name="displayName">displayName (required).</param>
        /// <param name="fallbackAvatar">fallbackAvatar (required).</param>
        /// <param name="id">A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed. (required).</param>
        /// <param name="profilePicOverride">profilePicOverride (required).</param>
        /// <param name="status">status (required).</param>
        /// <param name="statusDescription">statusDescription (required).</param>
        /// <param name="tags">tags (required).</param>
        /// <param name="userIcon">userIcon (required).</param>
        /// <param name="username">username (required).</param>
        public WebsocketUserUpdateUser(string bio = default, string currentAvatar = default, string currentAvatarImageUrl = default, string currentAvatarThumbnailImageUrl = default, string displayName = default, string fallbackAvatar = default, string id = default, string profilePicOverride = default, UserStatus status = default, string statusDescription = default, List<string> tags = default, string userIcon = default, string username = default)
        {
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Bio = bio;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.CurrentAvatar = currentAvatar;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.CurrentAvatarImageUrl = currentAvatarImageUrl;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.CurrentAvatarThumbnailImageUrl = currentAvatarThumbnailImageUrl;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.DisplayName = displayName;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.FallbackAvatar = fallbackAvatar;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Id = id;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.ProfilePicOverride = profilePicOverride;
            this.Status = status;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.StatusDescription = statusDescription;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Tags = tags;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.UserIcon = userIcon;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Username = username;
        }

        /// <summary>
        /// Gets or Sets Bio
        /// </summary>
        [DataMember(Name = "bio", IsRequired = true, EmitDefaultValue = true)]
        public string Bio { get; set; }

        /// <summary>
        /// Gets or Sets CurrentAvatar
        /// </summary>
        [DataMember(Name = "currentAvatar", IsRequired = true, EmitDefaultValue = true)]
        public string CurrentAvatar { get; set; }

        /// <summary>
        /// Gets or Sets CurrentAvatarImageUrl
        /// </summary>
        [DataMember(Name = "currentAvatarImageUrl", IsRequired = true, EmitDefaultValue = true)]
        public string CurrentAvatarImageUrl { get; set; }

        /// <summary>
        /// Gets or Sets CurrentAvatarThumbnailImageUrl
        /// </summary>
        [DataMember(Name = "currentAvatarThumbnailImageUrl", IsRequired = true, EmitDefaultValue = true)]
        public string CurrentAvatarThumbnailImageUrl { get; set; }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name = "displayName", IsRequired = true, EmitDefaultValue = true)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets FallbackAvatar
        /// </summary>
        [DataMember(Name = "fallbackAvatar", IsRequired = true, EmitDefaultValue = true)]
        public string FallbackAvatar { get; set; }

        /// <summary>
        /// A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed.
        /// </summary>
        /// <value>A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets ProfilePicOverride
        /// </summary>
        [DataMember(Name = "profilePicOverride", IsRequired = true, EmitDefaultValue = true)]
        public string ProfilePicOverride { get; set; }

        /// <summary>
        /// Gets or Sets StatusDescription
        /// </summary>
        [DataMember(Name = "statusDescription", IsRequired = true, EmitDefaultValue = true)]
        public string StatusDescription { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name = "tags", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Gets or Sets UserIcon
        /// </summary>
        [DataMember(Name = "userIcon", IsRequired = true, EmitDefaultValue = true)]
        public string UserIcon { get; set; }

        /// <summary>
        /// Gets or Sets Username
        /// </summary>
        [DataMember(Name = "username", IsRequired = true, EmitDefaultValue = true)]
        public string Username { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WebsocketUserUpdateUser {\n");
            sb.Append("  Bio: ").Append(Bio).Append("\n");
            sb.Append("  CurrentAvatar: ").Append(CurrentAvatar).Append("\n");
            sb.Append("  CurrentAvatarImageUrl: ").Append(CurrentAvatarImageUrl).Append("\n");
            sb.Append("  CurrentAvatarThumbnailImageUrl: ").Append(CurrentAvatarThumbnailImageUrl).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  FallbackAvatar: ").Append(FallbackAvatar).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ProfilePicOverride: ").Append(ProfilePicOverride).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StatusDescription: ").Append(StatusDescription).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  UserIcon: ").Append(UserIcon).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
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
            return this.Equals(input as WebsocketUserUpdateUser);
        }

        /// <summary>
        /// Returns true if WebsocketUserUpdateUser instances are equal
        /// </summary>
        /// <param name="input">Instance of WebsocketUserUpdateUser to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebsocketUserUpdateUser input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Bio == input.Bio ||
                    (this.Bio != null &&
                    this.Bio.Equals(input.Bio))
                ) && 
                (
                    this.CurrentAvatar == input.CurrentAvatar ||
                    (this.CurrentAvatar != null &&
                    this.CurrentAvatar.Equals(input.CurrentAvatar))
                ) && 
                (
                    this.CurrentAvatarImageUrl == input.CurrentAvatarImageUrl ||
                    (this.CurrentAvatarImageUrl != null &&
                    this.CurrentAvatarImageUrl.Equals(input.CurrentAvatarImageUrl))
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
                    this.FallbackAvatar == input.FallbackAvatar ||
                    (this.FallbackAvatar != null &&
                    this.FallbackAvatar.Equals(input.FallbackAvatar))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.UserIcon == input.UserIcon ||
                    (this.UserIcon != null &&
                    this.UserIcon.Equals(input.UserIcon))
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
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
                if (this.Bio != null)
                {
                    hashCode = (hashCode * 59) + this.Bio.GetHashCode();
                }
                if (this.CurrentAvatar != null)
                {
                    hashCode = (hashCode * 59) + this.CurrentAvatar.GetHashCode();
                }
                if (this.CurrentAvatarImageUrl != null)
                {
                    hashCode = (hashCode * 59) + this.CurrentAvatarImageUrl.GetHashCode();
                }
                if (this.CurrentAvatarThumbnailImageUrl != null)
                {
                    hashCode = (hashCode * 59) + this.CurrentAvatarThumbnailImageUrl.GetHashCode();
                }
                if (this.DisplayName != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayName.GetHashCode();
                }
                if (this.FallbackAvatar != null)
                {
                    hashCode = (hashCode * 59) + this.FallbackAvatar.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
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
                if (this.Tags != null)
                {
                    hashCode = (hashCode * 59) + this.Tags.GetHashCode();
                }
                if (this.UserIcon != null)
                {
                    hashCode = (hashCode * 59) + this.UserIcon.GetHashCode();
                }
                if (this.Username != null)
                {
                    hashCode = (hashCode * 59) + this.Username.GetHashCode();
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
