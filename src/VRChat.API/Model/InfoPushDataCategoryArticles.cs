

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
    /// InfoPushDataCategoryArticles
    /// </summary>
    [DataContract(Name = "InfoPushDataCategoryArticles")]
    public partial class InfoPushDataCategoryArticles : IEquatable<InfoPushDataCategoryArticles>, IValidatableObject
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Articles for value: articles
            /// </summary>
            [EnumMember(Value = "articles")]
            Articles = 1
        }


        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InfoPushDataCategoryArticles" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InfoPushDataCategoryArticles() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InfoPushDataCategoryArticles" /> class.
        /// </summary>
        /// <param name="ids">ids (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="ipsQuery">ipsQuery (required).</param>
        /// <param name="type">type (required).</param>
        public InfoPushDataCategoryArticles(List<string> ids = default, LocalizableString name = default, InfoPushIpsQuery ipsQuery = default, TypeEnum type = default)
        {
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Ids = ids;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Name = name;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.IpsQuery = ipsQuery;
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
        /// Gets or Sets IpsQuery
        /// </summary>
        [DataMember(Name = "ipsQuery", IsRequired = true, EmitDefaultValue = true)]
        public InfoPushIpsQuery IpsQuery { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InfoPushDataCategoryArticles {\n");
            sb.Append("  Ids: ").Append(Ids).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  IpsQuery: ").Append(IpsQuery).Append("\n");
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
            return this.Equals(input as InfoPushDataCategoryArticles);
        }

        /// <summary>
        /// Returns true if InfoPushDataCategoryArticles instances are equal
        /// </summary>
        /// <param name="input">Instance of InfoPushDataCategoryArticles to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InfoPushDataCategoryArticles input)
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
                    this.IpsQuery == input.IpsQuery ||
                    (this.IpsQuery != null &&
                    this.IpsQuery.Equals(input.IpsQuery))
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
                if (this.Ids != null)
                {
                    hashCode = (hashCode * 59) + this.Ids.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.IpsQuery != null)
                {
                    hashCode = (hashCode * 59) + this.IpsQuery.GetHashCode();
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
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
