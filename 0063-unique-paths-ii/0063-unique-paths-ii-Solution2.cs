public class Solution {
    public int UniquePathsWithObstacles(int[][] obstacleGrid) {
        var m = obstacleGrid.Length;
        var n = obstacleGrid[0].Length;
        int[,] matrix = new int[m,n];
        matrix[m-1, n-1] = 1- obstacleGrid[m-1][n-1];

        for(int i = m-2; i>=0; i--)
            matrix[i,n-1] = obstacleGrid[i][n-1] == 1 ? 0 : matrix[i+1,n-1];
        
        for(int i = n-2; i>=0; i--)
            matrix[m-1,i] = obstacleGrid[m-1][i] == 1 ? 0 : matrix[m-1,i+1];

        for(int row = m-2; row>=0; row--)
            for(int col = n-2; col>=0; col--)
                matrix[row,col] = obstacleGrid[row][col] == 1 ? 0 : (matrix[row+1,col] + matrix[row,col+1]);
        
        return matrix[0,0];
    }
}