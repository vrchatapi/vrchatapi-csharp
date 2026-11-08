

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
    /// A websocket message, which indicates that some sort of error has occurred
    /// </summary>
    [DataContract(Name = "WebsocketMessageError")]
    public partial class WebsocketMessageError : IEquatable<WebsocketMessageError>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebsocketMessageError" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WebsocketMessageError()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebsocketMessageError" /> class.
        /// </summary>
        /// <param name="err">err (required).</param>
        public WebsocketMessageError(string err = default)
        {
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Err = err;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets Err
        /// </summary>
        [DataMember(Name = "err", IsRequired = true, EmitDefaultValue = true)]
        public string Err { get; set; }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WebsocketMessageError {\n");
            sb.Append("  Err: ").Append(Err).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
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
            return this.Equals(input as WebsocketMessageError);
        }

        /// <summary>
        /// Returns true if WebsocketMessageError instances are equal
        /// </summary>
        /// <param name="input">Instance of WebsocketMessageError to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebsocketMessageError input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Err == input.Err ||
                    (this.Err != null &&
                    this.Err.Equals(input.Err))
                )
                && (this.AdditionalProperties.Count == input.AdditionalProperties.Count && !this.AdditionalProperties.Except(input.AdditionalProperties).Any());
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
                if (this.Err != null)
                {
                    hashCode = (hashCode * 59) + this.Err.GetHashCode();
                }
                if (this.AdditionalProperties != null)
                {
                    hashCode = (hashCode * 59) + this.AdditionalProperties.GetHashCode();
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
