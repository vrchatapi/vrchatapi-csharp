/*
 * VRChat API Documentation
 *
 *
 * The version of the OpenAPI document: 1.18.5
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
    /// NotificationDetailRequestInvite
    /// </summary>
    [DataContract(Name = "NotificationDetailRequestInvite")]
    public partial class NotificationDetailRequestInvite : IEquatable<NotificationDetailRequestInvite>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationDetailRequestInvite" /> class.
        /// </summary>
        /// <param name="platform">TODO: Does this still exist?.</param>
        /// <param name="requestMessage">Used when using InviteMessage Slot..</param>
        public NotificationDetailRequestInvite(string platform = default(string), string requestMessage = default(string))
        {
            this.Platform = platform;
            this.RequestMessage = requestMessage;
        }

        /// <summary>
        /// TODO: Does this still exist?
        /// </summary>
        /// <value>TODO: Does this still exist?</value>
        [DataMember(Name = "platform", EmitDefaultValue = false)]
        public string Platform { get; set; }

        /// <summary>
        /// Used when using InviteMessage Slot.
        /// </summary>
        /// <value>Used when using InviteMessage Slot.</value>
        [DataMember(Name = "requestMessage", EmitDefaultValue = false)]
        public string RequestMessage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NotificationDetailRequestInvite {\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
            sb.Append("  RequestMessage: ").Append(RequestMessage).Append("\n");
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
            return this.Equals(input as NotificationDetailRequestInvite);
        }

        /// <summary>
        /// Returns true if NotificationDetailRequestInvite instances are equal
        /// </summary>
        /// <param name="input">Instance of NotificationDetailRequestInvite to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NotificationDetailRequestInvite input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Platform == input.Platform ||
                    (this.Platform != null &&
                    this.Platform.Equals(input.Platform))
                ) && 
                (
                    this.RequestMessage == input.RequestMessage ||
                    (this.RequestMessage != null &&
                    this.RequestMessage.Equals(input.RequestMessage))
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
                if (this.Platform != null)
                {
                    hashCode = (hashCode * 59) + this.Platform.GetHashCode();
                }
                if (this.RequestMessage != null)
                {
                    hashCode = (hashCode * 59) + this.RequestMessage.GetHashCode();
                }
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
