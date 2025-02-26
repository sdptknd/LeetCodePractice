public class Solution {
    public void SortColors(int[] nums) {
        var sortedNextIndx = ProcessColour(nums, 0, 0);
        ProcessColour(nums, 1, sortedNextIndx);
    }

    private int ProcessColour(int[] nums, int colour, int start){
        int i = start, j = nums.Length - 1;
        while(i < j){
            if(nums[i] == colour){
                i++;
                continue;
            }
            if(i < j && nums[j] == colour) {
                var temp = nums[i];
                nums[i] = nums[j];
                nums[j] = temp;
            }
            j--;
        }

        while(i < nums.Length && nums[i] == colour) i++;

        return i;
    }
}