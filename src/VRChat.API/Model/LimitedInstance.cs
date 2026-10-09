

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
    /// LimitedInstance
    /// </summary>
    [DataContract(Name = "LimitedInstance")]
    public partial class LimitedInstance : IEquatable<LimitedInstance>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets GroupAccessType
        /// </summary>
        [DataMember(Name = "groupAccessType", EmitDefaultValue = false)]
        public GroupAccessType? GroupAccessType { get; set; }

        /// <summary>
        /// Gets or Sets PhotonRegion
        /// </summary>
        [DataMember(Name = "photonRegion", IsRequired = true, EmitDefaultValue = true)]
        public Region PhotonRegion { get; set; }

        /// <summary>
        /// Gets or Sets Region
        /// </summary>
        [DataMember(Name = "region", IsRequired = true, EmitDefaultValue = true)]
        public InstanceRegion Region { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public InstanceType Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="LimitedInstance" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LimitedInstance() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LimitedInstance" /> class.
        /// </summary>
        /// <param name="active">active (required) (default to true).</param>
        /// <param name="capacity">capacity (required).</param>
        /// <param name="categoryId">categoryId (required).</param>
        /// <param name="creationLanguages">creationLanguages (required).</param>
        /// <param name="description">description (required).</param>
        /// <param name="disabledPropAbilities">disabledPropAbilities (required).</param>
        /// <param name="displayName">displayName (required).</param>
        /// <param name="displayVibeId">displayVibeId (required).</param>
        /// <param name="dominantLanguage">dominantLanguage (required).</param>
        /// <param name="full">full (required) (default to false).</param>
        /// <param name="groupAccessType">groupAccessType.</param>
        /// <param name="id">InstanceID can be \&quot;offline\&quot; on User profiles if you are not friends with that user and \&quot;private\&quot; if you are friends and user is in private instance. (required).</param>
        /// <param name="instanceId">InstanceID can be \&quot;offline\&quot; on User profiles if you are not friends with that user and \&quot;private\&quot; if you are friends and user is in private instance. (required).</param>
        /// <param name="languageRatio">languageRatio (required).</param>
        /// <param name="languages">The keys of languageRatio, ordered by their share of the instance. (required).</param>
        /// <param name="languagesIso639">languagesIso639 (required).</param>
        /// <param name="location">Represents a unique location, consisting of a world identifier and an instance identifier, or \&quot;offline\&quot; if the user is not on your friends list. (required).</param>
        /// <param name="minimumAvatarPerformance">minimumAvatarPerformance (required).</param>
        /// <param name="nUsers">nUsers (required).</param>
        /// <param name="ownerId">A groupId if the instance type is \&quot;group\&quot;, null if instance type is public, or a userId otherwise (required).</param>
        /// <param name="permanent">permanent (required) (default to false).</param>
        /// <param name="photonRegion">photonRegion (required).</param>
        /// <param name="platforms">platforms (required).</param>
        /// <param name="queueEnabled">queueEnabled (required).</param>
        /// <param name="queueSize">queueSize (required).</param>
        /// <param name="recommendedCapacity">recommendedCapacity (required).</param>
        /// <param name="region">region (required).</param>
        /// <param name="roleRestricted">roleRestricted.</param>
        /// <param name="shortName">shortName (required).</param>
        /// <param name="tags">The tags array on Instances usually contain the language tags of the people in the instance.  (required).</param>
        /// <param name="type">type (required).</param>
        /// <param name="userCount">userCount (required).</param>
        /// <param name="userIcons">userIcons (required).</param>
        /// <param name="vibeIds">vibeIds (required).</param>
        /// <param name="world">world (required).</param>
        /// <param name="worldId">WorldID be \&quot;offline\&quot; on User profiles if you are not friends with that user. (required).</param>
        public LimitedInstance(bool active = true, int capacity = default, string categoryId = default, List<Object> creationLanguages = default, string description = default, List<Object> disabledPropAbilities = default, string displayName = default, string displayVibeId = default, string dominantLanguage = default, bool full = false, GroupAccessType? groupAccessType = default, string id = default, string instanceId = default, Dictionary<string, Object> languageRatio = default, List<string> languages = default, List<string> languagesIso639 = default, string location = default, string minimumAvatarPerformance = default, int nUsers = default, string ownerId = default, bool permanent = false, Region photonRegion = default, InstancePlatforms platforms = default, bool queueEnabled = default, int queueSize = default, int recommendedCapacity = default, InstanceRegion region = default, bool roleRestricted = default, string shortName = default, List<string> tags = default, InstanceType type = default, int userCount = default, List<string> userIcons = default, List<string> vibeIds = default, World world = default, string worldId = default)
        {
            this.Active = active;
            this.Capacity = capacity;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.CategoryId = categoryId;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.CreationLanguages = creationLanguages;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Description = description;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.DisabledPropAbilities = disabledPropAbilities;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.DisplayName = displayName;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.DisplayVibeId = displayVibeId;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.DominantLanguage = dominantLanguage;
            this.Full = full;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Id = id;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.InstanceId = instanceId;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.LanguageRatio = languageRatio;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Languages = languages;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.LanguagesIso639 = languagesIso639;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Location = location;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.MinimumAvatarPerformance = minimumAvatarPerformance;
            this.NUsers = nUsers;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.OwnerId = ownerId;
            this.Permanent = permanent;
            this.PhotonRegion = photonRegion;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Platforms = platforms;
            this.QueueEnabled = queueEnabled;
            this.QueueSize = queueSize;
            this.RecommendedCapacity = recommendedCapacity;
            this.Region = region;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.ShortName = shortName;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Tags = tags;
            this.Type = type;
            this.UserCount = userCount;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.UserIcons = userIcons;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.VibeIds = vibeIds;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.World = world;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.WorldId = worldId;
            this.GroupAccessType = groupAccessType;
            this.RoleRestricted = roleRestricted;
        }

        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name = "active", IsRequired = true, EmitDefaultValue = true)]
        public bool Active { get; set; }

        /// <summary>
        /// Gets or Sets Capacity
        /// </summary>
        [DataMember(Name = "capacity", IsRequired = true, EmitDefaultValue = true)]
        public int Capacity { get; set; }

        /// <summary>
        /// Gets or Sets CategoryId
        /// </summary>
        [DataMember(Name = "categoryId", IsRequired = true, EmitDefaultValue = true)]
        public string CategoryId { get; set; }

        /// <summary>
        /// Gets or Sets CreationLanguages
        /// </summary>
        [DataMember(Name = "creationLanguages", IsRequired = true, EmitDefaultValue = true)]
        public List<Object> CreationLanguages { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets DisabledPropAbilities
        /// </summary>
        [DataMember(Name = "disabledPropAbilities", IsRequired = true, EmitDefaultValue = true)]
        public List<Object> DisabledPropAbilities { get; set; }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name = "displayName", IsRequired = true, EmitDefaultValue = true)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets DisplayVibeId
        /// </summary>
        [DataMember(Name = "displayVibeId", IsRequired = true, EmitDefaultValue = true)]
        public string DisplayVibeId { get; set; }

        /// <summary>
        /// Gets or Sets DominantLanguage
        /// </summary>
        [DataMember(Name = "dominantLanguage", IsRequired = true, EmitDefaultValue = true)]
        public string DominantLanguage { get; set; }

        /// <summary>
        /// Gets or Sets Full
        /// </summary>
        [DataMember(Name = "full", IsRequired = true, EmitDefaultValue = true)]
        public bool Full { get; set; }

        /// <summary>
        /// InstanceID can be \&quot;offline\&quot; on User profiles if you are not friends with that user and \&quot;private\&quot; if you are friends and user is in private instance.
        /// </summary>
        /// <value>InstanceID can be \&quot;offline\&quot; on User profiles if you are not friends with that user and \&quot;private\&quot; if you are friends and user is in private instance.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// InstanceID can be \&quot;offline\&quot; on User profiles if you are not friends with that user and \&quot;private\&quot; if you are friends and user is in private instance.
        /// </summary>
        /// <value>InstanceID can be \&quot;offline\&quot; on User profiles if you are not friends with that user and \&quot;private\&quot; if you are friends and user is in private instance.</value>
        [DataMember(Name = "instanceId", IsRequired = true, EmitDefaultValue = true)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Gets or Sets LanguageRatio
        /// </summary>
        [DataMember(Name = "languageRatio", IsRequired = true, EmitDefaultValue = true)]
        public Dictionary<string, Object> LanguageRatio { get; set; }

        /// <summary>
        /// The keys of languageRatio, ordered by their share of the instance.
        /// </summary>
        /// <value>The keys of languageRatio, ordered by their share of the instance.</value>
        [DataMember(Name = "languages", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Languages { get; set; }

        /// <summary>
        /// Gets or Sets LanguagesIso639
        /// </summary>
        [DataMember(Name = "languagesIso639", IsRequired = true, EmitDefaultValue = true)]
        public List<string> LanguagesIso639 { get; set; }

        /// <summary>
        /// Represents a unique location, consisting of a world identifier and an instance identifier, or \&quot;offline\&quot; if the user is not on your friends list.
        /// </summary>
        /// <value>Represents a unique location, consisting of a world identifier and an instance identifier, or \&quot;offline\&quot; if the user is not on your friends list.</value>
        [DataMember(Name = "location", IsRequired = true, EmitDefaultValue = true)]
        public string Location { get; set; }

        /// <summary>
        /// Gets or Sets MinimumAvatarPerformance
        /// </summary>
        [DataMember(Name = "minimumAvatarPerformance", IsRequired = true, EmitDefaultValue = true)]
        public string MinimumAvatarPerformance { get; set; }

        /// <summary>
        /// Gets or Sets NUsers
        /// </summary>
        [DataMember(Name = "n_users", IsRequired = true, EmitDefaultValue = true)]
        public int NUsers { get; set; }

        /// <summary>
        /// A groupId if the instance type is \&quot;group\&quot;, null if instance type is public, or a userId otherwise
        /// </summary>
        /// <value>A groupId if the instance type is \&quot;group\&quot;, null if instance type is public, or a userId otherwise</value>
        [DataMember(Name = "ownerId", IsRequired = true, EmitDefaultValue = true)]
        public string OwnerId { get; set; }

        /// <summary>
        /// Gets or Sets Permanent
        /// </summary>
        [DataMember(Name = "permanent", IsRequired = true, EmitDefaultValue = true)]
        public bool Permanent { get; set; }

        /// <summary>
        /// Gets or Sets Platforms
        /// </summary>
        [DataMember(Name = "platforms", IsRequired = true, EmitDefaultValue = true)]
        public InstancePlatforms Platforms { get; set; }

        /// <summary>
        /// Gets or Sets QueueEnabled
        /// </summary>
        [DataMember(Name = "queueEnabled", IsRequired = true, EmitDefaultValue = true)]
        public bool QueueEnabled { get; set; }

        /// <summary>
        /// Gets or Sets QueueSize
        /// </summary>
        [DataMember(Name = "queueSize", IsRequired = true, EmitDefaultValue = true)]
        public int QueueSize { get; set; }

        /// <summary>
        /// Gets or Sets RecommendedCapacity
        /// </summary>
        [DataMember(Name = "recommendedCapacity", IsRequired = true, EmitDefaultValue = true)]
        public int RecommendedCapacity { get; set; }

        /// <summary>
        /// Gets or Sets RoleRestricted
        /// </summary>
        [DataMember(Name = "roleRestricted", EmitDefaultValue = true)]
        public bool RoleRestricted { get; set; }

        /// <summary>
        /// Gets or Sets ShortName
        /// </summary>
        [DataMember(Name = "shortName", IsRequired = true, EmitDefaultValue = true)]
        public string ShortName { get; set; }

        /// <summary>
        /// The tags array on Instances usually contain the language tags of the people in the instance. 
        /// </summary>
        /// <value>The tags array on Instances usually contain the language tags of the people in the instance. </value>
        [DataMember(Name = "tags", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Gets or Sets UserCount
        /// </summary>
        [DataMember(Name = "userCount", IsRequired = true, EmitDefaultValue = true)]
        public int UserCount { get; set; }

        /// <summary>
        /// Gets or Sets UserIcons
        /// </summary>
        [DataMember(Name = "userIcons", IsRequired = true, EmitDefaultValue = true)]
        public List<string> UserIcons { get; set; }

        /// <summary>
        /// Gets or Sets VibeIds
        /// </summary>
        [DataMember(Name = "vibeIds", IsRequired = true, EmitDefaultValue = true)]
        public List<string> VibeIds { get; set; }

        /// <summary>
        /// Gets or Sets World
        /// </summary>
        [DataMember(Name = "world", IsRequired = true, EmitDefaultValue = true)]
        public World World { get; set; }

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
            sb.Append("class LimitedInstance {\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  Capacity: ").Append(Capacity).Append("\n");
            sb.Append("  CategoryId: ").Append(CategoryId).Append("\n");
            sb.Append("  CreationLanguages: ").Append(CreationLanguages).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DisabledPropAbilities: ").Append(DisabledPropAbilities).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  DisplayVibeId: ").Append(DisplayVibeId).Append("\n");
            sb.Append("  DominantLanguage: ").Append(DominantLanguage).Append("\n");
            sb.Append("  Full: ").Append(Full).Append("\n");
            sb.Append("  GroupAccessType: ").Append(GroupAccessType).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  InstanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  LanguageRatio: ").Append(LanguageRatio).Append("\n");
            sb.Append("  Languages: ").Append(Languages).Append("\n");
            sb.Append("  LanguagesIso639: ").Append(LanguagesIso639).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  MinimumAvatarPerformance: ").Append(MinimumAvatarPerformance).Append("\n");
            sb.Append("  NUsers: ").Append(NUsers).Append("\n");
            sb.Append("  OwnerId: ").Append(OwnerId).Append("\n");
            sb.Append("  Permanent: ").Append(Permanent).Append("\n");
            sb.Append("  PhotonRegion: ").Append(PhotonRegion).Append("\n");
            sb.Append("  Platforms: ").Append(Platforms).Append("\n");
            sb.Append("  QueueEnabled: ").Append(QueueEnabled).Append("\n");
            sb.Append("  QueueSize: ").Append(QueueSize).Append("\n");
            sb.Append("  RecommendedCapacity: ").Append(RecommendedCapacity).Append("\n");
            sb.Append("  Region: ").Append(Region).Append("\n");
            sb.Append("  RoleRestricted: ").Append(RoleRestricted).Append("\n");
            sb.Append("  ShortName: ").Append(ShortName).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  UserCount: ").Append(UserCount).Append("\n");
            sb.Append("  UserIcons: ").Append(UserIcons).Append("\n");
            sb.Append("  VibeIds: ").Append(VibeIds).Append("\n");
            sb.Append("  World: ").Append(World).Append("\n");
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
            return this.Equals(input as LimitedInstance);
        }

        /// <summary>
        /// Returns true if LimitedInstance instances are equal
        /// </summary>
        /// <param name="input">Instance of LimitedInstance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LimitedInstance input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Active == input.Active ||
                    this.Active.Equals(input.Active)
                ) && 
                (
                    this.Capacity == input.Capacity ||
                    this.Capacity.Equals(input.Capacity)
                ) && 
                (
                    this.CategoryId == input.CategoryId ||
                    (this.CategoryId != null &&
                    this.CategoryId.Equals(input.CategoryId))
                ) && 
                (
                    this.CreationLanguages == input.CreationLanguages ||
                    this.CreationLanguages != null &&
                    input.CreationLanguages != null &&
                    this.CreationLanguages.SequenceEqual(input.CreationLanguages)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.DisabledPropAbilities == input.DisabledPropAbilities ||
                    this.DisabledPropAbilities != null &&
                    input.DisabledPropAbilities != null &&
                    this.DisabledPropAbilities.SequenceEqual(input.DisabledPropAbilities)
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.DisplayVibeId == input.DisplayVibeId ||
                    (this.DisplayVibeId != null &&
                    this.DisplayVibeId.Equals(input.DisplayVibeId))
                ) && 
                (
                    this.DominantLanguage == input.DominantLanguage ||
                    (this.DominantLanguage != null &&
                    this.DominantLanguage.Equals(input.DominantLanguage))
                ) && 
                (
                    this.Full == input.Full ||
                    this.Full.Equals(input.Full)
                ) && 
                (
                    this.GroupAccessType == input.GroupAccessType ||
                    this.GroupAccessType.Equals(input.GroupAccessType)
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
                    this.LanguageRatio == input.LanguageRatio ||
                    this.LanguageRatio != null &&
                    input.LanguageRatio != null &&
                    this.LanguageRatio.SequenceEqual(input.LanguageRatio)
                ) && 
                (
                    this.Languages == input.Languages ||
                    this.Languages != null &&
                    input.Languages != null &&
                    this.Languages.SequenceEqual(input.Languages)
                ) && 
                (
                    this.LanguagesIso639 == input.LanguagesIso639 ||
                    this.LanguagesIso639 != null &&
                    input.LanguagesIso639 != null &&
                    this.LanguagesIso639.SequenceEqual(input.LanguagesIso639)
                ) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && 
                (
                    this.MinimumAvatarPerformance == input.MinimumAvatarPerformance ||
                    (this.MinimumAvatarPerformance != null &&
                    this.MinimumAvatarPerformance.Equals(input.MinimumAvatarPerformance))
                ) && 
                (
                    this.NUsers == input.NUsers ||
                    this.NUsers.Equals(input.NUsers)
                ) && 
                (
                    this.OwnerId == input.OwnerId ||
                    (this.OwnerId != null &&
                    this.OwnerId.Equals(input.OwnerId))
                ) && 
                (
                    this.Permanent == input.Permanent ||
                    this.Permanent.Equals(input.Permanent)
                ) && 
                (
                    this.PhotonRegion == input.PhotonRegion ||
                    this.PhotonRegion.Equals(input.PhotonRegion)
                ) && 
                (
                    this.Platforms == input.Platforms ||
                    (this.Platforms != null &&
                    this.Platforms.Equals(input.Platforms))
                ) && 
                (
                    this.QueueEnabled == input.QueueEnabled ||
                    this.QueueEnabled.Equals(input.QueueEnabled)
                ) && 
                (
                    this.QueueSize == input.QueueSize ||
                    this.QueueSize.Equals(input.QueueSize)
                ) && 
                (
                    this.RecommendedCapacity == input.RecommendedCapacity ||
                    this.RecommendedCapacity.Equals(input.RecommendedCapacity)
                ) && 
                (
                    this.Region == input.Region ||
                    this.Region.Equals(input.Region)
                ) && 
                (
                    this.RoleRestricted == input.RoleRestricted ||
                    this.RoleRestricted.Equals(input.RoleRestricted)
                ) && 
                (
                    this.ShortName == input.ShortName ||
                    (this.ShortName != null &&
                    this.ShortName.Equals(input.ShortName))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.UserCount == input.UserCount ||
                    this.UserCount.Equals(input.UserCount)
                ) && 
                (
                    this.UserIcons == input.UserIcons ||
                    this.UserIcons != null &&
                    input.UserIcons != null &&
                    this.UserIcons.SequenceEqual(input.UserIcons)
                ) && 
                (
                    this.VibeIds == input.VibeIds ||
                    this.VibeIds != null &&
                    input.VibeIds != null &&
                    this.VibeIds.SequenceEqual(input.VibeIds)
                ) && 
                (
                    this.World == input.World ||
                    (this.World != null &&
                    this.World.Equals(input.World))
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
                hashCode = (hashCode * 59) + this.Active.GetHashCode();
                hashCode = (hashCode * 59) + this.Capacity.GetHashCode();
                if (this.CategoryId != null)
                {
                    hashCode = (hashCode * 59) + this.CategoryId.GetHashCode();
                }
                if (this.CreationLanguages != null)
                {
                    hashCode = (hashCode * 59) + this.CreationLanguages.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.DisabledPropAbilities != null)
                {
                    hashCode = (hashCode * 59) + this.DisabledPropAbilities.GetHashCode();
                }
                if (this.DisplayName != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayName.GetHashCode();
                }
                if (this.DisplayVibeId != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayVibeId.GetHashCode();
                }
                if (this.DominantLanguage != null)
                {
                    hashCode = (hashCode * 59) + this.DominantLanguage.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Full.GetHashCode();
                hashCode = (hashCode * 59) + this.GroupAccessType.GetHashCode();
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.InstanceId != null)
                {
                    hashCode = (hashCode * 59) + this.InstanceId.GetHashCode();
                }
                if (this.LanguageRatio != null)
                {
                    hashCode = (hashCode * 59) + this.LanguageRatio.GetHashCode();
                }
                if (this.Languages != null)
                {
                    hashCode = (hashCode * 59) + this.Languages.GetHashCode();
                }
                if (this.LanguagesIso639 != null)
                {
                    hashCode = (hashCode * 59) + this.LanguagesIso639.GetHashCode();
                }
                if (this.Location != null)
                {
                    hashCode = (hashCode * 59) + this.Location.GetHashCode();
                }
                if (this.MinimumAvatarPerformance != null)
                {
                    hashCode = (hashCode * 59) + this.MinimumAvatarPerformance.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.NUsers.GetHashCode();
                if (this.OwnerId != null)
                {
                    hashCode = (hashCode * 59) + this.OwnerId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Permanent.GetHashCode();
                hashCode = (hashCode * 59) + this.PhotonRegion.GetHashCode();
                if (this.Platforms != null)
                {
                    hashCode = (hashCode * 59) + this.Platforms.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.QueueEnabled.GetHashCode();
                hashCode = (hashCode * 59) + this.QueueSize.GetHashCode();
                hashCode = (hashCode * 59) + this.RecommendedCapacity.GetHashCode();
                hashCode = (hashCode * 59) + this.Region.GetHashCode();
                hashCode = (hashCode * 59) + this.RoleRestricted.GetHashCode();
                if (this.ShortName != null)
                {
                    hashCode = (hashCode * 59) + this.ShortName.GetHashCode();
                }
                if (this.Tags != null)
                {
                    hashCode = (hashCode * 59) + this.Tags.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                hashCode = (hashCode * 59) + this.UserCount.GetHashCode();
                if (this.UserIcons != null)
                {
                    hashCode = (hashCode * 59) + this.UserIcons.GetHashCode();
                }
                if (this.VibeIds != null)
                {
                    hashCode = (hashCode * 59) + this.VibeIds.GetHashCode();
                }
                if (this.World != null)
                {
                    hashCode = (hashCode * 59) + this.World.GetHashCode();
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
            // Capacity (int) minimum
            if (this.Capacity < (int)0)
            {
                yield return new ValidationResult("Invalid value for Capacity, must be a value greater than or equal to 0.", new [] { "Capacity" });
            }

            // NUsers (int) minimum
            if (this.NUsers < (int)0)
            {
                yield return new ValidationResult("Invalid value for NUsers, must be a value greater than or equal to 0.", new [] { "NUsers" });
            }

            // QueueSize (int) minimum
            if (this.QueueSize < (int)0)
            {
                yield return new ValidationResult("Invalid value for QueueSize, must be a value greater than or equal to 0.", new [] { "QueueSize" });
            }

            // RecommendedCapacity (int) minimum
            if (this.RecommendedCapacity < (int)0)
            {
                yield return new ValidationResult("Invalid value for RecommendedCapacity, must be a value greater than or equal to 0.", new [] { "RecommendedCapacity" });
            }

            // ShortName (string) minLength
            if (this.ShortName != null && this.ShortName.Length < 1)
            {
                yield return new ValidationResult("Invalid value for ShortName, length must be greater than 1.", new [] { "ShortName" });
            }

            // UserCount (int) minimum
            if (this.UserCount < (int)0)
            {
                yield return new ValidationResult("Invalid value for UserCount, must be a value greater than or equal to 0.", new [] { "UserCount" });
            }

            yield break;
        }
    }

}
