public class Solution {
    public bool IsInterleave(string s1, string s2, string s3) {
        var memo = new Dictionary<(int, int, int, bool), bool>();
        return IsInterleave2(s1, s2, s3, 0, 0, 0, 0, 0, true, memo);
            //    ||
            //    IsInterleave2(s1, s2, s3, 0, 0, 0, 0, 0, false, memo);
    }

    public bool IsInterleave2(string s1, string s2, string s3, int s1i, int s2i, int s3i, int s1c, int s2c, bool isLastS1, Dictionary<(int, int, int, bool), bool> memo){
        // Console.WriteLine($"s1i: {s1i}, s2i: {s2i}, s3i: {s3i}, s1c: {s1c}, s2c: {s2c}, isLastS1: {isLastS1}");
        if(memo.TryGetValue((s1i, s2i, s3i, isLastS1), out var result)) return result;

        if(s3i == s3.Length){
            result = (s1i == s1.Length && s2i == s2.Length && Math.Abs(s1c - s2c) <= 1);
            memo[(s1i, s2i, s3i, isLastS1)] = result;
            return result;
        }

        result = (s1i < s1.Length && s1[s1i] == s3[s3i] 
                  && IsInterleave2(s1, s2, s3, s1i+1, s2i, s3i+1, isLastS1 ? s1c : s1c+1, s2c, true, memo))
                  ||
                 (s2i < s2.Length && s2[s2i] == s3[s3i]
                  && IsInterleave2(s1, s2, s3, s1i, s2i+1, s3i+1, s1c, isLastS1 ? s2c+1 : s2c, false, memo));

        memo[(s1i, s2i, s3i, isLastS1)] = result;
        return result;
    }
}