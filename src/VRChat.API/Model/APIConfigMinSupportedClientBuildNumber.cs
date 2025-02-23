/*
 * VRChat API Documentation
 *
 *
 * The version of the OpenAPI document: 1.19.1
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
    /// Minimum supported client build number for various platforms
    /// </summary>
    [DataContract(Name = "APIConfig_minSupportedClientBuildNumber")]
    public partial class APIConfigMinSupportedClientBuildNumber : IEquatable<APIConfigMinSupportedClientBuildNumber>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="APIConfigMinSupportedClientBuildNumber" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected APIConfigMinSupportedClientBuildNumber() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="APIConfigMinSupportedClientBuildNumber" /> class.
        /// </summary>
        /// <param name="appStore">appStore (required).</param>
        /// <param name="_default">_default (required).</param>
        /// <param name="firebase">firebase (required).</param>
        /// <param name="firebaseiOS">firebaseiOS (required).</param>
        /// <param name="googlePlay">googlePlay (required).</param>
        /// <param name="pC">pC (required).</param>
        /// <param name="picoStore">picoStore (required).</param>
        /// <param name="questAppLab">questAppLab (required).</param>
        /// <param name="questStore">questStore (required).</param>
        /// <param name="testFlight">testFlight (required).</param>
        /// <param name="xRElite">xRElite (required).</param>
        public APIConfigMinSupportedClientBuildNumber(PlatformBuildInfo appStore = default(PlatformBuildInfo), PlatformBuildInfo _default = default(PlatformBuildInfo), PlatformBuildInfo firebase = default(PlatformBuildInfo), PlatformBuildInfo firebaseiOS = default(PlatformBuildInfo), PlatformBuildInfo googlePlay = default(PlatformBuildInfo), PlatformBuildInfo pC = default(PlatformBuildInfo), PlatformBuildInfo picoStore = default(PlatformBuildInfo), PlatformBuildInfo questAppLab = default(PlatformBuildInfo), PlatformBuildInfo questStore = default(PlatformBuildInfo), PlatformBuildInfo testFlight = default(PlatformBuildInfo), PlatformBuildInfo xRElite = default(PlatformBuildInfo))
        {
            // to ensure "appStore" is required (not null)
            if (appStore == null)
            {
                throw new ArgumentNullException("appStore is a required property for APIConfigMinSupportedClientBuildNumber and cannot be null");
            }
            this.AppStore = appStore;
            // to ensure "_default" is required (not null)
            if (_default == null)
            {
                throw new ArgumentNullException("_default is a required property for APIConfigMinSupportedClientBuildNumber and cannot be null");
            }
            this.Default = _default;
            // to ensure "firebase" is required (not null)
            if (firebase == null)
            {
                throw new ArgumentNullException("firebase is a required property for APIConfigMinSupportedClientBuildNumber and cannot be null");
            }
            this.Firebase = firebase;
            // to ensure "firebaseiOS" is required (not null)
            if (firebaseiOS == null)
            {
                throw new ArgumentNullException("firebaseiOS is a required property for APIConfigMinSupportedClientBuildNumber and cannot be null");
            }
            this.FirebaseiOS = firebaseiOS;
            // to ensure "googlePlay" is required (not null)
            if (googlePlay == null)
            {
                throw new ArgumentNullException("googlePlay is a required property for APIConfigMinSupportedClientBuildNumber and cannot be null");
            }
            this.GooglePlay = googlePlay;
            // to ensure "pC" is required (not null)
            if (pC == null)
            {
                throw new ArgumentNullException("pC is a required property for APIConfigMinSupportedClientBuildNumber and cannot be null");
            }
            this.PC = pC;
            // to ensure "picoStore" is required (not null)
            if (picoStore == null)
            {
                throw new ArgumentNullException("picoStore is a required property for APIConfigMinSupportedClientBuildNumber and cannot be null");
            }
            this.PicoStore = picoStore;
            // to ensure "questAppLab" is required (not null)
            if (questAppLab == null)
            {
                throw new ArgumentNullException("questAppLab is a required property for APIConfigMinSupportedClientBuildNumber and cannot be null");
            }
            this.QuestAppLab = questAppLab;
            // to ensure "questStore" is required (not null)
            if (questStore == null)
            {
                throw new ArgumentNullException("questStore is a required property for APIConfigMinSupportedClientBuildNumber and cannot be null");
            }
            this.QuestStore = questStore;
            // to ensure "testFlight" is required (not null)
            if (testFlight == null)
            {
                throw new ArgumentNullException("testFlight is a required property for APIConfigMinSupportedClientBuildNumber and cannot be null");
            }
            this.TestFlight = testFlight;
            // to ensure "xRElite" is required (not null)
            if (xRElite == null)
            {
                throw new ArgumentNullException("xRElite is a required property for APIConfigMinSupportedClientBuildNumber and cannot be null");
            }
            this.XRElite = xRElite;
        }

        /// <summary>
        /// Gets or Sets AppStore
        /// </summary>
        [DataMember(Name = "AppStore", IsRequired = true, EmitDefaultValue = true)]
        public PlatformBuildInfo AppStore { get; set; }

        /// <summary>
        /// Gets or Sets Default
        /// </summary>
        [DataMember(Name = "Default", IsRequired = true, EmitDefaultValue = true)]
        public PlatformBuildInfo Default { get; set; }

        /// <summary>
        /// Gets or Sets Firebase
        /// </summary>
        [DataMember(Name = "Firebase", IsRequired = true, EmitDefaultValue = true)]
        public PlatformBuildInfo Firebase { get; set; }

        /// <summary>
        /// Gets or Sets FirebaseiOS
        /// </summary>
        [DataMember(Name = "FirebaseiOS", IsRequired = true, EmitDefaultValue = true)]
        public PlatformBuildInfo FirebaseiOS { get; set; }

        /// <summary>
        /// Gets or Sets GooglePlay
        /// </summary>
        [DataMember(Name = "GooglePlay", IsRequired = true, EmitDefaultValue = true)]
        public PlatformBuildInfo GooglePlay { get; set; }

        /// <summary>
        /// Gets or Sets PC
        /// </summary>
        [DataMember(Name = "PC", IsRequired = true, EmitDefaultValue = true)]
        public PlatformBuildInfo PC { get; set; }

        /// <summary>
        /// Gets or Sets PicoStore
        /// </summary>
        [DataMember(Name = "PicoStore", IsRequired = true, EmitDefaultValue = true)]
        public PlatformBuildInfo PicoStore { get; set; }

        /// <summary>
        /// Gets or Sets QuestAppLab
        /// </summary>
        [DataMember(Name = "QuestAppLab", IsRequired = true, EmitDefaultValue = true)]
        public PlatformBuildInfo QuestAppLab { get; set; }

        /// <summary>
        /// Gets or Sets QuestStore
        /// </summary>
        [DataMember(Name = "QuestStore", IsRequired = true, EmitDefaultValue = true)]
        public PlatformBuildInfo QuestStore { get; set; }

        /// <summary>
        /// Gets or Sets TestFlight
        /// </summary>
        [DataMember(Name = "TestFlight", IsRequired = true, EmitDefaultValue = true)]
        public PlatformBuildInfo TestFlight { get; set; }

        /// <summary>
        /// Gets or Sets XRElite
        /// </summary>
        [DataMember(Name = "XRElite", IsRequired = true, EmitDefaultValue = true)]
        public PlatformBuildInfo XRElite { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class APIConfigMinSupportedClientBuildNumber {\n");
            sb.Append("  AppStore: ").Append(AppStore).Append("\n");
            sb.Append("  Default: ").Append(Default).Append("\n");
            sb.Append("  Firebase: ").Append(Firebase).Append("\n");
            sb.Append("  FirebaseiOS: ").Append(FirebaseiOS).Append("\n");
            sb.Append("  GooglePlay: ").Append(GooglePlay).Append("\n");
            sb.Append("  PC: ").Append(PC).Append("\n");
            sb.Append("  PicoStore: ").Append(PicoStore).Append("\n");
            sb.Append("  QuestAppLab: ").Append(QuestAppLab).Append("\n");
            sb.Append("  QuestStore: ").Append(QuestStore).Append("\n");
            sb.Append("  TestFlight: ").Append(TestFlight).Append("\n");
            sb.Append("  XRElite: ").Append(XRElite).Append("\n");
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
            return this.Equals(input as APIConfigMinSupportedClientBuildNumber);
        }

        /// <summary>
        /// Returns true if APIConfigMinSupportedClientBuildNumber instances are equal
        /// </summary>
        /// <param name="input">Instance of APIConfigMinSupportedClientBuildNumber to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(APIConfigMinSupportedClientBuildNumber input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AppStore == input.AppStore ||
                    (this.AppStore != null &&
                    this.AppStore.Equals(input.AppStore))
                ) && 
                (
                    this.Default == input.Default ||
                    (this.Default != null &&
                    this.Default.Equals(input.Default))
                ) && 
                (
                    this.Firebase == input.Firebase ||
                    (this.Firebase != null &&
                    this.Firebase.Equals(input.Firebase))
                ) && 
                (
                    this.FirebaseiOS == input.FirebaseiOS ||
                    (this.FirebaseiOS != null &&
                    this.FirebaseiOS.Equals(input.FirebaseiOS))
                ) && 
                (
                    this.GooglePlay == input.GooglePlay ||
                    (this.GooglePlay != null &&
                    this.GooglePlay.Equals(input.GooglePlay))
                ) && 
                (
                    this.PC == input.PC ||
                    (this.PC != null &&
                    this.PC.Equals(input.PC))
                ) && 
                (
                    this.PicoStore == input.PicoStore ||
                    (this.PicoStore != null &&
                    this.PicoStore.Equals(input.PicoStore))
                ) && 
                (
                    this.QuestAppLab == input.QuestAppLab ||
                    (this.QuestAppLab != null &&
                    this.QuestAppLab.Equals(input.QuestAppLab))
                ) && 
                (
                    this.QuestStore == input.QuestStore ||
                    (this.QuestStore != null &&
                    this.QuestStore.Equals(input.QuestStore))
                ) && 
                (
                    this.TestFlight == input.TestFlight ||
                    (this.TestFlight != null &&
                    this.TestFlight.Equals(input.TestFlight))
                ) && 
                (
                    this.XRElite == input.XRElite ||
                    (this.XRElite != null &&
                    this.XRElite.Equals(input.XRElite))
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
                if (this.AppStore != null)
                {
                    hashCode = (hashCode * 59) + this.AppStore.GetHashCode();
                }
                if (this.Default != null)
                {
                    hashCode = (hashCode * 59) + this.Default.GetHashCode();
                }
                if (this.Firebase != null)
                {
                    hashCode = (hashCode * 59) + this.Firebase.GetHashCode();
                }
                if (this.FirebaseiOS != null)
                {
                    hashCode = (hashCode * 59) + this.FirebaseiOS.GetHashCode();
                }
                if (this.GooglePlay != null)
                {
                    hashCode = (hashCode * 59) + this.GooglePlay.GetHashCode();
                }
                if (this.PC != null)
                {
                    hashCode = (hashCode * 59) + this.PC.GetHashCode();
                }
                if (this.PicoStore != null)
                {
                    hashCode = (hashCode * 59) + this.PicoStore.GetHashCode();
                }
                if (this.QuestAppLab != null)
                {
                    hashCode = (hashCode * 59) + this.QuestAppLab.GetHashCode();
                }
                if (this.QuestStore != null)
                {
                    hashCode = (hashCode * 59) + this.QuestStore.GetHashCode();
                }
                if (this.TestFlight != null)
                {
                    hashCode = (hashCode * 59) + this.TestFlight.GetHashCode();
                }
                if (this.XRElite != null)
                {
                    hashCode = (hashCode * 59) + this.XRElite.GetHashCode();
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
            yield break;
        }
    }

}
