

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
    /// InfoPushUrlConsentScreenData
    /// </summary>
    [DataContract(Name = "InfoPushUrlConsentScreenData")]
    public partial class InfoPushUrlConsentScreenData : IEquatable<InfoPushUrlConsentScreenData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InfoPushUrlConsentScreenData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InfoPushUrlConsentScreenData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InfoPushUrlConsentScreenData" /> class.
        /// </summary>
        /// <param name="disclaimerText">disclaimerText (required).</param>
        /// <param name="domainList">domainList (required).</param>
        /// <param name="worldTag">worldTag (required).</param>
        public InfoPushUrlConsentScreenData(string disclaimerText = default, List<InfoPushDataDomain> domainList = default, string worldTag = default)
        {
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.DisclaimerText = disclaimerText;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.DomainList = domainList;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.WorldTag = worldTag;
        }

        /// <summary>
        /// Gets or Sets DisclaimerText
        /// </summary>
        [DataMember(Name = "disclaimerText", IsRequired = true, EmitDefaultValue = true)]
        public string DisclaimerText { get; set; }

        /// <summary>
        /// Gets or Sets DomainList
        /// </summary>
        [DataMember(Name = "domainList", IsRequired = true, EmitDefaultValue = true)]
        public List<InfoPushDataDomain> DomainList { get; set; }

        /// <summary>
        /// Gets or Sets WorldTag
        /// </summary>
        [DataMember(Name = "worldTag", IsRequired = true, EmitDefaultValue = true)]
        public string WorldTag { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InfoPushUrlConsentScreenData {\n");
            sb.Append("  DisclaimerText: ").Append(DisclaimerText).Append("\n");
            sb.Append("  DomainList: ").Append(DomainList).Append("\n");
            sb.Append("  WorldTag: ").Append(WorldTag).Append("\n");
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
            return this.Equals(input as InfoPushUrlConsentScreenData);
        }

        /// <summary>
        /// Returns true if InfoPushUrlConsentScreenData instances are equal
        /// </summary>
        /// <param name="input">Instance of InfoPushUrlConsentScreenData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InfoPushUrlConsentScreenData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DisclaimerText == input.DisclaimerText ||
                    (this.DisclaimerText != null &&
                    this.DisclaimerText.Equals(input.DisclaimerText))
                ) && 
                (
                    this.DomainList == input.DomainList ||
                    this.DomainList != null &&
                    input.DomainList != null &&
                    this.DomainList.SequenceEqual(input.DomainList)
                ) && 
                (
                    this.WorldTag == input.WorldTag ||
                    (this.WorldTag != null &&
                    this.WorldTag.Equals(input.WorldTag))
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
                if (this.DisclaimerText != null)
                {
                    hashCode = (hashCode * 59) + this.DisclaimerText.GetHashCode();
                }
                if (this.DomainList != null)
                {
                    hashCode = (hashCode * 59) + this.DomainList.GetHashCode();
                }
                if (this.WorldTag != null)
                {
                    hashCode = (hashCode * 59) + this.WorldTag.GetHashCode();
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
