

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
    /// NotificationV2Data
    /// </summary>
    [JsonConverter(typeof(NotificationV2DataJsonConverter))]
    [DataContract(Name = "NotificationV2_data")]
    public partial class NotificationV2Data : AbstractOpenAPISchema, IEquatable<NotificationV2Data>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationV2Data" /> class
        /// with the <see cref="Object" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Object.</param>
        public NotificationV2Data(Object actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationV2Data" /> class
        /// with the <see cref="NotificationV2DataBadgeEarned" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of NotificationV2DataBadgeEarned.</param>
        public NotificationV2Data(NotificationV2DataBadgeEarned actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationV2Data" /> class
        /// with the <see cref="NotificationV2DataBoop" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of NotificationV2DataBoop.</param>
        public NotificationV2Data(NotificationV2DataBoop actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationV2Data" /> class
        /// with the <see cref="NotificationV2DataEventAnnouncement" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of NotificationV2DataEventAnnouncement.</param>
        public NotificationV2Data(NotificationV2DataEventAnnouncement actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationV2Data" /> class
        /// with the <see cref="NotificationV2DataGroupAnnouncement" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of NotificationV2DataGroupAnnouncement.</param>
        public NotificationV2Data(NotificationV2DataGroupAnnouncement actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationV2Data" /> class
        /// with the <see cref="NotificationV2DataGroupInformative" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of NotificationV2DataGroupInformative.</param>
        public NotificationV2Data(NotificationV2DataGroupInformative actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationV2Data" /> class
        /// with the <see cref="NotificationV2DataGroupTransfer" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of NotificationV2DataGroupTransfer.</param>
        public NotificationV2Data(NotificationV2DataGroupTransfer actualInstance)
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
                if (value.GetType() == typeof(NotificationV2DataBadgeEarned) || value is NotificationV2DataBadgeEarned)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(NotificationV2DataBoop) || value is NotificationV2DataBoop)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(NotificationV2DataEventAnnouncement) || value is NotificationV2DataEventAnnouncement)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(NotificationV2DataGroupAnnouncement) || value is NotificationV2DataGroupAnnouncement)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(NotificationV2DataGroupInformative) || value is NotificationV2DataGroupInformative)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(NotificationV2DataGroupTransfer) || value is NotificationV2DataGroupTransfer)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(Object) || value is Object)
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
        /// Converts to the <c>NotificationV2DataBadgeEarned</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator NotificationV2DataBadgeEarned(NotificationV2Data value) => (NotificationV2DataBadgeEarned)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>NotificationV2DataBoop</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator NotificationV2DataBoop(NotificationV2Data value) => (NotificationV2DataBoop)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>NotificationV2DataEventAnnouncement</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator NotificationV2DataEventAnnouncement(NotificationV2Data value) => (NotificationV2DataEventAnnouncement)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>NotificationV2DataGroupAnnouncement</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator NotificationV2DataGroupAnnouncement(NotificationV2Data value) => (NotificationV2DataGroupAnnouncement)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>NotificationV2DataGroupInformative</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator NotificationV2DataGroupInformative(NotificationV2Data value) => (NotificationV2DataGroupInformative)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>NotificationV2DataGroupTransfer</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator NotificationV2DataGroupTransfer(NotificationV2Data value) => (NotificationV2DataGroupTransfer)value?.ActualInstance;
        

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NotificationV2Data {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, NotificationV2Data.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of NotificationV2Data
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of NotificationV2Data</returns>
        public static NotificationV2Data FromJson(string jsonString)
        {
            NotificationV2Data newNotificationV2Data = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newNotificationV2Data;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(NotificationV2DataBadgeEarned).GetProperty("AdditionalProperties") == null)
                {
                    newNotificationV2Data = new NotificationV2Data(JsonConvert.DeserializeObject<NotificationV2DataBadgeEarned>(jsonString, NotificationV2Data.SerializerSettings));
                }
                else
                {
                    newNotificationV2Data = new NotificationV2Data(JsonConvert.DeserializeObject<NotificationV2DataBadgeEarned>(jsonString, NotificationV2Data.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("NotificationV2DataBadgeEarned");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into NotificationV2DataBadgeEarned: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(NotificationV2DataBoop).GetProperty("AdditionalProperties") == null)
                {
                    newNotificationV2Data = new NotificationV2Data(JsonConvert.DeserializeObject<NotificationV2DataBoop>(jsonString, NotificationV2Data.SerializerSettings));
                }
                else
                {
                    newNotificationV2Data = new NotificationV2Data(JsonConvert.DeserializeObject<NotificationV2DataBoop>(jsonString, NotificationV2Data.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("NotificationV2DataBoop");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into NotificationV2DataBoop: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(NotificationV2DataEventAnnouncement).GetProperty("AdditionalProperties") == null)
                {
                    newNotificationV2Data = new NotificationV2Data(JsonConvert.DeserializeObject<NotificationV2DataEventAnnouncement>(jsonString, NotificationV2Data.SerializerSettings));
                }
                else
                {
                    newNotificationV2Data = new NotificationV2Data(JsonConvert.DeserializeObject<NotificationV2DataEventAnnouncement>(jsonString, NotificationV2Data.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("NotificationV2DataEventAnnouncement");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into NotificationV2DataEventAnnouncement: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(NotificationV2DataGroupAnnouncement).GetProperty("AdditionalProperties") == null)
                {
                    newNotificationV2Data = new NotificationV2Data(JsonConvert.DeserializeObject<NotificationV2DataGroupAnnouncement>(jsonString, NotificationV2Data.SerializerSettings));
                }
                else
                {
                    newNotificationV2Data = new NotificationV2Data(JsonConvert.DeserializeObject<NotificationV2DataGroupAnnouncement>(jsonString, NotificationV2Data.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("NotificationV2DataGroupAnnouncement");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into NotificationV2DataGroupAnnouncement: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(NotificationV2DataGroupInformative).GetProperty("AdditionalProperties") == null)
                {
                    newNotificationV2Data = new NotificationV2Data(JsonConvert.DeserializeObject<NotificationV2DataGroupInformative>(jsonString, NotificationV2Data.SerializerSettings));
                }
                else
                {
                    newNotificationV2Data = new NotificationV2Data(JsonConvert.DeserializeObject<NotificationV2DataGroupInformative>(jsonString, NotificationV2Data.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("NotificationV2DataGroupInformative");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into NotificationV2DataGroupInformative: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(NotificationV2DataGroupTransfer).GetProperty("AdditionalProperties") == null)
                {
                    newNotificationV2Data = new NotificationV2Data(JsonConvert.DeserializeObject<NotificationV2DataGroupTransfer>(jsonString, NotificationV2Data.SerializerSettings));
                }
                else
                {
                    newNotificationV2Data = new NotificationV2Data(JsonConvert.DeserializeObject<NotificationV2DataGroupTransfer>(jsonString, NotificationV2Data.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("NotificationV2DataGroupTransfer");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into NotificationV2DataGroupTransfer: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(Object).GetProperty("AdditionalProperties") == null)
                {
                    newNotificationV2Data = new NotificationV2Data(JsonConvert.DeserializeObject<Object>(jsonString, NotificationV2Data.SerializerSettings));
                }
                else
                {
                    newNotificationV2Data = new NotificationV2Data(JsonConvert.DeserializeObject<Object>(jsonString, NotificationV2Data.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("Object");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into Object: {1}", jsonString, exception.ToString()));
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
            return newNotificationV2Data;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as NotificationV2Data);
        }

        /// <summary>
        /// Returns true if NotificationV2Data instances are equal
        /// </summary>
        /// <param name="input">Instance of NotificationV2Data to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NotificationV2Data input)
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
    /// Custom JSON converter for NotificationV2Data
    /// </summary>
    public class NotificationV2DataJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(NotificationV2Data).GetMethod("ToJson").Invoke(value, null)));
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
                    return NotificationV2Data.FromJson(JObject.Load(reader).ToString(Formatting.None));
                case JsonToken.StartArray:
                    return NotificationV2Data.FromJson(JArray.Load(reader).ToString(Formatting.None));
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
