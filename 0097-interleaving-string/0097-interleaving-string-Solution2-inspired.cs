public class Solution {
    public bool IsInterleave(string s1, string s2, string s3) {
        if(s3.Length != (s1.Length + s2.Length)) return false;

        var dp = new bool[s1.Length + 1, s2.Length + 1];
        dp[s1.Length,s2.Length] = true;

        for(int i = s1.Length; i >= 0; i--){
            for(int j = s2.Length; j >= 0; j--){
                if(i < s1.Length && dp[i+1,j] && s1[i] == s3[i+j])
                    dp[i,j] = true;
                if(j < s2.Length && dp[i,j+1] && s2[j] == s3[i+j])
                    dp[i,j] = true;
            }
        }

        return dp[0,0];
    }
}