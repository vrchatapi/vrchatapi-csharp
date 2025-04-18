/*
 * VRChat API Documentation
 *
 *
 * The version of the OpenAPI document: 1.19.2
 * Contact: vrchatapi.lpv0t@aries.fyi
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


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
using OpenAPIDateConverter = VRChat.API.Client.OpenAPIDateConverter;

namespace VRChat.API.Model
{
    /// <summary>
    /// AvatarStyles
    /// </summary>
    [DataContract(Name = "Avatar_styles")]
    public partial class AvatarStyles : IEquatable<AvatarStyles>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AvatarStyles" /> class.
        /// </summary>
        /// <param name="primary">primary.</param>
        /// <param name="secondary">secondary.</param>
        /// <param name="supplementary">supplementary.</param>
        public AvatarStyles(string primary = default(string), string secondary = default(string), List<string> supplementary = default(List<string>))
        {
            this.Primary = primary;
            this.Secondary = secondary;
            this.Supplementary = supplementary;
        }

        /// <summary>
        /// Gets or Sets Primary
        /// </summary>
        [DataMember(Name = "primary", EmitDefaultValue = true)]
        public string Primary { get; set; }

        /// <summary>
        /// Gets or Sets Secondary
        /// </summary>
        [DataMember(Name = "secondary", EmitDefaultValue = true)]
        public string Secondary { get; set; }

        /// <summary>
        /// Gets or Sets Supplementary
        /// </summary>
        [DataMember(Name = "supplementary", EmitDefaultValue = false)]
        public List<string> Supplementary { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AvatarStyles {\n");
            sb.Append("  Primary: ").Append(Primary).Append("\n");
            sb.Append("  Secondary: ").Append(Secondary).Append("\n");
            sb.Append("  Supplementary: ").Append(Supplementary).Append("\n");
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
            return this.Equals(input as AvatarStyles);
        }

        /// <summary>
        /// Returns true if AvatarStyles instances are equal
        /// </summary>
        /// <param name="input">Instance of AvatarStyles to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AvatarStyles input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Primary == input.Primary ||
                    (this.Primary != null &&
                    this.Primary.Equals(input.Primary))
                ) && 
                (
                    this.Secondary == input.Secondary ||
                    (this.Secondary != null &&
                    this.Secondary.Equals(input.Secondary))
                ) && 
                (
                    this.Supplementary == input.Supplementary ||
                    this.Supplementary != null &&
                    input.Supplementary != null &&
                    this.Supplementary.SequenceEqual(input.Supplementary)
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
                if (this.Primary != null)
                {
                    hashCode = (hashCode * 59) + this.Primary.GetHashCode();
                }
                if (this.Secondary != null)
                {
                    hashCode = (hashCode * 59) + this.Secondary.GetHashCode();
                }
                if (this.Supplementary != null)
                {
                    hashCode = (hashCode * 59) + this.Supplementary.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
