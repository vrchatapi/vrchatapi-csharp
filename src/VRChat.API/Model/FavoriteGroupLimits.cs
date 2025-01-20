/*
 * VRChat API Documentation
 *
 *
 * The version of the OpenAPI document: 1.18.9
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
    /// FavoriteGroupLimits
    /// </summary>
    [DataContract(Name = "FavoriteGroupLimits")]
    public partial class FavoriteGroupLimits : IEquatable<FavoriteGroupLimits>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FavoriteGroupLimits" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FavoriteGroupLimits() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FavoriteGroupLimits" /> class.
        /// </summary>
        /// <param name="avatar">avatar (required).</param>
        /// <param name="friend">friend (required).</param>
        /// <param name="world">world (required).</param>
        public FavoriteGroupLimits(int avatar = default(int), int friend = default(int), int world = default(int))
        {
            this.Avatar = avatar;
            this.Friend = friend;
            this.World = world;
        }

        /// <summary>
        /// Gets or Sets Avatar
        /// </summary>
        [DataMember(Name = "avatar", IsRequired = true, EmitDefaultValue = true)]
        public int Avatar { get; set; }

        /// <summary>
        /// Gets or Sets Friend
        /// </summary>
        [DataMember(Name = "friend", IsRequired = true, EmitDefaultValue = true)]
        public int Friend { get; set; }

        /// <summary>
        /// Gets or Sets World
        /// </summary>
        [DataMember(Name = "world", IsRequired = true, EmitDefaultValue = true)]
        public int World { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FavoriteGroupLimits {\n");
            sb.Append("  Avatar: ").Append(Avatar).Append("\n");
            sb.Append("  Friend: ").Append(Friend).Append("\n");
            sb.Append("  World: ").Append(World).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as FavoriteGroupLimits);
        }

        /// <summary>
        /// Returns true if FavoriteGroupLimits instances are equal
        /// </summary>
        /// <param name="input">Instance of FavoriteGroupLimits to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FavoriteGroupLimits input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Avatar == input.Avatar ||
                    this.Avatar.Equals(input.Avatar)
                ) && 
                (
                    this.Friend == input.Friend ||
                    this.Friend.Equals(input.Friend)
                ) && 
                (
                    this.World == input.World ||
                    this.World.Equals(input.World)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = (hashCode * 59) + this.Avatar.GetHashCode();
                hashCode = (hashCode * 59) + this.Friend.GetHashCode();
                hashCode = (hashCode * 59) + this.World.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
