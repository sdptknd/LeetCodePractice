public class Solution {
    public int LengthOfLastWord(string s) {
        var padRemoved = s.TrimEnd();

        var length = 0;
        for(int i = padRemoved.Length - 1; i >= 0 && s[i] != ' '; i--) length++;

        return length;
    }
}