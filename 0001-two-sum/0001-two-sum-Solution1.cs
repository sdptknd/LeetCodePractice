public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var visited = new Dictionary<int, int> {{nums[0], 0}};

        for(var i = 1; i < nums.Length; i++){
            if(visited.TryGetValue(target-nums[i], out var otherIndex)) return new int[] {otherIndex, i};

            visited[nums[i]] = i;
        }

        return new int[2];
    }
}