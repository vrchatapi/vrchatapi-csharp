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
    /// CreateGroupInviteRequest
    /// </summary>
    [DataContract(Name = "CreateGroupInviteRequest")]
    public partial class CreateGroupInviteRequest : IEquatable<CreateGroupInviteRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGroupInviteRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateGroupInviteRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGroupInviteRequest" /> class.
        /// </summary>
        /// <param name="userId">A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed. (required).</param>
        /// <param name="confirmOverrideBlock">confirmOverrideBlock (default to true).</param>
        public CreateGroupInviteRequest(string userId = default(string), bool confirmOverrideBlock = true)
        {
            // to ensure "userId" is required (not null)
            if (userId == null)
            {
                throw new ArgumentNullException("userId is a required property for CreateGroupInviteRequest and cannot be null");
            }
            this.UserId = userId;
            this.ConfirmOverrideBlock = confirmOverrideBlock;
        }

        /// <summary>
        /// A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed.
        /// </summary>
        /// <value>A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed.</value>
        [DataMember(Name = "userId", IsRequired = true, EmitDefaultValue = true)]
        public string UserId { get; set; }

        /// <summary>
        /// Gets or Sets ConfirmOverrideBlock
        /// </summary>
        [DataMember(Name = "confirmOverrideBlock", EmitDefaultValue = true)]
        public bool ConfirmOverrideBlock { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateGroupInviteRequest {\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  ConfirmOverrideBlock: ").Append(ConfirmOverrideBlock).Append("\n");
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
            return this.Equals(input as CreateGroupInviteRequest);
        }

        /// <summary>
        /// Returns true if CreateGroupInviteRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateGroupInviteRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateGroupInviteRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.ConfirmOverrideBlock == input.ConfirmOverrideBlock ||
                    this.ConfirmOverrideBlock.Equals(input.ConfirmOverrideBlock)
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
                if (this.UserId != null)
                {
                    hashCode = (hashCode * 59) + this.UserId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ConfirmOverrideBlock.GetHashCode();
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
