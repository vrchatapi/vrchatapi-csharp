/*
 * VRChat API Documentation
 *
 * ![VRChat API Banner](https://vrchatapi.github.io/assets/img/api_banner_1500x400.png)  # Welcome to the VRChat API  Before we begin, we would like to state this is a **COMMUNITY DRIVEN PROJECT**. This means that everything you read on here was written by the community itself and is **not** officially supported by VRChat. The documentation is provided \"AS IS\", and any action you take towards VRChat is completely your own responsibility.  The documentation and additional libraries SHALL ONLY be used for applications interacting with VRChat's API in accordance with their [Terms of Service](https://github.com/VRChatAPI), and MUST NOT be used for modifying the client, \"avatar ripping\", or other illegal activities. Malicious usage or spamming the API may result in account termination. Certain parts of the API are also more sensitive than others, for example moderation, so please read tread extra carefully and read the warnings when present.  ![Tupper Policy on API](https://i.imgur.com/yLlW7Ok.png)  Finally, use of the API using applications other than the approved methods (website, VRChat application, Unity SDK) is not officially supported. VRChat provides no guarantee or support for external applications using the API. Access to API endpoints may break **at any time, without notice**. Therefore, please **do not ping** VRChat Staff in the VRChat Discord if you are having API problems, as they do not provide API support. We will make a best effort in keeping this documentation and associated language libraries up to date, but things might be outdated or missing. If you find that something is no longer valid, please contact us on Discord or [create an issue](https://github.com/vrchatapi/specification/issues) and tell us so we can fix it.  # Getting Started  The VRChat API can be used to programmatically retrieve or update information regarding your profile, friends, avatars, worlds and more. The API consists of two parts, \"Photon\" which is only used in-game, and the \"Web API\" which is used by both the game and the website. This documentation focuses only on the Web API.  The API is designed around the REST ideology, providing semi-simple and usually predictable URIs to access and modify objects. Requests support standard HTTP methods like GET, PUT, POST, and DELETE and standard status codes. Response bodies are always UTF-8 encoded JSON objects, unless explicitly documented otherwise.  <div class=\"callout callout-error\">   <strong>🛑 Warning! Do not touch Photon!</strong><br>   Photon is only used by the in-game client and should <b>not</b> be touched. Doing so may result in permanent account termination. </div>  <div class=\"callout callout-info\">   <strong>ℹ️ API Key and Authentication</strong><br>   The API Key has always been the same and is currently <code>JlE5Jldo5Jibnk5O5hTx6XVqsJu4WJ26</code>.   Read <a href=\"#tag- -authentication\">Authentication</a> for how to log in. </div>  # Using the API  For simply exploring what the API can do it is strongly recommended to download [Insomnia](https://insomnia.rest/download), a free and open-source API client that's great for sending requests to the API in an orderly fashion. Insomnia allows you to send data in the format that's required for VRChat's API. It is also possible to try out the API in your browser, by first logging in at [vrchat.com/home](https://vrchat.com/home/) and then going to [vrchat.com/api/1/auth/user](https://vrchat.com/api/1/auth/user), but the information will be much harder to work with.  For more permanent operation such as software development it is instead recommended to use one of the existing language SDKs. This community project maintains API libraries in several languages, which allows you to interact with the API with simple function calls rather than having to implement the HTTP protocol yourself. Most of these libraries are automatically generated from the API specification, sometimes with additional helpful wrapper code to make usage easier. This allows them to be almost automatically updated and expanded upon as soon as a new feature is introduced in the specification itself. The libraries can be found on [GitHub](https://github.com/vrchatapi) or following:  * [NodeJS (JavaScript)](https://www.npmjs.com/package/vrchat) * [Dart](https://pub.dev/packages/vrchat_dart) * [Rust](https://crates.io/crates/vrchatapi) * [C#](github.com/vrchatapi/vrchatapi-csharp) * [Python](https://github.com/vrchatapi/VRChatPython)  # Pagination  Most endpoints enforce pagination, meaning they will only return 10 entries by default, and never more than 100.<br> Using both the limit and offset parameters allows you to easily paginate through a large number of objects.  | Query Parameter | Type | Description | | - -- -- -- -- -|- -|- -- -- -- | | `limit` | integer  | The number of objects to return. This value often defaults to 10. Highest limit is always 100.| | `offset` | integer  | A zero-based offset from the default object sorting.|  If a request returns fewer objects than the `limit` parameter, there are no more items available to return.  # Contribution  Do you want to get involved in the documentation effort? Do you want to help improve one of the language API libraries? This project is an [OPEN Open Source Project](https://openopensource.org)! This means that individuals making significant and valuable contributions are given commit-access to the project. It also means we are very open and welcoming of new people making contributions, unlike some more guarded open-source projects.  [![Discord](https://img.shields.io/static/v1?label=vrchatapi&message=discord&color=blueviolet&style=for-the-badge)](https://discord.gg/qjZE9C9fkB)
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
    /// UnityPackage
    /// </summary>
    [DataContract]
    public partial class UnityPackage :  IEquatable<UnityPackage>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Platform
        /// </summary>
        [DataMember(Name="platform", EmitDefaultValue=true)]
        public Platform Platform { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UnityPackage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UnityPackage() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UnityPackage" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="assetUrl">assetUrl.</param>
        /// <param name="assetUrlObject">assetUrlObject.</param>
        /// <param name="pluginUrl">pluginUrl.</param>
        /// <param name="pluginUrlObject">pluginUrlObject.</param>
        /// <param name="unityVersion">unityVersion (required) (default to &quot;5.3.4p1&quot;).</param>
        /// <param name="unitySortNumber">unitySortNumber.</param>
        /// <param name="assetVersion">assetVersion (required).</param>
        /// <param name="platform">platform (required).</param>
        /// <param name="createdAt">createdAt (required).</param>
        public UnityPackage(string id = default(string), string assetUrl = default(string), Object assetUrlObject = default(Object), string pluginUrl = default(string), Object pluginUrlObject = default(Object), string unityVersion = "5.3.4p1", decimal unitySortNumber = default(decimal), decimal assetVersion = default(decimal), Platform platform = default(Platform), DateTime createdAt = default(DateTime))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for UnityPackage and cannot be null");
            }
            else
            {
                this.Id = id;
            }

            // to ensure "unityVersion" is required (not null)
            if (unityVersion == null)
            {
                throw new InvalidDataException("unityVersion is a required property for UnityPackage and cannot be null");
            }
            else
            {
                this.UnityVersion = unityVersion;
            }

            // to ensure "assetVersion" is required (not null)
            if (assetVersion == null)
            {
                throw new InvalidDataException("assetVersion is a required property for UnityPackage and cannot be null");
            }
            else
            {
                this.AssetVersion = assetVersion;
            }

            // to ensure "platform" is required (not null)
            if (platform == null)
            {
                throw new InvalidDataException("platform is a required property for UnityPackage and cannot be null");
            }
            else
            {
                this.Platform = platform;
            }

            // to ensure "createdAt" is required (not null)
            if (createdAt == null)
            {
                throw new InvalidDataException("createdAt is a required property for UnityPackage and cannot be null");
            }
            else
            {
                this.CreatedAt = createdAt;
            }

            this.AssetUrl = assetUrl;
            this.AssetUrlObject = assetUrlObject;
            this.PluginUrl = pluginUrl;
            this.PluginUrlObject = pluginUrlObject;
            this.UnitySortNumber = unitySortNumber;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets AssetUrl
        /// </summary>
        [DataMember(Name="assetUrl", EmitDefaultValue=false)]
        public string AssetUrl { get; set; }

        /// <summary>
        /// Gets or Sets AssetUrlObject
        /// </summary>
        [DataMember(Name="assetUrlObject", EmitDefaultValue=false)]
        public Object AssetUrlObject { get; set; }

        /// <summary>
        /// Gets or Sets PluginUrl
        /// </summary>
        [DataMember(Name="pluginUrl", EmitDefaultValue=false)]
        public string PluginUrl { get; set; }

        /// <summary>
        /// Gets or Sets PluginUrlObject
        /// </summary>
        [DataMember(Name="pluginUrlObject", EmitDefaultValue=false)]
        public Object PluginUrlObject { get; set; }

        /// <summary>
        /// Gets or Sets UnityVersion
        /// </summary>
        [DataMember(Name="unityVersion", EmitDefaultValue=true)]
        public string UnityVersion { get; set; }

        /// <summary>
        /// Gets or Sets UnitySortNumber
        /// </summary>
        [DataMember(Name="unitySortNumber", EmitDefaultValue=false)]
        public decimal UnitySortNumber { get; set; }

        /// <summary>
        /// Gets or Sets AssetVersion
        /// </summary>
        [DataMember(Name="assetVersion", EmitDefaultValue=true)]
        public decimal AssetVersion { get; set; }


        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="created_at", EmitDefaultValue=true)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UnityPackage {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AssetUrl: ").Append(AssetUrl).Append("\n");
            sb.Append("  AssetUrlObject: ").Append(AssetUrlObject).Append("\n");
            sb.Append("  PluginUrl: ").Append(PluginUrl).Append("\n");
            sb.Append("  PluginUrlObject: ").Append(PluginUrlObject).Append("\n");
            sb.Append("  UnityVersion: ").Append(UnityVersion).Append("\n");
            sb.Append("  UnitySortNumber: ").Append(UnitySortNumber).Append("\n");
            sb.Append("  AssetVersion: ").Append(AssetVersion).Append("\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
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
            return this.Equals(input as UnityPackage);
        }

        /// <summary>
        /// Returns true if UnityPackage instances are equal
        /// </summary>
        /// <param name="input">Instance of UnityPackage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UnityPackage input)
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
                    this.AssetUrl == input.AssetUrl ||
                    (this.AssetUrl != null &&
                    this.AssetUrl.Equals(input.AssetUrl))
                ) && 
                (
                    this.AssetUrlObject == input.AssetUrlObject ||
                    (this.AssetUrlObject != null &&
                    this.AssetUrlObject.Equals(input.AssetUrlObject))
                ) && 
                (
                    this.PluginUrl == input.PluginUrl ||
                    (this.PluginUrl != null &&
                    this.PluginUrl.Equals(input.PluginUrl))
                ) && 
                (
                    this.PluginUrlObject == input.PluginUrlObject ||
                    (this.PluginUrlObject != null &&
                    this.PluginUrlObject.Equals(input.PluginUrlObject))
                ) && 
                (
                    this.UnityVersion == input.UnityVersion ||
                    (this.UnityVersion != null &&
                    this.UnityVersion.Equals(input.UnityVersion))
                ) && 
                (
                    this.UnitySortNumber == input.UnitySortNumber ||
                    (this.UnitySortNumber != null &&
                    this.UnitySortNumber.Equals(input.UnitySortNumber))
                ) && 
                (
                    this.AssetVersion == input.AssetVersion ||
                    (this.AssetVersion != null &&
                    this.AssetVersion.Equals(input.AssetVersion))
                ) && 
                (
                    this.Platform == input.Platform ||
                    (this.Platform != null &&
                    this.Platform.Equals(input.Platform))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
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
                if (this.AssetUrl != null)
                    hashCode = hashCode * 59 + this.AssetUrl.GetHashCode();
                if (this.AssetUrlObject != null)
                    hashCode = hashCode * 59 + this.AssetUrlObject.GetHashCode();
                if (this.PluginUrl != null)
                    hashCode = hashCode * 59 + this.PluginUrl.GetHashCode();
                if (this.PluginUrlObject != null)
                    hashCode = hashCode * 59 + this.PluginUrlObject.GetHashCode();
                if (this.UnityVersion != null)
                    hashCode = hashCode * 59 + this.UnityVersion.GetHashCode();
                if (this.UnitySortNumber != null)
                    hashCode = hashCode * 59 + this.UnitySortNumber.GetHashCode();
                if (this.AssetVersion != null)
                    hashCode = hashCode * 59 + this.AssetVersion.GetHashCode();
                if (this.Platform != null)
                    hashCode = hashCode * 59 + this.Platform.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
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
            Regex regexId = new Regex(@"(unp)_[0-9a-fA-F]{8}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{12}", RegexOptions.CultureInvariant);
            if (false == regexId.Match(this.Id).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, must match a pattern of " + regexId, new [] { "Id" });
            }


            // AssetUrl (string) minLength
            if(this.AssetUrl != null && this.AssetUrl.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AssetUrl, length must be greater than 1.", new [] { "AssetUrl" });
            }
 

            // UnityVersion (string) minLength
            if(this.UnityVersion != null && this.UnityVersion.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for UnityVersion, length must be greater than 1.", new [] { "UnityVersion" });
            }
 

 
            // UnitySortNumber (decimal) minimum
            if(this.UnitySortNumber < (decimal)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for UnitySortNumber, must be a value greater than or equal to 0.", new [] { "UnitySortNumber" });
            }

            yield break;
        }
    }

}
