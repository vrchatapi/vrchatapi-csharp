

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
    /// Defines CreateUserModerationRequestType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CreateUserModerationRequestType
    {
        /// <summary>
        /// Enum Avatar for value: avatar
        /// </summary>
        [EnumMember(Value = "avatar")]
        Avatar = 1,

        /// <summary>
        /// Enum Ban for value: ban
        /// </summary>
        [EnumMember(Value = "ban")]
        Ban = 2,

        /// <summary>
        /// Enum Banpubliconly for value: banpubliconly
        /// </summary>
        [EnumMember(Value = "banpubliconly")]
        Banpubliconly = 3,

        /// <summary>
        /// Enum Chat for value: chat
        /// </summary>
        [EnumMember(Value = "chat")]
        Chat = 4,

        /// <summary>
        /// Enum Emoji for value: emoji
        /// </summary>
        [EnumMember(Value = "emoji")]
        Emoji = 5,

        /// <summary>
        /// Enum Event for value: event
        /// </summary>
        [EnumMember(Value = "event")]
        Event = 6,

        /// <summary>
        /// Enum Gallery for value: gallery
        /// </summary>
        [EnumMember(Value = "gallery")]
        Gallery = 7,

        /// <summary>
        /// Enum Group for value: group
        /// </summary>
        [EnumMember(Value = "group")]
        Group = 8,

        /// <summary>
        /// Enum Hardban for value: hardban
        /// </summary>
        [EnumMember(Value = "hardban")]
        Hardban = 9,

        /// <summary>
        /// Enum Icon for value: icon
        /// </summary>
        [EnumMember(Value = "icon")]
        Icon = 10,

        /// <summary>
        /// Enum Kick for value: kick
        /// </summary>
        [EnumMember(Value = "kick")]
        Kick = 11,

        /// <summary>
        /// Enum Note for value: note
        /// </summary>
        [EnumMember(Value = "note")]
        Note = 12,

        /// <summary>
        /// Enum Nuisance for value: nuisance
        /// </summary>
        [EnumMember(Value = "nuisance")]
        Nuisance = 13,

        /// <summary>
        /// Enum Print for value: print
        /// </summary>
        [EnumMember(Value = "print")]
        Print = 14,

        /// <summary>
        /// Enum Profile for value: profile
        /// </summary>
        [EnumMember(Value = "profile")]
        Profile = 15,

        /// <summary>
        /// Enum Publicinstance for value: publicinstance
        /// </summary>
        [EnumMember(Value = "publicinstance")]
        Publicinstance = 16,

        /// <summary>
        /// Enum Sticker for value: sticker
        /// </summary>
        [EnumMember(Value = "sticker")]
        Sticker = 17,

        /// <summary>
        /// Enum Voice for value: voice
        /// </summary>
        [EnumMember(Value = "voice")]
        Voice = 18,

        /// <summary>
        /// Enum Warn for value: warn
        /// </summary>
        [EnumMember(Value = "warn")]
        Warn = 19,

        /// <summary>
        /// Enum Warning for value: warning
        /// </summary>
        [EnumMember(Value = "warning")]
        Warning = 20,

        /// <summary>
        /// Enum World for value: world
        /// </summary>
        [EnumMember(Value = "world")]
        World = 21
    }

}
