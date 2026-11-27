

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
    /// HypeTrain
    /// </summary>
    [DataContract(Name = "HypeTrain")]
    public partial class HypeTrain : IEquatable<HypeTrain>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HypeTrain" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected HypeTrain() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="HypeTrain" /> class.
        /// </summary>
        /// <param name="campaignId">campaignId (required).</param>
        /// <param name="cooldownSeconds">cooldownSeconds (required).</param>
        /// <param name="currentGiftCount">currentGiftCount (required).</param>
        /// <param name="currentLevel">currentLevel (required).</param>
        /// <param name="endDate">endDate (required).</param>
        /// <param name="hypeTrainId">hypeTrainId (required).</param>
        /// <param name="levels">levels (required).</param>
        /// <param name="startDate">startDate (required).</param>
        /// <param name="totalGiftContributors">totalGiftContributors (required).</param>
        /// <param name="totalGiftGoal">totalGiftGoal (required).</param>
        /// <param name="totalGiftsFromYouCount">totalGiftsFromYouCount (required).</param>
        public HypeTrain(string campaignId = default, int cooldownSeconds = default, int currentGiftCount = default, int currentLevel = default, DateTime endDate = default, string hypeTrainId = default, List<HypeTrainLevel> levels = default, DateTime startDate = default, int totalGiftContributors = default, int totalGiftGoal = default, int totalGiftsFromYouCount = default)
        {
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.CampaignId = campaignId;
            this.CooldownSeconds = cooldownSeconds;
            this.CurrentGiftCount = currentGiftCount;
            this.CurrentLevel = currentLevel;
            this.EndDate = endDate;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.HypeTrainId = hypeTrainId;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Levels = levels;
            this.StartDate = startDate;
            this.TotalGiftContributors = totalGiftContributors;
            this.TotalGiftGoal = totalGiftGoal;
            this.TotalGiftsFromYouCount = totalGiftsFromYouCount;
        }

        /// <summary>
        /// Gets or Sets CampaignId
        /// </summary>
        [DataMember(Name = "campaignId", IsRequired = true, EmitDefaultValue = true)]
        public string CampaignId { get; set; }

        /// <summary>
        /// Gets or Sets CooldownSeconds
        /// </summary>
        [DataMember(Name = "cooldownSeconds", IsRequired = true, EmitDefaultValue = true)]
        public int CooldownSeconds { get; set; }

        /// <summary>
        /// Gets or Sets CurrentGiftCount
        /// </summary>
        [DataMember(Name = "currentGiftCount", IsRequired = true, EmitDefaultValue = true)]
        public int CurrentGiftCount { get; set; }

        /// <summary>
        /// Gets or Sets CurrentLevel
        /// </summary>
        [DataMember(Name = "currentLevel", IsRequired = true, EmitDefaultValue = true)]
        public int CurrentLevel { get; set; }

        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [DataMember(Name = "endDate", IsRequired = true, EmitDefaultValue = true)]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Gets or Sets HypeTrainId
        /// </summary>
        [DataMember(Name = "hypeTrainId", IsRequired = true, EmitDefaultValue = true)]
        public string HypeTrainId { get; set; }

        /// <summary>
        /// Gets or Sets Levels
        /// </summary>
        [DataMember(Name = "levels", IsRequired = true, EmitDefaultValue = true)]
        public List<HypeTrainLevel> Levels { get; set; }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name = "startDate", IsRequired = true, EmitDefaultValue = true)]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or Sets TotalGiftContributors
        /// </summary>
        [DataMember(Name = "totalGiftContributors", IsRequired = true, EmitDefaultValue = true)]
        public int TotalGiftContributors { get; set; }

        /// <summary>
        /// Gets or Sets TotalGiftGoal
        /// </summary>
        [DataMember(Name = "totalGiftGoal", IsRequired = true, EmitDefaultValue = true)]
        public int TotalGiftGoal { get; set; }

        /// <summary>
        /// Gets or Sets TotalGiftsFromYouCount
        /// </summary>
        [DataMember(Name = "totalGiftsFromYouCount", IsRequired = true, EmitDefaultValue = true)]
        public int TotalGiftsFromYouCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class HypeTrain {\n");
            sb.Append("  CampaignId: ").Append(CampaignId).Append("\n");
            sb.Append("  CooldownSeconds: ").Append(CooldownSeconds).Append("\n");
            sb.Append("  CurrentGiftCount: ").Append(CurrentGiftCount).Append("\n");
            sb.Append("  CurrentLevel: ").Append(CurrentLevel).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  HypeTrainId: ").Append(HypeTrainId).Append("\n");
            sb.Append("  Levels: ").Append(Levels).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  TotalGiftContributors: ").Append(TotalGiftContributors).Append("\n");
            sb.Append("  TotalGiftGoal: ").Append(TotalGiftGoal).Append("\n");
            sb.Append("  TotalGiftsFromYouCount: ").Append(TotalGiftsFromYouCount).Append("\n");
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
            return this.Equals(input as HypeTrain);
        }

        /// <summary>
        /// Returns true if HypeTrain instances are equal
        /// </summary>
        /// <param name="input">Instance of HypeTrain to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HypeTrain input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CampaignId == input.CampaignId ||
                    (this.CampaignId != null &&
                    this.CampaignId.Equals(input.CampaignId))
                ) && 
                (
                    this.CooldownSeconds == input.CooldownSeconds ||
                    this.CooldownSeconds.Equals(input.CooldownSeconds)
                ) && 
                (
                    this.CurrentGiftCount == input.CurrentGiftCount ||
                    this.CurrentGiftCount.Equals(input.CurrentGiftCount)
                ) && 
                (
                    this.CurrentLevel == input.CurrentLevel ||
                    this.CurrentLevel.Equals(input.CurrentLevel)
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    this.EndDate.Equals(input.EndDate)
                ) && 
                (
                    this.HypeTrainId == input.HypeTrainId ||
                    (this.HypeTrainId != null &&
                    this.HypeTrainId.Equals(input.HypeTrainId))
                ) && 
                (
                    this.Levels == input.Levels ||
                    this.Levels != null &&
                    input.Levels != null &&
                    this.Levels.SequenceEqual(input.Levels)
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    this.StartDate.Equals(input.StartDate)
                ) && 
                (
                    this.TotalGiftContributors == input.TotalGiftContributors ||
                    this.TotalGiftContributors.Equals(input.TotalGiftContributors)
                ) && 
                (
                    this.TotalGiftGoal == input.TotalGiftGoal ||
                    this.TotalGiftGoal.Equals(input.TotalGiftGoal)
                ) && 
                (
                    this.TotalGiftsFromYouCount == input.TotalGiftsFromYouCount ||
                    this.TotalGiftsFromYouCount.Equals(input.TotalGiftsFromYouCount)
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
                if (this.CampaignId != null)
                {
                    hashCode = (hashCode * 59) + this.CampaignId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CooldownSeconds.GetHashCode();
                hashCode = (hashCode * 59) + this.CurrentGiftCount.GetHashCode();
                hashCode = (hashCode * 59) + this.CurrentLevel.GetHashCode();
                hashCode = (hashCode * 59) + this.EndDate.GetHashCode();
                if (this.HypeTrainId != null)
                {
                    hashCode = (hashCode * 59) + this.HypeTrainId.GetHashCode();
                }
                if (this.Levels != null)
                {
                    hashCode = (hashCode * 59) + this.Levels.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.StartDate.GetHashCode();
                hashCode = (hashCode * 59) + this.TotalGiftContributors.GetHashCode();
                hashCode = (hashCode * 59) + this.TotalGiftGoal.GetHashCode();
                hashCode = (hashCode * 59) + this.TotalGiftsFromYouCount.GetHashCode();
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
