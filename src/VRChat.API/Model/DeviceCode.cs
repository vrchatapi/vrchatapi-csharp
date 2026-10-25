

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
    /// A code that logs this device in once someone approves it at &#x60;verificationUrl&#x60;.
    /// </summary>
    [DataContract(Name = "DeviceCode")]
    public partial class DeviceCode : IEquatable<DeviceCode>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceCode" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DeviceCode() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceCode" /> class.
        /// </summary>
        /// <param name="varDeviceCode">Identifies this login attempt to &#x60;checkDeviceCode&#x60;. (required).</param>
        /// <param name="expiresIn">Seconds until the code expires. (required).</param>
        /// <param name="interval">Seconds to wait between calls to &#x60;checkDeviceCode&#x60;. (required).</param>
        /// <param name="userCode">The code a person enters at &#x60;verificationUrl&#x60; to approve the login. (required).</param>
        /// <param name="verificationUrl">verificationUrl (required).</param>
        /// <param name="verificationUrlComplete">&#x60;verificationUrl&#x60; with the code already filled in. (required).</param>
        public DeviceCode(string varDeviceCode = default, int expiresIn = default, int interval = default, string userCode = default, string verificationUrl = default, string verificationUrlComplete = default)
        {
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.VarDeviceCode = varDeviceCode;
            this.ExpiresIn = expiresIn;
            this.Interval = interval;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.UserCode = userCode;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.VerificationUrl = verificationUrl;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.VerificationUrlComplete = verificationUrlComplete;
        }

        /// <summary>
        /// Identifies this login attempt to &#x60;checkDeviceCode&#x60;.
        /// </summary>
        /// <value>Identifies this login attempt to &#x60;checkDeviceCode&#x60;.</value>
        [DataMember(Name = "deviceCode", IsRequired = true, EmitDefaultValue = true)]
        public string VarDeviceCode { get; set; }

        /// <summary>
        /// Seconds until the code expires.
        /// </summary>
        /// <value>Seconds until the code expires.</value>
        [DataMember(Name = "expiresIn", IsRequired = true, EmitDefaultValue = true)]
        public int ExpiresIn { get; set; }

        /// <summary>
        /// Seconds to wait between calls to &#x60;checkDeviceCode&#x60;.
        /// </summary>
        /// <value>Seconds to wait between calls to &#x60;checkDeviceCode&#x60;.</value>
        [DataMember(Name = "interval", IsRequired = true, EmitDefaultValue = true)]
        public int Interval { get; set; }

        /// <summary>
        /// The code a person enters at &#x60;verificationUrl&#x60; to approve the login.
        /// </summary>
        /// <value>The code a person enters at &#x60;verificationUrl&#x60; to approve the login.</value>
        [DataMember(Name = "userCode", IsRequired = true, EmitDefaultValue = true)]
        public string UserCode { get; set; }

        /// <summary>
        /// Gets or Sets VerificationUrl
        /// </summary>
        [DataMember(Name = "verificationUrl", IsRequired = true, EmitDefaultValue = true)]
        public string VerificationUrl { get; set; }

        /// <summary>
        /// &#x60;verificationUrl&#x60; with the code already filled in.
        /// </summary>
        /// <value>&#x60;verificationUrl&#x60; with the code already filled in.</value>
        [DataMember(Name = "verificationUrlComplete", IsRequired = true, EmitDefaultValue = true)]
        public string VerificationUrlComplete { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DeviceCode {\n");
            sb.Append("  VarDeviceCode: ").Append(VarDeviceCode).Append("\n");
            sb.Append("  ExpiresIn: ").Append(ExpiresIn).Append("\n");
            sb.Append("  Interval: ").Append(Interval).Append("\n");
            sb.Append("  UserCode: ").Append(UserCode).Append("\n");
            sb.Append("  VerificationUrl: ").Append(VerificationUrl).Append("\n");
            sb.Append("  VerificationUrlComplete: ").Append(VerificationUrlComplete).Append("\n");
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
            return this.Equals(input as DeviceCode);
        }

        /// <summary>
        /// Returns true if DeviceCode instances are equal
        /// </summary>
        /// <param name="input">Instance of DeviceCode to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeviceCode input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.VarDeviceCode == input.VarDeviceCode ||
                    (this.VarDeviceCode != null &&
                    this.VarDeviceCode.Equals(input.VarDeviceCode))
                ) && 
                (
                    this.ExpiresIn == input.ExpiresIn ||
                    this.ExpiresIn.Equals(input.ExpiresIn)
                ) && 
                (
                    this.Interval == input.Interval ||
                    this.Interval.Equals(input.Interval)
                ) && 
                (
                    this.UserCode == input.UserCode ||
                    (this.UserCode != null &&
                    this.UserCode.Equals(input.UserCode))
                ) && 
                (
                    this.VerificationUrl == input.VerificationUrl ||
                    (this.VerificationUrl != null &&
                    this.VerificationUrl.Equals(input.VerificationUrl))
                ) && 
                (
                    this.VerificationUrlComplete == input.VerificationUrlComplete ||
                    (this.VerificationUrlComplete != null &&
                    this.VerificationUrlComplete.Equals(input.VerificationUrlComplete))
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
                if (this.VarDeviceCode != null)
                {
                    hashCode = (hashCode * 59) + this.VarDeviceCode.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ExpiresIn.GetHashCode();
                hashCode = (hashCode * 59) + this.Interval.GetHashCode();
                if (this.UserCode != null)
                {
                    hashCode = (hashCode * 59) + this.UserCode.GetHashCode();
                }
                if (this.VerificationUrl != null)
                {
                    hashCode = (hashCode * 59) + this.VerificationUrl.GetHashCode();
                }
                if (this.VerificationUrlComplete != null)
                {
                    hashCode = (hashCode * 59) + this.VerificationUrlComplete.GetHashCode();
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
