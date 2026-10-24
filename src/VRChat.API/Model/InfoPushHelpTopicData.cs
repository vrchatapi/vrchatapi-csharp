

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
    /// InfoPushHelpTopicData
    /// </summary>
    [DataContract(Name = "InfoPushHelpTopicData")]
    public partial class InfoPushHelpTopicData : IEquatable<InfoPushHelpTopicData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InfoPushHelpTopicData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InfoPushHelpTopicData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InfoPushHelpTopicData" /> class.
        /// </summary>
        /// <param name="iconImageUrl">iconImageUrl (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="tooltipDescription">tooltipDescription (required).</param>
        /// <param name="description">description (required).</param>
        /// <param name="imageUrl">imageUrl.</param>
        /// <param name="ipsQuery">ipsQuery (required).</param>
        /// <param name="isNew">isNew (required).</param>
        /// <param name="thumbnailImageUrl">thumbnailImageUrl.</param>
        public InfoPushHelpTopicData(string iconImageUrl = default, LocalizableString name = default, LocalizableString tooltipDescription = default, LocalizableString description = default, string imageUrl = default, InfoPushIpsQuery ipsQuery = default, bool isNew = default, string thumbnailImageUrl = default)
        {
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.IconImageUrl = iconImageUrl;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Name = name;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.TooltipDescription = tooltipDescription;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Description = description;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.IpsQuery = ipsQuery;
            this.IsNew = isNew;
            this.ImageUrl = imageUrl;
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
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = true)]
        public LocalizableString Description { get; set; }

        /// <summary>
        /// Gets or Sets ImageUrl
        /// </summary>
        [DataMember(Name = "imageUrl", EmitDefaultValue = true)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// Gets or Sets IpsQuery
        /// </summary>
        [DataMember(Name = "ipsQuery", IsRequired = true, EmitDefaultValue = true)]
        public InfoPushIpsQuery IpsQuery { get; set; }

        /// <summary>
        /// Gets or Sets IsNew
        /// </summary>
        [DataMember(Name = "isNew", IsRequired = true, EmitDefaultValue = true)]
        public bool IsNew { get; set; }

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
            sb.Append("class InfoPushHelpTopicData {\n");
            sb.Append("  IconImageUrl: ").Append(IconImageUrl).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  TooltipDescription: ").Append(TooltipDescription).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("  IpsQuery: ").Append(IpsQuery).Append("\n");
            sb.Append("  IsNew: ").Append(IsNew).Append("\n");
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
            return this.Equals(input as InfoPushHelpTopicData);
        }

        /// <summary>
        /// Returns true if InfoPushHelpTopicData instances are equal
        /// </summary>
        /// <param name="input">Instance of InfoPushHelpTopicData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InfoPushHelpTopicData input)
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
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.ImageUrl == input.ImageUrl ||
                    (this.ImageUrl != null &&
                    this.ImageUrl.Equals(input.ImageUrl))
                ) && 
                (
                    this.IpsQuery == input.IpsQuery ||
                    (this.IpsQuery != null &&
                    this.IpsQuery.Equals(input.IpsQuery))
                ) && 
                (
                    this.IsNew == input.IsNew ||
                    this.IsNew.Equals(input.IsNew)
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
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.ImageUrl != null)
                {
                    hashCode = (hashCode * 59) + this.ImageUrl.GetHashCode();
                }
                if (this.IpsQuery != null)
                {
                    hashCode = (hashCode * 59) + this.IpsQuery.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsNew.GetHashCode();
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
