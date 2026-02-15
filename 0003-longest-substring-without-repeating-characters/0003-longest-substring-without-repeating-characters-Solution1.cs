public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var lastPosIndex = new Dictionary<char, int>();
        int max = 0, left = 0, right = 0;

        while(right < s.Length){
            var lastPos = lastPosIndex.GetValueOrDefault(s[right], -1);
            // Console.WriteLine($"left: {left}, right: {right}, max: {max}, lastPos: {lastPos}");
            if(lastPos < left){
                max = Math.Max(max, right - left + 1);
            } else {
                left = lastPos + 1;
            }
            lastPosIndex[s[right]] = right;
            right++;
        }

        return max;
    }
}