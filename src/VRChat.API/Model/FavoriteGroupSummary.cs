

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
    /// A favorite group as listed for one favorite type.
    /// </summary>
    [DataContract(Name = "FavoriteGroupSummary")]
    public partial class FavoriteGroupSummary : IEquatable<FavoriteGroupSummary>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Visibility
        /// </summary>
        [DataMember(Name = "visibility", IsRequired = true, EmitDefaultValue = true)]
        public FavoriteGroupVisibility Visibility { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FavoriteGroupSummary" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FavoriteGroupSummary() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FavoriteGroupSummary" /> class.
        /// </summary>
        /// <param name="displayName">displayName (required).</param>
        /// <param name="id">id (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="numFavorites">numFavorites (required).</param>
        /// <param name="visibility">visibility (required).</param>
        public FavoriteGroupSummary(string displayName = default, string id = default, string name = default, int numFavorites = default, FavoriteGroupVisibility visibility = default)
        {
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.DisplayName = displayName;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Id = id;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Name = name;
            this.NumFavorites = numFavorites;
            this.Visibility = visibility;
        }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name = "displayName", IsRequired = true, EmitDefaultValue = true)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        /*
        <example>fvgrp_8a02a44b-dc3a-4a9a-bc77-77fa37996fc7</example>
        */
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets NumFavorites
        /// </summary>
        [DataMember(Name = "numFavorites", IsRequired = true, EmitDefaultValue = true)]
        public int NumFavorites { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FavoriteGroupSummary {\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  NumFavorites: ").Append(NumFavorites).Append("\n");
            sb.Append("  Visibility: ").Append(Visibility).Append("\n");
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
            return this.Equals(input as FavoriteGroupSummary);
        }

        /// <summary>
        /// Returns true if FavoriteGroupSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of FavoriteGroupSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FavoriteGroupSummary input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.NumFavorites == input.NumFavorites ||
                    this.NumFavorites.Equals(input.NumFavorites)
                ) && 
                (
                    this.Visibility == input.Visibility ||
                    this.Visibility.Equals(input.Visibility)
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
                if (this.DisplayName != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayName.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.NumFavorites.GetHashCode();
                hashCode = (hashCode * 59) + this.Visibility.GetHashCode();
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
            // DisplayName (string) minLength
            if (this.DisplayName != null && this.DisplayName.Length < 1)
            {
                yield return new ValidationResult("Invalid value for DisplayName, length must be greater than 1.", new [] { "DisplayName" });
            }

            // Name (string) minLength
            if (this.Name != null && this.Name.Length < 1)
            {
                yield return new ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
            }

            // NumFavorites (int) minimum
            if (this.NumFavorites < (int)0)
            {
                yield return new ValidationResult("Invalid value for NumFavorites, must be a value greater than or equal to 0.", new [] { "NumFavorites" });
            }

            yield break;
        }
    }

}
