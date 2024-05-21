/*
 * VRChat API Documentation
 *
 *
 * The version of the OpenAPI document: 1.17.4
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
    /// CreateGroupPostRequest
    /// </summary>
    [DataContract(Name = "CreateGroupPostRequest")]
    public partial class CreateGroupPostRequest : IEquatable<CreateGroupPostRequest>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Visibility
        /// </summary>
        [DataMember(Name = "visibility", IsRequired = true, EmitDefaultValue = true)]
        public GroupPostVisibility Visibility { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGroupPostRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateGroupPostRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGroupPostRequest" /> class.
        /// </summary>
        /// <param name="title">Post title (required).</param>
        /// <param name="text">Post text (required).</param>
        /// <param name="imageId">imageId.</param>
        /// <param name="sendNotification">Send notification to group members. (required) (default to false).</param>
        /// <param name="roleIds"> .</param>
        /// <param name="visibility">visibility (required).</param>
        public CreateGroupPostRequest(string title = default(string), string text = default(string), string imageId = default(string), bool sendNotification = false, List<string> roleIds = default(List<string>), GroupPostVisibility visibility = default(GroupPostVisibility))
        {
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new ArgumentNullException("title is a required property for CreateGroupPostRequest and cannot be null");
            }
            this.Title = title;
            // to ensure "text" is required (not null)
            if (text == null)
            {
                throw new ArgumentNullException("text is a required property for CreateGroupPostRequest and cannot be null");
            }
            this.Text = text;
            this.SendNotification = sendNotification;
            this.Visibility = visibility;
            this.ImageId = imageId;
            this.RoleIds = roleIds;
        }

        /// <summary>
        /// Post title
        /// </summary>
        /// <value>Post title</value>
        [DataMember(Name = "title", IsRequired = true, EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Post text
        /// </summary>
        /// <value>Post text</value>
        [DataMember(Name = "text", IsRequired = true, EmitDefaultValue = true)]
        public string Text { get; set; }

        /// <summary>
        /// Gets or Sets ImageId
        /// </summary>
        [DataMember(Name = "imageId", EmitDefaultValue = false)]
        public string ImageId { get; set; }

        /// <summary>
        /// Send notification to group members.
        /// </summary>
        /// <value>Send notification to group members.</value>
        [DataMember(Name = "sendNotification", IsRequired = true, EmitDefaultValue = true)]
        public bool SendNotification { get; set; }

        /// <summary>
        ///  
        /// </summary>
        /// <value> </value>
        [DataMember(Name = "roleIds", EmitDefaultValue = false)]
        public List<string> RoleIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateGroupPostRequest {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  ImageId: ").Append(ImageId).Append("\n");
            sb.Append("  SendNotification: ").Append(SendNotification).Append("\n");
            sb.Append("  RoleIds: ").Append(RoleIds).Append("\n");
            sb.Append("  Visibility: ").Append(Visibility).Append("\n");
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
            return this.Equals(input as CreateGroupPostRequest);
        }

        /// <summary>
        /// Returns true if CreateGroupPostRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateGroupPostRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateGroupPostRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
                ) && 
                (
                    this.ImageId == input.ImageId ||
                    (this.ImageId != null &&
                    this.ImageId.Equals(input.ImageId))
                ) && 
                (
                    this.SendNotification == input.SendNotification ||
                    this.SendNotification.Equals(input.SendNotification)
                ) && 
                (
                    this.RoleIds == input.RoleIds ||
                    this.RoleIds != null &&
                    input.RoleIds != null &&
                    this.RoleIds.SequenceEqual(input.RoleIds)
                ) && 
                (
                    this.Visibility == input.Visibility ||
                    this.Visibility.Equals(input.Visibility)
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
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
                }
                if (this.Text != null)
                {
                    hashCode = (hashCode * 59) + this.Text.GetHashCode();
                }
                if (this.ImageId != null)
                {
                    hashCode = (hashCode * 59) + this.ImageId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SendNotification.GetHashCode();
                if (this.RoleIds != null)
                {
                    hashCode = (hashCode * 59) + this.RoleIds.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Visibility.GetHashCode();
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
            // Title (string) minLength
            if (this.Title != null && this.Title.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Title, length must be greater than 1.", new [] { "Title" });
            }

            // Text (string) minLength
            if (this.Text != null && this.Text.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Text, length must be greater than 1.", new [] { "Text" });
            }

            yield break;
        }
    }

}