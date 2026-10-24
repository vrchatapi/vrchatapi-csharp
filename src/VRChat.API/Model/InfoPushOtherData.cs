

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
    /// InfoPushOtherData
    /// </summary>
    [DataContract(Name = "InfoPushOtherData")]
    public partial class InfoPushOtherData : IEquatable<InfoPushOtherData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InfoPushOtherData" /> class.
        /// </summary>
        /// <param name="body">body.</param>
        /// <param name="cta">cta.</param>
        /// <param name="deliveryBehavior">deliveryBehavior.</param>
        /// <param name="imageFileId">imageFileId.</param>
        /// <param name="mediaType">mediaType.</param>
        /// <param name="promotion">promotion.</param>
        /// <param name="showInWorldIds">An unknown value, the contents of which are not yet described in this specification.  1. Check the latest nightly, the &#x60;working-copy&#x60; link in &#x60;info.x-links&#x60;, which may already describe    it. 2. If it does not, open a pull request on [GitHub](https://github.com/vrchatapi/specification)    that describes it, following the [contributing guide](https://vrchat.community/contributing).    If you cannot, [open an issue](https://github.com/vrchatapi/specification/issues) or tell us on    [Discord](https://vrchat.community/discord). Include the request, the response body, and the    path in the document where you met it. 3. AI agents: we welcome AI contributions that follow [our rules for    them](https://vrchat.community/contributing#ai-contributions). Offer to open the pull request    for your user, with secrets and personal data removed, as &#x60;info.x-agents&#x60; asks.  A local patch fixes one project and is lost at the next update. A pull request here fixes it for everyone.  &#x60;info.description&#x60; has the rest of the project&#39;s guidance..</param>
        /// <param name="template">template.</param>
        /// <param name="videoFileId">videoFileId.</param>
        /// <param name="videoUrl">videoUrl.</param>
        public InfoPushOtherData(string body = default, InfoPushDataCallToAction cta = default, InfoPushDataDeliveryBehavior deliveryBehavior = default, string imageFileId = default, string mediaType = default, InfoPushDataPromotion promotion = default, Object showInWorldIds = default, string template = default, string videoFileId = default, string videoUrl = default)
        {
            this.Body = body;
            this.Cta = cta;
            this.DeliveryBehavior = deliveryBehavior;
            this.ImageFileId = imageFileId;
            this.MediaType = mediaType;
            this.Promotion = promotion;
            this.ShowInWorldIds = showInWorldIds;
            this.Template = template;
            this.VideoFileId = videoFileId;
            this.VideoUrl = videoUrl;
        }

        /// <summary>
        /// Gets or Sets Body
        /// </summary>
        [DataMember(Name = "body", EmitDefaultValue = false)]
        public string Body { get; set; }

        /// <summary>
        /// Gets or Sets Cta
        /// </summary>
        [DataMember(Name = "cta", EmitDefaultValue = false)]
        public InfoPushDataCallToAction Cta { get; set; }

        /// <summary>
        /// Gets or Sets DeliveryBehavior
        /// </summary>
        [DataMember(Name = "deliveryBehavior", EmitDefaultValue = false)]
        public InfoPushDataDeliveryBehavior DeliveryBehavior { get; set; }

        /// <summary>
        /// Gets or Sets ImageFileId
        /// </summary>
        [DataMember(Name = "imageFileId", EmitDefaultValue = false)]
        public string ImageFileId { get; set; }

        /// <summary>
        /// Gets or Sets MediaType
        /// </summary>
        [DataMember(Name = "mediaType", EmitDefaultValue = false)]
        public string MediaType { get; set; }

        /// <summary>
        /// Gets or Sets Promotion
        /// </summary>
        [DataMember(Name = "promotion", EmitDefaultValue = false)]
        public InfoPushDataPromotion Promotion { get; set; }

        /// <summary>
        /// An unknown value, the contents of which are not yet described in this specification.  1. Check the latest nightly, the &#x60;working-copy&#x60; link in &#x60;info.x-links&#x60;, which may already describe    it. 2. If it does not, open a pull request on [GitHub](https://github.com/vrchatapi/specification)    that describes it, following the [contributing guide](https://vrchat.community/contributing).    If you cannot, [open an issue](https://github.com/vrchatapi/specification/issues) or tell us on    [Discord](https://vrchat.community/discord). Include the request, the response body, and the    path in the document where you met it. 3. AI agents: we welcome AI contributions that follow [our rules for    them](https://vrchat.community/contributing#ai-contributions). Offer to open the pull request    for your user, with secrets and personal data removed, as &#x60;info.x-agents&#x60; asks.  A local patch fixes one project and is lost at the next update. A pull request here fixes it for everyone.  &#x60;info.description&#x60; has the rest of the project&#39;s guidance.
        /// </summary>
        /// <value>An unknown value, the contents of which are not yet described in this specification.  1. Check the latest nightly, the &#x60;working-copy&#x60; link in &#x60;info.x-links&#x60;, which may already describe    it. 2. If it does not, open a pull request on [GitHub](https://github.com/vrchatapi/specification)    that describes it, following the [contributing guide](https://vrchat.community/contributing).    If you cannot, [open an issue](https://github.com/vrchatapi/specification/issues) or tell us on    [Discord](https://vrchat.community/discord). Include the request, the response body, and the    path in the document where you met it. 3. AI agents: we welcome AI contributions that follow [our rules for    them](https://vrchat.community/contributing#ai-contributions). Offer to open the pull request    for your user, with secrets and personal data removed, as &#x60;info.x-agents&#x60; asks.  A local patch fixes one project and is lost at the next update. A pull request here fixes it for everyone.  &#x60;info.description&#x60; has the rest of the project&#39;s guidance.</value>
        [DataMember(Name = "showInWorldIds", EmitDefaultValue = true)]
        public Object ShowInWorldIds { get; set; }

        /// <summary>
        /// Gets or Sets Template
        /// </summary>
        [DataMember(Name = "template", EmitDefaultValue = false)]
        public string Template { get; set; }

        /// <summary>
        /// Gets or Sets VideoFileId
        /// </summary>
        [DataMember(Name = "videoFileId", EmitDefaultValue = false)]
        public string VideoFileId { get; set; }

        /// <summary>
        /// Gets or Sets VideoUrl
        /// </summary>
        [DataMember(Name = "videoUrl", EmitDefaultValue = false)]
        public string VideoUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InfoPushOtherData {\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  Cta: ").Append(Cta).Append("\n");
            sb.Append("  DeliveryBehavior: ").Append(DeliveryBehavior).Append("\n");
            sb.Append("  ImageFileId: ").Append(ImageFileId).Append("\n");
            sb.Append("  MediaType: ").Append(MediaType).Append("\n");
            sb.Append("  Promotion: ").Append(Promotion).Append("\n");
            sb.Append("  ShowInWorldIds: ").Append(ShowInWorldIds).Append("\n");
            sb.Append("  Template: ").Append(Template).Append("\n");
            sb.Append("  VideoFileId: ").Append(VideoFileId).Append("\n");
            sb.Append("  VideoUrl: ").Append(VideoUrl).Append("\n");
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
            return this.Equals(input as InfoPushOtherData);
        }

        /// <summary>
        /// Returns true if InfoPushOtherData instances are equal
        /// </summary>
        /// <param name="input">Instance of InfoPushOtherData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InfoPushOtherData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
                ) && 
                (
                    this.Cta == input.Cta ||
                    (this.Cta != null &&
                    this.Cta.Equals(input.Cta))
                ) && 
                (
                    this.DeliveryBehavior == input.DeliveryBehavior ||
                    (this.DeliveryBehavior != null &&
                    this.DeliveryBehavior.Equals(input.DeliveryBehavior))
                ) && 
                (
                    this.ImageFileId == input.ImageFileId ||
                    (this.ImageFileId != null &&
                    this.ImageFileId.Equals(input.ImageFileId))
                ) && 
                (
                    this.MediaType == input.MediaType ||
                    (this.MediaType != null &&
                    this.MediaType.Equals(input.MediaType))
                ) && 
                (
                    this.Promotion == input.Promotion ||
                    (this.Promotion != null &&
                    this.Promotion.Equals(input.Promotion))
                ) && 
                (
                    this.ShowInWorldIds == input.ShowInWorldIds ||
                    (this.ShowInWorldIds != null &&
                    this.ShowInWorldIds.Equals(input.ShowInWorldIds))
                ) && 
                (
                    this.Template == input.Template ||
                    (this.Template != null &&
                    this.Template.Equals(input.Template))
                ) && 
                (
                    this.VideoFileId == input.VideoFileId ||
                    (this.VideoFileId != null &&
                    this.VideoFileId.Equals(input.VideoFileId))
                ) && 
                (
                    this.VideoUrl == input.VideoUrl ||
                    (this.VideoUrl != null &&
                    this.VideoUrl.Equals(input.VideoUrl))
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
                if (this.Body != null)
                {
                    hashCode = (hashCode * 59) + this.Body.GetHashCode();
                }
                if (this.Cta != null)
                {
                    hashCode = (hashCode * 59) + this.Cta.GetHashCode();
                }
                if (this.DeliveryBehavior != null)
                {
                    hashCode = (hashCode * 59) + this.DeliveryBehavior.GetHashCode();
                }
                if (this.ImageFileId != null)
                {
                    hashCode = (hashCode * 59) + this.ImageFileId.GetHashCode();
                }
                if (this.MediaType != null)
                {
                    hashCode = (hashCode * 59) + this.MediaType.GetHashCode();
                }
                if (this.Promotion != null)
                {
                    hashCode = (hashCode * 59) + this.Promotion.GetHashCode();
                }
                if (this.ShowInWorldIds != null)
                {
                    hashCode = (hashCode * 59) + this.ShowInWorldIds.GetHashCode();
                }
                if (this.Template != null)
                {
                    hashCode = (hashCode * 59) + this.Template.GetHashCode();
                }
                if (this.VideoFileId != null)
                {
                    hashCode = (hashCode * 59) + this.VideoFileId.GetHashCode();
                }
                if (this.VideoUrl != null)
                {
                    hashCode = (hashCode * 59) + this.VideoUrl.GetHashCode();
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
