

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
    /// WebsocketResponseNotification
    /// </summary>
    [DataContract(Name = "WebsocketResponseNotification")]
    public partial class WebsocketResponseNotification : IEquatable<WebsocketResponseNotification>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebsocketResponseNotification" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WebsocketResponseNotification() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebsocketResponseNotification" /> class.
        /// </summary>
        /// <param name="notificationId">notificationId (required).</param>
        /// <param name="receiverId">A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed. (required).</param>
        /// <param name="responseId">A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed. (required).</param>
        public WebsocketResponseNotification(string notificationId = default, string receiverId = default, string responseId = default)
        {
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.NotificationId = notificationId;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.ReceiverId = receiverId;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.ResponseId = responseId;
        }

        /// <summary>
        /// Gets or Sets NotificationId
        /// </summary>
        [DataMember(Name = "notificationId", IsRequired = true, EmitDefaultValue = true)]
        public string NotificationId { get; set; }

        /// <summary>
        /// A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed.
        /// </summary>
        /// <value>A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed.</value>
        [DataMember(Name = "receiverId", IsRequired = true, EmitDefaultValue = true)]
        public string ReceiverId { get; set; }

        /// <summary>
        /// A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed.
        /// </summary>
        /// <value>A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed.</value>
        [DataMember(Name = "responseId", IsRequired = true, EmitDefaultValue = true)]
        public string ResponseId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WebsocketResponseNotification {\n");
            sb.Append("  NotificationId: ").Append(NotificationId).Append("\n");
            sb.Append("  ReceiverId: ").Append(ReceiverId).Append("\n");
            sb.Append("  ResponseId: ").Append(ResponseId).Append("\n");
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
            return this.Equals(input as WebsocketResponseNotification);
        }

        /// <summary>
        /// Returns true if WebsocketResponseNotification instances are equal
        /// </summary>
        /// <param name="input">Instance of WebsocketResponseNotification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebsocketResponseNotification input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.NotificationId == input.NotificationId ||
                    (this.NotificationId != null &&
                    this.NotificationId.Equals(input.NotificationId))
                ) && 
                (
                    this.ReceiverId == input.ReceiverId ||
                    (this.ReceiverId != null &&
                    this.ReceiverId.Equals(input.ReceiverId))
                ) && 
                (
                    this.ResponseId == input.ResponseId ||
                    (this.ResponseId != null &&
                    this.ResponseId.Equals(input.ResponseId))
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
                if (this.NotificationId != null)
                {
                    hashCode = (hashCode * 59) + this.NotificationId.GetHashCode();
                }
                if (this.ReceiverId != null)
                {
                    hashCode = (hashCode * 59) + this.ReceiverId.GetHashCode();
                }
                if (this.ResponseId != null)
                {
                    hashCode = (hashCode * 59) + this.ResponseId.GetHashCode();
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
