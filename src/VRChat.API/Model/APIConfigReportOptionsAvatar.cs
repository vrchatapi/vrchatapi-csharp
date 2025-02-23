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
    /// APIConfigReportOptionsAvatar
    /// </summary>
    [DataContract(Name = "APIConfig_reportOptions_avatar")]
    public partial class APIConfigReportOptionsAvatar : IEquatable<APIConfigReportOptionsAvatar>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="APIConfigReportOptionsAvatar" /> class.
        /// </summary>
        /// <param name="avatar">avatar.</param>
        /// <param name="warnings">warnings.</param>
        public APIConfigReportOptionsAvatar(List<string> avatar = default(List<string>), List<string> warnings = default(List<string>))
        {
            this.Avatar = avatar;
            this.Warnings = warnings;
        }

        /// <summary>
        /// Gets or Sets Avatar
        /// </summary>
        [DataMember(Name = "avatar", EmitDefaultValue = false)]
        public List<string> Avatar { get; set; }

        /// <summary>
        /// Gets or Sets Warnings
        /// </summary>
        [DataMember(Name = "warnings", EmitDefaultValue = false)]
        public List<string> Warnings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class APIConfigReportOptionsAvatar {\n");
            sb.Append("  Avatar: ").Append(Avatar).Append("\n");
            sb.Append("  Warnings: ").Append(Warnings).Append("\n");
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
            return this.Equals(input as APIConfigReportOptionsAvatar);
        }

        /// <summary>
        /// Returns true if APIConfigReportOptionsAvatar instances are equal
        /// </summary>
        /// <param name="input">Instance of APIConfigReportOptionsAvatar to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(APIConfigReportOptionsAvatar input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Avatar == input.Avatar ||
                    this.Avatar != null &&
                    input.Avatar != null &&
                    this.Avatar.SequenceEqual(input.Avatar)
                ) && 
                (
                    this.Warnings == input.Warnings ||
                    this.Warnings != null &&
                    input.Warnings != null &&
                    this.Warnings.SequenceEqual(input.Warnings)
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
                if (this.Avatar != null)
                {
                    hashCode = (hashCode * 59) + this.Avatar.GetHashCode();
                }
                if (this.Warnings != null)
                {
                    hashCode = (hashCode * 59) + this.Warnings.GetHashCode();
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
