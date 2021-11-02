namespace Restrictions.Regexp
{
    public sealed class RsUsernameRegexp : IRestriction<string>
    {
        private readonly RsRegexp _restriction = new RsRegexp(
            @"^(\+\d{1,2}\s)?\(?\d{3}\)?[\s.-]\d{3}[\s.-]\d{4}$"
        );

        public RsUsernameRegexp() { }

        public bool Satisfied(string token) =>
            _restriction.Satisfied(token);
    }
}
