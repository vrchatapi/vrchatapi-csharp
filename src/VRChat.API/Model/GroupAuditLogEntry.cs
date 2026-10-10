

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
    [JsonConverter(typeof(GroupAuditLogEntryJsonConverter))]
    [DataContract(Name = "GroupAuditLogEntry")]
    public partial class GroupAuditLogEntry : AbstractOpenAPISchema, IEquatable<GroupAuditLogEntry>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLogEntry" /> class
        /// with the <see cref="GroupAuditLogEntryGroupAnnouncement" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GroupAuditLogEntryGroupAnnouncement.</param>
        public GroupAuditLogEntry(GroupAuditLogEntryGroupAnnouncement actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLogEntry" /> class
        /// with the <see cref="GroupAuditLogEntryGroupCalendarEventCreate" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GroupAuditLogEntryGroupCalendarEventCreate.</param>
        public GroupAuditLogEntry(GroupAuditLogEntryGroupCalendarEventCreate actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLogEntry" /> class
        /// with the <see cref="GroupAuditLogEntryGroupCalendarEventDelete" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GroupAuditLogEntryGroupCalendarEventDelete.</param>
        public GroupAuditLogEntry(GroupAuditLogEntryGroupCalendarEventDelete actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLogEntry" /> class
        /// with the <see cref="GroupAuditLogEntryGroupCreate" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GroupAuditLogEntryGroupCreate.</param>
        public GroupAuditLogEntry(GroupAuditLogEntryGroupCreate actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLogEntry" /> class
        /// with the <see cref="GroupAuditLogEntryGroupGalleryCreate" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GroupAuditLogEntryGroupGalleryCreate.</param>
        public GroupAuditLogEntry(GroupAuditLogEntryGroupGalleryCreate actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLogEntry" /> class
        /// with the <see cref="GroupAuditLogEntryGroupGalleryDelete" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GroupAuditLogEntryGroupGalleryDelete.</param>
        public GroupAuditLogEntry(GroupAuditLogEntryGroupGalleryDelete actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLogEntry" /> class
        /// with the <see cref="GroupAuditLogEntryGroupGalleryUpdate" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GroupAuditLogEntryGroupGalleryUpdate.</param>
        public GroupAuditLogEntry(GroupAuditLogEntryGroupGalleryUpdate actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLogEntry" /> class
        /// with the <see cref="GroupAuditLogEntryGroupInstanceAnnouncement" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GroupAuditLogEntryGroupInstanceAnnouncement.</param>
        public GroupAuditLogEntry(GroupAuditLogEntryGroupInstanceAnnouncement actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLogEntry" /> class
        /// with the <see cref="GroupAuditLogEntryGroupInstanceClose" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GroupAuditLogEntryGroupInstanceClose.</param>
        public GroupAuditLogEntry(GroupAuditLogEntryGroupInstanceClose actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLogEntry" /> class
        /// with the <see cref="GroupAuditLogEntryGroupInstanceCreate" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GroupAuditLogEntryGroupInstanceCreate.</param>
        public GroupAuditLogEntry(GroupAuditLogEntryGroupInstanceCreate actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLogEntry" /> class
        /// with the <see cref="GroupAuditLogEntryGroupInstanceKick" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GroupAuditLogEntryGroupInstanceKick.</param>
        public GroupAuditLogEntry(GroupAuditLogEntryGroupInstanceKick actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLogEntry" /> class
        /// with the <see cref="GroupAuditLogEntryGroupInstanceWarn" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GroupAuditLogEntryGroupInstanceWarn.</param>
        public GroupAuditLogEntry(GroupAuditLogEntryGroupInstanceWarn actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLogEntry" /> class
        /// with the <see cref="GroupAuditLogEntryGroupInviteCancel" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GroupAuditLogEntryGroupInviteCancel.</param>
        public GroupAuditLogEntry(GroupAuditLogEntryGroupInviteCancel actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLogEntry" /> class
        /// with the <see cref="GroupAuditLogEntryGroupInviteCreate" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GroupAuditLogEntryGroupInviteCreate.</param>
        public GroupAuditLogEntry(GroupAuditLogEntryGroupInviteCreate actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLogEntry" /> class
        /// with the <see cref="GroupAuditLogEntryGroupMemberJoin" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GroupAuditLogEntryGroupMemberJoin.</param>
        public GroupAuditLogEntry(GroupAuditLogEntryGroupMemberJoin actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLogEntry" /> class
        /// with the <see cref="GroupAuditLogEntryGroupMemberLeave" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GroupAuditLogEntryGroupMemberLeave.</param>
        public GroupAuditLogEntry(GroupAuditLogEntryGroupMemberLeave actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLogEntry" /> class
        /// with the <see cref="GroupAuditLogEntryGroupMemberRemove" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GroupAuditLogEntryGroupMemberRemove.</param>
        public GroupAuditLogEntry(GroupAuditLogEntryGroupMemberRemove actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLogEntry" /> class
        /// with the <see cref="GroupAuditLogEntryGroupMemberRoleAssign" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GroupAuditLogEntryGroupMemberRoleAssign.</param>
        public GroupAuditLogEntry(GroupAuditLogEntryGroupMemberRoleAssign actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLogEntry" /> class
        /// with the <see cref="GroupAuditLogEntryGroupMemberRoleUnassign" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GroupAuditLogEntryGroupMemberRoleUnassign.</param>
        public GroupAuditLogEntry(GroupAuditLogEntryGroupMemberRoleUnassign actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLogEntry" /> class
        /// with the <see cref="GroupAuditLogEntryGroupMemberUserUpdate" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GroupAuditLogEntryGroupMemberUserUpdate.</param>
        public GroupAuditLogEntry(GroupAuditLogEntryGroupMemberUserUpdate actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLogEntry" /> class
        /// with the <see cref="GroupAuditLogEntryGroupPostCreate" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GroupAuditLogEntryGroupPostCreate.</param>
        public GroupAuditLogEntry(GroupAuditLogEntryGroupPostCreate actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLogEntry" /> class
        /// with the <see cref="GroupAuditLogEntryGroupPostDelete" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GroupAuditLogEntryGroupPostDelete.</param>
        public GroupAuditLogEntry(GroupAuditLogEntryGroupPostDelete actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLogEntry" /> class
        /// with the <see cref="GroupAuditLogEntryGroupPostUpdate" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GroupAuditLogEntryGroupPostUpdate.</param>
        public GroupAuditLogEntry(GroupAuditLogEntryGroupPostUpdate actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLogEntry" /> class
        /// with the <see cref="GroupAuditLogEntryGroupRequestBlock" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GroupAuditLogEntryGroupRequestBlock.</param>
        public GroupAuditLogEntry(GroupAuditLogEntryGroupRequestBlock actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLogEntry" /> class
        /// with the <see cref="GroupAuditLogEntryGroupRequestCreate" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GroupAuditLogEntryGroupRequestCreate.</param>
        public GroupAuditLogEntry(GroupAuditLogEntryGroupRequestCreate actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLogEntry" /> class
        /// with the <see cref="GroupAuditLogEntryGroupRequestReject" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GroupAuditLogEntryGroupRequestReject.</param>
        public GroupAuditLogEntry(GroupAuditLogEntryGroupRequestReject actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLogEntry" /> class
        /// with the <see cref="GroupAuditLogEntryGroupRequestWithdraw" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GroupAuditLogEntryGroupRequestWithdraw.</param>
        public GroupAuditLogEntry(GroupAuditLogEntryGroupRequestWithdraw actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLogEntry" /> class
        /// with the <see cref="GroupAuditLogEntryGroupRoleCreate" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GroupAuditLogEntryGroupRoleCreate.</param>
        public GroupAuditLogEntry(GroupAuditLogEntryGroupRoleCreate actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLogEntry" /> class
        /// with the <see cref="GroupAuditLogEntryGroupRoleDelete" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GroupAuditLogEntryGroupRoleDelete.</param>
        public GroupAuditLogEntry(GroupAuditLogEntryGroupRoleDelete actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLogEntry" /> class
        /// with the <see cref="GroupAuditLogEntryGroupRoleUpdate" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GroupAuditLogEntryGroupRoleUpdate.</param>
        public GroupAuditLogEntry(GroupAuditLogEntryGroupRoleUpdate actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLogEntry" /> class
        /// with the <see cref="GroupAuditLogEntryGroupUpdate" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GroupAuditLogEntryGroupUpdate.</param>
        public GroupAuditLogEntry(GroupAuditLogEntryGroupUpdate actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLogEntry" /> class
        /// with the <see cref="GroupAuditLogEntryGroupUserBan" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GroupAuditLogEntryGroupUserBan.</param>
        public GroupAuditLogEntry(GroupAuditLogEntryGroupUserBan actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLogEntry" /> class
        /// with the <see cref="GroupAuditLogEntryGroupUserUnban" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GroupAuditLogEntryGroupUserUnban.</param>
        public GroupAuditLogEntry(GroupAuditLogEntryGroupUserUnban actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLogEntry" /> class
        /// with the <see cref="GroupAuditLogEntryUnknown" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GroupAuditLogEntryUnknown.</param>
        public GroupAuditLogEntry(GroupAuditLogEntryUnknown actualInstance)
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
                if (value.GetType() == typeof(GroupAuditLogEntryGroupAnnouncement) || value is GroupAuditLogEntryGroupAnnouncement)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GroupAuditLogEntryGroupCalendarEventCreate) || value is GroupAuditLogEntryGroupCalendarEventCreate)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GroupAuditLogEntryGroupCalendarEventDelete) || value is GroupAuditLogEntryGroupCalendarEventDelete)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GroupAuditLogEntryGroupCreate) || value is GroupAuditLogEntryGroupCreate)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GroupAuditLogEntryGroupGalleryCreate) || value is GroupAuditLogEntryGroupGalleryCreate)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GroupAuditLogEntryGroupGalleryDelete) || value is GroupAuditLogEntryGroupGalleryDelete)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GroupAuditLogEntryGroupGalleryUpdate) || value is GroupAuditLogEntryGroupGalleryUpdate)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GroupAuditLogEntryGroupInstanceAnnouncement) || value is GroupAuditLogEntryGroupInstanceAnnouncement)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GroupAuditLogEntryGroupInstanceClose) || value is GroupAuditLogEntryGroupInstanceClose)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GroupAuditLogEntryGroupInstanceCreate) || value is GroupAuditLogEntryGroupInstanceCreate)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GroupAuditLogEntryGroupInstanceKick) || value is GroupAuditLogEntryGroupInstanceKick)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GroupAuditLogEntryGroupInstanceWarn) || value is GroupAuditLogEntryGroupInstanceWarn)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GroupAuditLogEntryGroupInviteCancel) || value is GroupAuditLogEntryGroupInviteCancel)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GroupAuditLogEntryGroupInviteCreate) || value is GroupAuditLogEntryGroupInviteCreate)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GroupAuditLogEntryGroupMemberJoin) || value is GroupAuditLogEntryGroupMemberJoin)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GroupAuditLogEntryGroupMemberLeave) || value is GroupAuditLogEntryGroupMemberLeave)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GroupAuditLogEntryGroupMemberRemove) || value is GroupAuditLogEntryGroupMemberRemove)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GroupAuditLogEntryGroupMemberRoleAssign) || value is GroupAuditLogEntryGroupMemberRoleAssign)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GroupAuditLogEntryGroupMemberRoleUnassign) || value is GroupAuditLogEntryGroupMemberRoleUnassign)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GroupAuditLogEntryGroupMemberUserUpdate) || value is GroupAuditLogEntryGroupMemberUserUpdate)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GroupAuditLogEntryGroupPostCreate) || value is GroupAuditLogEntryGroupPostCreate)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GroupAuditLogEntryGroupPostDelete) || value is GroupAuditLogEntryGroupPostDelete)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GroupAuditLogEntryGroupPostUpdate) || value is GroupAuditLogEntryGroupPostUpdate)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GroupAuditLogEntryGroupRequestBlock) || value is GroupAuditLogEntryGroupRequestBlock)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GroupAuditLogEntryGroupRequestCreate) || value is GroupAuditLogEntryGroupRequestCreate)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GroupAuditLogEntryGroupRequestReject) || value is GroupAuditLogEntryGroupRequestReject)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GroupAuditLogEntryGroupRequestWithdraw) || value is GroupAuditLogEntryGroupRequestWithdraw)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GroupAuditLogEntryGroupRoleCreate) || value is GroupAuditLogEntryGroupRoleCreate)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GroupAuditLogEntryGroupRoleDelete) || value is GroupAuditLogEntryGroupRoleDelete)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GroupAuditLogEntryGroupRoleUpdate) || value is GroupAuditLogEntryGroupRoleUpdate)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GroupAuditLogEntryGroupUpdate) || value is GroupAuditLogEntryGroupUpdate)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GroupAuditLogEntryGroupUserBan) || value is GroupAuditLogEntryGroupUserBan)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GroupAuditLogEntryGroupUserUnban) || value is GroupAuditLogEntryGroupUserUnban)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GroupAuditLogEntryUnknown) || value is GroupAuditLogEntryUnknown)
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
        /// Converts to the <c>GroupAuditLogEntryGroupAnnouncement</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator GroupAuditLogEntryGroupAnnouncement(GroupAuditLogEntry value) => (GroupAuditLogEntryGroupAnnouncement)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>GroupAuditLogEntryGroupCalendarEventCreate</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator GroupAuditLogEntryGroupCalendarEventCreate(GroupAuditLogEntry value) => (GroupAuditLogEntryGroupCalendarEventCreate)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>GroupAuditLogEntryGroupCalendarEventDelete</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator GroupAuditLogEntryGroupCalendarEventDelete(GroupAuditLogEntry value) => (GroupAuditLogEntryGroupCalendarEventDelete)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>GroupAuditLogEntryGroupCreate</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator GroupAuditLogEntryGroupCreate(GroupAuditLogEntry value) => (GroupAuditLogEntryGroupCreate)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>GroupAuditLogEntryGroupGalleryCreate</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator GroupAuditLogEntryGroupGalleryCreate(GroupAuditLogEntry value) => (GroupAuditLogEntryGroupGalleryCreate)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>GroupAuditLogEntryGroupGalleryDelete</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator GroupAuditLogEntryGroupGalleryDelete(GroupAuditLogEntry value) => (GroupAuditLogEntryGroupGalleryDelete)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>GroupAuditLogEntryGroupGalleryUpdate</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator GroupAuditLogEntryGroupGalleryUpdate(GroupAuditLogEntry value) => (GroupAuditLogEntryGroupGalleryUpdate)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>GroupAuditLogEntryGroupInstanceAnnouncement</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator GroupAuditLogEntryGroupInstanceAnnouncement(GroupAuditLogEntry value) => (GroupAuditLogEntryGroupInstanceAnnouncement)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>GroupAuditLogEntryGroupInstanceClose</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator GroupAuditLogEntryGroupInstanceClose(GroupAuditLogEntry value) => (GroupAuditLogEntryGroupInstanceClose)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>GroupAuditLogEntryGroupInstanceCreate</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator GroupAuditLogEntryGroupInstanceCreate(GroupAuditLogEntry value) => (GroupAuditLogEntryGroupInstanceCreate)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>GroupAuditLogEntryGroupInstanceKick</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator GroupAuditLogEntryGroupInstanceKick(GroupAuditLogEntry value) => (GroupAuditLogEntryGroupInstanceKick)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>GroupAuditLogEntryGroupInstanceWarn</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator GroupAuditLogEntryGroupInstanceWarn(GroupAuditLogEntry value) => (GroupAuditLogEntryGroupInstanceWarn)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>GroupAuditLogEntryGroupInviteCancel</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator GroupAuditLogEntryGroupInviteCancel(GroupAuditLogEntry value) => (GroupAuditLogEntryGroupInviteCancel)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>GroupAuditLogEntryGroupInviteCreate</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator GroupAuditLogEntryGroupInviteCreate(GroupAuditLogEntry value) => (GroupAuditLogEntryGroupInviteCreate)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>GroupAuditLogEntryGroupMemberJoin</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator GroupAuditLogEntryGroupMemberJoin(GroupAuditLogEntry value) => (GroupAuditLogEntryGroupMemberJoin)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>GroupAuditLogEntryGroupMemberLeave</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator GroupAuditLogEntryGroupMemberLeave(GroupAuditLogEntry value) => (GroupAuditLogEntryGroupMemberLeave)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>GroupAuditLogEntryGroupMemberRemove</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator GroupAuditLogEntryGroupMemberRemove(GroupAuditLogEntry value) => (GroupAuditLogEntryGroupMemberRemove)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>GroupAuditLogEntryGroupMemberRoleAssign</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator GroupAuditLogEntryGroupMemberRoleAssign(GroupAuditLogEntry value) => (GroupAuditLogEntryGroupMemberRoleAssign)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>GroupAuditLogEntryGroupMemberRoleUnassign</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator GroupAuditLogEntryGroupMemberRoleUnassign(GroupAuditLogEntry value) => (GroupAuditLogEntryGroupMemberRoleUnassign)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>GroupAuditLogEntryGroupMemberUserUpdate</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator GroupAuditLogEntryGroupMemberUserUpdate(GroupAuditLogEntry value) => (GroupAuditLogEntryGroupMemberUserUpdate)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>GroupAuditLogEntryGroupPostCreate</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator GroupAuditLogEntryGroupPostCreate(GroupAuditLogEntry value) => (GroupAuditLogEntryGroupPostCreate)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>GroupAuditLogEntryGroupPostDelete</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator GroupAuditLogEntryGroupPostDelete(GroupAuditLogEntry value) => (GroupAuditLogEntryGroupPostDelete)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>GroupAuditLogEntryGroupPostUpdate</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator GroupAuditLogEntryGroupPostUpdate(GroupAuditLogEntry value) => (GroupAuditLogEntryGroupPostUpdate)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>GroupAuditLogEntryGroupRequestBlock</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator GroupAuditLogEntryGroupRequestBlock(GroupAuditLogEntry value) => (GroupAuditLogEntryGroupRequestBlock)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>GroupAuditLogEntryGroupRequestCreate</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator GroupAuditLogEntryGroupRequestCreate(GroupAuditLogEntry value) => (GroupAuditLogEntryGroupRequestCreate)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>GroupAuditLogEntryGroupRequestReject</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator GroupAuditLogEntryGroupRequestReject(GroupAuditLogEntry value) => (GroupAuditLogEntryGroupRequestReject)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>GroupAuditLogEntryGroupRequestWithdraw</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator GroupAuditLogEntryGroupRequestWithdraw(GroupAuditLogEntry value) => (GroupAuditLogEntryGroupRequestWithdraw)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>GroupAuditLogEntryGroupRoleCreate</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator GroupAuditLogEntryGroupRoleCreate(GroupAuditLogEntry value) => (GroupAuditLogEntryGroupRoleCreate)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>GroupAuditLogEntryGroupRoleDelete</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator GroupAuditLogEntryGroupRoleDelete(GroupAuditLogEntry value) => (GroupAuditLogEntryGroupRoleDelete)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>GroupAuditLogEntryGroupRoleUpdate</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator GroupAuditLogEntryGroupRoleUpdate(GroupAuditLogEntry value) => (GroupAuditLogEntryGroupRoleUpdate)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>GroupAuditLogEntryGroupUpdate</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator GroupAuditLogEntryGroupUpdate(GroupAuditLogEntry value) => (GroupAuditLogEntryGroupUpdate)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>GroupAuditLogEntryGroupUserBan</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator GroupAuditLogEntryGroupUserBan(GroupAuditLogEntry value) => (GroupAuditLogEntryGroupUserBan)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>GroupAuditLogEntryGroupUserUnban</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator GroupAuditLogEntryGroupUserUnban(GroupAuditLogEntry value) => (GroupAuditLogEntryGroupUserUnban)value?.ActualInstance;
        

        
        /// <summary>
        /// Converts to the <c>GroupAuditLogEntryUnknown</c> this instance holds, throwing <see cref="InvalidCastException"/> when it holds another type.
        /// </summary>
        public static implicit operator GroupAuditLogEntryUnknown(GroupAuditLogEntry value) => (GroupAuditLogEntryUnknown)value?.ActualInstance;
        

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GroupAuditLogEntry {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, GroupAuditLogEntry.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of GroupAuditLogEntry
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of GroupAuditLogEntry</returns>
        public static GroupAuditLogEntry FromJson(string jsonString)
        {
            GroupAuditLogEntry newGroupAuditLogEntry = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newGroupAuditLogEntry;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GroupAuditLogEntryGroupAnnouncement).GetProperty("AdditionalProperties") == null)
                {
                    newGroupAuditLogEntry = new GroupAuditLogEntry(JsonConvert.DeserializeObject<GroupAuditLogEntryGroupAnnouncement>(jsonString, GroupAuditLogEntry.SerializerSettings));
                }
                else
                {
                    newGroupAuditLogEntry = new GroupAuditLogEntry(JsonConvert.DeserializeObject<GroupAuditLogEntryGroupAnnouncement>(jsonString, GroupAuditLogEntry.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GroupAuditLogEntryGroupAnnouncement");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GroupAuditLogEntryGroupAnnouncement: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GroupAuditLogEntryGroupCalendarEventCreate).GetProperty("AdditionalProperties") == null)
                {
                    newGroupAuditLogEntry = new GroupAuditLogEntry(JsonConvert.DeserializeObject<GroupAuditLogEntryGroupCalendarEventCreate>(jsonString, GroupAuditLogEntry.SerializerSettings));
                }
                else
                {
                    newGroupAuditLogEntry = new GroupAuditLogEntry(JsonConvert.DeserializeObject<GroupAuditLogEntryGroupCalendarEventCreate>(jsonString, GroupAuditLogEntry.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GroupAuditLogEntryGroupCalendarEventCreate");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GroupAuditLogEntryGroupCalendarEventCreate: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GroupAuditLogEntryGroupCalendarEventDelete).GetProperty("AdditionalProperties") == null)
                {
                    newGroupAuditLogEntry = new GroupAuditLogEntry(JsonConvert.DeserializeObject<GroupAuditLogEntryGroupCalendarEventDelete>(jsonString, GroupAuditLogEntry.SerializerSettings));
                }
                else
                {
                    newGroupAuditLogEntry = new GroupAuditLogEntry(JsonConvert.DeserializeObject<GroupAuditLogEntryGroupCalendarEventDelete>(jsonString, GroupAuditLogEntry.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GroupAuditLogEntryGroupCalendarEventDelete");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GroupAuditLogEntryGroupCalendarEventDelete: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GroupAuditLogEntryGroupCreate).GetProperty("AdditionalProperties") == null)
                {
                    newGroupAuditLogEntry = new GroupAuditLogEntry(JsonConvert.DeserializeObject<GroupAuditLogEntryGroupCreate>(jsonString, GroupAuditLogEntry.SerializerSettings));
                }
                else
                {
                    newGroupAuditLogEntry = new GroupAuditLogEntry(JsonConvert.DeserializeObject<GroupAuditLogEntryGroupCreate>(jsonString, GroupAuditLogEntry.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GroupAuditLogEntryGroupCreate");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GroupAuditLogEntryGroupCreate: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GroupAuditLogEntryGroupGalleryCreate).GetProperty("AdditionalProperties") == null)
                {
                    newGroupAuditLogEntry = new GroupAuditLogEntry(JsonConvert.DeserializeObject<GroupAuditLogEntryGroupGalleryCreate>(jsonString, GroupAuditLogEntry.SerializerSettings));
                }
                else
                {
                    newGroupAuditLogEntry = new GroupAuditLogEntry(JsonConvert.DeserializeObject<GroupAuditLogEntryGroupGalleryCreate>(jsonString, GroupAuditLogEntry.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GroupAuditLogEntryGroupGalleryCreate");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GroupAuditLogEntryGroupGalleryCreate: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GroupAuditLogEntryGroupGalleryDelete).GetProperty("AdditionalProperties") == null)
                {
                    newGroupAuditLogEntry = new GroupAuditLogEntry(JsonConvert.DeserializeObject<GroupAuditLogEntryGroupGalleryDelete>(jsonString, GroupAuditLogEntry.SerializerSettings));
                }
                else
                {
                    newGroupAuditLogEntry = new GroupAuditLogEntry(JsonConvert.DeserializeObject<GroupAuditLogEntryGroupGalleryDelete>(jsonString, GroupAuditLogEntry.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GroupAuditLogEntryGroupGalleryDelete");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GroupAuditLogEntryGroupGalleryDelete: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GroupAuditLogEntryGroupGalleryUpdate).GetProperty("AdditionalProperties") == null)
                {
                    newGroupAuditLogEntry = new GroupAuditLogEntry(JsonConvert.DeserializeObject<GroupAuditLogEntryGroupGalleryUpdate>(jsonString, GroupAuditLogEntry.SerializerSettings));
                }
                else
                {
                    newGroupAuditLogEntry = new GroupAuditLogEntry(JsonConvert.DeserializeObject<GroupAuditLogEntryGroupGalleryUpdate>(jsonString, GroupAuditLogEntry.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GroupAuditLogEntryGroupGalleryUpdate");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GroupAuditLogEntryGroupGalleryUpdate: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GroupAuditLogEntryGroupInstanceAnnouncement).GetProperty("AdditionalProperties") == null)
                {
                    newGroupAuditLogEntry = new GroupAuditLogEntry(JsonConvert.DeserializeObject<GroupAuditLogEntryGroupInstanceAnnouncement>(jsonString, GroupAuditLogEntry.SerializerSettings));
                }
                else
                {
                    newGroupAuditLogEntry = new GroupAuditLogEntry(JsonConvert.DeserializeObject<GroupAuditLogEntryGroupInstanceAnnouncement>(jsonString, GroupAuditLogEntry.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GroupAuditLogEntryGroupInstanceAnnouncement");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GroupAuditLogEntryGroupInstanceAnnouncement: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GroupAuditLogEntryGroupInstanceClose).GetProperty("AdditionalProperties") == null)
                {
                    newGroupAuditLogEntry = new GroupAuditLogEntry(JsonConvert.DeserializeObject<GroupAuditLogEntryGroupInstanceClose>(jsonString, GroupAuditLogEntry.SerializerSettings));
                }
                else
                {
                    newGroupAuditLogEntry = new GroupAuditLogEntry(JsonConvert.DeserializeObject<GroupAuditLogEntryGroupInstanceClose>(jsonString, GroupAuditLogEntry.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GroupAuditLogEntryGroupInstanceClose");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GroupAuditLogEntryGroupInstanceClose: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GroupAuditLogEntryGroupInstanceCreate).GetProperty("AdditionalProperties") == null)
                {
                    newGroupAuditLogEntry = new GroupAuditLogEntry(JsonConvert.DeserializeObject<GroupAuditLogEntryGroupInstanceCreate>(jsonString, GroupAuditLogEntry.SerializerSettings));
                }
                else
                {
                    newGroupAuditLogEntry = new GroupAuditLogEntry(JsonConvert.DeserializeObject<GroupAuditLogEntryGroupInstanceCreate>(jsonString, GroupAuditLogEntry.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GroupAuditLogEntryGroupInstanceCreate");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GroupAuditLogEntryGroupInstanceCreate: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GroupAuditLogEntryGroupInstanceKick).GetProperty("AdditionalProperties") == null)
                {
                    newGroupAuditLogEntry = new GroupAuditLogEntry(JsonConvert.DeserializeObject<GroupAuditLogEntryGroupInstanceKick>(jsonString, GroupAuditLogEntry.SerializerSettings));
                }
                else
                {
                    newGroupAuditLogEntry = new GroupAuditLogEntry(JsonConvert.DeserializeObject<GroupAuditLogEntryGroupInstanceKick>(jsonString, GroupAuditLogEntry.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GroupAuditLogEntryGroupInstanceKick");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GroupAuditLogEntryGroupInstanceKick: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GroupAuditLogEntryGroupInstanceWarn).GetProperty("AdditionalProperties") == null)
                {
                    newGroupAuditLogEntry = new GroupAuditLogEntry(JsonConvert.DeserializeObject<GroupAuditLogEntryGroupInstanceWarn>(jsonString, GroupAuditLogEntry.SerializerSettings));
                }
                else
                {
                    newGroupAuditLogEntry = new GroupAuditLogEntry(JsonConvert.DeserializeObject<GroupAuditLogEntryGroupInstanceWarn>(jsonString, GroupAuditLogEntry.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GroupAuditLogEntryGroupInstanceWarn");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GroupAuditLogEntryGroupInstanceWarn: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GroupAuditLogEntryGroupInviteCancel).GetProperty("AdditionalProperties") == null)
                {
                    newGroupAuditLogEntry = new GroupAuditLogEntry(JsonConvert.DeserializeObject<GroupAuditLogEntryGroupInviteCancel>(jsonString, GroupAuditLogEntry.SerializerSettings));
                }
                else
                {
                    newGroupAuditLogEntry = new GroupAuditLogEntry(JsonConvert.DeserializeObject<GroupAuditLogEntryGroupInviteCancel>(jsonString, GroupAuditLogEntry.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GroupAuditLogEntryGroupInviteCancel");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GroupAuditLogEntryGroupInviteCancel: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GroupAuditLogEntryGroupInviteCreate).GetProperty("AdditionalProperties") == null)
                {
                    newGroupAuditLogEntry = new GroupAuditLogEntry(JsonConvert.DeserializeObject<GroupAuditLogEntryGroupInviteCreate>(jsonString, GroupAuditLogEntry.SerializerSettings));
                }
                else
                {
                    newGroupAuditLogEntry = new GroupAuditLogEntry(JsonConvert.DeserializeObject<GroupAuditLogEntryGroupInviteCreate>(jsonString, GroupAuditLogEntry.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GroupAuditLogEntryGroupInviteCreate");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GroupAuditLogEntryGroupInviteCreate: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GroupAuditLogEntryGroupMemberJoin).GetProperty("AdditionalProperties") == null)
                {
                    newGroupAuditLogEntry = new GroupAuditLogEntry(JsonConvert.DeserializeObject<GroupAuditLogEntryGroupMemberJoin>(jsonString, GroupAuditLogEntry.SerializerSettings));
                }
                else
                {
                    newGroupAuditLogEntry = new GroupAuditLogEntry(JsonConvert.DeserializeObject<GroupAuditLogEntryGroupMemberJoin>(jsonString, GroupAuditLogEntry.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GroupAuditLogEntryGroupMemberJoin");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GroupAuditLogEntryGroupMemberJoin: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GroupAuditLogEntryGroupMemberLeave).GetProperty("AdditionalProperties") == null)
                {
                    newGroupAuditLogEntry = new GroupAuditLogEntry(JsonConvert.DeserializeObject<GroupAuditLogEntryGroupMemberLeave>(jsonString, GroupAuditLogEntry.SerializerSettings));
                }
                else
                {
                    newGroupAuditLogEntry = new GroupAuditLogEntry(JsonConvert.DeserializeObject<GroupAuditLogEntryGroupMemberLeave>(jsonString, GroupAuditLogEntry.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GroupAuditLogEntryGroupMemberLeave");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GroupAuditLogEntryGroupMemberLeave: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GroupAuditLogEntryGroupMemberRemove).GetProperty("AdditionalProperties") == null)
                {
                    newGroupAuditLogEntry = new GroupAuditLogEntry(JsonConvert.DeserializeObject<GroupAuditLogEntryGroupMemberRemove>(jsonString, GroupAuditLogEntry.SerializerSettings));
                }
                else
                {
                    newGroupAuditLogEntry = new GroupAuditLogEntry(JsonConvert.DeserializeObject<GroupAuditLogEntryGroupMemberRemove>(jsonString, GroupAuditLogEntry.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GroupAuditLogEntryGroupMemberRemove");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GroupAuditLogEntryGroupMemberRemove: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GroupAuditLogEntryGroupMemberRoleAssign).GetProperty("AdditionalProperties") == null)
                {
                    newGroupAuditLogEntry = new GroupAuditLogEntry(JsonConvert.DeserializeObject<GroupAuditLogEntryGroupMemberRoleAssign>(jsonString, GroupAuditLogEntry.SerializerSettings));
                }
                else
                {
                    newGroupAuditLogEntry = new GroupAuditLogEntry(JsonConvert.DeserializeObject<GroupAuditLogEntryGroupMemberRoleAssign>(jsonString, GroupAuditLogEntry.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GroupAuditLogEntryGroupMemberRoleAssign");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GroupAuditLogEntryGroupMemberRoleAssign: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GroupAuditLogEntryGroupMemberRoleUnassign).GetProperty("AdditionalProperties") == null)
                {
                    newGroupAuditLogEntry = new GroupAuditLogEntry(JsonConvert.DeserializeObject<GroupAuditLogEntryGroupMemberRoleUnassign>(jsonString, GroupAuditLogEntry.SerializerSettings));
                }
                else
                {
                    newGroupAuditLogEntry = new GroupAuditLogEntry(JsonConvert.DeserializeObject<GroupAuditLogEntryGroupMemberRoleUnassign>(jsonString, GroupAuditLogEntry.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GroupAuditLogEntryGroupMemberRoleUnassign");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GroupAuditLogEntryGroupMemberRoleUnassign: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GroupAuditLogEntryGroupMemberUserUpdate).GetProperty("AdditionalProperties") == null)
                {
                    newGroupAuditLogEntry = new GroupAuditLogEntry(JsonConvert.DeserializeObject<GroupAuditLogEntryGroupMemberUserUpdate>(jsonString, GroupAuditLogEntry.SerializerSettings));
                }
                else
                {
                    newGroupAuditLogEntry = new GroupAuditLogEntry(JsonConvert.DeserializeObject<GroupAuditLogEntryGroupMemberUserUpdate>(jsonString, GroupAuditLogEntry.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GroupAuditLogEntryGroupMemberUserUpdate");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GroupAuditLogEntryGroupMemberUserUpdate: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GroupAuditLogEntryGroupPostCreate).GetProperty("AdditionalProperties") == null)
                {
                    newGroupAuditLogEntry = new GroupAuditLogEntry(JsonConvert.DeserializeObject<GroupAuditLogEntryGroupPostCreate>(jsonString, GroupAuditLogEntry.SerializerSettings));
                }
                else
                {
                    newGroupAuditLogEntry = new GroupAuditLogEntry(JsonConvert.DeserializeObject<GroupAuditLogEntryGroupPostCreate>(jsonString, GroupAuditLogEntry.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GroupAuditLogEntryGroupPostCreate");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GroupAuditLogEntryGroupPostCreate: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GroupAuditLogEntryGroupPostDelete).GetProperty("AdditionalProperties") == null)
                {
                    newGroupAuditLogEntry = new GroupAuditLogEntry(JsonConvert.DeserializeObject<GroupAuditLogEntryGroupPostDelete>(jsonString, GroupAuditLogEntry.SerializerSettings));
                }
                else
                {
                    newGroupAuditLogEntry = new GroupAuditLogEntry(JsonConvert.DeserializeObject<GroupAuditLogEntryGroupPostDelete>(jsonString, GroupAuditLogEntry.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GroupAuditLogEntryGroupPostDelete");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GroupAuditLogEntryGroupPostDelete: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GroupAuditLogEntryGroupPostUpdate).GetProperty("AdditionalProperties") == null)
                {
                    newGroupAuditLogEntry = new GroupAuditLogEntry(JsonConvert.DeserializeObject<GroupAuditLogEntryGroupPostUpdate>(jsonString, GroupAuditLogEntry.SerializerSettings));
                }
                else
                {
                    newGroupAuditLogEntry = new GroupAuditLogEntry(JsonConvert.DeserializeObject<GroupAuditLogEntryGroupPostUpdate>(jsonString, GroupAuditLogEntry.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GroupAuditLogEntryGroupPostUpdate");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GroupAuditLogEntryGroupPostUpdate: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GroupAuditLogEntryGroupRequestBlock).GetProperty("AdditionalProperties") == null)
                {
                    newGroupAuditLogEntry = new GroupAuditLogEntry(JsonConvert.DeserializeObject<GroupAuditLogEntryGroupRequestBlock>(jsonString, GroupAuditLogEntry.SerializerSettings));
                }
                else
                {
                    newGroupAuditLogEntry = new GroupAuditLogEntry(JsonConvert.DeserializeObject<GroupAuditLogEntryGroupRequestBlock>(jsonString, GroupAuditLogEntry.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GroupAuditLogEntryGroupRequestBlock");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GroupAuditLogEntryGroupRequestBlock: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GroupAuditLogEntryGroupRequestCreate).GetProperty("AdditionalProperties") == null)
                {
                    newGroupAuditLogEntry = new GroupAuditLogEntry(JsonConvert.DeserializeObject<GroupAuditLogEntryGroupRequestCreate>(jsonString, GroupAuditLogEntry.SerializerSettings));
                }
                else
                {
                    newGroupAuditLogEntry = new GroupAuditLogEntry(JsonConvert.DeserializeObject<GroupAuditLogEntryGroupRequestCreate>(jsonString, GroupAuditLogEntry.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GroupAuditLogEntryGroupRequestCreate");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GroupAuditLogEntryGroupRequestCreate: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GroupAuditLogEntryGroupRequestReject).GetProperty("AdditionalProperties") == null)
                {
                    newGroupAuditLogEntry = new GroupAuditLogEntry(JsonConvert.DeserializeObject<GroupAuditLogEntryGroupRequestReject>(jsonString, GroupAuditLogEntry.SerializerSettings));
                }
                else
                {
                    newGroupAuditLogEntry = new GroupAuditLogEntry(JsonConvert.DeserializeObject<GroupAuditLogEntryGroupRequestReject>(jsonString, GroupAuditLogEntry.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GroupAuditLogEntryGroupRequestReject");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GroupAuditLogEntryGroupRequestReject: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GroupAuditLogEntryGroupRequestWithdraw).GetProperty("AdditionalProperties") == null)
                {
                    newGroupAuditLogEntry = new GroupAuditLogEntry(JsonConvert.DeserializeObject<GroupAuditLogEntryGroupRequestWithdraw>(jsonString, GroupAuditLogEntry.SerializerSettings));
                }
                else
                {
                    newGroupAuditLogEntry = new GroupAuditLogEntry(JsonConvert.DeserializeObject<GroupAuditLogEntryGroupRequestWithdraw>(jsonString, GroupAuditLogEntry.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GroupAuditLogEntryGroupRequestWithdraw");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GroupAuditLogEntryGroupRequestWithdraw: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GroupAuditLogEntryGroupRoleCreate).GetProperty("AdditionalProperties") == null)
                {
                    newGroupAuditLogEntry = new GroupAuditLogEntry(JsonConvert.DeserializeObject<GroupAuditLogEntryGroupRoleCreate>(jsonString, GroupAuditLogEntry.SerializerSettings));
                }
                else
                {
                    newGroupAuditLogEntry = new GroupAuditLogEntry(JsonConvert.DeserializeObject<GroupAuditLogEntryGroupRoleCreate>(jsonString, GroupAuditLogEntry.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GroupAuditLogEntryGroupRoleCreate");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GroupAuditLogEntryGroupRoleCreate: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GroupAuditLogEntryGroupRoleDelete).GetProperty("AdditionalProperties") == null)
                {
                    newGroupAuditLogEntry = new GroupAuditLogEntry(JsonConvert.DeserializeObject<GroupAuditLogEntryGroupRoleDelete>(jsonString, GroupAuditLogEntry.SerializerSettings));
                }
                else
                {
                    newGroupAuditLogEntry = new GroupAuditLogEntry(JsonConvert.DeserializeObject<GroupAuditLogEntryGroupRoleDelete>(jsonString, GroupAuditLogEntry.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GroupAuditLogEntryGroupRoleDelete");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GroupAuditLogEntryGroupRoleDelete: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GroupAuditLogEntryGroupRoleUpdate).GetProperty("AdditionalProperties") == null)
                {
                    newGroupAuditLogEntry = new GroupAuditLogEntry(JsonConvert.DeserializeObject<GroupAuditLogEntryGroupRoleUpdate>(jsonString, GroupAuditLogEntry.SerializerSettings));
                }
                else
                {
                    newGroupAuditLogEntry = new GroupAuditLogEntry(JsonConvert.DeserializeObject<GroupAuditLogEntryGroupRoleUpdate>(jsonString, GroupAuditLogEntry.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GroupAuditLogEntryGroupRoleUpdate");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GroupAuditLogEntryGroupRoleUpdate: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GroupAuditLogEntryGroupUpdate).GetProperty("AdditionalProperties") == null)
                {
                    newGroupAuditLogEntry = new GroupAuditLogEntry(JsonConvert.DeserializeObject<GroupAuditLogEntryGroupUpdate>(jsonString, GroupAuditLogEntry.SerializerSettings));
                }
                else
                {
                    newGroupAuditLogEntry = new GroupAuditLogEntry(JsonConvert.DeserializeObject<GroupAuditLogEntryGroupUpdate>(jsonString, GroupAuditLogEntry.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GroupAuditLogEntryGroupUpdate");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GroupAuditLogEntryGroupUpdate: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GroupAuditLogEntryGroupUserBan).GetProperty("AdditionalProperties") == null)
                {
                    newGroupAuditLogEntry = new GroupAuditLogEntry(JsonConvert.DeserializeObject<GroupAuditLogEntryGroupUserBan>(jsonString, GroupAuditLogEntry.SerializerSettings));
                }
                else
                {
                    newGroupAuditLogEntry = new GroupAuditLogEntry(JsonConvert.DeserializeObject<GroupAuditLogEntryGroupUserBan>(jsonString, GroupAuditLogEntry.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GroupAuditLogEntryGroupUserBan");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GroupAuditLogEntryGroupUserBan: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GroupAuditLogEntryGroupUserUnban).GetProperty("AdditionalProperties") == null)
                {
                    newGroupAuditLogEntry = new GroupAuditLogEntry(JsonConvert.DeserializeObject<GroupAuditLogEntryGroupUserUnban>(jsonString, GroupAuditLogEntry.SerializerSettings));
                }
                else
                {
                    newGroupAuditLogEntry = new GroupAuditLogEntry(JsonConvert.DeserializeObject<GroupAuditLogEntryGroupUserUnban>(jsonString, GroupAuditLogEntry.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GroupAuditLogEntryGroupUserUnban");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GroupAuditLogEntryGroupUserUnban: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GroupAuditLogEntryUnknown).GetProperty("AdditionalProperties") == null)
                {
                    newGroupAuditLogEntry = new GroupAuditLogEntry(JsonConvert.DeserializeObject<GroupAuditLogEntryUnknown>(jsonString, GroupAuditLogEntry.SerializerSettings));
                }
                else
                {
                    newGroupAuditLogEntry = new GroupAuditLogEntry(JsonConvert.DeserializeObject<GroupAuditLogEntryUnknown>(jsonString, GroupAuditLogEntry.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GroupAuditLogEntryUnknown");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GroupAuditLogEntryUnknown: {1}", jsonString, exception.ToString()));
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
            return newGroupAuditLogEntry;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as GroupAuditLogEntry);
        }

        /// <summary>
        /// Returns true if GroupAuditLogEntry instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupAuditLogEntry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupAuditLogEntry input)
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
    /// Custom JSON converter for GroupAuditLogEntry
    /// </summary>
    public class GroupAuditLogEntryJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(GroupAuditLogEntry).GetMethod("ToJson").Invoke(value, null)));
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
                    return GroupAuditLogEntry.FromJson(JObject.Load(reader).ToString(Formatting.None));
                case JsonToken.StartArray:
                    return GroupAuditLogEntry.FromJson(JArray.Load(reader).ToString(Formatting.None));
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
