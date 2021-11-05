﻿using System.Text.RegularExpressions;


namespace Restrictions.Regexp
{
    public sealed class RsRegexp : IRestriction<string>
    {
        private readonly Regex _pattern;

        public RsRegexp(Regex pattern) =>
            _pattern = pattern;
        
        public RsRegexp(string pattern) :
            this(new Regexp(pattern)) {  }

        public bool SatisfiedBy(string token) =>
            _pattern.IsMatch(token);
    }
}