

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
    /// A websocket message whose &#x60;type&#x60; has no schema of its own.
    /// </summary>
    [DataContract(Name = "WebsocketMessageUnknown")]
    public partial class WebsocketMessageUnknown : IEquatable<WebsocketMessageUnknown>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebsocketMessageUnknown" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WebsocketMessageUnknown() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebsocketMessageUnknown" /> class.
        /// </summary>
        /// <param name="content">content.</param>
        /// <param name="type">type (required).</param>
        public WebsocketMessageUnknown(Object content = default, string type = default)
        {
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Type = type;
            this.Content = content;
        }

        /// <summary>
        /// Gets or Sets Content
        /// </summary>
        [DataMember(Name = "content", EmitDefaultValue = true)]
        public Object Content { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public string Type { get; set; }

        [System.Runtime.Serialization.OnDeserialized]
        internal void OnDeserializedTypeNotEnum(System.Runtime.Serialization.StreamingContext context)
        {
            if (this.Type == "clear-notification" || this.Type == "content-refresh" || this.Type == "friend-active" || this.Type == "friend-add" || this.Type == "friend-delete" || this.Type == "friend-location" || this.Type == "friend-offline" || this.Type == "friend-online" || this.Type == "friend-update" || this.Type == "group-joined" || this.Type == "group-left" || this.Type == "group-member-updated" || this.Type == "group-role-updated" || this.Type == "hide-notification" || this.Type == "instance-queue-joined" || this.Type == "instance-queue-ready" || this.Type == "notification" || this.Type == "notification-v2" || this.Type == "notification-v2-delete" || this.Type == "notification-v2-update" || this.Type == "response-notification" || this.Type == "see-notification" || this.Type == "user-badge-assigned" || this.Type == "user-badge-unassigned" || this.Type == "user-location" || this.Type == "user-update")
            {
                throw new ArgumentException("Invalid value for Type, must not be a value excluded by the 'not' schema.");
            }
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WebsocketMessageUnknown {\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as WebsocketMessageUnknown);
        }

        /// <summary>
        /// Returns true if WebsocketMessageUnknown instances are equal
        /// </summary>
        /// <param name="input">Instance of WebsocketMessageUnknown to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebsocketMessageUnknown input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Content != null)
                {
                    hashCode = (hashCode * 59) + this.Content.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
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
