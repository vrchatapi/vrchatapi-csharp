

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
    /// AccountStanding
    /// </summary>
    [DataContract(Name = "AccountStanding")]
    public partial class AccountStanding : IEquatable<AccountStanding>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountStanding" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AccountStanding() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountStanding" /> class.
        /// </summary>
        /// <param name="issueClearDays">issueClearDays (required).</param>
        /// <param name="sanctions">sanctions (required).</param>
        /// <param name="standing">standing (required).</param>
        public AccountStanding(int issueClearDays = default, List<Object> sanctions = default, string standing = default)
        {
            this.IssueClearDays = issueClearDays;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Sanctions = sanctions;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Standing = standing;
        }

        /// <summary>
        /// Gets or Sets IssueClearDays
        /// </summary>
        [DataMember(Name = "issueClearDays", IsRequired = true, EmitDefaultValue = true)]
        public int IssueClearDays { get; set; }

        /// <summary>
        /// Gets or Sets Sanctions
        /// </summary>
        [DataMember(Name = "sanctions", IsRequired = true, EmitDefaultValue = true)]
        public List<Object> Sanctions { get; set; }

        /// <summary>
        /// Gets or Sets Standing
        /// </summary>
        [DataMember(Name = "standing", IsRequired = true, EmitDefaultValue = true)]
        public string Standing { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AccountStanding {\n");
            sb.Append("  IssueClearDays: ").Append(IssueClearDays).Append("\n");
            sb.Append("  Sanctions: ").Append(Sanctions).Append("\n");
            sb.Append("  Standing: ").Append(Standing).Append("\n");
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
            return this.Equals(input as AccountStanding);
        }

        /// <summary>
        /// Returns true if AccountStanding instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountStanding to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountStanding input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.IssueClearDays == input.IssueClearDays ||
                    this.IssueClearDays.Equals(input.IssueClearDays)
                ) && 
                (
                    this.Sanctions == input.Sanctions ||
                    this.Sanctions != null &&
                    input.Sanctions != null &&
                    this.Sanctions.SequenceEqual(input.Sanctions)
                ) && 
                (
                    this.Standing == input.Standing ||
                    (this.Standing != null &&
                    this.Standing.Equals(input.Standing))
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
                hashCode = (hashCode * 59) + this.IssueClearDays.GetHashCode();
                if (this.Sanctions != null)
                {
                    hashCode = (hashCode * 59) + this.Sanctions.GetHashCode();
                }
                if (this.Standing != null)
                {
                    hashCode = (hashCode * 59) + this.Standing.GetHashCode();
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
