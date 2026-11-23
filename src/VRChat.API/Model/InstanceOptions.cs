

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
    /// The categories an instance can be listed under and the vibes it can be tagged with.
    /// </summary>
    [DataContract(Name = "InstanceOptions")]
    public partial class InstanceOptions : IEquatable<InstanceOptions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InstanceOptions" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InstanceOptions() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InstanceOptions" /> class.
        /// </summary>
        /// <param name="categories">categories (required).</param>
        /// <param name="vibes">vibes (required).</param>
        public InstanceOptions(List<InstanceCategory> categories = default, List<InstanceVibe> vibes = default)
        {
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Categories = categories;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Vibes = vibes;
        }

        /// <summary>
        /// Gets or Sets Categories
        /// </summary>
        [DataMember(Name = "categories", IsRequired = true, EmitDefaultValue = true)]
        public List<InstanceCategory> Categories { get; set; }

        /// <summary>
        /// Gets or Sets Vibes
        /// </summary>
        [DataMember(Name = "vibes", IsRequired = true, EmitDefaultValue = true)]
        public List<InstanceVibe> Vibes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InstanceOptions {\n");
            sb.Append("  Categories: ").Append(Categories).Append("\n");
            sb.Append("  Vibes: ").Append(Vibes).Append("\n");
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
            return this.Equals(input as InstanceOptions);
        }

        /// <summary>
        /// Returns true if InstanceOptions instances are equal
        /// </summary>
        /// <param name="input">Instance of InstanceOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InstanceOptions input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Categories == input.Categories ||
                    this.Categories != null &&
                    input.Categories != null &&
                    this.Categories.SequenceEqual(input.Categories)
                ) && 
                (
                    this.Vibes == input.Vibes ||
                    this.Vibes != null &&
                    input.Vibes != null &&
                    this.Vibes.SequenceEqual(input.Vibes)
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
                if (this.Categories != null)
                {
                    hashCode = (hashCode * 59) + this.Categories.GetHashCode();
                }
                if (this.Vibes != null)
                {
                    hashCode = (hashCode * 59) + this.Vibes.GetHashCode();
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
