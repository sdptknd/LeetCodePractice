public class Solution {
    public int SmallestNumber(int n) {
        var exactPower = Math.Log2(n + 1);
        return (int)(Math.Pow(2, Math.Ceiling(exactPower)) - 1);
    }
}