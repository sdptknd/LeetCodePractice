public class Solution {
    public bool IsValid(string s) {
        var pairs = new Dictionary<char, char> {
            {')', '('}, {'}', '{'}, {']', '['}
        };
        var open = new Stack<char>();

        foreach(var letter in s){
            if(!pairs.TryGetValue(letter, out var openning)){
                open.Push(letter);
            } else if(open.Count == 0 || openning != open.Peek()){
                return false;
            } else {
                open.Pop();
            }
        }

        return open.Count == 0;
    }
}