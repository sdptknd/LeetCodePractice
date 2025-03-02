public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if(nums.Length <= 2) return nums.Length;

        var shiftedIndx = 2;


        for(int i = 2; i < nums.Length; i++){
            var currNum = nums[i];
            if(currNum == nums[shiftedIndx - 2] && currNum == nums[shiftedIndx - 1]) continue;
            nums[shiftedIndx++] = currNum;
        }

        return shiftedIndx;
    }
}