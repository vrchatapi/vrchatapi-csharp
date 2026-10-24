

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
    /// DynamicContentRowBase
    /// </summary>
    [DataContract(Name = "DynamicContentRowBase")]
    public partial class DynamicContentRowBase : IEquatable<DynamicContentRowBase>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicContentRowBase" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DynamicContentRowBase() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicContentRowBase" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="platform">Usually \&quot;ThisPlatformSupported\&quot;, but can also be other values such as \&quot;all\&quot; or platform specific identifiers. (required).</param>
        public DynamicContentRowBase(LocalizableString name = default, string platform = default)
        {
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Name = name;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Platform = platform;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public LocalizableString Name { get; set; }

        /// <summary>
        /// Usually \&quot;ThisPlatformSupported\&quot;, but can also be other values such as \&quot;all\&quot; or platform specific identifiers.
        /// </summary>
        /// <value>Usually \&quot;ThisPlatformSupported\&quot;, but can also be other values such as \&quot;all\&quot; or platform specific identifiers.</value>
        [DataMember(Name = "platform", IsRequired = true, EmitDefaultValue = true)]
        public string Platform { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DynamicContentRowBase {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
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
            return this.Equals(input as DynamicContentRowBase);
        }

        /// <summary>
        /// Returns true if DynamicContentRowBase instances are equal
        /// </summary>
        /// <param name="input">Instance of DynamicContentRowBase to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DynamicContentRowBase input)
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
                    this.Platform == input.Platform ||
                    (this.Platform != null &&
                    this.Platform.Equals(input.Platform))
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
                if (this.Platform != null)
                {
                    hashCode = (hashCode * 59) + this.Platform.GetHashCode();
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
            // Platform (string) minLength
            if (this.Platform != null && this.Platform.Length < 1)
            {
                yield return new ValidationResult("Invalid value for Platform, length must be greater than 1.", new [] { "Platform" });
            }

            yield break;
        }
    }

}
