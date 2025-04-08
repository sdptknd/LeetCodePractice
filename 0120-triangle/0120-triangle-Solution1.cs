public class Solution {
    public int MinimumTotal(IList<IList<int>> triangle) {
        var nextRow = triangle[triangle.Count - 1];

        for(var i = triangle.Count - 2; i >= 0; i--){
            var newNextRow = new List<int>();
            
            for(var j = 0; j < triangle[i].Count; j++)
                newNextRow.Add(triangle[i][j] + Math.Min(nextRow[j], nextRow[j+1]));

            nextRow = newNextRow;
        }

        return nextRow[0];
    }
}