namespace Restrictions.Collections
{
    public sealed class RsSome : IRestriction
    {
        private readonly IEnumerable<IRestriction> _restrictions;
        private readonly int _amount;

        public RsSome(int amount, IEnumerable<IRestriction> restrictions)
        {
            if (amount < 0)
            {
                throw new ArgumentException($"{nameof(amount)} should be > 0");
            }
            _amount = amount;
            _restrictions = restrictions;
        }
           

        public RsSome(int amount, params IRestriction[] restrictions) :
            this(amount, restrictions.ToList())
        { }

        public bool Satisfied
        {
            get
            {
                return _restrictions.Count(restriction => restriction.Satisfied) >= _amount;
            }
        }
    }

}
