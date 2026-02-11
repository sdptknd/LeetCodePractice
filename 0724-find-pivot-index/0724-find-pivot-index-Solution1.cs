public class Solution {
    public int PivotIndex(int[] nums) {
        var leftSum = new int[nums.Length];
        var rightSum = new int[nums.Length];
        leftSum[0] = nums[0];
        rightSum[nums.Length - 1] = nums[nums.Length - 1];

        for(var i = 1; i < nums.Length; i++) leftSum[i] = leftSum[i-1] + nums[i];
        for(var i = nums.Length - 2; i >= 0; i--) rightSum[i] = rightSum[i+1] + nums[i];

        for(var i = 0; i < nums.Length; i++){
            var left = i == 0 ? 0 : leftSum[i - 1];
            var right = i == nums.Length - 1 ? 0 : rightSum[i + 1];
            if(left == right) return i;
        }

        return -1;
    }
}