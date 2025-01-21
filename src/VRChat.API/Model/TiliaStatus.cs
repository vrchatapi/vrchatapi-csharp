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
    /// TiliaStatus
    /// </summary>
    [DataContract(Name = "TiliaStatus")]
    public partial class TiliaStatus : IEquatable<TiliaStatus>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TiliaStatus" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TiliaStatus() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TiliaStatus" /> class.
        /// </summary>
        /// <param name="economyOnline">economyOnline (required).</param>
        public TiliaStatus(bool economyOnline = default(bool))
        {
            this.EconomyOnline = economyOnline;
        }

        /// <summary>
        /// Gets or Sets EconomyOnline
        /// </summary>
        [DataMember(Name = "economyOnline", IsRequired = true, EmitDefaultValue = true)]
        public bool EconomyOnline { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TiliaStatus {\n");
            sb.Append("  EconomyOnline: ").Append(EconomyOnline).Append("\n");
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
            return this.Equals(input as TiliaStatus);
        }

        /// <summary>
        /// Returns true if TiliaStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of TiliaStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TiliaStatus input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.EconomyOnline == input.EconomyOnline ||
                    this.EconomyOnline.Equals(input.EconomyOnline)
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
