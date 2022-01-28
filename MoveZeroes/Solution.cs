public class Solution {
    public void MoveZeroes(int[] nums) {
        if (nums==null || nums.Length<=1) return;
    
        var zeroPointer = -1;

        for (var i=0;i<nums.Length;i++)
        {
            if (zeroPointer==-1 && nums[i]==0) zeroPointer=i;

            if (zeroPointer!=-1 && nums[i]!=0 && i > zeroPointer)
            {
                nums[zeroPointer]=nums[i];
                nums[i]=0;
                zeroPointer++;
            }
            
        }
    }
}