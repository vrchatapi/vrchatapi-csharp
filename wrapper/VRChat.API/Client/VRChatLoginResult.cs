using System;

namespace VRChat.API.Client
{
    /// <summary>
    /// Represents the result of a VRChat login attempt, including success status and any exception encountered.
    /// </summary>
    /// <remarks>Use this class to determine whether a login operation to VRChat completed successfully and to
    /// access any exception that occurred during the process. The properties provide information about the outcome and
    /// any error details for diagnostic purposes.</remarks>
    public class VRChatLoginResult
    {
        /// <summary>
        /// Initializes a new instance of the VRChatLoginResult class with the specified success status and optional
        /// exception information.
        /// </summary>
        /// <param name="success">A value indicating whether the login operation was successful. Set to <see langword="true"/> if the login
        /// succeeded; otherwise, <see langword="false"/>.</param>
        /// <param name="exception">The exception that occurred during the login operation, if any. Specify <see langword="null"/> if no
        /// exception was thrown.</param>
        public VRChatLoginResult(bool success,  Exception exception = null)
        {
            Success = success;
            Exception = exception;
        }

        /// <summary>
        /// Gets a value indicating whether the operation completed successfully.
        /// </summary>
        public bool Success { get; private set; }

        /// <summary>
        /// Gets the exception that caused the current operation to fail.
        /// </summary>
        /// <remarks>Use this property to retrieve detailed information about the error that occurred
        /// during the operation. If the operation completed successfully, this property will be null.</remarks>
        public Exception Exception { get; private set; }
    }
}
