

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
    /// InfoPushDataPromotionNotification
    /// </summary>
    [DataContract(Name = "InfoPushDataPromotionNotification")]
    public partial class InfoPushDataPromotionNotification : IEquatable<InfoPushDataPromotionNotification>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InfoPushDataPromotionNotification" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InfoPushDataPromotionNotification() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InfoPushDataPromotionNotification" /> class.
        /// </summary>
        /// <param name="body">body (required).</param>
        /// <param name="command">command (required).</param>
        /// <param name="imageUrl">imageUrl (required).</param>
        /// <param name="varParameter">varParameter (required).</param>
        /// <param name="title">title (required).</param>
        public InfoPushDataPromotionNotification(string body = default, string command = default, string imageUrl = default, string varParameter = default, string title = default)
        {
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Body = body;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Command = command;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.ImageUrl = imageUrl;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Parameter = varParameter;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Title = title;
        }

        /// <summary>
        /// Gets or Sets Body
        /// </summary>
        [DataMember(Name = "body", IsRequired = true, EmitDefaultValue = true)]
        public string Body { get; set; }

        /// <summary>
        /// Gets or Sets Command
        /// </summary>
        [DataMember(Name = "command", IsRequired = true, EmitDefaultValue = true)]
        public string Command { get; set; }

        /// <summary>
        /// Gets or Sets ImageUrl
        /// </summary>
        [DataMember(Name = "imageUrl", IsRequired = true, EmitDefaultValue = true)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// Gets or Sets Parameter
        /// </summary>
        [DataMember(Name = "parameter", IsRequired = true, EmitDefaultValue = true)]
        public string Parameter { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", IsRequired = true, EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InfoPushDataPromotionNotification {\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  Command: ").Append(Command).Append("\n");
            sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("  Parameter: ").Append(Parameter).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
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
            return this.Equals(input as InfoPushDataPromotionNotification);
        }

        /// <summary>
        /// Returns true if InfoPushDataPromotionNotification instances are equal
        /// </summary>
        /// <param name="input">Instance of InfoPushDataPromotionNotification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InfoPushDataPromotionNotification input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
                ) && 
                (
                    this.Command == input.Command ||
                    (this.Command != null &&
                    this.Command.Equals(input.Command))
                ) && 
                (
                    this.ImageUrl == input.ImageUrl ||
                    (this.ImageUrl != null &&
                    this.ImageUrl.Equals(input.ImageUrl))
                ) && 
                (
                    this.Parameter == input.Parameter ||
                    (this.Parameter != null &&
                    this.Parameter.Equals(input.Parameter))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
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
                if (this.Body != null)
                {
                    hashCode = (hashCode * 59) + this.Body.GetHashCode();
                }
                if (this.Command != null)
                {
                    hashCode = (hashCode * 59) + this.Command.GetHashCode();
                }
                if (this.ImageUrl != null)
                {
                    hashCode = (hashCode * 59) + this.ImageUrl.GetHashCode();
                }
                if (this.Parameter != null)
                {
                    hashCode = (hashCode * 59) + this.Parameter.GetHashCode();
                }
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
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
