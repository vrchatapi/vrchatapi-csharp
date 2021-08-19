/*
 * VRChat API Documentation
 *
 * ![VRChat API Banner](https://vrchatapi.github.io/assets/img/api_banner_1500x400.png)  # Welcome to the VRChat API  Before we begin, we would like to state this is a **COMMUNITY DRIVEN PROJECT**. This means that everything you read on here was written by the community itself, and is **not** officially supported by VRChat. The documentation and additional libraries SHALL ONLY be used for applications interacting with VRChat's API, in accordance with their [Terms of Service](https://github.com/VRChatAPI), and MUST NOT be used for modifying the client, \"avatar ripping\", or other illegal activities.  This documentation is provided \"AS IS\", and any action you take towards VRChat is completely your own responsibility. Malicious usage or spamming the API may result in account termination. Certain parts of the API are also more sensitive than others, for example moderation, so please read tread extra carefully and read the warnings when present.  ![Tupper Policy on API](https://i.imgur.com/yLlW7Ok.png)  Finally, use of the API using applications other than the approved methods (website, VRChat application, Unity SDK) is not officially supported. VRChat provides no guarantee for external applications using the API. Access to API endpoints may break **at any time, without notice**. We will make a best effort in keeping this documentation and associated language libraries up to date, but things might be outdated or missing. If you find that something is no longer valid, please contact us on Discord or [create an issue](https://github.com/vrchatapi/specification/issues) and tell us so we can fix it.  # Getting Started  The VRChat API can be used to programatically retrive or update information regarding your profile, friends, avatars, worlds and more. The API consists of two parts, \"Photon\" which is only used in-game, and the \"Web API\" which is used by both the game and the website. This documentation focuses only on the Web API.  The API is designed around the REST ideology, providing semi-simple and usually predictable URIs to access and modify objects. Requests support standard HTTP methods like GET, PUT, POST, and DELETE and standard status codes. Response bodies are always UTF-8 encoded JSON objects, unless explicitly documented otherwise.  <div class=\"callout callout-error\">   <strong>🛑 Warning! Do not touch Photon!</strong><br>   Photon is only used by the in-game client and should <b>not</b> be touched. Doing so may result in permanent account termination. </div>  <div class=\"callout callout-info\">   <strong>ℹ️ API Key and Authentication</strong><br>   The API Key has always been the same, and is currently <code>JlE5Jldo5Jibnk5O5hTx6XVqsJu4WJ26</code>.   Read <a href=\"#tag- -authentication\">Authentication</a> for how to log in. </div>  # Using the API  For simply exploring what the API can do it is strongly recommended to download [Insomnia](https://insomnia.rest/download), a free and open-source API client that's great for sending requests to the API in an orderly fashion. Insomnia allows you to send data in the format that's required for VRChat's API. It is also possible to try out the API in your browser, by first logging in at [vrchat.com/home](https://vrchat.com/home/) and then going to [vrchat.com/api/1/auth/user](https://vrchat.com/api/1/auth/user), but the information will be much harder to work with.  For more permanent operation such as software development it is instead recommended to use one of the existing language SDKs. This community project maintain API libraries in several languages, which allows you to interact with the API with simple function calls rather than having to implement the HTTP protocol yourself. Most of these libraries are automatically generated from the API specification, sometimes with additional helpful wrapper code to make usage easier. This allows them to be almost automatically updated and expanded upon as soon as a new feature is introduced in the specification itself. The libraries can be found on [GitHub](https://github.com/vrchatapi) or following:  * [NodeJS (JavaScript)](https://www.npmjs.com/package/vrchat) * [Dart](https://pub.dev/packages/vrchat_dart) * [Rust](https://crates.io/crates/vrchatapi) * [C#](github.com/vrchatapi/vrchatapi-csharp) * [Python](https://github.com/vrchatapi/VRChatPython)  # Pagination  Most endpoints enforce pagination, meaning they will only return 10 entries by default, and never more than 100.<br> Using both the limit and offset parameters allows you to easily paginate through a large number of objects.  | Query Parameter | Type | Description | | - -- -- -- -- -|- -|- -- -- -- | | `limit` | integer  | The number of objects to return. This value often defaults to 10. Highest limit is always 100.| | `offset` | integer  | A zero-based offset from the default object sorting.|  If a request returns fewer objects than the `limit` parameter, there are no more items available to return.  # Contribution  Do you want to get involved in the documentation effort? Do you want to help improve one of the language API libraries? This project is an [OPEN Open Source Project](https://openopensource.org)! This means that individuals making significant and valuable contributions are given commit-access to the project. It also means we are very open and welcoming of new people making contributions, unlike some more guarded open source projects.  [![Discord](https://img.shields.io/static/v1?label=vrchatapi&message=discord&color=blueviolet&style=for-the-badge)](https://discord.gg/qjZE9C9fkB)
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: me@ruby.js.org
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = io.github.vrchatapi.Client.OpenAPIDateConverter;

namespace io.github.vrchatapi.Model
{
    /// <summary>
    /// Instance
    /// </summary>
    [DataContract]
    public partial class Instance :  IEquatable<Instance>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Instance" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Instance() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Instance" /> class.
        /// </summary>
        /// <param name="active">active (required) (default to true).</param>
        /// <param name="canRequestInvite">canRequestInvite (required) (default to true).</param>
        /// <param name="capacity">capacity (required).</param>
        /// <param name="clientNumber">clientNumber (required).</param>
        /// <param name="full">full (required) (default to false).</param>
        /// <param name="id">id (required).</param>
        /// <param name="instanceId">instanceId (required).</param>
        /// <param name="location">location (required).</param>
        /// <param name="nUsers">nUsers (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="nonce">nonce.</param>
        /// <param name="permanent">permanent (required) (default to false).</param>
        /// <param name="photonRegion">photonRegion (required).</param>
        /// <param name="platforms">platforms (required).</param>
        /// <param name="region">region (required).</param>
        /// <param name="shortName">shortName (required).</param>
        /// <param name="tags">tags (required).</param>
        /// <param name="type">type (required).</param>
        /// <param name="users">Always empty on non-existing instances, and non-present on existing instances..</param>
        /// <param name="world">Only present on non-existing instances, and only contains a very small subject of World object. Use World API instead..</param>
        /// <param name="worldId">worldId (required).</param>
        public Instance(bool active = true, bool canRequestInvite = true, decimal capacity = default(decimal), string clientNumber = default(string), bool full = false, string id = default(string), string instanceId = default(string), string location = default(string), decimal nUsers = default(decimal), string name = default(string), string nonce = default(string), bool permanent = false, string photonRegion = default(string), InstancePlatforms platforms = default(InstancePlatforms), string region = default(string), string shortName = default(string), List<string> tags = default(List<string>), string type = default(string), List<Object> users = default(List<Object>), Object world = default(Object), string worldId = default(string))
        {
            // to ensure "active" is required (not null)
            if (active == null)
            {
                throw new InvalidDataException("active is a required property for Instance and cannot be null");
            }
            else
            {
                this.Active = active;
            }

            // to ensure "canRequestInvite" is required (not null)
            if (canRequestInvite == null)
            {
                throw new InvalidDataException("canRequestInvite is a required property for Instance and cannot be null");
            }
            else
            {
                this.CanRequestInvite = canRequestInvite;
            }

            // to ensure "capacity" is required (not null)
            if (capacity == null)
            {
                throw new InvalidDataException("capacity is a required property for Instance and cannot be null");
            }
            else
            {
                this.Capacity = capacity;
            }

            // to ensure "clientNumber" is required (not null)
            if (clientNumber == null)
            {
                throw new InvalidDataException("clientNumber is a required property for Instance and cannot be null");
            }
            else
            {
                this.ClientNumber = clientNumber;
            }

            // to ensure "full" is required (not null)
            if (full == null)
            {
                throw new InvalidDataException("full is a required property for Instance and cannot be null");
            }
            else
            {
                this.Full = full;
            }

            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for Instance and cannot be null");
            }
            else
            {
                this.Id = id;
            }

            // to ensure "instanceId" is required (not null)
            if (instanceId == null)
            {
                throw new InvalidDataException("instanceId is a required property for Instance and cannot be null");
            }
            else
            {
                this.InstanceId = instanceId;
            }

            // to ensure "location" is required (not null)
            if (location == null)
            {
                throw new InvalidDataException("location is a required property for Instance and cannot be null");
            }
            else
            {
                this.Location = location;
            }

            // to ensure "nUsers" is required (not null)
            if (nUsers == null)
            {
                throw new InvalidDataException("nUsers is a required property for Instance and cannot be null");
            }
            else
            {
                this.NUsers = nUsers;
            }

            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for Instance and cannot be null");
            }
            else
            {
                this.Name = name;
            }

            // to ensure "permanent" is required (not null)
            if (permanent == null)
            {
                throw new InvalidDataException("permanent is a required property for Instance and cannot be null");
            }
            else
            {
                this.Permanent = permanent;
            }

            // to ensure "photonRegion" is required (not null)
            if (photonRegion == null)
            {
                throw new InvalidDataException("photonRegion is a required property for Instance and cannot be null");
            }
            else
            {
                this.PhotonRegion = photonRegion;
            }

            // to ensure "platforms" is required (not null)
            if (platforms == null)
            {
                throw new InvalidDataException("platforms is a required property for Instance and cannot be null");
            }
            else
            {
                this.Platforms = platforms;
            }

            // to ensure "region" is required (not null)
            if (region == null)
            {
                throw new InvalidDataException("region is a required property for Instance and cannot be null");
            }
            else
            {
                this.Region = region;
            }

            // to ensure "shortName" is required (not null)
            if (shortName == null)
            {
                throw new InvalidDataException("shortName is a required property for Instance and cannot be null");
            }
            else
            {
                this.ShortName = shortName;
            }

            // to ensure "tags" is required (not null)
            if (tags == null)
            {
                throw new InvalidDataException("tags is a required property for Instance and cannot be null");
            }
            else
            {
                this.Tags = tags;
            }

            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for Instance and cannot be null");
            }
            else
            {
                this.Type = type;
            }

            // to ensure "worldId" is required (not null)
            if (worldId == null)
            {
                throw new InvalidDataException("worldId is a required property for Instance and cannot be null");
            }
            else
            {
                this.WorldId = worldId;
            }

            this.Nonce = nonce;
            this.Users = users;
            this.World = world;
        }

        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name="active", EmitDefaultValue=true)]
        public bool Active { get; set; }

        /// <summary>
        /// Gets or Sets CanRequestInvite
        /// </summary>
        [DataMember(Name="canRequestInvite", EmitDefaultValue=true)]
        public bool CanRequestInvite { get; set; }

        /// <summary>
        /// Gets or Sets Capacity
        /// </summary>
        [DataMember(Name="capacity", EmitDefaultValue=true)]
        public decimal Capacity { get; set; }

        /// <summary>
        /// Gets or Sets ClientNumber
        /// </summary>
        [DataMember(Name="clientNumber", EmitDefaultValue=true)]
        public string ClientNumber { get; set; }

        /// <summary>
        /// Gets or Sets Full
        /// </summary>
        [DataMember(Name="full", EmitDefaultValue=true)]
        public bool Full { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets InstanceId
        /// </summary>
        [DataMember(Name="instanceId", EmitDefaultValue=true)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name="location", EmitDefaultValue=true)]
        public string Location { get; set; }

        /// <summary>
        /// Gets or Sets NUsers
        /// </summary>
        [DataMember(Name="n_users", EmitDefaultValue=true)]
        public decimal NUsers { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Nonce
        /// </summary>
        [DataMember(Name="nonce", EmitDefaultValue=false)]
        public string Nonce { get; set; }

        /// <summary>
        /// Gets or Sets OwnerId
        /// </summary>
        [DataMember(Name="ownerId", EmitDefaultValue=true)]
        public string OwnerId { get; private set; }

        /// <summary>
        /// Gets or Sets Permanent
        /// </summary>
        [DataMember(Name="permanent", EmitDefaultValue=true)]
        public bool Permanent { get; set; }

        /// <summary>
        /// Gets or Sets PhotonRegion
        /// </summary>
        [DataMember(Name="photonRegion", EmitDefaultValue=true)]
        public string PhotonRegion { get; set; }

        /// <summary>
        /// Gets or Sets Platforms
        /// </summary>
        [DataMember(Name="platforms", EmitDefaultValue=true)]
        public InstancePlatforms Platforms { get; set; }

        /// <summary>
        /// Gets or Sets Region
        /// </summary>
        [DataMember(Name="region", EmitDefaultValue=true)]
        public string Region { get; set; }

        /// <summary>
        /// Gets or Sets ShortName
        /// </summary>
        [DataMember(Name="shortName", EmitDefaultValue=true)]
        public string ShortName { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name="tags", EmitDefaultValue=true)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public string Type { get; set; }

        /// <summary>
        /// Always empty on non-existing instances, and non-present on existing instances.
        /// </summary>
        /// <value>Always empty on non-existing instances, and non-present on existing instances.</value>
        [DataMember(Name="users", EmitDefaultValue=false)]
        public List<Object> Users { get; set; }

        /// <summary>
        /// Only present on non-existing instances, and only contains a very small subject of World object. Use World API instead.
        /// </summary>
        /// <value>Only present on non-existing instances, and only contains a very small subject of World object. Use World API instead.</value>
        [DataMember(Name="world", EmitDefaultValue=false)]
        public Object World { get; set; }

        /// <summary>
        /// Gets or Sets WorldId
        /// </summary>
        [DataMember(Name="worldId", EmitDefaultValue=true)]
        public string WorldId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Instance {\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  CanRequestInvite: ").Append(CanRequestInvite).Append("\n");
            sb.Append("  Capacity: ").Append(Capacity).Append("\n");
            sb.Append("  ClientNumber: ").Append(ClientNumber).Append("\n");
            sb.Append("  Full: ").Append(Full).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  InstanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  NUsers: ").Append(NUsers).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Nonce: ").Append(Nonce).Append("\n");
            sb.Append("  OwnerId: ").Append(OwnerId).Append("\n");
            sb.Append("  Permanent: ").Append(Permanent).Append("\n");
            sb.Append("  PhotonRegion: ").Append(PhotonRegion).Append("\n");
            sb.Append("  Platforms: ").Append(Platforms).Append("\n");
            sb.Append("  Region: ").Append(Region).Append("\n");
            sb.Append("  ShortName: ").Append(ShortName).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Users: ").Append(Users).Append("\n");
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
            return this.Equals(input as Instance);
        }

        /// <summary>
        /// Returns true if Instance instances are equal
        /// </summary>
        /// <param name="input">Instance of Instance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Instance input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Active == input.Active ||
                    (this.Active != null &&
                    this.Active.Equals(input.Active))
                ) && 
                (
                    this.CanRequestInvite == input.CanRequestInvite ||
                    (this.CanRequestInvite != null &&
                    this.CanRequestInvite.Equals(input.CanRequestInvite))
                ) && 
                (
                    this.Capacity == input.Capacity ||
                    (this.Capacity != null &&
                    this.Capacity.Equals(input.Capacity))
                ) && 
                (
                    this.ClientNumber == input.ClientNumber ||
                    (this.ClientNumber != null &&
                    this.ClientNumber.Equals(input.ClientNumber))
                ) && 
                (
                    this.Full == input.Full ||
                    (this.Full != null &&
                    this.Full.Equals(input.Full))
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
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && 
                (
                    this.NUsers == input.NUsers ||
                    (this.NUsers != null &&
                    this.NUsers.Equals(input.NUsers))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Nonce == input.Nonce ||
                    (this.Nonce != null &&
                    this.Nonce.Equals(input.Nonce))
                ) && 
                (
                    this.OwnerId == input.OwnerId ||
                    (this.OwnerId != null &&
                    this.OwnerId.Equals(input.OwnerId))
                ) && 
                (
                    this.Permanent == input.Permanent ||
                    (this.Permanent != null &&
                    this.Permanent.Equals(input.Permanent))
                ) && 
                (
                    this.PhotonRegion == input.PhotonRegion ||
                    (this.PhotonRegion != null &&
                    this.PhotonRegion.Equals(input.PhotonRegion))
                ) && 
                (
                    this.Platforms == input.Platforms ||
                    (this.Platforms != null &&
                    this.Platforms.Equals(input.Platforms))
                ) && 
                (
                    this.Region == input.Region ||
                    (this.Region != null &&
                    this.Region.Equals(input.Region))
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
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Users == input.Users ||
                    this.Users != null &&
                    input.Users != null &&
                    this.Users.SequenceEqual(input.Users)
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
                if (this.Active != null)
                    hashCode = hashCode * 59 + this.Active.GetHashCode();
                if (this.CanRequestInvite != null)
                    hashCode = hashCode * 59 + this.CanRequestInvite.GetHashCode();
                if (this.Capacity != null)
                    hashCode = hashCode * 59 + this.Capacity.GetHashCode();
                if (this.ClientNumber != null)
                    hashCode = hashCode * 59 + this.ClientNumber.GetHashCode();
                if (this.Full != null)
                    hashCode = hashCode * 59 + this.Full.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.InstanceId != null)
                    hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.NUsers != null)
                    hashCode = hashCode * 59 + this.NUsers.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Nonce != null)
                    hashCode = hashCode * 59 + this.Nonce.GetHashCode();
                if (this.OwnerId != null)
                    hashCode = hashCode * 59 + this.OwnerId.GetHashCode();
                if (this.Permanent != null)
                    hashCode = hashCode * 59 + this.Permanent.GetHashCode();
                if (this.PhotonRegion != null)
                    hashCode = hashCode * 59 + this.PhotonRegion.GetHashCode();
                if (this.Platforms != null)
                    hashCode = hashCode * 59 + this.Platforms.GetHashCode();
                if (this.Region != null)
                    hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.ShortName != null)
                    hashCode = hashCode * 59 + this.ShortName.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Users != null)
                    hashCode = hashCode * 59 + this.Users.GetHashCode();
                if (this.World != null)
                    hashCode = hashCode * 59 + this.World.GetHashCode();
                if (this.WorldId != null)
                    hashCode = hashCode * 59 + this.WorldId.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {

 
            // Capacity (decimal) maximum
            if(this.Capacity > (decimal)40)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Capacity, must be a value less than or equal to 40.", new [] { "Capacity" });
            }

            // Capacity (decimal) minimum
            if(this.Capacity < (decimal)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Capacity, must be a value greater than or equal to 0.", new [] { "Capacity" });
            }


            // ClientNumber (string) minLength
            if(this.ClientNumber != null && this.ClientNumber.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ClientNumber, length must be greater than 1.", new [] { "ClientNumber" });
            }
 

            // Id (string) minLength
            if(this.Id != null && this.Id.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, length must be greater than 1.", new [] { "Id" });
            }
 

            // InstanceId (string) minLength
            if(this.InstanceId != null && this.InstanceId.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for InstanceId, length must be greater than 1.", new [] { "InstanceId" });
            }
 

            // Location (string) minLength
            if(this.Location != null && this.Location.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Location, length must be greater than 1.", new [] { "Location" });
            }
 

 
            // NUsers (decimal) minimum
            if(this.NUsers < (decimal)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for NUsers, must be a value greater than or equal to 0.", new [] { "NUsers" });
            }


            // Name (string) minLength
            if(this.Name != null && this.Name.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
            }
 

            // Nonce (string) minLength
            if(this.Nonce != null && this.Nonce.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Nonce, length must be greater than 1.", new [] { "Nonce" });
            }
 

            // PhotonRegion (string) minLength
            if(this.PhotonRegion != null && this.PhotonRegion.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PhotonRegion, length must be greater than 1.", new [] { "PhotonRegion" });
            }
 

            // Region (string) minLength
            if(this.Region != null && this.Region.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Region, length must be greater than 1.", new [] { "Region" });
            }
 

            // ShortName (string) minLength
            if(this.ShortName != null && this.ShortName.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ShortName, length must be greater than 1.", new [] { "ShortName" });
            }
 

            // Type (string) minLength
            if(this.Type != null && this.Type.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, length must be greater than 1.", new [] { "Type" });
            }
 

 
            // WorldId (string) pattern
            Regex regexWorldId = new Regex(@"(^$|offline|(wrld|wld)_[0-9a-fA-F]{8}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{12})", RegexOptions.CultureInvariant);
            if (false == regexWorldId.Match(this.WorldId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for WorldId, must match a pattern of " + regexWorldId, new [] { "WorldId" });
            }

            yield break;
        }
    }

}
