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
    /// VerifyAuthTokenResult
    /// </summary>
    [DataContract(Name = "VerifyAuthTokenResult")]
    public partial class VerifyAuthTokenResult : IEquatable<VerifyAuthTokenResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VerifyAuthTokenResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VerifyAuthTokenResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VerifyAuthTokenResult" /> class.
        /// </summary>
        /// <param name="ok">ok (required).</param>
        /// <param name="token">token (required).</param>
        public VerifyAuthTokenResult(bool ok = default(bool), string token = default(string))
        {
            this.Ok = ok;
            // to ensure "token" is required (not null)
            if (token == null)
            {
                throw new ArgumentNullException("token is a required property for VerifyAuthTokenResult and cannot be null");
            }
            this.Token = token;
        }

        /// <summary>
        /// Gets or Sets Ok
        /// </summary>
        [DataMember(Name = "ok", IsRequired = true, EmitDefaultValue = true)]
        public bool Ok { get; set; }

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
            sb.Append("class VerifyAuthTokenResult {\n");
            sb.Append("  Ok: ").Append(Ok).Append("\n");
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
            return this.Equals(input as VerifyAuthTokenResult);
        }

        /// <summary>
        /// Returns true if VerifyAuthTokenResult instances are equal
        /// </summary>
        /// <param name="input">Instance of VerifyAuthTokenResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VerifyAuthTokenResult input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Ok == input.Ok ||
                    this.Ok.Equals(input.Ok)
                ) && 
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
                hashCode = (hashCode * 59) + this.Ok.GetHashCode();
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
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            // Token (string) minLength
            if (this.Token != null && this.Token.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Token, length must be greater than 1.", new [] { "Token" });
            }

            yield break;
        }
    }

}
