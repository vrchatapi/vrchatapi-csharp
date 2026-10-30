

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
    /// GlobalInventoryItemAttributionCreator
    /// </summary>
    [DataContract(Name = "GlobalInventoryItemAttributionCreator")]
    public partial class GlobalInventoryItemAttributionCreator : IEquatable<GlobalInventoryItemAttributionCreator>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalInventoryItemAttributionCreator" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GlobalInventoryItemAttributionCreator() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalInventoryItemAttributionCreator" /> class.
        /// </summary>
        /// <param name="customName">customName (required).</param>
        /// <param name="userId">userId (required).</param>
        public GlobalInventoryItemAttributionCreator(string customName = default, string userId = default)
        {
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.CustomName = customName;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.UserId = userId;
        }

        /// <summary>
        /// Gets or Sets CustomName
        /// </summary>
        [DataMember(Name = "customName", IsRequired = true, EmitDefaultValue = true)]
        public string CustomName { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name = "userId", IsRequired = true, EmitDefaultValue = true)]
        public string UserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GlobalInventoryItemAttributionCreator {\n");
            sb.Append("  CustomName: ").Append(CustomName).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
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
            return this.Equals(input as GlobalInventoryItemAttributionCreator);
        }

        /// <summary>
        /// Returns true if GlobalInventoryItemAttributionCreator instances are equal
        /// </summary>
        /// <param name="input">Instance of GlobalInventoryItemAttributionCreator to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GlobalInventoryItemAttributionCreator input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CustomName == input.CustomName ||
                    (this.CustomName != null &&
                    this.CustomName.Equals(input.CustomName))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
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
                if (this.CustomName != null)
                {
                    hashCode = (hashCode * 59) + this.CustomName.GetHashCode();
                }
                if (this.UserId != null)
                {
                    hashCode = (hashCode * 59) + this.UserId.GetHashCode();
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
