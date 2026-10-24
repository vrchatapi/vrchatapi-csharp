

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
    /// Defines FileDataType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FileDataType
    {
        /// <summary>
        /// Enum Delta for value: delta
        /// </summary>
        [EnumMember(Value = "delta")]
        Delta = 1,

        /// <summary>
        /// Enum File for value: file
        /// </summary>
        [EnumMember(Value = "file")]
        File = 2,

        /// <summary>
        /// Enum Signature for value: signature
        /// </summary>
        [EnumMember(Value = "signature")]
        Signature = 3
    }

}
