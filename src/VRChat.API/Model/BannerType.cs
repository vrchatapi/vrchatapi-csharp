

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
    /// Defines BannerType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum BannerType
    {
        /// <summary>
        /// Enum AvatarBanner for value: avatarBanner
        /// </summary>
        [EnumMember(Value = "avatarBanner")]
        AvatarBanner = 1,

        /// <summary>
        /// Enum Color for value: color
        /// </summary>
        [EnumMember(Value = "color")]
        Color = 2,

        /// <summary>
        /// Enum CustomImage for value: customImage
        /// </summary>
        [EnumMember(Value = "customImage")]
        CustomImage = 3
    }

}
