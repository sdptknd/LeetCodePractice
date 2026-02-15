public class Solution {
    public string SmallestString(string s) {
        var chars = s.ToCharArray();
        var i = 0;
        while(i < chars.Length && chars[i] == 'a') i++;
        if(i == chars.Length) chars[chars.Length - 1] = 'z';
        while(i < chars.Length && chars[i] != 'a'){
            chars[i] = (char)(chars[i] - 1);
            i++;
        }
        return new String(chars);
    }
}