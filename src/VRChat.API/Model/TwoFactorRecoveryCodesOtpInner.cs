/*
 * VRChat API Documentation
 *
 *
 * The version of the OpenAPI document: 1.20.0
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
    /// TwoFactorRecoveryCodesOtpInner
    /// </summary>
    [DataContract(Name = "TwoFactorRecoveryCodes_otp_inner")]
    public partial class TwoFactorRecoveryCodesOtpInner : IEquatable<TwoFactorRecoveryCodesOtpInner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TwoFactorRecoveryCodesOtpInner" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TwoFactorRecoveryCodesOtpInner() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TwoFactorRecoveryCodesOtpInner" /> class.
        /// </summary>
        /// <param name="code">code (required).</param>
        /// <param name="used">used (required).</param>
        public TwoFactorRecoveryCodesOtpInner(string code = default(string), bool used = default(bool))
        {
            // to ensure "code" is required (not null)
            if (code == null)
            {
                throw new ArgumentNullException("code is a required property for TwoFactorRecoveryCodesOtpInner and cannot be null");
            }
            this.Code = code;
            this.Used = used;
        }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = true)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets Used
        /// </summary>
        [DataMember(Name = "used", IsRequired = true, EmitDefaultValue = true)]
        public bool Used { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TwoFactorRecoveryCodesOtpInner {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Used: ").Append(Used).Append("\n");
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
            return this.Equals(input as TwoFactorRecoveryCodesOtpInner);
        }

        /// <summary>
        /// Returns true if TwoFactorRecoveryCodesOtpInner instances are equal
        /// </summary>
        /// <param name="input">Instance of TwoFactorRecoveryCodesOtpInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TwoFactorRecoveryCodesOtpInner input)
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
                ) && 
                (
                    this.Used == input.Used ||
                    this.Used.Equals(input.Used)
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
                hashCode = (hashCode * 59) + this.Used.GetHashCode();
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
