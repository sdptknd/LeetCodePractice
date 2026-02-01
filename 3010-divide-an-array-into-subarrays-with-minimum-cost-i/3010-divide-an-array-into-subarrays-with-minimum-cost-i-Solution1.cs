public class Solution {
    public int MinimumCost(int[] nums) {
        int minIndex = 1, sum = nums[0];

        for(var i = 2; i < nums.Length; i++)
            if(nums[i] < nums[minIndex]) minIndex = i;
        
        sum += nums[minIndex];
        int secondIndex = minIndex;
        minIndex = secondIndex == 1 ? 2 : 1;

        for(var i = 2; i < nums.Length; i++){
            if(i == secondIndex) continue;
            if(nums[i] < nums[minIndex]) minIndex = i;
        }

        return sum + nums[minIndex];
    }
}