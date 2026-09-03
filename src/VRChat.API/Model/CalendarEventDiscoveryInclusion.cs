

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
    /// Defines CalendarEventDiscoveryInclusion
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CalendarEventDiscoveryInclusion
    {
        /// <summary>
        /// Enum Exclude for value: exclude
        /// </summary>
        [EnumMember(Value = "exclude")]
        Exclude = 1,

        /// <summary>
        /// Enum Include for value: include
        /// </summary>
        [EnumMember(Value = "include")]
        Include = 2,

        /// <summary>
        /// Enum Skip for value: skip
        /// </summary>
        [EnumMember(Value = "skip")]
        Skip = 3
    }

}
