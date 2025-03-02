public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if(nums.Length <= 2) return nums.Length;

        var shiftedIndx = 2;
        var lastNum1 = nums[0];
        var lastNum2 = nums[1];

        for(int i = 2; i < nums.Length; i++){
            if(nums[i] == lastNum1 && nums[i] == lastNum2) continue;
            nums[shiftedIndx++] = nums[i];
            lastNum1 = lastNum2;
            lastNum2 = nums[i];
        }

        return shiftedIndx;
    }
}