public class Solution {
    public string LongestPalindrome(string s) {
        int maxPalStart = 0, maxPalLength = 0;

        for(int i = 0; i < s.Length; i++){
            int left = i - 1, right = i + 1;

            while(left >= 0 && right < s.Length && s[left] == s[right]) {
                left--;
                right++;
            }

            var length = right - left - 1;
            if(maxPalLength < length){
                maxPalLength = length;
                maxPalStart = left + 1;
            }

            left = i;
            right = i+1;

            while(left >= 0 && right < s.Length && s[left] == s[right]) {
                left--;
                right++;
            }

            length = right - left - 1;
            if(maxPalLength < length){
                maxPalLength = length;
                maxPalStart = left + 1;
            }
        }

        return s.Substring(maxPalStart, maxPalLength);
    }
}