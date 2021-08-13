
/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number[]}
 */
 var twoSum = function(nums, target) {
    
    let vals = new Map();
    
    for(let i=0; i < nums.length; i++) {
        let num = nums[i];
        if (!vals.has(num)) {
             vals.set(num, i);
        } else {
            return [vals.get(num),i];
        }
    }
    
    for(let i=0; i < nums.length; i++) {
        let num = nums[i];
        let diff = target-num;
        if (vals.has(diff) && vals.get(diff)!=i) {
            return [i,vals.get(diff)];
        }
    }
    
    return [0,0];
    
};
