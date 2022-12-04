/*
 * VRChat API Documentation
 *
 *
 * The version of the OpenAPI document: 1.9.1
 * Contact: me@ariesclark.com
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
    /// User
    /// </summary>
    [DataContract(Name = "User")]
    public partial class User : IEquatable<User>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets DeveloperType
        /// </summary>
        [DataMember(Name = "developerType", IsRequired = true, EmitDefaultValue = true)]
        public DeveloperType DeveloperType { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", IsRequired = true, EmitDefaultValue = true)]
        public UserState State { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public UserStatus Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="User" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected User() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="User" /> class.
        /// </summary>
        /// <param name="allowAvatarCopying">allowAvatarCopying (required) (default to true).</param>
        /// <param name="bio">bio (required).</param>
        /// <param name="bioLinks">bioLinks (required).</param>
        /// <param name="currentAvatarImageUrl">When profilePicOverride is not empty, use it instead. (required).</param>
        /// <param name="currentAvatarThumbnailImageUrl">When profilePicOverride is not empty, use it instead. (required).</param>
        /// <param name="dateJoined">dateJoined (required).</param>
        /// <param name="developerType">developerType (required).</param>
        /// <param name="displayName">A users visual display name. This is what shows up in-game, and can different from their &#x60;username&#x60;. Changing display name is restricted to a cooldown period. (required).</param>
        /// <param name="friendKey">friendKey (required).</param>
        /// <param name="friendRequestStatus">friendRequestStatus.</param>
        /// <param name="id">A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed. (required).</param>
        /// <param name="instanceId">InstanceID can be \&quot;offline\&quot; on User profiles if you are not friends with that user and \&quot;private\&quot; if you are friends and user is in private instance..</param>
        /// <param name="isFriend">Either their &#x60;friendKey&#x60;, or empty string if you are not friends. Unknown usage. (required).</param>
        /// <param name="lastActivity">Either a date-time or empty string. (required).</param>
        /// <param name="lastLogin">Either a date-time or empty string. (required).</param>
        /// <param name="lastPlatform">This can be &#x60;standalonewindows&#x60; or &#x60;android&#x60;, but can also pretty much be any random Unity verison such as &#x60;2019.2.4-801-Release&#x60; or &#x60;2019.2.2-772-Release&#x60; or even &#x60;unknownplatform&#x60;. (required).</param>
        /// <param name="location">WorldID be \&quot;offline\&quot; on User profiles if you are not friends with that user..</param>
        /// <param name="note">note.</param>
        /// <param name="profilePicOverride">profilePicOverride (required).</param>
        /// <param name="state">state (required).</param>
        /// <param name="status">status (required).</param>
        /// <param name="statusDescription">statusDescription (required).</param>
        /// <param name="tags">  (required).</param>
        /// <param name="travelingToInstance">travelingToInstance.</param>
        /// <param name="travelingToLocation">travelingToLocation.</param>
        /// <param name="travelingToWorld">travelingToWorld.</param>
        /// <param name="userIcon">userIcon (required).</param>
        /// <param name="username">-| A users unique name, used during login. This is different from &#x60;displayName&#x60; which is what shows up in-game. A users &#x60;username&#x60; can never be changed.&#39; **DEPRECATED:** VRChat API no longer return usernames of other users. [See issue by Tupper for more information](https://github.com/pypy-vrc/VRCX/issues/429)..</param>
        /// <param name="worldId">WorldID be \&quot;offline\&quot; on User profiles if you are not friends with that user..</param>
        public User(bool allowAvatarCopying = true, string bio = default(string), List<string> bioLinks = default(List<string>), string currentAvatarImageUrl = default(string), string currentAvatarThumbnailImageUrl = default(string), DateTime dateJoined = default(DateTime), DeveloperType developerType = default(DeveloperType), string displayName = default(string), string friendKey = default(string), string friendRequestStatus = default(string), string id = default(string), string instanceId = default(string), bool isFriend = default(bool), string lastActivity = default(string), string lastLogin = default(string), string lastPlatform = default(string), string location = default(string), string note = default(string), string profilePicOverride = default(string), UserState state = default(UserState), UserStatus status = default(UserStatus), string statusDescription = default(string), List<string> tags = default(List<string>), string travelingToInstance = default(string), string travelingToLocation = default(string), string travelingToWorld = default(string), string userIcon = default(string), string username = default(string), string worldId = default(string))
        {
            this.AllowAvatarCopying = allowAvatarCopying;
            // to ensure "bio" is required (not null)
            if (bio == null)
            {
                throw new ArgumentNullException("bio is a required property for User and cannot be null");
            }
            this.Bio = bio;
            // to ensure "bioLinks" is required (not null)
            if (bioLinks == null)
            {
                throw new ArgumentNullException("bioLinks is a required property for User and cannot be null");
            }
            this.BioLinks = bioLinks;
            // to ensure "currentAvatarImageUrl" is required (not null)
            if (currentAvatarImageUrl == null)
            {
                throw new ArgumentNullException("currentAvatarImageUrl is a required property for User and cannot be null");
            }
            this.CurrentAvatarImageUrl = currentAvatarImageUrl;
            // to ensure "currentAvatarThumbnailImageUrl" is required (not null)
            if (currentAvatarThumbnailImageUrl == null)
            {
                throw new ArgumentNullException("currentAvatarThumbnailImageUrl is a required property for User and cannot be null");
            }
            this.CurrentAvatarThumbnailImageUrl = currentAvatarThumbnailImageUrl;
            this.DateJoined = dateJoined;
            this.DeveloperType = developerType;
            // to ensure "displayName" is required (not null)
            if (displayName == null)
            {
                throw new ArgumentNullException("displayName is a required property for User and cannot be null");
            }
            this.DisplayName = displayName;
            // to ensure "friendKey" is required (not null)
            if (friendKey == null)
            {
                throw new ArgumentNullException("friendKey is a required property for User and cannot be null");
            }
            this.FriendKey = friendKey;
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for User and cannot be null");
            }
            this.Id = id;
            this.IsFriend = isFriend;
            // to ensure "lastActivity" is required (not null)
            if (lastActivity == null)
            {
                throw new ArgumentNullException("lastActivity is a required property for User and cannot be null");
            }
            this.LastActivity = lastActivity;
            // to ensure "lastLogin" is required (not null)
            if (lastLogin == null)
            {
                throw new ArgumentNullException("lastLogin is a required property for User and cannot be null");
            }
            this.LastLogin = lastLogin;
            // to ensure "lastPlatform" is required (not null)
            if (lastPlatform == null)
            {
                throw new ArgumentNullException("lastPlatform is a required property for User and cannot be null");
            }
            this.LastPlatform = lastPlatform;
            // to ensure "profilePicOverride" is required (not null)
            if (profilePicOverride == null)
            {
                throw new ArgumentNullException("profilePicOverride is a required property for User and cannot be null");
            }
            this.ProfilePicOverride = profilePicOverride;
            this.State = state;
            this.Status = status;
            // to ensure "statusDescription" is required (not null)
            if (statusDescription == null)
            {
                throw new ArgumentNullException("statusDescription is a required property for User and cannot be null");
            }
            this.StatusDescription = statusDescription;
            // to ensure "tags" is required (not null)
            if (tags == null)
            {
                throw new ArgumentNullException("tags is a required property for User and cannot be null");
            }
            this.Tags = tags;
            // to ensure "userIcon" is required (not null)
            if (userIcon == null)
            {
                throw new ArgumentNullException("userIcon is a required property for User and cannot be null");
            }
            this.UserIcon = userIcon;
            this.FriendRequestStatus = friendRequestStatus;
            this.InstanceId = instanceId;
            this.Location = location;
            this.Note = note;
            this.TravelingToInstance = travelingToInstance;
            this.TravelingToLocation = travelingToLocation;
            this.TravelingToWorld = travelingToWorld;
            this.Username = username;
            this.WorldId = worldId;
        }

        /// <summary>
        /// Gets or Sets AllowAvatarCopying
        /// </summary>
        [DataMember(Name = "allowAvatarCopying", IsRequired = true, EmitDefaultValue = true)]
        public bool AllowAvatarCopying { get; set; }

        /// <summary>
        /// Gets or Sets Bio
        /// </summary>
        [DataMember(Name = "bio", IsRequired = true, EmitDefaultValue = true)]
        public string Bio { get; set; }

        /// <summary>
        /// Gets or Sets BioLinks
        /// </summary>
        [DataMember(Name = "bioLinks", IsRequired = true, EmitDefaultValue = true)]
        public List<string> BioLinks { get; set; }

        /// <summary>
        /// When profilePicOverride is not empty, use it instead.
        /// </summary>
        /// <value>When profilePicOverride is not empty, use it instead.</value>
        [DataMember(Name = "currentAvatarImageUrl", IsRequired = true, EmitDefaultValue = true)]
        public string CurrentAvatarImageUrl { get; set; }

        /// <summary>
        /// When profilePicOverride is not empty, use it instead.
        /// </summary>
        /// <value>When profilePicOverride is not empty, use it instead.</value>
        [DataMember(Name = "currentAvatarThumbnailImageUrl", IsRequired = true, EmitDefaultValue = true)]
        public string CurrentAvatarThumbnailImageUrl { get; set; }

        /// <summary>
        /// Gets or Sets DateJoined
        /// </summary>
        [DataMember(Name = "date_joined", IsRequired = true, EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime DateJoined { get; set; }

        /// <summary>
        /// A users visual display name. This is what shows up in-game, and can different from their &#x60;username&#x60;. Changing display name is restricted to a cooldown period.
        /// </summary>
        /// <value>A users visual display name. This is what shows up in-game, and can different from their &#x60;username&#x60;. Changing display name is restricted to a cooldown period.</value>
        [DataMember(Name = "displayName", IsRequired = true, EmitDefaultValue = true)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets FriendKey
        /// </summary>
        [DataMember(Name = "friendKey", IsRequired = true, EmitDefaultValue = true)]
        public string FriendKey { get; set; }

        /// <summary>
        /// Gets or Sets FriendRequestStatus
        /// </summary>
        [DataMember(Name = "friendRequestStatus", EmitDefaultValue = false)]
        public string FriendRequestStatus { get; set; }

        /// <summary>
        /// A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed.
        /// </summary>
        /// <value>A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// InstanceID can be \&quot;offline\&quot; on User profiles if you are not friends with that user and \&quot;private\&quot; if you are friends and user is in private instance.
        /// </summary>
        /// <value>InstanceID can be \&quot;offline\&quot; on User profiles if you are not friends with that user and \&quot;private\&quot; if you are friends and user is in private instance.</value>
        [DataMember(Name = "instanceId", EmitDefaultValue = false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Either their &#x60;friendKey&#x60;, or empty string if you are not friends. Unknown usage.
        /// </summary>
        /// <value>Either their &#x60;friendKey&#x60;, or empty string if you are not friends. Unknown usage.</value>
        [DataMember(Name = "isFriend", IsRequired = true, EmitDefaultValue = true)]
        public bool IsFriend { get; set; }

        /// <summary>
        /// Either a date-time or empty string.
        /// </summary>
        /// <value>Either a date-time or empty string.</value>
        [DataMember(Name = "last_activity", IsRequired = true, EmitDefaultValue = true)]
        public string LastActivity { get; set; }

        /// <summary>
        /// Either a date-time or empty string.
        /// </summary>
        /// <value>Either a date-time or empty string.</value>
        [DataMember(Name = "last_login", IsRequired = true, EmitDefaultValue = true)]
        public string LastLogin { get; set; }

        /// <summary>
        /// This can be &#x60;standalonewindows&#x60; or &#x60;android&#x60;, but can also pretty much be any random Unity verison such as &#x60;2019.2.4-801-Release&#x60; or &#x60;2019.2.2-772-Release&#x60; or even &#x60;unknownplatform&#x60;.
        /// </summary>
        /// <value>This can be &#x60;standalonewindows&#x60; or &#x60;android&#x60;, but can also pretty much be any random Unity verison such as &#x60;2019.2.4-801-Release&#x60; or &#x60;2019.2.2-772-Release&#x60; or even &#x60;unknownplatform&#x60;.</value>
        [DataMember(Name = "last_platform", IsRequired = true, EmitDefaultValue = true)]
        public string LastPlatform { get; set; }

        /// <summary>
        /// WorldID be \&quot;offline\&quot; on User profiles if you are not friends with that user.
        /// </summary>
        /// <value>WorldID be \&quot;offline\&quot; on User profiles if you are not friends with that user.</value>
        [DataMember(Name = "location", EmitDefaultValue = false)]
        public string Location { get; set; }

        /// <summary>
        /// Gets or Sets Note
        /// </summary>
        [DataMember(Name = "note", EmitDefaultValue = false)]
        public string Note { get; set; }

        /// <summary>
        /// Gets or Sets ProfilePicOverride
        /// </summary>
        [DataMember(Name = "profilePicOverride", IsRequired = true, EmitDefaultValue = true)]
        public string ProfilePicOverride { get; set; }

        /// <summary>
        /// Gets or Sets StatusDescription
        /// </summary>
        [DataMember(Name = "statusDescription", IsRequired = true, EmitDefaultValue = true)]
        public string StatusDescription { get; set; }

        /// <summary>
        ///  
        /// </summary>
        /// <value> </value>
        [DataMember(Name = "tags", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Tags { get; set; }

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
        /// Gets or Sets UserIcon
        /// </summary>
        [DataMember(Name = "userIcon", IsRequired = true, EmitDefaultValue = true)]
        public string UserIcon { get; set; }

        /// <summary>
        /// -| A users unique name, used during login. This is different from &#x60;displayName&#x60; which is what shows up in-game. A users &#x60;username&#x60; can never be changed.&#39; **DEPRECATED:** VRChat API no longer return usernames of other users. [See issue by Tupper for more information](https://github.com/pypy-vrc/VRCX/issues/429).
        /// </summary>
        /// <value>-| A users unique name, used during login. This is different from &#x60;displayName&#x60; which is what shows up in-game. A users &#x60;username&#x60; can never be changed.&#39; **DEPRECATED:** VRChat API no longer return usernames of other users. [See issue by Tupper for more information](https://github.com/pypy-vrc/VRCX/issues/429).</value>
        [DataMember(Name = "username", EmitDefaultValue = false)]
        [Obsolete]
        public string Username { get; set; }

        /// <summary>
        /// WorldID be \&quot;offline\&quot; on User profiles if you are not friends with that user.
        /// </summary>
        /// <value>WorldID be \&quot;offline\&quot; on User profiles if you are not friends with that user.</value>
        [DataMember(Name = "worldId", EmitDefaultValue = false)]
        public string WorldId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class User {\n");
            sb.Append("  AllowAvatarCopying: ").Append(AllowAvatarCopying).Append("\n");
            sb.Append("  Bio: ").Append(Bio).Append("\n");
            sb.Append("  BioLinks: ").Append(BioLinks).Append("\n");
            sb.Append("  CurrentAvatarImageUrl: ").Append(CurrentAvatarImageUrl).Append("\n");
            sb.Append("  CurrentAvatarThumbnailImageUrl: ").Append(CurrentAvatarThumbnailImageUrl).Append("\n");
            sb.Append("  DateJoined: ").Append(DateJoined).Append("\n");
            sb.Append("  DeveloperType: ").Append(DeveloperType).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  FriendKey: ").Append(FriendKey).Append("\n");
            sb.Append("  FriendRequestStatus: ").Append(FriendRequestStatus).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  InstanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  IsFriend: ").Append(IsFriend).Append("\n");
            sb.Append("  LastActivity: ").Append(LastActivity).Append("\n");
            sb.Append("  LastLogin: ").Append(LastLogin).Append("\n");
            sb.Append("  LastPlatform: ").Append(LastPlatform).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
            sb.Append("  ProfilePicOverride: ").Append(ProfilePicOverride).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StatusDescription: ").Append(StatusDescription).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  TravelingToInstance: ").Append(TravelingToInstance).Append("\n");
            sb.Append("  TravelingToLocation: ").Append(TravelingToLocation).Append("\n");
            sb.Append("  TravelingToWorld: ").Append(TravelingToWorld).Append("\n");
            sb.Append("  UserIcon: ").Append(UserIcon).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
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
            return this.Equals(input as User);
        }

        /// <summary>
        /// Returns true if User instances are equal
        /// </summary>
        /// <param name="input">Instance of User to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(User input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AllowAvatarCopying == input.AllowAvatarCopying ||
                    this.AllowAvatarCopying.Equals(input.AllowAvatarCopying)
                ) && 
                (
                    this.Bio == input.Bio ||
                    (this.Bio != null &&
                    this.Bio.Equals(input.Bio))
                ) && 
                (
                    this.BioLinks == input.BioLinks ||
                    this.BioLinks != null &&
                    input.BioLinks != null &&
                    this.BioLinks.SequenceEqual(input.BioLinks)
                ) && 
                (
                    this.CurrentAvatarImageUrl == input.CurrentAvatarImageUrl ||
                    (this.CurrentAvatarImageUrl != null &&
                    this.CurrentAvatarImageUrl.Equals(input.CurrentAvatarImageUrl))
                ) && 
                (
                    this.CurrentAvatarThumbnailImageUrl == input.CurrentAvatarThumbnailImageUrl ||
                    (this.CurrentAvatarThumbnailImageUrl != null &&
                    this.CurrentAvatarThumbnailImageUrl.Equals(input.CurrentAvatarThumbnailImageUrl))
                ) && 
                (
                    this.DateJoined == input.DateJoined ||
                    (this.DateJoined != null &&
                    this.DateJoined.Equals(input.DateJoined))
                ) && 
                (
                    this.DeveloperType == input.DeveloperType ||
                    this.DeveloperType.Equals(input.DeveloperType)
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.FriendKey == input.FriendKey ||
                    (this.FriendKey != null &&
                    this.FriendKey.Equals(input.FriendKey))
                ) && 
                (
                    this.FriendRequestStatus == input.FriendRequestStatus ||
                    (this.FriendRequestStatus != null &&
                    this.FriendRequestStatus.Equals(input.FriendRequestStatus))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.InstanceId == input.InstanceId ||
                    (this.InstanceId != null &&
                    this.InstanceId.Equals(input.InstanceId))
                ) && 
                (
                    this.IsFriend == input.IsFriend ||
                    this.IsFriend.Equals(input.IsFriend)
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
                    this.LastPlatform == input.LastPlatform ||
                    (this.LastPlatform != null &&
                    this.LastPlatform.Equals(input.LastPlatform))
                ) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && 
                (
                    this.Note == input.Note ||
                    (this.Note != null &&
                    this.Note.Equals(input.Note))
                ) && 
                (
                    this.ProfilePicOverride == input.ProfilePicOverride ||
                    (this.ProfilePicOverride != null &&
                    this.ProfilePicOverride.Equals(input.ProfilePicOverride))
                ) && 
                (
                    this.State == input.State ||
                    this.State.Equals(input.State)
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.StatusDescription == input.StatusDescription ||
                    (this.StatusDescription != null &&
                    this.StatusDescription.Equals(input.StatusDescription))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
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
                    this.UserIcon == input.UserIcon ||
                    (this.UserIcon != null &&
                    this.UserIcon.Equals(input.UserIcon))
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
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
                hashCode = (hashCode * 59) + this.AllowAvatarCopying.GetHashCode();
                if (this.Bio != null)
                {
                    hashCode = (hashCode * 59) + this.Bio.GetHashCode();
                }
                if (this.BioLinks != null)
                {
                    hashCode = (hashCode * 59) + this.BioLinks.GetHashCode();
                }
                if (this.CurrentAvatarImageUrl != null)
                {
                    hashCode = (hashCode * 59) + this.CurrentAvatarImageUrl.GetHashCode();
                }
                if (this.CurrentAvatarThumbnailImageUrl != null)
                {
                    hashCode = (hashCode * 59) + this.CurrentAvatarThumbnailImageUrl.GetHashCode();
                }
                if (this.DateJoined != null)
                {
                    hashCode = (hashCode * 59) + this.DateJoined.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.DeveloperType.GetHashCode();
                if (this.DisplayName != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayName.GetHashCode();
                }
                if (this.FriendKey != null)
                {
                    hashCode = (hashCode * 59) + this.FriendKey.GetHashCode();
                }
                if (this.FriendRequestStatus != null)
                {
                    hashCode = (hashCode * 59) + this.FriendRequestStatus.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.InstanceId != null)
                {
                    hashCode = (hashCode * 59) + this.InstanceId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsFriend.GetHashCode();
                if (this.LastActivity != null)
                {
                    hashCode = (hashCode * 59) + this.LastActivity.GetHashCode();
                }
                if (this.LastLogin != null)
                {
                    hashCode = (hashCode * 59) + this.LastLogin.GetHashCode();
                }
                if (this.LastPlatform != null)
                {
                    hashCode = (hashCode * 59) + this.LastPlatform.GetHashCode();
                }
                if (this.Location != null)
                {
                    hashCode = (hashCode * 59) + this.Location.GetHashCode();
                }
                if (this.Note != null)
                {
                    hashCode = (hashCode * 59) + this.Note.GetHashCode();
                }
                if (this.ProfilePicOverride != null)
                {
                    hashCode = (hashCode * 59) + this.ProfilePicOverride.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.State.GetHashCode();
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.StatusDescription != null)
                {
                    hashCode = (hashCode * 59) + this.StatusDescription.GetHashCode();
                }
                if (this.Tags != null)
                {
                    hashCode = (hashCode * 59) + this.Tags.GetHashCode();
                }
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
                if (this.UserIcon != null)
                {
                    hashCode = (hashCode * 59) + this.UserIcon.GetHashCode();
                }
                if (this.Username != null)
                {
                    hashCode = (hashCode * 59) + this.Username.GetHashCode();
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
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            // Bio (string) maxLength
            if (this.Bio != null && this.Bio.Length > 512)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Bio, length must be less than 512.", new [] { "Bio" });
            }

            // Bio (string) minLength
            if (this.Bio != null && this.Bio.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Bio, length must be greater than 0.", new [] { "Bio" });
            }

            // InstanceId (string) pattern
            Regex regexInstanceId = new Regex(@"(private|offline|(wrld|wld)_[0-9a-fA-F]{8}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{12}:(\\d+)(~region\\(([\\w]+)\\))?(~([\\w]+)\\(usr_([\\w-]+)\\)((\\~canRequestInvite)?)(~region\\(([\\w].+)\\))?~nonce\\((.+)\\))?)", RegexOptions.CultureInvariant);
            if (false == regexInstanceId.Match(this.InstanceId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for InstanceId, must match a pattern of " + regexInstanceId, new [] { "InstanceId" });
            }

            // Location (string) pattern
            Regex regexLocation = new Regex(@"(^$|offline|(wrld|wld)_[0-9a-fA-F]{8}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{12})", RegexOptions.CultureInvariant);
            if (false == regexLocation.Match(this.Location).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Location, must match a pattern of " + regexLocation, new [] { "Location" });
            }

            // WorldId (string) pattern
            Regex regexWorldId = new Regex(@"(^$|offline|(wrld|wld)_[0-9a-fA-F]{8}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{12})", RegexOptions.CultureInvariant);
            if (false == regexWorldId.Match(this.WorldId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for WorldId, must match a pattern of " + regexWorldId, new [] { "WorldId" });
            }

            yield break;
        }
    }

}
