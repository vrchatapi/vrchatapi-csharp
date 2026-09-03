

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
    /// A third-party service VRChat mints an SSO token for. Anything else is refused with \&quot;That is not a supported SSO provider.\&quot;
    /// </summary>
    /// <value>A third-party service VRChat mints an SSO token for. Anything else is refused with \&quot;That is not a supported SSO provider.\&quot;</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SsoProvider
    {
        /// <summary>
        /// Enum Canny for value: canny
        /// </summary>
        [EnumMember(Value = "canny")]
        Canny = 1,

        /// <summary>
        /// Enum Furality for value: furality
        /// </summary>
        [EnumMember(Value = "furality")]
        Furality = 2
    }

}
