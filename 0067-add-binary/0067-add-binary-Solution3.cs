public class Solution {
    public string AddBinary(string a, string b) {
        var result = string.Empty;
        var smallNum = a.Length > b.Length ? b : a;
        var bigNum = a.Length > b.Length ? a : b;
        var sPos = smallNum.Length - 1;
        var bPos = bigNum.Length - 1;
        var carry = 0;

        while(sPos >= 0){
            var posVal = int.Parse(smallNum[sPos--].ToString()) + int.Parse(bigNum[bPos--].ToString()) + carry;
            var posDigit = posVal % 2;
            carry = posVal / 2;
            result = posDigit.ToString() + result;
        }

        while(bPos >= 0){
            var posVal = int.Parse(bigNum[bPos--].ToString()) + carry;
            var posDigit = posVal % 2;
            carry = posVal / 2;
            result = posDigit.ToString() + result;
        }

        if(carry > 0) result = carry.ToString() + result;

        return result.ToString();
    }
}