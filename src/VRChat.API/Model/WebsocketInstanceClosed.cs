

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
    /// WebsocketInstanceClosed
    /// </summary>
    [DataContract(Name = "WebsocketInstanceClosed")]
    public partial class WebsocketInstanceClosed : IEquatable<WebsocketInstanceClosed>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebsocketInstanceClosed" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WebsocketInstanceClosed() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebsocketInstanceClosed" /> class.
        /// </summary>
        /// <param name="instanceLocation">Represents a unique location, consisting of a world identifier and an instance identifier, or \&quot;offline\&quot; if the user is not on your friends list. (required).</param>
        public WebsocketInstanceClosed(string instanceLocation = default)
        {
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.InstanceLocation = instanceLocation;
        }

        /// <summary>
        /// Represents a unique location, consisting of a world identifier and an instance identifier, or \&quot;offline\&quot; if the user is not on your friends list.
        /// </summary>
        /// <value>Represents a unique location, consisting of a world identifier and an instance identifier, or \&quot;offline\&quot; if the user is not on your friends list.</value>
        [DataMember(Name = "instanceLocation", IsRequired = true, EmitDefaultValue = true)]
        public string InstanceLocation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WebsocketInstanceClosed {\n");
            sb.Append("  InstanceLocation: ").Append(InstanceLocation).Append("\n");
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
            return this.Equals(input as WebsocketInstanceClosed);
        }

        /// <summary>
        /// Returns true if WebsocketInstanceClosed instances are equal
        /// </summary>
        /// <param name="input">Instance of WebsocketInstanceClosed to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebsocketInstanceClosed input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.InstanceLocation == input.InstanceLocation ||
                    (this.InstanceLocation != null &&
                    this.InstanceLocation.Equals(input.InstanceLocation))
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
                if (this.InstanceLocation != null)
                {
                    hashCode = (hashCode * 59) + this.InstanceLocation.GetHashCode();
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
