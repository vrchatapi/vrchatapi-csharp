/*
 * VRChat API Documentation
 *
 *
 * The version of the OpenAPI document: 1.19.1
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
    /// Defines FileStatus
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FileStatus
    {
        /// <summary>
        /// Enum Waiting for value: waiting
        /// </summary>
        [EnumMember(Value = "waiting")]
        Waiting = 1,

        /// <summary>
        /// Enum Complete for value: complete
        /// </summary>
        [EnumMember(Value = "complete")]
        Complete = 2,

        /// <summary>
        /// Enum None for value: none
        /// </summary>
        [EnumMember(Value = "none")]
        None = 3,

        /// <summary>
        /// Enum Queued for value: queued
        /// </summary>
        [EnumMember(Value = "queued")]
        Queued = 4

    }

}
