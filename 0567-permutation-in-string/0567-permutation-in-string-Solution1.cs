public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if(s1 == null || s2 == null || s1.Length > s2.Length) return false;

        var charCount = new int[26];

        for(int i = 0; i < s1.Length; i++){
            charCount[s1[i] - 'a']++;
            charCount[s2[i] - 'a']--;
        };
        
        if(IsValid(charCount)) return true;

        for(int i = s1.Length; i < s2.Length; i++){
            charCount[s2[i] - 'a']--;
            charCount[s2[i - s1.Length] - 'a']++;
            if(IsValid(charCount)) return true;
        }

        return false;
    }

    private bool IsValid(int[] charCount) => charCount.All(count => count == 0);
}