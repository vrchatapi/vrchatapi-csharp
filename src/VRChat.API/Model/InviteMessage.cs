/*
 * VRChat API Documentation
 *
 *
 * The version of the OpenAPI document: 1.20.0
 * Contact: vrchatapi.lpv0t@aries.fyi
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


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
using OpenAPIDateConverter = VRChat.API.Client.OpenAPIDateConverter;

namespace VRChat.API.Model
{
    /// <summary>
    /// InviteMessage
    /// </summary>
    [DataContract(Name = "InviteMessage")]
    public partial class InviteMessage : IEquatable<InviteMessage>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets MessageType
        /// </summary>
        [DataMember(Name = "messageType", IsRequired = true, EmitDefaultValue = true)]
        public InviteMessageType MessageType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InviteMessage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InviteMessage() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InviteMessage" /> class.
        /// </summary>
        /// <param name="canBeUpdated">canBeUpdated (required) (default to true).</param>
        /// <param name="id">id (required).</param>
        /// <param name="message">message (required).</param>
        /// <param name="messageType">messageType (required).</param>
        /// <param name="remainingCooldownMinutes">Changes to 60 when updated, although probably server-side configurable. (required) (default to 0).</param>
        /// <param name="slot">slot (required).</param>
        /// <param name="updatedAt">updatedAt (required).</param>
        public InviteMessage(bool canBeUpdated = true, string id = default(string), string message = default(string), InviteMessageType messageType = default(InviteMessageType), int remainingCooldownMinutes = 0, int slot = default(int), DateTime updatedAt = default(DateTime))
        {
            this.CanBeUpdated = canBeUpdated;
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for InviteMessage and cannot be null");
            }
            this.Id = id;
            // to ensure "message" is required (not null)
            if (message == null)
            {
                throw new ArgumentNullException("message is a required property for InviteMessage and cannot be null");
            }
            this.Message = message;
            this.MessageType = messageType;
            this.RemainingCooldownMinutes = remainingCooldownMinutes;
            this.Slot = slot;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Gets or Sets CanBeUpdated
        /// </summary>
        [DataMember(Name = "canBeUpdated", IsRequired = true, EmitDefaultValue = true)]
        public bool CanBeUpdated { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name = "message", IsRequired = true, EmitDefaultValue = true)]
        public string Message { get; set; }

        /// <summary>
        /// Changes to 60 when updated, although probably server-side configurable.
        /// </summary>
        /// <value>Changes to 60 when updated, although probably server-side configurable.</value>
        [DataMember(Name = "remainingCooldownMinutes", IsRequired = true, EmitDefaultValue = true)]
        public int RemainingCooldownMinutes { get; set; }

        /// <summary>
        /// Gets or Sets Slot
        /// </summary>
        [DataMember(Name = "slot", IsRequired = true, EmitDefaultValue = true)]
        public int Slot { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updatedAt", IsRequired = true, EmitDefaultValue = true)]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InviteMessage {\n");
            sb.Append("  CanBeUpdated: ").Append(CanBeUpdated).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  MessageType: ").Append(MessageType).Append("\n");
            sb.Append("  RemainingCooldownMinutes: ").Append(RemainingCooldownMinutes).Append("\n");
            sb.Append("  Slot: ").Append(Slot).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
            return this.Equals(input as InviteMessage);
        }

        /// <summary>
        /// Returns true if InviteMessage instances are equal
        /// </summary>
        /// <param name="input">Instance of InviteMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InviteMessage input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CanBeUpdated == input.CanBeUpdated ||
                    this.CanBeUpdated.Equals(input.CanBeUpdated)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.MessageType == input.MessageType ||
                    this.MessageType.Equals(input.MessageType)
                ) && 
                (
                    this.RemainingCooldownMinutes == input.RemainingCooldownMinutes ||
                    this.RemainingCooldownMinutes.Equals(input.RemainingCooldownMinutes)
                ) && 
                (
                    this.Slot == input.Slot ||
                    this.Slot.Equals(input.Slot)
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
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
                hashCode = (hashCode * 59) + this.CanBeUpdated.GetHashCode();
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Message != null)
                {
                    hashCode = (hashCode * 59) + this.Message.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.MessageType.GetHashCode();
                hashCode = (hashCode * 59) + this.RemainingCooldownMinutes.GetHashCode();
                hashCode = (hashCode * 59) + this.Slot.GetHashCode();
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            // Message (string) minLength
            if (this.Message != null && this.Message.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Message, length must be greater than 1.", new [] { "Message" });
            }

            // RemainingCooldownMinutes (int) minimum
            if (this.RemainingCooldownMinutes < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RemainingCooldownMinutes, must be a value greater than or equal to 0.", new [] { "RemainingCooldownMinutes" });
            }

            // Slot (int) maximum
            if (this.Slot > (int)11)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Slot, must be a value less than or equal to 11.", new [] { "Slot" });
            }

            // Slot (int) minimum
            if (this.Slot < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Slot, must be a value greater than or equal to 0.", new [] { "Slot" });
            }

            yield break;
        }
    }

}
