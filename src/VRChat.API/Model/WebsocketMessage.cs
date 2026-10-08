

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
    /// A message received over the websocket. The shape of &#x60;content&#x60; depends on &#x60;type&#x60;.
    /// </summary>
    [JsonConverter(typeof(WebsocketMessageJsonConverter))]
    [DataContract(Name = "WebsocketMessage")]
    public partial class WebsocketMessage : AbstractOpenAPISchema, IEquatable<WebsocketMessage>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebsocketMessage" /> class
        /// with the <see cref="WebsocketClearNotification" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of WebsocketClearNotification.</param>
        public WebsocketMessage(WebsocketClearNotification actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsocketMessage" /> class
        /// with the <see cref="WebsocketContentRefreshEncoded" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of WebsocketContentRefreshEncoded.</param>
        public WebsocketMessage(WebsocketContentRefreshEncoded actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsocketMessage" /> class
        /// with the <see cref="WebsocketFriendActiveEncoded" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of WebsocketFriendActiveEncoded.</param>
        public WebsocketMessage(WebsocketFriendActiveEncoded actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsocketMessage" /> class
        /// with the <see cref="WebsocketFriendAddEncoded" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of WebsocketFriendAddEncoded.</param>
        public WebsocketMessage(WebsocketFriendAddEncoded actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsocketMessage" /> class
        /// with the <see cref="WebsocketFriendDeleteEncoded" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of WebsocketFriendDeleteEncoded.</param>
        public WebsocketMessage(WebsocketFriendDeleteEncoded actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsocketMessage" /> class
        /// with the <see cref="WebsocketFriendLocationEncoded" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of WebsocketFriendLocationEncoded.</param>
        public WebsocketMessage(WebsocketFriendLocationEncoded actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsocketMessage" /> class
        /// with the <see cref="WebsocketFriendOfflineEncoded" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of WebsocketFriendOfflineEncoded.</param>
        public WebsocketMessage(WebsocketFriendOfflineEncoded actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsocketMessage" /> class
        /// with the <see cref="WebsocketFriendOnlineEncoded" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of WebsocketFriendOnlineEncoded.</param>
        public WebsocketMessage(WebsocketFriendOnlineEncoded actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsocketMessage" /> class
        /// with the <see cref="WebsocketFriendUpdateEncoded" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of WebsocketFriendUpdateEncoded.</param>
        public WebsocketMessage(WebsocketFriendUpdateEncoded actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsocketMessage" /> class
        /// with the <see cref="WebsocketGroupJoinedEncoded" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of WebsocketGroupJoinedEncoded.</param>
        public WebsocketMessage(WebsocketGroupJoinedEncoded actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsocketMessage" /> class
        /// with the <see cref="WebsocketGroupLeftEncoded" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of WebsocketGroupLeftEncoded.</param>
        public WebsocketMessage(WebsocketGroupLeftEncoded actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsocketMessage" /> class
        /// with the <see cref="WebsocketGroupMemberUpdatedEncoded" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of WebsocketGroupMemberUpdatedEncoded.</param>
        public WebsocketMessage(WebsocketGroupMemberUpdatedEncoded actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsocketMessage" /> class
        /// with the <see cref="WebsocketGroupRoleUpdatedEncoded" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of WebsocketGroupRoleUpdatedEncoded.</param>
        public WebsocketMessage(WebsocketGroupRoleUpdatedEncoded actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsocketMessage" /> class
        /// with the <see cref="WebsocketHideNotification" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of WebsocketHideNotification.</param>
        public WebsocketMessage(WebsocketHideNotification actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsocketMessage" /> class
        /// with the <see cref="WebsocketInstanceQueueJoinedEncoded" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of WebsocketInstanceQueueJoinedEncoded.</param>
        public WebsocketMessage(WebsocketInstanceQueueJoinedEncoded actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsocketMessage" /> class
        /// with the <see cref="WebsocketInstanceQueueReadyEncoded" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of WebsocketInstanceQueueReadyEncoded.</param>
        public WebsocketMessage(WebsocketInstanceQueueReadyEncoded actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsocketMessage" /> class
        /// with the <see cref="WebsocketNotificationEncoded" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of WebsocketNotificationEncoded.</param>
        public WebsocketMessage(WebsocketNotificationEncoded actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsocketMessage" /> class
        /// with the <see cref="WebsocketNotificationV2Encoded" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of WebsocketNotificationV2Encoded.</param>
        public WebsocketMessage(WebsocketNotificationV2Encoded actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsocketMessage" /> class
        /// with the <see cref="WebsocketNotificationV2DeleteEncoded" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of WebsocketNotificationV2DeleteEncoded.</param>
        public WebsocketMessage(WebsocketNotificationV2DeleteEncoded actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsocketMessage" /> class
        /// with the <see cref="WebsocketNotificationV2UpdateEncoded" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of WebsocketNotificationV2UpdateEncoded.</param>
        public WebsocketMessage(WebsocketNotificationV2UpdateEncoded actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsocketMessage" /> class
        /// with the <see cref="WebsocketResponseNotificationEncoded" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of WebsocketResponseNotificationEncoded.</param>
        public WebsocketMessage(WebsocketResponseNotificationEncoded actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsocketMessage" /> class
        /// with the <see cref="WebsocketSeeNotification" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of WebsocketSeeNotification.</param>
        public WebsocketMessage(WebsocketSeeNotification actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsocketMessage" /> class
        /// with the <see cref="WebsocketUserBadgeAssignedEncoded" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of WebsocketUserBadgeAssignedEncoded.</param>
        public WebsocketMessage(WebsocketUserBadgeAssignedEncoded actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsocketMessage" /> class
        /// with the <see cref="WebsocketUserBadgeUnassignedEncoded" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of WebsocketUserBadgeUnassignedEncoded.</param>
        public WebsocketMessage(WebsocketUserBadgeUnassignedEncoded actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsocketMessage" /> class
        /// with the <see cref="WebsocketUserLocationEncoded" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of WebsocketUserLocationEncoded.</param>
        public WebsocketMessage(WebsocketUserLocationEncoded actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsocketMessage" /> class
        /// with the <see cref="WebsocketUserUpdateEncoded" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of WebsocketUserUpdateEncoded.</param>
        public WebsocketMessage(WebsocketUserUpdateEncoded actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsocketMessage" /> class
        /// with the <see cref="WebsocketMessageUnknown" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of WebsocketMessageUnknown.</param>
        public WebsocketMessage(WebsocketMessageUnknown actualInstance)
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
                if (value.GetType() == typeof(WebsocketClearNotification) || value is WebsocketClearNotification)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(WebsocketContentRefreshEncoded) || value is WebsocketContentRefreshEncoded)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(WebsocketFriendActiveEncoded) || value is WebsocketFriendActiveEncoded)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(WebsocketFriendAddEncoded) || value is WebsocketFriendAddEncoded)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(WebsocketFriendDeleteEncoded) || value is WebsocketFriendDeleteEncoded)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(WebsocketFriendLocationEncoded) || value is WebsocketFriendLocationEncoded)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(WebsocketFriendOfflineEncoded) || value is WebsocketFriendOfflineEncoded)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(WebsocketFriendOnlineEncoded) || value is WebsocketFriendOnlineEncoded)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(WebsocketFriendUpdateEncoded) || value is WebsocketFriendUpdateEncoded)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(WebsocketGroupJoinedEncoded) || value is WebsocketGroupJoinedEncoded)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(WebsocketGroupLeftEncoded) || value is WebsocketGroupLeftEncoded)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(WebsocketGroupMemberUpdatedEncoded) || value is WebsocketGroupMemberUpdatedEncoded)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(WebsocketGroupRoleUpdatedEncoded) || value is WebsocketGroupRoleUpdatedEncoded)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(WebsocketHideNotification) || value is WebsocketHideNotification)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(WebsocketInstanceQueueJoinedEncoded) || value is WebsocketInstanceQueueJoinedEncoded)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(WebsocketInstanceQueueReadyEncoded) || value is WebsocketInstanceQueueReadyEncoded)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(WebsocketMessageUnknown) || value is WebsocketMessageUnknown)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(WebsocketNotificationEncoded) || value is WebsocketNotificationEncoded)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(WebsocketNotificationV2DeleteEncoded) || value is WebsocketNotificationV2DeleteEncoded)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(WebsocketNotificationV2Encoded) || value is WebsocketNotificationV2Encoded)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(WebsocketNotificationV2UpdateEncoded) || value is WebsocketNotificationV2UpdateEncoded)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(WebsocketResponseNotificationEncoded) || value is WebsocketResponseNotificationEncoded)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(WebsocketSeeNotification) || value is WebsocketSeeNotification)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(WebsocketUserBadgeAssignedEncoded) || value is WebsocketUserBadgeAssignedEncoded)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(WebsocketUserBadgeUnassignedEncoded) || value is WebsocketUserBadgeUnassignedEncoded)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(WebsocketUserLocationEncoded) || value is WebsocketUserLocationEncoded)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(WebsocketUserUpdateEncoded) || value is WebsocketUserUpdateEncoded)
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
        /// Converts to the <c>WebsocketClearNotification</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator WebsocketClearNotification(WebsocketMessage value) => (WebsocketClearNotification)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>WebsocketContentRefreshEncoded</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator WebsocketContentRefreshEncoded(WebsocketMessage value) => (WebsocketContentRefreshEncoded)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>WebsocketFriendActiveEncoded</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator WebsocketFriendActiveEncoded(WebsocketMessage value) => (WebsocketFriendActiveEncoded)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>WebsocketFriendAddEncoded</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator WebsocketFriendAddEncoded(WebsocketMessage value) => (WebsocketFriendAddEncoded)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>WebsocketFriendDeleteEncoded</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator WebsocketFriendDeleteEncoded(WebsocketMessage value) => (WebsocketFriendDeleteEncoded)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>WebsocketFriendLocationEncoded</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator WebsocketFriendLocationEncoded(WebsocketMessage value) => (WebsocketFriendLocationEncoded)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>WebsocketFriendOfflineEncoded</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator WebsocketFriendOfflineEncoded(WebsocketMessage value) => (WebsocketFriendOfflineEncoded)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>WebsocketFriendOnlineEncoded</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator WebsocketFriendOnlineEncoded(WebsocketMessage value) => (WebsocketFriendOnlineEncoded)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>WebsocketFriendUpdateEncoded</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator WebsocketFriendUpdateEncoded(WebsocketMessage value) => (WebsocketFriendUpdateEncoded)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>WebsocketGroupJoinedEncoded</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator WebsocketGroupJoinedEncoded(WebsocketMessage value) => (WebsocketGroupJoinedEncoded)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>WebsocketGroupLeftEncoded</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator WebsocketGroupLeftEncoded(WebsocketMessage value) => (WebsocketGroupLeftEncoded)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>WebsocketGroupMemberUpdatedEncoded</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator WebsocketGroupMemberUpdatedEncoded(WebsocketMessage value) => (WebsocketGroupMemberUpdatedEncoded)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>WebsocketGroupRoleUpdatedEncoded</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator WebsocketGroupRoleUpdatedEncoded(WebsocketMessage value) => (WebsocketGroupRoleUpdatedEncoded)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>WebsocketHideNotification</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator WebsocketHideNotification(WebsocketMessage value) => (WebsocketHideNotification)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>WebsocketInstanceQueueJoinedEncoded</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator WebsocketInstanceQueueJoinedEncoded(WebsocketMessage value) => (WebsocketInstanceQueueJoinedEncoded)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>WebsocketInstanceQueueReadyEncoded</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator WebsocketInstanceQueueReadyEncoded(WebsocketMessage value) => (WebsocketInstanceQueueReadyEncoded)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>WebsocketNotificationEncoded</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator WebsocketNotificationEncoded(WebsocketMessage value) => (WebsocketNotificationEncoded)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>WebsocketNotificationV2Encoded</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator WebsocketNotificationV2Encoded(WebsocketMessage value) => (WebsocketNotificationV2Encoded)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>WebsocketNotificationV2DeleteEncoded</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator WebsocketNotificationV2DeleteEncoded(WebsocketMessage value) => (WebsocketNotificationV2DeleteEncoded)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>WebsocketNotificationV2UpdateEncoded</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator WebsocketNotificationV2UpdateEncoded(WebsocketMessage value) => (WebsocketNotificationV2UpdateEncoded)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>WebsocketResponseNotificationEncoded</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator WebsocketResponseNotificationEncoded(WebsocketMessage value) => (WebsocketResponseNotificationEncoded)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>WebsocketSeeNotification</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator WebsocketSeeNotification(WebsocketMessage value) => (WebsocketSeeNotification)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>WebsocketUserBadgeAssignedEncoded</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator WebsocketUserBadgeAssignedEncoded(WebsocketMessage value) => (WebsocketUserBadgeAssignedEncoded)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>WebsocketUserBadgeUnassignedEncoded</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator WebsocketUserBadgeUnassignedEncoded(WebsocketMessage value) => (WebsocketUserBadgeUnassignedEncoded)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>WebsocketUserLocationEncoded</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator WebsocketUserLocationEncoded(WebsocketMessage value) => (WebsocketUserLocationEncoded)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>WebsocketUserUpdateEncoded</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator WebsocketUserUpdateEncoded(WebsocketMessage value) => (WebsocketUserUpdateEncoded)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>WebsocketMessageUnknown</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator WebsocketMessageUnknown(WebsocketMessage value) => (WebsocketMessageUnknown)value?.ActualInstance;
        

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebsocketMessage {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, WebsocketMessage.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of WebsocketMessage
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of WebsocketMessage</returns>
        public static WebsocketMessage FromJson(string jsonString)
        {
            WebsocketMessage newWebsocketMessage = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newWebsocketMessage;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(WebsocketClearNotification).GetProperty("AdditionalProperties") == null)
                {
                    newWebsocketMessage = new WebsocketMessage(JsonConvert.DeserializeObject<WebsocketClearNotification>(jsonString, WebsocketMessage.SerializerSettings));
                }
                else
                {
                    newWebsocketMessage = new WebsocketMessage(JsonConvert.DeserializeObject<WebsocketClearNotification>(jsonString, WebsocketMessage.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("WebsocketClearNotification");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into WebsocketClearNotification: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(WebsocketContentRefreshEncoded).GetProperty("AdditionalProperties") == null)
                {
                    newWebsocketMessage = new WebsocketMessage(JsonConvert.DeserializeObject<WebsocketContentRefreshEncoded>(jsonString, WebsocketMessage.SerializerSettings));
                }
                else
                {
                    newWebsocketMessage = new WebsocketMessage(JsonConvert.DeserializeObject<WebsocketContentRefreshEncoded>(jsonString, WebsocketMessage.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("WebsocketContentRefreshEncoded");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into WebsocketContentRefreshEncoded: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(WebsocketFriendActiveEncoded).GetProperty("AdditionalProperties") == null)
                {
                    newWebsocketMessage = new WebsocketMessage(JsonConvert.DeserializeObject<WebsocketFriendActiveEncoded>(jsonString, WebsocketMessage.SerializerSettings));
                }
                else
                {
                    newWebsocketMessage = new WebsocketMessage(JsonConvert.DeserializeObject<WebsocketFriendActiveEncoded>(jsonString, WebsocketMessage.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("WebsocketFriendActiveEncoded");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into WebsocketFriendActiveEncoded: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(WebsocketFriendAddEncoded).GetProperty("AdditionalProperties") == null)
                {
                    newWebsocketMessage = new WebsocketMessage(JsonConvert.DeserializeObject<WebsocketFriendAddEncoded>(jsonString, WebsocketMessage.SerializerSettings));
                }
                else
                {
                    newWebsocketMessage = new WebsocketMessage(JsonConvert.DeserializeObject<WebsocketFriendAddEncoded>(jsonString, WebsocketMessage.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("WebsocketFriendAddEncoded");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into WebsocketFriendAddEncoded: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(WebsocketFriendDeleteEncoded).GetProperty("AdditionalProperties") == null)
                {
                    newWebsocketMessage = new WebsocketMessage(JsonConvert.DeserializeObject<WebsocketFriendDeleteEncoded>(jsonString, WebsocketMessage.SerializerSettings));
                }
                else
                {
                    newWebsocketMessage = new WebsocketMessage(JsonConvert.DeserializeObject<WebsocketFriendDeleteEncoded>(jsonString, WebsocketMessage.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("WebsocketFriendDeleteEncoded");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into WebsocketFriendDeleteEncoded: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(WebsocketFriendLocationEncoded).GetProperty("AdditionalProperties") == null)
                {
                    newWebsocketMessage = new WebsocketMessage(JsonConvert.DeserializeObject<WebsocketFriendLocationEncoded>(jsonString, WebsocketMessage.SerializerSettings));
                }
                else
                {
                    newWebsocketMessage = new WebsocketMessage(JsonConvert.DeserializeObject<WebsocketFriendLocationEncoded>(jsonString, WebsocketMessage.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("WebsocketFriendLocationEncoded");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into WebsocketFriendLocationEncoded: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(WebsocketFriendOfflineEncoded).GetProperty("AdditionalProperties") == null)
                {
                    newWebsocketMessage = new WebsocketMessage(JsonConvert.DeserializeObject<WebsocketFriendOfflineEncoded>(jsonString, WebsocketMessage.SerializerSettings));
                }
                else
                {
                    newWebsocketMessage = new WebsocketMessage(JsonConvert.DeserializeObject<WebsocketFriendOfflineEncoded>(jsonString, WebsocketMessage.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("WebsocketFriendOfflineEncoded");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into WebsocketFriendOfflineEncoded: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(WebsocketFriendOnlineEncoded).GetProperty("AdditionalProperties") == null)
                {
                    newWebsocketMessage = new WebsocketMessage(JsonConvert.DeserializeObject<WebsocketFriendOnlineEncoded>(jsonString, WebsocketMessage.SerializerSettings));
                }
                else
                {
                    newWebsocketMessage = new WebsocketMessage(JsonConvert.DeserializeObject<WebsocketFriendOnlineEncoded>(jsonString, WebsocketMessage.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("WebsocketFriendOnlineEncoded");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into WebsocketFriendOnlineEncoded: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(WebsocketFriendUpdateEncoded).GetProperty("AdditionalProperties") == null)
                {
                    newWebsocketMessage = new WebsocketMessage(JsonConvert.DeserializeObject<WebsocketFriendUpdateEncoded>(jsonString, WebsocketMessage.SerializerSettings));
                }
                else
                {
                    newWebsocketMessage = new WebsocketMessage(JsonConvert.DeserializeObject<WebsocketFriendUpdateEncoded>(jsonString, WebsocketMessage.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("WebsocketFriendUpdateEncoded");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into WebsocketFriendUpdateEncoded: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(WebsocketGroupJoinedEncoded).GetProperty("AdditionalProperties") == null)
                {
                    newWebsocketMessage = new WebsocketMessage(JsonConvert.DeserializeObject<WebsocketGroupJoinedEncoded>(jsonString, WebsocketMessage.SerializerSettings));
                }
                else
                {
                    newWebsocketMessage = new WebsocketMessage(JsonConvert.DeserializeObject<WebsocketGroupJoinedEncoded>(jsonString, WebsocketMessage.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("WebsocketGroupJoinedEncoded");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into WebsocketGroupJoinedEncoded: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(WebsocketGroupLeftEncoded).GetProperty("AdditionalProperties") == null)
                {
                    newWebsocketMessage = new WebsocketMessage(JsonConvert.DeserializeObject<WebsocketGroupLeftEncoded>(jsonString, WebsocketMessage.SerializerSettings));
                }
                else
                {
                    newWebsocketMessage = new WebsocketMessage(JsonConvert.DeserializeObject<WebsocketGroupLeftEncoded>(jsonString, WebsocketMessage.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("WebsocketGroupLeftEncoded");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into WebsocketGroupLeftEncoded: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(WebsocketGroupMemberUpdatedEncoded).GetProperty("AdditionalProperties") == null)
                {
                    newWebsocketMessage = new WebsocketMessage(JsonConvert.DeserializeObject<WebsocketGroupMemberUpdatedEncoded>(jsonString, WebsocketMessage.SerializerSettings));
                }
                else
                {
                    newWebsocketMessage = new WebsocketMessage(JsonConvert.DeserializeObject<WebsocketGroupMemberUpdatedEncoded>(jsonString, WebsocketMessage.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("WebsocketGroupMemberUpdatedEncoded");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into WebsocketGroupMemberUpdatedEncoded: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(WebsocketGroupRoleUpdatedEncoded).GetProperty("AdditionalProperties") == null)
                {
                    newWebsocketMessage = new WebsocketMessage(JsonConvert.DeserializeObject<WebsocketGroupRoleUpdatedEncoded>(jsonString, WebsocketMessage.SerializerSettings));
                }
                else
                {
                    newWebsocketMessage = new WebsocketMessage(JsonConvert.DeserializeObject<WebsocketGroupRoleUpdatedEncoded>(jsonString, WebsocketMessage.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("WebsocketGroupRoleUpdatedEncoded");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into WebsocketGroupRoleUpdatedEncoded: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(WebsocketHideNotification).GetProperty("AdditionalProperties") == null)
                {
                    newWebsocketMessage = new WebsocketMessage(JsonConvert.DeserializeObject<WebsocketHideNotification>(jsonString, WebsocketMessage.SerializerSettings));
                }
                else
                {
                    newWebsocketMessage = new WebsocketMessage(JsonConvert.DeserializeObject<WebsocketHideNotification>(jsonString, WebsocketMessage.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("WebsocketHideNotification");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into WebsocketHideNotification: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(WebsocketInstanceQueueJoinedEncoded).GetProperty("AdditionalProperties") == null)
                {
                    newWebsocketMessage = new WebsocketMessage(JsonConvert.DeserializeObject<WebsocketInstanceQueueJoinedEncoded>(jsonString, WebsocketMessage.SerializerSettings));
                }
                else
                {
                    newWebsocketMessage = new WebsocketMessage(JsonConvert.DeserializeObject<WebsocketInstanceQueueJoinedEncoded>(jsonString, WebsocketMessage.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("WebsocketInstanceQueueJoinedEncoded");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into WebsocketInstanceQueueJoinedEncoded: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(WebsocketInstanceQueueReadyEncoded).GetProperty("AdditionalProperties") == null)
                {
                    newWebsocketMessage = new WebsocketMessage(JsonConvert.DeserializeObject<WebsocketInstanceQueueReadyEncoded>(jsonString, WebsocketMessage.SerializerSettings));
                }
                else
                {
                    newWebsocketMessage = new WebsocketMessage(JsonConvert.DeserializeObject<WebsocketInstanceQueueReadyEncoded>(jsonString, WebsocketMessage.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("WebsocketInstanceQueueReadyEncoded");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into WebsocketInstanceQueueReadyEncoded: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(WebsocketMessageUnknown).GetProperty("AdditionalProperties") == null)
                {
                    newWebsocketMessage = new WebsocketMessage(JsonConvert.DeserializeObject<WebsocketMessageUnknown>(jsonString, WebsocketMessage.SerializerSettings));
                }
                else
                {
                    newWebsocketMessage = new WebsocketMessage(JsonConvert.DeserializeObject<WebsocketMessageUnknown>(jsonString, WebsocketMessage.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("WebsocketMessageUnknown");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into WebsocketMessageUnknown: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(WebsocketNotificationEncoded).GetProperty("AdditionalProperties") == null)
                {
                    newWebsocketMessage = new WebsocketMessage(JsonConvert.DeserializeObject<WebsocketNotificationEncoded>(jsonString, WebsocketMessage.SerializerSettings));
                }
                else
                {
                    newWebsocketMessage = new WebsocketMessage(JsonConvert.DeserializeObject<WebsocketNotificationEncoded>(jsonString, WebsocketMessage.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("WebsocketNotificationEncoded");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into WebsocketNotificationEncoded: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(WebsocketNotificationV2DeleteEncoded).GetProperty("AdditionalProperties") == null)
                {
                    newWebsocketMessage = new WebsocketMessage(JsonConvert.DeserializeObject<WebsocketNotificationV2DeleteEncoded>(jsonString, WebsocketMessage.SerializerSettings));
                }
                else
                {
                    newWebsocketMessage = new WebsocketMessage(JsonConvert.DeserializeObject<WebsocketNotificationV2DeleteEncoded>(jsonString, WebsocketMessage.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("WebsocketNotificationV2DeleteEncoded");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into WebsocketNotificationV2DeleteEncoded: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(WebsocketNotificationV2Encoded).GetProperty("AdditionalProperties") == null)
                {
                    newWebsocketMessage = new WebsocketMessage(JsonConvert.DeserializeObject<WebsocketNotificationV2Encoded>(jsonString, WebsocketMessage.SerializerSettings));
                }
                else
                {
                    newWebsocketMessage = new WebsocketMessage(JsonConvert.DeserializeObject<WebsocketNotificationV2Encoded>(jsonString, WebsocketMessage.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("WebsocketNotificationV2Encoded");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into WebsocketNotificationV2Encoded: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(WebsocketNotificationV2UpdateEncoded).GetProperty("AdditionalProperties") == null)
                {
                    newWebsocketMessage = new WebsocketMessage(JsonConvert.DeserializeObject<WebsocketNotificationV2UpdateEncoded>(jsonString, WebsocketMessage.SerializerSettings));
                }
                else
                {
                    newWebsocketMessage = new WebsocketMessage(JsonConvert.DeserializeObject<WebsocketNotificationV2UpdateEncoded>(jsonString, WebsocketMessage.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("WebsocketNotificationV2UpdateEncoded");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into WebsocketNotificationV2UpdateEncoded: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(WebsocketResponseNotificationEncoded).GetProperty("AdditionalProperties") == null)
                {
                    newWebsocketMessage = new WebsocketMessage(JsonConvert.DeserializeObject<WebsocketResponseNotificationEncoded>(jsonString, WebsocketMessage.SerializerSettings));
                }
                else
                {
                    newWebsocketMessage = new WebsocketMessage(JsonConvert.DeserializeObject<WebsocketResponseNotificationEncoded>(jsonString, WebsocketMessage.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("WebsocketResponseNotificationEncoded");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into WebsocketResponseNotificationEncoded: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(WebsocketSeeNotification).GetProperty("AdditionalProperties") == null)
                {
                    newWebsocketMessage = new WebsocketMessage(JsonConvert.DeserializeObject<WebsocketSeeNotification>(jsonString, WebsocketMessage.SerializerSettings));
                }
                else
                {
                    newWebsocketMessage = new WebsocketMessage(JsonConvert.DeserializeObject<WebsocketSeeNotification>(jsonString, WebsocketMessage.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("WebsocketSeeNotification");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into WebsocketSeeNotification: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(WebsocketUserBadgeAssignedEncoded).GetProperty("AdditionalProperties") == null)
                {
                    newWebsocketMessage = new WebsocketMessage(JsonConvert.DeserializeObject<WebsocketUserBadgeAssignedEncoded>(jsonString, WebsocketMessage.SerializerSettings));
                }
                else
                {
                    newWebsocketMessage = new WebsocketMessage(JsonConvert.DeserializeObject<WebsocketUserBadgeAssignedEncoded>(jsonString, WebsocketMessage.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("WebsocketUserBadgeAssignedEncoded");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into WebsocketUserBadgeAssignedEncoded: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(WebsocketUserBadgeUnassignedEncoded).GetProperty("AdditionalProperties") == null)
                {
                    newWebsocketMessage = new WebsocketMessage(JsonConvert.DeserializeObject<WebsocketUserBadgeUnassignedEncoded>(jsonString, WebsocketMessage.SerializerSettings));
                }
                else
                {
                    newWebsocketMessage = new WebsocketMessage(JsonConvert.DeserializeObject<WebsocketUserBadgeUnassignedEncoded>(jsonString, WebsocketMessage.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("WebsocketUserBadgeUnassignedEncoded");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into WebsocketUserBadgeUnassignedEncoded: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(WebsocketUserLocationEncoded).GetProperty("AdditionalProperties") == null)
                {
                    newWebsocketMessage = new WebsocketMessage(JsonConvert.DeserializeObject<WebsocketUserLocationEncoded>(jsonString, WebsocketMessage.SerializerSettings));
                }
                else
                {
                    newWebsocketMessage = new WebsocketMessage(JsonConvert.DeserializeObject<WebsocketUserLocationEncoded>(jsonString, WebsocketMessage.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("WebsocketUserLocationEncoded");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into WebsocketUserLocationEncoded: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(WebsocketUserUpdateEncoded).GetProperty("AdditionalProperties") == null)
                {
                    newWebsocketMessage = new WebsocketMessage(JsonConvert.DeserializeObject<WebsocketUserUpdateEncoded>(jsonString, WebsocketMessage.SerializerSettings));
                }
                else
                {
                    newWebsocketMessage = new WebsocketMessage(JsonConvert.DeserializeObject<WebsocketUserUpdateEncoded>(jsonString, WebsocketMessage.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("WebsocketUserUpdateEncoded");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into WebsocketUserUpdateEncoded: {1}", jsonString, exception.ToString()));
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
            return newWebsocketMessage;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as WebsocketMessage);
        }

        /// <summary>
        /// Returns true if WebsocketMessage instances are equal
        /// </summary>
        /// <param name="input">Instance of WebsocketMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebsocketMessage input)
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
    /// Custom JSON converter for WebsocketMessage
    /// </summary>
    public class WebsocketMessageJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(WebsocketMessage).GetMethod("ToJson").Invoke(value, null)));
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
                    return WebsocketMessage.FromJson(JObject.Load(reader).ToString(Formatting.None));
                case JsonToken.StartArray:
                    return WebsocketMessage.FromJson(JArray.Load(reader).ToString(Formatting.None));
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
