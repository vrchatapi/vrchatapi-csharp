

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
    /// Defines UserSearchSort
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum UserSearchSort
    {
        /// <summary>
        /// Enum CreatedAt for value: _created_at
        /// </summary>
        [EnumMember(Value = "_created_at")]
        CreatedAt = 1,

        /// <summary>
        /// Enum Contains for value: contains
        /// </summary>
        [EnumMember(Value = "contains")]
        Contains = 2,

        /// <summary>
        /// Enum Created for value: created
        /// </summary>
        [EnumMember(Value = "created")]
        Created = 3,

        /// <summary>
        /// Enum Exact for value: exact
        /// </summary>
        [EnumMember(Value = "exact")]
        Exact = 4,

        /// <summary>
        /// Enum LastLogin for value: last_login
        /// </summary>
        [EnumMember(Value = "last_login")]
        LastLogin = 5,

        /// <summary>
        /// Enum Magic for value: magic
        /// </summary>
        [EnumMember(Value = "magic")]
        Magic = 6,

        /// <summary>
        /// Enum Name for value: name
        /// </summary>
        [EnumMember(Value = "name")]
        Name = 7,

        /// <summary>
        /// Enum NuisanceFactor for value: nuisanceFactor
        /// </summary>
        [EnumMember(Value = "nuisanceFactor")]
        NuisanceFactor = 8,

        /// <summary>
        /// Enum Relevance for value: relevance
        /// </summary>
        [EnumMember(Value = "relevance")]
        Relevance = 9,

        /// <summary>
        /// Enum Trust for value: trust
        /// </summary>
        [EnumMember(Value = "trust")]
        Trust = 10
    }

}
