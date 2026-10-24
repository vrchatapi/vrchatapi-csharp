

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
    /// DynamicContentRowWorlds
    /// </summary>
    [DataContract(Name = "DynamicContentRowWorlds")]
    public partial class DynamicContentRowWorlds : IEquatable<DynamicContentRowWorlds>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets SortOrder
        /// </summary>
        [DataMember(Name = "sortOrder", IsRequired = true, EmitDefaultValue = true)]
        public OrderOption SortOrder { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicContentRowWorlds" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DynamicContentRowWorlds() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicContentRowWorlds" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="platform">Usually \&quot;ThisPlatformSupported\&quot;, but can also be other values such as \&quot;all\&quot; or platform specific identifiers. (required).</param>
        /// <param name="avatarSpecific">avatarSpecific.</param>
        /// <param name="bannersTag">bannersTag.</param>
        /// <param name="index">index.</param>
        /// <param name="shortName">shortName.</param>
        /// <param name="sortHeading">sortHeading (required).</param>
        /// <param name="sortOrder">sortOrder (required).</param>
        /// <param name="sortOwnership">sortOwnership (required).</param>
        /// <param name="tag">Tag to filter content for this row. Not a &#x60;Tag&#x60;: that type forbids the empty string, which this field uses for a row that is not tag-filtered..</param>
        /// <param name="type">type.</param>
        public DynamicContentRowWorlds(LocalizableString name = default, string platform = default, bool? avatarSpecific = default, string bannersTag = default, int index = default, LocalizableString shortName = default, string sortHeading = default, OrderOption sortOrder = default, string sortOwnership = default, string tag = default, string type = default)
        {
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Name = name;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Platform = platform;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.SortHeading = sortHeading;
            this.SortOrder = sortOrder;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.SortOwnership = sortOwnership;
            this.AvatarSpecific = avatarSpecific;
            this.BannersTag = bannersTag;
            this.Index = index;
            this.ShortName = shortName;
            this.Tag = tag;
            this.Type = type;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public LocalizableString Name { get; set; }

        /// <summary>
        /// Usually \&quot;ThisPlatformSupported\&quot;, but can also be other values such as \&quot;all\&quot; or platform specific identifiers.
        /// </summary>
        /// <value>Usually \&quot;ThisPlatformSupported\&quot;, but can also be other values such as \&quot;all\&quot; or platform specific identifiers.</value>
        [DataMember(Name = "platform", IsRequired = true, EmitDefaultValue = true)]
        public string Platform { get; set; }

        /// <summary>
        /// Gets or Sets AvatarSpecific
        /// </summary>
        [DataMember(Name = "avatarSpecific", EmitDefaultValue = true)]
        public bool? AvatarSpecific { get; set; }

        /// <summary>
        /// Gets or Sets BannersTag
        /// </summary>
        [DataMember(Name = "bannersTag", EmitDefaultValue = false)]
        public string BannersTag { get; set; }

        /// <summary>
        /// Gets or Sets Index
        /// </summary>
        [DataMember(Name = "index", EmitDefaultValue = false)]
        public int Index { get; set; }

        /// <summary>
        /// Gets or Sets ShortName
        /// </summary>
        [DataMember(Name = "shortName", EmitDefaultValue = true)]
        public LocalizableString ShortName { get; set; }

        /// <summary>
        /// Gets or Sets SortHeading
        /// </summary>
        [DataMember(Name = "sortHeading", IsRequired = true, EmitDefaultValue = true)]
        public string SortHeading { get; set; }

        /// <summary>
        /// Gets or Sets SortOwnership
        /// </summary>
        [DataMember(Name = "sortOwnership", IsRequired = true, EmitDefaultValue = true)]
        public string SortOwnership { get; set; }

        /// <summary>
        /// Tag to filter content for this row. Not a &#x60;Tag&#x60;: that type forbids the empty string, which this field uses for a row that is not tag-filtered.
        /// </summary>
        /// <value>Tag to filter content for this row. Not a &#x60;Tag&#x60;: that type forbids the empty string, which this field uses for a row that is not tag-filtered.</value>
        [DataMember(Name = "tag", EmitDefaultValue = true)]
        public string Tag { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        [System.Runtime.Serialization.OnDeserialized]
        internal void OnDeserializedTypeNotEnum(System.Runtime.Serialization.StreamingContext context)
        {
            if (this.Type == "avatar" || this.Type == "events" || this.Type == "instances")
            {
                throw new ArgumentException("Invalid value for Type, must not be a value excluded by the 'not' schema.");
            }
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DynamicContentRowWorlds {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
            sb.Append("  AvatarSpecific: ").Append(AvatarSpecific).Append("\n");
            sb.Append("  BannersTag: ").Append(BannersTag).Append("\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  ShortName: ").Append(ShortName).Append("\n");
            sb.Append("  SortHeading: ").Append(SortHeading).Append("\n");
            sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
            sb.Append("  SortOwnership: ").Append(SortOwnership).Append("\n");
            sb.Append("  Tag: ").Append(Tag).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as DynamicContentRowWorlds);
        }

        /// <summary>
        /// Returns true if DynamicContentRowWorlds instances are equal
        /// </summary>
        /// <param name="input">Instance of DynamicContentRowWorlds to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DynamicContentRowWorlds input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Platform == input.Platform ||
                    (this.Platform != null &&
                    this.Platform.Equals(input.Platform))
                ) && 
                (
                    this.AvatarSpecific == input.AvatarSpecific ||
                    (this.AvatarSpecific != null &&
                    this.AvatarSpecific.Equals(input.AvatarSpecific))
                ) && 
                (
                    this.BannersTag == input.BannersTag ||
                    (this.BannersTag != null &&
                    this.BannersTag.Equals(input.BannersTag))
                ) && 
                (
                    this.Index == input.Index ||
                    this.Index.Equals(input.Index)
                ) && 
                (
                    this.ShortName == input.ShortName ||
                    (this.ShortName != null &&
                    this.ShortName.Equals(input.ShortName))
                ) && 
                (
                    this.SortHeading == input.SortHeading ||
                    (this.SortHeading != null &&
                    this.SortHeading.Equals(input.SortHeading))
                ) && 
                (
                    this.SortOrder == input.SortOrder ||
                    this.SortOrder.Equals(input.SortOrder)
                ) && 
                (
                    this.SortOwnership == input.SortOwnership ||
                    (this.SortOwnership != null &&
                    this.SortOwnership.Equals(input.SortOwnership))
                ) && 
                (
                    this.Tag == input.Tag ||
                    (this.Tag != null &&
                    this.Tag.Equals(input.Tag))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Platform != null)
                {
                    hashCode = (hashCode * 59) + this.Platform.GetHashCode();
                }
                if (this.AvatarSpecific != null)
                {
                    hashCode = (hashCode * 59) + this.AvatarSpecific.GetHashCode();
                }
                if (this.BannersTag != null)
                {
                    hashCode = (hashCode * 59) + this.BannersTag.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Index.GetHashCode();
                if (this.ShortName != null)
                {
                    hashCode = (hashCode * 59) + this.ShortName.GetHashCode();
                }
                if (this.SortHeading != null)
                {
                    hashCode = (hashCode * 59) + this.SortHeading.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SortOrder.GetHashCode();
                if (this.SortOwnership != null)
                {
                    hashCode = (hashCode * 59) + this.SortOwnership.GetHashCode();
                }
                if (this.Tag != null)
                {
                    hashCode = (hashCode * 59) + this.Tag.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
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
            // Platform (string) minLength
            if (this.Platform != null && this.Platform.Length < 1)
            {
                yield return new ValidationResult("Invalid value for Platform, length must be greater than 1.", new [] { "Platform" });
            }

            // Index (int) minimum
            if (this.Index < (int)0)
            {
                yield return new ValidationResult("Invalid value for Index, must be a value greater than or equal to 0.", new [] { "Index" });
            }

            // SortHeading (string) minLength
            if (this.SortHeading != null && this.SortHeading.Length < 1)
            {
                yield return new ValidationResult("Invalid value for SortHeading, length must be greater than 1.", new [] { "SortHeading" });
            }

            // SortOwnership (string) minLength
            if (this.SortOwnership != null && this.SortOwnership.Length < 1)
            {
                yield return new ValidationResult("Invalid value for SortOwnership, length must be greater than 1.", new [] { "SortOwnership" });
            }

            yield break;
        }
    }

}
