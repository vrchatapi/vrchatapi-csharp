

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
    /// Defines OrderOptionShort
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OrderOptionShort
    {
        /// <summary>
        /// Enum Asc for value: asc
        /// </summary>
        [EnumMember(Value = "asc")]
        Asc = 1,

        /// <summary>
        /// Enum Desc for value: desc
        /// </summary>
        [EnumMember(Value = "desc")]
        Desc = 2
    }

}
