public class Solution {
    public int[][] GenerateMatrix(int n) {
        var result = new List<int[]>();

        for(int k = 0; k < n; k++) result.Add(new int[n]);

        var direction = new Dictionary<(int, int), (int, int)>{
            {(0, 1), (1, 0)}, {(1, 0), (0, -1)}, {(0, -1), (-1, 0)}, {(-1, 0), (0, 1)}
        };

        var currNum = 1;
        int i = 0, j = 0, iDir = 0, jDir = 1;

        while(currNum <= n*n){
            // Console.WriteLine($"{i} {j} {currNum}");
            result[i][j] = currNum++;

            // if(currNum > n*n) break;

            var iNew = i + iDir;
            var jNew = j + jDir;

            
            // Console.WriteLine($"iNew: {iNew}, jNew: {jNew}");
            if(iNew < n && jNew < n && jNew >= 0 && result[iNew][jNew] == 0){
                i = iNew;
                j = jNew;
                continue;
            }
                
            (iDir, jDir) = direction[(iDir, jDir)];
            // Console.WriteLine($"updated directions: {iDir} {jDir}");
            i += iDir;
            j += jDir;
        }

        return result.ToArray();
    }
}