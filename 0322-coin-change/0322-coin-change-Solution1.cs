public class Solution {
    public int CoinChange(int[] coins, int amount) {
        var countCache = new Dictionary<(int, int), int>();
        var minCoinCount = FindMinCoinCount(coins, amount, coins.Length - 1, countCache);

        return minCoinCount == int.MaxValue ? -1 : minCoinCount;
    }

    private int FindMinCoinCount(int[] coins, int amount, int index, Dictionary<(int, int), int> countCache){
        if(amount == 0) return 0;
        if(index == 0) {
            if(amount % coins[0] == 0) return amount / coins[0];
            else return int.MaxValue;
        }

        if(countCache.TryGetValue((amount, index), out var count)) return count;

        var withoutCurrCoin = FindMinCoinCount(coins, amount, index - 1, countCache);
        var withCurrCoin = int.MaxValue;
        if(coins[index] <= amount){
            var nextDepth = FindMinCoinCount(coins, amount - coins[index], index, countCache);
            withCurrCoin = nextDepth == int.MaxValue ? int.MaxValue : nextDepth + 1;
        }
        count = Math.Min(withoutCurrCoin, withCurrCoin);
        countCache.Add((amount, index), count);
        return count;
    }
}