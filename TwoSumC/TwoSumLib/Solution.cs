using System;

namespace TwoSumLib
{
    public class Solution {


        // O(n2) solution
        public int[] TwoSum(int[] nums, int target) {

            // O(n^2)
            for (var i = 0; i < nums.Length; i++) {             // n x (n x O(1))
                for (var j = 0; j < nums.Length; j++) {         // n x O(1)
                    if (i != j) {
                        if (nums[i] + nums[j] == target) {      // O(1)
                            return new int[] { i, j };
                        }
                    }
                }
            }

            throw new InvalidOperationException("No solution found");
        }

    }
}
