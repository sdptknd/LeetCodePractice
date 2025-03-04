public class Solution {
    public int Fib(int n) {
        return FibWithMemo(n, new Dictionary<int, int>());
    }

    public int FibWithMemo(int n, Dictionary<int, int> memo){
        if(n < 2) return n;
        if(memo.TryGetValue(n, out var fib)) return fib;
        return Fib(n-2) + Fib(n-1);
    }
}