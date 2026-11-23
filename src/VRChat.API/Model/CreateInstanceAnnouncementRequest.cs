

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
    /// CreateInstanceAnnouncementRequest
    /// </summary>
    [DataContract(Name = "CreateInstanceAnnouncementRequest")]
    public partial class CreateInstanceAnnouncementRequest : IEquatable<CreateInstanceAnnouncementRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateInstanceAnnouncementRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateInstanceAnnouncementRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateInstanceAnnouncementRequest" /> class.
        /// </summary>
        /// <param name="imageId">imageId.</param>
        /// <param name="imageVersion">imageVersion.</param>
        /// <param name="message">message (required).</param>
        /// <param name="title">title (required).</param>
        public CreateInstanceAnnouncementRequest(string imageId = default, int imageVersion = default, string message = default, string title = default)
        {
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Message = message;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Title = title;
            this.ImageId = imageId;
            this.ImageVersion = imageVersion;
        }

        /// <summary>
        /// Gets or Sets ImageId
        /// </summary>
        [DataMember(Name = "imageId", EmitDefaultValue = false)]
        public string ImageId { get; set; }

        /// <summary>
        /// Gets or Sets ImageVersion
        /// </summary>
        [DataMember(Name = "imageVersion", EmitDefaultValue = false)]
        public int ImageVersion { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name = "message", IsRequired = true, EmitDefaultValue = true)]
        public string Message { get; set; }

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
            sb.Append("class CreateInstanceAnnouncementRequest {\n");
            sb.Append("  ImageId: ").Append(ImageId).Append("\n");
            sb.Append("  ImageVersion: ").Append(ImageVersion).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
            return this.Equals(input as CreateInstanceAnnouncementRequest);
        }

        /// <summary>
        /// Returns true if CreateInstanceAnnouncementRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateInstanceAnnouncementRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateInstanceAnnouncementRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ImageId == input.ImageId ||
                    (this.ImageId != null &&
                    this.ImageId.Equals(input.ImageId))
                ) && 
                (
                    this.ImageVersion == input.ImageVersion ||
                    this.ImageVersion.Equals(input.ImageVersion)
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
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
                if (this.ImageId != null)
                {
                    hashCode = (hashCode * 59) + this.ImageId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ImageVersion.GetHashCode();
                if (this.Message != null)
                {
                    hashCode = (hashCode * 59) + this.Message.GetHashCode();
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
