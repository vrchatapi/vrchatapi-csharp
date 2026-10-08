

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
    /// WebsocketUserBadgeUnassigned
    /// </summary>
    [DataContract(Name = "WebsocketUserBadgeUnassigned")]
    public partial class WebsocketUserBadgeUnassigned : IEquatable<WebsocketUserBadgeUnassigned>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebsocketUserBadgeUnassigned" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WebsocketUserBadgeUnassigned() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebsocketUserBadgeUnassigned" /> class.
        /// </summary>
        /// <param name="badgeId">badgeId (required).</param>
        public WebsocketUserBadgeUnassigned(string badgeId = default)
        {
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.BadgeId = badgeId;
        }

        /// <summary>
        /// Gets or Sets BadgeId
        /// </summary>
        [DataMember(Name = "badgeId", IsRequired = true, EmitDefaultValue = true)]
        public string BadgeId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WebsocketUserBadgeUnassigned {\n");
            sb.Append("  BadgeId: ").Append(BadgeId).Append("\n");
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
            return this.Equals(input as WebsocketUserBadgeUnassigned);
        }

        /// <summary>
        /// Returns true if WebsocketUserBadgeUnassigned instances are equal
        /// </summary>
        /// <param name="input">Instance of WebsocketUserBadgeUnassigned to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebsocketUserBadgeUnassigned input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BadgeId == input.BadgeId ||
                    (this.BadgeId != null &&
                    this.BadgeId.Equals(input.BadgeId))
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
                if (this.BadgeId != null)
                {
                    hashCode = (hashCode * 59) + this.BadgeId.GetHashCode();
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
