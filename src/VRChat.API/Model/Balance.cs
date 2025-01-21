/*
 * VRChat API Documentation
 *
 *
 * The version of the OpenAPI document: 1.19.0
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
    /// Balance
    /// </summary>
    [DataContract(Name = "Balance")]
    public partial class Balance : IEquatable<Balance>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Balance" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Balance() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Balance" /> class.
        /// </summary>
        /// <param name="balance">balance (required) (default to 0).</param>
        /// <param name="noTransactions">noTransactions.</param>
        /// <param name="tiliaResponse">tiliaResponse.</param>
        public Balance(int balance = 0, bool noTransactions = default(bool), bool tiliaResponse = default(bool))
        {
            this._Balance = balance;
            this.NoTransactions = noTransactions;
            this.TiliaResponse = tiliaResponse;
        }

        /// <summary>
        /// Gets or Sets _Balance
        /// </summary>
        [DataMember(Name = "balance", IsRequired = true, EmitDefaultValue = true)]
        public int _Balance { get; set; }

        /// <summary>
        /// Gets or Sets NoTransactions
        /// </summary>
        [DataMember(Name = "noTransactions", EmitDefaultValue = true)]
        public bool NoTransactions { get; set; }

        /// <summary>
        /// Gets or Sets TiliaResponse
        /// </summary>
        [DataMember(Name = "tiliaResponse", EmitDefaultValue = true)]
        public bool TiliaResponse { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Balance {\n");
            sb.Append("  _Balance: ").Append(_Balance).Append("\n");
            sb.Append("  NoTransactions: ").Append(NoTransactions).Append("\n");
            sb.Append("  TiliaResponse: ").Append(TiliaResponse).Append("\n");
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
            return this.Equals(input as Balance);
        }

        /// <summary>
        /// Returns true if Balance instances are equal
        /// </summary>
        /// <param name="input">Instance of Balance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Balance input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this._Balance == input._Balance ||
                    this._Balance.Equals(input._Balance)
                ) && 
                (
                    this.NoTransactions == input.NoTransactions ||
                    this.NoTransactions.Equals(input.NoTransactions)
                ) && 
                (
                    this.TiliaResponse == input.TiliaResponse ||
                    this.TiliaResponse.Equals(input.TiliaResponse)
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
                hashCode = (hashCode * 59) + this._Balance.GetHashCode();
                hashCode = (hashCode * 59) + this.NoTransactions.GetHashCode();
                hashCode = (hashCode * 59) + this.TiliaResponse.GetHashCode();
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
