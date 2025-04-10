public class Solution {
    public int MaxProfit(int[] prices) {
        var maxProfit = 0;
        var buy = prices[0];

        for(var i = 1; i < prices.Length; i++){
            if(prices[i] > buy) maxProfit = Math.Max(maxProfit, prices[i] - buy);
            else buy = prices[i];
        }

        return maxProfit;
    }
}