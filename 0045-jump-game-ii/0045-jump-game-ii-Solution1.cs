public class Solution {
    public int Jump(int[] nums) {
        var memo = new Dictionary<int, int>{{nums.Length - 1, 0}};

        for(var i = nums.Length - 2; i >= 0; i--){
            int minJumpCount = int.MaxValue;
            for(int step = 1; step <= nums[i]; step++){
                if(i + step < nums.Length){
                    var nextMinJumpCount = memo[i + step];
                    if(nextMinJumpCount < minJumpCount) minJumpCount = nextMinJumpCount;
                }
            }
            memo[i] = minJumpCount == int.MaxValue ? int.MaxValue : minJumpCount + 1;
        }

        return memo[0];
    }

    private int MinJump(int[] nums, int leftIndex, Dictionary<int, int> memo){
        if(leftIndex == nums.Length - 1) return 0;

        if(memo.TryGetValue(leftIndex, out var ans)) return ans;

        int minJumpCount = int.MaxValue;

        for(int step = 1; step <= nums[leftIndex]; step++){
            if(leftIndex + step < nums.Length){
                var nextMinJumpCount = MinJump(nums, leftIndex + step, memo);
                if(nextMinJumpCount < minJumpCount) minJumpCount = nextMinJumpCount;
            }
        }

        ans = minJumpCount == int.MaxValue ? int.MaxValue : minJumpCount + 1;
        memo[leftIndex] = ans;
        return ans;
    }
}