

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
    /// A vibe an instance can be tagged with.
    /// </summary>
    [DataContract(Name = "InstanceVibe")]
    public partial class InstanceVibe : IEquatable<InstanceVibe>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InstanceVibe" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InstanceVibe() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InstanceVibe" /> class.
        /// </summary>
        /// <param name="deleted">deleted (required).</param>
        /// <param name="id">id (required).</param>
        /// <param name="title">title (required).</param>
        public InstanceVibe(bool deleted = default, string id = default, string title = default)
        {
            this.Deleted = deleted;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Id = id;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Title = title;
        }

        /// <summary>
        /// Gets or Sets Deleted
        /// </summary>
        [DataMember(Name = "deleted", IsRequired = true, EmitDefaultValue = true)]
        public bool Deleted { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        /*
        <example>ivib_2d8445c4-f47b-4635-b565-467fc32c4003</example>
        */
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        /*
        <example>adventure</example>
        */
        [DataMember(Name = "title", IsRequired = true, EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InstanceVibe {\n");
            sb.Append("  Deleted: ").Append(Deleted).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(input as InstanceVibe);
        }

        /// <summary>
        /// Returns true if InstanceVibe instances are equal
        /// </summary>
        /// <param name="input">Instance of InstanceVibe to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InstanceVibe input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Deleted == input.Deleted ||
                    this.Deleted.Equals(input.Deleted)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                hashCode = (hashCode * 59) + this.Deleted.GetHashCode();
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
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
