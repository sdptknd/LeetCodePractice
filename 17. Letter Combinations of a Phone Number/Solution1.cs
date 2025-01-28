public class Solution {
    private Dictionary<char, string> digitLettersMap = new Dictionary<char, string>(){
        {'2', "abc"},
        {'3', "def"},
        {'4', "ghi"},
        {'5', "jkl"},
        {'6', "mno"},
        {'7', "pqrs"},
        {'8', "tuv"},
        {'9', "wxyz"},
    };

    public IList<string> LetterCombinations(string digits) {
        if(digits == string.Empty) return new List<string>();

        return Backtrack(string.Empty, digits, new List<string>());
    }

    private IList<string> Backtrack(string combo, string nextDigits, IList<string> output){
        if(nextDigits.Length == 0){
            output.Add(combo);
            return output;
        }

        var newOutput = output;
        foreach(var digit in digitLettersMap[nextDigits[0]]){
            newOutput = Backtrack(combo + digit, nextDigits.Substring(1), newOutput);
        }

        return newOutput;
    }
}