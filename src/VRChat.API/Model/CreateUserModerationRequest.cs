

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
    /// CreateUserModerationRequest
    /// </summary>
    [DataContract(Name = "CreateUserModerationRequest")]
    public partial class CreateUserModerationRequest : IEquatable<CreateUserModerationRequest>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public CreateUserModerationRequestType Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUserModerationRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateUserModerationRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUserModerationRequest" /> class.
        /// </summary>
        /// <param name="expires">expires.</param>
        /// <param name="instanceId">InstanceID can be \&quot;offline\&quot; on User profiles if you are not friends with that user and \&quot;private\&quot; if you are friends and user is in private instance..</param>
        /// <param name="isPermanent">isPermanent.</param>
        /// <param name="reason">reason (required).</param>
        /// <param name="type">type (required).</param>
        /// <param name="worldId">WorldID be \&quot;offline\&quot; on User profiles if you are not friends with that user..</param>
        public CreateUserModerationRequest(DateTime expires = default, string instanceId = default, bool isPermanent = default, string reason = default, CreateUserModerationRequestType type = default, string worldId = default)
        {
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Reason = reason;
            this.Type = type;
            this.Expires = expires;
            this.InstanceId = instanceId;
            this.IsPermanent = isPermanent;
            this.WorldId = worldId;
        }

        /// <summary>
        /// Gets or Sets Expires
        /// </summary>
        [DataMember(Name = "expires", EmitDefaultValue = false)]
        public DateTime Expires { get; set; }

        /// <summary>
        /// InstanceID can be \&quot;offline\&quot; on User profiles if you are not friends with that user and \&quot;private\&quot; if you are friends and user is in private instance.
        /// </summary>
        /// <value>InstanceID can be \&quot;offline\&quot; on User profiles if you are not friends with that user and \&quot;private\&quot; if you are friends and user is in private instance.</value>
        [DataMember(Name = "instanceId", EmitDefaultValue = false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Gets or Sets IsPermanent
        /// </summary>
        [DataMember(Name = "isPermanent", EmitDefaultValue = true)]
        public bool IsPermanent { get; set; }

        /// <summary>
        /// Gets or Sets Reason
        /// </summary>
        [DataMember(Name = "reason", IsRequired = true, EmitDefaultValue = true)]
        public string Reason { get; set; }

        /// <summary>
        /// WorldID be \&quot;offline\&quot; on User profiles if you are not friends with that user.
        /// </summary>
        /// <value>WorldID be \&quot;offline\&quot; on User profiles if you are not friends with that user.</value>
        [DataMember(Name = "worldId", EmitDefaultValue = false)]
        public string WorldId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateUserModerationRequest {\n");
            sb.Append("  Expires: ").Append(Expires).Append("\n");
            sb.Append("  InstanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  IsPermanent: ").Append(IsPermanent).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  WorldId: ").Append(WorldId).Append("\n");
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
            return this.Equals(input as CreateUserModerationRequest);
        }

        /// <summary>
        /// Returns true if CreateUserModerationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateUserModerationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateUserModerationRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Expires == input.Expires ||
                    this.Expires.Equals(input.Expires)
                ) && 
                (
                    this.InstanceId == input.InstanceId ||
                    (this.InstanceId != null &&
                    this.InstanceId.Equals(input.InstanceId))
                ) && 
                (
                    this.IsPermanent == input.IsPermanent ||
                    this.IsPermanent.Equals(input.IsPermanent)
                ) && 
                (
                    this.Reason == input.Reason ||
                    (this.Reason != null &&
                    this.Reason.Equals(input.Reason))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.WorldId == input.WorldId ||
                    (this.WorldId != null &&
                    this.WorldId.Equals(input.WorldId))
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
                hashCode = (hashCode * 59) + this.Expires.GetHashCode();
                if (this.InstanceId != null)
                {
                    hashCode = (hashCode * 59) + this.InstanceId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsPermanent.GetHashCode();
                if (this.Reason != null)
                {
                    hashCode = (hashCode * 59) + this.Reason.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.WorldId != null)
                {
                    hashCode = (hashCode * 59) + this.WorldId.GetHashCode();
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
