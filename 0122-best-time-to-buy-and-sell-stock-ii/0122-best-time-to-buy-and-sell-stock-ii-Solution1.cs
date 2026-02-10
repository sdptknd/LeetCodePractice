public class Solution {
    public int MaxProfit(int[] prices) {
        var buyPrice = prices[0];
        var profit = 0;

        for(int i = 1; i < prices.Length; i++){
            if(prices[i] > buyPrice) profit += (prices[i] - buyPrice);
            buyPrice = prices[i];
        }

        return profit;
    }
}