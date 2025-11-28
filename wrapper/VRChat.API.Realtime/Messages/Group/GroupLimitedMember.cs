using System;
using System.Collections.Generic;

namespace VRChat.API.Realtime.Messages
{
    /// <summary>
    /// Group member information received in WebSocket messages
    /// </summary>
    public class GroupLimitedMember
    {
        public string Id { get; set; }
        public string GroupId { get; set; }
        public string UserId { get; set; }
        public bool IsRepresenting { get; set; }
        public List<string> RoleIds { get; set; }
        public List<string> MRoleIds { get; set; }
        public DateTime JoinedAt { get; set; }
        public string MembershipStatus { get; set; }
        public string Visibility { get; set; }
        public bool IsSubscribedToAnnouncements { get; set; }
        public bool IsSubscribedToEventAnnouncements { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? BannedAt { get; set; }
        public string ManagerNotes { get; set; }
        public DateTime? LastPostReadAt { get; set; }
        public bool HasJoinedFromPurchase { get; set; }
    }
}

