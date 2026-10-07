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
        /// Whether this instance holds a <typeparamref name="T"/>.
        /// </summary>
        public bool Is<T>() => ActualInstance is T;

        /// <summary>
        /// The <typeparamref name="T"/> this instance holds, throwing <see cref="System.InvalidCastException"/> when it holds another type.
        /// </summary>
        public T As<T>() => (T)ActualInstance;

        /// <summary>
        /// Gets the <typeparamref name="T"/> this instance holds, if it holds one.
        /// </summary>
        public bool TryGet<T>(out T value)
        {
            if (ActualInstance is T instance)
            {
                value = instance;
                return true;
            }

            value = default;
            return false;
        }
    }
}
