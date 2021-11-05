namespace Restrictions.Regexp
{
    public sealed class RsEmailRegexp
    {
        private readonly RsRegexp _emailPattern = new RsRegexp(
            @"[^@ \t\r\n]+@[^@ \t\r\n]+\.[^@ \t\r\n]+"
        );

        public RsEmailRegexp() { }

        public bool SatisfiedBy(string token) =>
            _emailPattern.Satisfied(token);
    }
}
