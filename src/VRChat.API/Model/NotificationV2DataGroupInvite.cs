

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
    /// NotificationV2DataGroupInvite
    /// </summary>
    [DataContract(Name = "NotificationV2DataGroupInvite")]
    public partial class NotificationV2DataGroupInvite : IEquatable<NotificationV2DataGroupInvite>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationV2DataGroupInvite" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NotificationV2DataGroupInvite() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationV2DataGroupInvite" /> class.
        /// </summary>
        /// <param name="groupName">groupName (required).</param>
        /// <param name="managerUserDisplayName">managerUserDisplayName (required).</param>
        public NotificationV2DataGroupInvite(string groupName = default, string managerUserDisplayName = default)
        {
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.GroupName = groupName;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.ManagerUserDisplayName = managerUserDisplayName;
        }

        /// <summary>
        /// Gets or Sets GroupName
        /// </summary>
        [DataMember(Name = "groupName", IsRequired = true, EmitDefaultValue = true)]
        public string GroupName { get; set; }

        /// <summary>
        /// Gets or Sets ManagerUserDisplayName
        /// </summary>
        [DataMember(Name = "managerUserDisplayName", IsRequired = true, EmitDefaultValue = true)]
        public string ManagerUserDisplayName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NotificationV2DataGroupInvite {\n");
            sb.Append("  GroupName: ").Append(GroupName).Append("\n");
            sb.Append("  ManagerUserDisplayName: ").Append(ManagerUserDisplayName).Append("\n");
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
            return this.Equals(input as NotificationV2DataGroupInvite);
        }

        /// <summary>
        /// Returns true if NotificationV2DataGroupInvite instances are equal
        /// </summary>
        /// <param name="input">Instance of NotificationV2DataGroupInvite to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NotificationV2DataGroupInvite input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.GroupName == input.GroupName ||
                    (this.GroupName != null &&
                    this.GroupName.Equals(input.GroupName))
                ) && 
                (
                    this.ManagerUserDisplayName == input.ManagerUserDisplayName ||
                    (this.ManagerUserDisplayName != null &&
                    this.ManagerUserDisplayName.Equals(input.ManagerUserDisplayName))
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
                if (this.GroupName != null)
                {
                    hashCode = (hashCode * 59) + this.GroupName.GetHashCode();
                }
                if (this.ManagerUserDisplayName != null)
                {
                    hashCode = (hashCode * 59) + this.ManagerUserDisplayName.GetHashCode();
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
