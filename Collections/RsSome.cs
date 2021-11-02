namespace Restrictions.Collections
{
    public sealed class RsSome : IRestriction
    {
        private readonly IEnumerable<IRestriction> _restrictions;
        private readonly int _amount;

        public RsSome(IEnumerable<IRestriction> restrictions, int amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException($"{nameof(amount)} should be > 0");
            }
            _restrictions = restrictions;
            _amount = amount;
        }

        public bool Satisfied
        {
            get
            {
                return _restrictions.Count(restriction => restriction.Satisfied) >= _amount;
            }
        }
    }

}
