

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
    /// A group audit log entry. The shape of &#x60;data&#x60; depends on &#x60;eventType&#x60;.
    /// </summary>
    [JsonConverter(typeof(GroupAuditLogJsonConverter))]
    [DataContract(Name = "GroupAuditLog")]
    public partial class GroupAuditLog : AbstractOpenAPISchema, IEquatable<GroupAuditLog>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLog" /> class
        /// with the <see cref="GroupAuditLogGroupAnnouncement" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GroupAuditLogGroupAnnouncement.</param>
        public GroupAuditLog(GroupAuditLogGroupAnnouncement actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLog" /> class
        /// with the <see cref="GroupAuditLogGroupCalendarEventCreate" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GroupAuditLogGroupCalendarEventCreate.</param>
        public GroupAuditLog(GroupAuditLogGroupCalendarEventCreate actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLog" /> class
        /// with the <see cref="GroupAuditLogGroupCalendarEventDelete" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GroupAuditLogGroupCalendarEventDelete.</param>
        public GroupAuditLog(GroupAuditLogGroupCalendarEventDelete actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLog" /> class
        /// with the <see cref="GroupAuditLogGroupCreate" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GroupAuditLogGroupCreate.</param>
        public GroupAuditLog(GroupAuditLogGroupCreate actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLog" /> class
        /// with the <see cref="GroupAuditLogGroupGalleryCreate" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GroupAuditLogGroupGalleryCreate.</param>
        public GroupAuditLog(GroupAuditLogGroupGalleryCreate actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLog" /> class
        /// with the <see cref="GroupAuditLogGroupGalleryDelete" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GroupAuditLogGroupGalleryDelete.</param>
        public GroupAuditLog(GroupAuditLogGroupGalleryDelete actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLog" /> class
        /// with the <see cref="GroupAuditLogGroupGalleryUpdate" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GroupAuditLogGroupGalleryUpdate.</param>
        public GroupAuditLog(GroupAuditLogGroupGalleryUpdate actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLog" /> class
        /// with the <see cref="GroupAuditLogGroupInstanceAnnouncement" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GroupAuditLogGroupInstanceAnnouncement.</param>
        public GroupAuditLog(GroupAuditLogGroupInstanceAnnouncement actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLog" /> class
        /// with the <see cref="GroupAuditLogGroupInstanceClose" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GroupAuditLogGroupInstanceClose.</param>
        public GroupAuditLog(GroupAuditLogGroupInstanceClose actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLog" /> class
        /// with the <see cref="GroupAuditLogGroupInstanceCreate" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GroupAuditLogGroupInstanceCreate.</param>
        public GroupAuditLog(GroupAuditLogGroupInstanceCreate actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLog" /> class
        /// with the <see cref="GroupAuditLogGroupInstanceKick" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GroupAuditLogGroupInstanceKick.</param>
        public GroupAuditLog(GroupAuditLogGroupInstanceKick actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLog" /> class
        /// with the <see cref="GroupAuditLogGroupInstanceWarn" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GroupAuditLogGroupInstanceWarn.</param>
        public GroupAuditLog(GroupAuditLogGroupInstanceWarn actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLog" /> class
        /// with the <see cref="GroupAuditLogGroupInviteCancel" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GroupAuditLogGroupInviteCancel.</param>
        public GroupAuditLog(GroupAuditLogGroupInviteCancel actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLog" /> class
        /// with the <see cref="GroupAuditLogGroupInviteCreate" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GroupAuditLogGroupInviteCreate.</param>
        public GroupAuditLog(GroupAuditLogGroupInviteCreate actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLog" /> class
        /// with the <see cref="GroupAuditLogGroupMemberJoin" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GroupAuditLogGroupMemberJoin.</param>
        public GroupAuditLog(GroupAuditLogGroupMemberJoin actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLog" /> class
        /// with the <see cref="GroupAuditLogGroupMemberLeave" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GroupAuditLogGroupMemberLeave.</param>
        public GroupAuditLog(GroupAuditLogGroupMemberLeave actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLog" /> class
        /// with the <see cref="GroupAuditLogGroupMemberRemove" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GroupAuditLogGroupMemberRemove.</param>
        public GroupAuditLog(GroupAuditLogGroupMemberRemove actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLog" /> class
        /// with the <see cref="GroupAuditLogGroupMemberRoleAssign" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GroupAuditLogGroupMemberRoleAssign.</param>
        public GroupAuditLog(GroupAuditLogGroupMemberRoleAssign actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLog" /> class
        /// with the <see cref="GroupAuditLogGroupMemberRoleUnassign" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GroupAuditLogGroupMemberRoleUnassign.</param>
        public GroupAuditLog(GroupAuditLogGroupMemberRoleUnassign actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLog" /> class
        /// with the <see cref="GroupAuditLogGroupMemberUserUpdate" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GroupAuditLogGroupMemberUserUpdate.</param>
        public GroupAuditLog(GroupAuditLogGroupMemberUserUpdate actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLog" /> class
        /// with the <see cref="GroupAuditLogGroupPostCreate" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GroupAuditLogGroupPostCreate.</param>
        public GroupAuditLog(GroupAuditLogGroupPostCreate actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLog" /> class
        /// with the <see cref="GroupAuditLogGroupPostDelete" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GroupAuditLogGroupPostDelete.</param>
        public GroupAuditLog(GroupAuditLogGroupPostDelete actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLog" /> class
        /// with the <see cref="GroupAuditLogGroupPostUpdate" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GroupAuditLogGroupPostUpdate.</param>
        public GroupAuditLog(GroupAuditLogGroupPostUpdate actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLog" /> class
        /// with the <see cref="GroupAuditLogGroupRequestBlock" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GroupAuditLogGroupRequestBlock.</param>
        public GroupAuditLog(GroupAuditLogGroupRequestBlock actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLog" /> class
        /// with the <see cref="GroupAuditLogGroupRequestCreate" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GroupAuditLogGroupRequestCreate.</param>
        public GroupAuditLog(GroupAuditLogGroupRequestCreate actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLog" /> class
        /// with the <see cref="GroupAuditLogGroupRequestReject" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GroupAuditLogGroupRequestReject.</param>
        public GroupAuditLog(GroupAuditLogGroupRequestReject actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLog" /> class
        /// with the <see cref="GroupAuditLogGroupRequestWithdraw" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GroupAuditLogGroupRequestWithdraw.</param>
        public GroupAuditLog(GroupAuditLogGroupRequestWithdraw actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLog" /> class
        /// with the <see cref="GroupAuditLogGroupRoleCreate" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GroupAuditLogGroupRoleCreate.</param>
        public GroupAuditLog(GroupAuditLogGroupRoleCreate actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLog" /> class
        /// with the <see cref="GroupAuditLogGroupRoleDelete" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GroupAuditLogGroupRoleDelete.</param>
        public GroupAuditLog(GroupAuditLogGroupRoleDelete actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLog" /> class
        /// with the <see cref="GroupAuditLogGroupRoleUpdate" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GroupAuditLogGroupRoleUpdate.</param>
        public GroupAuditLog(GroupAuditLogGroupRoleUpdate actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLog" /> class
        /// with the <see cref="GroupAuditLogGroupUpdate" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GroupAuditLogGroupUpdate.</param>
        public GroupAuditLog(GroupAuditLogGroupUpdate actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLog" /> class
        /// with the <see cref="GroupAuditLogGroupUserBan" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GroupAuditLogGroupUserBan.</param>
        public GroupAuditLog(GroupAuditLogGroupUserBan actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLog" /> class
        /// with the <see cref="GroupAuditLogGroupUserUnban" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GroupAuditLogGroupUserUnban.</param>
        public GroupAuditLog(GroupAuditLogGroupUserUnban actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLog" /> class
        /// with the <see cref="GroupAuditLogUnknown" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GroupAuditLogUnknown.</param>
        public GroupAuditLog(GroupAuditLogUnknown actualInstance)
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
                if (value.GetType() == typeof(GroupAuditLogGroupAnnouncement) || value is GroupAuditLogGroupAnnouncement)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GroupAuditLogGroupCalendarEventCreate) || value is GroupAuditLogGroupCalendarEventCreate)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GroupAuditLogGroupCalendarEventDelete) || value is GroupAuditLogGroupCalendarEventDelete)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GroupAuditLogGroupCreate) || value is GroupAuditLogGroupCreate)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GroupAuditLogGroupGalleryCreate) || value is GroupAuditLogGroupGalleryCreate)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GroupAuditLogGroupGalleryDelete) || value is GroupAuditLogGroupGalleryDelete)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GroupAuditLogGroupGalleryUpdate) || value is GroupAuditLogGroupGalleryUpdate)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GroupAuditLogGroupInstanceAnnouncement) || value is GroupAuditLogGroupInstanceAnnouncement)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GroupAuditLogGroupInstanceClose) || value is GroupAuditLogGroupInstanceClose)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GroupAuditLogGroupInstanceCreate) || value is GroupAuditLogGroupInstanceCreate)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GroupAuditLogGroupInstanceKick) || value is GroupAuditLogGroupInstanceKick)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GroupAuditLogGroupInstanceWarn) || value is GroupAuditLogGroupInstanceWarn)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GroupAuditLogGroupInviteCancel) || value is GroupAuditLogGroupInviteCancel)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GroupAuditLogGroupInviteCreate) || value is GroupAuditLogGroupInviteCreate)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GroupAuditLogGroupMemberJoin) || value is GroupAuditLogGroupMemberJoin)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GroupAuditLogGroupMemberLeave) || value is GroupAuditLogGroupMemberLeave)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GroupAuditLogGroupMemberRemove) || value is GroupAuditLogGroupMemberRemove)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GroupAuditLogGroupMemberRoleAssign) || value is GroupAuditLogGroupMemberRoleAssign)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GroupAuditLogGroupMemberRoleUnassign) || value is GroupAuditLogGroupMemberRoleUnassign)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GroupAuditLogGroupMemberUserUpdate) || value is GroupAuditLogGroupMemberUserUpdate)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GroupAuditLogGroupPostCreate) || value is GroupAuditLogGroupPostCreate)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GroupAuditLogGroupPostDelete) || value is GroupAuditLogGroupPostDelete)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GroupAuditLogGroupPostUpdate) || value is GroupAuditLogGroupPostUpdate)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GroupAuditLogGroupRequestBlock) || value is GroupAuditLogGroupRequestBlock)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GroupAuditLogGroupRequestCreate) || value is GroupAuditLogGroupRequestCreate)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GroupAuditLogGroupRequestReject) || value is GroupAuditLogGroupRequestReject)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GroupAuditLogGroupRequestWithdraw) || value is GroupAuditLogGroupRequestWithdraw)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GroupAuditLogGroupRoleCreate) || value is GroupAuditLogGroupRoleCreate)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GroupAuditLogGroupRoleDelete) || value is GroupAuditLogGroupRoleDelete)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GroupAuditLogGroupRoleUpdate) || value is GroupAuditLogGroupRoleUpdate)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GroupAuditLogGroupUpdate) || value is GroupAuditLogGroupUpdate)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GroupAuditLogGroupUserBan) || value is GroupAuditLogGroupUserBan)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GroupAuditLogGroupUserUnban) || value is GroupAuditLogGroupUserUnban)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GroupAuditLogUnknown) || value is GroupAuditLogUnknown)
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
        /// Converts to the <c>GroupAuditLogGroupAnnouncement</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator GroupAuditLogGroupAnnouncement(GroupAuditLog value) => (GroupAuditLogGroupAnnouncement)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>GroupAuditLogGroupCalendarEventCreate</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator GroupAuditLogGroupCalendarEventCreate(GroupAuditLog value) => (GroupAuditLogGroupCalendarEventCreate)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>GroupAuditLogGroupCalendarEventDelete</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator GroupAuditLogGroupCalendarEventDelete(GroupAuditLog value) => (GroupAuditLogGroupCalendarEventDelete)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>GroupAuditLogGroupCreate</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator GroupAuditLogGroupCreate(GroupAuditLog value) => (GroupAuditLogGroupCreate)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>GroupAuditLogGroupGalleryCreate</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator GroupAuditLogGroupGalleryCreate(GroupAuditLog value) => (GroupAuditLogGroupGalleryCreate)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>GroupAuditLogGroupGalleryDelete</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator GroupAuditLogGroupGalleryDelete(GroupAuditLog value) => (GroupAuditLogGroupGalleryDelete)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>GroupAuditLogGroupGalleryUpdate</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator GroupAuditLogGroupGalleryUpdate(GroupAuditLog value) => (GroupAuditLogGroupGalleryUpdate)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>GroupAuditLogGroupInstanceAnnouncement</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator GroupAuditLogGroupInstanceAnnouncement(GroupAuditLog value) => (GroupAuditLogGroupInstanceAnnouncement)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>GroupAuditLogGroupInstanceClose</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator GroupAuditLogGroupInstanceClose(GroupAuditLog value) => (GroupAuditLogGroupInstanceClose)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>GroupAuditLogGroupInstanceCreate</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator GroupAuditLogGroupInstanceCreate(GroupAuditLog value) => (GroupAuditLogGroupInstanceCreate)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>GroupAuditLogGroupInstanceKick</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator GroupAuditLogGroupInstanceKick(GroupAuditLog value) => (GroupAuditLogGroupInstanceKick)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>GroupAuditLogGroupInstanceWarn</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator GroupAuditLogGroupInstanceWarn(GroupAuditLog value) => (GroupAuditLogGroupInstanceWarn)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>GroupAuditLogGroupInviteCancel</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator GroupAuditLogGroupInviteCancel(GroupAuditLog value) => (GroupAuditLogGroupInviteCancel)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>GroupAuditLogGroupInviteCreate</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator GroupAuditLogGroupInviteCreate(GroupAuditLog value) => (GroupAuditLogGroupInviteCreate)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>GroupAuditLogGroupMemberJoin</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator GroupAuditLogGroupMemberJoin(GroupAuditLog value) => (GroupAuditLogGroupMemberJoin)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>GroupAuditLogGroupMemberLeave</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator GroupAuditLogGroupMemberLeave(GroupAuditLog value) => (GroupAuditLogGroupMemberLeave)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>GroupAuditLogGroupMemberRemove</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator GroupAuditLogGroupMemberRemove(GroupAuditLog value) => (GroupAuditLogGroupMemberRemove)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>GroupAuditLogGroupMemberRoleAssign</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator GroupAuditLogGroupMemberRoleAssign(GroupAuditLog value) => (GroupAuditLogGroupMemberRoleAssign)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>GroupAuditLogGroupMemberRoleUnassign</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator GroupAuditLogGroupMemberRoleUnassign(GroupAuditLog value) => (GroupAuditLogGroupMemberRoleUnassign)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>GroupAuditLogGroupMemberUserUpdate</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator GroupAuditLogGroupMemberUserUpdate(GroupAuditLog value) => (GroupAuditLogGroupMemberUserUpdate)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>GroupAuditLogGroupPostCreate</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator GroupAuditLogGroupPostCreate(GroupAuditLog value) => (GroupAuditLogGroupPostCreate)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>GroupAuditLogGroupPostDelete</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator GroupAuditLogGroupPostDelete(GroupAuditLog value) => (GroupAuditLogGroupPostDelete)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>GroupAuditLogGroupPostUpdate</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator GroupAuditLogGroupPostUpdate(GroupAuditLog value) => (GroupAuditLogGroupPostUpdate)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>GroupAuditLogGroupRequestBlock</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator GroupAuditLogGroupRequestBlock(GroupAuditLog value) => (GroupAuditLogGroupRequestBlock)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>GroupAuditLogGroupRequestCreate</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator GroupAuditLogGroupRequestCreate(GroupAuditLog value) => (GroupAuditLogGroupRequestCreate)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>GroupAuditLogGroupRequestReject</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator GroupAuditLogGroupRequestReject(GroupAuditLog value) => (GroupAuditLogGroupRequestReject)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>GroupAuditLogGroupRequestWithdraw</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator GroupAuditLogGroupRequestWithdraw(GroupAuditLog value) => (GroupAuditLogGroupRequestWithdraw)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>GroupAuditLogGroupRoleCreate</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator GroupAuditLogGroupRoleCreate(GroupAuditLog value) => (GroupAuditLogGroupRoleCreate)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>GroupAuditLogGroupRoleDelete</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator GroupAuditLogGroupRoleDelete(GroupAuditLog value) => (GroupAuditLogGroupRoleDelete)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>GroupAuditLogGroupRoleUpdate</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator GroupAuditLogGroupRoleUpdate(GroupAuditLog value) => (GroupAuditLogGroupRoleUpdate)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>GroupAuditLogGroupUpdate</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator GroupAuditLogGroupUpdate(GroupAuditLog value) => (GroupAuditLogGroupUpdate)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>GroupAuditLogGroupUserBan</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator GroupAuditLogGroupUserBan(GroupAuditLog value) => (GroupAuditLogGroupUserBan)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>GroupAuditLogGroupUserUnban</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator GroupAuditLogGroupUserUnban(GroupAuditLog value) => (GroupAuditLogGroupUserUnban)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>GroupAuditLogUnknown</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator GroupAuditLogUnknown(GroupAuditLog value) => (GroupAuditLogUnknown)value?.ActualInstance;
        

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GroupAuditLog {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, GroupAuditLog.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of GroupAuditLog
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of GroupAuditLog</returns>
        public static GroupAuditLog FromJson(string jsonString)
        {
            GroupAuditLog newGroupAuditLog = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newGroupAuditLog;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GroupAuditLogGroupAnnouncement).GetProperty("AdditionalProperties") == null)
                {
                    newGroupAuditLog = new GroupAuditLog(JsonConvert.DeserializeObject<GroupAuditLogGroupAnnouncement>(jsonString, GroupAuditLog.SerializerSettings));
                }
                else
                {
                    newGroupAuditLog = new GroupAuditLog(JsonConvert.DeserializeObject<GroupAuditLogGroupAnnouncement>(jsonString, GroupAuditLog.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GroupAuditLogGroupAnnouncement");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GroupAuditLogGroupAnnouncement: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GroupAuditLogGroupCalendarEventCreate).GetProperty("AdditionalProperties") == null)
                {
                    newGroupAuditLog = new GroupAuditLog(JsonConvert.DeserializeObject<GroupAuditLogGroupCalendarEventCreate>(jsonString, GroupAuditLog.SerializerSettings));
                }
                else
                {
                    newGroupAuditLog = new GroupAuditLog(JsonConvert.DeserializeObject<GroupAuditLogGroupCalendarEventCreate>(jsonString, GroupAuditLog.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GroupAuditLogGroupCalendarEventCreate");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GroupAuditLogGroupCalendarEventCreate: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GroupAuditLogGroupCalendarEventDelete).GetProperty("AdditionalProperties") == null)
                {
                    newGroupAuditLog = new GroupAuditLog(JsonConvert.DeserializeObject<GroupAuditLogGroupCalendarEventDelete>(jsonString, GroupAuditLog.SerializerSettings));
                }
                else
                {
                    newGroupAuditLog = new GroupAuditLog(JsonConvert.DeserializeObject<GroupAuditLogGroupCalendarEventDelete>(jsonString, GroupAuditLog.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GroupAuditLogGroupCalendarEventDelete");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GroupAuditLogGroupCalendarEventDelete: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GroupAuditLogGroupCreate).GetProperty("AdditionalProperties") == null)
                {
                    newGroupAuditLog = new GroupAuditLog(JsonConvert.DeserializeObject<GroupAuditLogGroupCreate>(jsonString, GroupAuditLog.SerializerSettings));
                }
                else
                {
                    newGroupAuditLog = new GroupAuditLog(JsonConvert.DeserializeObject<GroupAuditLogGroupCreate>(jsonString, GroupAuditLog.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GroupAuditLogGroupCreate");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GroupAuditLogGroupCreate: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GroupAuditLogGroupGalleryCreate).GetProperty("AdditionalProperties") == null)
                {
                    newGroupAuditLog = new GroupAuditLog(JsonConvert.DeserializeObject<GroupAuditLogGroupGalleryCreate>(jsonString, GroupAuditLog.SerializerSettings));
                }
                else
                {
                    newGroupAuditLog = new GroupAuditLog(JsonConvert.DeserializeObject<GroupAuditLogGroupGalleryCreate>(jsonString, GroupAuditLog.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GroupAuditLogGroupGalleryCreate");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GroupAuditLogGroupGalleryCreate: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GroupAuditLogGroupGalleryDelete).GetProperty("AdditionalProperties") == null)
                {
                    newGroupAuditLog = new GroupAuditLog(JsonConvert.DeserializeObject<GroupAuditLogGroupGalleryDelete>(jsonString, GroupAuditLog.SerializerSettings));
                }
                else
                {
                    newGroupAuditLog = new GroupAuditLog(JsonConvert.DeserializeObject<GroupAuditLogGroupGalleryDelete>(jsonString, GroupAuditLog.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GroupAuditLogGroupGalleryDelete");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GroupAuditLogGroupGalleryDelete: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GroupAuditLogGroupGalleryUpdate).GetProperty("AdditionalProperties") == null)
                {
                    newGroupAuditLog = new GroupAuditLog(JsonConvert.DeserializeObject<GroupAuditLogGroupGalleryUpdate>(jsonString, GroupAuditLog.SerializerSettings));
                }
                else
                {
                    newGroupAuditLog = new GroupAuditLog(JsonConvert.DeserializeObject<GroupAuditLogGroupGalleryUpdate>(jsonString, GroupAuditLog.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GroupAuditLogGroupGalleryUpdate");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GroupAuditLogGroupGalleryUpdate: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GroupAuditLogGroupInstanceAnnouncement).GetProperty("AdditionalProperties") == null)
                {
                    newGroupAuditLog = new GroupAuditLog(JsonConvert.DeserializeObject<GroupAuditLogGroupInstanceAnnouncement>(jsonString, GroupAuditLog.SerializerSettings));
                }
                else
                {
                    newGroupAuditLog = new GroupAuditLog(JsonConvert.DeserializeObject<GroupAuditLogGroupInstanceAnnouncement>(jsonString, GroupAuditLog.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GroupAuditLogGroupInstanceAnnouncement");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GroupAuditLogGroupInstanceAnnouncement: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GroupAuditLogGroupInstanceClose).GetProperty("AdditionalProperties") == null)
                {
                    newGroupAuditLog = new GroupAuditLog(JsonConvert.DeserializeObject<GroupAuditLogGroupInstanceClose>(jsonString, GroupAuditLog.SerializerSettings));
                }
                else
                {
                    newGroupAuditLog = new GroupAuditLog(JsonConvert.DeserializeObject<GroupAuditLogGroupInstanceClose>(jsonString, GroupAuditLog.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GroupAuditLogGroupInstanceClose");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GroupAuditLogGroupInstanceClose: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GroupAuditLogGroupInstanceCreate).GetProperty("AdditionalProperties") == null)
                {
                    newGroupAuditLog = new GroupAuditLog(JsonConvert.DeserializeObject<GroupAuditLogGroupInstanceCreate>(jsonString, GroupAuditLog.SerializerSettings));
                }
                else
                {
                    newGroupAuditLog = new GroupAuditLog(JsonConvert.DeserializeObject<GroupAuditLogGroupInstanceCreate>(jsonString, GroupAuditLog.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GroupAuditLogGroupInstanceCreate");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GroupAuditLogGroupInstanceCreate: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GroupAuditLogGroupInstanceKick).GetProperty("AdditionalProperties") == null)
                {
                    newGroupAuditLog = new GroupAuditLog(JsonConvert.DeserializeObject<GroupAuditLogGroupInstanceKick>(jsonString, GroupAuditLog.SerializerSettings));
                }
                else
                {
                    newGroupAuditLog = new GroupAuditLog(JsonConvert.DeserializeObject<GroupAuditLogGroupInstanceKick>(jsonString, GroupAuditLog.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GroupAuditLogGroupInstanceKick");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GroupAuditLogGroupInstanceKick: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GroupAuditLogGroupInstanceWarn).GetProperty("AdditionalProperties") == null)
                {
                    newGroupAuditLog = new GroupAuditLog(JsonConvert.DeserializeObject<GroupAuditLogGroupInstanceWarn>(jsonString, GroupAuditLog.SerializerSettings));
                }
                else
                {
                    newGroupAuditLog = new GroupAuditLog(JsonConvert.DeserializeObject<GroupAuditLogGroupInstanceWarn>(jsonString, GroupAuditLog.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GroupAuditLogGroupInstanceWarn");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GroupAuditLogGroupInstanceWarn: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GroupAuditLogGroupInviteCancel).GetProperty("AdditionalProperties") == null)
                {
                    newGroupAuditLog = new GroupAuditLog(JsonConvert.DeserializeObject<GroupAuditLogGroupInviteCancel>(jsonString, GroupAuditLog.SerializerSettings));
                }
                else
                {
                    newGroupAuditLog = new GroupAuditLog(JsonConvert.DeserializeObject<GroupAuditLogGroupInviteCancel>(jsonString, GroupAuditLog.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GroupAuditLogGroupInviteCancel");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GroupAuditLogGroupInviteCancel: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GroupAuditLogGroupInviteCreate).GetProperty("AdditionalProperties") == null)
                {
                    newGroupAuditLog = new GroupAuditLog(JsonConvert.DeserializeObject<GroupAuditLogGroupInviteCreate>(jsonString, GroupAuditLog.SerializerSettings));
                }
                else
                {
                    newGroupAuditLog = new GroupAuditLog(JsonConvert.DeserializeObject<GroupAuditLogGroupInviteCreate>(jsonString, GroupAuditLog.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GroupAuditLogGroupInviteCreate");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GroupAuditLogGroupInviteCreate: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GroupAuditLogGroupMemberJoin).GetProperty("AdditionalProperties") == null)
                {
                    newGroupAuditLog = new GroupAuditLog(JsonConvert.DeserializeObject<GroupAuditLogGroupMemberJoin>(jsonString, GroupAuditLog.SerializerSettings));
                }
                else
                {
                    newGroupAuditLog = new GroupAuditLog(JsonConvert.DeserializeObject<GroupAuditLogGroupMemberJoin>(jsonString, GroupAuditLog.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GroupAuditLogGroupMemberJoin");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GroupAuditLogGroupMemberJoin: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GroupAuditLogGroupMemberLeave).GetProperty("AdditionalProperties") == null)
                {
                    newGroupAuditLog = new GroupAuditLog(JsonConvert.DeserializeObject<GroupAuditLogGroupMemberLeave>(jsonString, GroupAuditLog.SerializerSettings));
                }
                else
                {
                    newGroupAuditLog = new GroupAuditLog(JsonConvert.DeserializeObject<GroupAuditLogGroupMemberLeave>(jsonString, GroupAuditLog.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GroupAuditLogGroupMemberLeave");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GroupAuditLogGroupMemberLeave: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GroupAuditLogGroupMemberRemove).GetProperty("AdditionalProperties") == null)
                {
                    newGroupAuditLog = new GroupAuditLog(JsonConvert.DeserializeObject<GroupAuditLogGroupMemberRemove>(jsonString, GroupAuditLog.SerializerSettings));
                }
                else
                {
                    newGroupAuditLog = new GroupAuditLog(JsonConvert.DeserializeObject<GroupAuditLogGroupMemberRemove>(jsonString, GroupAuditLog.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GroupAuditLogGroupMemberRemove");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GroupAuditLogGroupMemberRemove: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GroupAuditLogGroupMemberRoleAssign).GetProperty("AdditionalProperties") == null)
                {
                    newGroupAuditLog = new GroupAuditLog(JsonConvert.DeserializeObject<GroupAuditLogGroupMemberRoleAssign>(jsonString, GroupAuditLog.SerializerSettings));
                }
                else
                {
                    newGroupAuditLog = new GroupAuditLog(JsonConvert.DeserializeObject<GroupAuditLogGroupMemberRoleAssign>(jsonString, GroupAuditLog.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GroupAuditLogGroupMemberRoleAssign");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GroupAuditLogGroupMemberRoleAssign: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GroupAuditLogGroupMemberRoleUnassign).GetProperty("AdditionalProperties") == null)
                {
                    newGroupAuditLog = new GroupAuditLog(JsonConvert.DeserializeObject<GroupAuditLogGroupMemberRoleUnassign>(jsonString, GroupAuditLog.SerializerSettings));
                }
                else
                {
                    newGroupAuditLog = new GroupAuditLog(JsonConvert.DeserializeObject<GroupAuditLogGroupMemberRoleUnassign>(jsonString, GroupAuditLog.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GroupAuditLogGroupMemberRoleUnassign");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GroupAuditLogGroupMemberRoleUnassign: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GroupAuditLogGroupMemberUserUpdate).GetProperty("AdditionalProperties") == null)
                {
                    newGroupAuditLog = new GroupAuditLog(JsonConvert.DeserializeObject<GroupAuditLogGroupMemberUserUpdate>(jsonString, GroupAuditLog.SerializerSettings));
                }
                else
                {
                    newGroupAuditLog = new GroupAuditLog(JsonConvert.DeserializeObject<GroupAuditLogGroupMemberUserUpdate>(jsonString, GroupAuditLog.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GroupAuditLogGroupMemberUserUpdate");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GroupAuditLogGroupMemberUserUpdate: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GroupAuditLogGroupPostCreate).GetProperty("AdditionalProperties") == null)
                {
                    newGroupAuditLog = new GroupAuditLog(JsonConvert.DeserializeObject<GroupAuditLogGroupPostCreate>(jsonString, GroupAuditLog.SerializerSettings));
                }
                else
                {
                    newGroupAuditLog = new GroupAuditLog(JsonConvert.DeserializeObject<GroupAuditLogGroupPostCreate>(jsonString, GroupAuditLog.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GroupAuditLogGroupPostCreate");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GroupAuditLogGroupPostCreate: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GroupAuditLogGroupPostDelete).GetProperty("AdditionalProperties") == null)
                {
                    newGroupAuditLog = new GroupAuditLog(JsonConvert.DeserializeObject<GroupAuditLogGroupPostDelete>(jsonString, GroupAuditLog.SerializerSettings));
                }
                else
                {
                    newGroupAuditLog = new GroupAuditLog(JsonConvert.DeserializeObject<GroupAuditLogGroupPostDelete>(jsonString, GroupAuditLog.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GroupAuditLogGroupPostDelete");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GroupAuditLogGroupPostDelete: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GroupAuditLogGroupPostUpdate).GetProperty("AdditionalProperties") == null)
                {
                    newGroupAuditLog = new GroupAuditLog(JsonConvert.DeserializeObject<GroupAuditLogGroupPostUpdate>(jsonString, GroupAuditLog.SerializerSettings));
                }
                else
                {
                    newGroupAuditLog = new GroupAuditLog(JsonConvert.DeserializeObject<GroupAuditLogGroupPostUpdate>(jsonString, GroupAuditLog.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GroupAuditLogGroupPostUpdate");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GroupAuditLogGroupPostUpdate: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GroupAuditLogGroupRequestBlock).GetProperty("AdditionalProperties") == null)
                {
                    newGroupAuditLog = new GroupAuditLog(JsonConvert.DeserializeObject<GroupAuditLogGroupRequestBlock>(jsonString, GroupAuditLog.SerializerSettings));
                }
                else
                {
                    newGroupAuditLog = new GroupAuditLog(JsonConvert.DeserializeObject<GroupAuditLogGroupRequestBlock>(jsonString, GroupAuditLog.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GroupAuditLogGroupRequestBlock");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GroupAuditLogGroupRequestBlock: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GroupAuditLogGroupRequestCreate).GetProperty("AdditionalProperties") == null)
                {
                    newGroupAuditLog = new GroupAuditLog(JsonConvert.DeserializeObject<GroupAuditLogGroupRequestCreate>(jsonString, GroupAuditLog.SerializerSettings));
                }
                else
                {
                    newGroupAuditLog = new GroupAuditLog(JsonConvert.DeserializeObject<GroupAuditLogGroupRequestCreate>(jsonString, GroupAuditLog.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GroupAuditLogGroupRequestCreate");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GroupAuditLogGroupRequestCreate: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GroupAuditLogGroupRequestReject).GetProperty("AdditionalProperties") == null)
                {
                    newGroupAuditLog = new GroupAuditLog(JsonConvert.DeserializeObject<GroupAuditLogGroupRequestReject>(jsonString, GroupAuditLog.SerializerSettings));
                }
                else
                {
                    newGroupAuditLog = new GroupAuditLog(JsonConvert.DeserializeObject<GroupAuditLogGroupRequestReject>(jsonString, GroupAuditLog.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GroupAuditLogGroupRequestReject");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GroupAuditLogGroupRequestReject: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GroupAuditLogGroupRequestWithdraw).GetProperty("AdditionalProperties") == null)
                {
                    newGroupAuditLog = new GroupAuditLog(JsonConvert.DeserializeObject<GroupAuditLogGroupRequestWithdraw>(jsonString, GroupAuditLog.SerializerSettings));
                }
                else
                {
                    newGroupAuditLog = new GroupAuditLog(JsonConvert.DeserializeObject<GroupAuditLogGroupRequestWithdraw>(jsonString, GroupAuditLog.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GroupAuditLogGroupRequestWithdraw");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GroupAuditLogGroupRequestWithdraw: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GroupAuditLogGroupRoleCreate).GetProperty("AdditionalProperties") == null)
                {
                    newGroupAuditLog = new GroupAuditLog(JsonConvert.DeserializeObject<GroupAuditLogGroupRoleCreate>(jsonString, GroupAuditLog.SerializerSettings));
                }
                else
                {
                    newGroupAuditLog = new GroupAuditLog(JsonConvert.DeserializeObject<GroupAuditLogGroupRoleCreate>(jsonString, GroupAuditLog.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GroupAuditLogGroupRoleCreate");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GroupAuditLogGroupRoleCreate: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GroupAuditLogGroupRoleDelete).GetProperty("AdditionalProperties") == null)
                {
                    newGroupAuditLog = new GroupAuditLog(JsonConvert.DeserializeObject<GroupAuditLogGroupRoleDelete>(jsonString, GroupAuditLog.SerializerSettings));
                }
                else
                {
                    newGroupAuditLog = new GroupAuditLog(JsonConvert.DeserializeObject<GroupAuditLogGroupRoleDelete>(jsonString, GroupAuditLog.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GroupAuditLogGroupRoleDelete");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GroupAuditLogGroupRoleDelete: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GroupAuditLogGroupRoleUpdate).GetProperty("AdditionalProperties") == null)
                {
                    newGroupAuditLog = new GroupAuditLog(JsonConvert.DeserializeObject<GroupAuditLogGroupRoleUpdate>(jsonString, GroupAuditLog.SerializerSettings));
                }
                else
                {
                    newGroupAuditLog = new GroupAuditLog(JsonConvert.DeserializeObject<GroupAuditLogGroupRoleUpdate>(jsonString, GroupAuditLog.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GroupAuditLogGroupRoleUpdate");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GroupAuditLogGroupRoleUpdate: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GroupAuditLogGroupUpdate).GetProperty("AdditionalProperties") == null)
                {
                    newGroupAuditLog = new GroupAuditLog(JsonConvert.DeserializeObject<GroupAuditLogGroupUpdate>(jsonString, GroupAuditLog.SerializerSettings));
                }
                else
                {
                    newGroupAuditLog = new GroupAuditLog(JsonConvert.DeserializeObject<GroupAuditLogGroupUpdate>(jsonString, GroupAuditLog.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GroupAuditLogGroupUpdate");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GroupAuditLogGroupUpdate: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GroupAuditLogGroupUserBan).GetProperty("AdditionalProperties") == null)
                {
                    newGroupAuditLog = new GroupAuditLog(JsonConvert.DeserializeObject<GroupAuditLogGroupUserBan>(jsonString, GroupAuditLog.SerializerSettings));
                }
                else
                {
                    newGroupAuditLog = new GroupAuditLog(JsonConvert.DeserializeObject<GroupAuditLogGroupUserBan>(jsonString, GroupAuditLog.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GroupAuditLogGroupUserBan");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GroupAuditLogGroupUserBan: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GroupAuditLogGroupUserUnban).GetProperty("AdditionalProperties") == null)
                {
                    newGroupAuditLog = new GroupAuditLog(JsonConvert.DeserializeObject<GroupAuditLogGroupUserUnban>(jsonString, GroupAuditLog.SerializerSettings));
                }
                else
                {
                    newGroupAuditLog = new GroupAuditLog(JsonConvert.DeserializeObject<GroupAuditLogGroupUserUnban>(jsonString, GroupAuditLog.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GroupAuditLogGroupUserUnban");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GroupAuditLogGroupUserUnban: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GroupAuditLogUnknown).GetProperty("AdditionalProperties") == null)
                {
                    newGroupAuditLog = new GroupAuditLog(JsonConvert.DeserializeObject<GroupAuditLogUnknown>(jsonString, GroupAuditLog.SerializerSettings));
                }
                else
                {
                    newGroupAuditLog = new GroupAuditLog(JsonConvert.DeserializeObject<GroupAuditLogUnknown>(jsonString, GroupAuditLog.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GroupAuditLogUnknown");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GroupAuditLogUnknown: {1}", jsonString, exception.ToString()));
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
            return newGroupAuditLog;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as GroupAuditLog);
        }

        /// <summary>
        /// Returns true if GroupAuditLog instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupAuditLog to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupAuditLog input)
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
    /// Custom JSON converter for GroupAuditLog
    /// </summary>
    public class GroupAuditLogJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(GroupAuditLog).GetMethod("ToJson").Invoke(value, null)));
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
                    return GroupAuditLog.FromJson(JObject.Load(reader).ToString(Formatting.None));
                case JsonToken.StartArray:
                    return GroupAuditLog.FromJson(JArray.Load(reader).ToString(Formatting.None));
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
