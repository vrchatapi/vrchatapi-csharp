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
    /// TiliaTOS
    /// </summary>
    [DataContract(Name = "TiliaTOS")]
    public partial class TiliaTOS : IEquatable<TiliaTOS>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TiliaTOS" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TiliaTOS() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TiliaTOS" /> class.
        /// </summary>
        /// <param name="signedTos">signedTos (required).</param>
        public TiliaTOS(bool signedTos = default(bool))
        {
            this.SignedTos = signedTos;
        }

        /// <summary>
        /// Gets or Sets SignedTos
        /// </summary>
        [DataMember(Name = "signed_tos", IsRequired = true, EmitDefaultValue = true)]
        public bool SignedTos { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TiliaTOS {\n");
            sb.Append("  SignedTos: ").Append(SignedTos).Append("\n");
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
            return this.Equals(input as TiliaTOS);
        }

        /// <summary>
        /// Returns true if TiliaTOS instances are equal
        /// </summary>
        /// <param name="input">Instance of TiliaTOS to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TiliaTOS input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SignedTos == input.SignedTos ||
                    this.SignedTos.Equals(input.SignedTos)
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
                hashCode = (hashCode * 59) + this.SignedTos.GetHashCode();
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
