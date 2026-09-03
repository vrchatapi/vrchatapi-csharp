

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
    /// The body VRChat returns for a route it does not serve. The shape differs from every other error in this description: &#x60;error&#x60; is a string here, not an &#x60;Error&#x60; object with &#x60;message&#x60; and &#x60;status_code&#x60; inside it.
    /// </summary>
    [DataContract(Name = "RouteNotImplemented")]
    public partial class RouteNotImplemented : IEquatable<RouteNotImplemented>, IValidatableObject
    {
        /// <summary>
        /// Defines Error
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ErrorEnum
        {
            /// <summary>
            /// Enum TheEndpointYoureLookingForIsNotImplementedByOurSystem for value: The endpoint you&#39;re looking for is not implemented by our system.
            /// </summary>
            [EnumMember(Value = "The endpoint you're looking for is not implemented by our system.")]
            TheEndpointYoureLookingForIsNotImplementedByOurSystem = 1
        }


        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name = "error", IsRequired = true, EmitDefaultValue = true)]
        public ErrorEnum Error { get; set; }
        /// <summary>
        /// Defines StatusCode
        /// </summary>
        public enum StatusCodeEnum
        {
            /// <summary>
            /// Enum NUMBER_404 for value: 404
            /// </summary>
            NUMBER_404 = 404
        }


        /// <summary>
        /// Gets or Sets StatusCode
        /// </summary>
        [DataMember(Name = "status_code", IsRequired = true, EmitDefaultValue = true)]
        public StatusCodeEnum StatusCode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RouteNotImplemented" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RouteNotImplemented() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RouteNotImplemented" /> class.
        /// </summary>
        /// <param name="error">error (required).</param>
        /// <param name="statusCode">statusCode (required).</param>
        public RouteNotImplemented(ErrorEnum error = default, StatusCodeEnum statusCode = default)
        {
            this.Error = error;
            this.StatusCode = statusCode;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RouteNotImplemented {\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
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
            return this.Equals(input as RouteNotImplemented);
        }

        /// <summary>
        /// Returns true if RouteNotImplemented instances are equal
        /// </summary>
        /// <param name="input">Instance of RouteNotImplemented to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RouteNotImplemented input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Error == input.Error ||
                    this.Error.Equals(input.Error)
                ) && 
                (
                    this.StatusCode == input.StatusCode ||
                    this.StatusCode.Equals(input.StatusCode)
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
                hashCode = (hashCode * 59) + this.Error.GetHashCode();
                hashCode = (hashCode * 59) + this.StatusCode.GetHashCode();
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
