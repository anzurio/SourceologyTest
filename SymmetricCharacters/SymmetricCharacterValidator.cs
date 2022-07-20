using System.Collections.Generic;

namespace SourceologyTest
{
    public class SymmetricCharacterValidator
    {
        private readonly SymmetricCharacterRules _rules;

        public SymmetricCharacterValidator(SymmetricCharacterRules rules)
        {
            _rules = rules;
        }

        public bool Validate(string input)
        {
            var stack = new Stack<char>(); 
            foreach (var c in input)
            {
                if (_rules.Opens(c))
                {
                    stack.Push(c);
                }
                else if (_rules.Closes(c))
                {
                    if (stack.TryPeek(out char top) && _rules.Correspond(top, c))
                    {
                        stack.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }
    }
}