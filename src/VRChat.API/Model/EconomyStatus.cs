

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
    /// Whether the economy is accepting requests.
    /// </summary>
    [DataContract(Name = "EconomyStatus")]
    public partial class EconomyStatus : IEquatable<EconomyStatus>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EconomyStatus" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EconomyStatus() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EconomyStatus" /> class.
        /// </summary>
        /// <param name="economyOnline">economyOnline (required).</param>
        /// <param name="economyState">economyState (required).</param>
        public EconomyStatus(bool economyOnline = default, int economyState = default)
        {
            this.EconomyOnline = economyOnline;
            this.EconomyState = economyState;
        }

        /// <summary>
        /// Gets or Sets EconomyOnline
        /// </summary>
        [DataMember(Name = "economyOnline", IsRequired = true, EmitDefaultValue = true)]
        public bool EconomyOnline { get; set; }

        /// <summary>
        /// Gets or Sets EconomyState
        /// </summary>
        [DataMember(Name = "economyState", IsRequired = true, EmitDefaultValue = true)]
        public int EconomyState { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EconomyStatus {\n");
            sb.Append("  EconomyOnline: ").Append(EconomyOnline).Append("\n");
            sb.Append("  EconomyState: ").Append(EconomyState).Append("\n");
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
            return this.Equals(input as EconomyStatus);
        }

        /// <summary>
        /// Returns true if EconomyStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of EconomyStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EconomyStatus input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.EconomyOnline == input.EconomyOnline ||
                    this.EconomyOnline.Equals(input.EconomyOnline)
                ) && 
                (
                    this.EconomyState == input.EconomyState ||
                    this.EconomyState.Equals(input.EconomyState)
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
                hashCode = (hashCode * 59) + this.EconomyOnline.GetHashCode();
                hashCode = (hashCode * 59) + this.EconomyState.GetHashCode();
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
