using Regexp = System.Text.RegularExpressions.Regex;


namespace Restrictions.Regex
{

    public sealed class RsPhone : IRestriction<string>
    {
        private readonly RsRegex _phonePattern = new RsRegex(
            @"^[\+]?[(]?[0-9]{3}[)]?[-\s\.]?[0-9]{3}[-\s\.]?[0-9]{4,6}$"
        );

        public RsPhone() { }

        public bool Satisfied(string token) =>
            _phonePattern.Satisfied(token);
    }
}
