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
    /// File
    /// </summary>
    [DataContract(Name = "File")]
    public partial class File : IEquatable<File>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets MimeType
        /// </summary>
        [DataMember(Name = "mimeType", IsRequired = true, EmitDefaultValue = true)]
        public MIMEType MimeType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="File" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected File() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="File" /> class.
        /// </summary>
        /// <param name="animationStyle">animationStyle.</param>
        /// <param name="maskTag">maskTag.</param>
        /// <param name="extension">extension (required).</param>
        /// <param name="id">id (required).</param>
        /// <param name="mimeType">mimeType (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="ownerId">A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed. (required).</param>
        /// <param name="tags">  (required).</param>
        /// <param name="versions">  (required).</param>
        public File(string animationStyle = default(string), string maskTag = default(string), string extension = default(string), string id = default(string), MIMEType mimeType = default(MIMEType), string name = default(string), string ownerId = default(string), List<string> tags = default(List<string>), List<FileVersion> versions = default(List<FileVersion>))
        {
            // to ensure "extension" is required (not null)
            if (extension == null)
            {
                throw new ArgumentNullException("extension is a required property for File and cannot be null");
            }
            this.Extension = extension;
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for File and cannot be null");
            }
            this.Id = id;
            this.MimeType = mimeType;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for File and cannot be null");
            }
            this.Name = name;
            // to ensure "ownerId" is required (not null)
            if (ownerId == null)
            {
                throw new ArgumentNullException("ownerId is a required property for File and cannot be null");
            }
            this.OwnerId = ownerId;
            // to ensure "tags" is required (not null)
            if (tags == null)
            {
                throw new ArgumentNullException("tags is a required property for File and cannot be null");
            }
            this.Tags = tags;
            // to ensure "versions" is required (not null)
            if (versions == null)
            {
                throw new ArgumentNullException("versions is a required property for File and cannot be null");
            }
            this.Versions = versions;
            this.AnimationStyle = animationStyle;
            this.MaskTag = maskTag;
        }

        /// <summary>
        /// Gets or Sets AnimationStyle
        /// </summary>
        [DataMember(Name = "animationStyle", EmitDefaultValue = false)]
        public string AnimationStyle { get; set; }

        /// <summary>
        /// Gets or Sets MaskTag
        /// </summary>
        [DataMember(Name = "maskTag", EmitDefaultValue = false)]
        public string MaskTag { get; set; }

        /// <summary>
        /// Gets or Sets Extension
        /// </summary>
        [DataMember(Name = "extension", IsRequired = true, EmitDefaultValue = true)]
        public string Extension { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed.
        /// </summary>
        /// <value>A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed.</value>
        [DataMember(Name = "ownerId", IsRequired = true, EmitDefaultValue = true)]
        public string OwnerId { get; set; }

        /// <summary>
        ///  
        /// </summary>
        /// <value> </value>
        [DataMember(Name = "tags", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Tags { get; set; }

        /// <summary>
        ///  
        /// </summary>
        /// <value> </value>
        [DataMember(Name = "versions", IsRequired = true, EmitDefaultValue = true)]
        public List<FileVersion> Versions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class File {\n");
            sb.Append("  AnimationStyle: ").Append(AnimationStyle).Append("\n");
            sb.Append("  MaskTag: ").Append(MaskTag).Append("\n");
            sb.Append("  Extension: ").Append(Extension).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  MimeType: ").Append(MimeType).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OwnerId: ").Append(OwnerId).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Versions: ").Append(Versions).Append("\n");
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
            return this.Equals(input as File);
        }

        /// <summary>
        /// Returns true if File instances are equal
        /// </summary>
        /// <param name="input">Instance of File to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(File input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AnimationStyle == input.AnimationStyle ||
                    (this.AnimationStyle != null &&
                    this.AnimationStyle.Equals(input.AnimationStyle))
                ) && 
                (
                    this.MaskTag == input.MaskTag ||
                    (this.MaskTag != null &&
                    this.MaskTag.Equals(input.MaskTag))
                ) && 
                (
                    this.Extension == input.Extension ||
                    (this.Extension != null &&
                    this.Extension.Equals(input.Extension))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.MimeType == input.MimeType ||
                    this.MimeType.Equals(input.MimeType)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.OwnerId == input.OwnerId ||
                    (this.OwnerId != null &&
                    this.OwnerId.Equals(input.OwnerId))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.Versions == input.Versions ||
                    this.Versions != null &&
                    input.Versions != null &&
                    this.Versions.SequenceEqual(input.Versions)
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
                if (this.AnimationStyle != null)
                {
                    hashCode = (hashCode * 59) + this.AnimationStyle.GetHashCode();
                }
                if (this.MaskTag != null)
                {
                    hashCode = (hashCode * 59) + this.MaskTag.GetHashCode();
                }
                if (this.Extension != null)
                {
                    hashCode = (hashCode * 59) + this.Extension.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.MimeType.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.OwnerId != null)
                {
                    hashCode = (hashCode * 59) + this.OwnerId.GetHashCode();
                }
                if (this.Tags != null)
                {
                    hashCode = (hashCode * 59) + this.Tags.GetHashCode();
                }
                if (this.Versions != null)
                {
                    hashCode = (hashCode * 59) + this.Versions.GetHashCode();
                }
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
            // Extension (string) minLength
            if (this.Extension != null && this.Extension.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Extension, length must be greater than 1.", new [] { "Extension" });
            }

            // Name (string) minLength
            if (this.Name != null && this.Name.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 0.", new [] { "Name" });
            }

            yield break;
        }
    }

}
