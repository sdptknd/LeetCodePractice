public class Solution {
    public void SetZeroes(int[][] matrix) {
        var zeroRows = new HashSet<int>();
        var zeroColumns = new HashSet<int>();

        for(int row = 0; row < matrix.Length; row++)
            for(int column = 0; column < matrix[0].Length; column++)
                if(matrix[row][column] == 0){
                    zeroRows.Add(row);
                    zeroColumns.Add(column);
                }

        for(int row = 0; row < matrix.Length; row++)
            for(int column = 0; column < matrix[0].Length; column++)
                if(zeroRows.Contains(row) || zeroColumns.Contains(column)) matrix[row][column] = 0;
    }
}