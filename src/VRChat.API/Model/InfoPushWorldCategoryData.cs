

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
    /// InfoPushWorldCategoryData
    /// </summary>
    [DataContract(Name = "InfoPushWorldCategoryData")]
    public partial class InfoPushWorldCategoryData : IEquatable<InfoPushWorldCategoryData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InfoPushWorldCategoryData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InfoPushWorldCategoryData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InfoPushWorldCategoryData" /> class.
        /// </summary>
        /// <param name="iconImageUrl">iconImageUrl (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="tooltipDescription">tooltipDescription (required).</param>
        /// <param name="contentList">contentList (required).</param>
        /// <param name="hoverToJoin">hoverToJoin.</param>
        /// <param name="shortName">shortName.</param>
        /// <param name="thumbnailImageUrl">thumbnailImageUrl.</param>
        public InfoPushWorldCategoryData(string iconImageUrl = default, LocalizableString name = default, LocalizableString tooltipDescription = default, DynamicContentRow contentList = default, bool hoverToJoin = default, LocalizableString shortName = default, string thumbnailImageUrl = default)
        {
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.IconImageUrl = iconImageUrl;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Name = name;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.TooltipDescription = tooltipDescription;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.ContentList = contentList;
            this.HoverToJoin = hoverToJoin;
            this.ShortName = shortName;
            this.ThumbnailImageUrl = thumbnailImageUrl;
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
        /// Gets or Sets ContentList
        /// </summary>
        [DataMember(Name = "contentList", IsRequired = true, EmitDefaultValue = true)]
        public DynamicContentRow ContentList { get; set; }

        /// <summary>
        /// Gets or Sets HoverToJoin
        /// </summary>
        [DataMember(Name = "hoverToJoin", EmitDefaultValue = true)]
        public bool HoverToJoin { get; set; }

        /// <summary>
        /// Gets or Sets ShortName
        /// </summary>
        [DataMember(Name = "shortName", EmitDefaultValue = true)]
        public LocalizableString ShortName { get; set; }

        /// <summary>
        /// Gets or Sets ThumbnailImageUrl
        /// </summary>
        [DataMember(Name = "thumbnailImageUrl", EmitDefaultValue = true)]
        public string ThumbnailImageUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InfoPushWorldCategoryData {\n");
            sb.Append("  IconImageUrl: ").Append(IconImageUrl).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  TooltipDescription: ").Append(TooltipDescription).Append("\n");
            sb.Append("  ContentList: ").Append(ContentList).Append("\n");
            sb.Append("  HoverToJoin: ").Append(HoverToJoin).Append("\n");
            sb.Append("  ShortName: ").Append(ShortName).Append("\n");
            sb.Append("  ThumbnailImageUrl: ").Append(ThumbnailImageUrl).Append("\n");
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
            return this.Equals(input as InfoPushWorldCategoryData);
        }

        /// <summary>
        /// Returns true if InfoPushWorldCategoryData instances are equal
        /// </summary>
        /// <param name="input">Instance of InfoPushWorldCategoryData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InfoPushWorldCategoryData input)
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
                    this.ContentList == input.ContentList ||
                    (this.ContentList != null &&
                    this.ContentList.Equals(input.ContentList))
                ) && 
                (
                    this.HoverToJoin == input.HoverToJoin ||
                    this.HoverToJoin.Equals(input.HoverToJoin)
                ) && 
                (
                    this.ShortName == input.ShortName ||
                    (this.ShortName != null &&
                    this.ShortName.Equals(input.ShortName))
                ) && 
                (
                    this.ThumbnailImageUrl == input.ThumbnailImageUrl ||
                    (this.ThumbnailImageUrl != null &&
                    this.ThumbnailImageUrl.Equals(input.ThumbnailImageUrl))
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
                if (this.ContentList != null)
                {
                    hashCode = (hashCode * 59) + this.ContentList.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.HoverToJoin.GetHashCode();
                if (this.ShortName != null)
                {
                    hashCode = (hashCode * 59) + this.ShortName.GetHashCode();
                }
                if (this.ThumbnailImageUrl != null)
                {
                    hashCode = (hashCode * 59) + this.ThumbnailImageUrl.GetHashCode();
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
