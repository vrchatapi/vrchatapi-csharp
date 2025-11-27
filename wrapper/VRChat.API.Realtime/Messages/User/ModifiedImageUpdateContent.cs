namespace VRChat.API.Realtime.Messages
{
    public class ModifiedImageUpdateContent
    {
        public string FileId { get; set; }
        public int PixelSize { get; set; }
        public int VersionNumber { get; set; }
        public bool NeedsProcessing { get; set; }
    }
}

