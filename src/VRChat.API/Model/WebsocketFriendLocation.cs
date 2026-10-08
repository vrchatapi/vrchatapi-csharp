

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
    /// WebsocketFriendLocation
    /// </summary>
    [DataContract(Name = "WebsocketFriendLocation")]
    public partial class WebsocketFriendLocation : IEquatable<WebsocketFriendLocation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebsocketFriendLocation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WebsocketFriendLocation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebsocketFriendLocation" /> class.
        /// </summary>
        /// <param name="canRequestInvite">canRequestInvite (required).</param>
        /// <param name="location">Represents a unique location, consisting of a world identifier and an instance identifier, or \&quot;offline\&quot; if the user is not on your friends list. (required).</param>
        /// <param name="travelingToLocation">Represents a unique location, consisting of a world identifier and an instance identifier, or \&quot;offline\&quot; if the user is not on your friends list. (required).</param>
        /// <param name="user">user (required).</param>
        /// <param name="userId">A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed. (required).</param>
        /// <param name="worldId">WorldID be \&quot;offline\&quot; on User profiles if you are not friends with that user. (required).</param>
        public WebsocketFriendLocation(bool canRequestInvite = default, string location = default, string travelingToLocation = default, User user = default, string userId = default, string worldId = default)
        {
            this.CanRequestInvite = canRequestInvite;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Location = location;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.TravelingToLocation = travelingToLocation;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.User = user;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.UserId = userId;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.WorldId = worldId;
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
        /// Represents a unique location, consisting of a world identifier and an instance identifier, or \&quot;offline\&quot; if the user is not on your friends list.
        /// </summary>
        /// <value>Represents a unique location, consisting of a world identifier and an instance identifier, or \&quot;offline\&quot; if the user is not on your friends list.</value>
        [DataMember(Name = "travelingToLocation", IsRequired = true, EmitDefaultValue = true)]
        public string TravelingToLocation { get; set; }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name = "user", IsRequired = true, EmitDefaultValue = true)]
        public User User { get; set; }

        /// <summary>
        /// A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed.
        /// </summary>
        /// <value>A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed.</value>
        [DataMember(Name = "userId", IsRequired = true, EmitDefaultValue = true)]
        public string UserId { get; set; }

        /// <summary>
        /// WorldID be \&quot;offline\&quot; on User profiles if you are not friends with that user.
        /// </summary>
        /// <value>WorldID be \&quot;offline\&quot; on User profiles if you are not friends with that user.</value>
        [DataMember(Name = "worldId", IsRequired = true, EmitDefaultValue = true)]
        public string WorldId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WebsocketFriendLocation {\n");
            sb.Append("  CanRequestInvite: ").Append(CanRequestInvite).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  TravelingToLocation: ").Append(TravelingToLocation).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  WorldId: ").Append(WorldId).Append("\n");
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
            return this.Equals(input as WebsocketFriendLocation);
        }

        /// <summary>
        /// Returns true if WebsocketFriendLocation instances are equal
        /// </summary>
        /// <param name="input">Instance of WebsocketFriendLocation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebsocketFriendLocation input)
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
                    this.TravelingToLocation == input.TravelingToLocation ||
                    (this.TravelingToLocation != null &&
                    this.TravelingToLocation.Equals(input.TravelingToLocation))
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.WorldId == input.WorldId ||
                    (this.WorldId != null &&
                    this.WorldId.Equals(input.WorldId))
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
                if (this.TravelingToLocation != null)
                {
                    hashCode = (hashCode * 59) + this.TravelingToLocation.GetHashCode();
                }
                if (this.User != null)
                {
                    hashCode = (hashCode * 59) + this.User.GetHashCode();
                }
                if (this.UserId != null)
                {
                    hashCode = (hashCode * 59) + this.UserId.GetHashCode();
                }
                if (this.WorldId != null)
                {
                    hashCode = (hashCode * 59) + this.WorldId.GetHashCode();
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
