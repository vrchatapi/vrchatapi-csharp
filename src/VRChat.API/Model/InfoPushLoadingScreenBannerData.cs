

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
    /// InfoPushLoadingScreenBannerData
    /// </summary>
    [DataContract(Name = "InfoPushLoadingScreenBannerData")]
    public partial class InfoPushLoadingScreenBannerData : IEquatable<InfoPushLoadingScreenBannerData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InfoPushLoadingScreenBannerData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InfoPushLoadingScreenBannerData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InfoPushLoadingScreenBannerData" /> class.
        /// </summary>
        /// <param name="category">category (required).</param>
        /// <param name="imageUrl">imageUrl (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="weight">weight (required).</param>
        public InfoPushLoadingScreenBannerData(string category = default, string imageUrl = default, LocalizableString name = default, int weight = default)
        {
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Category = category;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.ImageUrl = imageUrl;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Name = name;
            this.Weight = weight;
        }

        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name = "category", IsRequired = true, EmitDefaultValue = true)]
        public string Category { get; set; }

        /// <summary>
        /// Gets or Sets ImageUrl
        /// </summary>
        [DataMember(Name = "imageUrl", IsRequired = true, EmitDefaultValue = true)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public LocalizableString Name { get; set; }

        /// <summary>
        /// Gets or Sets Weight
        /// </summary>
        [DataMember(Name = "weight", IsRequired = true, EmitDefaultValue = true)]
        public int Weight { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InfoPushLoadingScreenBannerData {\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Weight: ").Append(Weight).Append("\n");
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
            return this.Equals(input as InfoPushLoadingScreenBannerData);
        }

        /// <summary>
        /// Returns true if InfoPushLoadingScreenBannerData instances are equal
        /// </summary>
        /// <param name="input">Instance of InfoPushLoadingScreenBannerData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InfoPushLoadingScreenBannerData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.ImageUrl == input.ImageUrl ||
                    (this.ImageUrl != null &&
                    this.ImageUrl.Equals(input.ImageUrl))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Weight == input.Weight ||
                    this.Weight.Equals(input.Weight)
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
                if (this.Category != null)
                {
                    hashCode = (hashCode * 59) + this.Category.GetHashCode();
                }
                if (this.ImageUrl != null)
                {
                    hashCode = (hashCode * 59) + this.ImageUrl.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Weight.GetHashCode();
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
