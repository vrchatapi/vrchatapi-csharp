

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
    /// Defines InventorySortOrder
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum InventorySortOrder
    {
        /// <summary>
        /// Enum Alphabetic for value: alphabetic
        /// </summary>
        [EnumMember(Value = "alphabetic")]
        Alphabetic = 1,

        /// <summary>
        /// Enum Angry for value: angry
        /// </summary>
        [EnumMember(Value = "angry")]
        Angry = 2,

        /// <summary>
        /// Enum Happy for value: happy
        /// </summary>
        [EnumMember(Value = "happy")]
        Happy = 3,

        /// <summary>
        /// Enum Newest for value: newest
        /// </summary>
        [EnumMember(Value = "newest")]
        Newest = 4,

        /// <summary>
        /// Enum NewestCreated for value: newest_created
        /// </summary>
        [EnumMember(Value = "newest_created")]
        NewestCreated = 5,

        /// <summary>
        /// Enum NewestTemplateCreated for value: newest_template_created
        /// </summary>
        [EnumMember(Value = "newest_template_created")]
        NewestTemplateCreated = 6,

        /// <summary>
        /// Enum NewestUpdated for value: newest_updated
        /// </summary>
        [EnumMember(Value = "newest_updated")]
        NewestUpdated = 7,

        /// <summary>
        /// Enum Oldest for value: oldest
        /// </summary>
        [EnumMember(Value = "oldest")]
        Oldest = 8,

        /// <summary>
        /// Enum OldestCreated for value: oldest_created
        /// </summary>
        [EnumMember(Value = "oldest_created")]
        OldestCreated = 9,

        /// <summary>
        /// Enum OldestTemplateCreated for value: oldest_template_created
        /// </summary>
        [EnumMember(Value = "oldest_template_created")]
        OldestTemplateCreated = 10,

        /// <summary>
        /// Enum OldestUpdated for value: oldest_updated
        /// </summary>
        [EnumMember(Value = "oldest_updated")]
        OldestUpdated = 11,

        /// <summary>
        /// Enum ReverseOrthographic for value: reverse-orthographic
        /// </summary>
        [EnumMember(Value = "reverse-orthographic")]
        ReverseOrthographic = 12
    }

}
