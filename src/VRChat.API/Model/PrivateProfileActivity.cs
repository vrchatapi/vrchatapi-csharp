

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
    /// PrivateProfileActivity
    /// </summary>
    [DataContract(Name = "PrivateProfileActivity")]
    public partial class PrivateProfileActivity : IEquatable<PrivateProfileActivity>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public UserState? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateProfileActivity" /> class.
        /// </summary>
        /// <param name="instanceId">InstanceID can be \&quot;offline\&quot; on User profiles if you are not friends with that user and \&quot;private\&quot; if you are friends and user is in private instance..</param>
        /// <param name="lastActivity">Either a date-time or an empty string..</param>
        /// <param name="lastLogin">Either a date-time or an empty string..</param>
        /// <param name="location">Represents a unique location, consisting of a world identifier and an instance identifier, or \&quot;offline\&quot; if the user is not on your friends list..</param>
        /// <param name="platform">This is normally &#x60;android&#x60;, &#x60;ios&#x60;, &#x60;standalonewindows&#x60;, &#x60;web&#x60;, or the empty value &#x60;&#x60;, but also supposedly can be any random Unity version such as &#x60;2019.2.4-801-Release&#x60; or &#x60;2019.2.2-772-Release&#x60; or even &#x60;unknownplatform&#x60;..</param>
        /// <param name="state">state.</param>
        /// <param name="travelingToInstance">travelingToInstance.</param>
        /// <param name="travelingToLocation">travelingToLocation.</param>
        /// <param name="travelingToWorld">travelingToWorld.</param>
        /// <param name="worldId">WorldID be \&quot;offline\&quot; on User profiles if you are not friends with that user..</param>
        public PrivateProfileActivity(string instanceId = default, string lastActivity = default, string lastLogin = default, string location = default, string platform = default, UserState? state = default, string travelingToInstance = default, string travelingToLocation = default, string travelingToWorld = default, string worldId = default)
        {
            this.InstanceId = instanceId;
            this.LastActivity = lastActivity;
            this.LastLogin = lastLogin;
            this.Location = location;
            this.Platform = platform;
            this.State = state;
            this.TravelingToInstance = travelingToInstance;
            this.TravelingToLocation = travelingToLocation;
            this.TravelingToWorld = travelingToWorld;
            this.WorldId = worldId;
        }

        /// <summary>
        /// InstanceID can be \&quot;offline\&quot; on User profiles if you are not friends with that user and \&quot;private\&quot; if you are friends and user is in private instance.
        /// </summary>
        /// <value>InstanceID can be \&quot;offline\&quot; on User profiles if you are not friends with that user and \&quot;private\&quot; if you are friends and user is in private instance.</value>
        /*
        <example>12345~hidden(usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469)~region(eu)~nonce(27e8414a-59a0-4f3d-af1f-f27557eb49a2)</example>
        */
        [DataMember(Name = "instanceId", EmitDefaultValue = false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Either a date-time or an empty string.
        /// </summary>
        /// <value>Either a date-time or an empty string.</value>
        [DataMember(Name = "last_activity", EmitDefaultValue = false)]
        public string LastActivity { get; set; }

        /// <summary>
        /// Either a date-time or an empty string.
        /// </summary>
        /// <value>Either a date-time or an empty string.</value>
        [DataMember(Name = "last_login", EmitDefaultValue = false)]
        public string LastLogin { get; set; }

        /// <summary>
        /// Represents a unique location, consisting of a world identifier and an instance identifier, or \&quot;offline\&quot; if the user is not on your friends list.
        /// </summary>
        /// <value>Represents a unique location, consisting of a world identifier and an instance identifier, or \&quot;offline\&quot; if the user is not on your friends list.</value>
        /*
        <example>wrld_4432ea9b-729c-46e3-8eaf-846aa0a37fdd:12345~hidden(usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469)~region(eu)~nonce(27e8414a-59a0-4f3d-af1f-f27557eb49a2)</example>
        */
        [DataMember(Name = "location", EmitDefaultValue = false)]
        public string Location { get; set; }

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
        /// Gets or Sets TravelingToInstance
        /// </summary>
        [DataMember(Name = "travelingToInstance", EmitDefaultValue = false)]
        public string TravelingToInstance { get; set; }

        /// <summary>
        /// Gets or Sets TravelingToLocation
        /// </summary>
        [DataMember(Name = "travelingToLocation", EmitDefaultValue = false)]
        public string TravelingToLocation { get; set; }

        /// <summary>
        /// Gets or Sets TravelingToWorld
        /// </summary>
        [DataMember(Name = "travelingToWorld", EmitDefaultValue = false)]
        public string TravelingToWorld { get; set; }

        /// <summary>
        /// WorldID be \&quot;offline\&quot; on User profiles if you are not friends with that user.
        /// </summary>
        /// <value>WorldID be \&quot;offline\&quot; on User profiles if you are not friends with that user.</value>
        /*
        <example>wrld_4432ea9b-729c-46e3-8eaf-846aa0a37fdd</example>
        */
        [DataMember(Name = "worldId", EmitDefaultValue = false)]
        public string WorldId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PrivateProfileActivity {\n");
            sb.Append("  InstanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  LastActivity: ").Append(LastActivity).Append("\n");
            sb.Append("  LastLogin: ").Append(LastLogin).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  TravelingToInstance: ").Append(TravelingToInstance).Append("\n");
            sb.Append("  TravelingToLocation: ").Append(TravelingToLocation).Append("\n");
            sb.Append("  TravelingToWorld: ").Append(TravelingToWorld).Append("\n");
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
            return this.Equals(input as PrivateProfileActivity);
        }

        /// <summary>
        /// Returns true if PrivateProfileActivity instances are equal
        /// </summary>
        /// <param name="input">Instance of PrivateProfileActivity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PrivateProfileActivity input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.InstanceId == input.InstanceId ||
                    (this.InstanceId != null &&
                    this.InstanceId.Equals(input.InstanceId))
                ) && 
                (
                    this.LastActivity == input.LastActivity ||
                    (this.LastActivity != null &&
                    this.LastActivity.Equals(input.LastActivity))
                ) && 
                (
                    this.LastLogin == input.LastLogin ||
                    (this.LastLogin != null &&
                    this.LastLogin.Equals(input.LastLogin))
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
                    this.State == input.State ||
                    this.State.Equals(input.State)
                ) && 
                (
                    this.TravelingToInstance == input.TravelingToInstance ||
                    (this.TravelingToInstance != null &&
                    this.TravelingToInstance.Equals(input.TravelingToInstance))
                ) && 
                (
                    this.TravelingToLocation == input.TravelingToLocation ||
                    (this.TravelingToLocation != null &&
                    this.TravelingToLocation.Equals(input.TravelingToLocation))
                ) && 
                (
                    this.TravelingToWorld == input.TravelingToWorld ||
                    (this.TravelingToWorld != null &&
                    this.TravelingToWorld.Equals(input.TravelingToWorld))
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
                if (this.InstanceId != null)
                {
                    hashCode = (hashCode * 59) + this.InstanceId.GetHashCode();
                }
                if (this.LastActivity != null)
                {
                    hashCode = (hashCode * 59) + this.LastActivity.GetHashCode();
                }
                if (this.LastLogin != null)
                {
                    hashCode = (hashCode * 59) + this.LastLogin.GetHashCode();
                }
                if (this.Location != null)
                {
                    hashCode = (hashCode * 59) + this.Location.GetHashCode();
                }
                if (this.Platform != null)
                {
                    hashCode = (hashCode * 59) + this.Platform.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.State.GetHashCode();
                if (this.TravelingToInstance != null)
                {
                    hashCode = (hashCode * 59) + this.TravelingToInstance.GetHashCode();
                }
                if (this.TravelingToLocation != null)
                {
                    hashCode = (hashCode * 59) + this.TravelingToLocation.GetHashCode();
                }
                if (this.TravelingToWorld != null)
                {
                    hashCode = (hashCode * 59) + this.TravelingToWorld.GetHashCode();
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
