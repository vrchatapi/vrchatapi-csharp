

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
    /// SentNotificationDetails
    /// </summary>
    [JsonConverter(typeof(SentNotificationDetailsJsonConverter))]
    [DataContract(Name = "SentNotification_details")]
    public partial class SentNotificationDetails : AbstractOpenAPISchema, IEquatable<SentNotificationDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SentNotificationDetails" /> class
        /// with the <see cref="Object" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Object.</param>
        public SentNotificationDetails(Object actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SentNotificationDetails" /> class
        /// with the <see cref="NotificationDetailBoop" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of NotificationDetailBoop.</param>
        public SentNotificationDetails(NotificationDetailBoop actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SentNotificationDetails" /> class
        /// with the <see cref="NotificationDetailInvite" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of NotificationDetailInvite.</param>
        public SentNotificationDetails(NotificationDetailInvite actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SentNotificationDetails" /> class
        /// with the <see cref="NotificationDetailInviteResponse" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of NotificationDetailInviteResponse.</param>
        public SentNotificationDetails(NotificationDetailInviteResponse actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SentNotificationDetails" /> class
        /// with the <see cref="NotificationDetailRequestInvite" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of NotificationDetailRequestInvite.</param>
        public SentNotificationDetails(NotificationDetailRequestInvite actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SentNotificationDetails" /> class
        /// with the <see cref="NotificationDetailRequestInviteResponse" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of NotificationDetailRequestInviteResponse.</param>
        public SentNotificationDetails(NotificationDetailRequestInviteResponse actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SentNotificationDetails" /> class
        /// with the <see cref="NotificationDetailVoteToKick" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of NotificationDetailVoteToKick.</param>
        public SentNotificationDetails(NotificationDetailVoteToKick actualInstance)
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
                if (value.GetType() == typeof(NotificationDetailBoop) || value is NotificationDetailBoop)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(NotificationDetailInvite) || value is NotificationDetailInvite)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(NotificationDetailInviteResponse) || value is NotificationDetailInviteResponse)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(NotificationDetailRequestInvite) || value is NotificationDetailRequestInvite)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(NotificationDetailRequestInviteResponse) || value is NotificationDetailRequestInviteResponse)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(NotificationDetailVoteToKick) || value is NotificationDetailVoteToKick)
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
        /// Converts to the <c>NotificationDetailBoop</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator NotificationDetailBoop(SentNotificationDetails value) => (NotificationDetailBoop)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>NotificationDetailInvite</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator NotificationDetailInvite(SentNotificationDetails value) => (NotificationDetailInvite)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>NotificationDetailInviteResponse</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator NotificationDetailInviteResponse(SentNotificationDetails value) => (NotificationDetailInviteResponse)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>NotificationDetailRequestInvite</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator NotificationDetailRequestInvite(SentNotificationDetails value) => (NotificationDetailRequestInvite)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>NotificationDetailRequestInviteResponse</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator NotificationDetailRequestInviteResponse(SentNotificationDetails value) => (NotificationDetailRequestInviteResponse)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>NotificationDetailVoteToKick</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator NotificationDetailVoteToKick(SentNotificationDetails value) => (NotificationDetailVoteToKick)value?.ActualInstance;
        

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SentNotificationDetails {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, SentNotificationDetails.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of SentNotificationDetails
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of SentNotificationDetails</returns>
        public static SentNotificationDetails FromJson(string jsonString)
        {
            SentNotificationDetails newSentNotificationDetails = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newSentNotificationDetails;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(NotificationDetailBoop).GetProperty("AdditionalProperties") == null)
                {
                    newSentNotificationDetails = new SentNotificationDetails(JsonConvert.DeserializeObject<NotificationDetailBoop>(jsonString, SentNotificationDetails.SerializerSettings));
                }
                else
                {
                    newSentNotificationDetails = new SentNotificationDetails(JsonConvert.DeserializeObject<NotificationDetailBoop>(jsonString, SentNotificationDetails.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("NotificationDetailBoop");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into NotificationDetailBoop: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(NotificationDetailInvite).GetProperty("AdditionalProperties") == null)
                {
                    newSentNotificationDetails = new SentNotificationDetails(JsonConvert.DeserializeObject<NotificationDetailInvite>(jsonString, SentNotificationDetails.SerializerSettings));
                }
                else
                {
                    newSentNotificationDetails = new SentNotificationDetails(JsonConvert.DeserializeObject<NotificationDetailInvite>(jsonString, SentNotificationDetails.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("NotificationDetailInvite");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into NotificationDetailInvite: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(NotificationDetailInviteResponse).GetProperty("AdditionalProperties") == null)
                {
                    newSentNotificationDetails = new SentNotificationDetails(JsonConvert.DeserializeObject<NotificationDetailInviteResponse>(jsonString, SentNotificationDetails.SerializerSettings));
                }
                else
                {
                    newSentNotificationDetails = new SentNotificationDetails(JsonConvert.DeserializeObject<NotificationDetailInviteResponse>(jsonString, SentNotificationDetails.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("NotificationDetailInviteResponse");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into NotificationDetailInviteResponse: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(NotificationDetailRequestInvite).GetProperty("AdditionalProperties") == null)
                {
                    newSentNotificationDetails = new SentNotificationDetails(JsonConvert.DeserializeObject<NotificationDetailRequestInvite>(jsonString, SentNotificationDetails.SerializerSettings));
                }
                else
                {
                    newSentNotificationDetails = new SentNotificationDetails(JsonConvert.DeserializeObject<NotificationDetailRequestInvite>(jsonString, SentNotificationDetails.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("NotificationDetailRequestInvite");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into NotificationDetailRequestInvite: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(NotificationDetailRequestInviteResponse).GetProperty("AdditionalProperties") == null)
                {
                    newSentNotificationDetails = new SentNotificationDetails(JsonConvert.DeserializeObject<NotificationDetailRequestInviteResponse>(jsonString, SentNotificationDetails.SerializerSettings));
                }
                else
                {
                    newSentNotificationDetails = new SentNotificationDetails(JsonConvert.DeserializeObject<NotificationDetailRequestInviteResponse>(jsonString, SentNotificationDetails.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("NotificationDetailRequestInviteResponse");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into NotificationDetailRequestInviteResponse: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(NotificationDetailVoteToKick).GetProperty("AdditionalProperties") == null)
                {
                    newSentNotificationDetails = new SentNotificationDetails(JsonConvert.DeserializeObject<NotificationDetailVoteToKick>(jsonString, SentNotificationDetails.SerializerSettings));
                }
                else
                {
                    newSentNotificationDetails = new SentNotificationDetails(JsonConvert.DeserializeObject<NotificationDetailVoteToKick>(jsonString, SentNotificationDetails.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("NotificationDetailVoteToKick");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into NotificationDetailVoteToKick: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(Object).GetProperty("AdditionalProperties") == null)
                {
                    newSentNotificationDetails = new SentNotificationDetails(JsonConvert.DeserializeObject<Object>(jsonString, SentNotificationDetails.SerializerSettings));
                }
                else
                {
                    newSentNotificationDetails = new SentNotificationDetails(JsonConvert.DeserializeObject<Object>(jsonString, SentNotificationDetails.AdditionalPropertiesSerializerSettings));
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
            return newSentNotificationDetails;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as SentNotificationDetails);
        }

        /// <summary>
        /// Returns true if SentNotificationDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of SentNotificationDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SentNotificationDetails input)
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
    /// Custom JSON converter for SentNotificationDetails
    /// </summary>
    public class SentNotificationDetailsJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(SentNotificationDetails).GetMethod("ToJson").Invoke(value, null)));
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
                    return SentNotificationDetails.FromJson(JObject.Load(reader).ToString(Formatting.None));
                case JsonToken.StartArray:
                    return SentNotificationDetails.FromJson(JArray.Load(reader).ToString(Formatting.None));
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
