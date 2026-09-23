

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
    /// NotificationV2DataBoop
    /// </summary>
    [DataContract(Name = "NotificationV2DataBoop")]
    public partial class NotificationV2DataBoop : IEquatable<NotificationV2DataBoop>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationV2DataBoop" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NotificationV2DataBoop() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationV2DataBoop" /> class.
        /// </summary>
        /// <param name="boopingUserDisplayName">boopingUserDisplayName (required).</param>
        public NotificationV2DataBoop(string boopingUserDisplayName = default)
        {
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.BoopingUserDisplayName = boopingUserDisplayName;
        }

        /// <summary>
        /// Gets or Sets BoopingUserDisplayName
        /// </summary>
        [DataMember(Name = "boopingUserDisplayName", IsRequired = true, EmitDefaultValue = true)]
        public string BoopingUserDisplayName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NotificationV2DataBoop {\n");
            sb.Append("  BoopingUserDisplayName: ").Append(BoopingUserDisplayName).Append("\n");
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
            return this.Equals(input as NotificationV2DataBoop);
        }

        /// <summary>
        /// Returns true if NotificationV2DataBoop instances are equal
        /// </summary>
        /// <param name="input">Instance of NotificationV2DataBoop to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NotificationV2DataBoop input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BoopingUserDisplayName == input.BoopingUserDisplayName ||
                    (this.BoopingUserDisplayName != null &&
                    this.BoopingUserDisplayName.Equals(input.BoopingUserDisplayName))
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
                if (this.BoopingUserDisplayName != null)
                {
                    hashCode = (hashCode * 59) + this.BoopingUserDisplayName.GetHashCode();
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
