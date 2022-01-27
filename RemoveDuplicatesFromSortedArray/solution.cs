public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if (nums==null || nums.Length==0) return 0;
        if (nums.Length==1) return 1;

        var insertionPoint = 0;

        for (var cp=1; cp<nums.Length; cp++)
        {
            if (nums[cp]>nums[insertionPoint])
            {
                insertionPoint++;
                if (insertionPoint!=cp) Move(nums, cp, insertionPoint);
            }
        }

        return insertionPoint+1;
    }

    public void Move(int[] arr, int sourceIndex, int targetIndex) {

        var val = arr[sourceIndex];
        for (var i=sourceIndex;i>=targetIndex;i--)
        {
            arr[i]=arr[i-1];
            if(i==targetIndex)
            {
                arr[i]=val;
            }
        }
    }
}