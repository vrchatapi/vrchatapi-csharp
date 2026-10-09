

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
    /// Defines CreateFileRequestMIMEType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CreateFileRequestMIMEType
    {
        /// <summary>
        /// Enum ApplicationGzip for value: application/gzip
        /// </summary>
        [EnumMember(Value = "application/gzip")]
        ApplicationGzip = 1,

        /// <summary>
        /// Enum ApplicationXAdminassetbundle for value: application/x-adminassetbundle
        /// </summary>
        [EnumMember(Value = "application/x-adminassetbundle")]
        ApplicationXAdminassetbundle = 2,

        /// <summary>
        /// Enum ApplicationXAvatar for value: application/x-avatar
        /// </summary>
        [EnumMember(Value = "application/x-avatar")]
        ApplicationXAvatar = 3,

        /// <summary>
        /// Enum ApplicationXAvatarbuilderresource for value: application/x-avatarbuilderresource
        /// </summary>
        [EnumMember(Value = "application/x-avatarbuilderresource")]
        ApplicationXAvatarbuilderresource = 4,

        /// <summary>
        /// Enum ApplicationXAvatarpart for value: application/x-avatarpart
        /// </summary>
        [EnumMember(Value = "application/x-avatarpart")]
        ApplicationXAvatarpart = 5,

        /// <summary>
        /// Enum ApplicationXProp for value: application/x-prop
        /// </summary>
        [EnumMember(Value = "application/x-prop")]
        ApplicationXProp = 6,

        /// <summary>
        /// Enum ApplicationXWorld for value: application/x-world
        /// </summary>
        [EnumMember(Value = "application/x-world")]
        ApplicationXWorld = 7,

        /// <summary>
        /// Enum ImageBmp for value: image/bmp
        /// </summary>
        [EnumMember(Value = "image/bmp")]
        ImageBmp = 8,

        /// <summary>
        /// Enum ImageGif for value: image/gif
        /// </summary>
        [EnumMember(Value = "image/gif")]
        ImageGif = 9,

        /// <summary>
        /// Enum ImageJpeg for value: image/jpeg
        /// </summary>
        [EnumMember(Value = "image/jpeg")]
        ImageJpeg = 10,

        /// <summary>
        /// Enum ImageJpg for value: image/jpg
        /// </summary>
        [EnumMember(Value = "image/jpg")]
        ImageJpg = 11,

        /// <summary>
        /// Enum ImagePng for value: image/png
        /// </summary>
        [EnumMember(Value = "image/png")]
        ImagePng = 12,

        /// <summary>
        /// Enum ImageSvgxml for value: image/svg+xml
        /// </summary>
        [EnumMember(Value = "image/svg+xml")]
        ImageSvgxml = 13,

        /// <summary>
        /// Enum ImageTiff for value: image/tiff
        /// </summary>
        [EnumMember(Value = "image/tiff")]
        ImageTiff = 14,

        /// <summary>
        /// Enum ImageWebp for value: image/webp
        /// </summary>
        [EnumMember(Value = "image/webp")]
        ImageWebp = 15,

        /// <summary>
        /// Enum VideoMp4 for value: video/mp4
        /// </summary>
        [EnumMember(Value = "video/mp4")]
        VideoMp4 = 16
    }

}
