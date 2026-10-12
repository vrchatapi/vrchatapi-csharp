

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
    /// FavoriteGroupContentsItemUnknown
    /// </summary>
    [DataContract(Name = "FavoriteGroupContentsItemUnknown")]
    public partial class FavoriteGroupContentsItemUnknown : IEquatable<FavoriteGroupContentsItemUnknown>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FavoriteGroupContentsItemUnknown" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FavoriteGroupContentsItemUnknown() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FavoriteGroupContentsItemUnknown" /> class.
        /// </summary>
        /// <param name="favoriteId">favoriteId (required).</param>
        /// <param name="id">id (required).</param>
        /// <param name="tags">tags (required).</param>
        /// <param name="type">type (required).</param>
        public FavoriteGroupContentsItemUnknown(string favoriteId = default, string id = default, List<string> tags = default, string type = default)
        {
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.FavoriteId = favoriteId;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Id = id;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Tags = tags;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Type = type;
        }

        /// <summary>
        /// Gets or Sets FavoriteId
        /// </summary>
        [DataMember(Name = "favoriteId", IsRequired = true, EmitDefaultValue = true)]
        public string FavoriteId { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name = "tags", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public string Type { get; set; }

        [System.Runtime.Serialization.OnDeserialized]
        internal void OnDeserializedTypeNotEnum(System.Runtime.Serialization.StreamingContext context)
        {
            if (this.Type == "avatar" || this.Type == "friend" || this.Type == "vrcPlusWorld" || this.Type == "world")
            {
                throw new ArgumentException("Invalid value for Type, must not be a value excluded by the 'not' schema.");
            }
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FavoriteGroupContentsItemUnknown {\n");
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
            return this.Equals(input as FavoriteGroupContentsItemUnknown);
        }

        /// <summary>
        /// Returns true if FavoriteGroupContentsItemUnknown instances are equal
        /// </summary>
        /// <param name="input">Instance of FavoriteGroupContentsItemUnknown to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FavoriteGroupContentsItemUnknown input)
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
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
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
