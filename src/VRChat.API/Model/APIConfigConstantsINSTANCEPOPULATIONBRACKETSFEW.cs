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
    /// Few population range
    /// </summary>
    [DataContract(Name = "APIConfigConstants_INSTANCE_POPULATION_BRACKETS_FEW")]
    public partial class APIConfigConstantsINSTANCEPOPULATIONBRACKETSFEW : IEquatable<APIConfigConstantsINSTANCEPOPULATIONBRACKETSFEW>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="APIConfigConstantsINSTANCEPOPULATIONBRACKETSFEW" /> class.
        /// </summary>
        /// <param name="max">Maximum population for a few instance.</param>
        /// <param name="min">Minimum population for a few instance.</param>
        public APIConfigConstantsINSTANCEPOPULATIONBRACKETSFEW(int max = default(int), int min = default(int))
        {
            this.Max = max;
            this.Min = min;
        }

        /// <summary>
        /// Maximum population for a few instance
        /// </summary>
        /// <value>Maximum population for a few instance</value>
        [DataMember(Name = "max", EmitDefaultValue = false)]
        public int Max { get; set; }

        /// <summary>
        /// Minimum population for a few instance
        /// </summary>
        /// <value>Minimum population for a few instance</value>
        [DataMember(Name = "min", EmitDefaultValue = false)]
        public int Min { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class APIConfigConstantsINSTANCEPOPULATIONBRACKETSFEW {\n");
            sb.Append("  Max: ").Append(Max).Append("\n");
            sb.Append("  Min: ").Append(Min).Append("\n");
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
            return this.Equals(input as APIConfigConstantsINSTANCEPOPULATIONBRACKETSFEW);
        }

        /// <summary>
        /// Returns true if APIConfigConstantsINSTANCEPOPULATIONBRACKETSFEW instances are equal
        /// </summary>
        /// <param name="input">Instance of APIConfigConstantsINSTANCEPOPULATIONBRACKETSFEW to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(APIConfigConstantsINSTANCEPOPULATIONBRACKETSFEW input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Max == input.Max ||
                    this.Max.Equals(input.Max)
                ) && 
                (
                    this.Min == input.Min ||
                    this.Min.Equals(input.Min)
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
                hashCode = (hashCode * 59) + this.Max.GetHashCode();
                hashCode = (hashCode * 59) + this.Min.GetHashCode();
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
