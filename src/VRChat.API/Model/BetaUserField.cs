

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
    /// BetaUserField
    /// </summary>
    [DataContract(Name = "BetaUserField")]
    public partial class BetaUserField : IEquatable<BetaUserField>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BetaUserField" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BetaUserField() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BetaUserField" /> class.
        /// </summary>
        /// <param name="allowedValues">allowedValues.</param>
        /// <param name="excludeFromAnalytics">excludeFromAnalytics.</param>
        /// <param name="required">required (required).</param>
        public BetaUserField(List<string> allowedValues = default, bool excludeFromAnalytics = default, bool required = default)
        {
            this.Required = required;
            this.AllowedValues = allowedValues;
            this.ExcludeFromAnalytics = excludeFromAnalytics;
        }

        /// <summary>
        /// Gets or Sets AllowedValues
        /// </summary>
        [DataMember(Name = "allowedValues", EmitDefaultValue = false)]
        public List<string> AllowedValues { get; set; }

        /// <summary>
        /// Gets or Sets ExcludeFromAnalytics
        /// </summary>
        [DataMember(Name = "excludeFromAnalytics", EmitDefaultValue = true)]
        public bool ExcludeFromAnalytics { get; set; }

        /// <summary>
        /// Gets or Sets Required
        /// </summary>
        [DataMember(Name = "required", IsRequired = true, EmitDefaultValue = true)]
        public bool Required { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BetaUserField {\n");
            sb.Append("  AllowedValues: ").Append(AllowedValues).Append("\n");
            sb.Append("  ExcludeFromAnalytics: ").Append(ExcludeFromAnalytics).Append("\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
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
            return this.Equals(input as BetaUserField);
        }

        /// <summary>
        /// Returns true if BetaUserField instances are equal
        /// </summary>
        /// <param name="input">Instance of BetaUserField to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BetaUserField input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AllowedValues == input.AllowedValues ||
                    this.AllowedValues != null &&
                    input.AllowedValues != null &&
                    this.AllowedValues.SequenceEqual(input.AllowedValues)
                ) && 
                (
                    this.ExcludeFromAnalytics == input.ExcludeFromAnalytics ||
                    this.ExcludeFromAnalytics.Equals(input.ExcludeFromAnalytics)
                ) && 
                (
                    this.Required == input.Required ||
                    this.Required.Equals(input.Required)
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
                if (this.AllowedValues != null)
                {
                    hashCode = (hashCode * 59) + this.AllowedValues.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ExcludeFromAnalytics.GetHashCode();
                hashCode = (hashCode * 59) + this.Required.GetHashCode();
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
