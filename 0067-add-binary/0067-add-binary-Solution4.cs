public class Solution {
    public string AddBinary(string a, string b) {
        var result = new StringBuilder();
        var aPos = a.Length - 1;
        var bPos = b.Length - 1;
        var carry = 0;

        while(aPos >= 0 || bPos >= 0 || carry > 0){
            var term1 = aPos >= 0 ? int.Parse(a[aPos--].ToString()) : 0;
            var term2 = bPos >= 0 ? int.Parse(b[bPos--].ToString()) : 0;
            var posVal = term1 + term2 + carry;
            var posDigit = posVal % 2;
            carry = posVal / 2;
            result.Insert(0, posDigit);
        }

        return result.ToString();
    }
}