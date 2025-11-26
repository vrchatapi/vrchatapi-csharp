using System.Collections.Generic;
using System.Threading;
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
        /// <param name="throwOnFail">Whether or not to throw an exception if any login fails.</param>
        /// <param name="ct">A <see cref="CancellationToken"/> to cancel the login operation.</param>
        /// <returns>A <see cref="Task{TResult}"/> representing this asynchronous operation, containing a <see cref="Dictionary{TKey, TValue}" /> that maps client names to <see cref="VRChatLoginResult"/> of success status and exception information.</returns>
        Task<Dictionary<string, VRChatLoginResult>> LoginAllClientsAsync(bool throwOnFail = false, CancellationToken ct = default);

        /// <summary>
        /// Calls <see cref="IVRChat.TryLoginAsync(System.Threading.CancellationToken)"/> on the named client, thus forcing the client to have a populated authcookie.
        /// <br /> This also ensures that the specified client is logged in. <b>This method does not throw an exception.</b>
        /// </summary>
        /// <param name="name">The name of the client to login</param>
        /// <param name="throwOnFail">Whether or not to throw an exception if the login fails.</param>
        /// <param name="ct">A <see cref="CancellationToken"/> to cancel the login operation.</param>
        /// <returns>
        /// A <see cref="Task"/> of <see cref="VRChatLoginResult"/> representing this asynchronous operation. The result contains a <see cref="VRChatLoginResult"/> specifying if the current client is logged in successfully and any exceptions returned.
        /// </returns>
        Task<VRChatLoginResult> LoginClientAsync(string name = "vrc_default", bool throwOnFail = false, CancellationToken ct = default);
    }
}