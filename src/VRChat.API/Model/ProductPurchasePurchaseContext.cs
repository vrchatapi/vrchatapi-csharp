

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
    /// ProductPurchasePurchaseContext
    /// </summary>
    [DataContract(Name = "ProductPurchase_purchaseContext")]
    public partial class ProductPurchasePurchaseContext : IEquatable<ProductPurchasePurchaseContext>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductPurchasePurchaseContext" /> class.
        /// </summary>
        /// <param name="locationType">locationType.</param>
        /// <param name="worldId">WorldID be \&quot;offline\&quot; on User profiles if you are not friends with that user..</param>
        /// <param name="worldName">worldName.</param>
        public ProductPurchasePurchaseContext(string locationType = default, string worldId = default, string worldName = default)
        {
            this.LocationType = locationType;
            this.WorldId = worldId;
            this.WorldName = worldName;
        }

        /// <summary>
        /// Gets or Sets LocationType
        /// </summary>
        /*
        <example>undefined</example>
        */
        [DataMember(Name = "locationType", EmitDefaultValue = false)]
        public string LocationType { get; set; }

        /// <summary>
        /// WorldID be \&quot;offline\&quot; on User profiles if you are not friends with that user.
        /// </summary>
        /// <value>WorldID be \&quot;offline\&quot; on User profiles if you are not friends with that user.</value>
        /*
        <example>wrld_4432ea9b-729c-46e3-8eaf-846aa0a37fdd</example>
        */
        [DataMember(Name = "worldId", EmitDefaultValue = false)]
        public string WorldId { get; set; }

        /// <summary>
        /// Gets or Sets WorldName
        /// </summary>
        [DataMember(Name = "worldName", EmitDefaultValue = false)]
        public string WorldName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProductPurchasePurchaseContext {\n");
            sb.Append("  LocationType: ").Append(LocationType).Append("\n");
            sb.Append("  WorldId: ").Append(WorldId).Append("\n");
            sb.Append("  WorldName: ").Append(WorldName).Append("\n");
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
            return this.Equals(input as ProductPurchasePurchaseContext);
        }

        /// <summary>
        /// Returns true if ProductPurchasePurchaseContext instances are equal
        /// </summary>
        /// <param name="input">Instance of ProductPurchasePurchaseContext to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductPurchasePurchaseContext input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.LocationType == input.LocationType ||
                    (this.LocationType != null &&
                    this.LocationType.Equals(input.LocationType))
                ) && 
                (
                    this.WorldId == input.WorldId ||
                    (this.WorldId != null &&
                    this.WorldId.Equals(input.WorldId))
                ) && 
                (
                    this.WorldName == input.WorldName ||
                    (this.WorldName != null &&
                    this.WorldName.Equals(input.WorldName))
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
                if (this.LocationType != null)
                {
                    hashCode = (hashCode * 59) + this.LocationType.GetHashCode();
                }
                if (this.WorldId != null)
                {
                    hashCode = (hashCode * 59) + this.WorldId.GetHashCode();
                }
                if (this.WorldName != null)
                {
                    hashCode = (hashCode * 59) + this.WorldName.GetHashCode();
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
