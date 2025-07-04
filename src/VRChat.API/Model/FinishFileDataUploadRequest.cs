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
    /// FinishFileDataUploadRequest
    /// </summary>
    [DataContract(Name = "FinishFileDataUploadRequest")]
    public partial class FinishFileDataUploadRequest : IEquatable<FinishFileDataUploadRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FinishFileDataUploadRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FinishFileDataUploadRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FinishFileDataUploadRequest" /> class.
        /// </summary>
        /// <param name="etags">Array of ETags uploaded..</param>
        /// <param name="nextPartNumber">Always a zero in string form, despite how many parts uploaded. (required) (default to &quot;0&quot;).</param>
        /// <param name="maxParts">Always a zero in string form, despite how many parts uploaded. (required) (default to &quot;0&quot;).</param>
        public FinishFileDataUploadRequest(List<string> etags = default(List<string>), string nextPartNumber = "0", string maxParts = "0")
        {
            // to ensure "nextPartNumber" is required (not null)
            if (nextPartNumber == null)
            {
                throw new ArgumentNullException("nextPartNumber is a required property for FinishFileDataUploadRequest and cannot be null");
            }
            this.NextPartNumber = nextPartNumber;
            // to ensure "maxParts" is required (not null)
            if (maxParts == null)
            {
                throw new ArgumentNullException("maxParts is a required property for FinishFileDataUploadRequest and cannot be null");
            }
            this.MaxParts = maxParts;
            this.Etags = etags;
        }

        /// <summary>
        /// Array of ETags uploaded.
        /// </summary>
        /// <value>Array of ETags uploaded.</value>
        [DataMember(Name = "etags", EmitDefaultValue = false)]
        public List<string> Etags { get; set; }

        /// <summary>
        /// Always a zero in string form, despite how many parts uploaded.
        /// </summary>
        /// <value>Always a zero in string form, despite how many parts uploaded.</value>
        [DataMember(Name = "nextPartNumber", IsRequired = true, EmitDefaultValue = true)]
        [Obsolete]
        public string NextPartNumber { get; set; }

        /// <summary>
        /// Always a zero in string form, despite how many parts uploaded.
        /// </summary>
        /// <value>Always a zero in string form, despite how many parts uploaded.</value>
        [DataMember(Name = "maxParts", IsRequired = true, EmitDefaultValue = true)]
        [Obsolete]
        public string MaxParts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FinishFileDataUploadRequest {\n");
            sb.Append("  Etags: ").Append(Etags).Append("\n");
            sb.Append("  NextPartNumber: ").Append(NextPartNumber).Append("\n");
            sb.Append("  MaxParts: ").Append(MaxParts).Append("\n");
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
            return this.Equals(input as FinishFileDataUploadRequest);
        }

        /// <summary>
        /// Returns true if FinishFileDataUploadRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of FinishFileDataUploadRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FinishFileDataUploadRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Etags == input.Etags ||
                    this.Etags != null &&
                    input.Etags != null &&
                    this.Etags.SequenceEqual(input.Etags)
                ) && 
                (
                    this.NextPartNumber == input.NextPartNumber ||
                    (this.NextPartNumber != null &&
                    this.NextPartNumber.Equals(input.NextPartNumber))
                ) && 
                (
                    this.MaxParts == input.MaxParts ||
                    (this.MaxParts != null &&
                    this.MaxParts.Equals(input.MaxParts))
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
                if (this.Etags != null)
                {
                    hashCode = (hashCode * 59) + this.Etags.GetHashCode();
                }
                if (this.NextPartNumber != null)
                {
                    hashCode = (hashCode * 59) + this.NextPartNumber.GetHashCode();
                }
                if (this.MaxParts != null)
                {
                    hashCode = (hashCode * 59) + this.MaxParts.GetHashCode();
                }
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
            // NextPartNumber (string) maxLength
            if (this.NextPartNumber != null && this.NextPartNumber.Length > 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for NextPartNumber, length must be less than 1.", new [] { "NextPartNumber" });
            }

            // NextPartNumber (string) minLength
            if (this.NextPartNumber != null && this.NextPartNumber.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for NextPartNumber, length must be greater than 1.", new [] { "NextPartNumber" });
            }

            // MaxParts (string) maxLength
            if (this.MaxParts != null && this.MaxParts.Length > 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MaxParts, length must be less than 1.", new [] { "MaxParts" });
            }

            // MaxParts (string) minLength
            if (this.MaxParts != null && this.MaxParts.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MaxParts, length must be greater than 1.", new [] { "MaxParts" });
            }

            yield break;
        }
    }

}
