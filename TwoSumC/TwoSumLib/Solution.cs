using System;
using System.Collections.Generic;

namespace TwoSumLib
{
    public class Solution {


        public int[] TwoSum(int[] nums, int target) {
            return TwoSum_Hashing(nums, target);
        }


        public int[] TwoSum_Hashing(int[] nums, int target) {

            // key is interger, value is index
            // note that we can never have the same integer twice
            // in the input array unless the output is the sum
            // of them (as only one valid solution exists)
            // - hence we are safe to key on the int
            var ints = new Dictionary<int, int>();                                          // s: O(n)

            // loop through num array checking for existance
            // - if the num already exists, then we're done (that MUST be the answer)

            // n x O(1) + O(log n) + O(1) + O(1) -> this loop
            // n x C1 + O(log n) + C2 -> equivalent
            // n x O(log n) -> drop constants
            // O(log n) -> drop co-efficient?
            // same repeated below so: O(2 log n) = O(log n)?!
            for (var index = 0; index < nums.Length; index++) {                             // t: n
                var num = nums[index];                                                      // t: O(1) / s: O(1)
                if (ints.ContainsKey(num)) {                                                // t: O(log n)
                    return new int[] { ints[num], index };                                  // t: O(1)
                }
                else
                {
                    ints.Add(num, index);                                                   // t: O(1)
                }
            }

            // if we're here then we need to work back through the numbers
            // to find a matching pair
            for (var index = 0; index < nums.Length; index++) {                             // t: n
                var num = nums[index];                                                      // t: O(1) / s: O(1)
                var pair = target - num;                                                    // O(1)
                if (pair != num && ints.ContainsKey(pair)) {                                // O(log n)
                    return new int[] { index, ints[pair] };                                 // O(1)
                }
            }

            throw new InvalidOperationException("No solution found");

        }

    
        // O(n2) solution
        public int[] TwoSum_Slow(int[] nums, int target) {

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
