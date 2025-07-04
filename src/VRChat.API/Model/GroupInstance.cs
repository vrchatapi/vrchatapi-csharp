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
    /// GroupInstance
    /// </summary>
    [DataContract(Name = "GroupInstance")]
    public partial class GroupInstance : IEquatable<GroupInstance>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupInstance" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GroupInstance() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupInstance" /> class.
        /// </summary>
        /// <param name="instanceId">instanceId (required).</param>
        /// <param name="location">InstanceID can be \&quot;offline\&quot; on User profiles if you are not friends with that user and \&quot;private\&quot; if you are friends and user is in private instance. (required).</param>
        /// <param name="world">world (required).</param>
        /// <param name="memberCount">memberCount (required).</param>
        public GroupInstance(string instanceId = default(string), string location = default(string), World world = default(World), int memberCount = default(int))
        {
            // to ensure "instanceId" is required (not null)
            if (instanceId == null)
            {
                throw new ArgumentNullException("instanceId is a required property for GroupInstance and cannot be null");
            }
            this.InstanceId = instanceId;
            // to ensure "location" is required (not null)
            if (location == null)
            {
                throw new ArgumentNullException("location is a required property for GroupInstance and cannot be null");
            }
            this.Location = location;
            // to ensure "world" is required (not null)
            if (world == null)
            {
                throw new ArgumentNullException("world is a required property for GroupInstance and cannot be null");
            }
            this.World = world;
            this.MemberCount = memberCount;
        }

        /// <summary>
        /// Gets or Sets InstanceId
        /// </summary>
        [DataMember(Name = "instanceId", IsRequired = true, EmitDefaultValue = true)]
        public string InstanceId { get; set; }

        /// <summary>
        /// InstanceID can be \&quot;offline\&quot; on User profiles if you are not friends with that user and \&quot;private\&quot; if you are friends and user is in private instance.
        /// </summary>
        /// <value>InstanceID can be \&quot;offline\&quot; on User profiles if you are not friends with that user and \&quot;private\&quot; if you are friends and user is in private instance.</value>
        [DataMember(Name = "location", IsRequired = true, EmitDefaultValue = true)]
        public string Location { get; set; }

        /// <summary>
        /// Gets or Sets World
        /// </summary>
        [DataMember(Name = "world", IsRequired = true, EmitDefaultValue = true)]
        public World World { get; set; }

        /// <summary>
        /// Gets or Sets MemberCount
        /// </summary>
        [DataMember(Name = "memberCount", IsRequired = true, EmitDefaultValue = true)]
        public int MemberCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GroupInstance {\n");
            sb.Append("  InstanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  World: ").Append(World).Append("\n");
            sb.Append("  MemberCount: ").Append(MemberCount).Append("\n");
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
            return this.Equals(input as GroupInstance);
        }

        /// <summary>
        /// Returns true if GroupInstance instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupInstance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupInstance input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.InstanceId == input.InstanceId ||
                    (this.InstanceId != null &&
                    this.InstanceId.Equals(input.InstanceId))
                ) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && 
                (
                    this.World == input.World ||
                    (this.World != null &&
                    this.World.Equals(input.World))
                ) && 
                (
                    this.MemberCount == input.MemberCount ||
                    this.MemberCount.Equals(input.MemberCount)
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
                if (this.InstanceId != null)
                {
                    hashCode = (hashCode * 59) + this.InstanceId.GetHashCode();
                }
                if (this.Location != null)
                {
                    hashCode = (hashCode * 59) + this.Location.GetHashCode();
                }
                if (this.World != null)
                {
                    hashCode = (hashCode * 59) + this.World.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.MemberCount.GetHashCode();
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
            // InstanceId (string) minLength
            if (this.InstanceId != null && this.InstanceId.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for InstanceId, length must be greater than 1.", new [] { "InstanceId" });
            }

            // MemberCount (int) minimum
            if (this.MemberCount < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MemberCount, must be a value greater than or equal to 0.", new [] { "MemberCount" });
            }

            yield break;
        }
    }

}
