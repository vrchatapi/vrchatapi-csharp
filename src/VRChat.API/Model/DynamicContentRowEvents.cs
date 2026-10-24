

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
    /// DynamicContentRowEvents
    /// </summary>
    [DataContract(Name = "DynamicContentRowEvents")]
    public partial class DynamicContentRowEvents : IEquatable<DynamicContentRowEvents>, IValidatableObject
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Events for value: events
            /// </summary>
            [EnumMember(Value = "events")]
            Events = 1
        }


        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicContentRowEvents" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DynamicContentRowEvents() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicContentRowEvents" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="platform">Usually \&quot;ThisPlatformSupported\&quot;, but can also be other values such as \&quot;all\&quot; or platform specific identifiers. (required).</param>
        /// <param name="categories">categories (required).</param>
        /// <param name="featuredResults">featuredResults (required).</param>
        /// <param name="minimumInterestCount">minimumInterestCount (required).</param>
        /// <param name="minimumRemainingMinutes">minimumRemainingMinutes (required).</param>
        /// <param name="nonFeaturedResults">nonFeaturedResults (required).</param>
        /// <param name="varParams">varParams (required).</param>
        /// <param name="personalizedResults">personalizedResults (required).</param>
        /// <param name="scope">scope (required).</param>
        /// <param name="tags">tags.</param>
        /// <param name="type">type (required).</param>
        /// <param name="upcomingOffsetMinutes">upcomingOffsetMinutes (required).</param>
        public DynamicContentRowEvents(LocalizableString name = default, string platform = default, List<string> categories = default, string featuredResults = default, int minimumInterestCount = default, int minimumRemainingMinutes = default, string nonFeaturedResults = default, Dictionary<string, Object> varParams = default, string personalizedResults = default, string scope = default, List<string> tags = default, TypeEnum type = default, int upcomingOffsetMinutes = default)
        {
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Name = name;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Platform = platform;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Categories = categories;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.FeaturedResults = featuredResults;
            this.MinimumInterestCount = minimumInterestCount;
            this.MinimumRemainingMinutes = minimumRemainingMinutes;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.NonFeaturedResults = nonFeaturedResults;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Params = varParams;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.PersonalizedResults = personalizedResults;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Scope = scope;
            this.Type = type;
            this.UpcomingOffsetMinutes = upcomingOffsetMinutes;
            this.Tags = tags;
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
        /// Gets or Sets Categories
        /// </summary>
        [DataMember(Name = "categories", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Categories { get; set; }

        /// <summary>
        /// Gets or Sets FeaturedResults
        /// </summary>
        [DataMember(Name = "featuredResults", IsRequired = true, EmitDefaultValue = true)]
        public string FeaturedResults { get; set; }

        /// <summary>
        /// Gets or Sets MinimumInterestCount
        /// </summary>
        [DataMember(Name = "minimumInterestCount", IsRequired = true, EmitDefaultValue = true)]
        public int MinimumInterestCount { get; set; }

        /// <summary>
        /// Gets or Sets MinimumRemainingMinutes
        /// </summary>
        [DataMember(Name = "minimumRemainingMinutes", IsRequired = true, EmitDefaultValue = true)]
        public int MinimumRemainingMinutes { get; set; }

        /// <summary>
        /// Gets or Sets NonFeaturedResults
        /// </summary>
        [DataMember(Name = "nonFeaturedResults", IsRequired = true, EmitDefaultValue = true)]
        public string NonFeaturedResults { get; set; }

        /// <summary>
        /// Gets or Sets Params
        /// </summary>
        [DataMember(Name = "params", IsRequired = true, EmitDefaultValue = true)]
        public Dictionary<string, Object> Params { get; set; }

        /// <summary>
        /// Gets or Sets PersonalizedResults
        /// </summary>
        [DataMember(Name = "personalizedResults", IsRequired = true, EmitDefaultValue = true)]
        public string PersonalizedResults { get; set; }

        /// <summary>
        /// Gets or Sets Scope
        /// </summary>
        [DataMember(Name = "scope", IsRequired = true, EmitDefaultValue = true)]
        public string Scope { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name = "tags", EmitDefaultValue = true)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Gets or Sets UpcomingOffsetMinutes
        /// </summary>
        [DataMember(Name = "upcomingOffsetMinutes", IsRequired = true, EmitDefaultValue = true)]
        public int UpcomingOffsetMinutes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DynamicContentRowEvents {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
            sb.Append("  Categories: ").Append(Categories).Append("\n");
            sb.Append("  FeaturedResults: ").Append(FeaturedResults).Append("\n");
            sb.Append("  MinimumInterestCount: ").Append(MinimumInterestCount).Append("\n");
            sb.Append("  MinimumRemainingMinutes: ").Append(MinimumRemainingMinutes).Append("\n");
            sb.Append("  NonFeaturedResults: ").Append(NonFeaturedResults).Append("\n");
            sb.Append("  Params: ").Append(Params).Append("\n");
            sb.Append("  PersonalizedResults: ").Append(PersonalizedResults).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  UpcomingOffsetMinutes: ").Append(UpcomingOffsetMinutes).Append("\n");
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
            return this.Equals(input as DynamicContentRowEvents);
        }

        /// <summary>
        /// Returns true if DynamicContentRowEvents instances are equal
        /// </summary>
        /// <param name="input">Instance of DynamicContentRowEvents to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DynamicContentRowEvents input)
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
                    this.Categories == input.Categories ||
                    this.Categories != null &&
                    input.Categories != null &&
                    this.Categories.SequenceEqual(input.Categories)
                ) && 
                (
                    this.FeaturedResults == input.FeaturedResults ||
                    (this.FeaturedResults != null &&
                    this.FeaturedResults.Equals(input.FeaturedResults))
                ) && 
                (
                    this.MinimumInterestCount == input.MinimumInterestCount ||
                    this.MinimumInterestCount.Equals(input.MinimumInterestCount)
                ) && 
                (
                    this.MinimumRemainingMinutes == input.MinimumRemainingMinutes ||
                    this.MinimumRemainingMinutes.Equals(input.MinimumRemainingMinutes)
                ) && 
                (
                    this.NonFeaturedResults == input.NonFeaturedResults ||
                    (this.NonFeaturedResults != null &&
                    this.NonFeaturedResults.Equals(input.NonFeaturedResults))
                ) && 
                (
                    this.Params == input.Params ||
                    this.Params != null &&
                    input.Params != null &&
                    this.Params.SequenceEqual(input.Params)
                ) && 
                (
                    this.PersonalizedResults == input.PersonalizedResults ||
                    (this.PersonalizedResults != null &&
                    this.PersonalizedResults.Equals(input.PersonalizedResults))
                ) && 
                (
                    this.Scope == input.Scope ||
                    (this.Scope != null &&
                    this.Scope.Equals(input.Scope))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.UpcomingOffsetMinutes == input.UpcomingOffsetMinutes ||
                    this.UpcomingOffsetMinutes.Equals(input.UpcomingOffsetMinutes)
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
                if (this.Categories != null)
                {
                    hashCode = (hashCode * 59) + this.Categories.GetHashCode();
                }
                if (this.FeaturedResults != null)
                {
                    hashCode = (hashCode * 59) + this.FeaturedResults.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.MinimumInterestCount.GetHashCode();
                hashCode = (hashCode * 59) + this.MinimumRemainingMinutes.GetHashCode();
                if (this.NonFeaturedResults != null)
                {
                    hashCode = (hashCode * 59) + this.NonFeaturedResults.GetHashCode();
                }
                if (this.Params != null)
                {
                    hashCode = (hashCode * 59) + this.Params.GetHashCode();
                }
                if (this.PersonalizedResults != null)
                {
                    hashCode = (hashCode * 59) + this.PersonalizedResults.GetHashCode();
                }
                if (this.Scope != null)
                {
                    hashCode = (hashCode * 59) + this.Scope.GetHashCode();
                }
                if (this.Tags != null)
                {
                    hashCode = (hashCode * 59) + this.Tags.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                hashCode = (hashCode * 59) + this.UpcomingOffsetMinutes.GetHashCode();
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

            yield break;
        }
    }

}
