public class Solution {
    public int EliminateMaximum(int[] dist, int[] speed) {
        var time = new int[dist.Length];

        for(var i = 0; i < dist.Length; i++){
            time[i] = (int)Math.Ceiling(((double)dist[i]) / speed[i]);
        }

        Array.Sort(time);

        for(var i = 1; i < time.Length; i++){
            if(time[i] <= i) return i;
        }

        return time.Length;
    }
}

// 1 1 2
// 0 1 2