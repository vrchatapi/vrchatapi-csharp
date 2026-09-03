

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
    /// APIConfigLoadingScreenWeights
    /// </summary>
    [DataContract(Name = "APIConfigLoadingScreenWeights")]
    public partial class APIConfigLoadingScreenWeights : IEquatable<APIConfigLoadingScreenWeights>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="APIConfigLoadingScreenWeights" /> class.
        /// </summary>
        /// <param name="announcement">announcement.</param>
        /// <param name="informational">informational.</param>
        /// <param name="promotional">promotional.</param>
        public APIConfigLoadingScreenWeights(int announcement = default, int informational = default, int promotional = default)
        {
            this.Announcement = announcement;
            this.Informational = informational;
            this.Promotional = promotional;
        }

        /// <summary>
        /// Gets or Sets Announcement
        /// </summary>
        /*
        <example>1</example>
        */
        [DataMember(Name = "announcement", EmitDefaultValue = false)]
        public int Announcement { get; set; }

        /// <summary>
        /// Gets or Sets Informational
        /// </summary>
        /*
        <example>89</example>
        */
        [DataMember(Name = "informational", EmitDefaultValue = false)]
        public int Informational { get; set; }

        /// <summary>
        /// Gets or Sets Promotional
        /// </summary>
        /*
        <example>10</example>
        */
        [DataMember(Name = "promotional", EmitDefaultValue = false)]
        public int Promotional { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class APIConfigLoadingScreenWeights {\n");
            sb.Append("  Announcement: ").Append(Announcement).Append("\n");
            sb.Append("  Informational: ").Append(Informational).Append("\n");
            sb.Append("  Promotional: ").Append(Promotional).Append("\n");
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
            return this.Equals(input as APIConfigLoadingScreenWeights);
        }

        /// <summary>
        /// Returns true if APIConfigLoadingScreenWeights instances are equal
        /// </summary>
        /// <param name="input">Instance of APIConfigLoadingScreenWeights to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(APIConfigLoadingScreenWeights input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Announcement == input.Announcement ||
                    this.Announcement.Equals(input.Announcement)
                ) && 
                (
                    this.Informational == input.Informational ||
                    this.Informational.Equals(input.Informational)
                ) && 
                (
                    this.Promotional == input.Promotional ||
                    this.Promotional.Equals(input.Promotional)
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
                hashCode = (hashCode * 59) + this.Announcement.GetHashCode();
                hashCode = (hashCode * 59) + this.Informational.GetHashCode();
                hashCode = (hashCode * 59) + this.Promotional.GetHashCode();
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
