public class Solution {
    public int MaxProfit(int[] prices) {
        var profit = 0;
        var buy = prices[0];

        for(var i = 1; i < prices.Length; i++){
            if(prices[i] > buy) profit += (prices[i] - buy);
            buy = prices[i];
        }

        return profit;
    }
}