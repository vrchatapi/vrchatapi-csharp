

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
    /// Defines InstanceDiscoveryBoost
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum InstanceDiscoveryBoost
    {
        /// <summary>
        /// Enum ALL for value: ALL
        /// </summary>
        [EnumMember(Value = "ALL")]
        ALL = 1,

        /// <summary>
        /// Enum Friends for value: friends
        /// </summary>
        [EnumMember(Value = "friends")]
        Friends = 2,

        /// <summary>
        /// Enum MyEvents for value: myEvents
        /// </summary>
        [EnumMember(Value = "myEvents")]
        MyEvents = 3,

        /// <summary>
        /// Enum MyFavoriteWorlds for value: myFavoriteWorlds
        /// </summary>
        [EnumMember(Value = "myFavoriteWorlds")]
        MyFavoriteWorlds = 4,

        /// <summary>
        /// Enum MyGroupEvents for value: myGroupEvents
        /// </summary>
        [EnumMember(Value = "myGroupEvents")]
        MyGroupEvents = 5,

        /// <summary>
        /// Enum MyGroups for value: myGroups
        /// </summary>
        [EnumMember(Value = "myGroups")]
        MyGroups = 6
    }

}
