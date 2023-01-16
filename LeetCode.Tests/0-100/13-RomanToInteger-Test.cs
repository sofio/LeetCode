using NUnit.Framework;
using Solutions._0_100;

namespace LeetCode.Tests._0_100
{
    public class _13_RomanToInteger_Test
    {
        [Test]
        [TestCase("MCMXCIV", 1994)]
        [TestCase("MMXLVIII", 2048)]
        [TestCase("IV", 4)]
        [TestCase("V", 5)]
        [TestCase("LXXIV", 74)]
        [TestCase("DCCXLIV", 744)]
        [TestCase("MMCDXCV", 2495)]
        public void RomanToInteger_Test(string s, int expectedInteger)
        {
            var solution = new _13_RomanToInteger();
            var result = solution.RomanToInt(s);
            Assert.That(result, Is.EqualTo(expectedInteger));
        }
    }
}
