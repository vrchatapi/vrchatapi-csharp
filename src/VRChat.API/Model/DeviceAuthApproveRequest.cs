

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
    /// DeviceAuthApproveRequest
    /// </summary>
    [DataContract(Name = "DeviceAuthApproveRequest")]
    public partial class DeviceAuthApproveRequest : IEquatable<DeviceAuthApproveRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceAuthApproveRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DeviceAuthApproveRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceAuthApproveRequest" /> class.
        /// </summary>
        /// <param name="userCode">The &#x60;userCode&#x60; of the device code to approve. (required).</param>
        public DeviceAuthApproveRequest(string userCode = default)
        {
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.UserCode = userCode;
        }

        /// <summary>
        /// The &#x60;userCode&#x60; of the device code to approve.
        /// </summary>
        /// <value>The &#x60;userCode&#x60; of the device code to approve.</value>
        [DataMember(Name = "userCode", IsRequired = true, EmitDefaultValue = true)]
        public string UserCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DeviceAuthApproveRequest {\n");
            sb.Append("  UserCode: ").Append(UserCode).Append("\n");
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
            return this.Equals(input as DeviceAuthApproveRequest);
        }

        /// <summary>
        /// Returns true if DeviceAuthApproveRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of DeviceAuthApproveRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeviceAuthApproveRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.UserCode == input.UserCode ||
                    (this.UserCode != null &&
                    this.UserCode.Equals(input.UserCode))
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
                if (this.UserCode != null)
                {
                    hashCode = (hashCode * 59) + this.UserCode.GetHashCode();
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
