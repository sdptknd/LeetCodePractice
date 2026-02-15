public class Solution {
    public void MoveZeroes(int[] nums) {
        for(int i = 0; i < nums.Length; i++){
            if(nums[i] != 0) continue;

            int j = i + 1;
            while(j < nums.Length && nums[j] == 0) j++;
            if(j == nums.Length) break;
            var tmp = nums[i];
            nums[i] = nums[j];
            nums[j] = tmp;
        }
    }
}