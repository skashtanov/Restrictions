namespace Restrictions.Single.Nullability
{
    public sealed class RsNotNull<T> : IRestriction
        where T : class
    {
        private readonly T _value;

        public RsNotNull(T value) =>
            _value = value;

        public bool Satisfied =>
            _value is not null;
    }
}
