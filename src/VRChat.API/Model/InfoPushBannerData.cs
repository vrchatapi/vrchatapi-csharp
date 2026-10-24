

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
    /// InfoPushBannerData
    /// </summary>
    [DataContract(Name = "InfoPushBannerData")]
    public partial class InfoPushBannerData : IEquatable<InfoPushBannerData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InfoPushBannerData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InfoPushBannerData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InfoPushBannerData" /> class.
        /// </summary>
        /// <param name="imageUrl">imageUrl (required).</param>
        /// <param name="name">name.</param>
        /// <param name="onPressed">onPressed.</param>
        public InfoPushBannerData(string imageUrl = default, LocalizableString name = default, InfoPushDataClickable onPressed = default)
        {
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.ImageUrl = imageUrl;
            this.Name = name;
            this.OnPressed = onPressed;
        }

        /// <summary>
        /// Gets or Sets ImageUrl
        /// </summary>
        [DataMember(Name = "imageUrl", IsRequired = true, EmitDefaultValue = true)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public LocalizableString Name { get; set; }

        /// <summary>
        /// Gets or Sets OnPressed
        /// </summary>
        [DataMember(Name = "onPressed", EmitDefaultValue = true)]
        public InfoPushDataClickable OnPressed { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InfoPushBannerData {\n");
            sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OnPressed: ").Append(OnPressed).Append("\n");
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
            return this.Equals(input as InfoPushBannerData);
        }

        /// <summary>
        /// Returns true if InfoPushBannerData instances are equal
        /// </summary>
        /// <param name="input">Instance of InfoPushBannerData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InfoPushBannerData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
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
                    this.OnPressed == input.OnPressed ||
                    (this.OnPressed != null &&
                    this.OnPressed.Equals(input.OnPressed))
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
                if (this.ImageUrl != null)
                {
                    hashCode = (hashCode * 59) + this.ImageUrl.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.OnPressed != null)
                {
                    hashCode = (hashCode * 59) + this.OnPressed.GetHashCode();
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
