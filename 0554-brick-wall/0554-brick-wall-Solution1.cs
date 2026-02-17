public class Solution {
    public int LeastBricks(IList<IList<int>> wall) {
        var colMap = new Dictionary<int,int>();
        foreach(var row in wall){
            var sum = 0;
            for(int i = 0; i < row.Count - 1; i++){
                sum += row[i];
                colMap[sum] = colMap.GetValueOrDefault(sum, 0) + 1;
            }
        }

        return wall.Count - (colMap.Count > 0 ? colMap.Values.Max() : 0);
    }
}