using System;
using System.Collections.Generic;

namespace VRChat.API.Realtime.Messages
{
    /// <summary>
    /// Represents group member information received in WebSocket messages.
    /// </summary>
    /// <remarks>
    /// This class contains membership details for a user within a group,
    /// including their roles, status, and subscription preferences.
    /// </remarks>
    /// <seealso cref="GroupMemberUpdatedContent"/>
    public class GroupLimitedMember
    {
        /// <summary>
        /// Gets or sets the unique identifier of this membership record.
        /// </summary>
        /// <value>
        /// A membership record ID in the form of <c>gmem_xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx</c>.
        /// </value>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of the group.
        /// </summary>
        /// <value>
        /// A group's unique ID in the form of <c>grp_xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx</c>.
        /// </value>
        public string GroupId { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of the user.
        /// </summary>
        /// <value>
        /// A user's unique ID, usually in the form of <c>usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469</c>.
        /// </value>
        public string UserId { get; set; }

        /// <summary>
        /// Gets or sets whether the user is representing this group.
        /// </summary>
        /// <value>
        /// <c>true</c> if the user has this group set as their represented group; otherwise, <c>false</c>.
        /// </value>
        public bool IsRepresenting { get; set; }

        /// <summary>
        /// Gets or sets the list of role IDs assigned to this member.
        /// </summary>
        /// <value>
        /// A list of role IDs in the form of <c>grol_xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx</c>.
        /// </value>
        public List<string> RoleIds { get; set; }

        /// <summary>
        /// Gets or sets the list of management role IDs assigned to this member.
        /// </summary>
        /// <value>
        /// A list of management role IDs that grant administrative permissions.
        /// </value>
        public List<string> MRoleIds { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the user joined the group.
        /// </summary>
        /// <value>
        /// The UTC timestamp of when the membership was created.
        /// </value>
        public DateTime JoinedAt { get; set; }

        /// <summary>
        /// Gets or sets the current membership status.
        /// </summary>
        /// <value>
        /// The membership status, such as "member", "requested", "invited", or "banned".
        /// </value>
        public string MembershipStatus { get; set; }

        /// <summary>
        /// Gets or sets the visibility of the membership.
        /// </summary>
        /// <value>
        /// The visibility setting, such as "visible" or "hidden".
        /// </value>
        public string Visibility { get; set; }

        /// <summary>
        /// Gets or sets whether the member is subscribed to group announcements.
        /// </summary>
        /// <value>
        /// <c>true</c> if the member receives notifications for group announcements; otherwise, <c>false</c>.
        /// </value>
        public bool IsSubscribedToAnnouncements { get; set; }

        /// <summary>
        /// Gets or sets whether the member is subscribed to event announcements.
        /// </summary>
        /// <value>
        /// <c>true</c> if the member receives notifications for group events; otherwise, <c>false</c>.
        /// </value>
        public bool IsSubscribedToEventAnnouncements { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the membership record was created.
        /// </summary>
        /// <value>
        /// The UTC timestamp of record creation.
        /// </value>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the member was banned, if applicable.
        /// </summary>
        /// <value>
        /// The UTC timestamp of when the ban was applied, or <c>null</c> if the member is not banned.
        /// </value>
        public DateTime? BannedAt { get; set; }

        /// <summary>
        /// Gets or sets notes about this member visible to group managers.
        /// </summary>
        /// <value>
        /// Manager notes as a string, or <c>null</c> if no notes exist.
        /// </value>
        public string ManagerNotes { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the member last read group posts.
        /// </summary>
        /// <value>
        /// The UTC timestamp of the last post read, or <c>null</c> if no posts have been read.
        /// </value>
        public DateTime? LastPostReadAt { get; set; }

        /// <summary>
        /// Gets or sets whether the member joined through a purchase.
        /// </summary>
        /// <value>
        /// <c>true</c> if the membership was gained through a purchase; otherwise, <c>false</c>.
        /// </value>
        public bool HasJoinedFromPurchase { get; set; }
    }
}
