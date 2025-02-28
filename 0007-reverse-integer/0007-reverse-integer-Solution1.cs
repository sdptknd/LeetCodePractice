public class Solution {
    public int Reverse(int x) {
            var rest = x < 0 ? x : -x;
    var reverse = 0;
    var multiplierLimit = -214748364;
    var additiveLimit = x < 0 ? -8 : -7;

    while(rest != 0){
        var digit = rest % 10;
        rest = rest / 10;

        if(reverse < multiplierLimit || (reverse == multiplierLimit && digit < additiveLimit))
            return 0;

        reverse = reverse * 10 + digit;
    }

    return x < 0 ? reverse : -reverse;
    }
}