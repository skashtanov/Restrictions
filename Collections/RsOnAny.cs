namespace Restrictions.Collections
{
    public sealed class RsOnAny<T> : IRestriction
    {
        private readonly IEnumerable<T> _values;
        private readonly IRestriction<T> _restriction;

        public RsOnAny(IEnumerable<T> values, IRestriction<T> restriction) =>
            (_values, _restriction) = (values, restriction);

        public bool Satisfied
        {
            get
            {
                return _values.Any(value => _restriction.SatisfiedBy(value));
            }
        }
    }
}
