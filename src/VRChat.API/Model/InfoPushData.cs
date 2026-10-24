

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
using System.Reflection;

namespace VRChat.API.Model
{
    /// <summary>
    /// The data of an item without &#x60;type&#x60;. Its fields depend on the item&#39;s tags.
    /// </summary>
    [JsonConverter(typeof(InfoPushDataJsonConverter))]
    [DataContract(Name = "InfoPushData")]
    public partial class InfoPushData : AbstractOpenAPISchema, IEquatable<InfoPushData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InfoPushData" /> class
        /// with the <see cref="InfoPushOnboardingAvatarData" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of InfoPushOnboardingAvatarData.</param>
        public InfoPushData(InfoPushOnboardingAvatarData actualInstance)
        {
            IsNullable = false;
            SchemaType= "anyOf";
            ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InfoPushData" /> class
        /// with the <see cref="InfoPushHelpTopicData" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of InfoPushHelpTopicData.</param>
        public InfoPushData(InfoPushHelpTopicData actualInstance)
        {
            IsNullable = false;
            SchemaType= "anyOf";
            ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InfoPushData" /> class
        /// with the <see cref="InfoPushDiscoveryCategoryData" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of InfoPushDiscoveryCategoryData.</param>
        public InfoPushData(InfoPushDiscoveryCategoryData actualInstance)
        {
            IsNullable = false;
            SchemaType= "anyOf";
            ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InfoPushData" /> class
        /// with the <see cref="InfoPushHelpArticleData" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of InfoPushHelpArticleData.</param>
        public InfoPushData(InfoPushHelpArticleData actualInstance)
        {
            IsNullable = false;
            SchemaType= "anyOf";
            ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InfoPushData" /> class
        /// with the <see cref="InfoPushLoadingScreenBannerData" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of InfoPushLoadingScreenBannerData.</param>
        public InfoPushData(InfoPushLoadingScreenBannerData actualInstance)
        {
            IsNullable = false;
            SchemaType= "anyOf";
            ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InfoPushData" /> class
        /// with the <see cref="InfoPushMarketplacePageData" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of InfoPushMarketplacePageData.</param>
        public InfoPushData(InfoPushMarketplacePageData actualInstance)
        {
            IsNullable = false;
            SchemaType= "anyOf";
            ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InfoPushData" /> class
        /// with the <see cref="InfoPushWorldCategoryData" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of InfoPushWorldCategoryData.</param>
        public InfoPushData(InfoPushWorldCategoryData actualInstance)
        {
            IsNullable = false;
            SchemaType= "anyOf";
            ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InfoPushData" /> class
        /// with the <see cref="InfoPushUrlConsentScreenData" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of InfoPushUrlConsentScreenData.</param>
        public InfoPushData(InfoPushUrlConsentScreenData actualInstance)
        {
            IsNullable = false;
            SchemaType= "anyOf";
            ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InfoPushData" /> class
        /// with the <see cref="InfoPushAvatarCategoryData" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of InfoPushAvatarCategoryData.</param>
        public InfoPushData(InfoPushAvatarCategoryData actualInstance)
        {
            IsNullable = false;
            SchemaType= "anyOf";
            ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InfoPushData" /> class
        /// with the <see cref="InfoPushSearchData" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of InfoPushSearchData.</param>
        public InfoPushData(InfoPushSearchData actualInstance)
        {
            IsNullable = false;
            SchemaType= "anyOf";
            ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InfoPushData" /> class
        /// with the <see cref="InfoPushAccessoriesCategoryData" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of InfoPushAccessoriesCategoryData.</param>
        public InfoPushData(InfoPushAccessoriesCategoryData actualInstance)
        {
            IsNullable = false;
            SchemaType= "anyOf";
            ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InfoPushData" /> class
        /// with the <see cref="InfoPushBannerData" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of InfoPushBannerData.</param>
        public InfoPushData(InfoPushBannerData actualInstance)
        {
            IsNullable = false;
            SchemaType= "anyOf";
            ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InfoPushData" /> class
        /// with the <see cref="InfoPushVersionData" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of InfoPushVersionData.</param>
        public InfoPushData(InfoPushVersionData actualInstance)
        {
            IsNullable = false;
            SchemaType= "anyOf";
            ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InfoPushData" /> class
        /// with the <see cref="InfoPushOtherData" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of InfoPushOtherData.</param>
        public InfoPushData(InfoPushOtherData actualInstance)
        {
            IsNullable = false;
            SchemaType= "anyOf";
            ActualInstance = actualInstance;
        }


        private Object _actualInstance;

        /// <summary>
        /// Gets or Sets ActualInstance
        /// </summary>
        public override Object ActualInstance
        {
            get
            {
                return _actualInstance;
            }
            set
            {
                if (value.GetType() == typeof(InfoPushAccessoriesCategoryData))
                {
                    _actualInstance = value;
                }
                else if (value.GetType() == typeof(InfoPushAvatarCategoryData))
                {
                    _actualInstance = value;
                }
                else if (value.GetType() == typeof(InfoPushBannerData))
                {
                    _actualInstance = value;
                }
                else if (value.GetType() == typeof(InfoPushDiscoveryCategoryData))
                {
                    _actualInstance = value;
                }
                else if (value.GetType() == typeof(InfoPushHelpArticleData))
                {
                    _actualInstance = value;
                }
                else if (value.GetType() == typeof(InfoPushHelpTopicData))
                {
                    _actualInstance = value;
                }
                else if (value.GetType() == typeof(InfoPushLoadingScreenBannerData))
                {
                    _actualInstance = value;
                }
                else if (value.GetType() == typeof(InfoPushMarketplacePageData))
                {
                    _actualInstance = value;
                }
                else if (value.GetType() == typeof(InfoPushOnboardingAvatarData))
                {
                    _actualInstance = value;
                }
                else if (value.GetType() == typeof(InfoPushOtherData))
                {
                    _actualInstance = value;
                }
                else if (value.GetType() == typeof(InfoPushSearchData))
                {
                    _actualInstance = value;
                }
                else if (value.GetType() == typeof(InfoPushUrlConsentScreenData))
                {
                    _actualInstance = value;
                }
                else if (value.GetType() == typeof(InfoPushVersionData))
                {
                    _actualInstance = value;
                }
                else if (value.GetType() == typeof(InfoPushWorldCategoryData))
                {
                    _actualInstance = value;
                }
                else
                {
                    // Allow setting unknown types to handle unexpected responses gracefully
                    System.Diagnostics.Debug.WriteLine(string.Format("Warning: Setting ActualInstance to a type not in anyOf schema: {0}", value?.GetType()?.Name ?? "null"));
                    _actualInstance = value;
                }
            }
        }

        
        /// <summary>
        /// Converts to the <c>InfoPushOnboardingAvatarData</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator InfoPushOnboardingAvatarData(InfoPushData value) => (InfoPushOnboardingAvatarData)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>InfoPushHelpTopicData</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator InfoPushHelpTopicData(InfoPushData value) => (InfoPushHelpTopicData)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>InfoPushDiscoveryCategoryData</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator InfoPushDiscoveryCategoryData(InfoPushData value) => (InfoPushDiscoveryCategoryData)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>InfoPushHelpArticleData</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator InfoPushHelpArticleData(InfoPushData value) => (InfoPushHelpArticleData)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>InfoPushLoadingScreenBannerData</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator InfoPushLoadingScreenBannerData(InfoPushData value) => (InfoPushLoadingScreenBannerData)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>InfoPushMarketplacePageData</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator InfoPushMarketplacePageData(InfoPushData value) => (InfoPushMarketplacePageData)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>InfoPushWorldCategoryData</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator InfoPushWorldCategoryData(InfoPushData value) => (InfoPushWorldCategoryData)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>InfoPushUrlConsentScreenData</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator InfoPushUrlConsentScreenData(InfoPushData value) => (InfoPushUrlConsentScreenData)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>InfoPushAvatarCategoryData</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator InfoPushAvatarCategoryData(InfoPushData value) => (InfoPushAvatarCategoryData)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>InfoPushSearchData</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator InfoPushSearchData(InfoPushData value) => (InfoPushSearchData)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>InfoPushAccessoriesCategoryData</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator InfoPushAccessoriesCategoryData(InfoPushData value) => (InfoPushAccessoriesCategoryData)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>InfoPushBannerData</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator InfoPushBannerData(InfoPushData value) => (InfoPushBannerData)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>InfoPushVersionData</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator InfoPushVersionData(InfoPushData value) => (InfoPushVersionData)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>InfoPushOtherData</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator InfoPushOtherData(InfoPushData value) => (InfoPushOtherData)value?.ActualInstance;
        

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InfoPushData {\n");
            sb.Append("  ActualInstance: ").Append(ActualInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(ActualInstance, InfoPushData.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of InfoPushData
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of InfoPushData</returns>
        public static InfoPushData FromJson(string jsonString)
        {
            InfoPushData newInfoPushData = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newInfoPushData;
            }

            try
            {
                newInfoPushData = new InfoPushData(JsonConvert.DeserializeObject<InfoPushAccessoriesCategoryData>(jsonString, InfoPushData.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newInfoPushData;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into InfoPushAccessoriesCategoryData: {1}", jsonString, exception.ToString()));
            }

            try
            {
                newInfoPushData = new InfoPushData(JsonConvert.DeserializeObject<InfoPushAvatarCategoryData>(jsonString, InfoPushData.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newInfoPushData;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into InfoPushAvatarCategoryData: {1}", jsonString, exception.ToString()));
            }

            try
            {
                newInfoPushData = new InfoPushData(JsonConvert.DeserializeObject<InfoPushBannerData>(jsonString, InfoPushData.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newInfoPushData;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into InfoPushBannerData: {1}", jsonString, exception.ToString()));
            }

            try
            {
                newInfoPushData = new InfoPushData(JsonConvert.DeserializeObject<InfoPushDiscoveryCategoryData>(jsonString, InfoPushData.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newInfoPushData;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into InfoPushDiscoveryCategoryData: {1}", jsonString, exception.ToString()));
            }

            try
            {
                newInfoPushData = new InfoPushData(JsonConvert.DeserializeObject<InfoPushHelpArticleData>(jsonString, InfoPushData.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newInfoPushData;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into InfoPushHelpArticleData: {1}", jsonString, exception.ToString()));
            }

            try
            {
                newInfoPushData = new InfoPushData(JsonConvert.DeserializeObject<InfoPushHelpTopicData>(jsonString, InfoPushData.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newInfoPushData;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into InfoPushHelpTopicData: {1}", jsonString, exception.ToString()));
            }

            try
            {
                newInfoPushData = new InfoPushData(JsonConvert.DeserializeObject<InfoPushLoadingScreenBannerData>(jsonString, InfoPushData.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newInfoPushData;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into InfoPushLoadingScreenBannerData: {1}", jsonString, exception.ToString()));
            }

            try
            {
                newInfoPushData = new InfoPushData(JsonConvert.DeserializeObject<InfoPushMarketplacePageData>(jsonString, InfoPushData.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newInfoPushData;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into InfoPushMarketplacePageData: {1}", jsonString, exception.ToString()));
            }

            try
            {
                newInfoPushData = new InfoPushData(JsonConvert.DeserializeObject<InfoPushOnboardingAvatarData>(jsonString, InfoPushData.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newInfoPushData;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into InfoPushOnboardingAvatarData: {1}", jsonString, exception.ToString()));
            }

            try
            {
                newInfoPushData = new InfoPushData(JsonConvert.DeserializeObject<InfoPushOtherData>(jsonString, InfoPushData.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newInfoPushData;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into InfoPushOtherData: {1}", jsonString, exception.ToString()));
            }

            try
            {
                newInfoPushData = new InfoPushData(JsonConvert.DeserializeObject<InfoPushSearchData>(jsonString, InfoPushData.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newInfoPushData;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into InfoPushSearchData: {1}", jsonString, exception.ToString()));
            }

            try
            {
                newInfoPushData = new InfoPushData(JsonConvert.DeserializeObject<InfoPushUrlConsentScreenData>(jsonString, InfoPushData.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newInfoPushData;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into InfoPushUrlConsentScreenData: {1}", jsonString, exception.ToString()));
            }

            try
            {
                newInfoPushData = new InfoPushData(JsonConvert.DeserializeObject<InfoPushVersionData>(jsonString, InfoPushData.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newInfoPushData;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into InfoPushVersionData: {1}", jsonString, exception.ToString()));
            }

            try
            {
                newInfoPushData = new InfoPushData(JsonConvert.DeserializeObject<InfoPushWorldCategoryData>(jsonString, InfoPushData.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newInfoPushData;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into InfoPushWorldCategoryData: {1}", jsonString, exception.ToString()));
            }

            // no match found, return null to handle unexpected responses gracefully
            System.Diagnostics.Debug.WriteLine(string.Format("The JSON string `{0}` cannot be deserialized into any schema defined.", jsonString));
            return null;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return Equals(input as InfoPushData);
        }

        /// <summary>
        /// Returns true if InfoPushData instances are equal
        /// </summary>
        /// <param name="input">Instance of InfoPushData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InfoPushData input)
        {
            if (input == null)
                return false;

            return ActualInstance.Equals(input.ActualInstance);
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
                if (ActualInstance != null)
                    hashCode = hashCode * 59 + ActualInstance.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// Custom JSON converter for InfoPushData
    /// </summary>
    public class InfoPushDataJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(InfoPushData).GetMethod("ToJson").Invoke(value, null)));
        }

        /// <summary>
        /// To convert a JSON string into an object
        /// </summary>
        /// <param name="reader">JSON reader</param>
        /// <param name="objectType">Object type</param>
        /// <param name="existingValue">Existing value</param>
        /// <param name="serializer">JSON Serializer</param>
        /// <returns>The object converted from the JSON string</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            switch(reader.TokenType) 
            {
                case JsonToken.StartObject:
                    return InfoPushData.FromJson(JObject.Load(reader).ToString(Formatting.None));
                case JsonToken.StartArray:
                    return InfoPushData.FromJson(JArray.Load(reader).ToString(Formatting.None));
                default:
                    return null;
            }
        }

        /// <summary>
        /// Check if the object can be converted
        /// </summary>
        /// <param name="objectType">Object type</param>
        /// <returns>True if the object can be converted</returns>
        public override bool CanConvert(Type objectType)
        {
            return false;
        }
    }

}
