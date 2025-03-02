public class Solution {
    public bool Search(int[] nums, int target) {
        return CustomBinary(nums, 0, nums.Length - 1, target);
    }

    public bool CustomBinary(int[] nums, int left, int right, int target) {
        Console.WriteLine($"left: {left}, riht: {right}");
        if(right < left) return false;
        var middle = left + (right - left) / 2;
        if(nums[middle] == target) return true;
        if(nums[left] == nums[middle]){
            return CustomBinary(nums, left+1, right, target);
        }
        if(nums[left] < nums[middle]){
            if(nums[left] <= target && target < nums[middle]) return CustomBinary(nums, left, middle - 1, target);
            else return CustomBinary(nums, middle + 1, right, target);
        }else{
            if(nums[middle] < target && target <= nums[right]) return CustomBinary(nums, middle+1, right, target);
            else return CustomBinary(nums, left, middle - 1, target);
        }
    }
}