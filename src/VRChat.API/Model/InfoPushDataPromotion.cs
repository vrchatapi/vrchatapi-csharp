

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
    /// InfoPushDataPromotion
    /// </summary>
    [DataContract(Name = "InfoPushDataPromotion")]
    public partial class InfoPushDataPromotion : IEquatable<InfoPushDataPromotion>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InfoPushDataPromotion" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InfoPushDataPromotion() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InfoPushDataPromotion" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="impressions">impressions (required).</param>
        /// <param name="notification">notification (required).</param>
        /// <param name="type">type (required).</param>
        public InfoPushDataPromotion(string id = default, int impressions = default, InfoPushDataPromotionNotification notification = default, string type = default)
        {
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Id = id;
            this.Impressions = impressions;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Notification = notification;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Type = type;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Impressions
        /// </summary>
        [DataMember(Name = "impressions", IsRequired = true, EmitDefaultValue = true)]
        public int Impressions { get; set; }

        /// <summary>
        /// Gets or Sets Notification
        /// </summary>
        [DataMember(Name = "notification", IsRequired = true, EmitDefaultValue = true)]
        public InfoPushDataPromotionNotification Notification { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InfoPushDataPromotion {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Impressions: ").Append(Impressions).Append("\n");
            sb.Append("  Notification: ").Append(Notification).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as InfoPushDataPromotion);
        }

        /// <summary>
        /// Returns true if InfoPushDataPromotion instances are equal
        /// </summary>
        /// <param name="input">Instance of InfoPushDataPromotion to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InfoPushDataPromotion input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Impressions == input.Impressions ||
                    this.Impressions.Equals(input.Impressions)
                ) && 
                (
                    this.Notification == input.Notification ||
                    (this.Notification != null &&
                    this.Notification.Equals(input.Notification))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Impressions.GetHashCode();
                if (this.Notification != null)
                {
                    hashCode = (hashCode * 59) + this.Notification.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
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
