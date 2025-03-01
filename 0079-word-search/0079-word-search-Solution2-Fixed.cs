public class Solution {
    private IEnumerable<(int, int)> PossibleNextCells(int row, int col, char[][] board){
        var nextCell = (row + 1, col);
        if(nextCell.Item1 < board.Length)
            yield return nextCell;

        nextCell = (row - 1, col);
        if(nextCell.Item1 >= 0)
            yield return nextCell;
        
        nextCell = (row, col+1);
        if(nextCell.Item2 < board[0].Length)
            yield return nextCell;
        
        nextCell = (row, col-1);
        if(nextCell.Item2 >= 0)
            yield return nextCell;
    }

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

        var validPath = PossibleNextCells(row, col, board)
                .Any(nextCell => 
                    Explore(board, nextCell.Item1, nextCell.Item2, charIndx+1, word));
        
        board[row][col] = tmp;

        return validPath;
    }
}