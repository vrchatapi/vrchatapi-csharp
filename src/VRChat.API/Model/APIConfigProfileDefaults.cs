

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
    /// Default profile theme colours, each a hex RGB triplet without a leading &#x60;#&#x60;.
    /// </summary>
    [DataContract(Name = "APIConfigProfileDefaults")]
    public partial class APIConfigProfileDefaults : IEquatable<APIConfigProfileDefaults>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="APIConfigProfileDefaults" /> class.
        /// </summary>
        /// <param name="backgroundGradientBottom">backgroundGradientBottom.</param>
        /// <param name="backgroundGradientTop">backgroundGradientTop.</param>
        /// <param name="themeButtonColor">themeButtonColor.</param>
        /// <param name="themeIconColor">themeIconColor.</param>
        /// <param name="themeSubtextColor">themeSubtextColor.</param>
        public APIConfigProfileDefaults(string backgroundGradientBottom = default, string backgroundGradientTop = default, string themeButtonColor = default, string themeIconColor = default, string themeSubtextColor = default)
        {
            this.BackgroundGradientBottom = backgroundGradientBottom;
            this.BackgroundGradientTop = backgroundGradientTop;
            this.ThemeButtonColor = themeButtonColor;
            this.ThemeIconColor = themeIconColor;
            this.ThemeSubtextColor = themeSubtextColor;
        }

        /// <summary>
        /// Gets or Sets BackgroundGradientBottom
        /// </summary>
        /*
        <example>9933FF</example>
        */
        [DataMember(Name = "backgroundGradientBottom", EmitDefaultValue = false)]
        public string BackgroundGradientBottom { get; set; }

        /// <summary>
        /// Gets or Sets BackgroundGradientTop
        /// </summary>
        /*
        <example>00C48A</example>
        */
        [DataMember(Name = "backgroundGradientTop", EmitDefaultValue = false)]
        public string BackgroundGradientTop { get; set; }

        /// <summary>
        /// Gets or Sets ThemeButtonColor
        /// </summary>
        /*
        <example>009599</example>
        */
        [DataMember(Name = "themeButtonColor", EmitDefaultValue = false)]
        public string ThemeButtonColor { get; set; }

        /// <summary>
        /// Gets or Sets ThemeIconColor
        /// </summary>
        /*
        <example>6BE4FA</example>
        */
        [DataMember(Name = "themeIconColor", EmitDefaultValue = false)]
        public string ThemeIconColor { get; set; }

        /// <summary>
        /// Gets or Sets ThemeSubtextColor
        /// </summary>
        /*
        <example>A9A9A9</example>
        */
        [DataMember(Name = "themeSubtextColor", EmitDefaultValue = false)]
        public string ThemeSubtextColor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class APIConfigProfileDefaults {\n");
            sb.Append("  BackgroundGradientBottom: ").Append(BackgroundGradientBottom).Append("\n");
            sb.Append("  BackgroundGradientTop: ").Append(BackgroundGradientTop).Append("\n");
            sb.Append("  ThemeButtonColor: ").Append(ThemeButtonColor).Append("\n");
            sb.Append("  ThemeIconColor: ").Append(ThemeIconColor).Append("\n");
            sb.Append("  ThemeSubtextColor: ").Append(ThemeSubtextColor).Append("\n");
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
            return this.Equals(input as APIConfigProfileDefaults);
        }

        /// <summary>
        /// Returns true if APIConfigProfileDefaults instances are equal
        /// </summary>
        /// <param name="input">Instance of APIConfigProfileDefaults to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(APIConfigProfileDefaults input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BackgroundGradientBottom == input.BackgroundGradientBottom ||
                    (this.BackgroundGradientBottom != null &&
                    this.BackgroundGradientBottom.Equals(input.BackgroundGradientBottom))
                ) && 
                (
                    this.BackgroundGradientTop == input.BackgroundGradientTop ||
                    (this.BackgroundGradientTop != null &&
                    this.BackgroundGradientTop.Equals(input.BackgroundGradientTop))
                ) && 
                (
                    this.ThemeButtonColor == input.ThemeButtonColor ||
                    (this.ThemeButtonColor != null &&
                    this.ThemeButtonColor.Equals(input.ThemeButtonColor))
                ) && 
                (
                    this.ThemeIconColor == input.ThemeIconColor ||
                    (this.ThemeIconColor != null &&
                    this.ThemeIconColor.Equals(input.ThemeIconColor))
                ) && 
                (
                    this.ThemeSubtextColor == input.ThemeSubtextColor ||
                    (this.ThemeSubtextColor != null &&
                    this.ThemeSubtextColor.Equals(input.ThemeSubtextColor))
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
                if (this.BackgroundGradientBottom != null)
                {
                    hashCode = (hashCode * 59) + this.BackgroundGradientBottom.GetHashCode();
                }
                if (this.BackgroundGradientTop != null)
                {
                    hashCode = (hashCode * 59) + this.BackgroundGradientTop.GetHashCode();
                }
                if (this.ThemeButtonColor != null)
                {
                    hashCode = (hashCode * 59) + this.ThemeButtonColor.GetHashCode();
                }
                if (this.ThemeIconColor != null)
                {
                    hashCode = (hashCode * 59) + this.ThemeIconColor.GetHashCode();
                }
                if (this.ThemeSubtextColor != null)
                {
                    hashCode = (hashCode * 59) + this.ThemeSubtextColor.GetHashCode();
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
