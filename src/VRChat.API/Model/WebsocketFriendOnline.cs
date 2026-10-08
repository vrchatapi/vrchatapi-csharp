

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
    /// WebsocketFriendOnline
    /// </summary>
    [DataContract(Name = "WebsocketFriendOnline")]
    public partial class WebsocketFriendOnline : IEquatable<WebsocketFriendOnline>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebsocketFriendOnline" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WebsocketFriendOnline() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebsocketFriendOnline" /> class.
        /// </summary>
        /// <param name="canRequestInvite">canRequestInvite (required).</param>
        /// <param name="location">Represents a unique location, consisting of a world identifier and an instance identifier, or \&quot;offline\&quot; if the user is not on your friends list. (required).</param>
        /// <param name="platform">This is normally &#x60;android&#x60;, &#x60;ios&#x60;, &#x60;standalonewindows&#x60;, &#x60;web&#x60;, or the empty value &#x60;&#x60;, but also supposedly can be any random Unity version such as &#x60;2019.2.4-801-Release&#x60; or &#x60;2019.2.2-772-Release&#x60; or even &#x60;unknownplatform&#x60;. (required).</param>
        /// <param name="userId">A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed. (required).</param>
        public WebsocketFriendOnline(bool canRequestInvite = default, string location = default, string platform = default, string userId = default)
        {
            this.CanRequestInvite = canRequestInvite;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Location = location;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Platform = platform;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.UserId = userId;
        }

        /// <summary>
        /// Gets or Sets CanRequestInvite
        /// </summary>
        [DataMember(Name = "canRequestInvite", IsRequired = true, EmitDefaultValue = true)]
        public bool CanRequestInvite { get; set; }

        /// <summary>
        /// Represents a unique location, consisting of a world identifier and an instance identifier, or \&quot;offline\&quot; if the user is not on your friends list.
        /// </summary>
        /// <value>Represents a unique location, consisting of a world identifier and an instance identifier, or \&quot;offline\&quot; if the user is not on your friends list.</value>
        [DataMember(Name = "location", IsRequired = true, EmitDefaultValue = true)]
        public string Location { get; set; }

        /// <summary>
        /// This is normally &#x60;android&#x60;, &#x60;ios&#x60;, &#x60;standalonewindows&#x60;, &#x60;web&#x60;, or the empty value &#x60;&#x60;, but also supposedly can be any random Unity version such as &#x60;2019.2.4-801-Release&#x60; or &#x60;2019.2.2-772-Release&#x60; or even &#x60;unknownplatform&#x60;.
        /// </summary>
        /// <value>This is normally &#x60;android&#x60;, &#x60;ios&#x60;, &#x60;standalonewindows&#x60;, &#x60;web&#x60;, or the empty value &#x60;&#x60;, but also supposedly can be any random Unity version such as &#x60;2019.2.4-801-Release&#x60; or &#x60;2019.2.2-772-Release&#x60; or even &#x60;unknownplatform&#x60;.</value>
        [DataMember(Name = "platform", IsRequired = true, EmitDefaultValue = true)]
        public string Platform { get; set; }

        /// <summary>
        /// A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed.
        /// </summary>
        /// <value>A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed.</value>
        [DataMember(Name = "userId", IsRequired = true, EmitDefaultValue = true)]
        public string UserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WebsocketFriendOnline {\n");
            sb.Append("  CanRequestInvite: ").Append(CanRequestInvite).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
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
            return this.Equals(input as WebsocketFriendOnline);
        }

        /// <summary>
        /// Returns true if WebsocketFriendOnline instances are equal
        /// </summary>
        /// <param name="input">Instance of WebsocketFriendOnline to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebsocketFriendOnline input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CanRequestInvite == input.CanRequestInvite ||
                    this.CanRequestInvite.Equals(input.CanRequestInvite)
                ) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && 
                (
                    this.Platform == input.Platform ||
                    (this.Platform != null &&
                    this.Platform.Equals(input.Platform))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
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
                hashCode = (hashCode * 59) + this.CanRequestInvite.GetHashCode();
                if (this.Location != null)
                {
                    hashCode = (hashCode * 59) + this.Location.GetHashCode();
                }
                if (this.Platform != null)
                {
                    hashCode = (hashCode * 59) + this.Platform.GetHashCode();
                }
                if (this.UserId != null)
                {
                    hashCode = (hashCode * 59) + this.UserId.GetHashCode();
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
