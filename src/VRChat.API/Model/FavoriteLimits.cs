/*
 * VRChat API Documentation
 *
 *
 * The version of the OpenAPI document: 1.18.9
 * Contact: vrchatapi.lpv0t@aries.fyi
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


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
using OpenAPIDateConverter = VRChat.API.Client.OpenAPIDateConverter;

namespace VRChat.API.Model
{
    /// <summary>
    /// FavoriteLimits
    /// </summary>
    [DataContract(Name = "FavoriteLimits")]
    public partial class FavoriteLimits : IEquatable<FavoriteLimits>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FavoriteLimits" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FavoriteLimits() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FavoriteLimits" /> class.
        /// </summary>
        /// <param name="defaultMaxFavoriteGroups">defaultMaxFavoriteGroups (required).</param>
        /// <param name="defaultMaxFavoritesPerGroup">defaultMaxFavoritesPerGroup (required).</param>
        /// <param name="maxFavoriteGroups">maxFavoriteGroups (required).</param>
        /// <param name="maxFavoritesPerGroup">maxFavoritesPerGroup (required).</param>
        public FavoriteLimits(int defaultMaxFavoriteGroups = default(int), int defaultMaxFavoritesPerGroup = default(int), FavoriteGroupLimits maxFavoriteGroups = default(FavoriteGroupLimits), FavoriteGroupLimits maxFavoritesPerGroup = default(FavoriteGroupLimits))
        {
            this.DefaultMaxFavoriteGroups = defaultMaxFavoriteGroups;
            this.DefaultMaxFavoritesPerGroup = defaultMaxFavoritesPerGroup;
            // to ensure "maxFavoriteGroups" is required (not null)
            if (maxFavoriteGroups == null)
            {
                throw new ArgumentNullException("maxFavoriteGroups is a required property for FavoriteLimits and cannot be null");
            }
            this.MaxFavoriteGroups = maxFavoriteGroups;
            // to ensure "maxFavoritesPerGroup" is required (not null)
            if (maxFavoritesPerGroup == null)
            {
                throw new ArgumentNullException("maxFavoritesPerGroup is a required property for FavoriteLimits and cannot be null");
            }
            this.MaxFavoritesPerGroup = maxFavoritesPerGroup;
        }

        /// <summary>
        /// Gets or Sets DefaultMaxFavoriteGroups
        /// </summary>
        [DataMember(Name = "defaultMaxFavoriteGroups", IsRequired = true, EmitDefaultValue = true)]
        public int DefaultMaxFavoriteGroups { get; set; }

        /// <summary>
        /// Gets or Sets DefaultMaxFavoritesPerGroup
        /// </summary>
        [DataMember(Name = "defaultMaxFavoritesPerGroup", IsRequired = true, EmitDefaultValue = true)]
        public int DefaultMaxFavoritesPerGroup { get; set; }

        /// <summary>
        /// Gets or Sets MaxFavoriteGroups
        /// </summary>
        [DataMember(Name = "maxFavoriteGroups", IsRequired = true, EmitDefaultValue = true)]
        public FavoriteGroupLimits MaxFavoriteGroups { get; set; }

        /// <summary>
        /// Gets or Sets MaxFavoritesPerGroup
        /// </summary>
        [DataMember(Name = "maxFavoritesPerGroup", IsRequired = true, EmitDefaultValue = true)]
        public FavoriteGroupLimits MaxFavoritesPerGroup { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FavoriteLimits {\n");
            sb.Append("  DefaultMaxFavoriteGroups: ").Append(DefaultMaxFavoriteGroups).Append("\n");
            sb.Append("  DefaultMaxFavoritesPerGroup: ").Append(DefaultMaxFavoritesPerGroup).Append("\n");
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
            return this.Equals(input as FavoriteLimits);
        }

        /// <summary>
        /// Returns true if FavoriteLimits instances are equal
        /// </summary>
        /// <param name="input">Instance of FavoriteLimits to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FavoriteLimits input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DefaultMaxFavoriteGroups == input.DefaultMaxFavoriteGroups ||
                    this.DefaultMaxFavoriteGroups.Equals(input.DefaultMaxFavoriteGroups)
                ) && 
                (
                    this.DefaultMaxFavoritesPerGroup == input.DefaultMaxFavoritesPerGroup ||
                    this.DefaultMaxFavoritesPerGroup.Equals(input.DefaultMaxFavoritesPerGroup)
                ) && 
                (
                    this.MaxFavoriteGroups == input.MaxFavoriteGroups ||
                    (this.MaxFavoriteGroups != null &&
                    this.MaxFavoriteGroups.Equals(input.MaxFavoriteGroups))
                ) && 
                (
                    this.MaxFavoritesPerGroup == input.MaxFavoritesPerGroup ||
                    (this.MaxFavoritesPerGroup != null &&
                    this.MaxFavoritesPerGroup.Equals(input.MaxFavoritesPerGroup))
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
                hashCode = (hashCode * 59) + this.DefaultMaxFavoriteGroups.GetHashCode();
                hashCode = (hashCode * 59) + this.DefaultMaxFavoritesPerGroup.GetHashCode();
                if (this.MaxFavoriteGroups != null)
                {
                    hashCode = (hashCode * 59) + this.MaxFavoriteGroups.GetHashCode();
                }
                if (this.MaxFavoritesPerGroup != null)
                {
                    hashCode = (hashCode * 59) + this.MaxFavoritesPerGroup.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
