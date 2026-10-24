

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
    /// DynamicContentRowInstances
    /// </summary>
    [DataContract(Name = "DynamicContentRowInstances")]
    public partial class DynamicContentRowInstances : IEquatable<DynamicContentRowInstances>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Mode
        /// </summary>
        [DataMember(Name = "mode", IsRequired = true, EmitDefaultValue = true)]
        public InstanceDiscoveryMode Mode { get; set; }

        /// <summary>
        /// Gets or Sets Region
        /// </summary>
        [DataMember(Name = "region", IsRequired = true, EmitDefaultValue = true)]
        public InstanceRegion Region { get; set; }
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Instances for value: instances
            /// </summary>
            [EnumMember(Value = "instances")]
            Instances = 1
        }


        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public TypeEnum Type { get; set; }

        /// <summary>
        /// Gets or Sets WorldPool
        /// </summary>
        [DataMember(Name = "worldPool", EmitDefaultValue = false)]
        public InstanceDiscoveryWorldPool? WorldPool { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicContentRowInstances" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DynamicContentRowInstances() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicContentRowInstances" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="platform">Usually \&quot;ThisPlatformSupported\&quot;, but can also be other values such as \&quot;all\&quot; or platform specific identifiers. (required).</param>
        /// <param name="groupPool">groupPool.</param>
        /// <param name="minOccupants">minOccupants (required).</param>
        /// <param name="mode">mode (required).</param>
        /// <param name="n">n (required).</param>
        /// <param name="varParams">varParams (required).</param>
        /// <param name="region">region (required).</param>
        /// <param name="type">type (required).</param>
        /// <param name="worldPool">worldPool.</param>
        public DynamicContentRowInstances(LocalizableString name = default, string platform = default, string groupPool = default, int minOccupants = default, InstanceDiscoveryMode mode = default, int n = default, Dictionary<string, Object> varParams = default, InstanceRegion region = default, TypeEnum type = default, InstanceDiscoveryWorldPool? worldPool = default)
        {
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Name = name;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Platform = platform;
            this.MinOccupants = minOccupants;
            this.Mode = mode;
            this.N = n;
            // Allow null values for required properties to handle unexpected API responses gracefully
            this.Params = varParams;
            this.Region = region;
            this.Type = type;
            this.GroupPool = groupPool;
            this.WorldPool = worldPool;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public LocalizableString Name { get; set; }

        /// <summary>
        /// Usually \&quot;ThisPlatformSupported\&quot;, but can also be other values such as \&quot;all\&quot; or platform specific identifiers.
        /// </summary>
        /// <value>Usually \&quot;ThisPlatformSupported\&quot;, but can also be other values such as \&quot;all\&quot; or platform specific identifiers.</value>
        [DataMember(Name = "platform", IsRequired = true, EmitDefaultValue = true)]
        public string Platform { get; set; }

        /// <summary>
        /// Gets or Sets GroupPool
        /// </summary>
        [DataMember(Name = "groupPool", EmitDefaultValue = false)]
        public string GroupPool { get; set; }

        /// <summary>
        /// Gets or Sets MinOccupants
        /// </summary>
        [DataMember(Name = "minOccupants", IsRequired = true, EmitDefaultValue = true)]
        public int MinOccupants { get; set; }

        /// <summary>
        /// Gets or Sets N
        /// </summary>
        [DataMember(Name = "n", IsRequired = true, EmitDefaultValue = true)]
        public int N { get; set; }

        /// <summary>
        /// Gets or Sets Params
        /// </summary>
        [DataMember(Name = "params", IsRequired = true, EmitDefaultValue = true)]
        public Dictionary<string, Object> Params { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DynamicContentRowInstances {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
            sb.Append("  GroupPool: ").Append(GroupPool).Append("\n");
            sb.Append("  MinOccupants: ").Append(MinOccupants).Append("\n");
            sb.Append("  Mode: ").Append(Mode).Append("\n");
            sb.Append("  N: ").Append(N).Append("\n");
            sb.Append("  Params: ").Append(Params).Append("\n");
            sb.Append("  Region: ").Append(Region).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  WorldPool: ").Append(WorldPool).Append("\n");
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
            return this.Equals(input as DynamicContentRowInstances);
        }

        /// <summary>
        /// Returns true if DynamicContentRowInstances instances are equal
        /// </summary>
        /// <param name="input">Instance of DynamicContentRowInstances to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DynamicContentRowInstances input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Platform == input.Platform ||
                    (this.Platform != null &&
                    this.Platform.Equals(input.Platform))
                ) && 
                (
                    this.GroupPool == input.GroupPool ||
                    (this.GroupPool != null &&
                    this.GroupPool.Equals(input.GroupPool))
                ) && 
                (
                    this.MinOccupants == input.MinOccupants ||
                    this.MinOccupants.Equals(input.MinOccupants)
                ) && 
                (
                    this.Mode == input.Mode ||
                    this.Mode.Equals(input.Mode)
                ) && 
                (
                    this.N == input.N ||
                    this.N.Equals(input.N)
                ) && 
                (
                    this.Params == input.Params ||
                    this.Params != null &&
                    input.Params != null &&
                    this.Params.SequenceEqual(input.Params)
                ) && 
                (
                    this.Region == input.Region ||
                    this.Region.Equals(input.Region)
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.WorldPool == input.WorldPool ||
                    this.WorldPool.Equals(input.WorldPool)
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Platform != null)
                {
                    hashCode = (hashCode * 59) + this.Platform.GetHashCode();
                }
                if (this.GroupPool != null)
                {
                    hashCode = (hashCode * 59) + this.GroupPool.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.MinOccupants.GetHashCode();
                hashCode = (hashCode * 59) + this.Mode.GetHashCode();
                hashCode = (hashCode * 59) + this.N.GetHashCode();
                if (this.Params != null)
                {
                    hashCode = (hashCode * 59) + this.Params.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Region.GetHashCode();
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                hashCode = (hashCode * 59) + this.WorldPool.GetHashCode();
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
            // Platform (string) minLength
            if (this.Platform != null && this.Platform.Length < 1)
            {
                yield return new ValidationResult("Invalid value for Platform, length must be greater than 1.", new [] { "Platform" });
            }

            yield break;
        }
    }

}
