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
    /// Avatar Performance ratings.
    /// </summary>
    /// <value>Avatar Performance ratings.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PerformanceRatings
    {
        /// <summary>
        /// Enum None for value: None
        /// </summary>
        [EnumMember(Value = "None")]
        None = 1,

        /// <summary>
        /// Enum Excellent for value: Excellent
        /// </summary>
        [EnumMember(Value = "Excellent")]
        Excellent = 2,

        /// <summary>
        /// Enum Good for value: Good
        /// </summary>
        [EnumMember(Value = "Good")]
        Good = 3,

        /// <summary>
        /// Enum Medium for value: Medium
        /// </summary>
        [EnumMember(Value = "Medium")]
        Medium = 4,

        /// <summary>
        /// Enum Poor for value: Poor
        /// </summary>
        [EnumMember(Value = "Poor")]
        Poor = 5,

        /// <summary>
        /// Enum VeryPoor for value: VeryPoor
        /// </summary>
        [EnumMember(Value = "VeryPoor")]
        VeryPoor = 6

    }

}
