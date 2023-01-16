using NUnit.Framework;
using Solutions._900_1000;

namespace LeetCode.Tests._900_1000
{
    public class _997_FindTheTownJudge_Test
    {
        [Test]
        public void FindTheTownJudge()
        {
            var trust = new int[][] { new int[] { 1, 2 }, new int[] { 2, 1 } };

            var solution = new _997_FindTheTownJudge();
            var result = solution.FindJudge(2,trust);
            Assert.That(result, Is.EqualTo(-1));
        }
    }
}

//[[1,3],[1,4],[2,3],[2,4],[4,3]]
