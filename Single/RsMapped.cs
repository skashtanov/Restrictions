namespace Restrictions.Collections
{
    public sealed class RsMapped<TIn, TOut> : IRestriction
    {
        private readonly TIn _value;
        private readonly Func<TIn, TOut> _mapper;
        private readonly IRestriction<TOut> _restriction;

        public RsMapped(TIn value, Func<TIn, TOut> mapper, IRestriction<TOut> restriction) =>
            (_value, _mapper, _restriction) = (value, mapper, restriction);

        public bool Satisfied =>
            _restriction.Satisfied(_mapper(_value));
    }
}
