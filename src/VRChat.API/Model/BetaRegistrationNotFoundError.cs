

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
    /// BetaRegistrationNotFoundError
    /// </summary>
    [DataContract(Name = "BetaRegistrationNotFoundError")]
    public partial class BetaRegistrationNotFoundError : IEquatable<BetaRegistrationNotFoundError>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRegistrationNotFoundError" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BetaRegistrationNotFoundError() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRegistrationNotFoundError" /> class.
        /// </summary>
        /// <param name="error">error (required).</param>
        public BetaRegistrationNotFoundError(string error = default)
        {
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Error = error;
        }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        /*
        <example>No registration found</example>
        */
        [DataMember(Name = "error", IsRequired = true, EmitDefaultValue = true)]
        public string Error { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BetaRegistrationNotFoundError {\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
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
            return this.Equals(input as BetaRegistrationNotFoundError);
        }

        /// <summary>
        /// Returns true if BetaRegistrationNotFoundError instances are equal
        /// </summary>
        /// <param name="input">Instance of BetaRegistrationNotFoundError to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BetaRegistrationNotFoundError input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
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
                if (this.Error != null)
                {
                    hashCode = (hashCode * 59) + this.Error.GetHashCode();
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
