

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
    /// A cosmetic a user holds, without the template&#39;s presentation fields.
    /// </summary>
    [DataContract(Name = "UserCosmetic")]
    public partial class UserCosmetic : IEquatable<UserCosmetic>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets ItemType
        /// </summary>
        [DataMember(Name = "itemType", IsRequired = true, EmitDefaultValue = true)]
        public InventoryItemType ItemType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserCosmetic" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserCosmetic() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserCosmetic" /> class.
        /// </summary>
        /// <param name="acquiredOn">acquiredOn (required).</param>
        /// <param name="acquisition">acquisition (required).</param>
        /// <param name="id">id (required).</param>
        /// <param name="itemType">itemType (required).</param>
        /// <param name="templateId">templateId (required).</param>
        /// <param name="userAttributes">userAttributes (required).</param>
        public UserCosmetic(DateTime acquiredOn = default, string acquisition = default, string id = default, InventoryItemType itemType = default, string templateId = default, InventoryUserAttributes userAttributes = default)
        {
            this.AcquiredOn = acquiredOn;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Acquisition = acquisition;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Id = id;
            this.ItemType = itemType;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.TemplateId = templateId;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.UserAttributes = userAttributes;
        }

        /// <summary>
        /// Gets or Sets AcquiredOn
        /// </summary>
        [DataMember(Name = "acquiredOn", IsRequired = true, EmitDefaultValue = true)]
        public DateTime AcquiredOn { get; set; }

        /// <summary>
        /// Gets or Sets Acquisition
        /// </summary>
        [DataMember(Name = "acquisition", IsRequired = true, EmitDefaultValue = true)]
        public string Acquisition { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        /*
        <example>inv_10bce5b0-2d2b-44e0-900d-db6534615162</example>
        */
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets TemplateId
        /// </summary>
        /*
        <example>invt_b80ce14b-038b-4f56-b970-d232771d62e3</example>
        */
        [DataMember(Name = "templateId", IsRequired = true, EmitDefaultValue = true)]
        public string TemplateId { get; set; }

        /// <summary>
        /// Gets or Sets UserAttributes
        /// </summary>
        [DataMember(Name = "userAttributes", IsRequired = true, EmitDefaultValue = true)]
        public InventoryUserAttributes UserAttributes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserCosmetic {\n");
            sb.Append("  AcquiredOn: ").Append(AcquiredOn).Append("\n");
            sb.Append("  Acquisition: ").Append(Acquisition).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ItemType: ").Append(ItemType).Append("\n");
            sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
            sb.Append("  UserAttributes: ").Append(UserAttributes).Append("\n");
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
            return this.Equals(input as UserCosmetic);
        }

        /// <summary>
        /// Returns true if UserCosmetic instances are equal
        /// </summary>
        /// <param name="input">Instance of UserCosmetic to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserCosmetic input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AcquiredOn == input.AcquiredOn ||
                    this.AcquiredOn.Equals(input.AcquiredOn)
                ) && 
                (
                    this.Acquisition == input.Acquisition ||
                    (this.Acquisition != null &&
                    this.Acquisition.Equals(input.Acquisition))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.ItemType == input.ItemType ||
                    this.ItemType.Equals(input.ItemType)
                ) && 
                (
                    this.TemplateId == input.TemplateId ||
                    (this.TemplateId != null &&
                    this.TemplateId.Equals(input.TemplateId))
                ) && 
                (
                    this.UserAttributes == input.UserAttributes ||
                    (this.UserAttributes != null &&
                    this.UserAttributes.Equals(input.UserAttributes))
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
                hashCode = (hashCode * 59) + this.AcquiredOn.GetHashCode();
                if (this.Acquisition != null)
                {
                    hashCode = (hashCode * 59) + this.Acquisition.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ItemType.GetHashCode();
                if (this.TemplateId != null)
                {
                    hashCode = (hashCode * 59) + this.TemplateId.GetHashCode();
                }
                if (this.UserAttributes != null)
                {
                    hashCode = (hashCode * 59) + this.UserAttributes.GetHashCode();
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
