using System;
using System.Collections.Generic;

namespace VRChat.API.Realtime.Messages
{
    /// <summary>
    /// Represents group role information received in WebSocket messages.
    /// </summary>
    /// <remarks>
    /// Group roles define permissions and capabilities for members within a group.
    /// Roles can be assigned to members and may grant various permissions.
    /// </remarks>
    /// <seealso cref="GroupRoleUpdatedContent"/>
    /// <seealso cref="GroupLimitedMember"/>
    public class GroupRole
    {
        /// <summary>
        /// Gets or sets the unique identifier of this role.
        /// </summary>
        /// <value>
        /// A role ID in the form of <c>grol_xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx</c>.
        /// </value>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of the group this role belongs to.
        /// </summary>
        /// <value>
        /// A group's unique ID in the form of <c>grp_xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx</c>.
        /// </value>
        public string GroupId { get; set; }

        /// <summary>
        /// Gets or sets the display name of the role.
        /// </summary>
        /// <value>
        /// The human-readable name of the role, such as "Member" or "Moderator".
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description of the role.
        /// </summary>
        /// <value>
        /// A description explaining the purpose and permissions of the role.
        /// </value>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets whether members can self-assign this role.
        /// </summary>
        /// <value>
        /// <c>true</c> if members can assign this role to themselves; otherwise, <c>false</c>.
        /// </value>
        public bool IsSelfAssignable { get; set; }

        /// <summary>
        /// Gets or sets the list of permissions granted by this role.
        /// </summary>
        /// <value>
        /// A list of permission strings, such as "group-posts-manage" or "group-members-manage".
        /// </value>
        public List<string> Permissions { get; set; }

        /// <summary>
        /// Gets or sets whether this is a management role.
        /// </summary>
        /// <value>
        /// <c>true</c> if this role grants management/administrative capabilities; otherwise, <c>false</c>.
        /// </value>
        public bool IsManagementRole { get; set; }

        /// <summary>
        /// Gets or sets whether this role requires two-factor authentication.
        /// </summary>
        /// <value>
        /// <c>true</c> if members must have 2FA enabled to use this role; otherwise, <c>false</c>.
        /// </value>
        public bool RequiresTwoFactor { get; set; }

        /// <summary>
        /// Gets or sets whether this role requires a purchase to obtain.
        /// </summary>
        /// <value>
        /// <c>true</c> if this role must be purchased; otherwise, <c>false</c>.
        /// </value>
        public bool RequiresPurchase { get; set; }

        /// <summary>
        /// Gets or sets the display order of the role.
        /// </summary>
        /// <value>
        /// An integer indicating the sort order, with lower numbers appearing first.
        /// </value>
        public int Order { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the role was created.
        /// </summary>
        /// <value>
        /// The UTC timestamp of role creation.
        /// </value>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the role was last updated.
        /// </summary>
        /// <value>
        /// The UTC timestamp of the last modification.
        /// </value>
        public DateTime UpdatedAt { get; set; }
    }
}
