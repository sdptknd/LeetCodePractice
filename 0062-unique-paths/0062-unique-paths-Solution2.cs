public class Solution {
    public int UniquePaths(int m, int n) {
        var paths = new int[m,n];
        // Console.WriteLine($"RowLen: {paths.GetLength(0)}, colLen: {paths.GetLength(1)}");
        return FindPathsCount(0, 0, paths);
    }

    public int FindPathsCount(int row, int col, int[,] paths){
        // Console.WriteLine($"Checking for row: {row} and col: {col}");
        if(paths[row, col] > 0) return paths[row, col];
        if(row == paths.GetLength(0) - 1 && col == paths.GetLength(1) - 1){
            paths[row, col] = 1;
            return 1;
        }

        var pathsCount = 0;

        // Console.WriteLine($"Calculate from adjacent");

        if(row < paths.GetLength(0) - 1) pathsCount += FindPathsCount(row+1, col, paths);

        if(col < paths.GetLength(1) - 1) pathsCount += FindPathsCount(row, col+1, paths);

        paths[row, col] = pathsCount;
        return pathsCount;
    }
}