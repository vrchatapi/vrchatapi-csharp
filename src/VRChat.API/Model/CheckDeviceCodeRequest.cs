

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
    /// CheckDeviceCodeRequest
    /// </summary>
    [DataContract(Name = "CheckDeviceCodeRequest")]
    public partial class CheckDeviceCodeRequest : IEquatable<CheckDeviceCodeRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckDeviceCodeRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CheckDeviceCodeRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckDeviceCodeRequest" /> class.
        /// </summary>
        /// <param name="deviceCode">deviceCode (required).</param>
        public CheckDeviceCodeRequest(string deviceCode = default)
        {
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.DeviceCode = deviceCode;
        }

        /// <summary>
        /// Gets or Sets DeviceCode
        /// </summary>
        [DataMember(Name = "deviceCode", IsRequired = true, EmitDefaultValue = true)]
        public string DeviceCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CheckDeviceCodeRequest {\n");
            sb.Append("  DeviceCode: ").Append(DeviceCode).Append("\n");
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
            return this.Equals(input as CheckDeviceCodeRequest);
        }

        /// <summary>
        /// Returns true if CheckDeviceCodeRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CheckDeviceCodeRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CheckDeviceCodeRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DeviceCode == input.DeviceCode ||
                    (this.DeviceCode != null &&
                    this.DeviceCode.Equals(input.DeviceCode))
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
                if (this.DeviceCode != null)
                {
                    hashCode = (hashCode * 59) + this.DeviceCode.GetHashCode();
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
