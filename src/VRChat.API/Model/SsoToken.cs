

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
    /// A token for a third-party service.
    /// </summary>
    [DataContract(Name = "SsoToken")]
    public partial class SsoToken : IEquatable<SsoToken>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SsoToken" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SsoToken() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SsoToken" /> class.
        /// </summary>
        /// <param name="token">token (required).</param>
        public SsoToken(string token = default)
        {
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Token = token;
        }

        /// <summary>
        /// Gets or Sets Token
        /// </summary>
        [DataMember(Name = "token", IsRequired = true, EmitDefaultValue = true)]
        public string Token { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SsoToken {\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
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
            return this.Equals(input as SsoToken);
        }

        /// <summary>
        /// Returns true if SsoToken instances are equal
        /// </summary>
        /// <param name="input">Instance of SsoToken to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SsoToken input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Token == input.Token ||
                    (this.Token != null &&
                    this.Token.Equals(input.Token))
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
                if (this.Token != null)
                {
                    hashCode = (hashCode * 59) + this.Token.GetHashCode();
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
            // Token (string) minLength
            if (this.Token != null && this.Token.Length < 1)
            {
                yield return new ValidationResult("Invalid value for Token, length must be greater than 1.", new [] { "Token" });
            }

            yield break;
        }
    }

}
