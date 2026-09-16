

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
    /// Stands in for a world the API will not describe. &#x60;name&#x60; and &#x60;authorName&#x60; are &#x60;???&#x60;, &#x60;imageUrl&#x60; is empty, and the counts are &#x60;0&#x60;.
    /// </summary>
    [DataContract(Name = "UnavailableWorld")]
    public partial class UnavailableWorld : IEquatable<UnavailableWorld>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnavailableWorld" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UnavailableWorld() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UnavailableWorld" /> class.
        /// </summary>
        /// <param name="authorName">authorName (required).</param>
        /// <param name="capacity">capacity (required).</param>
        /// <param name="id">WorldID be \&quot;offline\&quot; on User profiles if you are not friends with that user. (required).</param>
        /// <param name="imageUrl">imageUrl (required).</param>
        /// <param name="isSecure">isSecure (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="occupants">occupants (required).</param>
        /// <param name="thumbnailImageUrl">thumbnailImageUrl (required).</param>
        public UnavailableWorld(string authorName = default, int capacity = default, string id = default, string imageUrl = default, bool isSecure = default, string name = default, int occupants = default, string thumbnailImageUrl = default)
        {
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.AuthorName = authorName;
            this.Capacity = capacity;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Id = id;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.ImageUrl = imageUrl;
            this.IsSecure = isSecure;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Name = name;
            this.Occupants = occupants;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.ThumbnailImageUrl = thumbnailImageUrl;
        }

        /// <summary>
        /// Gets or Sets AuthorName
        /// </summary>
        /*
        <example>???</example>
        */
        [DataMember(Name = "authorName", IsRequired = true, EmitDefaultValue = true)]
        public string AuthorName { get; set; }

        /// <summary>
        /// Gets or Sets Capacity
        /// </summary>
        [DataMember(Name = "capacity", IsRequired = true, EmitDefaultValue = true)]
        public int Capacity { get; set; }

        /// <summary>
        /// WorldID be \&quot;offline\&quot; on User profiles if you are not friends with that user.
        /// </summary>
        /// <value>WorldID be \&quot;offline\&quot; on User profiles if you are not friends with that user.</value>
        /*
        <example>wrld_4432ea9b-729c-46e3-8eaf-846aa0a37fdd</example>
        */
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets ImageUrl
        /// </summary>
        [DataMember(Name = "imageUrl", IsRequired = true, EmitDefaultValue = true)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// Gets or Sets IsSecure
        /// </summary>
        [DataMember(Name = "isSecure", IsRequired = true, EmitDefaultValue = true)]
        public bool IsSecure { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        /*
        <example>???</example>
        */
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Occupants
        /// </summary>
        [DataMember(Name = "occupants", IsRequired = true, EmitDefaultValue = true)]
        public int Occupants { get; set; }

        /// <summary>
        /// Gets or Sets ThumbnailImageUrl
        /// </summary>
        /*
        <example>https://assets.vrchat.com/default/unavailable-world.png</example>
        */
        [DataMember(Name = "thumbnailImageUrl", IsRequired = true, EmitDefaultValue = true)]
        public string ThumbnailImageUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UnavailableWorld {\n");
            sb.Append("  AuthorName: ").Append(AuthorName).Append("\n");
            sb.Append("  Capacity: ").Append(Capacity).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("  IsSecure: ").Append(IsSecure).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Occupants: ").Append(Occupants).Append("\n");
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
            return this.Equals(input as UnavailableWorld);
        }

        /// <summary>
        /// Returns true if UnavailableWorld instances are equal
        /// </summary>
        /// <param name="input">Instance of UnavailableWorld to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UnavailableWorld input)
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
                    this.Capacity == input.Capacity ||
                    this.Capacity.Equals(input.Capacity)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.ImageUrl == input.ImageUrl ||
                    (this.ImageUrl != null &&
                    this.ImageUrl.Equals(input.ImageUrl))
                ) && 
                (
                    this.IsSecure == input.IsSecure ||
                    this.IsSecure.Equals(input.IsSecure)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Occupants == input.Occupants ||
                    this.Occupants.Equals(input.Occupants)
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
                if (this.AuthorName != null)
                {
                    hashCode = (hashCode * 59) + this.AuthorName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Capacity.GetHashCode();
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.ImageUrl != null)
                {
                    hashCode = (hashCode * 59) + this.ImageUrl.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsSecure.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Occupants.GetHashCode();
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
