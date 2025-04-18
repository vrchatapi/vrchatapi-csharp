/*
 * VRChat API Documentation
 *
 *
 * The version of the OpenAPI document: 1.19.2
 * Contact: vrchatapi.lpv0t@aries.fyi
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


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
using OpenAPIDateConverter = VRChat.API.Client.OpenAPIDateConverter;

namespace VRChat.API.Model
{
    /// <summary>
    /// APIConfigReportOptionsUser
    /// </summary>
    [DataContract(Name = "APIConfig_reportOptions_user")]
    public partial class APIConfigReportOptionsUser : IEquatable<APIConfigReportOptionsUser>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="APIConfigReportOptionsUser" /> class.
        /// </summary>
        /// <param name="behavior">behavior.</param>
        /// <param name="chat">chat.</param>
        /// <param name="emoji">emoji.</param>
        /// <param name="image">image.</param>
        /// <param name="sticker">sticker.</param>
        /// <param name="text">text.</param>
        public APIConfigReportOptionsUser(List<string> behavior = default(List<string>), List<string> chat = default(List<string>), List<string> emoji = default(List<string>), List<string> image = default(List<string>), List<string> sticker = default(List<string>), List<string> text = default(List<string>))
        {
            this.Behavior = behavior;
            this.Chat = chat;
            this.Emoji = emoji;
            this.Image = image;
            this.Sticker = sticker;
            this.Text = text;
        }

        /// <summary>
        /// Gets or Sets Behavior
        /// </summary>
        [DataMember(Name = "behavior", EmitDefaultValue = false)]
        public List<string> Behavior { get; set; }

        /// <summary>
        /// Gets or Sets Chat
        /// </summary>
        [DataMember(Name = "chat", EmitDefaultValue = false)]
        public List<string> Chat { get; set; }

        /// <summary>
        /// Gets or Sets Emoji
        /// </summary>
        [DataMember(Name = "emoji", EmitDefaultValue = false)]
        public List<string> Emoji { get; set; }

        /// <summary>
        /// Gets or Sets Image
        /// </summary>
        [DataMember(Name = "image", EmitDefaultValue = false)]
        public List<string> Image { get; set; }

        /// <summary>
        /// Gets or Sets Sticker
        /// </summary>
        [DataMember(Name = "sticker", EmitDefaultValue = false)]
        public List<string> Sticker { get; set; }

        /// <summary>
        /// Gets or Sets Text
        /// </summary>
        [DataMember(Name = "text", EmitDefaultValue = false)]
        public List<string> Text { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class APIConfigReportOptionsUser {\n");
            sb.Append("  Behavior: ").Append(Behavior).Append("\n");
            sb.Append("  Chat: ").Append(Chat).Append("\n");
            sb.Append("  Emoji: ").Append(Emoji).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  Sticker: ").Append(Sticker).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
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
            return this.Equals(input as APIConfigReportOptionsUser);
        }

        /// <summary>
        /// Returns true if APIConfigReportOptionsUser instances are equal
        /// </summary>
        /// <param name="input">Instance of APIConfigReportOptionsUser to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(APIConfigReportOptionsUser input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Behavior == input.Behavior ||
                    this.Behavior != null &&
                    input.Behavior != null &&
                    this.Behavior.SequenceEqual(input.Behavior)
                ) && 
                (
                    this.Chat == input.Chat ||
                    this.Chat != null &&
                    input.Chat != null &&
                    this.Chat.SequenceEqual(input.Chat)
                ) && 
                (
                    this.Emoji == input.Emoji ||
                    this.Emoji != null &&
                    input.Emoji != null &&
                    this.Emoji.SequenceEqual(input.Emoji)
                ) && 
                (
                    this.Image == input.Image ||
                    this.Image != null &&
                    input.Image != null &&
                    this.Image.SequenceEqual(input.Image)
                ) && 
                (
                    this.Sticker == input.Sticker ||
                    this.Sticker != null &&
                    input.Sticker != null &&
                    this.Sticker.SequenceEqual(input.Sticker)
                ) && 
                (
                    this.Text == input.Text ||
                    this.Text != null &&
                    input.Text != null &&
                    this.Text.SequenceEqual(input.Text)
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
                if (this.Behavior != null)
                {
                    hashCode = (hashCode * 59) + this.Behavior.GetHashCode();
                }
                if (this.Chat != null)
                {
                    hashCode = (hashCode * 59) + this.Chat.GetHashCode();
                }
                if (this.Emoji != null)
                {
                    hashCode = (hashCode * 59) + this.Emoji.GetHashCode();
                }
                if (this.Image != null)
                {
                    hashCode = (hashCode * 59) + this.Image.GetHashCode();
                }
                if (this.Sticker != null)
                {
                    hashCode = (hashCode * 59) + this.Sticker.GetHashCode();
                }
                if (this.Text != null)
                {
                    hashCode = (hashCode * 59) + this.Text.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
