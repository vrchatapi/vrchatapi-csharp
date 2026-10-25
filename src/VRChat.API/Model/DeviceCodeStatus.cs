

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
    /// DeviceCodeStatus
    /// </summary>
    [DataContract(Name = "DeviceCodeStatus")]
    public partial class DeviceCodeStatus : IEquatable<DeviceCodeStatus>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceCodeStatus" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DeviceCodeStatus() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceCodeStatus" /> class.
        /// </summary>
        /// <param name="status">status (required).</param>
        /// <param name="user">Set once someone approves the code, when the response also logs this device in..</param>
        public DeviceCodeStatus(string status = default, Object user = default)
        {
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Status = status;
            this.User = user;
        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public string Status { get; set; }

        /// <summary>
        /// Set once someone approves the code, when the response also logs this device in.
        /// </summary>
        /// <value>Set once someone approves the code, when the response also logs this device in.</value>
        [DataMember(Name = "user", EmitDefaultValue = true)]
        public Object User { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DeviceCodeStatus {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
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
            return this.Equals(input as DeviceCodeStatus);
        }

        /// <summary>
        /// Returns true if DeviceCodeStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of DeviceCodeStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeviceCodeStatus input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
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
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.User != null)
                {
                    hashCode = (hashCode * 59) + this.User.GetHashCode();
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
