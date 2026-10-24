

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
    /// InfoPushDataClickable
    /// </summary>
    [DataContract(Name = "InfoPushDataClickable")]
    public partial class InfoPushDataClickable : IEquatable<InfoPushDataClickable>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Command
        /// </summary>
        [DataMember(Name = "command", IsRequired = true, EmitDefaultValue = true)]
        public InfoPushCommand Command { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InfoPushDataClickable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InfoPushDataClickable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InfoPushDataClickable" /> class.
        /// </summary>
        /// <param name="parameters">In case of OpenURL, this would contain the link..</param>
        /// <param name="command">command (required).</param>
        public InfoPushDataClickable(List<string> parameters = default, InfoPushCommand command = default)
        {
            this.Command = command;
            this.Parameters = parameters;
        }

        /// <summary>
        /// In case of OpenURL, this would contain the link.
        /// </summary>
        /// <value>In case of OpenURL, this would contain the link.</value>
        [DataMember(Name = "parameters", EmitDefaultValue = false)]
        public List<string> Parameters { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InfoPushDataClickable {\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
            sb.Append("  Command: ").Append(Command).Append("\n");
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
            return this.Equals(input as InfoPushDataClickable);
        }

        /// <summary>
        /// Returns true if InfoPushDataClickable instances are equal
        /// </summary>
        /// <param name="input">Instance of InfoPushDataClickable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InfoPushDataClickable input)
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
                    this.Command.Equals(input.Command)
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
                hashCode = (hashCode * 59) + this.Command.GetHashCode();
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
