public class Solution {
    public string LongestPalindrome(string s) {
        int largestStart = 0, largestLength = 0;
        for(var i = s.Length; i > 0; i--){
            for(var j = 0; j <= s.Length - i; j++){
                if(IsPallindrom(s, j, i + j - 1)){
                    return s.Substring(j, i);
                }
            }
        }
        return "";
    }

    private bool IsPallindrom(string s, int start, int end){
        if(end - start < 2) return s[start] == s[end];
        return s[start] == s[end] && IsPallindrom(s, start + 1, end - 1);
    }
}