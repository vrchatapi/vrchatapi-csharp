

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
    /// DynamicContentRowAvatars
    /// </summary>
    [DataContract(Name = "DynamicContentRowAvatars")]
    public partial class DynamicContentRowAvatars : IEquatable<DynamicContentRowAvatars>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets SortOrder
        /// </summary>
        [DataMember(Name = "sortOrder", IsRequired = true, EmitDefaultValue = true)]
        public OrderOption SortOrder { get; set; }
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Avatar for value: avatar
            /// </summary>
            [EnumMember(Value = "avatar")]
            Avatar = 1
        }


        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicContentRowAvatars" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DynamicContentRowAvatars() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicContentRowAvatars" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="platform">Usually \&quot;ThisPlatformSupported\&quot;, but can also be other values such as \&quot;all\&quot; or platform specific identifiers. (required).</param>
        /// <param name="anyStyle">anyStyle.</param>
        /// <param name="anyTag">anyTag.</param>
        /// <param name="marketplace">marketplace.</param>
        /// <param name="maxPrice">maxPrice.</param>
        /// <param name="minPrice">minPrice.</param>
        /// <param name="notag">notag.</param>
        /// <param name="varParams">varParams (required).</param>
        /// <param name="sortHeading">sortHeading (required).</param>
        /// <param name="sortOrder">sortOrder (required).</param>
        /// <param name="sortOwnership">sortOwnership (required).</param>
        /// <param name="style">style.</param>
        /// <param name="tag">Tag to filter content for this row. Not a &#x60;Tag&#x60;: that type forbids the empty string, which this field uses for a row that is not tag-filtered..</param>
        /// <param name="type">type (required).</param>
        public DynamicContentRowAvatars(LocalizableString name = default, string platform = default, List<string> anyStyle = default, List<string> anyTag = default, string marketplace = default, int maxPrice = default, int minPrice = default, List<string> notag = default, Dictionary<string, Object> varParams = default, string sortHeading = default, OrderOption sortOrder = default, string sortOwnership = default, string style = default, string tag = default, TypeEnum type = default)
        {
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Name = name;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Platform = platform;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Params = varParams;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.SortHeading = sortHeading;
            this.SortOrder = sortOrder;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.SortOwnership = sortOwnership;
            this.Type = type;
            this.AnyStyle = anyStyle;
            this.AnyTag = anyTag;
            this.Marketplace = marketplace;
            this.MaxPrice = maxPrice;
            this.MinPrice = minPrice;
            this.Notag = notag;
            this.Style = style;
            this.Tag = tag;
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
        /// Gets or Sets AnyStyle
        /// </summary>
        [DataMember(Name = "anyStyle", EmitDefaultValue = true)]
        public List<string> AnyStyle { get; set; }

        /// <summary>
        /// Gets or Sets AnyTag
        /// </summary>
        [DataMember(Name = "anyTag", EmitDefaultValue = true)]
        public List<string> AnyTag { get; set; }

        /// <summary>
        /// Gets or Sets Marketplace
        /// </summary>
        [DataMember(Name = "marketplace", EmitDefaultValue = false)]
        public string Marketplace { get; set; }

        /// <summary>
        /// Gets or Sets MaxPrice
        /// </summary>
        [DataMember(Name = "maxPrice", EmitDefaultValue = false)]
        public int MaxPrice { get; set; }

        /// <summary>
        /// Gets or Sets MinPrice
        /// </summary>
        [DataMember(Name = "minPrice", EmitDefaultValue = false)]
        public int MinPrice { get; set; }

        /// <summary>
        /// Gets or Sets Notag
        /// </summary>
        [DataMember(Name = "notag", EmitDefaultValue = true)]
        public List<string> Notag { get; set; }

        /// <summary>
        /// Gets or Sets Params
        /// </summary>
        [DataMember(Name = "params", IsRequired = true, EmitDefaultValue = true)]
        public Dictionary<string, Object> Params { get; set; }

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
        /// Gets or Sets Style
        /// </summary>
        [DataMember(Name = "style", EmitDefaultValue = true)]
        public string Style { get; set; }

        /// <summary>
        /// Tag to filter content for this row. Not a &#x60;Tag&#x60;: that type forbids the empty string, which this field uses for a row that is not tag-filtered.
        /// </summary>
        /// <value>Tag to filter content for this row. Not a &#x60;Tag&#x60;: that type forbids the empty string, which this field uses for a row that is not tag-filtered.</value>
        [DataMember(Name = "tag", EmitDefaultValue = true)]
        public string Tag { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DynamicContentRowAvatars {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
            sb.Append("  AnyStyle: ").Append(AnyStyle).Append("\n");
            sb.Append("  AnyTag: ").Append(AnyTag).Append("\n");
            sb.Append("  Marketplace: ").Append(Marketplace).Append("\n");
            sb.Append("  MaxPrice: ").Append(MaxPrice).Append("\n");
            sb.Append("  MinPrice: ").Append(MinPrice).Append("\n");
            sb.Append("  Notag: ").Append(Notag).Append("\n");
            sb.Append("  Params: ").Append(Params).Append("\n");
            sb.Append("  SortHeading: ").Append(SortHeading).Append("\n");
            sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
            sb.Append("  SortOwnership: ").Append(SortOwnership).Append("\n");
            sb.Append("  Style: ").Append(Style).Append("\n");
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
            return this.Equals(input as DynamicContentRowAvatars);
        }

        /// <summary>
        /// Returns true if DynamicContentRowAvatars instances are equal
        /// </summary>
        /// <param name="input">Instance of DynamicContentRowAvatars to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DynamicContentRowAvatars input)
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
                    this.AnyStyle == input.AnyStyle ||
                    this.AnyStyle != null &&
                    input.AnyStyle != null &&
                    this.AnyStyle.SequenceEqual(input.AnyStyle)
                ) && 
                (
                    this.AnyTag == input.AnyTag ||
                    this.AnyTag != null &&
                    input.AnyTag != null &&
                    this.AnyTag.SequenceEqual(input.AnyTag)
                ) && 
                (
                    this.Marketplace == input.Marketplace ||
                    (this.Marketplace != null &&
                    this.Marketplace.Equals(input.Marketplace))
                ) && 
                (
                    this.MaxPrice == input.MaxPrice ||
                    this.MaxPrice.Equals(input.MaxPrice)
                ) && 
                (
                    this.MinPrice == input.MinPrice ||
                    this.MinPrice.Equals(input.MinPrice)
                ) && 
                (
                    this.Notag == input.Notag ||
                    this.Notag != null &&
                    input.Notag != null &&
                    this.Notag.SequenceEqual(input.Notag)
                ) && 
                (
                    this.Params == input.Params ||
                    this.Params != null &&
                    input.Params != null &&
                    this.Params.SequenceEqual(input.Params)
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
                    this.Style == input.Style ||
                    (this.Style != null &&
                    this.Style.Equals(input.Style))
                ) && 
                (
                    this.Tag == input.Tag ||
                    (this.Tag != null &&
                    this.Tag.Equals(input.Tag))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
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
                if (this.AnyStyle != null)
                {
                    hashCode = (hashCode * 59) + this.AnyStyle.GetHashCode();
                }
                if (this.AnyTag != null)
                {
                    hashCode = (hashCode * 59) + this.AnyTag.GetHashCode();
                }
                if (this.Marketplace != null)
                {
                    hashCode = (hashCode * 59) + this.Marketplace.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.MaxPrice.GetHashCode();
                hashCode = (hashCode * 59) + this.MinPrice.GetHashCode();
                if (this.Notag != null)
                {
                    hashCode = (hashCode * 59) + this.Notag.GetHashCode();
                }
                if (this.Params != null)
                {
                    hashCode = (hashCode * 59) + this.Params.GetHashCode();
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
                if (this.Style != null)
                {
                    hashCode = (hashCode * 59) + this.Style.GetHashCode();
                }
                if (this.Tag != null)
                {
                    hashCode = (hashCode * 59) + this.Tag.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
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
