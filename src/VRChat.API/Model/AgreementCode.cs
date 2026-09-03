

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
    /// The type of agreement.
    /// </summary>
    /// <value>The type of agreement.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AgreementCode
    {
        /// <summary>
        /// Enum ContentCopyrightOwned for value: content.copyright.owned
        /// </summary>
        [EnumMember(Value = "content.copyright.owned")]
        ContentCopyrightOwned = 1
    }

}
