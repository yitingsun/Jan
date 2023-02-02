﻿class ThreeSum
{
    public static IList<IList<int>> ThreeSumSolutions(int[] nums)
    {
        Array.Sort(nums);
        IList<IList<int>> res = new List<IList<int>>();
        for (int i = 0; i < nums.Length - 2; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1]) continue;
            int l = i + 1, r = nums.Length - 1;
            while (l < r)
            {
                int sum = nums[i] + nums[l] + nums[r];
                if (sum == 0)
                {
                    res.Add(new List<int> { nums[i], nums[l], nums[r] });
                    while (l < r && nums[l] == nums[l + 1]) l++;
                    while (l < r && nums[r] == nums[r - 1]) r--;
                    l++;
                    r--;
                }
                else if (sum < 0)
                {
                    l++;
                }
                else
                {
                    r--;
                }
            }
        }
        return res;
    }

    public static void Main(string[] args)
    {
        int[] nums = new int[] { -1, 0, 1, 2, -1, -4 };
        IList<IList<int>> res = ThreeSumSolutions(nums);
        foreach (var solution in res)
        {
            Console.WriteLine(string.Join(", ", solution));
        }
    }
}