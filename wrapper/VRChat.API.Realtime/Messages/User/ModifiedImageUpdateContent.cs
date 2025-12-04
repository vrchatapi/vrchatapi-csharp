namespace VRChat.API.Realtime.Messages
{
    /// <summary>
    /// Represents the content of a "modified-image-update" WebSocket event.
    /// </summary>
    /// <remarks>
    /// This event is raised when an image file is modified or processed.
    /// This typically occurs when uploading new images or when VRChat processes
    /// images for different resolutions.
    /// </remarks>
    public class ModifiedImageUpdateContent
    {
        /// <summary>
        /// Gets or sets the unique identifier of the file that was modified.
        /// </summary>
        /// <value>
        /// A file ID in the form of <c>file_xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx</c>.
        /// </value>
        public string FileId { get; set; }

        /// <summary>
        /// Gets or sets the pixel size of the processed image.
        /// </summary>
        /// <value>
        /// The size in pixels, such as 256, 512, or 1024 for standard thumbnail sizes.
        /// </value>
        public int PixelSize { get; set; }

        /// <summary>
        /// Gets or sets the version number of the file.
        /// </summary>
        /// <value>
        /// An integer version number that increments with each file modification.
        /// </value>
        public int VersionNumber { get; set; }

        /// <summary>
        /// Gets or sets whether the image still needs processing.
        /// </summary>
        /// <value>
        /// <c>true</c> if additional processing is required; <c>false</c> if processing is complete.
        /// </value>
        public bool NeedsProcessing { get; set; }
    }
}
