

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
    /// Defines SortOptionAvatar
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SortOptionAvatar
    {
        /// <summary>
        /// Enum CreatedAt for value: _created_at
        /// </summary>
        [EnumMember(Value = "_created_at")]
        CreatedAt = 1,

        /// <summary>
        /// Enum UpdatedAt for value: _updated_at
        /// </summary>
        [EnumMember(Value = "_updated_at")]
        UpdatedAt = 2,

        /// <summary>
        /// Enum Contains for value: contains
        /// </summary>
        [EnumMember(Value = "contains")]
        Contains = 3,

        /// <summary>
        /// Enum CountMonthlySales for value: countMonthlySales
        /// </summary>
        [EnumMember(Value = "countMonthlySales")]
        CountMonthlySales = 4,

        /// <summary>
        /// Enum Created for value: created
        /// </summary>
        [EnumMember(Value = "created")]
        Created = 5,

        /// <summary>
        /// Enum Exact for value: exact
        /// </summary>
        [EnumMember(Value = "exact")]
        Exact = 6,

        /// <summary>
        /// Enum ListingDate for value: listingDate
        /// </summary>
        [EnumMember(Value = "listingDate")]
        ListingDate = 7,

        /// <summary>
        /// Enum Name for value: name
        /// </summary>
        [EnumMember(Value = "name")]
        Name = 8,

        /// <summary>
        /// Enum Order for value: order
        /// </summary>
        [EnumMember(Value = "order")]
        Order = 9,

        /// <summary>
        /// Enum Performance for value: performance
        /// </summary>
        [EnumMember(Value = "performance")]
        Performance = 10,

        /// <summary>
        /// Enum Random for value: random
        /// </summary>
        [EnumMember(Value = "random")]
        Random = 11,

        /// <summary>
        /// Enum Relevance for value: relevance
        /// </summary>
        [EnumMember(Value = "relevance")]
        Relevance = 12,

        /// <summary>
        /// Enum Shuffle for value: shuffle
        /// </summary>
        [EnumMember(Value = "shuffle")]
        Shuffle = 13,

        /// <summary>
        /// Enum TrendRank for value: trendRank
        /// </summary>
        [EnumMember(Value = "trendRank")]
        TrendRank = 14,

        /// <summary>
        /// Enum Updated for value: updated
        /// </summary>
        [EnumMember(Value = "updated")]
        Updated = 15
    }

}
