

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
    /// InventoryAsset
    /// </summary>
    [DataContract(Name = "InventoryAsset")]
    public partial class InventoryAsset : IEquatable<InventoryAsset>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InventoryAsset" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InventoryAsset() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InventoryAsset" /> class.
        /// </summary>
        /// <param name="fileId">fileId.</param>
        /// <param name="frameCount">frameCount.</param>
        /// <param name="framesPerSecond">framesPerSecond.</param>
        /// <param name="loopCount">loopCount.</param>
        /// <param name="totalDurationMs">totalDurationMs.</param>
        /// <param name="type">type (required).</param>
        /// <param name="url">url (required).</param>
        public InventoryAsset(string fileId = default, int frameCount = default, decimal framesPerSecond = default, int loopCount = default, int totalDurationMs = default, string type = default, string url = default)
        {
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Type = type;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Url = url;
            this.FileId = fileId;
            this.FrameCount = frameCount;
            this.FramesPerSecond = framesPerSecond;
            this.LoopCount = loopCount;
            this.TotalDurationMs = totalDurationMs;
        }

        /// <summary>
        /// Gets or Sets FileId
        /// </summary>
        [DataMember(Name = "fileId", EmitDefaultValue = false)]
        public string FileId { get; set; }

        /// <summary>
        /// Gets or Sets FrameCount
        /// </summary>
        [DataMember(Name = "frameCount", EmitDefaultValue = false)]
        public int FrameCount { get; set; }

        /// <summary>
        /// Gets or Sets FramesPerSecond
        /// </summary>
        [DataMember(Name = "framesPerSecond", EmitDefaultValue = false)]
        public decimal FramesPerSecond { get; set; }

        /// <summary>
        /// Gets or Sets LoopCount
        /// </summary>
        [DataMember(Name = "loopCount", EmitDefaultValue = false)]
        public int LoopCount { get; set; }

        /// <summary>
        /// Gets or Sets TotalDurationMs
        /// </summary>
        [DataMember(Name = "totalDurationMs", EmitDefaultValue = false)]
        public int TotalDurationMs { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name = "url", IsRequired = true, EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InventoryAsset {\n");
            sb.Append("  FileId: ").Append(FileId).Append("\n");
            sb.Append("  FrameCount: ").Append(FrameCount).Append("\n");
            sb.Append("  FramesPerSecond: ").Append(FramesPerSecond).Append("\n");
            sb.Append("  LoopCount: ").Append(LoopCount).Append("\n");
            sb.Append("  TotalDurationMs: ").Append(TotalDurationMs).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
            return this.Equals(input as InventoryAsset);
        }

        /// <summary>
        /// Returns true if InventoryAsset instances are equal
        /// </summary>
        /// <param name="input">Instance of InventoryAsset to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InventoryAsset input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.FileId == input.FileId ||
                    (this.FileId != null &&
                    this.FileId.Equals(input.FileId))
                ) && 
                (
                    this.FrameCount == input.FrameCount ||
                    this.FrameCount.Equals(input.FrameCount)
                ) && 
                (
                    this.FramesPerSecond == input.FramesPerSecond ||
                    this.FramesPerSecond.Equals(input.FramesPerSecond)
                ) && 
                (
                    this.LoopCount == input.LoopCount ||
                    this.LoopCount.Equals(input.LoopCount)
                ) && 
                (
                    this.TotalDurationMs == input.TotalDurationMs ||
                    this.TotalDurationMs.Equals(input.TotalDurationMs)
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
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
                if (this.FileId != null)
                {
                    hashCode = (hashCode * 59) + this.FileId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.FrameCount.GetHashCode();
                hashCode = (hashCode * 59) + this.FramesPerSecond.GetHashCode();
                hashCode = (hashCode * 59) + this.LoopCount.GetHashCode();
                hashCode = (hashCode * 59) + this.TotalDurationMs.GetHashCode();
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                if (this.Url != null)
                {
                    hashCode = (hashCode * 59) + this.Url.GetHashCode();
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
