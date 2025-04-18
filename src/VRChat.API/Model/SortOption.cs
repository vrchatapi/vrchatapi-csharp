/*
 * VRChat API Documentation
 *
 *
 * The version of the OpenAPI document: 1.19.2
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
    /// Defines SortOption
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SortOption
    {
        /// <summary>
        /// Enum Popularity for value: popularity
        /// </summary>
        [EnumMember(Value = "popularity")]
        Popularity = 1,

        /// <summary>
        /// Enum Heat for value: heat
        /// </summary>
        [EnumMember(Value = "heat")]
        Heat = 2,

        /// <summary>
        /// Enum Trust for value: trust
        /// </summary>
        [EnumMember(Value = "trust")]
        Trust = 3,

        /// <summary>
        /// Enum Shuffle for value: shuffle
        /// </summary>
        [EnumMember(Value = "shuffle")]
        Shuffle = 4,

        /// <summary>
        /// Enum Random for value: random
        /// </summary>
        [EnumMember(Value = "random")]
        Random = 5,

        /// <summary>
        /// Enum Favorites for value: favorites
        /// </summary>
        [EnumMember(Value = "favorites")]
        Favorites = 6,

        /// <summary>
        /// Enum ReportScore for value: reportScore
        /// </summary>
        [EnumMember(Value = "reportScore")]
        ReportScore = 7,

        /// <summary>
        /// Enum ReportCount for value: reportCount
        /// </summary>
        [EnumMember(Value = "reportCount")]
        ReportCount = 8,

        /// <summary>
        /// Enum PublicationDate for value: publicationDate
        /// </summary>
        [EnumMember(Value = "publicationDate")]
        PublicationDate = 9,

        /// <summary>
        /// Enum LabsPublicationDate for value: labsPublicationDate
        /// </summary>
        [EnumMember(Value = "labsPublicationDate")]
        LabsPublicationDate = 10,

        /// <summary>
        /// Enum Created for value: created
        /// </summary>
        [EnumMember(Value = "created")]
        Created = 11,

        /// <summary>
        /// Enum CreatedAt for value: _created_at
        /// </summary>
        [EnumMember(Value = "_created_at")]
        CreatedAt = 12,

        /// <summary>
        /// Enum Updated for value: updated
        /// </summary>
        [EnumMember(Value = "updated")]
        Updated = 13,

        /// <summary>
        /// Enum UpdatedAt for value: _updated_at
        /// </summary>
        [EnumMember(Value = "_updated_at")]
        UpdatedAt = 14,

        /// <summary>
        /// Enum Order for value: order
        /// </summary>
        [EnumMember(Value = "order")]
        Order = 15,

        /// <summary>
        /// Enum Relevance for value: relevance
        /// </summary>
        [EnumMember(Value = "relevance")]
        Relevance = 16,

        /// <summary>
        /// Enum Magic for value: magic
        /// </summary>
        [EnumMember(Value = "magic")]
        Magic = 17,

        /// <summary>
        /// Enum Name for value: name
        /// </summary>
        [EnumMember(Value = "name")]
        Name = 18

    }

}
