/*
 * VRChat API Documentation
 *
 *
 * The version of the OpenAPI document: 1.19.0
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
    /// Submission
    /// </summary>
    [DataContract(Name = "Submission")]
    public partial class Submission : IEquatable<Submission>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Submission" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Submission() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Submission" /> class.
        /// </summary>
        /// <param name="contentId">Either world ID or avatar ID (required).</param>
        /// <param name="createdAt">createdAt (required).</param>
        /// <param name="description">description (required).</param>
        /// <param name="id">id (required).</param>
        /// <param name="jamId">jamId (required).</param>
        /// <param name="ratingScore">ratingScore.</param>
        /// <param name="submitterId">A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed. (required).</param>
        public Submission(string contentId = default(string), DateTime createdAt = default(DateTime), string description = default(string), string id = default(string), string jamId = default(string), int ratingScore = default(int), string submitterId = default(string))
        {
            // to ensure "contentId" is required (not null)
            if (contentId == null)
            {
                throw new ArgumentNullException("contentId is a required property for Submission and cannot be null");
            }
            this.ContentId = contentId;
            this.CreatedAt = createdAt;
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new ArgumentNullException("description is a required property for Submission and cannot be null");
            }
            this.Description = description;
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for Submission and cannot be null");
            }
            this.Id = id;
            // to ensure "jamId" is required (not null)
            if (jamId == null)
            {
                throw new ArgumentNullException("jamId is a required property for Submission and cannot be null");
            }
            this.JamId = jamId;
            // to ensure "submitterId" is required (not null)
            if (submitterId == null)
            {
                throw new ArgumentNullException("submitterId is a required property for Submission and cannot be null");
            }
            this.SubmitterId = submitterId;
            this.RatingScore = ratingScore;
        }

        /// <summary>
        /// Either world ID or avatar ID
        /// </summary>
        /// <value>Either world ID or avatar ID</value>
        [DataMember(Name = "contentId", IsRequired = true, EmitDefaultValue = true)]
        public string ContentId { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "created_at", IsRequired = true, EmitDefaultValue = true)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets JamId
        /// </summary>
        [DataMember(Name = "jamId", IsRequired = true, EmitDefaultValue = true)]
        public string JamId { get; set; }

        /// <summary>
        /// Gets or Sets RatingScore
        /// </summary>
        [DataMember(Name = "ratingScore", EmitDefaultValue = false)]
        public int RatingScore { get; set; }

        /// <summary>
        /// A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed.
        /// </summary>
        /// <value>A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed.</value>
        [DataMember(Name = "submitterId", IsRequired = true, EmitDefaultValue = true)]
        public string SubmitterId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Submission {\n");
            sb.Append("  ContentId: ").Append(ContentId).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  JamId: ").Append(JamId).Append("\n");
            sb.Append("  RatingScore: ").Append(RatingScore).Append("\n");
            sb.Append("  SubmitterId: ").Append(SubmitterId).Append("\n");
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
            return this.Equals(input as Submission);
        }

        /// <summary>
        /// Returns true if Submission instances are equal
        /// </summary>
        /// <param name="input">Instance of Submission to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Submission input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ContentId == input.ContentId ||
                    (this.ContentId != null &&
                    this.ContentId.Equals(input.ContentId))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.JamId == input.JamId ||
                    (this.JamId != null &&
                    this.JamId.Equals(input.JamId))
                ) && 
                (
                    this.RatingScore == input.RatingScore ||
                    this.RatingScore.Equals(input.RatingScore)
                ) && 
                (
                    this.SubmitterId == input.SubmitterId ||
                    (this.SubmitterId != null &&
                    this.SubmitterId.Equals(input.SubmitterId))
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
                if (this.ContentId != null)
                {
                    hashCode = (hashCode * 59) + this.ContentId.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.JamId != null)
                {
                    hashCode = (hashCode * 59) + this.JamId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.RatingScore.GetHashCode();
                if (this.SubmitterId != null)
                {
                    hashCode = (hashCode * 59) + this.SubmitterId.GetHashCode();
                }
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
            // ContentId (string) minLength
            if (this.ContentId != null && this.ContentId.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ContentId, length must be greater than 1.", new [] { "ContentId" });
            }

            // Id (string) minLength
            if (this.Id != null && this.Id.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, length must be greater than 1.", new [] { "Id" });
            }

            // JamId (string) minLength
            if (this.JamId != null && this.JamId.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for JamId, length must be greater than 1.", new [] { "JamId" });
            }

            // RatingScore (int) minimum
            if (this.RatingScore < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RatingScore, must be a value greater than or equal to 0.", new [] { "RatingScore" });
            }

            yield break;
        }
    }

}
