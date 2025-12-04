using System.Collections.Generic;

namespace VRChat.API.Realtime.Messages
{
    /// <summary>
    /// Represents the current user's profile information in WebSocket messages.
    /// </summary>
    /// <remarks>
    /// This class contains a subset of user profile fields that are included
    /// in user update events. For full user information, use the REST API.
    /// </remarks>
    /// <seealso cref="UserUpdateContent"/>
    public class CurrentUserInfo
    {
        /// <summary>
        /// Gets or sets the user's biography text.
        /// </summary>
        /// <value>
        /// The user's bio, limited to 512 characters.
        /// </value>
        public string Bio { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of the user's current avatar.
        /// </summary>
        /// <value>
        /// An avatar ID in the form of <c>avtr_xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx</c>.
        /// </value>
        public string CurrentAvatar { get; set; }

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
        /// Gets or sets the user's display name.
        /// </summary>
        /// <value>
        /// The user's visual display name shown in-game. This can be different from the username.
        /// </value>
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of the user's fallback avatar.
        /// </summary>
        /// <value>
        /// An avatar ID used when the primary avatar cannot be loaded.
        /// </value>
        public string FallbackAvatar { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of the user.
        /// </summary>
        /// <value>
        /// A user's unique ID, usually in the form of <c>usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469</c>.
        /// Legacy players can have old IDs in the form of <c>8JoV9XEdpo</c>.
        /// </value>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the URL of the user's profile picture override.
        /// </summary>
        /// <value>
        /// A URL to a custom profile picture, or <c>null</c> if using the avatar image.
        /// When set, this should be displayed instead of the avatar image URLs.
        /// </value>
        public string ProfilePicOverride { get; set; }

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
        /// Gets or sets the user's tags.
        /// </summary>
        /// <value>
        /// A list of system and user-assigned tags, such as trust rank tags and feature flags.
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
        /// Gets or sets the user's username.
        /// </summary>
        /// <value>
        /// The user's unique login name. This is different from <see cref="DisplayName"/>.
        /// </value>
        /// <remarks>
        /// Note: VRChat no longer returns usernames of other users in most API responses,
        /// but this may be available for the current user.
        /// </remarks>
        public string Username { get; set; }
    }
}
