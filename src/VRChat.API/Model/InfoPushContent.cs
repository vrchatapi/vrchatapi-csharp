

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
    /// The results of a content shelf&#39;s &#x60;contentSource&#x60;, as its &#x60;responseType&#x60; names them.
    /// </summary>
    [JsonConverter(typeof(InfoPushContentJsonConverter))]
    [DataContract(Name = "InfoPushContent")]
    public partial class InfoPushContent : AbstractOpenAPISchema, IEquatable<InfoPushContent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InfoPushContent" /> class
        /// with the <see cref="InfoPushContentInstances" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of InfoPushContentInstances.</param>
        public InfoPushContent(InfoPushContentInstances actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InfoPushContent" /> class
        /// with the <see cref="InfoPushContentCalendarEntries" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of InfoPushContentCalendarEntries.</param>
        public InfoPushContent(InfoPushContentCalendarEntries actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InfoPushContent" /> class
        /// with the <see cref="InfoPushContentUnknown" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of InfoPushContentUnknown.</param>
        public InfoPushContent(InfoPushContentUnknown actualInstance)
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
                if (value.GetType() == typeof(InfoPushContentCalendarEntries) || value is InfoPushContentCalendarEntries)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(InfoPushContentInstances) || value is InfoPushContentInstances)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(InfoPushContentUnknown) || value is InfoPushContentUnknown)
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
        /// Converts to the <c>InfoPushContentInstances</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator InfoPushContentInstances(InfoPushContent value) => (InfoPushContentInstances)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>InfoPushContentCalendarEntries</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator InfoPushContentCalendarEntries(InfoPushContent value) => (InfoPushContentCalendarEntries)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>InfoPushContentUnknown</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator InfoPushContentUnknown(InfoPushContent value) => (InfoPushContentUnknown)value?.ActualInstance;
        

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InfoPushContent {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, InfoPushContent.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of InfoPushContent
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of InfoPushContent</returns>
        public static InfoPushContent FromJson(string jsonString)
        {
            InfoPushContent newInfoPushContent = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newInfoPushContent;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(InfoPushContentCalendarEntries).GetProperty("AdditionalProperties") == null)
                {
                    newInfoPushContent = new InfoPushContent(JsonConvert.DeserializeObject<InfoPushContentCalendarEntries>(jsonString, InfoPushContent.SerializerSettings));
                }
                else
                {
                    newInfoPushContent = new InfoPushContent(JsonConvert.DeserializeObject<InfoPushContentCalendarEntries>(jsonString, InfoPushContent.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("InfoPushContentCalendarEntries");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into InfoPushContentCalendarEntries: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(InfoPushContentInstances).GetProperty("AdditionalProperties") == null)
                {
                    newInfoPushContent = new InfoPushContent(JsonConvert.DeserializeObject<InfoPushContentInstances>(jsonString, InfoPushContent.SerializerSettings));
                }
                else
                {
                    newInfoPushContent = new InfoPushContent(JsonConvert.DeserializeObject<InfoPushContentInstances>(jsonString, InfoPushContent.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("InfoPushContentInstances");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into InfoPushContentInstances: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(InfoPushContentUnknown).GetProperty("AdditionalProperties") == null)
                {
                    newInfoPushContent = new InfoPushContent(JsonConvert.DeserializeObject<InfoPushContentUnknown>(jsonString, InfoPushContent.SerializerSettings));
                }
                else
                {
                    newInfoPushContent = new InfoPushContent(JsonConvert.DeserializeObject<InfoPushContentUnknown>(jsonString, InfoPushContent.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("InfoPushContentUnknown");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into InfoPushContentUnknown: {1}", jsonString, exception.ToString()));
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
            return newInfoPushContent;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as InfoPushContent);
        }

        /// <summary>
        /// Returns true if InfoPushContent instances are equal
        /// </summary>
        /// <param name="input">Instance of InfoPushContent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InfoPushContent input)
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
    /// Custom JSON converter for InfoPushContent
    /// </summary>
    public class InfoPushContentJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(InfoPushContent).GetMethod("ToJson").Invoke(value, null)));
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
                    return InfoPushContent.FromJson(JObject.Load(reader).ToString(Formatting.None));
                case JsonToken.StartArray:
                    return InfoPushContent.FromJson(JArray.Load(reader).ToString(Formatting.None));
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
