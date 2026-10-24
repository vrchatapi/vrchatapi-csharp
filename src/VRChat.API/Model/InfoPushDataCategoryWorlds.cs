

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
    /// InfoPushDataCategoryWorlds
    /// </summary>
    [DataContract(Name = "InfoPushDataCategoryWorlds")]
    public partial class InfoPushDataCategoryWorlds : IEquatable<InfoPushDataCategoryWorlds>, IValidatableObject
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Worlds for value: worlds
            /// </summary>
            [EnumMember(Value = "worlds")]
            Worlds = 1
        }


        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InfoPushDataCategoryWorlds" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InfoPushDataCategoryWorlds() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InfoPushDataCategoryWorlds" /> class.
        /// </summary>
        /// <param name="ids">ids (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="maxCells">maxCells (required).</param>
        /// <param name="type">type (required).</param>
        public InfoPushDataCategoryWorlds(List<string> ids = default, LocalizableString name = default, int maxCells = default, TypeEnum type = default)
        {
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Ids = ids;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Name = name;
            this.MaxCells = maxCells;
            this.Type = type;
        }

        /// <summary>
        /// Gets or Sets Ids
        /// </summary>
        [DataMember(Name = "ids", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Ids { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public LocalizableString Name { get; set; }

        /// <summary>
        /// Gets or Sets MaxCells
        /// </summary>
        [DataMember(Name = "maxCells", IsRequired = true, EmitDefaultValue = true)]
        public int MaxCells { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InfoPushDataCategoryWorlds {\n");
            sb.Append("  Ids: ").Append(Ids).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  MaxCells: ").Append(MaxCells).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as InfoPushDataCategoryWorlds);
        }

        /// <summary>
        /// Returns true if InfoPushDataCategoryWorlds instances are equal
        /// </summary>
        /// <param name="input">Instance of InfoPushDataCategoryWorlds to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InfoPushDataCategoryWorlds input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Ids == input.Ids ||
                    this.Ids != null &&
                    input.Ids != null &&
                    this.Ids.SequenceEqual(input.Ids)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.MaxCells == input.MaxCells ||
                    this.MaxCells.Equals(input.MaxCells)
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
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
                if (this.Ids != null)
                {
                    hashCode = (hashCode * 59) + this.Ids.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.MaxCells.GetHashCode();
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
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
