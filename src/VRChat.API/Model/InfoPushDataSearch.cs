

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
    /// InfoPushDataSearch
    /// </summary>
    [DataContract(Name = "InfoPushDataSearch")]
    public partial class InfoPushDataSearch : IEquatable<InfoPushDataSearch>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InfoPushDataSearch" /> class.
        /// </summary>
        /// <param name="searchContent">searchContent.</param>
        /// <param name="searchInFields">searchInFields.</param>
        /// <param name="searchQuery">searchQuery.</param>
        /// <param name="searchTags">searchTags.</param>
        /// <param name="sortBy">sortBy.</param>
        public InfoPushDataSearch(string searchContent = default, string searchInFields = default, string searchQuery = default, string searchTags = default, string sortBy = default)
        {
            this.SearchContent = searchContent;
            this.SearchInFields = searchInFields;
            this.SearchQuery = searchQuery;
            this.SearchTags = searchTags;
            this.SortBy = sortBy;
        }

        /// <summary>
        /// Gets or Sets SearchContent
        /// </summary>
        [DataMember(Name = "searchContent", EmitDefaultValue = false)]
        public string SearchContent { get; set; }

        /// <summary>
        /// Gets or Sets SearchInFields
        /// </summary>
        [DataMember(Name = "searchInFields", EmitDefaultValue = false)]
        public string SearchInFields { get; set; }

        /// <summary>
        /// Gets or Sets SearchQuery
        /// </summary>
        [DataMember(Name = "searchQuery", EmitDefaultValue = false)]
        public string SearchQuery { get; set; }

        /// <summary>
        /// Gets or Sets SearchTags
        /// </summary>
        [DataMember(Name = "searchTags", EmitDefaultValue = false)]
        public string SearchTags { get; set; }

        /// <summary>
        /// Gets or Sets SortBy
        /// </summary>
        [DataMember(Name = "sortBy", EmitDefaultValue = false)]
        public string SortBy { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InfoPushDataSearch {\n");
            sb.Append("  SearchContent: ").Append(SearchContent).Append("\n");
            sb.Append("  SearchInFields: ").Append(SearchInFields).Append("\n");
            sb.Append("  SearchQuery: ").Append(SearchQuery).Append("\n");
            sb.Append("  SearchTags: ").Append(SearchTags).Append("\n");
            sb.Append("  SortBy: ").Append(SortBy).Append("\n");
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
            return this.Equals(input as InfoPushDataSearch);
        }

        /// <summary>
        /// Returns true if InfoPushDataSearch instances are equal
        /// </summary>
        /// <param name="input">Instance of InfoPushDataSearch to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InfoPushDataSearch input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SearchContent == input.SearchContent ||
                    (this.SearchContent != null &&
                    this.SearchContent.Equals(input.SearchContent))
                ) && 
                (
                    this.SearchInFields == input.SearchInFields ||
                    (this.SearchInFields != null &&
                    this.SearchInFields.Equals(input.SearchInFields))
                ) && 
                (
                    this.SearchQuery == input.SearchQuery ||
                    (this.SearchQuery != null &&
                    this.SearchQuery.Equals(input.SearchQuery))
                ) && 
                (
                    this.SearchTags == input.SearchTags ||
                    (this.SearchTags != null &&
                    this.SearchTags.Equals(input.SearchTags))
                ) && 
                (
                    this.SortBy == input.SortBy ||
                    (this.SortBy != null &&
                    this.SortBy.Equals(input.SortBy))
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
                if (this.SearchContent != null)
                {
                    hashCode = (hashCode * 59) + this.SearchContent.GetHashCode();
                }
                if (this.SearchInFields != null)
                {
                    hashCode = (hashCode * 59) + this.SearchInFields.GetHashCode();
                }
                if (this.SearchQuery != null)
                {
                    hashCode = (hashCode * 59) + this.SearchQuery.GetHashCode();
                }
                if (this.SearchTags != null)
                {
                    hashCode = (hashCode * 59) + this.SearchTags.GetHashCode();
                }
                if (this.SortBy != null)
                {
                    hashCode = (hashCode * 59) + this.SortBy.GetHashCode();
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
