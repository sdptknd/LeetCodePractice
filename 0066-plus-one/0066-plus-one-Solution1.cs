public class Solution {
    public int[] PlusOne(int[] digits) {
        var digs = digits.ToList();
        var carry = 1;

        for(int i = digs.Count - 1; i >= 0; i--){
            var total = digs[i] + carry;
            digs[i] = total % 10;
            carry = total / 10;
        }

        if(carry > 0) digs.Insert(0, carry);

        return digs.ToArray();
    }
}