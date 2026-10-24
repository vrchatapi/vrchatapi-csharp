

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
    /// Defines ProfileBackgroundType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ProfileBackgroundType
    {
        /// <summary>
        /// Enum Default for value: default
        /// </summary>
        [EnumMember(Value = "default")]
        Default = 1,

        /// <summary>
        /// Enum Gradient for value: gradient
        /// </summary>
        [EnumMember(Value = "gradient")]
        Gradient = 2,

        /// <summary>
        /// Enum Inventory for value: inventory
        /// </summary>
        [EnumMember(Value = "inventory")]
        Inventory = 3,

        /// <summary>
        /// Enum Texture for value: texture
        /// </summary>
        [EnumMember(Value = "texture")]
        Texture = 4
    }

}
