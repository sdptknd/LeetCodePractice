public class Solution {
    public int Reverse(int x) {
        if(x == -2147483648) return 0;
        var quotient = Math.Abs(x);
        int multiplicationLimit = 214748364;
        int additionLimit = x < 0 ? 8 : 7;
        var result = 0;
        do {
            var remainder = quotient % 10;
            quotient = quotient / 10;
            if(result > multiplicationLimit || (result == multiplicationLimit && remainder > additionLimit)){
                return 0;
            }
            result = (result * 10) + remainder;
        } while(quotient > 0);
        return result * Math.Sign(x);
    }
}