/*
 * VRChat API Documentation
 *
 *
 * The version of the OpenAPI document: 1.19.1
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
    /// Constants
    /// </summary>
    [DataContract(Name = "APIConfigConstants")]
    public partial class APIConfigConstants : IEquatable<APIConfigConstants>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="APIConfigConstants" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected APIConfigConstants() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="APIConfigConstants" /> class.
        /// </summary>
        /// <param name="gROUPS">gROUPS (required).</param>
        /// <param name="iNSTANCE">iNSTANCE (required).</param>
        /// <param name="lANGUAGE">lANGUAGE (required).</param>
        public APIConfigConstants(APIConfigConstantsGROUPS gROUPS = default(APIConfigConstantsGROUPS), APIConfigConstantsINSTANCE iNSTANCE = default(APIConfigConstantsINSTANCE), APIConfigConstantsLANGUAGE lANGUAGE = default(APIConfigConstantsLANGUAGE))
        {
            // to ensure "gROUPS" is required (not null)
            if (gROUPS == null)
            {
                throw new ArgumentNullException("gROUPS is a required property for APIConfigConstants and cannot be null");
            }
            this.GROUPS = gROUPS;
            // to ensure "iNSTANCE" is required (not null)
            if (iNSTANCE == null)
            {
                throw new ArgumentNullException("iNSTANCE is a required property for APIConfigConstants and cannot be null");
            }
            this.INSTANCE = iNSTANCE;
            // to ensure "lANGUAGE" is required (not null)
            if (lANGUAGE == null)
            {
                throw new ArgumentNullException("lANGUAGE is a required property for APIConfigConstants and cannot be null");
            }
            this.LANGUAGE = lANGUAGE;
        }

        /// <summary>
        /// Gets or Sets GROUPS
        /// </summary>
        [DataMember(Name = "GROUPS", IsRequired = true, EmitDefaultValue = true)]
        public APIConfigConstantsGROUPS GROUPS { get; set; }

        /// <summary>
        /// Gets or Sets INSTANCE
        /// </summary>
        [DataMember(Name = "INSTANCE", IsRequired = true, EmitDefaultValue = true)]
        public APIConfigConstantsINSTANCE INSTANCE { get; set; }

        /// <summary>
        /// Gets or Sets LANGUAGE
        /// </summary>
        [DataMember(Name = "LANGUAGE", IsRequired = true, EmitDefaultValue = true)]
        public APIConfigConstantsLANGUAGE LANGUAGE { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class APIConfigConstants {\n");
            sb.Append("  GROUPS: ").Append(GROUPS).Append("\n");
            sb.Append("  INSTANCE: ").Append(INSTANCE).Append("\n");
            sb.Append("  LANGUAGE: ").Append(LANGUAGE).Append("\n");
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
            return this.Equals(input as APIConfigConstants);
        }

        /// <summary>
        /// Returns true if APIConfigConstants instances are equal
        /// </summary>
        /// <param name="input">Instance of APIConfigConstants to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(APIConfigConstants input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.GROUPS == input.GROUPS ||
                    (this.GROUPS != null &&
                    this.GROUPS.Equals(input.GROUPS))
                ) && 
                (
                    this.INSTANCE == input.INSTANCE ||
                    (this.INSTANCE != null &&
                    this.INSTANCE.Equals(input.INSTANCE))
                ) && 
                (
                    this.LANGUAGE == input.LANGUAGE ||
                    (this.LANGUAGE != null &&
                    this.LANGUAGE.Equals(input.LANGUAGE))
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
                if (this.GROUPS != null)
                {
                    hashCode = (hashCode * 59) + this.GROUPS.GetHashCode();
                }
                if (this.INSTANCE != null)
                {
                    hashCode = (hashCode * 59) + this.INSTANCE.GetHashCode();
                }
                if (this.LANGUAGE != null)
                {
                    hashCode = (hashCode * 59) + this.LANGUAGE.GetHashCode();
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
            yield break;
        }
    }

}
