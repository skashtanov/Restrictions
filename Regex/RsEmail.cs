namespace Restrictions.Regex
{
    public sealed class RsEmail
    {
        private readonly RsRegex _emailPattern = new RsRegex(
            @"[^@ \t\r\n]+@[^@ \t\r\n]+\.[^@ \t\r\n]+"
        );

        public RsEmail() { }

        public bool Satisfied(string token) =>
            _emailPattern.Satisfied(token);
    }
}
