namespace SourceologyTest
{
    public readonly struct SymmetricCharacterRule
    {
        public readonly char Opening { get; init; }
        public readonly char Closing { get; init; }

        public static SymmetricCharacterRule Braces = new SymmetricCharacterRule() { Opening = '{', Closing = '}' };
        public static SymmetricCharacterRule Parenthesis = new SymmetricCharacterRule() { Opening = '(', Closing = ')' };
        public static SymmetricCharacterRule Brackets = new SymmetricCharacterRule() { Opening = '[', Closing = ']' };
        public static SymmetricCharacterRule Chevrons = new SymmetricCharacterRule() { Opening = '⟨', Closing = '⟩' };
    }
}
