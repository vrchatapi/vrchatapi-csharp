/*
 * VRChat API Documentation
 *
 *
 * The version of the OpenAPI document: 1.19.1
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
    /// APIConfigReportOptionsWorld
    /// </summary>
    [DataContract(Name = "APIConfig_reportOptions_world")]
    public partial class APIConfigReportOptionsWorld : IEquatable<APIConfigReportOptionsWorld>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="APIConfigReportOptionsWorld" /> class.
        /// </summary>
        /// <param name="environment">environment.</param>
        /// <param name="text">text.</param>
        /// <param name="warnings">warnings.</param>
        /// <param name="worldimage">worldimage.</param>
        /// <param name="worldstore">worldstore.</param>
        public APIConfigReportOptionsWorld(List<string> environment = default(List<string>), List<string> text = default(List<string>), List<string> warnings = default(List<string>), List<string> worldimage = default(List<string>), List<string> worldstore = default(List<string>))
        {
            this.Environment = environment;
            this.Text = text;
            this.Warnings = warnings;
            this.Worldimage = worldimage;
            this.Worldstore = worldstore;
        }

        /// <summary>
        /// Gets or Sets Environment
        /// </summary>
        [DataMember(Name = "environment", EmitDefaultValue = false)]
        public List<string> Environment { get; set; }

        /// <summary>
        /// Gets or Sets Text
        /// </summary>
        [DataMember(Name = "text", EmitDefaultValue = false)]
        public List<string> Text { get; set; }

        /// <summary>
        /// Gets or Sets Warnings
        /// </summary>
        [DataMember(Name = "warnings", EmitDefaultValue = false)]
        public List<string> Warnings { get; set; }

        /// <summary>
        /// Gets or Sets Worldimage
        /// </summary>
        [DataMember(Name = "worldimage", EmitDefaultValue = false)]
        public List<string> Worldimage { get; set; }

        /// <summary>
        /// Gets or Sets Worldstore
        /// </summary>
        [DataMember(Name = "worldstore", EmitDefaultValue = false)]
        public List<string> Worldstore { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class APIConfigReportOptionsWorld {\n");
            sb.Append("  Environment: ").Append(Environment).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Warnings: ").Append(Warnings).Append("\n");
            sb.Append("  Worldimage: ").Append(Worldimage).Append("\n");
            sb.Append("  Worldstore: ").Append(Worldstore).Append("\n");
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
            return this.Equals(input as APIConfigReportOptionsWorld);
        }

        /// <summary>
        /// Returns true if APIConfigReportOptionsWorld instances are equal
        /// </summary>
        /// <param name="input">Instance of APIConfigReportOptionsWorld to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(APIConfigReportOptionsWorld input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Environment == input.Environment ||
                    this.Environment != null &&
                    input.Environment != null &&
                    this.Environment.SequenceEqual(input.Environment)
                ) && 
                (
                    this.Text == input.Text ||
                    this.Text != null &&
                    input.Text != null &&
                    this.Text.SequenceEqual(input.Text)
                ) && 
                (
                    this.Warnings == input.Warnings ||
                    this.Warnings != null &&
                    input.Warnings != null &&
                    this.Warnings.SequenceEqual(input.Warnings)
                ) && 
                (
                    this.Worldimage == input.Worldimage ||
                    this.Worldimage != null &&
                    input.Worldimage != null &&
                    this.Worldimage.SequenceEqual(input.Worldimage)
                ) && 
                (
                    this.Worldstore == input.Worldstore ||
                    this.Worldstore != null &&
                    input.Worldstore != null &&
                    this.Worldstore.SequenceEqual(input.Worldstore)
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
                if (this.Environment != null)
                {
                    hashCode = (hashCode * 59) + this.Environment.GetHashCode();
                }
                if (this.Text != null)
                {
                    hashCode = (hashCode * 59) + this.Text.GetHashCode();
                }
                if (this.Warnings != null)
                {
                    hashCode = (hashCode * 59) + this.Warnings.GetHashCode();
                }
                if (this.Worldimage != null)
                {
                    hashCode = (hashCode * 59) + this.Worldimage.GetHashCode();
                }
                if (this.Worldstore != null)
                {
                    hashCode = (hashCode * 59) + this.Worldstore.GetHashCode();
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
