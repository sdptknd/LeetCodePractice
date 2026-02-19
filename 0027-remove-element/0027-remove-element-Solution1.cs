public class Solution {
    public int RemoveElement(int[] nums, int val) {
        if(nums.Length == 0) return 0;
        int l = 0, r = nums.Length - 1;
        while(r >= 0 && nums[r] == val) r--;
        if(r < 0) return 0;
        while(l <= r){
            if(nums[l] != val) {
                l++;
                continue;
            }
            nums[l] = nums[r];
            r--;
            while(r >= 0 && nums[r] == val) r--;
            l++;
        }

        return l;
    }
}