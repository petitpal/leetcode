using System.Collections.Generic;

public class Solution {

    public int SingleNumber(int[] nums) => SingleNumber_LinearTime_ConstantSpace(nums);

    int SingleNumber_LinearTime_ConstantSpace(int[] nums)
    {
        var r = 0;
        foreach (int num in nums)
            r ^= num;
        return r;
    }

    int SingleNumber_LinearTime_LinearSpace(int[] nums) {
        if (nums.Length==0) return 0;
        if (nums.Length==1) return nums[0];

        var d = new Dictionary<int, int>();

        foreach (var num in nums)
        {
            if (!d.ContainsKey(num))
                d.Add(num, 1);
            else
                d[num]=2;
        } 

        foreach (var num in d)
        {
            if (num.Value==1) {
                return num.Key;
            }
        }

        return 0;
    }
}