

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
    /// PrivateProfileActivityLastActivity
    /// </summary>
    [JsonConverter(typeof(PrivateProfileActivityLastActivityJsonConverter))]
    [DataContract(Name = "PrivateProfileActivity_last_activity")]
    public partial class PrivateProfileActivityLastActivity : AbstractOpenAPISchema, IEquatable<PrivateProfileActivityLastActivity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateProfileActivityLastActivity" /> class
        /// with the <see cref="DateTime" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of DateTime.</param>
        public PrivateProfileActivityLastActivity(DateTime actualInstance)
        {
            IsNullable = false;
            SchemaType= "anyOf";
            ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateProfileActivityLastActivity" /> class
        /// with the <see cref="string" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of string.</param>
        public PrivateProfileActivityLastActivity(string actualInstance)
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
                if (value.GetType() == typeof(DateTime))
                {
                    _actualInstance = value;
                }
                else if (value.GetType() == typeof(string))
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
        /// Converts to the <c>DateTime</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator DateTime(PrivateProfileActivityLastActivity value) => (DateTime)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>string</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator string(PrivateProfileActivityLastActivity value) => (string)value?.ActualInstance;
        

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PrivateProfileActivityLastActivity {\n");
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
            return JsonConvert.SerializeObject(ActualInstance, PrivateProfileActivityLastActivity.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of PrivateProfileActivityLastActivity
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of PrivateProfileActivityLastActivity</returns>
        public static PrivateProfileActivityLastActivity FromJson(string jsonString)
        {
            PrivateProfileActivityLastActivity newPrivateProfileActivityLastActivity = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newPrivateProfileActivityLastActivity;
            }

            try
            {
                newPrivateProfileActivityLastActivity = new PrivateProfileActivityLastActivity(JsonConvert.DeserializeObject<DateTime>(jsonString, PrivateProfileActivityLastActivity.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newPrivateProfileActivityLastActivity;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into DateTime: {1}", jsonString, exception.ToString()));
            }

            try
            {
                newPrivateProfileActivityLastActivity = new PrivateProfileActivityLastActivity(JsonConvert.DeserializeObject<string>(jsonString, PrivateProfileActivityLastActivity.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newPrivateProfileActivityLastActivity;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into string: {1}", jsonString, exception.ToString()));
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
            return Equals(input as PrivateProfileActivityLastActivity);
        }

        /// <summary>
        /// Returns true if PrivateProfileActivityLastActivity instances are equal
        /// </summary>
        /// <param name="input">Instance of PrivateProfileActivityLastActivity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PrivateProfileActivityLastActivity input)
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
    /// Custom JSON converter for PrivateProfileActivityLastActivity
    /// </summary>
    public class PrivateProfileActivityLastActivityJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(PrivateProfileActivityLastActivity).GetMethod("ToJson").Invoke(value, null)));
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
                case JsonToken.String: 
                    return new PrivateProfileActivityLastActivity(Convert.ToString(reader.Value));
                case JsonToken.StartObject:
                    return PrivateProfileActivityLastActivity.FromJson(JObject.Load(reader).ToString(Formatting.None));
                case JsonToken.StartArray:
                    return PrivateProfileActivityLastActivity.FromJson(JArray.Load(reader).ToString(Formatting.None));
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
