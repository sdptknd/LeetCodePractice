public class Solution {
    public int[][] Merge(int[][] intervals) {
        var sorted = intervals.OrderBy(interval => interval[0]);
        var merged = new List<int[]>();
        int[] curr = null;

        foreach(var interval in sorted){
            if(curr == null){
                curr = interval;
                continue;
            } else if(curr[1] >= interval[0]) {
                curr[1] = Math.Max(curr[1], interval[1]);
            } else {
                merged.Add(curr);
                curr = interval;
            }
        }

        merged.Add(curr);

        return merged.ToArray();
    }
}