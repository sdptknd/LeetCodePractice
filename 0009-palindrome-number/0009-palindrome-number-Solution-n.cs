public class Solution {
    public bool IsPalindrome(int x) {
        if(x < 0) return false;

        var remaining = x;
        var reverse = 0;

        while(remaining > 0){
            var remainder = remaining % 10;
            remaining = remaining / 10;
            reverse = (reverse * 10) + remainder;
        }

        Console.WriteLine(reverse);

        return x == reverse;
    }
}