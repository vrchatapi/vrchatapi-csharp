

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
    /// SentNotificationDetails
    /// </summary>
    [DataContract(Name = "SentNotification_details")]
    public partial class SentNotificationDetails : IEquatable<SentNotificationDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SentNotificationDetails" /> class.
        /// </summary>
        /// <param name="emojiId">emojiId.</param>
        /// <param name="emojiVersion">emojiVersion.</param>
        /// <param name="inventoryItemId">inventoryItemId.</param>
        /// <param name="inviteMessage">inviteMessage.</param>
        /// <param name="worldId">Represents a unique location, consisting of a world identifier and an instance identifier, or \&quot;offline\&quot; if the user is not on your friends list..</param>
        /// <param name="worldName">worldName.</param>
        /// <param name="inResponseTo">inResponseTo.</param>
        /// <param name="responseMessage">responseMessage.</param>
        /// <param name="platform">This is normally &#x60;android&#x60;, &#x60;ios&#x60;, &#x60;standalonewindows&#x60;, &#x60;web&#x60;, or the empty value &#x60;&#x60;, but also supposedly can be any random Unity version such as &#x60;2019.2.4-801-Release&#x60; or &#x60;2019.2.2-772-Release&#x60; or even &#x60;unknownplatform&#x60;..</param>
        /// <param name="requestMessage">Used when using InviteMessage Slot..</param>
        /// <param name="initiatorUserId">A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed..</param>
        /// <param name="userToKickId">A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed..</param>
        public SentNotificationDetails(string emojiId = default, int emojiVersion = default, string inventoryItemId = default, string inviteMessage = default, string worldId = default, string worldName = default, string inResponseTo = default, string responseMessage = default, string platform = default, string requestMessage = default, string initiatorUserId = default, string userToKickId = default)
        {
            this.EmojiId = emojiId;
            this.EmojiVersion = emojiVersion;
            this.InventoryItemId = inventoryItemId;
            this.InviteMessage = inviteMessage;
            this.WorldId = worldId;
            this.WorldName = worldName;
            this.InResponseTo = inResponseTo;
            this.ResponseMessage = responseMessage;
            this.Platform = platform;
            this.RequestMessage = requestMessage;
            this.InitiatorUserId = initiatorUserId;
            this.UserToKickId = userToKickId;
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
        /// Gets or Sets InviteMessage
        /// </summary>
        [DataMember(Name = "inviteMessage", EmitDefaultValue = false)]
        public string InviteMessage { get; set; }

        /// <summary>
        /// Represents a unique location, consisting of a world identifier and an instance identifier, or \&quot;offline\&quot; if the user is not on your friends list.
        /// </summary>
        /// <value>Represents a unique location, consisting of a world identifier and an instance identifier, or \&quot;offline\&quot; if the user is not on your friends list.</value>
        /*
        <example>wrld_4432ea9b-729c-46e3-8eaf-846aa0a37fdd:12345~hidden(usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469)~region(eu)~nonce(27e8414a-59a0-4f3d-af1f-f27557eb49a2)</example>
        */
        [DataMember(Name = "worldId", EmitDefaultValue = false)]
        public string WorldId { get; set; }

        /// <summary>
        /// Gets or Sets WorldName
        /// </summary>
        [DataMember(Name = "worldName", EmitDefaultValue = false)]
        public string WorldName { get; set; }

        /// <summary>
        /// Gets or Sets InResponseTo
        /// </summary>
        /*
        <example>not_00000000-0000-0000-0000-000000000000</example>
        */
        [DataMember(Name = "inResponseTo", EmitDefaultValue = false)]
        public string InResponseTo { get; set; }

        /// <summary>
        /// Gets or Sets ResponseMessage
        /// </summary>
        [DataMember(Name = "responseMessage", EmitDefaultValue = false)]
        public string ResponseMessage { get; set; }

        /// <summary>
        /// This is normally &#x60;android&#x60;, &#x60;ios&#x60;, &#x60;standalonewindows&#x60;, &#x60;web&#x60;, or the empty value &#x60;&#x60;, but also supposedly can be any random Unity version such as &#x60;2019.2.4-801-Release&#x60; or &#x60;2019.2.2-772-Release&#x60; or even &#x60;unknownplatform&#x60;.
        /// </summary>
        /// <value>This is normally &#x60;android&#x60;, &#x60;ios&#x60;, &#x60;standalonewindows&#x60;, &#x60;web&#x60;, or the empty value &#x60;&#x60;, but also supposedly can be any random Unity version such as &#x60;2019.2.4-801-Release&#x60; or &#x60;2019.2.2-772-Release&#x60; or even &#x60;unknownplatform&#x60;.</value>
        /*
        <example>standalonewindows</example>
        */
        [DataMember(Name = "platform", EmitDefaultValue = false)]
        public string Platform { get; set; }

        /// <summary>
        /// Used when using InviteMessage Slot.
        /// </summary>
        /// <value>Used when using InviteMessage Slot.</value>
        [DataMember(Name = "requestMessage", EmitDefaultValue = false)]
        public string RequestMessage { get; set; }

        /// <summary>
        /// A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed.
        /// </summary>
        /// <value>A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed.</value>
        /*
        <example>usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469</example>
        */
        [DataMember(Name = "initiatorUserId", EmitDefaultValue = false)]
        public string InitiatorUserId { get; set; }

        /// <summary>
        /// A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed.
        /// </summary>
        /// <value>A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed.</value>
        /*
        <example>usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469</example>
        */
        [DataMember(Name = "userToKickId", EmitDefaultValue = false)]
        public string UserToKickId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SentNotificationDetails {\n");
            sb.Append("  EmojiId: ").Append(EmojiId).Append("\n");
            sb.Append("  EmojiVersion: ").Append(EmojiVersion).Append("\n");
            sb.Append("  InventoryItemId: ").Append(InventoryItemId).Append("\n");
            sb.Append("  InviteMessage: ").Append(InviteMessage).Append("\n");
            sb.Append("  WorldId: ").Append(WorldId).Append("\n");
            sb.Append("  WorldName: ").Append(WorldName).Append("\n");
            sb.Append("  InResponseTo: ").Append(InResponseTo).Append("\n");
            sb.Append("  ResponseMessage: ").Append(ResponseMessage).Append("\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
            sb.Append("  RequestMessage: ").Append(RequestMessage).Append("\n");
            sb.Append("  InitiatorUserId: ").Append(InitiatorUserId).Append("\n");
            sb.Append("  UserToKickId: ").Append(UserToKickId).Append("\n");
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
            return this.Equals(input as SentNotificationDetails);
        }

        /// <summary>
        /// Returns true if SentNotificationDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of SentNotificationDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SentNotificationDetails input)
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
                ) && 
                (
                    this.InviteMessage == input.InviteMessage ||
                    (this.InviteMessage != null &&
                    this.InviteMessage.Equals(input.InviteMessage))
                ) && 
                (
                    this.WorldId == input.WorldId ||
                    (this.WorldId != null &&
                    this.WorldId.Equals(input.WorldId))
                ) && 
                (
                    this.WorldName == input.WorldName ||
                    (this.WorldName != null &&
                    this.WorldName.Equals(input.WorldName))
                ) && 
                (
                    this.InResponseTo == input.InResponseTo ||
                    (this.InResponseTo != null &&
                    this.InResponseTo.Equals(input.InResponseTo))
                ) && 
                (
                    this.ResponseMessage == input.ResponseMessage ||
                    (this.ResponseMessage != null &&
                    this.ResponseMessage.Equals(input.ResponseMessage))
                ) && 
                (
                    this.Platform == input.Platform ||
                    (this.Platform != null &&
                    this.Platform.Equals(input.Platform))
                ) && 
                (
                    this.RequestMessage == input.RequestMessage ||
                    (this.RequestMessage != null &&
                    this.RequestMessage.Equals(input.RequestMessage))
                ) && 
                (
                    this.InitiatorUserId == input.InitiatorUserId ||
                    (this.InitiatorUserId != null &&
                    this.InitiatorUserId.Equals(input.InitiatorUserId))
                ) && 
                (
                    this.UserToKickId == input.UserToKickId ||
                    (this.UserToKickId != null &&
                    this.UserToKickId.Equals(input.UserToKickId))
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
                if (this.InviteMessage != null)
                {
                    hashCode = (hashCode * 59) + this.InviteMessage.GetHashCode();
                }
                if (this.WorldId != null)
                {
                    hashCode = (hashCode * 59) + this.WorldId.GetHashCode();
                }
                if (this.WorldName != null)
                {
                    hashCode = (hashCode * 59) + this.WorldName.GetHashCode();
                }
                if (this.InResponseTo != null)
                {
                    hashCode = (hashCode * 59) + this.InResponseTo.GetHashCode();
                }
                if (this.ResponseMessage != null)
                {
                    hashCode = (hashCode * 59) + this.ResponseMessage.GetHashCode();
                }
                if (this.Platform != null)
                {
                    hashCode = (hashCode * 59) + this.Platform.GetHashCode();
                }
                if (this.RequestMessage != null)
                {
                    hashCode = (hashCode * 59) + this.RequestMessage.GetHashCode();
                }
                if (this.InitiatorUserId != null)
                {
                    hashCode = (hashCode * 59) + this.InitiatorUserId.GetHashCode();
                }
                if (this.UserToKickId != null)
                {
                    hashCode = (hashCode * 59) + this.UserToKickId.GetHashCode();
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
