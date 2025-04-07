public class Solution {
    public IList<int> GetRow(int rowIndex) {
        var lastRow = new List<int> { 1 };
        
        for(var i = 1; i <= rowIndex; i++){
            var newRow = new List<int> { 1 };

            for(var j = 1; j < i; j++)
                newRow.Add(lastRow[j-1] + lastRow[j]);

            newRow.Add(1);
            lastRow = newRow;
        }

        return lastRow;
    }
}