

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
    /// A notification. The shape of &#x60;details&#x60; depends on &#x60;type&#x60;.
    /// </summary>
    [JsonConverter(typeof(NotificationJsonConverter))]
    [DataContract(Name = "Notification")]
    public partial class Notification : AbstractOpenAPISchema, IEquatable<Notification>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Notification" /> class
        /// with the <see cref="NotificationBoop" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of NotificationBoop.</param>
        public Notification(NotificationBoop actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Notification" /> class
        /// with the <see cref="NotificationFriendRequest" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of NotificationFriendRequest.</param>
        public Notification(NotificationFriendRequest actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Notification" /> class
        /// with the <see cref="NotificationInvite" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of NotificationInvite.</param>
        public Notification(NotificationInvite actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Notification" /> class
        /// with the <see cref="NotificationInviteResponse" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of NotificationInviteResponse.</param>
        public Notification(NotificationInviteResponse actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Notification" /> class
        /// with the <see cref="NotificationMessage" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of NotificationMessage.</param>
        public Notification(NotificationMessage actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Notification" /> class
        /// with the <see cref="NotificationRequestInvite" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of NotificationRequestInvite.</param>
        public Notification(NotificationRequestInvite actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Notification" /> class
        /// with the <see cref="NotificationRequestInviteResponse" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of NotificationRequestInviteResponse.</param>
        public Notification(NotificationRequestInviteResponse actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Notification" /> class
        /// with the <see cref="NotificationVoteToKick" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of NotificationVoteToKick.</param>
        public Notification(NotificationVoteToKick actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Notification" /> class
        /// with the <see cref="NotificationUnknown" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of NotificationUnknown.</param>
        public Notification(NotificationUnknown actualInstance)
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
                if (value.GetType() == typeof(NotificationBoop) || value is NotificationBoop)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(NotificationFriendRequest) || value is NotificationFriendRequest)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(NotificationInvite) || value is NotificationInvite)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(NotificationInviteResponse) || value is NotificationInviteResponse)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(NotificationMessage) || value is NotificationMessage)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(NotificationRequestInvite) || value is NotificationRequestInvite)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(NotificationRequestInviteResponse) || value is NotificationRequestInviteResponse)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(NotificationUnknown) || value is NotificationUnknown)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(NotificationVoteToKick) || value is NotificationVoteToKick)
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
        /// Converts to the <c>NotificationBoop</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator NotificationBoop(Notification value) => (NotificationBoop)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>NotificationFriendRequest</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator NotificationFriendRequest(Notification value) => (NotificationFriendRequest)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>NotificationInvite</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator NotificationInvite(Notification value) => (NotificationInvite)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>NotificationInviteResponse</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator NotificationInviteResponse(Notification value) => (NotificationInviteResponse)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>NotificationMessage</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator NotificationMessage(Notification value) => (NotificationMessage)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>NotificationRequestInvite</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator NotificationRequestInvite(Notification value) => (NotificationRequestInvite)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>NotificationRequestInviteResponse</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator NotificationRequestInviteResponse(Notification value) => (NotificationRequestInviteResponse)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>NotificationVoteToKick</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator NotificationVoteToKick(Notification value) => (NotificationVoteToKick)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>NotificationUnknown</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator NotificationUnknown(Notification value) => (NotificationUnknown)value?.ActualInstance;
        

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Notification {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, Notification.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of Notification
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of Notification</returns>
        public static Notification FromJson(string jsonString)
        {
            Notification newNotification = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newNotification;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(NotificationBoop).GetProperty("AdditionalProperties") == null)
                {
                    newNotification = new Notification(JsonConvert.DeserializeObject<NotificationBoop>(jsonString, Notification.SerializerSettings));
                }
                else
                {
                    newNotification = new Notification(JsonConvert.DeserializeObject<NotificationBoop>(jsonString, Notification.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("NotificationBoop");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into NotificationBoop: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(NotificationFriendRequest).GetProperty("AdditionalProperties") == null)
                {
                    newNotification = new Notification(JsonConvert.DeserializeObject<NotificationFriendRequest>(jsonString, Notification.SerializerSettings));
                }
                else
                {
                    newNotification = new Notification(JsonConvert.DeserializeObject<NotificationFriendRequest>(jsonString, Notification.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("NotificationFriendRequest");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into NotificationFriendRequest: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(NotificationInvite).GetProperty("AdditionalProperties") == null)
                {
                    newNotification = new Notification(JsonConvert.DeserializeObject<NotificationInvite>(jsonString, Notification.SerializerSettings));
                }
                else
                {
                    newNotification = new Notification(JsonConvert.DeserializeObject<NotificationInvite>(jsonString, Notification.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("NotificationInvite");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into NotificationInvite: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(NotificationInviteResponse).GetProperty("AdditionalProperties") == null)
                {
                    newNotification = new Notification(JsonConvert.DeserializeObject<NotificationInviteResponse>(jsonString, Notification.SerializerSettings));
                }
                else
                {
                    newNotification = new Notification(JsonConvert.DeserializeObject<NotificationInviteResponse>(jsonString, Notification.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("NotificationInviteResponse");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into NotificationInviteResponse: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(NotificationMessage).GetProperty("AdditionalProperties") == null)
                {
                    newNotification = new Notification(JsonConvert.DeserializeObject<NotificationMessage>(jsonString, Notification.SerializerSettings));
                }
                else
                {
                    newNotification = new Notification(JsonConvert.DeserializeObject<NotificationMessage>(jsonString, Notification.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("NotificationMessage");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into NotificationMessage: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(NotificationRequestInvite).GetProperty("AdditionalProperties") == null)
                {
                    newNotification = new Notification(JsonConvert.DeserializeObject<NotificationRequestInvite>(jsonString, Notification.SerializerSettings));
                }
                else
                {
                    newNotification = new Notification(JsonConvert.DeserializeObject<NotificationRequestInvite>(jsonString, Notification.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("NotificationRequestInvite");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into NotificationRequestInvite: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(NotificationRequestInviteResponse).GetProperty("AdditionalProperties") == null)
                {
                    newNotification = new Notification(JsonConvert.DeserializeObject<NotificationRequestInviteResponse>(jsonString, Notification.SerializerSettings));
                }
                else
                {
                    newNotification = new Notification(JsonConvert.DeserializeObject<NotificationRequestInviteResponse>(jsonString, Notification.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("NotificationRequestInviteResponse");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into NotificationRequestInviteResponse: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(NotificationUnknown).GetProperty("AdditionalProperties") == null)
                {
                    newNotification = new Notification(JsonConvert.DeserializeObject<NotificationUnknown>(jsonString, Notification.SerializerSettings));
                }
                else
                {
                    newNotification = new Notification(JsonConvert.DeserializeObject<NotificationUnknown>(jsonString, Notification.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("NotificationUnknown");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into NotificationUnknown: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(NotificationVoteToKick).GetProperty("AdditionalProperties") == null)
                {
                    newNotification = new Notification(JsonConvert.DeserializeObject<NotificationVoteToKick>(jsonString, Notification.SerializerSettings));
                }
                else
                {
                    newNotification = new Notification(JsonConvert.DeserializeObject<NotificationVoteToKick>(jsonString, Notification.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("NotificationVoteToKick");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into NotificationVoteToKick: {1}", jsonString, exception.ToString()));
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
            return newNotification;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Notification);
        }

        /// <summary>
        /// Returns true if Notification instances are equal
        /// </summary>
        /// <param name="input">Instance of Notification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Notification input)
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
    /// Custom JSON converter for Notification
    /// </summary>
    public class NotificationJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(Notification).GetMethod("ToJson").Invoke(value, null)));
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
                    return Notification.FromJson(JObject.Load(reader).ToString(Formatting.None));
                case JsonToken.StartArray:
                    return Notification.FromJson(JArray.Load(reader).ToString(Formatting.None));
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
