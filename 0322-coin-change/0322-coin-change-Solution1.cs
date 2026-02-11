public class Solution {
    public int CoinChange(int[] coins, int amount) {
        // var countCache = new Dictionary<(int, int), int>();
        var prev = new int[amount+1];
        int[] prev2 = null;
        // var minCoinCount = FindMinCoinCount(coins, amount, coins.Length - 1, countCache);

        // return minCoinCount == int.MaxValue ? -1 : minCoinCount;

        for(var remaining = 0; remaining <= amount; remaining++){
            Console.WriteLine($"remaining: {remaining}");
            if(remaining % coins[0] == 0) prev[remaining] = remaining / coins[0];
            else prev[remaining] = int.MaxValue;
        }

        
        for(var coinIndx = 1; coinIndx < coins.Length; coinIndx++){
            var curr = new int[amount + 1];
            for(var remaining = 0; remaining <= amount; remaining++){
                Console.WriteLine($"coinIndx: {coinIndx}, remaining: {remaining}");
                var withoutCurrCoin = prev[remaining];
                var withCurrCoin = int.MaxValue;
                if(coins[coinIndx] <= remaining){
                    var prevMinCount = curr[remaining - coins[coinIndx]];
                    withCurrCoin = prevMinCount == int.MaxValue ? int.MaxValue : prevMinCount + 1;
                }
                curr[remaining] = Math.Min(withoutCurrCoin, withCurrCoin);
            }
            prev2 = prev;
            prev = curr;
        }

        var minCount = prev[amount];
        return minCount == int.MaxValue ? -1 : minCount;
    }

    // private int FindMinCoinCount(int[] coins, int amount, int index, Dictionary<(int, int), int> countCache){
    //     if(index == 0) {
    //         if(amount % coins[0] == 0) return amount / coins[0];
    //         else return int.MaxValue;
    //     }

    //     if(countCache.TryGetValue((amount, index), out var count)) return count;

    //     var withoutCurrCoin = FindMinCoinCount(coins, amount, index - 1, countCache);
    //     var withCurrCoin = int.MaxValue;
    //     if(coins[index] <= amount){
    //         var nextDepth = FindMinCoinCount(coins, amount - coins[index], index, countCache);
    //         withCurrCoin = nextDepth == int.MaxValue ? int.MaxValue : nextDepth + 1;
    //     }
    //     count = Math.Min(withoutCurrCoin, withCurrCoin);
    //     countCache.Add((amount, index), count);
    //     return count;
    // }
}