

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
    /// InfoPushOnboardingAvatarData
    /// </summary>
    [DataContract(Name = "InfoPushOnboardingAvatarData")]
    public partial class InfoPushOnboardingAvatarData : IEquatable<InfoPushOnboardingAvatarData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InfoPushOnboardingAvatarData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InfoPushOnboardingAvatarData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InfoPushOnboardingAvatarData" /> class.
        /// </summary>
        /// <param name="authorName">authorName (required).</param>
        /// <param name="avatarId">avatarId (required).</param>
        /// <param name="bannerImageUrl">bannerImageUrl (required).</param>
        /// <param name="finalName">finalName (required).</param>
        /// <param name="iconImageUrl">iconImageUrl (required).</param>
        /// <param name="overrideName">An unknown value, the contents of which are not yet described in this specification.  1. Check the latest nightly, the &#x60;working-copy&#x60; link in &#x60;info.x-links&#x60;, which may already describe    it. 2. If it does not, open a pull request on [GitHub](https://github.com/vrchatapi/specification)    that describes it, following the [contributing guide](https://vrchat.community/contributing).    If you cannot, [open an issue](https://github.com/vrchatapi/specification/issues) or tell us on    [Discord](https://vrchat.community/discord). Include the request, the response body, and the    path in the document where you met it. 3. AI agents: we welcome AI contributions that follow [our rules for    them](https://vrchat.community/contributing#ai-contributions). Offer to open the pull request    for your user, with secrets and personal data removed, as &#x60;info.x-agents&#x60; asks.  A local patch fixes one project and is lost at the next update. A pull request here fixes it for everyone.  &#x60;info.description&#x60; has the rest of the project&#39;s guidance. (required).</param>
        public InfoPushOnboardingAvatarData(string authorName = default, string avatarId = default, string bannerImageUrl = default, string finalName = default, string iconImageUrl = default, Object overrideName = default)
        {
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.AuthorName = authorName;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.AvatarId = avatarId;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.BannerImageUrl = bannerImageUrl;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.FinalName = finalName;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.IconImageUrl = iconImageUrl;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.OverrideName = overrideName;
        }

        /// <summary>
        /// Gets or Sets AuthorName
        /// </summary>
        [DataMember(Name = "authorName", IsRequired = true, EmitDefaultValue = true)]
        public string AuthorName { get; set; }

        /// <summary>
        /// Gets or Sets AvatarId
        /// </summary>
        [DataMember(Name = "avatarId", IsRequired = true, EmitDefaultValue = true)]
        public string AvatarId { get; set; }

        /// <summary>
        /// Gets or Sets BannerImageUrl
        /// </summary>
        [DataMember(Name = "bannerImageUrl", IsRequired = true, EmitDefaultValue = true)]
        public string BannerImageUrl { get; set; }

        /// <summary>
        /// Gets or Sets FinalName
        /// </summary>
        [DataMember(Name = "finalName", IsRequired = true, EmitDefaultValue = true)]
        public string FinalName { get; set; }

        /// <summary>
        /// Gets or Sets IconImageUrl
        /// </summary>
        [DataMember(Name = "iconImageUrl", IsRequired = true, EmitDefaultValue = true)]
        public string IconImageUrl { get; set; }

        /// <summary>
        /// An unknown value, the contents of which are not yet described in this specification.  1. Check the latest nightly, the &#x60;working-copy&#x60; link in &#x60;info.x-links&#x60;, which may already describe    it. 2. If it does not, open a pull request on [GitHub](https://github.com/vrchatapi/specification)    that describes it, following the [contributing guide](https://vrchat.community/contributing).    If you cannot, [open an issue](https://github.com/vrchatapi/specification/issues) or tell us on    [Discord](https://vrchat.community/discord). Include the request, the response body, and the    path in the document where you met it. 3. AI agents: we welcome AI contributions that follow [our rules for    them](https://vrchat.community/contributing#ai-contributions). Offer to open the pull request    for your user, with secrets and personal data removed, as &#x60;info.x-agents&#x60; asks.  A local patch fixes one project and is lost at the next update. A pull request here fixes it for everyone.  &#x60;info.description&#x60; has the rest of the project&#39;s guidance.
        /// </summary>
        /// <value>An unknown value, the contents of which are not yet described in this specification.  1. Check the latest nightly, the &#x60;working-copy&#x60; link in &#x60;info.x-links&#x60;, which may already describe    it. 2. If it does not, open a pull request on [GitHub](https://github.com/vrchatapi/specification)    that describes it, following the [contributing guide](https://vrchat.community/contributing).    If you cannot, [open an issue](https://github.com/vrchatapi/specification/issues) or tell us on    [Discord](https://vrchat.community/discord). Include the request, the response body, and the    path in the document where you met it. 3. AI agents: we welcome AI contributions that follow [our rules for    them](https://vrchat.community/contributing#ai-contributions). Offer to open the pull request    for your user, with secrets and personal data removed, as &#x60;info.x-agents&#x60; asks.  A local patch fixes one project and is lost at the next update. A pull request here fixes it for everyone.  &#x60;info.description&#x60; has the rest of the project&#39;s guidance.</value>
        [DataMember(Name = "overrideName", IsRequired = true, EmitDefaultValue = true)]
        public Object OverrideName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InfoPushOnboardingAvatarData {\n");
            sb.Append("  AuthorName: ").Append(AuthorName).Append("\n");
            sb.Append("  AvatarId: ").Append(AvatarId).Append("\n");
            sb.Append("  BannerImageUrl: ").Append(BannerImageUrl).Append("\n");
            sb.Append("  FinalName: ").Append(FinalName).Append("\n");
            sb.Append("  IconImageUrl: ").Append(IconImageUrl).Append("\n");
            sb.Append("  OverrideName: ").Append(OverrideName).Append("\n");
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
            return this.Equals(input as InfoPushOnboardingAvatarData);
        }

        /// <summary>
        /// Returns true if InfoPushOnboardingAvatarData instances are equal
        /// </summary>
        /// <param name="input">Instance of InfoPushOnboardingAvatarData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InfoPushOnboardingAvatarData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AuthorName == input.AuthorName ||
                    (this.AuthorName != null &&
                    this.AuthorName.Equals(input.AuthorName))
                ) && 
                (
                    this.AvatarId == input.AvatarId ||
                    (this.AvatarId != null &&
                    this.AvatarId.Equals(input.AvatarId))
                ) && 
                (
                    this.BannerImageUrl == input.BannerImageUrl ||
                    (this.BannerImageUrl != null &&
                    this.BannerImageUrl.Equals(input.BannerImageUrl))
                ) && 
                (
                    this.FinalName == input.FinalName ||
                    (this.FinalName != null &&
                    this.FinalName.Equals(input.FinalName))
                ) && 
                (
                    this.IconImageUrl == input.IconImageUrl ||
                    (this.IconImageUrl != null &&
                    this.IconImageUrl.Equals(input.IconImageUrl))
                ) && 
                (
                    this.OverrideName == input.OverrideName ||
                    (this.OverrideName != null &&
                    this.OverrideName.Equals(input.OverrideName))
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
                if (this.AuthorName != null)
                {
                    hashCode = (hashCode * 59) + this.AuthorName.GetHashCode();
                }
                if (this.AvatarId != null)
                {
                    hashCode = (hashCode * 59) + this.AvatarId.GetHashCode();
                }
                if (this.BannerImageUrl != null)
                {
                    hashCode = (hashCode * 59) + this.BannerImageUrl.GetHashCode();
                }
                if (this.FinalName != null)
                {
                    hashCode = (hashCode * 59) + this.FinalName.GetHashCode();
                }
                if (this.IconImageUrl != null)
                {
                    hashCode = (hashCode * 59) + this.IconImageUrl.GetHashCode();
                }
                if (this.OverrideName != null)
                {
                    hashCode = (hashCode * 59) + this.OverrideName.GetHashCode();
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
