namespace SourceologyTest
{
    public readonly struct SymmetricCharacterRule
    {
        private static readonly SymmetricCharacterRule braces = new SymmetricCharacterRule() { Opening = '{', Closing = '}' };
        private static readonly SymmetricCharacterRule parenthesis = new SymmetricCharacterRule() { Opening = '(', Closing = ')' };
        private static readonly SymmetricCharacterRule brackets = new SymmetricCharacterRule() { Opening = '[', Closing = ']' };
        private static SymmetricCharacterRule chevrons = new SymmetricCharacterRule() { Opening = '⟨', Closing = '⟩' };

        public readonly char Opening { get; init; }
        public readonly char Closing { get; init; }

        public static SymmetricCharacterRule Braces => braces;
        public static SymmetricCharacterRule Parenthesis => parenthesis;
        public static SymmetricCharacterRule Brackets => brackets;
        public static SymmetricCharacterRule Chevrons => chevrons;
    }
}
