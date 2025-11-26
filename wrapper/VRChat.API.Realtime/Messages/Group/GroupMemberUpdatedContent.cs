using System;
using VRChat.API.Model;

namespace VRChat.API.Realtime.Messages
{
    public class GroupMemberUpdatedContent : EventArgs
    {
        public GroupLimitedMember Member { get; set; }
    }
}

