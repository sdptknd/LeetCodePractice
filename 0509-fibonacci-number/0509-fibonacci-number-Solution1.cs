public class Solution {
    public int Fib(int n) {
        if(n < 2) return n;
        return Fib(n-2) + Fib(n-1);
    }
}