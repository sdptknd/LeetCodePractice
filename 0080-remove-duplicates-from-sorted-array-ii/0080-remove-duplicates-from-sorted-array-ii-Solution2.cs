public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if(nums.Length <= 2) return nums.Length;

        var shiftedIndx = 2;
        var lastNum1 = nums[0];
        var lastNum2 = nums[1];

        for(int i = 2; i < nums.Length; i++){
            var currNum = nums[i];
            if(currNum == lastNum1 && currNum == lastNum2) continue;
            nums[shiftedIndx++] = currNum;
            lastNum1 = lastNum2;
            lastNum2 = currNum;
        }

        return shiftedIndx;
    }
}