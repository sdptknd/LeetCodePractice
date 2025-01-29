public class Solution {
    public bool IsValid(string s) {
        var match = new Dictionary<char, char>{
            {')', '('}, {'}', '{'}, {']', '['}
        };
        var stack = new Stack<char>();
        foreach(var bracket in s){
            if(stack.Count == 0){
                stack.Push(bracket);
                continue;
            }
            if(match.TryGetValue(bracket, out var val)){
                if(val == stack.Peek()) stack.Pop();
                else stack.Push(bracket);
            }else stack.Push(bracket);
        }
        return stack.Count == 0;
    }
}