

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
    /// Defines InstanceDiscoveryMode
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum InstanceDiscoveryMode
    {
        /// <summary>
        /// Enum Active for value: active
        /// </summary>
        [EnumMember(Value = "active")]
        Active = 1,

        /// <summary>
        /// Enum Match for value: match
        /// </summary>
        [EnumMember(Value = "match")]
        Match = 2,

        /// <summary>
        /// Enum Population for value: population
        /// </summary>
        [EnumMember(Value = "population")]
        Population = 3,

        /// <summary>
        /// Enum Random for value: random
        /// </summary>
        [EnumMember(Value = "random")]
        Random = 4
    }

}
