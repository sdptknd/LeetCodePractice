public class Solution {
    public int UniquePaths(int m, int n) {
        if(m == 1 || n == 1) return 1;
        var matrix = new int[m, n];
        matrix[m-1, n-1] = 1;
        int row = m - 2, col = n - 2;

        while(row >= 0 && col >= 0){
            Console.WriteLine($"row: {row}, col: {col}");
            for(int i = n-1; i > col; i--){
                if(matrix[row,i] > 0) continue;
                var paths = 0;
                //adding right path
                paths += i == n-1 ? 0 : matrix[row, i+1];
                //adding down path
                paths += matrix[row+1, i];
                Console.WriteLine($"Adding Rowwise: i: {i}");
                matrix[row,i] = paths;
            }
            for(int j = m-1; j > row; j--){
                if(matrix[j,col] > 0) continue;
                var paths = 0;
                //adding right path
                paths += matrix[j, col+1];
                //adding down path
                paths += j == m-1 ? 0 : matrix[j+1, col];
                Console.WriteLine($"Adding Columnwise: j: {j}");
                matrix[j,col] = paths;
            }
            matrix[row,col] = matrix[row,col+1] + matrix[row+1,col];
            if(row ==0 && col ==0) break;
            row = row == 0 ? 0 : row - 1;
            col = col == 0 ? 0 : col - 1;
        }

        return matrix[0,0];
    }
}