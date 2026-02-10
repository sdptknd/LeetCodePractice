public class Solution {
    public int LeastBricks(IList<IList<int>> wall) {
        var breakMapping = new Dictionary<int, int>();

        foreach(var row in wall){
            int breakPos = 0;
            for(int i = 0; i <= row.Count - 2; i++){
                breakPos += row[i];
                breakMapping[breakPos] = breakMapping.TryGetValue(breakPos, out var count) ? (count + 1) : 1;
            }
        }

        if(breakMapping.Count == 0) return wall.Count;

        return wall.Count - breakMapping.Values.Max();
    }
}