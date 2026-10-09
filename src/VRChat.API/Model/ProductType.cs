

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
    /// Defines ProductType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ProductType
    {
        /// <summary>
        /// Enum Avatar for value: avatar
        /// </summary>
        [EnumMember(Value = "avatar")]
        Avatar = 1,

        /// <summary>
        /// Enum Credit for value: credit
        /// </summary>
        [EnumMember(Value = "credit")]
        Credit = 2,

        /// <summary>
        /// Enum Inventory for value: inventory
        /// </summary>
        [EnumMember(Value = "inventory")]
        Inventory = 3,

        /// <summary>
        /// Enum Listing for value: listing
        /// </summary>
        [EnumMember(Value = "listing")]
        Listing = 4,

        /// <summary>
        /// Enum TestBirdy for value: test_birdy
        /// </summary>
        [EnumMember(Value = "test_birdy")]
        TestBirdy = 5,

        /// <summary>
        /// Enum Udon for value: udon
        /// </summary>
        [EnumMember(Value = "udon")]
        Udon = 6,

        /// <summary>
        /// Enum Role for value: role
        /// </summary>
        [EnumMember(Value = "role")]
        Role = 7
    }

}
