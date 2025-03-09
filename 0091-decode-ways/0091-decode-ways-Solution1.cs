public class Solution {
    public int NumDecodings(string s) {
        return NumDecodings2(s, 0, new Dictionary<int,int>());
    }

    public int NumDecodings2(string s, int indx, Dictionary<int,int> memo){
        if(indx >= s.Length) return 1;
        if(memo.TryGetValue(indx, out var numDecodings)) return numDecodings;

        var currPosNumDecodings = 0;
        var currDigit = int.Parse(s[indx].ToString());

        if(currDigit > 0 && currDigit <= 26)
            currPosNumDecodings += NumDecodings2(s, indx+1, memo);
        
        if(indx == s.Length - 1) {
            memo[indx] = currPosNumDecodings;
            return currPosNumDecodings;
        }

        var nextDigit = int.Parse(s[indx+1].ToString());
        var num = currDigit * 10 + nextDigit;

        if(num > 9 && num <= 26)
            currPosNumDecodings += NumDecodings2(s, indx+2, memo);

        memo[indx] = currPosNumDecodings;
        return currPosNumDecodings;
    }
}