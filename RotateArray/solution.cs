using System;

public class Solution {

    public void Rotate(int[] nums, int k) {
        Rotate1(nums, k);
    }

    void Rotate1(int[] nums, int k) {
        if (nums==null || nums.Length==0 || k<=0) return;
        if (k > nums.Length) Math.DivRem(k, nums.Length, out k);

        var rotated = nums[^k..];
        var offset = nums.Length - k - 1;

        for (var i=offset;i>=0;i--)
        {
            nums[i+k] = nums[i];
        }
        
        for (var i=0;i<k;i++)
        {
            nums[i] = rotated[i];
        }

    }

    void SlowLoopyShuffleLeft(int[] nums, int k) {
        if (nums==null || nums.Length==0 || k<=0) return;
        if (k > nums.Length) Math.DivRem(k, nums.Length, out k);

        for (var i=nums.Length-k-1;i>=0;i--)
        {
            ShuffleLeft(nums, i, k);
        }
    }

    void ShuffleLeft(int[] nums, int index, int k)
    {
        var shufflee = nums[index];
        for (var i=index+1;i<=index+k;i++)
        {
            nums[i-1]=nums[i];
        }
        nums[index+k] = shufflee;
    }

}