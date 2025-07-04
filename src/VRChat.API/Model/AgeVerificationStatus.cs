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
    /// &#x60;verified&#x60; is obsolete.  User who have verified and are 18+ can switch to &#x60;plus18&#x60; status. 
    /// </summary>
    /// <value>&#x60;verified&#x60; is obsolete.  User who have verified and are 18+ can switch to &#x60;plus18&#x60; status. </value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AgeVerificationStatus
    {
        /// <summary>
        /// Enum hidden for value: hidden
        /// </summary>
        [EnumMember(Value = "hidden")]
        hidden = 1,

        /// <summary>
        /// Enum verified for value: verified
        /// </summary>
        [EnumMember(Value = "verified")]
        verified = 2,

        /// <summary>
        /// Enum plus18 for value: 18+
        /// </summary>
        [EnumMember(Value = "18+")]
        plus18 = 3

    }

}
