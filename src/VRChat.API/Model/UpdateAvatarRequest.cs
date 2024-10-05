/*
 * VRChat API Documentation
 *
 *
 * The version of the OpenAPI document: 1.18.5
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
    /// UpdateAvatarRequest
    /// </summary>
    [DataContract(Name = "UpdateAvatarRequest")]
    public partial class UpdateAvatarRequest : IEquatable<UpdateAvatarRequest>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets ReleaseStatus
        /// </summary>
        [DataMember(Name = "releaseStatus", EmitDefaultValue = false)]
        public ReleaseStatus? ReleaseStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAvatarRequest" /> class.
        /// </summary>
        /// <param name="assetUrl">assetUrl.</param>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="description">description.</param>
        /// <param name="tags"> .</param>
        /// <param name="imageUrl">imageUrl.</param>
        /// <param name="releaseStatus">releaseStatus.</param>
        /// <param name="version">version (default to 1).</param>
        /// <param name="unityPackageUrl">unityPackageUrl.</param>
        /// <param name="unityVersion">unityVersion (default to &quot;5.3.4p1&quot;).</param>
        public UpdateAvatarRequest(string assetUrl = default(string), string id = default(string), string name = default(string), string description = default(string), List<string> tags = default(List<string>), string imageUrl = default(string), ReleaseStatus? releaseStatus = default(ReleaseStatus?), int version = 1, string unityPackageUrl = default(string), string unityVersion = "5.3.4p1")
        {
            this.AssetUrl = assetUrl;
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Tags = tags;
            this.ImageUrl = imageUrl;
            this.ReleaseStatus = releaseStatus;
            this._Version = version;
            this.UnityPackageUrl = unityPackageUrl;
            // use default value if no "unityVersion" provided
            this.UnityVersion = unityVersion ?? "5.3.4p1";
        }

        /// <summary>
        /// Gets or Sets AssetUrl
        /// </summary>
        [DataMember(Name = "assetUrl", EmitDefaultValue = false)]
        public string AssetUrl { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        ///  
        /// </summary>
        /// <value> </value>
        [DataMember(Name = "tags", EmitDefaultValue = false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Gets or Sets ImageUrl
        /// </summary>
        [DataMember(Name = "imageUrl", EmitDefaultValue = false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// Gets or Sets _Version
        /// </summary>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public int _Version { get; set; }

        /// <summary>
        /// Gets or Sets UnityPackageUrl
        /// </summary>
        [DataMember(Name = "unityPackageUrl", EmitDefaultValue = false)]
        public string UnityPackageUrl { get; set; }

        /// <summary>
        /// Gets or Sets UnityVersion
        /// </summary>
        [DataMember(Name = "unityVersion", EmitDefaultValue = false)]
        public string UnityVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdateAvatarRequest {\n");
            sb.Append("  AssetUrl: ").Append(AssetUrl).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("  ReleaseStatus: ").Append(ReleaseStatus).Append("\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
            sb.Append("  UnityPackageUrl: ").Append(UnityPackageUrl).Append("\n");
            sb.Append("  UnityVersion: ").Append(UnityVersion).Append("\n");
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
            return this.Equals(input as UpdateAvatarRequest);
        }

        /// <summary>
        /// Returns true if UpdateAvatarRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateAvatarRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateAvatarRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AssetUrl == input.AssetUrl ||
                    (this.AssetUrl != null &&
                    this.AssetUrl.Equals(input.AssetUrl))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.ImageUrl == input.ImageUrl ||
                    (this.ImageUrl != null &&
                    this.ImageUrl.Equals(input.ImageUrl))
                ) && 
                (
                    this.ReleaseStatus == input.ReleaseStatus ||
                    this.ReleaseStatus.Equals(input.ReleaseStatus)
                ) && 
                (
                    this._Version == input._Version ||
                    this._Version.Equals(input._Version)
                ) && 
                (
                    this.UnityPackageUrl == input.UnityPackageUrl ||
                    (this.UnityPackageUrl != null &&
                    this.UnityPackageUrl.Equals(input.UnityPackageUrl))
                ) && 
                (
                    this.UnityVersion == input.UnityVersion ||
                    (this.UnityVersion != null &&
                    this.UnityVersion.Equals(input.UnityVersion))
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
                if (this.AssetUrl != null)
                {
                    hashCode = (hashCode * 59) + this.AssetUrl.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Tags != null)
                {
                    hashCode = (hashCode * 59) + this.Tags.GetHashCode();
                }
                if (this.ImageUrl != null)
                {
                    hashCode = (hashCode * 59) + this.ImageUrl.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ReleaseStatus.GetHashCode();
                hashCode = (hashCode * 59) + this._Version.GetHashCode();
                if (this.UnityPackageUrl != null)
                {
                    hashCode = (hashCode * 59) + this.UnityPackageUrl.GetHashCode();
                }
                if (this.UnityVersion != null)
                {
                    hashCode = (hashCode * 59) + this.UnityVersion.GetHashCode();
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
            // Name (string) minLength
            if (this.Name != null && this.Name.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
            }

            // Description (string) minLength
            if (this.Description != null && this.Description.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be greater than 1.", new [] { "Description" });
            }

            // ImageUrl (string) minLength
            if (this.ImageUrl != null && this.ImageUrl.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ImageUrl, length must be greater than 1.", new [] { "ImageUrl" });
            }

            // _Version (int) minimum
            if (this._Version < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for _Version, must be a value greater than or equal to 0.", new [] { "_Version" });
            }

            // UnityVersion (string) minLength
            if (this.UnityVersion != null && this.UnityVersion.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for UnityVersion, length must be greater than 1.", new [] { "UnityVersion" });
            }

            yield break;
        }
    }

}
