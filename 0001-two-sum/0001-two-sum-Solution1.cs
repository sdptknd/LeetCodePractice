public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var numberMap = new Dictionary<int, int>();
        numberMap.Add(nums[0], 0);

        for(var i = 1; i < nums.Length; i++){
            if(numberMap.TryGetValue(target - nums[i], out var j)){
                return new int[] {i, j};
            }
            numberMap[nums[i]] = i;
        }

        return new int[2];
    }
}