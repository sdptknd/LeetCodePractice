public class Solution {
    public bool Exist(char[][] board, string word) {
        for(int i = 0; i<board.Length; i++){
            for(int j = 0; j<board[0].Length; j++){
                if(Explore(board, i, j, 0, word)) return true;
            }
        }
        return false;
    }

    public bool Explore(char[][] board, int row, int col, int charIndx, string word){
        if(board[row][col] != word[charIndx]) return false;
        if(charIndx == word.Length -1) return true;

        var tmp = board[row][col];
        board[row][col] = '\0';

        var validPath = (row + 1 < board.Length && Explore(board, row + 1, col, charIndx+1, word))
            || (row > 0 && Explore(board, row - 1, col, charIndx+1, word))
            || (col + 1 < board[0].Length && Explore(board, row, col + 1, charIndx+1, word))
            || (col > 0 && Explore(board, row, col - 1, charIndx+1, word));
        
        board[row][col] = tmp;

        return validPath;
    }
}