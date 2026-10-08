

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
    /// Defines WebsocketContentRefreshActionType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum WebsocketContentRefreshActionType
    {
        /// <summary>
        /// Enum Add for value: add
        /// </summary>
        [EnumMember(Value = "add")]
        Add = 1,

        /// <summary>
        /// Enum Created for value: created
        /// </summary>
        [EnumMember(Value = "created")]
        Created = 2,

        /// <summary>
        /// Enum Delete for value: delete
        /// </summary>
        [EnumMember(Value = "delete")]
        Delete = 3,

        /// <summary>
        /// Enum Deleted for value: deleted
        /// </summary>
        [EnumMember(Value = "deleted")]
        Deleted = 4
    }

}
