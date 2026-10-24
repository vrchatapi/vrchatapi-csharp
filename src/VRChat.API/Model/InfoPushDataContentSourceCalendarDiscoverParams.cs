

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
    /// InfoPushDataContentSourceCalendarDiscoverParams
    /// </summary>
    [DataContract(Name = "InfoPushDataContentSourceCalendarDiscoverParams")]
    public partial class InfoPushDataContentSourceCalendarDiscoverParams : IEquatable<InfoPushDataContentSourceCalendarDiscoverParams>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets FeaturedResults
        /// </summary>
        [DataMember(Name = "featuredResults", IsRequired = true, EmitDefaultValue = true)]
        public CalendarEventDiscoveryInclusion FeaturedResults { get; set; }

        /// <summary>
        /// Gets or Sets Scope
        /// </summary>
        [DataMember(Name = "scope", IsRequired = true, EmitDefaultValue = true)]
        public CalendarEventDiscoveryScope Scope { get; set; }

        /// <summary>
        /// Gets or Sets UpcomingSort
        /// </summary>
        [DataMember(Name = "upcomingSort", IsRequired = true, EmitDefaultValue = true)]
        public CalendarEventDiscoverySort UpcomingSort { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InfoPushDataContentSourceCalendarDiscoverParams" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InfoPushDataContentSourceCalendarDiscoverParams() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InfoPushDataContentSourceCalendarDiscoverParams" /> class.
        /// </summary>
        /// <param name="featuredResults">featuredResults (required).</param>
        /// <param name="minimumInterestCount">minimumInterestCount (required).</param>
        /// <param name="requireLinkedInstance">requireLinkedInstance (required).</param>
        /// <param name="scope">scope (required).</param>
        /// <param name="upcomingOffsetMinutes">upcomingOffsetMinutes (required).</param>
        /// <param name="upcomingSort">upcomingSort (required).</param>
        public InfoPushDataContentSourceCalendarDiscoverParams(CalendarEventDiscoveryInclusion featuredResults = default, int minimumInterestCount = default, bool requireLinkedInstance = default, CalendarEventDiscoveryScope scope = default, int upcomingOffsetMinutes = default, CalendarEventDiscoverySort upcomingSort = default)
        {
            this.FeaturedResults = featuredResults;
            this.MinimumInterestCount = minimumInterestCount;
            this.RequireLinkedInstance = requireLinkedInstance;
            this.Scope = scope;
            this.UpcomingOffsetMinutes = upcomingOffsetMinutes;
            this.UpcomingSort = upcomingSort;
        }

        /// <summary>
        /// Gets or Sets MinimumInterestCount
        /// </summary>
        [DataMember(Name = "minimumInterestCount", IsRequired = true, EmitDefaultValue = true)]
        public int MinimumInterestCount { get; set; }

        /// <summary>
        /// Gets or Sets RequireLinkedInstance
        /// </summary>
        [DataMember(Name = "requireLinkedInstance", IsRequired = true, EmitDefaultValue = true)]
        public bool RequireLinkedInstance { get; set; }

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
            sb.Append("class InfoPushDataContentSourceCalendarDiscoverParams {\n");
            sb.Append("  FeaturedResults: ").Append(FeaturedResults).Append("\n");
            sb.Append("  MinimumInterestCount: ").Append(MinimumInterestCount).Append("\n");
            sb.Append("  RequireLinkedInstance: ").Append(RequireLinkedInstance).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  UpcomingOffsetMinutes: ").Append(UpcomingOffsetMinutes).Append("\n");
            sb.Append("  UpcomingSort: ").Append(UpcomingSort).Append("\n");
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
            return this.Equals(input as InfoPushDataContentSourceCalendarDiscoverParams);
        }

        /// <summary>
        /// Returns true if InfoPushDataContentSourceCalendarDiscoverParams instances are equal
        /// </summary>
        /// <param name="input">Instance of InfoPushDataContentSourceCalendarDiscoverParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InfoPushDataContentSourceCalendarDiscoverParams input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.FeaturedResults == input.FeaturedResults ||
                    this.FeaturedResults.Equals(input.FeaturedResults)
                ) && 
                (
                    this.MinimumInterestCount == input.MinimumInterestCount ||
                    this.MinimumInterestCount.Equals(input.MinimumInterestCount)
                ) && 
                (
                    this.RequireLinkedInstance == input.RequireLinkedInstance ||
                    this.RequireLinkedInstance.Equals(input.RequireLinkedInstance)
                ) && 
                (
                    this.Scope == input.Scope ||
                    this.Scope.Equals(input.Scope)
                ) && 
                (
                    this.UpcomingOffsetMinutes == input.UpcomingOffsetMinutes ||
                    this.UpcomingOffsetMinutes.Equals(input.UpcomingOffsetMinutes)
                ) && 
                (
                    this.UpcomingSort == input.UpcomingSort ||
                    this.UpcomingSort.Equals(input.UpcomingSort)
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
                hashCode = (hashCode * 59) + this.FeaturedResults.GetHashCode();
                hashCode = (hashCode * 59) + this.MinimumInterestCount.GetHashCode();
                hashCode = (hashCode * 59) + this.RequireLinkedInstance.GetHashCode();
                hashCode = (hashCode * 59) + this.Scope.GetHashCode();
                hashCode = (hashCode * 59) + this.UpcomingOffsetMinutes.GetHashCode();
                hashCode = (hashCode * 59) + this.UpcomingSort.GetHashCode();
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
