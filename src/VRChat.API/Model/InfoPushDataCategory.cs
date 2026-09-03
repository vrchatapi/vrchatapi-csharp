

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
    /// InfoPushDataCategory
    /// </summary>
    [DataContract(Name = "InfoPushDataCategory")]
    public partial class InfoPushDataCategory : IEquatable<InfoPushDataCategory>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InfoPushDataCategory" /> class.
        /// </summary>
        /// <param name="ids">ids.</param>
        /// <param name="ipsQuery">ipsQuery.</param>
        /// <param name="maxCells">maxCells.</param>
        /// <param name="name">name.</param>
        /// <param name="type">type.</param>
        public InfoPushDataCategory(List<string> ids = default, InfoPushIpsQuery ipsQuery = default, int maxCells = default, string name = default, string type = default)
        {
            this.Ids = ids;
            this.IpsQuery = ipsQuery;
            this.MaxCells = maxCells;
            this.Name = name;
            this.Type = type;
        }

        /// <summary>
        /// Gets or Sets Ids
        /// </summary>
        [DataMember(Name = "ids", EmitDefaultValue = false)]
        public List<string> Ids { get; set; }

        /// <summary>
        /// Gets or Sets IpsQuery
        /// </summary>
        [DataMember(Name = "ipsQuery", EmitDefaultValue = false)]
        public InfoPushIpsQuery IpsQuery { get; set; }

        /// <summary>
        /// Gets or Sets MaxCells
        /// </summary>
        [DataMember(Name = "maxCells", EmitDefaultValue = false)]
        public int MaxCells { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InfoPushDataCategory {\n");
            sb.Append("  Ids: ").Append(Ids).Append("\n");
            sb.Append("  IpsQuery: ").Append(IpsQuery).Append("\n");
            sb.Append("  MaxCells: ").Append(MaxCells).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as InfoPushDataCategory);
        }

        /// <summary>
        /// Returns true if InfoPushDataCategory instances are equal
        /// </summary>
        /// <param name="input">Instance of InfoPushDataCategory to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InfoPushDataCategory input)
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
                    this.IpsQuery == input.IpsQuery ||
                    (this.IpsQuery != null &&
                    this.IpsQuery.Equals(input.IpsQuery))
                ) && 
                (
                    this.MaxCells == input.MaxCells ||
                    this.MaxCells.Equals(input.MaxCells)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.IpsQuery != null)
                {
                    hashCode = (hashCode * 59) + this.IpsQuery.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.MaxCells.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
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
