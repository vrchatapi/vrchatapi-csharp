

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
    /// A seasonal campaign a group event can be listed under.
    /// </summary>
    [DataContract(Name = "APIConfigEventShelfCampaign")]
    public partial class APIConfigEventShelfCampaign : IEquatable<APIConfigEventShelfCampaign>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="APIConfigEventShelfCampaign" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected APIConfigEventShelfCampaign() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="APIConfigEventShelfCampaign" /> class.
        /// </summary>
        /// <param name="description">description.</param>
        /// <param name="key">key (required).</param>
        /// <param name="name">name (required).</param>
        public APIConfigEventShelfCampaign(string description = default, string key = default, string name = default)
        {
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Key = key;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Name = name;
            this.Description = description;
        }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        /*
        <example>Include this event in the VRChat Tanabata event shelf.</example>
        */
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Key
        /// </summary>
        /*
        <example>tanabata</example>
        */
        [DataMember(Name = "key", IsRequired = true, EmitDefaultValue = true)]
        public string Key { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        /*
        <example>Tanabata Homeworld Moderation</example>
        */
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class APIConfigEventShelfCampaign {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as APIConfigEventShelfCampaign);
        }

        /// <summary>
        /// Returns true if APIConfigEventShelfCampaign instances are equal
        /// </summary>
        /// <param name="input">Instance of APIConfigEventShelfCampaign to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(APIConfigEventShelfCampaign input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Key != null)
                {
                    hashCode = (hashCode * 59) + this.Key.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
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
