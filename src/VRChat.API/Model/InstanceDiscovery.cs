

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
    /// InstanceDiscovery
    /// </summary>
    [DataContract(Name = "InstanceDiscovery")]
    public partial class InstanceDiscovery : IEquatable<InstanceDiscovery>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InstanceDiscovery" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InstanceDiscovery() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InstanceDiscovery" /> class.
        /// </summary>
        /// <param name="attributionId">attributionId (required).</param>
        /// <param name="instances">instances (required).</param>
        public InstanceDiscovery(string attributionId = default, List<LimitedInstance> instances = default)
        {
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.AttributionId = attributionId;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Instances = instances;
        }

        /// <summary>
        /// Gets or Sets AttributionId
        /// </summary>
        [DataMember(Name = "attributionId", IsRequired = true, EmitDefaultValue = true)]
        public string AttributionId { get; set; }

        /// <summary>
        /// Gets or Sets Instances
        /// </summary>
        [DataMember(Name = "instances", IsRequired = true, EmitDefaultValue = true)]
        public List<LimitedInstance> Instances { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InstanceDiscovery {\n");
            sb.Append("  AttributionId: ").Append(AttributionId).Append("\n");
            sb.Append("  Instances: ").Append(Instances).Append("\n");
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
            return this.Equals(input as InstanceDiscovery);
        }

        /// <summary>
        /// Returns true if InstanceDiscovery instances are equal
        /// </summary>
        /// <param name="input">Instance of InstanceDiscovery to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InstanceDiscovery input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AttributionId == input.AttributionId ||
                    (this.AttributionId != null &&
                    this.AttributionId.Equals(input.AttributionId))
                ) && 
                (
                    this.Instances == input.Instances ||
                    this.Instances != null &&
                    input.Instances != null &&
                    this.Instances.SequenceEqual(input.Instances)
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
                if (this.AttributionId != null)
                {
                    hashCode = (hashCode * 59) + this.AttributionId.GetHashCode();
                }
                if (this.Instances != null)
                {
                    hashCode = (hashCode * 59) + this.Instances.GetHashCode();
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
