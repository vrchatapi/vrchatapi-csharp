

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
    /// RequiresTwoFactorAuth
    /// </summary>
    [DataContract(Name = "RequiresTwoFactorAuth")]
    public partial class RequiresTwoFactorAuth : IEquatable<RequiresTwoFactorAuth>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RequiresTwoFactorAuth" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RequiresTwoFactorAuth() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RequiresTwoFactorAuth" /> class.
        /// </summary>
        /// <param name="varRequiresTwoFactorAuth">varRequiresTwoFactorAuth (required).</param>
        public RequiresTwoFactorAuth(List<TwoFactorAuthType> varRequiresTwoFactorAuth = default)
        {
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.VarRequiresTwoFactorAuth = varRequiresTwoFactorAuth;
        }

        /// <summary>
        /// Gets or Sets VarRequiresTwoFactorAuth
        /// </summary>
        [DataMember(Name = "requiresTwoFactorAuth", IsRequired = true, EmitDefaultValue = true)]
        public List<TwoFactorAuthType> VarRequiresTwoFactorAuth { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RequiresTwoFactorAuth {\n");
            sb.Append("  VarRequiresTwoFactorAuth: ").Append(VarRequiresTwoFactorAuth).Append("\n");
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
            return this.Equals(input as RequiresTwoFactorAuth);
        }

        /// <summary>
        /// Returns true if RequiresTwoFactorAuth instances are equal
        /// </summary>
        /// <param name="input">Instance of RequiresTwoFactorAuth to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RequiresTwoFactorAuth input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.VarRequiresTwoFactorAuth == input.VarRequiresTwoFactorAuth ||
                    this.VarRequiresTwoFactorAuth != null &&
                    input.VarRequiresTwoFactorAuth != null &&
                    this.VarRequiresTwoFactorAuth.SequenceEqual(input.VarRequiresTwoFactorAuth)
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
                if (this.VarRequiresTwoFactorAuth != null)
                {
                    hashCode = (hashCode * 59) + this.VarRequiresTwoFactorAuth.GetHashCode();
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
