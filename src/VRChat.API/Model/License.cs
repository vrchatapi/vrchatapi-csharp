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
    /// License
    /// </summary>
    [DataContract(Name = "License")]
    public partial class License : IEquatable<License>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets ForType
        /// </summary>
        [DataMember(Name = "forType", IsRequired = true, EmitDefaultValue = true)]
        public LicenseType ForType { get; set; }

        /// <summary>
        /// Gets or Sets ForAction
        /// </summary>
        [DataMember(Name = "forAction", IsRequired = true, EmitDefaultValue = true)]
        public LicenseAction ForAction { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="License" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected License() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="License" /> class.
        /// </summary>
        /// <param name="forId">Either a AvatarID, LicenseGroupID, PermissionID or ProductID. This depends on the &#x60;forType&#x60; field. (required).</param>
        /// <param name="forType">forType (required).</param>
        /// <param name="forName">forName (required).</param>
        /// <param name="forAction">forAction (required).</param>
        public License(string forId = default(string), LicenseType forType = default(LicenseType), string forName = default(string), LicenseAction forAction = default(LicenseAction))
        {
            // to ensure "forId" is required (not null)
            if (forId == null)
            {
                throw new ArgumentNullException("forId is a required property for License and cannot be null");
            }
            this.ForId = forId;
            this.ForType = forType;
            // to ensure "forName" is required (not null)
            if (forName == null)
            {
                throw new ArgumentNullException("forName is a required property for License and cannot be null");
            }
            this.ForName = forName;
            this.ForAction = forAction;
        }

        /// <summary>
        /// Either a AvatarID, LicenseGroupID, PermissionID or ProductID. This depends on the &#x60;forType&#x60; field.
        /// </summary>
        /// <value>Either a AvatarID, LicenseGroupID, PermissionID or ProductID. This depends on the &#x60;forType&#x60; field.</value>
        [DataMember(Name = "forId", IsRequired = true, EmitDefaultValue = true)]
        public string ForId { get; set; }

        /// <summary>
        /// Gets or Sets ForName
        /// </summary>
        [DataMember(Name = "forName", IsRequired = true, EmitDefaultValue = true)]
        public string ForName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class License {\n");
            sb.Append("  ForId: ").Append(ForId).Append("\n");
            sb.Append("  ForType: ").Append(ForType).Append("\n");
            sb.Append("  ForName: ").Append(ForName).Append("\n");
            sb.Append("  ForAction: ").Append(ForAction).Append("\n");
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
            return this.Equals(input as License);
        }

        /// <summary>
        /// Returns true if License instances are equal
        /// </summary>
        /// <param name="input">Instance of License to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(License input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ForId == input.ForId ||
                    (this.ForId != null &&
                    this.ForId.Equals(input.ForId))
                ) && 
                (
                    this.ForType == input.ForType ||
                    this.ForType.Equals(input.ForType)
                ) && 
                (
                    this.ForName == input.ForName ||
                    (this.ForName != null &&
                    this.ForName.Equals(input.ForName))
                ) && 
                (
                    this.ForAction == input.ForAction ||
                    this.ForAction.Equals(input.ForAction)
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
                if (this.ForId != null)
                {
                    hashCode = (hashCode * 59) + this.ForId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ForType.GetHashCode();
                if (this.ForName != null)
                {
                    hashCode = (hashCode * 59) + this.ForName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ForAction.GetHashCode();
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
            // ForId (string) minLength
            if (this.ForId != null && this.ForId.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ForId, length must be greater than 1.", new [] { "ForId" });
            }

            // ForName (string) minLength
            if (this.ForName != null && this.ForName.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ForName, length must be greater than 1.", new [] { "ForName" });
            }

            yield break;
        }
    }

}
