

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
    /// InfoPushDataContentSourcePagination
    /// </summary>
    [DataContract(Name = "InfoPushDataContentSourcePagination")]
    public partial class InfoPushDataContentSourcePagination : IEquatable<InfoPushDataContentSourcePagination>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InfoPushDataContentSourcePagination" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InfoPushDataContentSourcePagination() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InfoPushDataContentSourcePagination" /> class.
        /// </summary>
        /// <param name="cursorParam">cursorParam (required).</param>
        /// <param name="cursorResponseField">cursorResponseField (required).</param>
        /// <param name="pageSize">pageSize (required).</param>
        /// <param name="pageSizeParam">pageSizeParam (required).</param>
        /// <param name="style">style (required).</param>
        public InfoPushDataContentSourcePagination(string cursorParam = default, string cursorResponseField = default, int pageSize = default, string pageSizeParam = default, string style = default)
        {
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.CursorParam = cursorParam;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.CursorResponseField = cursorResponseField;
            this.PageSize = pageSize;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.PageSizeParam = pageSizeParam;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Style = style;
        }

        /// <summary>
        /// Gets or Sets CursorParam
        /// </summary>
        /*
        <example>nextCursor</example>
        */
        [DataMember(Name = "cursorParam", IsRequired = true, EmitDefaultValue = true)]
        public string CursorParam { get; set; }

        /// <summary>
        /// Gets or Sets CursorResponseField
        /// </summary>
        /*
        <example>nextCursor</example>
        */
        [DataMember(Name = "cursorResponseField", IsRequired = true, EmitDefaultValue = true)]
        public string CursorResponseField { get; set; }

        /// <summary>
        /// Gets or Sets PageSize
        /// </summary>
        /*
        <example>50</example>
        */
        [DataMember(Name = "pageSize", IsRequired = true, EmitDefaultValue = true)]
        public int PageSize { get; set; }

        /// <summary>
        /// Gets or Sets PageSizeParam
        /// </summary>
        /*
        <example>n</example>
        */
        [DataMember(Name = "pageSizeParam", IsRequired = true, EmitDefaultValue = true)]
        public string PageSizeParam { get; set; }

        /// <summary>
        /// Gets or Sets Style
        /// </summary>
        /*
        <example>cursor</example>
        */
        [DataMember(Name = "style", IsRequired = true, EmitDefaultValue = true)]
        public string Style { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InfoPushDataContentSourcePagination {\n");
            sb.Append("  CursorParam: ").Append(CursorParam).Append("\n");
            sb.Append("  CursorResponseField: ").Append(CursorResponseField).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  PageSizeParam: ").Append(PageSizeParam).Append("\n");
            sb.Append("  Style: ").Append(Style).Append("\n");
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
            return this.Equals(input as InfoPushDataContentSourcePagination);
        }

        /// <summary>
        /// Returns true if InfoPushDataContentSourcePagination instances are equal
        /// </summary>
        /// <param name="input">Instance of InfoPushDataContentSourcePagination to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InfoPushDataContentSourcePagination input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CursorParam == input.CursorParam ||
                    (this.CursorParam != null &&
                    this.CursorParam.Equals(input.CursorParam))
                ) && 
                (
                    this.CursorResponseField == input.CursorResponseField ||
                    (this.CursorResponseField != null &&
                    this.CursorResponseField.Equals(input.CursorResponseField))
                ) && 
                (
                    this.PageSize == input.PageSize ||
                    this.PageSize.Equals(input.PageSize)
                ) && 
                (
                    this.PageSizeParam == input.PageSizeParam ||
                    (this.PageSizeParam != null &&
                    this.PageSizeParam.Equals(input.PageSizeParam))
                ) && 
                (
                    this.Style == input.Style ||
                    (this.Style != null &&
                    this.Style.Equals(input.Style))
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
                if (this.CursorParam != null)
                {
                    hashCode = (hashCode * 59) + this.CursorParam.GetHashCode();
                }
                if (this.CursorResponseField != null)
                {
                    hashCode = (hashCode * 59) + this.CursorResponseField.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PageSize.GetHashCode();
                if (this.PageSizeParam != null)
                {
                    hashCode = (hashCode * 59) + this.PageSizeParam.GetHashCode();
                }
                if (this.Style != null)
                {
                    hashCode = (hashCode * 59) + this.Style.GetHashCode();
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
