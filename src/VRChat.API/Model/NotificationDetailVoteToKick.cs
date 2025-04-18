/*
 * VRChat API Documentation
 *
 *
 * The version of the OpenAPI document: 1.19.2
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
    /// NotificationDetailVoteToKick
    /// </summary>
    [DataContract(Name = "NotificationDetailVoteToKick")]
    public partial class NotificationDetailVoteToKick : IEquatable<NotificationDetailVoteToKick>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationDetailVoteToKick" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NotificationDetailVoteToKick() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationDetailVoteToKick" /> class.
        /// </summary>
        /// <param name="initiatorUserId">A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed. (required).</param>
        /// <param name="userToKickId">A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed. (required).</param>
        public NotificationDetailVoteToKick(string initiatorUserId = default(string), string userToKickId = default(string))
        {
            // to ensure "initiatorUserId" is required (not null)
            if (initiatorUserId == null)
            {
                throw new ArgumentNullException("initiatorUserId is a required property for NotificationDetailVoteToKick and cannot be null");
            }
            this.InitiatorUserId = initiatorUserId;
            // to ensure "userToKickId" is required (not null)
            if (userToKickId == null)
            {
                throw new ArgumentNullException("userToKickId is a required property for NotificationDetailVoteToKick and cannot be null");
            }
            this.UserToKickId = userToKickId;
        }

        /// <summary>
        /// A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed.
        /// </summary>
        /// <value>A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed.</value>
        [DataMember(Name = "initiatorUserId", IsRequired = true, EmitDefaultValue = true)]
        public string InitiatorUserId { get; set; }

        /// <summary>
        /// A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed.
        /// </summary>
        /// <value>A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed.</value>
        [DataMember(Name = "userToKickId", IsRequired = true, EmitDefaultValue = true)]
        public string UserToKickId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NotificationDetailVoteToKick {\n");
            sb.Append("  InitiatorUserId: ").Append(InitiatorUserId).Append("\n");
            sb.Append("  UserToKickId: ").Append(UserToKickId).Append("\n");
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
            return this.Equals(input as NotificationDetailVoteToKick);
        }

        /// <summary>
        /// Returns true if NotificationDetailVoteToKick instances are equal
        /// </summary>
        /// <param name="input">Instance of NotificationDetailVoteToKick to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NotificationDetailVoteToKick input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.InitiatorUserId == input.InitiatorUserId ||
                    (this.InitiatorUserId != null &&
                    this.InitiatorUserId.Equals(input.InitiatorUserId))
                ) && 
                (
                    this.UserToKickId == input.UserToKickId ||
                    (this.UserToKickId != null &&
                    this.UserToKickId.Equals(input.UserToKickId))
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
                if (this.InitiatorUserId != null)
                {
                    hashCode = (hashCode * 59) + this.InitiatorUserId.GetHashCode();
                }
                if (this.UserToKickId != null)
                {
                    hashCode = (hashCode * 59) + this.UserToKickId.GetHashCode();
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
