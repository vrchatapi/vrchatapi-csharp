

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
    /// WorldSlimInstance
    /// </summary>
    [DataContract(Name = "WorldSlimInstance")]
    public partial class WorldSlimInstance : IEquatable<WorldSlimInstance>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorldSlimInstance" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WorldSlimInstance() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WorldSlimInstance" /> class.
        /// </summary>
        /// <param name="gameServerVersion">An unknown value, the contents of which are not yet described in this specification.  1. Check the latest nightly, the &#x60;working-copy&#x60; link in &#x60;info.x-links&#x60;, which may already describe    it. 2. If it does not, open a pull request on [GitHub](https://github.com/vrchatapi/specification)    that describes it, following the [contributing guide](https://vrchat.community/contributing).    If you cannot, [open an issue](https://github.com/vrchatapi/specification/issues) or tell us on    [Discord](https://vrchat.community/discord). Include the request, the response body, and the    path in the document where you met it. 3. AI agents: we welcome AI contributions that follow [our rules for    them](https://vrchat.community/contributing#ai-contributions). Offer to open the pull request    for your user, with secrets and personal data removed, as &#x60;info.x-agents&#x60; asks.  A local patch fixes one project and is lost at the next update. A pull request here fixes it for everyone.  &#x60;info.description&#x60; has the rest of the project&#39;s guidance..</param>
        /// <param name="instanceId">InstanceID can be \&quot;offline\&quot; on User profiles if you are not friends with that user and \&quot;private\&quot; if you are friends and user is in private instance. (required).</param>
        /// <param name="languageRatio">languageRatio (required).</param>
        /// <param name="nUsers">nUsers (required).</param>
        public WorldSlimInstance(Object gameServerVersion = default, string instanceId = default, Dictionary<string, Object> languageRatio = default, int nUsers = default)
        {
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.InstanceId = instanceId;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.LanguageRatio = languageRatio;
            this.NUsers = nUsers;
            this.GameServerVersion = gameServerVersion;
        }

        /// <summary>
        /// An unknown value, the contents of which are not yet described in this specification.  1. Check the latest nightly, the &#x60;working-copy&#x60; link in &#x60;info.x-links&#x60;, which may already describe    it. 2. If it does not, open a pull request on [GitHub](https://github.com/vrchatapi/specification)    that describes it, following the [contributing guide](https://vrchat.community/contributing).    If you cannot, [open an issue](https://github.com/vrchatapi/specification/issues) or tell us on    [Discord](https://vrchat.community/discord). Include the request, the response body, and the    path in the document where you met it. 3. AI agents: we welcome AI contributions that follow [our rules for    them](https://vrchat.community/contributing#ai-contributions). Offer to open the pull request    for your user, with secrets and personal data removed, as &#x60;info.x-agents&#x60; asks.  A local patch fixes one project and is lost at the next update. A pull request here fixes it for everyone.  &#x60;info.description&#x60; has the rest of the project&#39;s guidance.
        /// </summary>
        /// <value>An unknown value, the contents of which are not yet described in this specification.  1. Check the latest nightly, the &#x60;working-copy&#x60; link in &#x60;info.x-links&#x60;, which may already describe    it. 2. If it does not, open a pull request on [GitHub](https://github.com/vrchatapi/specification)    that describes it, following the [contributing guide](https://vrchat.community/contributing).    If you cannot, [open an issue](https://github.com/vrchatapi/specification/issues) or tell us on    [Discord](https://vrchat.community/discord). Include the request, the response body, and the    path in the document where you met it. 3. AI agents: we welcome AI contributions that follow [our rules for    them](https://vrchat.community/contributing#ai-contributions). Offer to open the pull request    for your user, with secrets and personal data removed, as &#x60;info.x-agents&#x60; asks.  A local patch fixes one project and is lost at the next update. A pull request here fixes it for everyone.  &#x60;info.description&#x60; has the rest of the project&#39;s guidance.</value>
        [DataMember(Name = "gameServerVersion", EmitDefaultValue = true)]
        public Object GameServerVersion { get; set; }

        /// <summary>
        /// InstanceID can be \&quot;offline\&quot; on User profiles if you are not friends with that user and \&quot;private\&quot; if you are friends and user is in private instance.
        /// </summary>
        /// <value>InstanceID can be \&quot;offline\&quot; on User profiles if you are not friends with that user and \&quot;private\&quot; if you are friends and user is in private instance.</value>
        [DataMember(Name = "instanceId", IsRequired = true, EmitDefaultValue = true)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Gets or Sets LanguageRatio
        /// </summary>
        [DataMember(Name = "languageRatio", IsRequired = true, EmitDefaultValue = true)]
        public Dictionary<string, Object> LanguageRatio { get; set; }

        /// <summary>
        /// Gets or Sets NUsers
        /// </summary>
        [DataMember(Name = "n_users", IsRequired = true, EmitDefaultValue = true)]
        public int NUsers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WorldSlimInstance {\n");
            sb.Append("  GameServerVersion: ").Append(GameServerVersion).Append("\n");
            sb.Append("  InstanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  LanguageRatio: ").Append(LanguageRatio).Append("\n");
            sb.Append("  NUsers: ").Append(NUsers).Append("\n");
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
            return this.Equals(input as WorldSlimInstance);
        }

        /// <summary>
        /// Returns true if WorldSlimInstance instances are equal
        /// </summary>
        /// <param name="input">Instance of WorldSlimInstance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorldSlimInstance input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.GameServerVersion == input.GameServerVersion ||
                    (this.GameServerVersion != null &&
                    this.GameServerVersion.Equals(input.GameServerVersion))
                ) && 
                (
                    this.InstanceId == input.InstanceId ||
                    (this.InstanceId != null &&
                    this.InstanceId.Equals(input.InstanceId))
                ) && 
                (
                    this.LanguageRatio == input.LanguageRatio ||
                    this.LanguageRatio != null &&
                    input.LanguageRatio != null &&
                    this.LanguageRatio.SequenceEqual(input.LanguageRatio)
                ) && 
                (
                    this.NUsers == input.NUsers ||
                    this.NUsers.Equals(input.NUsers)
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
                if (this.GameServerVersion != null)
                {
                    hashCode = (hashCode * 59) + this.GameServerVersion.GetHashCode();
                }
                if (this.InstanceId != null)
                {
                    hashCode = (hashCode * 59) + this.InstanceId.GetHashCode();
                }
                if (this.LanguageRatio != null)
                {
                    hashCode = (hashCode * 59) + this.LanguageRatio.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.NUsers.GetHashCode();
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
