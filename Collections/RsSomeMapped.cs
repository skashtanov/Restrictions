namespace Restrictions.Collections
{
    public sealed class RsSomeMapped<TIn, TOut> : IRestriction
    {
        private readonly IEnumerable<TIn> _values;
        private readonly Func<TIn, TOut> _mapper;
        private readonly IRestriction<TOut> _restriction;
        private readonly int _amount;

        public RsSomeMapped(IEnumerable<TIn> values, Func<TIn, TOut> mapper, 
                            IRestriction<TOut> restriction, int amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException($"{nameof(amount)} should be > 0");
            }
            _values = values;
            _mapper = mapper;
            _restriction = restriction;
            _amount = amount;
        }

        public bool Satisfied
        {
            get
            {
                return _values.Count(value => _restriction.SatisfiedBy(_mapper(value))) >= _amount;
            }
        }
    }

}
