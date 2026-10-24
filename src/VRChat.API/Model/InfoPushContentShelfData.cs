

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
    /// InfoPushContentShelfData
    /// </summary>
    [DataContract(Name = "InfoPushContentShelfData")]
    public partial class InfoPushContentShelfData : IEquatable<InfoPushContentShelfData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InfoPushContentShelfData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InfoPushContentShelfData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InfoPushContentShelfData" /> class.
        /// </summary>
        /// <param name="contentSource">contentSource (required).</param>
        /// <param name="controls">controls (required).</param>
        /// <param name="imageUrl">imageUrl (required).</param>
        /// <param name="onPressed">onPressed (required).</param>
        /// <param name="presentation">presentation (required).</param>
        /// <param name="schemaVersion">schemaVersion (required).</param>
        /// <param name="subtitle">subtitle (required).</param>
        /// <param name="thumbnailImageUrl">thumbnailImageUrl (required).</param>
        /// <param name="title">title (required).</param>
        public InfoPushContentShelfData(InfoPushDataContentSource contentSource = default, List<InfoPushDataControl> controls = default, string imageUrl = default, InfoPushDataClickable onPressed = default, InfoPushDataPresentation presentation = default, int schemaVersion = default, string subtitle = default, string thumbnailImageUrl = default, string title = default)
        {
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.ContentSource = contentSource;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Controls = controls;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.ImageUrl = imageUrl;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.OnPressed = onPressed;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Presentation = presentation;
            this.SchemaVersion = schemaVersion;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Subtitle = subtitle;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.ThumbnailImageUrl = thumbnailImageUrl;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Title = title;
        }

        /// <summary>
        /// Gets or Sets ContentSource
        /// </summary>
        [DataMember(Name = "contentSource", IsRequired = true, EmitDefaultValue = true)]
        public InfoPushDataContentSource ContentSource { get; set; }

        /// <summary>
        /// Gets or Sets Controls
        /// </summary>
        [DataMember(Name = "controls", IsRequired = true, EmitDefaultValue = true)]
        public List<InfoPushDataControl> Controls { get; set; }

        /// <summary>
        /// Gets or Sets ImageUrl
        /// </summary>
        [DataMember(Name = "imageUrl", IsRequired = true, EmitDefaultValue = true)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// Gets or Sets OnPressed
        /// </summary>
        [DataMember(Name = "onPressed", IsRequired = true, EmitDefaultValue = true)]
        public InfoPushDataClickable OnPressed { get; set; }

        /// <summary>
        /// Gets or Sets Presentation
        /// </summary>
        [DataMember(Name = "presentation", IsRequired = true, EmitDefaultValue = true)]
        public InfoPushDataPresentation Presentation { get; set; }

        /// <summary>
        /// Gets or Sets SchemaVersion
        /// </summary>
        [DataMember(Name = "schemaVersion", IsRequired = true, EmitDefaultValue = true)]
        public int SchemaVersion { get; set; }

        /// <summary>
        /// Gets or Sets Subtitle
        /// </summary>
        [DataMember(Name = "subtitle", IsRequired = true, EmitDefaultValue = true)]
        public string Subtitle { get; set; }

        /// <summary>
        /// Gets or Sets ThumbnailImageUrl
        /// </summary>
        [DataMember(Name = "thumbnailImageUrl", IsRequired = true, EmitDefaultValue = true)]
        public string ThumbnailImageUrl { get; set; }

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
            sb.Append("class InfoPushContentShelfData {\n");
            sb.Append("  ContentSource: ").Append(ContentSource).Append("\n");
            sb.Append("  Controls: ").Append(Controls).Append("\n");
            sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("  OnPressed: ").Append(OnPressed).Append("\n");
            sb.Append("  Presentation: ").Append(Presentation).Append("\n");
            sb.Append("  SchemaVersion: ").Append(SchemaVersion).Append("\n");
            sb.Append("  Subtitle: ").Append(Subtitle).Append("\n");
            sb.Append("  ThumbnailImageUrl: ").Append(ThumbnailImageUrl).Append("\n");
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
            return this.Equals(input as InfoPushContentShelfData);
        }

        /// <summary>
        /// Returns true if InfoPushContentShelfData instances are equal
        /// </summary>
        /// <param name="input">Instance of InfoPushContentShelfData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InfoPushContentShelfData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ContentSource == input.ContentSource ||
                    (this.ContentSource != null &&
                    this.ContentSource.Equals(input.ContentSource))
                ) && 
                (
                    this.Controls == input.Controls ||
                    this.Controls != null &&
                    input.Controls != null &&
                    this.Controls.SequenceEqual(input.Controls)
                ) && 
                (
                    this.ImageUrl == input.ImageUrl ||
                    (this.ImageUrl != null &&
                    this.ImageUrl.Equals(input.ImageUrl))
                ) && 
                (
                    this.OnPressed == input.OnPressed ||
                    (this.OnPressed != null &&
                    this.OnPressed.Equals(input.OnPressed))
                ) && 
                (
                    this.Presentation == input.Presentation ||
                    (this.Presentation != null &&
                    this.Presentation.Equals(input.Presentation))
                ) && 
                (
                    this.SchemaVersion == input.SchemaVersion ||
                    this.SchemaVersion.Equals(input.SchemaVersion)
                ) && 
                (
                    this.Subtitle == input.Subtitle ||
                    (this.Subtitle != null &&
                    this.Subtitle.Equals(input.Subtitle))
                ) && 
                (
                    this.ThumbnailImageUrl == input.ThumbnailImageUrl ||
                    (this.ThumbnailImageUrl != null &&
                    this.ThumbnailImageUrl.Equals(input.ThumbnailImageUrl))
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
                if (this.ContentSource != null)
                {
                    hashCode = (hashCode * 59) + this.ContentSource.GetHashCode();
                }
                if (this.Controls != null)
                {
                    hashCode = (hashCode * 59) + this.Controls.GetHashCode();
                }
                if (this.ImageUrl != null)
                {
                    hashCode = (hashCode * 59) + this.ImageUrl.GetHashCode();
                }
                if (this.OnPressed != null)
                {
                    hashCode = (hashCode * 59) + this.OnPressed.GetHashCode();
                }
                if (this.Presentation != null)
                {
                    hashCode = (hashCode * 59) + this.Presentation.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SchemaVersion.GetHashCode();
                if (this.Subtitle != null)
                {
                    hashCode = (hashCode * 59) + this.Subtitle.GetHashCode();
                }
                if (this.ThumbnailImageUrl != null)
                {
                    hashCode = (hashCode * 59) + this.ThumbnailImageUrl.GetHashCode();
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
