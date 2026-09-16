

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
    /// Returned only when &#x60;getLimits&#x60; is set.
    /// </summary>
    [DataContract(Name = "EconomyAccountLimits")]
    public partial class EconomyAccountLimits : IEquatable<EconomyAccountLimits>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EconomyAccountLimits" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EconomyAccountLimits() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EconomyAccountLimits" /> class.
        /// </summary>
        /// <param name="buyingTokenMaxPerDay">buyingTokenMaxPerDay (required).</param>
        /// <param name="buyingTokenRemainingAllowed">buyingTokenRemainingAllowed (required).</param>
        public EconomyAccountLimits(int buyingTokenMaxPerDay = default, int buyingTokenRemainingAllowed = default)
        {
            this.BuyingTokenMaxPerDay = buyingTokenMaxPerDay;
            this.BuyingTokenRemainingAllowed = buyingTokenRemainingAllowed;
        }

        /// <summary>
        /// Gets or Sets BuyingTokenMaxPerDay
        /// </summary>
        [DataMember(Name = "buyingTokenMaxPerDay", IsRequired = true, EmitDefaultValue = true)]
        public int BuyingTokenMaxPerDay { get; set; }

        /// <summary>
        /// Gets or Sets BuyingTokenRemainingAllowed
        /// </summary>
        [DataMember(Name = "buyingTokenRemainingAllowed", IsRequired = true, EmitDefaultValue = true)]
        public int BuyingTokenRemainingAllowed { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EconomyAccountLimits {\n");
            sb.Append("  BuyingTokenMaxPerDay: ").Append(BuyingTokenMaxPerDay).Append("\n");
            sb.Append("  BuyingTokenRemainingAllowed: ").Append(BuyingTokenRemainingAllowed).Append("\n");
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
            return this.Equals(input as EconomyAccountLimits);
        }

        /// <summary>
        /// Returns true if EconomyAccountLimits instances are equal
        /// </summary>
        /// <param name="input">Instance of EconomyAccountLimits to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EconomyAccountLimits input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BuyingTokenMaxPerDay == input.BuyingTokenMaxPerDay ||
                    this.BuyingTokenMaxPerDay.Equals(input.BuyingTokenMaxPerDay)
                ) && 
                (
                    this.BuyingTokenRemainingAllowed == input.BuyingTokenRemainingAllowed ||
                    this.BuyingTokenRemainingAllowed.Equals(input.BuyingTokenRemainingAllowed)
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
                hashCode = (hashCode * 59) + this.BuyingTokenMaxPerDay.GetHashCode();
                hashCode = (hashCode * 59) + this.BuyingTokenRemainingAllowed.GetHashCode();
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
            // BuyingTokenMaxPerDay (int) minimum
            if (this.BuyingTokenMaxPerDay < (int)0)
            {
                yield return new ValidationResult("Invalid value for BuyingTokenMaxPerDay, must be a value greater than or equal to 0.", new [] { "BuyingTokenMaxPerDay" });
            }

            // BuyingTokenRemainingAllowed (int) minimum
            if (this.BuyingTokenRemainingAllowed < (int)0)
            {
                yield return new ValidationResult("Invalid value for BuyingTokenRemainingAllowed, must be a value greater than or equal to 0.", new [] { "BuyingTokenRemainingAllowed" });
            }

            yield break;
        }
    }

}
