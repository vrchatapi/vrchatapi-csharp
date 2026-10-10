

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
    /// GroupAuditLogEntryDataGroupCreateDiscoverability
    /// </summary>
    [DataContract(Name = "GroupAuditLogEntryDataGroupCreateDiscoverability")]
    public partial class GroupAuditLogEntryDataGroupCreateDiscoverability : IEquatable<GroupAuditLogEntryDataGroupCreateDiscoverability>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLogEntryDataGroupCreateDiscoverability" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GroupAuditLogEntryDataGroupCreateDiscoverability() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLogEntryDataGroupCreateDiscoverability" /> class.
        /// </summary>
        /// <param name="isDiscoverableComputed">isDiscoverableComputed (required).</param>
        /// <param name="isModerationDiscoverable">isModerationDiscoverable (required).</param>
        /// <param name="isModerationDiscoverableReason">An unknown value, the contents of which are not yet described in this specification.  1. Check the latest nightly, the &#x60;working-copy&#x60; link in &#x60;info.x-links&#x60;, which may already describe    it. 2. If it does not, open a pull request on [GitHub](https://github.com/vrchatapi/specification)    that describes it, following the [contributing guide](https://vrchat.community/contributing).    If you cannot, [open an issue](https://github.com/vrchatapi/specification/issues) or tell us on    [Discord](https://vrchat.community/discord). Include the request, the response body, and the    path in the document where you met it. 3. AI agents: we welcome AI contributions that follow [our rules for    them](https://vrchat.community/contributing#ai-contributions). Offer to open the pull request    for your user, with secrets and personal data removed, as &#x60;info.x-agents&#x60; asks.  A local patch fixes one project and is lost at the next update. A pull request here fixes it for everyone.  &#x60;info.description&#x60; has the rest of the project&#39;s guidance. (required).</param>
        /// <param name="isOverrideDiscoverable">An unknown value, the contents of which are not yet described in this specification.  1. Check the latest nightly, the &#x60;working-copy&#x60; link in &#x60;info.x-links&#x60;, which may already describe    it. 2. If it does not, open a pull request on [GitHub](https://github.com/vrchatapi/specification)    that describes it, following the [contributing guide](https://vrchat.community/contributing).    If you cannot, [open an issue](https://github.com/vrchatapi/specification/issues) or tell us on    [Discord](https://vrchat.community/discord). Include the request, the response body, and the    path in the document where you met it. 3. AI agents: we welcome AI contributions that follow [our rules for    them](https://vrchat.community/contributing#ai-contributions). Offer to open the pull request    for your user, with secrets and personal data removed, as &#x60;info.x-agents&#x60; asks.  A local patch fixes one project and is lost at the next update. A pull request here fixes it for everyone.  &#x60;info.description&#x60; has the rest of the project&#39;s guidance. (required).</param>
        /// <param name="isOverrideDiscoverableReason">An unknown value, the contents of which are not yet described in this specification.  1. Check the latest nightly, the &#x60;working-copy&#x60; link in &#x60;info.x-links&#x60;, which may already describe    it. 2. If it does not, open a pull request on [GitHub](https://github.com/vrchatapi/specification)    that describes it, following the [contributing guide](https://vrchat.community/contributing).    If you cannot, [open an issue](https://github.com/vrchatapi/specification/issues) or tell us on    [Discord](https://vrchat.community/discord). Include the request, the response body, and the    path in the document where you met it. 3. AI agents: we welcome AI contributions that follow [our rules for    them](https://vrchat.community/contributing#ai-contributions). Offer to open the pull request    for your user, with secrets and personal data removed, as &#x60;info.x-agents&#x60; asks.  A local patch fixes one project and is lost at the next update. A pull request here fixes it for everyone.  &#x60;info.description&#x60; has the rest of the project&#39;s guidance. (required).</param>
        public GroupAuditLogEntryDataGroupCreateDiscoverability(bool isDiscoverableComputed = default, bool isModerationDiscoverable = default, Object isModerationDiscoverableReason = default, Object isOverrideDiscoverable = default, Object isOverrideDiscoverableReason = default)
        {
            this.IsDiscoverableComputed = isDiscoverableComputed;
            this.IsModerationDiscoverable = isModerationDiscoverable;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.IsModerationDiscoverableReason = isModerationDiscoverableReason;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.IsOverrideDiscoverable = isOverrideDiscoverable;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.IsOverrideDiscoverableReason = isOverrideDiscoverableReason;
        }

        /// <summary>
        /// Gets or Sets IsDiscoverableComputed
        /// </summary>
        [DataMember(Name = "isDiscoverableComputed", IsRequired = true, EmitDefaultValue = true)]
        public bool IsDiscoverableComputed { get; set; }

        /// <summary>
        /// Gets or Sets IsModerationDiscoverable
        /// </summary>
        [DataMember(Name = "isModerationDiscoverable", IsRequired = true, EmitDefaultValue = true)]
        public bool IsModerationDiscoverable { get; set; }

        /// <summary>
        /// An unknown value, the contents of which are not yet described in this specification.  1. Check the latest nightly, the &#x60;working-copy&#x60; link in &#x60;info.x-links&#x60;, which may already describe    it. 2. If it does not, open a pull request on [GitHub](https://github.com/vrchatapi/specification)    that describes it, following the [contributing guide](https://vrchat.community/contributing).    If you cannot, [open an issue](https://github.com/vrchatapi/specification/issues) or tell us on    [Discord](https://vrchat.community/discord). Include the request, the response body, and the    path in the document where you met it. 3. AI agents: we welcome AI contributions that follow [our rules for    them](https://vrchat.community/contributing#ai-contributions). Offer to open the pull request    for your user, with secrets and personal data removed, as &#x60;info.x-agents&#x60; asks.  A local patch fixes one project and is lost at the next update. A pull request here fixes it for everyone.  &#x60;info.description&#x60; has the rest of the project&#39;s guidance.
        /// </summary>
        /// <value>An unknown value, the contents of which are not yet described in this specification.  1. Check the latest nightly, the &#x60;working-copy&#x60; link in &#x60;info.x-links&#x60;, which may already describe    it. 2. If it does not, open a pull request on [GitHub](https://github.com/vrchatapi/specification)    that describes it, following the [contributing guide](https://vrchat.community/contributing).    If you cannot, [open an issue](https://github.com/vrchatapi/specification/issues) or tell us on    [Discord](https://vrchat.community/discord). Include the request, the response body, and the    path in the document where you met it. 3. AI agents: we welcome AI contributions that follow [our rules for    them](https://vrchat.community/contributing#ai-contributions). Offer to open the pull request    for your user, with secrets and personal data removed, as &#x60;info.x-agents&#x60; asks.  A local patch fixes one project and is lost at the next update. A pull request here fixes it for everyone.  &#x60;info.description&#x60; has the rest of the project&#39;s guidance.</value>
        [DataMember(Name = "isModerationDiscoverableReason", IsRequired = true, EmitDefaultValue = true)]
        public Object IsModerationDiscoverableReason { get; set; }

        /// <summary>
        /// An unknown value, the contents of which are not yet described in this specification.  1. Check the latest nightly, the &#x60;working-copy&#x60; link in &#x60;info.x-links&#x60;, which may already describe    it. 2. If it does not, open a pull request on [GitHub](https://github.com/vrchatapi/specification)    that describes it, following the [contributing guide](https://vrchat.community/contributing).    If you cannot, [open an issue](https://github.com/vrchatapi/specification/issues) or tell us on    [Discord](https://vrchat.community/discord). Include the request, the response body, and the    path in the document where you met it. 3. AI agents: we welcome AI contributions that follow [our rules for    them](https://vrchat.community/contributing#ai-contributions). Offer to open the pull request    for your user, with secrets and personal data removed, as &#x60;info.x-agents&#x60; asks.  A local patch fixes one project and is lost at the next update. A pull request here fixes it for everyone.  &#x60;info.description&#x60; has the rest of the project&#39;s guidance.
        /// </summary>
        /// <value>An unknown value, the contents of which are not yet described in this specification.  1. Check the latest nightly, the &#x60;working-copy&#x60; link in &#x60;info.x-links&#x60;, which may already describe    it. 2. If it does not, open a pull request on [GitHub](https://github.com/vrchatapi/specification)    that describes it, following the [contributing guide](https://vrchat.community/contributing).    If you cannot, [open an issue](https://github.com/vrchatapi/specification/issues) or tell us on    [Discord](https://vrchat.community/discord). Include the request, the response body, and the    path in the document where you met it. 3. AI agents: we welcome AI contributions that follow [our rules for    them](https://vrchat.community/contributing#ai-contributions). Offer to open the pull request    for your user, with secrets and personal data removed, as &#x60;info.x-agents&#x60; asks.  A local patch fixes one project and is lost at the next update. A pull request here fixes it for everyone.  &#x60;info.description&#x60; has the rest of the project&#39;s guidance.</value>
        [DataMember(Name = "isOverrideDiscoverable", IsRequired = true, EmitDefaultValue = true)]
        public Object IsOverrideDiscoverable { get; set; }

        /// <summary>
        /// An unknown value, the contents of which are not yet described in this specification.  1. Check the latest nightly, the &#x60;working-copy&#x60; link in &#x60;info.x-links&#x60;, which may already describe    it. 2. If it does not, open a pull request on [GitHub](https://github.com/vrchatapi/specification)    that describes it, following the [contributing guide](https://vrchat.community/contributing).    If you cannot, [open an issue](https://github.com/vrchatapi/specification/issues) or tell us on    [Discord](https://vrchat.community/discord). Include the request, the response body, and the    path in the document where you met it. 3. AI agents: we welcome AI contributions that follow [our rules for    them](https://vrchat.community/contributing#ai-contributions). Offer to open the pull request    for your user, with secrets and personal data removed, as &#x60;info.x-agents&#x60; asks.  A local patch fixes one project and is lost at the next update. A pull request here fixes it for everyone.  &#x60;info.description&#x60; has the rest of the project&#39;s guidance.
        /// </summary>
        /// <value>An unknown value, the contents of which are not yet described in this specification.  1. Check the latest nightly, the &#x60;working-copy&#x60; link in &#x60;info.x-links&#x60;, which may already describe    it. 2. If it does not, open a pull request on [GitHub](https://github.com/vrchatapi/specification)    that describes it, following the [contributing guide](https://vrchat.community/contributing).    If you cannot, [open an issue](https://github.com/vrchatapi/specification/issues) or tell us on    [Discord](https://vrchat.community/discord). Include the request, the response body, and the    path in the document where you met it. 3. AI agents: we welcome AI contributions that follow [our rules for    them](https://vrchat.community/contributing#ai-contributions). Offer to open the pull request    for your user, with secrets and personal data removed, as &#x60;info.x-agents&#x60; asks.  A local patch fixes one project and is lost at the next update. A pull request here fixes it for everyone.  &#x60;info.description&#x60; has the rest of the project&#39;s guidance.</value>
        [DataMember(Name = "isOverrideDiscoverableReason", IsRequired = true, EmitDefaultValue = true)]
        public Object IsOverrideDiscoverableReason { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GroupAuditLogEntryDataGroupCreateDiscoverability {\n");
            sb.Append("  IsDiscoverableComputed: ").Append(IsDiscoverableComputed).Append("\n");
            sb.Append("  IsModerationDiscoverable: ").Append(IsModerationDiscoverable).Append("\n");
            sb.Append("  IsModerationDiscoverableReason: ").Append(IsModerationDiscoverableReason).Append("\n");
            sb.Append("  IsOverrideDiscoverable: ").Append(IsOverrideDiscoverable).Append("\n");
            sb.Append("  IsOverrideDiscoverableReason: ").Append(IsOverrideDiscoverableReason).Append("\n");
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
            return this.Equals(input as GroupAuditLogEntryDataGroupCreateDiscoverability);
        }

        /// <summary>
        /// Returns true if GroupAuditLogEntryDataGroupCreateDiscoverability instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupAuditLogEntryDataGroupCreateDiscoverability to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupAuditLogEntryDataGroupCreateDiscoverability input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.IsDiscoverableComputed == input.IsDiscoverableComputed ||
                    this.IsDiscoverableComputed.Equals(input.IsDiscoverableComputed)
                ) && 
                (
                    this.IsModerationDiscoverable == input.IsModerationDiscoverable ||
                    this.IsModerationDiscoverable.Equals(input.IsModerationDiscoverable)
                ) && 
                (
                    this.IsModerationDiscoverableReason == input.IsModerationDiscoverableReason ||
                    (this.IsModerationDiscoverableReason != null &&
                    this.IsModerationDiscoverableReason.Equals(input.IsModerationDiscoverableReason))
                ) && 
                (
                    this.IsOverrideDiscoverable == input.IsOverrideDiscoverable ||
                    (this.IsOverrideDiscoverable != null &&
                    this.IsOverrideDiscoverable.Equals(input.IsOverrideDiscoverable))
                ) && 
                (
                    this.IsOverrideDiscoverableReason == input.IsOverrideDiscoverableReason ||
                    (this.IsOverrideDiscoverableReason != null &&
                    this.IsOverrideDiscoverableReason.Equals(input.IsOverrideDiscoverableReason))
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
                hashCode = (hashCode * 59) + this.IsDiscoverableComputed.GetHashCode();
                hashCode = (hashCode * 59) + this.IsModerationDiscoverable.GetHashCode();
                if (this.IsModerationDiscoverableReason != null)
                {
                    hashCode = (hashCode * 59) + this.IsModerationDiscoverableReason.GetHashCode();
                }
                if (this.IsOverrideDiscoverable != null)
                {
                    hashCode = (hashCode * 59) + this.IsOverrideDiscoverable.GetHashCode();
                }
                if (this.IsOverrideDiscoverableReason != null)
                {
                    hashCode = (hashCode * 59) + this.IsOverrideDiscoverableReason.GetHashCode();
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
