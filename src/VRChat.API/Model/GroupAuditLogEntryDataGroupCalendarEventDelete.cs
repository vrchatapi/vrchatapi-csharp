

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
    /// GroupAuditLogEntryDataGroupCalendarEventDelete
    /// </summary>
    [DataContract(Name = "GroupAuditLogEntryDataGroupCalendarEventDelete")]
    public partial class GroupAuditLogEntryDataGroupCalendarEventDelete : IEquatable<GroupAuditLogEntryDataGroupCalendarEventDelete>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets AccessType
        /// </summary>
        [DataMember(Name = "accessType", IsRequired = true, EmitDefaultValue = true)]
        public CalendarEventAccess AccessType { get; set; }

        /// <summary>
        /// Gets or Sets OccurrenceKind
        /// </summary>
        [DataMember(Name = "occurrenceKind", IsRequired = true, EmitDefaultValue = true)]
        public CalendarEventOccurrenceKind OccurrenceKind { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLogEntryDataGroupCalendarEventDelete" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GroupAuditLogEntryDataGroupCalendarEventDelete() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLogEntryDataGroupCalendarEventDelete" /> class.
        /// </summary>
        /// <param name="accessType">accessType (required).</param>
        /// <param name="description">The description of the calendar event. (required).</param>
        /// <param name="imageId">The image file ID for the event. (required).</param>
        /// <param name="title">The title of the calendar event. (required).</param>
        /// <param name="type">The type of calendar entry. (required).</param>
        /// <param name="category">The category of the event. (required).</param>
        /// <param name="closeInstanceAfterEndMinutes">Minutes after the event ends to close the instance. (required).</param>
        /// <param name="createdAt">The creation timestamp. (required).</param>
        /// <param name="deletedAt">The deletion timestamp. (required).</param>
        /// <param name="durationInMs">The duration of the event in milliseconds. (required).</param>
        /// <param name="endsAt">The end timestamp. (required).</param>
        /// <param name="featured">Whether the event is featured. (required).</param>
        /// <param name="guestEarlyJoinMinutes">Minutes before the start that guests can join. (required).</param>
        /// <param name="hostEarlyJoinMinutes">Minutes before the start that hosts can join. (required).</param>
        /// <param name="interestedUserCount">The number of interested users. (required).</param>
        /// <param name="isDraft">Whether the event is a draft. (required).</param>
        /// <param name="languages">The languages for the event. (required).</param>
        /// <param name="occurrenceKind">occurrenceKind (required).</param>
        /// <param name="occurrenceModified">occurrenceModified (required).</param>
        /// <param name="ownerId">The ID of the group that owns the event. (required).</param>
        /// <param name="platforms">The supported platforms. (required).</param>
        /// <param name="recurrence">The recurrence rule. (required).</param>
        /// <param name="roleIds">Group roles that may join this event. (required).</param>
        /// <param name="seriesId">The ID of the recurring series the event belongs to. (required).</param>
        /// <param name="shortCode">The short code. (required).</param>
        /// <param name="startsAt">The start timestamp. (required).</param>
        /// <param name="tags">The event tags. (required).</param>
        /// <param name="updatedAt">The last update timestamp. (required).</param>
        /// <param name="usesInstanceOverflow">Whether the event uses instance overflow. (required).</param>
        public GroupAuditLogEntryDataGroupCalendarEventDelete(CalendarEventAccess accessType = default, string description = default, string imageId = default, string title = default, string type = default, string category = default, int closeInstanceAfterEndMinutes = default, DateTime createdAt = default, DateTime? deletedAt = default, int durationInMs = default, DateTime endsAt = default, bool featured = default, int guestEarlyJoinMinutes = default, int hostEarlyJoinMinutes = default, int interestedUserCount = default, bool isDraft = default, List<string> languages = default, CalendarEventOccurrenceKind occurrenceKind = default, string occurrenceModified = default, string ownerId = default, List<string> platforms = default, CalendarEventRecurrence recurrence = default, List<string> roleIds = default, string seriesId = default, string shortCode = default, DateTime startsAt = default, List<string> tags = default, DateTime updatedAt = default, bool usesInstanceOverflow = default)
        {
            this.AccessType = accessType;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Description = description;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.ImageId = imageId;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Title = title;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Type = type;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Category = category;
            this.CloseInstanceAfterEndMinutes = closeInstanceAfterEndMinutes;
            this.CreatedAt = createdAt;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.DeletedAt = deletedAt;
            this.DurationInMs = durationInMs;
            this.EndsAt = endsAt;
            this.Featured = featured;
            this.GuestEarlyJoinMinutes = guestEarlyJoinMinutes;
            this.HostEarlyJoinMinutes = hostEarlyJoinMinutes;
            this.InterestedUserCount = interestedUserCount;
            this.IsDraft = isDraft;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Languages = languages;
            this.OccurrenceKind = occurrenceKind;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.OccurrenceModified = occurrenceModified;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.OwnerId = ownerId;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Platforms = platforms;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Recurrence = recurrence;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.RoleIds = roleIds;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.SeriesId = seriesId;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.ShortCode = shortCode;
            this.StartsAt = startsAt;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Tags = tags;
            this.UpdatedAt = updatedAt;
            this.UsesInstanceOverflow = usesInstanceOverflow;
        }

        /// <summary>
        /// The description of the calendar event.
        /// </summary>
        /// <value>The description of the calendar event.</value>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// The image file ID for the event.
        /// </summary>
        /// <value>The image file ID for the event.</value>
        [DataMember(Name = "imageId", IsRequired = true, EmitDefaultValue = true)]
        public string ImageId { get; set; }

        /// <summary>
        /// The title of the calendar event.
        /// </summary>
        /// <value>The title of the calendar event.</value>
        [DataMember(Name = "title", IsRequired = true, EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// The type of calendar entry.
        /// </summary>
        /// <value>The type of calendar entry.</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// The category of the event.
        /// </summary>
        /// <value>The category of the event.</value>
        [DataMember(Name = "category", IsRequired = true, EmitDefaultValue = true)]
        public string Category { get; set; }

        /// <summary>
        /// Minutes after the event ends to close the instance.
        /// </summary>
        /// <value>Minutes after the event ends to close the instance.</value>
        [DataMember(Name = "closeInstanceAfterEndMinutes", IsRequired = true, EmitDefaultValue = true)]
        public int CloseInstanceAfterEndMinutes { get; set; }

        /// <summary>
        /// The creation timestamp.
        /// </summary>
        /// <value>The creation timestamp.</value>
        [DataMember(Name = "createdAt", IsRequired = true, EmitDefaultValue = true)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// The deletion timestamp.
        /// </summary>
        /// <value>The deletion timestamp.</value>
        [DataMember(Name = "deletedAt", IsRequired = true, EmitDefaultValue = true)]
        public DateTime? DeletedAt { get; set; }

        /// <summary>
        /// The duration of the event in milliseconds.
        /// </summary>
        /// <value>The duration of the event in milliseconds.</value>
        [DataMember(Name = "durationInMs", IsRequired = true, EmitDefaultValue = true)]
        public int DurationInMs { get; set; }

        /// <summary>
        /// The end timestamp.
        /// </summary>
        /// <value>The end timestamp.</value>
        [DataMember(Name = "endsAt", IsRequired = true, EmitDefaultValue = true)]
        public DateTime EndsAt { get; set; }

        /// <summary>
        /// Whether the event is featured.
        /// </summary>
        /// <value>Whether the event is featured.</value>
        [DataMember(Name = "featured", IsRequired = true, EmitDefaultValue = true)]
        public bool Featured { get; set; }

        /// <summary>
        /// Minutes before the start that guests can join.
        /// </summary>
        /// <value>Minutes before the start that guests can join.</value>
        [DataMember(Name = "guestEarlyJoinMinutes", IsRequired = true, EmitDefaultValue = true)]
        public int GuestEarlyJoinMinutes { get; set; }

        /// <summary>
        /// Minutes before the start that hosts can join.
        /// </summary>
        /// <value>Minutes before the start that hosts can join.</value>
        [DataMember(Name = "hostEarlyJoinMinutes", IsRequired = true, EmitDefaultValue = true)]
        public int HostEarlyJoinMinutes { get; set; }

        /// <summary>
        /// The number of interested users.
        /// </summary>
        /// <value>The number of interested users.</value>
        [DataMember(Name = "interestedUserCount", IsRequired = true, EmitDefaultValue = true)]
        public int InterestedUserCount { get; set; }

        /// <summary>
        /// Whether the event is a draft.
        /// </summary>
        /// <value>Whether the event is a draft.</value>
        [DataMember(Name = "isDraft", IsRequired = true, EmitDefaultValue = true)]
        public bool IsDraft { get; set; }

        /// <summary>
        /// The languages for the event.
        /// </summary>
        /// <value>The languages for the event.</value>
        [DataMember(Name = "languages", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Languages { get; set; }

        /// <summary>
        /// Gets or Sets OccurrenceModified
        /// </summary>
        [DataMember(Name = "occurrenceModified", IsRequired = true, EmitDefaultValue = true)]
        public string OccurrenceModified { get; set; }

        /// <summary>
        /// The ID of the group that owns the event.
        /// </summary>
        /// <value>The ID of the group that owns the event.</value>
        [DataMember(Name = "ownerId", IsRequired = true, EmitDefaultValue = true)]
        public string OwnerId { get; set; }

        /// <summary>
        /// The supported platforms.
        /// </summary>
        /// <value>The supported platforms.</value>
        [DataMember(Name = "platforms", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Platforms { get; set; }

        /// <summary>
        /// The recurrence rule.
        /// </summary>
        /// <value>The recurrence rule.</value>
        [DataMember(Name = "recurrence", IsRequired = true, EmitDefaultValue = true)]
        public CalendarEventRecurrence Recurrence { get; set; }

        /// <summary>
        /// Group roles that may join this event.
        /// </summary>
        /// <value>Group roles that may join this event.</value>
        [DataMember(Name = "roleIds", IsRequired = true, EmitDefaultValue = true)]
        public List<string> RoleIds { get; set; }

        /// <summary>
        /// The ID of the recurring series the event belongs to.
        /// </summary>
        /// <value>The ID of the recurring series the event belongs to.</value>
        [DataMember(Name = "seriesId", IsRequired = true, EmitDefaultValue = true)]
        public string SeriesId { get; set; }

        /// <summary>
        /// The short code.
        /// </summary>
        /// <value>The short code.</value>
        [DataMember(Name = "shortCode", IsRequired = true, EmitDefaultValue = true)]
        public string ShortCode { get; set; }

        /// <summary>
        /// The start timestamp.
        /// </summary>
        /// <value>The start timestamp.</value>
        [DataMember(Name = "startsAt", IsRequired = true, EmitDefaultValue = true)]
        public DateTime StartsAt { get; set; }

        /// <summary>
        /// The event tags.
        /// </summary>
        /// <value>The event tags.</value>
        [DataMember(Name = "tags", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// The last update timestamp.
        /// </summary>
        /// <value>The last update timestamp.</value>
        [DataMember(Name = "updatedAt", IsRequired = true, EmitDefaultValue = true)]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Whether the event uses instance overflow.
        /// </summary>
        /// <value>Whether the event uses instance overflow.</value>
        [DataMember(Name = "usesInstanceOverflow", IsRequired = true, EmitDefaultValue = true)]
        public bool UsesInstanceOverflow { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GroupAuditLogEntryDataGroupCalendarEventDelete {\n");
            sb.Append("  AccessType: ").Append(AccessType).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ImageId: ").Append(ImageId).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  CloseInstanceAfterEndMinutes: ").Append(CloseInstanceAfterEndMinutes).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  DeletedAt: ").Append(DeletedAt).Append("\n");
            sb.Append("  DurationInMs: ").Append(DurationInMs).Append("\n");
            sb.Append("  EndsAt: ").Append(EndsAt).Append("\n");
            sb.Append("  Featured: ").Append(Featured).Append("\n");
            sb.Append("  GuestEarlyJoinMinutes: ").Append(GuestEarlyJoinMinutes).Append("\n");
            sb.Append("  HostEarlyJoinMinutes: ").Append(HostEarlyJoinMinutes).Append("\n");
            sb.Append("  InterestedUserCount: ").Append(InterestedUserCount).Append("\n");
            sb.Append("  IsDraft: ").Append(IsDraft).Append("\n");
            sb.Append("  Languages: ").Append(Languages).Append("\n");
            sb.Append("  OccurrenceKind: ").Append(OccurrenceKind).Append("\n");
            sb.Append("  OccurrenceModified: ").Append(OccurrenceModified).Append("\n");
            sb.Append("  OwnerId: ").Append(OwnerId).Append("\n");
            sb.Append("  Platforms: ").Append(Platforms).Append("\n");
            sb.Append("  Recurrence: ").Append(Recurrence).Append("\n");
            sb.Append("  RoleIds: ").Append(RoleIds).Append("\n");
            sb.Append("  SeriesId: ").Append(SeriesId).Append("\n");
            sb.Append("  ShortCode: ").Append(ShortCode).Append("\n");
            sb.Append("  StartsAt: ").Append(StartsAt).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  UsesInstanceOverflow: ").Append(UsesInstanceOverflow).Append("\n");
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
            return this.Equals(input as GroupAuditLogEntryDataGroupCalendarEventDelete);
        }

        /// <summary>
        /// Returns true if GroupAuditLogEntryDataGroupCalendarEventDelete instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupAuditLogEntryDataGroupCalendarEventDelete to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupAuditLogEntryDataGroupCalendarEventDelete input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccessType == input.AccessType ||
                    this.AccessType.Equals(input.AccessType)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.ImageId == input.ImageId ||
                    (this.ImageId != null &&
                    this.ImageId.Equals(input.ImageId))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.CloseInstanceAfterEndMinutes == input.CloseInstanceAfterEndMinutes ||
                    this.CloseInstanceAfterEndMinutes.Equals(input.CloseInstanceAfterEndMinutes)
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    this.CreatedAt.Equals(input.CreatedAt)
                ) && 
                (
                    this.DeletedAt == input.DeletedAt ||
                    (this.DeletedAt != null &&
                    this.DeletedAt.Equals(input.DeletedAt))
                ) && 
                (
                    this.DurationInMs == input.DurationInMs ||
                    this.DurationInMs.Equals(input.DurationInMs)
                ) && 
                (
                    this.EndsAt == input.EndsAt ||
                    this.EndsAt.Equals(input.EndsAt)
                ) && 
                (
                    this.Featured == input.Featured ||
                    this.Featured.Equals(input.Featured)
                ) && 
                (
                    this.GuestEarlyJoinMinutes == input.GuestEarlyJoinMinutes ||
                    this.GuestEarlyJoinMinutes.Equals(input.GuestEarlyJoinMinutes)
                ) && 
                (
                    this.HostEarlyJoinMinutes == input.HostEarlyJoinMinutes ||
                    this.HostEarlyJoinMinutes.Equals(input.HostEarlyJoinMinutes)
                ) && 
                (
                    this.InterestedUserCount == input.InterestedUserCount ||
                    this.InterestedUserCount.Equals(input.InterestedUserCount)
                ) && 
                (
                    this.IsDraft == input.IsDraft ||
                    this.IsDraft.Equals(input.IsDraft)
                ) && 
                (
                    this.Languages == input.Languages ||
                    this.Languages != null &&
                    input.Languages != null &&
                    this.Languages.SequenceEqual(input.Languages)
                ) && 
                (
                    this.OccurrenceKind == input.OccurrenceKind ||
                    this.OccurrenceKind.Equals(input.OccurrenceKind)
                ) && 
                (
                    this.OccurrenceModified == input.OccurrenceModified ||
                    (this.OccurrenceModified != null &&
                    this.OccurrenceModified.Equals(input.OccurrenceModified))
                ) && 
                (
                    this.OwnerId == input.OwnerId ||
                    (this.OwnerId != null &&
                    this.OwnerId.Equals(input.OwnerId))
                ) && 
                (
                    this.Platforms == input.Platforms ||
                    this.Platforms != null &&
                    input.Platforms != null &&
                    this.Platforms.SequenceEqual(input.Platforms)
                ) && 
                (
                    this.Recurrence == input.Recurrence ||
                    (this.Recurrence != null &&
                    this.Recurrence.Equals(input.Recurrence))
                ) && 
                (
                    this.RoleIds == input.RoleIds ||
                    this.RoleIds != null &&
                    input.RoleIds != null &&
                    this.RoleIds.SequenceEqual(input.RoleIds)
                ) && 
                (
                    this.SeriesId == input.SeriesId ||
                    (this.SeriesId != null &&
                    this.SeriesId.Equals(input.SeriesId))
                ) && 
                (
                    this.ShortCode == input.ShortCode ||
                    (this.ShortCode != null &&
                    this.ShortCode.Equals(input.ShortCode))
                ) && 
                (
                    this.StartsAt == input.StartsAt ||
                    this.StartsAt.Equals(input.StartsAt)
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
                ) && 
                (
                    this.UsesInstanceOverflow == input.UsesInstanceOverflow ||
                    this.UsesInstanceOverflow.Equals(input.UsesInstanceOverflow)
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
                hashCode = (hashCode * 59) + this.AccessType.GetHashCode();
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.ImageId != null)
                {
                    hashCode = (hashCode * 59) + this.ImageId.GetHashCode();
                }
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                if (this.Category != null)
                {
                    hashCode = (hashCode * 59) + this.Category.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CloseInstanceAfterEndMinutes.GetHashCode();
                hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                if (this.DeletedAt != null)
                {
                    hashCode = (hashCode * 59) + this.DeletedAt.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.DurationInMs.GetHashCode();
                hashCode = (hashCode * 59) + this.EndsAt.GetHashCode();
                hashCode = (hashCode * 59) + this.Featured.GetHashCode();
                hashCode = (hashCode * 59) + this.GuestEarlyJoinMinutes.GetHashCode();
                hashCode = (hashCode * 59) + this.HostEarlyJoinMinutes.GetHashCode();
                hashCode = (hashCode * 59) + this.InterestedUserCount.GetHashCode();
                hashCode = (hashCode * 59) + this.IsDraft.GetHashCode();
                if (this.Languages != null)
                {
                    hashCode = (hashCode * 59) + this.Languages.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.OccurrenceKind.GetHashCode();
                if (this.OccurrenceModified != null)
                {
                    hashCode = (hashCode * 59) + this.OccurrenceModified.GetHashCode();
                }
                if (this.OwnerId != null)
                {
                    hashCode = (hashCode * 59) + this.OwnerId.GetHashCode();
                }
                if (this.Platforms != null)
                {
                    hashCode = (hashCode * 59) + this.Platforms.GetHashCode();
                }
                if (this.Recurrence != null)
                {
                    hashCode = (hashCode * 59) + this.Recurrence.GetHashCode();
                }
                if (this.RoleIds != null)
                {
                    hashCode = (hashCode * 59) + this.RoleIds.GetHashCode();
                }
                if (this.SeriesId != null)
                {
                    hashCode = (hashCode * 59) + this.SeriesId.GetHashCode();
                }
                if (this.ShortCode != null)
                {
                    hashCode = (hashCode * 59) + this.ShortCode.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.StartsAt.GetHashCode();
                if (this.Tags != null)
                {
                    hashCode = (hashCode * 59) + this.Tags.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
                hashCode = (hashCode * 59) + this.UsesInstanceOverflow.GetHashCode();
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
