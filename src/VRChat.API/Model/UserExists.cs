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
    /// Status object representing if a queried user by username or userId exists or not. This model is primarily used by the &#x60;/auth/exists&#x60; endpoint, which in turn is used during registration. Please see the documentation on that endpoint for more information on usage.
    /// </summary>
    [DataContract(Name = "UserExists")]
    public partial class UserExists : IEquatable<UserExists>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserExists" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserExists() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserExists" /> class.
        /// </summary>
        /// <param name="userExists">Status if a user exist with that username or userId. (required) (default to false).</param>
        /// <param name="nameOk">Is the username valid? (default to false).</param>
        public UserExists(bool userExists = false, bool nameOk = false)
        {
            this._UserExists = userExists;
            this.NameOk = nameOk;
        }

        /// <summary>
        /// Status if a user exist with that username or userId.
        /// </summary>
        /// <value>Status if a user exist with that username or userId.</value>
        [DataMember(Name = "userExists", IsRequired = true, EmitDefaultValue = true)]
        public bool _UserExists { get; set; }

        /// <summary>
        /// Is the username valid?
        /// </summary>
        /// <value>Is the username valid?</value>
        [DataMember(Name = "nameOk", EmitDefaultValue = true)]
        public bool NameOk { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserExists {\n");
            sb.Append("  _UserExists: ").Append(_UserExists).Append("\n");
            sb.Append("  NameOk: ").Append(NameOk).Append("\n");
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
            return this.Equals(input as UserExists);
        }

        /// <summary>
        /// Returns true if UserExists instances are equal
        /// </summary>
        /// <param name="input">Instance of UserExists to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserExists input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this._UserExists == input._UserExists ||
                    this._UserExists.Equals(input._UserExists)
                ) && 
                (
                    this.NameOk == input.NameOk ||
                    this.NameOk.Equals(input.NameOk)
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
                hashCode = (hashCode * 59) + this._UserExists.GetHashCode();
                hashCode = (hashCode * 59) + this.NameOk.GetHashCode();
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
