

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
    /// A notification delivered over the websocket. The shape of &#x60;details&#x60; depends on &#x60;type&#x60;.
    /// </summary>
    [JsonConverter(typeof(WebsocketNotificationJsonConverter))]
    [DataContract(Name = "WebsocketNotification")]
    public partial class WebsocketNotification : AbstractOpenAPISchema, IEquatable<WebsocketNotification>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebsocketNotification" /> class
        /// with the <see cref="WebsocketNotificationDetailBoop" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of WebsocketNotificationDetailBoop.</param>
        public WebsocketNotification(WebsocketNotificationDetailBoop actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsocketNotification" /> class
        /// with the <see cref="WebsocketNotificationDetailInvite" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of WebsocketNotificationDetailInvite.</param>
        public WebsocketNotification(WebsocketNotificationDetailInvite actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsocketNotification" /> class
        /// with the <see cref="WebsocketNotificationDetailInviteResponse" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of WebsocketNotificationDetailInviteResponse.</param>
        public WebsocketNotification(WebsocketNotificationDetailInviteResponse actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsocketNotification" /> class
        /// with the <see cref="WebsocketNotificationDetailRequestInvite" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of WebsocketNotificationDetailRequestInvite.</param>
        public WebsocketNotification(WebsocketNotificationDetailRequestInvite actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsocketNotification" /> class
        /// with the <see cref="WebsocketNotificationDetailRequestInviteResponse" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of WebsocketNotificationDetailRequestInviteResponse.</param>
        public WebsocketNotification(WebsocketNotificationDetailRequestInviteResponse actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsocketNotification" /> class
        /// with the <see cref="WebsocketNotificationDetailVoteToKick" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of WebsocketNotificationDetailVoteToKick.</param>
        public WebsocketNotification(WebsocketNotificationDetailVoteToKick actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsocketNotification" /> class
        /// with the <see cref="WebsocketNotificationUnknown" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of WebsocketNotificationUnknown.</param>
        public WebsocketNotification(WebsocketNotificationUnknown actualInstance)
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
                if (value.GetType() == typeof(WebsocketNotificationDetailBoop) || value is WebsocketNotificationDetailBoop)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(WebsocketNotificationDetailInvite) || value is WebsocketNotificationDetailInvite)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(WebsocketNotificationDetailInviteResponse) || value is WebsocketNotificationDetailInviteResponse)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(WebsocketNotificationDetailRequestInvite) || value is WebsocketNotificationDetailRequestInvite)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(WebsocketNotificationDetailRequestInviteResponse) || value is WebsocketNotificationDetailRequestInviteResponse)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(WebsocketNotificationDetailVoteToKick) || value is WebsocketNotificationDetailVoteToKick)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(WebsocketNotificationUnknown) || value is WebsocketNotificationUnknown)
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
        /// Converts to the <c>WebsocketNotificationDetailBoop</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator WebsocketNotificationDetailBoop(WebsocketNotification value) => (WebsocketNotificationDetailBoop)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>WebsocketNotificationDetailInvite</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator WebsocketNotificationDetailInvite(WebsocketNotification value) => (WebsocketNotificationDetailInvite)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>WebsocketNotificationDetailInviteResponse</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator WebsocketNotificationDetailInviteResponse(WebsocketNotification value) => (WebsocketNotificationDetailInviteResponse)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>WebsocketNotificationDetailRequestInvite</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator WebsocketNotificationDetailRequestInvite(WebsocketNotification value) => (WebsocketNotificationDetailRequestInvite)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>WebsocketNotificationDetailRequestInviteResponse</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator WebsocketNotificationDetailRequestInviteResponse(WebsocketNotification value) => (WebsocketNotificationDetailRequestInviteResponse)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>WebsocketNotificationDetailVoteToKick</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator WebsocketNotificationDetailVoteToKick(WebsocketNotification value) => (WebsocketNotificationDetailVoteToKick)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>WebsocketNotificationUnknown</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator WebsocketNotificationUnknown(WebsocketNotification value) => (WebsocketNotificationUnknown)value?.ActualInstance;
        

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebsocketNotification {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, WebsocketNotification.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of WebsocketNotification
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of WebsocketNotification</returns>
        public static WebsocketNotification FromJson(string jsonString)
        {
            WebsocketNotification newWebsocketNotification = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newWebsocketNotification;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(WebsocketNotificationDetailBoop).GetProperty("AdditionalProperties") == null)
                {
                    newWebsocketNotification = new WebsocketNotification(JsonConvert.DeserializeObject<WebsocketNotificationDetailBoop>(jsonString, WebsocketNotification.SerializerSettings));
                }
                else
                {
                    newWebsocketNotification = new WebsocketNotification(JsonConvert.DeserializeObject<WebsocketNotificationDetailBoop>(jsonString, WebsocketNotification.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("WebsocketNotificationDetailBoop");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into WebsocketNotificationDetailBoop: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(WebsocketNotificationDetailInvite).GetProperty("AdditionalProperties") == null)
                {
                    newWebsocketNotification = new WebsocketNotification(JsonConvert.DeserializeObject<WebsocketNotificationDetailInvite>(jsonString, WebsocketNotification.SerializerSettings));
                }
                else
                {
                    newWebsocketNotification = new WebsocketNotification(JsonConvert.DeserializeObject<WebsocketNotificationDetailInvite>(jsonString, WebsocketNotification.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("WebsocketNotificationDetailInvite");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into WebsocketNotificationDetailInvite: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(WebsocketNotificationDetailInviteResponse).GetProperty("AdditionalProperties") == null)
                {
                    newWebsocketNotification = new WebsocketNotification(JsonConvert.DeserializeObject<WebsocketNotificationDetailInviteResponse>(jsonString, WebsocketNotification.SerializerSettings));
                }
                else
                {
                    newWebsocketNotification = new WebsocketNotification(JsonConvert.DeserializeObject<WebsocketNotificationDetailInviteResponse>(jsonString, WebsocketNotification.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("WebsocketNotificationDetailInviteResponse");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into WebsocketNotificationDetailInviteResponse: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(WebsocketNotificationDetailRequestInvite).GetProperty("AdditionalProperties") == null)
                {
                    newWebsocketNotification = new WebsocketNotification(JsonConvert.DeserializeObject<WebsocketNotificationDetailRequestInvite>(jsonString, WebsocketNotification.SerializerSettings));
                }
                else
                {
                    newWebsocketNotification = new WebsocketNotification(JsonConvert.DeserializeObject<WebsocketNotificationDetailRequestInvite>(jsonString, WebsocketNotification.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("WebsocketNotificationDetailRequestInvite");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into WebsocketNotificationDetailRequestInvite: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(WebsocketNotificationDetailRequestInviteResponse).GetProperty("AdditionalProperties") == null)
                {
                    newWebsocketNotification = new WebsocketNotification(JsonConvert.DeserializeObject<WebsocketNotificationDetailRequestInviteResponse>(jsonString, WebsocketNotification.SerializerSettings));
                }
                else
                {
                    newWebsocketNotification = new WebsocketNotification(JsonConvert.DeserializeObject<WebsocketNotificationDetailRequestInviteResponse>(jsonString, WebsocketNotification.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("WebsocketNotificationDetailRequestInviteResponse");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into WebsocketNotificationDetailRequestInviteResponse: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(WebsocketNotificationDetailVoteToKick).GetProperty("AdditionalProperties") == null)
                {
                    newWebsocketNotification = new WebsocketNotification(JsonConvert.DeserializeObject<WebsocketNotificationDetailVoteToKick>(jsonString, WebsocketNotification.SerializerSettings));
                }
                else
                {
                    newWebsocketNotification = new WebsocketNotification(JsonConvert.DeserializeObject<WebsocketNotificationDetailVoteToKick>(jsonString, WebsocketNotification.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("WebsocketNotificationDetailVoteToKick");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into WebsocketNotificationDetailVoteToKick: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(WebsocketNotificationUnknown).GetProperty("AdditionalProperties") == null)
                {
                    newWebsocketNotification = new WebsocketNotification(JsonConvert.DeserializeObject<WebsocketNotificationUnknown>(jsonString, WebsocketNotification.SerializerSettings));
                }
                else
                {
                    newWebsocketNotification = new WebsocketNotification(JsonConvert.DeserializeObject<WebsocketNotificationUnknown>(jsonString, WebsocketNotification.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("WebsocketNotificationUnknown");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into WebsocketNotificationUnknown: {1}", jsonString, exception.ToString()));
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
            return newWebsocketNotification;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as WebsocketNotification);
        }

        /// <summary>
        /// Returns true if WebsocketNotification instances are equal
        /// </summary>
        /// <param name="input">Instance of WebsocketNotification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebsocketNotification input)
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
    /// Custom JSON converter for WebsocketNotification
    /// </summary>
    public class WebsocketNotificationJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(WebsocketNotification).GetMethod("ToJson").Invoke(value, null)));
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
                    return WebsocketNotification.FromJson(JObject.Load(reader).ToString(Formatting.None));
                case JsonToken.StartArray:
                    return WebsocketNotification.FromJson(JArray.Load(reader).ToString(Formatting.None));
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
