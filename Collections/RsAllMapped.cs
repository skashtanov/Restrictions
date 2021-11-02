namespace Restrictions.Collections
{
    public sealed class RsAllMapped<TIn, TOut> : IRestriction
    {
        private readonly IEnumerable<TIn> _values;
        private readonly Func<TIn, TOut> _mapper;
        private readonly IRestriction<TOut> _restriction;

        public RsAllMapped(IEnumerable<TIn> values, Func<TIn, TOut> mapper, 
                           IRestriction<TOut> restriction) =>
            (_values, _mapper, _restriction) = (values, mapper, restriction);

        public bool Satisfied =>
            _values.All(value => _restriction.SatisfiedBy(_mapper(value)));
    }
}
