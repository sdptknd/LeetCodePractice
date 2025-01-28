public class Solution {
    public IList<string> LetterCombinations(string digits) {
        if(digits == string.Empty) return new List<string>();

        var digitChars = new Dictionary<char, char[]>(){
            {'2', new char[]{'a', 'b', 'c'}}, {'3', new char[]{'d', 'e', 'f'}}, {'4', new char[]{'g', 'h', 'i'}},
            {'5', new char[]{'j', 'k', 'l'}}, {'6', new char[]{'m', 'n', 'o'}}, {'7', new char[]{'p', 'q', 'r', 's'}},
            {'8', new char[]{'t', 'u', 'v'}}, {'9', new char[]{'w', 'x', 'y', 'z'}}
        };

        var combos = digitChars[digits[0]].Select(digit => digit.ToString()).ToList();

        for(int i = 1; i < digits.Length; i++){
            var nextLetters = digitChars[digits[i]];
            var newCombos = new List<string>();
            for(int j = 0; j < nextLetters.Length; j++){
                for(int k = 0; k < combos.Count; k++){
                    newCombos.Add(combos[k] + nextLetters[j]);
                }
            }
            combos = newCombos;
        }

        return combos;
    }
}