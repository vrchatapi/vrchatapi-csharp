

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
    /// A short-lived code used to hand the current session to an OAuth redirect.
    /// </summary>
    [DataContract(Name = "OAuthRedirectCode")]
    public partial class OAuthRedirectCode : IEquatable<OAuthRedirectCode>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthRedirectCode" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OAuthRedirectCode() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthRedirectCode" /> class.
        /// </summary>
        /// <param name="code">code (required).</param>
        public OAuthRedirectCode(string code = default)
        {
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Code = code;
        }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        /*
        <example>redirect_00000000-0000-0000-0000-000000000000</example>
        */
        [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = true)]
        public string Code { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OAuthRedirectCode {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
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
            return this.Equals(input as OAuthRedirectCode);
        }

        /// <summary>
        /// Returns true if OAuthRedirectCode instances are equal
        /// </summary>
        /// <param name="input">Instance of OAuthRedirectCode to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OAuthRedirectCode input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
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
                if (this.Code != null)
                {
                    hashCode = (hashCode * 59) + this.Code.GetHashCode();
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
            // Code (string) minLength
            if (this.Code != null && this.Code.Length < 1)
            {
                yield return new ValidationResult("Invalid value for Code, length must be greater than 1.", new [] { "Code" });
            }

            yield break;
        }
    }

}
