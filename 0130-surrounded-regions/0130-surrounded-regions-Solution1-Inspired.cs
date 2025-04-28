public class Solution {
    public void Solve(char[][] board) {
        for(var i = 0; i < board.Length - 1; i++){
            for(var j = 0; j < board[0].Length; j++){
                var visited = new HashSet<(int, int)>();
                if(board[i][j] == 'O' && !IsBoundaryReachable(board, i, j, visited))
                    updateCells(board, i, j);
            }
        }
    }

    public bool IsBoundaryReachable(char[][] board, int i, int j, HashSet<(int, int)> visited){
        if(i < 0 || i >= board.Length || j < 0 || j >= board[0].Length) return true;
        if(visited.Contains((i, j)) || board[i][j] == 'X') return false;

        visited.Add((i, j));

        return (IsBoundaryReachable(board, i - 1, j, visited) ||
            IsBoundaryReachable(board, i + 1, j, visited) ||
            IsBoundaryReachable(board, i, j - 1, visited) ||
            IsBoundaryReachable(board, i, j + 1, visited));
    }

    public void updateCells(char[][] board, int i, int j){
        if(i < 0 || i >= board.Length || j < 0 || j >= board[0].Length || board[i][j] == 'X') return;
        
        board[i][j] = 'X';

        updateCells(board, i + 1, j);
        updateCells(board, i - 1, j);
        updateCells(board, i, j + 1);
        updateCells(board, i, j - 1);
    }
}