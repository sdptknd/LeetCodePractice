public class Solution {
    public int MySqrt(int x) {
        return FindSqrt(0, x, x);
    }

    public int FindSqrt(int left, int right, int x){
        if(left > right) return right;

        var middle = left + (right - left) / 2;
        long middleSquare = (long)middle * (long)middle;
        // Console.WriteLine($"{left}-{right}: {middleSquare}");
        if(middleSquare == x) return middle;
        if(middleSquare > x) return FindSqrt(left, middle-1, x);
        return FindSqrt(middle+1, right, x);
    }
}