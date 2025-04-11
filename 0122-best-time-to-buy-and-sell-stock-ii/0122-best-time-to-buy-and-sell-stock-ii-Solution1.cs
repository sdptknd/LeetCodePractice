public class Solution {
    public int MaxProfit(int[] prices) {
        var profit = 0;

        for(var i = 1; i < prices.Length; i++){
            if(prices[i] > prices[i-1]) profit += (prices[i] - prices[i-1]);
        }

        return profit;
    }
}