public class Solution {
    public bool IsPalindrome(string s) {
        return PalindromeRec(s.ToLower(), 0, s.Length-1);
    }

    public bool PalindromeRec(string s, int left, int right){
        if(left < s.Length && !char.IsLetterOrDigit(s[left])) return PalindromeRec(s, left+1, right);
        if(right >= 0 && !char.IsLetterOrDigit(s[right])) return PalindromeRec(s, left, right-1);
        if(left >= right) return true;

        if(s[left] != s[right]) return false;

        return PalindromeRec(s, left + 1, right -1);
    }
}