namespace Restrictions.Collections
{
    public sealed class RsAll : IRestriction
    {
        private readonly IEnumerable<IRestriction> _restrictions;

        public RsAll(IEnumerable<IRestriction> restrictions) =>
            _restrictions = restrictions;

        public RsAll(params IRestriction[] restrictions) :
            this(restrictions.ToList())
        { }

        public bool Satisfied
        {
            get
            {
                return _restrictions.All(restriction => restriction.Satisfied);
            }
        }
    }
}
