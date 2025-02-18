public class Solution {
    public int UniquePathsWithObstacles(int[][] obstacleGrid) {
        var m = obstacleGrid.Length;
        var n = obstacleGrid[0].Length;
        // if(obstacleGrid[0][0] == 1 || obstacleGrid[m-1][n-1] == 1) return 0;
        int[,] matrix = new int[m,n];
        matrix[0,0] = 1 - obstacleGrid[0][0];

        for(int i = 1; i < m; i++)
            matrix[i,0] = obstacleGrid[i][0] == 1 ? 0 : matrix[i-1,0];
        
        for(int i = 1; i < n; i++)
            matrix[0,i] = obstacleGrid[0][i] == 1 ? 0 : matrix[0,i-1];

        for(int row = 1; row<m; row++)
            for(int col = 1; col<n; col++)
                matrix[row,col] = obstacleGrid[row][col] == 1 ? 0 : (matrix[row-1,col] + matrix[row,col-1]);
        
        return matrix[m-1,n-1];
    }
}