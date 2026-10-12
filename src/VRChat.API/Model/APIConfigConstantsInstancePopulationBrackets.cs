

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
    /// APIConfigConstantsInstancePopulationBrackets
    /// </summary>
    [DataContract(Name = "APIConfigConstantsInstancePopulationBrackets")]
    public partial class APIConfigConstantsInstancePopulationBrackets : IEquatable<APIConfigConstantsInstancePopulationBrackets>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="APIConfigConstantsInstancePopulationBrackets" /> class.
        /// </summary>
        /// <param name="cROWDED">Crowded population range.</param>
        /// <param name="fEW">Few population range.</param>
        /// <param name="mANY">Many population range.</param>
        public APIConfigConstantsInstancePopulationBrackets(APIConfigConstantsInstancePopulationBracket cROWDED = default, APIConfigConstantsInstancePopulationBracket fEW = default, APIConfigConstantsInstancePopulationBracket mANY = default)
        {
            this.CROWDED = cROWDED;
            this.FEW = fEW;
            this.MANY = mANY;
        }

        /// <summary>
        /// Crowded population range
        /// </summary>
        /// <value>Crowded population range</value>
        [DataMember(Name = "CROWDED", EmitDefaultValue = false)]
        public APIConfigConstantsInstancePopulationBracket CROWDED { get; set; }

        /// <summary>
        /// Few population range
        /// </summary>
        /// <value>Few population range</value>
        [DataMember(Name = "FEW", EmitDefaultValue = false)]
        public APIConfigConstantsInstancePopulationBracket FEW { get; set; }

        /// <summary>
        /// Many population range
        /// </summary>
        /// <value>Many population range</value>
        [DataMember(Name = "MANY", EmitDefaultValue = false)]
        public APIConfigConstantsInstancePopulationBracket MANY { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class APIConfigConstantsInstancePopulationBrackets {\n");
            sb.Append("  CROWDED: ").Append(CROWDED).Append("\n");
            sb.Append("  FEW: ").Append(FEW).Append("\n");
            sb.Append("  MANY: ").Append(MANY).Append("\n");
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
            return this.Equals(input as APIConfigConstantsInstancePopulationBrackets);
        }

        /// <summary>
        /// Returns true if APIConfigConstantsInstancePopulationBrackets instances are equal
        /// </summary>
        /// <param name="input">Instance of APIConfigConstantsInstancePopulationBrackets to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(APIConfigConstantsInstancePopulationBrackets input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CROWDED == input.CROWDED ||
                    (this.CROWDED != null &&
                    this.CROWDED.Equals(input.CROWDED))
                ) && 
                (
                    this.FEW == input.FEW ||
                    (this.FEW != null &&
                    this.FEW.Equals(input.FEW))
                ) && 
                (
                    this.MANY == input.MANY ||
                    (this.MANY != null &&
                    this.MANY.Equals(input.MANY))
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
                if (this.CROWDED != null)
                {
                    hashCode = (hashCode * 59) + this.CROWDED.GetHashCode();
                }
                if (this.FEW != null)
                {
                    hashCode = (hashCode * 59) + this.FEW.GetHashCode();
                }
                if (this.MANY != null)
                {
                    hashCode = (hashCode * 59) + this.MANY.GetHashCode();
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
