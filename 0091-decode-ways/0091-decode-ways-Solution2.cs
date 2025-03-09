public class Solution {
    public int NumDecodings(string s) {
        var digits = s.ToArray().Select(c => int.Parse(c.ToString())).ToList();
        return NumDecodings2(digits, 0, new Dictionary<int,int>());
    }

    public int NumDecodings2(List<int> d, int indx, Dictionary<int,int> memo){
        if(indx >= d.Count) return 1;
        if(memo.TryGetValue(indx, out var numDecodings)) return numDecodings;

        var currPosNumDecodings = 0;
        var currDigit = d[indx];

        if(currDigit > 0 && currDigit <= 26)
            currPosNumDecodings += NumDecodings2(d, indx+1, memo);
        
        if(indx == d.Count - 1) {
            memo[indx] = currPosNumDecodings;
            return currPosNumDecodings;
        }

        var nextDigit = d[indx+1];
        var num = currDigit * 10 + nextDigit;

        if(num > 9 && num <= 26)
            currPosNumDecodings += NumDecodings2(d, indx+2, memo);

        memo[indx] = currPosNumDecodings;
        return currPosNumDecodings;
    }
}