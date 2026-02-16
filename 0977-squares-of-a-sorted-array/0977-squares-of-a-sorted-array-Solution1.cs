public class Solution {
    public int[] SortedSquares(int[] nums) {
        var ans = new int[nums.Length];
        int left = 0, right = nums.Length - 1, i = right;

        while(i >= 0){
            if(Math.Abs(nums[left]) > nums[right]){
                ans[i--] = (int)Math.Pow(nums[left], 2);
                left++;
            } else {
                ans[i--] = (int)Math.Pow(nums[right], 2);
                right--;
            }
        }

        return ans;
    }
}