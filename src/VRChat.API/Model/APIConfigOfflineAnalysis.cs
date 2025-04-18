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
    /// Whether to allow offline analysis
    /// </summary>
    [DataContract(Name = "APIConfig_offlineAnalysis")]
    public partial class APIConfigOfflineAnalysis : IEquatable<APIConfigOfflineAnalysis>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="APIConfigOfflineAnalysis" /> class.
        /// </summary>
        /// <param name="android">Whether to allow offline analysis (default to true).</param>
        /// <param name="standalonewindows">Whether to allow offline analysis (default to true).</param>
        public APIConfigOfflineAnalysis(bool android = true, bool standalonewindows = true)
        {
            this.Android = android;
            this.Standalonewindows = standalonewindows;
        }

        /// <summary>
        /// Whether to allow offline analysis
        /// </summary>
        /// <value>Whether to allow offline analysis</value>
        [DataMember(Name = "android", EmitDefaultValue = true)]
        public bool Android { get; set; }

        /// <summary>
        /// Whether to allow offline analysis
        /// </summary>
        /// <value>Whether to allow offline analysis</value>
        [DataMember(Name = "standalonewindows", EmitDefaultValue = true)]
        public bool Standalonewindows { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class APIConfigOfflineAnalysis {\n");
            sb.Append("  Android: ").Append(Android).Append("\n");
            sb.Append("  Standalonewindows: ").Append(Standalonewindows).Append("\n");
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
            return this.Equals(input as APIConfigOfflineAnalysis);
        }

        /// <summary>
        /// Returns true if APIConfigOfflineAnalysis instances are equal
        /// </summary>
        /// <param name="input">Instance of APIConfigOfflineAnalysis to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(APIConfigOfflineAnalysis input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Android == input.Android ||
                    this.Android.Equals(input.Android)
                ) && 
                (
                    this.Standalonewindows == input.Standalonewindows ||
                    this.Standalonewindows.Equals(input.Standalonewindows)
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
                hashCode = (hashCode * 59) + this.Android.GetHashCode();
                hashCode = (hashCode * 59) + this.Standalonewindows.GetHashCode();
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
