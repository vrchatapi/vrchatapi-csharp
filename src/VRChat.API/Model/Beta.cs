

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
    /// Beta
    /// </summary>
    [DataContract(Name = "Beta")]
    public partial class Beta : IEquatable<Beta>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Beta" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Beta() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Beta" /> class.
        /// </summary>
        /// <param name="active">active (required).</param>
        /// <param name="betaAppId">betaAppId.</param>
        /// <param name="betaGroupId">betaGroupId.</param>
        /// <param name="betaName">betaName (required).</param>
        /// <param name="createdAt">createdAt (required).</param>
        /// <param name="id">id (required).</param>
        /// <param name="lastSynchronizedAt">lastSynchronizedAt.</param>
        /// <param name="type">type (required).</param>
        /// <param name="updatedAt">updatedAt (required).</param>
        /// <param name="userFields">The fields a registration must supply, keyed by field name. (required).</param>
        public Beta(bool active = default, string betaAppId = default, string betaGroupId = default, string betaName = default, DateTime createdAt = default, string id = default, DateTime lastSynchronizedAt = default, string type = default, DateTime updatedAt = default, Dictionary<string, BetaUserField> userFields = default)
        {
            this.Active = active;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.BetaName = betaName;
            this.CreatedAt = createdAt;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Id = id;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Type = type;
            this.UpdatedAt = updatedAt;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.UserFields = userFields;
            this.BetaAppId = betaAppId;
            this.BetaGroupId = betaGroupId;
            this.LastSynchronizedAt = lastSynchronizedAt;
        }

        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name = "active", IsRequired = true, EmitDefaultValue = true)]
        public bool Active { get; set; }

        /// <summary>
        /// Gets or Sets BetaAppId
        /// </summary>
        [DataMember(Name = "betaAppId", EmitDefaultValue = false)]
        public string BetaAppId { get; set; }

        /// <summary>
        /// Gets or Sets BetaGroupId
        /// </summary>
        [DataMember(Name = "betaGroupId", EmitDefaultValue = false)]
        public string BetaGroupId { get; set; }

        /// <summary>
        /// Gets or Sets BetaName
        /// </summary>
        [DataMember(Name = "betaName", IsRequired = true, EmitDefaultValue = true)]
        public string BetaName { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "created_at", IsRequired = true, EmitDefaultValue = true)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        /*
        <example>beta_872e10d7-699d-42cb-9e70-2373a9a044e1</example>
        */
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets LastSynchronizedAt
        /// </summary>
        [DataMember(Name = "lastSynchronizedAt", EmitDefaultValue = false)]
        public DateTime LastSynchronizedAt { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updated_at", IsRequired = true, EmitDefaultValue = true)]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// The fields a registration must supply, keyed by field name.
        /// </summary>
        /// <value>The fields a registration must supply, keyed by field name.</value>
        [DataMember(Name = "userFields", IsRequired = true, EmitDefaultValue = true)]
        public Dictionary<string, BetaUserField> UserFields { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Beta {\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  BetaAppId: ").Append(BetaAppId).Append("\n");
            sb.Append("  BetaGroupId: ").Append(BetaGroupId).Append("\n");
            sb.Append("  BetaName: ").Append(BetaName).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LastSynchronizedAt: ").Append(LastSynchronizedAt).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  UserFields: ").Append(UserFields).Append("\n");
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
            return this.Equals(input as Beta);
        }

        /// <summary>
        /// Returns true if Beta instances are equal
        /// </summary>
        /// <param name="input">Instance of Beta to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Beta input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Active == input.Active ||
                    this.Active.Equals(input.Active)
                ) && 
                (
                    this.BetaAppId == input.BetaAppId ||
                    (this.BetaAppId != null &&
                    this.BetaAppId.Equals(input.BetaAppId))
                ) && 
                (
                    this.BetaGroupId == input.BetaGroupId ||
                    (this.BetaGroupId != null &&
                    this.BetaGroupId.Equals(input.BetaGroupId))
                ) && 
                (
                    this.BetaName == input.BetaName ||
                    (this.BetaName != null &&
                    this.BetaName.Equals(input.BetaName))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    this.CreatedAt.Equals(input.CreatedAt)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.LastSynchronizedAt == input.LastSynchronizedAt ||
                    this.LastSynchronizedAt.Equals(input.LastSynchronizedAt)
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    this.UpdatedAt.Equals(input.UpdatedAt)
                ) && 
                (
                    this.UserFields == input.UserFields ||
                    this.UserFields != null &&
                    input.UserFields != null &&
                    this.UserFields.SequenceEqual(input.UserFields)
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
                hashCode = (hashCode * 59) + this.Active.GetHashCode();
                if (this.BetaAppId != null)
                {
                    hashCode = (hashCode * 59) + this.BetaAppId.GetHashCode();
                }
                if (this.BetaGroupId != null)
                {
                    hashCode = (hashCode * 59) + this.BetaGroupId.GetHashCode();
                }
                if (this.BetaName != null)
                {
                    hashCode = (hashCode * 59) + this.BetaName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.LastSynchronizedAt.GetHashCode();
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
                if (this.UserFields != null)
                {
                    hashCode = (hashCode * 59) + this.UserFields.GetHashCode();
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
