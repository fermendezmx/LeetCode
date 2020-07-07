using LeetCode.Training.Practice;
using Xunit;

namespace LeetCode.UnitTest.Practice
{
    public class TTwoSum
    {
        [Fact]
        public void Test1()
        {
            int target = 9;
            int[] input = { 2, 7, 11, 15 };
            int[] expected = { 0, 1 };
            int[] result = TwoSum.Solution(input, target);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test2()
        {
            int target = 7;
            int[] input = { 1, 4, 2, 8, 6, 9 };
            int[] expected = { 0, 4 };
            int[] result = TwoSum.Solution(input, target);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test3()
        {
            int target = 10;
            int[] input = { 5, 7, 1, 12, 6, 2, 3 };
            int[] expected = { 1, 6 };
            int[] result = TwoSum.Solution(input, target);

            Assert.Equal(expected, result);
        }
    }
}
