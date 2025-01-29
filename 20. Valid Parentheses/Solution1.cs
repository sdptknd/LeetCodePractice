public class Solution {
    public bool IsValid(string s) {
        var match = new Dictionary<char, char>{
            {')', '('}, {'}', '{'}, {']', '['}
        };
        var stack = new Stack<char>();
        foreach(var bracket in s){
            if(match.TryGetValue(bracket, out var val)){
                if(stack.Count == 0 || val != stack.Pop()) return false;
            }else stack.Push(bracket);
        }
        return stack.Count == 0;
    }
}