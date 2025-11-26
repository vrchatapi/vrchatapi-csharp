using System.Threading.Tasks;
using VRChat.API.Client;

namespace VRChat.API.Extensions.Hosting
{
    /// <summary>
    /// An interface used for implementing a factory to build <see cref="IVRChat"/> clients from DI.
    /// </summary>
    public interface IVRChatClientFactory
    {
        /// <summary>
        /// Creates a client using the default client provider and configuration.
        /// </summary>
        /// <returns>An instance of <see cref="IVRChat"/> from the default client provider.</returns>
        IVRChat CreateClient();

        /// <summary>
        /// Creates a named client from the client provider and named configuration.
        /// </summary>
        /// <param name="name">The name of the client to create</param>
        /// <returns>An instance of <see cref="IVRChat"/> from the named client provider.</returns>
        IVRChat CreateClient(string name);

        /// <summary>
        /// Calls <see cref="IVRChat.TryLoginAsync(System.Threading.CancellationToken)"/> on ALL of the registered clients, thus forcing them to have a populated authcookie.
        /// <br /> This also ensures that all clients are logged in. <b>This method does not throw an exception.</b>
        /// </summary>
        /// <returns>A <see cref="Task"/> representing this asyncronous operation.</returns>
        Task LoginAllClientsAsync();

        /// <summary>
        /// Calls <see cref="IVRChat.TryLoginAsync(System.Threading.CancellationToken)"/> on the named client, thus forcing the client to have a populated authcookie.
        /// <br /> This also ensures that the specified client is logged in. <b>This method does not throw an exception.</b>
        /// </summary>
        /// <param name="name">The name of the client to login</param>
        /// <returns>A <see cref="Task"/> representing this asyncronous operation.</returns>
        Task LoginClientAsync(string name = "vrc_default");
    }
}