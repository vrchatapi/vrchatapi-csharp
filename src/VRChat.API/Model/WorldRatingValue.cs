

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
    /// Defines WorldRatingValue
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum WorldRatingValue
    {
        /// <summary>
        /// Enum Dislike for value: dislike
        /// </summary>
        [EnumMember(Value = "dislike")]
        Dislike = 1,

        /// <summary>
        /// Enum Like for value: like
        /// </summary>
        [EnumMember(Value = "like")]
        Like = 2
    }

}
