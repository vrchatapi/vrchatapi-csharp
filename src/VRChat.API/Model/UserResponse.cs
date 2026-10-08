

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
    /// UserResponse
    /// </summary>
    [JsonConverter(typeof(UserResponseJsonConverter))]
    [DataContract(Name = "UserResponse")]
    public partial class UserResponse : AbstractOpenAPISchema, IEquatable<UserResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserResponse" /> class
        /// with the <see cref="User" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of User.</param>
        public UserResponse(User actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserResponse" /> class
        /// with the <see cref="CurrentUser" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of CurrentUser.</param>
        public UserResponse(CurrentUser actualInstance)
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
                if (value.GetType() == typeof(CurrentUser) || value is CurrentUser)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(User) || value is User)
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
        /// Converts to the <c>User</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator User(UserResponse value) => (User)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>CurrentUser</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator CurrentUser(UserResponse value) => (CurrentUser)value?.ActualInstance;
        

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserResponse {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, UserResponse.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of UserResponse
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of UserResponse</returns>
        public static UserResponse FromJson(string jsonString)
        {
            UserResponse newUserResponse = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newUserResponse;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(CurrentUser).GetProperty("AdditionalProperties") == null)
                {
                    newUserResponse = new UserResponse(JsonConvert.DeserializeObject<CurrentUser>(jsonString, UserResponse.SerializerSettings));
                }
                else
                {
                    newUserResponse = new UserResponse(JsonConvert.DeserializeObject<CurrentUser>(jsonString, UserResponse.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("CurrentUser");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into CurrentUser: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(User).GetProperty("AdditionalProperties") == null)
                {
                    newUserResponse = new UserResponse(JsonConvert.DeserializeObject<User>(jsonString, UserResponse.SerializerSettings));
                }
                else
                {
                    newUserResponse = new UserResponse(JsonConvert.DeserializeObject<User>(jsonString, UserResponse.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("User");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into User: {1}", jsonString, exception.ToString()));
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
            return newUserResponse;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as UserResponse);
        }

        /// <summary>
        /// Returns true if UserResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of UserResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserResponse input)
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
    /// Custom JSON converter for UserResponse
    /// </summary>
    public class UserResponseJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(UserResponse).GetMethod("ToJson").Invoke(value, null)));
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
                    return UserResponse.FromJson(JObject.Load(reader).ToString(Formatting.None));
                case JsonToken.StartArray:
                    return UserResponse.FromJson(JArray.Load(reader).ToString(Formatting.None));
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
