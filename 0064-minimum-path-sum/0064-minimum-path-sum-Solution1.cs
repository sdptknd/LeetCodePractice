public class Solution {
    public int MinPathSum(int[][] grid) {
        var m = grid.Length;
        var n = grid[0].Length;
        var matrix = new int[m,n];

        matrix[0,0] = grid[0][0];

        for(int col = 1; col < n; col++)
            matrix[0,col] = matrix[0,col-1] + grid[0][col];
        
        for(int row = 1; row < m; row++)
            matrix[row,0] = matrix[row-1,0] + grid[row][0];
        
        for(int row = 1; row < m; row++)
            for(int col = 1; col < n; col++)
                matrix[row,col] = grid[row][col] + Math.Min(matrix[row-1,col], matrix[row,col-1]);

        return matrix[m-1,n-1];
    }
}