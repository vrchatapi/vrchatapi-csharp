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
    /// Defines MIMEType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MIMEType
    {
        /// <summary>
        /// Enum ImageJpeg for value: image/jpeg
        /// </summary>
        [EnumMember(Value = "image/jpeg")]
        ImageJpeg = 1,

        /// <summary>
        /// Enum ImageJpg for value: image/jpg
        /// </summary>
        [EnumMember(Value = "image/jpg")]
        ImageJpg = 2,

        /// <summary>
        /// Enum ImagePng for value: image/png
        /// </summary>
        [EnumMember(Value = "image/png")]
        ImagePng = 3,

        /// <summary>
        /// Enum ImageWebp for value: image/webp
        /// </summary>
        [EnumMember(Value = "image/webp")]
        ImageWebp = 4,

        /// <summary>
        /// Enum ImageGif for value: image/gif
        /// </summary>
        [EnumMember(Value = "image/gif")]
        ImageGif = 5,

        /// <summary>
        /// Enum ImageBmp for value: image/bmp
        /// </summary>
        [EnumMember(Value = "image/bmp")]
        ImageBmp = 6,

        /// <summary>
        /// Enum ImageSvgxml for value: image/svg＋xml
        /// </summary>
        [EnumMember(Value = "image/svg＋xml")]
        ImageSvgxml = 7,

        /// <summary>
        /// Enum ImageTiff for value: image/tiff
        /// </summary>
        [EnumMember(Value = "image/tiff")]
        ImageTiff = 8,

        /// <summary>
        /// Enum ApplicationXAvatar for value: application/x-avatar
        /// </summary>
        [EnumMember(Value = "application/x-avatar")]
        ApplicationXAvatar = 9,

        /// <summary>
        /// Enum ApplicationXWorld for value: application/x-world
        /// </summary>
        [EnumMember(Value = "application/x-world")]
        ApplicationXWorld = 10,

        /// <summary>
        /// Enum ApplicationGzip for value: application/gzip
        /// </summary>
        [EnumMember(Value = "application/gzip")]
        ApplicationGzip = 11,

        /// <summary>
        /// Enum ApplicationXRsyncSignature for value: application/x-rsync-signature
        /// </summary>
        [EnumMember(Value = "application/x-rsync-signature")]
        ApplicationXRsyncSignature = 12,

        /// <summary>
        /// Enum ApplicationXRsyncDelta for value: application/x-rsync-delta
        /// </summary>
        [EnumMember(Value = "application/x-rsync-delta")]
        ApplicationXRsyncDelta = 13,

        /// <summary>
        /// Enum ApplicationOctetStream for value: application/octet-stream
        /// </summary>
        [EnumMember(Value = "application/octet-stream")]
        ApplicationOctetStream = 14

    }

}
