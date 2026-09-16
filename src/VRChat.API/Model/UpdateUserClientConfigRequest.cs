

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
    /// Only the settings named are changed.
    /// </summary>
    [DataContract(Name = "UpdateUserClientConfigRequest")]
    public partial class UpdateUserClientConfigRequest : IEquatable<UpdateUserClientConfigRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateUserClientConfigRequest" /> class.
        /// </summary>
        /// <param name="accessReduceDecorAnim">accessReduceDecorAnim.</param>
        public UpdateUserClientConfigRequest(bool accessReduceDecorAnim = default)
        {
            this.AccessReduceDecorAnim = accessReduceDecorAnim;
        }

        /// <summary>
        /// Gets or Sets AccessReduceDecorAnim
        /// </summary>
        [DataMember(Name = "accessReduceDecorAnim", EmitDefaultValue = true)]
        public bool AccessReduceDecorAnim { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdateUserClientConfigRequest {\n");
            sb.Append("  AccessReduceDecorAnim: ").Append(AccessReduceDecorAnim).Append("\n");
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
            return this.Equals(input as UpdateUserClientConfigRequest);
        }

        /// <summary>
        /// Returns true if UpdateUserClientConfigRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateUserClientConfigRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateUserClientConfigRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccessReduceDecorAnim == input.AccessReduceDecorAnim ||
                    this.AccessReduceDecorAnim.Equals(input.AccessReduceDecorAnim)
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
                hashCode = (hashCode * 59) + this.AccessReduceDecorAnim.GetHashCode();
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
