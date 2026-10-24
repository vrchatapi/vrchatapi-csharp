

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
    /// InfoPushContentCalendarEntries
    /// </summary>
    [DataContract(Name = "InfoPushContentCalendarEntries")]
    public partial class InfoPushContentCalendarEntries : IEquatable<InfoPushContentCalendarEntries>, IValidatableObject
    {
        /// <summary>
        /// Defines ResponseType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ResponseTypeEnum
        {
            /// <summary>
            /// Enum CalendarEntry for value: calendarEntry
            /// </summary>
            [EnumMember(Value = "calendarEntry")]
            CalendarEntry = 1
        }


        /// <summary>
        /// Gets or Sets ResponseType
        /// </summary>
        [DataMember(Name = "responseType", IsRequired = true, EmitDefaultValue = true)]
        public ResponseTypeEnum ResponseType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InfoPushContentCalendarEntries" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InfoPushContentCalendarEntries() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InfoPushContentCalendarEntries" /> class.
        /// </summary>
        /// <param name="nextCursor">Pass back as the &#x60;nextCursor&#x60; query parameter to read the page after this one. (required).</param>
        /// <param name="responseType">responseType (required).</param>
        /// <param name="results">results (required).</param>
        public InfoPushContentCalendarEntries(string nextCursor = default, ResponseTypeEnum responseType = default, List<CalendarEvent> results = default)
        {
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.NextCursor = nextCursor;
            this.ResponseType = responseType;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Results = results;
        }

        /// <summary>
        /// Pass back as the &#x60;nextCursor&#x60; query parameter to read the page after this one.
        /// </summary>
        /// <value>Pass back as the &#x60;nextCursor&#x60; query parameter to read the page after this one.</value>
        [DataMember(Name = "nextCursor", IsRequired = true, EmitDefaultValue = true)]
        public string NextCursor { get; set; }

        /// <summary>
        /// Gets or Sets Results
        /// </summary>
        [DataMember(Name = "results", IsRequired = true, EmitDefaultValue = true)]
        public List<CalendarEvent> Results { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InfoPushContentCalendarEntries {\n");
            sb.Append("  NextCursor: ").Append(NextCursor).Append("\n");
            sb.Append("  ResponseType: ").Append(ResponseType).Append("\n");
            sb.Append("  Results: ").Append(Results).Append("\n");
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
            return this.Equals(input as InfoPushContentCalendarEntries);
        }

        /// <summary>
        /// Returns true if InfoPushContentCalendarEntries instances are equal
        /// </summary>
        /// <param name="input">Instance of InfoPushContentCalendarEntries to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InfoPushContentCalendarEntries input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.NextCursor == input.NextCursor ||
                    (this.NextCursor != null &&
                    this.NextCursor.Equals(input.NextCursor))
                ) && 
                (
                    this.ResponseType == input.ResponseType ||
                    this.ResponseType.Equals(input.ResponseType)
                ) && 
                (
                    this.Results == input.Results ||
                    this.Results != null &&
                    input.Results != null &&
                    this.Results.SequenceEqual(input.Results)
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
                if (this.NextCursor != null)
                {
                    hashCode = (hashCode * 59) + this.NextCursor.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ResponseType.GetHashCode();
                if (this.Results != null)
                {
                    hashCode = (hashCode * 59) + this.Results.GetHashCode();
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
