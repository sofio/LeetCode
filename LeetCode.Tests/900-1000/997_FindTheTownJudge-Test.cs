using NUnit.Framework;
using Solutions._900_1000;
namespace LeetCode.Tests._900_1000
{
    public class _997_FindTheTownJudge_Test
    {
        static readonly object[] FindTheTownJudgeTestCaseData =
            {
                new object[] { new int[][] { new int[] { 1, 3 }, new int[] { 1, 4 }, new int[] { 2, 3 }, new int[] { 4, 3 } }, 4, 3 },
                new object[] { new int[][] { new int[] { 1 } }, 1, 1 },
                new object[] { new int[][] { new int[] { 1, 2 }, new int[] { 2, 1 } }, 2, -1 },
                new object[] { new int[][] { new int[] { 1, 3 }, new int[] { 2, 3 }, new int[] { 3, 1 } }, 3, -1 }
            };

        [Test]
        [TestCaseSource(nameof(FindTheTownJudgeTestCaseData))]
        public void FindTheTownJudge(int[][] trust, int n, int expectedResult)
        {
            var solution = new _997_FindTheTownJudge();
            var result = solution.FindJudge(n, trust);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}