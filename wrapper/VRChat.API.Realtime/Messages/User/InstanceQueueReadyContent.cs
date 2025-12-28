using System;

namespace VRChat.API.Realtime.Messages
{
    /// <summary>
    /// Represents the content of an "instance-queue-ready" WebSocket event.
    /// </summary>
    /// <remarks>
    /// This event is raised when you reach the front of an instance queue and can join.
    /// You should join the instance before the expiry time, or you will lose your spot.
    /// </remarks>
    /// <seealso cref="InstanceQueueJoinedContent"/>
    public class InstanceQueueReadyContent
    {
        /// <summary>
        /// Gets or sets the location of the instance you can now join.
        /// </summary>
        /// <value>
        /// A location string in the format <c>worldId:instanceId</c>, such as
        /// <c>wrld_4432ea9b-729c-46e3-8eaf-846aa0a37fdd:12345~private(usr_xxx)</c>.
        /// </value>
        public string InstanceLocation { get; set; }

        /// <summary>
        /// Gets or sets the expiration time for joining the instance.
        /// </summary>
        /// <value>
        /// The UTC timestamp by which you must join the instance, or you will lose your queue spot.
        /// </value>
        public DateTime Expiry { get; set; }
    }
}
