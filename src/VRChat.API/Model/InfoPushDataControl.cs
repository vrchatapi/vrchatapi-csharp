

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
    /// InfoPushDataControl
    /// </summary>
    [DataContract(Name = "InfoPushDataControl")]
    public partial class InfoPushDataControl : IEquatable<InfoPushDataControl>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InfoPushDataControl" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InfoPushDataControl() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InfoPushDataControl" /> class.
        /// </summary>
        /// <param name="control">control (required).</param>
        /// <param name="display">display (required).</param>
        /// <param name="id">id (required).</param>
        /// <param name="kind">kind (required).</param>
        /// <param name="label">label (required).</param>
        /// <param name="options">options (required).</param>
        /// <param name="selection">selection (required).</param>
        public InfoPushDataControl(string control = default, string display = default, string id = default, string kind = default, LocalizedString label = default, List<InfoPushDataControlOption> options = default, string selection = default)
        {
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Control = control;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Display = display;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Id = id;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Kind = kind;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Label = label;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Options = options;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Selection = selection;
        }

        /// <summary>
        /// Gets or Sets Control
        /// </summary>
        /*
        <example>select</example>
        */
        [DataMember(Name = "control", IsRequired = true, EmitDefaultValue = true)]
        public string Control { get; set; }

        /// <summary>
        /// Gets or Sets Display
        /// </summary>
        /*
        <example>overflow</example>
        */
        [DataMember(Name = "display", IsRequired = true, EmitDefaultValue = true)]
        public string Display { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        /*
        <example>categories</example>
        */
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Kind
        /// </summary>
        /*
        <example>filter</example>
        */
        [DataMember(Name = "kind", IsRequired = true, EmitDefaultValue = true)]
        public string Kind { get; set; }

        /// <summary>
        /// Gets or Sets Label
        /// </summary>
        [DataMember(Name = "label", IsRequired = true, EmitDefaultValue = true)]
        public LocalizedString Label { get; set; }

        /// <summary>
        /// Gets or Sets Options
        /// </summary>
        [DataMember(Name = "options", IsRequired = true, EmitDefaultValue = true)]
        public List<InfoPushDataControlOption> Options { get; set; }

        /// <summary>
        /// Gets or Sets Selection
        /// </summary>
        /*
        <example>multiple</example>
        */
        [DataMember(Name = "selection", IsRequired = true, EmitDefaultValue = true)]
        public string Selection { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InfoPushDataControl {\n");
            sb.Append("  Control: ").Append(Control).Append("\n");
            sb.Append("  Display: ").Append(Display).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Kind: ").Append(Kind).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
            sb.Append("  Selection: ").Append(Selection).Append("\n");
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
            return this.Equals(input as InfoPushDataControl);
        }

        /// <summary>
        /// Returns true if InfoPushDataControl instances are equal
        /// </summary>
        /// <param name="input">Instance of InfoPushDataControl to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InfoPushDataControl input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Control == input.Control ||
                    (this.Control != null &&
                    this.Control.Equals(input.Control))
                ) && 
                (
                    this.Display == input.Display ||
                    (this.Display != null &&
                    this.Display.Equals(input.Display))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Kind == input.Kind ||
                    (this.Kind != null &&
                    this.Kind.Equals(input.Kind))
                ) && 
                (
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
                ) && 
                (
                    this.Options == input.Options ||
                    this.Options != null &&
                    input.Options != null &&
                    this.Options.SequenceEqual(input.Options)
                ) && 
                (
                    this.Selection == input.Selection ||
                    (this.Selection != null &&
                    this.Selection.Equals(input.Selection))
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
                if (this.Control != null)
                {
                    hashCode = (hashCode * 59) + this.Control.GetHashCode();
                }
                if (this.Display != null)
                {
                    hashCode = (hashCode * 59) + this.Display.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Kind != null)
                {
                    hashCode = (hashCode * 59) + this.Kind.GetHashCode();
                }
                if (this.Label != null)
                {
                    hashCode = (hashCode * 59) + this.Label.GetHashCode();
                }
                if (this.Options != null)
                {
                    hashCode = (hashCode * 59) + this.Options.GetHashCode();
                }
                if (this.Selection != null)
                {
                    hashCode = (hashCode * 59) + this.Selection.GetHashCode();
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
