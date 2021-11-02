namespace Restrictions.Collections
{
    public sealed class RsOnSome<T> : IRestriction
    {
        private readonly IEnumerable<T> _values;
        private readonly IRestriction<T> _restriction;
        private readonly int _amount;

        public RsOnSome(IEnumerable<T> values, IRestriction<T> restriction, int amount) 
        {
             if (amount < 0)
            {
                throw new ArgumentException($"{nameof(amount)} should be > 0");
            }
            _values = values;
            _restriction = restrictions;
            _amount = amount;
        }

        public bool Satisfied
        {
            get
            {
                return _values.Count(value => _restriction.SatisfiedBy(value)) >= _amount;
            }
        }
    }
}
