public class Solution {
    public int MaxProfit(int[] prices) {
        var buyPrice = prices[0];
        var maxProfit = 0;

        for(int i = 1; i < prices.Length; i++){
            if(prices[i] > buyPrice) maxProfit = Math.Max(maxProfit, prices[i] - buyPrice);
            else buyPrice = prices[i];
        }

        return maxProfit;
    }
}