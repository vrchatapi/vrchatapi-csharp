

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
    /// CreateProfileThemeRequest
    /// </summary>
    [DataContract(Name = "CreateProfileThemeRequest")]
    public partial class CreateProfileThemeRequest : IEquatable<CreateProfileThemeRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProfileThemeRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateProfileThemeRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProfileThemeRequest" /> class.
        /// </summary>
        /// <param name="buttonColor">Six hexadecimal digits, without a leading &#x60;#&#x60;. (required).</param>
        /// <param name="iconColor">Six hexadecimal digits, without a leading &#x60;#&#x60;. (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="subtextColor">Six hexadecimal digits, without a leading &#x60;#&#x60;. (required).</param>
        public CreateProfileThemeRequest(string buttonColor = default, string iconColor = default, string name = default, string subtextColor = default)
        {
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.ButtonColor = buttonColor;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.IconColor = iconColor;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Name = name;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.SubtextColor = subtextColor;
        }

        /// <summary>
        /// Six hexadecimal digits, without a leading &#x60;#&#x60;.
        /// </summary>
        /// <value>Six hexadecimal digits, without a leading &#x60;#&#x60;.</value>
        [DataMember(Name = "buttonColor", IsRequired = true, EmitDefaultValue = true)]
        public string ButtonColor { get; set; }

        /// <summary>
        /// Six hexadecimal digits, without a leading &#x60;#&#x60;.
        /// </summary>
        /// <value>Six hexadecimal digits, without a leading &#x60;#&#x60;.</value>
        [DataMember(Name = "iconColor", IsRequired = true, EmitDefaultValue = true)]
        public string IconColor { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Six hexadecimal digits, without a leading &#x60;#&#x60;.
        /// </summary>
        /// <value>Six hexadecimal digits, without a leading &#x60;#&#x60;.</value>
        [DataMember(Name = "subtextColor", IsRequired = true, EmitDefaultValue = true)]
        public string SubtextColor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateProfileThemeRequest {\n");
            sb.Append("  ButtonColor: ").Append(ButtonColor).Append("\n");
            sb.Append("  IconColor: ").Append(IconColor).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SubtextColor: ").Append(SubtextColor).Append("\n");
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
            return this.Equals(input as CreateProfileThemeRequest);
        }

        /// <summary>
        /// Returns true if CreateProfileThemeRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateProfileThemeRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateProfileThemeRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ButtonColor == input.ButtonColor ||
                    (this.ButtonColor != null &&
                    this.ButtonColor.Equals(input.ButtonColor))
                ) && 
                (
                    this.IconColor == input.IconColor ||
                    (this.IconColor != null &&
                    this.IconColor.Equals(input.IconColor))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.SubtextColor == input.SubtextColor ||
                    (this.SubtextColor != null &&
                    this.SubtextColor.Equals(input.SubtextColor))
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
                if (this.ButtonColor != null)
                {
                    hashCode = (hashCode * 59) + this.ButtonColor.GetHashCode();
                }
                if (this.IconColor != null)
                {
                    hashCode = (hashCode * 59) + this.IconColor.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.SubtextColor != null)
                {
                    hashCode = (hashCode * 59) + this.SubtextColor.GetHashCode();
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
            if (this.ButtonColor != null) {
                // ButtonColor (string) pattern
                Regex regexButtonColor = new Regex(@"^[0-9A-Fa-f]{6}$", RegexOptions.CultureInvariant);
                if (!regexButtonColor.Match(this.ButtonColor).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ButtonColor, must match a pattern of " + regexButtonColor, new [] { "ButtonColor" });
                }
            }

            if (this.IconColor != null) {
                // IconColor (string) pattern
                Regex regexIconColor = new Regex(@"^[0-9A-Fa-f]{6}$", RegexOptions.CultureInvariant);
                if (!regexIconColor.Match(this.IconColor).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IconColor, must match a pattern of " + regexIconColor, new [] { "IconColor" });
                }
            }

            // Name (string) maxLength
            if (this.Name != null && this.Name.Length > 12)
            {
                yield return new ValidationResult("Invalid value for Name, length must be less than 12.", new [] { "Name" });
            }

            // Name (string) minLength
            if (this.Name != null && this.Name.Length < 1)
            {
                yield return new ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
            }

            if (this.SubtextColor != null) {
                // SubtextColor (string) pattern
                Regex regexSubtextColor = new Regex(@"^[0-9A-Fa-f]{6}$", RegexOptions.CultureInvariant);
                if (!regexSubtextColor.Match(this.SubtextColor).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SubtextColor, must match a pattern of " + regexSubtextColor, new [] { "SubtextColor" });
                }
            }

            yield break;
        }
    }

}
