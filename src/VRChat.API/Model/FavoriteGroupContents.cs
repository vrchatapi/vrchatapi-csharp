

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
    /// FavoriteGroupContents
    /// </summary>
    [DataContract(Name = "FavoriteGroupContents")]
    public partial class FavoriteGroupContents : IEquatable<FavoriteGroupContents>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FavoriteGroupContents" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FavoriteGroupContents() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FavoriteGroupContents" /> class.
        /// </summary>
        /// <param name="favorites">favorites (required).</param>
        /// <param name="totalCount">totalCount (required).</param>
        public FavoriteGroupContents(List<FavoriteGroupContentsEntry> favorites = default, int totalCount = default)
        {
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Favorites = favorites;
            this.TotalCount = totalCount;
        }

        /// <summary>
        /// Gets or Sets Favorites
        /// </summary>
        [DataMember(Name = "favorites", IsRequired = true, EmitDefaultValue = true)]
        public List<FavoriteGroupContentsEntry> Favorites { get; set; }

        /// <summary>
        /// Gets or Sets TotalCount
        /// </summary>
        [DataMember(Name = "totalCount", IsRequired = true, EmitDefaultValue = true)]
        public int TotalCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FavoriteGroupContents {\n");
            sb.Append("  Favorites: ").Append(Favorites).Append("\n");
            sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
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
            return this.Equals(input as FavoriteGroupContents);
        }

        /// <summary>
        /// Returns true if FavoriteGroupContents instances are equal
        /// </summary>
        /// <param name="input">Instance of FavoriteGroupContents to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FavoriteGroupContents input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Favorites == input.Favorites ||
                    this.Favorites != null &&
                    input.Favorites != null &&
                    this.Favorites.SequenceEqual(input.Favorites)
                ) && 
                (
                    this.TotalCount == input.TotalCount ||
                    this.TotalCount.Equals(input.TotalCount)
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
                if (this.Favorites != null)
                {
                    hashCode = (hashCode * 59) + this.Favorites.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TotalCount.GetHashCode();
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
