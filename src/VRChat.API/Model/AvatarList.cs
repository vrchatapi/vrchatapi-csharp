

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
    /// A page of avatar search results.
    /// </summary>
    [DataContract(Name = "AvatarList")]
    public partial class AvatarList : IEquatable<AvatarList>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AvatarList" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AvatarList() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AvatarList" /> class.
        /// </summary>
        /// <param name="hasNext">hasNext (required).</param>
        /// <param name="results">results (required).</param>
        /// <param name="totalCount">totalCount (required).</param>
        public AvatarList(bool hasNext = default, List<Avatar> results = default, int totalCount = default)
        {
            this.HasNext = hasNext;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Results = results;
            this.TotalCount = totalCount;
        }

        /// <summary>
        /// Gets or Sets HasNext
        /// </summary>
        [DataMember(Name = "hasNext", IsRequired = true, EmitDefaultValue = true)]
        public bool HasNext { get; set; }

        /// <summary>
        /// Gets or Sets Results
        /// </summary>
        [DataMember(Name = "results", IsRequired = true, EmitDefaultValue = true)]
        public List<Avatar> Results { get; set; }

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
            sb.Append("class AvatarList {\n");
            sb.Append("  HasNext: ").Append(HasNext).Append("\n");
            sb.Append("  Results: ").Append(Results).Append("\n");
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
            return this.Equals(input as AvatarList);
        }

        /// <summary>
        /// Returns true if AvatarList instances are equal
        /// </summary>
        /// <param name="input">Instance of AvatarList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AvatarList input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.HasNext == input.HasNext ||
                    this.HasNext.Equals(input.HasNext)
                ) && 
                (
                    this.Results == input.Results ||
                    this.Results != null &&
                    input.Results != null &&
                    this.Results.SequenceEqual(input.Results)
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
                hashCode = (hashCode * 59) + this.HasNext.GetHashCode();
                if (this.Results != null)
                {
                    hashCode = (hashCode * 59) + this.Results.GetHashCode();
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
            // TotalCount (int) minimum
            if (this.TotalCount < (int)0)
            {
                yield return new ValidationResult("Invalid value for TotalCount, must be a value greater than or equal to 0.", new [] { "TotalCount" });
            }

            yield break;
        }
    }

}
