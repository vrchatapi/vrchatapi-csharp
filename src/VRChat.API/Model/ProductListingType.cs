

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
    /// Defines ProductListingType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ProductListingType
    {
        /// <summary>
        /// Enum Duration for value: duration
        /// </summary>
        [EnumMember(Value = "duration")]
        Duration = 1,

        /// <summary>
        /// Enum Instant for value: instant
        /// </summary>
        [EnumMember(Value = "instant")]
        Instant = 2,

        /// <summary>
        /// Enum Permanent for value: permanent
        /// </summary>
        [EnumMember(Value = "permanent")]
        Permanent = 3,

        /// <summary>
        /// Enum Subscription for value: subscription
        /// </summary>
        [EnumMember(Value = "subscription")]
        Subscription = 4
    }

}
