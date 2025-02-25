public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        return BinarySearchMatrix(matrix, target, 0, (matrix.Length * matrix[0].Length) - 1);
    }

    public bool BinarySearchMatrix(int[][] matrix, int target, int left, int right){
        if(left > right) return false;

        var middle = left + ((right - left) / 2);
        var row = middle / matrix[0].Length;
        var col = middle % matrix[0].Length;

        if(matrix[row][col] == target) return true;
        if(matrix[row][col] < target) return BinarySearchMatrix(matrix, target, left + 1, right);
        return BinarySearchMatrix(matrix, target, left, right - 1);
    }
}