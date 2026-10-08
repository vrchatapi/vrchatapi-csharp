

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
    /// WebsocketGroupJoined
    /// </summary>
    [DataContract(Name = "WebsocketGroupJoined")]
    public partial class WebsocketGroupJoined : IEquatable<WebsocketGroupJoined>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebsocketGroupJoined" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WebsocketGroupJoined() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebsocketGroupJoined" /> class.
        /// </summary>
        /// <param name="groupId">groupId (required).</param>
        public WebsocketGroupJoined(string groupId = default)
        {
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.GroupId = groupId;
        }

        /// <summary>
        /// Gets or Sets GroupId
        /// </summary>
        [DataMember(Name = "groupId", IsRequired = true, EmitDefaultValue = true)]
        public string GroupId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WebsocketGroupJoined {\n");
            sb.Append("  GroupId: ").Append(GroupId).Append("\n");
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
            return this.Equals(input as WebsocketGroupJoined);
        }

        /// <summary>
        /// Returns true if WebsocketGroupJoined instances are equal
        /// </summary>
        /// <param name="input">Instance of WebsocketGroupJoined to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebsocketGroupJoined input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.GroupId == input.GroupId ||
                    (this.GroupId != null &&
                    this.GroupId.Equals(input.GroupId))
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
                if (this.GroupId != null)
                {
                    hashCode = (hashCode * 59) + this.GroupId.GetHashCode();
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
