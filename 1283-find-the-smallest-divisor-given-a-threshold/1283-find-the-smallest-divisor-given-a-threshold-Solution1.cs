public class Solution {
    public int SmallestDivisor(int[] nums, int threshold) {
        int left = 1, right = nums.Max();

        while(left <= right){
            int mid = left + ((right - left) / 2);
            if(DivisionSumLessOrEqual(nums, mid, threshold)){
                right = mid - 1;
            } else {
                left = mid + 1;
            }
        }

        return left;
    }

    private bool DivisionSumLessOrEqual(int[] nums, int divisor, int threshold){
        var sum = 0;
        foreach(var num in nums) sum += (int)Math.Ceiling((double)num / divisor);
        return sum <= threshold;
    }
}

// [1 2 5 9]

// 1 2 3 4 5 6 7 8 9