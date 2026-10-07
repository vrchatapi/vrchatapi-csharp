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
    /// Additions to the generated <see cref="AbstractOpenAPISchema"/>, which every union type extends.
    /// </summary>
    public abstract partial class AbstractOpenAPISchema
    {
        /// <summary>
        /// The value this instance holds: one of the union's member types.
        /// </summary>
        public object Value => ActualInstance;

        /// <summary>
        /// Whether this instance holds a <typeparamref name="T"/>.
        /// </summary>
        public bool Is<T>() => Value is T;

        /// <summary>
        /// Gets the <typeparamref name="T"/> this instance holds, if it holds one.
        /// </summary>
        public bool TryGet<T>(out T value)
        {
            if (Value is T instance)
            {
                value = instance;
                return true;
            }

            value = default;
            return false;
        }
    }
}
