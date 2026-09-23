

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
    /// A string the client resolves through its localization table, falling back to &#x60;fallback&#x60; when the key is unknown.
    /// </summary>
    [DataContract(Name = "LocalizedString")]
    public partial class LocalizedString : IEquatable<LocalizedString>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LocalizedString" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LocalizedString() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LocalizedString" /> class.
        /// </summary>
        /// <param name="fallback">The text to show when &#x60;key&#x60; cannot be resolved. (required).</param>
        /// <param name="key">The localization key. (required).</param>
        public LocalizedString(string fallback = default, string key = default)
        {
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Fallback = fallback;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Key = key;
        }

        /// <summary>
        /// The text to show when &#x60;key&#x60; cannot be resolved.
        /// </summary>
        /// <value>The text to show when &#x60;key&#x60; cannot be resolved.</value>
        /*
        <example>carnival</example>
        */
        [DataMember(Name = "fallback", IsRequired = true, EmitDefaultValue = true)]
        public string Fallback { get; set; }

        /// <summary>
        /// The localization key.
        /// </summary>
        /// <value>The localization key.</value>
        /*
        <example>SuggestedSearch/Carnival/Name/carnival</example>
        */
        [DataMember(Name = "key", IsRequired = true, EmitDefaultValue = true)]
        public string Key { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LocalizedString {\n");
            sb.Append("  Fallback: ").Append(Fallback).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
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
            return this.Equals(input as LocalizedString);
        }

        /// <summary>
        /// Returns true if LocalizedString instances are equal
        /// </summary>
        /// <param name="input">Instance of LocalizedString to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LocalizedString input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Fallback == input.Fallback ||
                    (this.Fallback != null &&
                    this.Fallback.Equals(input.Fallback))
                ) && 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
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
                if (this.Fallback != null)
                {
                    hashCode = (hashCode * 59) + this.Fallback.GetHashCode();
                }
                if (this.Key != null)
                {
                    hashCode = (hashCode * 59) + this.Key.GetHashCode();
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
