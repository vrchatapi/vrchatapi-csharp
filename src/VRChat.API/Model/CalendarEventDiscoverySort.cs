

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
    /// Defines CalendarEventDiscoverySort
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CalendarEventDiscoverySort
    {
        /// <summary>
        /// Enum FollowsDescending for value: follows_descending
        /// </summary>
        [EnumMember(Value = "follows_descending")]
        FollowsDescending = 1,

        /// <summary>
        /// Enum StartTimeAscending for value: startTime_ascending
        /// </summary>
        [EnumMember(Value = "startTime_ascending")]
        StartTimeAscending = 2,

        /// <summary>
        /// Enum StartTimeDescending for value: startTime_descending
        /// </summary>
        [EnumMember(Value = "startTime_descending")]
        StartTimeDescending = 3
    }

}
