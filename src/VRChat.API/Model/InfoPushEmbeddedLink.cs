

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
    /// InfoPushEmbeddedLink
    /// </summary>
    [DataContract(Name = "InfoPushEmbeddedLink")]
    public partial class InfoPushEmbeddedLink : IEquatable<InfoPushEmbeddedLink>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InfoPushEmbeddedLink" /> class.
        /// </summary>
        /// <param name="parameters">parameters.</param>
        /// <param name="command">command.</param>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        public InfoPushEmbeddedLink(List<string> parameters = default, string command = default, string id = default, string name = default)
        {
            this.Parameters = parameters;
            this.Command = command;
            this.Id = id;
            this.Name = name;
        }

        /// <summary>
        /// Gets or Sets Parameters
        /// </summary>
        [DataMember(Name = "parameters", EmitDefaultValue = false)]
        public List<string> Parameters { get; set; }

        /// <summary>
        /// Gets or Sets Command
        /// </summary>
        [DataMember(Name = "command", EmitDefaultValue = false)]
        public string Command { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InfoPushEmbeddedLink {\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
            sb.Append("  Command: ").Append(Command).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as InfoPushEmbeddedLink);
        }

        /// <summary>
        /// Returns true if InfoPushEmbeddedLink instances are equal
        /// </summary>
        /// <param name="input">Instance of InfoPushEmbeddedLink to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InfoPushEmbeddedLink input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Parameters == input.Parameters ||
                    this.Parameters != null &&
                    input.Parameters != null &&
                    this.Parameters.SequenceEqual(input.Parameters)
                ) && 
                (
                    this.Command == input.Command ||
                    (this.Command != null &&
                    this.Command.Equals(input.Command))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.Parameters != null)
                {
                    hashCode = (hashCode * 59) + this.Parameters.GetHashCode();
                }
                if (this.Command != null)
                {
                    hashCode = (hashCode * 59) + this.Command.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
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
