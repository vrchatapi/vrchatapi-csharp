

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
    /// WebsocketContentRefresh
    /// </summary>
    [DataContract(Name = "WebsocketContentRefresh")]
    public partial class WebsocketContentRefresh : IEquatable<WebsocketContentRefresh>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets ActionType
        /// </summary>
        [DataMember(Name = "actionType", IsRequired = true, EmitDefaultValue = true)]
        public WebsocketContentRefreshActionType ActionType { get; set; }

        /// <summary>
        /// Gets or Sets ItemType
        /// </summary>
        [DataMember(Name = "itemType", IsRequired = true, EmitDefaultValue = true)]
        public InventoryItemType ItemType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebsocketContentRefresh" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WebsocketContentRefresh() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebsocketContentRefresh" /> class.
        /// </summary>
        /// <param name="actionType">actionType (required).</param>
        /// <param name="contentType">contentType (required).</param>
        /// <param name="fileId">fileId (required).</param>
        /// <param name="itemId">itemId (required).</param>
        /// <param name="itemType">itemType (required).</param>
        public WebsocketContentRefresh(WebsocketContentRefreshActionType actionType = default, string contentType = default, string fileId = default, string itemId = default, InventoryItemType itemType = default)
        {
            this.ActionType = actionType;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.ContentType = contentType;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.FileId = fileId;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.ItemId = itemId;
            this.ItemType = itemType;
        }

        /// <summary>
        /// Gets or Sets ContentType
        /// </summary>
        [DataMember(Name = "contentType", IsRequired = true, EmitDefaultValue = true)]
        public string ContentType { get; set; }

        /// <summary>
        /// Gets or Sets FileId
        /// </summary>
        [DataMember(Name = "fileId", IsRequired = true, EmitDefaultValue = true)]
        public string FileId { get; set; }

        /// <summary>
        /// Gets or Sets ItemId
        /// </summary>
        [DataMember(Name = "itemId", IsRequired = true, EmitDefaultValue = true)]
        public string ItemId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WebsocketContentRefresh {\n");
            sb.Append("  ActionType: ").Append(ActionType).Append("\n");
            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
            sb.Append("  FileId: ").Append(FileId).Append("\n");
            sb.Append("  ItemId: ").Append(ItemId).Append("\n");
            sb.Append("  ItemType: ").Append(ItemType).Append("\n");
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
            return this.Equals(input as WebsocketContentRefresh);
        }

        /// <summary>
        /// Returns true if WebsocketContentRefresh instances are equal
        /// </summary>
        /// <param name="input">Instance of WebsocketContentRefresh to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebsocketContentRefresh input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ActionType == input.ActionType ||
                    this.ActionType.Equals(input.ActionType)
                ) && 
                (
                    this.ContentType == input.ContentType ||
                    (this.ContentType != null &&
                    this.ContentType.Equals(input.ContentType))
                ) && 
                (
                    this.FileId == input.FileId ||
                    (this.FileId != null &&
                    this.FileId.Equals(input.FileId))
                ) && 
                (
                    this.ItemId == input.ItemId ||
                    (this.ItemId != null &&
                    this.ItemId.Equals(input.ItemId))
                ) && 
                (
                    this.ItemType == input.ItemType ||
                    this.ItemType.Equals(input.ItemType)
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
                hashCode = (hashCode * 59) + this.ActionType.GetHashCode();
                if (this.ContentType != null)
                {
                    hashCode = (hashCode * 59) + this.ContentType.GetHashCode();
                }
                if (this.FileId != null)
                {
                    hashCode = (hashCode * 59) + this.FileId.GetHashCode();
                }
                if (this.ItemId != null)
                {
                    hashCode = (hashCode * 59) + this.ItemId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ItemType.GetHashCode();
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
