

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
    /// A notification. The shape of &#x60;data&#x60; depends on &#x60;type&#x60;.
    /// </summary>
    [JsonConverter(typeof(NotificationV2JsonConverter))]
    [DataContract(Name = "NotificationV2")]
    public partial class NotificationV2 : AbstractOpenAPISchema, IEquatable<NotificationV2>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationV2" /> class
        /// with the <see cref="NotificationV2GroupAnnouncement" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of NotificationV2GroupAnnouncement.</param>
        public NotificationV2(NotificationV2GroupAnnouncement actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationV2" /> class
        /// with the <see cref="NotificationV2GroupInvite" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of NotificationV2GroupInvite.</param>
        public NotificationV2(NotificationV2GroupInvite actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationV2" /> class
        /// with the <see cref="NotificationV2Unknown" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of NotificationV2Unknown.</param>
        public NotificationV2(NotificationV2Unknown actualInstance)
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
                if (value.GetType() == typeof(NotificationV2GroupAnnouncement) || value is NotificationV2GroupAnnouncement)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(NotificationV2GroupInvite) || value is NotificationV2GroupInvite)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(NotificationV2Unknown) || value is NotificationV2Unknown)
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
        /// Converts to the <c>NotificationV2GroupAnnouncement</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator NotificationV2GroupAnnouncement(NotificationV2 value) => (NotificationV2GroupAnnouncement)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>NotificationV2GroupInvite</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator NotificationV2GroupInvite(NotificationV2 value) => (NotificationV2GroupInvite)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>NotificationV2Unknown</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator NotificationV2Unknown(NotificationV2 value) => (NotificationV2Unknown)value?.ActualInstance;
        

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NotificationV2 {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, NotificationV2.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of NotificationV2
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of NotificationV2</returns>
        public static NotificationV2 FromJson(string jsonString)
        {
            NotificationV2 newNotificationV2 = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newNotificationV2;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(NotificationV2GroupAnnouncement).GetProperty("AdditionalProperties") == null)
                {
                    newNotificationV2 = new NotificationV2(JsonConvert.DeserializeObject<NotificationV2GroupAnnouncement>(jsonString, NotificationV2.SerializerSettings));
                }
                else
                {
                    newNotificationV2 = new NotificationV2(JsonConvert.DeserializeObject<NotificationV2GroupAnnouncement>(jsonString, NotificationV2.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("NotificationV2GroupAnnouncement");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into NotificationV2GroupAnnouncement: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(NotificationV2GroupInvite).GetProperty("AdditionalProperties") == null)
                {
                    newNotificationV2 = new NotificationV2(JsonConvert.DeserializeObject<NotificationV2GroupInvite>(jsonString, NotificationV2.SerializerSettings));
                }
                else
                {
                    newNotificationV2 = new NotificationV2(JsonConvert.DeserializeObject<NotificationV2GroupInvite>(jsonString, NotificationV2.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("NotificationV2GroupInvite");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into NotificationV2GroupInvite: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(NotificationV2Unknown).GetProperty("AdditionalProperties") == null)
                {
                    newNotificationV2 = new NotificationV2(JsonConvert.DeserializeObject<NotificationV2Unknown>(jsonString, NotificationV2.SerializerSettings));
                }
                else
                {
                    newNotificationV2 = new NotificationV2(JsonConvert.DeserializeObject<NotificationV2Unknown>(jsonString, NotificationV2.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("NotificationV2Unknown");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into NotificationV2Unknown: {1}", jsonString, exception.ToString()));
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
            return newNotificationV2;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as NotificationV2);
        }

        /// <summary>
        /// Returns true if NotificationV2 instances are equal
        /// </summary>
        /// <param name="input">Instance of NotificationV2 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NotificationV2 input)
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
    /// Custom JSON converter for NotificationV2
    /// </summary>
    public class NotificationV2JsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(NotificationV2).GetMethod("ToJson").Invoke(value, null)));
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
                    return NotificationV2.FromJson(JObject.Load(reader).ToString(Formatting.None));
                case JsonToken.StartArray:
                    return NotificationV2.FromJson(JArray.Load(reader).ToString(Formatting.None));
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
