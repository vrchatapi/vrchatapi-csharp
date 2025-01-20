/*
 * VRChat API Documentation
 *
 *
 * The version of the OpenAPI document: 1.18.9
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
    /// A category used for reporting content
    /// </summary>
    [DataContract(Name = "ReportCategory")]
    public partial class ReportCategory : IEquatable<ReportCategory>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportCategory" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ReportCategory() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportCategory" /> class.
        /// </summary>
        /// <param name="text">The label of the report category (required).</param>
        /// <param name="tooltip">The tooltip that describes the category (required).</param>
        public ReportCategory(string text = default(string), string tooltip = default(string))
        {
            // to ensure "text" is required (not null)
            if (text == null)
            {
                throw new ArgumentNullException("text is a required property for ReportCategory and cannot be null");
            }
            this.Text = text;
            // to ensure "tooltip" is required (not null)
            if (tooltip == null)
            {
                throw new ArgumentNullException("tooltip is a required property for ReportCategory and cannot be null");
            }
            this.Tooltip = tooltip;
        }

        /// <summary>
        /// The label of the report category
        /// </summary>
        /// <value>The label of the report category</value>
        [DataMember(Name = "text", IsRequired = true, EmitDefaultValue = true)]
        public string Text { get; set; }

        /// <summary>
        /// The tooltip that describes the category
        /// </summary>
        /// <value>The tooltip that describes the category</value>
        [DataMember(Name = "tooltip", IsRequired = true, EmitDefaultValue = true)]
        public string Tooltip { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReportCategory {\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Tooltip: ").Append(Tooltip).Append("\n");
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
            return this.Equals(input as ReportCategory);
        }

        /// <summary>
        /// Returns true if ReportCategory instances are equal
        /// </summary>
        /// <param name="input">Instance of ReportCategory to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportCategory input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
                ) && 
                (
                    this.Tooltip == input.Tooltip ||
                    (this.Tooltip != null &&
                    this.Tooltip.Equals(input.Tooltip))
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
                if (this.Text != null)
                {
                    hashCode = (hashCode * 59) + this.Text.GetHashCode();
                }
                if (this.Tooltip != null)
                {
                    hashCode = (hashCode * 59) + this.Tooltip.GetHashCode();
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
