public class Solution {
    public string DecodeString(string s) {
        // Console.WriteLine(s);
        string decoded = "";
        var indx = 0;
        var brackets = new Stack<char>();

        while(indx < s.Length){
            if(char.IsDigit(s[indx])){
                // Console.WriteLine($"indx: {indx}");
                var j = indx;
                while(s[j] != '[') j++;
                var repeat = int.Parse(s[indx..j]);
                j++;
                indx = j;
                brackets.Push('[');
                while(brackets.Count > 0){
                    if(s[j] == '[') brackets.Push('[');
                    if(s[j] == ']') brackets.Pop();
                    j++;
                }
                var repeatable = DecodeString(s[indx..(j-1)]);
                while(repeat > 0) {
                    decoded += repeatable;
                    repeat--;
                }
                indx = j;
            }else{
                // Console.WriteLine($"indx: {indx}");
                var j = indx;
                while(j < s.Length && !char.IsDigit(s[j])) j++;
                decoded += s[indx..j];
                indx = j;
            }
        }

        return decoded;
    }
}