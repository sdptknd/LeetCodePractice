public class Solution {
    public int MinimumTotal(IList<IList<int>> triangle) {
        // var memo = new Dictionary<(int, int), int> {{(0,0), triangle[0][0]}};
        var prev = new Dictionary<int, int> {{0, triangle[0][0]}};

        for(var i = 1; i < triangle.Count; i++){
            var row = triangle[i];
            var curr = new Dictionary<int, int>();
            for(var j = 0; j < row.Count; j++){
                int leftPath = int.MaxValue, rightPath = int.MaxValue;

                if(j != 0) leftPath = prev[j-1];
                if(j < row.Count - 1) rightPath = prev[j];
                curr[j] = Math.Min(leftPath, rightPath) + row[j];
            }
            prev = curr;
        }

        return prev.Values.Min();
    }
}