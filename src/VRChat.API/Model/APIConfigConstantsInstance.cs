

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
    /// APIConfigConstantsInstance
    /// </summary>
    [DataContract(Name = "APIConfigConstantsInstance")]
    public partial class APIConfigConstantsInstance : IEquatable<APIConfigConstantsInstance>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="APIConfigConstantsInstance" /> class.
        /// </summary>
        /// <param name="pOPULATIONBRACKETS">Population brackets based on instance population.</param>
        public APIConfigConstantsInstance(APIConfigConstantsInstancePopulationBrackets pOPULATIONBRACKETS = default)
        {
            this.POPULATION_BRACKETS = pOPULATIONBRACKETS;
        }

        /// <summary>
        /// Population brackets based on instance population
        /// </summary>
        /// <value>Population brackets based on instance population</value>
        [DataMember(Name = "POPULATION_BRACKETS", EmitDefaultValue = false)]
        public APIConfigConstantsInstancePopulationBrackets POPULATION_BRACKETS { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class APIConfigConstantsInstance {\n");
            sb.Append("  POPULATION_BRACKETS: ").Append(POPULATION_BRACKETS).Append("\n");
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
            return this.Equals(input as APIConfigConstantsInstance);
        }

        /// <summary>
        /// Returns true if APIConfigConstantsInstance instances are equal
        /// </summary>
        /// <param name="input">Instance of APIConfigConstantsInstance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(APIConfigConstantsInstance input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.POPULATION_BRACKETS == input.POPULATION_BRACKETS ||
                    (this.POPULATION_BRACKETS != null &&
                    this.POPULATION_BRACKETS.Equals(input.POPULATION_BRACKETS))
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
                if (this.POPULATION_BRACKETS != null)
                {
                    hashCode = (hashCode * 59) + this.POPULATION_BRACKETS.GetHashCode();
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
