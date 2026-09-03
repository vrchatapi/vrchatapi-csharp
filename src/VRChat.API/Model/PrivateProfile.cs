

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
    /// PrivateProfile
    /// </summary>
    [DataContract(Name = "PrivateProfile")]
    public partial class PrivateProfile : IEquatable<PrivateProfile>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public UserStatus? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateProfile" /> class.
        /// </summary>
        /// <param name="activity">activity.</param>
        /// <param name="friendRequestStatus">State of a friend request between the caller and this user. VRChat sends the string &#x60;\&quot;null\&quot;&#x60;, not JSON &#x60;null&#x60;..</param>
        /// <param name="id">A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed..</param>
        /// <param name="isFriend">isFriend.</param>
        /// <param name="note">note.</param>
        /// <param name="status">status.</param>
        /// <param name="statusDescription">statusDescription.</param>
        public PrivateProfile(PrivateProfileActivity activity = default, string friendRequestStatus = default, string id = default, bool isFriend = default, string note = default, UserStatus? status = default, string statusDescription = default)
        {
            this.Activity = activity;
            this.FriendRequestStatus = friendRequestStatus;
            this.Id = id;
            this.IsFriend = isFriend;
            this.Note = note;
            this.Status = status;
            this.StatusDescription = statusDescription;
        }

        /// <summary>
        /// Gets or Sets Activity
        /// </summary>
        [DataMember(Name = "activity", EmitDefaultValue = false)]
        public PrivateProfileActivity Activity { get; set; }

        /// <summary>
        /// State of a friend request between the caller and this user. VRChat sends the string &#x60;\&quot;null\&quot;&#x60;, not JSON &#x60;null&#x60;.
        /// </summary>
        /// <value>State of a friend request between the caller and this user. VRChat sends the string &#x60;\&quot;null\&quot;&#x60;, not JSON &#x60;null&#x60;.</value>
        /*
        <example>null</example>
        */
        [DataMember(Name = "friendRequestStatus", EmitDefaultValue = false)]
        public string FriendRequestStatus { get; set; }

        /// <summary>
        /// A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed.
        /// </summary>
        /// <value>A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed.</value>
        /*
        <example>usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469</example>
        */
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets IsFriend
        /// </summary>
        [DataMember(Name = "isFriend", EmitDefaultValue = true)]
        public bool IsFriend { get; set; }

        /// <summary>
        /// Gets or Sets Note
        /// </summary>
        [DataMember(Name = "note", EmitDefaultValue = true)]
        public string Note { get; set; }

        /// <summary>
        /// Gets or Sets StatusDescription
        /// </summary>
        [DataMember(Name = "statusDescription", EmitDefaultValue = false)]
        public string StatusDescription { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PrivateProfile {\n");
            sb.Append("  Activity: ").Append(Activity).Append("\n");
            sb.Append("  FriendRequestStatus: ").Append(FriendRequestStatus).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IsFriend: ").Append(IsFriend).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StatusDescription: ").Append(StatusDescription).Append("\n");
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
            return this.Equals(input as PrivateProfile);
        }

        /// <summary>
        /// Returns true if PrivateProfile instances are equal
        /// </summary>
        /// <param name="input">Instance of PrivateProfile to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PrivateProfile input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Activity == input.Activity ||
                    (this.Activity != null &&
                    this.Activity.Equals(input.Activity))
                ) && 
                (
                    this.FriendRequestStatus == input.FriendRequestStatus ||
                    (this.FriendRequestStatus != null &&
                    this.FriendRequestStatus.Equals(input.FriendRequestStatus))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.IsFriend == input.IsFriend ||
                    this.IsFriend.Equals(input.IsFriend)
                ) && 
                (
                    this.Note == input.Note ||
                    (this.Note != null &&
                    this.Note.Equals(input.Note))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.StatusDescription == input.StatusDescription ||
                    (this.StatusDescription != null &&
                    this.StatusDescription.Equals(input.StatusDescription))
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
                if (this.Activity != null)
                {
                    hashCode = (hashCode * 59) + this.Activity.GetHashCode();
                }
                if (this.FriendRequestStatus != null)
                {
                    hashCode = (hashCode * 59) + this.FriendRequestStatus.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsFriend.GetHashCode();
                if (this.Note != null)
                {
                    hashCode = (hashCode * 59) + this.Note.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.StatusDescription != null)
                {
                    hashCode = (hashCode * 59) + this.StatusDescription.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
