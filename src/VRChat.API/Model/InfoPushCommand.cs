

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
    /// Defines InfoPushCommand
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum InfoPushCommand
    {
        /// <summary>
        /// Enum CannedWorldSearch for value: CannedWorldSearch
        /// </summary>
        [EnumMember(Value = "CannedWorldSearch")]
        CannedWorldSearch = 1,

        /// <summary>
        /// Enum OpenAccountUpgrade for value: OpenAccountUpgrade
        /// </summary>
        [EnumMember(Value = "OpenAccountUpgrade")]
        OpenAccountUpgrade = 2,

        /// <summary>
        /// Enum OpenAvatarsMenu for value: OpenAvatarsMenu
        /// </summary>
        [EnumMember(Value = "OpenAvatarsMenu")]
        OpenAvatarsMenu = 3,

        /// <summary>
        /// Enum OpenHelpArticle for value: OpenHelpArticle
        /// </summary>
        [EnumMember(Value = "OpenHelpArticle")]
        OpenHelpArticle = 4,

        /// <summary>
        /// Enum OpenListingDetails for value: OpenListingDetails
        /// </summary>
        [EnumMember(Value = "OpenListingDetails")]
        OpenListingDetails = 5,

        /// <summary>
        /// Enum OpenSafetyMenu for value: OpenSafetyMenu
        /// </summary>
        [EnumMember(Value = "OpenSafetyMenu")]
        OpenSafetyMenu = 6,

        /// <summary>
        /// Enum OpenURL for value: OpenURL
        /// </summary>
        [EnumMember(Value = "OpenURL")]
        OpenURL = 7,

        /// <summary>
        /// Enum OpenVRCPlusMenu for value: OpenVRCPlusMenu
        /// </summary>
        [EnumMember(Value = "OpenVRCPlusMenu")]
        OpenVRCPlusMenu = 8,

        /// <summary>
        /// Enum OpenVRChatStore for value: OpenVRChatStore
        /// </summary>
        [EnumMember(Value = "OpenVRChatStore")]
        OpenVRChatStore = 9,

        /// <summary>
        /// Enum OpenWorldDetails for value: OpenWorldDetails
        /// </summary>
        [EnumMember(Value = "OpenWorldDetails")]
        OpenWorldDetails = 10,

        /// <summary>
        /// Enum OpenWorldsMenu for value: OpenWorldsMenu
        /// </summary>
        [EnumMember(Value = "OpenWorldsMenu")]
        OpenWorldsMenu = 11,

        /// <summary>
        /// Enum ScrollToShelf for value: scrollToShelf
        /// </summary>
        [EnumMember(Value = "scrollToShelf")]
        ScrollToShelf = 12
    }

}
