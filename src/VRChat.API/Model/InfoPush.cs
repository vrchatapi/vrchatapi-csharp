

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
    /// InfoPush
    /// </summary>
    [DataContract(Name = "InfoPush")]
    public partial class InfoPush : IEquatable<InfoPush>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets ReleaseStatus
        /// </summary>
        [DataMember(Name = "releaseStatus", IsRequired = true, EmitDefaultValue = true)]
        public ReleaseStatus ReleaseStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InfoPush" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InfoPush() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InfoPush" /> class.
        /// </summary>
        /// <param name="clientMinVersion">clientMinVersion.</param>
        /// <param name="createdAt">createdAt (required).</param>
        /// <param name="data">data (required).</param>
        /// <param name="endDate">endDate.</param>
        /// <param name="experiment">experiment.</param>
        /// <param name="hash">Unknown usage, MD5 (required).</param>
        /// <param name="id">id (required).</param>
        /// <param name="isEnabled">isEnabled (required) (default to true).</param>
        /// <param name="priority">priority (required).</param>
        /// <param name="regions">regions.</param>
        /// <param name="releaseStatus">releaseStatus (required).</param>
        /// <param name="requireClientTags">requireClientTags.</param>
        /// <param name="startDate">startDate.</param>
        /// <param name="tags">  (required).</param>
        /// <param name="updatedAt">updatedAt (required).</param>
        public InfoPush(Object clientMinVersion = default, DateTime createdAt = default, InfoPushData data = default, DateTime? endDate = default, InfoPushExperiment experiment = default, string hash = default, string id = default, bool isEnabled = true, int priority = default, List<string> regions = default, ReleaseStatus releaseStatus = default, List<string> requireClientTags = default, DateTime? startDate = default, List<string> tags = default, DateTime updatedAt = default)
        {
            this.CreatedAt = createdAt;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Data = data;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Hash = hash;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Id = id;
            this.IsEnabled = isEnabled;
            this.Priority = priority;
            this.ReleaseStatus = releaseStatus;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Tags = tags;
            this.UpdatedAt = updatedAt;
            this.ClientMinVersion = clientMinVersion;
            this.EndDate = endDate;
            this.Experiment = experiment;
            this.Regions = regions;
            this.RequireClientTags = requireClientTags;
            this.StartDate = startDate;
        }

        /// <summary>
        /// Gets or Sets ClientMinVersion
        /// </summary>
        [DataMember(Name = "clientMinVersion", EmitDefaultValue = true)]
        public Object ClientMinVersion { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "createdAt", IsRequired = true, EmitDefaultValue = true)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", IsRequired = true, EmitDefaultValue = true)]
        public InfoPushData Data { get; set; }

        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [DataMember(Name = "endDate", EmitDefaultValue = true)]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Gets or Sets Experiment
        /// </summary>
        [DataMember(Name = "experiment", EmitDefaultValue = false)]
        public InfoPushExperiment Experiment { get; set; }

        /// <summary>
        /// Unknown usage, MD5
        /// </summary>
        /// <value>Unknown usage, MD5</value>
        [DataMember(Name = "hash", IsRequired = true, EmitDefaultValue = true)]
        public string Hash { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        /*
        <example>launch-beta</example>
        */
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets IsEnabled
        /// </summary>
        [DataMember(Name = "isEnabled", IsRequired = true, EmitDefaultValue = true)]
        public bool IsEnabled { get; set; }

        /// <summary>
        /// Gets or Sets Priority
        /// </summary>
        [DataMember(Name = "priority", IsRequired = true, EmitDefaultValue = true)]
        public int Priority { get; set; }

        /// <summary>
        /// Gets or Sets Regions
        /// </summary>
        [DataMember(Name = "regions", EmitDefaultValue = false)]
        public List<string> Regions { get; set; }

        /// <summary>
        /// Gets or Sets RequireClientTags
        /// </summary>
        [DataMember(Name = "requireClientTags", EmitDefaultValue = false)]
        public List<string> RequireClientTags { get; set; }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name = "startDate", EmitDefaultValue = true)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        ///  
        /// </summary>
        /// <value> </value>
        [DataMember(Name = "tags", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updatedAt", IsRequired = true, EmitDefaultValue = true)]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InfoPush {\n");
            sb.Append("  ClientMinVersion: ").Append(ClientMinVersion).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  Experiment: ").Append(Experiment).Append("\n");
            sb.Append("  Hash: ").Append(Hash).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IsEnabled: ").Append(IsEnabled).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  Regions: ").Append(Regions).Append("\n");
            sb.Append("  ReleaseStatus: ").Append(ReleaseStatus).Append("\n");
            sb.Append("  RequireClientTags: ").Append(RequireClientTags).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
            return this.Equals(input as InfoPush);
        }

        /// <summary>
        /// Returns true if InfoPush instances are equal
        /// </summary>
        /// <param name="input">Instance of InfoPush to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InfoPush input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ClientMinVersion == input.ClientMinVersion ||
                    (this.ClientMinVersion != null &&
                    this.ClientMinVersion.Equals(input.ClientMinVersion))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    this.CreatedAt.Equals(input.CreatedAt)
                ) && 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.Experiment == input.Experiment ||
                    (this.Experiment != null &&
                    this.Experiment.Equals(input.Experiment))
                ) && 
                (
                    this.Hash == input.Hash ||
                    (this.Hash != null &&
                    this.Hash.Equals(input.Hash))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.IsEnabled == input.IsEnabled ||
                    this.IsEnabled.Equals(input.IsEnabled)
                ) && 
                (
                    this.Priority == input.Priority ||
                    this.Priority.Equals(input.Priority)
                ) && 
                (
                    this.Regions == input.Regions ||
                    this.Regions != null &&
                    input.Regions != null &&
                    this.Regions.SequenceEqual(input.Regions)
                ) && 
                (
                    this.ReleaseStatus == input.ReleaseStatus ||
                    this.ReleaseStatus.Equals(input.ReleaseStatus)
                ) && 
                (
                    this.RequireClientTags == input.RequireClientTags ||
                    this.RequireClientTags != null &&
                    input.RequireClientTags != null &&
                    this.RequireClientTags.SequenceEqual(input.RequireClientTags)
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    this.UpdatedAt.Equals(input.UpdatedAt)
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
                if (this.ClientMinVersion != null)
                {
                    hashCode = (hashCode * 59) + this.ClientMinVersion.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                if (this.Data != null)
                {
                    hashCode = (hashCode * 59) + this.Data.GetHashCode();
                }
                if (this.EndDate != null)
                {
                    hashCode = (hashCode * 59) + this.EndDate.GetHashCode();
                }
                if (this.Experiment != null)
                {
                    hashCode = (hashCode * 59) + this.Experiment.GetHashCode();
                }
                if (this.Hash != null)
                {
                    hashCode = (hashCode * 59) + this.Hash.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsEnabled.GetHashCode();
                hashCode = (hashCode * 59) + this.Priority.GetHashCode();
                if (this.Regions != null)
                {
                    hashCode = (hashCode * 59) + this.Regions.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ReleaseStatus.GetHashCode();
                if (this.RequireClientTags != null)
                {
                    hashCode = (hashCode * 59) + this.RequireClientTags.GetHashCode();
                }
                if (this.StartDate != null)
                {
                    hashCode = (hashCode * 59) + this.StartDate.GetHashCode();
                }
                if (this.Tags != null)
                {
                    hashCode = (hashCode * 59) + this.Tags.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
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
            // Hash (string) minLength
            if (this.Hash != null && this.Hash.Length < 1)
            {
                yield return new ValidationResult("Invalid value for Hash, length must be greater than 1.", new [] { "Hash" });
            }

            // Id (string) minLength
            if (this.Id != null && this.Id.Length < 1)
            {
                yield return new ValidationResult("Invalid value for Id, length must be greater than 1.", new [] { "Id" });
            }

            yield break;
        }
    }

}
