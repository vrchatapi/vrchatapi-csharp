namespace VRChat.API.Realtime.Messages
{
    /// <summary>
    /// Represents the content of an "instance-queue-joined" WebSocket event.
    /// </summary>
    /// <remarks>
    /// This event is raised when you join a queue to enter a full or restricted instance.
    /// You will receive an <see cref="InstanceQueueReadyContent"/> event when you reach
    /// the front of the queue and can join.
    /// </remarks>
    /// <seealso cref="InstanceQueueReadyContent"/>
    public class InstanceQueueJoinedContent
    {
        /// <summary>
        /// Gets or sets the location of the instance you are queued for.
        /// </summary>
        /// <value>
        /// A location string in the format <c>worldId:instanceId</c>, such as
        /// <c>wrld_4432ea9b-729c-46e3-8eaf-846aa0a37fdd:12345~private(usr_xxx)</c>.
        /// </value>
        public string InstanceLocation { get; set; }

        /// <summary>
        /// Gets or sets your current position in the queue.
        /// </summary>
        /// <value>
        /// A 1-based position number, where 1 means you are next in line to join.
        /// </value>
        public int Position { get; set; }
    }
}
