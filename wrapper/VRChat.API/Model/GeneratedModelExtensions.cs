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
}
