

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
    /// WebsocketNotificationV2Update
    /// </summary>
    [DataContract(Name = "WebsocketNotificationV2Update")]
    public partial class WebsocketNotificationV2Update : IEquatable<WebsocketNotificationV2Update>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebsocketNotificationV2Update" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WebsocketNotificationV2Update() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebsocketNotificationV2Update" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="updates">updates (required).</param>
        /// <param name="varVersion">varVersion (required).</param>
        public WebsocketNotificationV2Update(string id = default, Object updates = default, int varVersion = default)
        {
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Id = id;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Updates = updates;
            this.VarVersion = varVersion;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Updates
        /// </summary>
        [DataMember(Name = "updates", IsRequired = true, EmitDefaultValue = true)]
        public Object Updates { get; set; }

        /// <summary>
        /// Gets or Sets VarVersion
        /// </summary>
        [DataMember(Name = "version", IsRequired = true, EmitDefaultValue = true)]
        public int VarVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WebsocketNotificationV2Update {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Updates: ").Append(Updates).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
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
            return this.Equals(input as WebsocketNotificationV2Update);
        }

        /// <summary>
        /// Returns true if WebsocketNotificationV2Update instances are equal
        /// </summary>
        /// <param name="input">Instance of WebsocketNotificationV2Update to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebsocketNotificationV2Update input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Updates == input.Updates ||
                    (this.Updates != null &&
                    this.Updates.Equals(input.Updates))
                ) && 
                (
                    this.VarVersion == input.VarVersion ||
                    this.VarVersion.Equals(input.VarVersion)
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Updates != null)
                {
                    hashCode = (hashCode * 59) + this.Updates.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.VarVersion.GetHashCode();
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
