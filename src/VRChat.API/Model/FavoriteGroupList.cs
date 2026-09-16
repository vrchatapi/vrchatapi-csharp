

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
    /// A user&#39;s favorite groups of one type, with the limits that apply to them.
    /// </summary>
    [DataContract(Name = "FavoriteGroupList")]
    public partial class FavoriteGroupList : IEquatable<FavoriteGroupList>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FavoriteGroupList" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FavoriteGroupList() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FavoriteGroupList" /> class.
        /// </summary>
        /// <param name="favoriteGroups">favoriteGroups (required).</param>
        /// <param name="maxFavoriteGroups">Only returned when the owner is the currently authenticated user..</param>
        /// <param name="maxFavoritesPerGroup">Only returned when the owner is the currently authenticated user..</param>
        public FavoriteGroupList(List<FavoriteGroupSummary> favoriteGroups = default, int maxFavoriteGroups = default, int maxFavoritesPerGroup = default)
        {
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.FavoriteGroups = favoriteGroups;
            this.MaxFavoriteGroups = maxFavoriteGroups;
            this.MaxFavoritesPerGroup = maxFavoritesPerGroup;
        }

        /// <summary>
        /// Gets or Sets FavoriteGroups
        /// </summary>
        [DataMember(Name = "favoriteGroups", IsRequired = true, EmitDefaultValue = true)]
        public List<FavoriteGroupSummary> FavoriteGroups { get; set; }

        /// <summary>
        /// Only returned when the owner is the currently authenticated user.
        /// </summary>
        /// <value>Only returned when the owner is the currently authenticated user.</value>
        [DataMember(Name = "maxFavoriteGroups", EmitDefaultValue = false)]
        public int MaxFavoriteGroups { get; set; }

        /// <summary>
        /// Only returned when the owner is the currently authenticated user.
        /// </summary>
        /// <value>Only returned when the owner is the currently authenticated user.</value>
        [DataMember(Name = "maxFavoritesPerGroup", EmitDefaultValue = false)]
        public int MaxFavoritesPerGroup { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FavoriteGroupList {\n");
            sb.Append("  FavoriteGroups: ").Append(FavoriteGroups).Append("\n");
            sb.Append("  MaxFavoriteGroups: ").Append(MaxFavoriteGroups).Append("\n");
            sb.Append("  MaxFavoritesPerGroup: ").Append(MaxFavoritesPerGroup).Append("\n");
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
            return this.Equals(input as FavoriteGroupList);
        }

        /// <summary>
        /// Returns true if FavoriteGroupList instances are equal
        /// </summary>
        /// <param name="input">Instance of FavoriteGroupList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FavoriteGroupList input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.FavoriteGroups == input.FavoriteGroups ||
                    this.FavoriteGroups != null &&
                    input.FavoriteGroups != null &&
                    this.FavoriteGroups.SequenceEqual(input.FavoriteGroups)
                ) && 
                (
                    this.MaxFavoriteGroups == input.MaxFavoriteGroups ||
                    this.MaxFavoriteGroups.Equals(input.MaxFavoriteGroups)
                ) && 
                (
                    this.MaxFavoritesPerGroup == input.MaxFavoritesPerGroup ||
                    this.MaxFavoritesPerGroup.Equals(input.MaxFavoritesPerGroup)
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
                if (this.FavoriteGroups != null)
                {
                    hashCode = (hashCode * 59) + this.FavoriteGroups.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.MaxFavoriteGroups.GetHashCode();
                hashCode = (hashCode * 59) + this.MaxFavoritesPerGroup.GetHashCode();
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
            // MaxFavoriteGroups (int) minimum
            if (this.MaxFavoriteGroups < (int)0)
            {
                yield return new ValidationResult("Invalid value for MaxFavoriteGroups, must be a value greater than or equal to 0.", new [] { "MaxFavoriteGroups" });
            }

            // MaxFavoritesPerGroup (int) minimum
            if (this.MaxFavoritesPerGroup < (int)0)
            {
                yield return new ValidationResult("Invalid value for MaxFavoritesPerGroup, must be a value greater than or equal to 0.", new [] { "MaxFavoritesPerGroup" });
            }

            yield break;
        }
    }

}
