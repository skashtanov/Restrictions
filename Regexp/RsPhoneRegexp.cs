namespace Restrictions.Regexp
{
    public sealed class RsPhoneRegexp : IRestriction<string>
    {
        private readonly RsRegexp _phonePattern = new RsRegexp(
            @"^[\+]?[(]?[0-9]{3}[)]?[-\s\.]?[0-9]{3}[-\s\.]?[0-9]{4,6}$"
        );

        public RsPhoneRegexp() { }

        public bool SatisfiedBy(string token) =>
            _phonePattern.Satisfied(token);
    }
}
