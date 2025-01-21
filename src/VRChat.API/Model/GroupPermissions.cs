/*
 * VRChat API Documentation
 *
 *
 * The version of the OpenAPI document: 1.19.0
 * Contact: vrchatapi.lpv0t@aries.fyi
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


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
using OpenAPIDateConverter = VRChat.API.Client.OpenAPIDateConverter;

namespace VRChat.API.Model
{
    /// <summary>
    /// Defines GroupPermissions
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum GroupPermissions
    {
        /// <summary>
        /// Enum group_all for value: *
        /// </summary>
        [EnumMember(Value = "*")]
        group_all = 1,

        /// <summary>
        /// Enum group_announcement_manage for value: group-announcement-manage
        /// </summary>
        [EnumMember(Value = "group-announcement-manage")]
        group_announcement_manage = 2,

        /// <summary>
        /// Enum group_audit_view for value: group-audit-view
        /// </summary>
        [EnumMember(Value = "group-audit-view")]
        group_audit_view = 3,

        /// <summary>
        /// Enum group_bans_manage for value: group-bans-manage
        /// </summary>
        [EnumMember(Value = "group-bans-manage")]
        group_bans_manage = 4,

        /// <summary>
        /// Enum group_data_manage for value: group-data-manage
        /// </summary>
        [EnumMember(Value = "group-data-manage")]
        group_data_manage = 5,

        /// <summary>
        /// Enum group_default_role_manage for value: group-default-role-manage
        /// </summary>
        [EnumMember(Value = "group-default-role-manage")]
        group_default_role_manage = 6,

        /// <summary>
        /// Enum group_galleries_manage for value: group-galleries-manage
        /// </summary>
        [EnumMember(Value = "group-galleries-manage")]
        group_galleries_manage = 7,

        /// <summary>
        /// Enum group_instance_age_gated_create for value: group-instance-age-gated-create
        /// </summary>
        [EnumMember(Value = "group-instance-age-gated-create")]
        group_instance_age_gated_create = 8,

        /// <summary>
        /// Enum group_instance_join for value: group-instance-join
        /// </summary>
        [EnumMember(Value = "group-instance-join")]
        group_instance_join = 9,

        /// <summary>
        /// Enum group_instance_manage for value: group-instance-manage
        /// </summary>
        [EnumMember(Value = "group-instance-manage")]
        group_instance_manage = 10,

        /// <summary>
        /// Enum group_instance_moderate for value: group-instance-moderate
        /// </summary>
        [EnumMember(Value = "group-instance-moderate")]
        group_instance_moderate = 11,

        /// <summary>
        /// Enum group_instance_open_create for value: group-instance-open-create
        /// </summary>
        [EnumMember(Value = "group-instance-open-create")]
        group_instance_open_create = 12,

        /// <summary>
        /// Enum group_instance_plus_create for value: group-instance-plus-create
        /// </summary>
        [EnumMember(Value = "group-instance-plus-create")]
        group_instance_plus_create = 13,

        /// <summary>
        /// Enum group_instance_plus_portal for value: group-instance-plus-portal
        /// </summary>
        [EnumMember(Value = "group-instance-plus-portal")]
        group_instance_plus_portal = 14,

        /// <summary>
        /// Enum group_instance_plus_portal_unlocked for value: group-instance-plus-portal-unlocked
        /// </summary>
        [EnumMember(Value = "group-instance-plus-portal-unlocked")]
        group_instance_plus_portal_unlocked = 15,

        /// <summary>
        /// Enum group_instance_public_create for value: group-instance-public-create
        /// </summary>
        [EnumMember(Value = "group-instance-public-create")]
        group_instance_public_create = 16,

        /// <summary>
        /// Enum group_instance_queue_priority for value: group-instance-queue-priority
        /// </summary>
        [EnumMember(Value = "group-instance-queue-priority")]
        group_instance_queue_priority = 17,

        /// <summary>
        /// Enum group_instance_restricted_create for value: group-instance-restricted-create
        /// </summary>
        [EnumMember(Value = "group-instance-restricted-create")]
        group_instance_restricted_create = 18,

        /// <summary>
        /// Enum group_invites_manage for value: group-invites-manage
        /// </summary>
        [EnumMember(Value = "group-invites-manage")]
        group_invites_manage = 19,

        /// <summary>
        /// Enum group_members_manage for value: group-members-manage
        /// </summary>
        [EnumMember(Value = "group-members-manage")]
        group_members_manage = 20,

        /// <summary>
        /// Enum group_members_remove for value: group-members-remove
        /// </summary>
        [EnumMember(Value = "group-members-remove")]
        group_members_remove = 21,

        /// <summary>
        /// Enum group_members_viewall for value: group-members-viewall
        /// </summary>
        [EnumMember(Value = "group-members-viewall")]
        group_members_viewall = 22,

        /// <summary>
        /// Enum group_roles_assign for value: group-roles-assign
        /// </summary>
        [EnumMember(Value = "group-roles-assign")]
        group_roles_assign = 23,

        /// <summary>
        /// Enum group_roles_manage for value: group-roles-manage
        /// </summary>
        [EnumMember(Value = "group-roles-manage")]
        group_roles_manage = 24

    }

}
