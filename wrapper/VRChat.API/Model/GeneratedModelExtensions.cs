using System.Collections.Generic;
using System.Runtime.Serialization;

namespace VRChat.API.Model
{
    /// <summary>
    /// Additions to the generated <see cref="TwoFactorAuthCode"/>, so it can be passed wherever a
    /// two-factor code is accepted.
    /// </summary>
    public partial class TwoFactorAuthCode : ITwoFactorCode { }

    /// <summary>
    /// Additions to the generated <see cref="TwoFactorEmailCode"/>, so it can be passed wherever a
    /// two-factor code is accepted.
    /// </summary>
    public partial class TwoFactorEmailCode : ITwoFactorCode { }

    /// <summary>
    /// Additions to the generated <see cref="CurrentUser"/>.
    /// </summary>
    public partial class CurrentUser
    {
        /// <summary>
        /// An array of two-factor authentication methods available to use to with two factor authentication.
        /// </summary>
        /// <remarks>The API returns this field on the current-user response while a login is pending
        /// two-factor verification, but the specification does not model it, so it is declared here.</remarks>
        [DataMember(Name = "requiresTwoFactorAuth", IsRequired = false, EmitDefaultValue = true)]
        public List<string> RequiresTwoFactorAuth { get; set; }
    }
}
