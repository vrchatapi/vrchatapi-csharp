

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
    /// WebsocketNotificationV2DeleteEncoded
    /// </summary>
    [DataContract(Name = "WebsocketNotificationV2DeleteEncoded")]
    public partial class WebsocketNotificationV2DeleteEncoded : IEquatable<WebsocketNotificationV2DeleteEncoded>, IValidatableObject
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum NotificationV2Delete for value: notification-v2-delete
            /// </summary>
            [EnumMember(Value = "notification-v2-delete")]
            NotificationV2Delete = 1
        }


        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebsocketNotificationV2DeleteEncoded" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WebsocketNotificationV2DeleteEncoded() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebsocketNotificationV2DeleteEncoded" /> class.
        /// </summary>
        /// <param name="content">content (required).</param>
        /// <param name="type">type (required).</param>
        public WebsocketNotificationV2DeleteEncoded(string content = default, TypeEnum type = default)
        {
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Content = content;
            this.Type = type;
        }

        /// <summary>
        /// Gets or Sets Content
        /// </summary>
        [DataMember(Name = "content", IsRequired = true, EmitDefaultValue = true)]
        public string Content { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WebsocketNotificationV2DeleteEncoded {\n");
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
            return this.Equals(input as WebsocketNotificationV2DeleteEncoded);
        }

        /// <summary>
        /// Returns true if WebsocketNotificationV2DeleteEncoded instances are equal
        /// </summary>
        /// <param name="input">Instance of WebsocketNotificationV2DeleteEncoded to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebsocketNotificationV2DeleteEncoded input)
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
                    this.Type.Equals(input.Type)
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
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
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
