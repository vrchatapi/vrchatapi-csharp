

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
    /// A notification as its sender receives it back. The shape of &#x60;details&#x60; depends on &#x60;type&#x60;.
    /// </summary>
    [JsonConverter(typeof(SentNotificationJsonConverter))]
    [DataContract(Name = "SentNotification")]
    public partial class SentNotification : AbstractOpenAPISchema, IEquatable<SentNotification>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SentNotification" /> class
        /// with the <see cref="SentNotificationBoop" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of SentNotificationBoop.</param>
        public SentNotification(SentNotificationBoop actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SentNotification" /> class
        /// with the <see cref="SentNotificationFriendRequest" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of SentNotificationFriendRequest.</param>
        public SentNotification(SentNotificationFriendRequest actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SentNotification" /> class
        /// with the <see cref="SentNotificationInvite" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of SentNotificationInvite.</param>
        public SentNotification(SentNotificationInvite actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SentNotification" /> class
        /// with the <see cref="SentNotificationInviteResponse" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of SentNotificationInviteResponse.</param>
        public SentNotification(SentNotificationInviteResponse actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SentNotification" /> class
        /// with the <see cref="SentNotificationMessage" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of SentNotificationMessage.</param>
        public SentNotification(SentNotificationMessage actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SentNotification" /> class
        /// with the <see cref="SentNotificationRequestInvite" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of SentNotificationRequestInvite.</param>
        public SentNotification(SentNotificationRequestInvite actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SentNotification" /> class
        /// with the <see cref="SentNotificationRequestInviteResponse" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of SentNotificationRequestInviteResponse.</param>
        public SentNotification(SentNotificationRequestInviteResponse actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SentNotification" /> class
        /// with the <see cref="SentNotificationVoteToKick" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of SentNotificationVoteToKick.</param>
        public SentNotification(SentNotificationVoteToKick actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SentNotification" /> class
        /// with the <see cref="SentNotificationUnknown" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of SentNotificationUnknown.</param>
        public SentNotification(SentNotificationUnknown actualInstance)
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
                if (value.GetType() == typeof(SentNotificationBoop) || value is SentNotificationBoop)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(SentNotificationFriendRequest) || value is SentNotificationFriendRequest)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(SentNotificationInvite) || value is SentNotificationInvite)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(SentNotificationInviteResponse) || value is SentNotificationInviteResponse)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(SentNotificationMessage) || value is SentNotificationMessage)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(SentNotificationRequestInvite) || value is SentNotificationRequestInvite)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(SentNotificationRequestInviteResponse) || value is SentNotificationRequestInviteResponse)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(SentNotificationUnknown) || value is SentNotificationUnknown)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(SentNotificationVoteToKick) || value is SentNotificationVoteToKick)
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
        /// Converts to the <c>SentNotificationBoop</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator SentNotificationBoop(SentNotification value) => (SentNotificationBoop)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>SentNotificationFriendRequest</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator SentNotificationFriendRequest(SentNotification value) => (SentNotificationFriendRequest)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>SentNotificationInvite</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator SentNotificationInvite(SentNotification value) => (SentNotificationInvite)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>SentNotificationInviteResponse</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator SentNotificationInviteResponse(SentNotification value) => (SentNotificationInviteResponse)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>SentNotificationMessage</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator SentNotificationMessage(SentNotification value) => (SentNotificationMessage)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>SentNotificationRequestInvite</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator SentNotificationRequestInvite(SentNotification value) => (SentNotificationRequestInvite)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>SentNotificationRequestInviteResponse</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator SentNotificationRequestInviteResponse(SentNotification value) => (SentNotificationRequestInviteResponse)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>SentNotificationVoteToKick</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator SentNotificationVoteToKick(SentNotification value) => (SentNotificationVoteToKick)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>SentNotificationUnknown</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator SentNotificationUnknown(SentNotification value) => (SentNotificationUnknown)value?.ActualInstance;
        

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SentNotification {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, SentNotification.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of SentNotification
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of SentNotification</returns>
        public static SentNotification FromJson(string jsonString)
        {
            SentNotification newSentNotification = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newSentNotification;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(SentNotificationBoop).GetProperty("AdditionalProperties") == null)
                {
                    newSentNotification = new SentNotification(JsonConvert.DeserializeObject<SentNotificationBoop>(jsonString, SentNotification.SerializerSettings));
                }
                else
                {
                    newSentNotification = new SentNotification(JsonConvert.DeserializeObject<SentNotificationBoop>(jsonString, SentNotification.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("SentNotificationBoop");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into SentNotificationBoop: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(SentNotificationFriendRequest).GetProperty("AdditionalProperties") == null)
                {
                    newSentNotification = new SentNotification(JsonConvert.DeserializeObject<SentNotificationFriendRequest>(jsonString, SentNotification.SerializerSettings));
                }
                else
                {
                    newSentNotification = new SentNotification(JsonConvert.DeserializeObject<SentNotificationFriendRequest>(jsonString, SentNotification.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("SentNotificationFriendRequest");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into SentNotificationFriendRequest: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(SentNotificationInvite).GetProperty("AdditionalProperties") == null)
                {
                    newSentNotification = new SentNotification(JsonConvert.DeserializeObject<SentNotificationInvite>(jsonString, SentNotification.SerializerSettings));
                }
                else
                {
                    newSentNotification = new SentNotification(JsonConvert.DeserializeObject<SentNotificationInvite>(jsonString, SentNotification.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("SentNotificationInvite");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into SentNotificationInvite: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(SentNotificationInviteResponse).GetProperty("AdditionalProperties") == null)
                {
                    newSentNotification = new SentNotification(JsonConvert.DeserializeObject<SentNotificationInviteResponse>(jsonString, SentNotification.SerializerSettings));
                }
                else
                {
                    newSentNotification = new SentNotification(JsonConvert.DeserializeObject<SentNotificationInviteResponse>(jsonString, SentNotification.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("SentNotificationInviteResponse");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into SentNotificationInviteResponse: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(SentNotificationMessage).GetProperty("AdditionalProperties") == null)
                {
                    newSentNotification = new SentNotification(JsonConvert.DeserializeObject<SentNotificationMessage>(jsonString, SentNotification.SerializerSettings));
                }
                else
                {
                    newSentNotification = new SentNotification(JsonConvert.DeserializeObject<SentNotificationMessage>(jsonString, SentNotification.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("SentNotificationMessage");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into SentNotificationMessage: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(SentNotificationRequestInvite).GetProperty("AdditionalProperties") == null)
                {
                    newSentNotification = new SentNotification(JsonConvert.DeserializeObject<SentNotificationRequestInvite>(jsonString, SentNotification.SerializerSettings));
                }
                else
                {
                    newSentNotification = new SentNotification(JsonConvert.DeserializeObject<SentNotificationRequestInvite>(jsonString, SentNotification.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("SentNotificationRequestInvite");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into SentNotificationRequestInvite: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(SentNotificationRequestInviteResponse).GetProperty("AdditionalProperties") == null)
                {
                    newSentNotification = new SentNotification(JsonConvert.DeserializeObject<SentNotificationRequestInviteResponse>(jsonString, SentNotification.SerializerSettings));
                }
                else
                {
                    newSentNotification = new SentNotification(JsonConvert.DeserializeObject<SentNotificationRequestInviteResponse>(jsonString, SentNotification.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("SentNotificationRequestInviteResponse");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into SentNotificationRequestInviteResponse: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(SentNotificationUnknown).GetProperty("AdditionalProperties") == null)
                {
                    newSentNotification = new SentNotification(JsonConvert.DeserializeObject<SentNotificationUnknown>(jsonString, SentNotification.SerializerSettings));
                }
                else
                {
                    newSentNotification = new SentNotification(JsonConvert.DeserializeObject<SentNotificationUnknown>(jsonString, SentNotification.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("SentNotificationUnknown");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into SentNotificationUnknown: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(SentNotificationVoteToKick).GetProperty("AdditionalProperties") == null)
                {
                    newSentNotification = new SentNotification(JsonConvert.DeserializeObject<SentNotificationVoteToKick>(jsonString, SentNotification.SerializerSettings));
                }
                else
                {
                    newSentNotification = new SentNotification(JsonConvert.DeserializeObject<SentNotificationVoteToKick>(jsonString, SentNotification.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("SentNotificationVoteToKick");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into SentNotificationVoteToKick: {1}", jsonString, exception.ToString()));
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
            return newSentNotification;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as SentNotification);
        }

        /// <summary>
        /// Returns true if SentNotification instances are equal
        /// </summary>
        /// <param name="input">Instance of SentNotification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SentNotification input)
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
    /// Custom JSON converter for SentNotification
    /// </summary>
    public class SentNotificationJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(SentNotification).GetMethod("ToJson").Invoke(value, null)));
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
                    return SentNotification.FromJson(JObject.Load(reader).ToString(Formatting.None));
                case JsonToken.StartArray:
                    return SentNotification.FromJson(JArray.Load(reader).ToString(Formatting.None));
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
