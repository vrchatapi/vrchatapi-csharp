

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
    /// InfoPushSearchData
    /// </summary>
    [DataContract(Name = "InfoPushSearchData")]
    public partial class InfoPushSearchData : IEquatable<InfoPushSearchData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InfoPushSearchData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InfoPushSearchData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InfoPushSearchData" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="search">search (required).</param>
        public InfoPushSearchData(LocalizableString name = default, InfoPushDataSearch search = default)
        {
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Name = name;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Search = search;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public LocalizableString Name { get; set; }

        /// <summary>
        /// Gets or Sets Search
        /// </summary>
        [DataMember(Name = "search", IsRequired = true, EmitDefaultValue = true)]
        public InfoPushDataSearch Search { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InfoPushSearchData {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Search: ").Append(Search).Append("\n");
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
            return this.Equals(input as InfoPushSearchData);
        }

        /// <summary>
        /// Returns true if InfoPushSearchData instances are equal
        /// </summary>
        /// <param name="input">Instance of InfoPushSearchData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InfoPushSearchData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Search == input.Search ||
                    (this.Search != null &&
                    this.Search.Equals(input.Search))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Search != null)
                {
                    hashCode = (hashCode * 59) + this.Search.GetHashCode();
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
