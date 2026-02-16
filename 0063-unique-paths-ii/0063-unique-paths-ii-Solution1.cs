public class Solution {
    public int UniquePathsWithObstacles(int[][] obstacleGrid) {
        int[] prev = null;

        for(int i = 0; i < obstacleGrid.Length; i++){
            var curr = new int[obstacleGrid[0].Length];
            for(int j = 0; j < obstacleGrid[0].Length; j++){
                if(obstacleGrid[i][j] == 1){
                    curr[j] = 0;
                    continue;
                }

                if(i == 0 && j == 0){
                    curr[0] = 1;
                    continue;
                }

                int left = 0, upward = 0;

                if(j > 0) left = curr[j-1];// memo[(i, j-1)];
                if(i > 0) upward = prev[j]; //memo[(i-1, j)];

                curr[j] = left + upward;
            }
            prev = curr;
        }

        return prev[^1];
    }
}