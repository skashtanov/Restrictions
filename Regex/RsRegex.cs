using Regexp = System.Text.RegularExpressions.Regex;


namespace Restrictions.Regex
{
    public sealed class RsRegex : IRestriction<string>
    {
        private readonly Regexp _pattern;

        public RsRegex(Regexp pattern) =>
            _pattern = pattern;
        
        public RsRegex(string pattern) :
            this(new Regexp(pattern)) {  }

        public bool Satisfied(string token) =>
            _pattern.IsMatch(token);
    }
}