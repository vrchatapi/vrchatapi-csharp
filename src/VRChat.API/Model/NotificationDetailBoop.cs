

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
    /// Either inventoryItemId by itself, or emojiId with optional emojiVersion
    /// </summary>
    [DataContract(Name = "NotificationDetailBoop")]
    public partial class NotificationDetailBoop : IEquatable<NotificationDetailBoop>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationDetailBoop" /> class.
        /// </summary>
        /// <param name="emojiId">emojiId.</param>
        /// <param name="emojiVersion">emojiVersion.</param>
        /// <param name="inventoryItemId">inventoryItemId.</param>
        public NotificationDetailBoop(string emojiId = default, int emojiVersion = default, string inventoryItemId = default)
        {
            this.EmojiId = emojiId;
            this.EmojiVersion = emojiVersion;
            this.InventoryItemId = inventoryItemId;
        }

        /// <summary>
        /// Gets or Sets EmojiId
        /// </summary>
        /*
        <example>file_ce35d830-e20a-4df0-a6d4-5aaef4508044</example>
        */
        [DataMember(Name = "emojiId", EmitDefaultValue = false)]
        public string EmojiId { get; set; }

        /// <summary>
        /// Gets or Sets EmojiVersion
        /// </summary>
        [DataMember(Name = "emojiVersion", EmitDefaultValue = false)]
        public int EmojiVersion { get; set; }

        /// <summary>
        /// Gets or Sets InventoryItemId
        /// </summary>
        /*
        <example>inv_10bce5b0-2d2b-44e0-900d-db6534615162</example>
        */
        [DataMember(Name = "inventoryItemId", EmitDefaultValue = false)]
        public string InventoryItemId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NotificationDetailBoop {\n");
            sb.Append("  EmojiId: ").Append(EmojiId).Append("\n");
            sb.Append("  EmojiVersion: ").Append(EmojiVersion).Append("\n");
            sb.Append("  InventoryItemId: ").Append(InventoryItemId).Append("\n");
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
            return this.Equals(input as NotificationDetailBoop);
        }

        /// <summary>
        /// Returns true if NotificationDetailBoop instances are equal
        /// </summary>
        /// <param name="input">Instance of NotificationDetailBoop to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NotificationDetailBoop input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.EmojiId == input.EmojiId ||
                    (this.EmojiId != null &&
                    this.EmojiId.Equals(input.EmojiId))
                ) && 
                (
                    this.EmojiVersion == input.EmojiVersion ||
                    this.EmojiVersion.Equals(input.EmojiVersion)
                ) && 
                (
                    this.InventoryItemId == input.InventoryItemId ||
                    (this.InventoryItemId != null &&
                    this.InventoryItemId.Equals(input.InventoryItemId))
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
                if (this.EmojiId != null)
                {
                    hashCode = (hashCode * 59) + this.EmojiId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.EmojiVersion.GetHashCode();
                if (this.InventoryItemId != null)
                {
                    hashCode = (hashCode * 59) + this.InventoryItemId.GetHashCode();
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
