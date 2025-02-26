public class Solution {
    public void SortColors(int[] nums) {
        int i = 0, j = nums.Length - 1;

        while(i < j){
            Console.WriteLine($"i: {i}, j: {j}, nums: {string.Join(',', nums)}");
            if(nums[i] == 0){
                i++;
                continue;
            }
            Console.WriteLine($"i: {i}");
            if(i < j && nums[j] == 0) {
                var temp = nums[i];
                nums[i] = nums[j];
                nums[j] = temp;
            }
            j--;
        }

        j = nums.Length - 1;
        while(i < nums.Length && nums[i] == 0) i++;

        while(i < j){
            Console.WriteLine($"i: {i}, j: {j}, nums: {string.Join(',', nums)}");
            if(nums[i] == 1){
                i++;
                continue;
            }
            if(i < j && nums[j] == 1) {
                var temp = nums[i];
                nums[i] = nums[j];
                nums[j] = temp;
            }
            j--;
        }
    }
}