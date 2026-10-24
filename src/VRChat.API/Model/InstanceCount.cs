

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
    /// InstanceCount
    /// </summary>
    [DataContract(Name = "InstanceCount")]
    public partial class InstanceCount : IEquatable<InstanceCount>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InstanceCount" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InstanceCount() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InstanceCount" /> class.
        /// </summary>
        /// <param name="asOf">asOf (required).</param>
        /// <param name="events">events (required).</param>
        /// <param name="friends">friends (required).</param>
        /// <param name="instances">instances (required).</param>
        public InstanceCount(DateTime asOf = default, int events = default, int friends = default, int instances = default)
        {
            this.AsOf = asOf;
            this.Events = events;
            this.Friends = friends;
            this.Instances = instances;
        }

        /// <summary>
        /// Gets or Sets AsOf
        /// </summary>
        [DataMember(Name = "asOf", IsRequired = true, EmitDefaultValue = true)]
        public DateTime AsOf { get; set; }

        /// <summary>
        /// Gets or Sets Events
        /// </summary>
        [DataMember(Name = "events", IsRequired = true, EmitDefaultValue = true)]
        public int Events { get; set; }

        /// <summary>
        /// Gets or Sets Friends
        /// </summary>
        [DataMember(Name = "friends", IsRequired = true, EmitDefaultValue = true)]
        public int Friends { get; set; }

        /// <summary>
        /// Gets or Sets Instances
        /// </summary>
        [DataMember(Name = "instances", IsRequired = true, EmitDefaultValue = true)]
        public int Instances { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InstanceCount {\n");
            sb.Append("  AsOf: ").Append(AsOf).Append("\n");
            sb.Append("  Events: ").Append(Events).Append("\n");
            sb.Append("  Friends: ").Append(Friends).Append("\n");
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
            return this.Equals(input as InstanceCount);
        }

        /// <summary>
        /// Returns true if InstanceCount instances are equal
        /// </summary>
        /// <param name="input">Instance of InstanceCount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InstanceCount input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AsOf == input.AsOf ||
                    this.AsOf.Equals(input.AsOf)
                ) && 
                (
                    this.Events == input.Events ||
                    this.Events.Equals(input.Events)
                ) && 
                (
                    this.Friends == input.Friends ||
                    this.Friends.Equals(input.Friends)
                ) && 
                (
                    this.Instances == input.Instances ||
                    this.Instances.Equals(input.Instances)
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
                hashCode = (hashCode * 59) + this.AsOf.GetHashCode();
                hashCode = (hashCode * 59) + this.Events.GetHashCode();
                hashCode = (hashCode * 59) + this.Friends.GetHashCode();
                hashCode = (hashCode * 59) + this.Instances.GetHashCode();
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
            // Events (int) minimum
            if (this.Events < (int)0)
            {
                yield return new ValidationResult("Invalid value for Events, must be a value greater than or equal to 0.", new [] { "Events" });
            }

            // Friends (int) minimum
            if (this.Friends < (int)0)
            {
                yield return new ValidationResult("Invalid value for Friends, must be a value greater than or equal to 0.", new [] { "Friends" });
            }

            // Instances (int) minimum
            if (this.Instances < (int)0)
            {
                yield return new ValidationResult("Invalid value for Instances, must be a value greater than or equal to 0.", new [] { "Instances" });
            }

            yield break;
        }
    }

}
