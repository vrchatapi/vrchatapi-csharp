/*
 * VRChat API Documentation
 *
 *
 * The version of the OpenAPI document: 1.9.1
 * Contact: me@ariesclark.com
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
    /// Public Announcement
    /// </summary>
    [DataContract(Name = "Public_Announcement")]
    public partial class PublicAnnouncement : IEquatable<PublicAnnouncement>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PublicAnnouncement" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PublicAnnouncement() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PublicAnnouncement" /> class.
        /// </summary>
        /// <param name="name">Announcement name (required).</param>
        /// <param name="text">Announcement text (required).</param>
        public PublicAnnouncement(string name = default(string), string text = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for PublicAnnouncement and cannot be null");
            }
            this.Name = name;
            // to ensure "text" is required (not null)
            if (text == null)
            {
                throw new ArgumentNullException("text is a required property for PublicAnnouncement and cannot be null");
            }
            this.Text = text;
        }

        /// <summary>
        /// Announcement name
        /// </summary>
        /// <value>Announcement name</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Announcement text
        /// </summary>
        /// <value>Announcement text</value>
        [DataMember(Name = "text", IsRequired = true, EmitDefaultValue = true)]
        public string Text { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PublicAnnouncement {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
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
            return this.Equals(input as PublicAnnouncement);
        }

        /// <summary>
        /// Returns true if PublicAnnouncement instances are equal
        /// </summary>
        /// <param name="input">Instance of PublicAnnouncement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PublicAnnouncement input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Text != null)
                {
                    hashCode = (hashCode * 59) + this.Text.GetHashCode();
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
            // Name (string) minLength
            if (this.Name != null && this.Name.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
            }

            // Text (string) minLength
            if (this.Text != null && this.Text.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Text, length must be greater than 1.", new [] { "Text" });
            }

            yield break;
        }
    }

}
