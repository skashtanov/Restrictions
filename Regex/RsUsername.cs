namespace Restrictions.Regex
{
    public sealed class RsUsername : IRestriction<string>
    {
        private readonly RsRegex _restriction = new RsRegex(
            @"^(\+\d{1,2}\s)?\(?\d{3}\)?[\s.-]\d{3}[\s.-]\d{4}$"
        );

        public RsUsername() { }

        public bool Satisfied(string token) =>
            _restriction.Satisfied(token);
    }
}
