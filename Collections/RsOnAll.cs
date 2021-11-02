namespace Restrictions.Collections
{
    public sealed class RsOnAll<T> : IRestriction
    {
        private readonly IEnumerable<T> _values;
        private readonly IRestriction<T> _restriction;

        public RsOnAll(IEnumerable<T> values, IRestriction<T> restriction) =>
            (_values, _restriction) = (values, restriction);

        public bool Satisfied
        {
            get
            {
                return _values.All(value => _restriction.SatisfiedBy(value));
            }
        }
    }
}
