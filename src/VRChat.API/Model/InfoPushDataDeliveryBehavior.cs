

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
    /// InfoPushDataDeliveryBehavior
    /// </summary>
    [DataContract(Name = "InfoPushDataDeliveryBehavior")]
    public partial class InfoPushDataDeliveryBehavior : IEquatable<InfoPushDataDeliveryBehavior>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InfoPushDataDeliveryBehavior" /> class.
        /// </summary>
        /// <param name="bypass24HourWindow">bypass24HourWindow.</param>
        /// <param name="maxRedeliveryAttempts">maxRedeliveryAttempts.</param>
        /// <param name="redeliverIfNoEngagement">redeliverIfNoEngagement.</param>
        public InfoPushDataDeliveryBehavior(bool bypass24HourWindow = default, int maxRedeliveryAttempts = default, bool redeliverIfNoEngagement = default)
        {
            this.Bypass24HourWindow = bypass24HourWindow;
            this.MaxRedeliveryAttempts = maxRedeliveryAttempts;
            this.RedeliverIfNoEngagement = redeliverIfNoEngagement;
        }

        /// <summary>
        /// Gets or Sets Bypass24HourWindow
        /// </summary>
        [DataMember(Name = "bypass24HourWindow", EmitDefaultValue = true)]
        public bool Bypass24HourWindow { get; set; }

        /// <summary>
        /// Gets or Sets MaxRedeliveryAttempts
        /// </summary>
        [DataMember(Name = "maxRedeliveryAttempts", EmitDefaultValue = false)]
        public int MaxRedeliveryAttempts { get; set; }

        /// <summary>
        /// Gets or Sets RedeliverIfNoEngagement
        /// </summary>
        [DataMember(Name = "redeliverIfNoEngagement", EmitDefaultValue = true)]
        public bool RedeliverIfNoEngagement { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InfoPushDataDeliveryBehavior {\n");
            sb.Append("  Bypass24HourWindow: ").Append(Bypass24HourWindow).Append("\n");
            sb.Append("  MaxRedeliveryAttempts: ").Append(MaxRedeliveryAttempts).Append("\n");
            sb.Append("  RedeliverIfNoEngagement: ").Append(RedeliverIfNoEngagement).Append("\n");
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
            return this.Equals(input as InfoPushDataDeliveryBehavior);
        }

        /// <summary>
        /// Returns true if InfoPushDataDeliveryBehavior instances are equal
        /// </summary>
        /// <param name="input">Instance of InfoPushDataDeliveryBehavior to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InfoPushDataDeliveryBehavior input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Bypass24HourWindow == input.Bypass24HourWindow ||
                    this.Bypass24HourWindow.Equals(input.Bypass24HourWindow)
                ) && 
                (
                    this.MaxRedeliveryAttempts == input.MaxRedeliveryAttempts ||
                    this.MaxRedeliveryAttempts.Equals(input.MaxRedeliveryAttempts)
                ) && 
                (
                    this.RedeliverIfNoEngagement == input.RedeliverIfNoEngagement ||
                    this.RedeliverIfNoEngagement.Equals(input.RedeliverIfNoEngagement)
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
                hashCode = (hashCode * 59) + this.Bypass24HourWindow.GetHashCode();
                hashCode = (hashCode * 59) + this.MaxRedeliveryAttempts.GetHashCode();
                hashCode = (hashCode * 59) + this.RedeliverIfNoEngagement.GetHashCode();
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
