

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
    /// An integer field&#39;s value before and after an update.
    /// </summary>
    [DataContract(Name = "GroupAuditLogEntryIntegerChange")]
    public partial class GroupAuditLogEntryIntegerChange : IEquatable<GroupAuditLogEntryIntegerChange>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLogEntryIntegerChange" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GroupAuditLogEntryIntegerChange() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLogEntryIntegerChange" /> class.
        /// </summary>
        /// <param name="varNew">varNew (required).</param>
        /// <param name="old">old (required).</param>
        public GroupAuditLogEntryIntegerChange(int varNew = default, int old = default)
        {
            this.New = varNew;
            this.Old = old;
        }

        /// <summary>
        /// Gets or Sets New
        /// </summary>
        [DataMember(Name = "new", IsRequired = true, EmitDefaultValue = true)]
        public int New { get; set; }

        /// <summary>
        /// Gets or Sets Old
        /// </summary>
        [DataMember(Name = "old", IsRequired = true, EmitDefaultValue = true)]
        public int Old { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GroupAuditLogEntryIntegerChange {\n");
            sb.Append("  New: ").Append(New).Append("\n");
            sb.Append("  Old: ").Append(Old).Append("\n");
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
            return this.Equals(input as GroupAuditLogEntryIntegerChange);
        }

        /// <summary>
        /// Returns true if GroupAuditLogEntryIntegerChange instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupAuditLogEntryIntegerChange to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupAuditLogEntryIntegerChange input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.New == input.New ||
                    this.New.Equals(input.New)
                ) && 
                (
                    this.Old == input.Old ||
                    this.Old.Equals(input.Old)
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
                hashCode = (hashCode * 59) + this.New.GetHashCode();
                hashCode = (hashCode * 59) + this.Old.GetHashCode();
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
