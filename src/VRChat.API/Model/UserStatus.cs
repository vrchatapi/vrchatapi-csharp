/*
 * VRChat API Documentation
 *
 *
 * The version of the OpenAPI document: 1.16.0
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
    /// Defines the User&#39;s current status, for example \&quot;ask me\&quot;, \&quot;join me\&quot; or \&quot;offline. This status is a combined indicator of their online activity and privacy preference.
    /// </summary>
    /// <value>Defines the User&#39;s current status, for example \&quot;ask me\&quot;, \&quot;join me\&quot; or \&quot;offline. This status is a combined indicator of their online activity and privacy preference.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum UserStatus
    {
        /// <summary>
        /// Enum Active for value: active
        /// </summary>
        [EnumMember(Value = "active")]
        Active = 1,

        /// <summary>
        /// Enum JoinMe for value: join me
        /// </summary>
        [EnumMember(Value = "join me")]
        JoinMe = 2,

        /// <summary>
        /// Enum AskMe for value: ask me
        /// </summary>
        [EnumMember(Value = "ask me")]
        AskMe = 3,

        /// <summary>
        /// Enum Busy for value: busy
        /// </summary>
        [EnumMember(Value = "busy")]
        Busy = 4,

        /// <summary>
        /// Enum Offline for value: offline
        /// </summary>
        [EnumMember(Value = "offline")]
        Offline = 5

    }

}
