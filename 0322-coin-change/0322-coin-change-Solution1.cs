public class Solution {
    public int CoinChange(int[] coins, int amount) {
        var countCache = new Dictionary<(int, int), int>();
        // var prev = new List<int>(coins.Length);
        // var prev2
        // var minCoinCount = FindMinCoinCount(coins, amount, coins.Length - 1, countCache);

        // return minCoinCount == int.MaxValue ? -1 : minCoinCount;

        for(var remaining = 0; remaining <= amount; remaining++){
            if(remaining % coins[0] == 0) countCache[(remaining, 0)] = remaining / coins[0];
            else countCache[(remaining, 0)] = int.MaxValue;
        }

        
            for(var coinIndx = 1; coinIndx < coins.Length; coinIndx++){
                for(var remaining = 0; remaining <= amount; remaining++){
                var withoutCurrCoin = countCache[(remaining, coinIndx-1)];
                var withCurrCoin = int.MaxValue;
                if(coins[coinIndx] <= remaining){
                    var prevMinCount = countCache[(remaining - coins[coinIndx], coinIndx)];
                    withCurrCoin = prevMinCount == int.MaxValue ? int.MaxValue : prevMinCount + 1;
                }
                countCache[(remaining, coinIndx)] = Math.Min(withoutCurrCoin, withCurrCoin);
            }
        }

        var minCount = countCache[(amount, coins.Length - 1)];
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