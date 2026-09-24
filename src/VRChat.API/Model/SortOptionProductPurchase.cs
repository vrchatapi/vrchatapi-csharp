

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
    /// Defines SortOptionProductPurchase
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SortOptionProductPurchase
    {
        /// <summary>
        /// Enum ExpireDate for value: expireDate
        /// </summary>
        [EnumMember(Value = "expireDate")]
        ExpireDate = 1,

        /// <summary>
        /// Enum Name for value: name
        /// </summary>
        [EnumMember(Value = "name")]
        Name = 2,

        /// <summary>
        /// Enum PurchaseDate for value: purchaseDate
        /// </summary>
        [EnumMember(Value = "purchaseDate")]
        PurchaseDate = 3
    }

}
