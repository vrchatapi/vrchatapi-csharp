namespace VRChat.API.Realtime.Messages
{
    /// <summary>
    /// Represents the content of a "content-refresh" WebSocket event.
    /// </summary>
    /// <remarks>
    /// This event is raised when content is added, removed, or modified on your profile.
    /// This includes avatars, worlds, images, stickers, and other user-uploaded content.
    /// </remarks>
    public class ContentRefreshContent
    {
        /// <summary>
        /// Gets or sets the type of content that was refreshed.
        /// </summary>
        /// <value>
        /// The content type, such as "gallery", "avatar", "world", "emoji", etc.
        /// </value>
        public string ContentType { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of the associated file.
        /// </summary>
        /// <value>
        /// A file ID in the form of <c>file_xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx</c>,
        /// or <c>null</c> if not applicable.
        /// </value>
        public string FileId { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of the content item.
        /// </summary>
        /// <value>
        /// The item ID, such as an avatar ID (<c>avtr_xxx</c>), world ID (<c>wrld_xxx</c>),
        /// or other content-specific identifier.
        /// </value>
        public string ItemId { get; set; }

        /// <summary>
        /// Gets or sets the type of the content item.
        /// </summary>
        /// <value>
        /// The item type classification, providing more specific information about the content.
        /// </value>
        public string ItemType { get; set; }

        /// <summary>
        /// Gets or sets the action that triggered the refresh.
        /// </summary>
        /// <value>
        /// The action type, such as "add", "remove", "update", etc.
        /// </value>
        public string ActionType { get; set; }
    }
}
