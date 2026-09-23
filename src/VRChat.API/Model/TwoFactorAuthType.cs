

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
    /// Defines TwoFactorAuthType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TwoFactorAuthType
    {
        /// <summary>
        /// Enum EmailOtp for value: emailOtp
        /// </summary>
        [EnumMember(Value = "emailOtp")]
        EmailOtp = 1,

        /// <summary>
        /// Enum Otp for value: otp
        /// </summary>
        [EnumMember(Value = "otp")]
        Otp = 2,

        /// <summary>
        /// Enum Totp for value: totp
        /// </summary>
        [EnumMember(Value = "totp")]
        Totp = 3
    }

}
