

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
    /// InfoPushHelpArticleData
    /// </summary>
    [DataContract(Name = "InfoPushHelpArticleData")]
    public partial class InfoPushHelpArticleData : IEquatable<InfoPushHelpArticleData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InfoPushHelpArticleData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InfoPushHelpArticleData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InfoPushHelpArticleData" /> class.
        /// </summary>
        /// <param name="article">article (required).</param>
        /// <param name="description">description (required).</param>
        /// <param name="imageUrl">imageUrl (required).</param>
        /// <param name="name">name (required).</param>
        public InfoPushHelpArticleData(InfoPushDataArticle article = default, LocalizableString description = default, string imageUrl = default, LocalizableString name = default)
        {
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Article = article;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Description = description;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.ImageUrl = imageUrl;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Name = name;
        }

        /// <summary>
        /// Gets or Sets Article
        /// </summary>
        [DataMember(Name = "article", IsRequired = true, EmitDefaultValue = true)]
        public InfoPushDataArticle Article { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = true)]
        public LocalizableString Description { get; set; }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InfoPushHelpArticleData {\n");
            sb.Append("  Article: ").Append(Article).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as InfoPushHelpArticleData);
        }

        /// <summary>
        /// Returns true if InfoPushHelpArticleData instances are equal
        /// </summary>
        /// <param name="input">Instance of InfoPushHelpArticleData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InfoPushHelpArticleData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Article == input.Article ||
                    (this.Article != null &&
                    this.Article.Equals(input.Article))
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.Article != null)
                {
                    hashCode = (hashCode * 59) + this.Article.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.ImageUrl != null)
                {
                    hashCode = (hashCode * 59) + this.ImageUrl.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
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
