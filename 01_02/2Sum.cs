using System;
using System.Collections.Generic;

class TwoSum
{
    public static int[] FindTwoSum(int[] nums, int target)
    {
        var map = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (map.ContainsKey(complement))
            {
                return new int[] { map[complement], i };
            }
            map[nums[i]] = i;
        }
        throw new ArgumentException("No two sum solution");
    }

    public static void Main(string[] args)
    {
        int[] nums = new int[] { 2, 7, 11, 15 };
        int target = 9;
        int[] result = FindTwoSum(nums, target);
        Console.WriteLine($"{result[0]}, {result[1]}");
    }
}

