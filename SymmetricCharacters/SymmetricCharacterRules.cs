using System;
using System.Collections.Generic;

namespace SourceologyTest
{
    public class SymmetricCharacterRules
    {
        private HashSet<char> _allChars = new HashSet<char>();
        private Dictionary<char, char> _charPairs = new Dictionary<char, char>();

        public SymmetricCharacterRules(IEnumerable<SymmetricCharacterRule>? rules = null)
        {
            if (rules is not null)
            {
                foreach (var rule in rules)
                {
                    AddRule(rule);
                }
            }
        }

        public SymmetricCharacterRules AddRule(in SymmetricCharacterRule rule)
        {

            if (Contains(rule.Opening))
            {
                throw new ArgumentException($"The char {rule.Opening} is already part of a rule.", nameof(rule.Opening));
            }
            if (Contains(rule.Closing))
            {
                throw new ArgumentException($"The char {rule.Closing} is already part of a rule.", nameof(rule.Closing));
            }

            _charPairs.Add(rule.Closing, rule.Opening);
            _allChars.Add(rule.Opening);
            _allChars.Add(rule.Closing);

            return this;
        }

        public bool Opens(char c) => _allChars.Contains(c) && !_charPairs.ContainsKey(c);

        public bool Contains(char c) => _allChars.Contains(c);

        public bool Closes(char c) => _charPairs.ContainsKey(c);

        public bool Correspond(char openingChar, char closingChar)
        {
            if (_charPairs.TryGetValue(closingChar, out char expectedOpening))
            {
                return openingChar == expectedOpening;
            }

            return false;
        }
    }
}
