/**
 * @param {number[][]} matrix
 * @param {number} target
 * @return {boolean}
 */
var searchMatrix = function(matrix, target) {
    return binarySearchMatrix(matrix, target, 0, (matrix.length * matrix[0].length) - 1);
};

const binarySearchMatrix = (matrix, target, left, right) => {
    if(left > right) return false;

    const middle = left + Math.floor((right - left) / 2);
    const row = Math.floor(middle / matrix[0].length);
    const col = middle % matrix[0].length;

    if(matrix[row][col] == target ) return true;
    if(matrix[row][col] < target) return binarySearchMatrix(matrix, target, left + 1, right);
    return binarySearchMatrix(matrix, target, left, right - 1);
}