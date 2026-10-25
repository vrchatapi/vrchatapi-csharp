

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
    /// The approximate location of the device that created the code.
    /// </summary>
    [DataContract(Name = "DeviceAuthInfoGeolocation")]
    public partial class DeviceAuthInfoGeolocation : IEquatable<DeviceAuthInfoGeolocation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceAuthInfoGeolocation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DeviceAuthInfoGeolocation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceAuthInfoGeolocation" /> class.
        /// </summary>
        /// <param name="city">city (required).</param>
        /// <param name="country">country (required).</param>
        /// <param name="region">region (required).</param>
        /// <param name="regionCode">regionCode (required).</param>
        public DeviceAuthInfoGeolocation(string city = default, string country = default, string region = default, string regionCode = default)
        {
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.City = city;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Country = country;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Region = region;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.RegionCode = regionCode;
        }

        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name = "city", IsRequired = true, EmitDefaultValue = true)]
        public string City { get; set; }

        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name = "country", IsRequired = true, EmitDefaultValue = true)]
        public string Country { get; set; }

        /// <summary>
        /// Gets or Sets Region
        /// </summary>
        [DataMember(Name = "region", IsRequired = true, EmitDefaultValue = true)]
        public string Region { get; set; }

        /// <summary>
        /// Gets or Sets RegionCode
        /// </summary>
        [DataMember(Name = "regionCode", IsRequired = true, EmitDefaultValue = true)]
        public string RegionCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DeviceAuthInfoGeolocation {\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Region: ").Append(Region).Append("\n");
            sb.Append("  RegionCode: ").Append(RegionCode).Append("\n");
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
            return this.Equals(input as DeviceAuthInfoGeolocation);
        }

        /// <summary>
        /// Returns true if DeviceAuthInfoGeolocation instances are equal
        /// </summary>
        /// <param name="input">Instance of DeviceAuthInfoGeolocation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeviceAuthInfoGeolocation input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.Region == input.Region ||
                    (this.Region != null &&
                    this.Region.Equals(input.Region))
                ) && 
                (
                    this.RegionCode == input.RegionCode ||
                    (this.RegionCode != null &&
                    this.RegionCode.Equals(input.RegionCode))
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
                if (this.City != null)
                {
                    hashCode = (hashCode * 59) + this.City.GetHashCode();
                }
                if (this.Country != null)
                {
                    hashCode = (hashCode * 59) + this.Country.GetHashCode();
                }
                if (this.Region != null)
                {
                    hashCode = (hashCode * 59) + this.Region.GetHashCode();
                }
                if (this.RegionCode != null)
                {
                    hashCode = (hashCode * 59) + this.RegionCode.GetHashCode();
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
