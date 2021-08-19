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
    /// PlayerModeration
    /// </summary>
    [DataContract]
    public partial class PlayerModeration :  IEquatable<PlayerModeration>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public PlayerModerationType Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerModeration" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PlayerModeration() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerModeration" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="type">type (required).</param>
        /// <param name="sourceDisplayName">sourceDisplayName (required).</param>
        /// <param name="targetDisplayName">targetDisplayName (required).</param>
        /// <param name="created">created (required).</param>
        public PlayerModeration(string id = default(string), PlayerModerationType type = default(PlayerModerationType), string sourceDisplayName = default(string), string targetDisplayName = default(string), DateTime created = default(DateTime))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for PlayerModeration and cannot be null");
            }
            else
            {
                this.Id = id;
            }

            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for PlayerModeration and cannot be null");
            }
            else
            {
                this.Type = type;
            }

            // to ensure "sourceDisplayName" is required (not null)
            if (sourceDisplayName == null)
            {
                throw new InvalidDataException("sourceDisplayName is a required property for PlayerModeration and cannot be null");
            }
            else
            {
                this.SourceDisplayName = sourceDisplayName;
            }

            // to ensure "targetDisplayName" is required (not null)
            if (targetDisplayName == null)
            {
                throw new InvalidDataException("targetDisplayName is a required property for PlayerModeration and cannot be null");
            }
            else
            {
                this.TargetDisplayName = targetDisplayName;
            }

            // to ensure "created" is required (not null)
            if (created == null)
            {
                throw new InvalidDataException("created is a required property for PlayerModeration and cannot be null");
            }
            else
            {
                this.Created = created;
            }

        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public string Id { get; set; }


        /// <summary>
        /// Gets or Sets SourceUserId
        /// </summary>
        [DataMember(Name="sourceUserId", EmitDefaultValue=true)]
        public string SourceUserId { get; private set; }

        /// <summary>
        /// Gets or Sets SourceDisplayName
        /// </summary>
        [DataMember(Name="sourceDisplayName", EmitDefaultValue=true)]
        public string SourceDisplayName { get; set; }

        /// <summary>
        /// Gets or Sets TargetUserId
        /// </summary>
        [DataMember(Name="targetUserId", EmitDefaultValue=true)]
        public string TargetUserId { get; private set; }

        /// <summary>
        /// Gets or Sets TargetDisplayName
        /// </summary>
        [DataMember(Name="targetDisplayName", EmitDefaultValue=true)]
        public string TargetDisplayName { get; set; }

        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name="created", EmitDefaultValue=true)]
        public DateTime Created { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PlayerModeration {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  SourceUserId: ").Append(SourceUserId).Append("\n");
            sb.Append("  SourceDisplayName: ").Append(SourceDisplayName).Append("\n");
            sb.Append("  TargetUserId: ").Append(TargetUserId).Append("\n");
            sb.Append("  TargetDisplayName: ").Append(TargetDisplayName).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
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
            return this.Equals(input as PlayerModeration);
        }

        /// <summary>
        /// Returns true if PlayerModeration instances are equal
        /// </summary>
        /// <param name="input">Instance of PlayerModeration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PlayerModeration input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.SourceUserId == input.SourceUserId ||
                    (this.SourceUserId != null &&
                    this.SourceUserId.Equals(input.SourceUserId))
                ) && 
                (
                    this.SourceDisplayName == input.SourceDisplayName ||
                    (this.SourceDisplayName != null &&
                    this.SourceDisplayName.Equals(input.SourceDisplayName))
                ) && 
                (
                    this.TargetUserId == input.TargetUserId ||
                    (this.TargetUserId != null &&
                    this.TargetUserId.Equals(input.TargetUserId))
                ) && 
                (
                    this.TargetDisplayName == input.TargetDisplayName ||
                    (this.TargetDisplayName != null &&
                    this.TargetDisplayName.Equals(input.TargetDisplayName))
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.SourceUserId != null)
                    hashCode = hashCode * 59 + this.SourceUserId.GetHashCode();
                if (this.SourceDisplayName != null)
                    hashCode = hashCode * 59 + this.SourceDisplayName.GetHashCode();
                if (this.TargetUserId != null)
                    hashCode = hashCode * 59 + this.TargetUserId.GetHashCode();
                if (this.TargetDisplayName != null)
                    hashCode = hashCode * 59 + this.TargetDisplayName.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
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

 
            // Id (string) pattern
            Regex regexId = new Regex(@"pmod_[0-9a-fA-F]{8}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{12}", RegexOptions.CultureInvariant);
            if (false == regexId.Match(this.Id).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, must match a pattern of " + regexId, new [] { "Id" });
            }


            // SourceDisplayName (string) minLength
            if(this.SourceDisplayName != null && this.SourceDisplayName.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SourceDisplayName, length must be greater than 1.", new [] { "SourceDisplayName" });
            }
 

            // TargetDisplayName (string) minLength
            if(this.TargetDisplayName != null && this.TargetDisplayName.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TargetDisplayName, length must be greater than 1.", new [] { "TargetDisplayName" });
            }
 
            yield break;
        }
    }

}
