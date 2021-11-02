namespace Restrictions.Collections
{
    public sealed class RsAny : IRestriction
    {
        private readonly IEnumerable<IRestriction> _restrictions;

        public RsAny(IEnumerable<IRestriction> restrictions) =>
            _restrictions = restrictions;

        public bool Satisfied
        {
            get
            {
                return _restrictions.Any(restriction => restriction.Satisfied);
            }
        }
    }
}
