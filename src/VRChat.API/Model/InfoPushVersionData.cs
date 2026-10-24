

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
    /// InfoPushVersionData
    /// </summary>
    [DataContract(Name = "InfoPushVersionData")]
    public partial class InfoPushVersionData : IEquatable<InfoPushVersionData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InfoPushVersionData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InfoPushVersionData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InfoPushVersionData" /> class.
        /// </summary>
        /// <param name="varVersion">varVersion (required).</param>
        public InfoPushVersionData(string varVersion = default)
        {
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.VarVersion = varVersion;
        }

        /// <summary>
        /// Gets or Sets VarVersion
        /// </summary>
        [DataMember(Name = "version", IsRequired = true, EmitDefaultValue = true)]
        public string VarVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InfoPushVersionData {\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
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
            return this.Equals(input as InfoPushVersionData);
        }

        /// <summary>
        /// Returns true if InfoPushVersionData instances are equal
        /// </summary>
        /// <param name="input">Instance of InfoPushVersionData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InfoPushVersionData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.VarVersion == input.VarVersion ||
                    (this.VarVersion != null &&
                    this.VarVersion.Equals(input.VarVersion))
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
                if (this.VarVersion != null)
                {
                    hashCode = (hashCode * 59) + this.VarVersion.GetHashCode();
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
            // VarVersion (string) minLength
            if (this.VarVersion != null && this.VarVersion.Length < 1)
            {
                yield return new ValidationResult("Invalid value for VarVersion, length must be greater than 1.", new [] { "VarVersion" });
            }

            yield break;
        }
    }

}
