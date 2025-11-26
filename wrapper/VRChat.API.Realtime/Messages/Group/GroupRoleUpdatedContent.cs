using System;
using VRChat.API.Model;

namespace VRChat.API.Realtime.Messages
{
    public class GroupRoleUpdatedContent : EventArgs
    {
        public GroupRole Role { get; set; }
    }
}

