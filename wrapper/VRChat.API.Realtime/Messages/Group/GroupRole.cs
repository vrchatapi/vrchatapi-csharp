using System;
using System.Collections.Generic;

namespace VRChat.API.Realtime.Messages
{
    /// <summary>
    /// Group role information received in WebSocket messages
    /// </summary>
    public class GroupRole
    {
        public string Id { get; set; }
        public string GroupId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsSelfAssignable { get; set; }
        public List<string> Permissions { get; set; }
        public bool IsManagementRole { get; set; }
        public bool RequiresTwoFactor { get; set; }
        public bool RequiresPurchase { get; set; }
        public int Order { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}

