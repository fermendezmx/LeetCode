using System;
using LeetCode.Training.Practice;

namespace LeetCode.Play
{
    class Program
    {
        static void Main(string[] args)
        {
            int target = 9;
            int[] input = { 2, 7, 11, 15 };
            int[] result = TwoSum.Solution(input, target);
            Console.WriteLine(result);
        }
    }
}
