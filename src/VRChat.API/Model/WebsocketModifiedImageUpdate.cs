

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
    /// WebsocketModifiedImageUpdate
    /// </summary>
    [DataContract(Name = "WebsocketModifiedImageUpdate")]
    public partial class WebsocketModifiedImageUpdate : IEquatable<WebsocketModifiedImageUpdate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebsocketModifiedImageUpdate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WebsocketModifiedImageUpdate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebsocketModifiedImageUpdate" /> class.
        /// </summary>
        /// <param name="fileId">fileId (required).</param>
        /// <param name="needsProcessing">needsProcessing (required).</param>
        /// <param name="pixelSize">pixelSize (required).</param>
        /// <param name="versionNumber">versionNumber (required).</param>
        public WebsocketModifiedImageUpdate(string fileId = default, bool needsProcessing = default, decimal pixelSize = default, decimal versionNumber = default)
        {
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.FileId = fileId;
            this.NeedsProcessing = needsProcessing;
            this.PixelSize = pixelSize;
            this.VersionNumber = versionNumber;
        }

        /// <summary>
        /// Gets or Sets FileId
        /// </summary>
        [DataMember(Name = "fileId", IsRequired = true, EmitDefaultValue = true)]
        public string FileId { get; set; }

        /// <summary>
        /// Gets or Sets NeedsProcessing
        /// </summary>
        [DataMember(Name = "needsProcessing", IsRequired = true, EmitDefaultValue = true)]
        public bool NeedsProcessing { get; set; }

        /// <summary>
        /// Gets or Sets PixelSize
        /// </summary>
        [DataMember(Name = "pixelSize", IsRequired = true, EmitDefaultValue = true)]
        public decimal PixelSize { get; set; }

        /// <summary>
        /// Gets or Sets VersionNumber
        /// </summary>
        [DataMember(Name = "versionNumber", IsRequired = true, EmitDefaultValue = true)]
        public decimal VersionNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WebsocketModifiedImageUpdate {\n");
            sb.Append("  FileId: ").Append(FileId).Append("\n");
            sb.Append("  NeedsProcessing: ").Append(NeedsProcessing).Append("\n");
            sb.Append("  PixelSize: ").Append(PixelSize).Append("\n");
            sb.Append("  VersionNumber: ").Append(VersionNumber).Append("\n");
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
            return this.Equals(input as WebsocketModifiedImageUpdate);
        }

        /// <summary>
        /// Returns true if WebsocketModifiedImageUpdate instances are equal
        /// </summary>
        /// <param name="input">Instance of WebsocketModifiedImageUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebsocketModifiedImageUpdate input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.FileId == input.FileId ||
                    (this.FileId != null &&
                    this.FileId.Equals(input.FileId))
                ) && 
                (
                    this.NeedsProcessing == input.NeedsProcessing ||
                    this.NeedsProcessing.Equals(input.NeedsProcessing)
                ) && 
                (
                    this.PixelSize == input.PixelSize ||
                    this.PixelSize.Equals(input.PixelSize)
                ) && 
                (
                    this.VersionNumber == input.VersionNumber ||
                    this.VersionNumber.Equals(input.VersionNumber)
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
                if (this.FileId != null)
                {
                    hashCode = (hashCode * 59) + this.FileId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.NeedsProcessing.GetHashCode();
                hashCode = (hashCode * 59) + this.PixelSize.GetHashCode();
                hashCode = (hashCode * 59) + this.VersionNumber.GetHashCode();
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
