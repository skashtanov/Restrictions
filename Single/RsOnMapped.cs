namespace Restrictions.Single
{
    public sealed class RsOnMapped<TIn, TOut> : IRestriction<TIn>
    {
        private readonly Func<TIn, TOut> _mapper;
        private readonly IRestriction<TOut> _restriction;

        public RsOnMapped(Func<TIn, TOut> mapper, IRestriction<TOut> restriction) =>
            (_mapper, _restriction) = (mapper, restriction);

        public bool SatisfiedBy(TIn value) =>
            _restriction.SatisfiedBy(_mapper(value));
    }
}
