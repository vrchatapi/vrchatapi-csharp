

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
    /// Where a device code was created, shown to the person about to approve it.
    /// </summary>
    [DataContract(Name = "DeviceAuthInfo")]
    public partial class DeviceAuthInfo : IEquatable<DeviceAuthInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceAuthInfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DeviceAuthInfo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceAuthInfo" /> class.
        /// </summary>
        /// <param name="createdAt">When the device code was created, in milliseconds since the Unix epoch. (required).</param>
        /// <param name="geolocation">geolocation (required).</param>
        public DeviceAuthInfo(int createdAt = default, DeviceAuthInfoGeolocation geolocation = default)
        {
            this.CreatedAt = createdAt;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Geolocation = geolocation;
        }

        /// <summary>
        /// When the device code was created, in milliseconds since the Unix epoch.
        /// </summary>
        /// <value>When the device code was created, in milliseconds since the Unix epoch.</value>
        [DataMember(Name = "createdAt", IsRequired = true, EmitDefaultValue = true)]
        public int CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets Geolocation
        /// </summary>
        [DataMember(Name = "geolocation", IsRequired = true, EmitDefaultValue = true)]
        public DeviceAuthInfoGeolocation Geolocation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DeviceAuthInfo {\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Geolocation: ").Append(Geolocation).Append("\n");
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
            return this.Equals(input as DeviceAuthInfo);
        }

        /// <summary>
        /// Returns true if DeviceAuthInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of DeviceAuthInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeviceAuthInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CreatedAt == input.CreatedAt ||
                    this.CreatedAt.Equals(input.CreatedAt)
                ) && 
                (
                    this.Geolocation == input.Geolocation ||
                    (this.Geolocation != null &&
                    this.Geolocation.Equals(input.Geolocation))
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
                hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                if (this.Geolocation != null)
                {
                    hashCode = (hashCode * 59) + this.Geolocation.GetHashCode();
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
