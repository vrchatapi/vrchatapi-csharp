

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
    /// Defines SearchAvatarsMarketplace
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SearchAvatarsMarketplace
    {
        /// <summary>
        /// Enum All for value: all
        /// </summary>
        [EnumMember(Value = "all")]
        All = 1,

        /// <summary>
        /// Enum Free for value: free
        /// </summary>
        [EnumMember(Value = "free")]
        Free = 2,

        /// <summary>
        /// Enum Paid for value: paid
        /// </summary>
        [EnumMember(Value = "paid")]
        Paid = 3
    }

}
