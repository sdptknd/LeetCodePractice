public class Solution {
    public IList<IList<string>> Partition(string s) {
        var dp = new bool[s.Length, s.Length];

        for(var len = 1; len <= s.Length; len++){
            for(var i = 0; i <= s.Length - len; i++){
                var j = i + len - 1;
                if(len == 1)
                    dp[i, j] = true;
                else if(len == 2)
                    dp[i, j] = (s[i] == s[j]);
                else
                    dp[i, j] = (dp[i+1, j-1] && (s[i] == s[j]));
            }
        }

        var result = new List<IList<string>>();
        Backtrack(s, 0, new List<string>(), result, dp);
        return result;
    }

    public void Backtrack(string s, int i, IList<string> curr, IList<IList<string>> result, bool[,] dp){
        if(i >= s.Length) {
            result.Add(curr.ToList());
            return;
        }

        for(var j = 0; j < s.Length; j++){
            if(dp[i, j]){
                curr.Add(s.Substring(i, j-i+1));
                Backtrack(s, j+1, curr, result, dp);
                curr.RemoveAt(curr.Count - 1);
            }
        }

        // Backtrack(s, i+1, result, dp);
    }
}