public class Solution {
    public int Rob(int[] nums) {
        // var memo = new Dictionary<int, int> {{0, nums[0]}};
        int prev = nums[0], prev2 = 0;

        for(var i = 1; i < nums.Length; i++){
            var withCurrent = nums[i];
            if(i >= 2) withCurrent += prev2;
            var withoutCurrent = prev;
            var max = Math.Max(withCurrent, withoutCurrent);
            prev2 = prev;
            prev = max;
        }

        return prev;
    }

    private int MaxRob(int[] nums, int rightIndex, Dictionary<int, int> memo){
        if(rightIndex == 0) return nums[0];

        if(memo.TryGetValue(rightIndex, out var maxValue)) return maxValue;

        var withCurrent = nums[rightIndex];
        if(rightIndex >= 2) withCurrent += MaxRob(nums, rightIndex - 2, memo);

        var withoutCurrent = MaxRob(nums, rightIndex - 1, memo);
        var max = Math.Max(withCurrent, withoutCurrent);
        memo.Add(rightIndex, max);
        return max;
    }
}


//[2, 3, 2]