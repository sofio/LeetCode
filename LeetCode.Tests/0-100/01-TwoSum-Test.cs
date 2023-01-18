using NUnit.Framework;
using Solutions._0_100;

namespace LeetCode.Tests._0_100
{
    public class _01_TwoSum_Test
    {
        [Test]
        [TestCase(new int[4] { 2, 7, 11, 15 }, 9, new int[2] { 0, 1 })]
        [TestCase(new int[3] { 3, 2, 4 }, 6, new int[2] { 1, 2 })]
        [TestCase(new int[2] { 4, 4 }, 8, new int[2] { 0, 1 })]

        public void TwoSumTest(int[] nums, int targets, int[] expectedResult)
        {
            var solution = new _01_TwoSum();
            var result = solution.TwoSum(nums, targets);
            CollectionAssert.AreEqual(result, expectedResult);
        }
    }
}
