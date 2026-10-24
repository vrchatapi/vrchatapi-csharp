

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
    /// Defines CosmeticItemType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CosmeticItemType
    {
        /// <summary>
        /// Enum Droneskin for value: droneskin
        /// </summary>
        [EnumMember(Value = "droneskin")]
        Droneskin = 1,

        /// <summary>
        /// Enum IconFrame for value: iconFrame
        /// </summary>
        [EnumMember(Value = "iconFrame")]
        IconFrame = 2,

        /// <summary>
        /// Enum NameplateEffect for value: nameplateEffect
        /// </summary>
        [EnumMember(Value = "nameplateEffect")]
        NameplateEffect = 3,

        /// <summary>
        /// Enum Portalskin for value: portalskin
        /// </summary>
        [EnumMember(Value = "portalskin")]
        Portalskin = 4,

        /// <summary>
        /// Enum ProfileBackground for value: profileBackground
        /// </summary>
        [EnumMember(Value = "profileBackground")]
        ProfileBackground = 5,

        /// <summary>
        /// Enum ProfileEffect for value: profileEffect
        /// </summary>
        [EnumMember(Value = "profileEffect")]
        ProfileEffect = 6,

        /// <summary>
        /// Enum Warpeffect for value: warpeffect
        /// </summary>
        [EnumMember(Value = "warpeffect")]
        Warpeffect = 7
    }

}
