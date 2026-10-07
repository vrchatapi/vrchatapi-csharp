

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
    /// GroupAuditLogEntryEventData
    /// </summary>
    [DataContract(Name = "GroupAuditLogEntryEvent_data")]
    public partial class GroupAuditLogEntryEventData : IEquatable<GroupAuditLogEntryEventData>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets AccessType
        /// </summary>
        [DataMember(Name = "accessType", EmitDefaultValue = false)]
        public CalendarEventAccess? AccessType { get; set; }

        /// <summary>
        /// Gets or Sets OccurrenceKind
        /// </summary>
        [DataMember(Name = "occurrenceKind", EmitDefaultValue = false)]
        public CalendarEventOccurrenceKind? OccurrenceKind { get; set; }

        /// <summary>
        /// Gets or Sets GroupAccessType
        /// </summary>
        [DataMember(Name = "groupAccessType", EmitDefaultValue = false)]
        public GroupAccessType? GroupAccessType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLogEntryEventData" /> class.
        /// </summary>
        /// <param name="authorId">A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed..</param>
        /// <param name="imageId">imageId.</param>
        /// <param name="sendNotification">sendNotification.</param>
        /// <param name="text">text.</param>
        /// <param name="title">title.</param>
        /// <param name="accessType">accessType.</param>
        /// <param name="description">description.</param>
        /// <param name="type">The type of calendar entry..</param>
        /// <param name="category">The category of the event..</param>
        /// <param name="closeInstanceAfterEndMinutes">Minutes after the event ends to close the instance..</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="deletedAt">The deletion timestamp..</param>
        /// <param name="durationInMs">The duration of the event in milliseconds..</param>
        /// <param name="endsAt">The end timestamp..</param>
        /// <param name="featured">Whether the event is featured..</param>
        /// <param name="guestEarlyJoinMinutes">Minutes before the start that guests can join..</param>
        /// <param name="hostEarlyJoinMinutes">Minutes before the start that hosts can join..</param>
        /// <param name="interestedUserCount">The number of interested users..</param>
        /// <param name="isDraft">Whether the event is a draft..</param>
        /// <param name="languages">languages.</param>
        /// <param name="occurrenceKind">occurrenceKind.</param>
        /// <param name="occurrenceModified">occurrenceModified.</param>
        /// <param name="ownerId">ownerId.</param>
        /// <param name="platforms">The supported platforms..</param>
        /// <param name="recurrence">recurrence.</param>
        /// <param name="roleIds">roleIds.</param>
        /// <param name="seriesId">The ID of the recurring series the event belongs to..</param>
        /// <param name="shortCode">shortCode.</param>
        /// <param name="startsAt">The start timestamp..</param>
        /// <param name="tags">tags.</param>
        /// <param name="updatedAt">updatedAt.</param>
        /// <param name="usesInstanceOverflow">Whether the event uses instance overflow..</param>
        /// <param name="membersOnly">membersOnly.</param>
        /// <param name="name">name.</param>
        /// <param name="roleIdsToAutoApprove">The role IDs whose submissions are approved automatically..</param>
        /// <param name="roleIdsToManage">The role IDs that can manage the gallery..</param>
        /// <param name="roleIdsToSubmit">The role IDs that can submit to the gallery..</param>
        /// <param name="roleIdsToView">The role IDs that can view the gallery..</param>
        /// <param name="message">The announcement message..</param>
        /// <param name="groupAccessType">groupAccessType.</param>
        /// <param name="calendarEntryId">calendarEntryId.</param>
        /// <param name="location">Represents a unique location, consisting of a world identifier and an instance identifier, or \&quot;offline\&quot; if the user is not on your friends list..</param>
        /// <param name="roleId">roleId.</param>
        /// <param name="roleName">The name of the role that was assigned or unassigned..</param>
        /// <param name="managerNotes">managerNotes.</param>
        /// <param name="editorId">editorId.</param>
        /// <param name="imageUrl">The URL of the post image..</param>
        /// <param name="groupId">groupId.</param>
        /// <param name="lastUpdatedByUserId">A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed..</param>
        /// <param name="defaultRole">Whether the role is the group&#39;s default role..</param>
        /// <param name="isManagementRole">Whether the role is a management role..</param>
        /// <param name="isAddedOnJoin">isAddedOnJoin.</param>
        /// <param name="isSelfAssignable">isSelfAssignable.</param>
        /// <param name="order">order.</param>
        /// <param name="permissions">permissions.</param>
        /// <param name="allowGroupJoinPrompt">allowGroupJoinPrompt.</param>
        /// <param name="bannerId">bannerId.</param>
        /// <param name="iconId">iconId.</param>
        /// <param name="joinState">joinState.</param>
        /// <param name="links">links.</param>
        /// <param name="nameplateId">nameplateId.</param>
        /// <param name="rules">rules.</param>
        public GroupAuditLogEntryEventData(string authorId = default, string imageId = default, bool sendNotification = default, Object text = default, Object title = default, CalendarEventAccess? accessType = default, Object description = default, string type = default, string category = default, int closeInstanceAfterEndMinutes = default, DateTime createdAt = default, DateTime? deletedAt = default, int durationInMs = default, DateTime endsAt = default, bool featured = default, int guestEarlyJoinMinutes = default, int hostEarlyJoinMinutes = default, int interestedUserCount = default, bool isDraft = default, Object languages = default, CalendarEventOccurrenceKind? occurrenceKind = default, string occurrenceModified = default, string ownerId = default, List<string> platforms = default, CalendarEventRecurrence recurrence = default, List<string> roleIds = default, string seriesId = default, Object shortCode = default, DateTime startsAt = default, Object tags = default, DateTime updatedAt = default, bool usesInstanceOverflow = default, Object membersOnly = default, Object name = default, List<string> roleIdsToAutoApprove = default, List<string> roleIdsToManage = default, List<string> roleIdsToSubmit = default, List<string> roleIdsToView = default, string message = default, GroupAccessType? groupAccessType = default, string calendarEntryId = default, string location = default, string roleId = default, string roleName = default, GroupAuditLogEntryStringChange managerNotes = default, Object editorId = default, string imageUrl = default, string groupId = default, string lastUpdatedByUserId = default, bool defaultRole = default, bool isManagementRole = default, GroupAuditLogEntryBooleanChange isAddedOnJoin = default, GroupAuditLogEntryBooleanChange isSelfAssignable = default, GroupAuditLogEntryIntegerChange order = default, GroupAuditLogEntryStringListChange permissions = default, GroupAuditLogEntryBooleanChange allowGroupJoinPrompt = default, GroupAuditLogEntryFileIDChange bannerId = default, GroupAuditLogEntryFileIDChange iconId = default, GroupAuditLogEntryJoinStateChange joinState = default, GroupAuditLogEntryStringListChange links = default, GroupAuditLogEntryFileIDChange nameplateId = default, GroupAuditLogEntryStringChange rules = default)
        {
            this.AuthorId = authorId;
            this.ImageId = imageId;
            this.SendNotification = sendNotification;
            this.Text = text;
            this.Title = title;
            this.AccessType = accessType;
            this.Description = description;
            this.Type = type;
            this.Category = category;
            this.CloseInstanceAfterEndMinutes = closeInstanceAfterEndMinutes;
            this.CreatedAt = createdAt;
            this.DeletedAt = deletedAt;
            this.DurationInMs = durationInMs;
            this.EndsAt = endsAt;
            this.Featured = featured;
            this.GuestEarlyJoinMinutes = guestEarlyJoinMinutes;
            this.HostEarlyJoinMinutes = hostEarlyJoinMinutes;
            this.InterestedUserCount = interestedUserCount;
            this.IsDraft = isDraft;
            this.Languages = languages;
            this.OccurrenceKind = occurrenceKind;
            this.OccurrenceModified = occurrenceModified;
            this.OwnerId = ownerId;
            this.Platforms = platforms;
            this.Recurrence = recurrence;
            this.RoleIds = roleIds;
            this.SeriesId = seriesId;
            this.ShortCode = shortCode;
            this.StartsAt = startsAt;
            this.Tags = tags;
            this.UpdatedAt = updatedAt;
            this.UsesInstanceOverflow = usesInstanceOverflow;
            this.MembersOnly = membersOnly;
            this.Name = name;
            this.RoleIdsToAutoApprove = roleIdsToAutoApprove;
            this.RoleIdsToManage = roleIdsToManage;
            this.RoleIdsToSubmit = roleIdsToSubmit;
            this.RoleIdsToView = roleIdsToView;
            this.Message = message;
            this.GroupAccessType = groupAccessType;
            this.CalendarEntryId = calendarEntryId;
            this.Location = location;
            this.RoleId = roleId;
            this.RoleName = roleName;
            this.ManagerNotes = managerNotes;
            this.EditorId = editorId;
            this.ImageUrl = imageUrl;
            this.GroupId = groupId;
            this.LastUpdatedByUserId = lastUpdatedByUserId;
            this.DefaultRole = defaultRole;
            this.IsManagementRole = isManagementRole;
            this.IsAddedOnJoin = isAddedOnJoin;
            this.IsSelfAssignable = isSelfAssignable;
            this.Order = order;
            this.Permissions = permissions;
            this.AllowGroupJoinPrompt = allowGroupJoinPrompt;
            this.BannerId = bannerId;
            this.IconId = iconId;
            this.JoinState = joinState;
            this.Links = links;
            this.NameplateId = nameplateId;
            this.Rules = rules;
        }

        /// <summary>
        /// A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed.
        /// </summary>
        /// <value>A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed.</value>
        /*
        <example>usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469</example>
        */
        [DataMember(Name = "authorId", EmitDefaultValue = false)]
        public string AuthorId { get; set; }

        /// <summary>
        /// Gets or Sets ImageId
        /// </summary>
        /*
        <example>file_ce35d830-e20a-4df0-a6d4-5aaef4508044</example>
        */
        [DataMember(Name = "imageId", EmitDefaultValue = false)]
        public string ImageId { get; set; }

        /// <summary>
        /// Gets or Sets SendNotification
        /// </summary>
        [DataMember(Name = "sendNotification", EmitDefaultValue = true)]
        public bool SendNotification { get; set; }

        /// <summary>
        /// Gets or Sets Text
        /// </summary>
        [DataMember(Name = "text", EmitDefaultValue = true)]
        public Object Text { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public Object Title { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public Object Description { get; set; }

        /// <summary>
        /// The type of calendar entry.
        /// </summary>
        /// <value>The type of calendar entry.</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// The category of the event.
        /// </summary>
        /// <value>The category of the event.</value>
        [DataMember(Name = "category", EmitDefaultValue = false)]
        public string Category { get; set; }

        /// <summary>
        /// Minutes after the event ends to close the instance.
        /// </summary>
        /// <value>Minutes after the event ends to close the instance.</value>
        [DataMember(Name = "closeInstanceAfterEndMinutes", EmitDefaultValue = false)]
        public int CloseInstanceAfterEndMinutes { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "createdAt", EmitDefaultValue = false)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// The deletion timestamp.
        /// </summary>
        /// <value>The deletion timestamp.</value>
        [DataMember(Name = "deletedAt", EmitDefaultValue = true)]
        public DateTime? DeletedAt { get; set; }

        /// <summary>
        /// The duration of the event in milliseconds.
        /// </summary>
        /// <value>The duration of the event in milliseconds.</value>
        [DataMember(Name = "durationInMs", EmitDefaultValue = false)]
        public int DurationInMs { get; set; }

        /// <summary>
        /// The end timestamp.
        /// </summary>
        /// <value>The end timestamp.</value>
        [DataMember(Name = "endsAt", EmitDefaultValue = false)]
        public DateTime EndsAt { get; set; }

        /// <summary>
        /// Whether the event is featured.
        /// </summary>
        /// <value>Whether the event is featured.</value>
        [DataMember(Name = "featured", EmitDefaultValue = true)]
        public bool Featured { get; set; }

        /// <summary>
        /// Minutes before the start that guests can join.
        /// </summary>
        /// <value>Minutes before the start that guests can join.</value>
        [DataMember(Name = "guestEarlyJoinMinutes", EmitDefaultValue = false)]
        public int GuestEarlyJoinMinutes { get; set; }

        /// <summary>
        /// Minutes before the start that hosts can join.
        /// </summary>
        /// <value>Minutes before the start that hosts can join.</value>
        [DataMember(Name = "hostEarlyJoinMinutes", EmitDefaultValue = false)]
        public int HostEarlyJoinMinutes { get; set; }

        /// <summary>
        /// The number of interested users.
        /// </summary>
        /// <value>The number of interested users.</value>
        [DataMember(Name = "interestedUserCount", EmitDefaultValue = false)]
        public int InterestedUserCount { get; set; }

        /// <summary>
        /// Whether the event is a draft.
        /// </summary>
        /// <value>Whether the event is a draft.</value>
        [DataMember(Name = "isDraft", EmitDefaultValue = true)]
        public bool IsDraft { get; set; }

        /// <summary>
        /// Gets or Sets Languages
        /// </summary>
        [DataMember(Name = "languages", EmitDefaultValue = true)]
        public Object Languages { get; set; }

        /// <summary>
        /// Gets or Sets OccurrenceModified
        /// </summary>
        [DataMember(Name = "occurrenceModified", EmitDefaultValue = true)]
        public string OccurrenceModified { get; set; }

        /// <summary>
        /// Gets or Sets OwnerId
        /// </summary>
        /*
        <example>grp_71a7ff59-112c-4e78-a990-c7cc650776e5</example>
        */
        [DataMember(Name = "ownerId", EmitDefaultValue = false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// The supported platforms.
        /// </summary>
        /// <value>The supported platforms.</value>
        [DataMember(Name = "platforms", EmitDefaultValue = false)]
        public List<string> Platforms { get; set; }

        /// <summary>
        /// Gets or Sets Recurrence
        /// </summary>
        [DataMember(Name = "recurrence", EmitDefaultValue = false)]
        public CalendarEventRecurrence Recurrence { get; set; }

        /// <summary>
        /// Gets or Sets RoleIds
        /// </summary>
        [DataMember(Name = "roleIds", EmitDefaultValue = true)]
        public List<string> RoleIds { get; set; }

        /// <summary>
        /// The ID of the recurring series the event belongs to.
        /// </summary>
        /// <value>The ID of the recurring series the event belongs to.</value>
        [DataMember(Name = "seriesId", EmitDefaultValue = true)]
        public string SeriesId { get; set; }

        /// <summary>
        /// Gets or Sets ShortCode
        /// </summary>
        [DataMember(Name = "shortCode", EmitDefaultValue = true)]
        public Object ShortCode { get; set; }

        /// <summary>
        /// The start timestamp.
        /// </summary>
        /// <value>The start timestamp.</value>
        [DataMember(Name = "startsAt", EmitDefaultValue = false)]
        public DateTime StartsAt { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name = "tags", EmitDefaultValue = true)]
        public Object Tags { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updatedAt", EmitDefaultValue = false)]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Whether the event uses instance overflow.
        /// </summary>
        /// <value>Whether the event uses instance overflow.</value>
        [DataMember(Name = "usesInstanceOverflow", EmitDefaultValue = true)]
        public bool UsesInstanceOverflow { get; set; }

        /// <summary>
        /// Gets or Sets MembersOnly
        /// </summary>
        [DataMember(Name = "membersOnly", EmitDefaultValue = true)]
        public Object MembersOnly { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public Object Name { get; set; }

        /// <summary>
        /// The role IDs whose submissions are approved automatically.
        /// </summary>
        /// <value>The role IDs whose submissions are approved automatically.</value>
        [DataMember(Name = "roleIdsToAutoApprove", EmitDefaultValue = true)]
        public List<string> RoleIdsToAutoApprove { get; set; }

        /// <summary>
        /// The role IDs that can manage the gallery.
        /// </summary>
        /// <value>The role IDs that can manage the gallery.</value>
        [DataMember(Name = "roleIdsToManage", EmitDefaultValue = true)]
        public List<string> RoleIdsToManage { get; set; }

        /// <summary>
        /// The role IDs that can submit to the gallery.
        /// </summary>
        /// <value>The role IDs that can submit to the gallery.</value>
        [DataMember(Name = "roleIdsToSubmit", EmitDefaultValue = true)]
        public List<string> RoleIdsToSubmit { get; set; }

        /// <summary>
        /// The role IDs that can view the gallery.
        /// </summary>
        /// <value>The role IDs that can view the gallery.</value>
        [DataMember(Name = "roleIdsToView", EmitDefaultValue = true)]
        public List<string> RoleIdsToView { get; set; }

        /// <summary>
        /// The announcement message.
        /// </summary>
        /// <value>The announcement message.</value>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets CalendarEntryId
        /// </summary>
        /*
        <example>cal_6b182f0c-61ef-4bdf-97fe-94f63bcba27b</example>
        */
        [DataMember(Name = "calendarEntryId", EmitDefaultValue = false)]
        public string CalendarEntryId { get; set; }

        /// <summary>
        /// Represents a unique location, consisting of a world identifier and an instance identifier, or \&quot;offline\&quot; if the user is not on your friends list.
        /// </summary>
        /// <value>Represents a unique location, consisting of a world identifier and an instance identifier, or \&quot;offline\&quot; if the user is not on your friends list.</value>
        /*
        <example>wrld_4432ea9b-729c-46e3-8eaf-846aa0a37fdd:12345~hidden(usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469)~region(eu)~nonce(27e8414a-59a0-4f3d-af1f-f27557eb49a2)</example>
        */
        [DataMember(Name = "location", EmitDefaultValue = false)]
        public string Location { get; set; }

        /// <summary>
        /// Gets or Sets RoleId
        /// </summary>
        /*
        <example>grol_459d3911-f672-44bc-b84d-e54ffe7960fe</example>
        */
        [DataMember(Name = "roleId", EmitDefaultValue = false)]
        public string RoleId { get; set; }

        /// <summary>
        /// The name of the role that was assigned or unassigned.
        /// </summary>
        /// <value>The name of the role that was assigned or unassigned.</value>
        [DataMember(Name = "roleName", EmitDefaultValue = false)]
        public string RoleName { get; set; }

        /// <summary>
        /// Gets or Sets ManagerNotes
        /// </summary>
        [DataMember(Name = "managerNotes", EmitDefaultValue = false)]
        public GroupAuditLogEntryStringChange ManagerNotes { get; set; }

        /// <summary>
        /// Gets or Sets EditorId
        /// </summary>
        [DataMember(Name = "editorId", EmitDefaultValue = true)]
        public Object EditorId { get; set; }

        /// <summary>
        /// The URL of the post image.
        /// </summary>
        /// <value>The URL of the post image.</value>
        [DataMember(Name = "imageUrl", EmitDefaultValue = true)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// Gets or Sets GroupId
        /// </summary>
        /*
        <example>grp_71a7ff59-112c-4e78-a990-c7cc650776e5</example>
        */
        [DataMember(Name = "groupId", EmitDefaultValue = false)]
        public string GroupId { get; set; }

        /// <summary>
        /// A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed.
        /// </summary>
        /// <value>A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed.</value>
        /*
        <example>usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469</example>
        */
        [DataMember(Name = "lastUpdatedByUserId", EmitDefaultValue = false)]
        public string LastUpdatedByUserId { get; set; }

        /// <summary>
        /// Whether the role is the group&#39;s default role.
        /// </summary>
        /// <value>Whether the role is the group&#39;s default role.</value>
        [DataMember(Name = "defaultRole", EmitDefaultValue = true)]
        public bool DefaultRole { get; set; }

        /// <summary>
        /// Whether the role is a management role.
        /// </summary>
        /// <value>Whether the role is a management role.</value>
        [DataMember(Name = "isManagementRole", EmitDefaultValue = true)]
        public bool IsManagementRole { get; set; }

        /// <summary>
        /// Gets or Sets IsAddedOnJoin
        /// </summary>
        [DataMember(Name = "isAddedOnJoin", EmitDefaultValue = false)]
        public GroupAuditLogEntryBooleanChange IsAddedOnJoin { get; set; }

        /// <summary>
        /// Gets or Sets IsSelfAssignable
        /// </summary>
        [DataMember(Name = "isSelfAssignable", EmitDefaultValue = false)]
        public GroupAuditLogEntryBooleanChange IsSelfAssignable { get; set; }

        /// <summary>
        /// Gets or Sets Order
        /// </summary>
        [DataMember(Name = "order", EmitDefaultValue = false)]
        public GroupAuditLogEntryIntegerChange Order { get; set; }

        /// <summary>
        /// Gets or Sets Permissions
        /// </summary>
        [DataMember(Name = "permissions", EmitDefaultValue = false)]
        public GroupAuditLogEntryStringListChange Permissions { get; set; }

        /// <summary>
        /// Gets or Sets AllowGroupJoinPrompt
        /// </summary>
        [DataMember(Name = "allowGroupJoinPrompt", EmitDefaultValue = false)]
        public GroupAuditLogEntryBooleanChange AllowGroupJoinPrompt { get; set; }

        /// <summary>
        /// Gets or Sets BannerId
        /// </summary>
        [DataMember(Name = "bannerId", EmitDefaultValue = false)]
        public GroupAuditLogEntryFileIDChange BannerId { get; set; }

        /// <summary>
        /// Gets or Sets IconId
        /// </summary>
        [DataMember(Name = "iconId", EmitDefaultValue = false)]
        public GroupAuditLogEntryFileIDChange IconId { get; set; }

        /// <summary>
        /// Gets or Sets JoinState
        /// </summary>
        [DataMember(Name = "joinState", EmitDefaultValue = false)]
        public GroupAuditLogEntryJoinStateChange JoinState { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "links", EmitDefaultValue = false)]
        public GroupAuditLogEntryStringListChange Links { get; set; }

        /// <summary>
        /// Gets or Sets NameplateId
        /// </summary>
        [DataMember(Name = "nameplateId", EmitDefaultValue = false)]
        public GroupAuditLogEntryFileIDChange NameplateId { get; set; }

        /// <summary>
        /// Gets or Sets Rules
        /// </summary>
        [DataMember(Name = "rules", EmitDefaultValue = false)]
        public GroupAuditLogEntryStringChange Rules { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GroupAuditLogEntryEventData {\n");
            sb.Append("  AuthorId: ").Append(AuthorId).Append("\n");
            sb.Append("  ImageId: ").Append(ImageId).Append("\n");
            sb.Append("  SendNotification: ").Append(SendNotification).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  AccessType: ").Append(AccessType).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            sb.Append("  MembersOnly: ").Append(MembersOnly).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  RoleIdsToAutoApprove: ").Append(RoleIdsToAutoApprove).Append("\n");
            sb.Append("  RoleIdsToManage: ").Append(RoleIdsToManage).Append("\n");
            sb.Append("  RoleIdsToSubmit: ").Append(RoleIdsToSubmit).Append("\n");
            sb.Append("  RoleIdsToView: ").Append(RoleIdsToView).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  GroupAccessType: ").Append(GroupAccessType).Append("\n");
            sb.Append("  CalendarEntryId: ").Append(CalendarEntryId).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  RoleId: ").Append(RoleId).Append("\n");
            sb.Append("  RoleName: ").Append(RoleName).Append("\n");
            sb.Append("  ManagerNotes: ").Append(ManagerNotes).Append("\n");
            sb.Append("  EditorId: ").Append(EditorId).Append("\n");
            sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("  GroupId: ").Append(GroupId).Append("\n");
            sb.Append("  LastUpdatedByUserId: ").Append(LastUpdatedByUserId).Append("\n");
            sb.Append("  DefaultRole: ").Append(DefaultRole).Append("\n");
            sb.Append("  IsManagementRole: ").Append(IsManagementRole).Append("\n");
            sb.Append("  IsAddedOnJoin: ").Append(IsAddedOnJoin).Append("\n");
            sb.Append("  IsSelfAssignable: ").Append(IsSelfAssignable).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  Permissions: ").Append(Permissions).Append("\n");
            sb.Append("  AllowGroupJoinPrompt: ").Append(AllowGroupJoinPrompt).Append("\n");
            sb.Append("  BannerId: ").Append(BannerId).Append("\n");
            sb.Append("  IconId: ").Append(IconId).Append("\n");
            sb.Append("  JoinState: ").Append(JoinState).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  NameplateId: ").Append(NameplateId).Append("\n");
            sb.Append("  Rules: ").Append(Rules).Append("\n");
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
            return this.Equals(input as GroupAuditLogEntryEventData);
        }

        /// <summary>
        /// Returns true if GroupAuditLogEntryEventData instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupAuditLogEntryEventData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupAuditLogEntryEventData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AuthorId == input.AuthorId ||
                    (this.AuthorId != null &&
                    this.AuthorId.Equals(input.AuthorId))
                ) && 
                (
                    this.ImageId == input.ImageId ||
                    (this.ImageId != null &&
                    this.ImageId.Equals(input.ImageId))
                ) && 
                (
                    this.SendNotification == input.SendNotification ||
                    this.SendNotification.Equals(input.SendNotification)
                ) && 
                (
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
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
                    (this.Languages != null &&
                    this.Languages.Equals(input.Languages))
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
                    (this.Tags != null &&
                    this.Tags.Equals(input.Tags))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    this.UpdatedAt.Equals(input.UpdatedAt)
                ) && 
                (
                    this.UsesInstanceOverflow == input.UsesInstanceOverflow ||
                    this.UsesInstanceOverflow.Equals(input.UsesInstanceOverflow)
                ) && 
                (
                    this.MembersOnly == input.MembersOnly ||
                    (this.MembersOnly != null &&
                    this.MembersOnly.Equals(input.MembersOnly))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.RoleIdsToAutoApprove == input.RoleIdsToAutoApprove ||
                    this.RoleIdsToAutoApprove != null &&
                    input.RoleIdsToAutoApprove != null &&
                    this.RoleIdsToAutoApprove.SequenceEqual(input.RoleIdsToAutoApprove)
                ) && 
                (
                    this.RoleIdsToManage == input.RoleIdsToManage ||
                    this.RoleIdsToManage != null &&
                    input.RoleIdsToManage != null &&
                    this.RoleIdsToManage.SequenceEqual(input.RoleIdsToManage)
                ) && 
                (
                    this.RoleIdsToSubmit == input.RoleIdsToSubmit ||
                    this.RoleIdsToSubmit != null &&
                    input.RoleIdsToSubmit != null &&
                    this.RoleIdsToSubmit.SequenceEqual(input.RoleIdsToSubmit)
                ) && 
                (
                    this.RoleIdsToView == input.RoleIdsToView ||
                    this.RoleIdsToView != null &&
                    input.RoleIdsToView != null &&
                    this.RoleIdsToView.SequenceEqual(input.RoleIdsToView)
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.GroupAccessType == input.GroupAccessType ||
                    this.GroupAccessType.Equals(input.GroupAccessType)
                ) && 
                (
                    this.CalendarEntryId == input.CalendarEntryId ||
                    (this.CalendarEntryId != null &&
                    this.CalendarEntryId.Equals(input.CalendarEntryId))
                ) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && 
                (
                    this.RoleId == input.RoleId ||
                    (this.RoleId != null &&
                    this.RoleId.Equals(input.RoleId))
                ) && 
                (
                    this.RoleName == input.RoleName ||
                    (this.RoleName != null &&
                    this.RoleName.Equals(input.RoleName))
                ) && 
                (
                    this.ManagerNotes == input.ManagerNotes ||
                    (this.ManagerNotes != null &&
                    this.ManagerNotes.Equals(input.ManagerNotes))
                ) && 
                (
                    this.EditorId == input.EditorId ||
                    (this.EditorId != null &&
                    this.EditorId.Equals(input.EditorId))
                ) && 
                (
                    this.ImageUrl == input.ImageUrl ||
                    (this.ImageUrl != null &&
                    this.ImageUrl.Equals(input.ImageUrl))
                ) && 
                (
                    this.GroupId == input.GroupId ||
                    (this.GroupId != null &&
                    this.GroupId.Equals(input.GroupId))
                ) && 
                (
                    this.LastUpdatedByUserId == input.LastUpdatedByUserId ||
                    (this.LastUpdatedByUserId != null &&
                    this.LastUpdatedByUserId.Equals(input.LastUpdatedByUserId))
                ) && 
                (
                    this.DefaultRole == input.DefaultRole ||
                    this.DefaultRole.Equals(input.DefaultRole)
                ) && 
                (
                    this.IsManagementRole == input.IsManagementRole ||
                    this.IsManagementRole.Equals(input.IsManagementRole)
                ) && 
                (
                    this.IsAddedOnJoin == input.IsAddedOnJoin ||
                    (this.IsAddedOnJoin != null &&
                    this.IsAddedOnJoin.Equals(input.IsAddedOnJoin))
                ) && 
                (
                    this.IsSelfAssignable == input.IsSelfAssignable ||
                    (this.IsSelfAssignable != null &&
                    this.IsSelfAssignable.Equals(input.IsSelfAssignable))
                ) && 
                (
                    this.Order == input.Order ||
                    (this.Order != null &&
                    this.Order.Equals(input.Order))
                ) && 
                (
                    this.Permissions == input.Permissions ||
                    (this.Permissions != null &&
                    this.Permissions.Equals(input.Permissions))
                ) && 
                (
                    this.AllowGroupJoinPrompt == input.AllowGroupJoinPrompt ||
                    (this.AllowGroupJoinPrompt != null &&
                    this.AllowGroupJoinPrompt.Equals(input.AllowGroupJoinPrompt))
                ) && 
                (
                    this.BannerId == input.BannerId ||
                    (this.BannerId != null &&
                    this.BannerId.Equals(input.BannerId))
                ) && 
                (
                    this.IconId == input.IconId ||
                    (this.IconId != null &&
                    this.IconId.Equals(input.IconId))
                ) && 
                (
                    this.JoinState == input.JoinState ||
                    (this.JoinState != null &&
                    this.JoinState.Equals(input.JoinState))
                ) && 
                (
                    this.Links == input.Links ||
                    (this.Links != null &&
                    this.Links.Equals(input.Links))
                ) && 
                (
                    this.NameplateId == input.NameplateId ||
                    (this.NameplateId != null &&
                    this.NameplateId.Equals(input.NameplateId))
                ) && 
                (
                    this.Rules == input.Rules ||
                    (this.Rules != null &&
                    this.Rules.Equals(input.Rules))
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
                if (this.AuthorId != null)
                {
                    hashCode = (hashCode * 59) + this.AuthorId.GetHashCode();
                }
                if (this.ImageId != null)
                {
                    hashCode = (hashCode * 59) + this.ImageId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SendNotification.GetHashCode();
                if (this.Text != null)
                {
                    hashCode = (hashCode * 59) + this.Text.GetHashCode();
                }
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AccessType.GetHashCode();
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
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
                if (this.MembersOnly != null)
                {
                    hashCode = (hashCode * 59) + this.MembersOnly.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.RoleIdsToAutoApprove != null)
                {
                    hashCode = (hashCode * 59) + this.RoleIdsToAutoApprove.GetHashCode();
                }
                if (this.RoleIdsToManage != null)
                {
                    hashCode = (hashCode * 59) + this.RoleIdsToManage.GetHashCode();
                }
                if (this.RoleIdsToSubmit != null)
                {
                    hashCode = (hashCode * 59) + this.RoleIdsToSubmit.GetHashCode();
                }
                if (this.RoleIdsToView != null)
                {
                    hashCode = (hashCode * 59) + this.RoleIdsToView.GetHashCode();
                }
                if (this.Message != null)
                {
                    hashCode = (hashCode * 59) + this.Message.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.GroupAccessType.GetHashCode();
                if (this.CalendarEntryId != null)
                {
                    hashCode = (hashCode * 59) + this.CalendarEntryId.GetHashCode();
                }
                if (this.Location != null)
                {
                    hashCode = (hashCode * 59) + this.Location.GetHashCode();
                }
                if (this.RoleId != null)
                {
                    hashCode = (hashCode * 59) + this.RoleId.GetHashCode();
                }
                if (this.RoleName != null)
                {
                    hashCode = (hashCode * 59) + this.RoleName.GetHashCode();
                }
                if (this.ManagerNotes != null)
                {
                    hashCode = (hashCode * 59) + this.ManagerNotes.GetHashCode();
                }
                if (this.EditorId != null)
                {
                    hashCode = (hashCode * 59) + this.EditorId.GetHashCode();
                }
                if (this.ImageUrl != null)
                {
                    hashCode = (hashCode * 59) + this.ImageUrl.GetHashCode();
                }
                if (this.GroupId != null)
                {
                    hashCode = (hashCode * 59) + this.GroupId.GetHashCode();
                }
                if (this.LastUpdatedByUserId != null)
                {
                    hashCode = (hashCode * 59) + this.LastUpdatedByUserId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.DefaultRole.GetHashCode();
                hashCode = (hashCode * 59) + this.IsManagementRole.GetHashCode();
                if (this.IsAddedOnJoin != null)
                {
                    hashCode = (hashCode * 59) + this.IsAddedOnJoin.GetHashCode();
                }
                if (this.IsSelfAssignable != null)
                {
                    hashCode = (hashCode * 59) + this.IsSelfAssignable.GetHashCode();
                }
                if (this.Order != null)
                {
                    hashCode = (hashCode * 59) + this.Order.GetHashCode();
                }
                if (this.Permissions != null)
                {
                    hashCode = (hashCode * 59) + this.Permissions.GetHashCode();
                }
                if (this.AllowGroupJoinPrompt != null)
                {
                    hashCode = (hashCode * 59) + this.AllowGroupJoinPrompt.GetHashCode();
                }
                if (this.BannerId != null)
                {
                    hashCode = (hashCode * 59) + this.BannerId.GetHashCode();
                }
                if (this.IconId != null)
                {
                    hashCode = (hashCode * 59) + this.IconId.GetHashCode();
                }
                if (this.JoinState != null)
                {
                    hashCode = (hashCode * 59) + this.JoinState.GetHashCode();
                }
                if (this.Links != null)
                {
                    hashCode = (hashCode * 59) + this.Links.GetHashCode();
                }
                if (this.NameplateId != null)
                {
                    hashCode = (hashCode * 59) + this.NameplateId.GetHashCode();
                }
                if (this.Rules != null)
                {
                    hashCode = (hashCode * 59) + this.Rules.GetHashCode();
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
