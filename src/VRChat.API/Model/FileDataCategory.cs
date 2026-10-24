

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
    /// Defines FileDataCategory
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FileDataCategory
    {
        /// <summary>
        /// Enum Multipart for value: multipart
        /// </summary>
        [EnumMember(Value = "multipart")]
        Multipart = 1,

        /// <summary>
        /// Enum Queued for value: queued
        /// </summary>
        [EnumMember(Value = "queued")]
        Queued = 2,

        /// <summary>
        /// Enum Simple for value: simple
        /// </summary>
        [EnumMember(Value = "simple")]
        Simple = 3
    }

}
