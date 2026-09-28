

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
    /// InfoPushDataContentSource
    /// </summary>
    [DataContract(Name = "InfoPushDataContentSource")]
    public partial class InfoPushDataContentSource : IEquatable<InfoPushDataContentSource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InfoPushDataContentSource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InfoPushDataContentSource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InfoPushDataContentSource" /> class.
        /// </summary>
        /// <param name="attributionResponseField">attributionResponseField.</param>
        /// <param name="computedParams">computedParams (required).</param>
        /// <param name="endpoint">endpoint (required).</param>
        /// <param name="kind">kind (required).</param>
        /// <param name="method">method (required).</param>
        /// <param name="pagination">pagination (required).</param>
        /// <param name="paramModifiability">paramModifiability (required).</param>
        /// <param name="varParams">varParams (required).</param>
        /// <param name="responseType">responseType (required).</param>
        /// <param name="resultsField">resultsField (required).</param>
        /// <param name="schemaVersion">schemaVersion (required).</param>
        public InfoPushDataContentSource(string attributionResponseField = default, Dictionary<string, string> computedParams = default, string endpoint = default, string kind = default, string method = default, InfoPushDataContentSourcePagination pagination = default, Dictionary<string, Object> paramModifiability = default, Dictionary<string, Object> varParams = default, string responseType = default, string resultsField = default, int schemaVersion = default)
        {
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.ComputedParams = computedParams;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Endpoint = endpoint;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Kind = kind;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Method = method;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Pagination = pagination;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.ParamModifiability = paramModifiability;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Params = varParams;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.ResponseType = responseType;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.ResultsField = resultsField;
            this.SchemaVersion = schemaVersion;
            this.AttributionResponseField = attributionResponseField;
        }

        /// <summary>
        /// Gets or Sets AttributionResponseField
        /// </summary>
        /*
        <example>attributionId</example>
        */
        [DataMember(Name = "attributionResponseField", EmitDefaultValue = false)]
        public string AttributionResponseField { get; set; }

        /// <summary>
        /// Gets or Sets ComputedParams
        /// </summary>
        [DataMember(Name = "computedParams", IsRequired = true, EmitDefaultValue = true)]
        public Dictionary<string, string> ComputedParams { get; set; }

        /// <summary>
        /// Gets or Sets Endpoint
        /// </summary>
        /*
        <example>/api/1/instances/discover</example>
        */
        [DataMember(Name = "endpoint", IsRequired = true, EmitDefaultValue = true)]
        public string Endpoint { get; set; }

        /// <summary>
        /// Gets or Sets Kind
        /// </summary>
        /*
        <example>instanceDiscover</example>
        */
        [DataMember(Name = "kind", IsRequired = true, EmitDefaultValue = true)]
        public string Kind { get; set; }

        /// <summary>
        /// Gets or Sets Method
        /// </summary>
        /*
        <example>GET</example>
        */
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
        /// Gets or Sets Params
        /// </summary>
        [DataMember(Name = "params", IsRequired = true, EmitDefaultValue = true)]
        public Dictionary<string, Object> Params { get; set; }

        /// <summary>
        /// Gets or Sets ResponseType
        /// </summary>
        /*
        <example>instance</example>
        */
        [DataMember(Name = "responseType", IsRequired = true, EmitDefaultValue = true)]
        public string ResponseType { get; set; }

        /// <summary>
        /// Gets or Sets ResultsField
        /// </summary>
        /*
        <example>instances</example>
        */
        [DataMember(Name = "resultsField", IsRequired = true, EmitDefaultValue = true)]
        public string ResultsField { get; set; }

        /// <summary>
        /// Gets or Sets SchemaVersion
        /// </summary>
        /*
        <example>1</example>
        */
        [DataMember(Name = "schemaVersion", IsRequired = true, EmitDefaultValue = true)]
        public int SchemaVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InfoPushDataContentSource {\n");
            sb.Append("  AttributionResponseField: ").Append(AttributionResponseField).Append("\n");
            sb.Append("  ComputedParams: ").Append(ComputedParams).Append("\n");
            sb.Append("  Endpoint: ").Append(Endpoint).Append("\n");
            sb.Append("  Kind: ").Append(Kind).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  Pagination: ").Append(Pagination).Append("\n");
            sb.Append("  ParamModifiability: ").Append(ParamModifiability).Append("\n");
            sb.Append("  Params: ").Append(Params).Append("\n");
            sb.Append("  ResponseType: ").Append(ResponseType).Append("\n");
            sb.Append("  ResultsField: ").Append(ResultsField).Append("\n");
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
            return this.Equals(input as InfoPushDataContentSource);
        }

        /// <summary>
        /// Returns true if InfoPushDataContentSource instances are equal
        /// </summary>
        /// <param name="input">Instance of InfoPushDataContentSource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InfoPushDataContentSource input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AttributionResponseField == input.AttributionResponseField ||
                    (this.AttributionResponseField != null &&
                    this.AttributionResponseField.Equals(input.AttributionResponseField))
                ) && 
                (
                    this.ComputedParams == input.ComputedParams ||
                    this.ComputedParams != null &&
                    input.ComputedParams != null &&
                    this.ComputedParams.SequenceEqual(input.ComputedParams)
                ) && 
                (
                    this.Endpoint == input.Endpoint ||
                    (this.Endpoint != null &&
                    this.Endpoint.Equals(input.Endpoint))
                ) && 
                (
                    this.Kind == input.Kind ||
                    (this.Kind != null &&
                    this.Kind.Equals(input.Kind))
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
                    this.Params == input.Params ||
                    this.Params != null &&
                    input.Params != null &&
                    this.Params.SequenceEqual(input.Params)
                ) && 
                (
                    this.ResponseType == input.ResponseType ||
                    (this.ResponseType != null &&
                    this.ResponseType.Equals(input.ResponseType))
                ) && 
                (
                    this.ResultsField == input.ResultsField ||
                    (this.ResultsField != null &&
                    this.ResultsField.Equals(input.ResultsField))
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
                if (this.AttributionResponseField != null)
                {
                    hashCode = (hashCode * 59) + this.AttributionResponseField.GetHashCode();
                }
                if (this.ComputedParams != null)
                {
                    hashCode = (hashCode * 59) + this.ComputedParams.GetHashCode();
                }
                if (this.Endpoint != null)
                {
                    hashCode = (hashCode * 59) + this.Endpoint.GetHashCode();
                }
                if (this.Kind != null)
                {
                    hashCode = (hashCode * 59) + this.Kind.GetHashCode();
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
                if (this.Params != null)
                {
                    hashCode = (hashCode * 59) + this.Params.GetHashCode();
                }
                if (this.ResponseType != null)
                {
                    hashCode = (hashCode * 59) + this.ResponseType.GetHashCode();
                }
                if (this.ResultsField != null)
                {
                    hashCode = (hashCode * 59) + this.ResultsField.GetHashCode();
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
