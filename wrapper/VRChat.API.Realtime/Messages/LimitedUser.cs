using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VRChat.API.Realtime.Messages
{
    /// <summary>
    /// Represents limited user information received in WebSocket messages.
    /// </summary>
    /// <remarks>
    /// This class contains a subset of user profile information that is included
    /// in various WebSocket events such as friend updates and location changes.
    /// For full user information, use the REST API.
    /// </remarks>
    /// <seealso cref="FriendOnlineContent"/>
    /// <seealso cref="FriendUpdateContent"/>
    /// <seealso cref="CurrentUserInfo"/>
    public class LimitedUser
    {
        /// <summary>
        /// Gets or sets the unique identifier of the user.
        /// </summary>
        /// <value>
        /// A user's unique ID, usually in the form of <c>usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469</c>.
        /// Legacy players can have old IDs in the form of <c>8JoV9XEdpo</c>.
        /// </value>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the user's unique username.
        /// </summary>
        /// <value>
        /// The user's login name, which is different from <see cref="DisplayName"/>.
        /// </value>
        /// <remarks>
        /// <b>DEPRECATED:</b> VRChat API no longer returns usernames of other users.
        /// See <see href="https://github.com/pypy-vrc/VRCX/issues/429">this issue</see> for more information.
        /// </remarks>
        [Obsolete("VRChat API no longer returns usernames of other users.")]
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets the user's display name.
        /// </summary>
        /// <value>
        /// The user's visual display name shown in-game. Changing display name is restricted to a cooldown period.
        /// </value>
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the user's biography text.
        /// </summary>
        /// <value>
        /// The user's bio, limited to 512 characters.
        /// </value>
        public string Bio { get; set; }

        /// <summary>
        /// Gets or sets the user's biography links.
        /// </summary>
        /// <value>
        /// A list of URLs included in the user's bio.
        /// </value>
        public List<string> BioLinks { get; set; }

        /// <summary>
        /// Gets or sets the URL of the user's current avatar image.
        /// </summary>
        /// <value>
        /// A URL to the full avatar image. When <see cref="ProfilePicOverride"/> is not empty,
        /// that should be used instead.
        /// </value>
        public string CurrentAvatarImageUrl { get; set; }

        /// <summary>
        /// Gets or sets the URL of the user's current avatar thumbnail image.
        /// </summary>
        /// <value>
        /// A URL to the avatar thumbnail image. When <see cref="ProfilePicOverride"/> is not empty,
        /// that should be used instead.
        /// </value>
        public string CurrentAvatarThumbnailImageUrl { get; set; }

        /// <summary>
        /// Gets or sets the tags associated with the user's current avatar.
        /// </summary>
        /// <value>
        /// A list of avatar feature tags.
        /// </value>
        public List<string> CurrentAvatarTags { get; set; }

        /// <summary>
        /// Gets or sets the user's developer type.
        /// </summary>
        /// <value>
        /// The developer type, such as "none", "trusted", or "internal".
        /// </value>
        public string DeveloperType { get; set; }

        /// <summary>
        /// Gets or sets whether the user is a friend.
        /// </summary>
        /// <value>
        /// <c>true</c> if the user is in your friends list; otherwise, <c>false</c>.
        /// </value>
        public bool IsFriend { get; set; }

        /// <summary>
        /// Gets or sets the friend key.
        /// </summary>
        /// <value>
        /// Either the user's friend key, or an empty string if you are not friends.
        /// </value>
        public string FriendKey { get; set; }

        /// <summary>
        /// Gets or sets the friend request status.
        /// </summary>
        /// <value>
        /// The status of any pending friend request between you and this user.
        /// </value>
        public string FriendRequestStatus { get; set; }

        /// <summary>
        /// Gets or sets the platform the user was last active on.
        /// </summary>
        /// <value>
        /// The platform identifier, such as "standalonewindows", "android", or other Unity version strings.
        /// </value>
        public string LastPlatform { get; set; }

        /// <summary>
        /// Gets or sets the user's current location.
        /// </summary>
        /// <value>
        /// A location string in the format <c>worldId:instanceId</c>.
        /// May be "offline" if not friends, or "private" if in a private instance.
        /// </value>
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets the instance ID of the user's current location.
        /// </summary>
        /// <value>
        /// The instance portion of the location, or "offline"/"private" depending on visibility.
        /// </value>
        public string InstanceId { get; set; }

        /// <summary>
        /// Gets or sets the world ID of the user's current world.
        /// </summary>
        /// <value>
        /// A world's unique ID in the form of <c>wrld_xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx</c>,
        /// or "offline" if not friends with the user.
        /// </value>
        public string WorldId { get; set; }

        /// <summary>
        /// Gets or sets the user's current platform.
        /// </summary>
        /// <value>
        /// The platform identifier for the user's current session.
        /// </value>
        public string Platform { get; set; }

        /// <summary>
        /// Gets or sets the URL of the user's profile picture override.
        /// </summary>
        /// <value>
        /// A URL to a custom profile picture. When set, this should be displayed
        /// instead of the avatar image URLs.
        /// </value>
        public string ProfilePicOverride { get; set; }

        /// <summary>
        /// Gets or sets the URL of the user's profile picture override thumbnail.
        /// </summary>
        /// <value>
        /// A URL to a thumbnail version of the custom profile picture.
        /// </value>
        public string ProfilePicOverrideThumbnail { get; set; }

        /// <summary>
        /// Gets or sets the user's pronouns.
        /// </summary>
        /// <value>
        /// The user's preferred pronouns as displayed on their profile.
        /// </value>
        public string Pronouns { get; set; }

        /// <summary>
        /// Gets or sets the user's current status.
        /// </summary>
        /// <value>
        /// The status type, such as "active", "join me", "ask me", "busy", or "offline".
        /// </value>
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the user's custom status description.
        /// </summary>
        /// <value>
        /// A custom status message set by the user.
        /// </value>
        public string StatusDescription { get; set; }

        /// <summary>
        /// Gets or sets the user's state.
        /// </summary>
        /// <value>
        /// The user's current state, such as "online", "active", or "offline".
        /// </value>
        public string State { get; set; }

        /// <summary>
        /// Gets or sets the user's tags.
        /// </summary>
        /// <value>
        /// A list of system and user-assigned tags, such as trust rank tags and feature flags.
        /// Note: This is always empty when querying friends via the friend list endpoint.
        /// </value>
        public List<string> Tags { get; set; }

        /// <summary>
        /// Gets or sets the URL of the user's custom icon.
        /// </summary>
        /// <value>
        /// A URL to the user's custom icon image, or <c>null</c> if not set.
        /// </value>
        public string UserIcon { get; set; }

        /// <summary>
        /// Gets or sets a note about this user.
        /// </summary>
        /// <value>
        /// A personal note you've saved about this user, or <c>null</c> if no note exists.
        /// </value>
        public string Note { get; set; }

        /// <summary>
        /// Gets or sets the user's age verification status.
        /// </summary>
        /// <value>
        /// The age verification status string.
        /// </value>
        public string AgeVerificationStatus { get; set; }

        /// <summary>
        /// Gets or sets whether the user is age verified.
        /// </summary>
        /// <value>
        /// <c>true</c> if the user has completed age verification; otherwise, <c>false</c>.
        /// Note: This is not the same as being 18+ verified.
        /// </value>
        public bool AgeVerified { get; set; }

        /// <summary>
        /// Gets or sets whether the user allows avatar copying.
        /// </summary>
        /// <value>
        /// <c>true</c> if the user allows their avatar to be cloned; otherwise, <c>false</c>.
        /// </value>
        public bool AllowAvatarCopying { get; set; }

        /// <summary>
        /// Gets or sets the instance the user is traveling to.
        /// </summary>
        /// <value>
        /// The target instance ID if the user is traveling, or <c>null</c> if not traveling.
        /// </value>
        public string TravelingToInstance { get; set; }

        /// <summary>
        /// Gets or sets the location the user is traveling to.
        /// </summary>
        /// <value>
        /// The full location string of the destination, or <c>null</c> if not traveling.
        /// </value>
        public string TravelingToLocation { get; set; }

        /// <summary>
        /// Gets or sets the world the user is traveling to.
        /// </summary>
        /// <value>
        /// The world ID of the destination, or <c>null</c> if not traveling.
        /// </value>
        public string TravelingToWorld { get; set; }

        /// <summary>
        /// Gets or sets the date the user joined VRChat.
        /// </summary>
        /// <value>
        /// A date string in ISO format, or <c>null</c> if not available.
        /// </value>
        [JsonPropertyName("date_joined")]
        public string DateJoined { get; set; }

        /// <summary>
        /// Gets or sets the user's last activity timestamp.
        /// </summary>
        /// <value>
        /// A date-time string of the user's last activity, or an empty string.
        /// </value>
        [JsonPropertyName("last_activity")]
        public string LastActivity { get; set; }

        /// <summary>
        /// Gets or sets the user's last login timestamp.
        /// </summary>
        /// <value>
        /// A date-time string of the user's last login, or an empty string.
        /// </value>
        [JsonPropertyName("last_login")]
        public string LastLogin { get; set; }

        /// <summary>
        /// Gets or sets the user's last mobile login timestamp.
        /// </summary>
        /// <value>
        /// A date-time string of the user's last mobile login, or <c>null</c>.
        /// </value>
        [JsonPropertyName("last_mobile")]
        public string LastMobile { get; set; }

        /// <summary>
        /// Gets or sets the user's badges.
        /// </summary>
        /// <value>
        /// A list of <see cref="Badge"/> objects representing the user's earned badges.
        /// </value>
        public List<Badge> Badges { get; set; }
    }

    /// <summary>
    /// Represents a badge that can be assigned to a user.
    /// </summary>
    /// <remarks>
    /// Badges are visual indicators of achievements, subscriptions (like VRChat+),
    /// or special recognitions displayed on user profiles.
    /// </remarks>
    /// <seealso cref="UserBadgeAssignedContent"/>
    /// <seealso cref="UserBadgeUnassignedContent"/>
    public class Badge
    {
        /// <summary>
        /// Gets or sets the unique identifier of the badge.
        /// </summary>
        /// <value>
        /// A badge ID in the form of <c>bdge_xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx</c>.
        /// </value>
        public string BadgeId { get; set; }

        /// <summary>
        /// Gets or sets the display name of the badge.
        /// </summary>
        /// <value>
        /// The human-readable name of the badge, such as "VRChat Plus Supporter".
        /// </value>
        public string BadgeName { get; set; }

        /// <summary>
        /// Gets or sets the description of the badge.
        /// </summary>
        /// <value>
        /// A description explaining how the badge was earned or what it represents.
        /// </value>
        public string BadgeDescription { get; set; }

        /// <summary>
        /// Gets or sets the URL of the badge image.
        /// </summary>
        /// <value>
        /// A URL to the badge icon image.
        /// </value>
        public string BadgeImageUrl { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the badge was assigned.
        /// </summary>
        /// <value>
        /// The UTC timestamp of when the badge was given to the user.
        /// </value>
        public DateTime AssignedAt { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the badge was last updated.
        /// </summary>
        /// <value>
        /// The UTC timestamp of the last modification to this badge assignment.
        /// </value>
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Gets or sets whether the badge is hidden.
        /// </summary>
        /// <value>
        /// <c>true</c> if the user has chosen to hide this badge; otherwise, <c>false</c>.
        /// </value>
        public bool Hidden { get; set; }

        /// <summary>
        /// Gets or sets whether the badge is showcased on the user's profile.
        /// </summary>
        /// <value>
        /// <c>true</c> if the badge is featured/showcased; otherwise, <c>false</c>.
        /// </value>
        public bool Showcased { get; set; }
    }
}
