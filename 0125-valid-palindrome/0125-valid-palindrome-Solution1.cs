public class Solution {
    public bool IsPalindrome(string s) {
        return isPalindromeRec(s, 0, s.Length - 1);
    }

    public bool isPalindromeRec(string s, int left, int right){
        if(left >= right) return true;

        char leftChar = s[left], rightChar = s[right];

        if(!Char.IsLetterOrDigit(leftChar)) return isPalindromeRec(s, left + 1, right);
        else if(!Char.IsLetterOrDigit(rightChar)) return isPalindromeRec(s, left, right - 1);
        else return Char.ToLower(leftChar) == Char.ToLower(rightChar) && isPalindromeRec(s, left + 1, right - 1);
    }
}