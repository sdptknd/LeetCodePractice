public class Solution {
    public string ReverseParentheses(string s) {
        var strings = new Stack<string>();
        var ans = new String(s);
        var currString = "";

        for(int i = 0; i < s.Length; i++){
            if(s[i] == '('){
                strings.Push(currString);
                currString = ""; 
            }else if(s[i] == ')'){
                var reversed = string.Concat(currString.Reverse());
                currString = strings.Pop() + reversed;
            }else{
                currString += s[i];
            }
        }

        return currString;
    }
}