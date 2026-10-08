

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
    /// WebsocketUserLocation
    /// </summary>
    [DataContract(Name = "WebsocketUserLocation")]
    public partial class WebsocketUserLocation : IEquatable<WebsocketUserLocation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebsocketUserLocation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WebsocketUserLocation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebsocketUserLocation" /> class.
        /// </summary>
        /// <param name="instance">InstanceID can be \&quot;offline\&quot; on User profiles if you are not friends with that user and \&quot;private\&quot; if you are friends and user is in private instance. (required).</param>
        /// <param name="location">Represents a unique location, consisting of a world identifier and an instance identifier, or \&quot;offline\&quot; if the user is not on your friends list. (required).</param>
        /// <param name="travelingToLocation">Represents a unique location, consisting of a world identifier and an instance identifier, or \&quot;offline\&quot; if the user is not on your friends list. (required).</param>
        /// <param name="user">user (required).</param>
        /// <param name="userId">A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed. (required).</param>
        public WebsocketUserLocation(string instance = default, string location = default, string travelingToLocation = default, User user = default, string userId = default)
        {
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Instance = instance;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Location = location;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.TravelingToLocation = travelingToLocation;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.User = user;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.UserId = userId;
        }

        /// <summary>
        /// InstanceID can be \&quot;offline\&quot; on User profiles if you are not friends with that user and \&quot;private\&quot; if you are friends and user is in private instance.
        /// </summary>
        /// <value>InstanceID can be \&quot;offline\&quot; on User profiles if you are not friends with that user and \&quot;private\&quot; if you are friends and user is in private instance.</value>
        [DataMember(Name = "instance", IsRequired = true, EmitDefaultValue = true)]
        public string Instance { get; set; }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WebsocketUserLocation {\n");
            sb.Append("  Instance: ").Append(Instance).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  TravelingToLocation: ").Append(TravelingToLocation).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
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
            return this.Equals(input as WebsocketUserLocation);
        }

        /// <summary>
        /// Returns true if WebsocketUserLocation instances are equal
        /// </summary>
        /// <param name="input">Instance of WebsocketUserLocation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebsocketUserLocation input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Instance == input.Instance ||
                    (this.Instance != null &&
                    this.Instance.Equals(input.Instance))
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
                if (this.Instance != null)
                {
                    hashCode = (hashCode * 59) + this.Instance.GetHashCode();
                }
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
