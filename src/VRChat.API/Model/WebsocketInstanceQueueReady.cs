

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
    /// WebsocketInstanceQueueReady
    /// </summary>
    [DataContract(Name = "WebsocketInstanceQueueReady")]
    public partial class WebsocketInstanceQueueReady : IEquatable<WebsocketInstanceQueueReady>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebsocketInstanceQueueReady" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WebsocketInstanceQueueReady() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebsocketInstanceQueueReady" /> class.
        /// </summary>
        /// <param name="expiry">expiry (required).</param>
        /// <param name="location">Represents a unique location, consisting of a world identifier and an instance identifier, or \&quot;offline\&quot; if the user is not on your friends list. (required).</param>
        public WebsocketInstanceQueueReady(DateTime expiry = default, string location = default)
        {
            this.Expiry = expiry;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Location = location;
        }

        /// <summary>
        /// Gets or Sets Expiry
        /// </summary>
        [DataMember(Name = "expiry", IsRequired = true, EmitDefaultValue = true)]
        public DateTime Expiry { get; set; }

        /// <summary>
        /// Represents a unique location, consisting of a world identifier and an instance identifier, or \&quot;offline\&quot; if the user is not on your friends list.
        /// </summary>
        /// <value>Represents a unique location, consisting of a world identifier and an instance identifier, or \&quot;offline\&quot; if the user is not on your friends list.</value>
        [DataMember(Name = "location", IsRequired = true, EmitDefaultValue = true)]
        public string Location { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WebsocketInstanceQueueReady {\n");
            sb.Append("  Expiry: ").Append(Expiry).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
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
            return this.Equals(input as WebsocketInstanceQueueReady);
        }

        /// <summary>
        /// Returns true if WebsocketInstanceQueueReady instances are equal
        /// </summary>
        /// <param name="input">Instance of WebsocketInstanceQueueReady to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebsocketInstanceQueueReady input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Expiry == input.Expiry ||
                    this.Expiry.Equals(input.Expiry)
                ) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
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
                hashCode = (hashCode * 59) + this.Expiry.GetHashCode();
                if (this.Location != null)
                {
                    hashCode = (hashCode * 59) + this.Location.GetHashCode();
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
