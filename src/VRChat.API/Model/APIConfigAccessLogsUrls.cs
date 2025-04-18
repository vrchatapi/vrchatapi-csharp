/*
 * VRChat API Documentation
 *
 *
 * The version of the OpenAPI document: 1.19.2
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
    /// APIConfigAccessLogsUrls
    /// </summary>
    [DataContract(Name = "APIConfig_accessLogsUrls")]
    public partial class APIConfigAccessLogsUrls : IEquatable<APIConfigAccessLogsUrls>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="APIConfigAccessLogsUrls" /> class.
        /// </summary>
        /// <param name="_default">_default.</param>
        /// <param name="pico">pico.</param>
        /// <param name="quest">quest.</param>
        /// <param name="xRElite">xRElite.</param>
        public APIConfigAccessLogsUrls(string _default = default(string), string pico = default(string), string quest = default(string), string xRElite = default(string))
        {
            this.Default = _default;
            this.Pico = pico;
            this.Quest = quest;
            this.XRElite = xRElite;
        }

        /// <summary>
        /// Gets or Sets Default
        /// </summary>
        [DataMember(Name = "Default", EmitDefaultValue = false)]
        public string Default { get; set; }

        /// <summary>
        /// Gets or Sets Pico
        /// </summary>
        [DataMember(Name = "Pico", EmitDefaultValue = false)]
        public string Pico { get; set; }

        /// <summary>
        /// Gets or Sets Quest
        /// </summary>
        [DataMember(Name = "Quest", EmitDefaultValue = false)]
        public string Quest { get; set; }

        /// <summary>
        /// Gets or Sets XRElite
        /// </summary>
        [DataMember(Name = "XRElite", EmitDefaultValue = false)]
        public string XRElite { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class APIConfigAccessLogsUrls {\n");
            sb.Append("  Default: ").Append(Default).Append("\n");
            sb.Append("  Pico: ").Append(Pico).Append("\n");
            sb.Append("  Quest: ").Append(Quest).Append("\n");
            sb.Append("  XRElite: ").Append(XRElite).Append("\n");
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
            return this.Equals(input as APIConfigAccessLogsUrls);
        }

        /// <summary>
        /// Returns true if APIConfigAccessLogsUrls instances are equal
        /// </summary>
        /// <param name="input">Instance of APIConfigAccessLogsUrls to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(APIConfigAccessLogsUrls input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Default == input.Default ||
                    (this.Default != null &&
                    this.Default.Equals(input.Default))
                ) && 
                (
                    this.Pico == input.Pico ||
                    (this.Pico != null &&
                    this.Pico.Equals(input.Pico))
                ) && 
                (
                    this.Quest == input.Quest ||
                    (this.Quest != null &&
                    this.Quest.Equals(input.Quest))
                ) && 
                (
                    this.XRElite == input.XRElite ||
                    (this.XRElite != null &&
                    this.XRElite.Equals(input.XRElite))
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
                if (this.Default != null)
                {
                    hashCode = (hashCode * 59) + this.Default.GetHashCode();
                }
                if (this.Pico != null)
                {
                    hashCode = (hashCode * 59) + this.Pico.GetHashCode();
                }
                if (this.Quest != null)
                {
                    hashCode = (hashCode * 59) + this.Quest.GetHashCode();
                }
                if (this.XRElite != null)
                {
                    hashCode = (hashCode * 59) + this.XRElite.GetHashCode();
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
