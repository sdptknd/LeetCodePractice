public class Solution {
    public int Jump(int[] nums) {
        return JumpCount(nums, 0);
    }

    public int JumpCount(int[] nums, int index){
        if(index == nums.Length - 1) return 0;

        if(nums[index] >= nums.Length - 1 - index) return 1;

        var max = index + 1;
        for(int i = index + 1; i <= index + nums[index]; i++){
            if(nums[i] == 0) continue;
            if(nums[i] + i >= nums[max] + max) max = i;
        }
        return 1 + JumpCount(nums, max);
    }
}