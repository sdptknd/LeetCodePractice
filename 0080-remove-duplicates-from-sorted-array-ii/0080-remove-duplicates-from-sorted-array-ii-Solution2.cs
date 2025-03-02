public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if(nums.Length <= 2) return nums.Length;

        var shiftedIndx = 2;

        for(int i = 2; i < nums.Length; i++){
            if(nums[i] == nums[shiftedIndx-1] && nums[i] == nums[shiftedIndx-2]) continue;
            nums[shiftedIndx++] = nums[i];
        }

        return shiftedIndx;
    }
}