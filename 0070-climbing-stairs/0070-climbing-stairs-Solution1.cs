public class Solution {
    public int ClimbStairs(int n) {
        return ClimbStairs2(n, new int[n + 1]);
    }

    public int ClimbStairs2(int n, int[] memo) {
        if(memo[n] > 0) return memo[n];
        var steps = n <= 1 ? 1 : ClimbStairs2(n-1, memo) + ClimbStairs2(n-2, memo);
        memo[n] = steps;
        return steps;
    }
}