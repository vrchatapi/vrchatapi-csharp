using System.Text.Json.Serialization;

namespace VRChat.API.Realtime.Messages
{
    /// <summary>
    /// Represents the content of a "friend-active" WebSocket event.
    /// </summary>
    /// <remarks>
    /// This event is raised when a friend becomes active on the VRChat website
    /// (not in-game). This is different from <see cref="FriendOnlineContent"/> which
    /// indicates a friend is online in the VRChat game client.
    /// </remarks>
    /// <seealso cref="FriendOnlineContent"/>
    /// <seealso cref="FriendOfflineContent"/>
    public class FriendActiveContent
    {
        /// <summary>
        /// Gets or sets the unique identifier of the friend who became active.
        /// </summary>
        /// <value>
        /// A user's unique ID, usually in the form of <c>usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469</c>.
        /// Legacy players can have old IDs in the form of <c>8JoV9XEdpo</c>.
        /// </value>
        /// <remarks>
        /// Note: The VRChat API sends this as lowercase "userid" instead of "userId",
        /// hence the <see cref="JsonPropertyNameAttribute"/>.
        /// </remarks>
        [JsonPropertyName("userid")]
        public string UserId { get; set; }

        /// <summary>
        /// Gets or sets the platform the friend is active on.
        /// </summary>
        /// <value>
        /// The platform identifier, typically "web" for website activity.
        /// </value>
        public string Platform { get; set; }

        /// <summary>
        /// Gets or sets the friend's user information.
        /// </summary>
        /// <value>
        /// A <see cref="LimitedUser"/> object containing the friend's profile information,
        /// or <c>null</c> if not provided.
        /// </value>
        public LimitedUser User { get; set; }
    }
}
