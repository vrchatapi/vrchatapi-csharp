

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
    /// Defines CreateInstanceRequestMinimumAvatarPerformance
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CreateInstanceRequestMinimumAvatarPerformance
    {
        /// <summary>
        /// Enum Good for value: Good
        /// </summary>
        [EnumMember(Value = "Good")]
        Good = 1,

        /// <summary>
        /// Enum Medium for value: Medium
        /// </summary>
        [EnumMember(Value = "Medium")]
        Medium = 2,

        /// <summary>
        /// Enum None for value: None
        /// </summary>
        [EnumMember(Value = "None")]
        None = 3,

        /// <summary>
        /// Enum Poor for value: Poor
        /// </summary>
        [EnumMember(Value = "Poor")]
        Poor = 4
    }

}
