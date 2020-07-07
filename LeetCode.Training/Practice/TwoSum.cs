using System.Collections;

namespace LeetCode.Training.Practice
{
    #region Problem

    // Given an array of integers, return indices of the two numbers such that
    // they add up to a specific target.
    //
    // You may assume that each input would have exactly one solution, and you
    // may not use the same element twice.
    //
    // Example:
    //
    // Given nums = [2, 7, 11, 15], target = 9,
    //
    // Because nums[0] + nums[1] = 2 + 7 = 9,
    // return [0, 1].

    #endregion

    public static class TwoSum
    {
        public static int[] Solution(int[] nums, int target)
        {
            int[] result = { };
            Hashtable table = new Hashtable();

            for (int i = 0; i < nums.Length; i++)
            {
                // We add each element's value and its index to the table
                table.Add(nums[i], i);
            }

            for (int i = 0; i < nums.Length; i++)
            {
                // Get the complement (target - nums[i])
                int complement = target - nums[i];

                // Then, we check if each element's complement exists in the table
                // And beware that the complement must not be nums[i] itself
                if (table.ContainsKey(complement) && (int)table[complement] != i)
                {
                    // Set the indexes in 'result' to provide the solution
                    result = new int[] { i, (int)table[complement] };
                    break;
                }
            }

            return result;
        }
    }
}
