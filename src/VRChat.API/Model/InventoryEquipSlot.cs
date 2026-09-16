

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
    /// Defines InventoryEquipSlot
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum InventoryEquipSlot
    {
        /// <summary>
        /// Enum Empty for value: 
        /// </summary>
        [EnumMember(Value = "")]
        Empty = 1,

        /// <summary>
        /// Enum Drone for value: drone
        /// </summary>
        [EnumMember(Value = "drone")]
        Drone = 2,

        /// <summary>
        /// Enum IconFrame for value: iconFrame
        /// </summary>
        [EnumMember(Value = "iconFrame")]
        IconFrame = 3,

        /// <summary>
        /// Enum NameplateEffect for value: nameplateEffect
        /// </summary>
        [EnumMember(Value = "nameplateEffect")]
        NameplateEffect = 4,

        /// <summary>
        /// Enum Portal for value: portal
        /// </summary>
        [EnumMember(Value = "portal")]
        Portal = 5,

        /// <summary>
        /// Enum ProfileEffect for value: profileEffect
        /// </summary>
        [EnumMember(Value = "profileEffect")]
        ProfileEffect = 6,

        /// <summary>
        /// Enum Warp for value: warp
        /// </summary>
        [EnumMember(Value = "warp")]
        Warp = 7
    }

}
