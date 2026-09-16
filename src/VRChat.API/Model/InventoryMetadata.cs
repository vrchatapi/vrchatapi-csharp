

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
    /// InventoryMetadata
    /// </summary>
    [DataContract(Name = "InventoryMetadata")]
    public partial class InventoryMetadata : IEquatable<InventoryMetadata>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InventoryMetadata" /> class.
        /// </summary>
        /// <param name="animated">animated.</param>
        /// <param name="animationStyle">animationStyle.</param>
        /// <param name="assetBundleId">assetBundleId.</param>
        /// <param name="assets">assets.</param>
        /// <param name="fileId">fileId.</param>
        /// <param name="gradientEnd">Six hexadecimal digits, without a leading &#x60;#&#x60;. May be empty..</param>
        /// <param name="gradientStart">Six hexadecimal digits, without a leading &#x60;#&#x60;. May be empty..</param>
        /// <param name="imageUrl">imageUrl.</param>
        /// <param name="inventoryItemsToInstantiate">Only in bundles.</param>
        /// <param name="maskTag">maskTag.</param>
        /// <param name="propId">propId.</param>
        /// <param name="propKind">propKind.</param>
        /// <param name="viewfinderBundleId">viewfinderBundleId.</param>
        public InventoryMetadata(bool animated = default, string animationStyle = default, string assetBundleId = default, List<InventoryAsset> assets = default, string fileId = default, string gradientEnd = default, string gradientStart = default, string imageUrl = default, List<string> inventoryItemsToInstantiate = default, string maskTag = default, string propId = default, int propKind = default, string viewfinderBundleId = default)
        {
            this.Animated = animated;
            this.AnimationStyle = animationStyle;
            this.AssetBundleId = assetBundleId;
            this.Assets = assets;
            this.FileId = fileId;
            this.GradientEnd = gradientEnd;
            this.GradientStart = gradientStart;
            this.ImageUrl = imageUrl;
            this.InventoryItemsToInstantiate = inventoryItemsToInstantiate;
            this.MaskTag = maskTag;
            this.PropId = propId;
            this.PropKind = propKind;
            this.ViewfinderBundleId = viewfinderBundleId;
        }

        /// <summary>
        /// Gets or Sets Animated
        /// </summary>
        [DataMember(Name = "animated", EmitDefaultValue = true)]
        public bool Animated { get; set; }

        /// <summary>
        /// Gets or Sets AnimationStyle
        /// </summary>
        [DataMember(Name = "animationStyle", EmitDefaultValue = false)]
        public string AnimationStyle { get; set; }

        /// <summary>
        /// Gets or Sets AssetBundleId
        /// </summary>
        [DataMember(Name = "assetBundleId", EmitDefaultValue = false)]
        public string AssetBundleId { get; set; }

        /// <summary>
        /// Gets or Sets Assets
        /// </summary>
        [DataMember(Name = "assets", EmitDefaultValue = false)]
        public List<InventoryAsset> Assets { get; set; }

        /// <summary>
        /// Gets or Sets FileId
        /// </summary>
        [DataMember(Name = "fileId", EmitDefaultValue = false)]
        public string FileId { get; set; }

        /// <summary>
        /// Six hexadecimal digits, without a leading &#x60;#&#x60;. May be empty.
        /// </summary>
        /// <value>Six hexadecimal digits, without a leading &#x60;#&#x60;. May be empty.</value>
        /*
        <example>3cc92c</example>
        */
        [DataMember(Name = "gradientEnd", EmitDefaultValue = false)]
        public string GradientEnd { get; set; }

        /// <summary>
        /// Six hexadecimal digits, without a leading &#x60;#&#x60;. May be empty.
        /// </summary>
        /// <value>Six hexadecimal digits, without a leading &#x60;#&#x60;. May be empty.</value>
        /*
        <example>3cc92c</example>
        */
        [DataMember(Name = "gradientStart", EmitDefaultValue = false)]
        public string GradientStart { get; set; }

        /// <summary>
        /// Gets or Sets ImageUrl
        /// </summary>
        [DataMember(Name = "imageUrl", EmitDefaultValue = false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// Only in bundles
        /// </summary>
        /// <value>Only in bundles</value>
        [DataMember(Name = "inventoryItemsToInstantiate", EmitDefaultValue = false)]
        public List<string> InventoryItemsToInstantiate { get; set; }

        /// <summary>
        /// Gets or Sets MaskTag
        /// </summary>
        [DataMember(Name = "maskTag", EmitDefaultValue = false)]
        public string MaskTag { get; set; }

        /// <summary>
        /// Gets or Sets PropId
        /// </summary>
        /*
        <example>prop_829ba6f6-b837-49d9-b9a9-056b82103b58</example>
        */
        [DataMember(Name = "propId", EmitDefaultValue = false)]
        public string PropId { get; set; }

        /// <summary>
        /// Gets or Sets PropKind
        /// </summary>
        [DataMember(Name = "propKind", EmitDefaultValue = false)]
        public int PropKind { get; set; }

        /// <summary>
        /// Gets or Sets ViewfinderBundleId
        /// </summary>
        [DataMember(Name = "viewfinderBundleId", EmitDefaultValue = false)]
        public string ViewfinderBundleId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InventoryMetadata {\n");
            sb.Append("  Animated: ").Append(Animated).Append("\n");
            sb.Append("  AnimationStyle: ").Append(AnimationStyle).Append("\n");
            sb.Append("  AssetBundleId: ").Append(AssetBundleId).Append("\n");
            sb.Append("  Assets: ").Append(Assets).Append("\n");
            sb.Append("  FileId: ").Append(FileId).Append("\n");
            sb.Append("  GradientEnd: ").Append(GradientEnd).Append("\n");
            sb.Append("  GradientStart: ").Append(GradientStart).Append("\n");
            sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("  InventoryItemsToInstantiate: ").Append(InventoryItemsToInstantiate).Append("\n");
            sb.Append("  MaskTag: ").Append(MaskTag).Append("\n");
            sb.Append("  PropId: ").Append(PropId).Append("\n");
            sb.Append("  PropKind: ").Append(PropKind).Append("\n");
            sb.Append("  ViewfinderBundleId: ").Append(ViewfinderBundleId).Append("\n");
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
            return this.Equals(input as InventoryMetadata);
        }

        /// <summary>
        /// Returns true if InventoryMetadata instances are equal
        /// </summary>
        /// <param name="input">Instance of InventoryMetadata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InventoryMetadata input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Animated == input.Animated ||
                    this.Animated.Equals(input.Animated)
                ) && 
                (
                    this.AnimationStyle == input.AnimationStyle ||
                    (this.AnimationStyle != null &&
                    this.AnimationStyle.Equals(input.AnimationStyle))
                ) && 
                (
                    this.AssetBundleId == input.AssetBundleId ||
                    (this.AssetBundleId != null &&
                    this.AssetBundleId.Equals(input.AssetBundleId))
                ) && 
                (
                    this.Assets == input.Assets ||
                    this.Assets != null &&
                    input.Assets != null &&
                    this.Assets.SequenceEqual(input.Assets)
                ) && 
                (
                    this.FileId == input.FileId ||
                    (this.FileId != null &&
                    this.FileId.Equals(input.FileId))
                ) && 
                (
                    this.GradientEnd == input.GradientEnd ||
                    (this.GradientEnd != null &&
                    this.GradientEnd.Equals(input.GradientEnd))
                ) && 
                (
                    this.GradientStart == input.GradientStart ||
                    (this.GradientStart != null &&
                    this.GradientStart.Equals(input.GradientStart))
                ) && 
                (
                    this.ImageUrl == input.ImageUrl ||
                    (this.ImageUrl != null &&
                    this.ImageUrl.Equals(input.ImageUrl))
                ) && 
                (
                    this.InventoryItemsToInstantiate == input.InventoryItemsToInstantiate ||
                    this.InventoryItemsToInstantiate != null &&
                    input.InventoryItemsToInstantiate != null &&
                    this.InventoryItemsToInstantiate.SequenceEqual(input.InventoryItemsToInstantiate)
                ) && 
                (
                    this.MaskTag == input.MaskTag ||
                    (this.MaskTag != null &&
                    this.MaskTag.Equals(input.MaskTag))
                ) && 
                (
                    this.PropId == input.PropId ||
                    (this.PropId != null &&
                    this.PropId.Equals(input.PropId))
                ) && 
                (
                    this.PropKind == input.PropKind ||
                    this.PropKind.Equals(input.PropKind)
                ) && 
                (
                    this.ViewfinderBundleId == input.ViewfinderBundleId ||
                    (this.ViewfinderBundleId != null &&
                    this.ViewfinderBundleId.Equals(input.ViewfinderBundleId))
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
                hashCode = (hashCode * 59) + this.Animated.GetHashCode();
                if (this.AnimationStyle != null)
                {
                    hashCode = (hashCode * 59) + this.AnimationStyle.GetHashCode();
                }
                if (this.AssetBundleId != null)
                {
                    hashCode = (hashCode * 59) + this.AssetBundleId.GetHashCode();
                }
                if (this.Assets != null)
                {
                    hashCode = (hashCode * 59) + this.Assets.GetHashCode();
                }
                if (this.FileId != null)
                {
                    hashCode = (hashCode * 59) + this.FileId.GetHashCode();
                }
                if (this.GradientEnd != null)
                {
                    hashCode = (hashCode * 59) + this.GradientEnd.GetHashCode();
                }
                if (this.GradientStart != null)
                {
                    hashCode = (hashCode * 59) + this.GradientStart.GetHashCode();
                }
                if (this.ImageUrl != null)
                {
                    hashCode = (hashCode * 59) + this.ImageUrl.GetHashCode();
                }
                if (this.InventoryItemsToInstantiate != null)
                {
                    hashCode = (hashCode * 59) + this.InventoryItemsToInstantiate.GetHashCode();
                }
                if (this.MaskTag != null)
                {
                    hashCode = (hashCode * 59) + this.MaskTag.GetHashCode();
                }
                if (this.PropId != null)
                {
                    hashCode = (hashCode * 59) + this.PropId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PropKind.GetHashCode();
                if (this.ViewfinderBundleId != null)
                {
                    hashCode = (hashCode * 59) + this.ViewfinderBundleId.GetHashCode();
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
