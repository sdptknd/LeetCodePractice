public class Solution {
    public bool IsTrionic(int[] nums) {
        if(nums.Length < 4) return false;

        var p = 0;
        var q = nums.Length - 1;

        while(p < nums.Length - 3 && nums[p+1] > nums[p]) p++;

        if(p == 0) return false;

        while(q > 2 && nums[q-1] < nums[q]) q--;

        if(q == nums.Length -1) return false;

        if(p >= q) return false;

        for(var i = p; i < q; i++ )
            if(nums[i+1] >= nums[i]) return false;

        return true;
    }
}


// [1, 3, 2, 3]
//. 0. 1. 2. 3