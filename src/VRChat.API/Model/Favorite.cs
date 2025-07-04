/*
 * VRChat API Documentation
 *
 *
 * The version of the OpenAPI document: 1.20.0
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
    /// Favorite
    /// </summary>
    [DataContract(Name = "Favorite")]
    public partial class Favorite : IEquatable<Favorite>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public FavoriteType Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Favorite" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Favorite() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Favorite" /> class.
        /// </summary>
        /// <param name="favoriteId">MUST be either AvatarID, UserID or WorldID. (required).</param>
        /// <param name="id">id (required).</param>
        /// <param name="tags">  (required).</param>
        /// <param name="type">type (required).</param>
        public Favorite(string favoriteId = default(string), string id = default(string), List<string> tags = default(List<string>), FavoriteType type = default(FavoriteType))
        {
            // to ensure "favoriteId" is required (not null)
            if (favoriteId == null)
            {
                throw new ArgumentNullException("favoriteId is a required property for Favorite and cannot be null");
            }
            this.FavoriteId = favoriteId;
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for Favorite and cannot be null");
            }
            this.Id = id;
            // to ensure "tags" is required (not null)
            if (tags == null)
            {
                throw new ArgumentNullException("tags is a required property for Favorite and cannot be null");
            }
            this.Tags = tags;
            this.Type = type;
        }

        /// <summary>
        /// MUST be either AvatarID, UserID or WorldID.
        /// </summary>
        /// <value>MUST be either AvatarID, UserID or WorldID.</value>
        [DataMember(Name = "favoriteId", IsRequired = true, EmitDefaultValue = true)]
        public string FavoriteId { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        ///  
        /// </summary>
        /// <value> </value>
        [DataMember(Name = "tags", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Favorite {\n");
            sb.Append("  FavoriteId: ").Append(FavoriteId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as Favorite);
        }

        /// <summary>
        /// Returns true if Favorite instances are equal
        /// </summary>
        /// <param name="input">Instance of Favorite to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Favorite input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.FavoriteId == input.FavoriteId ||
                    (this.FavoriteId != null &&
                    this.FavoriteId.Equals(input.FavoriteId))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
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
                if (this.FavoriteId != null)
                {
                    hashCode = (hashCode * 59) + this.FavoriteId.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Tags != null)
                {
                    hashCode = (hashCode * 59) + this.Tags.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
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
