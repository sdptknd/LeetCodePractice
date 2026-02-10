public class Solution {
    public bool BackspaceCompare(string s, string t) {
        var sFinal = new Stack<char>();
        var tFinal = new Stack<char>();

        foreach(char c in s){
            if(c != '#') sFinal.Push(c);
            else if(sFinal.Count > 0) sFinal.Pop();
        }

        foreach(char c in t){
            if(c != '#') tFinal.Push(c);
            else if(tFinal.Count > 0) tFinal.Pop();
        }

        if(sFinal.Count != tFinal.Count) return false;

        while(sFinal.Count > 0){
            if(sFinal.Pop() != tFinal.Pop()) return false;
        }

        return true;
    }
}

// abc##   ad#e#
//
