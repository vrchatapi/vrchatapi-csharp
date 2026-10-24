

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
    /// InfoPushMarketplacePageData
    /// </summary>
    [DataContract(Name = "InfoPushMarketplacePageData")]
    public partial class InfoPushMarketplacePageData : IEquatable<InfoPushMarketplacePageData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InfoPushMarketplacePageData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InfoPushMarketplacePageData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InfoPushMarketplacePageData" /> class.
        /// </summary>
        /// <param name="iconImageUrl">iconImageUrl (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="tooltipDescription">tooltipDescription (required).</param>
        /// <param name="categories">categories (required).</param>
        /// <param name="featuredAvatarCategoryId">featuredAvatarCategoryId.</param>
        public InfoPushMarketplacePageData(string iconImageUrl = default, LocalizableString name = default, LocalizableString tooltipDescription = default, List<InfoPushDataCategory> categories = default, string featuredAvatarCategoryId = default)
        {
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.IconImageUrl = iconImageUrl;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Name = name;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.TooltipDescription = tooltipDescription;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Categories = categories;
            this.FeaturedAvatarCategoryId = featuredAvatarCategoryId;
        }

        /// <summary>
        /// Gets or Sets IconImageUrl
        /// </summary>
        [DataMember(Name = "iconImageUrl", IsRequired = true, EmitDefaultValue = true)]
        public string IconImageUrl { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public LocalizableString Name { get; set; }

        /// <summary>
        /// Gets or Sets TooltipDescription
        /// </summary>
        [DataMember(Name = "tooltipDescription", IsRequired = true, EmitDefaultValue = true)]
        public LocalizableString TooltipDescription { get; set; }

        /// <summary>
        /// Gets or Sets Categories
        /// </summary>
        [DataMember(Name = "categories", IsRequired = true, EmitDefaultValue = true)]
        public List<InfoPushDataCategory> Categories { get; set; }

        /// <summary>
        /// Gets or Sets FeaturedAvatarCategoryId
        /// </summary>
        [DataMember(Name = "featuredAvatarCategoryId", EmitDefaultValue = false)]
        public string FeaturedAvatarCategoryId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InfoPushMarketplacePageData {\n");
            sb.Append("  IconImageUrl: ").Append(IconImageUrl).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  TooltipDescription: ").Append(TooltipDescription).Append("\n");
            sb.Append("  Categories: ").Append(Categories).Append("\n");
            sb.Append("  FeaturedAvatarCategoryId: ").Append(FeaturedAvatarCategoryId).Append("\n");
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
            return this.Equals(input as InfoPushMarketplacePageData);
        }

        /// <summary>
        /// Returns true if InfoPushMarketplacePageData instances are equal
        /// </summary>
        /// <param name="input">Instance of InfoPushMarketplacePageData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InfoPushMarketplacePageData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.IconImageUrl == input.IconImageUrl ||
                    (this.IconImageUrl != null &&
                    this.IconImageUrl.Equals(input.IconImageUrl))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.TooltipDescription == input.TooltipDescription ||
                    (this.TooltipDescription != null &&
                    this.TooltipDescription.Equals(input.TooltipDescription))
                ) && 
                (
                    this.Categories == input.Categories ||
                    this.Categories != null &&
                    input.Categories != null &&
                    this.Categories.SequenceEqual(input.Categories)
                ) && 
                (
                    this.FeaturedAvatarCategoryId == input.FeaturedAvatarCategoryId ||
                    (this.FeaturedAvatarCategoryId != null &&
                    this.FeaturedAvatarCategoryId.Equals(input.FeaturedAvatarCategoryId))
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
                if (this.IconImageUrl != null)
                {
                    hashCode = (hashCode * 59) + this.IconImageUrl.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.TooltipDescription != null)
                {
                    hashCode = (hashCode * 59) + this.TooltipDescription.GetHashCode();
                }
                if (this.Categories != null)
                {
                    hashCode = (hashCode * 59) + this.Categories.GetHashCode();
                }
                if (this.FeaturedAvatarCategoryId != null)
                {
                    hashCode = (hashCode * 59) + this.FeaturedAvatarCategoryId.GetHashCode();
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
