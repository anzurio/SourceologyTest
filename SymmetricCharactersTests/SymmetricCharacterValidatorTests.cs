using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SourceologyTest.Tests
{
    [TestClass()]
    public class SymmetricCharacterValidatorTests
    {
        [TestMethod("Sample Test Cases for Braces Only")]
        [DataRow("{}", true)]
        [DataRow("}{", false)]
        [DataRow("{}}", false)]
        [DataRow("", true)]
        [DataRow("{abc...xyz}", true)]
        public void ProvidedBracesTests(string input, bool expectedResult)
        {
            var rules = new SymmetricCharacterRules(new[] { SymmetricCharacterRule.Braces });
            var bracesValidator = new SymmetricCharacterValidator(rules);
            Assert.AreEqual(expectedResult, bracesValidator.Validate(input));
        }

        [TestMethod("Negative Tests")]
        [DataRow(")(")]
        [DataRow("}{")]
        [DataRow("][")]
        [DataRow(")")]
        [DataRow("(]")]
        [DataRow("(()}{}")]
        [DataRow("(a(a)}aaaa{}...")]
        public void NegativeTests(string input)
        {
            var rules = new SymmetricCharacterRules();
            rules.AddRule(SymmetricCharacterRule.Braces)
                .AddRule(SymmetricCharacterRule.Brackets)
                .AddRule(SymmetricCharacterRule.Parenthesis);

            var validator = new SymmetricCharacterValidator(rules);
            Assert.IsFalse(validator.Validate(input));
        }

        [TestMethod("Positive Tests")]
        [DataRow("()[]{}")]
        [DataRow("([{}])")]
        [DataRow("([{}])")]
        [DataRow("([{}])(){}[()]")]
        [DataRow("(a[b{c}d]e)f(g){h}[i()]")]
        public void PositiveTests(string input)
        {
            var rules = new SymmetricCharacterRules();
            rules.AddRule(SymmetricCharacterRule.Braces)
                .AddRule(SymmetricCharacterRule.Brackets)
                .AddRule(SymmetricCharacterRule.Parenthesis);

            var validator = new SymmetricCharacterValidator(rules);
            Assert.IsTrue(validator.Validate(input));
        }
    }
}