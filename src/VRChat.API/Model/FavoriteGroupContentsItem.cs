

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
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using FileParameter = VRChat.API.Client.FileParameter;
using OpenAPIDateConverter = VRChat.API.Client.OpenAPIDateConverter;
using System.Reflection;

namespace VRChat.API.Model
{
    /// <summary>
    /// A favorite alongside the object it points at. The object appears under a property named for the favorite&#39;s type.
    /// </summary>
    [JsonConverter(typeof(FavoriteGroupContentsItemJsonConverter))]
    [DataContract(Name = "FavoriteGroupContentsItem")]
    public partial class FavoriteGroupContentsItem : AbstractOpenAPISchema, IEquatable<FavoriteGroupContentsItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FavoriteGroupContentsItem" /> class
        /// with the <see cref="FavoriteGroupContentsItemAvatar" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of FavoriteGroupContentsItemAvatar.</param>
        public FavoriteGroupContentsItem(FavoriteGroupContentsItemAvatar actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FavoriteGroupContentsItem" /> class
        /// with the <see cref="FavoriteGroupContentsItemFriend" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of FavoriteGroupContentsItemFriend.</param>
        public FavoriteGroupContentsItem(FavoriteGroupContentsItemFriend actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FavoriteGroupContentsItem" /> class
        /// with the <see cref="FavoriteGroupContentsItemVRCPlusWorld" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of FavoriteGroupContentsItemVRCPlusWorld.</param>
        public FavoriteGroupContentsItem(FavoriteGroupContentsItemVRCPlusWorld actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FavoriteGroupContentsItem" /> class
        /// with the <see cref="FavoriteGroupContentsItemWorld" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of FavoriteGroupContentsItemWorld.</param>
        public FavoriteGroupContentsItem(FavoriteGroupContentsItemWorld actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FavoriteGroupContentsItem" /> class
        /// with the <see cref="FavoriteGroupContentsItemUnknown" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of FavoriteGroupContentsItemUnknown.</param>
        public FavoriteGroupContentsItem(FavoriteGroupContentsItemUnknown actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
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
                if (value.GetType() == typeof(FavoriteGroupContentsItemAvatar) || value is FavoriteGroupContentsItemAvatar)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(FavoriteGroupContentsItemFriend) || value is FavoriteGroupContentsItemFriend)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(FavoriteGroupContentsItemUnknown) || value is FavoriteGroupContentsItemUnknown)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(FavoriteGroupContentsItemVRCPlusWorld) || value is FavoriteGroupContentsItemVRCPlusWorld)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(FavoriteGroupContentsItemWorld) || value is FavoriteGroupContentsItemWorld)
                {
                    this._actualInstance = value;
                }
                else
                {
                    // Allow setting unknown types to handle unexpected responses gracefully
                    System.Diagnostics.Debug.WriteLine(string.Format("Warning: Setting ActualInstance to a type not in oneOf schema: {0}", value?.GetType()?.Name ?? "null"));
                    this._actualInstance = value;
                }
            }
        }

        
        /// <summary>
        /// Converts to the <c>FavoriteGroupContentsItemAvatar</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator FavoriteGroupContentsItemAvatar(FavoriteGroupContentsItem value) => (FavoriteGroupContentsItemAvatar)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>FavoriteGroupContentsItemFriend</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator FavoriteGroupContentsItemFriend(FavoriteGroupContentsItem value) => (FavoriteGroupContentsItemFriend)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>FavoriteGroupContentsItemVRCPlusWorld</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator FavoriteGroupContentsItemVRCPlusWorld(FavoriteGroupContentsItem value) => (FavoriteGroupContentsItemVRCPlusWorld)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>FavoriteGroupContentsItemWorld</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator FavoriteGroupContentsItemWorld(FavoriteGroupContentsItem value) => (FavoriteGroupContentsItemWorld)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>FavoriteGroupContentsItemUnknown</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator FavoriteGroupContentsItemUnknown(FavoriteGroupContentsItem value) => (FavoriteGroupContentsItemUnknown)value?.ActualInstance;
        

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FavoriteGroupContentsItem {\n");
            sb.Append("  ActualInstance: ").Append(this.ActualInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this.ActualInstance, FavoriteGroupContentsItem.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of FavoriteGroupContentsItem
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of FavoriteGroupContentsItem</returns>
        public static FavoriteGroupContentsItem FromJson(string jsonString)
        {
            FavoriteGroupContentsItem newFavoriteGroupContentsItem = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newFavoriteGroupContentsItem;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(FavoriteGroupContentsItemAvatar).GetProperty("AdditionalProperties") == null)
                {
                    newFavoriteGroupContentsItem = new FavoriteGroupContentsItem(JsonConvert.DeserializeObject<FavoriteGroupContentsItemAvatar>(jsonString, FavoriteGroupContentsItem.SerializerSettings));
                }
                else
                {
                    newFavoriteGroupContentsItem = new FavoriteGroupContentsItem(JsonConvert.DeserializeObject<FavoriteGroupContentsItemAvatar>(jsonString, FavoriteGroupContentsItem.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("FavoriteGroupContentsItemAvatar");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into FavoriteGroupContentsItemAvatar: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(FavoriteGroupContentsItemFriend).GetProperty("AdditionalProperties") == null)
                {
                    newFavoriteGroupContentsItem = new FavoriteGroupContentsItem(JsonConvert.DeserializeObject<FavoriteGroupContentsItemFriend>(jsonString, FavoriteGroupContentsItem.SerializerSettings));
                }
                else
                {
                    newFavoriteGroupContentsItem = new FavoriteGroupContentsItem(JsonConvert.DeserializeObject<FavoriteGroupContentsItemFriend>(jsonString, FavoriteGroupContentsItem.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("FavoriteGroupContentsItemFriend");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into FavoriteGroupContentsItemFriend: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(FavoriteGroupContentsItemUnknown).GetProperty("AdditionalProperties") == null)
                {
                    newFavoriteGroupContentsItem = new FavoriteGroupContentsItem(JsonConvert.DeserializeObject<FavoriteGroupContentsItemUnknown>(jsonString, FavoriteGroupContentsItem.SerializerSettings));
                }
                else
                {
                    newFavoriteGroupContentsItem = new FavoriteGroupContentsItem(JsonConvert.DeserializeObject<FavoriteGroupContentsItemUnknown>(jsonString, FavoriteGroupContentsItem.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("FavoriteGroupContentsItemUnknown");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into FavoriteGroupContentsItemUnknown: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(FavoriteGroupContentsItemVRCPlusWorld).GetProperty("AdditionalProperties") == null)
                {
                    newFavoriteGroupContentsItem = new FavoriteGroupContentsItem(JsonConvert.DeserializeObject<FavoriteGroupContentsItemVRCPlusWorld>(jsonString, FavoriteGroupContentsItem.SerializerSettings));
                }
                else
                {
                    newFavoriteGroupContentsItem = new FavoriteGroupContentsItem(JsonConvert.DeserializeObject<FavoriteGroupContentsItemVRCPlusWorld>(jsonString, FavoriteGroupContentsItem.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("FavoriteGroupContentsItemVRCPlusWorld");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into FavoriteGroupContentsItemVRCPlusWorld: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(FavoriteGroupContentsItemWorld).GetProperty("AdditionalProperties") == null)
                {
                    newFavoriteGroupContentsItem = new FavoriteGroupContentsItem(JsonConvert.DeserializeObject<FavoriteGroupContentsItemWorld>(jsonString, FavoriteGroupContentsItem.SerializerSettings));
                }
                else
                {
                    newFavoriteGroupContentsItem = new FavoriteGroupContentsItem(JsonConvert.DeserializeObject<FavoriteGroupContentsItemWorld>(jsonString, FavoriteGroupContentsItem.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("FavoriteGroupContentsItemWorld");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into FavoriteGroupContentsItemWorld: {1}", jsonString, exception.ToString()));
            }

            if (match == 0)
            {
                // No match found, return null to handle unexpected responses gracefully
                System.Diagnostics.Debug.WriteLine(string.Format("The JSON string `{0}` cannot be deserialized into any schema defined.", jsonString));
                return null;
            }
            else if (match > 1)
            {
                // Multiple matches found, use the first match and log a warning
                System.Diagnostics.Debug.WriteLine(string.Format("The JSON string `{0}` matches more than one schema: {1}. Using the first match.", jsonString, String.Join(",", matchedTypes)));
            }

            // deserialization is considered successful at this point if no exception has been thrown.
            return newFavoriteGroupContentsItem;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as FavoriteGroupContentsItem);
        }

        /// <summary>
        /// Returns true if FavoriteGroupContentsItem instances are equal
        /// </summary>
        /// <param name="input">Instance of FavoriteGroupContentsItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FavoriteGroupContentsItem input)
        {
            if (input == null)
                return false;

            return this.ActualInstance.Equals(input.ActualInstance);
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
                if (this.ActualInstance != null)
                    hashCode = hashCode * 59 + this.ActualInstance.GetHashCode();
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
    /// Custom JSON converter for FavoriteGroupContentsItem
    /// </summary>
    public class FavoriteGroupContentsItemJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(FavoriteGroupContentsItem).GetMethod("ToJson").Invoke(value, null)));
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
                    return FavoriteGroupContentsItem.FromJson(JObject.Load(reader).ToString(Formatting.None));
                case JsonToken.StartArray:
                    return FavoriteGroupContentsItem.FromJson(JArray.Load(reader).ToString(Formatting.None));
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
