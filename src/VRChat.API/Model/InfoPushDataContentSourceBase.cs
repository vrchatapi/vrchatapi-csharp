

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
    /// InfoPushDataContentSourceBase
    /// </summary>
    [DataContract(Name = "InfoPushDataContentSourceBase")]
    public partial class InfoPushDataContentSourceBase : IEquatable<InfoPushDataContentSourceBase>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InfoPushDataContentSourceBase" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InfoPushDataContentSourceBase() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InfoPushDataContentSourceBase" /> class.
        /// </summary>
        /// <param name="computedParams">computedParams (required).</param>
        /// <param name="method">method (required).</param>
        /// <param name="pagination">pagination (required).</param>
        /// <param name="paramModifiability">paramModifiability (required).</param>
        /// <param name="schemaVersion">schemaVersion (required).</param>
        public InfoPushDataContentSourceBase(Dictionary<string, string> computedParams = default, string method = default, InfoPushDataContentSourcePagination pagination = default, Dictionary<string, Object> paramModifiability = default, int schemaVersion = default)
        {
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.ComputedParams = computedParams;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Method = method;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Pagination = pagination;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.ParamModifiability = paramModifiability;
            this.SchemaVersion = schemaVersion;
        }

        /// <summary>
        /// Gets or Sets ComputedParams
        /// </summary>
        [DataMember(Name = "computedParams", IsRequired = true, EmitDefaultValue = true)]
        public Dictionary<string, string> ComputedParams { get; set; }

        /// <summary>
        /// Gets or Sets Method
        /// </summary>
        [DataMember(Name = "method", IsRequired = true, EmitDefaultValue = true)]
        public string Method { get; set; }

        /// <summary>
        /// Gets or Sets Pagination
        /// </summary>
        [DataMember(Name = "pagination", IsRequired = true, EmitDefaultValue = true)]
        public InfoPushDataContentSourcePagination Pagination { get; set; }

        /// <summary>
        /// Gets or Sets ParamModifiability
        /// </summary>
        [DataMember(Name = "paramModifiability", IsRequired = true, EmitDefaultValue = true)]
        public Dictionary<string, Object> ParamModifiability { get; set; }

        /// <summary>
        /// Gets or Sets SchemaVersion
        /// </summary>
        [DataMember(Name = "schemaVersion", IsRequired = true, EmitDefaultValue = true)]
        public int SchemaVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InfoPushDataContentSourceBase {\n");
            sb.Append("  ComputedParams: ").Append(ComputedParams).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  Pagination: ").Append(Pagination).Append("\n");
            sb.Append("  ParamModifiability: ").Append(ParamModifiability).Append("\n");
            sb.Append("  SchemaVersion: ").Append(SchemaVersion).Append("\n");
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
            return this.Equals(input as InfoPushDataContentSourceBase);
        }

        /// <summary>
        /// Returns true if InfoPushDataContentSourceBase instances are equal
        /// </summary>
        /// <param name="input">Instance of InfoPushDataContentSourceBase to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InfoPushDataContentSourceBase input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ComputedParams == input.ComputedParams ||
                    this.ComputedParams != null &&
                    input.ComputedParams != null &&
                    this.ComputedParams.SequenceEqual(input.ComputedParams)
                ) && 
                (
                    this.Method == input.Method ||
                    (this.Method != null &&
                    this.Method.Equals(input.Method))
                ) && 
                (
                    this.Pagination == input.Pagination ||
                    (this.Pagination != null &&
                    this.Pagination.Equals(input.Pagination))
                ) && 
                (
                    this.ParamModifiability == input.ParamModifiability ||
                    this.ParamModifiability != null &&
                    input.ParamModifiability != null &&
                    this.ParamModifiability.SequenceEqual(input.ParamModifiability)
                ) && 
                (
                    this.SchemaVersion == input.SchemaVersion ||
                    this.SchemaVersion.Equals(input.SchemaVersion)
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
                if (this.ComputedParams != null)
                {
                    hashCode = (hashCode * 59) + this.ComputedParams.GetHashCode();
                }
                if (this.Method != null)
                {
                    hashCode = (hashCode * 59) + this.Method.GetHashCode();
                }
                if (this.Pagination != null)
                {
                    hashCode = (hashCode * 59) + this.Pagination.GetHashCode();
                }
                if (this.ParamModifiability != null)
                {
                    hashCode = (hashCode * 59) + this.ParamModifiability.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SchemaVersion.GetHashCode();
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
