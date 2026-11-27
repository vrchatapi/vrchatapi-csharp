

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
    /// HypeTrainLevel
    /// </summary>
    [DataContract(Name = "HypeTrainLevel")]
    public partial class HypeTrainLevel : IEquatable<HypeTrainLevel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HypeTrainLevel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected HypeTrainLevel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="HypeTrainLevel" /> class.
        /// </summary>
        /// <param name="giftsNeededToUnlock">giftsNeededToUnlock (required).</param>
        /// <param name="level">level (required).</param>
        /// <param name="reached">reached (required).</param>
        public HypeTrainLevel(int giftsNeededToUnlock = default, int level = default, bool reached = default)
        {
            this.GiftsNeededToUnlock = giftsNeededToUnlock;
            this.Level = level;
            this.Reached = reached;
        }

        /// <summary>
        /// Gets or Sets GiftsNeededToUnlock
        /// </summary>
        [DataMember(Name = "giftsNeededToUnlock", IsRequired = true, EmitDefaultValue = true)]
        public int GiftsNeededToUnlock { get; set; }

        /// <summary>
        /// Gets or Sets Level
        /// </summary>
        [DataMember(Name = "level", IsRequired = true, EmitDefaultValue = true)]
        public int Level { get; set; }

        /// <summary>
        /// Gets or Sets Reached
        /// </summary>
        [DataMember(Name = "reached", IsRequired = true, EmitDefaultValue = true)]
        public bool Reached { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class HypeTrainLevel {\n");
            sb.Append("  GiftsNeededToUnlock: ").Append(GiftsNeededToUnlock).Append("\n");
            sb.Append("  Level: ").Append(Level).Append("\n");
            sb.Append("  Reached: ").Append(Reached).Append("\n");
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
            return this.Equals(input as HypeTrainLevel);
        }

        /// <summary>
        /// Returns true if HypeTrainLevel instances are equal
        /// </summary>
        /// <param name="input">Instance of HypeTrainLevel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HypeTrainLevel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.GiftsNeededToUnlock == input.GiftsNeededToUnlock ||
                    this.GiftsNeededToUnlock.Equals(input.GiftsNeededToUnlock)
                ) && 
                (
                    this.Level == input.Level ||
                    this.Level.Equals(input.Level)
                ) && 
                (
                    this.Reached == input.Reached ||
                    this.Reached.Equals(input.Reached)
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
                hashCode = (hashCode * 59) + this.GiftsNeededToUnlock.GetHashCode();
                hashCode = (hashCode * 59) + this.Level.GetHashCode();
                hashCode = (hashCode * 59) + this.Reached.GetHashCode();
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
