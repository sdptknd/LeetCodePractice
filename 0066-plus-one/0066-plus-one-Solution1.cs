public class Solution {
    public int[] PlusOne(int[] digits) {
        var result = digits.ToList();

        for(var pos = digits.Length - 1; pos >= 0; pos--){
            if(result[pos] < 9){
                result[pos]++;
                return result.ToArray();
            }
            result[pos] = 0;
        }

        result.Insert(0, 1);

        return result.ToArray();
    }
}