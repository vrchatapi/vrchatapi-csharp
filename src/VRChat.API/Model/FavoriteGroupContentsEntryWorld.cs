

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
    /// FavoriteGroupContentsEntryWorld
    /// </summary>
    [JsonConverter(typeof(FavoriteGroupContentsEntryWorldJsonConverter))]
    [DataContract(Name = "FavoriteGroupContentsEntry_world")]
    public partial class FavoriteGroupContentsEntryWorld : AbstractOpenAPISchema, IEquatable<FavoriteGroupContentsEntryWorld>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FavoriteGroupContentsEntryWorld" /> class
        /// with the <see cref="FavoritedWorld" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of FavoritedWorld.</param>
        public FavoriteGroupContentsEntryWorld(FavoritedWorld actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FavoriteGroupContentsEntryWorld" /> class
        /// with the <see cref="UnavailableWorld" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of UnavailableWorld.</param>
        public FavoriteGroupContentsEntryWorld(UnavailableWorld actualInstance)
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
                if (value.GetType() == typeof(FavoritedWorld) || value is FavoritedWorld)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(UnavailableWorld) || value is UnavailableWorld)
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
        /// Get the actual instance of `FavoritedWorld`. If the actual instance is not `FavoritedWorld`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of FavoritedWorld</returns>
        public FavoritedWorld GetFavoritedWorld()
        {
            return (FavoritedWorld)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `UnavailableWorld`. If the actual instance is not `UnavailableWorld`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of UnavailableWorld</returns>
        public UnavailableWorld GetUnavailableWorld()
        {
            return (UnavailableWorld)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FavoriteGroupContentsEntryWorld {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, FavoriteGroupContentsEntryWorld.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of FavoriteGroupContentsEntryWorld
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of FavoriteGroupContentsEntryWorld</returns>
        public static FavoriteGroupContentsEntryWorld FromJson(string jsonString)
        {
            FavoriteGroupContentsEntryWorld newFavoriteGroupContentsEntryWorld = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newFavoriteGroupContentsEntryWorld;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(FavoritedWorld).GetProperty("AdditionalProperties") == null)
                {
                    newFavoriteGroupContentsEntryWorld = new FavoriteGroupContentsEntryWorld(JsonConvert.DeserializeObject<FavoritedWorld>(jsonString, FavoriteGroupContentsEntryWorld.SerializerSettings));
                }
                else
                {
                    newFavoriteGroupContentsEntryWorld = new FavoriteGroupContentsEntryWorld(JsonConvert.DeserializeObject<FavoritedWorld>(jsonString, FavoriteGroupContentsEntryWorld.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("FavoritedWorld");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into FavoritedWorld: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(UnavailableWorld).GetProperty("AdditionalProperties") == null)
                {
                    newFavoriteGroupContentsEntryWorld = new FavoriteGroupContentsEntryWorld(JsonConvert.DeserializeObject<UnavailableWorld>(jsonString, FavoriteGroupContentsEntryWorld.SerializerSettings));
                }
                else
                {
                    newFavoriteGroupContentsEntryWorld = new FavoriteGroupContentsEntryWorld(JsonConvert.DeserializeObject<UnavailableWorld>(jsonString, FavoriteGroupContentsEntryWorld.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("UnavailableWorld");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into UnavailableWorld: {1}", jsonString, exception.ToString()));
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
            return newFavoriteGroupContentsEntryWorld;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as FavoriteGroupContentsEntryWorld);
        }

        /// <summary>
        /// Returns true if FavoriteGroupContentsEntryWorld instances are equal
        /// </summary>
        /// <param name="input">Instance of FavoriteGroupContentsEntryWorld to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FavoriteGroupContentsEntryWorld input)
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
    /// Custom JSON converter for FavoriteGroupContentsEntryWorld
    /// </summary>
    public class FavoriteGroupContentsEntryWorldJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(FavoriteGroupContentsEntryWorld).GetMethod("ToJson").Invoke(value, null)));
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
                    return FavoriteGroupContentsEntryWorld.FromJson(JObject.Load(reader).ToString(Formatting.None));
                case JsonToken.StartArray:
                    return FavoriteGroupContentsEntryWorld.FromJson(JArray.Load(reader).ToString(Formatting.None));
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
