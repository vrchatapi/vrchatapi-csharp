/*
 * VRChat API Documentation
 *
 *
 * The version of the OpenAPI document: 1.20.0
 * Contact: vrchatapi.lpv0t@aries.fyi
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


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
using OpenAPIDateConverter = VRChat.API.Client.OpenAPIDateConverter;

namespace VRChat.API.Model
{
    /// <summary>
    /// Defines SubscriptionPeriod
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SubscriptionPeriod
    {
        /// <summary>
        /// Enum Hour for value: hour
        /// </summary>
        [EnumMember(Value = "hour")]
        Hour = 1,

        /// <summary>
        /// Enum Day for value: day
        /// </summary>
        [EnumMember(Value = "day")]
        Day = 2,

        /// <summary>
        /// Enum Week for value: week
        /// </summary>
        [EnumMember(Value = "week")]
        Week = 3,

        /// <summary>
        /// Enum Month for value: month
        /// </summary>
        [EnumMember(Value = "month")]
        Month = 4,

        /// <summary>
        /// Enum Year for value: year
        /// </summary>
        [EnumMember(Value = "year")]
        Year = 5

    }

}
