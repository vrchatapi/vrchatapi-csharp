

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
    /// A list field&#39;s value before and after an update.
    /// </summary>
    [DataContract(Name = "GroupAuditLogEntryStringListChange")]
    public partial class GroupAuditLogEntryStringListChange : IEquatable<GroupAuditLogEntryStringListChange>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLogEntryStringListChange" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GroupAuditLogEntryStringListChange() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLogEntryStringListChange" /> class.
        /// </summary>
        /// <param name="varNew">varNew (required).</param>
        /// <param name="old">old (required).</param>
        public GroupAuditLogEntryStringListChange(List<string> varNew = default, List<string> old = default)
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
        public List<string> New { get; set; }

        /// <summary>
        /// Gets or Sets Old
        /// </summary>
        [DataMember(Name = "old", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Old { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GroupAuditLogEntryStringListChange {\n");
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
            return this.Equals(input as GroupAuditLogEntryStringListChange);
        }

        /// <summary>
        /// Returns true if GroupAuditLogEntryStringListChange instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupAuditLogEntryStringListChange to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupAuditLogEntryStringListChange input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.New == input.New ||
                    this.New != null &&
                    input.New != null &&
                    this.New.SequenceEqual(input.New)
                ) && 
                (
                    this.Old == input.Old ||
                    this.Old != null &&
                    input.Old != null &&
                    this.Old.SequenceEqual(input.Old)
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
