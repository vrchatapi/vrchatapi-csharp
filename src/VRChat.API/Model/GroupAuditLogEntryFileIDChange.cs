

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
    /// A File ID field&#39;s value before and after an update.
    /// </summary>
    [DataContract(Name = "GroupAuditLogEntryFileIDChange")]
    public partial class GroupAuditLogEntryFileIDChange : IEquatable<GroupAuditLogEntryFileIDChange>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLogEntryFileIDChange" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GroupAuditLogEntryFileIDChange() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLogEntryFileIDChange" /> class.
        /// </summary>
        /// <param name="varNew">varNew (required).</param>
        /// <param name="old">old (required).</param>
        public GroupAuditLogEntryFileIDChange(string varNew = default, string old = default)
        {
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.New = varNew;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Old = old;
        }

        /// <summary>
        /// Gets or Sets New
        /// </summary>
        [DataMember(Name = "new", IsRequired = true, EmitDefaultValue = true)]
        public string New { get; set; }

        /// <summary>
        /// Gets or Sets Old
        /// </summary>
        [DataMember(Name = "old", IsRequired = true, EmitDefaultValue = true)]
        public string Old { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GroupAuditLogEntryFileIDChange {\n");
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
            return this.Equals(input as GroupAuditLogEntryFileIDChange);
        }

        /// <summary>
        /// Returns true if GroupAuditLogEntryFileIDChange instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupAuditLogEntryFileIDChange to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupAuditLogEntryFileIDChange input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.New == input.New ||
                    (this.New != null &&
                    this.New.Equals(input.New))
                ) && 
                (
                    this.Old == input.Old ||
                    (this.Old != null &&
                    this.Old.Equals(input.Old))
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
                if (this.New != null)
                {
                    hashCode = (hashCode * 59) + this.New.GetHashCode();
                }
                if (this.Old != null)
                {
                    hashCode = (hashCode * 59) + this.Old.GetHashCode();
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
