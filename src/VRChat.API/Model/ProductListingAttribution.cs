

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
    /// Attribution shown alongside a listing.
    /// </summary>
    [DataContract(Name = "ProductListingAttribution")]
    public partial class ProductListingAttribution : IEquatable<ProductListingAttribution>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductListingAttribution" /> class.
        /// </summary>
        /// <param name="creator">creator.</param>
        /// <param name="publisher">publisher.</param>
        public ProductListingAttribution(ProductListingAttributionCreator creator = default, ProductListingAttributionCreator publisher = default)
        {
            this.Creator = creator;
            this.Publisher = publisher;
        }

        /// <summary>
        /// Gets or Sets Creator
        /// </summary>
        [DataMember(Name = "creator", EmitDefaultValue = false)]
        public ProductListingAttributionCreator Creator { get; set; }

        /// <summary>
        /// Gets or Sets Publisher
        /// </summary>
        [DataMember(Name = "publisher", EmitDefaultValue = false)]
        public ProductListingAttributionCreator Publisher { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProductListingAttribution {\n");
            sb.Append("  Creator: ").Append(Creator).Append("\n");
            sb.Append("  Publisher: ").Append(Publisher).Append("\n");
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
            return this.Equals(input as ProductListingAttribution);
        }

        /// <summary>
        /// Returns true if ProductListingAttribution instances are equal
        /// </summary>
        /// <param name="input">Instance of ProductListingAttribution to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductListingAttribution input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Creator == input.Creator ||
                    (this.Creator != null &&
                    this.Creator.Equals(input.Creator))
                ) && 
                (
                    this.Publisher == input.Publisher ||
                    (this.Publisher != null &&
                    this.Publisher.Equals(input.Publisher))
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
                if (this.Creator != null)
                {
                    hashCode = (hashCode * 59) + this.Creator.GetHashCode();
                }
                if (this.Publisher != null)
                {
                    hashCode = (hashCode * 59) + this.Publisher.GetHashCode();
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
