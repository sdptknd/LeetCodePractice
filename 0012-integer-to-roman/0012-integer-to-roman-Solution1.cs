public class Solution {
    private readonly Dictionary<int, string> mapping = new Dictionary<int, string> {{1, "I"}, {5, "V"}, {10, "X"}, {50, "L"}, {100, "C"}, {500, "D"}, {1000, "M"}};

    public string IntToRoman(int num) {
        var remaining = num;
        var answer = new StringBuilder();
        var tens = 1;

        while(remaining > 0){
            Console.WriteLine(remaining);
            var leadingDigit = remaining % 10;
            remaining = remaining / 10;

            if(leadingDigit == 4 || leadingDigit == 9){
                answer.Insert(0, mapping[(tens * leadingDigit) + tens]);
                answer.Insert(0, mapping[tens]);
            } else if(leadingDigit == 5){
                answer.Insert(0, mapping[tens * 5]);
            } else if(leadingDigit < 4){
                answer.Insert(0, string.Join("", Enumerable.Repeat(mapping[tens], leadingDigit)));
            } else{
                answer.Insert(0, string.Join("", Enumerable.Repeat(mapping[tens], leadingDigit - 5)));
                answer.Insert(0, mapping[tens * 5]);
            }
            tens *= 10;
        }

        return answer.ToString();
    }
}