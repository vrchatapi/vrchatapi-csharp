

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
    /// InfoPushDataCategoryUnknown
    /// </summary>
    [DataContract(Name = "InfoPushDataCategoryUnknown")]
    public partial class InfoPushDataCategoryUnknown : IEquatable<InfoPushDataCategoryUnknown>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InfoPushDataCategoryUnknown" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InfoPushDataCategoryUnknown() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InfoPushDataCategoryUnknown" /> class.
        /// </summary>
        /// <param name="ids">ids (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="type">type (required).</param>
        public InfoPushDataCategoryUnknown(List<string> ids = default, LocalizableString name = default, string type = default)
        {
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Ids = ids;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Name = name;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Type = type;
        }

        /// <summary>
        /// Gets or Sets Ids
        /// </summary>
        [DataMember(Name = "ids", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Ids { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public LocalizableString Name { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public string Type { get; set; }

        [System.Runtime.Serialization.OnDeserialized]
        internal void OnDeserializedTypeNotEnum(System.Runtime.Serialization.StreamingContext context)
        {
            if (this.Type == "articles" || this.Type == "groups" || this.Type == "worlds")
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
            sb.Append("class InfoPushDataCategoryUnknown {\n");
            sb.Append("  Ids: ").Append(Ids).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as InfoPushDataCategoryUnknown);
        }

        /// <summary>
        /// Returns true if InfoPushDataCategoryUnknown instances are equal
        /// </summary>
        /// <param name="input">Instance of InfoPushDataCategoryUnknown to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InfoPushDataCategoryUnknown input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Ids == input.Ids ||
                    this.Ids != null &&
                    input.Ids != null &&
                    this.Ids.SequenceEqual(input.Ids)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.Ids != null)
                {
                    hashCode = (hashCode * 59) + this.Ids.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
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
