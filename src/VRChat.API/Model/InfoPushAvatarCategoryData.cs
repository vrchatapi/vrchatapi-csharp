

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
    /// InfoPushAvatarCategoryData
    /// </summary>
    [DataContract(Name = "InfoPushAvatarCategoryData")]
    public partial class InfoPushAvatarCategoryData : IEquatable<InfoPushAvatarCategoryData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InfoPushAvatarCategoryData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InfoPushAvatarCategoryData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InfoPushAvatarCategoryData" /> class.
        /// </summary>
        /// <param name="contentList">contentList (required).</param>
        /// <param name="imageUrl">imageUrl (required).</param>
        public InfoPushAvatarCategoryData(DynamicContentRow contentList = default, string imageUrl = default)
        {
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.ContentList = contentList;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.ImageUrl = imageUrl;
        }

        /// <summary>
        /// Gets or Sets ContentList
        /// </summary>
        [DataMember(Name = "contentList", IsRequired = true, EmitDefaultValue = true)]
        public DynamicContentRow ContentList { get; set; }

        /// <summary>
        /// Gets or Sets ImageUrl
        /// </summary>
        [DataMember(Name = "imageUrl", IsRequired = true, EmitDefaultValue = true)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InfoPushAvatarCategoryData {\n");
            sb.Append("  ContentList: ").Append(ContentList).Append("\n");
            sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
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
            return this.Equals(input as InfoPushAvatarCategoryData);
        }

        /// <summary>
        /// Returns true if InfoPushAvatarCategoryData instances are equal
        /// </summary>
        /// <param name="input">Instance of InfoPushAvatarCategoryData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InfoPushAvatarCategoryData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ContentList == input.ContentList ||
                    (this.ContentList != null &&
                    this.ContentList.Equals(input.ContentList))
                ) && 
                (
                    this.ImageUrl == input.ImageUrl ||
                    (this.ImageUrl != null &&
                    this.ImageUrl.Equals(input.ImageUrl))
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
                if (this.ContentList != null)
                {
                    hashCode = (hashCode * 59) + this.ContentList.GetHashCode();
                }
                if (this.ImageUrl != null)
                {
                    hashCode = (hashCode * 59) + this.ImageUrl.GetHashCode();
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
