public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        var lastRow = new List<int> { 1 };
        var result = new List<IList<int>> {lastRow};
        
        for(var i = 2; i <= numRows; i++){
            var newRow = new List<int> { 1 };

            for(var j = 1; j < i-1; j++)
                newRow.Add(lastRow[j-1] + lastRow[j]);

            newRow.Add(1);
            result.Add(newRow);
            lastRow = newRow;
        }

        return result;
    }
}