

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
    /// A reason used for reporting users
    /// </summary>
    [DataContract(Name = "ReportReason")]
    public partial class ReportReason : IEquatable<ReportReason>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportReason" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ReportReason() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportReason" /> class.
        /// </summary>
        /// <param name="policy">policy.</param>
        /// <param name="text">The label or name of the report reason (required).</param>
        /// <param name="tooltip">A brief explanation of what this reason entails (required).</param>
        public ReportReason(List<string> policy = default, string text = default, string tooltip = default)
        {
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Text = text;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Tooltip = tooltip;
            this.Policy = policy;
        }

        /// <summary>
        /// Gets or Sets Policy
        /// </summary>
        [DataMember(Name = "policy", EmitDefaultValue = false)]
        public List<string> Policy { get; set; }

        /// <summary>
        /// The label or name of the report reason
        /// </summary>
        /// <value>The label or name of the report reason</value>
        [DataMember(Name = "text", IsRequired = true, EmitDefaultValue = true)]
        public string Text { get; set; }

        /// <summary>
        /// A brief explanation of what this reason entails
        /// </summary>
        /// <value>A brief explanation of what this reason entails</value>
        [DataMember(Name = "tooltip", IsRequired = true, EmitDefaultValue = true)]
        public string Tooltip { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReportReason {\n");
            sb.Append("  Policy: ").Append(Policy).Append("\n");
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
            return this.Equals(input as ReportReason);
        }

        /// <summary>
        /// Returns true if ReportReason instances are equal
        /// </summary>
        /// <param name="input">Instance of ReportReason to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportReason input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Policy == input.Policy ||
                    this.Policy != null &&
                    input.Policy != null &&
                    this.Policy.SequenceEqual(input.Policy)
                ) && 
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
                if (this.Policy != null)
                {
                    hashCode = (hashCode * 59) + this.Policy.GetHashCode();
                }
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
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
